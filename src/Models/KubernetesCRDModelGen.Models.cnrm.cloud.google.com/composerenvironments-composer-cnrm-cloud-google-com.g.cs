using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.composer.cnrm.cloud.google.com;
#nullable enable
/// <summary>ComposerEnvironment is the Schema for the ComposerEnvironment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComposerEnvironmentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ComposerEnvironment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComposerEnvironmentList";
    public const string KubeGroup = "composer.cnrm.cloud.google.com";
    public const string KubePluralName = "composerenvironments";
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
    public IList<V1alpha1ComposerEnvironment> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The retention policy for airflow metadata database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigDataRetentionConfigAirflowMetadataRetentionConfig
{
    /// <summary>Optional. How many days data should be retained for.</summary>
    [JsonPropertyName("retentionDays")]
    public int? RetentionDays { get; set; }

    /// <summary>Optional. Retention can be either enabled or disabled.</summary>
    [JsonPropertyName("retentionMode")]
    public string? RetentionMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration settings for task logs retention</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigDataRetentionConfigTaskLogsRetentionConfig
{
    /// <summary>Optional. The mode of storage for Airflow workers task logs.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration setting for Airflow database data retention mechanism.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigDataRetentionConfig
{
    /// <summary>Optional. The retention policy for airflow metadata database.</summary>
    [JsonPropertyName("airflowMetadataRetentionConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigDataRetentionConfigAirflowMetadataRetentionConfig? AirflowMetadataRetentionConfig { get; set; }

    /// <summary>Optional. The configuration settings for task logs retention</summary>
    [JsonPropertyName("taskLogsRetentionConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigDataRetentionConfigTaskLogsRetentionConfig? TaskLogsRetentionConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration settings for Cloud SQL instance used internally by Apache Airflow software.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigDatabaseConfig
{
    /// <summary>Optional. Cloud SQL machine type used by Airflow database. It has to be one of: db-n1-standard-2, db-n1-standard-4, db-n1-standard-8 or db-n1-standard-16. If not specified, db-n1-standard-2 will be used. Supported for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Optional. The Compute Engine zone where the Airflow database is created. If zone is provided, it must be in the region selected for the environment. If zone is not provided, a zone is automatically selected. The zone can only be set during environment creation. Supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.*.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Customer-managed Encryption Key available through Google's Key Management Service. Cannot be updated. If not specified, Google-managed key will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigEncryptionConfigKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The encryption options for the Cloud Composer environment and its dependencies. Cannot be updated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigEncryptionConfig
{
    /// <summary>Optional. Customer-managed Encryption Key available through Google's Key Management Service. Cannot be updated. If not specified, Google-managed key will be used.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1ComposerEnvironmentSpecConfigEncryptionConfigKmsKeyRef? KmsKeyRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The maintenance window is the period when Cloud Composer  components may undergo maintenance. It is defined so that maintenance is  not executed during peak hours or critical time periods.   The system will not be under maintenance for every occurrence of this  window, but when maintenance is planned, it will be scheduled  during the window.   The maintenance window period must encompass at least 12 hours per week.  This may be split into multiple chunks, each with a size of  at least 4 hours.   If this value is omitted, the default value for maintenance window is  applied. By default, maintenance windows are from 00:00:00 to 04:00:00  (GMT) on Friday, Saturday, and Sunday every week.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigMaintenanceWindow
{
    /// <summary>Required. Maintenance window end time. It is used only to calculate the duration of the maintenance window. The value for end-time must be in the future, relative to `start_time`.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Required. Maintenance window recurrence. Format is a subset of [RFC-5545](https://tools.ietf.org/html/rfc5545) `RRULE`. The only allowed values for `FREQ` field are `FREQ=DAILY` and `FREQ=WEEKLY;BYDAY=...` Example values: `FREQ=WEEKLY;BYDAY=TU,WE`, `FREQ=DAILY`.</summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary>Required. Start time of the first recurrence of the maintenance window.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigMasterAuthorizedNetworksConfigCidrBlocks
{
    /// <summary>CIDR block that must be specified in CIDR notation.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>User-defined name that identifies the CIDR block.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration options for GKE cluster master authorized networks. By default master authorized networks feature is: - in case of private environment: enabled with no external networks allowlisted. - in case of public environment: disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigMasterAuthorizedNetworksConfig
{
    /// <summary>Up to 50 external networks that could access Kubernetes master through HTTPS.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<V1alpha1ComposerEnvironmentSpecConfigMasterAuthorizedNetworksConfigCidrBlocks>? CidrBlocks { get; set; }

    /// <summary>Whether or not master authorized networks feature is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Network Attachment that Cloud Composer environment is connected  to, which provides connectivity with a user's VPC network. Takes precedence  over network and subnetwork settings. If not provided, but network and  subnetwork are defined during environment, it will be provisioned. If not  provided and network and subnetwork are also empty, then connectivity to  user's VPC network is disabled. Network attachment must be provided in  format  projects/{project}/regions/{region}/networkAttachments/{networkAttachment}.   This field is supported for Cloud Composer environments in versions  composer-3.*.*-airflow-*.*.* and newer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigNodeConfigComposerNetworkAttachmentRef
{
    /// <summary>The value of an externally managed ComputeNetworkAttachment resource in the form "projects/{{project}}/regions/{{region}}/networkAttachments/{{name}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetworkAttachment resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetworkAttachment resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration for controlling how IPs are allocated in the GKE cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigNodeConfigIpAllocationPolicy
{
    /// <summary>Optional. The IP address range used to allocate IP addresses to pods in  the GKE cluster.   For Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*,  this field is applicable only when `use_ip_aliases` is true.   Set to blank to have GKE choose a range with the default size.   Set to /netmask (e.g. `/14`) to have GKE choose a range with a specific  netmask.   Set to a  [CIDR](https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing)  notation (e.g. `10.96.0.0/14`) from the RFC-1918 private networks (e.g.  `10.0.0.0/8`, `172.16.0.0/12`, `192.168.0.0/16`) to pick a specific range  to use.</summary>
    [JsonPropertyName("clusterIPV4CIDRBlock")]
    public string? ClusterIPV4CIDRBlock { get; set; }

    /// <summary>Optional. The name of the GKE cluster's secondary range used to allocate  IP addresses to pods.   For Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*,  this field is applicable only when `use_ip_aliases` is true.</summary>
    [JsonPropertyName("clusterSecondaryRangeName")]
    public string? ClusterSecondaryRangeName { get; set; }

    /// <summary>Optional. The IP address range of the services IP addresses in this  GKE cluster.   For Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*,  this field is applicable only when `use_ip_aliases` is true.   Set to blank to have GKE choose a range with the default size.   Set to /netmask (e.g. `/14`) to have GKE choose a range with a specific  netmask.   Set to a  [CIDR](https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing)  notation (e.g. `10.96.0.0/14`) from the RFC-1918 private networks (e.g.  `10.0.0.0/8`, `172.16.0.0/12`, `192.168.0.0/16`) to pick a specific range  to use.</summary>
    [JsonPropertyName("servicesIPV4CIDRBlock")]
    public string? ServicesIPV4CIDRBlock { get; set; }

    /// <summary>Optional. The name of the services' secondary range used to allocate  IP addresses to the GKE cluster.   For Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*,  this field is applicable only when `use_ip_aliases` is true.</summary>
    [JsonPropertyName("servicesSecondaryRangeName")]
    public string? ServicesSecondaryRangeName { get; set; }

    /// <summary>Optional. Whether or not to enable Alias IPs in the GKE cluster.  If `true`, a VPC-native cluster is created.   This field is only supported for Cloud Composer environments in versions  composer-1.*.*-airflow-*.*.*. Environments in newer versions always use  VPC-native GKE clusters.</summary>
    [JsonPropertyName("useIPAliases")]
    public bool? UseIPAliases { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The Compute Engine network to be used for machine  communications, specified as a  [relative resource  name](/apis/design/resource_names#relative_resource_name). For example:  "projects/{projectId}/global/networks/{networkId}".   If unspecified, the "default" network ID in the environment's project is  used. If a [Custom Subnet Network](/vpc/docs/vpc#vpc_networks_and_subnets)  is provided, `nodeConfig.subnetwork` must also be provided. For  [Shared VPC](/vpc/docs/shared-vpc) subnetwork requirements, see  `nodeConfig.subnetwork`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigNodeConfigNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The Google Cloud Platform Service Account to be used by the node VMs. If a service account is not specified, the "default" Compute Engine service account is used. Cannot be updated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigNodeConfigServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The Compute Engine subnetwork to be used for machine  communications, specified as a  [relative resource  name](/apis/design/resource_names#relative_resource_name). For example:  "projects/{projectId}/regions/{regionId}/subnetworks/{subnetworkId}"   If a subnetwork is provided, `nodeConfig.network` must also be provided,  and the subnetwork must belong to the enclosing environment's project and  location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigNodeConfigSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form "projects/{{project}}/regions/{{region}}/subnetworks/{{name}}", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration used for the Kubernetes Engine cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigNodeConfig
{
    /// <summary>Optional. The IP range in CIDR notation to use internally by Cloud  Composer. IP addresses are not reserved - and the same range can be used by  multiple Cloud Composer environments. In case of overlap, IPs from this  range will not be accessible in the user's VPC network. Cannot be updated.  If not specified, the default value of '100.64.128.0/20' is used.   This field is supported for Cloud Composer environments in versions  composer-3.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("composerInternalIPv4CIDRBlock")]
    public string? ComposerInternalIPv4CIDRBlock { get; set; }

    /// <summary>Optional. Network Attachment that Cloud Composer environment is connected  to, which provides connectivity with a user's VPC network. Takes precedence  over network and subnetwork settings. If not provided, but network and  subnetwork are defined during environment, it will be provisioned. If not  provided and network and subnetwork are also empty, then connectivity to  user's VPC network is disabled. Network attachment must be provided in  format  projects/{project}/regions/{region}/networkAttachments/{networkAttachment}.   This field is supported for Cloud Composer environments in versions  composer-3.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("composerNetworkAttachmentRef")]
    public V1alpha1ComposerEnvironmentSpecConfigNodeConfigComposerNetworkAttachmentRef? ComposerNetworkAttachmentRef { get; set; }

    /// <summary>Optional. The disk size in GB used for node VMs. Minimum size is 30GB.  If unspecified, defaults to 100GB. Cannot be updated.   This field is supported for Cloud Composer environments in versions  composer-1.*.*-airflow-*.*.*.</summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Optional. Deploys 'ip-masq-agent' daemon set in the GKE cluster and defines  nonMasqueradeCIDRs equals to pod IP range so IP masquerading is used for  all destination addresses, except between pods traffic.   See:  https://cloud.google.com/kubernetes-engine/docs/how-to/ip-masquerade-agent</summary>
    [JsonPropertyName("enableIPMasqAgent")]
    public bool? EnableIPMasqAgent { get; set; }

    /// <summary>Optional. The configuration for controlling how IPs are allocated in the GKE cluster.</summary>
    [JsonPropertyName("ipAllocationPolicy")]
    public V1alpha1ComposerEnvironmentSpecConfigNodeConfigIpAllocationPolicy? IpAllocationPolicy { get; set; }

    /// <summary>Optional. The Compute Engine [zone](/compute/docs/regions-zones) in which  to deploy the VMs used to run the Apache Airflow software, specified as a  [relative resource  name](/apis/design/resource_names#relative_resource_name). For example:  "projects/{projectId}/zones/{zoneId}".   This `location` must belong to the enclosing environment's project and  location. If both this field and `nodeConfig.machineType` are specified,  `nodeConfig.machineType` must belong to this `location`; if both are  unspecified, the service will pick a zone in the Compute Engine region  corresponding to the Cloud Composer location, and propagate that choice to  both fields. If only one field (`location` or `nodeConfig.machineType`) is  specified, the location information from the specified field will be  propagated to the unspecified field.   This field is supported for Cloud Composer environments in versions  composer-1.*.*-airflow-*.*.*.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. The Compute Engine  [machine type](/compute/docs/machine-types) used for cluster instances,  specified as a  [relative resource  name](/apis/design/resource_names#relative_resource_name). For example:  "projects/{projectId}/zones/{zoneId}/machineTypes/{machineTypeId}".   The `machineType` must belong to the enclosing environment's project and  location. If both this field and `nodeConfig.location` are specified,  this `machineType` must belong to the `nodeConfig.location`; if both are  unspecified, the service will pick a zone in the Compute Engine region  corresponding to the Cloud Composer location, and propagate that choice to  both fields. If exactly one of this field and `nodeConfig.location` is  specified, the location information from the specified field will be  propagated to the unspecified field.   The `machineTypeId` must not be a [shared-core machine  type](/compute/docs/machine-types#sharedcore).   If this field is unspecified, the `machineTypeId` defaults  to "n1-standard-1".   This field is supported for Cloud Composer environments in versions  composer-1.*.*-airflow-*.*.*.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Optional. The Compute Engine network to be used for machine  communications, specified as a  [relative resource  name](/apis/design/resource_names#relative_resource_name). For example:  "projects/{projectId}/global/networks/{networkId}".   If unspecified, the "default" network ID in the environment's project is  used. If a [Custom Subnet Network](/vpc/docs/vpc#vpc_networks_and_subnets)  is provided, `nodeConfig.subnetwork` must also be provided. For  [Shared VPC](/vpc/docs/shared-vpc) subnetwork requirements, see  `nodeConfig.subnetwork`.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1ComposerEnvironmentSpecConfigNodeConfigNetworkRef? NetworkRef { get; set; }

    /// <summary>Optional. The set of Google API scopes to be made available on all  node VMs. If `oauth_scopes` is empty, defaults to  ["https://www.googleapis.com/auth/cloud-platform"]. Cannot be updated.   This field is supported for Cloud Composer environments in versions  composer-1.*.*-airflow-*.*.*.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>Optional. The Google Cloud Platform Service Account to be used by the node VMs. If a service account is not specified, the "default" Compute Engine service account is used. Cannot be updated.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1ComposerEnvironmentSpecConfigNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. The Compute Engine subnetwork to be used for machine  communications, specified as a  [relative resource  name](/apis/design/resource_names#relative_resource_name). For example:  "projects/{projectId}/regions/{regionId}/subnetworks/{subnetworkId}"   If a subnetwork is provided, `nodeConfig.network` must also be provided,  and the subnetwork must belong to the enclosing environment's project and  location.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1alpha1ComposerEnvironmentSpecConfigNodeConfigSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Optional. The list of instance tags applied to all node VMs. Tags are used to identify valid sources or targets for network firewalls. Each tag within the list must comply with [RFC1035](https://www.ietf.org/rfc/rfc1035.txt). Cannot be updated.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. When specified, the environment will use Private Service Connect instead of VPC peerings to connect to Cloud SQL in the Tenant Project, and the PSC endpoint in the Customer Project will use an IP address from this subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigPrivateEnvironmentConfigCloudComposerConnectionSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form "projects/{{project}}/regions/{{region}}/subnetworks/{{name}}", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration for the network connections configuration in the environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigPrivateEnvironmentConfigNetworkingConfig
{
    /// <summary>Optional. Indicates the user requested specifc connection type between Tenant and Customer projects. You cannot set networking connection type in public IP environment.</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration for the private GKE cluster for a Private IP Cloud Composer environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigPrivateEnvironmentConfigPrivateClusterConfig
{
    /// <summary>Optional. If `true`, access to the public endpoint of the GKE cluster is denied.</summary>
    [JsonPropertyName("enablePrivateEndpoint")]
    public bool? EnablePrivateEndpoint { get; set; }

    /// <summary>Optional. The CIDR block from which IPv4 range for GKE master will be reserved. If left blank, the default value of '172.16.0.0/23' is used.</summary>
    [JsonPropertyName("masterIPV4CIDRBlock")]
    public string? MasterIPV4CIDRBlock { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration used for the Private IP Cloud Composer environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigPrivateEnvironmentConfig
{
    /// <summary>Optional. When specified, the environment will use Private Service Connect instead of VPC peerings to connect to Cloud SQL in the Tenant Project, and the PSC endpoint in the Customer Project will use an IP address from this subnetwork.</summary>
    [JsonPropertyName("cloudComposerConnectionSubnetworkRef")]
    public V1alpha1ComposerEnvironmentSpecConfigPrivateEnvironmentConfigCloudComposerConnectionSubnetworkRef? CloudComposerConnectionSubnetworkRef { get; set; }

    /// <summary>Optional. The CIDR block from which IP range for Cloud Composer Network in  tenant project will be reserved. Needs to be disjoint from  private_cluster_config.master_ipv4_cidr_block and  cloud_sql_ipv4_cidr_block.   This field is supported for Cloud Composer environments in versions  composer-2.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("cloudComposerNetworkIPv4CIDRBlock")]
    public string? CloudComposerNetworkIPv4CIDRBlock { get; set; }

    /// <summary>Optional. The CIDR block from which IP range in tenant project will be reserved for Cloud SQL. Needs to be disjoint from `web_server_ipv4_cidr_block`.</summary>
    [JsonPropertyName("cloudSQLIPv4CIDRBlock")]
    public string? CloudSQLIPv4CIDRBlock { get; set; }

    /// <summary>Optional. If `true`, builds performed during operations that install Python  packages have only private connectivity to Google services (including  Artifact Registry) and VPC network (if either `NodeConfig.network` and  `NodeConfig.subnetwork` fields or `NodeConfig.composer_network_attachment`  field are specified). If `false`, the builds also have access to the  internet.   This field is supported for Cloud Composer environments in versions  composer-3.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("enablePrivateBuildsOnly")]
    public bool? EnablePrivateBuildsOnly { get; set; }

    /// <summary>Optional. If `true`, a Private IP Cloud Composer environment is created. If this field is set to true, `IPAllocationPolicy.use_ip_aliases` must be set to true for Cloud Composer environments in versions composer-1.*.*-airflow-*.*.*.</summary>
    [JsonPropertyName("enablePrivateEnvironment")]
    public bool? EnablePrivateEnvironment { get; set; }

    /// <summary>Optional. When enabled, IPs from public (non-RFC1918) ranges can be used for `IPAllocationPolicy.cluster_ipv4_cidr_block` and `IPAllocationPolicy.service_ipv4_cidr_block`.</summary>
    [JsonPropertyName("enablePrivatelyUsedPublicIPs")]
    public bool? EnablePrivatelyUsedPublicIPs { get; set; }

    /// <summary>Optional. Configuration for the network connections configuration in the environment.</summary>
    [JsonPropertyName("networkingConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigPrivateEnvironmentConfigNetworkingConfig? NetworkingConfig { get; set; }

    /// <summary>Optional. Configuration for the private GKE cluster for a Private IP Cloud Composer environment.</summary>
    [JsonPropertyName("privateClusterConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigPrivateEnvironmentConfigPrivateClusterConfig? PrivateClusterConfig { get; set; }

    /// <summary>Optional. The CIDR block from which IP range for web server will be  reserved. Needs to be disjoint from  `private_cluster_config.master_ipv4_cidr_block` and  `cloud_sql_ipv4_cidr_block`.   This field is supported for Cloud Composer environments in versions  composer-1.*.*-airflow-*.*.*.</summary>
    [JsonPropertyName("webServerIPv4CIDRBlock")]
    public string? WebServerIPv4CIDRBlock { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration for scheduled snapshot creation mechanism.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigRecoveryConfigScheduledSnapshotsConfig
{
    /// <summary>Optional. Whether scheduled snapshots creation is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Optional. The cron expression representing the time when snapshots creation mechanism runs. This field is subject to additional validation around frequency of execution.</summary>
    [JsonPropertyName("snapshotCreationSchedule")]
    public string? SnapshotCreationSchedule { get; set; }

    /// <summary>Optional. The Cloud Storage location for storing automatically created snapshots.</summary>
    [JsonPropertyName("snapshotLocation")]
    public string? SnapshotLocation { get; set; }

    /// <summary>Optional. Time zone that sets the context to interpret snapshot_creation_schedule.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The Recovery settings configuration of an environment.   This field is supported for Cloud Composer environments in versions  composer-2.*.*-airflow-*.*.* and newer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigRecoveryConfig
{
    /// <summary>Optional. The configuration for scheduled snapshot creation mechanism.</summary>
    [JsonPropertyName("scheduledSnapshotsConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigRecoveryConfigScheduledSnapshotsConfig? ScheduledSnapshotsConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration for Cloud Data Lineage integration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigSoftwareConfigCloudDataLineageIntegration
{
    /// <summary>Optional. Whether or not Cloud Data Lineage integration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration settings for software inside the environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigSoftwareConfig
{
    /// <summary>Optional. Apache Airflow configuration properties to override.   Property keys contain the section and property names, separated by a  hyphen, for example "core-dags_are_paused_at_creation". Section names must  not contain hyphens ("-"), opening square brackets ("["),  or closing  square brackets ("]"). The property name must not be empty and must not  contain an equals sign ("=") or semicolon (";"). Section and property names  must not contain a period ("."). Apache Airflow configuration property  names must be written in  [snake_case](https://en.wikipedia.org/wiki/Snake_case). Property values can  contain any character, and can be written in any lower/upper case format.   Certain Apache Airflow configuration property values are  [blocked](/composer/docs/concepts/airflow-configurations),  and cannot be overridden.</summary>
    [JsonPropertyName("airflowConfigOverrides")]
    public IDictionary<string, string>? AirflowConfigOverrides { get; set; }

    /// <summary>Optional. The configuration for Cloud Data Lineage integration.</summary>
    [JsonPropertyName("cloudDataLineageIntegration")]
    public V1alpha1ComposerEnvironmentSpecConfigSoftwareConfigCloudDataLineageIntegration? CloudDataLineageIntegration { get; set; }

    /// <summary>Optional. Additional environment variables to provide to the Apache Airflow  scheduler, worker, and webserver processes.   Environment variable names must match the regular expression  `[a-zA-Z_][a-zA-Z0-9_]*`. They cannot specify Apache Airflow  software configuration overrides (they cannot match the regular expression  `AIRFLOW__[A-Z0-9_]+__[A-Z0-9_]+`), and they cannot match any of the  following reserved names:   * `AIRFLOW_HOME`  * `C_FORCE_ROOT`  * `CONTAINER_NAME`  * `DAGS_FOLDER`  * `GCP_PROJECT`  * `GCS_BUCKET`  * `GKE_CLUSTER_NAME`  * `SQL_DATABASE`  * `SQL_INSTANCE`  * `SQL_PASSWORD`  * `SQL_PROJECT`  * `SQL_REGION`  * `SQL_USER`</summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary>Optional. The version of the software running in the environment.  This encapsulates both the version of Cloud Composer functionality and the  version of Apache Airflow. It must match the regular expression  `composer-([0-9]+(\.[0-9]+\.[0-9]+(-preview\.[0-9]+)?)?|latest)-airflow-([0-9]+(\.[0-9]+(\.[0-9]+)?)?)`.  When used as input, the server also checks if the provided version is  supported and denies the request for an unsupported version.   The Cloud Composer portion of the image version is a full  [semantic version](https://semver.org), or an alias in the form of major  version number or `latest`. When an alias is provided, the server replaces  it with the current Cloud Composer version that satisfies the alias.   The Apache Airflow portion of the image version is a full semantic version  that points to one of the supported Apache Airflow versions, or an alias in  the form of only major or major.minor versions specified. When an alias is  provided, the server replaces it with the latest Apache Airflow version  that satisfies the alias and is supported in the given Cloud Composer  version.   In all cases, the resolved image version is stored in the same field.   See also [version  list](/composer/docs/concepts/versioning/composer-versions) and [versioning  overview](/composer/docs/concepts/versioning/composer-versioning-overview).</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>Optional. Custom Python Package Index (PyPI) packages to be installed in  the environment.   Keys refer to the lowercase package name such as "numpy"  and values are the lowercase extras and version specifier such as  "==1.12.0", "[devel,gcp_api]", or "[devel]&gt;=1.8.2, &lt;1.9.2". To specify a  package without pinning it to a version specifier, use the empty string as  the value.</summary>
    [JsonPropertyName("pypiPackages")]
    public IDictionary<string, string>? PypiPackages { get; set; }

    /// <summary>Optional. The major version of Python used to run the Apache Airflow  scheduler, worker, and webserver processes.   Can be set to '2' or '3'. If not specified, the default is '3'. Cannot be  updated.   This field is only supported for Cloud Composer environments in versions  composer-1.*.*-airflow-*.*.*. Environments in newer versions always use  Python major version 3.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>Optional. The number of schedulers for Airflow.   This field is supported for Cloud Composer environments in versions  composer-1.*.*-airflow-2.*.*.</summary>
    [JsonPropertyName("schedulerCount")]
    public int? SchedulerCount { get; set; }

    /// <summary>Optional. Whether or not the web server uses custom plugins.  If unspecified, the field defaults to `PLUGINS_ENABLED`.   This field is supported for Cloud Composer environments in versions  composer-3.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("webServerPluginsMode")]
    public string? WebServerPluginsMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration settings for the Airflow web server App Engine instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigWebServerConfig
{
    /// <summary>Optional. Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. If not specified, composer-n1-webserver-2 will be used. Value custom is returned only in response, if Airflow web server parameters were manually changed to a non-standard values.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigWebServerNetworkAccessControlAllowedIPRanges
{
    /// <summary>Optional. User-provided description. It must contain at most 300 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>IP address or range, defined using CIDR notation, of requests that this  rule applies to.  Examples: `192.168.1.1` or `192.168.0.0/16` or `2001:db8::/32`            or `2001:0db8:0000:0042:0000:8a2e:0370:7334`.   IP range prefixes should be properly truncated. For example,  `1.2.3.4/24` should be truncated to `1.2.3.0/24`. Similarly, for IPv6,  `2001:db8::1/32` should be truncated to `2001:db8::/32`.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The network-level access control policy for the Airflow web server. If unspecified, no network-level access restrictions will be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigWebServerNetworkAccessControl
{
    /// <summary>A collection of allowed IP ranges with descriptions.</summary>
    [JsonPropertyName("allowedIPRanges")]
    public IList<V1alpha1ComposerEnvironmentSpecConfigWebServerNetworkAccessControlAllowedIPRanges>? AllowedIPRanges { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Resources used by Airflow DAG processors.   This field is supported for Cloud Composer environments in versions  composer-3.*.*-airflow-*.*.* and newer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfigDagProcessor
{
    /// <summary>Optional. The number of DAG processors. If not provided or set to 0, a single DAG processor instance will be created.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Optional. CPU request and limit for a single Airflow DAG processor replica.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Optional. Memory (GB) request and limit for a single Airflow DAG processor replica.</summary>
    [JsonPropertyName("memoryGB")]
    public string? MemoryGB { get; set; }

    /// <summary>Optional. Storage (GB) request and limit for a single Airflow DAG processor replica.</summary>
    [JsonPropertyName("storageGB")]
    public string? StorageGB { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Resources used by Airflow schedulers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfigScheduler
{
    /// <summary>Optional. The number of schedulers.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Optional. CPU request and limit for a single Airflow scheduler replica.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Optional. Memory (GB) request and limit for a single Airflow scheduler replica.</summary>
    [JsonPropertyName("memoryGB")]
    public string? MemoryGB { get; set; }

    /// <summary>Optional. Storage (GB) request and limit for a single Airflow scheduler replica.</summary>
    [JsonPropertyName("storageGB")]
    public string? StorageGB { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Resources used by Airflow triggerers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfigTriggerer
{
    /// <summary>Optional. The number of triggerers.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Optional. CPU request and limit for a single Airflow triggerer replica.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Optional. Memory (GB) request and limit for a single Airflow triggerer replica.</summary>
    [JsonPropertyName("memoryGB")]
    public string? MemoryGB { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Resources used by Airflow web server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfigWebServer
{
    /// <summary>Optional. CPU request and limit for Airflow web server.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Optional. Memory (GB) request and limit for Airflow web server.</summary>
    [JsonPropertyName("memoryGB")]
    public string? MemoryGB { get; set; }

    /// <summary>Optional. Storage (GB) request and limit for Airflow web server.</summary>
    [JsonPropertyName("storageGB")]
    public string? StorageGB { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Resources used by Airflow workers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfigWorker
{
    /// <summary>Optional. CPU request and limit for a single Airflow worker replica.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Optional. Maximum number of workers for autoscaling.</summary>
    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    /// <summary>Optional. Memory (GB) request and limit for a single Airflow worker replica.</summary>
    [JsonPropertyName("memoryGB")]
    public string? MemoryGB { get; set; }

    /// <summary>Optional. Minimum number of workers for autoscaling.</summary>
    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    /// <summary>Optional. Storage (GB) request and limit for a single Airflow worker replica.</summary>
    [JsonPropertyName("storageGB")]
    public string? StorageGB { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The workloads configuration settings for the GKE cluster  associated with the Cloud Composer environment. The GKE cluster runs  Airflow scheduler, web server and workers workloads.   This field is supported for Cloud Composer environments in versions  composer-2.*.*-airflow-*.*.* and newer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfig
{
    /// <summary>Optional. Resources used by Airflow DAG processors.   This field is supported for Cloud Composer environments in versions  composer-3.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("dagProcessor")]
    public V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfigDagProcessor? DagProcessor { get; set; }

    /// <summary>Optional. Resources used by Airflow schedulers.</summary>
    [JsonPropertyName("scheduler")]
    public V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfigScheduler? Scheduler { get; set; }

    /// <summary>Optional. Resources used by Airflow triggerers.</summary>
    [JsonPropertyName("triggerer")]
    public V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfigTriggerer? Triggerer { get; set; }

    /// <summary>Optional. Resources used by Airflow web server.</summary>
    [JsonPropertyName("webServer")]
    public V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfigWebServer? WebServer { get; set; }

    /// <summary>Optional. Resources used by Airflow workers.</summary>
    [JsonPropertyName("worker")]
    public V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfigWorker? Worker { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration parameters for this environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecConfig
{
    /// <summary>Optional. The configuration setting for Airflow database data retention mechanism.</summary>
    [JsonPropertyName("dataRetentionConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigDataRetentionConfig? DataRetentionConfig { get; set; }

    /// <summary>Optional. The configuration settings for Cloud SQL instance used internally by Apache Airflow software.</summary>
    [JsonPropertyName("databaseConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigDatabaseConfig? DatabaseConfig { get; set; }

    /// <summary>Optional. The encryption options for the Cloud Composer environment and its dependencies. Cannot be updated.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Optional. The size of the Cloud Composer environment.   This field is supported for Cloud Composer environments in versions  composer-2.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("environmentSize")]
    public string? EnvironmentSize { get; set; }

    /// <summary>Optional. The maintenance window is the period when Cloud Composer  components may undergo maintenance. It is defined so that maintenance is  not executed during peak hours or critical time periods.   The system will not be under maintenance for every occurrence of this  window, but when maintenance is planned, it will be scheduled  during the window.   The maintenance window period must encompass at least 12 hours per week.  This may be split into multiple chunks, each with a size of  at least 4 hours.   If this value is omitted, the default value for maintenance window is  applied. By default, maintenance windows are from 00:00:00 to 04:00:00  (GMT) on Friday, Saturday, and Sunday every week.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1alpha1ComposerEnvironmentSpecConfigMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>Optional. The configuration options for GKE cluster master authorized networks. By default master authorized networks feature is: - in case of private environment: enabled with no external networks allowlisted. - in case of public environment: disabled.</summary>
    [JsonPropertyName("masterAuthorizedNetworksConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigMasterAuthorizedNetworksConfig? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>Optional. The configuration used for the Kubernetes Engine cluster.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigNodeConfig? NodeConfig { get; set; }

    /// <summary>The number of nodes in the Kubernetes Engine cluster that will be  used to run this environment.   This field is supported for Cloud Composer environments in versions  composer-1.*.*-airflow-*.*.*.</summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary>Optional. The configuration used for the Private IP Cloud Composer environment.</summary>
    [JsonPropertyName("privateEnvironmentConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigPrivateEnvironmentConfig? PrivateEnvironmentConfig { get; set; }

    /// <summary>Optional. The Recovery settings configuration of an environment.   This field is supported for Cloud Composer environments in versions  composer-2.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("recoveryConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigRecoveryConfig? RecoveryConfig { get; set; }

    /// <summary>Optional. Resilience mode of the Cloud Composer Environment.   This field is supported for Cloud Composer environments in versions  composer-2.2.0-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("resilienceMode")]
    public string? ResilienceMode { get; set; }

    /// <summary>Optional. The configuration settings for software inside the environment.</summary>
    [JsonPropertyName("softwareConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigSoftwareConfig? SoftwareConfig { get; set; }

    /// <summary>Optional. The configuration settings for the Airflow web server App Engine instance.</summary>
    [JsonPropertyName("webServerConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigWebServerConfig? WebServerConfig { get; set; }

    /// <summary>Optional. The network-level access control policy for the Airflow web server. If unspecified, no network-level access restrictions will be applied.</summary>
    [JsonPropertyName("webServerNetworkAccessControl")]
    public V1alpha1ComposerEnvironmentSpecConfigWebServerNetworkAccessControl? WebServerNetworkAccessControl { get; set; }

    /// <summary>Optional. The workloads configuration settings for the GKE cluster  associated with the Cloud Composer environment. The GKE cluster runs  Airflow scheduler, web server and workers workloads.   This field is supported for Cloud Composer environments in versions  composer-2.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("workloadsConfig")]
    public V1alpha1ComposerEnvironmentSpecConfigWorkloadsConfig? WorkloadsConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The name of the Cloud Storage bucket used by the environment. No `gs://` prefix.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecStorageConfigBucketRef
{
    /// <summary>The StorageBucket selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Storage configuration for this environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpecStorageConfig
{
    /// <summary>Optional. The name of the Cloud Storage bucket used by the environment. No `gs://` prefix.</summary>
    [JsonPropertyName("bucketRef")]
    public V1alpha1ComposerEnvironmentSpecStorageConfigBucketRef? BucketRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ComposerEnvironmentSpec defines the desired state of ComposerEnvironment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentSpec
{
    /// <summary>Optional. Configuration parameters for this environment.</summary>
    [JsonPropertyName("config")]
    public V1alpha1ComposerEnvironmentSpecConfig? Config { get; set; }

    /// <summary>Optional. User-defined labels for this environment.  The labels map can contain no more than 64 entries. Entries of the labels  map are UTF8 strings that comply with the following restrictions:   * Keys must conform to regexp: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}  * Values must conform to regexp:  [\p{Ll}\p{Lo}\p{N}_-]{0,63}  * Both keys and values are additionally constrained to be &lt;= 128 bytes in  size.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. The name of the location where the Environment will be created. Required.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ComposerEnvironmentSpecProjectRef ProjectRef { get; set; }

    /// <summary>The ComposerEnvironment name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Storage configuration for this environment.</summary>
    [JsonPropertyName("storageConfig")]
    public V1alpha1ComposerEnvironmentSpecStorageConfig? StorageConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration for the private GKE cluster for a Private IP Cloud Composer environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentStatusObservedStateConfigPrivateEnvironmentConfigPrivateClusterConfig
{
    /// <summary>Output only. The IP range in CIDR notation to use for the hosted master network. This range is used for assigning internal IP addresses to the GKE cluster master or set of masters and to the internal load balancer virtual IP. This range must not overlap with any other ranges in use within the cluster's network.</summary>
    [JsonPropertyName("masterIPV4ReservedRange")]
    public string? MasterIPV4ReservedRange { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. The configuration used for the Private IP Cloud Composer environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentStatusObservedStateConfigPrivateEnvironmentConfig
{
    /// <summary>Output only. The IP range reserved for the tenant project's Cloud Composer  network.   This field is supported for Cloud Composer environments in versions  composer-2.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("cloudComposerNetworkIPv4ReservedRange")]
    public string? CloudComposerNetworkIPv4ReservedRange { get; set; }

    /// <summary>Optional. Configuration for the private GKE cluster for a Private IP Cloud Composer environment.</summary>
    [JsonPropertyName("privateClusterConfig")]
    public V1alpha1ComposerEnvironmentStatusObservedStateConfigPrivateEnvironmentConfigPrivateClusterConfig? PrivateClusterConfig { get; set; }

    /// <summary>Output only. The IP range reserved for the tenant project's App Engine VMs.   This field is supported for Cloud Composer environments in versions  composer-1.*.*-airflow-*.*.*.</summary>
    [JsonPropertyName("webServerIPv4ReservedRange")]
    public string? WebServerIPv4ReservedRange { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Configuration parameters for this environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentStatusObservedStateConfig
{
    /// <summary>Output only. The 'bring your own identity' variant of the URI of the Apache Airflow Web UI hosted within this environment, to be accessed with external identities using workforce identity federation (see [Access environments with workforce identity federation](/composer/docs/composer-2/access-environments-with-workforce-identity-federation)).</summary>
    [JsonPropertyName("airflowBYOIDURI")]
    public string? AirflowBYOIDURI { get; set; }

    /// <summary>Output only. The URI of the Apache Airflow Web UI hosted within this environment (see [Airflow web interface](/composer/docs/how-to/accessing/airflow-web-interface)).</summary>
    [JsonPropertyName("airflowURI")]
    public string? AirflowURI { get; set; }

    /// <summary>Output only. The Cloud Storage prefix of the DAGs for this environment. Although Cloud Storage objects reside in a flat namespace, a hierarchical file tree can be simulated using "/"-delimited object name prefixes. DAG objects for this environment reside in a simulated directory with the given prefix.</summary>
    [JsonPropertyName("dagGCSPrefix")]
    public string? DagGCSPrefix { get; set; }

    /// <summary>Output only. The Kubernetes Engine cluster used to run this environment.</summary>
    [JsonPropertyName("gkeCluster")]
    public string? GkeCluster { get; set; }

    /// <summary>Optional. The configuration used for the Private IP Cloud Composer environment.</summary>
    [JsonPropertyName("privateEnvironmentConfig")]
    public V1alpha1ComposerEnvironmentStatusObservedStateConfigPrivateEnvironmentConfig? PrivateEnvironmentConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentStatusObservedState
{
    /// <summary>Optional. Configuration parameters for this environment.</summary>
    [JsonPropertyName("config")]
    public V1alpha1ComposerEnvironmentStatusObservedStateConfig? Config { get; set; }

    /// <summary>Output only. The time at which this environment was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The current state of the environment.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The time at which this environment was last modified.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The UUID (Universally Unique IDentifier) associated with this environment. This value is generated when the environment is created.</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ComposerEnvironmentStatus defines the config connector machine state of ComposerEnvironment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComposerEnvironmentStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComposerEnvironmentStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ComposerEnvironment resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ComposerEnvironmentStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ComposerEnvironment is the Schema for the ComposerEnvironment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComposerEnvironment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComposerEnvironmentSpec>, IStatus<V1alpha1ComposerEnvironmentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComposerEnvironment";
    public const string KubeGroup = "composer.cnrm.cloud.google.com";
    public const string KubePluralName = "composerenvironments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComposerEnvironmentSpec defines the desired state of ComposerEnvironment</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ComposerEnvironmentSpec Spec { get; set; }

    /// <summary>ComposerEnvironmentStatus defines the config connector machine state of ComposerEnvironment</summary>
    [JsonPropertyName("status")]
    public V1alpha1ComposerEnvironmentStatus? Status { get; set; }
}
#nullable disable
