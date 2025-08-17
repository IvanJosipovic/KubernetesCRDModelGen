using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudsearch.aws.m.upbound.io;
#nullable enable
/// <summary>Domain is the Schema for the Domains API. Provides an CloudSearch domain resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DomainList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Domain>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DomainList";
    public const string KubeGroup = "cloudsearch.aws.m.upbound.io";
    public const string KubePluralName = "domains";
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
    public IList<V1beta1Domain> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Domain endpoint options. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderEndpointOptions
{
    /// <summary>Enables or disables the requirement that all requests to the domain arrive over HTTPS.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>The minimum required TLS version. See the AWS documentation for valid values.</summary>
    [JsonPropertyName("tlsSecurityPolicy")]
    public string? TlsSecurityPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderIndexField
{
    /// <summary>The analysis scheme you want to use for a text field. The analysis scheme specifies the language-specific text processing options that are used during indexing.</summary>
    [JsonPropertyName("analysisScheme")]
    public string? AnalysisScheme { get; set; }

    /// <summary>The default value for the field. This value is used when no value is specified for the field in the document data.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>You can get facet information by enabling this.</summary>
    [JsonPropertyName("facet")]
    public bool? Facet { get; set; }

    /// <summary>You can highlight information.</summary>
    [JsonPropertyName("highlight")]
    public bool? Highlight { get; set; }

    /// <summary>The name of the CloudSearch domain.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>You can enable returning the value of all searchable fields.</summary>
    [JsonPropertyName("return")]
    public bool? Return { get; set; }

    /// <summary>You can set whether this index should be searchable or not.</summary>
    [JsonPropertyName("search")]
    public bool? Search { get; set; }

    /// <summary>You can enable the property to be sortable.</summary>
    [JsonPropertyName("sort")]
    public bool? Sort { get; set; }

    /// <summary>A comma-separated list of source fields to map to the field. Specifying a source field copies data from one field to another, enabling you to use the same source data in different ways by configuring different options for the fields.</summary>
    [JsonPropertyName("sourceFields")]
    public string? SourceFields { get; set; }

    /// <summary>The field type. Valid values: date, date-array, double, double-array, int, int-array, literal, literal-array, text, text-array.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Domain scaling parameters. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProviderScalingParameters
{
    /// <summary>The instance type that you want to preconfigure for your domain. See the AWS documentation for valid values.</summary>
    [JsonPropertyName("desiredInstanceType")]
    public string? DesiredInstanceType { get; set; }

    /// <summary>The number of partitions you want to preconfigure for your domain. Only valid when you select search.2xlarge as the instance type.</summary>
    [JsonPropertyName("desiredPartitionCount")]
    public double? DesiredPartitionCount { get; set; }

    /// <summary>The number of replicas you want to preconfigure for each index partition.</summary>
    [JsonPropertyName("desiredReplicationCount")]
    public double? DesiredReplicationCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProvider
{
    /// <summary>Domain endpoint options. Documented below.</summary>
    [JsonPropertyName("endpointOptions")]
    public V1beta1DomainSpecForProviderEndpointOptions? EndpointOptions { get; set; }

    /// <summary>The index fields for documents added to the domain. Documented below.</summary>
    [JsonPropertyName("indexField")]
    public IList<V1beta1DomainSpecForProviderIndexField>? IndexField { get; set; }

    /// <summary>Whether or not to maintain extra instances for the domain in a second Availability Zone to ensure high availability.</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Domain scaling parameters. Documented below.</summary>
    [JsonPropertyName("scalingParameters")]
    public V1beta1DomainSpecForProviderScalingParameters? ScalingParameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Domain endpoint options. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderEndpointOptions
{
    /// <summary>Enables or disables the requirement that all requests to the domain arrive over HTTPS.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>The minimum required TLS version. See the AWS documentation for valid values.</summary>
    [JsonPropertyName("tlsSecurityPolicy")]
    public string? TlsSecurityPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderIndexField
{
    /// <summary>The analysis scheme you want to use for a text field. The analysis scheme specifies the language-specific text processing options that are used during indexing.</summary>
    [JsonPropertyName("analysisScheme")]
    public string? AnalysisScheme { get; set; }

    /// <summary>The default value for the field. This value is used when no value is specified for the field in the document data.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>You can get facet information by enabling this.</summary>
    [JsonPropertyName("facet")]
    public bool? Facet { get; set; }

    /// <summary>You can highlight information.</summary>
    [JsonPropertyName("highlight")]
    public bool? Highlight { get; set; }

    /// <summary>The name of the CloudSearch domain.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>You can enable returning the value of all searchable fields.</summary>
    [JsonPropertyName("return")]
    public bool? Return { get; set; }

    /// <summary>You can set whether this index should be searchable or not.</summary>
    [JsonPropertyName("search")]
    public bool? Search { get; set; }

    /// <summary>You can enable the property to be sortable.</summary>
    [JsonPropertyName("sort")]
    public bool? Sort { get; set; }

    /// <summary>A comma-separated list of source fields to map to the field. Specifying a source field copies data from one field to another, enabling you to use the same source data in different ways by configuring different options for the fields.</summary>
    [JsonPropertyName("sourceFields")]
    public string? SourceFields { get; set; }

    /// <summary>The field type. Valid values: date, date-array, double, double-array, int, int-array, literal, literal-array, text, text-array.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Domain scaling parameters. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProviderScalingParameters
{
    /// <summary>The instance type that you want to preconfigure for your domain. See the AWS documentation for valid values.</summary>
    [JsonPropertyName("desiredInstanceType")]
    public string? DesiredInstanceType { get; set; }

    /// <summary>The number of partitions you want to preconfigure for your domain. Only valid when you select search.2xlarge as the instance type.</summary>
    [JsonPropertyName("desiredPartitionCount")]
    public double? DesiredPartitionCount { get; set; }

    /// <summary>The number of replicas you want to preconfigure for each index partition.</summary>
    [JsonPropertyName("desiredReplicationCount")]
    public double? DesiredReplicationCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProvider
{
    /// <summary>Domain endpoint options. Documented below.</summary>
    [JsonPropertyName("endpointOptions")]
    public V1beta1DomainSpecInitProviderEndpointOptions? EndpointOptions { get; set; }

    /// <summary>The index fields for documents added to the domain. Documented below.</summary>
    [JsonPropertyName("indexField")]
    public IList<V1beta1DomainSpecInitProviderIndexField>? IndexField { get; set; }

    /// <summary>Whether or not to maintain extra instances for the domain in a second Availability Zone to ensure high availability.</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>Domain scaling parameters. Documented below.</summary>
    [JsonPropertyName("scalingParameters")]
    public V1beta1DomainSpecInitProviderScalingParameters? ScalingParameters { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecProviderConfigRef
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
public partial class V1beta1DomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DomainSpec defines the desired state of Domain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DomainSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DomainSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Domain endpoint options. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderEndpointOptions
{
    /// <summary>Enables or disables the requirement that all requests to the domain arrive over HTTPS.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>The minimum required TLS version. See the AWS documentation for valid values.</summary>
    [JsonPropertyName("tlsSecurityPolicy")]
    public string? TlsSecurityPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderIndexField
{
    /// <summary>The analysis scheme you want to use for a text field. The analysis scheme specifies the language-specific text processing options that are used during indexing.</summary>
    [JsonPropertyName("analysisScheme")]
    public string? AnalysisScheme { get; set; }

    /// <summary>The default value for the field. This value is used when no value is specified for the field in the document data.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>You can get facet information by enabling this.</summary>
    [JsonPropertyName("facet")]
    public bool? Facet { get; set; }

    /// <summary>You can highlight information.</summary>
    [JsonPropertyName("highlight")]
    public bool? Highlight { get; set; }

    /// <summary>The name of the CloudSearch domain.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>You can enable returning the value of all searchable fields.</summary>
    [JsonPropertyName("return")]
    public bool? Return { get; set; }

    /// <summary>You can set whether this index should be searchable or not.</summary>
    [JsonPropertyName("search")]
    public bool? Search { get; set; }

    /// <summary>You can enable the property to be sortable.</summary>
    [JsonPropertyName("sort")]
    public bool? Sort { get; set; }

    /// <summary>A comma-separated list of source fields to map to the field. Specifying a source field copies data from one field to another, enabling you to use the same source data in different ways by configuring different options for the fields.</summary>
    [JsonPropertyName("sourceFields")]
    public string? SourceFields { get; set; }

    /// <summary>The field type. Valid values: date, date-array, double, double-array, int, int-array, literal, literal-array, text, text-array.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Domain scaling parameters. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProviderScalingParameters
{
    /// <summary>The instance type that you want to preconfigure for your domain. See the AWS documentation for valid values.</summary>
    [JsonPropertyName("desiredInstanceType")]
    public string? DesiredInstanceType { get; set; }

    /// <summary>The number of partitions you want to preconfigure for your domain. Only valid when you select search.2xlarge as the instance type.</summary>
    [JsonPropertyName("desiredPartitionCount")]
    public double? DesiredPartitionCount { get; set; }

    /// <summary>The number of replicas you want to preconfigure for each index partition.</summary>
    [JsonPropertyName("desiredReplicationCount")]
    public double? DesiredReplicationCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusAtProvider
{
    /// <summary>The domain's ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The service endpoint for updating documents in a search domain.</summary>
    [JsonPropertyName("documentServiceEndpoint")]
    public string? DocumentServiceEndpoint { get; set; }

    /// <summary>An internally generated unique identifier for the domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Domain endpoint options. Documented below.</summary>
    [JsonPropertyName("endpointOptions")]
    public V1beta1DomainStatusAtProviderEndpointOptions? EndpointOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The index fields for documents added to the domain. Documented below.</summary>
    [JsonPropertyName("indexField")]
    public IList<V1beta1DomainStatusAtProviderIndexField>? IndexField { get; set; }

    /// <summary>Whether or not to maintain extra instances for the domain in a second Availability Zone to ensure high availability.</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Domain scaling parameters. Documented below.</summary>
    [JsonPropertyName("scalingParameters")]
    public V1beta1DomainStatusAtProviderScalingParameters? ScalingParameters { get; set; }

    /// <summary>The service endpoint for requesting search results from a search domain.</summary>
    [JsonPropertyName("searchServiceEndpoint")]
    public string? SearchServiceEndpoint { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatusConditions
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
/// <summary>DomainStatus defines the observed state of Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DomainStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Domain is the Schema for the Domains API. Provides an CloudSearch domain resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DomainSpec>, IStatus<V1beta1DomainStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "cloudsearch.aws.m.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainSpec defines the desired state of Domain</summary>
    [JsonPropertyName("spec")]
    public V1beta1DomainSpec Spec { get; set; }

    /// <summary>DomainStatus defines the observed state of Domain.</summary>
    [JsonPropertyName("status")]
    public V1beta1DomainStatus? Status { get; set; }
}
#nullable disable
