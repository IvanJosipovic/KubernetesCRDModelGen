using k8s.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.Text.Json;
using System.Xml;
using CsCodeGenerator;
using CsCodeGenerator.Enums;
using System.Text.Json.Serialization;
using System.Security;

namespace KubernetesCRDModelGen;

public class CRDGenerator : ICRDGenerator
{
    public const string ModelNamespace = "KubernetesCRDModelGen.Models";

    private ILogger<CRDGenerator>? Logger { get; }

    private MetadataReference[] MetadataReferences { get; set; }

    private static readonly List<string> keywords = new List<string>()
    {
        "abstract",
        "as",
        "base",
        "bool",
        "break",
        "byte",
        "case",
        "catch",
        "char",
        "checked",
        "class",
        "const",
        "continue",
        "decimal",
        "default",
        "delegate",
        "do",
        "double",
        "else",
        "enum",
        "event",
        "explicit",
        "extern",
        "false",
        "finally",
        "fixed",
        "float",
        "for",
        "foreach",
        "goto",
        "if",
        "implicit",
        "in",
        "int",
        "interface",
        "internal",
        "is",
        "lock",
        "long",
        "namespace",
        "new",
        "null",
        "object",
        "operator",
        "out",
        "override",
        "params",
        "private",
        "protected",
        "public",
        "readonly",
        "ref",
        "return",
        "sbyte",
        "sealed",
        "short",
        "sizeof",
        "stackalloc",
        "static",
        "string",
        "struct",
        "switch",
        "this",
        "throw",
        "true",
        "try",
        "typeof",
        "uint",
        "ulong",
        "unchecked",
        "unsafe",
        "ushort",
        "using",
        "virtual",
        "void",
        "volatile",
        "while"
    };

    private static readonly List<char> characters = new List<char>
    {
        '-',
        '$',
        '`',
        '!',
        '@',
        '#',
        '%',
        '^',
        '&',
        '*',
        '(',
        ')',
        '-',
        '+',
        '~',
        '_',
        '='
    };

    public CRDGenerator(ILogger<CRDGenerator> logger)
    {
        Logger = logger;
    }

    public CRDGenerator()
    {
    }

    public string GenerateCode(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        var types = new List<ClassModel>();

        @namespace = GetCleanNamespace(@namespace);

        var version = crd.Spec.Versions.First(x => x.Served && x.Storage);

        types.Add(GenerateClass(version.Schema.OpenAPIV3Schema, crd.Spec.Names.Kind, version.Name, crd.Spec.Names.Kind, crd.Spec.Group, crd.Spec.Names.Plural));

        var usingDirectives = new List<string>
        {
            "System.Collections.Generic;",
            "System.ComponentModel;",
            "System.Runtime;",
            "System.Text.Json.Nodes;",
            "System.Text.Json.Serialization;",
            "System.Text.Json;",
            "System;",
            "k8s.Models;",
            "k8s;",
            "KubernetesCRDModelGen.Models;",
        };

        FileModel complexNumberFile = new(crd.Metadata.Name);
        complexNumberFile.LoadUsingDirectives(usingDirectives);
        complexNumberFile.Namespace = @namespace + "." + crd.Spec.Group;
        complexNumberFile.Classes.AddRange(types);

        var code = complexNumberFile.ToString();

        // fix for summary https://github.com/borisdj/CsCodeGenerator/issues/6
        code = code.Replace("    // <summary>", "    /// <summary>");

        return code;
    }

    public async Task<(Assembly?, XmlDocument?)> GenerateAssembly(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        var code = GenerateCode(crd, @namespace);
        return await GenerateAssembly(crd.Metadata.Name, code);
    }

