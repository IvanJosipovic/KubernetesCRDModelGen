using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.databricks.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate privateSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate privateSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate publicSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate publicSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderCustomParameters
{
    /// <summary>The ID of a Azure Machine Learning workspace to link with Databricks workspace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("machineLearningWorkspaceId")]
    public string? MachineLearningWorkspaceId { get; set; }

    /// <summary>Name of the NAT gateway for Secure Cluster Connectivity (No Public IP) workspace subnets. Defaults to nat-gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayName")]
    public string? NatGatewayName { get; set; }

    /// <summary>Are public IP Addresses not allowed? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("noPublicIp")]
    public bool? NoPublicIp { get; set; }

    /// <summary>The name of the Private Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateSubnetName")]
    public string? PrivateSubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate privateSubnetName.</summary>
    [JsonPropertyName("privateSubnetNameRef")]
    public V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameRef? PrivateSubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate privateSubnetName.</summary>
    [JsonPropertyName("privateSubnetNameSelector")]
    public V1beta1WorkspaceSpecForProviderCustomParametersPrivateSubnetNameSelector? PrivateSubnetNameSelector { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the private_subnet_name field. This is the same as the ID of the subnet referred to by the private_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("privateSubnetNetworkSecurityGroupAssociationId")]
    public string? PrivateSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Name of the Public IP for No Public IP workspace with managed vNet. Defaults to nat-gw-public-ip. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpName")]
    public string? PublicIpName { get; set; }

    /// <summary>The name of the Public Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicSubnetName")]
    public string? PublicSubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate publicSubnetName.</summary>
    [JsonPropertyName("publicSubnetNameRef")]
    public V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameRef? PublicSubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate publicSubnetName.</summary>
    [JsonPropertyName("publicSubnetNameSelector")]
    public V1beta1WorkspaceSpecForProviderCustomParametersPublicSubnetNameSelector? PublicSubnetNameSelector { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the public_subnet_name field. This is the same as the ID of the subnet referred to by the public_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("publicSubnetNetworkSecurityGroupAssociationId")]
    public string? PublicSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Default Databricks File Storage account name. Defaults to a randomized name(e.g. dbstoragel6mfeghoe5kxu). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Storage account SKU name. Possible values include Standard_LRS, Standard_GRS, Standard_RAGRS, Standard_GZRS, Standard_RAGZRS, Standard_ZRS, Premium_LRS or Premium_ZRS. Defaults to Standard_GRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountSkuName")]
    public string? StorageAccountSkuName { get; set; }

    /// <summary>The ID of a Virtual Network where this Databricks Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>Address prefix for Managed virtual network. Defaults to 10.139. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vnetAddressPrefix")]
    public string? VnetAddressPrefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProvider
{
    /// <summary>A custom_parameters block as documented below.</summary>
    [JsonPropertyName("customParameters")]
    public IList<V1beta1WorkspaceSpecForProviderCustomParameters>? CustomParameters { get; set; }

    /// <summary>Is the workspace enabled for customer managed key encryption? If true this enables the Managed Identity for the managed storage account. Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium.</summary>
    [JsonPropertyName("customerManagedKeyEnabled")]
    public bool? CustomerManagedKeyEnabled { get; set; }

    /// <summary>Is the Databricks File System root file system enabled with a secondary layer of encryption with platform managed keys? Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Resource ID of the Outbound Load balancer Backend Address Pool for Secure Cluster Connectivity (No Public IP) workspace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolId")]
    public string? LoadBalancerBackendAddressPoolId { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed disks.</summary>
    [JsonPropertyName("managedDiskCmkKeyVaultKeyId")]
    public string? ManagedDiskCmkKeyVaultKeyId { get; set; }

    /// <summary>Whether customer managed keys for disk encryption will automatically be rotated to the latest version.</summary>
    [JsonPropertyName("managedDiskCmkRotationToLatestVersionEnabled")]
    public bool? ManagedDiskCmkRotationToLatestVersionEnabled { get; set; }

    /// <summary>The name of the resource group where Azure should place the managed Databricks resources. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameRef")]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRef? ManagedResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameSelector")]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelector? ManagedResourceGroupNameSelector { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed resources(e.g. Notebooks and Artifacts).</summary>
    [JsonPropertyName("managedServicesCmkKeyVaultKeyId")]
    public string? ManagedServicesCmkKeyVaultKeyId { get; set; }

    /// <summary>Does the data plane (clusters) to control plane communication happen over private link endpoint only or publicly? Possible values AllRules, NoAzureDatabricksRules or NoAzureServiceRules. Required when public_network_access_enabled is set to false.</summary>
    [JsonPropertyName("networkSecurityGroupRulesRequired")]
    public string? NetworkSecurityGroupRulesRequired { get; set; }

    /// <summary>Allow public access for accessing workspace. Set value to false to access workspace only via private link endpoint. Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group in which the Databricks Workspace should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The sku to use for the Databricks Workspace. Possible values are standard, premium, or trial.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate privateSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate privateSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate publicSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate publicSubnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderCustomParameters
{
    /// <summary>The ID of a Azure Machine Learning workspace to link with Databricks workspace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("machineLearningWorkspaceId")]
    public string? MachineLearningWorkspaceId { get; set; }

    /// <summary>Name of the NAT gateway for Secure Cluster Connectivity (No Public IP) workspace subnets. Defaults to nat-gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayName")]
    public string? NatGatewayName { get; set; }

    /// <summary>Are public IP Addresses not allowed? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("noPublicIp")]
    public bool? NoPublicIp { get; set; }

    /// <summary>The name of the Private Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateSubnetName")]
    public string? PrivateSubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate privateSubnetName.</summary>
    [JsonPropertyName("privateSubnetNameRef")]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameRef? PrivateSubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate privateSubnetName.</summary>
    [JsonPropertyName("privateSubnetNameSelector")]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPrivateSubnetNameSelector? PrivateSubnetNameSelector { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the private_subnet_name field. This is the same as the ID of the subnet referred to by the private_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("privateSubnetNetworkSecurityGroupAssociationId")]
    public string? PrivateSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Name of the Public IP for No Public IP workspace with managed vNet. Defaults to nat-gw-public-ip. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpName")]
    public string? PublicIpName { get; set; }

    /// <summary>The name of the Public Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicSubnetName")]
    public string? PublicSubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate publicSubnetName.</summary>
    [JsonPropertyName("publicSubnetNameRef")]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameRef? PublicSubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate publicSubnetName.</summary>
    [JsonPropertyName("publicSubnetNameSelector")]
    public V1beta1WorkspaceSpecInitProviderCustomParametersPublicSubnetNameSelector? PublicSubnetNameSelector { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the public_subnet_name field. This is the same as the ID of the subnet referred to by the public_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("publicSubnetNetworkSecurityGroupAssociationId")]
    public string? PublicSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Default Databricks File Storage account name. Defaults to a randomized name(e.g. dbstoragel6mfeghoe5kxu). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Storage account SKU name. Possible values include Standard_LRS, Standard_GRS, Standard_RAGRS, Standard_GZRS, Standard_RAGZRS, Standard_ZRS, Premium_LRS or Premium_ZRS. Defaults to Standard_GRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountSkuName")]
    public string? StorageAccountSkuName { get; set; }

    /// <summary>The ID of a Virtual Network where this Databricks Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>Address prefix for Managed virtual network. Defaults to 10.139. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vnetAddressPrefix")]
    public string? VnetAddressPrefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProvider
{
    /// <summary>A custom_parameters block as documented below.</summary>
    [JsonPropertyName("customParameters")]
    public IList<V1beta1WorkspaceSpecInitProviderCustomParameters>? CustomParameters { get; set; }

    /// <summary>Is the workspace enabled for customer managed key encryption? If true this enables the Managed Identity for the managed storage account. Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium.</summary>
    [JsonPropertyName("customerManagedKeyEnabled")]
    public bool? CustomerManagedKeyEnabled { get; set; }

    /// <summary>Is the Databricks File System root file system enabled with a secondary layer of encryption with platform managed keys? Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Resource ID of the Outbound Load balancer Backend Address Pool for Secure Cluster Connectivity (No Public IP) workspace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolId")]
    public string? LoadBalancerBackendAddressPoolId { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed disks.</summary>
    [JsonPropertyName("managedDiskCmkKeyVaultKeyId")]
    public string? ManagedDiskCmkKeyVaultKeyId { get; set; }

    /// <summary>Whether customer managed keys for disk encryption will automatically be rotated to the latest version.</summary>
    [JsonPropertyName("managedDiskCmkRotationToLatestVersionEnabled")]
    public bool? ManagedDiskCmkRotationToLatestVersionEnabled { get; set; }

    /// <summary>The name of the resource group where Azure should place the managed Databricks resources. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameRef")]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRef? ManagedResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameSelector")]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelector? ManagedResourceGroupNameSelector { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed resources(e.g. Notebooks and Artifacts).</summary>
    [JsonPropertyName("managedServicesCmkKeyVaultKeyId")]
    public string? ManagedServicesCmkKeyVaultKeyId { get; set; }

    /// <summary>Does the data plane (clusters) to control plane communication happen over private link endpoint only or publicly? Possible values AllRules, NoAzureDatabricksRules or NoAzureServiceRules. Required when public_network_access_enabled is set to false.</summary>
    [JsonPropertyName("networkSecurityGroupRulesRequired")]
    public string? NetworkSecurityGroupRulesRequired { get; set; }

    /// <summary>Allow public access for accessing workspace. Set value to false to access workspace only via private link endpoint. Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The sku to use for the Databricks Workspace. Possible values are standard, premium, or trial.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecManagementPoliciesEnum
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
public enum V1beta1WorkspaceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1WorkspaceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>WorkspaceSpec defines the desired state of Workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecDeletionPolicyEnum>))]
    public V1beta1WorkspaceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WorkspaceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WorkspaceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WorkspaceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkspaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkspaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatusAtProviderCustomParameters
{
    /// <summary>The ID of a Azure Machine Learning workspace to link with Databricks workspace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("machineLearningWorkspaceId")]
    public string? MachineLearningWorkspaceId { get; set; }

    /// <summary>Name of the NAT gateway for Secure Cluster Connectivity (No Public IP) workspace subnets. Defaults to nat-gateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayName")]
    public string? NatGatewayName { get; set; }

    /// <summary>Are public IP Addresses not allowed? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("noPublicIp")]
    public bool? NoPublicIp { get; set; }

    /// <summary>The name of the Private Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateSubnetName")]
    public string? PrivateSubnetName { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the private_subnet_name field. This is the same as the ID of the subnet referred to by the private_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("privateSubnetNetworkSecurityGroupAssociationId")]
    public string? PrivateSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Name of the Public IP for No Public IP workspace with managed vNet. Defaults to nat-gw-public-ip. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpName")]
    public string? PublicIpName { get; set; }

    /// <summary>The name of the Public Subnet within the Virtual Network. Required if virtual_network_id is set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicSubnetName")]
    public string? PublicSubnetName { get; set; }

    /// <summary>The resource ID of the azurerm_subnet_network_security_group_association resource which is referred to by the public_subnet_name field. This is the same as the ID of the subnet referred to by the public_subnet_name field. Required if virtual_network_id is set.</summary>
    [JsonPropertyName("publicSubnetNetworkSecurityGroupAssociationId")]
    public string? PublicSubnetNetworkSecurityGroupAssociationId { get; set; }

    /// <summary>Default Databricks File Storage account name. Defaults to a randomized name(e.g. dbstoragel6mfeghoe5kxu). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Storage account SKU name. Possible values include Standard_LRS, Standard_GRS, Standard_RAGRS, Standard_GZRS, Standard_RAGZRS, Standard_ZRS, Premium_LRS or Premium_ZRS. Defaults to Standard_GRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountSkuName")]
    public string? StorageAccountSkuName { get; set; }

    /// <summary>The ID of a Virtual Network where this Databricks Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }

    /// <summary>Address prefix for Managed virtual network. Defaults to 10.139. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vnetAddressPrefix")]
    public string? VnetAddressPrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatusAtProviderManagedDiskIdentity
{
    /// <summary>The principal UUID for the internal databricks disks identity needed to provide access to the workspace for enabling Customer Managed Keys.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The UUID of the tenant where the internal databricks disks identity was created.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of the internal databricks disks identity.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatusAtProviderStorageAccountIdentity
{
    /// <summary>The principal UUID for the internal databricks storage account needed to provide access to the workspace for enabling Customer Managed Keys.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The UUID of the tenant where the internal databricks storage account was created.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of the internal databricks storage account.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatusAtProvider
{
    /// <summary>A custom_parameters block as documented below.</summary>
    [JsonPropertyName("customParameters")]
    public IList<V1beta1WorkspaceStatusAtProviderCustomParameters>? CustomParameters { get; set; }

    /// <summary>Is the workspace enabled for customer managed key encryption? If true this enables the Managed Identity for the managed storage account. Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium.</summary>
    [JsonPropertyName("customerManagedKeyEnabled")]
    public bool? CustomerManagedKeyEnabled { get; set; }

    /// <summary>The ID of Managed Disk Encryption Set created by the Databricks Workspace.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The ID of the Databricks Workspace in the Azure management plane.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Is the Databricks File System root file system enabled with a secondary layer of encryption with platform managed keys? Possible values are true or false. Defaults to false. This field is only valid if the Databricks Workspace sku is set to premium. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("infrastructureEncryptionEnabled")]
    public bool? InfrastructureEncryptionEnabled { get; set; }

    /// <summary>Resource ID of the Outbound Load balancer Backend Address Pool for Secure Cluster Connectivity (No Public IP) workspace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolId")]
    public string? LoadBalancerBackendAddressPoolId { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed disks.</summary>
    [JsonPropertyName("managedDiskCmkKeyVaultKeyId")]
    public string? ManagedDiskCmkKeyVaultKeyId { get; set; }

    /// <summary>Whether customer managed keys for disk encryption will automatically be rotated to the latest version.</summary>
    [JsonPropertyName("managedDiskCmkRotationToLatestVersionEnabled")]
    public bool? ManagedDiskCmkRotationToLatestVersionEnabled { get; set; }

    /// <summary>A managed_disk_identity block as documented below.</summary>
    [JsonPropertyName("managedDiskIdentity")]
    public IList<V1beta1WorkspaceStatusAtProviderManagedDiskIdentity>? ManagedDiskIdentity { get; set; }

    /// <summary>The ID of the Managed Resource Group created by the Databricks Workspace.</summary>
    [JsonPropertyName("managedResourceGroupId")]
    public string? ManagedResourceGroupId { get; set; }

    /// <summary>The name of the resource group where Azure should place the managed Databricks resources. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary>Customer managed encryption properties for the Databricks Workspace managed resources(e.g. Notebooks and Artifacts).</summary>
    [JsonPropertyName("managedServicesCmkKeyVaultKeyId")]
    public string? ManagedServicesCmkKeyVaultKeyId { get; set; }

    /// <summary>Does the data plane (clusters) to control plane communication happen over private link endpoint only or publicly? Possible values AllRules, NoAzureDatabricksRules or NoAzureServiceRules. Required when public_network_access_enabled is set to false.</summary>
    [JsonPropertyName("networkSecurityGroupRulesRequired")]
    public string? NetworkSecurityGroupRulesRequired { get; set; }

    /// <summary>Allow public access for accessing workspace. Set value to false to access workspace only via private link endpoint. Possible values include true or false. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group in which the Databricks Workspace should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The sku to use for the Databricks Workspace. Possible values are standard, premium, or trial.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>A storage_account_identity block as documented below.</summary>
    [JsonPropertyName("storageAccountIdentity")]
    public IList<V1beta1WorkspaceStatusAtProviderStorageAccountIdentity>? StorageAccountIdentity { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The unique identifier of the databricks workspace in Databricks control plane.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    /// <summary>The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatusConditions
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

/// <summary>WorkspaceStatus defines the observed state of Workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WorkspaceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Workspace is the Schema for the Workspaces API. Manages a Databricks Workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Workspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkspaceSpec>, IStatus<V1beta1WorkspaceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "databricks.azure.upbound.io";
    public const string KubePluralName = "workspaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkspaceSpec defines the desired state of Workspace</summary>
    [JsonPropertyName("spec")]
    public V1beta1WorkspaceSpec Spec { get; set; }

    /// <summary>WorkspaceStatus defines the observed state of Workspace.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkspaceStatus? Status { get; set; }
}