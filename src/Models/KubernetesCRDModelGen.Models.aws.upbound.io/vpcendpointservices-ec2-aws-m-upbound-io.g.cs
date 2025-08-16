using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>VPCEndpointService is the Schema for the VPCEndpointServices API. Provides a VPC Endpoint Service resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPCEndpointServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VPCEndpointService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPCEndpointServiceList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "vpcendpointservices";
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
    public IList<V1beta1VPCEndpointService> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecForProviderGatewayLoadBalancerArnsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecForProviderGatewayLoadBalancerArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointServiceSpecForProviderGatewayLoadBalancerArnsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecForProviderGatewayLoadBalancerArnsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of LB in elbv2 to populate gatewayLoadBalancerArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecForProviderGatewayLoadBalancerArnsSelector
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
    public V1beta1VPCEndpointServiceSpecForProviderGatewayLoadBalancerArnsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecForProviderNetworkLoadBalancerArnsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecForProviderNetworkLoadBalancerArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointServiceSpecForProviderNetworkLoadBalancerArnsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecForProviderNetworkLoadBalancerArnsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of LB in elbv2 to populate networkLoadBalancerArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecForProviderNetworkLoadBalancerArnsSelector
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
    public V1beta1VPCEndpointServiceSpecForProviderNetworkLoadBalancerArnsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecForProvider
{
    /// <summary>Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - true or false.</summary>
    [JsonPropertyName("acceptanceRequired")]
    public bool? AcceptanceRequired { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Gateway Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("gatewayLoadBalancerArns")]
    public IList<string>? GatewayLoadBalancerArns { get; set; }

    /// <summary>References to LB in elbv2 to populate gatewayLoadBalancerArns.</summary>
    [JsonPropertyName("gatewayLoadBalancerArnsRefs")]
    public IList<V1beta1VPCEndpointServiceSpecForProviderGatewayLoadBalancerArnsRefs>? GatewayLoadBalancerArnsRefs { get; set; }

    /// <summary>Selector for a list of LB in elbv2 to populate gatewayLoadBalancerArns.</summary>
    [JsonPropertyName("gatewayLoadBalancerArnsSelector")]
    public V1beta1VPCEndpointServiceSpecForProviderGatewayLoadBalancerArnsSelector? GatewayLoadBalancerArnsSelector { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Network Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("networkLoadBalancerArns")]
    public IList<string>? NetworkLoadBalancerArns { get; set; }

    /// <summary>References to LB in elbv2 to populate networkLoadBalancerArns.</summary>
    [JsonPropertyName("networkLoadBalancerArnsRefs")]
    public IList<V1beta1VPCEndpointServiceSpecForProviderNetworkLoadBalancerArnsRefs>? NetworkLoadBalancerArnsRefs { get; set; }

    /// <summary>Selector for a list of LB in elbv2 to populate networkLoadBalancerArns.</summary>
    [JsonPropertyName("networkLoadBalancerArnsSelector")]
    public V1beta1VPCEndpointServiceSpecForProviderNetworkLoadBalancerArnsSelector? NetworkLoadBalancerArnsSelector { get; set; }

    /// <summary>The private DNS name for the service.</summary>
    [JsonPropertyName("privateDnsName")]
    public string? PrivateDnsName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The supported IP address types. The possible values are ipv4 and ipv6.</summary>
    [JsonPropertyName("supportedIpAddressTypes")]
    public IList<string>? SupportedIpAddressTypes { get; set; }

    /// <summary>The set of regions from which service consumers can access the service.</summary>
    [JsonPropertyName("supportedRegions")]
    public IList<string>? SupportedRegions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecInitProviderGatewayLoadBalancerArnsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecInitProviderGatewayLoadBalancerArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointServiceSpecInitProviderGatewayLoadBalancerArnsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecInitProviderGatewayLoadBalancerArnsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of LB in elbv2 to populate gatewayLoadBalancerArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecInitProviderGatewayLoadBalancerArnsSelector
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
    public V1beta1VPCEndpointServiceSpecInitProviderGatewayLoadBalancerArnsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecInitProviderNetworkLoadBalancerArnsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecInitProviderNetworkLoadBalancerArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPCEndpointServiceSpecInitProviderNetworkLoadBalancerArnsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecInitProviderNetworkLoadBalancerArnsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of LB in elbv2 to populate networkLoadBalancerArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecInitProviderNetworkLoadBalancerArnsSelector
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
    public V1beta1VPCEndpointServiceSpecInitProviderNetworkLoadBalancerArnsSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecInitProvider
{
    /// <summary>Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - true or false.</summary>
    [JsonPropertyName("acceptanceRequired")]
    public bool? AcceptanceRequired { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Gateway Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("gatewayLoadBalancerArns")]
    public IList<string>? GatewayLoadBalancerArns { get; set; }

    /// <summary>References to LB in elbv2 to populate gatewayLoadBalancerArns.</summary>
    [JsonPropertyName("gatewayLoadBalancerArnsRefs")]
    public IList<V1beta1VPCEndpointServiceSpecInitProviderGatewayLoadBalancerArnsRefs>? GatewayLoadBalancerArnsRefs { get; set; }

    /// <summary>Selector for a list of LB in elbv2 to populate gatewayLoadBalancerArns.</summary>
    [JsonPropertyName("gatewayLoadBalancerArnsSelector")]
    public V1beta1VPCEndpointServiceSpecInitProviderGatewayLoadBalancerArnsSelector? GatewayLoadBalancerArnsSelector { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Network Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("networkLoadBalancerArns")]
    public IList<string>? NetworkLoadBalancerArns { get; set; }

    /// <summary>References to LB in elbv2 to populate networkLoadBalancerArns.</summary>
    [JsonPropertyName("networkLoadBalancerArnsRefs")]
    public IList<V1beta1VPCEndpointServiceSpecInitProviderNetworkLoadBalancerArnsRefs>? NetworkLoadBalancerArnsRefs { get; set; }

    /// <summary>Selector for a list of LB in elbv2 to populate networkLoadBalancerArns.</summary>
    [JsonPropertyName("networkLoadBalancerArnsSelector")]
    public V1beta1VPCEndpointServiceSpecInitProviderNetworkLoadBalancerArnsSelector? NetworkLoadBalancerArnsSelector { get; set; }

    /// <summary>The private DNS name for the service.</summary>
    [JsonPropertyName("privateDnsName")]
    public string? PrivateDnsName { get; set; }

    /// <summary>The supported IP address types. The possible values are ipv4 and ipv6.</summary>
    [JsonPropertyName("supportedIpAddressTypes")]
    public IList<string>? SupportedIpAddressTypes { get; set; }

    /// <summary>The set of regions from which service consumers can access the service.</summary>
    [JsonPropertyName("supportedRegions")]
    public IList<string>? SupportedRegions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpecProviderConfigRef
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
public partial class V1beta1VPCEndpointServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>VPCEndpointServiceSpec defines the desired state of VPCEndpointService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPCEndpointServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPCEndpointServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPCEndpointServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPCEndpointServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceStatusAtProviderPrivateDnsNameConfiguration
{
    /// <summary>Name of the record subdomain the service provider needs to create.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The state of the VPC endpoint service.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Endpoint service verification type, for example TXT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value the service provider adds to the private DNS name domain record before verification.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceStatusAtProvider
{
    /// <summary>Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - true or false.</summary>
    [JsonPropertyName("acceptanceRequired")]
    public bool? AcceptanceRequired { get; set; }

    /// <summary>The ARNs of one or more principals allowed to discover the endpoint service.</summary>
    [JsonPropertyName("allowedPrincipals")]
    public IList<string>? AllowedPrincipals { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the VPC endpoint service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A set of Availability Zones in which the service is available.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>A set of DNS names for the service.</summary>
    [JsonPropertyName("baseEndpointDnsNames")]
    public IList<string>? BaseEndpointDnsNames { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Gateway Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("gatewayLoadBalancerArns")]
    public IList<string>? GatewayLoadBalancerArns { get; set; }

    /// <summary>The ID of the VPC endpoint service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether or not the service manages its VPC endpoints - true or false.</summary>
    [JsonPropertyName("managesVpcEndpoints")]
    public bool? ManagesVpcEndpoints { get; set; }

    /// <summary>Amazon Resource Names (ARNs) of one or more Network Load Balancers for the endpoint service.</summary>
    [JsonPropertyName("networkLoadBalancerArns")]
    public IList<string>? NetworkLoadBalancerArns { get; set; }

    /// <summary>The private DNS name for the service.</summary>
    [JsonPropertyName("privateDnsName")]
    public string? PrivateDnsName { get; set; }

    /// <summary>List of objects containing information about the endpoint service private DNS name configuration.</summary>
    [JsonPropertyName("privateDnsNameConfiguration")]
    public IList<V1beta1VPCEndpointServiceStatusAtProviderPrivateDnsNameConfiguration>? PrivateDnsNameConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The service name.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>The service type, Gateway or Interface.</summary>
    [JsonPropertyName("serviceType")]
    public string? ServiceType { get; set; }

    /// <summary>The state of the VPC endpoint service.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The supported IP address types. The possible values are ipv4 and ipv6.</summary>
    [JsonPropertyName("supportedIpAddressTypes")]
    public IList<string>? SupportedIpAddressTypes { get; set; }

    /// <summary>The set of regions from which service consumers can access the service.</summary>
    [JsonPropertyName("supportedRegions")]
    public IList<string>? SupportedRegions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceStatusConditions
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

/// <summary>VPCEndpointServiceStatus defines the observed state of VPCEndpointService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCEndpointServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPCEndpointServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPCEndpointServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VPCEndpointService is the Schema for the VPCEndpointServices API. Provides a VPC Endpoint Service resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPCEndpointService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPCEndpointServiceSpec>, IStatus<V1beta1VPCEndpointServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPCEndpointService";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "vpcendpointservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPCEndpointServiceSpec defines the desired state of VPCEndpointService</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPCEndpointServiceSpec Spec { get; set; }

    /// <summary>VPCEndpointServiceStatus defines the observed state of VPCEndpointService.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPCEndpointServiceStatus? Status { get; set; }
}