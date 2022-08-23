using k8s;
using k8s.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Xml;
using CsCodeGenerator;
using CsCodeGenerator.Enums;

namespace KubernetesCRDModelGen;

public class CRDGenerator : ICRDGenerator
{
    public const string ModelNamespace = "KubernetesCRDModelGen.Models";

    private ILogger<CRDGenerator> Logger { get; set; }

    private MetadataReference[] MetadataReferences { get; set; }

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

        var version = crd.Spec.Versions.First(x => x.Served && x.Storage);

        types.AddRange(GenerateClasses(version.Schema.OpenAPIV3Schema, crd.Spec.Names.Kind, version.Name, crd.Spec.Names.Kind, crd.Spec.Group, crd.Spec.Names.Plural));

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
        };

        FileModel complexNumberFile = new FileModel(crd.Metadata.Name);
        complexNumberFile.LoadUsingDirectives(usingDirectives);
        complexNumberFile.Namespace = @namespace;
        complexNumberFile.Classes.AddRange(types);

        return ArrangeUsingRoslyn(complexNumberFile.ToString());
    }

    public async Task<(Assembly?, XmlDocument?)> GenerateAssembly(V1CustomResourceDefinition crd, string @namespace = ModelNamespace)
    {
        var code = GenerateCode(crd, @namespace);
        return await GenerateAssembly(crd.Metadata.Name.Replace(".", "-"), code);
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

            var compilation = CSharpCompilation.Create(
                name,
                syntaxTrees: new[] { syntaxTree },
                references: MetadataReferences,
                options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

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

    private List<ClassModel> GenerateClasses(V1JSONSchemaProps schema, string name, string? version = null, string? kind = null, string? group = null, string? plural = null)
    {
        bool isRoot = version != null && kind != null && group != null && plural != null;

        var types = new List<ClassModel>();
        var model = new ClassModel(CapitalizeFirstLetter(name));
        types.Add(model);

        model.Comment = CleanDescription(schema.Description);

        if (isRoot)
        {
            model.Fields.Add(new Field(BuiltInDataType.String, "KubeApiVersion")
            {
                AccessModifier = AccessModifier.Public,
                KeyWords = new List<KeyWord>() { KeyWord.Const },
                DefaultValue = "\"" + version + "\""
            });

            model.Fields.Add(new Field(BuiltInDataType.String, "KubeKind")
            {
                AccessModifier = AccessModifier.Public,
                KeyWords = new List<KeyWord>() { KeyWord.Const },
                DefaultValue = "\"" + kind + "\""
            });

            model.Fields.Add(new Field(BuiltInDataType.String, "KubeGroup")
            {
                AccessModifier = AccessModifier.Public,
                KeyWords = new List<KeyWord>() { KeyWord.Const },
                DefaultValue = "\"" + group + "\""
            });

            model.Fields.Add(new Field(BuiltInDataType.String, "KubePluralName")
            {
                AccessModifier = AccessModifier.Public,
                KeyWords = new List<KeyWord>() { KeyWord.Const },
                DefaultValue = "\"" + plural + "\""
            });

            model.Attributes.Add(new AttributeModel("KubernetesEntity")
            {
                Parameters = new List<Parameter>()
                {
                    new Parameter()
                    {
                        Name = "ApiVersion",
                        Value = "\"" + version + "\""
                    },
                    new Parameter()
                    {
                        Name = "Group",
                        Value = "\"" + group + "\""
                    },
                    new Parameter()
                    {
                        Name = "Kind",
                        Value = "\"" + kind + "\""
                    },
                    new Parameter()
                    {
                        Name = "PluralName",
                        Value = "\"" + plural + "\""
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

            model.Interfaces.Add($"IKubernetesObject<V1ObjectMeta?>");

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
                        SingleParameter = new Parameter("\"" + property.Key + "\"")
                    }
                };

                string fieldName = property.Key;

                if (fieldName == "continue" || fieldName == "ref" || fieldName == "namespace" || fieldName == "static")
                {
                    fieldName = "@" + fieldName;
                }

                if (fieldName.Contains("$"))
                {
                    fieldName = fieldName.Replace("$", "");
                }

                fieldName = CapitalizeFirstLetter(fieldName);

                var combinedFieldName = name + CapitalizeFirstLetter(property.Key.Replace("$", "").Replace("@", ""));

                if (isRoot)
                {
                    // Root Model

                    if (property.Key == "apiVersion" || property.Key == "kind" || property.Key == "metadata")
                    {
                        continue;
                    }
                }

                switch (property.Value.Type)
                {
                    case "object":
                        types.AddRange(GenerateClasses(property.Value, combinedFieldName));

                        model.Properties.Add(new Property(combinedFieldName + (IsNullable(property) ? "?" : ""), fieldName)
                        {
                            Attributes = attribute,
                            Comment = CleanDescription(property.Value.Description)
                        });

                        if (isRoot)
                        {
                            // Root Model

                            if (property.Key.Equals("status"))
                            {
                                model.Interfaces.Add($"IStatus<{combinedFieldName + (IsNullable(property) ? "?" : "")}>");
                            }
                            else if (property.Key.Equals("spec"))
                            {
                                model.Interfaces.Add($"ISpec<{combinedFieldName + (IsNullable(property) ? "?" : "")}>");
                            }
                        }
                        break;

                    case "array":
                        types.AddRange(GenerateClasses(property.Value, combinedFieldName));
                        model.Properties.Add(new Property($"IList<{combinedFieldName}>" + (IsNullable(property) ? "?" : ""), fieldName)
                        {
                            Attributes = attribute,
                            Comment = CleanDescription(property.Value.Description)
                        });
                        break;

                    case "boolean":
                        model.Properties.Add(new Property("bool" + (IsNullable(property) ? "?" : ""), fieldName)
                        {
                            Attributes = attribute,
                            Comment = CleanDescription(property.Value.Description)
                        });
                        break;

                    case "integer":
                        if (property.Value.Format == "int64")
                        {
                            model.Properties.Add(new Property("long" + (IsNullable(property) ? "?" : ""), fieldName)
                            {
                                Attributes = attribute,
                                Comment = CleanDescription(property.Value.Description)
                            });
                        }
                        else
                        {
                            model.Properties.Add(new Property("int" + (IsNullable(property) ? "?" : ""), fieldName)
                            {
                                Attributes = attribute,
                                Comment = CleanDescription(property.Value.Description)
                            });
                        }
                        break;

                    case "string":
                        model.Properties.Add(new Property("string" + (IsNullable(property) ? "?" : ""), fieldName)
                        {
                            Attributes = attribute,
                            Comment = CleanDescription(property.Value.Description)
                        }); 
                        break;

                    case "":
                    case null:
                        if (property.Value.XKubernetesPreserveUnknownFields == true)
                        {
                            model.Properties.Add(new Property("JsonNode" + (IsNullable(property) ? "?" : ""), fieldName)
                            {
                                Attributes = attribute,
                                Comment = CleanDescription(property.Value.Description)
                            });

                            if (isRoot)
                            {
                                // Root Model

                                if (property.Key.Equals("status"))
                                {
                                    model.Interfaces.Add($"IStatus<JsonNode{(IsNullable(property) ? "?" : "")}>");
                                }
                                else if (property.Key.Equals("spec"))
                                {
                                    model.Interfaces.Add($"ISpec<JsonNode{(IsNullable(property) ? "?" : "")}>");
                                }
                            }
                        }
                        break;

                    default:
                        if (Logger == null)
                        {
                            Console.WriteLine("Unhandled Property Type {type}", property.Value.Type);
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

            //model.Fields.Add(new DynamicProperty(fieldName, $"IList<{Name + fieldName}>", IsNullable(property), property.Value.Description, new() { attribute }));
            //types.AddRange(GenerateTypes(property.Value, Name + fieldName));
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
                Console.WriteLine("Unhandled Type {type}", schema.Type);
            }
            else
            {
                Logger.LogWarning("Unhandled Type {type}", schema.Type);
            }
        }

        return types;
    }

    private string CleanDescription(string? description)
    {
        if (string.IsNullOrEmpty(description))
        {
            return string.Empty;
        }

        return description.Replace("\n", "").Replace("\r","");
    }

    //private List<DynamicType> GenerateTypes(V1JSONSchemaProps schema, string name, string @namespace = ModelNamespace, string? version = null, string? kind = null, string? group = null, string? plural = null)
    //{
    //    bool isRoot = version != null && kind != null && group != null && plural != null;

    //    var types = new List<DynamicType>();
    //    var model = new DynamicType();
    //    types.Add(model);

    //    model.Name = CapitalizeFirstLetter(name);
    //    model.Description = schema.Description;

    //    if (isRoot)
    //    {
    //        // Root Model
    //        model.Namespace = @namespace;
    //        model.AddUsing = true;

    //        model.Constant.Add($"public const string KubeApiVersion = \"{version}\";");
    //        model.Constant.Add($"public const string KubeKind = \"{kind}\";");
    //        model.Constant.Add($"public const string KubeGroup = \"{group}\";");
    //        model.Constant.Add($"public const string KubePluralName = \"{plural}\";");

    //        model.Attributes.Add($"[KubernetesEntity(ApiVersion = \"{version}\", Group = \"{group}\", Kind = \"{kind}\", PluralName = \"{plural}\")]");

    //        model.Fields.Add(new DynamicProperty("ApiVersion", "string", false, "APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources", new() { "[JsonPropertyName(\"apiVersion\")]" }));
    //        model.Fields.Add(new DynamicProperty("Kind", "string", false, "Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds", new() { "[JsonPropertyName(\"kind\")]" }));

    //        model.Implements = $"IKubernetesObject<V1ObjectMeta?>";
    //        model.Fields.Add(new DynamicProperty("Metadata", "V1ObjectMeta", false, "ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.", new() { $"[JsonPropertyName(\"metadata\")]" }));
    //    }

    //    if (schema.XKubernetesPreserveUnknownFields == true)
    //    {
    //        model.Fields.Add(new DynamicProperty("ExtensionData", $"Dictionary<string, object>", false, null, new List<string>() { "[JsonExtensionData]" }));
    //    }

    //    if (schema.Properties != null)
    //    {
    //        foreach (var property in schema.Properties)
    //        {
    //            var attribute = $"[JsonPropertyName(\"{property.Key}\")]";
    //            string fieldName = property.Key;

    //            if (fieldName == "continue" || fieldName == "ref" || fieldName == "namespace" || fieldName == "static")
    //            {
    //                fieldName = "@" + fieldName;
    //            }

    //            if (fieldName.Contains("$"))
    //            {
    //                fieldName = fieldName.Replace("$", "");
    //            }

    //            fieldName = CapitalizeFirstLetter(fieldName);

    //            var combinedFieldName = name + CapitalizeFirstLetter(property.Key.Replace("$", "").Replace("@", ""));

    //            if (isRoot)
    //            {
    //                // Root Model

    //                if (property.Key == "apiVersion" || property.Key == "kind" || property.Key == "metadata")
    //                {
    //                    continue;
    //                }
    //            }

    //            switch (property.Value.Type)
    //            {
    //                case "object":
    //                    model.Fields.Add(new DynamicProperty(fieldName, combinedFieldName, IsNullable(property), property.Value.Description, new() { attribute }));
    //                    types.AddRange(GenerateTypes(property.Value, combinedFieldName));

    //                    if (isRoot)
    //                    {
    //                        // Root Model

    //                        if (property.Key.Equals("status"))
    //                        {
    //                            model.Implements += $", IStatus<{combinedFieldName + (IsNullable(property) ? "?" : "")}>";
    //                        }
    //                        else if (property.Key.Equals("spec"))
    //                        {
    //                            model.Implements += $", ISpec<{combinedFieldName + (IsNullable(property) ? "?" : "")}>";
    //                        }
    //                    }
    //                    break;

    //                case "array":
    //                    model.Fields.Add(new DynamicProperty(fieldName, $"IList<{combinedFieldName}>", IsNullable(property), property.Value.Description, new() { attribute }));
    //                    types.AddRange(GenerateTypes(property.Value, combinedFieldName));
    //                    break;

    //                case "boolean":
    //                    model.Fields.Add(new DynamicProperty(fieldName, "bool", IsNullable(property), property.Value.Description, new() { attribute }));
    //                    break;

    //                case "integer":
    //                    if (property.Value.Format == "int64")
    //                    {
    //                        model.Fields.Add(new DynamicProperty(fieldName, "long", IsNullable(property), property.Value.Description, new() { attribute }));
    //                    }
    //                    else
    //                    {
    //                        model.Fields.Add(new DynamicProperty(fieldName, "int", IsNullable(property), property.Value.Description, new() { attribute }));
    //                    }
    //                    break;

    //                case "string":
    //                    model.Fields.Add(new DynamicProperty(fieldName, "string", IsNullable(property), property.Value.Description, new() { attribute }));
    //                    break;

    //                case "":
    //                case null:
    //                    if (property.Value.XKubernetesPreserveUnknownFields == true)
    //                    {
    //                        model.Fields.Add(new DynamicProperty(fieldName, $"JsonNode", IsNullable(property), property.Value.Description, new() { attribute }));

    //                        if (isRoot)
    //                        {
    //                            // Root Model

    //                            if (property.Key.Equals("status"))
    //                            {
    //                                model.Implements += $", IStatus<JsonNode{(IsNullable(property) ? "?" : "")}>";
    //                            }
    //                            else if (property.Key.Equals("spec"))
    //                            {
    //                                model.Implements += $", ISpec<JsonNode{(IsNullable(property) ? "?" : "")}>";
    //                            }
    //                        }
    //                    }
    //                    break;

    //                default:
    //                    if (Logger == null)
    //                    {
    //                        Console.WriteLine("Unhandled Property Type {type}", property.Value.Type);
    //                    }
    //                    else
    //                    {
    //                        Logger.LogWarning("Unhandled Property Type {type}", property.Value.Type);
    //                    }
    //                    break;
    //            }
    //        }
    //    }
    //    else if (schema.Type == "array")
    //    {

    //        //model.Fields.Add(new DynamicProperty(fieldName, $"IList<{Name + fieldName}>", IsNullable(property), property.Value.Description, new() { attribute }));
    //        //types.AddRange(GenerateTypes(property.Value, Name + fieldName));
    //    }
    //    else if (schema.Type == "object")
    //    {
    //        //model.Fields.Add(new DynamicProperty(fieldName, $"IList<{Name + fieldName}>", IsNullable(property), property.Value.Description, new() { attribute }));
    //        //types.AddRange(GenerateTypes(property.Value, Name + fieldName));
    //    }
    //    else
    //    {
    //        if (Logger == null)
    //        {
    //            Console.WriteLine("Unhandled Type {type}", schema.Type);
    //        }
    //        else
    //        {
    //            Logger.LogWarning("Unhandled Type {type}", schema.Type);
    //        }
    //    }

    //    return types;
    //}

    private static bool IsNullable(KeyValuePair<string, V1JSONSchemaProps> item)
    {
        if (item.Value.Required == null)
        {
            return true;
        }

        return !item.Value.Required.Contains(item.Key);
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

        var assebly = GetType().Assembly;

        var assemblies = assebly.GetManifestResourceNames().Where(x => x.StartsWith("runtime.") && x.EndsWith(".dll")).ToList();

        foreach (var item in assemblies)
        {
            using var stream = assebly.GetManifestResourceStream(item);
            var ass = MetadataReference.CreateFromStream(stream);
            references.Add(ass);
        }

        references.Add(Basic.Reference.Assemblies.NetStandard20.netstandard);

        MetadataReferences = references.ToArray();
    }

    public static void FixSerializer()
    {
        try
        {
            var property = typeof(KubernetesJson).GetField("JsonSerializerOptions", BindingFlags.Static | BindingFlags.NonPublic);

            var options = (JsonSerializerOptions)property.GetValue(null);

            options.NumberHandling = JsonNumberHandling.AllowReadingFromString;
            options.Converters.Add(new BoolConverter());
            options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        }
        catch (InvalidOperationException)
        { }
        catch (Exception ex)
        {
            Console.WriteLine("Error setting JsonSerializerOptions: {error}", ex);
        }
    }

    private class BoolConverter : JsonConverter<bool>
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
}
