using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.m.upbound.io;
/// <summary>MSSQLManagedInstanceFailoverGroup is the Schema for the MSSQLManagedInstanceFailoverGroups API. Manages an Azure SQL Managed Instance Failover Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MSSQLManagedInstanceFailoverGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLManagedInstanceFailoverGroupList";
    public const string KubeGroup = "sql.azure.m.upbound.io";
    public const string KubePluralName = "mssqlmanagedinstancefailovergroups";
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
    public IList<V1beta1MSSQLManagedInstanceFailoverGroup> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderManagedInstanceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderManagedInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderManagedInstanceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderManagedInstanceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderManagedInstanceIdSelector
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
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderManagedInstanceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderPartnerManagedInstanceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MSSQLManagedInstance in sql to populate partnerManagedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderPartnerManagedInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderPartnerManagedInstanceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderPartnerManagedInstanceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MSSQLManagedInstance in sql to populate partnerManagedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderPartnerManagedInstanceIdSelector
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
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderPartnerManagedInstanceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A read_write_endpoint_failover_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderReadWriteEndpointFailoverPolicy
{
    /// <summary>Applies only if mode is Automatic. The grace period in minutes before failover with data loss is attempted.</summary>
    [JsonPropertyName("graceMinutes")]
    public double? GraceMinutes { get; set; }

    /// <summary>The failover mode. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecForProvider
{
    /// <summary>The Azure Region where the Managed Instance Failover Group should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The ID of the Azure SQL Managed Instance which will be replicated using a Managed Instance Failover Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedInstanceId")]
    public string? ManagedInstanceId { get; set; }

    /// <summary>Reference to a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
    [JsonPropertyName("managedInstanceIdRef")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderManagedInstanceIdRef? ManagedInstanceIdRef { get; set; }

    /// <summary>Selector for a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
    [JsonPropertyName("managedInstanceIdSelector")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderManagedInstanceIdSelector? ManagedInstanceIdSelector { get; set; }

    /// <summary>The ID of the Azure SQL Managed Instance which will be replicated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partnerManagedInstanceId")]
    public string? PartnerManagedInstanceId { get; set; }

    /// <summary>Reference to a MSSQLManagedInstance in sql to populate partnerManagedInstanceId.</summary>
    [JsonPropertyName("partnerManagedInstanceIdRef")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderPartnerManagedInstanceIdRef? PartnerManagedInstanceIdRef { get; set; }

    /// <summary>Selector for a MSSQLManagedInstance in sql to populate partnerManagedInstanceId.</summary>
    [JsonPropertyName("partnerManagedInstanceIdSelector")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderPartnerManagedInstanceIdSelector? PartnerManagedInstanceIdSelector { get; set; }

    /// <summary>A read_write_endpoint_failover_policy block as defined below.</summary>
    [JsonPropertyName("readWriteEndpointFailoverPolicy")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecForProviderReadWriteEndpointFailoverPolicy? ReadWriteEndpointFailoverPolicy { get; set; }

    /// <summary>Failover policy for the read-only endpoint. Defaults to true.</summary>
    [JsonPropertyName("readonlyEndpointFailoverPolicyEnabled")]
    public bool? ReadonlyEndpointFailoverPolicyEnabled { get; set; }

    /// <summary>The type of the secondary Managed Instance. Possible values are Geo, Standby. Defaults to Geo.</summary>
    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderManagedInstanceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderManagedInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderManagedInstanceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderManagedInstanceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderManagedInstanceIdSelector
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
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderManagedInstanceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderPartnerManagedInstanceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MSSQLManagedInstance in sql to populate partnerManagedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderPartnerManagedInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderPartnerManagedInstanceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderPartnerManagedInstanceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MSSQLManagedInstance in sql to populate partnerManagedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderPartnerManagedInstanceIdSelector
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
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderPartnerManagedInstanceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A read_write_endpoint_failover_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderReadWriteEndpointFailoverPolicy
{
    /// <summary>Applies only if mode is Automatic. The grace period in minutes before failover with data loss is attempted.</summary>
    [JsonPropertyName("graceMinutes")]
    public double? GraceMinutes { get; set; }

    /// <summary>The failover mode. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProvider
{
    /// <summary>The ID of the Azure SQL Managed Instance which will be replicated using a Managed Instance Failover Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedInstanceId")]
    public string? ManagedInstanceId { get; set; }

    /// <summary>Reference to a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
    [JsonPropertyName("managedInstanceIdRef")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderManagedInstanceIdRef? ManagedInstanceIdRef { get; set; }

    /// <summary>Selector for a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
    [JsonPropertyName("managedInstanceIdSelector")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderManagedInstanceIdSelector? ManagedInstanceIdSelector { get; set; }

    /// <summary>The ID of the Azure SQL Managed Instance which will be replicated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partnerManagedInstanceId")]
    public string? PartnerManagedInstanceId { get; set; }

    /// <summary>Reference to a MSSQLManagedInstance in sql to populate partnerManagedInstanceId.</summary>
    [JsonPropertyName("partnerManagedInstanceIdRef")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderPartnerManagedInstanceIdRef? PartnerManagedInstanceIdRef { get; set; }

    /// <summary>Selector for a MSSQLManagedInstance in sql to populate partnerManagedInstanceId.</summary>
    [JsonPropertyName("partnerManagedInstanceIdSelector")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderPartnerManagedInstanceIdSelector? PartnerManagedInstanceIdSelector { get; set; }

    /// <summary>A read_write_endpoint_failover_policy block as defined below.</summary>
    [JsonPropertyName("readWriteEndpointFailoverPolicy")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProviderReadWriteEndpointFailoverPolicy? ReadWriteEndpointFailoverPolicy { get; set; }

    /// <summary>Failover policy for the read-only endpoint. Defaults to true.</summary>
    [JsonPropertyName("readonlyEndpointFailoverPolicyEnabled")]
    public bool? ReadonlyEndpointFailoverPolicyEnabled { get; set; }

    /// <summary>The type of the secondary Managed Instance. Possible values are Geo, Standby. Defaults to Geo.</summary>
    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecProviderConfigRef
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
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>MSSQLManagedInstanceFailoverGroupSpec defines the desired state of MSSQLManagedInstanceFailoverGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupStatusAtProviderPartnerRegion
{
    /// <summary>The Azure Region where the Managed Instance Failover Group partner exists.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The partner replication role of the Managed Instance Failover Group.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>A read_write_endpoint_failover_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupStatusAtProviderReadWriteEndpointFailoverPolicy
{
    /// <summary>Applies only if mode is Automatic. The grace period in minutes before failover with data loss is attempted.</summary>
    [JsonPropertyName("graceMinutes")]
    public double? GraceMinutes { get; set; }

    /// <summary>The failover mode. Possible values are Automatic or Manual.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupStatusAtProvider
{
    /// <summary>The ID of the Managed Instance Failover Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Azure Region where the Managed Instance Failover Group should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the Azure SQL Managed Instance which will be replicated using a Managed Instance Failover Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedInstanceId")]
    public string? ManagedInstanceId { get; set; }

    /// <summary>The ID of the Azure SQL Managed Instance which will be replicated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partnerManagedInstanceId")]
    public string? PartnerManagedInstanceId { get; set; }

    /// <summary>A partner_region block as defined below.</summary>
    [JsonPropertyName("partnerRegion")]
    public IList<V1beta1MSSQLManagedInstanceFailoverGroupStatusAtProviderPartnerRegion>? PartnerRegion { get; set; }

    /// <summary>A read_write_endpoint_failover_policy block as defined below.</summary>
    [JsonPropertyName("readWriteEndpointFailoverPolicy")]
    public V1beta1MSSQLManagedInstanceFailoverGroupStatusAtProviderReadWriteEndpointFailoverPolicy? ReadWriteEndpointFailoverPolicy { get; set; }

    /// <summary>Failover policy for the read-only endpoint. Defaults to true.</summary>
    [JsonPropertyName("readonlyEndpointFailoverPolicyEnabled")]
    public bool? ReadonlyEndpointFailoverPolicyEnabled { get; set; }

    /// <summary>The local replication role of the Managed Instance Failover Group.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>The type of the secondary Managed Instance. Possible values are Geo, Standby. Defaults to Geo.</summary>
    [JsonPropertyName("secondaryType")]
    public string? SecondaryType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupStatusConditions
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

/// <summary>MSSQLManagedInstanceFailoverGroupStatus defines the observed state of MSSQLManagedInstanceFailoverGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceFailoverGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MSSQLManagedInstanceFailoverGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MSSQLManagedInstanceFailoverGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MSSQLManagedInstanceFailoverGroup is the Schema for the MSSQLManagedInstanceFailoverGroups API. Manages an Azure SQL Managed Instance Failover Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLManagedInstanceFailoverGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MSSQLManagedInstanceFailoverGroupSpec>, IStatus<V1beta1MSSQLManagedInstanceFailoverGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLManagedInstanceFailoverGroup";
    public const string KubeGroup = "sql.azure.m.upbound.io";
    public const string KubePluralName = "mssqlmanagedinstancefailovergroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MSSQLManagedInstanceFailoverGroupSpec defines the desired state of MSSQLManagedInstanceFailoverGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1MSSQLManagedInstanceFailoverGroupSpec Spec { get; set; }

    /// <summary>MSSQLManagedInstanceFailoverGroupStatus defines the observed state of MSSQLManagedInstanceFailoverGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1MSSQLManagedInstanceFailoverGroupStatus? Status { get; set; }
}