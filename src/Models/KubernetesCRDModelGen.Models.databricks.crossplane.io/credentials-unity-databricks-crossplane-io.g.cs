using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.crossplane.io;
#nullable enable
/// <summary>Credential is the Schema for the Credentials API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CredentialList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Credential>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CredentialList";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "credentials";
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
    public IList<V1alpha1Credential> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecForProviderAwsIamRole
{
    /// <summary>ID of this credential - same as the name.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role you want to use to setup the trust policy, of the form arn:aws:iam::1234567890:role/MyRole-AJJHDSKSDF</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("unityCatalogIamArn")]
    public string? UnityCatalogIamArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecForProviderAzureManagedIdentity
{
    /// <summary>The Resource ID of the Azure Databricks Access Connector resource, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.Databricks/accessConnectors/connector-name.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>Unique ID of the credential.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The Resource ID of the Azure User Assigned Managed Identity associated with Azure Databricks Access Connector, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.ManagedIdentity/userAssignedIdentities/user-managed-identity-name.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The client secret generated for the above app ID in AAD. This field is redacted on output</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecForProviderAzureServicePrincipalClientSecretSecretRef
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
public partial class V1alpha1CredentialSpecForProviderAzureServicePrincipal
{
    /// <summary>The application ID of the application registration within the referenced AAD tenant</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>The client secret generated for the above app ID in AAD. This field is redacted on output</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1alpha1CredentialSpecForProviderAzureServicePrincipalClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The directory ID corresponding to the Azure Active Directory (AAD) tenant of the application</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecForProviderDatabricksGcpServiceAccount
{
    /// <summary>Unique ID of the credential.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The email of the GCP service account created, to be granted access to relevant buckets.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this credential - same as the name.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecForProvider
{
    /// <summary></summary>
    [JsonPropertyName("awsIamRole")]
    public IList<V1alpha1CredentialSpecForProviderAwsIamRole>? AwsIamRole { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureManagedIdentity")]
    public IList<V1alpha1CredentialSpecForProviderAzureManagedIdentity>? AzureManagedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureServicePrincipal")]
    public IList<V1alpha1CredentialSpecForProviderAzureServicePrincipal>? AzureServicePrincipal { get; set; }

    /// <summary></summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databricksGcpServiceAccount")]
    public IList<V1alpha1CredentialSpecForProviderDatabricksGcpServiceAccount>? DatabricksGcpServiceAccount { get; set; }

    /// <summary>Delete credential regardless of its dependencies.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update credential regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    /// <summary>Name of Credentials, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>Whether the credential is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the credential to ISOLATION_MODE_ISOLATED will automatically restrict access to only from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this credential - same as the name.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Name of Credentials, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Username/groupname/sp application_id of the credential owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Indicates the purpose of the credential. Can be SERVICE or STORAGE.</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Indicates whether the credential is only usable for read operations. Only applicable when purpose is STORAGE.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the credential.</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usedForManagedStorage")]
    public bool? UsedForManagedStorage { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecInitProviderAwsIamRole
{
    /// <summary>ID of this credential - same as the name.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role you want to use to setup the trust policy, of the form arn:aws:iam::1234567890:role/MyRole-AJJHDSKSDF</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("unityCatalogIamArn")]
    public string? UnityCatalogIamArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecInitProviderAzureManagedIdentity
{
    /// <summary>The Resource ID of the Azure Databricks Access Connector resource, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.Databricks/accessConnectors/connector-name.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>Unique ID of the credential.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The Resource ID of the Azure User Assigned Managed Identity associated with Azure Databricks Access Connector, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.ManagedIdentity/userAssignedIdentities/user-managed-identity-name.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The client secret generated for the above app ID in AAD. This field is redacted on output</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecInitProviderAzureServicePrincipalClientSecretSecretRef
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
public partial class V1alpha1CredentialSpecInitProviderAzureServicePrincipal
{
    /// <summary>The application ID of the application registration within the referenced AAD tenant</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>The client secret generated for the above app ID in AAD. This field is redacted on output</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1alpha1CredentialSpecInitProviderAzureServicePrincipalClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>The directory ID corresponding to the Azure Active Directory (AAD) tenant of the application</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecInitProviderDatabricksGcpServiceAccount
{
    /// <summary>Unique ID of the credential.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The email of the GCP service account created, to be granted access to relevant buckets.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this credential - same as the name.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecInitProvider
{
    /// <summary></summary>
    [JsonPropertyName("awsIamRole")]
    public IList<V1alpha1CredentialSpecInitProviderAwsIamRole>? AwsIamRole { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureManagedIdentity")]
    public IList<V1alpha1CredentialSpecInitProviderAzureManagedIdentity>? AzureManagedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureServicePrincipal")]
    public IList<V1alpha1CredentialSpecInitProviderAzureServicePrincipal>? AzureServicePrincipal { get; set; }

    /// <summary></summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databricksGcpServiceAccount")]
    public IList<V1alpha1CredentialSpecInitProviderDatabricksGcpServiceAccount>? DatabricksGcpServiceAccount { get; set; }

    /// <summary>Delete credential regardless of its dependencies.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update credential regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    /// <summary>Name of Credentials, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>Whether the credential is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the credential to ISOLATION_MODE_ISOLATED will automatically restrict access to only from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this credential - same as the name.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Name of Credentials, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Username/groupname/sp application_id of the credential owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Indicates the purpose of the credential. Can be SERVICE or STORAGE.</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Indicates whether the credential is only usable for read operations. Only applicable when purpose is STORAGE.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the credential.</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usedForManagedStorage")]
    public bool? UsedForManagedStorage { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecProviderConfigRefPolicy
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
public partial class V1alpha1CredentialSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1CredentialSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1CredentialSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1CredentialSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1CredentialSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1CredentialSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1CredentialSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpecWriteConnectionSecretToRef
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
/// <summary>CredentialSpec defines the desired state of Credential</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1CredentialSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1CredentialSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1CredentialSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1CredentialSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1CredentialSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialStatusAtProviderAwsIamRole
{
    /// <summary>ID of this credential - same as the name.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the AWS IAM role you want to use to setup the trust policy, of the form arn:aws:iam::1234567890:role/MyRole-AJJHDSKSDF</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("unityCatalogIamArn")]
    public string? UnityCatalogIamArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialStatusAtProviderAzureManagedIdentity
{
    /// <summary>The Resource ID of the Azure Databricks Access Connector resource, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.Databricks/accessConnectors/connector-name.</summary>
    [JsonPropertyName("accessConnectorId")]
    public string? AccessConnectorId { get; set; }

    /// <summary>Unique ID of the credential.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The Resource ID of the Azure User Assigned Managed Identity associated with Azure Databricks Access Connector, of the form /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-name/providers/Microsoft.ManagedIdentity/userAssignedIdentities/user-managed-identity-name.</summary>
    [JsonPropertyName("managedIdentityId")]
    public string? ManagedIdentityId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialStatusAtProviderAzureServicePrincipal
{
    /// <summary>The application ID of the application registration within the referenced AAD tenant</summary>
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; set; }

    /// <summary>The directory ID corresponding to the Azure Active Directory (AAD) tenant of the application</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialStatusAtProviderDatabricksGcpServiceAccount
{
    /// <summary>Unique ID of the credential.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>The email of the GCP service account created, to be granted access to relevant buckets.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>ID of this credential - same as the name.</summary>
    [JsonPropertyName("privateKeyId")]
    public string? PrivateKeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("awsIamRole")]
    public IList<V1alpha1CredentialStatusAtProviderAwsIamRole>? AwsIamRole { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureManagedIdentity")]
    public IList<V1alpha1CredentialStatusAtProviderAzureManagedIdentity>? AzureManagedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureServicePrincipal")]
    public IList<V1alpha1CredentialStatusAtProviderAzureServicePrincipal>? AzureServicePrincipal { get; set; }

    /// <summary></summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>Unique ID of the credential.</summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databricksGcpServiceAccount")]
    public IList<V1alpha1CredentialStatusAtProviderDatabricksGcpServiceAccount>? DatabricksGcpServiceAccount { get; set; }

    /// <summary>Delete credential regardless of its dependencies.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Update credential regardless of its dependents.</summary>
    [JsonPropertyName("forceUpdate")]
    public bool? ForceUpdate { get; set; }

    /// <summary>Name of Credentials, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>ID of this credential - same as the name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether the credential is accessible from all workspaces or a specific set of workspaces. Can be ISOLATION_MODE_ISOLATED or ISOLATION_MODE_OPEN. Setting the credential to ISOLATION_MODE_ISOLATED will automatically restrict access to only from the current workspace.</summary>
    [JsonPropertyName("isolationMode")]
    public string? IsolationMode { get; set; }

    /// <summary>ID of this credential - same as the name.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>Name of Credentials, which must be unique within the databricks_metastore. Change forces creation of a new resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Username/groupname/sp application_id of the credential owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Indicates the purpose of the credential. Can be SERVICE or STORAGE.</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Indicates whether the credential is only usable for read operations. Only applicable when purpose is STORAGE.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Suppress validation errors if any &amp; force save the credential.</summary>
    [JsonPropertyName("skipValidation")]
    public bool? SkipValidation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usedForManagedStorage")]
    public bool? UsedForManagedStorage { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialStatusConditions
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
/// <summary>CredentialStatus defines the observed state of Credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CredentialStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1CredentialStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CredentialStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Credential is the Schema for the Credentials API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Credential : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CredentialSpec>, IStatus<V1alpha1CredentialStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Credential";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "credentials";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CredentialSpec defines the desired state of Credential</summary>
    [JsonPropertyName("spec")]
    public V1alpha1CredentialSpec Spec { get; set; }

    /// <summary>CredentialStatus defines the observed state of Credential.</summary>
    [JsonPropertyName("status")]
    public V1alpha1CredentialStatus? Status { get; set; }
}
#nullable disable
