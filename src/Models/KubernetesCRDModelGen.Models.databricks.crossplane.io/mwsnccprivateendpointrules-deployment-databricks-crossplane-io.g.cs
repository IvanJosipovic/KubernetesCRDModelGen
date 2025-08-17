using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deployment.databricks.crossplane.io;
#nullable enable
/// <summary>MwsNccPrivateEndpointRule is the Schema for the MwsNccPrivateEndpointRules API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsNccPrivateEndpointRuleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MwsNccPrivateEndpointRule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsNccPrivateEndpointRuleList";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsnccprivateendpointrules";
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
    public IList<V1alpha1MwsNccPrivateEndpointRule> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleSpecForProvider
{
    /// <summary></summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The current status of this private endpoint. The private endpoint rules are effective only if the connection state is ESTABLISHED. Remember that you must approve new endpoints on your resources in the Azure portal before they take effect. The possible values are:</summary>
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>Time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>Whether this private endpoint is deactivated.</summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary>Time in epoch milliseconds when this object was deactivated.</summary>
    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>(AWS only) Activation status. Only used by private endpoints towards an AWS S3 service. Update this field to activate/deactivate this private endpoint to allow egress access from serverless compute resources. Can only be updated after a private endpoint rule towards an AWS S3 service is successfully created.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Azure private endpoint resource, e.g. "databricks-088781b3-77fa-4132-b429-1af0d91bc593-pe-3cb31234"</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>(AWS only) Example com.amazonaws.vpce.us-east-1.vpce-svc-123abcc1298abc123. The full target AWS endpoint service name that connects to the destination resources of the private endpoint.</summary>
    [JsonPropertyName("endpointService")]
    public string? EndpointService { get; set; }

    /// <summary>(Azure only) Not used by customer-managed private endpoint services. The sub-resource type (group ID) of the target resource. Must be one of supported resource types (i.e., blob, dfs, sqlServer , etc. Consult the Azure documentation for full list of supported resources). Note that to connect to workspace root storage (root DBFS), you need two endpoints, one for blob and one for dfs. Change forces creation of a new resource. Conflicts with domain_names.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account. Change forces creation of a new resource.</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>(Azure only) The Azure resource ID of the target resource. Change forces creation of a new resource.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>the ID of a private endpoint rule.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>Time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }

    /// <summary>The AWS VPC endpoint ID. You can use this ID to identify the VPC endpoint created by Databricks.</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleSpecInitProvider
{
    /// <summary></summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The current status of this private endpoint. The private endpoint rules are effective only if the connection state is ESTABLISHED. Remember that you must approve new endpoints on your resources in the Azure portal before they take effect. The possible values are:</summary>
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>Time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>Whether this private endpoint is deactivated.</summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary>Time in epoch milliseconds when this object was deactivated.</summary>
    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>(AWS only) Activation status. Only used by private endpoints towards an AWS S3 service. Update this field to activate/deactivate this private endpoint to allow egress access from serverless compute resources. Can only be updated after a private endpoint rule towards an AWS S3 service is successfully created.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Azure private endpoint resource, e.g. "databricks-088781b3-77fa-4132-b429-1af0d91bc593-pe-3cb31234"</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>(AWS only) Example com.amazonaws.vpce.us-east-1.vpce-svc-123abcc1298abc123. The full target AWS endpoint service name that connects to the destination resources of the private endpoint.</summary>
    [JsonPropertyName("endpointService")]
    public string? EndpointService { get; set; }

    /// <summary>(Azure only) Not used by customer-managed private endpoint services. The sub-resource type (group ID) of the target resource. Must be one of supported resource types (i.e., blob, dfs, sqlServer , etc. Consult the Azure documentation for full list of supported resources). Note that to connect to workspace root storage (root DBFS), you need two endpoints, one for blob and one for dfs. Change forces creation of a new resource. Conflicts with domain_names.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account. Change forces creation of a new resource.</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>(Azure only) The Azure resource ID of the target resource. Change forces creation of a new resource.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>the ID of a private endpoint rule.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>Time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }

    /// <summary>The AWS VPC endpoint ID. You can use this ID to identify the VPC endpoint created by Databricks.</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleSpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsNccPrivateEndpointRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleSpecPublishConnectionDetailsToConfigRefPolicy
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
/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsNccPrivateEndpointRuleSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1MwsNccPrivateEndpointRuleSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1MwsNccPrivateEndpointRuleSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MwsNccPrivateEndpointRuleSpec defines the desired state of MwsNccPrivateEndpointRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1MwsNccPrivateEndpointRuleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1MwsNccPrivateEndpointRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1MwsNccPrivateEndpointRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1MwsNccPrivateEndpointRuleSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1MwsNccPrivateEndpointRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The current status of this private endpoint. The private endpoint rules are effective only if the connection state is ESTABLISHED. Remember that you must approve new endpoints on your resources in the Azure portal before they take effect. The possible values are:</summary>
    [JsonPropertyName("connectionState")]
    public string? ConnectionState { get; set; }

    /// <summary>Time in epoch milliseconds when this object was created.</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>Whether this private endpoint is deactivated.</summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }

    /// <summary>Time in epoch milliseconds when this object was deactivated.</summary>
    [JsonPropertyName("deactivatedAt")]
    public double? DeactivatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNames")]
    public IList<string>? DomainNames { get; set; }

    /// <summary>(AWS only) Activation status. Only used by private endpoints towards an AWS S3 service. Update this field to activate/deactivate this private endpoint to allow egress access from serverless compute resources. Can only be updated after a private endpoint rule towards an AWS S3 service is successfully created.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Azure private endpoint resource, e.g. "databricks-088781b3-77fa-4132-b429-1af0d91bc593-pe-3cb31234"</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>(AWS only) Example com.amazonaws.vpce.us-east-1.vpce-svc-123abcc1298abc123. The full target AWS endpoint service name that connects to the destination resources of the private endpoint.</summary>
    [JsonPropertyName("endpointService")]
    public string? EndpointService { get; set; }

    /// <summary>(Azure only) Not used by customer-managed private endpoint services. The sub-resource type (group ID) of the target resource. Must be one of supported resource types (i.e., blob, dfs, sqlServer , etc. Consult the Azure documentation for full list of supported resources). Note that to connect to workspace root storage (root DBFS), you need two endpoints, one for blob and one for dfs. Change forces creation of a new resource. Conflicts with domain_names.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Canonical unique identifier of Network Connectivity Config in Databricks Account. Change forces creation of a new resource.</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>(Azure only) The Azure resource ID of the target resource. Change forces creation of a new resource.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>the ID of a private endpoint rule.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>Time in epoch milliseconds when this object was updated.</summary>
    [JsonPropertyName("updatedTime")]
    public double? UpdatedTime { get; set; }

    /// <summary>The AWS VPC endpoint ID. You can use this ID to identify the VPC endpoint created by Databricks.</summary>
    [JsonPropertyName("vpcEndpointId")]
    public string? VpcEndpointId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleStatusConditions
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
/// <summary>MwsNccPrivateEndpointRuleStatus defines the observed state of MwsNccPrivateEndpointRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNccPrivateEndpointRuleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1MwsNccPrivateEndpointRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MwsNccPrivateEndpointRuleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MwsNccPrivateEndpointRule is the Schema for the MwsNccPrivateEndpointRules API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsNccPrivateEndpointRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MwsNccPrivateEndpointRuleSpec>, IStatus<V1alpha1MwsNccPrivateEndpointRuleStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsNccPrivateEndpointRule";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsnccprivateendpointrules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MwsNccPrivateEndpointRuleSpec defines the desired state of MwsNccPrivateEndpointRule</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MwsNccPrivateEndpointRuleSpec Spec { get; set; }

    /// <summary>MwsNccPrivateEndpointRuleStatus defines the observed state of MwsNccPrivateEndpointRule.</summary>
    [JsonPropertyName("status")]
    public V1alpha1MwsNccPrivateEndpointRuleStatus? Status { get; set; }
}
#nullable disable
