using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.gcp.upbound.io;
#nullable enable
/// <summary>AddonsConfig is the Schema for the AddonsConfigs API. Configures the add-ons for the Apigee organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AddonsConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AddonsConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AddonsConfigList";
    public const string KubeGroup = "apigee.gcp.upbound.io";
    public const string KubePluralName = "addonsconfigs";
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
    public IList<V1beta1AddonsConfig> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Advanced API Ops add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecForProviderAddonsConfigAdvancedApiOpsConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the API Security add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecForProviderAddonsConfigApiSecurityConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecForProviderAddonsConfigConnectorsPlatformConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Integration add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecForProviderAddonsConfigIntegrationConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecForProviderAddonsConfigMonetizationConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Addon configurations of the Apigee organization. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecForProviderAddonsConfig
{
    /// <summary>Configuration for the Advanced API Ops add-on. Structure is documented below.</summary>
    [JsonPropertyName("advancedApiOpsConfig")]
    public V1beta1AddonsConfigSpecForProviderAddonsConfigAdvancedApiOpsConfig? AdvancedApiOpsConfig { get; set; }

    /// <summary>Configuration for the API Security add-on. Structure is documented below.</summary>
    [JsonPropertyName("apiSecurityConfig")]
    public V1beta1AddonsConfigSpecForProviderAddonsConfigApiSecurityConfig? ApiSecurityConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
    [JsonPropertyName("connectorsPlatformConfig")]
    public V1beta1AddonsConfigSpecForProviderAddonsConfigConnectorsPlatformConfig? ConnectorsPlatformConfig { get; set; }

    /// <summary>Configuration for the Integration add-on. Structure is documented below.</summary>
    [JsonPropertyName("integrationConfig")]
    public V1beta1AddonsConfigSpecForProviderAddonsConfigIntegrationConfig? IntegrationConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
    [JsonPropertyName("monetizationConfig")]
    public V1beta1AddonsConfigSpecForProviderAddonsConfigMonetizationConfig? MonetizationConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecForProviderOrgRefPolicy
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
/// <summary>Reference to a Organization in apigee to populate org.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecForProviderOrgRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AddonsConfigSpecForProviderOrgRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecForProviderOrgSelectorPolicy
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
/// <summary>Selector for a Organization in apigee to populate org.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecForProviderOrgSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AddonsConfigSpecForProviderOrgSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecForProvider
{
    /// <summary>Addon configurations of the Apigee organization. Structure is documented below.</summary>
    [JsonPropertyName("addonsConfig")]
    public V1beta1AddonsConfigSpecForProviderAddonsConfig? AddonsConfig { get; set; }

    /// <summary>Name of the Apigee organization.</summary>
    [JsonPropertyName("org")]
    public string? Org { get; set; }

    /// <summary>Reference to a Organization in apigee to populate org.</summary>
    [JsonPropertyName("orgRef")]
    public V1beta1AddonsConfigSpecForProviderOrgRef? OrgRef { get; set; }

    /// <summary>Selector for a Organization in apigee to populate org.</summary>
    [JsonPropertyName("orgSelector")]
    public V1beta1AddonsConfigSpecForProviderOrgSelector? OrgSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Advanced API Ops add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecInitProviderAddonsConfigAdvancedApiOpsConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the API Security add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecInitProviderAddonsConfigApiSecurityConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecInitProviderAddonsConfigConnectorsPlatformConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Integration add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecInitProviderAddonsConfigIntegrationConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecInitProviderAddonsConfigMonetizationConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Addon configurations of the Apigee organization. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecInitProviderAddonsConfig
{
    /// <summary>Configuration for the Advanced API Ops add-on. Structure is documented below.</summary>
    [JsonPropertyName("advancedApiOpsConfig")]
    public V1beta1AddonsConfigSpecInitProviderAddonsConfigAdvancedApiOpsConfig? AdvancedApiOpsConfig { get; set; }

    /// <summary>Configuration for the API Security add-on. Structure is documented below.</summary>
    [JsonPropertyName("apiSecurityConfig")]
    public V1beta1AddonsConfigSpecInitProviderAddonsConfigApiSecurityConfig? ApiSecurityConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
    [JsonPropertyName("connectorsPlatformConfig")]
    public V1beta1AddonsConfigSpecInitProviderAddonsConfigConnectorsPlatformConfig? ConnectorsPlatformConfig { get; set; }

    /// <summary>Configuration for the Integration add-on. Structure is documented below.</summary>
    [JsonPropertyName("integrationConfig")]
    public V1beta1AddonsConfigSpecInitProviderAddonsConfigIntegrationConfig? IntegrationConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
    [JsonPropertyName("monetizationConfig")]
    public V1beta1AddonsConfigSpecInitProviderAddonsConfigMonetizationConfig? MonetizationConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecInitProviderOrgRefPolicy
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
/// <summary>Reference to a Organization in apigee to populate org.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecInitProviderOrgRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AddonsConfigSpecInitProviderOrgRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecInitProviderOrgSelectorPolicy
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
/// <summary>Selector for a Organization in apigee to populate org.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecInitProviderOrgSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AddonsConfigSpecInitProviderOrgSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecInitProvider
{
    /// <summary>Addon configurations of the Apigee organization. Structure is documented below.</summary>
    [JsonPropertyName("addonsConfig")]
    public V1beta1AddonsConfigSpecInitProviderAddonsConfig? AddonsConfig { get; set; }

    /// <summary>Name of the Apigee organization.</summary>
    [JsonPropertyName("org")]
    public string? Org { get; set; }

    /// <summary>Reference to a Organization in apigee to populate org.</summary>
    [JsonPropertyName("orgRef")]
    public V1beta1AddonsConfigSpecInitProviderOrgRef? OrgRef { get; set; }

    /// <summary>Selector for a Organization in apigee to populate org.</summary>
    [JsonPropertyName("orgSelector")]
    public V1beta1AddonsConfigSpecInitProviderOrgSelector? OrgSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecProviderConfigRefPolicy
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
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AddonsConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AddonsConfigSpec defines the desired state of AddonsConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AddonsConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AddonsConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AddonsConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AddonsConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Advanced API Ops add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigStatusAtProviderAddonsConfigAdvancedApiOpsConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the API Security add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigStatusAtProviderAddonsConfigApiSecurityConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(Output) Time at which the Connectors Platform add-on expires in milliseconds since epoch. If unspecified, the add-on will never expire.</summary>
    [JsonPropertyName("expiresAt")]
    public string? ExpiresAt { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigStatusAtProviderAddonsConfigConnectorsPlatformConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>(Output) Time at which the Connectors Platform add-on expires in milliseconds since epoch. If unspecified, the add-on will never expire.</summary>
    [JsonPropertyName("expiresAt")]
    public string? ExpiresAt { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Integration add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigStatusAtProviderAddonsConfigIntegrationConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigStatusAtProviderAddonsConfigMonetizationConfig
{
    /// <summary>Flag that specifies whether the Monetization add-on is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Addon configurations of the Apigee organization. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigStatusAtProviderAddonsConfig
{
    /// <summary>Configuration for the Advanced API Ops add-on. Structure is documented below.</summary>
    [JsonPropertyName("advancedApiOpsConfig")]
    public V1beta1AddonsConfigStatusAtProviderAddonsConfigAdvancedApiOpsConfig? AdvancedApiOpsConfig { get; set; }

    /// <summary>Configuration for the API Security add-on. Structure is documented below.</summary>
    [JsonPropertyName("apiSecurityConfig")]
    public V1beta1AddonsConfigStatusAtProviderAddonsConfigApiSecurityConfig? ApiSecurityConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
    [JsonPropertyName("connectorsPlatformConfig")]
    public V1beta1AddonsConfigStatusAtProviderAddonsConfigConnectorsPlatformConfig? ConnectorsPlatformConfig { get; set; }

    /// <summary>Configuration for the Integration add-on. Structure is documented below.</summary>
    [JsonPropertyName("integrationConfig")]
    public V1beta1AddonsConfigStatusAtProviderAddonsConfigIntegrationConfig? IntegrationConfig { get; set; }

    /// <summary>Configuration for the Monetization add-on. Structure is documented below.</summary>
    [JsonPropertyName("monetizationConfig")]
    public V1beta1AddonsConfigStatusAtProviderAddonsConfigMonetizationConfig? MonetizationConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigStatusAtProvider
{
    /// <summary>Addon configurations of the Apigee organization. Structure is documented below.</summary>
    [JsonPropertyName("addonsConfig")]
    public V1beta1AddonsConfigStatusAtProviderAddonsConfig? AddonsConfig { get; set; }

    /// <summary>an identifier for the resource with format organizations/{{org}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the Apigee organization.</summary>
    [JsonPropertyName("org")]
    public string? Org { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigStatusConditions
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
/// <summary>AddonsConfigStatus defines the observed state of AddonsConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AddonsConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AddonsConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AddonsConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>AddonsConfig is the Schema for the AddonsConfigs API. Configures the add-ons for the Apigee organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AddonsConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AddonsConfigSpec>, IStatus<V1beta1AddonsConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AddonsConfig";
    public const string KubeGroup = "apigee.gcp.upbound.io";
    public const string KubePluralName = "addonsconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AddonsConfigSpec defines the desired state of AddonsConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1AddonsConfigSpec Spec { get; set; }

    /// <summary>AddonsConfigStatus defines the observed state of AddonsConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1AddonsConfigStatus? Status { get; set; }
}
#nullable disable
