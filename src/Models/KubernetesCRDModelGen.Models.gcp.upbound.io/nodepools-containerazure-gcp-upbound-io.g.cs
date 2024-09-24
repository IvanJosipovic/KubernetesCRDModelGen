using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerazure.gcp.upbound.io;
public enum V1beta1NodePoolSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1NodePoolSpecForProviderAutoscaling
{
    /// <summary>Maximum number of nodes in the node pool. Must be >= min_node_count.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes in the node pool. Must be >= 1 and <= max_node_count.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

public enum V1beta1NodePoolSpecForProviderClusterRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NodePoolSpecForProviderClusterRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NodePoolSpecForProviderClusterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterRefPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecForProviderClusterRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterRefPolicyResolveEnum>))]
    public V1beta1NodePoolSpecForProviderClusterRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NodePoolSpecForProviderClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderClusterRefPolicy? Policy { get; set; }
}

public enum V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NodePoolSpecForProviderClusterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolveEnum>))]
    public V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NodePoolSpecForProviderClusterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderClusterSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1NodePoolSpecForProviderConfigProxyConfig
{
    /// <summary>The ARM ID the of the resource group containing proxy keyvault. Resource group ids are formatted as /subscriptions/<subscription-id>/resourceGroups/<resource-group-name></summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>The URL the of the proxy setting secret with its version. Secret ids are formatted as https:<key-vault-name>.vault.azure.net/secrets/<secret-name>/<secret-version>.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

public partial class V1beta1NodePoolSpecForProviderConfigRootVolume
{
    /// <summary>Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }
}

public partial class V1beta1NodePoolSpecForProviderConfigSshConfig
{
    /// <summary>The SSH public key data for VMs managed by Anthos. This accepts the authorized_keys file format used in OpenSSH according to the sshd(8) manual page.</summary>
    [JsonPropertyName("authorizedKey")]
    public string? AuthorizedKey { get; set; }
}

public partial class V1beta1NodePoolSpecForProviderConfig
{
    /// <summary>Optional. The initial labels assigned to nodes of this node pool. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
    [JsonPropertyName("proxyConfig")]
    public IList<V1beta1NodePoolSpecForProviderConfigProxyConfig>? ProxyConfig { get; set; }

    /// <summary>Optional. Configuration related to the root volume provisioned for each node pool machine. When unspecified, it defaults to a 32-GiB Azure Disk.</summary>
    [JsonPropertyName("rootVolume")]
    public IList<V1beta1NodePoolSpecForProviderConfigRootVolume>? RootVolume { get; set; }

    /// <summary>SSH configuration for how to access the node pool machines.</summary>
    [JsonPropertyName("sshConfig")]
    public IList<V1beta1NodePoolSpecForProviderConfigSshConfig>? SshConfig { get; set; }

    /// <summary>Optional. A set of tags to apply to all underlying Azure resources for this node pool. This currently only includes Virtual Machine Scale Sets. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Optional. The Azure VM size name. Example: Standard_DS2_v2. See (/anthos/clusters/docs/azure/reference/supported-vms) for options. When unspecified, it defaults to Standard_DS2_v2.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1NodePoolSpecForProviderManagement
{
    /// <summary>Optional. Whether or not the nodes will be automatically repaired.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }
}

public partial class V1beta1NodePoolSpecForProviderMaxPodsConstraint
{
    /// <summary>The maximum number of pods to schedule on a single node.</summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }
}

public partial class V1beta1NodePoolSpecForProvider
{
    /// <summary>Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Keys can have 2 segments: prefix  and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Autoscaler configuration for this node pool.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1NodePoolSpecForProviderAutoscaling>? Autoscaling { get; set; }

    /// <summary>Optional. The Azure availability zone of the nodes in this nodepool. When unspecified, it defaults to 1.</summary>
    [JsonPropertyName("azureAvailabilityZone")]
    public string? AzureAvailabilityZone { get; set; }

    /// <summary>The azureCluster for the resource</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in containerazure to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1NodePoolSpecForProviderClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in containerazure to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta1NodePoolSpecForProviderClusterSelector? ClusterSelector { get; set; }

    /// <summary>The node configuration of the node pool.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1NodePoolSpecForProviderConfig>? Config { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Management configuration for this node pool.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1NodePoolSpecForProviderManagement>? Management { get; set; }

    /// <summary>The constraint on the maximum number of pods that can be run simultaneously on a node in the node pool.</summary>
    [JsonPropertyName("maxPodsConstraint")]
    public IList<V1beta1NodePoolSpecForProviderMaxPodsConstraint>? MaxPodsConstraint { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The ARM ID of the subnet where the node pool VMs run. Make sure it's a subnet under the virtual network in the cluster configuration.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The Kubernetes version (e.g. 1.19.10-gke.1000) running on this node pool.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1NodePoolSpecInitProviderAutoscaling
{
    /// <summary>Maximum number of nodes in the node pool. Must be >= min_node_count.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes in the node pool. Must be >= 1 and <= max_node_count.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

public partial class V1beta1NodePoolSpecInitProviderConfigProxyConfig
{
    /// <summary>The ARM ID the of the resource group containing proxy keyvault. Resource group ids are formatted as /subscriptions/<subscription-id>/resourceGroups/<resource-group-name></summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>The URL the of the proxy setting secret with its version. Secret ids are formatted as https:<key-vault-name>.vault.azure.net/secrets/<secret-name>/<secret-version>.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

public partial class V1beta1NodePoolSpecInitProviderConfigRootVolume
{
    /// <summary>Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }
}

public partial class V1beta1NodePoolSpecInitProviderConfigSshConfig
{
    /// <summary>The SSH public key data for VMs managed by Anthos. This accepts the authorized_keys file format used in OpenSSH according to the sshd(8) manual page.</summary>
    [JsonPropertyName("authorizedKey")]
    public string? AuthorizedKey { get; set; }
}

public partial class V1beta1NodePoolSpecInitProviderConfig
{
    /// <summary>Optional. The initial labels assigned to nodes of this node pool. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
    [JsonPropertyName("proxyConfig")]
    public IList<V1beta1NodePoolSpecInitProviderConfigProxyConfig>? ProxyConfig { get; set; }

    /// <summary>Optional. Configuration related to the root volume provisioned for each node pool machine. When unspecified, it defaults to a 32-GiB Azure Disk.</summary>
    [JsonPropertyName("rootVolume")]
    public IList<V1beta1NodePoolSpecInitProviderConfigRootVolume>? RootVolume { get; set; }

    /// <summary>SSH configuration for how to access the node pool machines.</summary>
    [JsonPropertyName("sshConfig")]
    public IList<V1beta1NodePoolSpecInitProviderConfigSshConfig>? SshConfig { get; set; }

    /// <summary>Optional. A set of tags to apply to all underlying Azure resources for this node pool. This currently only includes Virtual Machine Scale Sets. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Optional. The Azure VM size name. Example: Standard_DS2_v2. See (/anthos/clusters/docs/azure/reference/supported-vms) for options. When unspecified, it defaults to Standard_DS2_v2.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1NodePoolSpecInitProviderManagement
{
    /// <summary>Optional. Whether or not the nodes will be automatically repaired.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }
}

public partial class V1beta1NodePoolSpecInitProviderMaxPodsConstraint
{
    /// <summary>The maximum number of pods to schedule on a single node.</summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }
}

public partial class V1beta1NodePoolSpecInitProvider
{
    /// <summary>Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Keys can have 2 segments: prefix  and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Autoscaler configuration for this node pool.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1NodePoolSpecInitProviderAutoscaling>? Autoscaling { get; set; }

    /// <summary>Optional. The Azure availability zone of the nodes in this nodepool. When unspecified, it defaults to 1.</summary>
    [JsonPropertyName("azureAvailabilityZone")]
    public string? AzureAvailabilityZone { get; set; }

    /// <summary>The node configuration of the node pool.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1NodePoolSpecInitProviderConfig>? Config { get; set; }

    /// <summary>The Management configuration for this node pool.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1NodePoolSpecInitProviderManagement>? Management { get; set; }

    /// <summary>The constraint on the maximum number of pods that can be run simultaneously on a node in the node pool.</summary>
    [JsonPropertyName("maxPodsConstraint")]
    public IList<V1beta1NodePoolSpecInitProviderMaxPodsConstraint>? MaxPodsConstraint { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The ARM ID of the subnet where the node pool VMs run. Make sure it's a subnet under the virtual network in the cluster configuration.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The Kubernetes version (e.g. 1.19.10-gke.1000) running on this node pool.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public enum V1beta1NodePoolSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1NodePoolSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NodePoolSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NodePoolSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1NodePoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NodePoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1NodePoolSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1NodePoolSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1NodePoolSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1NodePoolSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1NodePoolSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1NodePoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1NodePoolSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecDeletionPolicyEnum>))]
    public V1beta1NodePoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NodePoolSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NodePoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1NodePoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NodePoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1NodePoolSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NodePoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1NodePoolStatusAtProviderAutoscaling
{
    /// <summary>Maximum number of nodes in the node pool. Must be >= min_node_count.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes in the node pool. Must be >= 1 and <= max_node_count.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

public partial class V1beta1NodePoolStatusAtProviderConfigProxyConfig
{
    /// <summary>The ARM ID the of the resource group containing proxy keyvault. Resource group ids are formatted as /subscriptions/<subscription-id>/resourceGroups/<resource-group-name></summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>The URL the of the proxy setting secret with its version. Secret ids are formatted as https:<key-vault-name>.vault.azure.net/secrets/<secret-name>/<secret-version>.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

public partial class V1beta1NodePoolStatusAtProviderConfigRootVolume
{
    /// <summary>Optional. The size of the disk, in GiBs. When unspecified, a default value is provided. See the specific reference in the parent resource.</summary>
    [JsonPropertyName("sizeGib")]
    public double? SizeGib { get; set; }
}

public partial class V1beta1NodePoolStatusAtProviderConfigSshConfig
{
    /// <summary>The SSH public key data for VMs managed by Anthos. This accepts the authorized_keys file format used in OpenSSH according to the sshd(8) manual page.</summary>
    [JsonPropertyName("authorizedKey")]
    public string? AuthorizedKey { get; set; }
}

public partial class V1beta1NodePoolStatusAtProviderConfig
{
    /// <summary>Optional. The initial labels assigned to nodes of this node pool. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Proxy configuration for outbound HTTP(S) traffic.</summary>
    [JsonPropertyName("proxyConfig")]
    public IList<V1beta1NodePoolStatusAtProviderConfigProxyConfig>? ProxyConfig { get; set; }

    /// <summary>Optional. Configuration related to the root volume provisioned for each node pool machine. When unspecified, it defaults to a 32-GiB Azure Disk.</summary>
    [JsonPropertyName("rootVolume")]
    public IList<V1beta1NodePoolStatusAtProviderConfigRootVolume>? RootVolume { get; set; }

    /// <summary>SSH configuration for how to access the node pool machines.</summary>
    [JsonPropertyName("sshConfig")]
    public IList<V1beta1NodePoolStatusAtProviderConfigSshConfig>? SshConfig { get; set; }

    /// <summary>Optional. A set of tags to apply to all underlying Azure resources for this node pool. This currently only includes Virtual Machine Scale Sets. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Optional. The Azure VM size name. Example: Standard_DS2_v2. See (/anthos/clusters/docs/azure/reference/supported-vms) for options. When unspecified, it defaults to Standard_DS2_v2.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

public partial class V1beta1NodePoolStatusAtProviderManagement
{
    /// <summary>Optional. Whether or not the nodes will be automatically repaired.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }
}

public partial class V1beta1NodePoolStatusAtProviderMaxPodsConstraint
{
    /// <summary>The maximum number of pods to schedule on a single node.</summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }
}

public partial class V1beta1NodePoolStatusAtProvider
{
    /// <summary>Optional. Annotations on the node pool. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Keys can have 2 segments: prefix  and name , separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Autoscaler configuration for this node pool.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1NodePoolStatusAtProviderAutoscaling>? Autoscaling { get; set; }

    /// <summary>Optional. The Azure availability zone of the nodes in this nodepool. When unspecified, it defaults to 1.</summary>
    [JsonPropertyName("azureAvailabilityZone")]
    public string? AzureAvailabilityZone { get; set; }

    /// <summary>The azureCluster for the resource</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>The node configuration of the node pool.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1NodePoolStatusAtProviderConfig>? Config { get; set; }

    /// <summary>Output only. The time at which this node pool was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary>Allows clients to perform consistent read-modify-writes through optimistic concurrency control. May be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/azureClusters/{{cluster}}/azureNodePools/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Management configuration for this node pool.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1NodePoolStatusAtProviderManagement>? Management { get; set; }

    /// <summary>The constraint on the maximum number of pods that can be run simultaneously on a node in the node pool.</summary>
    [JsonPropertyName("maxPodsConstraint")]
    public IList<V1beta1NodePoolStatusAtProviderMaxPodsConstraint>? MaxPodsConstraint { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Output only. If set, there are currently pending changes to the node pool.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The current state of the node pool. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The ARM ID of the subnet where the node pool VMs run. Make sure it's a subnet under the virtual network in the cluster configuration.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Output only. A globally unique identifier for the node pool.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time at which this node pool was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>The Kubernetes version (e.g. 1.19.10-gke.1000) running on this node pool.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1NodePoolStatusConditions
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

public partial class V1beta1NodePoolStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NodePoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NodePoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NodePoolSpec>, IStatus<V1beta1NodePoolStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodePool";
    public const string KubeGroup = "containerazure.gcp.upbound.io";
    public const string KubePluralName = "nodepools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NodePoolSpec defines the desired state of NodePool</summary>
    [JsonPropertyName("spec")]
    public V1beta1NodePoolSpec Spec { get; set; }

    /// <summary>NodePoolStatus defines the observed state of NodePool.</summary>
    [JsonPropertyName("status")]
    public V1beta1NodePoolStatus? Status { get; set; }
}