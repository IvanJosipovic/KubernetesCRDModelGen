using System.Reflection;
using System.Xml;
using k8s.Models;

namespace KubernetesCRDModelGen;

// <summary>
// Provides methods to generate an assembly or source code from a Kubernetes Custom Resource Definition (CRD).
// </summary>
public interface IGenerator
{
    /// <summary>
    /// Generates an assembly from the given CRD with the containing types.
    /// </summary>
    /// <param name="crd">The custom resource definition.</param>
    /// <param name="namespace">The namespace to use for the generated code.</param>
    /// <returns>A tuple containing the generated assembly and associated XML document.</returns>
    (Assembly?, XmlDocument?) GenerateAssembly(V1CustomResourceDefinition crd, string @namespace = Generator.ModelNamespace);

    /// <summary>
    /// Generates source code from the given CRD with the containing types.
    /// </summary>
    /// <param name="crd">The custom resource definition.</param>
    /// <param name="namespace">The namespace to use for the generated code.</param>
    /// <returns>A string containing the generated source code.</returns>
    string GenerateCode(V1CustomResourceDefinition crd, string @namespace = Generator.ModelNamespace);

    /// <summary>
    /// Enables or disables enum support in the generated code.
    /// When enabled, enums will be generated as part of the code model.
    /// </summary>
    /// <param name="enabled">True to enable enum support, false to disable.</param>
    void SetEnumSupport(bool enabled);
}
