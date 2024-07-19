using System.Reflection;
using System.Xml;
using k8s.Models;

namespace KubernetesCRDModelGen;

public interface IGenerator
{
    /// <summary>
    /// Generates an assembly from the given CRD with the containing types
    /// </summary>
    /// <param name="crd"></param>
    /// <param name="namespace"></param>
    (Assembly?, XmlDocument?) GenerateAssembly(V1CustomResourceDefinition crd, string @namespace = Generator.ModelNamespace);

    /// <summary>
    /// Generates source code from the given CRD with the containing types
    /// </summary>
    /// <param name="crd"></param>
    /// <param name="namespace"></param>
    /// <returns></returns>
    string GenerateCode(V1CustomResourceDefinition crd, string @namespace = Generator.ModelNamespace);
}