    private async Task<(Assembly?, XmlDocument?)> GenerateAssembly(string name, string code)
    {
        try
        {
            var syntaxTree = SyntaxFactory.ParseSyntaxTree(SourceText.From(code));

            if (MetadataReferences == null)
            {
                GenerateReferences();
            }

            var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
                .WithDeterministic(true)
                .WithOptimizationLevel(OptimizationLevel.Release)
                .WithNullableContextOptions(NullableContextOptions.Enable)
                .WithOverflowChecks(false)
                .WithPlatform(Platform.AnyCpu)
                .WithConcurrentBuild(true)
                .WithAssemblyIdentityComparer(DesktopAssemblyIdentityComparer.Default)
                .WithSpecificDiagnosticOptions(new KeyValuePair<string, ReportDiagnostic>[]
                {
                    // Don't warn for binding redirects
                    new("CS1701", ReportDiagnostic.Suppress),
                    new("CS1702", ReportDiagnostic.Suppress)
                });

            var compilation = CSharpCompilation.Create(
                name,
                syntaxTrees: new[] { syntaxTree },
                references: MetadataReferences,
                options: options);

            using var peStream = new MemoryStream();
            using var xmlDocumentationStream = new MemoryStream();

            var result = compilation.Emit(peStream, xmlDocumentationStream: xmlDocumentationStream);

            if (!result.Success)
            {
                var failures = result.Diagnostics.Where(diagnostic => diagnostic.IsWarningAsError || diagnostic.Severity == DiagnosticSeverity.Error);

                foreach (var diagnostic in failures)
                {
                    if (Logger == null)
                    {
                        Console.WriteLine("Error creating Assembly: {0}: {1}", diagnostic.Id, diagnostic.GetMessage());
                    }
                    else
                    {
                        Logger.LogError("Error creating Assembly: {0}: {1}", diagnostic.Id, diagnostic.GetMessage());
                    }
                }
            }
            else
            {
                peStream.Seek(0, SeekOrigin.Begin);
                var assembly = Assembly.Load(peStream.ToArray());

                xmlDocumentationStream.Seek(0, SeekOrigin.Begin);
                var xml = new XmlDocument();
                xml.Load(xmlDocumentationStream);

                return (assembly, xml);
            }
        }
        catch (Exception ex)
        {
            if (Logger == null)
            {
                Console.WriteLine("Error creating Assembly: {0}", ex);
            }
            else
            {
                Logger.LogError(ex, "Error creating Assembly");
            }
        }

        return (null, null);
    }

    private static string ArrangeUsingRoslyn(string csCode)
    {
        var tree = CSharpSyntaxTree.ParseText(csCode);
        var root = tree.GetRoot().NormalizeWhitespace();

        return root.ToFullString();
    }

