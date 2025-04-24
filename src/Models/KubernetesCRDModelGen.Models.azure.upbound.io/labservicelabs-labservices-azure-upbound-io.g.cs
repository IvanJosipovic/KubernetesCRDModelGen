using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.labservices.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderAutoShutdown
{
    /// <summary>The amount of time a VM will stay running after a user disconnects if this behavior is enabled. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("disconnectDelay")]
    public string? DisconnectDelay { get; set; }

    /// <summary>The amount of time a VM will idle before it is shutdown if this behavior is enabled. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("idleDelay")]
    public string? IdleDelay { get; set; }

    /// <summary>The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("noConnectDelay")]
    public string? NoConnectDelay { get; set; }

    /// <summary>A VM will get shutdown when it has idled for a period of time. Possible values are LowUsage and UserAbsence.</summary>
    [JsonPropertyName("shutdownOnIdle")]
    public string? ShutdownOnIdle { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderConnectionSetting
{
    /// <summary>The enabled access level for Client Access over RDP. Possible value is Public.</summary>
    [JsonPropertyName("clientRdpAccess")]
    public string? ClientRdpAccess { get; set; }

    /// <summary>The enabled access level for Client Access over SSH. Possible value is Public.</summary>
    [JsonPropertyName("clientSshAccess")]
    public string? ClientSshAccess { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LabServiceLabSpecForProviderNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LabServiceLabSpecForProviderNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderNetwork
{
    /// <summary>The resource ID of the Subnet for the network profile of the Lab Service Lab.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1LabServiceLabSpecForProviderNetworkSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1LabServiceLabSpecForProviderNetworkSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1LabServiceLabSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LabServiceLabSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1LabServiceLabSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LabServiceLabSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderRoster
{
    /// <summary>The AAD group ID which this Lab Service Lab roster is populated from.</summary>
    [JsonPropertyName("activeDirectoryGroupId")]
    public string? ActiveDirectoryGroupId { get; set; }

    /// <summary>The base URI identifying the lms instance.</summary>
    [JsonPropertyName("lmsInstance")]
    public string? LmsInstance { get; set; }

    /// <summary>The unique id of the Azure Lab Service tool in the lms.</summary>
    [JsonPropertyName("ltiClientId")]
    public string? LtiClientId { get; set; }

    /// <summary>The unique context identifier for the Lab Service Lab in the lms.</summary>
    [JsonPropertyName("ltiContextId")]
    public string? LtiContextId { get; set; }

    /// <summary>The URI of the names and roles service endpoint on the lms for the class attached to this Lab Service Lab.</summary>
    [JsonPropertyName("ltiRosterEndpoint")]
    public string? LtiRosterEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderSecurity
{
    /// <summary>Is open access enabled to allow any user or only specified users to register to a Lab Service Lab?</summary>
    [JsonPropertyName("openAccessEnabled")]
    public bool? OpenAccessEnabled { get; set; }
}

/// <summary>The password for the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderVirtualMachineAdminUserPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderVirtualMachineAdminUser
{
    /// <summary>The password for the user.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1LabServiceLabSpecForProviderVirtualMachineAdminUserPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username to use when signing in to Lab Service Lab VMs.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderVirtualMachineImageReference
{
    /// <summary>The resource ID of the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The image offer if applicable. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>The image publisher. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The image version specified on creation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The password for the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderVirtualMachineNonAdminUserPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderVirtualMachineNonAdminUser
{
    /// <summary>The password for the user.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1LabServiceLabSpecForProviderVirtualMachineNonAdminUserPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>The username to use when signing in to Lab Service Lab VMs.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderVirtualMachineSku
{
    /// <summary>The capacity for the SKU. Possible values are between 0 and 400.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the SKU. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProviderVirtualMachine
{
    /// <summary>Is flagged to pre-install dedicated GPU drivers? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalCapabilityGpuDriversInstalled")]
    public bool? AdditionalCapabilityGpuDriversInstalled { get; set; }

    /// <summary>An admin_user block as defined below.</summary>
    [JsonPropertyName("adminUser")]
    public IList<V1beta1LabServiceLabSpecForProviderVirtualMachineAdminUser>? AdminUser { get; set; }

    /// <summary>The create option to indicate what Lab Service Lab VMs are created from. Possible values are Image and TemplateVM. Defaults to Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>An image_reference block as defined below.</summary>
    [JsonPropertyName("imageReference")]
    public IList<V1beta1LabServiceLabSpecForProviderVirtualMachineImageReference>? ImageReference { get; set; }

    /// <summary>A non_admin_user block as defined below.</summary>
    [JsonPropertyName("nonAdminUser")]
    public IList<V1beta1LabServiceLabSpecForProviderVirtualMachineNonAdminUser>? NonAdminUser { get; set; }

    /// <summary>Is the shared password enabled with the same password for all user VMs? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sharedPasswordEnabled")]
    public bool? SharedPasswordEnabled { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1LabServiceLabSpecForProviderVirtualMachineSku>? Sku { get; set; }

    /// <summary>The initial quota allocated to each Lab Service Lab user. Defaults to PT0S. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("usageQuota")]
    public string? UsageQuota { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecForProvider
{
    /// <summary>An auto_shutdown block as defined below.</summary>
    [JsonPropertyName("autoShutdown")]
    public IList<V1beta1LabServiceLabSpecForProviderAutoShutdown>? AutoShutdown { get; set; }

    /// <summary>A connection_setting block as defined below.</summary>
    [JsonPropertyName("connectionSetting")]
    public IList<V1beta1LabServiceLabSpecForProviderConnectionSetting>? ConnectionSetting { get; set; }

    /// <summary>The description of the Lab Service Lab.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The resource ID of the Lab Plan that is used during resource creation to provide defaults and acts as a permission container when creating a Lab Service Lab via labs.azure.com.</summary>
    [JsonPropertyName("labPlanId")]
    public string? LabPlanId { get; set; }

    /// <summary>The Azure Region where the Lab Service Lab should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1LabServiceLabSpecForProviderNetwork>? Network { get; set; }

    /// <summary>The name of the Resource Group where the Lab Service Lab should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1LabServiceLabSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1LabServiceLabSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A roster block as defined below.</summary>
    [JsonPropertyName("roster")]
    public IList<V1beta1LabServiceLabSpecForProviderRoster>? Roster { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public IList<V1beta1LabServiceLabSpecForProviderSecurity>? Security { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Lab Service Lab.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The title of the Lab Service Lab.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A virtual_machine block as defined below.</summary>
    [JsonPropertyName("virtualMachine")]
    public IList<V1beta1LabServiceLabSpecForProviderVirtualMachine>? VirtualMachine { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderAutoShutdown
{
    /// <summary>The amount of time a VM will stay running after a user disconnects if this behavior is enabled. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("disconnectDelay")]
    public string? DisconnectDelay { get; set; }

    /// <summary>The amount of time a VM will idle before it is shutdown if this behavior is enabled. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("idleDelay")]
    public string? IdleDelay { get; set; }

    /// <summary>The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("noConnectDelay")]
    public string? NoConnectDelay { get; set; }

    /// <summary>A VM will get shutdown when it has idled for a period of time. Possible values are LowUsage and UserAbsence.</summary>
    [JsonPropertyName("shutdownOnIdle")]
    public string? ShutdownOnIdle { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderConnectionSetting
{
    /// <summary>The enabled access level for Client Access over RDP. Possible value is Public.</summary>
    [JsonPropertyName("clientRdpAccess")]
    public string? ClientRdpAccess { get; set; }

    /// <summary>The enabled access level for Client Access over SSH. Possible value is Public.</summary>
    [JsonPropertyName("clientSshAccess")]
    public string? ClientSshAccess { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderNetworkSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LabServiceLabSpecInitProviderNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderNetworkSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderNetworkSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LabServiceLabSpecInitProviderNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderNetwork
{
    /// <summary>The resource ID of the Subnet for the network profile of the Lab Service Lab.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1LabServiceLabSpecInitProviderNetworkSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1LabServiceLabSpecInitProviderNetworkSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderRoster
{
    /// <summary>The AAD group ID which this Lab Service Lab roster is populated from.</summary>
    [JsonPropertyName("activeDirectoryGroupId")]
    public string? ActiveDirectoryGroupId { get; set; }

    /// <summary>The base URI identifying the lms instance.</summary>
    [JsonPropertyName("lmsInstance")]
    public string? LmsInstance { get; set; }

    /// <summary>The unique id of the Azure Lab Service tool in the lms.</summary>
    [JsonPropertyName("ltiClientId")]
    public string? LtiClientId { get; set; }

    /// <summary>The unique context identifier for the Lab Service Lab in the lms.</summary>
    [JsonPropertyName("ltiContextId")]
    public string? LtiContextId { get; set; }

    /// <summary>The URI of the names and roles service endpoint on the lms for the class attached to this Lab Service Lab.</summary>
    [JsonPropertyName("ltiRosterEndpoint")]
    public string? LtiRosterEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderSecurity
{
    /// <summary>Is open access enabled to allow any user or only specified users to register to a Lab Service Lab?</summary>
    [JsonPropertyName("openAccessEnabled")]
    public bool? OpenAccessEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderVirtualMachineAdminUser
{
    /// <summary>The username to use when signing in to Lab Service Lab VMs.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderVirtualMachineImageReference
{
    /// <summary>The resource ID of the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The image offer if applicable. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>The image publisher. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The image version specified on creation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderVirtualMachineNonAdminUser
{
    /// <summary>The username to use when signing in to Lab Service Lab VMs.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderVirtualMachineSku
{
    /// <summary>The capacity for the SKU. Possible values are between 0 and 400.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the SKU. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProviderVirtualMachine
{
    /// <summary>Is flagged to pre-install dedicated GPU drivers? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalCapabilityGpuDriversInstalled")]
    public bool? AdditionalCapabilityGpuDriversInstalled { get; set; }

    /// <summary>An admin_user block as defined below.</summary>
    [JsonPropertyName("adminUser")]
    public IList<V1beta1LabServiceLabSpecInitProviderVirtualMachineAdminUser>? AdminUser { get; set; }

    /// <summary>The create option to indicate what Lab Service Lab VMs are created from. Possible values are Image and TemplateVM. Defaults to Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>An image_reference block as defined below.</summary>
    [JsonPropertyName("imageReference")]
    public IList<V1beta1LabServiceLabSpecInitProviderVirtualMachineImageReference>? ImageReference { get; set; }

    /// <summary>A non_admin_user block as defined below.</summary>
    [JsonPropertyName("nonAdminUser")]
    public IList<V1beta1LabServiceLabSpecInitProviderVirtualMachineNonAdminUser>? NonAdminUser { get; set; }

    /// <summary>Is the shared password enabled with the same password for all user VMs? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sharedPasswordEnabled")]
    public bool? SharedPasswordEnabled { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1LabServiceLabSpecInitProviderVirtualMachineSku>? Sku { get; set; }

    /// <summary>The initial quota allocated to each Lab Service Lab user. Defaults to PT0S. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("usageQuota")]
    public string? UsageQuota { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecInitProvider
{
    /// <summary>An auto_shutdown block as defined below.</summary>
    [JsonPropertyName("autoShutdown")]
    public IList<V1beta1LabServiceLabSpecInitProviderAutoShutdown>? AutoShutdown { get; set; }

    /// <summary>A connection_setting block as defined below.</summary>
    [JsonPropertyName("connectionSetting")]
    public IList<V1beta1LabServiceLabSpecInitProviderConnectionSetting>? ConnectionSetting { get; set; }

    /// <summary>The description of the Lab Service Lab.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The resource ID of the Lab Plan that is used during resource creation to provide defaults and acts as a permission container when creating a Lab Service Lab via labs.azure.com.</summary>
    [JsonPropertyName("labPlanId")]
    public string? LabPlanId { get; set; }

    /// <summary>The Azure Region where the Lab Service Lab should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1LabServiceLabSpecInitProviderNetwork>? Network { get; set; }

    /// <summary>A roster block as defined below.</summary>
    [JsonPropertyName("roster")]
    public IList<V1beta1LabServiceLabSpecInitProviderRoster>? Roster { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public IList<V1beta1LabServiceLabSpecInitProviderSecurity>? Security { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Lab Service Lab.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The title of the Lab Service Lab.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A virtual_machine block as defined below.</summary>
    [JsonPropertyName("virtualMachine")]
    public IList<V1beta1LabServiceLabSpecInitProviderVirtualMachine>? VirtualMachine { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecProviderConfigRefPolicy
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
public partial class V1beta1LabServiceLabSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LabServiceLabSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LabServiceLabSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LabServiceLabSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LabServiceLabSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LabServiceLabSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LabServiceLabSpec defines the desired state of LabServiceLab</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LabServiceLabSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LabServiceLabSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LabServiceLabSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LabServiceLabSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LabServiceLabSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusAtProviderAutoShutdown
{
    /// <summary>The amount of time a VM will stay running after a user disconnects if this behavior is enabled. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("disconnectDelay")]
    public string? DisconnectDelay { get; set; }

    /// <summary>The amount of time a VM will idle before it is shutdown if this behavior is enabled. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("idleDelay")]
    public string? IdleDelay { get; set; }

    /// <summary>The amount of time a VM will stay running before it is shutdown if no connection is made and this behavior is enabled. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("noConnectDelay")]
    public string? NoConnectDelay { get; set; }

    /// <summary>A VM will get shutdown when it has idled for a period of time. Possible values are LowUsage and UserAbsence.</summary>
    [JsonPropertyName("shutdownOnIdle")]
    public string? ShutdownOnIdle { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusAtProviderConnectionSetting
{
    /// <summary>The enabled access level for Client Access over RDP. Possible value is Public.</summary>
    [JsonPropertyName("clientRdpAccess")]
    public string? ClientRdpAccess { get; set; }

    /// <summary>The enabled access level for Client Access over SSH. Possible value is Public.</summary>
    [JsonPropertyName("clientSshAccess")]
    public string? ClientSshAccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusAtProviderNetwork
{
    /// <summary>The resource ID of the Load Balancer for the network profile of the Lab Service Lab.</summary>
    [JsonPropertyName("loadBalancerId")]
    public string? LoadBalancerId { get; set; }

    /// <summary>The resource ID of the Public IP for the network profile of the Lab Service Lab.</summary>
    [JsonPropertyName("publicIpId")]
    public string? PublicIpId { get; set; }

    /// <summary>The resource ID of the Subnet for the network profile of the Lab Service Lab.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusAtProviderRoster
{
    /// <summary>The AAD group ID which this Lab Service Lab roster is populated from.</summary>
    [JsonPropertyName("activeDirectoryGroupId")]
    public string? ActiveDirectoryGroupId { get; set; }

    /// <summary>The base URI identifying the lms instance.</summary>
    [JsonPropertyName("lmsInstance")]
    public string? LmsInstance { get; set; }

    /// <summary>The unique id of the Azure Lab Service tool in the lms.</summary>
    [JsonPropertyName("ltiClientId")]
    public string? LtiClientId { get; set; }

    /// <summary>The unique context identifier for the Lab Service Lab in the lms.</summary>
    [JsonPropertyName("ltiContextId")]
    public string? LtiContextId { get; set; }

    /// <summary>The URI of the names and roles service endpoint on the lms for the class attached to this Lab Service Lab.</summary>
    [JsonPropertyName("ltiRosterEndpoint")]
    public string? LtiRosterEndpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusAtProviderSecurity
{
    /// <summary>Is open access enabled to allow any user or only specified users to register to a Lab Service Lab?</summary>
    [JsonPropertyName("openAccessEnabled")]
    public bool? OpenAccessEnabled { get; set; }

    /// <summary>The registration code for the Lab Service Lab.</summary>
    [JsonPropertyName("registrationCode")]
    public string? RegistrationCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusAtProviderVirtualMachineAdminUser
{
    /// <summary>The username to use when signing in to Lab Service Lab VMs.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusAtProviderVirtualMachineImageReference
{
    /// <summary>The resource ID of the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The image offer if applicable. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>The image publisher. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The image version specified on creation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusAtProviderVirtualMachineNonAdminUser
{
    /// <summary>The username to use when signing in to Lab Service Lab VMs.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusAtProviderVirtualMachineSku
{
    /// <summary>The capacity for the SKU. Possible values are between 0 and 400.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the SKU. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusAtProviderVirtualMachine
{
    /// <summary>Is flagged to pre-install dedicated GPU drivers? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalCapabilityGpuDriversInstalled")]
    public bool? AdditionalCapabilityGpuDriversInstalled { get; set; }

    /// <summary>An admin_user block as defined below.</summary>
    [JsonPropertyName("adminUser")]
    public IList<V1beta1LabServiceLabStatusAtProviderVirtualMachineAdminUser>? AdminUser { get; set; }

    /// <summary>The create option to indicate what Lab Service Lab VMs are created from. Possible values are Image and TemplateVM. Defaults to Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>An image_reference block as defined below.</summary>
    [JsonPropertyName("imageReference")]
    public IList<V1beta1LabServiceLabStatusAtProviderVirtualMachineImageReference>? ImageReference { get; set; }

    /// <summary>A non_admin_user block as defined below.</summary>
    [JsonPropertyName("nonAdminUser")]
    public IList<V1beta1LabServiceLabStatusAtProviderVirtualMachineNonAdminUser>? NonAdminUser { get; set; }

    /// <summary>Is the shared password enabled with the same password for all user VMs? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sharedPasswordEnabled")]
    public bool? SharedPasswordEnabled { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1LabServiceLabStatusAtProviderVirtualMachineSku>? Sku { get; set; }

    /// <summary>The initial quota allocated to each Lab Service Lab user. Defaults to PT0S. This value must be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("usageQuota")]
    public string? UsageQuota { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusAtProvider
{
    /// <summary>An auto_shutdown block as defined below.</summary>
    [JsonPropertyName("autoShutdown")]
    public IList<V1beta1LabServiceLabStatusAtProviderAutoShutdown>? AutoShutdown { get; set; }

    /// <summary>A connection_setting block as defined below.</summary>
    [JsonPropertyName("connectionSetting")]
    public IList<V1beta1LabServiceLabStatusAtProviderConnectionSetting>? ConnectionSetting { get; set; }

    /// <summary>The description of the Lab Service Lab.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the Lab Service Lab.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The resource ID of the Lab Plan that is used during resource creation to provide defaults and acts as a permission container when creating a Lab Service Lab via labs.azure.com.</summary>
    [JsonPropertyName("labPlanId")]
    public string? LabPlanId { get; set; }

    /// <summary>The Azure Region where the Lab Service Lab should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A network block as defined below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1LabServiceLabStatusAtProviderNetwork>? Network { get; set; }

    /// <summary>The name of the Resource Group where the Lab Service Lab should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A roster block as defined below.</summary>
    [JsonPropertyName("roster")]
    public IList<V1beta1LabServiceLabStatusAtProviderRoster>? Roster { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public IList<V1beta1LabServiceLabStatusAtProviderSecurity>? Security { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Lab Service Lab.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The title of the Lab Service Lab.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A virtual_machine block as defined below.</summary>
    [JsonPropertyName("virtualMachine")]
    public IList<V1beta1LabServiceLabStatusAtProviderVirtualMachine>? VirtualMachine { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatusConditions
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

/// <summary>LabServiceLabStatus defines the observed state of LabServiceLab.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LabServiceLabStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LabServiceLabStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LabServiceLabStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LabServiceLab is the Schema for the LabServiceLabs API. Manages a Lab Service Lab.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LabServiceLab : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LabServiceLabSpec>, IStatus<V1beta1LabServiceLabStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LabServiceLab";
    public const string KubeGroup = "labservices.azure.upbound.io";
    public const string KubePluralName = "labservicelabs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LabServiceLabSpec defines the desired state of LabServiceLab</summary>
    [JsonPropertyName("spec")]
    public V1beta1LabServiceLabSpec Spec { get; set; }

    /// <summary>LabServiceLabStatus defines the observed state of LabServiceLab.</summary>
    [JsonPropertyName("status")]
    public V1beta1LabServiceLabStatus? Status { get; set; }
}

/// <summary>LabServiceLab is the Schema for the LabServiceLabs API. Manages a Lab Service Lab.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LabServiceLabList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LabServiceLab>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LabServiceLabList";
    public const string KubeGroup = "labservices.azure.upbound.io";
    public const string KubePluralName = "labservicelabs";
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
    public IList<V1beta1LabServiceLab> Items { get; set; }
}