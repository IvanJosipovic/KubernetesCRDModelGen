using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.argoproj.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceLabelSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResource
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public string ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResourceTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClustersTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsClusters
{
    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersSelector? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsClustersTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitDirectories
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public bool? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitFiles
{
    /// <summary></summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGitTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsGit
{
    /// <summary></summary>
    [JsonPropertyName("directories")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitDirectories>? Directories { get; set; }

    /// <summary></summary>
    [JsonPropertyName("files")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsGitFiles>? Files { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathParamPrefix")]
    public string? PathParamPrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsGitTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsListTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsList
{
    /// <summary></summary>
    [JsonPropertyName("elements")]
    public IList<JsonNode>? Elements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elementsYaml")]
    public string? ElementsYaml { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsListTemplate? Template { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceLabelSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResource
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public string ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResourceTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusters
{
    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersSelector? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClustersTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitDirectories
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public bool? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitFiles
{
    /// <summary></summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGit
{
    /// <summary></summary>
    [JsonPropertyName("directories")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitDirectories>? Directories { get; set; }

    /// <summary></summary>
    [JsonPropertyName("files")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitFiles>? Files { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathParamPrefix")]
    public string? PathParamPrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGitTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsList
{
    /// <summary></summary>
    [JsonPropertyName("elements")]
    public IList<JsonNode>? Elements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elementsYaml")]
    public string? ElementsYaml { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsListTemplate? Template { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginConfigMapRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginInput
{
    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, JsonNode>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPlugin
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginConfigMapRef ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("input")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginInput? Input { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPluginTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevopsTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevops
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("organization")]
    public string Organization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevopsTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketBasicAuthPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketBasicAuthPasswordRef PasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketBearerTokenTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketBearerToken
{
    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketBearerTokenTokenRef TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucket
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bearerToken")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketBearerToken? BearerToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketServerBasicAuthPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketServerBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketServerBasicAuthPasswordRef PasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketServer
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketServerBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestFilters
{
    /// <summary></summary>
    [JsonPropertyName("branchMatch")]
    public string? BranchMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetBranchMatch")]
    public string? TargetBranchMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGiteaTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitea
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGiteaTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGithubTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGithub
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appSecretName")]
    public string? AppSecretName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGithubTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlabTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlab
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pullRequestState")]
    public string? PullRequestState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlabTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequest
{
    /// <summary></summary>
    [JsonPropertyName("azuredevops")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestAzuredevops? Azuredevops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucket")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucket? Bitbucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucketServer")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestBitbucketServer? BitbucketServer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestFilters>? Filters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitea")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitea? Gitea { get; set; }

    /// <summary></summary>
    [JsonPropertyName("github")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGithub? Github { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitlab")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestGitlab? Gitlab { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequestTemplate? Template { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderAwsCodeCommitTagFilters
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderAwsCodeCommit
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagFilters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderAwsCodeCommitTagFilters>? TagFilters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderAzureDevOpsAccessTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderAzureDevOps
{
    /// <summary></summary>
    [JsonPropertyName("accessTokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderAzureDevOpsAccessTokenRef AccessTokenRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("organization")]
    public string Organization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("teamProject")]
    public string TeamProject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketAppPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucket
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appPasswordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketAppPasswordRef AppPasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string User { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerBasicAuthPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerBasicAuthPasswordRef PasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServer
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServerBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderFilters
{
    /// <summary></summary>
    [JsonPropertyName("branchMatch")]
    public string? BranchMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelMatch")]
    public string? LabelMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathsDoNotExist")]
    public IList<string>? PathsDoNotExist { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathsExist")]
    public IList<string>? PathsExist { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repositoryMatch")]
    public string? RepositoryMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGiteaTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitea
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGiteaTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGithubTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGithub
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appSecretName")]
    public string? AppSecretName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("organization")]
    public string Organization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGithubTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlabTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlab
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeSharedProjects")]
    public bool? IncludeSharedProjects { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeSubgroups")]
    public bool? IncludeSubgroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlabTokenRef? TokenRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProvider
{
    /// <summary></summary>
    [JsonPropertyName("awsCodeCommit")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderAwsCodeCommit? AwsCodeCommit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureDevOps")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderAzureDevOps? AzureDevOps { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucket")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucket? Bitbucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucketServer")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderBitbucketServer? BitbucketServer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloneProtocol")]
    public string? CloneProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderFilters>? Filters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitea")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitea? Gitea { get; set; }

    /// <summary></summary>
    [JsonPropertyName("github")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGithub? Github { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitlab")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderGitlab? Gitlab { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProviderTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixGenerators
{
    /// <summary></summary>
    [JsonPropertyName("clusterDecisionResource")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusterDecisionResource? ClusterDecisionResource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusters")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsClusters? Clusters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("git")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsGit? Git { get; set; }

    /// <summary></summary>
    [JsonPropertyName("list")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsList? List { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matrix")]
    public JsonNode? Matrix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("merge")]
    public JsonNode? Merge { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pullRequest")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsPullRequest? PullRequest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scmProvider")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsScmProvider? ScmProvider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixGeneratorsSelector? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrixTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMatrix
{
    /// <summary></summary>
    [JsonPropertyName("generators")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMatrixGenerators> Generators { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrixTemplate? Template { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceLabelSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceLabelSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResource
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public string ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceLabelSelector? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResourceTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusters
{
    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersSelector? Selector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClustersTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitDirectories
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public bool? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitFiles
{
    /// <summary></summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGit
{
    /// <summary></summary>
    [JsonPropertyName("directories")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitDirectories>? Directories { get; set; }

    /// <summary></summary>
    [JsonPropertyName("files")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitFiles>? Files { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathParamPrefix")]
    public string? PathParamPrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGitTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsList
{
    /// <summary></summary>
    [JsonPropertyName("elements")]
    public IList<JsonNode>? Elements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("elementsYaml")]
    public string? ElementsYaml { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsListTemplate? Template { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginConfigMapRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginInput
{
    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, JsonNode>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPlugin
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginConfigMapRef ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("input")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginInput? Input { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPluginTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestAzuredevopsTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestAzuredevops
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("organization")]
    public string Organization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestAzuredevopsTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketBasicAuthPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketBasicAuthPasswordRef PasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketBearerTokenTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketBearerToken
{
    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketBearerTokenTokenRef TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucket
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bearerToken")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketBearerToken? BearerToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketServerBasicAuthPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketServerBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketServerBasicAuthPasswordRef PasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketServer
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketServerBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestFilters
{
    /// <summary></summary>
    [JsonPropertyName("branchMatch")]
    public string? BranchMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetBranchMatch")]
    public string? TargetBranchMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGiteaTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGitea
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGiteaTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGithubTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGithub
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appSecretName")]
    public string? AppSecretName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGithubTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGitlabTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGitlab
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pullRequestState")]
    public string? PullRequestState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGitlabTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequest
{
    /// <summary></summary>
    [JsonPropertyName("azuredevops")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestAzuredevops? Azuredevops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucket")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucket? Bitbucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucketServer")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestBitbucketServer? BitbucketServer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestFilters>? Filters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitea")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGitea? Gitea { get; set; }

    /// <summary></summary>
    [JsonPropertyName("github")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGithub? Github { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitlab")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestGitlab? Gitlab { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequestTemplate? Template { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderAwsCodeCommitTagFilters
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderAwsCodeCommit
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagFilters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderAwsCodeCommitTagFilters>? TagFilters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderAzureDevOpsAccessTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderAzureDevOps
{
    /// <summary></summary>
    [JsonPropertyName("accessTokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderAzureDevOpsAccessTokenRef AccessTokenRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("organization")]
    public string Organization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("teamProject")]
    public string TeamProject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketAppPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucket
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appPasswordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketAppPasswordRef AppPasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string User { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketServerBasicAuthPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketServerBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketServerBasicAuthPasswordRef PasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketServer
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketServerBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderFilters
{
    /// <summary></summary>
    [JsonPropertyName("branchMatch")]
    public string? BranchMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelMatch")]
    public string? LabelMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathsDoNotExist")]
    public IList<string>? PathsDoNotExist { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathsExist")]
    public IList<string>? PathsExist { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repositoryMatch")]
    public string? RepositoryMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGiteaTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGitea
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGiteaTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGithubTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGithub
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appSecretName")]
    public string? AppSecretName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("organization")]
    public string Organization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGithubTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGitlabTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGitlab
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeSharedProjects")]
    public bool? IncludeSharedProjects { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeSubgroups")]
    public bool? IncludeSubgroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGitlabTokenRef? TokenRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProvider
{
    /// <summary></summary>
    [JsonPropertyName("awsCodeCommit")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderAwsCodeCommit? AwsCodeCommit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureDevOps")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderAzureDevOps? AzureDevOps { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucket")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucket? Bitbucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucketServer")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderBitbucketServer? BitbucketServer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloneProtocol")]
    public string? CloneProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderFilters>? Filters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitea")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGitea? Gitea { get; set; }

    /// <summary></summary>
    [JsonPropertyName("github")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGithub? Github { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitlab")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderGitlab? Gitlab { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProviderTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeGenerators
{
    /// <summary></summary>
    [JsonPropertyName("clusterDecisionResource")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusterDecisionResource? ClusterDecisionResource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusters")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsClusters? Clusters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("git")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsGit? Git { get; set; }

    /// <summary></summary>
    [JsonPropertyName("list")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsList? List { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matrix")]
    public JsonNode? Matrix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("merge")]
    public JsonNode? Merge { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pullRequest")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsPullRequest? PullRequest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scmProvider")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsScmProvider? ScmProvider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeGeneratorsSelector? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMergeTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsMerge
{
    /// <summary></summary>
    [JsonPropertyName("generators")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsMergeGenerators> Generators { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mergeKeys")]
    public IList<string> MergeKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsMergeTemplate? Template { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginConfigMapRef
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginInput
{
    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, JsonNode>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPluginTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPlugin
{
    /// <summary></summary>
    [JsonPropertyName("configMapRef")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginConfigMapRef ConfigMapRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("input")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginInput? Input { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsPluginTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestAzuredevopsTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestAzuredevops
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("organization")]
    public string Organization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestAzuredevopsTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketBasicAuthPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketBasicAuthPasswordRef PasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketBearerTokenTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketBearerToken
{
    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketBearerTokenTokenRef TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucket
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bearerToken")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketBearerToken? BearerToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketServerBasicAuthPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketServerBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketServerBasicAuthPasswordRef PasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketServer
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketServerBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestFilters
{
    /// <summary></summary>
    [JsonPropertyName("branchMatch")]
    public string? BranchMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetBranchMatch")]
    public string? TargetBranchMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestGiteaTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestGitea
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestGiteaTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestGithubTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestGithub
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appSecretName")]
    public string? AppSecretName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestGithubTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestGitlabTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestGitlab
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pullRequestState")]
    public string? PullRequestState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestGitlabTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsPullRequest
{
    /// <summary></summary>
    [JsonPropertyName("azuredevops")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestAzuredevops? Azuredevops { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucket")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucket? Bitbucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucketServer")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestBitbucketServer? BitbucketServer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsPullRequestFilters>? Filters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitea")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestGitea? Gitea { get; set; }

    /// <summary></summary>
    [JsonPropertyName("github")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestGithub? Github { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitlab")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestGitlab? Gitlab { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequestTemplate? Template { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderAwsCodeCommitTagFilters
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderAwsCodeCommit
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagFilters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderAwsCodeCommitTagFilters>? TagFilters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderAzureDevOpsAccessTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderAzureDevOps
{
    /// <summary></summary>
    [JsonPropertyName("accessTokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderAzureDevOpsAccessTokenRef AccessTokenRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("organization")]
    public string Organization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("teamProject")]
    public string TeamProject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderBitbucketAppPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderBitbucket
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appPasswordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderBitbucketAppPasswordRef AppPasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string User { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderBitbucketServerBasicAuthPasswordRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderBitbucketServerBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordRef")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderBitbucketServerBasicAuthPasswordRef PasswordRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderBitbucketServer
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderBitbucketServerBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderFilters
{
    /// <summary></summary>
    [JsonPropertyName("branchMatch")]
    public string? BranchMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelMatch")]
    public string? LabelMatch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathsDoNotExist")]
    public IList<string>? PathsDoNotExist { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pathsExist")]
    public IList<string>? PathsExist { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repositoryMatch")]
    public string? RepositoryMatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderGiteaTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderGitea
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderGiteaTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderGithubTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderGithub
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("appSecretName")]
    public string? AppSecretName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("organization")]
    public string Organization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderGithubTokenRef? TokenRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderGitlabTokenRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretName")]
    public string SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderGitlab
{
    /// <summary></summary>
    [JsonPropertyName("allBranches")]
    public bool? AllBranches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeSharedProjects")]
    public bool? IncludeSharedProjects { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeSubgroups")]
    public bool? IncludeSubgroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenRef")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderGitlabTokenRef? TokenRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsScmProvider
{
    /// <summary></summary>
    [JsonPropertyName("awsCodeCommit")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderAwsCodeCommit? AwsCodeCommit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureDevOps")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderAzureDevOps? AzureDevOps { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucket")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderBitbucket? Bitbucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bitbucketServer")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderBitbucketServer? BitbucketServer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloneProtocol")]
    public string? CloneProtocol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filters")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsScmProviderFilters>? Filters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitea")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderGitea? Gitea { get; set; }

    /// <summary></summary>
    [JsonPropertyName("github")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderGithub? Github { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gitlab")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderGitlab? Gitlab { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requeueAfterSeconds")]
    public long? RequeueAfterSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProviderTemplate? Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IDictionary<string, string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsSelectorMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGeneratorsSelector
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ApplicationSetSpecGeneratorsSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecGenerators
{
    /// <summary></summary>
    [JsonPropertyName("clusterDecisionResource")]
    public V1alpha1ApplicationSetSpecGeneratorsClusterDecisionResource? ClusterDecisionResource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusters")]
    public V1alpha1ApplicationSetSpecGeneratorsClusters? Clusters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("git")]
    public V1alpha1ApplicationSetSpecGeneratorsGit? Git { get; set; }

    /// <summary></summary>
    [JsonPropertyName("list")]
    public V1alpha1ApplicationSetSpecGeneratorsList? List { get; set; }

    /// <summary></summary>
    [JsonPropertyName("matrix")]
    public V1alpha1ApplicationSetSpecGeneratorsMatrix? Matrix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("merge")]
    public V1alpha1ApplicationSetSpecGeneratorsMerge? Merge { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecGeneratorsPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pullRequest")]
    public V1alpha1ApplicationSetSpecGeneratorsPullRequest? PullRequest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scmProvider")]
    public V1alpha1ApplicationSetSpecGeneratorsScmProvider? ScmProvider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selector")]
    public V1alpha1ApplicationSetSpecGeneratorsSelector? Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecIgnoreApplicationDifferences
{
    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecPreservedFields
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecStrategyRollingSyncStepsMatchExpressions
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecStrategyRollingSyncSteps
{
    /// <summary></summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ApplicationSetSpecStrategyRollingSyncStepsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxUpdate")]
    public IntstrIntOrString? MaxUpdate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecStrategyRollingSync
{
    /// <summary></summary>
    [JsonPropertyName("steps")]
    public IList<V1alpha1ApplicationSetSpecStrategyRollingSyncSteps>? Steps { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecStrategy
{
    /// <summary></summary>
    [JsonPropertyName("rollingSync")]
    public V1alpha1ApplicationSetSpecStrategyRollingSync? RollingSync { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("applicationsSync")]
    public string? ApplicationsSync { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preserveResourcesOnDeletion")]
    public bool? PreserveResourcesOnDeletion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecIgnoreDifferences
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqPathExpressions")]
    public IList<string>? JqPathExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPointers")]
    public IList<string>? JsonPointers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourceDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourceDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourceDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourceDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourceHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourceHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourceHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourceKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourceKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourceKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourceKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcePluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcePluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcePlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSource
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourceDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourceHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourceKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourcePlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesDirectoryJsonnetExtVars
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesDirectoryJsonnetTlas
{
    /// <summary></summary>
    [JsonPropertyName("code")]
    public bool? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesDirectoryJsonnet
{
    /// <summary></summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary></summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesDirectory
{
    /// <summary></summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary></summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesHelmFileParameters
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesHelmParameters
{
    /// <summary></summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesHelm
{
    /// <summary></summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesKustomizePatchesTarget
{
    /// <summary></summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesKustomizePatches
{
    /// <summary></summary>
    [JsonPropertyName("options")]
    public IDictionary<string, bool>? Options { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string? Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesKustomizeReplicas
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesKustomize
{
    /// <summary></summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesPluginEnv
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesPluginParameters
{
    /// <summary></summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary></summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSourcesPlugin
{
    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSources
{
    /// <summary></summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourcesDirectory? Directory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourcesHelm? Helm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSetSpecTemplateSpecSourcesPlugin? Plugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSyncPolicyAutomated
{
    /// <summary></summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSyncPolicyRetryBackoff
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSyncPolicyRetry
{
    /// <summary></summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSetSpecTemplateSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary></summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpecSyncPolicy
{
    /// <summary></summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSetSpecTemplateSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSetSpecTemplateSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSetSpecTemplateSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplateSpec
{
    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSetSpecTemplateSpecDestination Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecInfo>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSetSpecTemplateSpecSource? Source { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSetSpecTemplateSpecSources>? Sources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecTemplateSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpecTemplate
{
    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ApplicationSetSpecTemplateMetadata Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpecTemplateSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetSpec
{
    /// <summary></summary>
    [JsonPropertyName("applyNestedSelectors")]
    public bool? ApplyNestedSelectors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generators")]
    public IList<V1alpha1ApplicationSetSpecGenerators> Generators { get; set; }

    /// <summary></summary>
    [JsonPropertyName("goTemplate")]
    public bool? GoTemplate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("goTemplateOptions")]
    public IList<string>? GoTemplateOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignoreApplicationDifferences")]
    public IList<V1alpha1ApplicationSetSpecIgnoreApplicationDifferences>? IgnoreApplicationDifferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preservedFields")]
    public V1alpha1ApplicationSetSpecPreservedFields? PreservedFields { get; set; }

    /// <summary></summary>
    [JsonPropertyName("strategy")]
    public V1alpha1ApplicationSetSpecStrategy? Strategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSetSpecSyncPolicy? SyncPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("template")]
    public V1alpha1ApplicationSetSpecTemplate Template { get; set; }

    /// <summary></summary>
    [JsonPropertyName("templatePatch")]
    public string? TemplatePatch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetStatusApplicationStatus
{
    /// <summary></summary>
    [JsonPropertyName("application")]
    public string Application { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("step")]
    public string Step { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRevisions")]
    public IList<string> TargetRevisions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetStatusConditions
{
    /// <summary></summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetStatusResourcesHealth
{
    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetStatusResources
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("health")]
    public V1alpha1ApplicationSetStatusResourcesHealth? Health { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hook")]
    public bool? Hook { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiresPruning")]
    public bool? RequiresPruning { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("syncWave")]
    public long? SyncWave { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSetStatus
{
    /// <summary></summary>
    [JsonPropertyName("applicationStatus")]
    public IList<V1alpha1ApplicationSetStatusApplicationStatus>? ApplicationStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ApplicationSetStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha1ApplicationSetStatusResources>? Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApplicationSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ApplicationSetSpec>, IStatus<V1alpha1ApplicationSetStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ApplicationSet";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "applicationsets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSetSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ApplicationSetStatus? Status { get; set; }
}