    private ClassModel GenerateClass(V1JSONSchemaProps schema, string name, string? version = null, string? kind = null, string? group = null, string? plural = null)
    {
        bool isRoot = version != null && kind != null && group != null && plural != null;

        var model = new ClassModel(GetCleanClassName((isRoot ? version : "") + name));

        model.Comment = CleanDescription(schema.Description);

        if (isRoot)
        {
            model.Fields.Add(new Field(BuiltInDataType.String, "KubeApiVersion")
            {
                AccessModifier = AccessModifier.Public,
                KeyWords = new List<KeyWord>() { KeyWord.Const },
                DefaultValue = '"' + version + '"'
            });

            model.Fields.Add(new Field(BuiltInDataType.String, "KubeKind")
            {
                AccessModifier = AccessModifier.Public,
                KeyWords = new List<KeyWord>() { KeyWord.Const },
                DefaultValue = '"' + kind + '"'
            });

            model.Fields.Add(new Field(BuiltInDataType.String, "KubeGroup")
            {
                AccessModifier = AccessModifier.Public,
                KeyWords = new List<KeyWord>() { KeyWord.Const },
                DefaultValue = '"' + group + '"'
            });

            model.Fields.Add(new Field(BuiltInDataType.String, "KubePluralName")
            {
                AccessModifier = AccessModifier.Public,
                KeyWords = new List<KeyWord>() { KeyWord.Const },
                DefaultValue = '"' + plural + '"'
            });

            model.Attributes.Add(new AttributeModel("KubernetesEntity")
            {
                Parameters = new List<Parameter>()
                {
                    new Parameter()
                    {
                        Name = "ApiVersion",
                        Value = '"' + version + '"'
                    },
                    new Parameter()
                    {
                        Name = "Group",
                        Value = '"' + group + '"'
                    },
                    new Parameter()
                    {
                        Name = "Kind",
                        Value = '"' + kind + '"'
                    },
                    new Parameter()
                    {
                        Name = "PluralName",
                        Value = '"' + plural + '"'
                    }
                }
            });

            model.Properties.Add(new Property(BuiltInDataType.String, "ApiVersion")
            {
                Comment = "APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources",
                Attributes = new List<AttributeModel>()
                {
                    new AttributeModel()
                    {
                        Name = "JsonPropertyName",
                        SingleParameter = new Parameter("\"apiVersion\"")
                    }
                }
            });

            model.Properties.Add(new Property(BuiltInDataType.String, "Kind")
            {
                Comment = "Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds",
                Attributes = new List<AttributeModel>()
                {
                    new AttributeModel()
                    {
                        Name = "JsonPropertyName",
                        SingleParameter = new Parameter("\"kind\"")
                    }
                }
            });

            model.Interfaces.Add("IKubernetesObject<V1ObjectMeta?>");

            model.Properties.Add(new Property("V1ObjectMeta", "Metadata")
            {
                Comment = "ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.",
                Attributes = new List<AttributeModel>()
                {
                    new AttributeModel()
                    {
                        Name = "JsonPropertyName",
                        SingleParameter = new Parameter("\"metadata\"")
                    }
                }
            });
        }

        if (schema.XKubernetesPreserveUnknownFields == true)
        {
            model.Properties.Add(new Property("Dictionary<string, object>", "ExtensionData")
            {
                Attributes = new List<AttributeModel>()
                {
                    new AttributeModel()
                    {
                        Name = "JsonExtensionData"
                    }
                }
            });
        }

        if (schema.Properties != null)
        {
            foreach (var property in schema.Properties)
            {
                var attribute = new List<AttributeModel>()
                {
                    new AttributeModel()
                    {
                        Name = "JsonPropertyName",
                        SingleParameter = new Parameter($"\"{property.Key}\"")
                    }
                };

                string propertyName = GetCleanPropertyName(property.Key);

                var propertyTypeName = propertyName + "Model";

                if (isRoot)
                {
                    // Root Model, skip these fields as we are adding the above

                    if (property.Key == "apiVersion" || property.Key == "kind" || property.Key == "metadata")
                    {
                        continue;
                    }
                }

                switch (property.Value.Type)
                {
                    case "object":
                        if (property.Value.XKubernetesPreserveUnknownFields == true)
                        {
                            propertyTypeName = "JsonNode";

                            model.Properties.Add(new Property("JsonNode" + (IsNullable(schema.Required, property.Key) ? "?" : ""), propertyName)
                            {
                                Attributes = attribute,
                                Comment = CleanDescription(property.Value.Description)
                            });
                        }
                        else
                        {
                            if (property.Value.AdditionalProperties != null)
                            {
                                var addProp = ReSerialize(property.Value.AdditionalProperties);

                                model.Properties.Add(new Property("IDictionary<string, object>" + (IsNullable(schema.Required, property.Key) ? "?" : ""), propertyName)
                                {
                                    Attributes = attribute,
                                    Comment = CleanDescription(property.Value.Description)
                                });
                            }
                            else
                            {
                                model.NestedClasses.Add(GenerateClass(property.Value, propertyTypeName));

                                propertyTypeName = model.Name + "." + propertyTypeName;

                                model.Properties.Add(new Property(propertyTypeName + (IsNullable(schema.Required, property.Key) ? "?" : ""), propertyName)
                                {
                                    Attributes = attribute,
                                    Comment = CleanDescription(property.Value.Description)
                                });
                            }
                        }

                        if (isRoot)
                        {
                            // Root Model

                            if (property.Key.Equals("status"))
                            {
                                model.Interfaces.Add($"IStatus<{propertyTypeName + (IsNullable(schema.Required, property.Key) ? "?" : "")}>");
                            }
                            else if (property.Key.Equals("spec"))
                            {
                                model.Interfaces.Add($"ISpec<{propertyTypeName + (IsNullable(schema.Required, property.Key) ? "?" : "")}>");
                            }
                        }
                        break;

                    case "array":

                        var type = "";

                        var prop = ReSerialize(property.Value.Items);

                        if (prop.XKubernetesPreserveUnknownFields == true)
                        {
                            type = "JsonNode";
                        }
                        else if (prop.XKubernetesIntOrString == true)
                        {
                            type = "IntstrIntOrString";
                        }
                        else if (!string.IsNullOrEmpty(prop.Type))
                        {
                            type = prop.Type;
                        }
                        else
                        {
                            throw new Exception($"Unknown Type: {prop}");
                        }

                        switch (type)
                        {
                            case "object":
                                propertyTypeName = propertyName + "Item";
                                model.NestedClasses.Add(GenerateClass(property.Value, propertyTypeName));

                                propertyTypeName = model.Name + "." + propertyName + "Item";

                                break;
                            case "string":
                                propertyTypeName = "string";
                                if (prop.EnumProperty != null && prop.EnumProperty.Count > 0)
                                {
                                    var attr = new AttributeModel()
                                    {
                                        Name = "EnumAttribute",
                                        SingleParameter = new Parameter($"new[] {{ {string.Join(",", prop.EnumProperty.Select(x => '"' + x.ToString() + '"'))} }}")
                                    };
                                    attribute.Add(attr);
                                }
                                break;
                            case "integer":
                                if (prop.Format != null && prop.Format == "int64")
                                {
                                    propertyTypeName = "long";
                                }
                                else
                                {
                                    propertyTypeName = "int";
                                }
                                break;
                            case "number":
                                propertyTypeName = "double";
                                break;
                            case "JsonNode":
                            case "array":
                                propertyTypeName = "JsonNode";
                                break;
                            case "IntstrIntOrString":
                                propertyTypeName = "IntstrIntOrString";
                                break;
                            default:
                                throw new Exception($"Unknown Type2: {type}");
                        }

                        model.Properties.Add(new Property($"IList<{propertyTypeName}>" + (IsNullable(schema.Required, property.Key) ? "?" : ""), propertyName)
                        {
                            Attributes = attribute,
                            Comment = CleanDescription(property.Value.Description)
                        });
                        break;

                    case "boolean":
                        model.Properties.Add(new Property("bool" + (IsNullable(schema.Required, property.Key) ? "?" : ""), propertyName)
                        {
                            Attributes = attribute,
                            Comment = CleanDescription(property.Value.Description)
                        });
                        break;

                    case "number":
                        model.Properties.Add(new Property("double" + (IsNullable(schema.Required, property.Key) ? "?" : ""), propertyName)
                        {
                            Attributes = attribute,
                            Comment = CleanDescription(property.Value.Description)
                        });
                        break;
                    case "integer":
                        if (property.Value.Format != null && property.Value.Format == "int64")
                        {
                            model.Properties.Add(new Property("long" + (IsNullable(schema.Required, property.Key) ? "?" : ""), propertyName)
                            {
                                Attributes = attribute,
                                Comment = CleanDescription(property.Value.Description)
                            });
                        }
                        else
                        {
                            model.Properties.Add(new Property("int" + (IsNullable(schema.Required, property.Key) ? "?" : ""), propertyName)
                            {
                                Attributes = attribute,
                                Comment = CleanDescription(property.Value.Description)
                            });
                        }
                        break;

                    case "string":
                        if (property.Value.EnumProperty != null && property.Value.EnumProperty.Count > 0)
                        {
                            var attr = new AttributeModel()
                            {
                                Name = "EnumAttribute",
                                SingleParameter = new Parameter($"new[] {{ {string.Join(",", property.Value.EnumProperty.Select(x => '"' + x.ToString() + '"'))} }}")
                            };
                            attribute.Add(attr);
                        }

                        model.Properties.Add(new Property("string" + (IsNullable(schema.Required, property.Key) ? "?" : ""), propertyName)
                        {
                            Attributes = attribute,
                            Comment = CleanDescription(property.Value.Description)
                        });
                        break;

                    case "":
                    case null:
                        if (property.Value.XKubernetesPreserveUnknownFields == true)
                        {
                            model.Properties.Add(new Property("JsonNode" + (IsNullable(schema.Required, property.Key) ? "?" : ""), propertyName)
                            {
                                Attributes = attribute,
                                Comment = CleanDescription(property.Value.Description)
                            });

                            if (isRoot)
                            {
                                // Root Model

                                if (property.Key.Equals("status"))
                                {
                                    model.Interfaces.Add($"IStatus<JsonNode{(IsNullable(schema.Required, property.Key) ? "?" : "")}>");
                                }
                                else if (property.Key.Equals("spec"))
                                {
                                    model.Interfaces.Add($"ISpec<JsonNode{(IsNullable(schema.Required, property.Key) ? "?" : "")}>");
                                }
                            }
                        }

                        if (property.Value.XKubernetesIntOrString == true)
                        {
                            model.Properties.Add(new Property("IntstrIntOrString" + (IsNullable(schema.Required, property.Key) ? "?" : ""), propertyName)
                            {
                                Attributes = attribute,
                                Comment = CleanDescription(property.Value.Description)
                            });
                        }
                        break;

                    default:
                        if (Logger == null)
                        {
                            Console.WriteLine("Unhandled Property Type {0}", property.Value.Type);
                        }
                        else
                        {
                            Logger.LogWarning("Unhandled Property Type {type}", property.Value.Type);
                        }
                        break;
                }
            }
        }
        else if (schema.Type == "array")
        {
            var obj = ReSerialize(schema.Items);

            model = GenerateClass(obj, name);
        }
        else if (schema.Type == "object")
        {
            //model.Fields.Add(new DynamicProperty(fieldName, $"IList<{Name + fieldName}>", IsNullable(property), property.Value.Description, new() { attribute }));
            //types.AddRange(GenerateTypes(property.Value, Name + fieldName));
        }
        else
        {
            if (Logger == null)
            {
                Console.WriteLine("Unhandled Type {0}", schema.Type);
            }
            else
            {
                Logger.LogWarning("Unhandled Type {type}", schema.Type);
            }
        }

        return model;
    }

