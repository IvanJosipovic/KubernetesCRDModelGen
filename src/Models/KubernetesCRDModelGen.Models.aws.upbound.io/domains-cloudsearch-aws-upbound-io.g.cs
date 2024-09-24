using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudsearch.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
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

/// <summary></summary>
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecForProvider
{
    /// <summary>Domain endpoint options. Documented below.</summary>
    [JsonPropertyName("endpointOptions")]
    public IList<V1beta1DomainSpecForProviderEndpointOptions>? EndpointOptions { get; set; }

    /// <summary>The index fields for documents added to the domain. Documented below.</summary>
    [JsonPropertyName("indexField")]
    public IList<V1beta1DomainSpecForProviderIndexField>? IndexField { get; set; }

    /// <summary>Whether or not to maintain extra instances for the domain in a second Availability Zone to ensure high availability.</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Domain scaling parameters. Documented below.</summary>
    [JsonPropertyName("scalingParameters")]
    public IList<V1beta1DomainSpecForProviderScalingParameters>? ScalingParameters { get; set; }
}

/// <summary></summary>
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

/// <summary></summary>
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

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecInitProvider
{
    /// <summary>Domain endpoint options. Documented below.</summary>
    [JsonPropertyName("endpointOptions")]
    public IList<V1beta1DomainSpecInitProviderEndpointOptions>? EndpointOptions { get; set; }

    /// <summary>The index fields for documents added to the domain. Documented below.</summary>
    [JsonPropertyName("indexField")]
    public IList<V1beta1DomainSpecInitProviderIndexField>? IndexField { get; set; }

    /// <summary>Whether or not to maintain extra instances for the domain in a second Availability Zone to ensure high availability.</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>Domain scaling parameters. Documented below.</summary>
    [JsonPropertyName("scalingParameters")]
    public IList<V1beta1DomainSpecInitProviderScalingParameters>? ScalingParameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DomainSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DomainSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DomainSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DomainSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DomainSpec defines the desired state of Domain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainSpecDeletionPolicyEnum>))]
    public V1beta1DomainSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DomainSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DomainSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DomainSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DomainSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
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

/// <summary></summary>
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
    public IList<V1beta1DomainStatusAtProviderEndpointOptions>? EndpointOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The index fields for documents added to the domain. Documented below.</summary>
    [JsonPropertyName("indexField")]
    public IList<V1beta1DomainStatusAtProviderIndexField>? IndexField { get; set; }

    /// <summary>Whether or not to maintain extra instances for the domain in a second Availability Zone to ensure high availability.</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>Domain scaling parameters. Documented below.</summary>
    [JsonPropertyName("scalingParameters")]
    public IList<V1beta1DomainStatusAtProviderScalingParameters>? ScalingParameters { get; set; }

    /// <summary>The service endpoint for requesting search results from a search domain.</summary>
    [JsonPropertyName("searchServiceEndpoint")]
    public string? SearchServiceEndpoint { get; set; }
}

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

/// <summary>Domain is the Schema for the Domains API. Provides an CloudSearch domain resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DomainSpec>, IStatus<V1beta1DomainStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "cloudsearch.aws.upbound.io";
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