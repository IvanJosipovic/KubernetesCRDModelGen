using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TrafficManagerProfileSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecForProviderDnsConfig
{
    /// <summary>The relative domain name, this is combined with the domain name used by Traffic Manager to form the FQDN which is exported as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("relativeName")]
    public string? RelativeName { get; set; }

    /// <summary>The TTL value of the Profile used by Local DNS resolvers and clients.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecForProviderMonitorConfigCustomHeader
{
    /// <summary>The name of the Traffic Manager profile. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of custom header. Applicable for HTTP and HTTPS protocol.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecForProviderMonitorConfig
{
    /// <summary>One or more custom_header blocks as defined below.</summary>
    [JsonPropertyName("customHeader")]
    public IList<V1beta1TrafficManagerProfileSpecForProviderMonitorConfigCustomHeader>? CustomHeader { get; set; }

    /// <summary>A list of status code ranges in the format of 100-101.</summary>
    [JsonPropertyName("expectedStatusCodeRanges")]
    public IList<string>? ExpectedStatusCodeRanges { get; set; }

    /// <summary>The interval used to check the endpoint health from a Traffic Manager probing agent. You can specify two values here: 30 (normal probing) and 10 (fast probing). The default value is 30.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>The path used by the monitoring checks. Required when protocol is set to HTTP or HTTPS - cannot be set when protocol is set to TCP.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number used by the monitoring checks.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol used by the monitoring checks, supported values are HTTP, HTTPS and TCP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The amount of time the Traffic Manager probing agent should wait before considering that check a failure when a health check probe is sent to the endpoint. If interval_in_seconds is set to 30, then timeout_in_seconds can be between 5 and 10. The default value is 10. If interval_in_seconds is set to 10, then valid values are between 5 and 9 and timeout_in_seconds is required.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public double? TimeoutInSeconds { get; set; }

    /// <summary>The number of failures a Traffic Manager probing agent tolerates before marking that endpoint as unhealthy. Valid values are between 0 and 9. The default value is 3</summary>
    [JsonPropertyName("toleratedNumberOfFailures")]
    public double? ToleratedNumberOfFailures { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecForProvider
{
    /// <summary>This block specifies the DNS configuration of the Profile. One dns_config block as defined below.</summary>
    [JsonPropertyName("dnsConfig")]
    public IList<V1beta1TrafficManagerProfileSpecForProviderDnsConfig>? DnsConfig { get; set; }

    /// <summary>The amount of endpoints to return for DNS queries to this Profile. Possible values range from 1 to 8.</summary>
    [JsonPropertyName("maxReturn")]
    public double? MaxReturn { get; set; }

    /// <summary>This block specifies the Endpoint monitoring configuration for the Profile. One monitor_config block as defined below.</summary>
    [JsonPropertyName("monitorConfig")]
    public IList<V1beta1TrafficManagerProfileSpecForProviderMonitorConfig>? MonitorConfig { get; set; }

    /// <summary>The status of the profile, can be set to either Enabled or Disabled. Defaults to Enabled.</summary>
    [JsonPropertyName("profileStatus")]
    public string? ProfileStatus { get; set; }

    /// <summary>The name of the resource group in which to create the Traffic Manager profile. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1TrafficManagerProfileSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the algorithm used to route traffic. Possible values are Geographic, Weighted, Performance, Priority, Subnet and MultiValue.</summary>
    [JsonPropertyName("trafficRoutingMethod")]
    public string? TrafficRoutingMethod { get; set; }

    /// <summary>Indicates whether Traffic View is enabled for the Traffic Manager profile.</summary>
    [JsonPropertyName("trafficViewEnabled")]
    public bool? TrafficViewEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecInitProviderDnsConfig
{
    /// <summary>The relative domain name, this is combined with the domain name used by Traffic Manager to form the FQDN which is exported as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("relativeName")]
    public string? RelativeName { get; set; }

    /// <summary>The TTL value of the Profile used by Local DNS resolvers and clients.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecInitProviderMonitorConfigCustomHeader
{
    /// <summary>The name of the Traffic Manager profile. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of custom header. Applicable for HTTP and HTTPS protocol.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecInitProviderMonitorConfig
{
    /// <summary>One or more custom_header blocks as defined below.</summary>
    [JsonPropertyName("customHeader")]
    public IList<V1beta1TrafficManagerProfileSpecInitProviderMonitorConfigCustomHeader>? CustomHeader { get; set; }

    /// <summary>A list of status code ranges in the format of 100-101.</summary>
    [JsonPropertyName("expectedStatusCodeRanges")]
    public IList<string>? ExpectedStatusCodeRanges { get; set; }

    /// <summary>The interval used to check the endpoint health from a Traffic Manager probing agent. You can specify two values here: 30 (normal probing) and 10 (fast probing). The default value is 30.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>The path used by the monitoring checks. Required when protocol is set to HTTP or HTTPS - cannot be set when protocol is set to TCP.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number used by the monitoring checks.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol used by the monitoring checks, supported values are HTTP, HTTPS and TCP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The amount of time the Traffic Manager probing agent should wait before considering that check a failure when a health check probe is sent to the endpoint. If interval_in_seconds is set to 30, then timeout_in_seconds can be between 5 and 10. The default value is 10. If interval_in_seconds is set to 10, then valid values are between 5 and 9 and timeout_in_seconds is required.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public double? TimeoutInSeconds { get; set; }

    /// <summary>The number of failures a Traffic Manager probing agent tolerates before marking that endpoint as unhealthy. Valid values are between 0 and 9. The default value is 3</summary>
    [JsonPropertyName("toleratedNumberOfFailures")]
    public double? ToleratedNumberOfFailures { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecInitProvider
{
    /// <summary>This block specifies the DNS configuration of the Profile. One dns_config block as defined below.</summary>
    [JsonPropertyName("dnsConfig")]
    public IList<V1beta1TrafficManagerProfileSpecInitProviderDnsConfig>? DnsConfig { get; set; }

    /// <summary>The amount of endpoints to return for DNS queries to this Profile. Possible values range from 1 to 8.</summary>
    [JsonPropertyName("maxReturn")]
    public double? MaxReturn { get; set; }

    /// <summary>This block specifies the Endpoint monitoring configuration for the Profile. One monitor_config block as defined below.</summary>
    [JsonPropertyName("monitorConfig")]
    public IList<V1beta1TrafficManagerProfileSpecInitProviderMonitorConfig>? MonitorConfig { get; set; }

    /// <summary>The status of the profile, can be set to either Enabled or Disabled. Defaults to Enabled.</summary>
    [JsonPropertyName("profileStatus")]
    public string? ProfileStatus { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the algorithm used to route traffic. Possible values are Geographic, Weighted, Performance, Priority, Subnet and MultiValue.</summary>
    [JsonPropertyName("trafficRoutingMethod")]
    public string? TrafficRoutingMethod { get; set; }

    /// <summary>Indicates whether Traffic View is enabled for the Traffic Manager profile.</summary>
    [JsonPropertyName("trafficViewEnabled")]
    public bool? TrafficViewEnabled { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TrafficManagerProfileSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TrafficManagerProfileSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TrafficManagerProfileSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficManagerProfileSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TrafficManagerProfileSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficManagerProfileSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TrafficManagerProfileSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrafficManagerProfileSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TrafficManagerProfileSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TrafficManagerProfileSpec defines the desired state of TrafficManagerProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TrafficManagerProfileSpecDeletionPolicyEnum>))]
    public V1beta1TrafficManagerProfileSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TrafficManagerProfileSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TrafficManagerProfileSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TrafficManagerProfileSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TrafficManagerProfileSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TrafficManagerProfileSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TrafficManagerProfileSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileStatusAtProviderDnsConfig
{
    /// <summary>The relative domain name, this is combined with the domain name used by Traffic Manager to form the FQDN which is exported as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("relativeName")]
    public string? RelativeName { get; set; }

    /// <summary>The TTL value of the Profile used by Local DNS resolvers and clients.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileStatusAtProviderMonitorConfigCustomHeader
{
    /// <summary>The name of the Traffic Manager profile. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of custom header. Applicable for HTTP and HTTPS protocol.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileStatusAtProviderMonitorConfig
{
    /// <summary>One or more custom_header blocks as defined below.</summary>
    [JsonPropertyName("customHeader")]
    public IList<V1beta1TrafficManagerProfileStatusAtProviderMonitorConfigCustomHeader>? CustomHeader { get; set; }

    /// <summary>A list of status code ranges in the format of 100-101.</summary>
    [JsonPropertyName("expectedStatusCodeRanges")]
    public IList<string>? ExpectedStatusCodeRanges { get; set; }

    /// <summary>The interval used to check the endpoint health from a Traffic Manager probing agent. You can specify two values here: 30 (normal probing) and 10 (fast probing). The default value is 30.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>The path used by the monitoring checks. Required when protocol is set to HTTP or HTTPS - cannot be set when protocol is set to TCP.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port number used by the monitoring checks.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol used by the monitoring checks, supported values are HTTP, HTTPS and TCP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The amount of time the Traffic Manager probing agent should wait before considering that check a failure when a health check probe is sent to the endpoint. If interval_in_seconds is set to 30, then timeout_in_seconds can be between 5 and 10. The default value is 10. If interval_in_seconds is set to 10, then valid values are between 5 and 9 and timeout_in_seconds is required.</summary>
    [JsonPropertyName("timeoutInSeconds")]
    public double? TimeoutInSeconds { get; set; }

    /// <summary>The number of failures a Traffic Manager probing agent tolerates before marking that endpoint as unhealthy. Valid values are between 0 and 9. The default value is 3</summary>
    [JsonPropertyName("toleratedNumberOfFailures")]
    public double? ToleratedNumberOfFailures { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileStatusAtProvider
{
    /// <summary>This block specifies the DNS configuration of the Profile. One dns_config block as defined below.</summary>
    [JsonPropertyName("dnsConfig")]
    public IList<V1beta1TrafficManagerProfileStatusAtProviderDnsConfig>? DnsConfig { get; set; }

    /// <summary>The FQDN of the created Profile.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The ID of the Traffic Manager Profile.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The amount of endpoints to return for DNS queries to this Profile. Possible values range from 1 to 8.</summary>
    [JsonPropertyName("maxReturn")]
    public double? MaxReturn { get; set; }

    /// <summary>This block specifies the Endpoint monitoring configuration for the Profile. One monitor_config block as defined below.</summary>
    [JsonPropertyName("monitorConfig")]
    public IList<V1beta1TrafficManagerProfileStatusAtProviderMonitorConfig>? MonitorConfig { get; set; }

    /// <summary>The status of the profile, can be set to either Enabled or Disabled. Defaults to Enabled.</summary>
    [JsonPropertyName("profileStatus")]
    public string? ProfileStatus { get; set; }

    /// <summary>The name of the resource group in which to create the Traffic Manager profile. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the algorithm used to route traffic. Possible values are Geographic, Weighted, Performance, Priority, Subnet and MultiValue.</summary>
    [JsonPropertyName("trafficRoutingMethod")]
    public string? TrafficRoutingMethod { get; set; }

    /// <summary>Indicates whether Traffic View is enabled for the Traffic Manager profile.</summary>
    [JsonPropertyName("trafficViewEnabled")]
    public bool? TrafficViewEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileStatusConditions
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

/// <summary>TrafficManagerProfileStatus defines the observed state of TrafficManagerProfile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TrafficManagerProfileStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TrafficManagerProfileStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TrafficManagerProfileStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TrafficManagerProfile is the Schema for the TrafficManagerProfiles API. Manages a Traffic Manager Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TrafficManagerProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TrafficManagerProfileSpec>, IStatus<V1beta1TrafficManagerProfileStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TrafficManagerProfile";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "trafficmanagerprofiles";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TrafficManagerProfileSpec defines the desired state of TrafficManagerProfile</summary>
    [JsonPropertyName("spec")]
    public V1beta1TrafficManagerProfileSpec Spec { get; set; }

    /// <summary>TrafficManagerProfileStatus defines the observed state of TrafficManagerProfile.</summary>
    [JsonPropertyName("status")]
    public V1beta1TrafficManagerProfileStatus? Status { get; set; }
}