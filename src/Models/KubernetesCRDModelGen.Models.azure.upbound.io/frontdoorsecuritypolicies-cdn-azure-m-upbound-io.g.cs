using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelector
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
    public V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelector
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
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomain
{
    /// <summary>The Resource Id of the Front Door Custom Domain or Front Door Endpoint that should be bound to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorDomainId")]
    public string? CdnFrontdoorDomainId { get; set; }

    /// <summary>Reference to a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
    [JsonPropertyName("cdnFrontdoorDomainIdRef")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRef? CdnFrontdoorDomainIdRef { get; set; }

    /// <summary>Selector for a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
    [JsonPropertyName("cdnFrontdoorDomainIdSelector")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelector? CdnFrontdoorDomainIdSelector { get; set; }
}

/// <summary>An association block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociation
{
    /// <summary>One or more domain blocks as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("domain")]
    public IList<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomain>? Domain { get; set; }

    /// <summary>The list of paths to match for this firewall policy. Possible value includes /*. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelector
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
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An firewall block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewall
{
    /// <summary>An association block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("association")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociation? Association { get; set; }

    /// <summary>The Resource Id of the Front Door Firewall Policy that should be linked to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyId")]
    public string? CdnFrontdoorFirewallPolicyId { get; set; }

    /// <summary>Reference to a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyIdRef")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRef? CdnFrontdoorFirewallPolicyIdRef { get; set; }

    /// <summary>Selector for a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyIdSelector")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelector? CdnFrontdoorFirewallPolicyIdSelector { get; set; }
}

/// <summary>An security_policies block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPolicies
{
    /// <summary>An firewall block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("firewall")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewall? Firewall { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProvider
{
    /// <summary>The Front Door Profile Resource Id that is linked to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorProfileId")]
    public string? CdnFrontdoorProfileId { get; set; }

    /// <summary>Reference to a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
    [JsonPropertyName("cdnFrontdoorProfileIdRef")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRef? CdnFrontdoorProfileIdRef { get; set; }

    /// <summary>Selector for a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
    [JsonPropertyName("cdnFrontdoorProfileIdSelector")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelector? CdnFrontdoorProfileIdSelector { get; set; }

    /// <summary>An security_policies block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("securityPolicies")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPolicies? SecurityPolicies { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelector
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
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomain
{
    /// <summary>The Resource Id of the Front Door Custom Domain or Front Door Endpoint that should be bound to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorDomainId")]
    public string? CdnFrontdoorDomainId { get; set; }

    /// <summary>Reference to a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
    [JsonPropertyName("cdnFrontdoorDomainIdRef")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRef? CdnFrontdoorDomainIdRef { get; set; }

    /// <summary>Selector for a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
    [JsonPropertyName("cdnFrontdoorDomainIdSelector")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelector? CdnFrontdoorDomainIdSelector { get; set; }
}

/// <summary>An association block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociation
{
    /// <summary>One or more domain blocks as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("domain")]
    public IList<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomain>? Domain { get; set; }

    /// <summary>The list of paths to match for this firewall policy. Possible value includes /*. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelector
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
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An firewall block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewall
{
    /// <summary>An association block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("association")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociation? Association { get; set; }

    /// <summary>The Resource Id of the Front Door Firewall Policy that should be linked to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyId")]
    public string? CdnFrontdoorFirewallPolicyId { get; set; }

    /// <summary>Reference to a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyIdRef")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRef? CdnFrontdoorFirewallPolicyIdRef { get; set; }

    /// <summary>Selector for a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyIdSelector")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelector? CdnFrontdoorFirewallPolicyIdSelector { get; set; }
}

/// <summary>An security_policies block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPolicies
{
    /// <summary>An firewall block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("firewall")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewall? Firewall { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProvider
{
    /// <summary>An security_policies block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("securityPolicies")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPolicies? SecurityPolicies { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecProviderConfigRef
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
public partial class V1beta1FrontdoorSecurityPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>FrontdoorSecurityPolicySpec defines the desired state of FrontdoorSecurityPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontdoorSecurityPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontdoorSecurityPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FrontdoorSecurityPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FrontdoorSecurityPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewallAssociationDomain
{
    /// <summary>(Computed) Is the Front Door Custom Domain/Endpoint activated?</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>The Resource Id of the Front Door Custom Domain or Front Door Endpoint that should be bound to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorDomainId")]
    public string? CdnFrontdoorDomainId { get; set; }
}

/// <summary>An association block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewallAssociation
{
    /// <summary>One or more domain blocks as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("domain")]
    public IList<V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewallAssociationDomain>? Domain { get; set; }

    /// <summary>The list of paths to match for this firewall policy. Possible value includes /*. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }
}

/// <summary>An firewall block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewall
{
    /// <summary>An association block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("association")]
    public V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewallAssociation? Association { get; set; }

    /// <summary>The Resource Id of the Front Door Firewall Policy that should be linked to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyId")]
    public string? CdnFrontdoorFirewallPolicyId { get; set; }
}

/// <summary>An security_policies block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPolicies
{
    /// <summary>An firewall block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("firewall")]
    public V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewall? Firewall { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicyStatusAtProvider
{
    /// <summary>The Front Door Profile Resource Id that is linked to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorProfileId")]
    public string? CdnFrontdoorProfileId { get; set; }

    /// <summary>The ID of the Front Door Security Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An security_policies block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("securityPolicies")]
    public V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPolicies? SecurityPolicies { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicyStatusConditions
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

/// <summary>FrontdoorSecurityPolicyStatus defines the observed state of FrontdoorSecurityPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FrontdoorSecurityPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FrontdoorSecurityPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FrontdoorSecurityPolicy is the Schema for the FrontdoorSecurityPolicys API. Manages a Front Door (standard/premium) Security Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorSecurityPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FrontdoorSecurityPolicySpec>, IStatus<V1beta1FrontdoorSecurityPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorSecurityPolicy";
    public const string KubeGroup = "cdn.azure.m.upbound.io";
    public const string KubePluralName = "frontdoorsecuritypolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorSecurityPolicySpec defines the desired state of FrontdoorSecurityPolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1FrontdoorSecurityPolicySpec Spec { get; set; }

    /// <summary>FrontdoorSecurityPolicyStatus defines the observed state of FrontdoorSecurityPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1FrontdoorSecurityPolicyStatus? Status { get; set; }
}

/// <summary>FrontdoorSecurityPolicy is the Schema for the FrontdoorSecurityPolicys API. Manages a Front Door (standard/premium) Security Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontdoorSecurityPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FrontdoorSecurityPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontdoorSecurityPolicyList";
    public const string KubeGroup = "cdn.azure.m.upbound.io";
    public const string KubePluralName = "frontdoorsecuritypolicies";
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
    public IList<V1beta1FrontdoorSecurityPolicy> Items { get; set; }
}