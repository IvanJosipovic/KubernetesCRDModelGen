using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pkg.crossplane.io;
/// <summary>ImageMatch defines a rule for matching image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecMatchImages
{
    /// <summary>Prefix is the prefix that should be matched.</summary>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; }

    /// <summary>Type is the type of match.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PullSecretRef is a reference to a secret that contains the credentials for the registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecRegistryAuthenticationPullSecretRef
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Authentication is the authentication information for the registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecRegistryAuthentication
{
    /// <summary>PullSecretRef is a reference to a secret that contains the credentials for the registry.</summary>
    [JsonPropertyName("pullSecretRef")]
    public V1beta1ImageConfigSpecRegistryAuthenticationPullSecretRef PullSecretRef { get; set; }
}

/// <summary>Registry is the configuration for the registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecRegistry
{
    /// <summary>Authentication is the authentication information for the registry.</summary>
    [JsonPropertyName("authentication")]
    public V1beta1ImageConfigSpecRegistryAuthentication? Authentication { get; set; }
}

/// <summary>Attestation defines the type of attestation to validate and optionally apply a policy decision to it. Authority block is used to verify the specified attestation types, and if Policy is specified, then it's applied only after the validation of the Attestation signature has been verified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecVerificationCosignAuthoritiesAttestations
{
    /// <summary>Name of the attestation.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>PredicateType defines which predicate type to verify. Matches cosign verify-attestation options.</summary>
    [JsonPropertyName("predicateType")]
    public string PredicateType { get; set; }
}

/// <summary>SecretRef sets a reference to a secret with the key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecVerificationCosignAuthoritiesKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Key defines the type of key to validate the image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecVerificationCosignAuthoritiesKey
{
    /// <summary>HashAlgorithm always defaults to sha256 if the algorithm hasn't been explicitly set</summary>
    [JsonPropertyName("hashAlgorithm")]
    public string HashAlgorithm { get; set; }

    /// <summary>SecretRef sets a reference to a secret with the key.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1ImageConfigSpecVerificationCosignAuthoritiesKeySecretRef SecretRef { get; set; }
}

/// <summary>Identity may contain the issuer and/or the subject found in the transparency log. Issuer/Subject uses a strict match, while IssuerRegExp and SubjectRegExp apply a regexp for matching.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecVerificationCosignAuthoritiesKeylessIdentities
{
    /// <summary>Issuer defines the issuer for this identity.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>IssuerRegExp specifies a regular expression to match the issuer for this identity. This has precedence over the Issuer field.</summary>
    [JsonPropertyName("issuerRegExp")]
    public string? IssuerRegExp { get; set; }

    /// <summary>Subject defines the subject for this identity.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>SubjectRegExp specifies a regular expression to match the subject for this identity. This has precedence over the Subject field.</summary>
    [JsonPropertyName("subjectRegExp")]
    public string? SubjectRegExp { get; set; }
}

/// <summary>Keyless sets the configuration to verify the authority against a Fulcio instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecVerificationCosignAuthoritiesKeyless
{
    /// <summary>Identities sets a list of identities.</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1ImageConfigSpecVerificationCosignAuthoritiesKeylessIdentities> Identities { get; set; }

    /// <summary>InsecureIgnoreSCT omits verifying if a certificate contains an embedded SCT</summary>
    [JsonPropertyName("insecureIgnoreSCT")]
    public bool? InsecureIgnoreSCT { get; set; }
}

/// <summary>CosignAuthority defines the rules for discovering and validating signatures.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecVerificationCosignAuthorities
{
    /// <summary>Attestations is a list of individual attestations for this authority, once the signature for this authority has been verified.</summary>
    [JsonPropertyName("attestations")]
    public IList<V1beta1ImageConfigSpecVerificationCosignAuthoritiesAttestations>? Attestations { get; set; }

    /// <summary>Key defines the type of key to validate the image.</summary>
    [JsonPropertyName("key")]
    public V1beta1ImageConfigSpecVerificationCosignAuthoritiesKey? Key { get; set; }

    /// <summary>Keyless sets the configuration to verify the authority against a Fulcio instance.</summary>
    [JsonPropertyName("keyless")]
    public V1beta1ImageConfigSpecVerificationCosignAuthoritiesKeyless? Keyless { get; set; }

    /// <summary>Name is the name for this authority.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Cosign is the configuration for verifying the image using cosign.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecVerificationCosign
{
    /// <summary>Authorities defines the rules for discovering and validating signatures.</summary>
    [JsonPropertyName("authorities")]
    public IList<V1beta1ImageConfigSpecVerificationCosignAuthorities> Authorities { get; set; }
}

/// <summary>Verification contains the configuration for verifying the image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpecVerification
{
    /// <summary>Cosign is the configuration for verifying the image using cosign.</summary>
    [JsonPropertyName("cosign")]
    public V1beta1ImageConfigSpecVerificationCosign? Cosign { get; set; }

    /// <summary>Provider is the provider that should be used to verify the image.</summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }
}

/// <summary>ImageConfigSpec contains the configuration for matching images.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ImageConfigSpec
{
    /// <summary>MatchImages is a list of image matching rules that should be satisfied.</summary>
    [JsonPropertyName("matchImages")]
    public IList<V1beta1ImageConfigSpecMatchImages> MatchImages { get; set; }

    /// <summary>Registry is the configuration for the registry.</summary>
    [JsonPropertyName("registry")]
    public V1beta1ImageConfigSpecRegistry? Registry { get; set; }

    /// <summary>Verification contains the configuration for verifying the image.</summary>
    [JsonPropertyName("verification")]
    public V1beta1ImageConfigSpecVerification? Verification { get; set; }
}

/// <summary>The ImageConfig resource is used to configure settings for package images.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ImageConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ImageConfigSpec>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ImageConfig";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "imageconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageConfigSpec contains the configuration for matching images.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ImageConfigSpec? Spec { get; set; }
}