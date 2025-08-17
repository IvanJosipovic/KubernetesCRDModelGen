using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.codestarconnections.aws.m.upbound.io;
#nullable enable
/// <summary>Host is the Schema for the Hosts API. Provides a CodeStar Host</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HostList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Host>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HostList";
    public const string KubeGroup = "codestarconnections.aws.m.upbound.io";
    public const string KubePluralName = "hosts";
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
    public IList<V1beta1Host> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The VPC configuration to be provisioned for the host. A VPC must be configured, and the infrastructure to be represented by the host must already be connected to the VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HostSpecForProviderVpcConfiguration
{
    /// <summary>ID of the security group or security groups associated with the Amazon VPC connected to the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The ID of the subnet or subnets associated with the Amazon VPC connected to the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>The value of the Transport Layer Security (TLS) certificate associated with the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("tlsCertificate")]
    public string? TlsCertificate { get; set; }

    /// <summary>The ID of the Amazon VPC connected to the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HostSpecForProvider
{
    /// <summary>The name of the host to be created. The name must be unique in the calling AWS account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The endpoint of the infrastructure to be represented by the host after it is created.</summary>
    [JsonPropertyName("providerEndpoint")]
    public string? ProviderEndpoint { get; set; }

    /// <summary>The name of the external provider where your third-party code repository is configured.</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The VPC configuration to be provisioned for the host. A VPC must be configured, and the infrastructure to be represented by the host must already be connected to the VPC.</summary>
    [JsonPropertyName("vpcConfiguration")]
    public V1beta1HostSpecForProviderVpcConfiguration? VpcConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The VPC configuration to be provisioned for the host. A VPC must be configured, and the infrastructure to be represented by the host must already be connected to the VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HostSpecInitProviderVpcConfiguration
{
    /// <summary>ID of the security group or security groups associated with the Amazon VPC connected to the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The ID of the subnet or subnets associated with the Amazon VPC connected to the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>The value of the Transport Layer Security (TLS) certificate associated with the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("tlsCertificate")]
    public string? TlsCertificate { get; set; }

    /// <summary>The ID of the Amazon VPC connected to the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HostSpecInitProvider
{
    /// <summary>The name of the host to be created. The name must be unique in the calling AWS account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The endpoint of the infrastructure to be represented by the host after it is created.</summary>
    [JsonPropertyName("providerEndpoint")]
    public string? ProviderEndpoint { get; set; }

    /// <summary>The name of the external provider where your third-party code repository is configured.</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }

    /// <summary>The VPC configuration to be provisioned for the host. A VPC must be configured, and the infrastructure to be represented by the host must already be connected to the VPC.</summary>
    [JsonPropertyName("vpcConfiguration")]
    public V1beta1HostSpecInitProviderVpcConfiguration? VpcConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HostSpecProviderConfigRef
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
public partial class V1beta1HostSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HostSpec defines the desired state of Host</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HostSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1HostSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1HostSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1HostSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1HostSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The VPC configuration to be provisioned for the host. A VPC must be configured, and the infrastructure to be represented by the host must already be connected to the VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HostStatusAtProviderVpcConfiguration
{
    /// <summary>ID of the security group or security groups associated with the Amazon VPC connected to the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The ID of the subnet or subnets associated with the Amazon VPC connected to the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>The value of the Transport Layer Security (TLS) certificate associated with the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("tlsCertificate")]
    public string? TlsCertificate { get; set; }

    /// <summary>The ID of the Amazon VPC connected to the infrastructure where your provider type is installed.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HostStatusAtProvider
{
    /// <summary>The CodeStar Host ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The CodeStar Host ARN.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the host to be created. The name must be unique in the calling AWS account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The endpoint of the infrastructure to be represented by the host after it is created.</summary>
    [JsonPropertyName("providerEndpoint")]
    public string? ProviderEndpoint { get; set; }

    /// <summary>The name of the external provider where your third-party code repository is configured.</summary>
    [JsonPropertyName("providerType")]
    public string? ProviderType { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The CodeStar Host status. Possible values are PENDING, AVAILABLE, VPC_CONFIG_DELETING, VPC_CONFIG_INITIALIZING, and VPC_CONFIG_FAILED_INITIALIZATION.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The VPC configuration to be provisioned for the host. A VPC must be configured, and the infrastructure to be represented by the host must already be connected to the VPC.</summary>
    [JsonPropertyName("vpcConfiguration")]
    public V1beta1HostStatusAtProviderVpcConfiguration? VpcConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HostStatusConditions
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
/// <summary>HostStatus defines the observed state of Host.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HostStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1HostStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1HostStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Host is the Schema for the Hosts API. Provides a CodeStar Host</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Host : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HostSpec>, IStatus<V1beta1HostStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Host";
    public const string KubeGroup = "codestarconnections.aws.m.upbound.io";
    public const string KubePluralName = "hosts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HostSpec defines the desired state of Host</summary>
    [JsonPropertyName("spec")]
    public V1beta1HostSpec Spec { get; set; }

    /// <summary>HostStatus defines the observed state of Host.</summary>
    [JsonPropertyName("status")]
    public V1beta1HostStatus? Status { get; set; }
}
#nullable disable
