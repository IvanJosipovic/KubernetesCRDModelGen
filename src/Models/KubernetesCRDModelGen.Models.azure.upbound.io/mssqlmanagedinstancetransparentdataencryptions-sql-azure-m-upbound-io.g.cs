using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.m.upbound.io;
#nullable enable
/// <summary>MSSQLManagedInstanceTransparentDataEncryption is the Schema for the MSSQLManagedInstanceTransparentDataEncryptions API. Manages the transparent data encryption configuration for a MSSQL Managed Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MSSQLManagedInstanceTransparentDataEncryption>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLManagedInstanceTransparentDataEncryptionList";
    public const string KubeGroup = "sql.azure.m.upbound.io";
    public const string KubePluralName = "mssqlmanagedinstancetransparentdataencryptions";
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
    public IList<V1beta1MSSQLManagedInstanceTransparentDataEncryption> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderKeyVaultKeyIdRefPolicy
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
/// <summary>Reference to a Key in keyvault to populate keyVaultKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderKeyVaultKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderKeyVaultKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderKeyVaultKeyIdSelectorPolicy
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
/// <summary>Selector for a Key in keyvault to populate keyVaultKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderKeyVaultKeyIdSelector
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
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderKeyVaultKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderManagedInstanceIdRefPolicy
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
/// <summary>Reference to a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderManagedInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderManagedInstanceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderManagedInstanceIdSelectorPolicy
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
/// <summary>Selector for a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderManagedInstanceIdSelector
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
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderManagedInstanceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProvider
{
    /// <summary>When enabled, the SQL Managed Instance will continuously check the key vault for any new versions of the key being used as the TDE protector. If a new version of the key is detected, the TDE protector on the SQL Managed Instance will be automatically rotated to the latest key version within 60 minutes.</summary>
    [JsonPropertyName("autoRotationEnabled")]
    public bool? AutoRotationEnabled { get; set; }

    /// <summary>To use customer managed keys from Azure Key Vault, provide the AKV Key ID. To use service managed keys, omit this field.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate keyVaultKeyId.</summary>
    [JsonPropertyName("keyVaultKeyIdRef")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderKeyVaultKeyIdRef? KeyVaultKeyIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate keyVaultKeyId.</summary>
    [JsonPropertyName("keyVaultKeyIdSelector")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderKeyVaultKeyIdSelector? KeyVaultKeyIdSelector { get; set; }

    /// <summary>To use customer managed keys from a managed HSM, provide the Managed HSM Key ID. To use service managed keys, omit this field.</summary>
    [JsonPropertyName("managedHsmKeyId")]
    public string? ManagedHsmKeyId { get; set; }

    /// <summary>Specifies the name of the MS SQL Managed Instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedInstanceId")]
    public string? ManagedInstanceId { get; set; }

    /// <summary>Reference to a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
    [JsonPropertyName("managedInstanceIdRef")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderManagedInstanceIdRef? ManagedInstanceIdRef { get; set; }

    /// <summary>Selector for a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
    [JsonPropertyName("managedInstanceIdSelector")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProviderManagedInstanceIdSelector? ManagedInstanceIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecInitProviderKeyVaultKeyIdRefPolicy
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
/// <summary>Reference to a Key in keyvault to populate keyVaultKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecInitProviderKeyVaultKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecInitProviderKeyVaultKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecInitProviderKeyVaultKeyIdSelectorPolicy
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
/// <summary>Selector for a Key in keyvault to populate keyVaultKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecInitProviderKeyVaultKeyIdSelector
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
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecInitProviderKeyVaultKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecInitProvider
{
    /// <summary>When enabled, the SQL Managed Instance will continuously check the key vault for any new versions of the key being used as the TDE protector. If a new version of the key is detected, the TDE protector on the SQL Managed Instance will be automatically rotated to the latest key version within 60 minutes.</summary>
    [JsonPropertyName("autoRotationEnabled")]
    public bool? AutoRotationEnabled { get; set; }

    /// <summary>To use customer managed keys from Azure Key Vault, provide the AKV Key ID. To use service managed keys, omit this field.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate keyVaultKeyId.</summary>
    [JsonPropertyName("keyVaultKeyIdRef")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecInitProviderKeyVaultKeyIdRef? KeyVaultKeyIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate keyVaultKeyId.</summary>
    [JsonPropertyName("keyVaultKeyIdSelector")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecInitProviderKeyVaultKeyIdSelector? KeyVaultKeyIdSelector { get; set; }

    /// <summary>To use customer managed keys from a managed HSM, provide the Managed HSM Key ID. To use service managed keys, omit this field.</summary>
    [JsonPropertyName("managedHsmKeyId")]
    public string? ManagedHsmKeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecProviderConfigRef
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
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MSSQLManagedInstanceTransparentDataEncryptionSpec defines the desired state of MSSQLManagedInstanceTransparentDataEncryption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionStatusAtProvider
{
    /// <summary>When enabled, the SQL Managed Instance will continuously check the key vault for any new versions of the key being used as the TDE protector. If a new version of the key is detected, the TDE protector on the SQL Managed Instance will be automatically rotated to the latest key version within 60 minutes.</summary>
    [JsonPropertyName("autoRotationEnabled")]
    public bool? AutoRotationEnabled { get; set; }

    /// <summary>The ID of the MSSQL encryption protector</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>To use customer managed keys from Azure Key Vault, provide the AKV Key ID. To use service managed keys, omit this field.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>To use customer managed keys from a managed HSM, provide the Managed HSM Key ID. To use service managed keys, omit this field.</summary>
    [JsonPropertyName("managedHsmKeyId")]
    public string? ManagedHsmKeyId { get; set; }

    /// <summary>Specifies the name of the MS SQL Managed Instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedInstanceId")]
    public string? ManagedInstanceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionStatusConditions
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
/// <summary>MSSQLManagedInstanceTransparentDataEncryptionStatus defines the observed state of MSSQLManagedInstanceTransparentDataEncryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryptionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MSSQLManagedInstanceTransparentDataEncryptionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MSSQLManagedInstanceTransparentDataEncryption is the Schema for the MSSQLManagedInstanceTransparentDataEncryptions API. Manages the transparent data encryption configuration for a MSSQL Managed Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLManagedInstanceTransparentDataEncryption : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpec>, IStatus<V1beta1MSSQLManagedInstanceTransparentDataEncryptionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLManagedInstanceTransparentDataEncryption";
    public const string KubeGroup = "sql.azure.m.upbound.io";
    public const string KubePluralName = "mssqlmanagedinstancetransparentdataencryptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MSSQLManagedInstanceTransparentDataEncryptionSpec defines the desired state of MSSQLManagedInstanceTransparentDataEncryption</summary>
    [JsonPropertyName("spec")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionSpec Spec { get; set; }

    /// <summary>MSSQLManagedInstanceTransparentDataEncryptionStatus defines the observed state of MSSQLManagedInstanceTransparentDataEncryption.</summary>
    [JsonPropertyName("status")]
    public V1beta1MSSQLManagedInstanceTransparentDataEncryptionStatus? Status { get; set; }
}
#nullable disable
