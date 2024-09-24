using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1RegionNetworkEndpointGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderAppEngine
{
    /// <summary>Optional serving service. The service name must be 1-63 characters long, and comply with RFC1035. Example value: "default", "my-service".</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>A template to parse service and version fields from a request URL. URL mask allows for routing to multiple App Engine services without having to create multiple Network Endpoint Groups and backend services. For example, the request URLs "foo1-dot-appname.appspot.com/v1" and "foo1-dot-appname.appspot.com/v2" can be backed by the same Serverless NEG with URL mask "-dot-appname.appspot.com/". The URL mask will parse them to { service = "foo1", version = "v1" } and { service = "foo1", version = "v2" } respectively.</summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }

    /// <summary>Optional serving version. The version must be 1-63 characters long, and comply with RFC1035. Example value: "v1", "v2".</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in cloudfunctions to populate function.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in cloudfunctions to populate function.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunction
{
    /// <summary>A user-defined name of the Cloud Function. The function name is case-sensitive and must be 1-63 characters long. Example value: "func1".</summary>
    [JsonPropertyName("function")]
    public string? Function { get; set; }

    /// <summary>Reference to a Function in cloudfunctions to populate function.</summary>
    [JsonPropertyName("functionRef")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionRef? FunctionRef { get; set; }

    /// <summary>Selector for a Function in cloudfunctions to populate function.</summary>
    [JsonPropertyName("functionSelector")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunctionFunctionSelector? FunctionSelector { get; set; }

    /// <summary>A template to parse function field from a request URL. URL mask allows for routing to multiple Cloud Functions without having to create multiple Network Endpoint Groups and backend services. For example, request URLs "mydomain.com/function1" and "mydomain.com/function2" can be backed by the same Serverless NEG with URL mask "/". The URL mask will parse them to { function = "function1" } and { function = "function2" } respectively.</summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Service in cloudrun to populate service.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Service in cloudrun to populate service.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRun
{
    /// <summary>Cloud Run service is the main resource of Cloud Run. The service must be 1-63 characters long, and comply with RFC1035. Example value: "run-service".</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRunServiceSelector? ServiceSelector { get; set; }

    /// <summary>Cloud Run tag represents the "named-revision" to provide additional fine-grained traffic routing information. The tag must be 1-63 characters long, and comply with RFC1035. Example value: "revision-0010".</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>A template to parse service and tag fields from a request URL. URL mask allows for routing to multiple Run services without having to create multiple network endpoint groups and backend services. For example, request URLs "foo1.domain.com/bar1" and "foo1.domain.com/bar2" an be backed by the same Serverless Network Endpoint Group (NEG) with URL mask ".domain.com/". The URL mask will parse them to { service="bar1", tag="foo1" } and { service="bar2", tag="foo2" } respectively.</summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAttachment in compute to populate pscTargetService.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAttachment in compute to populate pscTargetService.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecForProvider
{
    /// <summary>This field is only used for SERVERLESS NEGs. Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set. Structure is documented below.</summary>
    [JsonPropertyName("appEngine")]
    public IList<V1beta1RegionNetworkEndpointGroupSpecForProviderAppEngine>? AppEngine { get; set; }

    /// <summary>This field is only used for SERVERLESS NEGs. Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set. Structure is documented below.</summary>
    [JsonPropertyName("cloudFunction")]
    public IList<V1beta1RegionNetworkEndpointGroupSpecForProviderCloudFunction>? CloudFunction { get; set; }

    /// <summary>This field is only used for SERVERLESS NEGs. Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set. Structure is documented below.</summary>
    [JsonPropertyName("cloudRun")]
    public IList<V1beta1RegionNetworkEndpointGroupSpecForProviderCloudRun>? CloudRun { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>This field is only used for PSC and INTERNET NEGs. The URL of the network to which all network endpoints in the NEG belong. Uses "default" project network if unspecified.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Type of network endpoints in this network endpoint group. Defaults to SERVERLESS. Default value is SERVERLESS. Possible values are: SERVERLESS, PRIVATE_SERVICE_CONNECT, INTERNET_IP_PORT, INTERNET_FQDN_PORT.</summary>
    [JsonPropertyName("networkEndpointType")]
    public string? NetworkEndpointType { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>This field is only used for PSC and INTERNET NEGs. The target service url used to set up private service connection to a Google API or a PSC Producer Service Attachment.</summary>
    [JsonPropertyName("pscTargetService")]
    public string? PscTargetService { get; set; }

    /// <summary>Reference to a ServiceAttachment in compute to populate pscTargetService.</summary>
    [JsonPropertyName("pscTargetServiceRef")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceRef? PscTargetServiceRef { get; set; }

    /// <summary>Selector for a ServiceAttachment in compute to populate pscTargetService.</summary>
    [JsonPropertyName("pscTargetServiceSelector")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderPscTargetServiceSelector? PscTargetServiceSelector { get; set; }

    /// <summary>A reference to the region where the regional NEGs reside.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>This field is only used for PSC NEGs. Optional URL of the subnetwork to which all network endpoints in the NEG belong.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1RegionNetworkEndpointGroupSpecForProviderSubnetworkSelector? SubnetworkSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderAppEngine
{
    /// <summary>Optional serving service. The service name must be 1-63 characters long, and comply with RFC1035. Example value: "default", "my-service".</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>A template to parse service and version fields from a request URL. URL mask allows for routing to multiple App Engine services without having to create multiple Network Endpoint Groups and backend services. For example, the request URLs "foo1-dot-appname.appspot.com/v1" and "foo1-dot-appname.appspot.com/v2" can be backed by the same Serverless NEG with URL mask "-dot-appname.appspot.com/". The URL mask will parse them to { service = "foo1", version = "v1" } and { service = "foo1", version = "v2" } respectively.</summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }

    /// <summary>Optional serving version. The version must be 1-63 characters long, and comply with RFC1035. Example value: "v1", "v2".</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in cloudfunctions to populate function.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in cloudfunctions to populate function.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunction
{
    /// <summary>A user-defined name of the Cloud Function. The function name is case-sensitive and must be 1-63 characters long. Example value: "func1".</summary>
    [JsonPropertyName("function")]
    public string? Function { get; set; }

    /// <summary>Reference to a Function in cloudfunctions to populate function.</summary>
    [JsonPropertyName("functionRef")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionRef? FunctionRef { get; set; }

    /// <summary>Selector for a Function in cloudfunctions to populate function.</summary>
    [JsonPropertyName("functionSelector")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunctionFunctionSelector? FunctionSelector { get; set; }

    /// <summary>A template to parse function field from a request URL. URL mask allows for routing to multiple Cloud Functions without having to create multiple Network Endpoint Groups and backend services. For example, request URLs "mydomain.com/function1" and "mydomain.com/function2" can be backed by the same Serverless NEG with URL mask "/". The URL mask will parse them to { function = "function1" } and { function = "function2" } respectively.</summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Service in cloudrun to populate service.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Service in cloudrun to populate service.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRun
{
    /// <summary>Cloud Run service is the main resource of Cloud Run. The service must be 1-63 characters long, and comply with RFC1035. Example value: "run-service".</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRunServiceSelector? ServiceSelector { get; set; }

    /// <summary>Cloud Run tag represents the "named-revision" to provide additional fine-grained traffic routing information. The tag must be 1-63 characters long, and comply with RFC1035. Example value: "revision-0010".</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>A template to parse service and tag fields from a request URL. URL mask allows for routing to multiple Run services without having to create multiple network endpoint groups and backend services. For example, request URLs "foo1.domain.com/bar1" and "foo1.domain.com/bar2" an be backed by the same Serverless Network Endpoint Group (NEG) with URL mask ".domain.com/". The URL mask will parse them to { service="bar1", tag="foo1" } and { service="bar2", tag="foo2" } respectively.</summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAttachment in compute to populate pscTargetService.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAttachment in compute to populate pscTargetService.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelectorPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecInitProvider
{
    /// <summary>This field is only used for SERVERLESS NEGs. Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set. Structure is documented below.</summary>
    [JsonPropertyName("appEngine")]
    public IList<V1beta1RegionNetworkEndpointGroupSpecInitProviderAppEngine>? AppEngine { get; set; }

    /// <summary>This field is only used for SERVERLESS NEGs. Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set. Structure is documented below.</summary>
    [JsonPropertyName("cloudFunction")]
    public IList<V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudFunction>? CloudFunction { get; set; }

    /// <summary>This field is only used for SERVERLESS NEGs. Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set. Structure is documented below.</summary>
    [JsonPropertyName("cloudRun")]
    public IList<V1beta1RegionNetworkEndpointGroupSpecInitProviderCloudRun>? CloudRun { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>This field is only used for PSC and INTERNET NEGs. The URL of the network to which all network endpoints in the NEG belong. Uses "default" project network if unspecified.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Type of network endpoints in this network endpoint group. Defaults to SERVERLESS. Default value is SERVERLESS. Possible values are: SERVERLESS, PRIVATE_SERVICE_CONNECT, INTERNET_IP_PORT, INTERNET_FQDN_PORT.</summary>
    [JsonPropertyName("networkEndpointType")]
    public string? NetworkEndpointType { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>This field is only used for PSC and INTERNET NEGs. The target service url used to set up private service connection to a Google API or a PSC Producer Service Attachment.</summary>
    [JsonPropertyName("pscTargetService")]
    public string? PscTargetService { get; set; }

    /// <summary>Reference to a ServiceAttachment in compute to populate pscTargetService.</summary>
    [JsonPropertyName("pscTargetServiceRef")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceRef? PscTargetServiceRef { get; set; }

    /// <summary>Selector for a ServiceAttachment in compute to populate pscTargetService.</summary>
    [JsonPropertyName("pscTargetServiceSelector")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderPscTargetServiceSelector? PscTargetServiceSelector { get; set; }

    /// <summary>This field is only used for PSC NEGs. Optional URL of the subnetwork to which all network endpoints in the NEG belong.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProviderSubnetworkSelector? SubnetworkSelector { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecManagementPoliciesEnum
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

public enum V1beta1RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>RegionNetworkEndpointGroupSpec defines the desired state of RegionNetworkEndpointGroup</summary>
public partial class V1beta1RegionNetworkEndpointGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionNetworkEndpointGroupSpecDeletionPolicyEnum>))]
    public V1beta1RegionNetworkEndpointGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RegionNetworkEndpointGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RegionNetworkEndpointGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RegionNetworkEndpointGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegionNetworkEndpointGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1RegionNetworkEndpointGroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegionNetworkEndpointGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionNetworkEndpointGroupStatusAtProviderAppEngine
{
    /// <summary>Optional serving service. The service name must be 1-63 characters long, and comply with RFC1035. Example value: "default", "my-service".</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>A template to parse service and version fields from a request URL. URL mask allows for routing to multiple App Engine services without having to create multiple Network Endpoint Groups and backend services. For example, the request URLs "foo1-dot-appname.appspot.com/v1" and "foo1-dot-appname.appspot.com/v2" can be backed by the same Serverless NEG with URL mask "-dot-appname.appspot.com/". The URL mask will parse them to { service = "foo1", version = "v1" } and { service = "foo1", version = "v2" } respectively.</summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }

    /// <summary>Optional serving version. The version must be 1-63 characters long, and comply with RFC1035. Example value: "v1", "v2".</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionNetworkEndpointGroupStatusAtProviderCloudFunction
{
    /// <summary>A user-defined name of the Cloud Function. The function name is case-sensitive and must be 1-63 characters long. Example value: "func1".</summary>
    [JsonPropertyName("function")]
    public string? Function { get; set; }

    /// <summary>A template to parse function field from a request URL. URL mask allows for routing to multiple Cloud Functions without having to create multiple Network Endpoint Groups and backend services. For example, request URLs "mydomain.com/function1" and "mydomain.com/function2" can be backed by the same Serverless NEG with URL mask "/". The URL mask will parse them to { function = "function1" } and { function = "function2" } respectively.</summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionNetworkEndpointGroupStatusAtProviderCloudRun
{
    /// <summary>Cloud Run service is the main resource of Cloud Run. The service must be 1-63 characters long, and comply with RFC1035. Example value: "run-service".</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Cloud Run tag represents the "named-revision" to provide additional fine-grained traffic routing information. The tag must be 1-63 characters long, and comply with RFC1035. Example value: "revision-0010".</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>A template to parse service and tag fields from a request URL. URL mask allows for routing to multiple Run services without having to create multiple network endpoint groups and backend services. For example, request URLs "foo1.domain.com/bar1" and "foo1.domain.com/bar2" an be backed by the same Serverless Network Endpoint Group (NEG) with URL mask ".domain.com/". The URL mask will parse them to { service="bar1", tag="foo1" } and { service="bar2", tag="foo2" } respectively.</summary>
    [JsonPropertyName("urlMask")]
    public string? UrlMask { get; set; }
}

/// <summary></summary>
public partial class V1beta1RegionNetworkEndpointGroupStatusAtProvider
{
    /// <summary>This field is only used for SERVERLESS NEGs. Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set. Structure is documented below.</summary>
    [JsonPropertyName("appEngine")]
    public IList<V1beta1RegionNetworkEndpointGroupStatusAtProviderAppEngine>? AppEngine { get; set; }

    /// <summary>This field is only used for SERVERLESS NEGs. Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set. Structure is documented below.</summary>
    [JsonPropertyName("cloudFunction")]
    public IList<V1beta1RegionNetworkEndpointGroupStatusAtProviderCloudFunction>? CloudFunction { get; set; }

    /// <summary>This field is only used for SERVERLESS NEGs. Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set. Structure is documented below.</summary>
    [JsonPropertyName("cloudRun")]
    public IList<V1beta1RegionNetworkEndpointGroupStatusAtProviderCloudRun>? CloudRun { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/networkEndpointGroups/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>This field is only used for PSC and INTERNET NEGs. The URL of the network to which all network endpoints in the NEG belong. Uses "default" project network if unspecified.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Type of network endpoints in this network endpoint group. Defaults to SERVERLESS. Default value is SERVERLESS. Possible values are: SERVERLESS, PRIVATE_SERVICE_CONNECT, INTERNET_IP_PORT, INTERNET_FQDN_PORT.</summary>
    [JsonPropertyName("networkEndpointType")]
    public string? NetworkEndpointType { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>This field is only used for PSC and INTERNET NEGs. The target service url used to set up private service connection to a Google API or a PSC Producer Service Attachment.</summary>
    [JsonPropertyName("pscTargetService")]
    public string? PscTargetService { get; set; }

    /// <summary>A reference to the region where the regional NEGs reside.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>This field is only used for PSC NEGs. Optional URL of the subnetwork to which all network endpoints in the NEG belong.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1RegionNetworkEndpointGroupStatusConditions
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

/// <summary>RegionNetworkEndpointGroupStatus defines the observed state of RegionNetworkEndpointGroup.</summary>
public partial class V1beta1RegionNetworkEndpointGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RegionNetworkEndpointGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegionNetworkEndpointGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>RegionNetworkEndpointGroup is the Schema for the RegionNetworkEndpointGroups API. A regional NEG that can support Serverless Products and proxying traffic to external backends.</summary>
public partial class V1beta1RegionNetworkEndpointGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegionNetworkEndpointGroupSpec>, IStatus<V1beta1RegionNetworkEndpointGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionNetworkEndpointGroup";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionnetworkendpointgroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionNetworkEndpointGroupSpec defines the desired state of RegionNetworkEndpointGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1RegionNetworkEndpointGroupSpec Spec { get; set; }

    /// <summary>RegionNetworkEndpointGroupStatus defines the observed state of RegionNetworkEndpointGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegionNetworkEndpointGroupStatus? Status { get; set; }
}