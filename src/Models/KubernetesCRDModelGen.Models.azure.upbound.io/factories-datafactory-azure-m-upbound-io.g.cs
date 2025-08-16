using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.m.upbound.io;
/// <summary>Factory is the Schema for the Factorys API. Manages an Azure Data Factory (Version 2).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FactoryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Factory>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FactoryList";
    public const string KubeGroup = "datafactory.azure.m.upbound.io";
    public const string KubePluralName = "factories";
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
    public IList<V1beta1Factory> Items { get; set; }
}

/// <summary>A github_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecForProviderGithubConfiguration
{
    /// <summary>Specifies the GitHub account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Specifies the GitHub Enterprise host name. For example: https://github.mydomain.com. Use https://github.com for open source repositories.</summary>
    [JsonPropertyName("gitUrl")]
    public string? GitUrl { get; set; }

    /// <summary>Is automated publishing enabled? Defaults to true.</summary>
    [JsonPropertyName("publishingEnabled")]
    public bool? PublishingEnabled { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecForProviderGlobalParameter
{
    /// <summary>Specifies the global parameter name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the global parameter type. Possible Values are Array, Bool, Float, Int, Object or String.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the global parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Data Factory.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Factory. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1FactorySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FactorySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1FactorySpecForProviderResourceGroupNameSelector
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
    public V1beta1FactorySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A vsts_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecForProviderVstsConfiguration
{
    /// <summary>Specifies the VSTS account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Specifies the name of the VSTS project.</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>Is automated publishing enabled? Defaults to true.</summary>
    [JsonPropertyName("publishingEnabled")]
    public bool? PublishingEnabled { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary>Specifies the Tenant ID associated with the VSTS account.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecForProvider
{
    /// <summary>Specifies the Azure Key Vault Key ID to be used as the Customer Managed Key (CMK) for double encryption. Required with user assigned identity.</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>Specifies the ID of the user assigned identity associated with the Customer Managed Key. Must be supplied if customer_managed_key_id is set.</summary>
    [JsonPropertyName("customerManagedKeyIdentityId")]
    public string? CustomerManagedKeyIdentityId { get; set; }

    /// <summary>A github_configuration block as defined below.</summary>
    [JsonPropertyName("githubConfiguration")]
    public V1beta1FactorySpecForProviderGithubConfiguration? GithubConfiguration { get; set; }

    /// <summary>A list of global_parameter blocks as defined above.</summary>
    [JsonPropertyName("globalParameter")]
    public IList<V1beta1FactorySpecForProviderGlobalParameter>? GlobalParameter { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1FactorySpecForProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Is Managed Virtual Network enabled?</summary>
    [JsonPropertyName("managedVirtualNetworkEnabled")]
    public bool? ManagedVirtualNetworkEnabled { get; set; }

    /// <summary>Is the Data Factory visible to the public network? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkEnabled")]
    public bool? PublicNetworkEnabled { get; set; }

    /// <summary>Specifies the ID of the purview account resource associated with the Data Factory.</summary>
    [JsonPropertyName("purviewId")]
    public string? PurviewId { get; set; }

    /// <summary>The name of the resource group in which to create the Data Factory. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1FactorySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1FactorySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A vsts_configuration block as defined below.</summary>
    [JsonPropertyName("vstsConfiguration")]
    public V1beta1FactorySpecForProviderVstsConfiguration? VstsConfiguration { get; set; }
}

/// <summary>A github_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecInitProviderGithubConfiguration
{
    /// <summary>Specifies the GitHub account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Specifies the GitHub Enterprise host name. For example: https://github.mydomain.com. Use https://github.com for open source repositories.</summary>
    [JsonPropertyName("gitUrl")]
    public string? GitUrl { get; set; }

    /// <summary>Is automated publishing enabled? Defaults to true.</summary>
    [JsonPropertyName("publishingEnabled")]
    public bool? PublishingEnabled { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecInitProviderGlobalParameter
{
    /// <summary>Specifies the global parameter name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the global parameter type. Possible Values are Array, Bool, Float, Int, Object or String.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the global parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Data Factory.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Factory. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A vsts_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecInitProviderVstsConfiguration
{
    /// <summary>Specifies the VSTS account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Specifies the name of the VSTS project.</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>Is automated publishing enabled? Defaults to true.</summary>
    [JsonPropertyName("publishingEnabled")]
    public bool? PublishingEnabled { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary>Specifies the Tenant ID associated with the VSTS account.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecInitProvider
{
    /// <summary>Specifies the Azure Key Vault Key ID to be used as the Customer Managed Key (CMK) for double encryption. Required with user assigned identity.</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>Specifies the ID of the user assigned identity associated with the Customer Managed Key. Must be supplied if customer_managed_key_id is set.</summary>
    [JsonPropertyName("customerManagedKeyIdentityId")]
    public string? CustomerManagedKeyIdentityId { get; set; }

    /// <summary>A github_configuration block as defined below.</summary>
    [JsonPropertyName("githubConfiguration")]
    public V1beta1FactorySpecInitProviderGithubConfiguration? GithubConfiguration { get; set; }

    /// <summary>A list of global_parameter blocks as defined above.</summary>
    [JsonPropertyName("globalParameter")]
    public IList<V1beta1FactorySpecInitProviderGlobalParameter>? GlobalParameter { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1FactorySpecInitProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Is Managed Virtual Network enabled?</summary>
    [JsonPropertyName("managedVirtualNetworkEnabled")]
    public bool? ManagedVirtualNetworkEnabled { get; set; }

    /// <summary>Is the Data Factory visible to the public network? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkEnabled")]
    public bool? PublicNetworkEnabled { get; set; }

    /// <summary>Specifies the ID of the purview account resource associated with the Data Factory.</summary>
    [JsonPropertyName("purviewId")]
    public string? PurviewId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A vsts_configuration block as defined below.</summary>
    [JsonPropertyName("vstsConfiguration")]
    public V1beta1FactorySpecInitProviderVstsConfiguration? VstsConfiguration { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpecProviderConfigRef
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
public partial class V1beta1FactorySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>FactorySpec defines the desired state of Factory</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactorySpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FactorySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FactorySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FactorySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FactorySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A github_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactoryStatusAtProviderGithubConfiguration
{
    /// <summary>Specifies the GitHub account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Specifies the GitHub Enterprise host name. For example: https://github.mydomain.com. Use https://github.com for open source repositories.</summary>
    [JsonPropertyName("gitUrl")]
    public string? GitUrl { get; set; }

    /// <summary>Is automated publishing enabled? Defaults to true.</summary>
    [JsonPropertyName("publishingEnabled")]
    public bool? PublishingEnabled { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactoryStatusAtProviderGlobalParameter
{
    /// <summary>Specifies the global parameter name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the global parameter type. Possible Values are Array, Bool, Float, Int, Object or String.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the global parameter value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactoryStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Data Factory.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Data Factory. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A vsts_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactoryStatusAtProviderVstsConfiguration
{
    /// <summary>Specifies the VSTS account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Specifies the name of the VSTS project.</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>Is automated publishing enabled? Defaults to true.</summary>
    [JsonPropertyName("publishingEnabled")]
    public bool? PublishingEnabled { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary>Specifies the Tenant ID associated with the VSTS account.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactoryStatusAtProvider
{
    /// <summary>Specifies the Azure Key Vault Key ID to be used as the Customer Managed Key (CMK) for double encryption. Required with user assigned identity.</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>Specifies the ID of the user assigned identity associated with the Customer Managed Key. Must be supplied if customer_managed_key_id is set.</summary>
    [JsonPropertyName("customerManagedKeyIdentityId")]
    public string? CustomerManagedKeyIdentityId { get; set; }

    /// <summary>A github_configuration block as defined below.</summary>
    [JsonPropertyName("githubConfiguration")]
    public V1beta1FactoryStatusAtProviderGithubConfiguration? GithubConfiguration { get; set; }

    /// <summary>A list of global_parameter blocks as defined above.</summary>
    [JsonPropertyName("globalParameter")]
    public IList<V1beta1FactoryStatusAtProviderGlobalParameter>? GlobalParameter { get; set; }

    /// <summary>The ID of the Data Factory.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1FactoryStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Is Managed Virtual Network enabled?</summary>
    [JsonPropertyName("managedVirtualNetworkEnabled")]
    public bool? ManagedVirtualNetworkEnabled { get; set; }

    /// <summary>Is the Data Factory visible to the public network? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkEnabled")]
    public bool? PublicNetworkEnabled { get; set; }

    /// <summary>Specifies the ID of the purview account resource associated with the Data Factory.</summary>
    [JsonPropertyName("purviewId")]
    public string? PurviewId { get; set; }

    /// <summary>The name of the resource group in which to create the Data Factory. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A vsts_configuration block as defined below.</summary>
    [JsonPropertyName("vstsConfiguration")]
    public V1beta1FactoryStatusAtProviderVstsConfiguration? VstsConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactoryStatusConditions
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

/// <summary>FactoryStatus defines the observed state of Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FactoryStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FactoryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FactoryStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Factory is the Schema for the Factorys API. Manages an Azure Data Factory (Version 2).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Factory : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FactorySpec>, IStatus<V1beta1FactoryStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Factory";
    public const string KubeGroup = "datafactory.azure.m.upbound.io";
    public const string KubePluralName = "factories";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FactorySpec defines the desired state of Factory</summary>
    [JsonPropertyName("spec")]
    public V1beta1FactorySpec Spec { get; set; }

    /// <summary>FactoryStatus defines the observed state of Factory.</summary>
    [JsonPropertyName("status")]
    public V1beta1FactoryStatus? Status { get; set; }
}