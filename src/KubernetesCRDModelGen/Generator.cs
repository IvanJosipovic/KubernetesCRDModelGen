using k8s.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Text;
using System.ComponentModel;
using System.Reflection;

namespace KubernetesCRDModelGen
{
    public class Generator
    {
        [Description("")]
        public Assembly Generate(V1CustomResourceDefinition crd)
        {
            var model = new DynamicType();
            model.AddUsing = true;

            var types = new List<DynamicType>();

            var version = crd.Spec.Versions.First(x => x.Served && x.Storage);

            model.Name = crd.Spec.Names.Kind;

            var specModelName = model.Name + "Spec";
            var statusModelName = model.Name + "Status";

            model.Implements = $"IKubernetesObject<V1ObjectMeta?>, ISpec<{specModelName}?>, IStatus<{statusModelName}?>";

            model.Constant.Add($"public const string KubeApiVersion = \"{version.Name}\";");
            model.Constant.Add($"public const string KubeKind = \"{crd.Spec.Names.Kind}\";");
            model.Constant.Add($"public const string KubeGroup = \"{crd.Spec.Group}\";");

            model.Attributes.Add($"[KubernetesEntity(ApiVersion = \"{version.Name}\", Group = \"{crd.Spec.Group}\", Kind = \"{crd.Spec.Names.Kind}\", PluralName = \"{crd.Spec.Names.Plural}\")]");
            model.Description = version.Schema.OpenAPIV3Schema.Description;

            /// <inheritdoc />
            model.Fields.Add(new DynamicProperty("ApiVersion", "string"));

            /// <inheritdoc />
            model.Fields.Add(new DynamicProperty("Kind", "string"));

            /// <inheritdoc />
            model.Fields.Add(new DynamicProperty("Metadata", "V1ObjectMeta", true));

            var spec = version.Schema.OpenAPIV3Schema.Properties["spec"];

            var specTypes = GenerateTypes(spec, specModelName);
            types.AddRange(specTypes);

            model.Fields.Add(new DynamicProperty("Spec", specModelName));

            var status = version.Schema.OpenAPIV3Schema.Properties["status"];

            var statusTypes = GenerateTypes(status, statusModelName);
            types.AddRange(statusTypes);

            model.Fields.Add(new DynamicProperty("Status", statusModelName));

            var str = model.ToString() + "\n" + types.Select(x => x.ToString()).Aggregate((a, b) => a + "\n" + b);

            var syntaxTree = SyntaxFactory.ParseSyntaxTree(SourceText.From(str));
            var dotNetCoreDir = Path.GetDirectoryName(typeof(object).GetTypeInfo().Assembly.Location);

            string assemblyName = Path.GetRandomFileName();
            MetadataReference[] references = new MetadataReference[]
            {
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(V1Pod).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(DescriptionAttribute).Assembly.Location),
                MetadataReference.CreateFromFile(Path.Combine(dotNetCoreDir, "System.Runtime.dll"))
            };

            var compilation = CSharpCompilation.Create(
                assemblyName,
                syntaxTrees: new[] { syntaxTree },
                references: references,
                options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            using (var ms = new MemoryStream())
            {
                EmitResult result = compilation.Emit(ms);

                if (!result.Success)
                {
                    IEnumerable<Diagnostic> failures = result.Diagnostics.Where(diagnostic =>
                        diagnostic.IsWarningAsError || diagnostic.Severity == DiagnosticSeverity.Error);

                    foreach (Diagnostic diagnostic in failures)
                    {
                        Console.Error.WriteLine("{0}: {1}", diagnostic.Id, diagnostic.GetMessage());
                    }
                }
                else
                {
                    ms.Seek(0, SeekOrigin.Begin);
                    var assembly = Assembly.Load(ms.ToArray());
                    return assembly;
                }
            }

            return null;
        }

        private List<DynamicType> GenerateTypes(V1JSONSchemaProps type, string Name)
        {
            var types = new List<DynamicType>();
            var model = new DynamicType();
            types.Add(model);

            model.Name = Name;
            model.Description = type.Description;

            foreach (var property in type.Properties)
            {
                var fieldName = property.Key;

                switch (property.Value.Type)
                {
                    case "object":
                        // Create object
                        model.Fields.Add(new DynamicProperty(property.Key, Name + fieldName, false, property.Value.Description));
                        types.AddRange(GenerateTypes(property.Value, Name + fieldName));
                        break;
                    case "boolean":
                        model.Fields.Add(new DynamicProperty(property.Key, "bool", false, property.Value.Description));
                        break;
                    case "integer":
                        model.Fields.Add(new DynamicProperty(property.Key, "int", false, property.Value.Description));
                        break;
                    case "string":
                        model.Fields.Add(new DynamicProperty(property.Key, "string", false, property.Value.Description));
                        break;
                    default:
                        break;
                }
            }

            return types;
        }
    }
}