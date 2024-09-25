using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.image.toolkit.fluxcd.io;
/// <summary>FilterTags enables filtering for only a subset of tags based on a set of rules. If no rules are provided, all the tags from the repository will be ordered and compared.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePolicySpecFilterTags
{
    /// <summary>Extract allows a capture group to be extracted from the specified regular expression pattern, useful before tag evaluation.</summary>
    [JsonPropertyName("extract")]
    public string? Extract { get; set; }

    /// <summary>Pattern specifies a regular expression pattern used to filter for image tags.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>ImageRepositoryRef points at the object specifying the image being scanned</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePolicySpecImageRepositoryRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referent, when not specified it acts as LocalObjectReference.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Order specifies the sorting order of the tags. Given the letters of the alphabet as tags, ascending order would select Z, and descending order would select A.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ImagePolicySpecPolicyAlphabeticalOrderEnum
{
    [EnumMember(Value = "asc"), JsonStringEnumMemberName("asc")]
    /// <summary>asc</summary>
    Asc,
    [EnumMember(Value = "desc"), JsonStringEnumMemberName("desc")]
    /// <summary>desc</summary>
    Desc
}

/// <summary>Alphabetical set of rules to use for alphabetical ordering of the tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePolicySpecPolicyAlphabetical
{
    /// <summary>Order specifies the sorting order of the tags. Given the letters of the alphabet as tags, ascending order would select Z, and descending order would select A.</summary>
    [JsonPropertyName("order")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePolicySpecPolicyAlphabeticalOrderEnum>))]
    public V1beta2ImagePolicySpecPolicyAlphabeticalOrderEnum? Order { get; set; }
}

/// <summary>Order specifies the sorting order of the tags. Given the integer values from 0 to 9 as tags, ascending order would select 9, and descending order would select 0.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ImagePolicySpecPolicyNumericalOrderEnum
{
    [EnumMember(Value = "asc"), JsonStringEnumMemberName("asc")]
    /// <summary>asc</summary>
    Asc,
    [EnumMember(Value = "desc"), JsonStringEnumMemberName("desc")]
    /// <summary>desc</summary>
    Desc
}

/// <summary>Numerical set of rules to use for numerical ordering of the tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePolicySpecPolicyNumerical
{
    /// <summary>Order specifies the sorting order of the tags. Given the integer values from 0 to 9 as tags, ascending order would select 9, and descending order would select 0.</summary>
    [JsonPropertyName("order")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePolicySpecPolicyNumericalOrderEnum>))]
    public V1beta2ImagePolicySpecPolicyNumericalOrderEnum? Order { get; set; }
}

/// <summary>SemVer gives a semantic version range to check against the tags available.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePolicySpecPolicySemver
{
    /// <summary>Range gives a semver range for the image tag; the highest version within the range that's a tag yields the latest image.</summary>
    [JsonPropertyName("range")]
    public string Range { get; set; }
}

/// <summary>Policy gives the particulars of the policy to be followed in selecting the most recent image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePolicySpecPolicy
{
    /// <summary>Alphabetical set of rules to use for alphabetical ordering of the tags.</summary>
    [JsonPropertyName("alphabetical")]
    public V1beta2ImagePolicySpecPolicyAlphabetical? Alphabetical { get; set; }

    /// <summary>Numerical set of rules to use for numerical ordering of the tags.</summary>
    [JsonPropertyName("numerical")]
    public V1beta2ImagePolicySpecPolicyNumerical? Numerical { get; set; }

    /// <summary>SemVer gives a semantic version range to check against the tags available.</summary>
    [JsonPropertyName("semver")]
    public V1beta2ImagePolicySpecPolicySemver? Semver { get; set; }
}

/// <summary>ImagePolicySpec defines the parameters for calculating the ImagePolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePolicySpec
{
    /// <summary>FilterTags enables filtering for only a subset of tags based on a set of rules. If no rules are provided, all the tags from the repository will be ordered and compared.</summary>
    [JsonPropertyName("filterTags")]
    public V1beta2ImagePolicySpecFilterTags? FilterTags { get; set; }

    /// <summary>ImageRepositoryRef points at the object specifying the image being scanned</summary>
    [JsonPropertyName("imageRepositoryRef")]
    public V1beta2ImagePolicySpecImageRepositoryRef ImageRepositoryRef { get; set; }

    /// <summary>Policy gives the particulars of the policy to be followed in selecting the most recent image</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImagePolicySpecPolicy Policy { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta2ImagePolicyStatusConditionsStatusEnum
{
    [EnumMember(Value = "true"), JsonStringEnumMemberName("true")]
    /// <summary>true</summary>
    True,
    [EnumMember(Value = "false"), JsonStringEnumMemberName("false")]
    /// <summary>false</summary>
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    /// <summary>Unknown</summary>
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource. --- This struct is intended for direct use as an array at the field path .status.conditions.  For example,   	type FooStatus struct{ 	    // Represents the observations of a foo's current state. 	    // Known .status.conditions.type are: "Available", "Progressing", and "Degraded" 	    // +patchMergeKey=type 	    // +patchStrategy=merge 	    // +listType=map 	    // +listMapKey=type 	    Conditions []metav1.Condition `json:"conditions,omitempty" patchStrategy:"merge" patchMergeKey:"type" protobuf:"bytes,1,rep,name=conditions"`   	    // other fields 	}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePolicyStatusConditions
{
    /// <summary>lastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>message is a human readable message indicating details about the transition. This may be an empty string.</summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePolicyStatusConditionsStatusEnum>))]
    public V1beta2ImagePolicyStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase. --- Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to deconflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt)</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>ImagePolicyStatus defines the observed state of ImagePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ImagePolicyStatusConditions>? Conditions { get; set; }

    /// <summary>LatestImage gives the first in the list of images scanned by the image repository, when filtered and ordered according to the policy.</summary>
    [JsonPropertyName("latestImage")]
    public string? LatestImage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedPreviousImage is the observed previous LatestImage. It is used to keep track of the previous and current images.</summary>
    [JsonPropertyName("observedPreviousImage")]
    public string? ObservedPreviousImage { get; set; }
}

/// <summary>ImagePolicy is the Schema for the imagepolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ImagePolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ImagePolicySpec>, IStatus<V1beta2ImagePolicyStatus>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ImagePolicy";
    public const string KubeGroup = "image.toolkit.fluxcd.io";
    public const string KubePluralName = "imagepolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImagePolicySpec defines the parameters for calculating the ImagePolicy.</summary>
    [JsonPropertyName("spec")]
    public V1beta2ImagePolicySpec? Spec { get; set; }

    /// <summary>ImagePolicyStatus defines the observed state of ImagePolicy</summary>
    [JsonPropertyName("status")]
    public V1beta2ImagePolicyStatus? Status { get; set; }
}