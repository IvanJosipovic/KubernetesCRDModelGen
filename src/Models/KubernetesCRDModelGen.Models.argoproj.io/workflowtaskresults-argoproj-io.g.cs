using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.argoproj.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsArchiveNone
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsArchiveTar
{
    /// <summary></summary>
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsArchiveZip
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsArchive
{
    /// <summary></summary>
    [JsonPropertyName("none")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsArchiveNone? None { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tar")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsArchiveTar? Tar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zip")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsArchiveZip? Zip { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsArtifactGCPodMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1alpha1WorkflowTaskResultOutputsArtifactsArtifactGCStrategyEnum
{
    [EnumMember(Value = ""), JsonStringEnumMemberName("")]
    /// <summary></summary>
    Option0,
    [EnumMember(Value = "OnWorkflowCompletion"), JsonStringEnumMemberName("OnWorkflowCompletion")]
    /// <summary>OnWorkflowCompletion</summary>
    OnWorkflowCompletion,
    [EnumMember(Value = "OnWorkflowDeletion"), JsonStringEnumMemberName("OnWorkflowDeletion")]
    /// <summary>OnWorkflowDeletion</summary>
    OnWorkflowDeletion,
    [EnumMember(Value = "Never"), JsonStringEnumMemberName("Never")]
    /// <summary>Never</summary>
    Never
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsArtifactGC
{
    /// <summary></summary>
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("strategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha1WorkflowTaskResultOutputsArtifactsArtifactGCStrategyEnum>))]
    public V1alpha1WorkflowTaskResultOutputsArtifactsArtifactGCStrategyEnum? Strategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsArtifactoryPasswordSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsArtifactoryUsernameSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsArtifactory
{
    /// <summary></summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsAzureAccountKeySecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsAzure
{
    /// <summary></summary>
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("blob")]
    public string Blob { get; set; }

    /// <summary></summary>
    [JsonPropertyName("container")]
    public string Container { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsGcsServiceAccountKeySecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsGcs
{
    /// <summary></summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsGitPasswordSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsGitSshPrivateKeySecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsGitUsernameSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsGit
{
    /// <summary></summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsGitPasswordSecret? PasswordSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string Repo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary></summary>
    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHdfsKrbCCacheSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHdfsKrbConfigConfigMap
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHdfsKrbKeytabSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHdfs
{
    /// <summary></summary>
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthBasicAuthPasswordSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthBasicAuthUsernameSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthClientCertClientCertSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthClientCertClientKeySecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthClientCert
{
    /// <summary></summary>
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthOauth2ClientIDSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthOauth2ClientSecretSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthOauth2EndpointParams
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthOauth2TokenURLSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthOauth2
{
    /// <summary></summary>
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuth
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthClientCert? ClientCert { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsHttp
{
    /// <summary></summary>
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttpAuth? Auth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowTaskResultOutputsArtifactsHttpHeaders>? Headers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsOssAccessKeySecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsOssLifecycleRule
{
    /// <summary></summary>
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsOssSecretKeySecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsOss
{
    /// <summary></summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsRaw
{
    /// <summary></summary>
    [JsonPropertyName("data")]
    public string Data { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsS3AccessKeySecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsS3CaSecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsS3CreateBucketIfNotPresent
{
    /// <summary></summary>
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsS3EncryptionOptions
{
    /// <summary></summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsS3SecretKeySecret
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifactsS3
{
    /// <summary></summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsS3CaSecret? CaSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsArtifacts
{
    /// <summary></summary>
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsArchive? Archive { get; set; }

    /// <summary></summary>
    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsArtifactGC? ArtifactGC { get; set; }

    /// <summary></summary>
    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsArtifactory? Artifactory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azure")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsAzure? Azure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary></summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsGcs? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("git")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsGit? Git { get; set; }

    /// <summary></summary>
    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHdfs? Hdfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsHttp? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oss")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsOss? Oss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("raw")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsRaw? Raw { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public V1alpha1WorkflowTaskResultOutputsArtifactsS3? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsParametersValueFromConfigMapKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsParametersValueFromSupplied
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsParametersValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowTaskResultOutputsParametersValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary></summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jqFilter")]
    public string? JqFilter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supplied")]
    public V1alpha1WorkflowTaskResultOutputsParametersValueFromSupplied? Supplied { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputsParameters
{
    /// <summary></summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enum")]
    public IList<string>? Enum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowTaskResultOutputsParametersValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowTaskResultOutputs
{
    /// <summary></summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1WorkflowTaskResultOutputsArtifacts>? Artifacts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exitCode")]
    public string? ExitCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1WorkflowTaskResultOutputsParameters>? Parameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowTaskResult : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowTaskResult";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "workflowtaskresults";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outputs")]
    public V1alpha1WorkflowTaskResultOutputs? Outputs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("progress")]
    public string? Progress { get; set; }
}