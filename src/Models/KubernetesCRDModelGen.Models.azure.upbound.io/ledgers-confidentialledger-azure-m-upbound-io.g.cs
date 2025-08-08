using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.confidentialledger.azure.m.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerSpecForProviderAzureadBasedServicePrincipal
{
    /// <summary>Specifies the Ledger Role to grant this AzureAD Service Principal. Possible values are Administrator, Contributor and Reader.</summary>
    [JsonPropertyName("ledgerRoleName")]
    public string? LedgerRoleName { get; set; }

    /// <summary>Specifies the Principal ID of the AzureAD Service Principal.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Specifies the Tenant ID for this AzureAD Service Principal.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerSpecForProviderCertificateBasedSecurityPrincipal
{
    /// <summary>Specifies the Ledger Role to grant this Certificate Security Principal. Possible values are Administrator, Contributor and Reader.</summary>
    [JsonPropertyName("ledgerRoleName")]
    public string? LedgerRoleName { get; set; }

    /// <summary>The public key, in PEM format, of the certificate used by this identity to authenticate with the Confidential Ledger.</summary>
    [JsonPropertyName("pemPublicKey")]
    public string? PemPublicKey { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1LedgerSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LedgerSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1LedgerSpecForProviderResourceGroupNameSelector
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
    public V1beta1LedgerSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerSpecForProvider
{
    /// <summary>A list of azuread_based_service_principal blocks as defined below.</summary>
    [JsonPropertyName("azureadBasedServicePrincipal")]
    public IList<V1beta1LedgerSpecForProviderAzureadBasedServicePrincipal>? AzureadBasedServicePrincipal { get; set; }

    /// <summary>A list of certificate_based_security_principal blocks as defined below.</summary>
    [JsonPropertyName("certificateBasedSecurityPrincipal")]
    public IList<V1beta1LedgerSpecForProviderCertificateBasedSecurityPrincipal>? CertificateBasedSecurityPrincipal { get; set; }

    /// <summary>Specifies the type of Confidential Ledger. Possible values are Private and Public. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ledgerType")]
    public string? LedgerType { get; set; }

    /// <summary>Specifies the supported Azure location where the Confidential Ledger exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Resource Group where the Confidential Ledger exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1LedgerSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1LedgerSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Confidential Ledger.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerSpecInitProviderAzureadBasedServicePrincipal
{
    /// <summary>Specifies the Ledger Role to grant this AzureAD Service Principal. Possible values are Administrator, Contributor and Reader.</summary>
    [JsonPropertyName("ledgerRoleName")]
    public string? LedgerRoleName { get; set; }

    /// <summary>Specifies the Principal ID of the AzureAD Service Principal.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Specifies the Tenant ID for this AzureAD Service Principal.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerSpecInitProviderCertificateBasedSecurityPrincipal
{
    /// <summary>Specifies the Ledger Role to grant this Certificate Security Principal. Possible values are Administrator, Contributor and Reader.</summary>
    [JsonPropertyName("ledgerRoleName")]
    public string? LedgerRoleName { get; set; }

    /// <summary>The public key, in PEM format, of the certificate used by this identity to authenticate with the Confidential Ledger.</summary>
    [JsonPropertyName("pemPublicKey")]
    public string? PemPublicKey { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerSpecInitProvider
{
    /// <summary>A list of azuread_based_service_principal blocks as defined below.</summary>
    [JsonPropertyName("azureadBasedServicePrincipal")]
    public IList<V1beta1LedgerSpecInitProviderAzureadBasedServicePrincipal>? AzureadBasedServicePrincipal { get; set; }

    /// <summary>A list of certificate_based_security_principal blocks as defined below.</summary>
    [JsonPropertyName("certificateBasedSecurityPrincipal")]
    public IList<V1beta1LedgerSpecInitProviderCertificateBasedSecurityPrincipal>? CertificateBasedSecurityPrincipal { get; set; }

    /// <summary>Specifies the type of Confidential Ledger. Possible values are Private and Public. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ledgerType")]
    public string? LedgerType { get; set; }

    /// <summary>Specifies the supported Azure location where the Confidential Ledger exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A mapping of tags to assign to the Confidential Ledger.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerSpecProviderConfigRef
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
public partial class V1beta1LedgerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>LedgerSpec defines the desired state of Ledger</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LedgerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LedgerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LedgerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LedgerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerStatusAtProviderAzureadBasedServicePrincipal
{
    /// <summary>Specifies the Ledger Role to grant this AzureAD Service Principal. Possible values are Administrator, Contributor and Reader.</summary>
    [JsonPropertyName("ledgerRoleName")]
    public string? LedgerRoleName { get; set; }

    /// <summary>Specifies the Principal ID of the AzureAD Service Principal.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>Specifies the Tenant ID for this AzureAD Service Principal.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerStatusAtProviderCertificateBasedSecurityPrincipal
{
    /// <summary>Specifies the Ledger Role to grant this Certificate Security Principal. Possible values are Administrator, Contributor and Reader.</summary>
    [JsonPropertyName("ledgerRoleName")]
    public string? LedgerRoleName { get; set; }

    /// <summary>The public key, in PEM format, of the certificate used by this identity to authenticate with the Confidential Ledger.</summary>
    [JsonPropertyName("pemPublicKey")]
    public string? PemPublicKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerStatusAtProvider
{
    /// <summary>A list of azuread_based_service_principal blocks as defined below.</summary>
    [JsonPropertyName("azureadBasedServicePrincipal")]
    public IList<V1beta1LedgerStatusAtProviderAzureadBasedServicePrincipal>? AzureadBasedServicePrincipal { get; set; }

    /// <summary>A list of certificate_based_security_principal blocks as defined below.</summary>
    [JsonPropertyName("certificateBasedSecurityPrincipal")]
    public IList<V1beta1LedgerStatusAtProviderCertificateBasedSecurityPrincipal>? CertificateBasedSecurityPrincipal { get; set; }

    /// <summary>The ID of this Confidential Ledger.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Identity Service Endpoint for this Confidential Ledger.</summary>
    [JsonPropertyName("identityServiceEndpoint")]
    public string? IdentityServiceEndpoint { get; set; }

    /// <summary>The Endpoint for this Confidential Ledger.</summary>
    [JsonPropertyName("ledgerEndpoint")]
    public string? LedgerEndpoint { get; set; }

    /// <summary>Specifies the type of Confidential Ledger. Possible values are Private and Public. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ledgerType")]
    public string? LedgerType { get; set; }

    /// <summary>Specifies the supported Azure location where the Confidential Ledger exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Resource Group where the Confidential Ledger exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the Confidential Ledger.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerStatusConditions
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

/// <summary>LedgerStatus defines the observed state of Ledger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LedgerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LedgerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LedgerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Ledger is the Schema for the Ledgers API. Manages a Confidential Ledger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Ledger : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LedgerSpec>, IStatus<V1beta1LedgerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Ledger";
    public const string KubeGroup = "confidentialledger.azure.m.upbound.io";
    public const string KubePluralName = "ledgers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LedgerSpec defines the desired state of Ledger</summary>
    [JsonPropertyName("spec")]
    public V1beta1LedgerSpec Spec { get; set; }

    /// <summary>LedgerStatus defines the observed state of Ledger.</summary>
    [JsonPropertyName("status")]
    public V1beta1LedgerStatus? Status { get; set; }
}

/// <summary>Ledger is the Schema for the Ledgers API. Manages a Confidential Ledger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LedgerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Ledger>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LedgerList";
    public const string KubeGroup = "confidentialledger.azure.m.upbound.io";
    public const string KubePluralName = "ledgers";
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
    public IList<V1beta1Ledger> Items { get; set; }
}