using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.databricks.crossplane.io;
/// <summary>InstancePool is the Schema for the InstancePools API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1InstancePoolList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1InstancePool>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "InstancePoolList";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "instancepools";
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
    public IList<V1alpha1InstancePool> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderAwsAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>(Integer) The max price for AWS spot instances, as a percentage of the corresponding instance type's on-demand price. For example, if this field is set to 50, and the instance pool needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this instance pool, only spot instances whose max price percentage matches this field are considered. For safety, this field cannot be greater than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>(String) Identifier for the availability zone/datacenter in which the instance pool resides. This string is of the form like "us-west-2a". The provided availability zone must be in the same region as the Databricks deployment. For example, "us-west-2a" is not a valid zone ID if the Databricks deployment resides in the "us-east-1" region. If not specified, a default zone is used. You can find the list of available zones as well as the default value by using the List Zones API.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderAzureAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderDiskSpecDiskType
{
    /// <summary></summary>
    [JsonPropertyName("azureDiskVolumeType")]
    public string? AzureDiskVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderDiskSpec
{
    /// <summary>(Integer) The number of disks to attach to each instance. This feature is only enabled for supported node types. Users can choose up to the limit of the disks supported by the node type. For node types with no local disk, at least one disk needs to be specified.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>(Integer) The size of each disk (in GiB) to attach.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskType")]
    public IList<V1alpha1InstancePoolSpecForProviderDiskSpecDiskType>? DiskType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderGcpAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are PREEMPTIBLE_GCP, PREEMPTIBLE_WITH_FALLBACK_GCP and ON_DEMAND_GCP, default: ON_DEMAND_GCP.</summary>
    [JsonPropertyName("gcpAvailability")]
    public string? GcpAvailability { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-central1-a. The provided availability zone must be in the same region as the Databricks workspace.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderInstancePoolFleetAttributesFleetOnDemandOption
{
    /// <summary></summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderInstancePoolFleetAttributesFleetSpotOption
{
    /// <summary></summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderInstancePoolFleetAttributesLaunchTemplateOverride
{
    /// <summary></summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderInstancePoolFleetAttributes
{
    /// <summary></summary>
    [JsonPropertyName("fleetOnDemandOption")]
    public IList<V1alpha1InstancePoolSpecForProviderInstancePoolFleetAttributesFleetOnDemandOption>? FleetOnDemandOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fleetSpotOption")]
    public IList<V1alpha1InstancePoolSpecForProviderInstancePoolFleetAttributesFleetSpotOption>? FleetSpotOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("launchTemplateOverride")]
    public IList<V1alpha1InstancePoolSpecForProviderInstancePoolFleetAttributesLaunchTemplateOverride>? LaunchTemplateOverride { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderPreloadedDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderPreloadedDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1InstancePoolSpecForProviderPreloadedDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProviderPreloadedDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1InstancePoolSpecForProviderPreloadedDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecForProvider
{
    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1InstancePoolSpecForProviderAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1InstancePoolSpecForProviderAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>(Map) Additional tags for instance pool resources. Databricks tags all pool resources (e.g. AWS &amp; Azure instances and Disk volumes). The tags of the instance pool will propagate to the clusters using the pool (see the official documentation). Attempting to set the same tags in both cluster and instance pool will raise an error. Databricks allows at most 43 custom tags.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSpec")]
    public IList<V1alpha1InstancePoolSpecForProviderDiskSpec>? DiskSpec { get; set; }

    /// <summary>(Bool) Autoscaling Local Storage: when enabled, the instances in the pool dynamically acquire additional disk space when they are running low on disk space.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1InstancePoolSpecForProviderGcpAttributes>? GcpAttributes { get; set; }

    /// <summary>(Integer) The number of minutes that idle instances in excess of the min_idle_instances are maintained by the pool before being terminated. If not specified, excess idle instances are terminated automatically after a default timeout period. If specified, the time must be between 0 and 10000 minutes. If you specify 0, excess idle instances are removed as soon as possible.</summary>
    [JsonPropertyName("idleInstanceAutoterminationMinutes")]
    public double? IdleInstanceAutoterminationMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instancePoolFleetAttributes")]
    public IList<V1alpha1InstancePoolSpecForProviderInstancePoolFleetAttributes>? InstancePoolFleetAttributes { get; set; }

    /// <summary>Canonical unique identifier for the instance pool.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>(String) The name of the instance pool. This is required for create and edit operations. It must be unique, non-empty, and less than 100 characters.</summary>
    [JsonPropertyName("instancePoolName")]
    public string? InstancePoolName { get; set; }

    /// <summary>(Integer) The maximum number of instances the pool can contain, including both idle instances and ones in use by clusters. Once the maximum capacity is reached, you cannot create new clusters from the pool and existing clusters cannot autoscale up until some instances are made idle in the pool via cluster termination or down-scaling. There is no default limit, but as a best practice, this should be set based on anticipated usage.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>(Integer) The minimum number of idle instances maintained by the pool. This is in addition to any instances in use by active clusters.</summary>
    [JsonPropertyName("minIdleInstances")]
    public double? MinIdleInstances { get; set; }

    /// <summary>(String) The node type for the instances in the pool. All clusters attached to the pool inherit this node type and the pool's idle instances are allocated based on this type. You can retrieve a list of available node types by using the List Node Types API call.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preloadedDockerImage")]
    public IList<V1alpha1InstancePoolSpecForProviderPreloadedDockerImage>? PreloadedDockerImage { get; set; }

    /// <summary>(List) A list with at most one runtime version the pool installs on each instance. Pool clusters that use a preloaded runtime version start faster as they do not have to wait for the image to download. You can retrieve them via databricks_spark_version data source or via  Runtime Versions API call.</summary>
    [JsonPropertyName("preloadedSparkVersions")]
    public IList<string>? PreloadedSparkVersions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderAwsAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>(Integer) The max price for AWS spot instances, as a percentage of the corresponding instance type's on-demand price. For example, if this field is set to 50, and the instance pool needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this instance pool, only spot instances whose max price percentage matches this field are considered. For safety, this field cannot be greater than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>(String) Identifier for the availability zone/datacenter in which the instance pool resides. This string is of the form like "us-west-2a". The provided availability zone must be in the same region as the Databricks deployment. For example, "us-west-2a" is not a valid zone ID if the Databricks deployment resides in the "us-east-1" region. If not specified, a default zone is used. You can find the list of available zones as well as the default value by using the List Zones API.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderAzureAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderDiskSpecDiskType
{
    /// <summary></summary>
    [JsonPropertyName("azureDiskVolumeType")]
    public string? AzureDiskVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderDiskSpec
{
    /// <summary>(Integer) The number of disks to attach to each instance. This feature is only enabled for supported node types. Users can choose up to the limit of the disks supported by the node type. For node types with no local disk, at least one disk needs to be specified.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>(Integer) The size of each disk (in GiB) to attach.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskType")]
    public IList<V1alpha1InstancePoolSpecInitProviderDiskSpecDiskType>? DiskType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderGcpAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are PREEMPTIBLE_GCP, PREEMPTIBLE_WITH_FALLBACK_GCP and ON_DEMAND_GCP, default: ON_DEMAND_GCP.</summary>
    [JsonPropertyName("gcpAvailability")]
    public string? GcpAvailability { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-central1-a. The provided availability zone must be in the same region as the Databricks workspace.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderInstancePoolFleetAttributesFleetOnDemandOption
{
    /// <summary></summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderInstancePoolFleetAttributesFleetSpotOption
{
    /// <summary></summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderInstancePoolFleetAttributesLaunchTemplateOverride
{
    /// <summary></summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderInstancePoolFleetAttributes
{
    /// <summary></summary>
    [JsonPropertyName("fleetOnDemandOption")]
    public IList<V1alpha1InstancePoolSpecInitProviderInstancePoolFleetAttributesFleetOnDemandOption>? FleetOnDemandOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fleetSpotOption")]
    public IList<V1alpha1InstancePoolSpecInitProviderInstancePoolFleetAttributesFleetSpotOption>? FleetSpotOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("launchTemplateOverride")]
    public IList<V1alpha1InstancePoolSpecInitProviderInstancePoolFleetAttributesLaunchTemplateOverride>? LaunchTemplateOverride { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderPreloadedDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderPreloadedDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1InstancePoolSpecInitProviderPreloadedDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProviderPreloadedDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1InstancePoolSpecInitProviderPreloadedDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecInitProvider
{
    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1InstancePoolSpecInitProviderAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1InstancePoolSpecInitProviderAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>(Map) Additional tags for instance pool resources. Databricks tags all pool resources (e.g. AWS &amp; Azure instances and Disk volumes). The tags of the instance pool will propagate to the clusters using the pool (see the official documentation). Attempting to set the same tags in both cluster and instance pool will raise an error. Databricks allows at most 43 custom tags.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSpec")]
    public IList<V1alpha1InstancePoolSpecInitProviderDiskSpec>? DiskSpec { get; set; }

    /// <summary>(Bool) Autoscaling Local Storage: when enabled, the instances in the pool dynamically acquire additional disk space when they are running low on disk space.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1InstancePoolSpecInitProviderGcpAttributes>? GcpAttributes { get; set; }

    /// <summary>(Integer) The number of minutes that idle instances in excess of the min_idle_instances are maintained by the pool before being terminated. If not specified, excess idle instances are terminated automatically after a default timeout period. If specified, the time must be between 0 and 10000 minutes. If you specify 0, excess idle instances are removed as soon as possible.</summary>
    [JsonPropertyName("idleInstanceAutoterminationMinutes")]
    public double? IdleInstanceAutoterminationMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instancePoolFleetAttributes")]
    public IList<V1alpha1InstancePoolSpecInitProviderInstancePoolFleetAttributes>? InstancePoolFleetAttributes { get; set; }

    /// <summary>Canonical unique identifier for the instance pool.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>(String) The name of the instance pool. This is required for create and edit operations. It must be unique, non-empty, and less than 100 characters.</summary>
    [JsonPropertyName("instancePoolName")]
    public string? InstancePoolName { get; set; }

    /// <summary>(Integer) The maximum number of instances the pool can contain, including both idle instances and ones in use by clusters. Once the maximum capacity is reached, you cannot create new clusters from the pool and existing clusters cannot autoscale up until some instances are made idle in the pool via cluster termination or down-scaling. There is no default limit, but as a best practice, this should be set based on anticipated usage.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>(Integer) The minimum number of idle instances maintained by the pool. This is in addition to any instances in use by active clusters.</summary>
    [JsonPropertyName("minIdleInstances")]
    public double? MinIdleInstances { get; set; }

    /// <summary>(String) The node type for the instances in the pool. All clusters attached to the pool inherit this node type and the pool's idle instances are allocated based on this type. You can retrieve a list of available node types by using the List Node Types API call.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preloadedDockerImage")]
    public IList<V1alpha1InstancePoolSpecInitProviderPreloadedDockerImage>? PreloadedDockerImage { get; set; }

    /// <summary>(List) A list with at most one runtime version the pool installs on each instance. Pool clusters that use a preloaded runtime version start faster as they do not have to wait for the image to download. You can retrieve them via databricks_spark_version data source or via  Runtime Versions API call.</summary>
    [JsonPropertyName("preloadedSparkVersions")]
    public IList<string>? PreloadedSparkVersions { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1InstancePoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1InstancePoolSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1InstancePoolSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1InstancePoolSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>InstancePoolSpec defines the desired state of InstancePool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1InstancePoolSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1InstancePoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1InstancePoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1InstancePoolSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1InstancePoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProviderAwsAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>(Integer) The max price for AWS spot instances, as a percentage of the corresponding instance type's on-demand price. For example, if this field is set to 50, and the instance pool needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this instance pool, only spot instances whose max price percentage matches this field are considered. For safety, this field cannot be greater than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>(String) Identifier for the availability zone/datacenter in which the instance pool resides. This string is of the form like "us-west-2a". The provided availability zone must be in the same region as the Databricks deployment. For example, "us-west-2a" is not a valid zone ID if the Databricks deployment resides in the "us-east-1" region. If not specified, a default zone is used. You can find the list of available zones as well as the default value by using the List Zones API.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProviderAzureAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProviderDiskSpecDiskType
{
    /// <summary></summary>
    [JsonPropertyName("azureDiskVolumeType")]
    public string? AzureDiskVolumeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProviderDiskSpec
{
    /// <summary>(Integer) The number of disks to attach to each instance. This feature is only enabled for supported node types. Users can choose up to the limit of the disks supported by the node type. For node types with no local disk, at least one disk needs to be specified.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>(Integer) The size of each disk (in GiB) to attach.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskType")]
    public IList<V1alpha1InstancePoolStatusAtProviderDiskSpecDiskType>? DiskType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProviderGcpAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are PREEMPTIBLE_GCP, PREEMPTIBLE_WITH_FALLBACK_GCP and ON_DEMAND_GCP, default: ON_DEMAND_GCP.</summary>
    [JsonPropertyName("gcpAvailability")]
    public string? GcpAvailability { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-central1-a. The provided availability zone must be in the same region as the Databricks workspace.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProviderInstancePoolFleetAttributesFleetOnDemandOption
{
    /// <summary></summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProviderInstancePoolFleetAttributesFleetSpotOption
{
    /// <summary></summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProviderInstancePoolFleetAttributesLaunchTemplateOverride
{
    /// <summary></summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProviderInstancePoolFleetAttributes
{
    /// <summary></summary>
    [JsonPropertyName("fleetOnDemandOption")]
    public IList<V1alpha1InstancePoolStatusAtProviderInstancePoolFleetAttributesFleetOnDemandOption>? FleetOnDemandOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fleetSpotOption")]
    public IList<V1alpha1InstancePoolStatusAtProviderInstancePoolFleetAttributesFleetSpotOption>? FleetSpotOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("launchTemplateOverride")]
    public IList<V1alpha1InstancePoolStatusAtProviderInstancePoolFleetAttributesLaunchTemplateOverride>? LaunchTemplateOverride { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProviderPreloadedDockerImageBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProviderPreloadedDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1InstancePoolStatusAtProviderPreloadedDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1InstancePoolStatusAtProviderAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1InstancePoolStatusAtProviderAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>(Map) Additional tags for instance pool resources. Databricks tags all pool resources (e.g. AWS &amp; Azure instances and Disk volumes). The tags of the instance pool will propagate to the clusters using the pool (see the official documentation). Attempting to set the same tags in both cluster and instance pool will raise an error. Databricks allows at most 43 custom tags.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSpec")]
    public IList<V1alpha1InstancePoolStatusAtProviderDiskSpec>? DiskSpec { get; set; }

    /// <summary>(Bool) Autoscaling Local Storage: when enabled, the instances in the pool dynamically acquire additional disk space when they are running low on disk space.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1InstancePoolStatusAtProviderGcpAttributes>? GcpAttributes { get; set; }

    /// <summary>Canonical unique identifier for the instance pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>(Integer) The number of minutes that idle instances in excess of the min_idle_instances are maintained by the pool before being terminated. If not specified, excess idle instances are terminated automatically after a default timeout period. If specified, the time must be between 0 and 10000 minutes. If you specify 0, excess idle instances are removed as soon as possible.</summary>
    [JsonPropertyName("idleInstanceAutoterminationMinutes")]
    public double? IdleInstanceAutoterminationMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instancePoolFleetAttributes")]
    public IList<V1alpha1InstancePoolStatusAtProviderInstancePoolFleetAttributes>? InstancePoolFleetAttributes { get; set; }

    /// <summary>Canonical unique identifier for the instance pool.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>(String) The name of the instance pool. This is required for create and edit operations. It must be unique, non-empty, and less than 100 characters.</summary>
    [JsonPropertyName("instancePoolName")]
    public string? InstancePoolName { get; set; }

    /// <summary>(Integer) The maximum number of instances the pool can contain, including both idle instances and ones in use by clusters. Once the maximum capacity is reached, you cannot create new clusters from the pool and existing clusters cannot autoscale up until some instances are made idle in the pool via cluster termination or down-scaling. There is no default limit, but as a best practice, this should be set based on anticipated usage.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>(Integer) The minimum number of idle instances maintained by the pool. This is in addition to any instances in use by active clusters.</summary>
    [JsonPropertyName("minIdleInstances")]
    public double? MinIdleInstances { get; set; }

    /// <summary>(String) The node type for the instances in the pool. All clusters attached to the pool inherit this node type and the pool's idle instances are allocated based on this type. You can retrieve a list of available node types by using the List Node Types API call.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preloadedDockerImage")]
    public IList<V1alpha1InstancePoolStatusAtProviderPreloadedDockerImage>? PreloadedDockerImage { get; set; }

    /// <summary>(List) A list with at most one runtime version the pool installs on each instance. Pool clusters that use a preloaded runtime version start faster as they do not have to wait for the image to download. You can retrieve them via databricks_spark_version data source or via  Runtime Versions API call.</summary>
    [JsonPropertyName("preloadedSparkVersions")]
    public IList<string>? PreloadedSparkVersions { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatusConditions
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

/// <summary>InstancePoolStatus defines the observed state of InstancePool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstancePoolStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1InstancePoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1InstancePoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>InstancePool is the Schema for the InstancePools API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1InstancePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1InstancePoolSpec>, IStatus<V1alpha1InstancePoolStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "InstancePool";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "instancepools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstancePoolSpec defines the desired state of InstancePool</summary>
    [JsonPropertyName("spec")]
    public V1alpha1InstancePoolSpec Spec { get; set; }

    /// <summary>InstancePoolStatus defines the observed state of InstancePool.</summary>
    [JsonPropertyName("status")]
    public V1alpha1InstancePoolStatus? Status { get; set; }
}