using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lightsail.aws.upbound.io;
#nullable enable
/// <summary>Instance is the Schema for the Instances API. Manages a Lightsail Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Instance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "lightsail.aws.upbound.io";
    public const string KubePluralName = "instances";
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
    public IList<V1beta1Instance> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProviderAddOn
{
    /// <summary>Daily time when an automatic snapshot will be created. Must be in HH:00 format, and in an hourly increment and specified in Coordinated Universal Time (UTC). The snapshot will be automatically created between the time specified and up to 45 minutes after.</summary>
    [JsonPropertyName("snapshotTime")]
    public string? SnapshotTime { get; set; }

    /// <summary>Status of the add-on. Valid values: Enabled, Disabled.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Add-on type. There is currently only one valid type AutoSnapshot.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecForProvider
{
    /// <summary>Add-on configuration for the instance. See below.</summary>
    [JsonPropertyName("addOn")]
    public IList<V1beta1InstanceSpecForProviderAddOn>? AddOn { get; set; }

    /// <summary>Availability Zone in which to create your instance. A list of available zones can be obtained using the AWS CLI command: aws lightsail get-regions --include-availability-zones.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>ID for a virtual private server image. A list of available blueprint IDs can be obtained using the AWS CLI command: aws lightsail get-blueprints.</summary>
    [JsonPropertyName("blueprintId")]
    public string? BlueprintId { get; set; }

    /// <summary>Bundle of specification information. A list of available bundle IDs can be obtained using the AWS CLI command: aws lightsail get-bundles.</summary>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>IP address type of the Lightsail Instance. Valid values: dualstack, ipv4, ipv6. Default: dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Name of your key pair. Created in the Lightsail console (cannot use aws_key_pair at this time).</summary>
    [JsonPropertyName("keyPairName")]
    public string? KeyPairName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Single lined launch script as a string to configure server with additional user data.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProviderAddOn
{
    /// <summary>Daily time when an automatic snapshot will be created. Must be in HH:00 format, and in an hourly increment and specified in Coordinated Universal Time (UTC). The snapshot will be automatically created between the time specified and up to 45 minutes after.</summary>
    [JsonPropertyName("snapshotTime")]
    public string? SnapshotTime { get; set; }

    /// <summary>Status of the add-on. Valid values: Enabled, Disabled.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Add-on type. There is currently only one valid type AutoSnapshot.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecInitProvider
{
    /// <summary>Add-on configuration for the instance. See below.</summary>
    [JsonPropertyName("addOn")]
    public IList<V1beta1InstanceSpecInitProviderAddOn>? AddOn { get; set; }

    /// <summary>Availability Zone in which to create your instance. A list of available zones can be obtained using the AWS CLI command: aws lightsail get-regions --include-availability-zones.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>ID for a virtual private server image. A list of available blueprint IDs can be obtained using the AWS CLI command: aws lightsail get-blueprints.</summary>
    [JsonPropertyName("blueprintId")]
    public string? BlueprintId { get; set; }

    /// <summary>Bundle of specification information. A list of available bundle IDs can be obtained using the AWS CLI command: aws lightsail get-bundles.</summary>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>IP address type of the Lightsail Instance. Valid values: dualstack, ipv4, ipv6. Default: dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Name of your key pair. Created in the Lightsail console (cannot use aws_key_pair at this time).</summary>
    [JsonPropertyName("keyPairName")]
    public string? KeyPairName { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Single lined launch script as a string to configure server with additional user data.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecProviderConfigRefPolicy
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
public partial class V1beta1InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpecWriteConnectionSecretToRef
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
/// <summary>InstanceSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProviderAddOn
{
    /// <summary>Daily time when an automatic snapshot will be created. Must be in HH:00 format, and in an hourly increment and specified in Coordinated Universal Time (UTC). The snapshot will be automatically created between the time specified and up to 45 minutes after.</summary>
    [JsonPropertyName("snapshotTime")]
    public string? SnapshotTime { get; set; }

    /// <summary>Status of the add-on. Valid values: Enabled, Disabled.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Add-on type. There is currently only one valid type AutoSnapshot.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusAtProvider
{
    /// <summary>Add-on configuration for the instance. See below.</summary>
    [JsonPropertyName("addOn")]
    public IList<V1beta1InstanceStatusAtProviderAddOn>? AddOn { get; set; }

    /// <summary>ARN of the Lightsail instance (matches id).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Availability Zone in which to create your instance. A list of available zones can be obtained using the AWS CLI command: aws lightsail get-regions --include-availability-zones.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>ID for a virtual private server image. A list of available blueprint IDs can be obtained using the AWS CLI command: aws lightsail get-blueprints.</summary>
    [JsonPropertyName("blueprintId")]
    public string? BlueprintId { get; set; }

    /// <summary>Bundle of specification information. A list of available bundle IDs can be obtained using the AWS CLI command: aws lightsail get-bundles.</summary>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>Number of vCPUs the instance has.</summary>
    [JsonPropertyName("cpuCount")]
    public double? CpuCount { get; set; }

    /// <summary>Timestamp when the instance was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>ARN of the Lightsail instance (matches arn).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IP address type of the Lightsail Instance. Valid values: dualstack, ipv4, ipv6. Default: dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>List of IPv6 addresses for the Lightsail instance.</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>Whether this instance has a static IP assigned to it.</summary>
    [JsonPropertyName("isStaticIp")]
    public bool? IsStaticIp { get; set; }

    /// <summary>Name of your key pair. Created in the Lightsail console (cannot use aws_key_pair at this time).</summary>
    [JsonPropertyName("keyPairName")]
    public string? KeyPairName { get; set; }

    /// <summary>Private IP address of the instance.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>Public IP address of the instance.</summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }

    /// <summary>Amount of RAM in GB on the instance (e.g., 1.0).</summary>
    [JsonPropertyName("ramSize")]
    public double? RamSize { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Single lined launch script as a string to configure server with additional user data.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>User name for connecting to the instance (e.g., ec2-user).</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatusConditions
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
/// <summary>InstanceStatus defines the observed state of Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Instance is the Schema for the Instances API. Manages a Lightsail Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceSpec>, IStatus<V1beta1InstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "lightsail.aws.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceStatus? Status { get; set; }
}
#nullable disable