    public static string GetCleanClassName(string nane)
    {
        return CapitalizeFirstLetter(nane);
    }

    public static string GetCleanPropertyName(string name)
    {
        foreach (var badChar in characters)
        {
            if (name.Contains(badChar))
            {
                name = name.Replace(badChar.ToString(), "");
            }
        }

        return CapitalizeFirstLetter(name);
    }

    public static string GetCleanNamespace(string name)
    {
        foreach (var badChar in characters)
        {
            if (name.Contains(badChar))
            {
                name = name.Replace(badChar.ToString(), "");
            }
        }

        foreach (var keyword in keywords)
        {
            if (name.Contains("." + keyword + ".") || name.StartsWith(keyword + ".") || name.EndsWith("." + keyword))
            {
                name = name.Replace(keyword, "@" + keyword);
            }
        }

        return name;
    }

    private string? CleanDescription(string? description)
    {
        if (string.IsNullOrEmpty(description))
        {
            return null;
        }

        return $"<summary>{SecurityElement.Escape(description.Replace("\n", "").Replace("\r", ""))}</summary>";
    }

    private static bool IsNullable(IList<string> required, string key)
    {
        if (required == null)
        {
            return true;
        }

        return !required.Contains(key);
    }

    private static string CapitalizeFirstLetter(string str)
    {
        if (str.Length == 0)
        {
            return string.Empty;
        }
        else if (str.Length == 1)
        {
            return char.ToUpper(str[0]).ToString();
        }
        else
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }

