using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deployment.databricks.crossplane.io;
/// <summary>Account Id that could be found in the top right corner of Accounts Console</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecForProviderAccountIdSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecForProviderErrorMessages
{
    /// <summary></summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorType")]
    public string? ErrorType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecForProviderGcpNetworkInfo
{
    /// <summary>The Google Cloud project ID of the VPC network.</summary>
    [JsonPropertyName("networkProjectId")]
    public string? NetworkProjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podIpRangeName")]
    public string? PodIpRangeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceIpRangeName")]
    public string? ServiceIpRangeName { get; set; }

    /// <summary>The ID of the subnet associated with this network.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The Google Cloud region of the workspace data plane. For example, us-east4.</summary>
    [JsonPropertyName("subnetRegion")]
    public string? SubnetRegion { get; set; }

    /// <summary>(AWS only) aws_vpc id</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecForProviderVpcEndpoints
{
    /// <summary></summary>
    [JsonPropertyName("dataplaneRelay")]
    public IList<string>? DataplaneRelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restApi")]
    public IList<string>? RestApi { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecForProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console</summary>
    [JsonPropertyName("accountIdSecretRef")]
    public V1alpha1MwsNetworksSpecForProviderAccountIdSecretRef? AccountIdSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorMessages")]
    public IList<V1alpha1MwsNetworksSpecForProviderErrorMessages>? ErrorMessages { get; set; }

    /// <summary>(GCP only) a block consists of Google Cloud specific information for this network, for example the VPC ID, subnet ID, and secondary IP ranges. It has the following fields:</summary>
    [JsonPropertyName("gcpNetworkInfo")]
    public IList<V1alpha1MwsNetworksSpecForProviderGcpNetworkInfo>? GcpNetworkInfo { get; set; }

    /// <summary>(String) id of network to be used for databricks_mws_workspaces resource.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>name under which this network is registered</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    /// <summary>(AWS only) ids of aws_security_group</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>(AWS only) ids of aws_subnet</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>mapping of databricks_mws_vpc_endpoint for PrivateLink or Private Service Connect connections</summary>
    [JsonPropertyName("vpcEndpoints")]
    public IList<V1alpha1MwsNetworksSpecForProviderVpcEndpoints>? VpcEndpoints { get; set; }

    /// <summary>(AWS only) aws_vpc id</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>(String) VPC attachment status</summary>
    [JsonPropertyName("vpcStatus")]
    public string? VpcStatus { get; set; }

    /// <summary>(Integer) id of associated workspace</summary>
    [JsonPropertyName("workspaceId")]
    public double? WorkspaceId { get; set; }
}

/// <summary>Account Id that could be found in the top right corner of Accounts Console</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecInitProviderAccountIdSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecInitProviderErrorMessages
{
    /// <summary></summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorType")]
    public string? ErrorType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecInitProviderGcpNetworkInfo
{
    /// <summary>The Google Cloud project ID of the VPC network.</summary>
    [JsonPropertyName("networkProjectId")]
    public string? NetworkProjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podIpRangeName")]
    public string? PodIpRangeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceIpRangeName")]
    public string? ServiceIpRangeName { get; set; }

    /// <summary>The ID of the subnet associated with this network.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The Google Cloud region of the workspace data plane. For example, us-east4.</summary>
    [JsonPropertyName("subnetRegion")]
    public string? SubnetRegion { get; set; }

    /// <summary>(AWS only) aws_vpc id</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecInitProviderVpcEndpoints
{
    /// <summary></summary>
    [JsonPropertyName("dataplaneRelay")]
    public IList<string>? DataplaneRelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restApi")]
    public IList<string>? RestApi { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecInitProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console</summary>
    [JsonPropertyName("accountIdSecretRef")]
    public V1alpha1MwsNetworksSpecInitProviderAccountIdSecretRef AccountIdSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorMessages")]
    public IList<V1alpha1MwsNetworksSpecInitProviderErrorMessages>? ErrorMessages { get; set; }

    /// <summary>(GCP only) a block consists of Google Cloud specific information for this network, for example the VPC ID, subnet ID, and secondary IP ranges. It has the following fields:</summary>
    [JsonPropertyName("gcpNetworkInfo")]
    public IList<V1alpha1MwsNetworksSpecInitProviderGcpNetworkInfo>? GcpNetworkInfo { get; set; }

    /// <summary>(String) id of network to be used for databricks_mws_workspaces resource.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>name under which this network is registered</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    /// <summary>(AWS only) ids of aws_security_group</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>(AWS only) ids of aws_subnet</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>mapping of databricks_mws_vpc_endpoint for PrivateLink or Private Service Connect connections</summary>
    [JsonPropertyName("vpcEndpoints")]
    public IList<V1alpha1MwsNetworksSpecInitProviderVpcEndpoints>? VpcEndpoints { get; set; }

    /// <summary>(AWS only) aws_vpc id</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>(String) VPC attachment status</summary>
    [JsonPropertyName("vpcStatus")]
    public string? VpcStatus { get; set; }

    /// <summary>(Integer) id of associated workspace</summary>
    [JsonPropertyName("workspaceId")]
    public double? WorkspaceId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecProviderConfigRefPolicy
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
public partial class V1alpha1MwsNetworksSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsNetworksSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsNetworksSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1MwsNetworksSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1MwsNetworksSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MwsNetworksSpec defines the desired state of MwsNetworks</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1MwsNetworksSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1MwsNetworksSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1MwsNetworksSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1MwsNetworksSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1MwsNetworksSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksStatusAtProviderErrorMessages
{
    /// <summary></summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorType")]
    public string? ErrorType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksStatusAtProviderGcpNetworkInfo
{
    /// <summary>The Google Cloud project ID of the VPC network.</summary>
    [JsonPropertyName("networkProjectId")]
    public string? NetworkProjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podIpRangeName")]
    public string? PodIpRangeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceIpRangeName")]
    public string? ServiceIpRangeName { get; set; }

    /// <summary>The ID of the subnet associated with this network.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The Google Cloud region of the workspace data plane. For example, us-east4.</summary>
    [JsonPropertyName("subnetRegion")]
    public string? SubnetRegion { get; set; }

    /// <summary>(AWS only) aws_vpc id</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksStatusAtProviderVpcEndpoints
{
    /// <summary></summary>
    [JsonPropertyName("dataplaneRelay")]
    public IList<string>? DataplaneRelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restApi")]
    public IList<string>? RestApi { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorMessages")]
    public IList<V1alpha1MwsNetworksStatusAtProviderErrorMessages>? ErrorMessages { get; set; }

    /// <summary>(GCP only) a block consists of Google Cloud specific information for this network, for example the VPC ID, subnet ID, and secondary IP ranges. It has the following fields:</summary>
    [JsonPropertyName("gcpNetworkInfo")]
    public IList<V1alpha1MwsNetworksStatusAtProviderGcpNetworkInfo>? GcpNetworkInfo { get; set; }

    /// <summary>Canonical unique identifier for the mws networks.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>(String) id of network to be used for databricks_mws_workspaces resource.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>name under which this network is registered</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    /// <summary>(AWS only) ids of aws_security_group</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>(AWS only) ids of aws_subnet</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>mapping of databricks_mws_vpc_endpoint for PrivateLink or Private Service Connect connections</summary>
    [JsonPropertyName("vpcEndpoints")]
    public IList<V1alpha1MwsNetworksStatusAtProviderVpcEndpoints>? VpcEndpoints { get; set; }

    /// <summary>(AWS only) aws_vpc id</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }

    /// <summary>(String) VPC attachment status</summary>
    [JsonPropertyName("vpcStatus")]
    public string? VpcStatus { get; set; }

    /// <summary>(Integer) id of associated workspace</summary>
    [JsonPropertyName("workspaceId")]
    public double? WorkspaceId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksStatusConditions
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

/// <summary>MwsNetworksStatus defines the observed state of MwsNetworks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsNetworksStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1MwsNetworksStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MwsNetworksStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MwsNetworks is the Schema for the MwsNetworkss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsNetworks : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MwsNetworksSpec>, IStatus<V1alpha1MwsNetworksStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsNetworks";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsnetworks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MwsNetworksSpec defines the desired state of MwsNetworks</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MwsNetworksSpec Spec { get; set; }

    /// <summary>MwsNetworksStatus defines the observed state of MwsNetworks.</summary>
    [JsonPropertyName("status")]
    public V1alpha1MwsNetworksStatus? Status { get; set; }
}

/// <summary>MwsNetworks is the Schema for the MwsNetworkss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsNetworksList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MwsNetworks>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsNetworksList";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsnetworks";
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
    public IList<V1alpha1MwsNetworks> Items { get; set; }
}