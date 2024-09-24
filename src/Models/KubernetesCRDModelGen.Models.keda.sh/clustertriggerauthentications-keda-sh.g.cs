using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keda.sh;
public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFromSecretKeyRef SecretKeyRef { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKey
{
    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFrom ValueFrom { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFromSecretKeyRef SecretKeyRef { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKey
{
    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFrom ValueFrom { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFromSecretKeyRef SecretKeyRef { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessToken
{
    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFrom ValueFrom { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentials
{
    /// <summary></summary>
    [JsonPropertyName("accessKey")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKey AccessKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessSecretKey")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKey AccessSecretKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessToken")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentialsAccessToken? AccessToken { get; set; }
}

public enum V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    /// <summary>keda</summary>
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    /// <summary>workload</summary>
    Workload
}

public enum V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityProviderEnum
{
    [EnumMember(Value = "azure-workload"), JsonStringEnumMemberName("azure-workload")]
    /// <summary>azure-workload</summary>
    AzureWorkload,
    [EnumMember(Value = "gcp"), JsonStringEnumMemberName("gcp")]
    /// <summary>gcp</summary>
    Gcp,
    [EnumMember(Value = "aws"), JsonStringEnumMemberName("aws")]
    /// <summary>aws</summary>
    Aws,
    [EnumMember(Value = "aws-eks"), JsonStringEnumMemberName("aws-eks")]
    /// <summary>aws-eks</summary>
    AwsEks,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    /// <summary>none</summary>
    None
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentity
{
    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityIdentityOwnerEnum>))]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityProviderEnum>))]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerSecrets
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public string Parameter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versionStage")]
    public string? VersionStage { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManager
{
    /// <summary></summary>
    [JsonPropertyName("credentials")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerCredentials? Credentials { get; set; }

    /// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerPodIdentity? PodIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManagerSecrets> Secrets { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCloud
{
    /// <summary></summary>
    [JsonPropertyName("activeDirectoryEndpoint")]
    public string? ActiveDirectoryEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultResourceURL")]
    public string? KeyVaultResourceURL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFromSecretKeyRef SecretKeyRef { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecret
{
    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFrom ValueFrom { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentials
{
    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecret")]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecret ClientSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string TenantId { get; set; }
}

public enum V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    /// <summary>keda</summary>
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    /// <summary>workload</summary>
    Workload
}

public enum V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityProviderEnum
{
    [EnumMember(Value = "azure-workload"), JsonStringEnumMemberName("azure-workload")]
    /// <summary>azure-workload</summary>
    AzureWorkload,
    [EnumMember(Value = "gcp"), JsonStringEnumMemberName("gcp")]
    /// <summary>gcp</summary>
    Gcp,
    [EnumMember(Value = "aws"), JsonStringEnumMemberName("aws")]
    /// <summary>aws</summary>
    Aws,
    [EnumMember(Value = "aws-eks"), JsonStringEnumMemberName("aws-eks")]
    /// <summary>aws-eks</summary>
    AwsEks,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    /// <summary>none</summary>
    None
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentity
{
    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityIdentityOwnerEnum>))]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityProviderEnum>))]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultSecrets
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public string Parameter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVault
{
    /// <summary></summary>
    [JsonPropertyName("cloud")]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCloud? Cloud { get; set; }

    /// <summary></summary>
    [JsonPropertyName("credentials")]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultCredentials? Credentials { get; set; }

    /// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultPodIdentity? PodIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVaultSecrets> Secrets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultUri")]
    public string VaultUri { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecConfigMapTargetRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public string Parameter { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecEnv
{
    /// <summary></summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public string Parameter { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFromSecretKeyRef SecretKeyRef { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecret
{
    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFrom ValueFrom { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentials
{
    /// <summary></summary>
    [JsonPropertyName("clientSecret")]
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecret ClientSecret { get; set; }
}

public enum V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    /// <summary>keda</summary>
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    /// <summary>workload</summary>
    Workload
}

public enum V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityProviderEnum
{
    [EnumMember(Value = "azure-workload"), JsonStringEnumMemberName("azure-workload")]
    /// <summary>azure-workload</summary>
    AzureWorkload,
    [EnumMember(Value = "gcp"), JsonStringEnumMemberName("gcp")]
    /// <summary>gcp</summary>
    Gcp,
    [EnumMember(Value = "aws"), JsonStringEnumMemberName("aws")]
    /// <summary>aws</summary>
    Aws,
    [EnumMember(Value = "aws-eks"), JsonStringEnumMemberName("aws-eks")]
    /// <summary>aws-eks</summary>
    AwsEks,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    /// <summary>none</summary>
    None
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentity
{
    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityIdentityOwnerEnum>))]
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityProviderEnum>))]
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerSecrets
{
    /// <summary></summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public string Parameter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManager
{
    /// <summary></summary>
    [JsonPropertyName("credentials")]
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerCredentials? Credentials { get; set; }

    /// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerPodIdentity? PodIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManagerSecrets> Secrets { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultCredential
{
    /// <summary></summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultSecretsPkiData
{
    /// <summary></summary>
    [JsonPropertyName("altNames")]
    public string? AltNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipSans")]
    public string? IpSans { get; set; }

    /// <summary></summary>
    [JsonPropertyName("otherSans")]
    public string? OtherSans { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uriSans")]
    public string? UriSans { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultSecrets
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public string Parameter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pkiData")]
    public V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultSecretsPkiData? PkiData { get; set; }

    /// <summary>VaultSecretType defines the type of vault secret</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVault
{
    /// <summary></summary>
    [JsonPropertyName("address")]
    public string Address { get; set; }

    /// <summary>VaultAuthentication contains the list of Hashicorp Vault authentication methods</summary>
    [JsonPropertyName("authentication")]
    public string Authentication { get; set; }

    /// <summary>Credential defines the Hashicorp Vault credentials depending on the authentication method</summary>
    [JsonPropertyName("credential")]
    public V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultCredential? Credential { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mount")]
    public string? Mount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVaultSecrets> Secrets { get; set; }
}

public enum V1alpha1ClusterTriggerAuthenticationSpecPodIdentityIdentityOwnerEnum
{
    [EnumMember(Value = "keda"), JsonStringEnumMemberName("keda")]
    /// <summary>keda</summary>
    Keda,
    [EnumMember(Value = "workload"), JsonStringEnumMemberName("workload")]
    /// <summary>workload</summary>
    Workload
}

public enum V1alpha1ClusterTriggerAuthenticationSpecPodIdentityProviderEnum
{
    [EnumMember(Value = "azure-workload"), JsonStringEnumMemberName("azure-workload")]
    /// <summary>azure-workload</summary>
    AzureWorkload,
    [EnumMember(Value = "gcp"), JsonStringEnumMemberName("gcp")]
    /// <summary>gcp</summary>
    Gcp,
    [EnumMember(Value = "aws"), JsonStringEnumMemberName("aws")]
    /// <summary>aws</summary>
    Aws,
    [EnumMember(Value = "aws-eks"), JsonStringEnumMemberName("aws-eks")]
    /// <summary>aws-eks</summary>
    AwsEks,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    /// <summary>none</summary>
    None
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecPodIdentity
{
    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecPodIdentityIdentityOwnerEnum>))]
    public V1alpha1ClusterTriggerAuthenticationSpecPodIdentityIdentityOwnerEnum? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterTriggerAuthenticationSpecPodIdentityProviderEnum>))]
    public V1alpha1ClusterTriggerAuthenticationSpecPodIdentityProviderEnum Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpecSecretTargetRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public string Parameter { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationSpec
{
    /// <summary>AwsSecretManager is used to authenticate using AwsSecretManager</summary>
    [JsonPropertyName("awsSecretManager")]
    public V1alpha1ClusterTriggerAuthenticationSpecAwsSecretManager? AwsSecretManager { get; set; }

    /// <summary>AzureKeyVault is used to authenticate using Azure Key Vault</summary>
    [JsonPropertyName("azureKeyVault")]
    public V1alpha1ClusterTriggerAuthenticationSpecAzureKeyVault? AzureKeyVault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapTargetRef")]
    public IList<V1alpha1ClusterTriggerAuthenticationSpecConfigMapTargetRef>? ConfigMapTargetRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1ClusterTriggerAuthenticationSpecEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManager")]
    public V1alpha1ClusterTriggerAuthenticationSpecGcpSecretManager? GcpSecretManager { get; set; }

    /// <summary>HashiCorpVault is used to authenticate using Hashicorp Vault</summary>
    [JsonPropertyName("hashiCorpVault")]
    public V1alpha1ClusterTriggerAuthenticationSpecHashiCorpVault? HashiCorpVault { get; set; }

    /// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1ClusterTriggerAuthenticationSpecPodIdentity? PodIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretTargetRef")]
    public IList<V1alpha1ClusterTriggerAuthenticationSpecSecretTargetRef>? SecretTargetRef { get; set; }
}

public partial class V1alpha1ClusterTriggerAuthenticationStatus
{
    /// <summary></summary>
    [JsonPropertyName("scaledjobs")]
    public string? Scaledjobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaledobjects")]
    public string? Scaledobjects { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterTriggerAuthentication : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterTriggerAuthenticationSpec>, IStatus<V1alpha1ClusterTriggerAuthenticationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterTriggerAuthentication";
    public const string KubeGroup = "keda.sh";
    public const string KubePluralName = "clustertriggerauthentications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TriggerAuthenticationSpec defines the various ways to authenticate</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterTriggerAuthenticationSpec Spec { get; set; }

    /// <summary>TriggerAuthenticationStatus defines the observed state of TriggerAuthentication</summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterTriggerAuthenticationStatus? Status { get; set; }
}