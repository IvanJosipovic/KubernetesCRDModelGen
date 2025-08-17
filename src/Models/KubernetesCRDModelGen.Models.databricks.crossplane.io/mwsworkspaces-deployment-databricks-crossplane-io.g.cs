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
/// <summary>MwsWorkspaces is the Schema for the MwsWorkspacess API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsWorkspacesList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MwsWorkspaces>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsWorkspacesList";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsworkspaces";
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
    public IList<V1alpha1MwsWorkspaces> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecForProviderAccountIdSecretRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecForProviderCloudResourceContainerGcp
{
    /// <summary>The Google Cloud project ID, which the workspace uses to instantiate cloud resources for your workspace.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecForProviderCloudResourceContainer
{
    /// <summary>A block that consists of the following field:</summary>
    [JsonPropertyName("gcp")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderCloudResourceContainerGcp>? Gcp { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecForProviderExternalCustomerInfo
{
    /// <summary></summary>
    [JsonPropertyName("authoritativeUserEmail")]
    public string? AuthoritativeUserEmail { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authoritativeUserFullName")]
    public string? AuthoritativeUserFullName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecForProviderGcpManagedNetworkConfig
{
    /// <summary></summary>
    [JsonPropertyName("gkeClusterPodIpRange")]
    public string? GkeClusterPodIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gkeClusterServiceIpRange")]
    public string? GkeClusterServiceIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecForProviderGkeConfig
{
    /// <summary></summary>
    [JsonPropertyName("connectivityType")]
    public string? ConnectivityType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("masterIpRange")]
    public string? MasterIpRange { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecForProviderTokenTokenValueSecretRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecForProviderToken
{
    /// <summary>Comment, that will appear in "User Settings / Access Tokens" page on Workspace UI.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Token expiry lifetime. By default its 2592000 (30 days).</summary>
    [JsonPropertyName("lifetimeSeconds")]
    public double? LifetimeSeconds { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("tokenId")]
    public string? TokenId { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("tokenValueSecretRef")]
    public V1alpha1MwsWorkspacesSpecForProviderTokenTokenValueSecretRef? TokenValueSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecForProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountIdSecretRef")]
    public V1alpha1MwsWorkspacesSpecForProviderAccountIdSecretRef? AccountIdSecretRef { get; set; }

    /// <summary>(AWS only) region of VPC.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloud")]
    public string? Cloud { get; set; }

    /// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
    [JsonPropertyName("cloudResourceContainer")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderCloudResourceContainer>? CloudResourceContainer { get; set; }

    /// <summary>- The compute mode for the workspace. When unset, a classic workspace is created, and both credentials_id and storage_configuration_id must be specified. When set to SERVERLESS, the resulting workspace is a serverless workspace, and credentials_id and storage_configuration_id must not be set. The only allowed value for this is SERVERLESS. Changing this field requires recreation of the workspace.</summary>
    [JsonPropertyName("computeMode")]
    public string? ComputeMode { get; set; }

    /// <summary>(Integer) time when workspace was created</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(AWS only, Optional) credentials_id from credentials. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>- The custom tags key-value pairing that is attached to this workspace. These tags will be applied to clusters automatically in addition to any default_tags or custom_tags on a cluster level. Please note it can take up to an hour for custom_tags to be set due to scheduling on Control Plane. After custom tags are applied, they can be modified however they can never be completely removed.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>part of URL as in https://&lt;prefix&gt;-&lt;deployment-name&gt;.cloud.databricks.com. Deployment name cannot be used until a deployment name prefix is defined. Please contact your Databricks representative. Once a new deployment prefix is added/updated, it only will affect the new workspaces created.</summary>
    [JsonPropertyName("deploymentName")]
    public string? DeploymentName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("externalCustomerInfo")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderExternalCustomerInfo>? ExternalCustomerInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpManagedNetworkConfig")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderGcpManagedNetworkConfig>? GcpManagedNetworkConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gkeConfig")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderGkeConfig>? GkeConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isNoPublicIpEnabled")]
    public bool? IsNoPublicIpEnabled { get; set; }

    /// <summary>(GCP only) region of the subnet.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to MANAGED_SERVICES. This is used to encrypt the workspace's notebook and secret data in the control plane.</summary>
    [JsonPropertyName("managedServicesCustomerManagedKeyId")]
    public string? ManagedServicesCustomerManagedKeyId { get; set; }

    /// <summary>network_id from networks.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>- The pricing tier of the workspace.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>Canonical unique identifier of databricks_mws_private_access_settings in Databricks Account.</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>(AWS only, Optional) storage_configuration_id from storage configuration. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to STORAGE. This is used to encrypt the DBFS Storage &amp; Cluster Volumes.</summary>
    [JsonPropertyName("storageCustomerManagedKeyId")]
    public string? StorageCustomerManagedKeyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("token")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderToken>? Token { get; set; }

    /// <summary>(String) workspace id</summary>
    [JsonPropertyName("workspaceId")]
    public double? WorkspaceId { get; set; }

    /// <summary>name of the workspace, will appear on UI.</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }

    /// <summary>(String) workspace status</summary>
    [JsonPropertyName("workspaceStatus")]
    public string? WorkspaceStatus { get; set; }

    /// <summary>(String) updates on workspace status</summary>
    [JsonPropertyName("workspaceStatusMessage")]
    public string? WorkspaceStatusMessage { get; set; }

    /// <summary>(String) URL of the workspace</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecInitProviderAccountIdSecretRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecInitProviderCloudResourceContainerGcp
{
    /// <summary>The Google Cloud project ID, which the workspace uses to instantiate cloud resources for your workspace.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecInitProviderCloudResourceContainer
{
    /// <summary>A block that consists of the following field:</summary>
    [JsonPropertyName("gcp")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderCloudResourceContainerGcp>? Gcp { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecInitProviderExternalCustomerInfo
{
    /// <summary></summary>
    [JsonPropertyName("authoritativeUserEmail")]
    public string? AuthoritativeUserEmail { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authoritativeUserFullName")]
    public string? AuthoritativeUserFullName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecInitProviderGcpManagedNetworkConfig
{
    /// <summary></summary>
    [JsonPropertyName("gkeClusterPodIpRange")]
    public string? GkeClusterPodIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gkeClusterServiceIpRange")]
    public string? GkeClusterServiceIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecInitProviderGkeConfig
{
    /// <summary></summary>
    [JsonPropertyName("connectivityType")]
    public string? ConnectivityType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("masterIpRange")]
    public string? MasterIpRange { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecInitProviderTokenTokenValueSecretRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecInitProviderToken
{
    /// <summary>Comment, that will appear in "User Settings / Access Tokens" page on Workspace UI.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Token expiry lifetime. By default its 2592000 (30 days).</summary>
    [JsonPropertyName("lifetimeSeconds")]
    public double? LifetimeSeconds { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("tokenId")]
    public string? TokenId { get; set; }

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("tokenValueSecretRef")]
    public V1alpha1MwsWorkspacesSpecInitProviderTokenTokenValueSecretRef? TokenValueSecretRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecInitProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountIdSecretRef")]
    public V1alpha1MwsWorkspacesSpecInitProviderAccountIdSecretRef AccountIdSecretRef { get; set; }

    /// <summary>(AWS only) region of VPC.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloud")]
    public string? Cloud { get; set; }

    /// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
    [JsonPropertyName("cloudResourceContainer")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderCloudResourceContainer>? CloudResourceContainer { get; set; }

    /// <summary>- The compute mode for the workspace. When unset, a classic workspace is created, and both credentials_id and storage_configuration_id must be specified. When set to SERVERLESS, the resulting workspace is a serverless workspace, and credentials_id and storage_configuration_id must not be set. The only allowed value for this is SERVERLESS. Changing this field requires recreation of the workspace.</summary>
    [JsonPropertyName("computeMode")]
    public string? ComputeMode { get; set; }

    /// <summary>(Integer) time when workspace was created</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(AWS only, Optional) credentials_id from credentials. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>- The custom tags key-value pairing that is attached to this workspace. These tags will be applied to clusters automatically in addition to any default_tags or custom_tags on a cluster level. Please note it can take up to an hour for custom_tags to be set due to scheduling on Control Plane. After custom tags are applied, they can be modified however they can never be completely removed.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>part of URL as in https://&lt;prefix&gt;-&lt;deployment-name&gt;.cloud.databricks.com. Deployment name cannot be used until a deployment name prefix is defined. Please contact your Databricks representative. Once a new deployment prefix is added/updated, it only will affect the new workspaces created.</summary>
    [JsonPropertyName("deploymentName")]
    public string? DeploymentName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("externalCustomerInfo")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderExternalCustomerInfo>? ExternalCustomerInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpManagedNetworkConfig")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderGcpManagedNetworkConfig>? GcpManagedNetworkConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gkeConfig")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderGkeConfig>? GkeConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isNoPublicIpEnabled")]
    public bool? IsNoPublicIpEnabled { get; set; }

    /// <summary>(GCP only) region of the subnet.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to MANAGED_SERVICES. This is used to encrypt the workspace's notebook and secret data in the control plane.</summary>
    [JsonPropertyName("managedServicesCustomerManagedKeyId")]
    public string? ManagedServicesCustomerManagedKeyId { get; set; }

    /// <summary>network_id from networks.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>- The pricing tier of the workspace.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>Canonical unique identifier of databricks_mws_private_access_settings in Databricks Account.</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>(AWS only, Optional) storage_configuration_id from storage configuration. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to STORAGE. This is used to encrypt the DBFS Storage &amp; Cluster Volumes.</summary>
    [JsonPropertyName("storageCustomerManagedKeyId")]
    public string? StorageCustomerManagedKeyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("token")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderToken>? Token { get; set; }

    /// <summary>(String) workspace id</summary>
    [JsonPropertyName("workspaceId")]
    public double? WorkspaceId { get; set; }

    /// <summary>name of the workspace, will appear on UI.</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }

    /// <summary>(String) workspace status</summary>
    [JsonPropertyName("workspaceStatus")]
    public string? WorkspaceStatus { get; set; }

    /// <summary>(String) updates on workspace status</summary>
    [JsonPropertyName("workspaceStatusMessage")]
    public string? WorkspaceStatusMessage { get; set; }

    /// <summary>(String) URL of the workspace</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecProviderConfigRefPolicy
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
public partial class V1alpha1MwsWorkspacesSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsWorkspacesSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1MwsWorkspacesSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsWorkspacesSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1MwsWorkspacesSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1MwsWorkspacesSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1MwsWorkspacesSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpecWriteConnectionSecretToRef
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
/// <summary>MwsWorkspacesSpec defines the desired state of MwsWorkspaces</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1MwsWorkspacesSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1MwsWorkspacesSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1MwsWorkspacesSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1MwsWorkspacesSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1MwsWorkspacesSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesStatusAtProviderCloudResourceContainerGcp
{
    /// <summary>The Google Cloud project ID, which the workspace uses to instantiate cloud resources for your workspace.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesStatusAtProviderCloudResourceContainer
{
    /// <summary>A block that consists of the following field:</summary>
    [JsonPropertyName("gcp")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderCloudResourceContainerGcp>? Gcp { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesStatusAtProviderExternalCustomerInfo
{
    /// <summary></summary>
    [JsonPropertyName("authoritativeUserEmail")]
    public string? AuthoritativeUserEmail { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authoritativeUserFullName")]
    public string? AuthoritativeUserFullName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesStatusAtProviderGcpManagedNetworkConfig
{
    /// <summary></summary>
    [JsonPropertyName("gkeClusterPodIpRange")]
    public string? GkeClusterPodIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gkeClusterServiceIpRange")]
    public string? GkeClusterServiceIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesStatusAtProviderGkeConfig
{
    /// <summary></summary>
    [JsonPropertyName("connectivityType")]
    public string? ConnectivityType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("masterIpRange")]
    public string? MasterIpRange { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesStatusAtProviderToken
{
    /// <summary>Comment, that will appear in "User Settings / Access Tokens" page on Workspace UI.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Token expiry lifetime. By default its 2592000 (30 days).</summary>
    [JsonPropertyName("lifetimeSeconds")]
    public double? LifetimeSeconds { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("tokenId")]
    public string? TokenId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesStatusAtProvider
{
    /// <summary>(AWS only) region of VPC.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloud")]
    public string? Cloud { get; set; }

    /// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
    [JsonPropertyName("cloudResourceContainer")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderCloudResourceContainer>? CloudResourceContainer { get; set; }

    /// <summary>- The compute mode for the workspace. When unset, a classic workspace is created, and both credentials_id and storage_configuration_id must be specified. When set to SERVERLESS, the resulting workspace is a serverless workspace, and credentials_id and storage_configuration_id must not be set. The only allowed value for this is SERVERLESS. Changing this field requires recreation of the workspace.</summary>
    [JsonPropertyName("computeMode")]
    public string? ComputeMode { get; set; }

    /// <summary>(Integer) time when workspace was created</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(AWS only, Optional) credentials_id from credentials. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>- The custom tags key-value pairing that is attached to this workspace. These tags will be applied to clusters automatically in addition to any default_tags or custom_tags on a cluster level. Please note it can take up to an hour for custom_tags to be set due to scheduling on Control Plane. After custom tags are applied, they can be modified however they can never be completely removed.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>part of URL as in https://&lt;prefix&gt;-&lt;deployment-name&gt;.cloud.databricks.com. Deployment name cannot be used until a deployment name prefix is defined. Please contact your Databricks representative. Once a new deployment prefix is added/updated, it only will affect the new workspaces created.</summary>
    [JsonPropertyName("deploymentName")]
    public string? DeploymentName { get; set; }

    /// <summary>(String) The effective compute mode for the workspace. This is either SERVERLESS for serverless workspaces or HYBRID for classic workspaces.</summary>
    [JsonPropertyName("effectiveComputeMode")]
    public string? EffectiveComputeMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("externalCustomerInfo")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderExternalCustomerInfo>? ExternalCustomerInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpManagedNetworkConfig")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderGcpManagedNetworkConfig>? GcpManagedNetworkConfig { get; set; }

    /// <summary>(String, GCP only) identifier of a service account created for the workspace in form of db-&lt;workspace-id&gt;@prod-gcp-&lt;region&gt;.iam.gserviceaccount.com</summary>
    [JsonPropertyName("gcpWorkspaceSa")]
    public string? GcpWorkspaceSa { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gkeConfig")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderGkeConfig>? GkeConfig { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isNoPublicIpEnabled")]
    public bool? IsNoPublicIpEnabled { get; set; }

    /// <summary>(GCP only) region of the subnet.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to MANAGED_SERVICES. This is used to encrypt the workspace's notebook and secret data in the control plane.</summary>
    [JsonPropertyName("managedServicesCustomerManagedKeyId")]
    public string? ManagedServicesCustomerManagedKeyId { get; set; }

    /// <summary>network_id from networks.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>- The pricing tier of the workspace.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>Canonical unique identifier of databricks_mws_private_access_settings in Databricks Account.</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>(AWS only, Optional) storage_configuration_id from storage configuration. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to STORAGE. This is used to encrypt the DBFS Storage &amp; Cluster Volumes.</summary>
    [JsonPropertyName("storageCustomerManagedKeyId")]
    public string? StorageCustomerManagedKeyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("token")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderToken>? Token { get; set; }

    /// <summary>(String) workspace id</summary>
    [JsonPropertyName("workspaceId")]
    public double? WorkspaceId { get; set; }

    /// <summary>name of the workspace, will appear on UI.</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }

    /// <summary>(String) workspace status</summary>
    [JsonPropertyName("workspaceStatus")]
    public string? WorkspaceStatus { get; set; }

    /// <summary>(String) updates on workspace status</summary>
    [JsonPropertyName("workspaceStatusMessage")]
    public string? WorkspaceStatusMessage { get; set; }

    /// <summary>(String) URL of the workspace</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesStatusConditions
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
/// <summary>MwsWorkspacesStatus defines the observed state of MwsWorkspaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsWorkspacesStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1MwsWorkspacesStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MwsWorkspacesStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MwsWorkspaces is the Schema for the MwsWorkspacess API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsWorkspaces : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MwsWorkspacesSpec>, IStatus<V1alpha1MwsWorkspacesStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsWorkspaces";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsworkspaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MwsWorkspacesSpec defines the desired state of MwsWorkspaces</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MwsWorkspacesSpec Spec { get; set; }

    /// <summary>MwsWorkspacesStatus defines the observed state of MwsWorkspaces.</summary>
    [JsonPropertyName("status")]
    public V1alpha1MwsWorkspacesStatus? Status { get; set; }
}
#nullable disable
