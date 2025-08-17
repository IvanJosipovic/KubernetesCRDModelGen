using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.m.upbound.io;
#nullable enable
/// <summary>MSSQLManagedInstanceActiveDirectoryAdministrator is the Schema for the MSSQLManagedInstanceActiveDirectoryAdministrators API. Manages an Active Directory Administrator on a Microsoft Azure SQL Managed Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MSSQLManagedInstanceActiveDirectoryAdministrator>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLManagedInstanceActiveDirectoryAdministratorList";
    public const string KubeGroup = "sql.azure.m.upbound.io";
    public const string KubePluralName = "mssqlmanagedinstanceactivedirectoryadministrators";
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
    public IList<V1beta1MSSQLManagedInstanceActiveDirectoryAdministrator> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecForProviderManagedInstanceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecForProviderManagedInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecForProviderManagedInstanceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecForProviderManagedInstanceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecForProviderManagedInstanceIdSelector
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
    public V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecForProviderManagedInstanceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecForProvider
{
    /// <summary>When true, only permit logins from AAD users and administrators. When false, also allow local database users.</summary>
    [JsonPropertyName("azureadAuthenticationOnly")]
    public bool? AzureadAuthenticationOnly { get; set; }

    /// <summary>The login name of the principal to set as the Managed Instance Administrator.</summary>
    [JsonPropertyName("loginUsername")]
    public string? LoginUsername { get; set; }

    /// <summary>The ID of the Azure SQL Managed Instance for which to set the administrator. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedInstanceId")]
    public string? ManagedInstanceId { get; set; }

    /// <summary>Reference to a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
    [JsonPropertyName("managedInstanceIdRef")]
    public V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecForProviderManagedInstanceIdRef? ManagedInstanceIdRef { get; set; }

    /// <summary>Selector for a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
    [JsonPropertyName("managedInstanceIdSelector")]
    public V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecForProviderManagedInstanceIdSelector? ManagedInstanceIdSelector { get; set; }

    /// <summary>The Object ID of the principal to set as the Managed Instance Administrator.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecInitProvider
{
    /// <summary>When true, only permit logins from AAD users and administrators. When false, also allow local database users.</summary>
    [JsonPropertyName("azureadAuthenticationOnly")]
    public bool? AzureadAuthenticationOnly { get; set; }

    /// <summary>The login name of the principal to set as the Managed Instance Administrator.</summary>
    [JsonPropertyName("loginUsername")]
    public string? LoginUsername { get; set; }

    /// <summary>The Object ID of the principal to set as the Managed Instance Administrator.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MSSQLManagedInstanceActiveDirectoryAdministratorSpec defines the desired state of MSSQLManagedInstanceActiveDirectoryAdministrator</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorStatusAtProvider
{
    /// <summary>When true, only permit logins from AAD users and administrators. When false, also allow local database users.</summary>
    [JsonPropertyName("azureadAuthenticationOnly")]
    public bool? AzureadAuthenticationOnly { get; set; }

    /// <summary>The ID of the SQL Managed Instance Active Directory Administrator.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The login name of the principal to set as the Managed Instance Administrator.</summary>
    [JsonPropertyName("loginUsername")]
    public string? LoginUsername { get; set; }

    /// <summary>The ID of the Azure SQL Managed Instance for which to set the administrator. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedInstanceId")]
    public string? ManagedInstanceId { get; set; }

    /// <summary>The Object ID of the principal to set as the Managed Instance Administrator.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The Azure Active Directory Tenant ID.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorStatusConditions
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
#nullable disable

#nullable enable
/// <summary>MSSQLManagedInstanceActiveDirectoryAdministratorStatus defines the observed state of MSSQLManagedInstanceActiveDirectoryAdministrator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MSSQLManagedInstanceActiveDirectoryAdministrator is the Schema for the MSSQLManagedInstanceActiveDirectoryAdministrators API. Manages an Active Directory Administrator on a Microsoft Azure SQL Managed Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLManagedInstanceActiveDirectoryAdministrator : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpec>, IStatus<V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLManagedInstanceActiveDirectoryAdministrator";
    public const string KubeGroup = "sql.azure.m.upbound.io";
    public const string KubePluralName = "mssqlmanagedinstanceactivedirectoryadministrators";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MSSQLManagedInstanceActiveDirectoryAdministratorSpec defines the desired state of MSSQLManagedInstanceActiveDirectoryAdministrator</summary>
    [JsonPropertyName("spec")]
    public V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorSpec Spec { get; set; }

    /// <summary>MSSQLManagedInstanceActiveDirectoryAdministratorStatus defines the observed state of MSSQLManagedInstanceActiveDirectoryAdministrator.</summary>
    [JsonPropertyName("status")]
    public V1beta1MSSQLManagedInstanceActiveDirectoryAdministratorStatus? Status { get; set; }
}
#nullable disable
