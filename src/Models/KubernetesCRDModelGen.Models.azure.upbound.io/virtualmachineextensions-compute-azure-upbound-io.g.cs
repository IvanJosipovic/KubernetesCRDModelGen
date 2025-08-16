using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.upbound.io;
/// <summary>VirtualMachineExtension is the Schema for the VirtualMachineExtensions API. Manages a Virtual Machine Extension to provide post deployment configuration and run automated tasks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualMachineExtensionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VirtualMachineExtension>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualMachineExtensionList";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "virtualmachineextensions";
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
    public IList<V1beta1VirtualMachineExtension> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpecForProviderProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>The protected_settings passed to the extension, like settings, these are specified as a JSON object in a string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpecForProviderProtectedSettingsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpecForProviderVirtualMachineIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpecForProviderVirtualMachineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineExtensionSpecForProviderVirtualMachineIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpecForProviderVirtualMachineIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpecForProviderVirtualMachineIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineExtensionSpecForProviderVirtualMachineIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpecForProvider
{
    /// <summary>Specifies if the platform deploys the latest minor version update to the type_handler_version specified.</summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>Should the Extension be automatically updated whenever the Publisher releases a new version of this VM Extension?</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>Should failures from the extension be suppressed? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("failureSuppressionEnabled")]
    public bool? FailureSuppressionEnabled { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public IList<V1beta1VirtualMachineExtensionSpecForProviderProtectedSettingsFromKeyVault>? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>The protected_settings passed to the extension, like settings, these are specified as a JSON object in a string.</summary>
    [JsonPropertyName("protectedSettingsSecretRef")]
    public V1beta1VirtualMachineExtensionSpecForProviderProtectedSettingsSecretRef? ProtectedSettingsSecretRef { get; set; }

    /// <summary>Specifies the collection of extension names after which this extension needs to be provisioned.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>The publisher of the extension, available publishers can be found by using the Azure CLI. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>The settings passed to the extension, these are specified as a JSON object in a string.</summary>
    [JsonPropertyName("settings")]
    public string? Settings { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of extension, available types for a publisher can be found using the Azure CLI.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the version of the extension to use, available versions can be found using the Azure CLI.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }

    /// <summary>The ID of the Virtual Machine. Changing this forces a new resource to be created</summary>
    [JsonPropertyName("virtualMachineId")]
    public string? VirtualMachineId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdRef")]
    public V1beta1VirtualMachineExtensionSpecForProviderVirtualMachineIdRef? VirtualMachineIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachine in compute to populate virtualMachineId.</summary>
    [JsonPropertyName("virtualMachineIdSelector")]
    public V1beta1VirtualMachineExtensionSpecForProviderVirtualMachineIdSelector? VirtualMachineIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpecInitProviderProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpecInitProvider
{
    /// <summary>Specifies if the platform deploys the latest minor version update to the type_handler_version specified.</summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>Should the Extension be automatically updated whenever the Publisher releases a new version of this VM Extension?</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>Should failures from the extension be suppressed? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("failureSuppressionEnabled")]
    public bool? FailureSuppressionEnabled { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public IList<V1beta1VirtualMachineExtensionSpecInitProviderProtectedSettingsFromKeyVault>? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>Specifies the collection of extension names after which this extension needs to be provisioned.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>The publisher of the extension, available publishers can be found by using the Azure CLI. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>The settings passed to the extension, these are specified as a JSON object in a string.</summary>
    [JsonPropertyName("settings")]
    public string? Settings { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of extension, available types for a publisher can be found using the Azure CLI.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the version of the extension to use, available versions can be found using the Azure CLI.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpecProviderConfigRefPolicy
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
public partial class V1beta1VirtualMachineExtensionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualMachineExtensionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VirtualMachineExtensionSpec defines the desired state of VirtualMachineExtension</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VirtualMachineExtensionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VirtualMachineExtensionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualMachineExtensionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualMachineExtensionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionStatusAtProviderProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionStatusAtProvider
{
    /// <summary>Specifies if the platform deploys the latest minor version update to the type_handler_version specified.</summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>Should the Extension be automatically updated whenever the Publisher releases a new version of this VM Extension?</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>Should failures from the extension be suppressed? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("failureSuppressionEnabled")]
    public bool? FailureSuppressionEnabled { get; set; }

    /// <summary>The ID of the Virtual Machine Extension.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public IList<V1beta1VirtualMachineExtensionStatusAtProviderProtectedSettingsFromKeyVault>? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>Specifies the collection of extension names after which this extension needs to be provisioned.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>The publisher of the extension, available publishers can be found by using the Azure CLI. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>The settings passed to the extension, these are specified as a JSON object in a string.</summary>
    [JsonPropertyName("settings")]
    public string? Settings { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of extension, available types for a publisher can be found using the Azure CLI.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the version of the extension to use, available versions can be found using the Azure CLI.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }

    /// <summary>The ID of the Virtual Machine. Changing this forces a new resource to be created</summary>
    [JsonPropertyName("virtualMachineId")]
    public string? VirtualMachineId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionStatusConditions
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

/// <summary>VirtualMachineExtensionStatus defines the observed state of VirtualMachineExtension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualMachineExtensionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualMachineExtensionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualMachineExtensionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VirtualMachineExtension is the Schema for the VirtualMachineExtensions API. Manages a Virtual Machine Extension to provide post deployment configuration and run automated tasks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualMachineExtension : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualMachineExtensionSpec>, IStatus<V1beta1VirtualMachineExtensionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualMachineExtension";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "virtualmachineextensions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualMachineExtensionSpec defines the desired state of VirtualMachineExtension</summary>
    [JsonPropertyName("spec")]
    public V1beta1VirtualMachineExtensionSpec Spec { get; set; }

    /// <summary>VirtualMachineExtensionStatus defines the observed state of VirtualMachineExtension.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualMachineExtensionStatus? Status { get; set; }
}