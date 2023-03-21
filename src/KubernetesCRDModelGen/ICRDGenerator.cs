using k8s.Models;
using System.Reflection;
using System.Xml;

namespace KubernetesCRDModelGen;

public interface ICRDGenerator
{
    /// <summary>
    /// Generates an assembly from the given CRD with the containing types
    /// </summary>
    /// <param name="crd"></param>
    /// <param name="namespace"></param>
    /// <returns>Assembly and XML Documentation</returns>
    Task<(Assembly?, XmlDocument?)> GenerateAssembly(V1CustomResourceDefinition crd, string @namespace = CRDGenerator.RootNamespace, bool embedSources = false);

    /// <summary>
    /// Generates an assembly stream from the given CRD with the containing types
    /// </summary>
    /// <param name="crd"></param>
    /// <param name="namespace"></param>
    /// <param name="embedSources"></param>
    /// <returns></returns>
    Task<(Stream?, Stream?)> GenerateAssemblyStream(V1CustomResourceDefinition crd, string @namespace = CRDGenerator.RootNamespace, bool embedSources = false);

    /// <summary>
    /// Generates an assembly stream from the given CRDs with the containing types
    /// </summary>
    /// <param name="crd"></param>
    /// <param name="namespace"></param>
    /// <param name="embedSources"></param>
    /// <returns></returns>
    Task<(Stream, Stream)> GeneratePackageStream(IEnumerable<V1CustomResourceDefinition> crds, string assemblyName, string @namespace = CRDGenerator.RootNamespace);
}
