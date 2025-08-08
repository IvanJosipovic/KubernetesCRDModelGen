using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.grafana.aws.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpecForProviderWorkspaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in grafana to populate workspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpecForProviderWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSAMLConfigurationSpecForProviderWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpecForProviderWorkspaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in grafana to populate workspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpecForProviderWorkspaceIdSelector
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
    public V1beta1WorkspaceSAMLConfigurationSpecForProviderWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpecForProvider
{
    /// <summary>The admin role values.</summary>
    [JsonPropertyName("adminRoleValues")]
    public IList<string>? AdminRoleValues { get; set; }

    /// <summary>The allowed organizations.</summary>
    [JsonPropertyName("allowedOrganizations")]
    public IList<string>? AllowedOrganizations { get; set; }

    /// <summary>The editor role values.</summary>
    [JsonPropertyName("editorRoleValues")]
    public IList<string>? EditorRoleValues { get; set; }

    /// <summary>The email assertion.</summary>
    [JsonPropertyName("emailAssertion")]
    public string? EmailAssertion { get; set; }

    /// <summary>The groups assertion.</summary>
    [JsonPropertyName("groupsAssertion")]
    public string? GroupsAssertion { get; set; }

    /// <summary>The IDP Metadata URL. Note that either idp_metadata_url or idp_metadata_xml (but not both) must be specified.</summary>
    [JsonPropertyName("idpMetadataUrl")]
    public string? IdpMetadataUrl { get; set; }

    /// <summary>The IDP Metadata XML. Note that either idp_metadata_url or idp_metadata_xml (but not both) must be specified.</summary>
    [JsonPropertyName("idpMetadataXml")]
    public string? IdpMetadataXml { get; set; }

    /// <summary>The login assertion.</summary>
    [JsonPropertyName("loginAssertion")]
    public string? LoginAssertion { get; set; }

    /// <summary>The login validity duration.</summary>
    [JsonPropertyName("loginValidityDuration")]
    public double? LoginValidityDuration { get; set; }

    /// <summary>The name assertion.</summary>
    [JsonPropertyName("nameAssertion")]
    public string? NameAssertion { get; set; }

    /// <summary>The org assertion.</summary>
    [JsonPropertyName("orgAssertion")]
    public string? OrgAssertion { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The role assertion.</summary>
    [JsonPropertyName("roleAssertion")]
    public string? RoleAssertion { get; set; }

    /// <summary>The workspace id.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in grafana to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdRef")]
    public V1beta1WorkspaceSAMLConfigurationSpecForProviderWorkspaceIdRef? WorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in grafana to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdSelector")]
    public V1beta1WorkspaceSAMLConfigurationSpecForProviderWorkspaceIdSelector? WorkspaceIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpecInitProviderWorkspaceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in grafana to populate workspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpecInitProviderWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSAMLConfigurationSpecInitProviderWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpecInitProviderWorkspaceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in grafana to populate workspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpecInitProviderWorkspaceIdSelector
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
    public V1beta1WorkspaceSAMLConfigurationSpecInitProviderWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpecInitProvider
{
    /// <summary>The admin role values.</summary>
    [JsonPropertyName("adminRoleValues")]
    public IList<string>? AdminRoleValues { get; set; }

    /// <summary>The allowed organizations.</summary>
    [JsonPropertyName("allowedOrganizations")]
    public IList<string>? AllowedOrganizations { get; set; }

    /// <summary>The editor role values.</summary>
    [JsonPropertyName("editorRoleValues")]
    public IList<string>? EditorRoleValues { get; set; }

    /// <summary>The email assertion.</summary>
    [JsonPropertyName("emailAssertion")]
    public string? EmailAssertion { get; set; }

    /// <summary>The groups assertion.</summary>
    [JsonPropertyName("groupsAssertion")]
    public string? GroupsAssertion { get; set; }

    /// <summary>The IDP Metadata URL. Note that either idp_metadata_url or idp_metadata_xml (but not both) must be specified.</summary>
    [JsonPropertyName("idpMetadataUrl")]
    public string? IdpMetadataUrl { get; set; }

    /// <summary>The IDP Metadata XML. Note that either idp_metadata_url or idp_metadata_xml (but not both) must be specified.</summary>
    [JsonPropertyName("idpMetadataXml")]
    public string? IdpMetadataXml { get; set; }

    /// <summary>The login assertion.</summary>
    [JsonPropertyName("loginAssertion")]
    public string? LoginAssertion { get; set; }

    /// <summary>The login validity duration.</summary>
    [JsonPropertyName("loginValidityDuration")]
    public double? LoginValidityDuration { get; set; }

    /// <summary>The name assertion.</summary>
    [JsonPropertyName("nameAssertion")]
    public string? NameAssertion { get; set; }

    /// <summary>The org assertion.</summary>
    [JsonPropertyName("orgAssertion")]
    public string? OrgAssertion { get; set; }

    /// <summary>The role assertion.</summary>
    [JsonPropertyName("roleAssertion")]
    public string? RoleAssertion { get; set; }

    /// <summary>The workspace id.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in grafana to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdRef")]
    public V1beta1WorkspaceSAMLConfigurationSpecInitProviderWorkspaceIdRef? WorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in grafana to populate workspaceId.</summary>
    [JsonPropertyName("workspaceIdSelector")]
    public V1beta1WorkspaceSAMLConfigurationSpecInitProviderWorkspaceIdSelector? WorkspaceIdSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpecProviderConfigRef
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
public partial class V1beta1WorkspaceSAMLConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WorkspaceSAMLConfigurationSpec defines the desired state of WorkspaceSAMLConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WorkspaceSAMLConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WorkspaceSAMLConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkspaceSAMLConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkspaceSAMLConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationStatusAtProvider
{
    /// <summary>The admin role values.</summary>
    [JsonPropertyName("adminRoleValues")]
    public IList<string>? AdminRoleValues { get; set; }

    /// <summary>The allowed organizations.</summary>
    [JsonPropertyName("allowedOrganizations")]
    public IList<string>? AllowedOrganizations { get; set; }

    /// <summary>The editor role values.</summary>
    [JsonPropertyName("editorRoleValues")]
    public IList<string>? EditorRoleValues { get; set; }

    /// <summary>The email assertion.</summary>
    [JsonPropertyName("emailAssertion")]
    public string? EmailAssertion { get; set; }

    /// <summary>The groups assertion.</summary>
    [JsonPropertyName("groupsAssertion")]
    public string? GroupsAssertion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IDP Metadata URL. Note that either idp_metadata_url or idp_metadata_xml (but not both) must be specified.</summary>
    [JsonPropertyName("idpMetadataUrl")]
    public string? IdpMetadataUrl { get; set; }

    /// <summary>The IDP Metadata XML. Note that either idp_metadata_url or idp_metadata_xml (but not both) must be specified.</summary>
    [JsonPropertyName("idpMetadataXml")]
    public string? IdpMetadataXml { get; set; }

    /// <summary>The login assertion.</summary>
    [JsonPropertyName("loginAssertion")]
    public string? LoginAssertion { get; set; }

    /// <summary>The login validity duration.</summary>
    [JsonPropertyName("loginValidityDuration")]
    public double? LoginValidityDuration { get; set; }

    /// <summary>The name assertion.</summary>
    [JsonPropertyName("nameAssertion")]
    public string? NameAssertion { get; set; }

    /// <summary>The org assertion.</summary>
    [JsonPropertyName("orgAssertion")]
    public string? OrgAssertion { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The role assertion.</summary>
    [JsonPropertyName("roleAssertion")]
    public string? RoleAssertion { get; set; }

    /// <summary>The status of the SAML configuration.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The workspace id.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationStatusConditions
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

/// <summary>WorkspaceSAMLConfigurationStatus defines the observed state of WorkspaceSAMLConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSAMLConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WorkspaceSAMLConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkspaceSAMLConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WorkspaceSAMLConfiguration is the Schema for the WorkspaceSAMLConfigurations API. Provides an Amazon Managed Grafana workspace SAML configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkspaceSAMLConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkspaceSAMLConfigurationSpec>, IStatus<V1beta1WorkspaceSAMLConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkspaceSAMLConfiguration";
    public const string KubeGroup = "grafana.aws.m.upbound.io";
    public const string KubePluralName = "workspacesamlconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkspaceSAMLConfigurationSpec defines the desired state of WorkspaceSAMLConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1WorkspaceSAMLConfigurationSpec Spec { get; set; }

    /// <summary>WorkspaceSAMLConfigurationStatus defines the observed state of WorkspaceSAMLConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkspaceSAMLConfigurationStatus? Status { get; set; }
}

/// <summary>WorkspaceSAMLConfiguration is the Schema for the WorkspaceSAMLConfigurations API. Provides an Amazon Managed Grafana workspace SAML configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkspaceSAMLConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WorkspaceSAMLConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkspaceSAMLConfigurationList";
    public const string KubeGroup = "grafana.aws.m.upbound.io";
    public const string KubePluralName = "workspacesamlconfigurations";
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
    public IList<V1beta1WorkspaceSAMLConfiguration> Items { get; set; }
}