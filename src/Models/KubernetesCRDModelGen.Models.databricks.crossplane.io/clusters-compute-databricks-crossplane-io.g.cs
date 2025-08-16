using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.databricks.crossplane.io;
/// <summary>Cluster is the Schema for the Clusters API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Cluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "clusters";
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
    public IList<V1alpha1Cluster> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderAutoscale
{
    /// <summary>The maximum number of workers to which the cluster can scale up when overloaded. max_workers must be strictly greater than min_workers.</summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary>The minimum number of workers to which the cluster can scale down when underutilized. It is also the initial number of workers the cluster will have after creation.</summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderAwsAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT, SPOT_WITH_FALLBACK and ON_DEMAND. Note: If first_on_demand is zero, this availability type will be used for the entire cluster. Backend default value is SPOT_WITH_FALLBACK and could change in the future</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The number of volumes launched for each instance. You can choose up to 10 volumes. This feature is only enabled for supported node types. Legacy node types cannot specify custom EBS volumes. For node types with no instance store, at least one EBS volume needs to be specified; otherwise, cluster creation will fail. These EBS volumes will be mounted at /ebs0, /ebs1, and etc. Instance store volumes will be mounted at /local_disk0, /local_disk1, and etc. If EBS volumes are attached, Databricks will configure Spark to use only the EBS volumes for scratch storage because heterogeneously sized scratch devices can lead to inefficient disk utilization. If no EBS volumes are attached, Databricks will configure Spark to use instance store volumes. If EBS volumes are specified, then the Spark configuration spark.local.dir will be overridden.</summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary>The size of each EBS volume (in GiB) launched for each instance. For general purpose SSD, this value must be within the range 100 - 4096. For throughput optimized HDD, this value must be within the range 500 - 4096. Custom EBS volumes cannot be specified for the legacy node types (memory-optimized and compute-optimized).</summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary>The type of EBS volumes that will be launched with this cluster. Valid values are GENERAL_PURPOSE_SSD or THROUGHPUT_OPTIMIZED_HDD. Use this option only if you're not picking Delta Optimized  node types.</summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster. If unspecified, the default value is 0.</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary>Nodes for this cluster will only be placed on AWS instances with this instance profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The max price for AWS spot instances, as a percentage of the corresponding instance type’s on-demand price. For example, if this field is set to 50, and the cluster needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this cluster, only spot instances whose max price percentage matches this field will be considered. For safety, we enforce this field to be no more than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-west-2a. The provided availability zone must be in the same region as the Databricks deployment. For example, us-west-2a is not a valid zone ID if the Databricks deployment resides in the us-east-1 region. Enable automatic availability zone selection ("Auto-AZ"), by setting the value auto. Databricks selects the AZ based on available IPs in the workspace subnets and retries in other availability zones if AWS returns insufficient capacity errors.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier for the cluster.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderAzureAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT_AZURE, SPOT_WITH_FALLBACK_AZURE, and ON_DEMAND_AZURE. Note: If first_on_demand is zero, this availability type will be used for the entire cluster.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster.</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1ClusterSpecForProviderAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderClusterLogConfDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderClusterLogConfS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderClusterLogConfVolumes
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1ClusterSpecForProviderClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1ClusterSpecForProviderClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1ClusterSpecForProviderClusterLogConfVolumes>? Volumes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderClusterMountInfoNetworkFilesystemInfo
{
    /// <summary>string that will be passed as options passed to the mount command.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>host name.</summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderClusterMountInfo
{
    /// <summary>path inside the Spark container.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary>block specifying connection. It consists of:</summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1ClusterSpecForProviderClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>string specifying path to mount on the remote service.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderDockerImageBasicAuthPasswordSecretRef
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
public partial class V1alpha1ClusterSpecForProviderDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1ClusterSpecForProviderDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1ClusterSpecForProviderDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderGcpAttributes
{
    /// <summary>, and will be removed soon.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>Boot disk size in GB</summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary>Google Service Account email address that the cluster uses to authenticate with Google Identity. This field is used for authentication with the GCS and BigQuery data sources.</summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>if we should use preemptible executors (GCP documentation). Warning: this field is deprecated in favor of</summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>Identifier for the availability zone in which the cluster resides. This can be one of the following:</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderInitScriptsAbfss
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderInitScriptsDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderInitScriptsFile
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderInitScriptsGcs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderInitScriptsS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderInitScriptsVolumes
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderInitScriptsWorkspace
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1ClusterSpecForProviderInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1ClusterSpecForProviderInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1ClusterSpecForProviderInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1ClusterSpecForProviderInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1ClusterSpecForProviderInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1ClusterSpecForProviderInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1ClusterSpecForProviderInitScriptsWorkspace>? Workspace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1ClusterSpecForProviderLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1ClusterSpecForProviderLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1ClusterSpecForProviderLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderWorkloadTypeClients
{
    /// <summary>boolean flag defining if it's possible to run Databricks Jobs on this cluster. Default: true.</summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary>boolean flag defining if it's possible to run notebooks on this cluster. Default: true.</summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProviderWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1ClusterSpecForProviderWorkloadTypeClients>? Clients { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecForProvider
{
    /// <summary>Whether to use policy default values for missing cluster attributes.</summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1ClusterSpecForProviderAutoscale>? Autoscale { get; set; }

    /// <summary>Automatically terminate the cluster after being inactive for this time in minutes. If specified, the threshold must be between 10 and 10000 minutes. You can also set this value to 0 to explicitly disable automatic termination. Defaults to 60.  We highly recommend having this setting present for Interactive/BI clusters.</summary>
    [JsonPropertyName("autoterminationMinutes")]
    public double? AutoterminationMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1ClusterSpecForProviderAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1ClusterSpecForProviderAzureAttributes>? AzureAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1ClusterSpecForProviderClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1ClusterSpecForProviderClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>Cluster name, which doesn't have to be unique. If not specified at creation, the cluster name will be an empty string.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Additional tags for cluster resources. Databricks will tag all cluster resources (e.g., AWS EC2 instances and EBS volumes) with these tags in addition to default_tags. If a custom cluster tag has the same name as a default cluster tag, the custom tag is prefixed with an x_ when it is propagated.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Select the security features of the cluster (see API docs for full list of values). Unity Catalog requires SINGLE_USER or USER_ISOLATION mode. LEGACY_PASSTHROUGH for passthrough cluster and LEGACY_TABLE_ACL for Table ACL cluster. If omitted, default security features are enabled. To disable security features use NONE or legacy mode NO_ISOLATION.  If kind is specified, then the following options are available:</summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1ClusterSpecForProviderDockerImage>? DockerImage { get; set; }

    /// <summary>similar to instance_pool_id, but for driver node. If omitted, and instance_pool_id is specified, then the driver will be allocated from that pool.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>The node type of the Spark driver. This field is optional; if unset, API will set the driver node type to the same value as node_type_id defined above.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary>If you don't want to allocate a fixed number of EBS volumes at cluster creation time, use autoscaling local storage. With autoscaling local storage, Databricks monitors the amount of free disk space available on your cluster's Spark workers. If a worker begins to run too low on disk, Databricks automatically attaches a new EBS volume to the worker before it runs out of disk space. EBS volumes are attached up to a limit of 5 TB of total disk space per instance (including the instance's local storage). To scale down EBS usage, make sure you have autotermination_minutes and autoscale attributes set. More documentation available at cluster configuration page.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary>Some instance types you use to run clusters may have locally attached disks. Databricks may store shuffle data or temporary data on these locally attached disks. To ensure that all data at rest is encrypted for all storage types, including shuffle data stored temporarily on your cluster's local disks, you can enable local disk encryption. When local disk encryption is enabled, Databricks generates an encryption key locally unique to each cluster node and uses it to encrypt all data stored on local disks. The scope of the key is local to each cluster node and is destroyed along with the cluster node itself. During its lifetime, the key resides in memory for encryption and decryption and is stored encrypted on the disk. Your workloads may run more slowly because of the performance impact of reading and writing encrypted data to and from local volumes. This feature is not available for all Azure Databricks subscriptions. Contact your Microsoft or Databricks account representative to request access.</summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1ClusterSpecForProviderGcpAttributes>? GcpAttributes { get; set; }

    /// <summary>An optional token to guarantee the idempotency of cluster creation requests. If an active cluster with the provided token already exists, the request will not create a new cluster, but it will return the existing running cluster's ID instead. If you specify the idempotency token, upon failure, you can retry until the request succeeds. Databricks platform guarantees to launch exactly one cluster with that idempotency token. This token should have at most 64 characters.</summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1ClusterSpecForProviderInitScripts>? InitScripts { get; set; }

    /// <summary>required if node_type_id is not given) - To reduce cluster start time, you can attach a cluster to a predefined pool of idle instances. When attached to a pool, a cluster allocates its driver and worker nodes from the pool. If the pool does not have sufficient idle resources to accommodate the cluster's request, it expands by allocating new instances from the instance provider. When an attached cluster changes its state to TERMINATED, the instances it used are returned to the pool and reused by a different cluster.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>boolean value specifying if the cluster is pinned (not pinned by default). You must be a Databricks administrator to use this.  The pinned clusters' maximum number is limited to 100, so apply may fail if you have more than that (this number may change over time, so check Databricks documentation for actual number).</summary>
    [JsonPropertyName("isPinned")]
    public bool? IsPinned { get; set; }

    /// <summary>When set to true, Databricks will automatically set single node related custom_tags, spark_conf, and num_workers.</summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary>The kind of compute described by this compute specification.  Possible values (see API docs for full list): CLASSIC_PREVIEW (if corresponding public preview is enabled).</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1ClusterSpecForProviderLibrary>? Library { get; set; }

    /// <summary>If true, the provider will not wait for the cluster to reach RUNNING state when creating the cluster, allowing cluster creation and library installation to continue asynchronously. Defaults to false (the provider will wait for cluster creation and library installation to succeed).</summary>
    [JsonPropertyName("noWait")]
    public bool? NoWait { get; set; }

    /// <summary>Any supported databricks_node_type id. If instance_pool_id is specified, this field is not needed.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary>Number of worker nodes that this cluster should have. A cluster has one Spark driver and num_workers executors for a total of num_workers + 1 Spark nodes.</summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Identifier of Cluster Policy to validate cluster and preset certain defaults. The primary use for cluster policies is to allow users to create policy-scoped clusters via UI rather than sharing configuration for API-created clusters. For example, when you specify policy_id of external metastore policy, you still have to fill in relevant keys for spark_conf.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary>The type of runtime engine to use. If not specified, the runtime engine type is inferred based on the spark_version value. Allowed values include: PHOTON, STANDARD.</summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>The optional user name of the user (or group name if kind if specified) to assign to an interactive cluster. This field is required when using data_security_mode set to SINGLE_USER or AAD Passthrough for Azure Data Lake Storage (ADLS) with a single-user cluster (i.e., not high-concurrency clusters).</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary>Map with key-value pairs to fine-tune Spark clusters, where you can provide custom Spark configuration properties in a cluster configuration.</summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary>Map with environment variable key-value pairs to fine-tune Spark clusters. Key-value pairs of the form (X,Y) are exported (i.e., X='Y') while launching the driver and workers.</summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>Runtime version of the cluster. Any supported databricks_spark_version id.  We advise using Cluster Policies to restrict the list of versions for simplicity while maintaining enough control.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>SSH public key contents that will be added to each Spark node in this cluster. The corresponding private keys can be used to login with the user name ubuntu on port 2200. You can specify up to 10 keys.</summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary>Whenever ML runtime should be selected or not.  Actual runtime is determined by spark_version (DBR release), this field use_ml_runtime, and whether node_type_id is GPU node or not.</summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1ClusterSpecForProviderWorkloadType>? WorkloadType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderAutoscale
{
    /// <summary>The maximum number of workers to which the cluster can scale up when overloaded. max_workers must be strictly greater than min_workers.</summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary>The minimum number of workers to which the cluster can scale down when underutilized. It is also the initial number of workers the cluster will have after creation.</summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderAwsAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT, SPOT_WITH_FALLBACK and ON_DEMAND. Note: If first_on_demand is zero, this availability type will be used for the entire cluster. Backend default value is SPOT_WITH_FALLBACK and could change in the future</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The number of volumes launched for each instance. You can choose up to 10 volumes. This feature is only enabled for supported node types. Legacy node types cannot specify custom EBS volumes. For node types with no instance store, at least one EBS volume needs to be specified; otherwise, cluster creation will fail. These EBS volumes will be mounted at /ebs0, /ebs1, and etc. Instance store volumes will be mounted at /local_disk0, /local_disk1, and etc. If EBS volumes are attached, Databricks will configure Spark to use only the EBS volumes for scratch storage because heterogeneously sized scratch devices can lead to inefficient disk utilization. If no EBS volumes are attached, Databricks will configure Spark to use instance store volumes. If EBS volumes are specified, then the Spark configuration spark.local.dir will be overridden.</summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary>The size of each EBS volume (in GiB) launched for each instance. For general purpose SSD, this value must be within the range 100 - 4096. For throughput optimized HDD, this value must be within the range 500 - 4096. Custom EBS volumes cannot be specified for the legacy node types (memory-optimized and compute-optimized).</summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary>The type of EBS volumes that will be launched with this cluster. Valid values are GENERAL_PURPOSE_SSD or THROUGHPUT_OPTIMIZED_HDD. Use this option only if you're not picking Delta Optimized  node types.</summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster. If unspecified, the default value is 0.</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary>Nodes for this cluster will only be placed on AWS instances with this instance profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The max price for AWS spot instances, as a percentage of the corresponding instance type’s on-demand price. For example, if this field is set to 50, and the cluster needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this cluster, only spot instances whose max price percentage matches this field will be considered. For safety, we enforce this field to be no more than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-west-2a. The provided availability zone must be in the same region as the Databricks deployment. For example, us-west-2a is not a valid zone ID if the Databricks deployment resides in the us-east-1 region. Enable automatic availability zone selection ("Auto-AZ"), by setting the value auto. Databricks selects the AZ based on available IPs in the workspace subnets and retries in other availability zones if AWS returns insufficient capacity errors.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier for the cluster.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderAzureAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT_AZURE, SPOT_WITH_FALLBACK_AZURE, and ON_DEMAND_AZURE. Note: If first_on_demand is zero, this availability type will be used for the entire cluster.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster.</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1ClusterSpecInitProviderAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderClusterLogConfDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderClusterLogConfS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderClusterLogConfVolumes
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1ClusterSpecInitProviderClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1ClusterSpecInitProviderClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1ClusterSpecInitProviderClusterLogConfVolumes>? Volumes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderClusterMountInfoNetworkFilesystemInfo
{
    /// <summary>string that will be passed as options passed to the mount command.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>host name.</summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderClusterMountInfo
{
    /// <summary>path inside the Spark container.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary>block specifying connection. It consists of:</summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1ClusterSpecInitProviderClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>string specifying path to mount on the remote service.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderDockerImageBasicAuthPasswordSecretRef
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
public partial class V1alpha1ClusterSpecInitProviderDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1ClusterSpecInitProviderDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1ClusterSpecInitProviderDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderGcpAttributes
{
    /// <summary>, and will be removed soon.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>Boot disk size in GB</summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary>Google Service Account email address that the cluster uses to authenticate with Google Identity. This field is used for authentication with the GCS and BigQuery data sources.</summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>if we should use preemptible executors (GCP documentation). Warning: this field is deprecated in favor of</summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>Identifier for the availability zone in which the cluster resides. This can be one of the following:</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderInitScriptsAbfss
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderInitScriptsDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderInitScriptsFile
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderInitScriptsGcs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderInitScriptsS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderInitScriptsVolumes
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderInitScriptsWorkspace
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1ClusterSpecInitProviderInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1ClusterSpecInitProviderInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1ClusterSpecInitProviderInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1ClusterSpecInitProviderInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1ClusterSpecInitProviderInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1ClusterSpecInitProviderInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1ClusterSpecInitProviderInitScriptsWorkspace>? Workspace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1ClusterSpecInitProviderLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1ClusterSpecInitProviderLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1ClusterSpecInitProviderLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderWorkloadTypeClients
{
    /// <summary>boolean flag defining if it's possible to run Databricks Jobs on this cluster. Default: true.</summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary>boolean flag defining if it's possible to run notebooks on this cluster. Default: true.</summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProviderWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1ClusterSpecInitProviderWorkloadTypeClients>? Clients { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecInitProvider
{
    /// <summary>Whether to use policy default values for missing cluster attributes.</summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1ClusterSpecInitProviderAutoscale>? Autoscale { get; set; }

    /// <summary>Automatically terminate the cluster after being inactive for this time in minutes. If specified, the threshold must be between 10 and 10000 minutes. You can also set this value to 0 to explicitly disable automatic termination. Defaults to 60.  We highly recommend having this setting present for Interactive/BI clusters.</summary>
    [JsonPropertyName("autoterminationMinutes")]
    public double? AutoterminationMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1ClusterSpecInitProviderAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1ClusterSpecInitProviderAzureAttributes>? AzureAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1ClusterSpecInitProviderClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1ClusterSpecInitProviderClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>Cluster name, which doesn't have to be unique. If not specified at creation, the cluster name will be an empty string.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Additional tags for cluster resources. Databricks will tag all cluster resources (e.g., AWS EC2 instances and EBS volumes) with these tags in addition to default_tags. If a custom cluster tag has the same name as a default cluster tag, the custom tag is prefixed with an x_ when it is propagated.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Select the security features of the cluster (see API docs for full list of values). Unity Catalog requires SINGLE_USER or USER_ISOLATION mode. LEGACY_PASSTHROUGH for passthrough cluster and LEGACY_TABLE_ACL for Table ACL cluster. If omitted, default security features are enabled. To disable security features use NONE or legacy mode NO_ISOLATION.  If kind is specified, then the following options are available:</summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1ClusterSpecInitProviderDockerImage>? DockerImage { get; set; }

    /// <summary>similar to instance_pool_id, but for driver node. If omitted, and instance_pool_id is specified, then the driver will be allocated from that pool.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>The node type of the Spark driver. This field is optional; if unset, API will set the driver node type to the same value as node_type_id defined above.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary>If you don't want to allocate a fixed number of EBS volumes at cluster creation time, use autoscaling local storage. With autoscaling local storage, Databricks monitors the amount of free disk space available on your cluster's Spark workers. If a worker begins to run too low on disk, Databricks automatically attaches a new EBS volume to the worker before it runs out of disk space. EBS volumes are attached up to a limit of 5 TB of total disk space per instance (including the instance's local storage). To scale down EBS usage, make sure you have autotermination_minutes and autoscale attributes set. More documentation available at cluster configuration page.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary>Some instance types you use to run clusters may have locally attached disks. Databricks may store shuffle data or temporary data on these locally attached disks. To ensure that all data at rest is encrypted for all storage types, including shuffle data stored temporarily on your cluster's local disks, you can enable local disk encryption. When local disk encryption is enabled, Databricks generates an encryption key locally unique to each cluster node and uses it to encrypt all data stored on local disks. The scope of the key is local to each cluster node and is destroyed along with the cluster node itself. During its lifetime, the key resides in memory for encryption and decryption and is stored encrypted on the disk. Your workloads may run more slowly because of the performance impact of reading and writing encrypted data to and from local volumes. This feature is not available for all Azure Databricks subscriptions. Contact your Microsoft or Databricks account representative to request access.</summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1ClusterSpecInitProviderGcpAttributes>? GcpAttributes { get; set; }

    /// <summary>An optional token to guarantee the idempotency of cluster creation requests. If an active cluster with the provided token already exists, the request will not create a new cluster, but it will return the existing running cluster's ID instead. If you specify the idempotency token, upon failure, you can retry until the request succeeds. Databricks platform guarantees to launch exactly one cluster with that idempotency token. This token should have at most 64 characters.</summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1ClusterSpecInitProviderInitScripts>? InitScripts { get; set; }

    /// <summary>required if node_type_id is not given) - To reduce cluster start time, you can attach a cluster to a predefined pool of idle instances. When attached to a pool, a cluster allocates its driver and worker nodes from the pool. If the pool does not have sufficient idle resources to accommodate the cluster's request, it expands by allocating new instances from the instance provider. When an attached cluster changes its state to TERMINATED, the instances it used are returned to the pool and reused by a different cluster.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>boolean value specifying if the cluster is pinned (not pinned by default). You must be a Databricks administrator to use this.  The pinned clusters' maximum number is limited to 100, so apply may fail if you have more than that (this number may change over time, so check Databricks documentation for actual number).</summary>
    [JsonPropertyName("isPinned")]
    public bool? IsPinned { get; set; }

    /// <summary>When set to true, Databricks will automatically set single node related custom_tags, spark_conf, and num_workers.</summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary>The kind of compute described by this compute specification.  Possible values (see API docs for full list): CLASSIC_PREVIEW (if corresponding public preview is enabled).</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1ClusterSpecInitProviderLibrary>? Library { get; set; }

    /// <summary>If true, the provider will not wait for the cluster to reach RUNNING state when creating the cluster, allowing cluster creation and library installation to continue asynchronously. Defaults to false (the provider will wait for cluster creation and library installation to succeed).</summary>
    [JsonPropertyName("noWait")]
    public bool? NoWait { get; set; }

    /// <summary>Any supported databricks_node_type id. If instance_pool_id is specified, this field is not needed.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary>Number of worker nodes that this cluster should have. A cluster has one Spark driver and num_workers executors for a total of num_workers + 1 Spark nodes.</summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Identifier of Cluster Policy to validate cluster and preset certain defaults. The primary use for cluster policies is to allow users to create policy-scoped clusters via UI rather than sharing configuration for API-created clusters. For example, when you specify policy_id of external metastore policy, you still have to fill in relevant keys for spark_conf.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary>The type of runtime engine to use. If not specified, the runtime engine type is inferred based on the spark_version value. Allowed values include: PHOTON, STANDARD.</summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>The optional user name of the user (or group name if kind if specified) to assign to an interactive cluster. This field is required when using data_security_mode set to SINGLE_USER or AAD Passthrough for Azure Data Lake Storage (ADLS) with a single-user cluster (i.e., not high-concurrency clusters).</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary>Map with key-value pairs to fine-tune Spark clusters, where you can provide custom Spark configuration properties in a cluster configuration.</summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary>Map with environment variable key-value pairs to fine-tune Spark clusters. Key-value pairs of the form (X,Y) are exported (i.e., X='Y') while launching the driver and workers.</summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>Runtime version of the cluster. Any supported databricks_spark_version id.  We advise using Cluster Policies to restrict the list of versions for simplicity while maintaining enough control.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>SSH public key contents that will be added to each Spark node in this cluster. The corresponding private keys can be used to login with the user name ubuntu on port 2200. You can specify up to 10 keys.</summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary>Whenever ML runtime should be selected or not.  Actual runtime is determined by spark_version (DBR release), this field use_ml_runtime, and whether node_type_id is GPU node or not.</summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1ClusterSpecInitProviderWorkloadType>? WorkloadType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecProviderConfigRefPolicy
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
public partial class V1alpha1ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1ClusterSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ClusterSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1ClusterSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1ClusterSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ClusterSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1ClusterSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderAutoscale
{
    /// <summary>The maximum number of workers to which the cluster can scale up when overloaded. max_workers must be strictly greater than min_workers.</summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary>The minimum number of workers to which the cluster can scale down when underutilized. It is also the initial number of workers the cluster will have after creation.</summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderAwsAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT, SPOT_WITH_FALLBACK and ON_DEMAND. Note: If first_on_demand is zero, this availability type will be used for the entire cluster. Backend default value is SPOT_WITH_FALLBACK and could change in the future</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The number of volumes launched for each instance. You can choose up to 10 volumes. This feature is only enabled for supported node types. Legacy node types cannot specify custom EBS volumes. For node types with no instance store, at least one EBS volume needs to be specified; otherwise, cluster creation will fail. These EBS volumes will be mounted at /ebs0, /ebs1, and etc. Instance store volumes will be mounted at /local_disk0, /local_disk1, and etc. If EBS volumes are attached, Databricks will configure Spark to use only the EBS volumes for scratch storage because heterogeneously sized scratch devices can lead to inefficient disk utilization. If no EBS volumes are attached, Databricks will configure Spark to use instance store volumes. If EBS volumes are specified, then the Spark configuration spark.local.dir will be overridden.</summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary>The size of each EBS volume (in GiB) launched for each instance. For general purpose SSD, this value must be within the range 100 - 4096. For throughput optimized HDD, this value must be within the range 500 - 4096. Custom EBS volumes cannot be specified for the legacy node types (memory-optimized and compute-optimized).</summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary>The type of EBS volumes that will be launched with this cluster. Valid values are GENERAL_PURPOSE_SSD or THROUGHPUT_OPTIMIZED_HDD. Use this option only if you're not picking Delta Optimized  node types.</summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster. If unspecified, the default value is 0.</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary>Nodes for this cluster will only be placed on AWS instances with this instance profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The max price for AWS spot instances, as a percentage of the corresponding instance type’s on-demand price. For example, if this field is set to 50, and the cluster needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this cluster, only spot instances whose max price percentage matches this field will be considered. For safety, we enforce this field to be no more than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-west-2a. The provided availability zone must be in the same region as the Databricks deployment. For example, us-west-2a is not a valid zone ID if the Databricks deployment resides in the us-east-1 region. Enable automatic availability zone selection ("Auto-AZ"), by setting the value auto. Databricks selects the AZ based on available IPs in the workspace subnets and retries in other availability zones if AWS returns insufficient capacity errors.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderAzureAttributesLogAnalyticsInfo
{
    /// <summary></summary>
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier for the cluster.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderAzureAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT_AZURE, SPOT_WITH_FALLBACK_AZURE, and ON_DEMAND_AZURE. Note: If first_on_demand is zero, this availability type will be used for the entire cluster.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster.</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsInfo")]
    public IList<V1alpha1ClusterStatusAtProviderAzureAttributesLogAnalyticsInfo>? LogAnalyticsInfo { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderClusterLogConfDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderClusterLogConfS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderClusterLogConfVolumes
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderClusterLogConf
{
    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1ClusterStatusAtProviderClusterLogConfDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1ClusterStatusAtProviderClusterLogConfS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1ClusterStatusAtProviderClusterLogConfVolumes>? Volumes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderClusterMountInfoNetworkFilesystemInfo
{
    /// <summary>string that will be passed as options passed to the mount command.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>host name.</summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderClusterMountInfo
{
    /// <summary>path inside the Spark container.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary>block specifying connection. It consists of:</summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public IList<V1alpha1ClusterStatusAtProviderClusterMountInfoNetworkFilesystemInfo>? NetworkFilesystemInfo { get; set; }

    /// <summary>string specifying path to mount on the remote service.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderDockerImageBasicAuth
{
    /// <summary></summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
    [JsonPropertyName("basicAuth")]
    public IList<V1alpha1ClusterStatusAtProviderDockerImageBasicAuth>? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderGcpAttributes
{
    /// <summary>, and will be removed soon.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>Boot disk size in GB</summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary>Google Service Account email address that the cluster uses to authenticate with Google Identity. This field is used for authentication with the GCS and BigQuery data sources.</summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>if we should use preemptible executors (GCP documentation). Warning: this field is deprecated in favor of</summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>Identifier for the availability zone in which the cluster resides. This can be one of the following:</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderInitScriptsAbfss
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderInitScriptsDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderInitScriptsFile
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderInitScriptsGcs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderInitScriptsS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderInitScriptsVolumes
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderInitScriptsWorkspace
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderInitScripts
{
    /// <summary></summary>
    [JsonPropertyName("abfss")]
    public IList<V1alpha1ClusterStatusAtProviderInitScriptsAbfss>? Abfss { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dbfs")]
    public IList<V1alpha1ClusterStatusAtProviderInitScriptsDbfs>? Dbfs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("file")]
    public IList<V1alpha1ClusterStatusAtProviderInitScriptsFile>? File { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcs")]
    public IList<V1alpha1ClusterStatusAtProviderInitScriptsGcs>? Gcs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IList<V1alpha1ClusterStatusAtProviderInitScriptsS3>? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("volumes")]
    public IList<V1alpha1ClusterStatusAtProviderInitScriptsVolumes>? Volumes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspace")]
    public IList<V1alpha1ClusterStatusAtProviderInitScriptsWorkspace>? Workspace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderLibraryCran
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderLibraryMaven
{
    /// <summary></summary>
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderLibraryPypi
{
    /// <summary></summary>
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderLibrary
{
    /// <summary></summary>
    [JsonPropertyName("cran")]
    public IList<V1alpha1ClusterStatusAtProviderLibraryCran>? Cran { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    /// <summary></summary>
    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maven")]
    public IList<V1alpha1ClusterStatusAtProviderLibraryMaven>? Maven { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pypi")]
    public IList<V1alpha1ClusterStatusAtProviderLibraryPypi>? Pypi { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderWorkloadTypeClients
{
    /// <summary>boolean flag defining if it's possible to run Databricks Jobs on this cluster. Default: true.</summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary>boolean flag defining if it's possible to run notebooks on this cluster. Default: true.</summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProviderWorkloadType
{
    /// <summary></summary>
    [JsonPropertyName("clients")]
    public IList<V1alpha1ClusterStatusAtProviderWorkloadTypeClients>? Clients { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAtProvider
{
    /// <summary>Whether to use policy default values for missing cluster attributes.</summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoscale")]
    public IList<V1alpha1ClusterStatusAtProviderAutoscale>? Autoscale { get; set; }

    /// <summary>Automatically terminate the cluster after being inactive for this time in minutes. If specified, the threshold must be between 10 and 10000 minutes. You can also set this value to 0 to explicitly disable automatic termination. Defaults to 60.  We highly recommend having this setting present for Interactive/BI clusters.</summary>
    [JsonPropertyName("autoterminationMinutes")]
    public double? AutoterminationMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("awsAttributes")]
    public IList<V1alpha1ClusterStatusAtProviderAwsAttributes>? AwsAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureAttributes")]
    public IList<V1alpha1ClusterStatusAtProviderAzureAttributes>? AzureAttributes { get; set; }

    /// <summary>Canonical unique identifier for the cluster.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterLogConf")]
    public IList<V1alpha1ClusterStatusAtProviderClusterLogConf>? ClusterLogConf { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterMountInfo")]
    public IList<V1alpha1ClusterStatusAtProviderClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>Cluster name, which doesn't have to be unique. If not specified at creation, the cluster name will be an empty string.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Additional tags for cluster resources. Databricks will tag all cluster resources (e.g., AWS EC2 instances and EBS volumes) with these tags in addition to default_tags. If a custom cluster tag has the same name as a default cluster tag, the custom tag is prefixed with an x_ when it is propagated.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Select the security features of the cluster (see API docs for full list of values). Unity Catalog requires SINGLE_USER or USER_ISOLATION mode. LEGACY_PASSTHROUGH for passthrough cluster and LEGACY_TABLE_ACL for Table ACL cluster. If omitted, default security features are enabled. To disable security features use NONE or legacy mode NO_ISOLATION.  If kind is specified, then the following options are available:</summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary>(map) Tags that are added by Databricks by default, regardless of any custom_tags that may have been added. These include: Vendor: Databricks, Creator: &lt;username_of_creator&gt;, ClusterName: &lt;name_of_cluster&gt;, ClusterId: &lt;id_of_cluster&gt;, Name: , and any workspace and pool tags.</summary>
    [JsonPropertyName("defaultTags")]
    public IDictionary<string, string>? DefaultTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dockerImage")]
    public IList<V1alpha1ClusterStatusAtProviderDockerImage>? DockerImage { get; set; }

    /// <summary>similar to instance_pool_id, but for driver node. If omitted, and instance_pool_id is specified, then the driver will be allocated from that pool.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>The node type of the Spark driver. This field is optional; if unset, API will set the driver node type to the same value as node_type_id defined above.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary>If you don't want to allocate a fixed number of EBS volumes at cluster creation time, use autoscaling local storage. With autoscaling local storage, Databricks monitors the amount of free disk space available on your cluster's Spark workers. If a worker begins to run too low on disk, Databricks automatically attaches a new EBS volume to the worker before it runs out of disk space. EBS volumes are attached up to a limit of 5 TB of total disk space per instance (including the instance's local storage). To scale down EBS usage, make sure you have autotermination_minutes and autoscale attributes set. More documentation available at cluster configuration page.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary>Some instance types you use to run clusters may have locally attached disks. Databricks may store shuffle data or temporary data on these locally attached disks. To ensure that all data at rest is encrypted for all storage types, including shuffle data stored temporarily on your cluster's local disks, you can enable local disk encryption. When local disk encryption is enabled, Databricks generates an encryption key locally unique to each cluster node and uses it to encrypt all data stored on local disks. The scope of the key is local to each cluster node and is destroyed along with the cluster node itself. During its lifetime, the key resides in memory for encryption and decryption and is stored encrypted on the disk. Your workloads may run more slowly because of the performance impact of reading and writing encrypted data to and from local volumes. This feature is not available for all Azure Databricks subscriptions. Contact your Microsoft or Databricks account representative to request access.</summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpAttributes")]
    public IList<V1alpha1ClusterStatusAtProviderGcpAttributes>? GcpAttributes { get; set; }

    /// <summary>Canonical unique identifier for the cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An optional token to guarantee the idempotency of cluster creation requests. If an active cluster with the provided token already exists, the request will not create a new cluster, but it will return the existing running cluster's ID instead. If you specify the idempotency token, upon failure, you can retry until the request succeeds. Databricks platform guarantees to launch exactly one cluster with that idempotency token. This token should have at most 64 characters.</summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initScripts")]
    public IList<V1alpha1ClusterStatusAtProviderInitScripts>? InitScripts { get; set; }

    /// <summary>required if node_type_id is not given) - To reduce cluster start time, you can attach a cluster to a predefined pool of idle instances. When attached to a pool, a cluster allocates its driver and worker nodes from the pool. If the pool does not have sufficient idle resources to accommodate the cluster's request, it expands by allocating new instances from the instance provider. When an attached cluster changes its state to TERMINATED, the instances it used are returned to the pool and reused by a different cluster.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>boolean value specifying if the cluster is pinned (not pinned by default). You must be a Databricks administrator to use this.  The pinned clusters' maximum number is limited to 100, so apply may fail if you have more than that (this number may change over time, so check Databricks documentation for actual number).</summary>
    [JsonPropertyName("isPinned")]
    public bool? IsPinned { get; set; }

    /// <summary>When set to true, Databricks will automatically set single node related custom_tags, spark_conf, and num_workers.</summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary>The kind of compute described by this compute specification.  Possible values (see API docs for full list): CLASSIC_PREVIEW (if corresponding public preview is enabled).</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("library")]
    public IList<V1alpha1ClusterStatusAtProviderLibrary>? Library { get; set; }

    /// <summary>If true, the provider will not wait for the cluster to reach RUNNING state when creating the cluster, allowing cluster creation and library installation to continue asynchronously. Defaults to false (the provider will wait for cluster creation and library installation to succeed).</summary>
    [JsonPropertyName("noWait")]
    public bool? NoWait { get; set; }

    /// <summary>Any supported databricks_node_type id. If instance_pool_id is specified, this field is not needed.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary>Number of worker nodes that this cluster should have. A cluster has one Spark driver and num_workers executors for a total of num_workers + 1 Spark nodes.</summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Identifier of Cluster Policy to validate cluster and preset certain defaults. The primary use for cluster policies is to allow users to create policy-scoped clusters via UI rather than sharing configuration for API-created clusters. For example, when you specify policy_id of external metastore policy, you still have to fill in relevant keys for spark_conf.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("remoteDiskThroughput")]
    public double? RemoteDiskThroughput { get; set; }

    /// <summary>The type of runtime engine to use. If not specified, the runtime engine type is inferred based on the spark_version value. Allowed values include: PHOTON, STANDARD.</summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>The optional user name of the user (or group name if kind if specified) to assign to an interactive cluster. This field is required when using data_security_mode set to SINGLE_USER or AAD Passthrough for Azure Data Lake Storage (ADLS) with a single-user cluster (i.e., not high-concurrency clusters).</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary>Map with key-value pairs to fine-tune Spark clusters, where you can provide custom Spark configuration properties in a cluster configuration.</summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary>Map with environment variable key-value pairs to fine-tune Spark clusters. Key-value pairs of the form (X,Y) are exported (i.e., X='Y') while launching the driver and workers.</summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>Runtime version of the cluster. Any supported databricks_spark_version id.  We advise using Cluster Policies to restrict the list of versions for simplicity while maintaining enough control.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>SSH public key contents that will be added to each Spark node in this cluster. The corresponding private keys can be used to login with the user name ubuntu on port 2200. You can specify up to 10 keys.</summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary>(string) State of the cluster.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalInitialRemoteDiskSize")]
    public double? TotalInitialRemoteDiskSize { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Whenever ML runtime should be selected or not.  Actual runtime is determined by spark_version (DBR release), this field use_ml_runtime, and whether node_type_id is GPU node or not.</summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadType")]
    public IList<V1alpha1ClusterStatusAtProviderWorkloadType>? WorkloadType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusConditions
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

/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterSpec>, IStatus<V1alpha1ClusterStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "clusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterStatus? Status { get; set; }
}