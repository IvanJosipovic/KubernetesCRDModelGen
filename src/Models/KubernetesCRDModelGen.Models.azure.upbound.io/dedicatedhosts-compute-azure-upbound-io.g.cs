using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.upbound.io;
#nullable enable
/// <summary>DedicatedHost is the Schema for the DedicatedHosts API. Manage a Dedicated Host within a Dedicated Host Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DedicatedHostList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DedicatedHost>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DedicatedHostList";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "dedicatedhosts";
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
    public IList<V1beta1DedicatedHost> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DedicatedHostSpecForProvider
{
    /// <summary>Should the Dedicated Host automatically be replaced in case of a Hardware Failure? Defaults to true.</summary>
    [JsonPropertyName("autoReplaceOnFailure")]
    public bool? AutoReplaceOnFailure { get; set; }

    /// <summary>Specifies the ID of the Dedicated Host Group where the Dedicated Host should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dedicatedHostGroupId")]
    public string DedicatedHostGroupId { get; set; }

    /// <summary>Specifies the software license type that will be applied to the VMs deployed on the Dedicated Host. Possible values are None, Windows_Server_Hybrid and Windows_Server_Perpetual. Defaults to None.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specify the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specify the fault domain of the Dedicated Host Group in which to create the Dedicated Host. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomain")]
    public double? PlatformFaultDomain { get; set; }

    /// <summary>Specify the SKU name of the Dedicated Host. Possible values are DADSv5-Type1, DASv4-Type1, DASv4-Type2, DASv5-Type1, DCSv2-Type1, DDSv4-Type1, DDSv4-Type2, DDSv5-Type1, DSv3-Type1, DSv3-Type2, DSv3-Type3, DSv3-Type4, DSv4-Type1, DSv4-Type2, DSv5-Type1, EADSv5-Type1, EASv4-Type1, EASv4-Type2, EASv5-Type1, EDSv4-Type1, EDSv4-Type2, EDSv5-Type1, ESv3-Type1, ESv3-Type2, ESv3-Type3, ESv3-Type4, ESv4-Type1, ESv4-Type2, ESv5-Type1, FSv2-Type2, FSv2-Type3, FSv2-Type4, FXmds-Type1, LSv2-Type1, LSv3-Type1, MDMSv2MedMem-Type1, MDSv2MedMem-Type1, MMSv2MedMem-Type1, MS-Type1, MSm-Type1, MSmv2-Type1, MSv2-Type1, MSv2MedMem-Type1, NVASv4-Type1 and NVSv3-Type1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DedicatedHostSpecInitProvider
{
    /// <summary>Should the Dedicated Host automatically be replaced in case of a Hardware Failure? Defaults to true.</summary>
    [JsonPropertyName("autoReplaceOnFailure")]
    public bool? AutoReplaceOnFailure { get; set; }

    /// <summary>Specifies the software license type that will be applied to the VMs deployed on the Dedicated Host. Possible values are None, Windows_Server_Hybrid and Windows_Server_Perpetual. Defaults to None.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specify the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specify the fault domain of the Dedicated Host Group in which to create the Dedicated Host. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomain")]
    public double? PlatformFaultDomain { get; set; }

    /// <summary>Specify the SKU name of the Dedicated Host. Possible values are DADSv5-Type1, DASv4-Type1, DASv4-Type2, DASv5-Type1, DCSv2-Type1, DDSv4-Type1, DDSv4-Type2, DDSv5-Type1, DSv3-Type1, DSv3-Type2, DSv3-Type3, DSv3-Type4, DSv4-Type1, DSv4-Type2, DSv5-Type1, EADSv5-Type1, EASv4-Type1, EASv4-Type2, EASv5-Type1, EDSv4-Type1, EDSv4-Type2, EDSv5-Type1, ESv3-Type1, ESv3-Type2, ESv3-Type3, ESv3-Type4, ESv4-Type1, ESv4-Type2, ESv5-Type1, FSv2-Type2, FSv2-Type3, FSv2-Type4, FXmds-Type1, LSv2-Type1, LSv3-Type1, MDMSv2MedMem-Type1, MDSv2MedMem-Type1, MMSv2MedMem-Type1, MS-Type1, MSm-Type1, MSmv2-Type1, MSv2-Type1, MSv2MedMem-Type1, NVASv4-Type1 and NVSv3-Type1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DedicatedHostSpecProviderConfigRefPolicy
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
public partial class V1beta1DedicatedHostSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DedicatedHostSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DedicatedHostSpecWriteConnectionSecretToRef
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
/// <summary>DedicatedHostSpec defines the desired state of DedicatedHost</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DedicatedHostSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DedicatedHostSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DedicatedHostSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DedicatedHostSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DedicatedHostSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DedicatedHostStatusAtProvider
{
    /// <summary>Should the Dedicated Host automatically be replaced in case of a Hardware Failure? Defaults to true.</summary>
    [JsonPropertyName("autoReplaceOnFailure")]
    public bool? AutoReplaceOnFailure { get; set; }

    /// <summary>Specifies the ID of the Dedicated Host Group where the Dedicated Host should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dedicatedHostGroupId")]
    public string? DedicatedHostGroupId { get; set; }

    /// <summary>The ID of the Dedicated Host.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the software license type that will be applied to the VMs deployed on the Dedicated Host. Possible values are None, Windows_Server_Hybrid and Windows_Server_Perpetual. Defaults to None.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specify the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specify the fault domain of the Dedicated Host Group in which to create the Dedicated Host. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomain")]
    public double? PlatformFaultDomain { get; set; }

    /// <summary>Specify the SKU name of the Dedicated Host. Possible values are DADSv5-Type1, DASv4-Type1, DASv4-Type2, DASv5-Type1, DCSv2-Type1, DDSv4-Type1, DDSv4-Type2, DDSv5-Type1, DSv3-Type1, DSv3-Type2, DSv3-Type3, DSv3-Type4, DSv4-Type1, DSv4-Type2, DSv5-Type1, EADSv5-Type1, EASv4-Type1, EASv4-Type2, EASv5-Type1, EDSv4-Type1, EDSv4-Type2, EDSv5-Type1, ESv3-Type1, ESv3-Type2, ESv3-Type3, ESv3-Type4, ESv4-Type1, ESv4-Type2, ESv5-Type1, FSv2-Type2, FSv2-Type3, FSv2-Type4, FXmds-Type1, LSv2-Type1, LSv3-Type1, MDMSv2MedMem-Type1, MDSv2MedMem-Type1, MMSv2MedMem-Type1, MS-Type1, MSm-Type1, MSmv2-Type1, MSv2-Type1, MSv2MedMem-Type1, NVASv4-Type1 and NVSv3-Type1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DedicatedHostStatusConditions
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
/// <summary>DedicatedHostStatus defines the observed state of DedicatedHost.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DedicatedHostStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DedicatedHostStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DedicatedHostStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DedicatedHost is the Schema for the DedicatedHosts API. Manage a Dedicated Host within a Dedicated Host Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DedicatedHost : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DedicatedHostSpec>, IStatus<V1beta1DedicatedHostStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DedicatedHost";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "dedicatedhosts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DedicatedHostSpec defines the desired state of DedicatedHost</summary>
    [JsonPropertyName("spec")]
    public V1beta1DedicatedHostSpec Spec { get; set; }

    /// <summary>DedicatedHostStatus defines the observed state of DedicatedHost.</summary>
    [JsonPropertyName("status")]
    public V1beta1DedicatedHostStatus? Status { get; set; }
}
#nullable disable
