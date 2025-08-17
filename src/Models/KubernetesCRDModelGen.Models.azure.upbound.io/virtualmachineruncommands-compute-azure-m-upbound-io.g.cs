using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.m.upbound.io;
#nullable enable
/// <summary>VirtualMachineRunCommand is the Schema for the VirtualMachineRunCommands API. Manages a Virtual Machine Run Command.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualMachineRunCommandList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VirtualMachineRunCommand>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualMachineRunCommandList";
    public const string KubeGroup = "compute.azure.m.upbound.io";
    public const string KubePluralName = "virtualmachineruncommands";
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
    public IList<V1beta1VirtualMachineRunCommand> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The client ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobManagedIdentityClientIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The object ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobManagedIdentityObjectIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An error_blob_managed_identity block as defined below. User-assigned managed Identity that has access to errorBlobUri storage blob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobManagedIdentity
{
    /// <summary>The client ID of the managed identity.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobManagedIdentityClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>The object ID of the managed identity.</summary>
    [JsonPropertyName("objectIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobManagedIdentityObjectIdSecretRef? ObjectIdSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Blob in storage to populate errorBlobUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobUriRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Blob in storage to populate errorBlobUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobUriSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The client ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobManagedIdentityClientIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The object ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobManagedIdentityObjectIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An output_blob_managed_identity block as defined below. User-assigned managed Identity that has access to outputBlobUri storage blob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobManagedIdentity
{
    /// <summary>The client ID of the managed identity.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobManagedIdentityClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>The object ID of the managed identity.</summary>
    [JsonPropertyName("objectIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobManagedIdentityObjectIdSecretRef? ObjectIdSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Blob in storage to populate outputBlobUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobUriRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Blob in storage to populate outputBlobUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobUriSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderParameter
{
    /// <summary>The run parameter name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The run parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The run parameter name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderProtectedParameterNameSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The run parameter value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderProtectedParameterValueSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderProtectedParameter
{
    /// <summary>The run parameter name.</summary>
    [JsonPropertyName("nameSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderProtectedParameterNameSecretRef? NameSecretRef { get; set; }

    /// <summary>The run parameter value.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderProtectedParameterValueSecretRef? ValueSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the user account password on the VM when executing the Virtual Machine Run Command.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderRunAsPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The client ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriManagedIdentityClientIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The object ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriManagedIdentityObjectIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A script_uri_managed_identity block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriManagedIdentity
{
    /// <summary>The client ID of the managed identity.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriManagedIdentityClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>The object ID of the managed identity.</summary>
    [JsonPropertyName("objectIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriManagedIdentityObjectIdSecretRef? ObjectIdSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Blob in storage to populate scriptUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Blob in storage to populate scriptUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A source block as defined below. The source of the run command script.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderSource
{
    /// <summary></summary>
    [JsonPropertyName("commandId")]
    public string? CommandId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptUri")]
    public string? ScriptUri { get; set; }

    /// <summary>A script_uri_managed_identity block as defined above.</summary>
    [JsonPropertyName("scriptUriManagedIdentity")]
    public V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriManagedIdentity? ScriptUriManagedIdentity { get; set; }

    /// <summary>Reference to a Blob in storage to populate scriptUri.</summary>
    [JsonPropertyName("scriptUriRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriRef? ScriptUriRef { get; set; }

    /// <summary>Selector for a Blob in storage to populate scriptUri.</summary>
    [JsonPropertyName("scriptUriSelector")]
    public V1beta1VirtualMachineRunCommandSpecForProviderSourceScriptUriSelector? ScriptUriSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderVirtualMachineIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderVirtualMachineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecForProviderVirtualMachineIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderVirtualMachineIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProviderVirtualMachineIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecForProviderVirtualMachineIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecForProvider
{
    /// <summary>An error_blob_managed_identity block as defined below. User-assigned managed Identity that has access to errorBlobUri storage blob.</summary>
    [JsonPropertyName("errorBlobManagedIdentity")]
    public V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobManagedIdentity? ErrorBlobManagedIdentity { get; set; }

    /// <summary>Specifies the Azure storage blob where script error stream will be uploaded.</summary>
    [JsonPropertyName("errorBlobUri")]
    public string? ErrorBlobUri { get; set; }

    /// <summary>Reference to a Blob in storage to populate errorBlobUri.</summary>
    [JsonPropertyName("errorBlobUriRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobUriRef? ErrorBlobUriRef { get; set; }

    /// <summary>Selector for a Blob in storage to populate errorBlobUri.</summary>
    [JsonPropertyName("errorBlobUriSelector")]
    public V1beta1VirtualMachineRunCommandSpecForProviderErrorBlobUriSelector? ErrorBlobUriSelector { get; set; }

    /// <summary>The Azure Region where the Virtual Machine Run Command should exist. Changing this forces a new Virtual Machine Run Command to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An output_blob_managed_identity block as defined below. User-assigned managed Identity that has access to outputBlobUri storage blob.</summary>
    [JsonPropertyName("outputBlobManagedIdentity")]
    public V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobManagedIdentity? OutputBlobManagedIdentity { get; set; }

    /// <summary>Specifies the Azure storage blob where script output stream will be uploaded. It can be basic blob URI with SAS token.</summary>
    [JsonPropertyName("outputBlobUri")]
    public string? OutputBlobUri { get; set; }

    /// <summary>Reference to a Blob in storage to populate outputBlobUri.</summary>
    [JsonPropertyName("outputBlobUriRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobUriRef? OutputBlobUriRef { get; set; }

    /// <summary>Selector for a Blob in storage to populate outputBlobUri.</summary>
    [JsonPropertyName("outputBlobUriSelector")]
    public V1beta1VirtualMachineRunCommandSpecForProviderOutputBlobUriSelector? OutputBlobUriSelector { get; set; }

    /// <summary>A list of parameter blocks as defined below. The parameters used by the script.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1VirtualMachineRunCommandSpecForProviderParameter>? Parameter { get; set; }

    /// <summary>A list of protected_parameter blocks as defined below. The protected parameters used by the script.</summary>
    [JsonPropertyName("protectedParameter")]
    public IList<V1beta1VirtualMachineRunCommandSpecForProviderProtectedParameter>? ProtectedParameter { get; set; }

    /// <summary>Specifies the user account password on the VM when executing the Virtual Machine Run Command.</summary>
    [JsonPropertyName("runAsPasswordSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderRunAsPasswordSecretRef? RunAsPasswordSecretRef { get; set; }

    /// <summary>Specifies the user account on the VM when executing the Virtual Machine Run Command.</summary>
    [JsonPropertyName("runAsUser")]
    public string? RunAsUser { get; set; }

    /// <summary>A source block as defined below. The source of the run command script.</summary>
    [JsonPropertyName("source")]
    public V1beta1VirtualMachineRunCommandSpecForProviderSource? Source { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Virtual Machine Run Command.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Virtual Machine ID within which this Virtual Machine Run Command should exist. Changing this forces a new Virtual Machine Run Command to be created.</summary>
    [JsonPropertyName("virtualMachineId")]
    public string? VirtualMachineId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdRef")]
    public V1beta1VirtualMachineRunCommandSpecForProviderVirtualMachineIdRef? VirtualMachineIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdSelector")]
    public V1beta1VirtualMachineRunCommandSpecForProviderVirtualMachineIdSelector? VirtualMachineIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The client ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobManagedIdentityClientIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The object ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobManagedIdentityObjectIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An error_blob_managed_identity block as defined below. User-assigned managed Identity that has access to errorBlobUri storage blob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobManagedIdentity
{
    /// <summary>The client ID of the managed identity.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobManagedIdentityClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>The object ID of the managed identity.</summary>
    [JsonPropertyName("objectIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobManagedIdentityObjectIdSecretRef? ObjectIdSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Blob in storage to populate errorBlobUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobUriRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Blob in storage to populate errorBlobUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobUriSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The client ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobManagedIdentityClientIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The object ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobManagedIdentityObjectIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An output_blob_managed_identity block as defined below. User-assigned managed Identity that has access to outputBlobUri storage blob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobManagedIdentity
{
    /// <summary>The client ID of the managed identity.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobManagedIdentityClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>The object ID of the managed identity.</summary>
    [JsonPropertyName("objectIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobManagedIdentityObjectIdSecretRef? ObjectIdSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Blob in storage to populate outputBlobUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobUriRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Blob in storage to populate outputBlobUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobUriSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderParameter
{
    /// <summary>The run parameter name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The run parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The run parameter name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderProtectedParameterNameSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The run parameter value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderProtectedParameterValueSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderProtectedParameter
{
    /// <summary>The run parameter name.</summary>
    [JsonPropertyName("nameSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderProtectedParameterNameSecretRef NameSecretRef { get; set; }

    /// <summary>The run parameter value.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderProtectedParameterValueSecretRef ValueSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the user account password on the VM when executing the Virtual Machine Run Command.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderRunAsPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The client ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriManagedIdentityClientIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The object ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriManagedIdentityObjectIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A script_uri_managed_identity block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriManagedIdentity
{
    /// <summary>The client ID of the managed identity.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriManagedIdentityClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>The object ID of the managed identity.</summary>
    [JsonPropertyName("objectIdSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriManagedIdentityObjectIdSecretRef? ObjectIdSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Blob in storage to populate scriptUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Blob in storage to populate scriptUri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A source block as defined below. The source of the run command script.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProviderSource
{
    /// <summary></summary>
    [JsonPropertyName("commandId")]
    public string? CommandId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptUri")]
    public string? ScriptUri { get; set; }

    /// <summary>A script_uri_managed_identity block as defined above.</summary>
    [JsonPropertyName("scriptUriManagedIdentity")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriManagedIdentity? ScriptUriManagedIdentity { get; set; }

    /// <summary>Reference to a Blob in storage to populate scriptUri.</summary>
    [JsonPropertyName("scriptUriRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriRef? ScriptUriRef { get; set; }

    /// <summary>Selector for a Blob in storage to populate scriptUri.</summary>
    [JsonPropertyName("scriptUriSelector")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderSourceScriptUriSelector? ScriptUriSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecInitProvider
{
    /// <summary>An error_blob_managed_identity block as defined below. User-assigned managed Identity that has access to errorBlobUri storage blob.</summary>
    [JsonPropertyName("errorBlobManagedIdentity")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobManagedIdentity? ErrorBlobManagedIdentity { get; set; }

    /// <summary>Specifies the Azure storage blob where script error stream will be uploaded.</summary>
    [JsonPropertyName("errorBlobUri")]
    public string? ErrorBlobUri { get; set; }

    /// <summary>Reference to a Blob in storage to populate errorBlobUri.</summary>
    [JsonPropertyName("errorBlobUriRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobUriRef? ErrorBlobUriRef { get; set; }

    /// <summary>Selector for a Blob in storage to populate errorBlobUri.</summary>
    [JsonPropertyName("errorBlobUriSelector")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderErrorBlobUriSelector? ErrorBlobUriSelector { get; set; }

    /// <summary>The Azure Region where the Virtual Machine Run Command should exist. Changing this forces a new Virtual Machine Run Command to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An output_blob_managed_identity block as defined below. User-assigned managed Identity that has access to outputBlobUri storage blob.</summary>
    [JsonPropertyName("outputBlobManagedIdentity")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobManagedIdentity? OutputBlobManagedIdentity { get; set; }

    /// <summary>Specifies the Azure storage blob where script output stream will be uploaded. It can be basic blob URI with SAS token.</summary>
    [JsonPropertyName("outputBlobUri")]
    public string? OutputBlobUri { get; set; }

    /// <summary>Reference to a Blob in storage to populate outputBlobUri.</summary>
    [JsonPropertyName("outputBlobUriRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobUriRef? OutputBlobUriRef { get; set; }

    /// <summary>Selector for a Blob in storage to populate outputBlobUri.</summary>
    [JsonPropertyName("outputBlobUriSelector")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderOutputBlobUriSelector? OutputBlobUriSelector { get; set; }

    /// <summary>A list of parameter blocks as defined below. The parameters used by the script.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1VirtualMachineRunCommandSpecInitProviderParameter>? Parameter { get; set; }

    /// <summary>A list of protected_parameter blocks as defined below. The protected parameters used by the script.</summary>
    [JsonPropertyName("protectedParameter")]
    public IList<V1beta1VirtualMachineRunCommandSpecInitProviderProtectedParameter>? ProtectedParameter { get; set; }

    /// <summary>Specifies the user account password on the VM when executing the Virtual Machine Run Command.</summary>
    [JsonPropertyName("runAsPasswordSecretRef")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderRunAsPasswordSecretRef? RunAsPasswordSecretRef { get; set; }

    /// <summary>Specifies the user account on the VM when executing the Virtual Machine Run Command.</summary>
    [JsonPropertyName("runAsUser")]
    public string? RunAsUser { get; set; }

    /// <summary>A source block as defined below. The source of the run command script.</summary>
    [JsonPropertyName("source")]
    public V1beta1VirtualMachineRunCommandSpecInitProviderSource? Source { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Virtual Machine Run Command.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>VirtualMachineRunCommandSpec defines the desired state of VirtualMachineRunCommand</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VirtualMachineRunCommandSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VirtualMachineRunCommandSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualMachineRunCommandSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualMachineRunCommandSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The client ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderErrorBlobManagedIdentityClientIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The object ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderErrorBlobManagedIdentityObjectIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An error_blob_managed_identity block as defined below. User-assigned managed Identity that has access to errorBlobUri storage blob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderErrorBlobManagedIdentity
{
    /// <summary>The client ID of the managed identity.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderErrorBlobManagedIdentityClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>The object ID of the managed identity.</summary>
    [JsonPropertyName("objectIdSecretRef")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderErrorBlobManagedIdentityObjectIdSecretRef? ObjectIdSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderInstanceView
{
    /// <summary></summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("executionMessage")]
    public string? ExecutionMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("executionState")]
    public string? ExecutionState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exitCode")]
    public double? ExitCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("output")]
    public string? Output { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The client ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderOutputBlobManagedIdentityClientIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The object ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderOutputBlobManagedIdentityObjectIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An output_blob_managed_identity block as defined below. User-assigned managed Identity that has access to outputBlobUri storage blob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderOutputBlobManagedIdentity
{
    /// <summary>The client ID of the managed identity.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderOutputBlobManagedIdentityClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>The object ID of the managed identity.</summary>
    [JsonPropertyName("objectIdSecretRef")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderOutputBlobManagedIdentityObjectIdSecretRef? ObjectIdSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderParameter
{
    /// <summary>The run parameter name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The run parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The run parameter name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderProtectedParameterNameSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The run parameter value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderProtectedParameterValueSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderProtectedParameter
{
    /// <summary>The run parameter name.</summary>
    [JsonPropertyName("nameSecretRef")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderProtectedParameterNameSecretRef? NameSecretRef { get; set; }

    /// <summary>The run parameter value.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderProtectedParameterValueSecretRef? ValueSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The client ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderSourceScriptUriManagedIdentityClientIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The object ID of the managed identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderSourceScriptUriManagedIdentityObjectIdSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A script_uri_managed_identity block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderSourceScriptUriManagedIdentity
{
    /// <summary>The client ID of the managed identity.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderSourceScriptUriManagedIdentityClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>The object ID of the managed identity.</summary>
    [JsonPropertyName("objectIdSecretRef")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderSourceScriptUriManagedIdentityObjectIdSecretRef? ObjectIdSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A source block as defined below. The source of the run command script.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProviderSource
{
    /// <summary></summary>
    [JsonPropertyName("commandId")]
    public string? CommandId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scriptUri")]
    public string? ScriptUri { get; set; }

    /// <summary>A script_uri_managed_identity block as defined above.</summary>
    [JsonPropertyName("scriptUriManagedIdentity")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderSourceScriptUriManagedIdentity? ScriptUriManagedIdentity { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusAtProvider
{
    /// <summary>An error_blob_managed_identity block as defined below. User-assigned managed Identity that has access to errorBlobUri storage blob.</summary>
    [JsonPropertyName("errorBlobManagedIdentity")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderErrorBlobManagedIdentity? ErrorBlobManagedIdentity { get; set; }

    /// <summary>Specifies the Azure storage blob where script error stream will be uploaded.</summary>
    [JsonPropertyName("errorBlobUri")]
    public string? ErrorBlobUri { get; set; }

    /// <summary>The ID of the Virtual Machine Run Command.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceView")]
    public IList<V1beta1VirtualMachineRunCommandStatusAtProviderInstanceView>? InstanceView { get; set; }

    /// <summary>The Azure Region where the Virtual Machine Run Command should exist. Changing this forces a new Virtual Machine Run Command to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An output_blob_managed_identity block as defined below. User-assigned managed Identity that has access to outputBlobUri storage blob.</summary>
    [JsonPropertyName("outputBlobManagedIdentity")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderOutputBlobManagedIdentity? OutputBlobManagedIdentity { get; set; }

    /// <summary>Specifies the Azure storage blob where script output stream will be uploaded. It can be basic blob URI with SAS token.</summary>
    [JsonPropertyName("outputBlobUri")]
    public string? OutputBlobUri { get; set; }

    /// <summary>A list of parameter blocks as defined below. The parameters used by the script.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1VirtualMachineRunCommandStatusAtProviderParameter>? Parameter { get; set; }

    /// <summary>A list of protected_parameter blocks as defined below. The protected parameters used by the script.</summary>
    [JsonPropertyName("protectedParameter")]
    public IList<V1beta1VirtualMachineRunCommandStatusAtProviderProtectedParameter>? ProtectedParameter { get; set; }

    /// <summary>Specifies the user account on the VM when executing the Virtual Machine Run Command.</summary>
    [JsonPropertyName("runAsUser")]
    public string? RunAsUser { get; set; }

    /// <summary>A source block as defined below. The source of the run command script.</summary>
    [JsonPropertyName("source")]
    public V1beta1VirtualMachineRunCommandStatusAtProviderSource? Source { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Virtual Machine Run Command.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the Virtual Machine ID within which this Virtual Machine Run Command should exist. Changing this forces a new Virtual Machine Run Command to be created.</summary>
    [JsonPropertyName("virtualMachineId")]
    public string? VirtualMachineId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatusConditions
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
#nullable disable

#nullable enable
/// <summary>VirtualMachineRunCommandStatus defines the observed state of VirtualMachineRunCommand.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineRunCommandStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualMachineRunCommandStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualMachineRunCommandStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>VirtualMachineRunCommand is the Schema for the VirtualMachineRunCommands API. Manages a Virtual Machine Run Command.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualMachineRunCommand : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualMachineRunCommandSpec>, IStatus<V1beta1VirtualMachineRunCommandStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualMachineRunCommand";
    public const string KubeGroup = "compute.azure.m.upbound.io";
    public const string KubePluralName = "virtualmachineruncommands";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualMachineRunCommandSpec defines the desired state of VirtualMachineRunCommand</summary>
    [JsonPropertyName("spec")]
    public V1beta1VirtualMachineRunCommandSpec Spec { get; set; }

    /// <summary>VirtualMachineRunCommandStatus defines the observed state of VirtualMachineRunCommand.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualMachineRunCommandStatus? Status { get; set; }
}
#nullable disable
