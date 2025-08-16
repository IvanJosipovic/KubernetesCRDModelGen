using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.globalaccelerator.aws.upbound.io;
/// <summary>Accelerator is the Schema for the Accelerators API. Provides a Global Accelerator accelerator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AcceleratorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Accelerator>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AcceleratorList";
    public const string KubeGroup = "globalaccelerator.aws.upbound.io";
    public const string KubePluralName = "accelerators";
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
    public IList<V1beta1Accelerator> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorSpecForProviderAttributes
{
    /// <summary>Indicates whether flow logs are enabled. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("flowLogsEnabled")]
    public bool? FlowLogsEnabled { get; set; }

    /// <summary>The name of the Amazon S3 bucket for the flow logs. Required if flow_logs_enabled is true.</summary>
    [JsonPropertyName("flowLogsS3Bucket")]
    public string? FlowLogsS3Bucket { get; set; }

    /// <summary>The prefix for the location in the Amazon S3 bucket for the flow logs. Required if flow_logs_enabled is true.</summary>
    [JsonPropertyName("flowLogsS3Prefix")]
    public string? FlowLogsS3Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorSpecForProvider
{
    /// <summary>The attributes of the accelerator. Fields documented below.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1beta1AcceleratorSpecForProviderAttributes>? Attributes { get; set; }

    /// <summary>Indicates whether the accelerator is enabled. Defaults to true. Valid values: true, false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The value for the address type. Defaults to IPV4. Valid values: IPV4, DUAL_STACK.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>The IP addresses to use for BYOIP accelerators. If not specified, the service assigns IP addresses. Valid values: 1 or 2 IPv4 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The name of the accelerator.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorSpecInitProviderAttributes
{
    /// <summary>Indicates whether flow logs are enabled. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("flowLogsEnabled")]
    public bool? FlowLogsEnabled { get; set; }

    /// <summary>The name of the Amazon S3 bucket for the flow logs. Required if flow_logs_enabled is true.</summary>
    [JsonPropertyName("flowLogsS3Bucket")]
    public string? FlowLogsS3Bucket { get; set; }

    /// <summary>The prefix for the location in the Amazon S3 bucket for the flow logs. Required if flow_logs_enabled is true.</summary>
    [JsonPropertyName("flowLogsS3Prefix")]
    public string? FlowLogsS3Prefix { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorSpecInitProvider
{
    /// <summary>The attributes of the accelerator. Fields documented below.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1beta1AcceleratorSpecInitProviderAttributes>? Attributes { get; set; }

    /// <summary>Indicates whether the accelerator is enabled. Defaults to true. Valid values: true, false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The value for the address type. Defaults to IPV4. Valid values: IPV4, DUAL_STACK.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>The IP addresses to use for BYOIP accelerators. If not specified, the service assigns IP addresses. Valid values: 1 or 2 IPv4 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The name of the accelerator.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorSpecProviderConfigRefPolicy
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
public partial class V1beta1AcceleratorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AcceleratorSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AcceleratorSpec defines the desired state of Accelerator</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AcceleratorSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AcceleratorSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AcceleratorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AcceleratorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorStatusAtProviderAttributes
{
    /// <summary>Indicates whether flow logs are enabled. Defaults to false. Valid values: true, false.</summary>
    [JsonPropertyName("flowLogsEnabled")]
    public bool? FlowLogsEnabled { get; set; }

    /// <summary>The name of the Amazon S3 bucket for the flow logs. Required if flow_logs_enabled is true.</summary>
    [JsonPropertyName("flowLogsS3Bucket")]
    public string? FlowLogsS3Bucket { get; set; }

    /// <summary>The prefix for the location in the Amazon S3 bucket for the flow logs. Required if flow_logs_enabled is true.</summary>
    [JsonPropertyName("flowLogsS3Prefix")]
    public string? FlowLogsS3Prefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorStatusAtProviderIpSets
{
    /// <summary>The IP addresses to use for BYOIP accelerators. If not specified, the service assigns IP addresses. Valid values: 1 or 2 IPv4 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The type of IP addresses included in this IP set.</summary>
    [JsonPropertyName("ipFamily")]
    public string? IpFamily { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) of the accelerator.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The attributes of the accelerator. Fields documented below.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1beta1AcceleratorStatusAtProviderAttributes>? Attributes { get; set; }

    /// <summary>The DNS name of the accelerator. For example, a5d53ff5ee6bca4ce.awsglobalaccelerator.com.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>The Domain Name System (DNS) name that Global Accelerator creates that points to a dual-stack accelerator's four static IP addresses: two IPv4 addresses and two IPv6 addresses. For example, a1234567890abcdef.dualstack.awsglobalaccelerator.com.</summary>
    [JsonPropertyName("dualStackDnsName")]
    public string? DualStackDnsName { get; set; }

    /// <summary>Indicates whether the accelerator is enabled. Defaults to true. Valid values: true, false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>-  The Global Accelerator Route 53 zone ID that can be used to route an Alias Resource Record Set to the Global Accelerator. This attribute is simply an alias for the zone ID Z2BJ6XQ5FK7U4H.</summary>
    [JsonPropertyName("hostedZoneId")]
    public string? HostedZoneId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the accelerator.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The value for the address type. Defaults to IPV4. Valid values: IPV4, DUAL_STACK.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>The IP addresses to use for BYOIP accelerators. If not specified, the service assigns IP addresses. Valid values: 1 or 2 IPv4 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>IP address set associated with the accelerator.</summary>
    [JsonPropertyName("ipSets")]
    public IList<V1beta1AcceleratorStatusAtProviderIpSets>? IpSets { get; set; }

    /// <summary>The name of the accelerator.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorStatusConditions
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

/// <summary>AcceleratorStatus defines the observed state of Accelerator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AcceleratorStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AcceleratorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AcceleratorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Accelerator is the Schema for the Accelerators API. Provides a Global Accelerator accelerator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Accelerator : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AcceleratorSpec>, IStatus<V1beta1AcceleratorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Accelerator";
    public const string KubeGroup = "globalaccelerator.aws.upbound.io";
    public const string KubePluralName = "accelerators";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AcceleratorSpec defines the desired state of Accelerator</summary>
    [JsonPropertyName("spec")]
    public V1beta1AcceleratorSpec Spec { get; set; }

    /// <summary>AcceleratorStatus defines the observed state of Accelerator.</summary>
    [JsonPropertyName("status")]
    public V1beta1AcceleratorStatus? Status { get; set; }
}