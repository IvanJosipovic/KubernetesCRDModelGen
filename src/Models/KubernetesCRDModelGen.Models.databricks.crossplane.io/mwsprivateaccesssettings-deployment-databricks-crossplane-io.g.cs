using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deployment.databricks.crossplane.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsPrivateAccessSettingsSpecForProvider
{
    /// <summary>the ID of the Private Access Settings in form of account_id/private_access_settings_id.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>An array of databricks_mws_vpc_endpoint vpc_endpoint_id (not id). Only used when private_access_level is set to ENDPOINT. This is an allow list of databricks_mws_vpc_endpoint that in your account that can connect to your databricks_mws_workspaces over AWS PrivateLink. If hybrid access to your workspace is enabled by setting public_access_enabled to true, then this control only works for PrivateLink connections. To control how your workspace is accessed via public internet, see the article for databricks_ip_access_list.</summary>
    [JsonPropertyName("allowedVpcEndpointIds")]
    public IList<string>? AllowedVpcEndpointIds { get; set; }

    /// <summary>The private access level controls which VPC endpoints can connect to the UI or API of any workspace that attaches this private access settings object. ACCOUNT level access (default) lets only databricks_mws_vpc_endpoint that are registered in your Databricks account connect to your databricks_mws_workspaces. ENDPOINT level access lets only specified databricks_mws_vpc_endpoint connect to your workspace. Please see the allowed_vpc_endpoint_ids documentation for more details.</summary>
    [JsonPropertyName("privateAccessLevel")]
    public string? PrivateAccessLevel { get; set; }

    /// <summary>Canonical unique identifier of Private Access Settings in Databricks Account</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>Name of Private Access Settings in Databricks Account</summary>
    [JsonPropertyName("privateAccessSettingsName")]
    public string? PrivateAccessSettingsName { get; set; }

    /// <summary>If true, the databricks_mws_workspaces can be accessed over the databricks_mws_vpc_endpoint as well as over the public network. In such a case, you could also configure an databricks_ip_access_list for the workspace, to restrict the source networks that could be used to access it over the public network. If false, the workspace can be accessed only over VPC endpoints, and not over the public network. Once explicitly set, this field becomes mandatory.</summary>
    [JsonPropertyName("publicAccessEnabled")]
    public bool? PublicAccessEnabled { get; set; }

    /// <summary>Region of AWS VPC or the Google Cloud VPC network</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsPrivateAccessSettingsSpecInitProvider
{
    /// <summary>the ID of the Private Access Settings in form of account_id/private_access_settings_id.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>An array of databricks_mws_vpc_endpoint vpc_endpoint_id (not id). Only used when private_access_level is set to ENDPOINT. This is an allow list of databricks_mws_vpc_endpoint that in your account that can connect to your databricks_mws_workspaces over AWS PrivateLink. If hybrid access to your workspace is enabled by setting public_access_enabled to true, then this control only works for PrivateLink connections. To control how your workspace is accessed via public internet, see the article for databricks_ip_access_list.</summary>
    [JsonPropertyName("allowedVpcEndpointIds")]
    public IList<string>? AllowedVpcEndpointIds { get; set; }

    /// <summary>The private access level controls which VPC endpoints can connect to the UI or API of any workspace that attaches this private access settings object. ACCOUNT level access (default) lets only databricks_mws_vpc_endpoint that are registered in your Databricks account connect to your databricks_mws_workspaces. ENDPOINT level access lets only specified databricks_mws_vpc_endpoint connect to your workspace. Please see the allowed_vpc_endpoint_ids documentation for more details.</summary>
    [JsonPropertyName("privateAccessLevel")]
    public string? PrivateAccessLevel { get; set; }

    /// <summary>Canonical unique identifier of Private Access Settings in Databricks Account</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>Name of Private Access Settings in Databricks Account</summary>
    [JsonPropertyName("privateAccessSettingsName")]
    public string? PrivateAccessSettingsName { get; set; }

    /// <summary>If true, the databricks_mws_workspaces can be accessed over the databricks_mws_vpc_endpoint as well as over the public network. In such a case, you could also configure an databricks_ip_access_list for the workspace, to restrict the source networks that could be used to access it over the public network. If false, the workspace can be accessed only over VPC endpoints, and not over the public network. Once explicitly set, this field becomes mandatory.</summary>
    [JsonPropertyName("publicAccessEnabled")]
    public bool? PublicAccessEnabled { get; set; }

    /// <summary>Region of AWS VPC or the Google Cloud VPC network</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsPrivateAccessSettingsSpecProviderConfigRefPolicy
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
public partial class V1alpha1MwsPrivateAccessSettingsSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsPrivateAccessSettingsSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsPrivateAccessSettingsSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1MwsPrivateAccessSettingsSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsPrivateAccessSettingsSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsPrivateAccessSettingsSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1MwsPrivateAccessSettingsSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1MwsPrivateAccessSettingsSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1MwsPrivateAccessSettingsSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsPrivateAccessSettingsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MwsPrivateAccessSettingsSpec defines the desired state of MwsPrivateAccessSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsPrivateAccessSettingsSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1MwsPrivateAccessSettingsSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1MwsPrivateAccessSettingsSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1MwsPrivateAccessSettingsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1MwsPrivateAccessSettingsSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1MwsPrivateAccessSettingsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsPrivateAccessSettingsStatusAtProvider
{
    /// <summary>the ID of the Private Access Settings in form of account_id/private_access_settings_id.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>An array of databricks_mws_vpc_endpoint vpc_endpoint_id (not id). Only used when private_access_level is set to ENDPOINT. This is an allow list of databricks_mws_vpc_endpoint that in your account that can connect to your databricks_mws_workspaces over AWS PrivateLink. If hybrid access to your workspace is enabled by setting public_access_enabled to true, then this control only works for PrivateLink connections. To control how your workspace is accessed via public internet, see the article for databricks_ip_access_list.</summary>
    [JsonPropertyName("allowedVpcEndpointIds")]
    public IList<string>? AllowedVpcEndpointIds { get; set; }

    /// <summary>the ID of the Private Access Settings in form of account_id/private_access_settings_id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The private access level controls which VPC endpoints can connect to the UI or API of any workspace that attaches this private access settings object. ACCOUNT level access (default) lets only databricks_mws_vpc_endpoint that are registered in your Databricks account connect to your databricks_mws_workspaces. ENDPOINT level access lets only specified databricks_mws_vpc_endpoint connect to your workspace. Please see the allowed_vpc_endpoint_ids documentation for more details.</summary>
    [JsonPropertyName("privateAccessLevel")]
    public string? PrivateAccessLevel { get; set; }

    /// <summary>Canonical unique identifier of Private Access Settings in Databricks Account</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>Name of Private Access Settings in Databricks Account</summary>
    [JsonPropertyName("privateAccessSettingsName")]
    public string? PrivateAccessSettingsName { get; set; }

    /// <summary>If true, the databricks_mws_workspaces can be accessed over the databricks_mws_vpc_endpoint as well as over the public network. In such a case, you could also configure an databricks_ip_access_list for the workspace, to restrict the source networks that could be used to access it over the public network. If false, the workspace can be accessed only over VPC endpoints, and not over the public network. Once explicitly set, this field becomes mandatory.</summary>
    [JsonPropertyName("publicAccessEnabled")]
    public bool? PublicAccessEnabled { get; set; }

    /// <summary>Region of AWS VPC or the Google Cloud VPC network</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsPrivateAccessSettingsStatusConditions
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

/// <summary>MwsPrivateAccessSettingsStatus defines the observed state of MwsPrivateAccessSettings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MwsPrivateAccessSettingsStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1MwsPrivateAccessSettingsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MwsPrivateAccessSettingsStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MwsPrivateAccessSettings is the Schema for the MwsPrivateAccessSettingss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsPrivateAccessSettings : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MwsPrivateAccessSettingsSpec>, IStatus<V1alpha1MwsPrivateAccessSettingsStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsPrivateAccessSettings";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsprivateaccesssettings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MwsPrivateAccessSettingsSpec defines the desired state of MwsPrivateAccessSettings</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MwsPrivateAccessSettingsSpec Spec { get; set; }

    /// <summary>MwsPrivateAccessSettingsStatus defines the observed state of MwsPrivateAccessSettings.</summary>
    [JsonPropertyName("status")]
    public V1alpha1MwsPrivateAccessSettingsStatus? Status { get; set; }
}

/// <summary>MwsPrivateAccessSettings is the Schema for the MwsPrivateAccessSettingss API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsPrivateAccessSettingsList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MwsPrivateAccessSettings>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsPrivateAccessSettingsList";
    public const string KubeGroup = "deployment.databricks.crossplane.io";
    public const string KubePluralName = "mwsprivateaccesssettings";
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
    public IList<V1alpha1MwsPrivateAccessSettings> Items { get; set; }
}