using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lambda.aws.upbound.io;
public enum V1beta1CodeSigningConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolutionEnum>))]
    public V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolveEnum>))]
    public V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsRefsPolicy? Policy { get; set; }
}

public enum V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolutionEnum>))]
    public V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolveEnum>))]
    public V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SigningProfile in signer to populate signingProfileVersionArns.</summary>
public partial class V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1CodeSigningConfigSpecForProviderAllowedPublishers
{
    /// <summary>The Amazon Resource Name (ARN) for each of the signing profiles. A signing profile defines a trusted user who can sign a code package.</summary>
    [JsonPropertyName("signingProfileVersionArns")]
    public IList<string>? SigningProfileVersionArns { get; set; }

    /// <summary>References to SigningProfile in signer to populate signingProfileVersionArns.</summary>
    [JsonPropertyName("signingProfileVersionArnsRefs")]
    public IList<V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsRefs>? SigningProfileVersionArnsRefs { get; set; }

    /// <summary>Selector for a list of SigningProfile in signer to populate signingProfileVersionArns.</summary>
    [JsonPropertyName("signingProfileVersionArnsSelector")]
    public V1beta1CodeSigningConfigSpecForProviderAllowedPublishersSigningProfileVersionArnsSelector? SigningProfileVersionArnsSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1CodeSigningConfigSpecForProviderPolicies
{
    /// <summary>Code signing configuration policy for deployment validation failure. If you set the policy to Enforce, Lambda blocks the deployment request if code-signing validation checks fail. If you set the policy to Warn, Lambda allows the deployment and creates a CloudWatch log. Valid values: Warn, Enforce. Default value: Warn.</summary>
    [JsonPropertyName("untrustedArtifactOnDeployment")]
    public string? UntrustedArtifactOnDeployment { get; set; }
}

/// <summary></summary>
public partial class V1beta1CodeSigningConfigSpecForProvider
{
    /// <summary>A configuration block of allowed publishers as signing profiles for this code signing configuration. Detailed below.</summary>
    [JsonPropertyName("allowedPublishers")]
    public IList<V1beta1CodeSigningConfigSpecForProviderAllowedPublishers>? AllowedPublishers { get; set; }

    /// <summary>Descriptive name for this code signing configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A configuration block of code signing policies that define the actions to take if the validation checks fail. Detailed below.</summary>
    [JsonPropertyName("policies")]
    public IList<V1beta1CodeSigningConfigSpecForProviderPolicies>? Policies { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

public enum V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolutionEnum>))]
    public V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolveEnum>))]
    public V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
public partial class V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsRefsPolicy? Policy { get; set; }
}

public enum V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolutionEnum>))]
    public V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolveEnum>))]
    public V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SigningProfile in signer to populate signingProfileVersionArns.</summary>
public partial class V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1CodeSigningConfigSpecInitProviderAllowedPublishers
{
    /// <summary>The Amazon Resource Name (ARN) for each of the signing profiles. A signing profile defines a trusted user who can sign a code package.</summary>
    [JsonPropertyName("signingProfileVersionArns")]
    public IList<string>? SigningProfileVersionArns { get; set; }

    /// <summary>References to SigningProfile in signer to populate signingProfileVersionArns.</summary>
    [JsonPropertyName("signingProfileVersionArnsRefs")]
    public IList<V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsRefs>? SigningProfileVersionArnsRefs { get; set; }

