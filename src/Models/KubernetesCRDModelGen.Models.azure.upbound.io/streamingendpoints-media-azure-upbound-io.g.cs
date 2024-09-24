using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.media.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecDeletionPolicyEnum
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
public partial class V1beta1StreamingEndpointSpecForProviderAccessControlAkamaiSignatureHeaderAuthenticationKey
{
    /// <summary>Authentication key.</summary>
    [JsonPropertyName("base64Key")]
    public string? Base64Key { get; set; }

    /// <summary>The expiration time of the authentication key.</summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; set; }

    /// <summary>Identifier of the key.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecForProviderAccessControlIpAllow
{
    /// <summary>The IP address to allow.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The sku name of Streaming Endpoint.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The subnet mask prefix length (see CIDR notation).</summary>
    [JsonPropertyName("subnetPrefixLength")]
    public double? SubnetPrefixLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecForProviderAccessControl
{
    /// <summary>One or more akamai_signature_header_authentication_key blocks as defined below.</summary>
    [JsonPropertyName("akamaiSignatureHeaderAuthenticationKey")]
    public IList<V1beta1StreamingEndpointSpecForProviderAccessControlAkamaiSignatureHeaderAuthenticationKey>? AkamaiSignatureHeaderAuthenticationKey { get; set; }

    /// <summary>A ip_allow block as defined below.</summary>
    [JsonPropertyName("ipAllow")]
    public IList<V1beta1StreamingEndpointSpecForProviderAccessControlIpAllow>? IpAllow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecForProviderCrossSiteAccessPolicy
{
    /// <summary>The content of clientaccesspolicy.xml used by Silverlight.</summary>
    [JsonPropertyName("clientAccessPolicy")]
    public string? ClientAccessPolicy { get; set; }

    /// <summary>The content of crossdomain.xml used by Silverlight.</summary>
    [JsonPropertyName("crossDomainPolicy")]
    public string? CrossDomainPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameRefPolicyResolveEnum
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
public partial class V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum>))]
    public V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameRefPolicyResolveEnum>))]
    public V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServicesAccount in media to populate mediaServicesAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum
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
public partial class V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum>))]
    public V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum>))]
    public V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServicesAccount in media to populate mediaServicesAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecForProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1StreamingEndpointSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1StreamingEndpointSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1StreamingEndpointSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingEndpointSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1StreamingEndpointSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1StreamingEndpointSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1StreamingEndpointSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingEndpointSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecForProvider
{
    /// <summary>A access_control block as defined below.</summary>
    [JsonPropertyName("accessControl")]
    public IList<V1beta1StreamingEndpointSpecForProviderAccessControl>? AccessControl { get; set; }

    /// <summary>The flag indicates if the resource should be automatically started on creation.</summary>
    [JsonPropertyName("autoStartEnabled")]
    public bool? AutoStartEnabled { get; set; }

    /// <summary>The CDN enabled flag.</summary>
    [JsonPropertyName("cdnEnabled")]
    public bool? CdnEnabled { get; set; }

    /// <summary>The CDN profile name.</summary>
    [JsonPropertyName("cdnProfile")]
    public string? CdnProfile { get; set; }

    /// <summary>The CDN provider name. Supported value are StandardVerizon,PremiumVerizon and StandardAkamai</summary>
    [JsonPropertyName("cdnProvider")]
    public string? CdnProvider { get; set; }

    /// <summary>A cross_site_access_policy block as defined below.</summary>
    [JsonPropertyName("crossSiteAccessPolicy")]
    public IList<V1beta1StreamingEndpointSpecForProviderCrossSiteAccessPolicy>? CrossSiteAccessPolicy { get; set; }

    /// <summary>The custom host names of the streaming endpoint.</summary>
    [JsonPropertyName("customHostNames")]
    public IList<string>? CustomHostNames { get; set; }

    /// <summary>The streaming endpoint description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Azure Region where the Streaming Endpoint should exist. Changing this forces a new Streaming Endpoint to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Max cache age in seconds.</summary>
    [JsonPropertyName("maxCacheAgeSeconds")]
    public double? MaxCacheAgeSeconds { get; set; }

    /// <summary>The Media Services account name. Changing this forces a new Streaming Endpoint to be created.</summary>
    [JsonPropertyName("mediaServicesAccountName")]
    public string? MediaServicesAccountName { get; set; }

    /// <summary>Reference to a ServicesAccount in media to populate mediaServicesAccountName.</summary>
    [JsonPropertyName("mediaServicesAccountNameRef")]
    public V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameRef? MediaServicesAccountNameRef { get; set; }

    /// <summary>Selector for a ServicesAccount in media to populate mediaServicesAccountName.</summary>
    [JsonPropertyName("mediaServicesAccountNameSelector")]
    public V1beta1StreamingEndpointSpecForProviderMediaServicesAccountNameSelector? MediaServicesAccountNameSelector { get; set; }

    /// <summary>The name of the Resource Group where the Streaming Endpoint should exist. Changing this forces a new Streaming Endpoint to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1StreamingEndpointSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1StreamingEndpointSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The number of scale units. To create a Standard Streaming Endpoint set 0. For Premium Streaming Endpoint valid values are between 1 and 10.</summary>
    [JsonPropertyName("scaleUnits")]
    public double? ScaleUnits { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Streaming Endpoint.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecInitProviderAccessControlAkamaiSignatureHeaderAuthenticationKey
{
    /// <summary>Authentication key.</summary>
    [JsonPropertyName("base64Key")]
    public string? Base64Key { get; set; }

    /// <summary>The expiration time of the authentication key.</summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; set; }

    /// <summary>Identifier of the key.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecInitProviderAccessControlIpAllow
{
    /// <summary>The IP address to allow.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The sku name of Streaming Endpoint.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The subnet mask prefix length (see CIDR notation).</summary>
    [JsonPropertyName("subnetPrefixLength")]
    public double? SubnetPrefixLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecInitProviderAccessControl
{
    /// <summary>One or more akamai_signature_header_authentication_key blocks as defined below.</summary>
    [JsonPropertyName("akamaiSignatureHeaderAuthenticationKey")]
    public IList<V1beta1StreamingEndpointSpecInitProviderAccessControlAkamaiSignatureHeaderAuthenticationKey>? AkamaiSignatureHeaderAuthenticationKey { get; set; }

    /// <summary>A ip_allow block as defined below.</summary>
    [JsonPropertyName("ipAllow")]
    public IList<V1beta1StreamingEndpointSpecInitProviderAccessControlIpAllow>? IpAllow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecInitProviderCrossSiteAccessPolicy
{
    /// <summary>The content of clientaccesspolicy.xml used by Silverlight.</summary>
    [JsonPropertyName("clientAccessPolicy")]
    public string? ClientAccessPolicy { get; set; }

    /// <summary>The content of crossdomain.xml used by Silverlight.</summary>
    [JsonPropertyName("crossDomainPolicy")]
    public string? CrossDomainPolicy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecInitProvider
{
    /// <summary>A access_control block as defined below.</summary>
    [JsonPropertyName("accessControl")]
    public IList<V1beta1StreamingEndpointSpecInitProviderAccessControl>? AccessControl { get; set; }

    /// <summary>The flag indicates if the resource should be automatically started on creation.</summary>
    [JsonPropertyName("autoStartEnabled")]
    public bool? AutoStartEnabled { get; set; }

    /// <summary>The CDN enabled flag.</summary>
    [JsonPropertyName("cdnEnabled")]
    public bool? CdnEnabled { get; set; }

    /// <summary>The CDN profile name.</summary>
    [JsonPropertyName("cdnProfile")]
    public string? CdnProfile { get; set; }

    /// <summary>The CDN provider name. Supported value are StandardVerizon,PremiumVerizon and StandardAkamai</summary>
    [JsonPropertyName("cdnProvider")]
    public string? CdnProvider { get; set; }

    /// <summary>A cross_site_access_policy block as defined below.</summary>
    [JsonPropertyName("crossSiteAccessPolicy")]
    public IList<V1beta1StreamingEndpointSpecInitProviderCrossSiteAccessPolicy>? CrossSiteAccessPolicy { get; set; }

    /// <summary>The custom host names of the streaming endpoint.</summary>
    [JsonPropertyName("customHostNames")]
    public IList<string>? CustomHostNames { get; set; }

    /// <summary>The streaming endpoint description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Azure Region where the Streaming Endpoint should exist. Changing this forces a new Streaming Endpoint to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Max cache age in seconds.</summary>
    [JsonPropertyName("maxCacheAgeSeconds")]
    public double? MaxCacheAgeSeconds { get; set; }

    /// <summary>The number of scale units. To create a Standard Streaming Endpoint set 0. For Premium Streaming Endpoint valid values are between 1 and 10.</summary>
    [JsonPropertyName("scaleUnits")]
    public double? ScaleUnits { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Streaming Endpoint.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecManagementPoliciesEnum
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
public enum V1beta1StreamingEndpointSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1StreamingEndpointSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1StreamingEndpointSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1StreamingEndpointSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingEndpointSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1StreamingEndpointSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1StreamingEndpointSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1StreamingEndpointSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1StreamingEndpointSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1StreamingEndpointSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1StreamingEndpointSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1StreamingEndpointSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1StreamingEndpointSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>StreamingEndpointSpec defines the desired state of StreamingEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1StreamingEndpointSpecDeletionPolicyEnum>))]
    public V1beta1StreamingEndpointSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1StreamingEndpointSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1StreamingEndpointSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1StreamingEndpointSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StreamingEndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1StreamingEndpointSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StreamingEndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointStatusAtProviderAccessControlAkamaiSignatureHeaderAuthenticationKey
{
    /// <summary>Authentication key.</summary>
    [JsonPropertyName("base64Key")]
    public string? Base64Key { get; set; }

    /// <summary>The expiration time of the authentication key.</summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; set; }

    /// <summary>Identifier of the key.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointStatusAtProviderAccessControlIpAllow
{
    /// <summary>The IP address to allow.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The sku name of Streaming Endpoint.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The subnet mask prefix length (see CIDR notation).</summary>
    [JsonPropertyName("subnetPrefixLength")]
    public double? SubnetPrefixLength { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointStatusAtProviderAccessControl
{
    /// <summary>One or more akamai_signature_header_authentication_key blocks as defined below.</summary>
    [JsonPropertyName("akamaiSignatureHeaderAuthenticationKey")]
    public IList<V1beta1StreamingEndpointStatusAtProviderAccessControlAkamaiSignatureHeaderAuthenticationKey>? AkamaiSignatureHeaderAuthenticationKey { get; set; }

    /// <summary>A ip_allow block as defined below.</summary>
    [JsonPropertyName("ipAllow")]
    public IList<V1beta1StreamingEndpointStatusAtProviderAccessControlIpAllow>? IpAllow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointStatusAtProviderCrossSiteAccessPolicy
{
    /// <summary>The content of clientaccesspolicy.xml used by Silverlight.</summary>
    [JsonPropertyName("clientAccessPolicy")]
    public string? ClientAccessPolicy { get; set; }

    /// <summary>The content of crossdomain.xml used by Silverlight.</summary>
    [JsonPropertyName("crossDomainPolicy")]
    public string? CrossDomainPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointStatusAtProviderSku
{
    /// <summary>The sku capacity of Streaming Endpoint.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The sku name of Streaming Endpoint.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointStatusAtProvider
{
    /// <summary>A access_control block as defined below.</summary>
    [JsonPropertyName("accessControl")]
    public IList<V1beta1StreamingEndpointStatusAtProviderAccessControl>? AccessControl { get; set; }

    /// <summary>The flag indicates if the resource should be automatically started on creation.</summary>
    [JsonPropertyName("autoStartEnabled")]
    public bool? AutoStartEnabled { get; set; }

    /// <summary>The CDN enabled flag.</summary>
    [JsonPropertyName("cdnEnabled")]
    public bool? CdnEnabled { get; set; }

    /// <summary>The CDN profile name.</summary>
    [JsonPropertyName("cdnProfile")]
    public string? CdnProfile { get; set; }

    /// <summary>The CDN provider name. Supported value are StandardVerizon,PremiumVerizon and StandardAkamai</summary>
    [JsonPropertyName("cdnProvider")]
    public string? CdnProvider { get; set; }

    /// <summary>A cross_site_access_policy block as defined below.</summary>
    [JsonPropertyName("crossSiteAccessPolicy")]
    public IList<V1beta1StreamingEndpointStatusAtProviderCrossSiteAccessPolicy>? CrossSiteAccessPolicy { get; set; }

    /// <summary>The custom host names of the streaming endpoint.</summary>
    [JsonPropertyName("customHostNames")]
    public IList<string>? CustomHostNames { get; set; }

    /// <summary>The streaming endpoint description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The host name of the Streaming Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Streaming Endpoint.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Azure Region where the Streaming Endpoint should exist. Changing this forces a new Streaming Endpoint to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Max cache age in seconds.</summary>
    [JsonPropertyName("maxCacheAgeSeconds")]
    public double? MaxCacheAgeSeconds { get; set; }

    /// <summary>The Media Services account name. Changing this forces a new Streaming Endpoint to be created.</summary>
    [JsonPropertyName("mediaServicesAccountName")]
    public string? MediaServicesAccountName { get; set; }

    /// <summary>The name of the Resource Group where the Streaming Endpoint should exist. Changing this forces a new Streaming Endpoint to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The number of scale units. To create a Standard Streaming Endpoint set 0. For Premium Streaming Endpoint valid values are between 1 and 10.</summary>
    [JsonPropertyName("scaleUnits")]
    public double? ScaleUnits { get; set; }

    /// <summary>A sku block defined as below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1StreamingEndpointStatusAtProviderSku>? Sku { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Streaming Endpoint.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointStatusConditions
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

/// <summary>StreamingEndpointStatus defines the observed state of StreamingEndpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StreamingEndpointStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1StreamingEndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StreamingEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>StreamingEndpoint is the Schema for the StreamingEndpoints API. Manages a Streaming Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StreamingEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StreamingEndpointSpec>, IStatus<V1beta1StreamingEndpointStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StreamingEndpoint";
    public const string KubeGroup = "media.azure.upbound.io";
    public const string KubePluralName = "streamingendpoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StreamingEndpointSpec defines the desired state of StreamingEndpoint</summary>
    [JsonPropertyName("spec")]
    public V1beta1StreamingEndpointSpec Spec { get; set; }

    /// <summary>StreamingEndpointStatus defines the observed state of StreamingEndpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1StreamingEndpointStatus? Status { get; set; }
}