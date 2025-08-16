using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.gcp.m.upbound.io;
/// <summary>Organization is the Schema for the Organizations API. An</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OrganizationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Organization>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OrganizationList";
    public const string KubeGroup = "apigee.gcp.m.upbound.io";
    public const string KubePluralName = "organizations";
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
    public IList<V1beta1Organization> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProviderAuthorizedNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProviderAuthorizedNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrganizationSpecForProviderAuthorizedNetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProviderAuthorizedNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProviderAuthorizedNetworkSelector
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
    public V1beta1OrganizationSpecForProviderAuthorizedNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProviderPropertiesProperty
{
    /// <summary>Name of the property.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the property.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Properties defined in the Apigee organization profile. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProviderProperties
{
    /// <summary>List of all properties in the object. Structure is documented below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1OrganizationSpecForProviderPropertiesProperty>? Property { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProviderRuntimeDatabaseEncryptionKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate runtimeDatabaseEncryptionKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProviderRuntimeDatabaseEncryptionKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrganizationSpecForProviderRuntimeDatabaseEncryptionKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProviderRuntimeDatabaseEncryptionKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate runtimeDatabaseEncryptionKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProviderRuntimeDatabaseEncryptionKeyNameSelector
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
    public V1beta1OrganizationSpecForProviderRuntimeDatabaseEncryptionKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProvider
{
    /// <summary>Primary GCP region for analytics data storage. For valid values, see Create an Apigee organization.</summary>
    [JsonPropertyName("analyticsRegion")]
    public string? AnalyticsRegion { get; set; }

    /// <summary>Cloud KMS key name used for encrypting API consumer data.</summary>
    [JsonPropertyName("apiConsumerDataEncryptionKeyName")]
    public string? ApiConsumerDataEncryptionKeyName { get; set; }

    /// <summary>This field is needed only for customers using non-default data residency regions. Apigee stores some control plane data only in single region. This field determines which single region Apigee should use.</summary>
    [JsonPropertyName("apiConsumerDataLocation")]
    public string? ApiConsumerDataLocation { get; set; }

    /// <summary>Compute Engine network used for Service Networking to be peered with Apigee runtime instances. See Getting started with the Service Networking API. Valid only when RuntimeType is set to CLOUD. The value can be updated only when there are no runtime instances. For example: "default".</summary>
    [JsonPropertyName("authorizedNetwork")]
    public string? AuthorizedNetwork { get; set; }

    /// <summary>Reference to a Network in compute to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkRef")]
    public V1beta1OrganizationSpecForProviderAuthorizedNetworkRef? AuthorizedNetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkSelector")]
    public V1beta1OrganizationSpecForProviderAuthorizedNetworkSelector? AuthorizedNetworkSelector { get; set; }

    /// <summary>Billing type of the Apigee organization. See Apigee pricing.</summary>
    [JsonPropertyName("billingType")]
    public string? BillingType { get; set; }

    /// <summary>Cloud KMS key name used for encrypting control plane data that is stored in a multi region. Only used for the data residency region "US" or "EU".</summary>
    [JsonPropertyName("controlPlaneEncryptionKeyName")]
    public string? ControlPlaneEncryptionKeyName { get; set; }

    /// <summary>Description of the Apigee organization.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Flag that specifies whether the VPC Peering through Private Google Access should be disabled between the consumer network and Apigee. Required if an authorizedNetwork on the consumer project is not provided, in which case the flag should be set to true. Valid only when RuntimeType is set to CLOUD. The value must be set before the creation of any Apigee runtime instance and can be updated only when there are no runtime instances.</summary>
    [JsonPropertyName("disableVpcPeering")]
    public bool? DisableVpcPeering { get; set; }

    /// <summary>The display name of the Apigee organization.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The project ID associated with the Apigee organization.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Properties defined in the Apigee organization profile. Structure is documented below.</summary>
    [JsonPropertyName("properties")]
    public V1beta1OrganizationSpecForProviderProperties? Properties { get; set; }

    /// <summary>Optional. This setting is applicable only for organizations that are soft-deleted (i.e., BillingType is not EVALUATION). It controls how long Organization data will be retained after the initial delete operation completes. During this period, the Organization may be restored to its last known state. After this period, the Organization will no longer be able to be restored. Default value is DELETION_RETENTION_UNSPECIFIED. Possible values are: DELETION_RETENTION_UNSPECIFIED, MINIMUM.</summary>
    [JsonPropertyName("retention")]
    public string? Retention { get; set; }

    /// <summary>Cloud KMS key name used for encrypting the data that is stored and replicated across runtime instances. Update is not allowed after the organization is created. If not specified, a Google-Managed encryption key will be used. Valid only when RuntimeType is CLOUD. For example: projects/foo/locations/us/keyRings/bar/cryptoKeys/baz.</summary>
    [JsonPropertyName("runtimeDatabaseEncryptionKeyName")]
    public string? RuntimeDatabaseEncryptionKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate runtimeDatabaseEncryptionKeyName.</summary>
    [JsonPropertyName("runtimeDatabaseEncryptionKeyNameRef")]
    public V1beta1OrganizationSpecForProviderRuntimeDatabaseEncryptionKeyNameRef? RuntimeDatabaseEncryptionKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate runtimeDatabaseEncryptionKeyName.</summary>
    [JsonPropertyName("runtimeDatabaseEncryptionKeyNameSelector")]
    public V1beta1OrganizationSpecForProviderRuntimeDatabaseEncryptionKeyNameSelector? RuntimeDatabaseEncryptionKeyNameSelector { get; set; }

    /// <summary>Runtime type of the Apigee organization based on the Apigee subscription purchased. Default value is CLOUD. Possible values are: CLOUD, HYBRID.</summary>
    [JsonPropertyName("runtimeType")]
    public string? RuntimeType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecInitProviderAuthorizedNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecInitProviderAuthorizedNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrganizationSpecInitProviderAuthorizedNetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecInitProviderAuthorizedNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate authorizedNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecInitProviderAuthorizedNetworkSelector
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
    public V1beta1OrganizationSpecInitProviderAuthorizedNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecInitProviderPropertiesProperty
{
    /// <summary>Name of the property.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the property.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Properties defined in the Apigee organization profile. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecInitProviderProperties
{
    /// <summary>List of all properties in the object. Structure is documented below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1OrganizationSpecInitProviderPropertiesProperty>? Property { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecInitProviderRuntimeDatabaseEncryptionKeyNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate runtimeDatabaseEncryptionKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecInitProviderRuntimeDatabaseEncryptionKeyNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrganizationSpecInitProviderRuntimeDatabaseEncryptionKeyNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecInitProviderRuntimeDatabaseEncryptionKeyNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate runtimeDatabaseEncryptionKeyName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecInitProviderRuntimeDatabaseEncryptionKeyNameSelector
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
    public V1beta1OrganizationSpecInitProviderRuntimeDatabaseEncryptionKeyNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecInitProvider
{
    /// <summary>Primary GCP region for analytics data storage. For valid values, see Create an Apigee organization.</summary>
    [JsonPropertyName("analyticsRegion")]
    public string? AnalyticsRegion { get; set; }

    /// <summary>Cloud KMS key name used for encrypting API consumer data.</summary>
    [JsonPropertyName("apiConsumerDataEncryptionKeyName")]
    public string? ApiConsumerDataEncryptionKeyName { get; set; }

    /// <summary>This field is needed only for customers using non-default data residency regions. Apigee stores some control plane data only in single region. This field determines which single region Apigee should use.</summary>
    [JsonPropertyName("apiConsumerDataLocation")]
    public string? ApiConsumerDataLocation { get; set; }

    /// <summary>Compute Engine network used for Service Networking to be peered with Apigee runtime instances. See Getting started with the Service Networking API. Valid only when RuntimeType is set to CLOUD. The value can be updated only when there are no runtime instances. For example: "default".</summary>
    [JsonPropertyName("authorizedNetwork")]
    public string? AuthorizedNetwork { get; set; }

    /// <summary>Reference to a Network in compute to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkRef")]
    public V1beta1OrganizationSpecInitProviderAuthorizedNetworkRef? AuthorizedNetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate authorizedNetwork.</summary>
    [JsonPropertyName("authorizedNetworkSelector")]
    public V1beta1OrganizationSpecInitProviderAuthorizedNetworkSelector? AuthorizedNetworkSelector { get; set; }

    /// <summary>Billing type of the Apigee organization. See Apigee pricing.</summary>
    [JsonPropertyName("billingType")]
    public string? BillingType { get; set; }

    /// <summary>Cloud KMS key name used for encrypting control plane data that is stored in a multi region. Only used for the data residency region "US" or "EU".</summary>
    [JsonPropertyName("controlPlaneEncryptionKeyName")]
    public string? ControlPlaneEncryptionKeyName { get; set; }

    /// <summary>Description of the Apigee organization.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Flag that specifies whether the VPC Peering through Private Google Access should be disabled between the consumer network and Apigee. Required if an authorizedNetwork on the consumer project is not provided, in which case the flag should be set to true. Valid only when RuntimeType is set to CLOUD. The value must be set before the creation of any Apigee runtime instance and can be updated only when there are no runtime instances.</summary>
    [JsonPropertyName("disableVpcPeering")]
    public bool? DisableVpcPeering { get; set; }

    /// <summary>The display name of the Apigee organization.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The project ID associated with the Apigee organization.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Properties defined in the Apigee organization profile. Structure is documented below.</summary>
    [JsonPropertyName("properties")]
    public V1beta1OrganizationSpecInitProviderProperties? Properties { get; set; }

    /// <summary>Optional. This setting is applicable only for organizations that are soft-deleted (i.e., BillingType is not EVALUATION). It controls how long Organization data will be retained after the initial delete operation completes. During this period, the Organization may be restored to its last known state. After this period, the Organization will no longer be able to be restored. Default value is DELETION_RETENTION_UNSPECIFIED. Possible values are: DELETION_RETENTION_UNSPECIFIED, MINIMUM.</summary>
    [JsonPropertyName("retention")]
    public string? Retention { get; set; }

    /// <summary>Cloud KMS key name used for encrypting the data that is stored and replicated across runtime instances. Update is not allowed after the organization is created. If not specified, a Google-Managed encryption key will be used. Valid only when RuntimeType is CLOUD. For example: projects/foo/locations/us/keyRings/bar/cryptoKeys/baz.</summary>
    [JsonPropertyName("runtimeDatabaseEncryptionKeyName")]
    public string? RuntimeDatabaseEncryptionKeyName { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate runtimeDatabaseEncryptionKeyName.</summary>
    [JsonPropertyName("runtimeDatabaseEncryptionKeyNameRef")]
    public V1beta1OrganizationSpecInitProviderRuntimeDatabaseEncryptionKeyNameRef? RuntimeDatabaseEncryptionKeyNameRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate runtimeDatabaseEncryptionKeyName.</summary>
    [JsonPropertyName("runtimeDatabaseEncryptionKeyNameSelector")]
    public V1beta1OrganizationSpecInitProviderRuntimeDatabaseEncryptionKeyNameSelector? RuntimeDatabaseEncryptionKeyNameSelector { get; set; }

    /// <summary>Runtime type of the Apigee organization based on the Apigee subscription purchased. Default value is CLOUD. Possible values are: CLOUD, HYBRID.</summary>
    [JsonPropertyName("runtimeType")]
    public string? RuntimeType { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>OrganizationSpec defines the desired state of Organization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OrganizationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OrganizationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OrganizationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OrganizationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatusAtProviderPropertiesProperty
{
    /// <summary>Name of the property.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the property.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Properties defined in the Apigee organization profile. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatusAtProviderProperties
{
    /// <summary>List of all properties in the object. Structure is documented below.</summary>
    [JsonPropertyName("property")]
    public IList<V1beta1OrganizationStatusAtProviderPropertiesProperty>? Property { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatusAtProvider
{
    /// <summary>Primary GCP region for analytics data storage. For valid values, see Create an Apigee organization.</summary>
    [JsonPropertyName("analyticsRegion")]
    public string? AnalyticsRegion { get; set; }

    /// <summary>Cloud KMS key name used for encrypting API consumer data.</summary>
    [JsonPropertyName("apiConsumerDataEncryptionKeyName")]
    public string? ApiConsumerDataEncryptionKeyName { get; set; }

    /// <summary>This field is needed only for customers using non-default data residency regions. Apigee stores some control plane data only in single region. This field determines which single region Apigee should use.</summary>
    [JsonPropertyName("apiConsumerDataLocation")]
    public string? ApiConsumerDataLocation { get; set; }

    /// <summary>Output only. Project ID of the Apigee Tenant Project.</summary>
    [JsonPropertyName("apigeeProjectId")]
    public string? ApigeeProjectId { get; set; }

    /// <summary>Compute Engine network used for Service Networking to be peered with Apigee runtime instances. See Getting started with the Service Networking API. Valid only when RuntimeType is set to CLOUD. The value can be updated only when there are no runtime instances. For example: "default".</summary>
    [JsonPropertyName("authorizedNetwork")]
    public string? AuthorizedNetwork { get; set; }

    /// <summary>Billing type of the Apigee organization. See Apigee pricing.</summary>
    [JsonPropertyName("billingType")]
    public string? BillingType { get; set; }

    /// <summary>Output only. Base64-encoded public certificate for the root CA of the Apigee organization. Valid only when RuntimeType is CLOUD. A base64-encoded string.</summary>
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; set; }

    /// <summary>Cloud KMS key name used for encrypting control plane data that is stored in a multi region. Only used for the data residency region "US" or "EU".</summary>
    [JsonPropertyName("controlPlaneEncryptionKeyName")]
    public string? ControlPlaneEncryptionKeyName { get; set; }

    /// <summary>Description of the Apigee organization.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Flag that specifies whether the VPC Peering through Private Google Access should be disabled between the consumer network and Apigee. Required if an authorizedNetwork on the consumer project is not provided, in which case the flag should be set to true. Valid only when RuntimeType is set to CLOUD. The value must be set before the creation of any Apigee runtime instance and can be updated only when there are no runtime instances.</summary>
    [JsonPropertyName("disableVpcPeering")]
    public bool? DisableVpcPeering { get; set; }

    /// <summary>The display name of the Apigee organization.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>an identifier for the resource with format organizations/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Output only. Name of the Apigee organization.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The project ID associated with the Apigee organization.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Properties defined in the Apigee organization profile. Structure is documented below.</summary>
    [JsonPropertyName("properties")]
    public V1beta1OrganizationStatusAtProviderProperties? Properties { get; set; }

    /// <summary>Optional. This setting is applicable only for organizations that are soft-deleted (i.e., BillingType is not EVALUATION). It controls how long Organization data will be retained after the initial delete operation completes. During this period, the Organization may be restored to its last known state. After this period, the Organization will no longer be able to be restored. Default value is DELETION_RETENTION_UNSPECIFIED. Possible values are: DELETION_RETENTION_UNSPECIFIED, MINIMUM.</summary>
    [JsonPropertyName("retention")]
    public string? Retention { get; set; }

    /// <summary>Cloud KMS key name used for encrypting the data that is stored and replicated across runtime instances. Update is not allowed after the organization is created. If not specified, a Google-Managed encryption key will be used. Valid only when RuntimeType is CLOUD. For example: projects/foo/locations/us/keyRings/bar/cryptoKeys/baz.</summary>
    [JsonPropertyName("runtimeDatabaseEncryptionKeyName")]
    public string? RuntimeDatabaseEncryptionKeyName { get; set; }

    /// <summary>Runtime type of the Apigee organization based on the Apigee subscription purchased. Default value is CLOUD. Possible values are: CLOUD, HYBRID.</summary>
    [JsonPropertyName("runtimeType")]
    public string? RuntimeType { get; set; }

    /// <summary>Output only. Subscription type of the Apigee organization. Valid values include trial (free, limited, and for evaluation purposes only) or paid (full subscription has been purchased).</summary>
    [JsonPropertyName("subscriptionType")]
    public string? SubscriptionType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatusConditions
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

/// <summary>OrganizationStatus defines the observed state of Organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OrganizationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OrganizationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Organization is the Schema for the Organizations API. An</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Organization : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OrganizationSpec>, IStatus<V1beta1OrganizationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Organization";
    public const string KubeGroup = "apigee.gcp.m.upbound.io";
    public const string KubePluralName = "organizations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OrganizationSpec defines the desired state of Organization</summary>
    [JsonPropertyName("spec")]
    public V1beta1OrganizationSpec Spec { get; set; }

    /// <summary>OrganizationStatus defines the observed state of Organization.</summary>
    [JsonPropertyName("status")]
    public V1beta1OrganizationStatus? Status { get; set; }
}