    /// <summary>Selector for a list of SigningProfile in signer to populate signingProfileVersionArns.</summary>
    [JsonPropertyName("signingProfileVersionArnsSelector")]
    public V1beta1CodeSigningConfigSpecInitProviderAllowedPublishersSigningProfileVersionArnsSelector? SigningProfileVersionArnsSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1CodeSigningConfigSpecInitProviderPolicies
{
    /// <summary>Code signing configuration policy for deployment validation failure. If you set the policy to Enforce, Lambda blocks the deployment request if code-signing validation checks fail. If you set the policy to Warn, Lambda allows the deployment and creates a CloudWatch log. Valid values: Warn, Enforce. Default value: Warn.</summary>
    [JsonPropertyName("untrustedArtifactOnDeployment")]
    public string? UntrustedArtifactOnDeployment { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1CodeSigningConfigSpecInitProvider
{
    /// <summary>A configuration block of allowed publishers as signing profiles for this code signing configuration. Detailed below.</summary>
    [JsonPropertyName("allowedPublishers")]
    public IList<V1beta1CodeSigningConfigSpecInitProviderAllowedPublishers>? AllowedPublishers { get; set; }

    /// <summary>Descriptive name for this code signing configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A configuration block of code signing policies that define the actions to take if the validation checks fail. Detailed below.</summary>
    [JsonPropertyName("policies")]
    public IList<V1beta1CodeSigningConfigSpecInitProviderPolicies>? Policies { get; set; }
}

public enum V1beta1CodeSigningConfigSpecManagementPoliciesEnum
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

public enum V1beta1CodeSigningConfigSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CodeSigningConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CodeSigningConfigSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1CodeSigningConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1CodeSigningConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1CodeSigningConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodeSigningConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1CodeSigningConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1CodeSigningConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1CodeSigningConfigSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1CodeSigningConfigSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1CodeSigningConfigSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1CodeSigningConfigSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CodeSigningConfigSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1CodeSigningConfigSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
public partial class V1beta1CodeSigningConfigSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1CodeSigningConfigSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1CodeSigningConfigSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1CodeSigningConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>CodeSigningConfigSpec defines the desired state of CodeSigningConfig</summary>
public partial class V1beta1CodeSigningConfigSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1CodeSigningConfigSpecDeletionPolicyEnum>))]
    public V1beta1CodeSigningConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CodeSigningConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CodeSigningConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1CodeSigningConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CodeSigningConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1CodeSigningConfigSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CodeSigningConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1CodeSigningConfigStatusAtProviderAllowedPublishers
{
    /// <summary>The Amazon Resource Name (ARN) for each of the signing profiles. A signing profile defines a trusted user who can sign a code package.</summary>
    [JsonPropertyName("signingProfileVersionArns")]
    public IList<string>? SigningProfileVersionArns { get; set; }
}

/// <summary></summary>
public partial class V1beta1CodeSigningConfigStatusAtProviderPolicies
{
    /// <summary>Code signing configuration policy for deployment validation failure. If you set the policy to Enforce, Lambda blocks the deployment request if code-signing validation checks fail. If you set the policy to Warn, Lambda allows the deployment and creates a CloudWatch log. Valid values: Warn, Enforce. Default value: Warn.</summary>
    [JsonPropertyName("untrustedArtifactOnDeployment")]
    public string? UntrustedArtifactOnDeployment { get; set; }
}

/// <summary></summary>
public partial class V1beta1CodeSigningConfigStatusAtProvider
{
    /// <summary>A configuration block of allowed publishers as signing profiles for this code signing configuration. Detailed below.</summary>
    [JsonPropertyName("allowedPublishers")]
    public IList<V1beta1CodeSigningConfigStatusAtProviderAllowedPublishers>? AllowedPublishers { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the code signing configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Unique identifier for the code signing configuration.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>Descriptive name for this code signing configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The date and time that the code signing configuration was last modified.</summary>
    [JsonPropertyName("lastModified")]
    public string? LastModified { get; set; }

    /// <summary>A configuration block of code signing policies that define the actions to take if the validation checks fail. Detailed below.</summary>
    [JsonPropertyName("policies")]
    public IList<V1beta1CodeSigningConfigStatusAtProviderPolicies>? Policies { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1CodeSigningConfigStatusConditions
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

/// <summary>CodeSigningConfigStatus defines the observed state of CodeSigningConfig.</summary>
public partial class V1beta1CodeSigningConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CodeSigningConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CodeSigningConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>CodeSigningConfig is the Schema for the CodeSigningConfigs API. Provides a Lambda Code Signing Config resource.</summary>
public partial class V1beta1CodeSigningConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CodeSigningConfigSpec>, IStatus<V1beta1CodeSigningConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CodeSigningConfig";
    public const string KubeGroup = "lambda.aws.upbound.io";
    public const string KubePluralName = "codesigningconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CodeSigningConfigSpec defines the desired state of CodeSigningConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1CodeSigningConfigSpec Spec { get; set; }

    /// <summary>CodeSigningConfigStatus defines the observed state of CodeSigningConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1CodeSigningConfigStatus? Status { get; set; }
}