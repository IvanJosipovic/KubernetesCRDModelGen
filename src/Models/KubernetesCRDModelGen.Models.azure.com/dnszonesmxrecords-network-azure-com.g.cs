using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
/// <summary>Storage version of v1api20180501.AaaaRecord An AAAA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecAAAARecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }
}

/// <summary>Storage version of v1api20180501.ARecord An A record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecARecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}

/// <summary>Storage version of v1api20180501.CnameRecord A CNAME record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecCNAMERecord
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }
}

/// <summary>Storage version of v1api20180501.MxRecord An MX record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecMXRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exchange")]
    public string? Exchange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preference")]
    public int? Preference { get; set; }
}

/// <summary>Storage version of v1api20180501.NsRecord An NS record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecNSRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nsdname")]
    public string? Nsdname { get; set; }
}

/// <summary>Storage version of v1api20180501.PtrRecord A PTR record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecPTRRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ptrdname")]
    public string? Ptrdname { get; set; }
}

/// <summary>Storage version of v1api20180501.SoaRecord An SOA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecSOARecord
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expireTime")]
    public int? ExpireTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimumTTL")]
    public int? MinimumTTL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("refreshTime")]
    public int? RefreshTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retryTime")]
    public int? RetryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serialNumber")]
    public int? SerialNumber { get; set; }
}

/// <summary>Storage version of v1api20180501.SrvRecord An SRV record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecSRVRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Storage version of v1api20180501.TxtRecord A TXT record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecTXTRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

/// <summary>Storage version of v1api20180501.CaaRecord A CAA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecCaaRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("flags")]
    public int? Flags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a network.azure.com/DnsZone resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource Id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecTargetResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20180501.SubResource A reference to a another resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpecTargetResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id.</summary>
    [JsonPropertyName("reference")]
    public V1api20180501storageDnsZonesMXRecordSpecTargetResourceReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20180501.DnsZonesMXRecord_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("AAAARecords")]
    public IList<V1api20180501storageDnsZonesMXRecordSpecAAAARecords>? AAAARecords { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ARecords")]
    public IList<V1api20180501storageDnsZonesMXRecordSpecARecords>? ARecords { get; set; }

    /// <summary>Storage version of v1api20180501.CnameRecord A CNAME record.</summary>
    [JsonPropertyName("CNAMERecord")]
    public V1api20180501storageDnsZonesMXRecordSpecCNAMERecord? CNAMERecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("MXRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordSpecMXRecords>? MXRecords { get; set; }

    /// <summary></summary>
    [JsonPropertyName("NSRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordSpecNSRecords>? NSRecords { get; set; }

    /// <summary></summary>
    [JsonPropertyName("PTRRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordSpecPTRRecords>? PTRRecords { get; set; }

    /// <summary>Storage version of v1api20180501.SoaRecord An SOA record.</summary>
    [JsonPropertyName("SOARecord")]
    public V1api20180501storageDnsZonesMXRecordSpecSOARecord? SOARecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("SRVRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordSpecSRVRecords>? SRVRecords { get; set; }

    /// <summary></summary>
    [JsonPropertyName("TTL")]
    public int? TTL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("TXTRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordSpecTXTRecords>? TXTRecords { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("caaRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordSpecCaaRecords>? CaaRecords { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a network.azure.com/DnsZone resource</summary>
    [JsonPropertyName("owner")]
    public V1api20180501storageDnsZonesMXRecordSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20180501.SubResource A reference to a another resource</summary>
    [JsonPropertyName("targetResource")]
    public V1api20180501storageDnsZonesMXRecordSpecTargetResource? TargetResource { get; set; }
}

/// <summary>Storage version of v1api20180501.AaaaRecord_STATUS An AAAA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusAAAARecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }
}

/// <summary>Storage version of v1api20180501.ARecord_STATUS An A record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusARecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipv4Address")]
    public string? Ipv4Address { get; set; }
}

/// <summary>Storage version of v1api20180501.CnameRecord_STATUS A CNAME record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusCNAMERecord
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }
}

/// <summary>Storage version of v1api20180501.MxRecord_STATUS An MX record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusMXRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exchange")]
    public string? Exchange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preference")]
    public int? Preference { get; set; }
}

/// <summary>Storage version of v1api20180501.NsRecord_STATUS An NS record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusNSRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nsdname")]
    public string? Nsdname { get; set; }
}

/// <summary>Storage version of v1api20180501.PtrRecord_STATUS A PTR record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusPTRRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ptrdname")]
    public string? Ptrdname { get; set; }
}

/// <summary>Storage version of v1api20180501.SoaRecord_STATUS An SOA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusSOARecord
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expireTime")]
    public int? ExpireTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimumTTL")]
    public int? MinimumTTL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("refreshTime")]
    public int? RefreshTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("retryTime")]
    public int? RetryTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serialNumber")]
    public int? SerialNumber { get; set; }
}

