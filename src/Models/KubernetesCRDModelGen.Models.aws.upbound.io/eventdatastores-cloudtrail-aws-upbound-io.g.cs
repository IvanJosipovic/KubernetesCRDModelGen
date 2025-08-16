using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudtrail.aws.upbound.io;
/// <summary>EventDataStore is the Schema for the EventDataStores API. Provides a CloudTrail Event Data Store resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EventDataStoreList : IKubernetesObject<V1ListMeta>, IItems<V1beta1EventDataStore>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventDataStoreList";
    public const string KubeGroup = "cloudtrail.aws.upbound.io";
    public const string KubePluralName = "eventdatastores";
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
    public IList<V1beta1EventDataStore> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecForProviderAdvancedEventSelectorFieldSelector
{
    /// <summary>A list of values that includes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("endsWith")]
    public IList<string>? EndsWith { get; set; }

    /// <summary>A list of values that includes events that match the exact value of the event record field specified as the value of field. This is the only valid operator that you can use with the readOnly, eventCategory, and resources.type fields.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>Specifies a field in an event record on which to filter events to be logged. You can specify only the following values: readOnly, eventSource, eventName, eventCategory, resources.type, resources.ARN.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A list of values that excludes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEndsWith")]
    public IList<string>? NotEndsWith { get; set; }

    /// <summary>A list of values that excludes events that match the exact value of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }

    /// <summary>A list of values that excludes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notStartsWith")]
    public IList<string>? NotStartsWith { get; set; }

    /// <summary>A list of values that includes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("startsWith")]
    public IList<string>? StartsWith { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecForProviderAdvancedEventSelector
{
    /// <summary>Specifies the selector statements in an advanced event selector. Fields documented below.</summary>
    [JsonPropertyName("fieldSelector")]
    public IList<V1beta1EventDataStoreSpecForProviderAdvancedEventSelectorFieldSelector>? FieldSelector { get; set; }

    /// <summary>The name of the event data store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventDataStoreSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecForProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventDataStoreSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecForProvider
{
    /// <summary>The advanced event selectors to use to select the events for the data store. For more information about how to use advanced event selectors, see Log events by using advanced event selectors in the CloudTrail User Guide.</summary>
    [JsonPropertyName("advancedEventSelector")]
    public IList<V1beta1EventDataStoreSpecForProviderAdvancedEventSelector>? AdvancedEventSelector { get; set; }

    /// <summary>The billing mode for the event data store. The valid values are EXTENDABLE_RETENTION_PRICING and FIXED_RETENTION_PRICING. Defaults to EXTENDABLE_RETENTION_PRICING.</summary>
    [JsonPropertyName("billingMode")]
    public string? BillingMode { get; set; }

    /// <summary>Specifies the AWS KMS key ID to use to encrypt the events delivered by CloudTrail. The value can be an alias name prefixed by alias/, a fully specified ARN to an alias, a fully specified ARN to a key, or a globally unique identifier.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1EventDataStoreSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1EventDataStoreSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Specifies whether the event data store includes events from all regions, or only from the region in which the event data store is created. Default: true.</summary>
    [JsonPropertyName("multiRegionEnabled")]
    public bool? MultiRegionEnabled { get; set; }

    /// <summary>The name of the event data store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies whether an event data store collects events logged for an organization in AWS Organizations. Default: false.</summary>
    [JsonPropertyName("organizationEnabled")]
    public bool? OrganizationEnabled { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The retention period of the event data store, in days. You can set a retention period of up to 2555 days, the equivalent of seven years. Default: 2555.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }

    /// <summary>Specifies whether to stop ingesting new events into the event data store. If set to true, ingestion is suspended while maintaining the ability to query existing events. If set to false, ingestion is active.</summary>
    [JsonPropertyName("suspend")]
    public string? Suspend { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies whether termination protection is enabled for the event data store. If termination protection is enabled, you cannot delete the event data store until termination protection is disabled. Default: true.</summary>
    [JsonPropertyName("terminationProtectionEnabled")]
    public bool? TerminationProtectionEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecInitProviderAdvancedEventSelectorFieldSelector
{
    /// <summary>A list of values that includes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("endsWith")]
    public IList<string>? EndsWith { get; set; }

    /// <summary>A list of values that includes events that match the exact value of the event record field specified as the value of field. This is the only valid operator that you can use with the readOnly, eventCategory, and resources.type fields.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>Specifies a field in an event record on which to filter events to be logged. You can specify only the following values: readOnly, eventSource, eventName, eventCategory, resources.type, resources.ARN.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A list of values that excludes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEndsWith")]
    public IList<string>? NotEndsWith { get; set; }

    /// <summary>A list of values that excludes events that match the exact value of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }

    /// <summary>A list of values that excludes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notStartsWith")]
    public IList<string>? NotStartsWith { get; set; }

    /// <summary>A list of values that includes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("startsWith")]
    public IList<string>? StartsWith { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecInitProviderAdvancedEventSelector
{
    /// <summary>Specifies the selector statements in an advanced event selector. Fields documented below.</summary>
    [JsonPropertyName("fieldSelector")]
    public IList<V1beta1EventDataStoreSpecInitProviderAdvancedEventSelectorFieldSelector>? FieldSelector { get; set; }

    /// <summary>The name of the event data store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventDataStoreSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecInitProviderKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventDataStoreSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecInitProvider
{
    /// <summary>The advanced event selectors to use to select the events for the data store. For more information about how to use advanced event selectors, see Log events by using advanced event selectors in the CloudTrail User Guide.</summary>
    [JsonPropertyName("advancedEventSelector")]
    public IList<V1beta1EventDataStoreSpecInitProviderAdvancedEventSelector>? AdvancedEventSelector { get; set; }

    /// <summary>The billing mode for the event data store. The valid values are EXTENDABLE_RETENTION_PRICING and FIXED_RETENTION_PRICING. Defaults to EXTENDABLE_RETENTION_PRICING.</summary>
    [JsonPropertyName("billingMode")]
    public string? BillingMode { get; set; }

    /// <summary>Specifies the AWS KMS key ID to use to encrypt the events delivered by CloudTrail. The value can be an alias name prefixed by alias/, a fully specified ARN to an alias, a fully specified ARN to a key, or a globally unique identifier.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta1EventDataStoreSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta1EventDataStoreSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Specifies whether the event data store includes events from all regions, or only from the region in which the event data store is created. Default: true.</summary>
    [JsonPropertyName("multiRegionEnabled")]
    public bool? MultiRegionEnabled { get; set; }

    /// <summary>The name of the event data store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies whether an event data store collects events logged for an organization in AWS Organizations. Default: false.</summary>
    [JsonPropertyName("organizationEnabled")]
    public bool? OrganizationEnabled { get; set; }

    /// <summary>The retention period of the event data store, in days. You can set a retention period of up to 2555 days, the equivalent of seven years. Default: 2555.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }

    /// <summary>Specifies whether to stop ingesting new events into the event data store. If set to true, ingestion is suspended while maintaining the ability to query existing events. If set to false, ingestion is active.</summary>
    [JsonPropertyName("suspend")]
    public string? Suspend { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies whether termination protection is enabled for the event data store. If termination protection is enabled, you cannot delete the event data store until termination protection is disabled. Default: true.</summary>
    [JsonPropertyName("terminationProtectionEnabled")]
    public bool? TerminationProtectionEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecProviderConfigRefPolicy
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
public partial class V1beta1EventDataStoreSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EventDataStoreSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>EventDataStoreSpec defines the desired state of EventDataStore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EventDataStoreSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EventDataStoreSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EventDataStoreSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EventDataStoreSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreStatusAtProviderAdvancedEventSelectorFieldSelector
{
    /// <summary>A list of values that includes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("endsWith")]
    public IList<string>? EndsWith { get; set; }

    /// <summary>A list of values that includes events that match the exact value of the event record field specified as the value of field. This is the only valid operator that you can use with the readOnly, eventCategory, and resources.type fields.</summary>
    [JsonPropertyName("equals")]
    public IList<string>? Equals { get; set; }

    /// <summary>Specifies a field in an event record on which to filter events to be logged. You can specify only the following values: readOnly, eventSource, eventName, eventCategory, resources.type, resources.ARN.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>A list of values that excludes events that match the last few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEndsWith")]
    public IList<string>? NotEndsWith { get; set; }

    /// <summary>A list of values that excludes events that match the exact value of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notEquals")]
    public IList<string>? NotEquals { get; set; }

    /// <summary>A list of values that excludes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("notStartsWith")]
    public IList<string>? NotStartsWith { get; set; }

    /// <summary>A list of values that includes events that match the first few characters of the event record field specified as the value of field.</summary>
    [JsonPropertyName("startsWith")]
    public IList<string>? StartsWith { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreStatusAtProviderAdvancedEventSelector
{
    /// <summary>Specifies the selector statements in an advanced event selector. Fields documented below.</summary>
    [JsonPropertyName("fieldSelector")]
    public IList<V1beta1EventDataStoreStatusAtProviderAdvancedEventSelectorFieldSelector>? FieldSelector { get; set; }

    /// <summary>The name of the event data store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreStatusAtProvider
{
    /// <summary>The advanced event selectors to use to select the events for the data store. For more information about how to use advanced event selectors, see Log events by using advanced event selectors in the CloudTrail User Guide.</summary>
    [JsonPropertyName("advancedEventSelector")]
    public IList<V1beta1EventDataStoreStatusAtProviderAdvancedEventSelector>? AdvancedEventSelector { get; set; }

    /// <summary>ARN of the event data store.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The billing mode for the event data store. The valid values are EXTENDABLE_RETENTION_PRICING and FIXED_RETENTION_PRICING. Defaults to EXTENDABLE_RETENTION_PRICING.</summary>
    [JsonPropertyName("billingMode")]
    public string? BillingMode { get; set; }

    /// <summary>Name of the event data store.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the AWS KMS key ID to use to encrypt the events delivered by CloudTrail. The value can be an alias name prefixed by alias/, a fully specified ARN to an alias, a fully specified ARN to a key, or a globally unique identifier.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Specifies whether the event data store includes events from all regions, or only from the region in which the event data store is created. Default: true.</summary>
    [JsonPropertyName("multiRegionEnabled")]
    public bool? MultiRegionEnabled { get; set; }

    /// <summary>The name of the event data store.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies whether an event data store collects events logged for an organization in AWS Organizations. Default: false.</summary>
    [JsonPropertyName("organizationEnabled")]
    public bool? OrganizationEnabled { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The retention period of the event data store, in days. You can set a retention period of up to 2555 days, the equivalent of seven years. Default: 2555.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }

    /// <summary>Specifies whether to stop ingesting new events into the event data store. If set to true, ingestion is suspended while maintaining the ability to query existing events. If set to false, ingestion is active.</summary>
    [JsonPropertyName("suspend")]
    public string? Suspend { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Specifies whether termination protection is enabled for the event data store. If termination protection is enabled, you cannot delete the event data store until termination protection is disabled. Default: true.</summary>
    [JsonPropertyName("terminationProtectionEnabled")]
    public bool? TerminationProtectionEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreStatusConditions
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

/// <summary>EventDataStoreStatus defines the observed state of EventDataStore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventDataStoreStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EventDataStoreStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EventDataStoreStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>EventDataStore is the Schema for the EventDataStores API. Provides a CloudTrail Event Data Store resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EventDataStore : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EventDataStoreSpec>, IStatus<V1beta1EventDataStoreStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventDataStore";
    public const string KubeGroup = "cloudtrail.aws.upbound.io";
    public const string KubePluralName = "eventdatastores";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EventDataStoreSpec defines the desired state of EventDataStore</summary>
    [JsonPropertyName("spec")]
    public V1beta1EventDataStoreSpec Spec { get; set; }

    /// <summary>EventDataStoreStatus defines the observed state of EventDataStore.</summary>
    [JsonPropertyName("status")]
    public V1beta1EventDataStoreStatus? Status { get; set; }
}