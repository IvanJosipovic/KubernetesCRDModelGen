using k8s.Models;
using System.ComponentModel;

namespace KubernetesCRDModelGen
{
    public class Generator
    {
        [Description("")]
        public object Generate(V1CustomResourceDefinition crd)
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

            var specTypes = GenerateTypes(spec, model.Name + "Spec");
            types.AddRange(specTypes);

            model.Fields.Add(new DynamicProperty("Spec", model.Name + "Spec"));

            var status = version.Schema.OpenAPIV3Schema.Properties["status"];

            var statusTypes = GenerateTypes(status, model.Name + "Status");
            types.AddRange(statusTypes);

            model.Fields.Add(new DynamicProperty("Status", model.Name + "Status"));

            var str = model.ToString() + "\n" + types.Select(x => x.ToString()).Aggregate((a, b) => a + "\n" + b);

            return new object();
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
                        model.Fields.Add(new DynamicProperty(property.Key, typeof(bool).FullName, false, property.Value.Description));
                        break;
                    case "integer":
                        model.Fields.Add(new DynamicProperty(property.Key, typeof(int).FullName, false, property.Value.Description));
                        break;
                    case "string":
                        model.Fields.Add(new DynamicProperty(property.Key, typeof(string).FullName, false, property.Value.Description));
                        break;
                    default:
                        break;
                }
            }

            return types;
        }
    }
}