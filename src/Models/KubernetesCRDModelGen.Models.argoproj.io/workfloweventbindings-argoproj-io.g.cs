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
public partial class V1alpha1WorkflowEventBindingSpecEvent
{
    /// <summary></summary>
    [JsonPropertyName("selector")]
    public string Selector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveNone
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveTar
{
    /// <summary></summary>
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveZip
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchive
{
    /// <summary></summary>
    [JsonPropertyName("none")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveNone? None { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tar")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveTar? Tar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zip")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveZip? Zip { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactGCPodMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactGC
{
    /// <summary></summary>
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactoryPasswordSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactoryUsernameSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactory
{
    /// <summary></summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsAzureAccountKeySecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsAzure
{
    /// <summary></summary>
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGcsServiceAccountKeySecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGcs
{
    /// <summary></summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitPasswordSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitSshPrivateKeySecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitUsernameSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGit
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
    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitPasswordSecret? PasswordSecret { get; set; }

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
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbCCacheSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbConfigConfigMap
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbKeytabSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfs
{
    /// <summary></summary>
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuthPasswordSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuthUsernameSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCertClientCertSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCertClientKeySecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCert
{
    /// <summary></summary>
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2ClientIDSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2ClientSecretSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2EndpointParams
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2TokenURLSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2
{
    /// <summary></summary>
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuth
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCert? ClientCert { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpHeaders
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttp
{
    /// <summary></summary>
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuth? Auth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpHeaders>? Headers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssAccessKeySecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssLifecycleRule
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssSecretKeySecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOss
{
    /// <summary></summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

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
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsRaw
{
    /// <summary></summary>
    [JsonPropertyName("data")]
    public string Data { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3AccessKeySecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3CaSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3CreateBucketIfNotPresent
{
    /// <summary></summary>
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3EncryptionOptions
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
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3SecretKeySecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3SessionTokenSecret
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3
{
    /// <summary></summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3CaSecret? CaSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

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
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifacts
{
    /// <summary></summary>
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchive? Archive { get; set; }

    /// <summary></summary>
    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactGC? ArtifactGC { get; set; }

    /// <summary></summary>
    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactory? Artifactory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azure")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsAzure? Azure { get; set; }

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
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGcs? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("git")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGit? Git { get; set; }

    /// <summary></summary>
    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfs? Hdfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttp? Http { get; set; }

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
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOss? Oss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("raw")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsRaw? Raw { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFromConfigMapKeyRef
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
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFromSupplied
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFrom
{
    /// <summary></summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

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
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFromSupplied? Supplied { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsParameters
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
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArguments
{
    /// <summary></summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifacts>? Artifacts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1WorkflowEventBindingSpecSubmitArgumentsParameters>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generateName")]
    public string? GenerateName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitWorkflowTemplateRef
{
    /// <summary></summary>
    [JsonPropertyName("clusterScope")]
    public bool? ClusterScope { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmit
{
    /// <summary></summary>
    [JsonPropertyName("arguments")]
    public V1alpha1WorkflowEventBindingSpecSubmitArguments? Arguments { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1alpha1WorkflowEventBindingSpecSubmitMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workflowTemplateRef")]
    public V1alpha1WorkflowEventBindingSpecSubmitWorkflowTemplateRef WorkflowTemplateRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpec
{
    /// <summary></summary>
    [JsonPropertyName("event")]
    public V1alpha1WorkflowEventBindingSpecEvent Event { get; set; }

    /// <summary></summary>
    [JsonPropertyName("submit")]
    public V1alpha1WorkflowEventBindingSpecSubmit? Submit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowEventBinding : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WorkflowEventBindingSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowEventBinding";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "workfloweventbindings";
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
    [JsonPropertyName("spec")]
    public V1alpha1WorkflowEventBindingSpec Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowEventBindingList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1WorkflowEventBinding>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowEventBindingList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "workfloweventbindings";
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
    public IList<V1alpha1WorkflowEventBinding> Items { get; set; }
}