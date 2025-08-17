using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.licensemanager.aws.m.upbound.io;
#nullable enable
/// <summary>LicenseConfiguration is the Schema for the LicenseConfigurations API. Provides a License Manager license configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LicenseConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LicenseConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LicenseConfigurationList";
    public const string KubeGroup = "licensemanager.aws.m.upbound.io";
    public const string KubePluralName = "licenseconfigurations";
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
    public IList<V1beta1LicenseConfiguration> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LicenseConfigurationSpecForProvider
{
    /// <summary>Description of the license configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Number of licenses managed by the license configuration.</summary>
    [JsonPropertyName("licenseCount")]
    public double? LicenseCount { get; set; }

    /// <summary>Sets the number of available licenses as a hard limit.</summary>
    [JsonPropertyName("licenseCountHardLimit")]
    public bool? LicenseCountHardLimit { get; set; }

    /// <summary>Dimension to use to track license inventory. Specify either vCPU, Instance, Core or Socket.</summary>
    [JsonPropertyName("licenseCountingType")]
    public string? LicenseCountingType { get; set; }

    /// <summary>Array of configured License Manager rules.</summary>
    [JsonPropertyName("licenseRules")]
    public IList<string>? LicenseRules { get; set; }

    /// <summary>Name of the license configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LicenseConfigurationSpecInitProvider
{
    /// <summary>Description of the license configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Number of licenses managed by the license configuration.</summary>
    [JsonPropertyName("licenseCount")]
    public double? LicenseCount { get; set; }

    /// <summary>Sets the number of available licenses as a hard limit.</summary>
    [JsonPropertyName("licenseCountHardLimit")]
    public bool? LicenseCountHardLimit { get; set; }

    /// <summary>Dimension to use to track license inventory. Specify either vCPU, Instance, Core or Socket.</summary>
    [JsonPropertyName("licenseCountingType")]
    public string? LicenseCountingType { get; set; }

    /// <summary>Array of configured License Manager rules.</summary>
    [JsonPropertyName("licenseRules")]
    public IList<string>? LicenseRules { get; set; }

    /// <summary>Name of the license configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LicenseConfigurationSpecProviderConfigRef
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
public partial class V1beta1LicenseConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>LicenseConfigurationSpec defines the desired state of LicenseConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LicenseConfigurationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LicenseConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LicenseConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LicenseConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LicenseConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LicenseConfigurationStatusAtProvider
{
    /// <summary>The license configuration ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Description of the license configuration.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The license configuration ARN.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Number of licenses managed by the license configuration.</summary>
    [JsonPropertyName("licenseCount")]
    public double? LicenseCount { get; set; }

    /// <summary>Sets the number of available licenses as a hard limit.</summary>
    [JsonPropertyName("licenseCountHardLimit")]
    public bool? LicenseCountHardLimit { get; set; }

    /// <summary>Dimension to use to track license inventory. Specify either vCPU, Instance, Core or Socket.</summary>
    [JsonPropertyName("licenseCountingType")]
    public string? LicenseCountingType { get; set; }

    /// <summary>Array of configured License Manager rules.</summary>
    [JsonPropertyName("licenseRules")]
    public IList<string>? LicenseRules { get; set; }

    /// <summary>Name of the license configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Account ID of the owner of the license configuration.</summary>
    [JsonPropertyName("ownerAccountId")]
    public string? OwnerAccountId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LicenseConfigurationStatusConditions
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
/// <summary>LicenseConfigurationStatus defines the observed state of LicenseConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LicenseConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LicenseConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LicenseConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>LicenseConfiguration is the Schema for the LicenseConfigurations API. Provides a License Manager license configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LicenseConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LicenseConfigurationSpec>, IStatus<V1beta1LicenseConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LicenseConfiguration";
    public const string KubeGroup = "licensemanager.aws.m.upbound.io";
    public const string KubePluralName = "licenseconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LicenseConfigurationSpec defines the desired state of LicenseConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1LicenseConfigurationSpec Spec { get; set; }

    /// <summary>LicenseConfigurationStatus defines the observed state of LicenseConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1LicenseConfigurationStatus? Status { get; set; }
}
#nullable disable
