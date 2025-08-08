using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.recoveryservices.azure.m.upbound.io;
/// <summary>a automatic_update block defined as below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderAutomaticUpdate
{
    /// <summary>The authentication type used for automation account. Possible values are RunAsAccount and SystemAssignedIdentity. Defaults to SystemAssignedIdentity.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The automation account ID which holds the automatic update runbook and authenticates to Azure resources.</summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary>Should the Mobility service installed on Azure virtual machines be automatically updated. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryFabricNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SiteRecoveryFabric in recoveryservices to populate recoveryFabricName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryFabricNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryFabricNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryFabricNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SiteRecoveryFabric in recoveryservices to populate recoveryFabricName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryFabricNameSelector
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
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryFabricNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryReplicationPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SiteRecoveryReplicationPolicy in recoveryservices to populate recoveryReplicationPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryReplicationPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryReplicationPolicyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryReplicationPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SiteRecoveryReplicationPolicy in recoveryservices to populate recoveryReplicationPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryReplicationPolicyIdSelector
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
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryReplicationPolicyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoverySourceProtectionContainerNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SiteRecoveryProtectionContainer in recoveryservices to populate recoverySourceProtectionContainerName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoverySourceProtectionContainerNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoverySourceProtectionContainerNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoverySourceProtectionContainerNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SiteRecoveryProtectionContainer in recoveryservices to populate recoverySourceProtectionContainerName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoverySourceProtectionContainerNameSelector
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
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoverySourceProtectionContainerNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryTargetProtectionContainerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SiteRecoveryProtectionContainer in recoveryservices to populate recoveryTargetProtectionContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryTargetProtectionContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryTargetProtectionContainerIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryTargetProtectionContainerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SiteRecoveryProtectionContainer in recoveryservices to populate recoveryTargetProtectionContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryTargetProtectionContainerIdSelector
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
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryTargetProtectionContainerIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryVaultNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Vault in recoveryservices to populate recoveryVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryVaultNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryVaultNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Vault in recoveryservices to populate recoveryVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryVaultNameSelector
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
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryVaultNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderResourceGroupNameSelector
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
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecForProvider
{
    /// <summary>a automatic_update block defined as below.</summary>
    [JsonPropertyName("automaticUpdate")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderAutomaticUpdate? AutomaticUpdate { get; set; }

    /// <summary>Name of fabric that should contains the protection container to map. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryFabricName")]
    public string? RecoveryFabricName { get; set; }

    /// <summary>Reference to a SiteRecoveryFabric in recoveryservices to populate recoveryFabricName.</summary>
    [JsonPropertyName("recoveryFabricNameRef")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryFabricNameRef? RecoveryFabricNameRef { get; set; }

    /// <summary>Selector for a SiteRecoveryFabric in recoveryservices to populate recoveryFabricName.</summary>
    [JsonPropertyName("recoveryFabricNameSelector")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryFabricNameSelector? RecoveryFabricNameSelector { get; set; }

    /// <summary>Id of the policy to use for this mapping. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryReplicationPolicyId")]
    public string? RecoveryReplicationPolicyId { get; set; }

    /// <summary>Reference to a SiteRecoveryReplicationPolicy in recoveryservices to populate recoveryReplicationPolicyId.</summary>
    [JsonPropertyName("recoveryReplicationPolicyIdRef")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryReplicationPolicyIdRef? RecoveryReplicationPolicyIdRef { get; set; }

    /// <summary>Selector for a SiteRecoveryReplicationPolicy in recoveryservices to populate recoveryReplicationPolicyId.</summary>
    [JsonPropertyName("recoveryReplicationPolicyIdSelector")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryReplicationPolicyIdSelector? RecoveryReplicationPolicyIdSelector { get; set; }

    /// <summary>Name of the source protection container to map. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoverySourceProtectionContainerName")]
    public string? RecoverySourceProtectionContainerName { get; set; }

    /// <summary>Reference to a SiteRecoveryProtectionContainer in recoveryservices to populate recoverySourceProtectionContainerName.</summary>
    [JsonPropertyName("recoverySourceProtectionContainerNameRef")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoverySourceProtectionContainerNameRef? RecoverySourceProtectionContainerNameRef { get; set; }

    /// <summary>Selector for a SiteRecoveryProtectionContainer in recoveryservices to populate recoverySourceProtectionContainerName.</summary>
    [JsonPropertyName("recoverySourceProtectionContainerNameSelector")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoverySourceProtectionContainerNameSelector? RecoverySourceProtectionContainerNameSelector { get; set; }

    /// <summary>Id of target protection container to map to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryTargetProtectionContainerId")]
    public string? RecoveryTargetProtectionContainerId { get; set; }

    /// <summary>Reference to a SiteRecoveryProtectionContainer in recoveryservices to populate recoveryTargetProtectionContainerId.</summary>
    [JsonPropertyName("recoveryTargetProtectionContainerIdRef")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryTargetProtectionContainerIdRef? RecoveryTargetProtectionContainerIdRef { get; set; }

    /// <summary>Selector for a SiteRecoveryProtectionContainer in recoveryservices to populate recoveryTargetProtectionContainerId.</summary>
    [JsonPropertyName("recoveryTargetProtectionContainerIdSelector")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryTargetProtectionContainerIdSelector? RecoveryTargetProtectionContainerIdSelector { get; set; }

    /// <summary>The name of the vault that should be updated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryVaultName")]
    public string? RecoveryVaultName { get; set; }

    /// <summary>Reference to a Vault in recoveryservices to populate recoveryVaultName.</summary>
    [JsonPropertyName("recoveryVaultNameRef")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryVaultNameRef? RecoveryVaultNameRef { get; set; }

    /// <summary>Selector for a Vault in recoveryservices to populate recoveryVaultName.</summary>
    [JsonPropertyName("recoveryVaultNameSelector")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderRecoveryVaultNameSelector? RecoveryVaultNameSelector { get; set; }

    /// <summary>Name of the resource group where the vault that should be updated is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }
}

/// <summary>a automatic_update block defined as below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderAutomaticUpdate
{
    /// <summary>The authentication type used for automation account. Possible values are RunAsAccount and SystemAssignedIdentity. Defaults to SystemAssignedIdentity.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The automation account ID which holds the automatic update runbook and authenticates to Azure resources.</summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary>Should the Mobility service installed on Azure virtual machines be automatically updated. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryReplicationPolicyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SiteRecoveryReplicationPolicy in recoveryservices to populate recoveryReplicationPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryReplicationPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryReplicationPolicyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryReplicationPolicyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SiteRecoveryReplicationPolicy in recoveryservices to populate recoveryReplicationPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryReplicationPolicyIdSelector
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
    public V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryReplicationPolicyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryTargetProtectionContainerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SiteRecoveryProtectionContainer in recoveryservices to populate recoveryTargetProtectionContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryTargetProtectionContainerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryTargetProtectionContainerIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryTargetProtectionContainerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SiteRecoveryProtectionContainer in recoveryservices to populate recoveryTargetProtectionContainerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryTargetProtectionContainerIdSelector
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
    public V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryTargetProtectionContainerIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecInitProvider
{
    /// <summary>a automatic_update block defined as below.</summary>
    [JsonPropertyName("automaticUpdate")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderAutomaticUpdate? AutomaticUpdate { get; set; }

    /// <summary>Id of the policy to use for this mapping. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryReplicationPolicyId")]
    public string? RecoveryReplicationPolicyId { get; set; }

    /// <summary>Reference to a SiteRecoveryReplicationPolicy in recoveryservices to populate recoveryReplicationPolicyId.</summary>
    [JsonPropertyName("recoveryReplicationPolicyIdRef")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryReplicationPolicyIdRef? RecoveryReplicationPolicyIdRef { get; set; }

    /// <summary>Selector for a SiteRecoveryReplicationPolicy in recoveryservices to populate recoveryReplicationPolicyId.</summary>
    [JsonPropertyName("recoveryReplicationPolicyIdSelector")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryReplicationPolicyIdSelector? RecoveryReplicationPolicyIdSelector { get; set; }

    /// <summary>Id of target protection container to map to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryTargetProtectionContainerId")]
    public string? RecoveryTargetProtectionContainerId { get; set; }

    /// <summary>Reference to a SiteRecoveryProtectionContainer in recoveryservices to populate recoveryTargetProtectionContainerId.</summary>
    [JsonPropertyName("recoveryTargetProtectionContainerIdRef")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryTargetProtectionContainerIdRef? RecoveryTargetProtectionContainerIdRef { get; set; }

    /// <summary>Selector for a SiteRecoveryProtectionContainer in recoveryservices to populate recoveryTargetProtectionContainerId.</summary>
    [JsonPropertyName("recoveryTargetProtectionContainerIdSelector")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecInitProviderRecoveryTargetProtectionContainerIdSelector? RecoveryTargetProtectionContainerIdSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecProviderConfigRef
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
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SiteRecoveryProtectionContainerMappingSpec defines the desired state of SiteRecoveryProtectionContainerMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>a automatic_update block defined as below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingStatusAtProviderAutomaticUpdate
{
    /// <summary>The authentication type used for automation account. Possible values are RunAsAccount and SystemAssignedIdentity. Defaults to SystemAssignedIdentity.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The automation account ID which holds the automatic update runbook and authenticates to Azure resources.</summary>
    [JsonPropertyName("automationAccountId")]
    public string? AutomationAccountId { get; set; }

    /// <summary>Should the Mobility service installed on Azure virtual machines be automatically updated. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingStatusAtProvider
{
    /// <summary>a automatic_update block defined as below.</summary>
    [JsonPropertyName("automaticUpdate")]
    public V1beta1SiteRecoveryProtectionContainerMappingStatusAtProviderAutomaticUpdate? AutomaticUpdate { get; set; }

    /// <summary>The ID of the Site Recovery Protection Container Mapping.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of fabric that should contains the protection container to map. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryFabricName")]
    public string? RecoveryFabricName { get; set; }

    /// <summary>Id of the policy to use for this mapping. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryReplicationPolicyId")]
    public string? RecoveryReplicationPolicyId { get; set; }

    /// <summary>Name of the source protection container to map. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoverySourceProtectionContainerName")]
    public string? RecoverySourceProtectionContainerName { get; set; }

    /// <summary>Id of target protection container to map to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryTargetProtectionContainerId")]
    public string? RecoveryTargetProtectionContainerId { get; set; }

    /// <summary>The name of the vault that should be updated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryVaultName")]
    public string? RecoveryVaultName { get; set; }

    /// <summary>Name of the resource group where the vault that should be updated is located. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingStatusConditions
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

/// <summary>SiteRecoveryProtectionContainerMappingStatus defines the observed state of SiteRecoveryProtectionContainerMapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SiteRecoveryProtectionContainerMappingStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SiteRecoveryProtectionContainerMappingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SiteRecoveryProtectionContainerMappingStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SiteRecoveryProtectionContainerMapping is the Schema for the SiteRecoveryProtectionContainerMappings API. Manages a Site Recovery protection container mapping on Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SiteRecoveryProtectionContainerMapping : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SiteRecoveryProtectionContainerMappingSpec>, IStatus<V1beta1SiteRecoveryProtectionContainerMappingStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SiteRecoveryProtectionContainerMapping";
    public const string KubeGroup = "recoveryservices.azure.m.upbound.io";
    public const string KubePluralName = "siterecoveryprotectioncontainermappings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SiteRecoveryProtectionContainerMappingSpec defines the desired state of SiteRecoveryProtectionContainerMapping</summary>
    [JsonPropertyName("spec")]
    public V1beta1SiteRecoveryProtectionContainerMappingSpec Spec { get; set; }

    /// <summary>SiteRecoveryProtectionContainerMappingStatus defines the observed state of SiteRecoveryProtectionContainerMapping.</summary>
    [JsonPropertyName("status")]
    public V1beta1SiteRecoveryProtectionContainerMappingStatus? Status { get; set; }
}

/// <summary>SiteRecoveryProtectionContainerMapping is the Schema for the SiteRecoveryProtectionContainerMappings API. Manages a Site Recovery protection container mapping on Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SiteRecoveryProtectionContainerMappingList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SiteRecoveryProtectionContainerMapping>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SiteRecoveryProtectionContainerMappingList";
    public const string KubeGroup = "recoveryservices.azure.m.upbound.io";
    public const string KubePluralName = "siterecoveryprotectioncontainermappings";
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
    public IList<V1beta1SiteRecoveryProtectionContainerMapping> Items { get; set; }
}