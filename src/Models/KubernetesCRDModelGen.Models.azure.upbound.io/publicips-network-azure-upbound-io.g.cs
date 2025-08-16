using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary>PublicIP is the Schema for the PublicIPs API. Manages a Public IP Address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PublicIPList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PublicIP>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PublicIPList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "publicips";
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
    public IList<V1beta1PublicIP> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PublicIPSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PublicIPSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPSpecForProvider
{
    /// <summary>Defines the allocation method for this IP address. Possible values are Static or Dynamic.</summary>
    [JsonPropertyName("allocationMethod")]
    public string? AllocationMethod { get; set; }

    /// <summary>The DDoS protection mode of the public IP. Possible values are Disabled, Enabled, and VirtualNetworkInherited. Defaults to VirtualNetworkInherited.</summary>
    [JsonPropertyName("ddosProtectionMode")]
    public string? DdosProtectionMode { get; set; }

    /// <summary>The ID of DDoS protection plan associated with the public IP.</summary>
    [JsonPropertyName("ddosProtectionPlanId")]
    public string? DdosProtectionPlanId { get; set; }

    /// <summary>Label for the Domain Name. Will be used to make up the FQDN. If a domain name label is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>Scope for the domain name label. If a domain name label scope is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system with a hashed value includes in FQDN. Possible values are NoReuse, ResourceGroupReuse, SubscriptionReuse and TenantReuse. Changing this forces a new Public IP to be created.</summary>
    [JsonPropertyName("domainNameLabelScope")]
    public string? DomainNameLabelScope { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Public IP should exist. Changing this forces a new Public IP to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Specifies the timeout for the TCP idle connection. The value can be set between 4 and 30 minutes.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>A mapping of IP tags to assign to the public IP. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTags")]
    public IDictionary<string, string>? IpTags { get; set; }

    /// <summary>The IP Version to use, IPv6 or IPv4. Changing this forces a new resource to be created. Defaults to IPv4.</summary>
    [JsonPropertyName("ipVersion")]
    public string? IpVersion { get; set; }

    /// <summary>Specifies the supported Azure location where the Public IP should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>If specified then public IP address allocated will be provided from the public IP prefix resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>The name of the Resource Group where this Public IP should exist. Changing this forces a new Public IP to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1PublicIPSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1PublicIPSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A fully qualified domain name that resolves to this public IP address. If the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain to the reverse FQDN.</summary>
    [JsonPropertyName("reverseFqdn")]
    public string? ReverseFqdn { get; set; }

    /// <summary>The SKU of the Public IP. Accepted values are Basic and Standard. Defaults to Standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The SKU Tier that should be used for the Public IP. Possible values are Regional and Global. Defaults to Regional. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A collection containing the availability zone to allocate the Public IP in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPSpecInitProvider
{
    /// <summary>Defines the allocation method for this IP address. Possible values are Static or Dynamic.</summary>
    [JsonPropertyName("allocationMethod")]
    public string? AllocationMethod { get; set; }

    /// <summary>The DDoS protection mode of the public IP. Possible values are Disabled, Enabled, and VirtualNetworkInherited. Defaults to VirtualNetworkInherited.</summary>
    [JsonPropertyName("ddosProtectionMode")]
    public string? DdosProtectionMode { get; set; }

    /// <summary>The ID of DDoS protection plan associated with the public IP.</summary>
    [JsonPropertyName("ddosProtectionPlanId")]
    public string? DdosProtectionPlanId { get; set; }

    /// <summary>Label for the Domain Name. Will be used to make up the FQDN. If a domain name label is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>Scope for the domain name label. If a domain name label scope is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system with a hashed value includes in FQDN. Possible values are NoReuse, ResourceGroupReuse, SubscriptionReuse and TenantReuse. Changing this forces a new Public IP to be created.</summary>
    [JsonPropertyName("domainNameLabelScope")]
    public string? DomainNameLabelScope { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Public IP should exist. Changing this forces a new Public IP to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Specifies the timeout for the TCP idle connection. The value can be set between 4 and 30 minutes.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>A mapping of IP tags to assign to the public IP. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTags")]
    public IDictionary<string, string>? IpTags { get; set; }

    /// <summary>The IP Version to use, IPv6 or IPv4. Changing this forces a new resource to be created. Defaults to IPv4.</summary>
    [JsonPropertyName("ipVersion")]
    public string? IpVersion { get; set; }

    /// <summary>Specifies the supported Azure location where the Public IP should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>If specified then public IP address allocated will be provided from the public IP prefix resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>A fully qualified domain name that resolves to this public IP address. If the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain to the reverse FQDN.</summary>
    [JsonPropertyName("reverseFqdn")]
    public string? ReverseFqdn { get; set; }

    /// <summary>The SKU of the Public IP. Accepted values are Basic and Standard. Defaults to Standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The SKU Tier that should be used for the Public IP. Possible values are Regional and Global. Defaults to Regional. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A collection containing the availability zone to allocate the Public IP in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPSpecProviderConfigRefPolicy
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
public partial class V1beta1PublicIPSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PublicIPSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PublicIPSpec defines the desired state of PublicIP</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PublicIPSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PublicIPSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PublicIPSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PublicIPSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPStatusAtProvider
{
    /// <summary>Defines the allocation method for this IP address. Possible values are Static or Dynamic.</summary>
    [JsonPropertyName("allocationMethod")]
    public string? AllocationMethod { get; set; }

    /// <summary>The DDoS protection mode of the public IP. Possible values are Disabled, Enabled, and VirtualNetworkInherited. Defaults to VirtualNetworkInherited.</summary>
    [JsonPropertyName("ddosProtectionMode")]
    public string? DdosProtectionMode { get; set; }

    /// <summary>The ID of DDoS protection plan associated with the public IP.</summary>
    [JsonPropertyName("ddosProtectionPlanId")]
    public string? DdosProtectionPlanId { get; set; }

    /// <summary>Label for the Domain Name. Will be used to make up the FQDN. If a domain name label is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>Scope for the domain name label. If a domain name label scope is specified, an A DNS record is created for the public IP in the Microsoft Azure DNS system with a hashed value includes in FQDN. Possible values are NoReuse, ResourceGroupReuse, SubscriptionReuse and TenantReuse. Changing this forces a new Public IP to be created.</summary>
    [JsonPropertyName("domainNameLabelScope")]
    public string? DomainNameLabelScope { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Public IP should exist. Changing this forces a new Public IP to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Fully qualified domain name of the A DNS record associated with the public IP. domain_name_label must be specified to get the fqdn. This is the concatenation of the domain_name_label and the regionalized DNS zone</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The ID of this Public IP.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the timeout for the TCP idle connection. The value can be set between 4 and 30 minutes.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>The IP address value that was allocated.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>A mapping of IP tags to assign to the public IP. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTags")]
    public IDictionary<string, string>? IpTags { get; set; }

    /// <summary>The IP Version to use, IPv6 or IPv4. Changing this forces a new resource to be created. Defaults to IPv4.</summary>
    [JsonPropertyName("ipVersion")]
    public string? IpVersion { get; set; }

    /// <summary>Specifies the supported Azure location where the Public IP should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>If specified then public IP address allocated will be provided from the public IP prefix resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>The name of the Resource Group where this Public IP should exist. Changing this forces a new Public IP to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A fully qualified domain name that resolves to this public IP address. If the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain to the reverse FQDN.</summary>
    [JsonPropertyName("reverseFqdn")]
    public string? ReverseFqdn { get; set; }

    /// <summary>The SKU of the Public IP. Accepted values are Basic and Standard. Defaults to Standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The SKU Tier that should be used for the Public IP. Possible values are Regional and Global. Defaults to Regional. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A collection containing the availability zone to allocate the Public IP in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPStatusConditions
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

/// <summary>PublicIPStatus defines the observed state of PublicIP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PublicIPStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PublicIPStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PublicIPStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PublicIP is the Schema for the PublicIPs API. Manages a Public IP Address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PublicIP : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PublicIPSpec>, IStatus<V1beta1PublicIPStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PublicIP";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "publicips";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PublicIPSpec defines the desired state of PublicIP</summary>
    [JsonPropertyName("spec")]
    public V1beta1PublicIPSpec Spec { get; set; }

    /// <summary>PublicIPStatus defines the observed state of PublicIP.</summary>
    [JsonPropertyName("status")]
    public V1beta1PublicIPStatus? Status { get; set; }
}