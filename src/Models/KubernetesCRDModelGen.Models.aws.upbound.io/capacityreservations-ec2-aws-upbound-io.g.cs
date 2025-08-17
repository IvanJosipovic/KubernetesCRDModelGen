using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
#nullable enable
/// <summary>CapacityReservation is the Schema for the CapacityReservations API. Provides an EC2 Capacity Reservation. This allows you to reserve capacity for your Amazon EC2 instances in a specific Availability Zone for any duration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CapacityReservationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CapacityReservation>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CapacityReservationList";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "capacityreservations";
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
    public IList<V1beta1CapacityReservation> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityReservationSpecForProvider
{
    /// <summary>The Availability Zone in which to create the Capacity Reservation.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Indicates whether the Capacity Reservation supports EBS-optimized instances.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>The date and time at which the Capacity Reservation expires. When a Capacity Reservation expires, the reserved capacity is released and you can no longer launch instances into it. Valid values: RFC3339 time string (YYYY-MM-DDTHH:MM:SSZ)</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>Indicates the way in which the Capacity Reservation ends. Specify either unlimited or limited.</summary>
    [JsonPropertyName("endDateType")]
    public string? EndDateType { get; set; }

    /// <summary>Indicates whether the Capacity Reservation supports instances with temporary, block-level storage.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public bool? EphemeralStorage { get; set; }

    /// <summary>The number of instances for which to reserve capacity.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Indicates the type of instance launches that the Capacity Reservation accepts. Specify either open or targeted.</summary>
    [JsonPropertyName("instanceMatchCriteria")]
    public string? InstanceMatchCriteria { get; set; }

    /// <summary>The type of operating system for which to reserve capacity. Valid options are Linux/UNIX, Red Hat Enterprise Linux, SUSE Linux, Windows, Windows with SQL Server, Windows with SQL Server Enterprise, Windows with SQL Server Standard or Windows with SQL Server Web.</summary>
    [JsonPropertyName("instancePlatform")]
    public string? InstancePlatform { get; set; }

    /// <summary>The instance type for which to reserve capacity.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Outpost on which to create the Capacity Reservation.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the cluster placement group in which to create the Capacity Reservation.</summary>
    [JsonPropertyName("placementGroupArn")]
    public string? PlacementGroupArn { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Indicates the tenancy of the Capacity Reservation. Specify either default or dedicated.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityReservationSpecInitProvider
{
    /// <summary>The Availability Zone in which to create the Capacity Reservation.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Indicates whether the Capacity Reservation supports EBS-optimized instances.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>The date and time at which the Capacity Reservation expires. When a Capacity Reservation expires, the reserved capacity is released and you can no longer launch instances into it. Valid values: RFC3339 time string (YYYY-MM-DDTHH:MM:SSZ)</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>Indicates the way in which the Capacity Reservation ends. Specify either unlimited or limited.</summary>
    [JsonPropertyName("endDateType")]
    public string? EndDateType { get; set; }

    /// <summary>Indicates whether the Capacity Reservation supports instances with temporary, block-level storage.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public bool? EphemeralStorage { get; set; }

    /// <summary>The number of instances for which to reserve capacity.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Indicates the type of instance launches that the Capacity Reservation accepts. Specify either open or targeted.</summary>
    [JsonPropertyName("instanceMatchCriteria")]
    public string? InstanceMatchCriteria { get; set; }

    /// <summary>The type of operating system for which to reserve capacity. Valid options are Linux/UNIX, Red Hat Enterprise Linux, SUSE Linux, Windows, Windows with SQL Server, Windows with SQL Server Enterprise, Windows with SQL Server Standard or Windows with SQL Server Web.</summary>
    [JsonPropertyName("instancePlatform")]
    public string? InstancePlatform { get; set; }

    /// <summary>The instance type for which to reserve capacity.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Outpost on which to create the Capacity Reservation.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the cluster placement group in which to create the Capacity Reservation.</summary>
    [JsonPropertyName("placementGroupArn")]
    public string? PlacementGroupArn { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Indicates the tenancy of the Capacity Reservation. Specify either default or dedicated.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityReservationSpecProviderConfigRefPolicy
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
public partial class V1beta1CapacityReservationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CapacityReservationSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityReservationSpecWriteConnectionSecretToRef
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
/// <summary>CapacityReservationSpec defines the desired state of CapacityReservation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityReservationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CapacityReservationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CapacityReservationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CapacityReservationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CapacityReservationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityReservationStatusAtProvider
{
    /// <summary>The ARN of the Capacity Reservation.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The Availability Zone in which to create the Capacity Reservation.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Indicates whether the Capacity Reservation supports EBS-optimized instances.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>The date and time at which the Capacity Reservation expires. When a Capacity Reservation expires, the reserved capacity is released and you can no longer launch instances into it. Valid values: RFC3339 time string (YYYY-MM-DDTHH:MM:SSZ)</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>Indicates the way in which the Capacity Reservation ends. Specify either unlimited or limited.</summary>
    [JsonPropertyName("endDateType")]
    public string? EndDateType { get; set; }

    /// <summary>Indicates whether the Capacity Reservation supports instances with temporary, block-level storage.</summary>
    [JsonPropertyName("ephemeralStorage")]
    public bool? EphemeralStorage { get; set; }

    /// <summary>The Capacity Reservation ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The number of instances for which to reserve capacity.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Indicates the type of instance launches that the Capacity Reservation accepts. Specify either open or targeted.</summary>
    [JsonPropertyName("instanceMatchCriteria")]
    public string? InstanceMatchCriteria { get; set; }

    /// <summary>The type of operating system for which to reserve capacity. Valid options are Linux/UNIX, Red Hat Enterprise Linux, SUSE Linux, Windows, Windows with SQL Server, Windows with SQL Server Enterprise, Windows with SQL Server Standard or Windows with SQL Server Web.</summary>
    [JsonPropertyName("instancePlatform")]
    public string? InstancePlatform { get; set; }

    /// <summary>The instance type for which to reserve capacity.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Outpost on which to create the Capacity Reservation.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>The ID of the AWS account that owns the Capacity Reservation.</summary>
    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the cluster placement group in which to create the Capacity Reservation.</summary>
    [JsonPropertyName("placementGroupArn")]
    public string? PlacementGroupArn { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Indicates the tenancy of the Capacity Reservation. Specify either default or dedicated.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityReservationStatusConditions
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
/// <summary>CapacityReservationStatus defines the observed state of CapacityReservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityReservationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CapacityReservationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CapacityReservationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CapacityReservation is the Schema for the CapacityReservations API. Provides an EC2 Capacity Reservation. This allows you to reserve capacity for your Amazon EC2 instances in a specific Availability Zone for any duration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CapacityReservation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CapacityReservationSpec>, IStatus<V1beta1CapacityReservationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CapacityReservation";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "capacityreservations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CapacityReservationSpec defines the desired state of CapacityReservation</summary>
    [JsonPropertyName("spec")]
    public V1beta1CapacityReservationSpec Spec { get; set; }

    /// <summary>CapacityReservationStatus defines the observed state of CapacityReservation.</summary>
    [JsonPropertyName("status")]
    public V1beta1CapacityReservationStatus? Status { get; set; }
}
#nullable disable
