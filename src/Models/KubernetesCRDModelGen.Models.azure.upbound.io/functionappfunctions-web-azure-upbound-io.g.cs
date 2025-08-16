using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.upbound.io;
/// <summary>FunctionAppFunction is the Schema for the FunctionAppFunctions API. Manages a Function App Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FunctionAppFunctionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FunctionAppFunction>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FunctionAppFunctionList";
    public const string KubeGroup = "web.azure.upbound.io";
    public const string KubePluralName = "functionappfunctions";
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
    public IList<V1beta1FunctionAppFunction> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecForProviderFile
{
    /// <summary>The content of the file. Changing this forces a new resource to be created. The content of the file.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The filename of the file to be uploaded. Changing this forces a new resource to be created. The filename of the file to be uploaded.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecForProviderFunctionAppIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinuxFunctionApp in web to populate functionAppId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecForProviderFunctionAppIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppFunctionSpecForProviderFunctionAppIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecForProviderFunctionAppIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinuxFunctionApp in web to populate functionAppId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecForProviderFunctionAppIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppFunctionSpecForProviderFunctionAppIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecForProvider
{
    /// <summary>The config for this Function in JSON format. The config for this Function in JSON format.</summary>
    [JsonPropertyName("configJson")]
    public string? ConfigJson { get; set; }

    /// <summary>Should this function be enabled. Defaults to true. Should this function be enabled. Defaults to `true`.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A file block as detailed below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1FunctionAppFunctionSpecForProviderFile>? File { get; set; }

    /// <summary>The ID of the Function App in which this function should reside. Changing this forces a new resource to be created. The ID of the Function App in which this function should reside.</summary>
    [JsonPropertyName("functionAppId")]
    public string? FunctionAppId { get; set; }

    /// <summary>Reference to a LinuxFunctionApp in web to populate functionAppId.</summary>
    [JsonPropertyName("functionAppIdRef")]
    public V1beta1FunctionAppFunctionSpecForProviderFunctionAppIdRef? FunctionAppIdRef { get; set; }

    /// <summary>Selector for a LinuxFunctionApp in web to populate functionAppId.</summary>
    [JsonPropertyName("functionAppIdSelector")]
    public V1beta1FunctionAppFunctionSpecForProviderFunctionAppIdSelector? FunctionAppIdSelector { get; set; }

    /// <summary>The language the Function is written in. Possible values are CSharp, Custom, Java, Javascript, Python, PowerShell, and TypeScript. The language the Function is written in.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>The name of the function. Changing this forces a new resource to be created. The name of the function.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The test data for the function. The test data for the function.</summary>
    [JsonPropertyName("testData")]
    public string? TestData { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecInitProviderFile
{
    /// <summary>The content of the file. Changing this forces a new resource to be created. The content of the file.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The filename of the file to be uploaded. Changing this forces a new resource to be created. The filename of the file to be uploaded.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecInitProviderFunctionAppIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinuxFunctionApp in web to populate functionAppId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecInitProviderFunctionAppIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppFunctionSpecInitProviderFunctionAppIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecInitProviderFunctionAppIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinuxFunctionApp in web to populate functionAppId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecInitProviderFunctionAppIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppFunctionSpecInitProviderFunctionAppIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecInitProvider
{
    /// <summary>The config for this Function in JSON format. The config for this Function in JSON format.</summary>
    [JsonPropertyName("configJson")]
    public string? ConfigJson { get; set; }

    /// <summary>Should this function be enabled. Defaults to true. Should this function be enabled. Defaults to `true`.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A file block as detailed below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1FunctionAppFunctionSpecInitProviderFile>? File { get; set; }

    /// <summary>The ID of the Function App in which this function should reside. Changing this forces a new resource to be created. The ID of the Function App in which this function should reside.</summary>
    [JsonPropertyName("functionAppId")]
    public string? FunctionAppId { get; set; }

    /// <summary>Reference to a LinuxFunctionApp in web to populate functionAppId.</summary>
    [JsonPropertyName("functionAppIdRef")]
    public V1beta1FunctionAppFunctionSpecInitProviderFunctionAppIdRef? FunctionAppIdRef { get; set; }

    /// <summary>Selector for a LinuxFunctionApp in web to populate functionAppId.</summary>
    [JsonPropertyName("functionAppIdSelector")]
    public V1beta1FunctionAppFunctionSpecInitProviderFunctionAppIdSelector? FunctionAppIdSelector { get; set; }

    /// <summary>The language the Function is written in. Possible values are CSharp, Custom, Java, Javascript, Python, PowerShell, and TypeScript. The language the Function is written in.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>The name of the function. Changing this forces a new resource to be created. The name of the function.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The test data for the function. The test data for the function.</summary>
    [JsonPropertyName("testData")]
    public string? TestData { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppFunctionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FunctionAppFunctionSpec defines the desired state of FunctionAppFunction</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FunctionAppFunctionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FunctionAppFunctionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FunctionAppFunctionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FunctionAppFunctionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionStatusAtProviderFile
{
    /// <summary>The content of the file. Changing this forces a new resource to be created. The content of the file.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The filename of the file to be uploaded. Changing this forces a new resource to be created. The filename of the file to be uploaded.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionStatusAtProvider
{
    /// <summary>The config for this Function in JSON format. The config for this Function in JSON format.</summary>
    [JsonPropertyName("configJson")]
    public string? ConfigJson { get; set; }

    /// <summary>The URL of the configuration JSON. The URL of the configuration JSON.</summary>
    [JsonPropertyName("configUrl")]
    public string? ConfigUrl { get; set; }

    /// <summary>Should this function be enabled. Defaults to true. Should this function be enabled. Defaults to `true`.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A file block as detailed below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("file")]
    public IList<V1beta1FunctionAppFunctionStatusAtProviderFile>? File { get; set; }

    /// <summary>The ID of the Function App in which this function should reside. Changing this forces a new resource to be created. The ID of the Function App in which this function should reside.</summary>
    [JsonPropertyName("functionAppId")]
    public string? FunctionAppId { get; set; }

    /// <summary>The ID of the Function App Function</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The invocation URL. The invocation URL.</summary>
    [JsonPropertyName("invocationUrl")]
    public string? InvocationUrl { get; set; }

    /// <summary>The language the Function is written in. Possible values are CSharp, Custom, Java, Javascript, Python, PowerShell, and TypeScript. The language the Function is written in.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>The name of the function. Changing this forces a new resource to be created. The name of the function.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Script root path URL. The Script root path URL.</summary>
    [JsonPropertyName("scriptRootPathUrl")]
    public string? ScriptRootPathUrl { get; set; }

    /// <summary>The script URL. The script URL.</summary>
    [JsonPropertyName("scriptUrl")]
    public string? ScriptUrl { get; set; }

    /// <summary>The URL for the Secrets File. The URL for the Secrets File.</summary>
    [JsonPropertyName("secretsFileUrl")]
    public string? SecretsFileUrl { get; set; }

    /// <summary>The test data for the function. The test data for the function.</summary>
    [JsonPropertyName("testData")]
    public string? TestData { get; set; }

    /// <summary>The Test data URL. The Test data URL.</summary>
    [JsonPropertyName("testDataUrl")]
    public string? TestDataUrl { get; set; }

    /// <summary>The function URL. The function URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>FunctionAppFunctionStatus defines the observed state of FunctionAppFunction.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppFunctionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FunctionAppFunctionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FunctionAppFunctionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FunctionAppFunction is the Schema for the FunctionAppFunctions API. Manages a Function App Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FunctionAppFunction : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FunctionAppFunctionSpec>, IStatus<V1beta1FunctionAppFunctionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FunctionAppFunction";
    public const string KubeGroup = "web.azure.upbound.io";
    public const string KubePluralName = "functionappfunctions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionAppFunctionSpec defines the desired state of FunctionAppFunction</summary>
    [JsonPropertyName("spec")]
    public V1beta1FunctionAppFunctionSpec Spec { get; set; }

    /// <summary>FunctionAppFunctionStatus defines the observed state of FunctionAppFunction.</summary>
    [JsonPropertyName("status")]
    public V1beta1FunctionAppFunctionStatus? Status { get; set; }
}