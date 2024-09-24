using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.composer.gcp.upbound.io;
public enum V1beta1EnvironmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1EnvironmentSpecForProviderConfigDataRetentionConfigTaskLogsRetentionConfig
{
    /// <summary>The mode of storage for Airflow workers task logs. Values for storage mode are CLOUD_LOGGING_ONLY to only store logs in cloud logging and CLOUD_LOGGING_AND_CLOUD_STORAGE to store logs in cloud logging and cloud storage.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigDataRetentionConfig
{
    /// <summary>The configuration setting for Task Logs. Structure is documented below.</summary>
    [JsonPropertyName("taskLogsRetentionConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigDataRetentionConfigTaskLogsRetentionConfig>? TaskLogsRetentionConfig { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigDatabaseConfig
{
    /// <summary>Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. Value custom is returned only in response, if Airflow web server parameters were manually changed to a non-standard values.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The Compute Engine zone in which to deploy the VMs running the Apache Airflow software, specified as the zone name or relative resource name (e.g. "projects/{project}/zones/{zone}"). Must belong to the enclosing environment's project and region.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigEncryptionConfig
{
    /// <summary>Customer-managed Encryption Key available through Google's Key Management Service. It must be the fully qualified resource name, i.e. projects/project-id/locations/location/keyRings/keyring/cryptoKeys/key. Cannot be updated.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigMaintenanceWindow
{
    /// <summary>Maintenance window end time. It is used only to calculate the duration of the maintenance window. The value for end-time must be in the future, relative to 'start_time'.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Maintenance window recurrence. Format is a subset of RFC-5545 (https://tools.ietf.org/html/rfc5545) 'RRULE'. The only allowed values for 'FREQ' field are 'FREQ=DAILY' and 'FREQ=WEEKLY;BYDAY=...'. Example values: 'FREQ=WEEKLY;BYDAY=TU,WE', 'FREQ=DAILY'.</summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary>Start time of the first recurrence of the maintenance window.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigMasterAuthorizedNetworksConfigCidrBlocks
{
    /// <summary>cidr_block must be specified in CIDR notation.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>display_name is a field for users to identify CIDR blocks.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigMasterAuthorizedNetworksConfig
{
    /// <summary>cidr_blocks define up to 50 external networks that could access Kubernetes master through HTTPS. Structure is documented below.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<V1beta1EnvironmentSpecForProviderConfigMasterAuthorizedNetworksConfigCidrBlocks>? CidrBlocks { get; set; }

    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigIpAllocationPolicy
{
    /// <summary>The IP address range used to allocate IP addresses to pods in the cluster. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true. Set to blank to have GKE choose a range with the default size. Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use. Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both.</summary>
    [JsonPropertyName("clusterIpv4CidrBlock")]
    public string? ClusterIpv4CidrBlock { get; set; }

    /// <summary>The name of the cluster's secondary range used to allocate IP addresses to pods. Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.</summary>
    [JsonPropertyName("clusterSecondaryRangeName")]
    public string? ClusterSecondaryRangeName { get; set; }

    /// <summary>The IP address range used to allocate IP addresses in this cluster. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true. Set to blank to have GKE choose a range with the default size. Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use. Specify either services_secondary_range_name or services_ipv4_cidr_block but not both.</summary>
    [JsonPropertyName("servicesIpv4CidrBlock")]
    public string? ServicesIpv4CidrBlock { get; set; }

    /// <summary>The name of the services' secondary range used to allocate IP addresses to the cluster. Specify either services_secondary_range_name or services_ipv4_cidr_block but not both. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.</summary>
    [JsonPropertyName("servicesSecondaryRangeName")]
    public string? ServicesSecondaryRangeName { get; set; }

    /// <summary>Whether or not to enable Alias IPs in the GKE cluster. If true, a VPC-native cluster is created. Defaults to true if the ip_allocation_policy block is present in config.</summary>
    [JsonPropertyName("useIpAliases")]
    public bool? UseIpAliases { get; set; }
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigNodeConfig
{
    /// <summary>The disk size in GB used for node VMs. Minimum size is 20GB. If unspecified, defaults to 100GB. Cannot be updated.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Deploys 'ip-masq-agent' daemon set in the GKE cluster and defines nonMasqueradeCIDRs equals to pod IP range so IP masquerading is used for all destination addresses, except between pods traffic. See the documentation.</summary>
    [JsonPropertyName("enableIpMasqAgent")]
    public bool? EnableIpMasqAgent { get; set; }

    /// <summary>Configuration for controlling how IPs are allocated in the GKE cluster. Structure is documented below. Cannot be updated.</summary>
    [JsonPropertyName("ipAllocationPolicy")]
    public IList<V1beta1EnvironmentSpecForProviderConfigNodeConfigIpAllocationPolicy>? IpAllocationPolicy { get; set; }

    /// <summary>Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. Value custom is returned only in response, if Airflow web server parameters were manually changed to a non-standard values.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications, specified as a self-link, relative resource name (for example "projects/{project}/global/networks/{network}"), by name.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The set of Google API scopes to be made available on all node VMs. Cannot be updated. If empty, defaults to ["https://www.googleapis.com/auth/cloud-platform"].</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>The Google Cloud Platform Service Account to be used by the node VMs. If a service account is not specified, the "default" Compute Engine service account is used. Cannot be updated. If given, note that the service account must have roles/composer.worker for any GCP resources created under the Cloud Composer Environment.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications, specified as a self-link, relative resource name (for example, "projects/{project}/regions/{region}/subnetworks/{subnetwork}"), or by name. If subnetwork is provided, network must also be provided and the subnetwork must belong to the enclosing environment's project and region.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelector? SubnetworkSelector { get; set; }

    /// <summary>The list of instance tags applied to all node VMs. Tags are used to identify valid sources or targets for network firewalls. Each tag within the list must comply with RFC1035. Cannot be updated.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The Compute Engine zone in which to deploy the VMs running the Apache Airflow software, specified as the zone name or relative resource name (e.g. "projects/{project}/zones/{zone}"). Must belong to the enclosing environment's project and region.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigPrivateEnvironmentConfig
{
    /// <summary>When specified, the environment will use Private Service Connect instead of VPC peerings to connect to Cloud SQL in the Tenant Project, and the PSC endpoint in the Customer Project will use an IP address from this subnetwork. This field is supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("cloudComposerConnectionSubnetwork")]
    public string? CloudComposerConnectionSubnetwork { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudComposerNetworkIpv4CidrBlock")]
    public string? CloudComposerNetworkIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range in tenant project will be reserved for Cloud SQL. Needs to be disjoint from web_server_ipv4_cidr_block</summary>
    [JsonPropertyName("cloudSqlIpv4CidrBlock")]
    public string? CloudSqlIpv4CidrBlock { get; set; }

    /// <summary>Mode of internal communication within the Composer environment. Must be one of "VPC_PEERING" or "PRIVATE_SERVICE_CONNECT".</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>If true, access to the public endpoint of the GKE cluster is denied. If this field is set to true, the ip_allocation_policy.use_ip_aliases field must also be set to true for Cloud Composer 1 environments.</summary>
    [JsonPropertyName("enablePrivateEndpoint")]
    public bool? EnablePrivateEndpoint { get; set; }

    /// <summary>When enabled, IPs from public (non-RFC1918) ranges can be used for ip_allocation_policy.cluster_ipv4_cidr_block and ip_allocation_policy.service_ipv4_cidr_block.</summary>
    [JsonPropertyName("enablePrivatelyUsedPublicIps")]
    public bool? EnablePrivatelyUsedPublicIps { get; set; }

    /// <summary>The IP range in CIDR notation to use for the hosted master network. This range is used for assigning internal IP addresses to the cluster master or set of masters and to the internal load balancer virtual IP. This range must not overlap with any other ranges in use within the cluster's network. If left blank, the default value of is used. See documentation for default values per region.</summary>
    [JsonPropertyName("masterIpv4CidrBlock")]
    public string? MasterIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range for web server will be reserved. Needs to be disjoint from master_ipv4_cidr_block and cloud_sql_ipv4_cidr_block.</summary>
    [JsonPropertyName("webServerIpv4CidrBlock")]
    public string? WebServerIpv4CidrBlock { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigRecoveryConfigScheduledSnapshotsConfig
{
    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Snapshot schedule, in the unix-cron format.</summary>
    [JsonPropertyName("snapshotCreationSchedule")]
    public string? SnapshotCreationSchedule { get; set; }

    /// <summary>The URI of a bucket folder where to save the snapshot.</summary>
    [JsonPropertyName("snapshotLocation")]
    public string? SnapshotLocation { get; set; }

    /// <summary>A time zone for the schedule. This value is a time offset and does not take into account daylight saving time changes. Valid values are from UTC-12 to UTC+12. Examples: UTC, UTC-01, UTC+03.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigRecoveryConfig
{
    /// <summary>The recovery configuration settings for the Cloud Composer environment.</summary>
    [JsonPropertyName("scheduledSnapshotsConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigRecoveryConfigScheduledSnapshotsConfig>? ScheduledSnapshotsConfig { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigSoftwareConfig
{
    /// <summary>Apache Airflow configuration properties to override. Property keys contain the section and property names, separated by a hyphen, for example "core-dags_are_paused_at_creation".</summary>
    [JsonPropertyName("airflowConfigOverrides")]
    public IDictionary<string, string>? AirflowConfigOverrides { get; set; }

    /// <summary>Additional environment variables to provide to the Apache Airflow scheduler, worker, and webserver processes. Environment variable names must match the regular expression [a-zA-Z_][a-zA-Z0-9_]*. They cannot specify Apache Airflow software configuration overrides (they cannot match the regular expression AIRFLOW__[A-Z0-9_]+__[A-Z0-9_]+), and they cannot match any of the following reserved names:</summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>Custom Python Package Index (PyPI) packages to be installed in the environment. Keys refer to the lowercase package name (e.g. "numpy"). Values are the lowercase extras and version specifier (e.g. "==1.12.0", "[devel,gcp_api]", "[devel]&gt;=1.8.2, &lt;1.9.2"). To specify a package without pinning it to a version specifier, use the empty string as the value.</summary>
    [JsonPropertyName("pypiPackages")]
    public IDictionary<string, string>? PypiPackages { get; set; }

    /// <summary>The major version of Python used to run the Apache Airflow scheduler, worker, and webserver processes. Can be set to '2' or '3'. If not specified, the default is '3'.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The number of schedulers for Airflow.</summary>
    [JsonPropertyName("schedulerCount")]
    public double? SchedulerCount { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigWebServerConfig
{
    /// <summary>Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. Value custom is returned only in response, if Airflow web server parameters were manually changed to a non-standard values.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigWebServerNetworkAccessControlAllowedIpRange
{
    /// <summary>A description of this ip range.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>IP address or range, defined using CIDR notation, of requests that this rule applies to. Examples: 192.168.1.1 or 192.168.0.0/16 or 2001:db8::/32 or 2001:0db8:0000:0042:0000:8a2e:0370:7334. IP range prefixes should be properly truncated. For example, 1.2.3.4/24 should be truncated to 1.2.3.0/24. Similarly, for IPv6, 2001:db8::1/32 should be truncated to 2001:db8::/32.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigWebServerNetworkAccessControl
{
    /// <summary>A collection of allowed IP ranges with descriptions. Structure is documented below.</summary>
    [JsonPropertyName("allowedIpRange")]
    public IList<V1beta1EnvironmentSpecForProviderConfigWebServerNetworkAccessControlAllowedIpRange>? AllowedIpRange { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigWorkloadsConfigScheduler
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for the Airflow web server.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigWorkloadsConfigTriggerer
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigWorkloadsConfigWebServer
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for the Airflow web server.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigWorkloadsConfigWorker
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The maximum number of Airflow workers that the environment can run. The number of workers in the environment does not go above this number, even if a higher number of workers is required to handle the load.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The minimum number of Airflow workers that the environment can run. The number of workers in the environment does not go above this number, even if a lower number of workers can handle the load.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>The amount of storage (GB) for the Airflow web server.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfigWorkloadsConfig
{
    /// <summary>Configuration for resources used by Airflow schedulers.</summary>
    [JsonPropertyName("scheduler")]
    public IList<V1beta1EnvironmentSpecForProviderConfigWorkloadsConfigScheduler>? Scheduler { get; set; }

    /// <summary>Configuration for resources used by Airflow triggerer.</summary>
    [JsonPropertyName("triggerer")]
    public IList<V1beta1EnvironmentSpecForProviderConfigWorkloadsConfigTriggerer>? Triggerer { get; set; }

    /// <summary>Configuration for resources used by Airflow web server.</summary>
    [JsonPropertyName("webServer")]
    public IList<V1beta1EnvironmentSpecForProviderConfigWorkloadsConfigWebServer>? WebServer { get; set; }

    /// <summary>Configuration for resources used by Airflow workers.</summary>
    [JsonPropertyName("worker")]
    public IList<V1beta1EnvironmentSpecForProviderConfigWorkloadsConfigWorker>? Worker { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderConfig
{
    /// <summary>Configuration setting for airflow data rentention mechanism. Structure is documented below.</summary>
    [JsonPropertyName("dataRetentionConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigDataRetentionConfig>? DataRetentionConfig { get; set; }

    /// <summary>The configuration settings for Cloud SQL instance used internally by Apache Airflow software.</summary>
    [JsonPropertyName("databaseConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigDatabaseConfig>? DatabaseConfig { get; set; }

    /// <summary>The encryption options for the Cloud Composer environment and its dependencies.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>The environment size controls the performance parameters of the managed Cloud Composer infrastructure that includes the Airflow database. Values for environment size are ENVIRONMENT_SIZE_SMALL, ENVIRONMENT_SIZE_MEDIUM, and ENVIRONMENT_SIZE_LARGE.</summary>
    [JsonPropertyName("environmentSize")]
    public string? EnvironmentSize { get; set; }

    /// <summary>The configuration settings for Cloud Composer maintenance windows.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1EnvironmentSpecForProviderConfigMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>Configuration options for the master authorized networks feature. Enabled master authorized networks will disallow all external traffic to access Kubernetes master through HTTPS except traffic from the given CIDR blocks, Google Compute Engine Public IPs and Google Prod IPs. Structure is documented below.</summary>
    [JsonPropertyName("masterAuthorizedNetworksConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigMasterAuthorizedNetworksConfig>? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>The configuration used for the Kubernetes Engine cluster.  Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigNodeConfig>? NodeConfig { get; set; }

    /// <summary>The number of nodes in the Kubernetes Engine cluster of the environment.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The configuration used for the Private IP Cloud Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("privateEnvironmentConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigPrivateEnvironmentConfig>? PrivateEnvironmentConfig { get; set; }

    /// <summary>The configuration settings for recovery. Structure is documented below.</summary>
    [JsonPropertyName("recoveryConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigRecoveryConfig>? RecoveryConfig { get; set; }

    /// <summary>The resilience mode states whether high resilience is enabled for the environment or not. Values for resilience mode are HIGH_RESILIENCE for high resilience and STANDARD_RESILIENCE for standard resilience.</summary>
    [JsonPropertyName("resilienceMode")]
    public string? ResilienceMode { get; set; }

    /// <summary>The configuration settings for software inside the environment.  Structure is documented below.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>The configuration settings for the Airflow web server App Engine instance.</summary>
    [JsonPropertyName("webServerConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigWebServerConfig>? WebServerConfig { get; set; }

    /// <summary>The network-level access control policy for the Airflow web server. If unspecified, no network-level access restrictions are applied.</summary>
    [JsonPropertyName("webServerNetworkAccessControl")]
    public IList<V1beta1EnvironmentSpecForProviderConfigWebServerNetworkAccessControl>? WebServerNetworkAccessControl { get; set; }

    /// <summary>The Kubernetes workloads configuration for GKE cluster associated with the Cloud Composer environment.</summary>
    [JsonPropertyName("workloadsConfig")]
    public IList<V1beta1EnvironmentSpecForProviderConfigWorkloadsConfig>? WorkloadsConfig { get; set; }
}

public enum V1beta1EnvironmentSpecForProviderProjectRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecForProviderProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecForProviderProjectRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderProjectRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecForProviderProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderProjectRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecForProviderProjectRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderProjectRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecForProviderProjectSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecForProviderProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecForProviderProjectSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderProjectSelectorPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecForProviderProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecForProviderProjectSelectorPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecForProviderProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderProjectSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecForProviderProjectSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1EnvironmentSpecForProviderStorageConfig
{
    /// <summary>Name of an existing Cloud Storage bucket to be used by the environment.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }
}

public partial class V1beta1EnvironmentSpecForProvider
{
    /// <summary>Configuration parameters for this environment  Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1EnvironmentSpecForProviderConfig>? Config { get; set; }

    /// <summary>User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be associated with a given environment. Both keys and values must be &lt;= 128 bytes in size.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1EnvironmentSpecForProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1EnvironmentSpecForProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>The location or Compute Engine region for the environment.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Configuration options for storage used by Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public IList<V1beta1EnvironmentSpecForProviderStorageConfig>? StorageConfig { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigDataRetentionConfigTaskLogsRetentionConfig
{
    /// <summary>The mode of storage for Airflow workers task logs. Values for storage mode are CLOUD_LOGGING_ONLY to only store logs in cloud logging and CLOUD_LOGGING_AND_CLOUD_STORAGE to store logs in cloud logging and cloud storage.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigDataRetentionConfig
{
    /// <summary>The configuration setting for Task Logs. Structure is documented below.</summary>
    [JsonPropertyName("taskLogsRetentionConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigDataRetentionConfigTaskLogsRetentionConfig>? TaskLogsRetentionConfig { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigDatabaseConfig
{
    /// <summary>Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. Value custom is returned only in response, if Airflow web server parameters were manually changed to a non-standard values.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The Compute Engine zone in which to deploy the VMs running the Apache Airflow software, specified as the zone name or relative resource name (e.g. "projects/{project}/zones/{zone}"). Must belong to the enclosing environment's project and region.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigEncryptionConfig
{
    /// <summary>Customer-managed Encryption Key available through Google's Key Management Service. It must be the fully qualified resource name, i.e. projects/project-id/locations/location/keyRings/keyring/cryptoKeys/key. Cannot be updated.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigMaintenanceWindow
{
    /// <summary>Maintenance window end time. It is used only to calculate the duration of the maintenance window. The value for end-time must be in the future, relative to 'start_time'.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Maintenance window recurrence. Format is a subset of RFC-5545 (https://tools.ietf.org/html/rfc5545) 'RRULE'. The only allowed values for 'FREQ' field are 'FREQ=DAILY' and 'FREQ=WEEKLY;BYDAY=...'. Example values: 'FREQ=WEEKLY;BYDAY=TU,WE', 'FREQ=DAILY'.</summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary>Start time of the first recurrence of the maintenance window.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigMasterAuthorizedNetworksConfigCidrBlocks
{
    /// <summary>cidr_block must be specified in CIDR notation.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>display_name is a field for users to identify CIDR blocks.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigMasterAuthorizedNetworksConfig
{
    /// <summary>cidr_blocks define up to 50 external networks that could access Kubernetes master through HTTPS. Structure is documented below.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigMasterAuthorizedNetworksConfigCidrBlocks>? CidrBlocks { get; set; }

    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigIpAllocationPolicy
{
    /// <summary>The IP address range used to allocate IP addresses to pods in the cluster. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true. Set to blank to have GKE choose a range with the default size. Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use. Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both.</summary>
    [JsonPropertyName("clusterIpv4CidrBlock")]
    public string? ClusterIpv4CidrBlock { get; set; }

    /// <summary>The name of the cluster's secondary range used to allocate IP addresses to pods. Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.</summary>
    [JsonPropertyName("clusterSecondaryRangeName")]
    public string? ClusterSecondaryRangeName { get; set; }

    /// <summary>The IP address range used to allocate IP addresses in this cluster. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true. Set to blank to have GKE choose a range with the default size. Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use. Specify either services_secondary_range_name or services_ipv4_cidr_block but not both.</summary>
    [JsonPropertyName("servicesIpv4CidrBlock")]
    public string? ServicesIpv4CidrBlock { get; set; }

    /// <summary>The name of the services' secondary range used to allocate IP addresses to the cluster. Specify either services_secondary_range_name or services_ipv4_cidr_block but not both. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.</summary>
    [JsonPropertyName("servicesSecondaryRangeName")]
    public string? ServicesSecondaryRangeName { get; set; }

    /// <summary>Whether or not to enable Alias IPs in the GKE cluster. If true, a VPC-native cluster is created. Defaults to true if the ip_allocation_policy block is present in config.</summary>
    [JsonPropertyName("useIpAliases")]
    public bool? UseIpAliases { get; set; }
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigNodeConfig
{
    /// <summary>The disk size in GB used for node VMs. Minimum size is 20GB. If unspecified, defaults to 100GB. Cannot be updated.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Deploys 'ip-masq-agent' daemon set in the GKE cluster and defines nonMasqueradeCIDRs equals to pod IP range so IP masquerading is used for all destination addresses, except between pods traffic. See the documentation.</summary>
    [JsonPropertyName("enableIpMasqAgent")]
    public bool? EnableIpMasqAgent { get; set; }

    /// <summary>Configuration for controlling how IPs are allocated in the GKE cluster. Structure is documented below. Cannot be updated.</summary>
    [JsonPropertyName("ipAllocationPolicy")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigNodeConfigIpAllocationPolicy>? IpAllocationPolicy { get; set; }

    /// <summary>Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. Value custom is returned only in response, if Airflow web server parameters were manually changed to a non-standard values.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications, specified as a self-link, relative resource name (for example "projects/{project}/global/networks/{network}"), by name.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The set of Google API scopes to be made available on all node VMs. Cannot be updated. If empty, defaults to ["https://www.googleapis.com/auth/cloud-platform"].</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>The Google Cloud Platform Service Account to be used by the node VMs. If a service account is not specified, the "default" Compute Engine service account is used. Cannot be updated. If given, note that the service account must have roles/composer.worker for any GCP resources created under the Cloud Composer Environment.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications, specified as a self-link, relative resource name (for example, "projects/{project}/regions/{region}/subnetworks/{subnetwork}"), or by name. If subnetwork is provided, network must also be provided and the subnetwork must belong to the enclosing environment's project and region.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelector? SubnetworkSelector { get; set; }

    /// <summary>The list of instance tags applied to all node VMs. Tags are used to identify valid sources or targets for network firewalls. Each tag within the list must comply with RFC1035. Cannot be updated.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The Compute Engine zone in which to deploy the VMs running the Apache Airflow software, specified as the zone name or relative resource name (e.g. "projects/{project}/zones/{zone}"). Must belong to the enclosing environment's project and region.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigPrivateEnvironmentConfig
{
    /// <summary>When specified, the environment will use Private Service Connect instead of VPC peerings to connect to Cloud SQL in the Tenant Project, and the PSC endpoint in the Customer Project will use an IP address from this subnetwork. This field is supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("cloudComposerConnectionSubnetwork")]
    public string? CloudComposerConnectionSubnetwork { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudComposerNetworkIpv4CidrBlock")]
    public string? CloudComposerNetworkIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range in tenant project will be reserved for Cloud SQL. Needs to be disjoint from web_server_ipv4_cidr_block</summary>
    [JsonPropertyName("cloudSqlIpv4CidrBlock")]
    public string? CloudSqlIpv4CidrBlock { get; set; }

    /// <summary>Mode of internal communication within the Composer environment. Must be one of "VPC_PEERING" or "PRIVATE_SERVICE_CONNECT".</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>If true, access to the public endpoint of the GKE cluster is denied. If this field is set to true, the ip_allocation_policy.use_ip_aliases field must also be set to true for Cloud Composer 1 environments.</summary>
    [JsonPropertyName("enablePrivateEndpoint")]
    public bool? EnablePrivateEndpoint { get; set; }

    /// <summary>When enabled, IPs from public (non-RFC1918) ranges can be used for ip_allocation_policy.cluster_ipv4_cidr_block and ip_allocation_policy.service_ipv4_cidr_block.</summary>
    [JsonPropertyName("enablePrivatelyUsedPublicIps")]
    public bool? EnablePrivatelyUsedPublicIps { get; set; }

    /// <summary>The IP range in CIDR notation to use for the hosted master network. This range is used for assigning internal IP addresses to the cluster master or set of masters and to the internal load balancer virtual IP. This range must not overlap with any other ranges in use within the cluster's network. If left blank, the default value of is used. See documentation for default values per region.</summary>
    [JsonPropertyName("masterIpv4CidrBlock")]
    public string? MasterIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range for web server will be reserved. Needs to be disjoint from master_ipv4_cidr_block and cloud_sql_ipv4_cidr_block.</summary>
    [JsonPropertyName("webServerIpv4CidrBlock")]
    public string? WebServerIpv4CidrBlock { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigRecoveryConfigScheduledSnapshotsConfig
{
    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Snapshot schedule, in the unix-cron format.</summary>
    [JsonPropertyName("snapshotCreationSchedule")]
    public string? SnapshotCreationSchedule { get; set; }

    /// <summary>The URI of a bucket folder where to save the snapshot.</summary>
    [JsonPropertyName("snapshotLocation")]
    public string? SnapshotLocation { get; set; }

    /// <summary>A time zone for the schedule. This value is a time offset and does not take into account daylight saving time changes. Valid values are from UTC-12 to UTC+12. Examples: UTC, UTC-01, UTC+03.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigRecoveryConfig
{
    /// <summary>The recovery configuration settings for the Cloud Composer environment.</summary>
    [JsonPropertyName("scheduledSnapshotsConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigRecoveryConfigScheduledSnapshotsConfig>? ScheduledSnapshotsConfig { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigSoftwareConfig
{
    /// <summary>Apache Airflow configuration properties to override. Property keys contain the section and property names, separated by a hyphen, for example "core-dags_are_paused_at_creation".</summary>
    [JsonPropertyName("airflowConfigOverrides")]
    public IDictionary<string, string>? AirflowConfigOverrides { get; set; }

    /// <summary>Additional environment variables to provide to the Apache Airflow scheduler, worker, and webserver processes. Environment variable names must match the regular expression [a-zA-Z_][a-zA-Z0-9_]*. They cannot specify Apache Airflow software configuration overrides (they cannot match the regular expression AIRFLOW__[A-Z0-9_]+__[A-Z0-9_]+), and they cannot match any of the following reserved names:</summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>Custom Python Package Index (PyPI) packages to be installed in the environment. Keys refer to the lowercase package name (e.g. "numpy"). Values are the lowercase extras and version specifier (e.g. "==1.12.0", "[devel,gcp_api]", "[devel]&gt;=1.8.2, &lt;1.9.2"). To specify a package without pinning it to a version specifier, use the empty string as the value.</summary>
    [JsonPropertyName("pypiPackages")]
    public IDictionary<string, string>? PypiPackages { get; set; }

    /// <summary>The major version of Python used to run the Apache Airflow scheduler, worker, and webserver processes. Can be set to '2' or '3'. If not specified, the default is '3'.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The number of schedulers for Airflow.</summary>
    [JsonPropertyName("schedulerCount")]
    public double? SchedulerCount { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigWebServerConfig
{
    /// <summary>Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. Value custom is returned only in response, if Airflow web server parameters were manually changed to a non-standard values.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigWebServerNetworkAccessControlAllowedIpRange
{
    /// <summary>A description of this ip range.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>IP address or range, defined using CIDR notation, of requests that this rule applies to. Examples: 192.168.1.1 or 192.168.0.0/16 or 2001:db8::/32 or 2001:0db8:0000:0042:0000:8a2e:0370:7334. IP range prefixes should be properly truncated. For example, 1.2.3.4/24 should be truncated to 1.2.3.0/24. Similarly, for IPv6, 2001:db8::1/32 should be truncated to 2001:db8::/32.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigWebServerNetworkAccessControl
{
    /// <summary>A collection of allowed IP ranges with descriptions. Structure is documented below.</summary>
    [JsonPropertyName("allowedIpRange")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigWebServerNetworkAccessControlAllowedIpRange>? AllowedIpRange { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigWorkloadsConfigScheduler
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for the Airflow web server.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigWorkloadsConfigTriggerer
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigWorkloadsConfigWebServer
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for the Airflow web server.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigWorkloadsConfigWorker
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The maximum number of Airflow workers that the environment can run. The number of workers in the environment does not go above this number, even if a higher number of workers is required to handle the load.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The minimum number of Airflow workers that the environment can run. The number of workers in the environment does not go above this number, even if a lower number of workers can handle the load.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>The amount of storage (GB) for the Airflow web server.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfigWorkloadsConfig
{
    /// <summary>Configuration for resources used by Airflow schedulers.</summary>
    [JsonPropertyName("scheduler")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigWorkloadsConfigScheduler>? Scheduler { get; set; }

    /// <summary>Configuration for resources used by Airflow triggerer.</summary>
    [JsonPropertyName("triggerer")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigWorkloadsConfigTriggerer>? Triggerer { get; set; }

    /// <summary>Configuration for resources used by Airflow web server.</summary>
    [JsonPropertyName("webServer")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigWorkloadsConfigWebServer>? WebServer { get; set; }

    /// <summary>Configuration for resources used by Airflow workers.</summary>
    [JsonPropertyName("worker")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigWorkloadsConfigWorker>? Worker { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderConfig
{
    /// <summary>Configuration setting for airflow data rentention mechanism. Structure is documented below.</summary>
    [JsonPropertyName("dataRetentionConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigDataRetentionConfig>? DataRetentionConfig { get; set; }

    /// <summary>The configuration settings for Cloud SQL instance used internally by Apache Airflow software.</summary>
    [JsonPropertyName("databaseConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigDatabaseConfig>? DatabaseConfig { get; set; }

    /// <summary>The encryption options for the Cloud Composer environment and its dependencies.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>The environment size controls the performance parameters of the managed Cloud Composer infrastructure that includes the Airflow database. Values for environment size are ENVIRONMENT_SIZE_SMALL, ENVIRONMENT_SIZE_MEDIUM, and ENVIRONMENT_SIZE_LARGE.</summary>
    [JsonPropertyName("environmentSize")]
    public string? EnvironmentSize { get; set; }

    /// <summary>The configuration settings for Cloud Composer maintenance windows.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>Configuration options for the master authorized networks feature. Enabled master authorized networks will disallow all external traffic to access Kubernetes master through HTTPS except traffic from the given CIDR blocks, Google Compute Engine Public IPs and Google Prod IPs. Structure is documented below.</summary>
    [JsonPropertyName("masterAuthorizedNetworksConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigMasterAuthorizedNetworksConfig>? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>The configuration used for the Kubernetes Engine cluster.  Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigNodeConfig>? NodeConfig { get; set; }

    /// <summary>The number of nodes in the Kubernetes Engine cluster of the environment.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The configuration used for the Private IP Cloud Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("privateEnvironmentConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigPrivateEnvironmentConfig>? PrivateEnvironmentConfig { get; set; }

    /// <summary>The configuration settings for recovery. Structure is documented below.</summary>
    [JsonPropertyName("recoveryConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigRecoveryConfig>? RecoveryConfig { get; set; }

    /// <summary>The resilience mode states whether high resilience is enabled for the environment or not. Values for resilience mode are HIGH_RESILIENCE for high resilience and STANDARD_RESILIENCE for standard resilience.</summary>
    [JsonPropertyName("resilienceMode")]
    public string? ResilienceMode { get; set; }

    /// <summary>The configuration settings for software inside the environment.  Structure is documented below.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>The configuration settings for the Airflow web server App Engine instance.</summary>
    [JsonPropertyName("webServerConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigWebServerConfig>? WebServerConfig { get; set; }

    /// <summary>The network-level access control policy for the Airflow web server. If unspecified, no network-level access restrictions are applied.</summary>
    [JsonPropertyName("webServerNetworkAccessControl")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigWebServerNetworkAccessControl>? WebServerNetworkAccessControl { get; set; }

    /// <summary>The Kubernetes workloads configuration for GKE cluster associated with the Cloud Composer environment.</summary>
    [JsonPropertyName("workloadsConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderConfigWorkloadsConfig>? WorkloadsConfig { get; set; }
}

public enum V1beta1EnvironmentSpecInitProviderProjectRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecInitProviderProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecInitProviderProjectRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderProjectRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecInitProviderProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderProjectRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecInitProviderProjectRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderProjectRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecInitProviderProjectSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecInitProviderProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecInitProviderProjectSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderProjectSelectorPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecInitProviderProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecInitProviderProjectSelectorPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecInitProviderProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderProjectSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecInitProviderProjectSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProviderStorageConfig
{
    /// <summary>Name of an existing Cloud Storage bucket to be used by the environment.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }
}

public partial class V1beta1EnvironmentSpecInitProvider
{
    /// <summary>Configuration parameters for this environment  Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1EnvironmentSpecInitProviderConfig>? Config { get; set; }

    /// <summary>User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be associated with a given environment. Both keys and values must be &lt;= 128 bytes in size.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1EnvironmentSpecInitProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1EnvironmentSpecInitProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>Configuration options for storage used by Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public IList<V1beta1EnvironmentSpecInitProviderStorageConfig>? StorageConfig { get; set; }
}

public enum V1beta1EnvironmentSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1EnvironmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1EnvironmentSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1EnvironmentSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1EnvironmentSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1EnvironmentSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1EnvironmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1EnvironmentSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1EnvironmentSpecDeletionPolicyEnum>))]
    public V1beta1EnvironmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EnvironmentSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EnvironmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EnvironmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EnvironmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1EnvironmentSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EnvironmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigDataRetentionConfigTaskLogsRetentionConfig
{
    /// <summary>The mode of storage for Airflow workers task logs. Values for storage mode are CLOUD_LOGGING_ONLY to only store logs in cloud logging and CLOUD_LOGGING_AND_CLOUD_STORAGE to store logs in cloud logging and cloud storage.</summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigDataRetentionConfig
{
    /// <summary>The configuration setting for Task Logs. Structure is documented below.</summary>
    [JsonPropertyName("taskLogsRetentionConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigDataRetentionConfigTaskLogsRetentionConfig>? TaskLogsRetentionConfig { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigDatabaseConfig
{
    /// <summary>Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. Value custom is returned only in response, if Airflow web server parameters were manually changed to a non-standard values.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The Compute Engine zone in which to deploy the VMs running the Apache Airflow software, specified as the zone name or relative resource name (e.g. "projects/{project}/zones/{zone}"). Must belong to the enclosing environment's project and region.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigEncryptionConfig
{
    /// <summary>Customer-managed Encryption Key available through Google's Key Management Service. It must be the fully qualified resource name, i.e. projects/project-id/locations/location/keyRings/keyring/cryptoKeys/key. Cannot be updated.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigMaintenanceWindow
{
    /// <summary>Maintenance window end time. It is used only to calculate the duration of the maintenance window. The value for end-time must be in the future, relative to 'start_time'.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Maintenance window recurrence. Format is a subset of RFC-5545 (https://tools.ietf.org/html/rfc5545) 'RRULE'. The only allowed values for 'FREQ' field are 'FREQ=DAILY' and 'FREQ=WEEKLY;BYDAY=...'. Example values: 'FREQ=WEEKLY;BYDAY=TU,WE', 'FREQ=DAILY'.</summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary>Start time of the first recurrence of the maintenance window.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigMasterAuthorizedNetworksConfigCidrBlocks
{
    /// <summary>cidr_block must be specified in CIDR notation.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>display_name is a field for users to identify CIDR blocks.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigMasterAuthorizedNetworksConfig
{
    /// <summary>cidr_blocks define up to 50 external networks that could access Kubernetes master through HTTPS. Structure is documented below.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigMasterAuthorizedNetworksConfigCidrBlocks>? CidrBlocks { get; set; }

    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigNodeConfigIpAllocationPolicy
{
    /// <summary>The IP address range used to allocate IP addresses to pods in the cluster. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true. Set to blank to have GKE choose a range with the default size. Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use. Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both.</summary>
    [JsonPropertyName("clusterIpv4CidrBlock")]
    public string? ClusterIpv4CidrBlock { get; set; }

    /// <summary>The name of the cluster's secondary range used to allocate IP addresses to pods. Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.</summary>
    [JsonPropertyName("clusterSecondaryRangeName")]
    public string? ClusterSecondaryRangeName { get; set; }

    /// <summary>The IP address range used to allocate IP addresses in this cluster. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true. Set to blank to have GKE choose a range with the default size. Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use. Specify either services_secondary_range_name or services_ipv4_cidr_block but not both.</summary>
    [JsonPropertyName("servicesIpv4CidrBlock")]
    public string? ServicesIpv4CidrBlock { get; set; }

    /// <summary>The name of the services' secondary range used to allocate IP addresses to the cluster. Specify either services_secondary_range_name or services_ipv4_cidr_block but not both. For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.</summary>
    [JsonPropertyName("servicesSecondaryRangeName")]
    public string? ServicesSecondaryRangeName { get; set; }

    /// <summary>Whether or not to enable Alias IPs in the GKE cluster. If true, a VPC-native cluster is created. Defaults to true if the ip_allocation_policy block is present in config.</summary>
    [JsonPropertyName("useIpAliases")]
    public bool? UseIpAliases { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigNodeConfig
{
    /// <summary>The disk size in GB used for node VMs. Minimum size is 20GB. If unspecified, defaults to 100GB. Cannot be updated.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Deploys 'ip-masq-agent' daemon set in the GKE cluster and defines nonMasqueradeCIDRs equals to pod IP range so IP masquerading is used for all destination addresses, except between pods traffic. See the documentation.</summary>
    [JsonPropertyName("enableIpMasqAgent")]
    public bool? EnableIpMasqAgent { get; set; }

    /// <summary>Configuration for controlling how IPs are allocated in the GKE cluster. Structure is documented below. Cannot be updated.</summary>
    [JsonPropertyName("ipAllocationPolicy")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigNodeConfigIpAllocationPolicy>? IpAllocationPolicy { get; set; }

    /// <summary>Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. Value custom is returned only in response, if Airflow web server parameters were manually changed to a non-standard values.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications, specified as a self-link, relative resource name (for example "projects/{project}/global/networks/{network}"), by name.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The set of Google API scopes to be made available on all node VMs. Cannot be updated. If empty, defaults to ["https://www.googleapis.com/auth/cloud-platform"].</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>The Google Cloud Platform Service Account to be used by the node VMs. If a service account is not specified, the "default" Compute Engine service account is used. Cannot be updated. If given, note that the service account must have roles/composer.worker for any GCP resources created under the Cloud Composer Environment.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications, specified as a self-link, relative resource name (for example, "projects/{project}/regions/{region}/subnetworks/{subnetwork}"), or by name. If subnetwork is provided, network must also be provided and the subnetwork must belong to the enclosing environment's project and region.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The list of instance tags applied to all node VMs. Tags are used to identify valid sources or targets for network firewalls. Each tag within the list must comply with RFC1035. Cannot be updated.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The Compute Engine zone in which to deploy the VMs running the Apache Airflow software, specified as the zone name or relative resource name (e.g. "projects/{project}/zones/{zone}"). Must belong to the enclosing environment's project and region.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigPrivateEnvironmentConfig
{
    /// <summary>When specified, the environment will use Private Service Connect instead of VPC peerings to connect to Cloud SQL in the Tenant Project, and the PSC endpoint in the Customer Project will use an IP address from this subnetwork. This field is supported for Cloud Composer environments in versions composer-2.*.*-airflow-*.*.* and newer.</summary>
    [JsonPropertyName("cloudComposerConnectionSubnetwork")]
    public string? CloudComposerConnectionSubnetwork { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cloudComposerNetworkIpv4CidrBlock")]
    public string? CloudComposerNetworkIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range in tenant project will be reserved for Cloud SQL. Needs to be disjoint from web_server_ipv4_cidr_block</summary>
    [JsonPropertyName("cloudSqlIpv4CidrBlock")]
    public string? CloudSqlIpv4CidrBlock { get; set; }

    /// <summary>Mode of internal communication within the Composer environment. Must be one of "VPC_PEERING" or "PRIVATE_SERVICE_CONNECT".</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>If true, access to the public endpoint of the GKE cluster is denied. If this field is set to true, the ip_allocation_policy.use_ip_aliases field must also be set to true for Cloud Composer 1 environments.</summary>
    [JsonPropertyName("enablePrivateEndpoint")]
    public bool? EnablePrivateEndpoint { get; set; }

    /// <summary>When enabled, IPs from public (non-RFC1918) ranges can be used for ip_allocation_policy.cluster_ipv4_cidr_block and ip_allocation_policy.service_ipv4_cidr_block.</summary>
    [JsonPropertyName("enablePrivatelyUsedPublicIps")]
    public bool? EnablePrivatelyUsedPublicIps { get; set; }

    /// <summary>The IP range in CIDR notation to use for the hosted master network. This range is used for assigning internal IP addresses to the cluster master or set of masters and to the internal load balancer virtual IP. This range must not overlap with any other ranges in use within the cluster's network. If left blank, the default value of is used. See documentation for default values per region.</summary>
    [JsonPropertyName("masterIpv4CidrBlock")]
    public string? MasterIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range for web server will be reserved. Needs to be disjoint from master_ipv4_cidr_block and cloud_sql_ipv4_cidr_block.</summary>
    [JsonPropertyName("webServerIpv4CidrBlock")]
    public string? WebServerIpv4CidrBlock { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigRecoveryConfigScheduledSnapshotsConfig
{
    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Snapshot schedule, in the unix-cron format.</summary>
    [JsonPropertyName("snapshotCreationSchedule")]
    public string? SnapshotCreationSchedule { get; set; }

    /// <summary>The URI of a bucket folder where to save the snapshot.</summary>
    [JsonPropertyName("snapshotLocation")]
    public string? SnapshotLocation { get; set; }

    /// <summary>A time zone for the schedule. This value is a time offset and does not take into account daylight saving time changes. Valid values are from UTC-12 to UTC+12. Examples: UTC, UTC-01, UTC+03.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigRecoveryConfig
{
    /// <summary>The recovery configuration settings for the Cloud Composer environment.</summary>
    [JsonPropertyName("scheduledSnapshotsConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigRecoveryConfigScheduledSnapshotsConfig>? ScheduledSnapshotsConfig { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigSoftwareConfig
{
    /// <summary>Apache Airflow configuration properties to override. Property keys contain the section and property names, separated by a hyphen, for example "core-dags_are_paused_at_creation".</summary>
    [JsonPropertyName("airflowConfigOverrides")]
    public IDictionary<string, string>? AirflowConfigOverrides { get; set; }

    /// <summary>Additional environment variables to provide to the Apache Airflow scheduler, worker, and webserver processes. Environment variable names must match the regular expression [a-zA-Z_][a-zA-Z0-9_]*. They cannot specify Apache Airflow software configuration overrides (they cannot match the regular expression AIRFLOW__[A-Z0-9_]+__[A-Z0-9_]+), and they cannot match any of the following reserved names:</summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>Custom Python Package Index (PyPI) packages to be installed in the environment. Keys refer to the lowercase package name (e.g. "numpy"). Values are the lowercase extras and version specifier (e.g. "==1.12.0", "[devel,gcp_api]", "[devel]&gt;=1.8.2, &lt;1.9.2"). To specify a package without pinning it to a version specifier, use the empty string as the value.</summary>
    [JsonPropertyName("pypiPackages")]
    public IDictionary<string, string>? PypiPackages { get; set; }

    /// <summary>The major version of Python used to run the Apache Airflow scheduler, worker, and webserver processes. Can be set to '2' or '3'. If not specified, the default is '3'.</summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The number of schedulers for Airflow.</summary>
    [JsonPropertyName("schedulerCount")]
    public double? SchedulerCount { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigWebServerConfig
{
    /// <summary>Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2, composer-n1-webserver-4 or composer-n1-webserver-8. Value custom is returned only in response, if Airflow web server parameters were manually changed to a non-standard values.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigWebServerNetworkAccessControlAllowedIpRange
{
    /// <summary>A description of this ip range.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>IP address or range, defined using CIDR notation, of requests that this rule applies to. Examples: 192.168.1.1 or 192.168.0.0/16 or 2001:db8::/32 or 2001:0db8:0000:0042:0000:8a2e:0370:7334. IP range prefixes should be properly truncated. For example, 1.2.3.4/24 should be truncated to 1.2.3.0/24. Similarly, for IPv6, 2001:db8::1/32 should be truncated to 2001:db8::/32.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigWebServerNetworkAccessControl
{
    /// <summary>A collection of allowed IP ranges with descriptions. Structure is documented below.</summary>
    [JsonPropertyName("allowedIpRange")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigWebServerNetworkAccessControlAllowedIpRange>? AllowedIpRange { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigWorkloadsConfigScheduler
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for the Airflow web server.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigWorkloadsConfigTriggerer
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigWorkloadsConfigWebServer
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for the Airflow web server.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigWorkloadsConfigWorker
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The maximum number of Airflow workers that the environment can run. The number of workers in the environment does not go above this number, even if a higher number of workers is required to handle the load.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The minimum number of Airflow workers that the environment can run. The number of workers in the environment does not go above this number, even if a lower number of workers can handle the load.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>The amount of storage (GB) for the Airflow web server.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfigWorkloadsConfig
{
    /// <summary>Configuration for resources used by Airflow schedulers.</summary>
    [JsonPropertyName("scheduler")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigWorkloadsConfigScheduler>? Scheduler { get; set; }

    /// <summary>Configuration for resources used by Airflow triggerer.</summary>
    [JsonPropertyName("triggerer")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigWorkloadsConfigTriggerer>? Triggerer { get; set; }

    /// <summary>Configuration for resources used by Airflow web server.</summary>
    [JsonPropertyName("webServer")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigWorkloadsConfigWebServer>? WebServer { get; set; }

    /// <summary>Configuration for resources used by Airflow workers.</summary>
    [JsonPropertyName("worker")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigWorkloadsConfigWorker>? Worker { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderConfig
{
    /// <summary>The URI of the Apache Airflow Web UI hosted within this environment.</summary>
    [JsonPropertyName("airflowUri")]
    public string? AirflowUri { get; set; }

    /// <summary>The Cloud Storage prefix of the DAGs for this environment. Although Cloud Storage objects reside in a flat namespace, a hierarchical file tree can be simulated using '/'-delimited object name prefixes. DAG objects for this environment reside in a simulated directory with this prefix.</summary>
    [JsonPropertyName("dagGcsPrefix")]
    public string? DagGcsPrefix { get; set; }

    /// <summary>Configuration setting for airflow data rentention mechanism. Structure is documented below.</summary>
    [JsonPropertyName("dataRetentionConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigDataRetentionConfig>? DataRetentionConfig { get; set; }

    /// <summary>The configuration settings for Cloud SQL instance used internally by Apache Airflow software.</summary>
    [JsonPropertyName("databaseConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigDatabaseConfig>? DatabaseConfig { get; set; }

    /// <summary>The encryption options for the Cloud Composer environment and its dependencies.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>The environment size controls the performance parameters of the managed Cloud Composer infrastructure that includes the Airflow database. Values for environment size are ENVIRONMENT_SIZE_SMALL, ENVIRONMENT_SIZE_MEDIUM, and ENVIRONMENT_SIZE_LARGE.</summary>
    [JsonPropertyName("environmentSize")]
    public string? EnvironmentSize { get; set; }

    /// <summary>The Kubernetes Engine cluster used to run this environment.</summary>
    [JsonPropertyName("gkeCluster")]
    public string? GkeCluster { get; set; }

    /// <summary>The configuration settings for Cloud Composer maintenance windows.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>Configuration options for the master authorized networks feature. Enabled master authorized networks will disallow all external traffic to access Kubernetes master through HTTPS except traffic from the given CIDR blocks, Google Compute Engine Public IPs and Google Prod IPs. Structure is documented below.</summary>
    [JsonPropertyName("masterAuthorizedNetworksConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigMasterAuthorizedNetworksConfig>? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>The configuration used for the Kubernetes Engine cluster.  Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigNodeConfig>? NodeConfig { get; set; }

    /// <summary>The number of nodes in the Kubernetes Engine cluster of the environment.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The configuration used for the Private IP Cloud Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("privateEnvironmentConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigPrivateEnvironmentConfig>? PrivateEnvironmentConfig { get; set; }

    /// <summary>The configuration settings for recovery. Structure is documented below.</summary>
    [JsonPropertyName("recoveryConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigRecoveryConfig>? RecoveryConfig { get; set; }

    /// <summary>The resilience mode states whether high resilience is enabled for the environment or not. Values for resilience mode are HIGH_RESILIENCE for high resilience and STANDARD_RESILIENCE for standard resilience.</summary>
    [JsonPropertyName("resilienceMode")]
    public string? ResilienceMode { get; set; }

    /// <summary>The configuration settings for software inside the environment.  Structure is documented below.</summary>
    [JsonPropertyName("softwareConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigSoftwareConfig>? SoftwareConfig { get; set; }

    /// <summary>The configuration settings for the Airflow web server App Engine instance.</summary>
    [JsonPropertyName("webServerConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigWebServerConfig>? WebServerConfig { get; set; }

    /// <summary>The network-level access control policy for the Airflow web server. If unspecified, no network-level access restrictions are applied.</summary>
    [JsonPropertyName("webServerNetworkAccessControl")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigWebServerNetworkAccessControl>? WebServerNetworkAccessControl { get; set; }

    /// <summary>The Kubernetes workloads configuration for GKE cluster associated with the Cloud Composer environment.</summary>
    [JsonPropertyName("workloadsConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderConfigWorkloadsConfig>? WorkloadsConfig { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProviderStorageConfig
{
    /// <summary>Name of an existing Cloud Storage bucket to be used by the environment.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }
}

public partial class V1beta1EnvironmentStatusAtProvider
{
    /// <summary>Configuration parameters for this environment  Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public IList<V1beta1EnvironmentStatusAtProviderConfig>? Config { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{region}}/environments/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>User-defined labels for this environment. The labels map can contain no more than 64 entries. Entries of the labels map are UTF8 strings that comply with the following restrictions: Label keys must be between 1 and 63 characters long and must conform to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?. Label values must be between 0 and 63 characters long and must conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?. No more than 64 labels can be associated with a given environment. Both keys and values must be &lt;= 128 bytes in size.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The location or Compute Engine region for the environment.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration options for storage used by Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public IList<V1beta1EnvironmentStatusAtProviderStorageConfig>? StorageConfig { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

public partial class V1beta1EnvironmentStatusConditions
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

public partial class V1beta1EnvironmentStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EnvironmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EnvironmentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Environment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EnvironmentSpec>, IStatus<V1beta1EnvironmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Environment";
    public const string KubeGroup = "composer.gcp.upbound.io";
    public const string KubePluralName = "environments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EnvironmentSpec defines the desired state of Environment</summary>
    [JsonPropertyName("spec")]
    public V1beta1EnvironmentSpec Spec { get; set; }

    /// <summary>EnvironmentStatus defines the observed state of Environment.</summary>
    [JsonPropertyName("status")]
    public V1beta1EnvironmentStatus? Status { get; set; }
}