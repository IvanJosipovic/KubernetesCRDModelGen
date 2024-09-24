using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolveEnum? Resolve { get; set; }
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
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

/// <summary></summary>
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum? Resolve { get; set; }
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewall
{
    /// <summary>An association block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("association")]
    public IList<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociation>? Association { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPolicies
{
    /// <summary>An firewall block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("firewall")]
    public IList<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewall>? Firewall { get; set; }
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
    public IList<V1beta1FrontdoorSecurityPolicySpecForProviderSecurityPolicies>? SecurityPolicies { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
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

/// <summary></summary>
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum? Resolve { get; set; }
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewall
{
    /// <summary>An association block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("association")]
    public IList<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociation>? Association { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPolicies
{
    /// <summary>An firewall block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("firewall")]
    public IList<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewall>? Firewall { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecInitProvider
{
    /// <summary>An security_policies block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("securityPolicies")]
    public IList<V1beta1FrontdoorSecurityPolicySpecInitProviderSecurityPolicies>? SecurityPolicies { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FrontdoorSecurityPolicySpec defines the desired state of FrontdoorSecurityPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FrontdoorSecurityPolicySpecDeletionPolicyEnum>))]
    public V1beta1FrontdoorSecurityPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontdoorSecurityPolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontdoorSecurityPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FrontdoorSecurityPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FrontdoorSecurityPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FrontdoorSecurityPolicySpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
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

/// <summary></summary>
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewall
{
    /// <summary>An association block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("association")]
    public IList<V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewallAssociation>? Association { get; set; }

    /// <summary>The Resource Id of the Front Door Firewall Policy that should be linked to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyId")]
    public string? CdnFrontdoorFirewallPolicyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPolicies
{
    /// <summary>An firewall block as defined below. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("firewall")]
    public IList<V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewall>? Firewall { get; set; }
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
    public IList<V1beta1FrontdoorSecurityPolicyStatusAtProviderSecurityPolicies>? SecurityPolicies { get; set; }
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
    public const string KubeGroup = "cdn.azure.upbound.io";
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