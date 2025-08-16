using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.configservice.aws.upbound.io;
/// <summary>ConfigurationRecorder is the Schema for the ConfigurationRecorders API. Provides an AWS Config Configuration Recorder.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigurationRecorderList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ConfigurationRecorder>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigurationRecorderList";
    public const string KubeGroup = "configservice.aws.upbound.io";
    public const string KubePluralName = "configurationrecorders";
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
    public IList<V1beta1ConfigurationRecorder> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecForProviderRecordingGroupExclusionByResourceTypes
{
    /// <summary>A list that specifies the types of AWS resources for which AWS Config excludes records configuration changes. See relevant part of AWS Docs for available types.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecForProviderRecordingGroupRecordingStrategy
{
    /// <summary></summary>
    [JsonPropertyName("useOnly")]
    public string? UseOnly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecForProviderRecordingGroup
{
    /// <summary>Specifies whether AWS Config records configuration changes for every supported type of regional resource (which includes any new type that will become supported in the future). Conflicts with resource_types. Defaults to true.</summary>
    [JsonPropertyName("allSupported")]
    public bool? AllSupported { get; set; }

    /// <summary>An object that specifies how AWS Config excludes resource types from being recorded by the configuration recorder.To use this option, you must set the useOnly field of RecordingStrategy to EXCLUSION_BY_RESOURCE_TYPES Requires all_supported = false. Conflicts with resource_types.</summary>
    [JsonPropertyName("exclusionByResourceTypes")]
    public IList<V1beta1ConfigurationRecorderSpecForProviderRecordingGroupExclusionByResourceTypes>? ExclusionByResourceTypes { get; set; }

    /// <summary>Specifies whether AWS Config includes all supported types of global resources with the resources that it records. Requires all_supported = true. Conflicts with resource_types.</summary>
    [JsonPropertyName("includeGlobalResourceTypes")]
    public bool? IncludeGlobalResourceTypes { get; set; }

    /// <summary>Recording Strategy. Detailed below.</summary>
    [JsonPropertyName("recordingStrategy")]
    public IList<V1beta1ConfigurationRecorderSpecForProviderRecordingGroupRecordingStrategy>? RecordingStrategy { get; set; }

    /// <summary>A list that specifies the types of AWS resources for which AWS Config records configuration changes (for example, AWS::EC2::Instance or AWS::CloudTrail::Trail). See relevant part of AWS Docs for available types. In order to use this attribute, all_supported must be set to false.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecForProviderRecordingModeRecordingModeOverride
{
    /// <summary>A description you provide of the override.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Default recording frequency. CONTINUOUS or DAILY.</summary>
    [JsonPropertyName("recordingFrequency")]
    public string? RecordingFrequency { get; set; }

    /// <summary>A list that specifies the types of AWS resources for which AWS Config excludes records configuration changes. See relevant part of AWS Docs for available types.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecForProviderRecordingMode
{
    /// <summary>Default recording frequency. CONTINUOUS or DAILY.</summary>
    [JsonPropertyName("recordingFrequency")]
    public string? RecordingFrequency { get; set; }

    /// <summary>Recording mode overrides. Detailed below.</summary>
    [JsonPropertyName("recordingModeOverride")]
    public IList<V1beta1ConfigurationRecorderSpecForProviderRecordingModeRecordingModeOverride>? RecordingModeOverride { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecForProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationRecorderSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecForProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationRecorderSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecForProvider
{
    /// <summary>Recording group - see below.</summary>
    [JsonPropertyName("recordingGroup")]
    public IList<V1beta1ConfigurationRecorderSpecForProviderRecordingGroup>? RecordingGroup { get; set; }

    /// <summary>Recording mode - see below.</summary>
    [JsonPropertyName("recordingMode")]
    public IList<V1beta1ConfigurationRecorderSpecForProviderRecordingMode>? RecordingMode { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the IAM role. Used to make read or write requests to the delivery channel and to describe the AWS resources associated with the account. See AWS Docs for more details.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ConfigurationRecorderSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ConfigurationRecorderSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecInitProviderRecordingGroupExclusionByResourceTypes
{
    /// <summary>A list that specifies the types of AWS resources for which AWS Config excludes records configuration changes. See relevant part of AWS Docs for available types.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecInitProviderRecordingGroupRecordingStrategy
{
    /// <summary></summary>
    [JsonPropertyName("useOnly")]
    public string? UseOnly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecInitProviderRecordingGroup
{
    /// <summary>Specifies whether AWS Config records configuration changes for every supported type of regional resource (which includes any new type that will become supported in the future). Conflicts with resource_types. Defaults to true.</summary>
    [JsonPropertyName("allSupported")]
    public bool? AllSupported { get; set; }

    /// <summary>An object that specifies how AWS Config excludes resource types from being recorded by the configuration recorder.To use this option, you must set the useOnly field of RecordingStrategy to EXCLUSION_BY_RESOURCE_TYPES Requires all_supported = false. Conflicts with resource_types.</summary>
    [JsonPropertyName("exclusionByResourceTypes")]
    public IList<V1beta1ConfigurationRecorderSpecInitProviderRecordingGroupExclusionByResourceTypes>? ExclusionByResourceTypes { get; set; }

    /// <summary>Specifies whether AWS Config includes all supported types of global resources with the resources that it records. Requires all_supported = true. Conflicts with resource_types.</summary>
    [JsonPropertyName("includeGlobalResourceTypes")]
    public bool? IncludeGlobalResourceTypes { get; set; }

    /// <summary>Recording Strategy. Detailed below.</summary>
    [JsonPropertyName("recordingStrategy")]
    public IList<V1beta1ConfigurationRecorderSpecInitProviderRecordingGroupRecordingStrategy>? RecordingStrategy { get; set; }

    /// <summary>A list that specifies the types of AWS resources for which AWS Config records configuration changes (for example, AWS::EC2::Instance or AWS::CloudTrail::Trail). See relevant part of AWS Docs for available types. In order to use this attribute, all_supported must be set to false.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecInitProviderRecordingModeRecordingModeOverride
{
    /// <summary>A description you provide of the override.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Default recording frequency. CONTINUOUS or DAILY.</summary>
    [JsonPropertyName("recordingFrequency")]
    public string? RecordingFrequency { get; set; }

    /// <summary>A list that specifies the types of AWS resources for which AWS Config excludes records configuration changes. See relevant part of AWS Docs for available types.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecInitProviderRecordingMode
{
    /// <summary>Default recording frequency. CONTINUOUS or DAILY.</summary>
    [JsonPropertyName("recordingFrequency")]
    public string? RecordingFrequency { get; set; }

    /// <summary>Recording mode overrides. Detailed below.</summary>
    [JsonPropertyName("recordingModeOverride")]
    public IList<V1beta1ConfigurationRecorderSpecInitProviderRecordingModeRecordingModeOverride>? RecordingModeOverride { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecInitProviderRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationRecorderSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecInitProviderRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationRecorderSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecInitProvider
{
    /// <summary>Recording group - see below.</summary>
    [JsonPropertyName("recordingGroup")]
    public IList<V1beta1ConfigurationRecorderSpecInitProviderRecordingGroup>? RecordingGroup { get; set; }

    /// <summary>Recording mode - see below.</summary>
    [JsonPropertyName("recordingMode")]
    public IList<V1beta1ConfigurationRecorderSpecInitProviderRecordingMode>? RecordingMode { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the IAM role. Used to make read or write requests to the delivery channel and to describe the AWS resources associated with the account. See AWS Docs for more details.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta1ConfigurationRecorderSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta1ConfigurationRecorderSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationRecorderSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ConfigurationRecorderSpec defines the desired state of ConfigurationRecorder</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConfigurationRecorderSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConfigurationRecorderSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConfigurationRecorderSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConfigurationRecorderSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderStatusAtProviderRecordingGroupExclusionByResourceTypes
{
    /// <summary>A list that specifies the types of AWS resources for which AWS Config excludes records configuration changes. See relevant part of AWS Docs for available types.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderStatusAtProviderRecordingGroupRecordingStrategy
{
    /// <summary></summary>
    [JsonPropertyName("useOnly")]
    public string? UseOnly { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderStatusAtProviderRecordingGroup
{
    /// <summary>Specifies whether AWS Config records configuration changes for every supported type of regional resource (which includes any new type that will become supported in the future). Conflicts with resource_types. Defaults to true.</summary>
    [JsonPropertyName("allSupported")]
    public bool? AllSupported { get; set; }

    /// <summary>An object that specifies how AWS Config excludes resource types from being recorded by the configuration recorder.To use this option, you must set the useOnly field of RecordingStrategy to EXCLUSION_BY_RESOURCE_TYPES Requires all_supported = false. Conflicts with resource_types.</summary>
    [JsonPropertyName("exclusionByResourceTypes")]
    public IList<V1beta1ConfigurationRecorderStatusAtProviderRecordingGroupExclusionByResourceTypes>? ExclusionByResourceTypes { get; set; }

    /// <summary>Specifies whether AWS Config includes all supported types of global resources with the resources that it records. Requires all_supported = true. Conflicts with resource_types.</summary>
    [JsonPropertyName("includeGlobalResourceTypes")]
    public bool? IncludeGlobalResourceTypes { get; set; }

    /// <summary>Recording Strategy. Detailed below.</summary>
    [JsonPropertyName("recordingStrategy")]
    public IList<V1beta1ConfigurationRecorderStatusAtProviderRecordingGroupRecordingStrategy>? RecordingStrategy { get; set; }

    /// <summary>A list that specifies the types of AWS resources for which AWS Config records configuration changes (for example, AWS::EC2::Instance or AWS::CloudTrail::Trail). See relevant part of AWS Docs for available types. In order to use this attribute, all_supported must be set to false.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderStatusAtProviderRecordingModeRecordingModeOverride
{
    /// <summary>A description you provide of the override.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Default recording frequency. CONTINUOUS or DAILY.</summary>
    [JsonPropertyName("recordingFrequency")]
    public string? RecordingFrequency { get; set; }

    /// <summary>A list that specifies the types of AWS resources for which AWS Config excludes records configuration changes. See relevant part of AWS Docs for available types.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderStatusAtProviderRecordingMode
{
    /// <summary>Default recording frequency. CONTINUOUS or DAILY.</summary>
    [JsonPropertyName("recordingFrequency")]
    public string? RecordingFrequency { get; set; }

    /// <summary>Recording mode overrides. Detailed below.</summary>
    [JsonPropertyName("recordingModeOverride")]
    public IList<V1beta1ConfigurationRecorderStatusAtProviderRecordingModeRecordingModeOverride>? RecordingModeOverride { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderStatusAtProvider
{
    /// <summary>Name of the recorder</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Recording group - see below.</summary>
    [JsonPropertyName("recordingGroup")]
    public IList<V1beta1ConfigurationRecorderStatusAtProviderRecordingGroup>? RecordingGroup { get; set; }

    /// <summary>Recording mode - see below.</summary>
    [JsonPropertyName("recordingMode")]
    public IList<V1beta1ConfigurationRecorderStatusAtProviderRecordingMode>? RecordingMode { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the IAM role. Used to make read or write requests to the delivery channel and to describe the AWS resources associated with the account. See AWS Docs for more details.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderStatusConditions
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

/// <summary>ConfigurationRecorderStatus defines the observed state of ConfigurationRecorder.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationRecorderStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConfigurationRecorderStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConfigurationRecorderStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ConfigurationRecorder is the Schema for the ConfigurationRecorders API. Provides an AWS Config Configuration Recorder.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigurationRecorder : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConfigurationRecorderSpec>, IStatus<V1beta1ConfigurationRecorderStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigurationRecorder";
    public const string KubeGroup = "configservice.aws.upbound.io";
    public const string KubePluralName = "configurationrecorders";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConfigurationRecorderSpec defines the desired state of ConfigurationRecorder</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConfigurationRecorderSpec Spec { get; set; }

    /// <summary>ConfigurationRecorderStatus defines the observed state of ConfigurationRecorder.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConfigurationRecorderStatus? Status { get; set; }
}