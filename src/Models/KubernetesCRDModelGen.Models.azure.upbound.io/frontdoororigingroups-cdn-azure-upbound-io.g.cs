using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.upbound.io;
#nullable enable
/// <summary>FrontdoorOriginGroup is the Schema for the FrontdoorOriginGroups API. Manages a Front Door (standard/premium) Origin Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorOriginGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FrontdoorOriginGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorOriginGroupList";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoororigingroups";
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
    public IList<V1beta1FrontdoorOriginGroup> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecForProviderCdnFrontdoorProfileIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecForProviderCdnFrontdoorProfileIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorOriginGroupSpecForProviderCdnFrontdoorProfileIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecForProviderCdnFrontdoorProfileIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecForProviderCdnFrontdoorProfileIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorOriginGroupSpecForProviderCdnFrontdoorProfileIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecForProviderHealthProbe
{
    /// <summary>Specifies the number of seconds between health probes. Possible values are between 5 and 31536000 seconds (inclusive).</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the path relative to the origin that is used to determine the health of the origin. Defaults to /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol to use for health probe. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the type of health probe request that is made. Possible values are GET and HEAD. Defaults to HEAD.</summary>
    [JsonPropertyName("requestType")]
    public string? RequestType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecForProviderLoadBalancing
{
    /// <summary>Specifies the additional latency in milliseconds for probes to fall into the lowest latency bucket. Possible values are between 0 and 1000 milliseconds (inclusive). Defaults to 50.</summary>
    [JsonPropertyName("additionalLatencyInMilliseconds")]
    public double? AdditionalLatencyInMilliseconds { get; set; }

    /// <summary>Specifies the number of samples to consider for load balancing decisions. Possible values are between 0 and 255 (inclusive). Defaults to 4.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }

    /// <summary>Specifies the number of samples within the sample period that must succeed. Possible values are between 0 and 255 (inclusive). Defaults to 3.</summary>
    [JsonPropertyName("successfulSamplesRequired")]
    public double? SuccessfulSamplesRequired { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecForProvider
{
    /// <summary>The ID of the Front Door Profile within which this Front Door Origin Group should exist. Changing this forces a new Front Door Origin Group to be created.</summary>
    [JsonPropertyName("cdnFrontdoorProfileId")]
    public string? CdnFrontdoorProfileId { get; set; }

    /// <summary>Reference to a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
    [JsonPropertyName("cdnFrontdoorProfileIdRef")]
    public V1beta1FrontdoorOriginGroupSpecForProviderCdnFrontdoorProfileIdRef? CdnFrontdoorProfileIdRef { get; set; }

    /// <summary>Selector for a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
    [JsonPropertyName("cdnFrontdoorProfileIdSelector")]
    public V1beta1FrontdoorOriginGroupSpecForProviderCdnFrontdoorProfileIdSelector? CdnFrontdoorProfileIdSelector { get; set; }

    /// <summary>A health_probe block as defined below.</summary>
    [JsonPropertyName("healthProbe")]
    public IList<V1beta1FrontdoorOriginGroupSpecForProviderHealthProbe>? HealthProbe { get; set; }

    /// <summary>A load_balancing block as defined below.</summary>
    [JsonPropertyName("loadBalancing")]
    public IList<V1beta1FrontdoorOriginGroupSpecForProviderLoadBalancing>? LoadBalancing { get; set; }

    /// <summary>Specifies the amount of time which should elapse before shifting traffic to another endpoint when a healthy endpoint becomes unhealthy or a new endpoint is added. Possible values are between 0 and 50 minutes (inclusive). Default is 10 minutes.</summary>
    [JsonPropertyName("restoreTrafficTimeToHealedOrNewEndpointInMinutes")]
    public double? RestoreTrafficTimeToHealedOrNewEndpointInMinutes { get; set; }

    /// <summary>Specifies whether session affinity should be enabled on this host. Defaults to true.</summary>
    [JsonPropertyName("sessionAffinityEnabled")]
    public bool? SessionAffinityEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecInitProviderHealthProbe
{
    /// <summary>Specifies the number of seconds between health probes. Possible values are between 5 and 31536000 seconds (inclusive).</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the path relative to the origin that is used to determine the health of the origin. Defaults to /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol to use for health probe. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the type of health probe request that is made. Possible values are GET and HEAD. Defaults to HEAD.</summary>
    [JsonPropertyName("requestType")]
    public string? RequestType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecInitProviderLoadBalancing
{
    /// <summary>Specifies the additional latency in milliseconds for probes to fall into the lowest latency bucket. Possible values are between 0 and 1000 milliseconds (inclusive). Defaults to 50.</summary>
    [JsonPropertyName("additionalLatencyInMilliseconds")]
    public double? AdditionalLatencyInMilliseconds { get; set; }

    /// <summary>Specifies the number of samples to consider for load balancing decisions. Possible values are between 0 and 255 (inclusive). Defaults to 4.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }

    /// <summary>Specifies the number of samples within the sample period that must succeed. Possible values are between 0 and 255 (inclusive). Defaults to 3.</summary>
    [JsonPropertyName("successfulSamplesRequired")]
    public double? SuccessfulSamplesRequired { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecInitProvider
{
    /// <summary>A health_probe block as defined below.</summary>
    [JsonPropertyName("healthProbe")]
    public IList<V1beta1FrontdoorOriginGroupSpecInitProviderHealthProbe>? HealthProbe { get; set; }

    /// <summary>A load_balancing block as defined below.</summary>
    [JsonPropertyName("loadBalancing")]
    public IList<V1beta1FrontdoorOriginGroupSpecInitProviderLoadBalancing>? LoadBalancing { get; set; }

    /// <summary>Specifies the amount of time which should elapse before shifting traffic to another endpoint when a healthy endpoint becomes unhealthy or a new endpoint is added. Possible values are between 0 and 50 minutes (inclusive). Default is 10 minutes.</summary>
    [JsonPropertyName("restoreTrafficTimeToHealedOrNewEndpointInMinutes")]
    public double? RestoreTrafficTimeToHealedOrNewEndpointInMinutes { get; set; }

    /// <summary>Specifies whether session affinity should be enabled on this host. Defaults to true.</summary>
    [JsonPropertyName("sessionAffinityEnabled")]
    public bool? SessionAffinityEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorOriginGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FrontdoorOriginGroupSpec defines the desired state of FrontdoorOriginGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontdoorOriginGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontdoorOriginGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FrontdoorOriginGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FrontdoorOriginGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupStatusAtProviderHealthProbe
{
    /// <summary>Specifies the number of seconds between health probes. Possible values are between 5 and 31536000 seconds (inclusive).</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the path relative to the origin that is used to determine the health of the origin. Defaults to /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies the protocol to use for health probe. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Specifies the type of health probe request that is made. Possible values are GET and HEAD. Defaults to HEAD.</summary>
    [JsonPropertyName("requestType")]
    public string? RequestType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupStatusAtProviderLoadBalancing
{
    /// <summary>Specifies the additional latency in milliseconds for probes to fall into the lowest latency bucket. Possible values are between 0 and 1000 milliseconds (inclusive). Defaults to 50.</summary>
    [JsonPropertyName("additionalLatencyInMilliseconds")]
    public double? AdditionalLatencyInMilliseconds { get; set; }

    /// <summary>Specifies the number of samples to consider for load balancing decisions. Possible values are between 0 and 255 (inclusive). Defaults to 4.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }

    /// <summary>Specifies the number of samples within the sample period that must succeed. Possible values are between 0 and 255 (inclusive). Defaults to 3.</summary>
    [JsonPropertyName("successfulSamplesRequired")]
    public double? SuccessfulSamplesRequired { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupStatusAtProvider
{
    /// <summary>The ID of the Front Door Profile within which this Front Door Origin Group should exist. Changing this forces a new Front Door Origin Group to be created.</summary>
    [JsonPropertyName("cdnFrontdoorProfileId")]
    public string? CdnFrontdoorProfileId { get; set; }

    /// <summary>A health_probe block as defined below.</summary>
    [JsonPropertyName("healthProbe")]
    public IList<V1beta1FrontdoorOriginGroupStatusAtProviderHealthProbe>? HealthProbe { get; set; }

    /// <summary>The ID of the Front Door Origin Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A load_balancing block as defined below.</summary>
    [JsonPropertyName("loadBalancing")]
    public IList<V1beta1FrontdoorOriginGroupStatusAtProviderLoadBalancing>? LoadBalancing { get; set; }

    /// <summary>Specifies the amount of time which should elapse before shifting traffic to another endpoint when a healthy endpoint becomes unhealthy or a new endpoint is added. Possible values are between 0 and 50 minutes (inclusive). Default is 10 minutes.</summary>
    [JsonPropertyName("restoreTrafficTimeToHealedOrNewEndpointInMinutes")]
    public double? RestoreTrafficTimeToHealedOrNewEndpointInMinutes { get; set; }

    /// <summary>Specifies whether session affinity should be enabled on this host. Defaults to true.</summary>
    [JsonPropertyName("sessionAffinityEnabled")]
    public bool? SessionAffinityEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupStatusConditions
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
/// <summary>FrontdoorOriginGroupStatus defines the observed state of FrontdoorOriginGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorOriginGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FrontdoorOriginGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FrontdoorOriginGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FrontdoorOriginGroup is the Schema for the FrontdoorOriginGroups API. Manages a Front Door (standard/premium) Origin Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorOriginGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FrontdoorOriginGroupSpec>, IStatus<V1beta1FrontdoorOriginGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorOriginGroup";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoororigingroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorOriginGroupSpec defines the desired state of FrontdoorOriginGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1FrontdoorOriginGroupSpec Spec { get; set; }

    /// <summary>FrontdoorOriginGroupStatus defines the observed state of FrontdoorOriginGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1FrontdoorOriginGroupStatus? Status { get; set; }
}
#nullable disable
