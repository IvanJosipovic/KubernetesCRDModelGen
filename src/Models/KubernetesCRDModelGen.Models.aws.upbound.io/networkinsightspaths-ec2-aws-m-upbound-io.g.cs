using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderDestinationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInsightsPathSpecForProviderDestinationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderDestinationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderDestinationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInsightsPathSpecForProviderDestinationSelectorPolicy? Policy { get; set; }
}

/// <summary>The destination port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderFilterAtDestinationDestinationPortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>The source port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderFilterAtDestinationSourcePortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Scopes the analysis to network paths that match specific filters at the destination. If you specify this parameter, you can't specify destination_ip. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderFilterAtDestination
{
    /// <summary>The destination IPv4 address.</summary>
    [JsonPropertyName("destinationAddress")]
    public string? DestinationAddress { get; set; }

    /// <summary>The destination port range. See below for details.</summary>
    [JsonPropertyName("destinationPortRange")]
    public V1beta1NetworkInsightsPathSpecForProviderFilterAtDestinationDestinationPortRange? DestinationPortRange { get; set; }

    /// <summary>IP address of the source resource.</summary>
    [JsonPropertyName("sourceAddress")]
    public string? SourceAddress { get; set; }

    /// <summary>The source port range. See below for details.</summary>
    [JsonPropertyName("sourcePortRange")]
    public V1beta1NetworkInsightsPathSpecForProviderFilterAtDestinationSourcePortRange? SourcePortRange { get; set; }
}

