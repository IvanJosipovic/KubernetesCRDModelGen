using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.argoproj.io;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowArtifactGCTaskList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1WorkflowArtifactGCTask>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowArtifactGCTaskList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "workflowartifactgctasks";
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
    public IList<V1alpha1WorkflowArtifactGCTask> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactoryPasswordSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactoryUsernameSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactory
{
    /// <summary></summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactoryPasswordSecret? PasswordSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactoryUsernameSecret? UsernameSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationAzureAccountKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationAzure
{
    /// <summary></summary>
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationAzureAccountKeySecret? AccountKeySecret { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGcsServiceAccountKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGcs
{
    /// <summary></summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitPasswordSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitSshPrivateKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitUsernameSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGit
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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitPasswordSecret? PasswordSecret { get; set; }

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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitUsernameSecret? UsernameSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbCCacheSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbConfigConfigMap
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbKeytabSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfs
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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuthPasswordSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuthUsernameSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCertClientCertSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCertClientKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCert
{
    /// <summary></summary>
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2ClientIDSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2ClientSecretSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2EndpointParams
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2TokenURLSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2
{
    /// <summary></summary>
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuth
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCert? ClientCert { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2? Oauth2 { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttp
{
    /// <summary></summary>
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuth? Auth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpHeaders>? Headers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssAccessKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssLifecycleRule
{
    /// <summary></summary>
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssSecretKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOss
{
    /// <summary></summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssAccessKeySecret? AccessKeySecret { get; set; }

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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssLifecycleRule? LifecycleRule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssSecretKeySecret? SecretKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationRaw
{
    /// <summary></summary>
    [JsonPropertyName("data")]
    public string Data { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3AccessKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3CaSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3CreateBucketIfNotPresent
{
    /// <summary></summary>
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3EncryptionOptionsServerSideCustomerKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3EncryptionOptions
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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3SecretKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3SessionTokenSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3
{
    /// <summary></summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3AccessKeySecret? AccessKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3CaSecret? CaSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3EncryptionOptions? EncryptionOptions { get; set; }

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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3SecretKeySecret? SecretKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3SessionTokenSecret? SessionTokenSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocation
{
    /// <summary></summary>
    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactory? Artifactory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azure")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationAzure? Azure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGcs? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("git")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGit? Git { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfs? Hdfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttp? Http { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oss")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOss? Oss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("raw")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationRaw? Raw { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3? S3 { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveNone
{
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveTar
{
    /// <summary></summary>
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveZip
{
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchive
{
    /// <summary></summary>
    [JsonPropertyName("none")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveNone? None { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tar")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveTar? Tar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zip")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveZip? Zip { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactGCPodMetadata
{
    /// <summary></summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactGC
{
    /// <summary></summary>
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactoryPasswordSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactoryUsernameSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactory
{
    /// <summary></summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsAzureAccountKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsAzure
{
    /// <summary></summary>
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGcsServiceAccountKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGcs
{
    /// <summary></summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitPasswordSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitSshPrivateKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitUsernameSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGit
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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitPasswordSecret? PasswordSecret { get; set; }

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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbCCacheSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbConfigConfigMap
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbKeytabSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfs
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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    /// <summary></summary>
    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuthPasswordSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuthUsernameSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCertClientCertSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCertClientKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCert
{
    /// <summary></summary>
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2ClientIDSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2ClientSecretSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2EndpointParams
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2TokenURLSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2
{
    /// <summary></summary>
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuth
{
    /// <summary></summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCert? ClientCert { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpHeaders
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttp
{
    /// <summary></summary>
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuth? Auth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpHeaders>? Headers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssAccessKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssLifecycleRule
{
    /// <summary></summary>
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    /// <summary></summary>
    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssSecretKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOss
{
    /// <summary></summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsRaw
{
    /// <summary></summary>
    [JsonPropertyName("data")]
    public string Data { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3AccessKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3CaSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3CreateBucketIfNotPresent
{
    /// <summary></summary>
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3EncryptionOptions
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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3SecretKeySecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3SessionTokenSecret
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3
{
    /// <summary></summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3CaSecret? CaSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifacts
{
    /// <summary></summary>
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchive? Archive { get; set; }

    /// <summary></summary>
    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactGC? ArtifactGC { get; set; }

    /// <summary></summary>
    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactory? Artifactory { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azure")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsAzure? Azure { get; set; }

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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGcs? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("git")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGit? Git { get; set; }

    /// <summary></summary>
    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfs? Hdfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttp? Http { get; set; }

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
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOss? Oss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("raw")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsRaw? Raw { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNode
{
    /// <summary></summary>
    [JsonPropertyName("archiveLocation")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocation? ArchiveLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("artifacts")]
    public IDictionary<string, V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifacts>? Artifacts { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpec
{
    /// <summary></summary>
    [JsonPropertyName("artifactsByNode")]
    public IDictionary<string, V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNode>? ArtifactsByNode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskStatusArtifactResultsByNodeArtifactResults
{
    /// <summary></summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskStatusArtifactResultsByNode
{
    /// <summary></summary>
    [JsonPropertyName("artifactResults")]
    public IDictionary<string, V1alpha1WorkflowArtifactGCTaskStatusArtifactResultsByNodeArtifactResults>? ArtifactResults { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskStatus
{
    /// <summary></summary>
    [JsonPropertyName("artifactResultsByNode")]
    public IDictionary<string, V1alpha1WorkflowArtifactGCTaskStatusArtifactResultsByNode>? ArtifactResultsByNode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowArtifactGCTask : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WorkflowArtifactGCTaskSpec>, IStatus<V1alpha1WorkflowArtifactGCTaskStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowArtifactGCTask";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "workflowartifactgctasks";
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
    public V1alpha1WorkflowArtifactGCTaskSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1WorkflowArtifactGCTaskStatus? Status { get; set; }
}
#nullable disable
