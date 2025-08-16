using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.conditionalaccess.azuread.upbound.io;
/// <summary>Location is the Schema for the Locations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LocationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Location>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LocationList";
    public const string KubeGroup = "conditionalaccess.azuread.upbound.io";
    public const string KubePluralName = "locations";
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
    public IList<V1beta1Location> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecForProviderCountry
{
    /// <summary>List of countries and/or regions in two-letter format specified by ISO 3166-2.</summary>
    [JsonPropertyName("countriesAndRegions")]
    public IList<string>? CountriesAndRegions { get; set; }

    /// <summary>Method of detecting country the user is located in. Possible values are clientIpAddress for IP-based location and authenticatorAppGps for Authenticator app GPS-based location.  Defaults to clientIpAddress.</summary>
    [JsonPropertyName("countryLookupMethod")]
    public string? CountryLookupMethod { get; set; }

    /// <summary>Whether IP addresses that don't map to a country or region should be included in the named location. Defaults to false.</summary>
    [JsonPropertyName("includeUnknownCountriesAndRegions")]
    public bool? IncludeUnknownCountriesAndRegions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecForProviderIp
{
    /// <summary>List of IP address ranges in IPv4 CIDR format (e.g. 1.2.3.4/32) or any allowable IPv6 format from IETF RFC596. Each CIDR prefix must be /8 or larger.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>Whether the named location is trusted. Defaults to false.</summary>
    [JsonPropertyName("trusted")]
    public bool? Trusted { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecForProvider
{
    /// <summary>A country block as documented below, which configures a country-based named location.</summary>
    [JsonPropertyName("country")]
    public IList<V1beta1LocationSpecForProviderCountry>? Country { get; set; }

    /// <summary>The friendly name for this named location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>An ip block as documented below, which configures an IP-based named location.</summary>
    [JsonPropertyName("ip")]
    public IList<V1beta1LocationSpecForProviderIp>? Ip { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecInitProviderCountry
{
    /// <summary>List of countries and/or regions in two-letter format specified by ISO 3166-2.</summary>
    [JsonPropertyName("countriesAndRegions")]
    public IList<string>? CountriesAndRegions { get; set; }

    /// <summary>Method of detecting country the user is located in. Possible values are clientIpAddress for IP-based location and authenticatorAppGps for Authenticator app GPS-based location.  Defaults to clientIpAddress.</summary>
    [JsonPropertyName("countryLookupMethod")]
    public string? CountryLookupMethod { get; set; }

    /// <summary>Whether IP addresses that don't map to a country or region should be included in the named location. Defaults to false.</summary>
    [JsonPropertyName("includeUnknownCountriesAndRegions")]
    public bool? IncludeUnknownCountriesAndRegions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecInitProviderIp
{
    /// <summary>List of IP address ranges in IPv4 CIDR format (e.g. 1.2.3.4/32) or any allowable IPv6 format from IETF RFC596. Each CIDR prefix must be /8 or larger.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>Whether the named location is trusted. Defaults to false.</summary>
    [JsonPropertyName("trusted")]
    public bool? Trusted { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecInitProvider
{
    /// <summary>A country block as documented below, which configures a country-based named location.</summary>
    [JsonPropertyName("country")]
    public IList<V1beta1LocationSpecInitProviderCountry>? Country { get; set; }

    /// <summary>The friendly name for this named location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>An ip block as documented below, which configures an IP-based named location.</summary>
    [JsonPropertyName("ip")]
    public IList<V1beta1LocationSpecInitProviderIp>? Ip { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecProviderConfigRefPolicy
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
public partial class V1beta1LocationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LocationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LocationSpec defines the desired state of Location</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LocationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LocationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LocationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LocationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationStatusAtProviderCountry
{
    /// <summary>List of countries and/or regions in two-letter format specified by ISO 3166-2.</summary>
    [JsonPropertyName("countriesAndRegions")]
    public IList<string>? CountriesAndRegions { get; set; }

    /// <summary>Method of detecting country the user is located in. Possible values are clientIpAddress for IP-based location and authenticatorAppGps for Authenticator app GPS-based location.  Defaults to clientIpAddress.</summary>
    [JsonPropertyName("countryLookupMethod")]
    public string? CountryLookupMethod { get; set; }

    /// <summary>Whether IP addresses that don't map to a country or region should be included in the named location. Defaults to false.</summary>
    [JsonPropertyName("includeUnknownCountriesAndRegions")]
    public bool? IncludeUnknownCountriesAndRegions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationStatusAtProviderIp
{
    /// <summary>List of IP address ranges in IPv4 CIDR format (e.g. 1.2.3.4/32) or any allowable IPv6 format from IETF RFC596. Each CIDR prefix must be /8 or larger.</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>Whether the named location is trusted. Defaults to false.</summary>
    [JsonPropertyName("trusted")]
    public bool? Trusted { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationStatusAtProvider
{
    /// <summary>A country block as documented below, which configures a country-based named location.</summary>
    [JsonPropertyName("country")]
    public IList<V1beta1LocationStatusAtProviderCountry>? Country { get; set; }

    /// <summary>The friendly name for this named location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the named location.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An ip block as documented below, which configures an IP-based named location.</summary>
    [JsonPropertyName("ip")]
    public IList<V1beta1LocationStatusAtProviderIp>? Ip { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationStatusConditions
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

/// <summary>LocationStatus defines the observed state of Location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LocationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LocationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LocationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Location is the Schema for the Locations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Location : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LocationSpec>, IStatus<V1beta1LocationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Location";
    public const string KubeGroup = "conditionalaccess.azuread.upbound.io";
    public const string KubePluralName = "locations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LocationSpec defines the desired state of Location</summary>
    [JsonPropertyName("spec")]
    public V1beta1LocationSpec Spec { get; set; }

    /// <summary>LocationStatus defines the observed state of Location.</summary>
    [JsonPropertyName("status")]
    public V1beta1LocationStatus? Status { get; set; }
}