/// <summary>The destination port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderFilterAtSourceDestinationPortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>The source port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderFilterAtSourceSourcePortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Scopes the analysis to network paths that match specific filters at the source. If you specify this parameter, you can't specify source_ip or destination_port. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderFilterAtSource
{
    /// <summary>The destination IPv4 address.</summary>
    [JsonPropertyName("destinationAddress")]
    public string? DestinationAddress { get; set; }

    /// <summary>The destination port range. See below for details.</summary>
    [JsonPropertyName("destinationPortRange")]
    public V1beta1NetworkInsightsPathSpecForProviderFilterAtSourceDestinationPortRange? DestinationPortRange { get; set; }

    /// <summary>IP address of the source resource.</summary>
    [JsonPropertyName("sourceAddress")]
    public string? SourceAddress { get; set; }

    /// <summary>The source port range. See below for details.</summary>
    [JsonPropertyName("sourcePortRange")]
    public V1beta1NetworkInsightsPathSpecForProviderFilterAtSourceSourcePortRange? SourcePortRange { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInsightsPathSpecForProviderSourceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProviderSourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInsightsPathSpecForProviderSourceSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecForProvider
{
    /// <summary>ID or ARN of the resource which is the destination of the path. Can be an Instance, Internet Gateway, Network Interface, Transit Gateway, VPC Endpoint, VPC Peering Connection or VPN Gateway. If the resource is in another account, you must specify an ARN. Either the destination argument or the destination_address argument in the filter_at_source block must be specified.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>IP address of the destination resource.</summary>
    [JsonPropertyName("destinationIp")]
    public string? DestinationIp { get; set; }

    /// <summary>Destination port to analyze access to.</summary>
    [JsonPropertyName("destinationPort")]
    public double? DestinationPort { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate destination.</summary>
    [JsonPropertyName("destinationRef")]
    public V1beta1NetworkInsightsPathSpecForProviderDestinationRef? DestinationRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate destination.</summary>
    [JsonPropertyName("destinationSelector")]
    public V1beta1NetworkInsightsPathSpecForProviderDestinationSelector? DestinationSelector { get; set; }

    /// <summary>Scopes the analysis to network paths that match specific filters at the destination. If you specify this parameter, you can't specify destination_ip. See below for details.</summary>
    [JsonPropertyName("filterAtDestination")]
    public V1beta1NetworkInsightsPathSpecForProviderFilterAtDestination? FilterAtDestination { get; set; }

    /// <summary>Scopes the analysis to network paths that match specific filters at the source. If you specify this parameter, you can't specify source_ip or destination_port. See below for details.</summary>
    [JsonPropertyName("filterAtSource")]
    public V1beta1NetworkInsightsPathSpecForProviderFilterAtSource? FilterAtSource { get; set; }

    /// <summary>Protocol to use for analysis. Valid options are tcp or udp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>ID or ARN of the resource which is the source of the path. Can be an Instance, Internet Gateway, Network Interface, Transit Gateway, VPC Endpoint, VPC Peering Connection or VPN Gateway. If the resource is in another account, you must specify an ARN.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>IP address of the source resource.</summary>
    [JsonPropertyName("sourceIp")]
    public string? SourceIp { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate source.</summary>
    [JsonPropertyName("sourceRef")]
    public V1beta1NetworkInsightsPathSpecForProviderSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta1NetworkInsightsPathSpecForProviderSourceSelector? SourceSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderDestinationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInsightsPathSpecInitProviderDestinationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderDestinationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderDestinationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInsightsPathSpecInitProviderDestinationSelectorPolicy? Policy { get; set; }
}

/// <summary>The destination port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderFilterAtDestinationDestinationPortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>The source port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderFilterAtDestinationSourcePortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Scopes the analysis to network paths that match specific filters at the destination. If you specify this parameter, you can't specify destination_ip. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderFilterAtDestination
{
    /// <summary>The destination IPv4 address.</summary>
    [JsonPropertyName("destinationAddress")]
    public string? DestinationAddress { get; set; }

    /// <summary>The destination port range. See below for details.</summary>
    [JsonPropertyName("destinationPortRange")]
    public V1beta1NetworkInsightsPathSpecInitProviderFilterAtDestinationDestinationPortRange? DestinationPortRange { get; set; }

    /// <summary>IP address of the source resource.</summary>
    [JsonPropertyName("sourceAddress")]
    public string? SourceAddress { get; set; }

    /// <summary>The source port range. See below for details.</summary>
    [JsonPropertyName("sourcePortRange")]
    public V1beta1NetworkInsightsPathSpecInitProviderFilterAtDestinationSourcePortRange? SourcePortRange { get; set; }
}

/// <summary>The destination port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderFilterAtSourceDestinationPortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>The source port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderFilterAtSourceSourcePortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Scopes the analysis to network paths that match specific filters at the source. If you specify this parameter, you can't specify source_ip or destination_port. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderFilterAtSource
{
    /// <summary>The destination IPv4 address.</summary>
    [JsonPropertyName("destinationAddress")]
    public string? DestinationAddress { get; set; }

    /// <summary>The destination port range. See below for details.</summary>
    [JsonPropertyName("destinationPortRange")]
    public V1beta1NetworkInsightsPathSpecInitProviderFilterAtSourceDestinationPortRange? DestinationPortRange { get; set; }

    /// <summary>IP address of the source resource.</summary>
    [JsonPropertyName("sourceAddress")]
    public string? SourceAddress { get; set; }

    /// <summary>The source port range. See below for details.</summary>
    [JsonPropertyName("sourcePortRange")]
    public V1beta1NetworkInsightsPathSpecInitProviderFilterAtSourceSourcePortRange? SourcePortRange { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderSourceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInsightsPathSpecInitProviderSourceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderSourceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProviderSourceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NetworkInsightsPathSpecInitProviderSourceSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecInitProvider
{
    /// <summary>ID or ARN of the resource which is the destination of the path. Can be an Instance, Internet Gateway, Network Interface, Transit Gateway, VPC Endpoint, VPC Peering Connection or VPN Gateway. If the resource is in another account, you must specify an ARN. Either the destination argument or the destination_address argument in the filter_at_source block must be specified.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>IP address of the destination resource.</summary>
    [JsonPropertyName("destinationIp")]
    public string? DestinationIp { get; set; }

    /// <summary>Destination port to analyze access to.</summary>
    [JsonPropertyName("destinationPort")]
    public double? DestinationPort { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate destination.</summary>
    [JsonPropertyName("destinationRef")]
    public V1beta1NetworkInsightsPathSpecInitProviderDestinationRef? DestinationRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate destination.</summary>
    [JsonPropertyName("destinationSelector")]
    public V1beta1NetworkInsightsPathSpecInitProviderDestinationSelector? DestinationSelector { get; set; }

    /// <summary>Scopes the analysis to network paths that match specific filters at the destination. If you specify this parameter, you can't specify destination_ip. See below for details.</summary>
    [JsonPropertyName("filterAtDestination")]
    public V1beta1NetworkInsightsPathSpecInitProviderFilterAtDestination? FilterAtDestination { get; set; }

    /// <summary>Scopes the analysis to network paths that match specific filters at the source. If you specify this parameter, you can't specify source_ip or destination_port. See below for details.</summary>
    [JsonPropertyName("filterAtSource")]
    public V1beta1NetworkInsightsPathSpecInitProviderFilterAtSource? FilterAtSource { get; set; }

    /// <summary>Protocol to use for analysis. Valid options are tcp or udp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>ID or ARN of the resource which is the source of the path. Can be an Instance, Internet Gateway, Network Interface, Transit Gateway, VPC Endpoint, VPC Peering Connection or VPN Gateway. If the resource is in another account, you must specify an ARN.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>IP address of the source resource.</summary>
    [JsonPropertyName("sourceIp")]
    public string? SourceIp { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate source.</summary>
    [JsonPropertyName("sourceRef")]
    public V1beta1NetworkInsightsPathSpecInitProviderSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta1NetworkInsightsPathSpecInitProviderSourceSelector? SourceSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>NetworkInsightsPathSpec defines the desired state of NetworkInsightsPath</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NetworkInsightsPathSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NetworkInsightsPathSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NetworkInsightsPathSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NetworkInsightsPathSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The destination port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathStatusAtProviderFilterAtDestinationDestinationPortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>The source port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathStatusAtProviderFilterAtDestinationSourcePortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Scopes the analysis to network paths that match specific filters at the destination. If you specify this parameter, you can't specify destination_ip. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathStatusAtProviderFilterAtDestination
{
    /// <summary>The destination IPv4 address.</summary>
    [JsonPropertyName("destinationAddress")]
    public string? DestinationAddress { get; set; }

    /// <summary>The destination port range. See below for details.</summary>
    [JsonPropertyName("destinationPortRange")]
    public V1beta1NetworkInsightsPathStatusAtProviderFilterAtDestinationDestinationPortRange? DestinationPortRange { get; set; }

    /// <summary>IP address of the source resource.</summary>
    [JsonPropertyName("sourceAddress")]
    public string? SourceAddress { get; set; }

    /// <summary>The source port range. See below for details.</summary>
    [JsonPropertyName("sourcePortRange")]
    public V1beta1NetworkInsightsPathStatusAtProviderFilterAtDestinationSourcePortRange? SourcePortRange { get; set; }
}

/// <summary>The destination port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathStatusAtProviderFilterAtSourceDestinationPortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>The source port range. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathStatusAtProviderFilterAtSourceSourcePortRange
{
    /// <summary>The first port in the range.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The last port in the range.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

/// <summary>Scopes the analysis to network paths that match specific filters at the source. If you specify this parameter, you can't specify source_ip or destination_port. See below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathStatusAtProviderFilterAtSource
{
    /// <summary>The destination IPv4 address.</summary>
    [JsonPropertyName("destinationAddress")]
    public string? DestinationAddress { get; set; }

    /// <summary>The destination port range. See below for details.</summary>
    [JsonPropertyName("destinationPortRange")]
    public V1beta1NetworkInsightsPathStatusAtProviderFilterAtSourceDestinationPortRange? DestinationPortRange { get; set; }

    /// <summary>IP address of the source resource.</summary>
    [JsonPropertyName("sourceAddress")]
    public string? SourceAddress { get; set; }

    /// <summary>The source port range. See below for details.</summary>
    [JsonPropertyName("sourcePortRange")]
    public V1beta1NetworkInsightsPathStatusAtProviderFilterAtSourceSourcePortRange? SourcePortRange { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathStatusAtProvider
{
    /// <summary>ARN of the Network Insights Path.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ID or ARN of the resource which is the destination of the path. Can be an Instance, Internet Gateway, Network Interface, Transit Gateway, VPC Endpoint, VPC Peering Connection or VPN Gateway. If the resource is in another account, you must specify an ARN. Either the destination argument or the destination_address argument in the filter_at_source block must be specified.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>ARN of the destination.</summary>
    [JsonPropertyName("destinationArn")]
    public string? DestinationArn { get; set; }

    /// <summary>IP address of the destination resource.</summary>
    [JsonPropertyName("destinationIp")]
    public string? DestinationIp { get; set; }

    /// <summary>Destination port to analyze access to.</summary>
    [JsonPropertyName("destinationPort")]
    public double? DestinationPort { get; set; }

    /// <summary>Scopes the analysis to network paths that match specific filters at the destination. If you specify this parameter, you can't specify destination_ip. See below for details.</summary>
    [JsonPropertyName("filterAtDestination")]
    public V1beta1NetworkInsightsPathStatusAtProviderFilterAtDestination? FilterAtDestination { get; set; }

    /// <summary>Scopes the analysis to network paths that match specific filters at the source. If you specify this parameter, you can't specify source_ip or destination_port. See below for details.</summary>
    [JsonPropertyName("filterAtSource")]
    public V1beta1NetworkInsightsPathStatusAtProviderFilterAtSource? FilterAtSource { get; set; }

    /// <summary>ID of the Network Insights Path.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Protocol to use for analysis. Valid options are tcp or udp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ID or ARN of the resource which is the source of the path. Can be an Instance, Internet Gateway, Network Interface, Transit Gateway, VPC Endpoint, VPC Peering Connection or VPN Gateway. If the resource is in another account, you must specify an ARN.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>ARN of the source.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }

    /// <summary>IP address of the source resource.</summary>
    [JsonPropertyName("sourceIp")]
    public string? SourceIp { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathStatusConditions
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

/// <summary>NetworkInsightsPathStatus defines the observed state of NetworkInsightsPath.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkInsightsPathStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NetworkInsightsPathStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NetworkInsightsPathStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NetworkInsightsPath is the Schema for the NetworkInsightsPaths API. Provides a Network Insights Path resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkInsightsPath : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NetworkInsightsPathSpec>, IStatus<V1beta1NetworkInsightsPathStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkInsightsPath";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "networkinsightspaths";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkInsightsPathSpec defines the desired state of NetworkInsightsPath</summary>
    [JsonPropertyName("spec")]
    public V1beta1NetworkInsightsPathSpec Spec { get; set; }

    /// <summary>NetworkInsightsPathStatus defines the observed state of NetworkInsightsPath.</summary>
    [JsonPropertyName("status")]
    public V1beta1NetworkInsightsPathStatus? Status { get; set; }
}

/// <summary>NetworkInsightsPath is the Schema for the NetworkInsightsPaths API. Provides a Network Insights Path resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkInsightsPathList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NetworkInsightsPath>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkInsightsPathList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "networkinsightspaths";
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
    public IList<V1beta1NetworkInsightsPath> Items { get; set; }
}