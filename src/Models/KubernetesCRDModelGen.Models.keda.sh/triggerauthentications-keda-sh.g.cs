using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keda.sh;
#nullable enable
/// <summary>TriggerAuthentication defines how a trigger can authenticate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TriggerAuthenticationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TriggerAuthentication>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TriggerAuthenticationList";
    public const string KubeGroup = "keda.sh";
    public const string KubePluralName = "triggerauthentications";
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
    public IList<V1alpha1TriggerAuthentication> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFromSecretKeyRef SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKey
{
    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKeyValueFrom ValueFrom { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFromSecretKeyRef SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKey
{
    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKeyValueFrom ValueFrom { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFromSecretKeyRef SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessToken
{
    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessTokenValueFrom ValueFrom { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentials
{
    /// <summary></summary>
    [JsonPropertyName("accessKey")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessKey AccessKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessSecretKey")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessSecretKey AccessSecretKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accessToken")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentialsAccessToken? AccessToken { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerPodIdentity
{
    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    public string? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManagerSecrets
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public string Parameter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKey")]
    public string? SecretKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("versionStage")]
    public string? VersionStage { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AwsSecretManager is used to authenticate using AwsSecretManager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAwsSecretManager
{
    /// <summary></summary>
    [JsonPropertyName("credentials")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerCredentials? Credentials { get; set; }

    /// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManagerPodIdentity? PodIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<V1alpha1TriggerAuthenticationSpecAwsSecretManagerSecrets> Secrets { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultCloud
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFromSecretKeyRef SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecret
{
    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecretValueFrom ValueFrom { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentials
{
    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecret")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentialsClientSecret ClientSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string TenantId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultPodIdentity
{
    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    public string? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVaultSecrets
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
#nullable disable

#nullable enable
/// <summary>AzureKeyVault is used to authenticate using Azure Key Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecAzureKeyVault
{
    /// <summary></summary>
    [JsonPropertyName("cloud")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVaultCloud? Cloud { get; set; }

    /// <summary></summary>
    [JsonPropertyName("credentials")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVaultCredentials? Credentials { get; set; }

    /// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVaultPodIdentity? PodIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<V1alpha1TriggerAuthenticationSpecAzureKeyVaultSecrets> Secrets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultUri")]
    public string VaultUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecBoundServiceAccountToken
{
    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public string Parameter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountName")]
    public string ServiceAccountName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AuthConfigMapTargetRef is used to authenticate using a reference to a config map</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecConfigMapTargetRef
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
#nullable disable

#nullable enable
/// <summary>AuthEnvironment is used to authenticate using environment variables in the destination ScaleTarget spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecEnv
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFromSecretKeyRef SecretKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecret
{
    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecretValueFrom ValueFrom { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentials
{
    /// <summary></summary>
    [JsonPropertyName("clientSecret")]
    public V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentialsClientSecret ClientSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerPodIdentity
{
    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    public string? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManagerSecrets
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecGcpSecretManager
{
    /// <summary></summary>
    [JsonPropertyName("credentials")]
    public V1alpha1TriggerAuthenticationSpecGcpSecretManagerCredentials? Credentials { get; set; }

    /// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1TriggerAuthenticationSpecGcpSecretManagerPodIdentity? PodIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<V1alpha1TriggerAuthenticationSpecGcpSecretManagerSecrets> Secrets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Credential defines the Hashicorp Vault credentials depending on the authentication method</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecHashiCorpVaultCredential
{
    /// <summary></summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecHashiCorpVaultSecretsPkiData
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
#nullable disable

#nullable enable
/// <summary>VaultSecret defines the mapping between the path of the secret in Vault to the parameter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecHashiCorpVaultSecrets
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
    public V1alpha1TriggerAuthenticationSpecHashiCorpVaultSecretsPkiData? PkiData { get; set; }

    /// <summary>VaultSecretType defines the type of vault secret</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HashiCorpVault is used to authenticate using Hashicorp Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecHashiCorpVault
{
    /// <summary></summary>
    [JsonPropertyName("address")]
    public string Address { get; set; }

    /// <summary>VaultAuthentication contains the list of Hashicorp Vault authentication methods</summary>
    [JsonPropertyName("authentication")]
    public string Authentication { get; set; }

    /// <summary>Credential defines the Hashicorp Vault credentials depending on the authentication method</summary>
    [JsonPropertyName("credential")]
    public V1alpha1TriggerAuthenticationSpecHashiCorpVaultCredential? Credential { get; set; }

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
    public IList<V1alpha1TriggerAuthenticationSpecHashiCorpVaultSecrets> Secrets { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecPodIdentity
{
    /// <summary>Set identityAuthorityHost to override the default Azure authority host. If this is set, then the IdentityTenantID must also be set</summary>
    [JsonPropertyName("identityAuthorityHost")]
    public string? IdentityAuthorityHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>IdentityOwner configures which identity has to be used during auto discovery, keda or the scaled workload. Mutually exclusive with roleArn</summary>
    [JsonPropertyName("identityOwner")]
    public string? IdentityOwner { get; set; }

    /// <summary>Set identityTenantId to override the default Azure tenant id. If this is set, then the IdentityID must also be set</summary>
    [JsonPropertyName("identityTenantId")]
    public string? IdentityTenantId { get; set; }

    /// <summary>PodIdentityProvider contains the list of providers</summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }

    /// <summary>RoleArn sets the AWS RoleArn to be used. Mutually exclusive with IdentityOwner</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AuthSecretTargetRef is used to authenticate using a reference to a secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpecSecretTargetRef
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
#nullable disable

#nullable enable
/// <summary>TriggerAuthenticationSpec defines the various ways to authenticate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationSpec
{
    /// <summary>AwsSecretManager is used to authenticate using AwsSecretManager</summary>
    [JsonPropertyName("awsSecretManager")]
    public V1alpha1TriggerAuthenticationSpecAwsSecretManager? AwsSecretManager { get; set; }

    /// <summary>AzureKeyVault is used to authenticate using Azure Key Vault</summary>
    [JsonPropertyName("azureKeyVault")]
    public V1alpha1TriggerAuthenticationSpecAzureKeyVault? AzureKeyVault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("boundServiceAccountToken")]
    public IList<V1alpha1TriggerAuthenticationSpecBoundServiceAccountToken>? BoundServiceAccountToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapTargetRef")]
    public IList<V1alpha1TriggerAuthenticationSpecConfigMapTargetRef>? ConfigMapTargetRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("env")]
    public IList<V1alpha1TriggerAuthenticationSpecEnv>? Env { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManager")]
    public V1alpha1TriggerAuthenticationSpecGcpSecretManager? GcpSecretManager { get; set; }

    /// <summary>HashiCorpVault is used to authenticate using Hashicorp Vault</summary>
    [JsonPropertyName("hashiCorpVault")]
    public V1alpha1TriggerAuthenticationSpecHashiCorpVault? HashiCorpVault { get; set; }

    /// <summary>AuthPodIdentity allows users to select the platform native identity mechanism</summary>
    [JsonPropertyName("podIdentity")]
    public V1alpha1TriggerAuthenticationSpecPodIdentity? PodIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretTargetRef")]
    public IList<V1alpha1TriggerAuthenticationSpecSecretTargetRef>? SecretTargetRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TriggerAuthenticationStatus defines the observed state of TriggerAuthentication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TriggerAuthenticationStatus
{
    /// <summary></summary>
    [JsonPropertyName("scaledjobs")]
    public string? Scaledjobs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaledobjects")]
    public string? Scaledobjects { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TriggerAuthentication defines how a trigger can authenticate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TriggerAuthentication : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TriggerAuthenticationSpec>, IStatus<V1alpha1TriggerAuthenticationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TriggerAuthentication";
    public const string KubeGroup = "keda.sh";
    public const string KubePluralName = "triggerauthentications";
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
    public V1alpha1TriggerAuthenticationSpec Spec { get; set; }

    /// <summary>TriggerAuthenticationStatus defines the observed state of TriggerAuthentication</summary>
    [JsonPropertyName("status")]
    public V1alpha1TriggerAuthenticationStatus? Status { get; set; }
}
#nullable disable