    private void GenerateReferences()
    {
        var references = new List<MetadataReference>();

        var assembly = GetType().Assembly;

        var assemblies = assembly.GetManifestResourceNames().Where(x => x.StartsWith("runtime.") && x.EndsWith(".dll")).ToList();

        foreach (var item in assemblies)
        {
            using var stream = assembly.GetManifestResourceStream(item);
            var ass = MetadataReference.CreateFromStream(stream);
            references.Add(ass);
        }

        references.AddRange(Basic.Reference.Assemblies.NetStandard20.References.All);

        MetadataReferences = references.ToArray();
    }

    public class BoolConverter : JsonConverter<bool>
    {
        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) =>
            writer.WriteBooleanValue(value);

        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.TokenType switch
            {
                JsonTokenType.True => true,
                JsonTokenType.False => false,
                JsonTokenType.String => bool.TryParse(reader.GetString(), out var b) ? b : throw new JsonException(),
                JsonTokenType.Number => reader.TryGetInt64(out long l) ? Convert.ToBoolean(l) : reader.TryGetDouble(out double d) ? Convert.ToBoolean(d) : false,
                _ => throw new JsonException(),
            };
    }

    private V1JSONSchemaProps ReSerialize(object schema)
    {
        var options = new JsonSerializerOptions()
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
        };

        options.Converters.Add(new BoolConverter());

        return JsonSerializer.Deserialize<V1JSONSchemaProps>(JsonSerializer.Serialize(schema), options);
    }
}
