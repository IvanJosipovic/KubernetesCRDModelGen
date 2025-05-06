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
public partial class V1alpha1ApplicationOperationInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>InitiatedBy contains information about who initiated the operations</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationInitiatedBy
{
    /// <summary>Automated is set to true if operation was initiated automatically by the application controller.</summary>
    [JsonPropertyName("automated")]
    public bool? Automated { get; set; }

    /// <summary>Username contains the name of a user who started operation</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Backoff controls how to backoff on subsequent retries of failed syncs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationRetryBackoff
{
    /// <summary>Duration is the amount to back off. Default unit is seconds, but could also be a duration (e.g. "2m", "1h")</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Factor is a factor to multiply the base duration after each failed retry</summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary>MaxDuration is the maximum amount of time allowed for the backoff strategy</summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary>Retry controls the strategy to apply if a sync fails</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationRetry
{
    /// <summary>Backoff controls how to backoff on subsequent retries of failed syncs</summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationOperationRetryBackoff? Backoff { get; set; }

    /// <summary>Limit is the maximum number of attempts for retrying a failed sync. If set to 0, no retries will be performed.</summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary>SyncOperationResource contains resources to sync.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncResources
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourceDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourceDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourceDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationOperationSyncSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationOperationSyncSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourceDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationOperationSyncSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourceHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourceHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourceHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationOperationSyncSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationOperationSyncSourceHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourceKustomizePatchesTarget
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
public partial class V1alpha1ApplicationOperationSyncSourceKustomizePatches
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
    public V1alpha1ApplicationOperationSyncSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourceKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourceKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationOperationSyncSourceKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationOperationSyncSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcePluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcePluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcePlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationOperationSyncSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationOperationSyncSourcePluginParameters>? Parameters { get; set; }
}

/// <summary>Source overrides the source definition set in the application. This is typically set in a Rollback operation and is nil during a Sync operation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSource
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationOperationSyncSourceDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationOperationSyncSourceHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationOperationSyncSourceKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationOperationSyncSourcePlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationOperationSyncSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationOperationSyncSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationOperationSyncSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationOperationSyncSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationOperationSyncSourcesHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesKustomizePatchesTarget
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
public partial class V1alpha1ApplicationOperationSyncSourcesKustomizePatches
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
    public V1alpha1ApplicationOperationSyncSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationOperationSyncSourcesKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationOperationSyncSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesPluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesPluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSourcesPlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationOperationSyncSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationOperationSyncSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary>ApplicationSource contains all required information about the source of an application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSources
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationOperationSyncSourcesDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationOperationSyncSourcesHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationOperationSyncSourcesKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationOperationSyncSourcesPlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>Apply will perform a `kubectl apply` to perform the sync.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSyncStrategyApply
{
    /// <summary>Force indicates whether or not to supply the --force flag to `kubectl apply`. The --force flag deletes and re-create the resource, when PATCH encounters conflict and has retried for 5 times.</summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }
}

/// <summary>Hook will submit any referenced resources to perform the sync. This is the default strategy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSyncStrategyHook
{
    /// <summary>Force indicates whether or not to supply the --force flag to `kubectl apply`. The --force flag deletes and re-create the resource, when PATCH encounters conflict and has retried for 5 times.</summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }
}

/// <summary>SyncStrategy describes how to perform the sync</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSyncSyncStrategy
{
    /// <summary>Apply will perform a `kubectl apply` to perform the sync.</summary>
    [JsonPropertyName("apply")]
    public V1alpha1ApplicationOperationSyncSyncStrategyApply? Apply { get; set; }

    /// <summary>Hook will submit any referenced resources to perform the sync. This is the default strategy</summary>
    [JsonPropertyName("hook")]
    public V1alpha1ApplicationOperationSyncSyncStrategyHook? Hook { get; set; }
}

/// <summary>Sync contains parameters for the operation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperationSync
{
    /// <summary>SelfHealAttemptsCount contains the number of auto-heal attempts</summary>
    [JsonPropertyName("autoHealAttemptsCount")]
    public long? AutoHealAttemptsCount { get; set; }

    /// <summary>DryRun specifies to perform a `kubectl apply --dry-run` without actually performing the sync</summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>Manifests is an optional field that overrides sync source with a local directory for development</summary>
    [JsonPropertyName("manifests")]
    public IList<string>? Manifests { get; set; }

    /// <summary>Prune specifies to delete resources from the cluster that are no longer tracked in git</summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary>Resources describes which resources shall be part of the sync</summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha1ApplicationOperationSyncResources>? Resources { get; set; }

    /// <summary>Revision is the revision (Git) or chart version (Helm) which to sync the application to If omitted, will use the revision specified in app spec.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Revisions is the list of revision (Git) or chart version (Helm) which to sync each source in sources field for the application to If omitted, will use the revision specified in app spec.</summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }

    /// <summary>Source overrides the source definition set in the application. This is typically set in a Rollback operation and is nil during a Sync operation</summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationOperationSyncSource? Source { get; set; }

    /// <summary>Sources overrides the source definition set in the application. This is typically set in a Rollback operation and is nil during a Sync operation</summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationOperationSyncSources>? Sources { get; set; }

    /// <summary>SyncOptions provide per-sync sync-options, e.g. Validate=false</summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }

    /// <summary>SyncStrategy describes how to perform the sync</summary>
    [JsonPropertyName("syncStrategy")]
    public V1alpha1ApplicationOperationSyncSyncStrategy? SyncStrategy { get; set; }
}

/// <summary>Operation contains information about a requested or running operation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationOperation
{
    /// <summary>Info is a list of informational items for this operation</summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationOperationInfo>? Info { get; set; }

    /// <summary>InitiatedBy contains information about who initiated the operations</summary>
    [JsonPropertyName("initiatedBy")]
    public V1alpha1ApplicationOperationInitiatedBy? InitiatedBy { get; set; }

    /// <summary>Retry controls the strategy to apply if a sync fails</summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationOperationRetry? Retry { get; set; }

    /// <summary>Sync contains parameters for the operation</summary>
    [JsonPropertyName("sync")]
    public V1alpha1ApplicationOperationSync? Sync { get; set; }
}

/// <summary>Destination is a reference to the target Kubernetes server and namespace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecDestination
{
    /// <summary>Name is an alternate way of specifying the target cluster by its symbolic name. This must be set if Server is not set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies the target namespace for the application's resources. The namespace will only be set for namespace-scoped resources that have not set a value for .metadata.namespace</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Server specifies the URL of the target cluster's Kubernetes control plane API. This must be set if Name is not set.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>ResourceIgnoreDifferences contains resource filter and list of json paths which should be ignored during comparison with live state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecIgnoreDifferences
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

    /// <summary>ManagedFieldsManagers is a list of trusted managers. Fields mutated by those managers will take precedence over the desired state defined in the SCM and won't be displayed in diffs</summary>
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
public partial class V1alpha1ApplicationSpecInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSpecSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSpecSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSpecSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSpecSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSpecSourceHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceKustomizePatchesTarget
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
public partial class V1alpha1ApplicationSpecSourceKustomizePatches
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
    public V1alpha1ApplicationSpecSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSpecSourceKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSpecSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcePluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcePluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcePlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSpecSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSpecSourcePluginParameters>? Parameters { get; set; }
}

/// <summary>Source is a reference to the location of the application's manifests or chart</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSource
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSpecSourceDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSpecSourceHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSpecSourceKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSpecSourcePlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>DrySource specifies where the dry "don't repeat yourself" manifest source lives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceHydratorDrySource
{
    /// <summary>Path is a directory path within the Git repository where the manifests are located</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>RepoURL is the URL to the git repository that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to hydrate</summary>
    [JsonPropertyName("targetRevision")]
    public string TargetRevision { get; set; }
}

/// <summary>HydrateTo specifies an optional "staging" location to push hydrated manifests to. An external system would then have to move manifests to the SyncSource, e.g. by pull request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceHydratorHydrateTo
{
    /// <summary>TargetBranch is the branch to which hydrated manifests should be committed</summary>
    [JsonPropertyName("targetBranch")]
    public string TargetBranch { get; set; }
}

/// <summary>SyncSource specifies where to sync hydrated manifests from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceHydratorSyncSource
{
    /// <summary>Path is a directory path within the git repository where hydrated manifests should be committed to and synced from. If hydrateTo is set, this is just the path from which hydrated manifests will be synced.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>TargetBranch is the branch to which hydrated manifests should be committed</summary>
    [JsonPropertyName("targetBranch")]
    public string TargetBranch { get; set; }
}

/// <summary>SourceHydrator provides a way to push hydrated manifests back to git before syncing them to the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourceHydrator
{
    /// <summary>DrySource specifies where the dry "don't repeat yourself" manifest source lives.</summary>
    [JsonPropertyName("drySource")]
    public V1alpha1ApplicationSpecSourceHydratorDrySource DrySource { get; set; }

    /// <summary>HydrateTo specifies an optional "staging" location to push hydrated manifests to. An external system would then have to move manifests to the SyncSource, e.g. by pull request.</summary>
    [JsonPropertyName("hydrateTo")]
    public V1alpha1ApplicationSpecSourceHydratorHydrateTo? HydrateTo { get; set; }

    /// <summary>SyncSource specifies where to sync hydrated manifests from.</summary>
    [JsonPropertyName("syncSource")]
    public V1alpha1ApplicationSpecSourceHydratorSyncSource SyncSource { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationSpecSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationSpecSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationSpecSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationSpecSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSpecSourcesHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesKustomizePatchesTarget
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
public partial class V1alpha1ApplicationSpecSourcesKustomizePatches
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
    public V1alpha1ApplicationSpecSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationSpecSourcesKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationSpecSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesPluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesPluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSourcesPlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationSpecSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationSpecSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary>ApplicationSource contains all required information about the source of an application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSources
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationSpecSourcesDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationSpecSourcesHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationSpecSourcesKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationSpecSourcesPlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>Automated will keep an application synced to the target revision</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSyncPolicyAutomated
{
    /// <summary>AllowEmpty allows apps have zero live resources (default: false)</summary>
    [JsonPropertyName("allowEmpty")]
    public bool? AllowEmpty { get; set; }

    /// <summary>Enable allows apps to explicitly control automated sync</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Prune specifies whether to delete resources from the cluster that are not found in the sources anymore as part of automated sync (default: false)</summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary>SelfHeal specifies whether to revert resources back to their desired state upon modification in the cluster (default: false)</summary>
    [JsonPropertyName("selfHeal")]
    public bool? SelfHeal { get; set; }
}

/// <summary>ManagedNamespaceMetadata controls metadata in the given namespace (if CreateNamespace=true)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSyncPolicyManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Backoff controls how to backoff on subsequent retries of failed syncs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSyncPolicyRetryBackoff
{
    /// <summary>Duration is the amount to back off. Default unit is seconds, but could also be a duration (e.g. "2m", "1h")</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Factor is a factor to multiply the base duration after each failed retry</summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary>MaxDuration is the maximum amount of time allowed for the backoff strategy</summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary>Retry controls failed sync retry behavior</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSyncPolicyRetry
{
    /// <summary>Backoff controls how to backoff on subsequent retries of failed syncs</summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationSpecSyncPolicyRetryBackoff? Backoff { get; set; }

    /// <summary>Limit is the maximum number of attempts for retrying a failed sync. If set to 0, no retries will be performed.</summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary>SyncPolicy controls when and how a sync will be performed</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpecSyncPolicy
{
    /// <summary>Automated will keep an application synced to the target revision</summary>
    [JsonPropertyName("automated")]
    public V1alpha1ApplicationSpecSyncPolicyAutomated? Automated { get; set; }

    /// <summary>ManagedNamespaceMetadata controls metadata in the given namespace (if CreateNamespace=true)</summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationSpecSyncPolicyManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary>Retry controls failed sync retry behavior</summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationSpecSyncPolicyRetry? Retry { get; set; }

    /// <summary>Options allow you to specify whole app sync-options</summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }
}

/// <summary>ApplicationSpec represents desired application state. Contains link to repository with application definition and additional parameters link definition revision.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationSpec
{
    /// <summary>Destination is a reference to the target Kubernetes server and namespace</summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationSpecDestination Destination { get; set; }

    /// <summary>IgnoreDifferences is a list of resources and their fields which should be ignored during comparison</summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationSpecIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary>Info contains a list of information (URLs, email addresses, and plain text) that relates to the application</summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationSpecInfo>? Info { get; set; }

    /// <summary>Project is a reference to the project this application belongs to. The empty string means that application belongs to the 'default' project.</summary>
    [JsonPropertyName("project")]
    public string Project { get; set; }

    /// <summary>RevisionHistoryLimit limits the number of items kept in the application's revision history, which is used for informational purposes as well as for rollbacks to previous versions. This should only be changed in exceptional circumstances. Setting to zero will store no history. This will reduce storage used. Increasing will increase the space used to store the history, so we do not recommend increasing it. Default is 10.</summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary>Source is a reference to the location of the application's manifests or chart</summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationSpecSource? Source { get; set; }

    /// <summary>SourceHydrator provides a way to push hydrated manifests back to git before syncing them to the cluster.</summary>
    [JsonPropertyName("sourceHydrator")]
    public V1alpha1ApplicationSpecSourceHydrator? SourceHydrator { get; set; }

    /// <summary>Sources is a reference to the location of the application's manifests or chart</summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationSpecSources>? Sources { get; set; }

    /// <summary>SyncPolicy controls when and how a sync will be performed</summary>
    [JsonPropertyName("syncPolicy")]
    public V1alpha1ApplicationSpecSyncPolicy? SyncPolicy { get; set; }
}

/// <summary>ApplicationCondition contains details about an application condition, which is usually an error or warning</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusConditions
{
    /// <summary>LastTransitionTime is the time the condition was last observed</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Message contains human-readable message indicating details about condition</summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>Type is an application condition type</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Health contains information about the application's current health status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHealth
{
    /// <summary>LastTransitionTime is the time the HealthStatus was set or updated</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Message is a human-readable informational message describing the health status</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Status holds the status code of the application or resource</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>InitiatedBy contains information about who initiated the operations</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistoryInitiatedBy
{
    /// <summary>Automated is set to true if operation was initiated automatically by the application controller.</summary>
    [JsonPropertyName("automated")]
    public bool? Automated { get; set; }

    /// <summary>Username contains the name of a user who started operation</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourceDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourceDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourceDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationStatusHistorySourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationStatusHistorySourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourceDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationStatusHistorySourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourceHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourceHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourceHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationStatusHistorySourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusHistorySourceHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourceKustomizePatchesTarget
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
public partial class V1alpha1ApplicationStatusHistorySourceKustomizePatches
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
    public V1alpha1ApplicationStatusHistorySourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourceKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourceKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationStatusHistorySourceKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationStatusHistorySourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcePluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcePluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcePlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationStatusHistorySourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusHistorySourcePluginParameters>? Parameters { get; set; }
}

/// <summary>Source is a reference to the application source used for the sync operation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySource
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationStatusHistorySourceDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationStatusHistorySourceHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationStatusHistorySourceKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationStatusHistorySourcePlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationStatusHistorySourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationStatusHistorySourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationStatusHistorySourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationStatusHistorySourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusHistorySourcesHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesKustomizePatchesTarget
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
public partial class V1alpha1ApplicationStatusHistorySourcesKustomizePatches
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
    public V1alpha1ApplicationStatusHistorySourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationStatusHistorySourcesKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationStatusHistorySourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesPluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesPluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySourcesPlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationStatusHistorySourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusHistorySourcesPluginParameters>? Parameters { get; set; }
}

/// <summary>ApplicationSource contains all required information about the source of an application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistorySources
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationStatusHistorySourcesDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationStatusHistorySourcesHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationStatusHistorySourcesKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationStatusHistorySourcesPlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>RevisionHistory contains history information about a previous sync</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusHistory
{
    /// <summary>DeployStartedAt holds the time the sync operation started</summary>
    [JsonPropertyName("deployStartedAt")]
    public string? DeployStartedAt { get; set; }

    /// <summary>DeployedAt holds the time the sync operation completed</summary>
    [JsonPropertyName("deployedAt")]
    public string DeployedAt { get; set; }

    /// <summary>ID is an auto incrementing identifier of the RevisionHistory</summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>InitiatedBy contains information about who initiated the operations</summary>
    [JsonPropertyName("initiatedBy")]
    public V1alpha1ApplicationStatusHistoryInitiatedBy? InitiatedBy { get; set; }

    /// <summary>Revision holds the revision the sync was performed against</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Revisions holds the revision of each source in sources field the sync was performed against</summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }

    /// <summary>Source is a reference to the application source used for the sync operation</summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationStatusHistorySource? Source { get; set; }

    /// <summary>Sources is a reference to the application sources used for the sync operation</summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationStatusHistorySources>? Sources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationInfo
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>InitiatedBy contains information about who initiated the operations</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationInitiatedBy
{
    /// <summary>Automated is set to true if operation was initiated automatically by the application controller.</summary>
    [JsonPropertyName("automated")]
    public bool? Automated { get; set; }

    /// <summary>Username contains the name of a user who started operation</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Backoff controls how to backoff on subsequent retries of failed syncs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationRetryBackoff
{
    /// <summary>Duration is the amount to back off. Default unit is seconds, but could also be a duration (e.g. "2m", "1h")</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Factor is a factor to multiply the base duration after each failed retry</summary>
    [JsonPropertyName("factor")]
    public long? Factor { get; set; }

    /// <summary>MaxDuration is the maximum amount of time allowed for the backoff strategy</summary>
    [JsonPropertyName("maxDuration")]
    public string? MaxDuration { get; set; }
}

/// <summary>Retry controls the strategy to apply if a sync fails</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationRetry
{
    /// <summary>Backoff controls how to backoff on subsequent retries of failed syncs</summary>
    [JsonPropertyName("backoff")]
    public V1alpha1ApplicationStatusOperationStateOperationRetryBackoff? Backoff { get; set; }

    /// <summary>Limit is the maximum number of attempts for retrying a failed sync. If set to 0, no retries will be performed.</summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }
}

/// <summary>SyncOperationResource contains resources to sync.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncResources
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourceDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourceDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourceDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourceDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourceHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourceHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourceHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourceHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourceKustomizePatchesTarget
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
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourceKustomizePatches
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
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourceKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourceKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourceKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcePluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcePluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcePlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourcePluginParameters>? Parameters { get; set; }
}

/// <summary>Source overrides the source definition set in the application. This is typically set in a Rollback operation and is nil during a Sync operation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSource
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourceDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourceHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourceKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourcePlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourcesHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesKustomizePatchesTarget
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
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesKustomizePatches
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
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourcesKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesPluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesPluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSourcesPlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary>ApplicationSource contains all required information about the source of an application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSources
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourcesDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourcesHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourcesKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSourcesPlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>Apply will perform a `kubectl apply` to perform the sync.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSyncStrategyApply
{
    /// <summary>Force indicates whether or not to supply the --force flag to `kubectl apply`. The --force flag deletes and re-create the resource, when PATCH encounters conflict and has retried for 5 times.</summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }
}

/// <summary>Hook will submit any referenced resources to perform the sync. This is the default strategy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSyncStrategyHook
{
    /// <summary>Force indicates whether or not to supply the --force flag to `kubectl apply`. The --force flag deletes and re-create the resource, when PATCH encounters conflict and has retried for 5 times.</summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }
}

/// <summary>SyncStrategy describes how to perform the sync</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSyncSyncStrategy
{
    /// <summary>Apply will perform a `kubectl apply` to perform the sync.</summary>
    [JsonPropertyName("apply")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSyncStrategyApply? Apply { get; set; }

    /// <summary>Hook will submit any referenced resources to perform the sync. This is the default strategy</summary>
    [JsonPropertyName("hook")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSyncStrategyHook? Hook { get; set; }
}

/// <summary>Sync contains parameters for the operation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperationSync
{
    /// <summary>SelfHealAttemptsCount contains the number of auto-heal attempts</summary>
    [JsonPropertyName("autoHealAttemptsCount")]
    public long? AutoHealAttemptsCount { get; set; }

    /// <summary>DryRun specifies to perform a `kubectl apply --dry-run` without actually performing the sync</summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>Manifests is an optional field that overrides sync source with a local directory for development</summary>
    [JsonPropertyName("manifests")]
    public IList<string>? Manifests { get; set; }

    /// <summary>Prune specifies to delete resources from the cluster that are no longer tracked in git</summary>
    [JsonPropertyName("prune")]
    public bool? Prune { get; set; }

    /// <summary>Resources describes which resources shall be part of the sync</summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncResources>? Resources { get; set; }

    /// <summary>Revision is the revision (Git) or chart version (Helm) which to sync the application to If omitted, will use the revision specified in app spec.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Revisions is the list of revision (Git) or chart version (Helm) which to sync each source in sources field for the application to If omitted, will use the revision specified in app spec.</summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }

    /// <summary>Source overrides the source definition set in the application. This is typically set in a Rollback operation and is nil during a Sync operation</summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSource? Source { get; set; }

    /// <summary>Sources overrides the source definition set in the application. This is typically set in a Rollback operation and is nil during a Sync operation</summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationSyncSources>? Sources { get; set; }

    /// <summary>SyncOptions provide per-sync sync-options, e.g. Validate=false</summary>
    [JsonPropertyName("syncOptions")]
    public IList<string>? SyncOptions { get; set; }

    /// <summary>SyncStrategy describes how to perform the sync</summary>
    [JsonPropertyName("syncStrategy")]
    public V1alpha1ApplicationStatusOperationStateOperationSyncSyncStrategy? SyncStrategy { get; set; }
}

/// <summary>Operation is the original requested operation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateOperation
{
    /// <summary>Info is a list of informational items for this operation</summary>
    [JsonPropertyName("info")]
    public IList<V1alpha1ApplicationStatusOperationStateOperationInfo>? Info { get; set; }

    /// <summary>InitiatedBy contains information about who initiated the operations</summary>
    [JsonPropertyName("initiatedBy")]
    public V1alpha1ApplicationStatusOperationStateOperationInitiatedBy? InitiatedBy { get; set; }

    /// <summary>Retry controls the strategy to apply if a sync fails</summary>
    [JsonPropertyName("retry")]
    public V1alpha1ApplicationStatusOperationStateOperationRetry? Retry { get; set; }

    /// <summary>Sync contains parameters for the operation</summary>
    [JsonPropertyName("sync")]
    public V1alpha1ApplicationStatusOperationStateOperationSync? Sync { get; set; }
}

/// <summary>ManagedNamespaceMetadata contains the current sync state of managed namespace metadata</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultManagedNamespaceMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>ResourceResult holds the operation result details of a specific resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultResources
{
    /// <summary>Group specifies the API group of the resource</summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary>HookPhase contains the state of any operation associated with this resource OR hook This can also contain values for non-hook resources.</summary>
    [JsonPropertyName("hookPhase")]
    public string? HookPhase { get; set; }

    /// <summary>HookType specifies the type of the hook. Empty for non-hook resources</summary>
    [JsonPropertyName("hookType")]
    public string? HookType { get; set; }

    /// <summary>Kind specifies the API kind of the resource</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Message contains an informational or error message for the last sync OR operation</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Name specifies the name of the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace specifies the target namespace of the resource</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>Status holds the final result of the sync. Will be empty if the resources is yet to be applied/pruned and is always zero-value for hooks</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>SyncPhase indicates the particular phase of the sync that this result was acquired in</summary>
    [JsonPropertyName("syncPhase")]
    public string? SyncPhase { get; set; }

    /// <summary>Version specifies the API version of the resource</summary>
    [JsonPropertyName("version")]
    public string Version { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourceDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationStatusOperationStateSyncResultSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourceHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourceHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourceHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourceHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourceKustomizePatchesTarget
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
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourceKustomizePatches
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
    public V1alpha1ApplicationStatusOperationStateSyncResultSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourceKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourceKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourceKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcePluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcePluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcePlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourcePluginParameters>? Parameters { get; set; }
}

/// <summary>Source records the application source information of the sync, used for comparing auto-sync</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSource
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationStatusOperationStateSyncResultSourceDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationStatusOperationStateSyncResultSourceHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationStatusOperationStateSyncResultSourceKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationStatusOperationStateSyncResultSourcePlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationStatusOperationStateSyncResultSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourcesHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesKustomizePatchesTarget
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
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesKustomizePatches
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
    public V1alpha1ApplicationStatusOperationStateSyncResultSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourcesKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesPluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesPluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSourcesPlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary>ApplicationSource contains all required information about the source of an application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResultSources
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationStatusOperationStateSyncResultSourcesDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationStatusOperationStateSyncResultSourcesHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationStatusOperationStateSyncResultSourcesKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationStatusOperationStateSyncResultSourcesPlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>SyncResult is the result of a Sync operation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationStateSyncResult
{
    /// <summary>ManagedNamespaceMetadata contains the current sync state of managed namespace metadata</summary>
    [JsonPropertyName("managedNamespaceMetadata")]
    public V1alpha1ApplicationStatusOperationStateSyncResultManagedNamespaceMetadata? ManagedNamespaceMetadata { get; set; }

    /// <summary>Resources contains a list of sync result items for each individual resource in a sync operation</summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultResources>? Resources { get; set; }

    /// <summary>Revision holds the revision this sync operation was performed to</summary>
    [JsonPropertyName("revision")]
    public string Revision { get; set; }

    /// <summary>Revisions holds the revision this sync operation was performed for respective indexed source in sources field</summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }

    /// <summary>Source records the application source information of the sync, used for comparing auto-sync</summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationStatusOperationStateSyncResultSource? Source { get; set; }

    /// <summary>Source records the application source information of the sync, used for comparing auto-sync</summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationStatusOperationStateSyncResultSources>? Sources { get; set; }
}

/// <summary>OperationState contains information about any ongoing operations, such as a sync</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusOperationState
{
    /// <summary>FinishedAt contains time of operation completion</summary>
    [JsonPropertyName("finishedAt")]
    public string? FinishedAt { get; set; }

    /// <summary>Message holds any pertinent messages when attempting to perform operation (typically errors).</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Operation is the original requested operation</summary>
    [JsonPropertyName("operation")]
    public V1alpha1ApplicationStatusOperationStateOperation Operation { get; set; }

    /// <summary>Phase is the current phase of the operation</summary>
    [JsonPropertyName("phase")]
    public string Phase { get; set; }

    /// <summary>RetryCount contains time of operation retries</summary>
    [JsonPropertyName("retryCount")]
    public long? RetryCount { get; set; }

    /// <summary>StartedAt contains time of operation start</summary>
    [JsonPropertyName("startedAt")]
    public string StartedAt { get; set; }

    /// <summary>SyncResult is the result of a Sync operation</summary>
    [JsonPropertyName("syncResult")]
    public V1alpha1ApplicationStatusOperationStateSyncResult? SyncResult { get; set; }
}

/// <summary>Health indicates the health status of the resource (e.g., Healthy, Degraded, Progressing).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusResourcesHealth
{
    /// <summary>LastTransitionTime is the time the HealthStatus was set or updated</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Message is a human-readable informational message describing the health status</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Status holds the status code of the application or resource</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ResourceStatus holds the current synchronization and health status of a Kubernetes resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusResources
{
    /// <summary>Group represents the API group of the resource (e.g., "apps" for Deployments).</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Health indicates the health status of the resource (e.g., Healthy, Degraded, Progressing).</summary>
    [JsonPropertyName("health")]
    public V1alpha1ApplicationStatusResourcesHealth? Health { get; set; }

    /// <summary>Hook is true if the resource is used as a lifecycle hook in an Argo CD application.</summary>
    [JsonPropertyName("hook")]
    public bool? Hook { get; set; }

    /// <summary>Kind specifies the type of the resource (e.g., "Deployment", "Service").</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the unique name of the resource within the namespace.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace defines the Kubernetes namespace where the resource is located.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>RequiresDeletionConfirmation is true if the resource requires explicit user confirmation before deletion.</summary>
    [JsonPropertyName("requiresDeletionConfirmation")]
    public bool? RequiresDeletionConfirmation { get; set; }

    /// <summary>RequiresPruning is true if the resource needs to be pruned (deleted) as part of synchronization.</summary>
    [JsonPropertyName("requiresPruning")]
    public bool? RequiresPruning { get; set; }

    /// <summary>Status represents the synchronization state of the resource (e.g., Synced, OutOfSync).</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>SyncWave determines the order in which resources are applied during a sync operation. Lower values are applied first.</summary>
    [JsonPropertyName("syncWave")]
    public long? SyncWave { get; set; }

    /// <summary>Version indicates the API version of the resource (e.g., "v1", "v1beta1").</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>DrySource specifies where the dry "don't repeat yourself" manifest source lives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSourceHydratorCurrentOperationSourceHydratorDrySource
{
    /// <summary>Path is a directory path within the Git repository where the manifests are located</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>RepoURL is the URL to the git repository that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to hydrate</summary>
    [JsonPropertyName("targetRevision")]
    public string TargetRevision { get; set; }
}

/// <summary>HydrateTo specifies an optional "staging" location to push hydrated manifests to. An external system would then have to move manifests to the SyncSource, e.g. by pull request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSourceHydratorCurrentOperationSourceHydratorHydrateTo
{
    /// <summary>TargetBranch is the branch to which hydrated manifests should be committed</summary>
    [JsonPropertyName("targetBranch")]
    public string TargetBranch { get; set; }
}

/// <summary>SyncSource specifies where to sync hydrated manifests from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSourceHydratorCurrentOperationSourceHydratorSyncSource
{
    /// <summary>Path is a directory path within the git repository where hydrated manifests should be committed to and synced from. If hydrateTo is set, this is just the path from which hydrated manifests will be synced.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>TargetBranch is the branch to which hydrated manifests should be committed</summary>
    [JsonPropertyName("targetBranch")]
    public string TargetBranch { get; set; }
}

/// <summary>SourceHydrator holds the hydrator config used for the hydrate operation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSourceHydratorCurrentOperationSourceHydrator
{
    /// <summary>DrySource specifies where the dry "don't repeat yourself" manifest source lives.</summary>
    [JsonPropertyName("drySource")]
    public V1alpha1ApplicationStatusSourceHydratorCurrentOperationSourceHydratorDrySource DrySource { get; set; }

    /// <summary>HydrateTo specifies an optional "staging" location to push hydrated manifests to. An external system would then have to move manifests to the SyncSource, e.g. by pull request.</summary>
    [JsonPropertyName("hydrateTo")]
    public V1alpha1ApplicationStatusSourceHydratorCurrentOperationSourceHydratorHydrateTo? HydrateTo { get; set; }

    /// <summary>SyncSource specifies where to sync hydrated manifests from.</summary>
    [JsonPropertyName("syncSource")]
    public V1alpha1ApplicationStatusSourceHydratorCurrentOperationSourceHydratorSyncSource SyncSource { get; set; }
}

/// <summary>CurrentOperation holds the status of the hydrate operation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSourceHydratorCurrentOperation
{
    /// <summary>DrySHA holds the resolved revision (sha) of the dry source as of the most recent reconciliation</summary>
    [JsonPropertyName("drySHA")]
    public string? DrySHA { get; set; }

    /// <summary>FinishedAt indicates when the hydrate operation finished</summary>
    [JsonPropertyName("finishedAt")]
    public string? FinishedAt { get; set; }

    /// <summary>HydratedSHA holds the resolved revision (sha) of the hydrated source as of the most recent reconciliation</summary>
    [JsonPropertyName("hydratedSHA")]
    public string? HydratedSHA { get; set; }

    /// <summary>Message contains a message describing the current status of the hydrate operation</summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>Phase indicates the status of the hydrate operation</summary>
    [JsonPropertyName("phase")]
    public string Phase { get; set; }

    /// <summary>SourceHydrator holds the hydrator config used for the hydrate operation</summary>
    [JsonPropertyName("sourceHydrator")]
    public V1alpha1ApplicationStatusSourceHydratorCurrentOperationSourceHydrator? SourceHydrator { get; set; }

    /// <summary>StartedAt indicates when the hydrate operation started</summary>
    [JsonPropertyName("startedAt")]
    public string? StartedAt { get; set; }
}

/// <summary>DrySource specifies where the dry "don't repeat yourself" manifest source lives.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSourceHydratorLastSuccessfulOperationSourceHydratorDrySource
{
    /// <summary>Path is a directory path within the Git repository where the manifests are located</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>RepoURL is the URL to the git repository that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to hydrate</summary>
    [JsonPropertyName("targetRevision")]
    public string TargetRevision { get; set; }
}

/// <summary>HydrateTo specifies an optional "staging" location to push hydrated manifests to. An external system would then have to move manifests to the SyncSource, e.g. by pull request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSourceHydratorLastSuccessfulOperationSourceHydratorHydrateTo
{
    /// <summary>TargetBranch is the branch to which hydrated manifests should be committed</summary>
    [JsonPropertyName("targetBranch")]
    public string TargetBranch { get; set; }
}

/// <summary>SyncSource specifies where to sync hydrated manifests from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSourceHydratorLastSuccessfulOperationSourceHydratorSyncSource
{
    /// <summary>Path is a directory path within the git repository where hydrated manifests should be committed to and synced from. If hydrateTo is set, this is just the path from which hydrated manifests will be synced.</summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>TargetBranch is the branch to which hydrated manifests should be committed</summary>
    [JsonPropertyName("targetBranch")]
    public string TargetBranch { get; set; }
}

/// <summary>SourceHydrator holds the hydrator config used for the hydrate operation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSourceHydratorLastSuccessfulOperationSourceHydrator
{
    /// <summary>DrySource specifies where the dry "don't repeat yourself" manifest source lives.</summary>
    [JsonPropertyName("drySource")]
    public V1alpha1ApplicationStatusSourceHydratorLastSuccessfulOperationSourceHydratorDrySource DrySource { get; set; }

    /// <summary>HydrateTo specifies an optional "staging" location to push hydrated manifests to. An external system would then have to move manifests to the SyncSource, e.g. by pull request.</summary>
    [JsonPropertyName("hydrateTo")]
    public V1alpha1ApplicationStatusSourceHydratorLastSuccessfulOperationSourceHydratorHydrateTo? HydrateTo { get; set; }

    /// <summary>SyncSource specifies where to sync hydrated manifests from.</summary>
    [JsonPropertyName("syncSource")]
    public V1alpha1ApplicationStatusSourceHydratorLastSuccessfulOperationSourceHydratorSyncSource SyncSource { get; set; }
}

/// <summary>LastSuccessfulOperation holds info about the most recent successful hydration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSourceHydratorLastSuccessfulOperation
{
    /// <summary>DrySHA holds the resolved revision (sha) of the dry source as of the most recent reconciliation</summary>
    [JsonPropertyName("drySHA")]
    public string? DrySHA { get; set; }

    /// <summary>HydratedSHA holds the resolved revision (sha) of the hydrated source as of the most recent reconciliation</summary>
    [JsonPropertyName("hydratedSHA")]
    public string? HydratedSHA { get; set; }

    /// <summary>SourceHydrator holds the hydrator config used for the hydrate operation</summary>
    [JsonPropertyName("sourceHydrator")]
    public V1alpha1ApplicationStatusSourceHydratorLastSuccessfulOperationSourceHydrator? SourceHydrator { get; set; }
}

/// <summary>SourceHydrator stores information about the current state of source hydration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSourceHydrator
{
    /// <summary>CurrentOperation holds the status of the hydrate operation</summary>
    [JsonPropertyName("currentOperation")]
    public V1alpha1ApplicationStatusSourceHydratorCurrentOperation? CurrentOperation { get; set; }

    /// <summary>LastSuccessfulOperation holds info about the most recent successful hydration</summary>
    [JsonPropertyName("lastSuccessfulOperation")]
    public V1alpha1ApplicationStatusSourceHydratorLastSuccessfulOperation? LastSuccessfulOperation { get; set; }
}

/// <summary>Summary contains a list of URLs and container images used by this application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSummary
{
    /// <summary>ExternalURLs holds all external URLs of application child resources.</summary>
    [JsonPropertyName("externalURLs")]
    public IList<string>? ExternalURLs { get; set; }

    /// <summary>Images holds all images of application child resources.</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }
}

/// <summary>Destination is a reference to the application's destination used for comparison</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToDestination
{
    /// <summary>Name is an alternate way of specifying the target cluster by its symbolic name. This must be set if Server is not set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace specifies the target namespace for the application's resources. The namespace will only be set for namespace-scoped resources that have not set a value for .metadata.namespace</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Server specifies the URL of the target cluster's Kubernetes control plane API. This must be set if Name is not set.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>ResourceIgnoreDifferences contains resource filter and list of json paths which should be ignored during comparison with live state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToIgnoreDifferences
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

    /// <summary>ManagedFieldsManagers is a list of trusted managers. Fields mutated by those managers will take precedence over the desired state defined in the SCM and won't be displayed in diffs</summary>
    [JsonPropertyName("managedFieldsManagers")]
    public IList<string>? ManagedFieldsManagers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourceDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourceDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourceDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourceDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourceDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourceDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationStatusSyncComparedToSourceDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourceHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourceHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourceHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourceHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourceHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourceKustomizePatchesTarget
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
public partial class V1alpha1ApplicationStatusSyncComparedToSourceKustomizePatches
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
    public V1alpha1ApplicationStatusSyncComparedToSourceKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourceKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourceKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourceKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourceKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcePluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcePluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcePlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourcePluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourcePluginParameters>? Parameters { get; set; }
}

/// <summary>Source is a reference to the application's source used for comparison</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSource
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationStatusSyncComparedToSourceDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationStatusSyncComparedToSourceHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationStatusSyncComparedToSourceKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationStatusSyncComparedToSourcePlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesDirectoryJsonnetExtVars
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

/// <summary>JsonnetVar represents a variable to be passed to jsonnet during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesDirectoryJsonnetTlas
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

/// <summary>Jsonnet holds options specific to Jsonnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesDirectoryJsonnet
{
    /// <summary>ExtVars is a list of Jsonnet External Variables</summary>
    [JsonPropertyName("extVars")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourcesDirectoryJsonnetExtVars>? ExtVars { get; set; }

    /// <summary>Additional library search dirs</summary>
    [JsonPropertyName("libs")]
    public IList<string>? Libs { get; set; }

    /// <summary>TLAS is a list of Jsonnet Top-level Arguments</summary>
    [JsonPropertyName("tlas")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourcesDirectoryJsonnetTlas>? Tlas { get; set; }
}

/// <summary>Directory holds path/directory specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesDirectory
{
    /// <summary>Exclude contains a glob pattern to match paths against that should be explicitly excluded from being used during manifest generation</summary>
    [JsonPropertyName("exclude")]
    public string? Exclude { get; set; }

    /// <summary>Include contains a glob pattern to match paths against that should be explicitly included during manifest generation</summary>
    [JsonPropertyName("include")]
    public string? Include { get; set; }

    /// <summary>Jsonnet holds options specific to Jsonnet</summary>
    [JsonPropertyName("jsonnet")]
    public V1alpha1ApplicationStatusSyncComparedToSourcesDirectoryJsonnet? Jsonnet { get; set; }

    /// <summary>Recurse specifies whether to scan a directory recursively for manifests</summary>
    [JsonPropertyName("recurse")]
    public bool? Recurse { get; set; }
}

/// <summary>HelmFileParameter is a file parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesHelmFileParameters
{
    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is the path to the file containing the values for the Helm parameter</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>HelmParameter is a parameter that's passed to helm template during manifest generation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesHelmParameters
{
    /// <summary>ForceString determines whether to tell Helm to interpret booleans and numbers as strings</summary>
    [JsonPropertyName("forceString")]
    public bool? ForceString { get; set; }

    /// <summary>Name is the name of the Helm parameter</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value is the value for the Helm parameter</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Helm holds helm specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesHelm
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>FileParameters are file parameters to the helm template</summary>
    [JsonPropertyName("fileParameters")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourcesHelmFileParameters>? FileParameters { get; set; }

    /// <summary>IgnoreMissingValueFiles prevents helm template from failing when valueFiles do not exist locally by not appending them to helm template --values</summary>
    [JsonPropertyName("ignoreMissingValueFiles")]
    public bool? IgnoreMissingValueFiles { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>Namespace is an optional namespace to template with. If left empty, defaults to the app's destination namespace.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Parameters is a list of Helm parameters which are passed to the helm template command upon manifest generation</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourcesHelmParameters>? Parameters { get; set; }

    /// <summary>PassCredentials pass credentials to all domains (Helm's --pass-credentials)</summary>
    [JsonPropertyName("passCredentials")]
    public bool? PassCredentials { get; set; }

    /// <summary>ReleaseName is the Helm release name to use. If omitted it will use the application name</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>SkipCrds skips custom resource definition installation step (Helm's --skip-crds)</summary>
    [JsonPropertyName("skipCrds")]
    public bool? SkipCrds { get; set; }

    /// <summary>SkipSchemaValidation skips JSON schema validation (Helm's --skip-schema-validation)</summary>
    [JsonPropertyName("skipSchemaValidation")]
    public bool? SkipSchemaValidation { get; set; }

    /// <summary>SkipTests skips test manifest installation step (Helm's --skip-tests).</summary>
    [JsonPropertyName("skipTests")]
    public bool? SkipTests { get; set; }

    /// <summary>ValuesFiles is a list of Helm value files to use when generating a template</summary>
    [JsonPropertyName("valueFiles")]
    public IList<string>? ValueFiles { get; set; }

    /// <summary>Values specifies Helm values to be passed to helm template, typically defined as a block. ValuesObject takes precedence over Values, so use one or the other.</summary>
    [JsonPropertyName("values")]
    public string? Values { get; set; }

    /// <summary>ValuesObject specifies Helm values to be passed to helm template, defined as a map. This takes precedence over Values.</summary>
    [JsonPropertyName("valuesObject")]
    public JsonNode? ValuesObject { get; set; }

    /// <summary>Version is the Helm version to use for templating ("3")</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesKustomizePatchesTarget
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
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesKustomizePatches
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
    public V1alpha1ApplicationStatusSyncComparedToSourcesKustomizePatchesTarget? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesKustomizeReplicas
{
    /// <summary>Number of replicas</summary>
    [JsonPropertyName("count")]
    public IntstrIntOrString Count { get; set; }

    /// <summary>Name of Deployment or StatefulSet</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Kustomize holds kustomize specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesKustomize
{
    /// <summary>APIVersions specifies the Kubernetes resource API versions to pass to Helm when templating manifests. By default, Argo CD uses the API versions of the target cluster. The format is [group/]version/kind.</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>CommonAnnotations is a list of additional annotations to add to rendered manifests</summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>CommonAnnotationsEnvsubst specifies whether to apply env variables substitution for annotation values</summary>
    [JsonPropertyName("commonAnnotationsEnvsubst")]
    public bool? CommonAnnotationsEnvsubst { get; set; }

    /// <summary>CommonLabels is a list of additional labels to add to rendered manifests</summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>Components specifies a list of kustomize components to add to the kustomization before building</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>ForceCommonAnnotations specifies whether to force applying common annotations to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonAnnotations")]
    public bool? ForceCommonAnnotations { get; set; }

    /// <summary>ForceCommonLabels specifies whether to force applying common labels to resources for Kustomize apps</summary>
    [JsonPropertyName("forceCommonLabels")]
    public bool? ForceCommonLabels { get; set; }

    /// <summary>IgnoreMissingComponents prevents kustomize from failing when components do not exist locally by not appending them to kustomization file</summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>Images is a list of Kustomize image override specifications</summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>KubeVersion specifies the Kubernetes API version to pass to Helm when templating manifests. By default, Argo CD uses the Kubernetes version of the target cluster.</summary>
    [JsonPropertyName("kubeVersion")]
    public string? KubeVersion { get; set; }

    /// <summary>LabelIncludeTemplates specifies whether to apply common labels to resource templates or not</summary>
    [JsonPropertyName("labelIncludeTemplates")]
    public bool? LabelIncludeTemplates { get; set; }

    /// <summary>LabelWithoutSelector specifies whether to apply common labels to resource selectors or not</summary>
    [JsonPropertyName("labelWithoutSelector")]
    public bool? LabelWithoutSelector { get; set; }

    /// <summary>NamePrefix is a prefix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix is a suffix appended to resources for Kustomize apps</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Namespace sets the namespace that Kustomize adds to all resources</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Patches is a list of Kustomize patches</summary>
    [JsonPropertyName("patches")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourcesKustomizePatches>? Patches { get; set; }

    /// <summary>Replicas is a list of Kustomize Replicas override specifications</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourcesKustomizeReplicas>? Replicas { get; set; }

    /// <summary>Version controls which version of Kustomize to use for rendering manifests</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>EnvEntry represents an entry in the application's environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesPluginEnv
{
    /// <summary>Name is the name of the variable, usually expressed in uppercase</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is the value of the variable</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesPluginParameters
{
    /// <summary>Array is the value of an array type parameter.</summary>
    [JsonPropertyName("array")]
    public IList<string>? Array { get; set; }

    /// <summary>Map is the value of a map type parameter.</summary>
    [JsonPropertyName("map")]
    public IDictionary<string, string>? Map { get; set; }

    /// <summary>Name is the name identifying a parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>String_ is the value of a string type parameter.</summary>
    [JsonPropertyName("string")]
    public string? String { get; set; }
}

/// <summary>Plugin holds config management plugin specific options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSourcesPlugin
{
    /// <summary>Env is a list of environment variable entries</summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourcesPluginEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSourcesPluginParameters>? Parameters { get; set; }
}

/// <summary>ApplicationSource contains all required information about the source of an application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedToSources
{
    /// <summary>Chart is a Helm chart name, and must be specified for applications sourced from a Helm repo.</summary>
    [JsonPropertyName("chart")]
    public string? Chart { get; set; }

    /// <summary>Directory holds path/directory specific options</summary>
    [JsonPropertyName("directory")]
    public V1alpha1ApplicationStatusSyncComparedToSourcesDirectory? Directory { get; set; }

    /// <summary>Helm holds helm specific options</summary>
    [JsonPropertyName("helm")]
    public V1alpha1ApplicationStatusSyncComparedToSourcesHelm? Helm { get; set; }

    /// <summary>Kustomize holds kustomize specific options</summary>
    [JsonPropertyName("kustomize")]
    public V1alpha1ApplicationStatusSyncComparedToSourcesKustomize? Kustomize { get; set; }

    /// <summary>Name is used to refer to a source and is displayed in the UI. It is used in multi-source Applications.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path is a directory path within the Git repository, and is only valid for applications sourced from Git.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin holds config management plugin specific options</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1ApplicationStatusSyncComparedToSourcesPlugin? Plugin { get; set; }

    /// <summary>Ref is reference to another source within sources field. This field will not be used if used with a `source` tag.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>RepoURL is the URL to the repository (Git or Helm) that contains the application manifests</summary>
    [JsonPropertyName("repoURL")]
    public string RepoURL { get; set; }

    /// <summary>TargetRevision defines the revision of the source to sync the application to. In case of Git, this can be commit, tag, or branch. If omitted, will equal to HEAD. In case of Helm, this is a semver tag for the Chart's version.</summary>
    [JsonPropertyName("targetRevision")]
    public string? TargetRevision { get; set; }
}

/// <summary>ComparedTo contains information about what has been compared</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSyncComparedTo
{
    /// <summary>Destination is a reference to the application's destination used for comparison</summary>
    [JsonPropertyName("destination")]
    public V1alpha1ApplicationStatusSyncComparedToDestination Destination { get; set; }

    /// <summary>IgnoreDifferences is a reference to the application's ignored differences used for comparison</summary>
    [JsonPropertyName("ignoreDifferences")]
    public IList<V1alpha1ApplicationStatusSyncComparedToIgnoreDifferences>? IgnoreDifferences { get; set; }

    /// <summary>Source is a reference to the application's source used for comparison</summary>
    [JsonPropertyName("source")]
    public V1alpha1ApplicationStatusSyncComparedToSource? Source { get; set; }

    /// <summary>Sources is a reference to the application's multiple sources used for comparison</summary>
    [JsonPropertyName("sources")]
    public IList<V1alpha1ApplicationStatusSyncComparedToSources>? Sources { get; set; }
}

/// <summary>Sync contains information about the application's current sync status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatusSync
{
    /// <summary>ComparedTo contains information about what has been compared</summary>
    [JsonPropertyName("comparedTo")]
    public V1alpha1ApplicationStatusSyncComparedTo? ComparedTo { get; set; }

    /// <summary>Revision contains information about the revision the comparison has been performed to</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>Revisions contains information about the revisions of multiple sources the comparison has been performed to</summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }

    /// <summary>Status is the sync state of the comparison</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
}

/// <summary>ApplicationStatus contains status information for the application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ApplicationStatus
{
    /// <summary>Conditions is a list of currently observed application conditions</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>ControllerNamespace indicates the namespace in which the application controller is located</summary>
    [JsonPropertyName("controllerNamespace")]
    public string? ControllerNamespace { get; set; }

    /// <summary>Health contains information about the application's current health status</summary>
    [JsonPropertyName("health")]
    public V1alpha1ApplicationStatusHealth? Health { get; set; }

    /// <summary>History contains information about the application's sync history</summary>
    [JsonPropertyName("history")]
    public IList<V1alpha1ApplicationStatusHistory>? History { get; set; }

    /// <summary>ObservedAt indicates when the application state was updated without querying latest git state Deprecated: controller no longer updates ObservedAt field</summary>
    [JsonPropertyName("observedAt")]
    public string? ObservedAt { get; set; }

    /// <summary>OperationState contains information about any ongoing operations, such as a sync</summary>
    [JsonPropertyName("operationState")]
    public V1alpha1ApplicationStatusOperationState? OperationState { get; set; }

    /// <summary>ReconciledAt indicates when the application state was reconciled using the latest git version</summary>
    [JsonPropertyName("reconciledAt")]
    public string? ReconciledAt { get; set; }

    /// <summary>ResourceHealthSource indicates where the resource health status is stored: inline if not set or appTree</summary>
    [JsonPropertyName("resourceHealthSource")]
    public string? ResourceHealthSource { get; set; }

    /// <summary>Resources is a list of Kubernetes resources managed by this application</summary>
    [JsonPropertyName("resources")]
    public IList<V1alpha1ApplicationStatusResources>? Resources { get; set; }

    /// <summary>SourceHydrator stores information about the current state of source hydration</summary>
    [JsonPropertyName("sourceHydrator")]
    public V1alpha1ApplicationStatusSourceHydrator? SourceHydrator { get; set; }

    /// <summary>SourceType specifies the type of this application</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }

    /// <summary>SourceTypes specifies the type of the sources included in the application</summary>
    [JsonPropertyName("sourceTypes")]
    public IList<string>? SourceTypes { get; set; }

    /// <summary>Summary contains a list of URLs and container images used by this application</summary>
    [JsonPropertyName("summary")]
    public V1alpha1ApplicationStatusSummary? Summary { get; set; }

    /// <summary>Sync contains information about the application's current sync status</summary>
    [JsonPropertyName("sync")]
    public V1alpha1ApplicationStatusSync? Sync { get; set; }
}

/// <summary>Application is a definition of Application resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Application : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ApplicationSpec>, IStatus<V1alpha1ApplicationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Application";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "applications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Operation contains information about a requested or running operation</summary>
    [JsonPropertyName("operation")]
    public V1alpha1ApplicationOperation? Operation { get; set; }

    /// <summary>ApplicationSpec represents desired application state. Contains link to repository with application definition and additional parameters link definition revision.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ApplicationSpec Spec { get; set; }

    /// <summary>ApplicationStatus contains status information for the application</summary>
    [JsonPropertyName("status")]
    public V1alpha1ApplicationStatus? Status { get; set; }
}

/// <summary>Application is a definition of Application resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Application>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ApplicationList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "applications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1alpha1Application> Items { get; set; }
}