/// <summary>Storage version of v1api20180501.SrvRecord_STATUS An SRV record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusSRVRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Storage version of v1api20180501.TxtRecord_STATUS A TXT record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusTXTRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

/// <summary>Storage version of v1api20180501.CaaRecord_STATUS A CAA record.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusCaaRecords
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("flags")]
    public int? Flags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20180501.SubResource_STATUS A reference to a another resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatusTargetResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20180501.DnsZonesMXRecord_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501storageDnsZonesMXRecordStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("AAAARecords")]
    public IList<V1api20180501storageDnsZonesMXRecordStatusAAAARecords>? AAAARecords { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ARecords")]
    public IList<V1api20180501storageDnsZonesMXRecordStatusARecords>? ARecords { get; set; }

    /// <summary>Storage version of v1api20180501.CnameRecord_STATUS A CNAME record.</summary>
    [JsonPropertyName("CNAMERecord")]
    public V1api20180501storageDnsZonesMXRecordStatusCNAMERecord? CNAMERecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("MXRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordStatusMXRecords>? MXRecords { get; set; }

    /// <summary></summary>
    [JsonPropertyName("NSRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordStatusNSRecords>? NSRecords { get; set; }

    /// <summary></summary>
    [JsonPropertyName("PTRRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordStatusPTRRecords>? PTRRecords { get; set; }

    /// <summary>Storage version of v1api20180501.SoaRecord_STATUS An SOA record.</summary>
    [JsonPropertyName("SOARecord")]
    public V1api20180501storageDnsZonesMXRecordStatusSOARecord? SOARecord { get; set; }

    /// <summary></summary>
    [JsonPropertyName("SRVRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordStatusSRVRecords>? SRVRecords { get; set; }

    /// <summary></summary>
    [JsonPropertyName("TTL")]
    public int? TTL { get; set; }

    /// <summary></summary>
    [JsonPropertyName("TXTRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordStatusTXTRecords>? TXTRecords { get; set; }

    /// <summary></summary>
    [JsonPropertyName("caaRecords")]
    public IList<V1api20180501storageDnsZonesMXRecordStatusCaaRecords>? CaaRecords { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20180501storageDnsZonesMXRecordStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v1api20180501.SubResource_STATUS A reference to a another resource</summary>
    [JsonPropertyName("targetResource")]
    public V1api20180501storageDnsZonesMXRecordStatusTargetResource? TargetResource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20180501.DnsZonesMXRecord Generator information: - Generated from: /dns/resource-manager/Microsoft.Network/stable/2018-05-01/dns.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/MX/{relativeRecordSetName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180501storageDnsZonesMXRecord : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20180501storageDnsZonesMXRecordSpec>, IStatus<V1api20180501storageDnsZonesMXRecordStatus>
{
    public const string KubeApiVersion = "v1api20180501storage";
    public const string KubeKind = "DnsZonesMXRecord";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "dnszonesmxrecords";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20180501.DnsZonesMXRecord_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20180501storageDnsZonesMXRecordSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20180501.DnsZonesMXRecord_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20180501storageDnsZonesMXRecordStatus? Status { get; set; }
}