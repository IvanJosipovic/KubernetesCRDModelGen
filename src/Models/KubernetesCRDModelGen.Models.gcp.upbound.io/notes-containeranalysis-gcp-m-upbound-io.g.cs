using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containeranalysis.gcp.m.upbound.io;
#nullable enable
/// <summary>Note is the Schema for the Notes API. A Container Analysis note is a high-level piece of metadata that describes a type of analysis that can be done for a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NoteList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Note>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NoteList";
    public const string KubeGroup = "containeranalysis.gcp.m.upbound.io";
    public const string KubePluralName = "notes";
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
    public IList<V1beta1Note> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>This submessage provides human-readable hints about the purpose of the AttestationAuthority. Because the name of a Note acts as its resource reference, it is important to disambiguate the canonical name of the Note (which might be a UUID for security purposes) from "readable" names more suitable for debug output. Note that these hints should NOT be used to look up AttestationAuthorities in security sensitive contexts, such as when looking up Attestations to verify. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteSpecForProviderAttestationAuthorityHint
{
    /// <summary>The human readable name of this Attestation Authority, for example "qa".</summary>
    [JsonPropertyName("humanReadableName")]
    public string? HumanReadableName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Note kind that represents a logical attestation "role" or "authority". For example, an organization might have one AttestationAuthority for "QA" and one for "build". This Note is intended to act strictly as a grouping mechanism for the attached Occurrences (Attestations). This grouping mechanism also provides a security boundary, since IAM ACLs gate the ability for a principle to attach an Occurrence to a given Note. It also provides a single point of lookup to find all attached Attestation Occurrences, even if they don't all live in the same project. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteSpecForProviderAttestationAuthority
{
    /// <summary>This submessage provides human-readable hints about the purpose of the AttestationAuthority. Because the name of a Note acts as its resource reference, it is important to disambiguate the canonical name of the Note (which might be a UUID for security purposes) from "readable" names more suitable for debug output. Note that these hints should NOT be used to look up AttestationAuthorities in security sensitive contexts, such as when looking up Attestations to verify. Structure is documented below.</summary>
    [JsonPropertyName("hint")]
    public V1beta1NoteSpecForProviderAttestationAuthorityHint? Hint { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteSpecForProviderRelatedUrl
{
    /// <summary>Label to describe usage of the URL</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Specific URL associated with the resource.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteSpecForProvider
{
    /// <summary>Note kind that represents a logical attestation "role" or "authority". For example, an organization might have one AttestationAuthority for "QA" and one for "build". This Note is intended to act strictly as a grouping mechanism for the attached Occurrences (Attestations). This grouping mechanism also provides a security boundary, since IAM ACLs gate the ability for a principle to attach an Occurrence to a given Note. It also provides a single point of lookup to find all attached Attestation Occurrences, even if they don't all live in the same project. Structure is documented below.</summary>
    [JsonPropertyName("attestationAuthority")]
    public V1beta1NoteSpecForProviderAttestationAuthority? AttestationAuthority { get; set; }

    /// <summary>Time of expiration for this note. Leave empty if note does not expire.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>A detailed description of the note</summary>
    [JsonPropertyName("longDescription")]
    public string? LongDescription { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Names of other notes related to this note.</summary>
    [JsonPropertyName("relatedNoteNames")]
    public IList<string>? RelatedNoteNames { get; set; }

    /// <summary>URLs associated with this note and related metadata. Structure is documented below.</summary>
    [JsonPropertyName("relatedUrl")]
    public IList<V1beta1NoteSpecForProviderRelatedUrl>? RelatedUrl { get; set; }

    /// <summary>A one sentence description of the note.</summary>
    [JsonPropertyName("shortDescription")]
    public string? ShortDescription { get; set; }
}
#nullable disable

#nullable enable
/// <summary>This submessage provides human-readable hints about the purpose of the AttestationAuthority. Because the name of a Note acts as its resource reference, it is important to disambiguate the canonical name of the Note (which might be a UUID for security purposes) from "readable" names more suitable for debug output. Note that these hints should NOT be used to look up AttestationAuthorities in security sensitive contexts, such as when looking up Attestations to verify. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteSpecInitProviderAttestationAuthorityHint
{
    /// <summary>The human readable name of this Attestation Authority, for example "qa".</summary>
    [JsonPropertyName("humanReadableName")]
    public string? HumanReadableName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Note kind that represents a logical attestation "role" or "authority". For example, an organization might have one AttestationAuthority for "QA" and one for "build". This Note is intended to act strictly as a grouping mechanism for the attached Occurrences (Attestations). This grouping mechanism also provides a security boundary, since IAM ACLs gate the ability for a principle to attach an Occurrence to a given Note. It also provides a single point of lookup to find all attached Attestation Occurrences, even if they don't all live in the same project. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteSpecInitProviderAttestationAuthority
{
    /// <summary>This submessage provides human-readable hints about the purpose of the AttestationAuthority. Because the name of a Note acts as its resource reference, it is important to disambiguate the canonical name of the Note (which might be a UUID for security purposes) from "readable" names more suitable for debug output. Note that these hints should NOT be used to look up AttestationAuthorities in security sensitive contexts, such as when looking up Attestations to verify. Structure is documented below.</summary>
    [JsonPropertyName("hint")]
    public V1beta1NoteSpecInitProviderAttestationAuthorityHint? Hint { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteSpecInitProviderRelatedUrl
{
    /// <summary>Label to describe usage of the URL</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Specific URL associated with the resource.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteSpecInitProvider
{
    /// <summary>Note kind that represents a logical attestation "role" or "authority". For example, an organization might have one AttestationAuthority for "QA" and one for "build". This Note is intended to act strictly as a grouping mechanism for the attached Occurrences (Attestations). This grouping mechanism also provides a security boundary, since IAM ACLs gate the ability for a principle to attach an Occurrence to a given Note. It also provides a single point of lookup to find all attached Attestation Occurrences, even if they don't all live in the same project. Structure is documented below.</summary>
    [JsonPropertyName("attestationAuthority")]
    public V1beta1NoteSpecInitProviderAttestationAuthority? AttestationAuthority { get; set; }

    /// <summary>Time of expiration for this note. Leave empty if note does not expire.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>A detailed description of the note</summary>
    [JsonPropertyName("longDescription")]
    public string? LongDescription { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Names of other notes related to this note.</summary>
    [JsonPropertyName("relatedNoteNames")]
    public IList<string>? RelatedNoteNames { get; set; }

    /// <summary>URLs associated with this note and related metadata. Structure is documented below.</summary>
    [JsonPropertyName("relatedUrl")]
    public IList<V1beta1NoteSpecInitProviderRelatedUrl>? RelatedUrl { get; set; }

    /// <summary>A one sentence description of the note.</summary>
    [JsonPropertyName("shortDescription")]
    public string? ShortDescription { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>NoteSpec defines the desired state of Note</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NoteSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NoteSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NoteSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NoteSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>This submessage provides human-readable hints about the purpose of the AttestationAuthority. Because the name of a Note acts as its resource reference, it is important to disambiguate the canonical name of the Note (which might be a UUID for security purposes) from "readable" names more suitable for debug output. Note that these hints should NOT be used to look up AttestationAuthorities in security sensitive contexts, such as when looking up Attestations to verify. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteStatusAtProviderAttestationAuthorityHint
{
    /// <summary>The human readable name of this Attestation Authority, for example "qa".</summary>
    [JsonPropertyName("humanReadableName")]
    public string? HumanReadableName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Note kind that represents a logical attestation "role" or "authority". For example, an organization might have one AttestationAuthority for "QA" and one for "build". This Note is intended to act strictly as a grouping mechanism for the attached Occurrences (Attestations). This grouping mechanism also provides a security boundary, since IAM ACLs gate the ability for a principle to attach an Occurrence to a given Note. It also provides a single point of lookup to find all attached Attestation Occurrences, even if they don't all live in the same project. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteStatusAtProviderAttestationAuthority
{
    /// <summary>This submessage provides human-readable hints about the purpose of the AttestationAuthority. Because the name of a Note acts as its resource reference, it is important to disambiguate the canonical name of the Note (which might be a UUID for security purposes) from "readable" names more suitable for debug output. Note that these hints should NOT be used to look up AttestationAuthorities in security sensitive contexts, such as when looking up Attestations to verify. Structure is documented below.</summary>
    [JsonPropertyName("hint")]
    public V1beta1NoteStatusAtProviderAttestationAuthorityHint? Hint { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteStatusAtProviderRelatedUrl
{
    /// <summary>Label to describe usage of the URL</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Specific URL associated with the resource.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteStatusAtProvider
{
    /// <summary>Note kind that represents a logical attestation "role" or "authority". For example, an organization might have one AttestationAuthority for "QA" and one for "build". This Note is intended to act strictly as a grouping mechanism for the attached Occurrences (Attestations). This grouping mechanism also provides a security boundary, since IAM ACLs gate the ability for a principle to attach an Occurrence to a given Note. It also provides a single point of lookup to find all attached Attestation Occurrences, even if they don't all live in the same project. Structure is documented below.</summary>
    [JsonPropertyName("attestationAuthority")]
    public V1beta1NoteStatusAtProviderAttestationAuthority? AttestationAuthority { get; set; }

    /// <summary>The time this note was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Time of expiration for this note. Leave empty if note does not expire.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/notes/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of analysis this note describes</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>A detailed description of the note</summary>
    [JsonPropertyName("longDescription")]
    public string? LongDescription { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Names of other notes related to this note.</summary>
    [JsonPropertyName("relatedNoteNames")]
    public IList<string>? RelatedNoteNames { get; set; }

    /// <summary>URLs associated with this note and related metadata. Structure is documented below.</summary>
    [JsonPropertyName("relatedUrl")]
    public IList<V1beta1NoteStatusAtProviderRelatedUrl>? RelatedUrl { get; set; }

    /// <summary>A one sentence description of the note.</summary>
    [JsonPropertyName("shortDescription")]
    public string? ShortDescription { get; set; }

    /// <summary>The time this note was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteStatusConditions
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
/// <summary>NoteStatus defines the observed state of Note.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NoteStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NoteStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NoteStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Note is the Schema for the Notes API. A Container Analysis note is a high-level piece of metadata that describes a type of analysis that can be done for a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Note : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NoteSpec>, IStatus<V1beta1NoteStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Note";
    public const string KubeGroup = "containeranalysis.gcp.m.upbound.io";
    public const string KubePluralName = "notes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NoteSpec defines the desired state of Note</summary>
    [JsonPropertyName("spec")]
    public V1beta1NoteSpec Spec { get; set; }

    /// <summary>NoteStatus defines the observed state of Note.</summary>
    [JsonPropertyName("status")]
    public V1beta1NoteStatus? Status { get; set; }
}
#nullable disable
