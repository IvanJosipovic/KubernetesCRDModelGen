using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cognitoidp.aws.upbound.io;
public enum V1beta1UserPoolUICustomizationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1UserPoolUICustomizationSpecForProviderClientIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolUICustomizationSpecForProviderClientIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolUICustomizationSpecForProviderClientIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecForProviderClientIdRefPolicyResolutionEnum>))]
    public V1beta1UserPoolUICustomizationSpecForProviderClientIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecForProviderClientIdRefPolicyResolveEnum>))]
    public V1beta1UserPoolUICustomizationSpecForProviderClientIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecForProviderClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolUICustomizationSpecForProviderClientIdRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolUICustomizationSpecForProviderClientIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolUICustomizationSpecForProviderClientIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolUICustomizationSpecForProviderClientIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecForProviderClientIdSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolUICustomizationSpecForProviderClientIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecForProviderClientIdSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolUICustomizationSpecForProviderClientIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecForProviderClientIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolUICustomizationSpecForProviderClientIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdRefPolicyResolutionEnum>))]
    public V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdRefPolicyResolveEnum>))]
    public V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecForProvider
{
    /// <summary>The client ID for the client app. Defaults to ALL. If ALL is specified, the css and/or image_file settings will be used for every client that has no UI customization set previously.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Reference to a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdRef")]
    public V1beta1UserPoolUICustomizationSpecForProviderClientIdRef? ClientIdRef { get; set; }

    /// <summary>Selector for a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdSelector")]
    public V1beta1UserPoolUICustomizationSpecForProviderClientIdSelector? ClientIdSelector { get; set; }

    /// <summary>The CSS values in the UI customization, provided as a String. At least one of css or image_file is required.</summary>
    [JsonPropertyName("css")]
    public string? Css { get; set; }

    /// <summary>The uploaded logo image for the UI customization, provided as a base64-encoded String. Drift detection is not possible for this argument. At least one of css or image_file is required.</summary>
    [JsonPropertyName("imageFile")]
    public string? ImageFile { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The user pool ID for the user pool.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta1UserPoolUICustomizationSpecForProviderUserPoolIdSelector? UserPoolIdSelector { get; set; }
}

public enum V1beta1UserPoolUICustomizationSpecInitProviderClientIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolUICustomizationSpecInitProviderClientIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolUICustomizationSpecInitProviderClientIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecInitProviderClientIdRefPolicyResolutionEnum>))]
    public V1beta1UserPoolUICustomizationSpecInitProviderClientIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecInitProviderClientIdRefPolicyResolveEnum>))]
    public V1beta1UserPoolUICustomizationSpecInitProviderClientIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecInitProviderClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolUICustomizationSpecInitProviderClientIdRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolUICustomizationSpecInitProviderClientIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolUICustomizationSpecInitProviderClientIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolUICustomizationSpecInitProviderClientIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecInitProviderClientIdSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolUICustomizationSpecInitProviderClientIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecInitProviderClientIdSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolUICustomizationSpecInitProviderClientIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecInitProviderClientIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolUICustomizationSpecInitProviderClientIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdRefPolicyResolutionEnum>))]
    public V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdRefPolicyResolveEnum>))]
    public V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdSelectorPolicyResolutionEnum>))]
    public V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdSelectorPolicyResolveEnum>))]
    public V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecInitProvider
{
    /// <summary>The client ID for the client app. Defaults to ALL. If ALL is specified, the css and/or image_file settings will be used for every client that has no UI customization set previously.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Reference to a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdRef")]
    public V1beta1UserPoolUICustomizationSpecInitProviderClientIdRef? ClientIdRef { get; set; }

    /// <summary>Selector for a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdSelector")]
    public V1beta1UserPoolUICustomizationSpecInitProviderClientIdSelector? ClientIdSelector { get; set; }

    /// <summary>The CSS values in the UI customization, provided as a String. At least one of css or image_file is required.</summary>
    [JsonPropertyName("css")]
    public string? Css { get; set; }

    /// <summary>The uploaded logo image for the UI customization, provided as a base64-encoded String. Drift detection is not possible for this argument. At least one of css or image_file is required.</summary>
    [JsonPropertyName("imageFile")]
    public string? ImageFile { get; set; }

    /// <summary>The user pool ID for the user pool.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta1UserPoolUICustomizationSpecInitProviderUserPoolIdSelector? UserPoolIdSelector { get; set; }
}

public enum V1beta1UserPoolUICustomizationSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1UserPoolUICustomizationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolUICustomizationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolUICustomizationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1UserPoolUICustomizationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1UserPoolUICustomizationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolUICustomizationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1UserPoolUICustomizationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1UserPoolUICustomizationSpecDeletionPolicyEnum>))]
    public V1beta1UserPoolUICustomizationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1UserPoolUICustomizationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1UserPoolUICustomizationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1UserPoolUICustomizationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1UserPoolUICustomizationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1UserPoolUICustomizationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1UserPoolUICustomizationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1UserPoolUICustomizationStatusAtProvider
{
    /// <summary>The client ID for the client app. Defaults to ALL. If ALL is specified, the css and/or image_file settings will be used for every client that has no UI customization set previously.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The creation date in RFC3339 format for the UI customization.</summary>
    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    /// <summary>The CSS values in the UI customization, provided as a String. At least one of css or image_file is required.</summary>
    [JsonPropertyName("css")]
    public string? Css { get; set; }

    /// <summary>The CSS version number.</summary>
    [JsonPropertyName("cssVersion")]
    public string? CssVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The uploaded logo image for the UI customization, provided as a base64-encoded String. Drift detection is not possible for this argument. At least one of css or image_file is required.</summary>
    [JsonPropertyName("imageFile")]
    public string? ImageFile { get; set; }

    /// <summary>The logo image URL for the UI customization.</summary>
    [JsonPropertyName("imageUrl")]
    public string? ImageUrl { get; set; }

    /// <summary>The last-modified date in RFC3339 format for the UI customization.</summary>
    [JsonPropertyName("lastModifiedDate")]
    public string? LastModifiedDate { get; set; }

    /// <summary>The user pool ID for the user pool.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

public partial class V1beta1UserPoolUICustomizationStatusConditions
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

public partial class V1beta1UserPoolUICustomizationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1UserPoolUICustomizationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1UserPoolUICustomizationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1UserPoolUICustomization : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1UserPoolUICustomizationSpec>, IStatus<V1beta1UserPoolUICustomizationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "UserPoolUICustomization";
    public const string KubeGroup = "cognitoidp.aws.upbound.io";
    public const string KubePluralName = "userpooluicustomizations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserPoolUICustomizationSpec defines the desired state of UserPoolUICustomization</summary>
    [JsonPropertyName("spec")]
    public V1beta1UserPoolUICustomizationSpec Spec { get; set; }

    /// <summary>UserPoolUICustomizationStatus defines the observed state of UserPoolUICustomization.</summary>
    [JsonPropertyName("status")]
    public V1beta1UserPoolUICustomizationStatus? Status { get; set; }
}