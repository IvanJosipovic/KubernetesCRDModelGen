using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ClassifierSpecDeletionPolicyEnum
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
public partial class V1beta1ClassifierSpecForProviderCsvClassifier
{
    /// <summary>Enables the processing of files that contain only one column.</summary>
    [JsonPropertyName("allowSingleColumn")]
    public bool? AllowSingleColumn { get; set; }

    /// <summary>Indicates whether the CSV file contains a header. This can be one of "ABSENT", "PRESENT", or "UNKNOWN".</summary>
    [JsonPropertyName("containsHeader")]
    public string? ContainsHeader { get; set; }

    /// <summary>Enables the custom datatype to be configured.</summary>
    [JsonPropertyName("customDatatypeConfigured")]
    public bool? CustomDatatypeConfigured { get; set; }

    /// <summary>A list of supported custom datatypes. Valid values are BINARY, BOOLEAN, DATE, DECIMAL, DOUBLE, FLOAT, INT, LONG, SHORT, STRING, TIMESTAMP.</summary>
    [JsonPropertyName("customDatatypes")]
    public IList<string>? CustomDatatypes { get; set; }

    /// <summary>The delimiter used in the Csv to separate columns.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>Specifies whether to trim column values.</summary>
    [JsonPropertyName("disableValueTrimming")]
    public bool? DisableValueTrimming { get; set; }

    /// <summary>A list of strings representing column names.</summary>
    [JsonPropertyName("header")]
    public IList<string>? Header { get; set; }

    /// <summary>A custom symbol to denote what combines content into a single column value. It must be different from the column delimiter.</summary>
    [JsonPropertyName("quoteSymbol")]
    public string? QuoteSymbol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serde")]
    public string? Serde { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecForProviderGrokClassifier
{
    /// <summary>An identifier of the data format that the classifier matches, such as Twitter, JSON, Omniture logs, Amazon CloudWatch Logs, and so on.</summary>
    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    /// <summary>Custom grok patterns used by this classifier.</summary>
    [JsonPropertyName("customPatterns")]
    public string? CustomPatterns { get; set; }

    /// <summary>The grok pattern used by this classifier.</summary>
    [JsonPropertyName("grokPattern")]
    public string? GrokPattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecForProviderJsonClassifier
{
    /// <summary>A JsonPath string defining the JSON data for the classifier to classify. AWS Glue supports a subset of JsonPath, as described in Writing JsonPath Custom Classifiers.</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecForProviderXmlClassifier
{
    /// <summary>An identifier of the data format that the classifier matches.</summary>
    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    /// <summary>The XML tag designating the element that contains each record in an XML document being parsed. Note that this cannot identify a self-closing element (closed by /&gt;). An empty row element that contains only attributes can be parsed as long as it ends with a closing tag (for example, &lt;row item_a="A" item_b="B"&gt;&lt;/row&gt; is okay, but &lt;row item_a="A" item_b="B" /&gt; is not).</summary>
    [JsonPropertyName("rowTag")]
    public string? RowTag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecForProvider
{
    /// <summary>A classifier for Csv content. Defined below.</summary>
    [JsonPropertyName("csvClassifier")]
    public IList<V1beta1ClassifierSpecForProviderCsvClassifier>? CsvClassifier { get; set; }

    /// <summary>–  A classifier that uses grok patterns. Defined below.</summary>
    [JsonPropertyName("grokClassifier")]
    public IList<V1beta1ClassifierSpecForProviderGrokClassifier>? GrokClassifier { get; set; }

    /// <summary>–  A classifier for JSON content. Defined below.</summary>
    [JsonPropertyName("jsonClassifier")]
    public IList<V1beta1ClassifierSpecForProviderJsonClassifier>? JsonClassifier { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>–  A classifier for XML content. Defined below.</summary>
    [JsonPropertyName("xmlClassifier")]
    public IList<V1beta1ClassifierSpecForProviderXmlClassifier>? XmlClassifier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecInitProviderCsvClassifier
{
    /// <summary>Enables the processing of files that contain only one column.</summary>
    [JsonPropertyName("allowSingleColumn")]
    public bool? AllowSingleColumn { get; set; }

    /// <summary>Indicates whether the CSV file contains a header. This can be one of "ABSENT", "PRESENT", or "UNKNOWN".</summary>
    [JsonPropertyName("containsHeader")]
    public string? ContainsHeader { get; set; }

    /// <summary>Enables the custom datatype to be configured.</summary>
    [JsonPropertyName("customDatatypeConfigured")]
    public bool? CustomDatatypeConfigured { get; set; }

    /// <summary>A list of supported custom datatypes. Valid values are BINARY, BOOLEAN, DATE, DECIMAL, DOUBLE, FLOAT, INT, LONG, SHORT, STRING, TIMESTAMP.</summary>
    [JsonPropertyName("customDatatypes")]
    public IList<string>? CustomDatatypes { get; set; }

    /// <summary>The delimiter used in the Csv to separate columns.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>Specifies whether to trim column values.</summary>
    [JsonPropertyName("disableValueTrimming")]
    public bool? DisableValueTrimming { get; set; }

    /// <summary>A list of strings representing column names.</summary>
    [JsonPropertyName("header")]
    public IList<string>? Header { get; set; }

    /// <summary>A custom symbol to denote what combines content into a single column value. It must be different from the column delimiter.</summary>
    [JsonPropertyName("quoteSymbol")]
    public string? QuoteSymbol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serde")]
    public string? Serde { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecInitProviderGrokClassifier
{
    /// <summary>An identifier of the data format that the classifier matches, such as Twitter, JSON, Omniture logs, Amazon CloudWatch Logs, and so on.</summary>
    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    /// <summary>Custom grok patterns used by this classifier.</summary>
    [JsonPropertyName("customPatterns")]
    public string? CustomPatterns { get; set; }

    /// <summary>The grok pattern used by this classifier.</summary>
    [JsonPropertyName("grokPattern")]
    public string? GrokPattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecInitProviderJsonClassifier
{
    /// <summary>A JsonPath string defining the JSON data for the classifier to classify. AWS Glue supports a subset of JsonPath, as described in Writing JsonPath Custom Classifiers.</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecInitProviderXmlClassifier
{
    /// <summary>An identifier of the data format that the classifier matches.</summary>
    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    /// <summary>The XML tag designating the element that contains each record in an XML document being parsed. Note that this cannot identify a self-closing element (closed by /&gt;). An empty row element that contains only attributes can be parsed as long as it ends with a closing tag (for example, &lt;row item_a="A" item_b="B"&gt;&lt;/row&gt; is okay, but &lt;row item_a="A" item_b="B" /&gt; is not).</summary>
    [JsonPropertyName("rowTag")]
    public string? RowTag { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecInitProvider
{
    /// <summary>A classifier for Csv content. Defined below.</summary>
    [JsonPropertyName("csvClassifier")]
    public IList<V1beta1ClassifierSpecInitProviderCsvClassifier>? CsvClassifier { get; set; }

    /// <summary>–  A classifier that uses grok patterns. Defined below.</summary>
    [JsonPropertyName("grokClassifier")]
    public IList<V1beta1ClassifierSpecInitProviderGrokClassifier>? GrokClassifier { get; set; }

    /// <summary>–  A classifier for JSON content. Defined below.</summary>
    [JsonPropertyName("jsonClassifier")]
    public IList<V1beta1ClassifierSpecInitProviderJsonClassifier>? JsonClassifier { get; set; }

    /// <summary>–  A classifier for XML content. Defined below.</summary>
    [JsonPropertyName("xmlClassifier")]
    public IList<V1beta1ClassifierSpecInitProviderXmlClassifier>? XmlClassifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ClassifierSpecManagementPoliciesEnum
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
public enum V1beta1ClassifierSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ClassifierSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1ClassifierSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClassifierSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ClassifierSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClassifierSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ClassifierSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClassifierSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ClassifierSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1ClassifierSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1ClassifierSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClassifierSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ClassifierSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClassifierSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ClassifierSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClassifierSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ClassifierSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ClassifierSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ClassifierSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ClassifierSpec defines the desired state of Classifier</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClassifierSpecDeletionPolicyEnum>))]
    public V1beta1ClassifierSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClassifierSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClassifierSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ClassifierSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClassifierSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ClassifierSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClassifierSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierStatusAtProviderCsvClassifier
{
    /// <summary>Enables the processing of files that contain only one column.</summary>
    [JsonPropertyName("allowSingleColumn")]
    public bool? AllowSingleColumn { get; set; }

    /// <summary>Indicates whether the CSV file contains a header. This can be one of "ABSENT", "PRESENT", or "UNKNOWN".</summary>
    [JsonPropertyName("containsHeader")]
    public string? ContainsHeader { get; set; }

    /// <summary>Enables the custom datatype to be configured.</summary>
    [JsonPropertyName("customDatatypeConfigured")]
    public bool? CustomDatatypeConfigured { get; set; }

    /// <summary>A list of supported custom datatypes. Valid values are BINARY, BOOLEAN, DATE, DECIMAL, DOUBLE, FLOAT, INT, LONG, SHORT, STRING, TIMESTAMP.</summary>
    [JsonPropertyName("customDatatypes")]
    public IList<string>? CustomDatatypes { get; set; }

    /// <summary>The delimiter used in the Csv to separate columns.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>Specifies whether to trim column values.</summary>
    [JsonPropertyName("disableValueTrimming")]
    public bool? DisableValueTrimming { get; set; }

    /// <summary>A list of strings representing column names.</summary>
    [JsonPropertyName("header")]
    public IList<string>? Header { get; set; }

    /// <summary>A custom symbol to denote what combines content into a single column value. It must be different from the column delimiter.</summary>
    [JsonPropertyName("quoteSymbol")]
    public string? QuoteSymbol { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serde")]
    public string? Serde { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierStatusAtProviderGrokClassifier
{
    /// <summary>An identifier of the data format that the classifier matches, such as Twitter, JSON, Omniture logs, Amazon CloudWatch Logs, and so on.</summary>
    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    /// <summary>Custom grok patterns used by this classifier.</summary>
    [JsonPropertyName("customPatterns")]
    public string? CustomPatterns { get; set; }

    /// <summary>The grok pattern used by this classifier.</summary>
    [JsonPropertyName("grokPattern")]
    public string? GrokPattern { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierStatusAtProviderJsonClassifier
{
    /// <summary>A JsonPath string defining the JSON data for the classifier to classify. AWS Glue supports a subset of JsonPath, as described in Writing JsonPath Custom Classifiers.</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierStatusAtProviderXmlClassifier
{
    /// <summary>An identifier of the data format that the classifier matches.</summary>
    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    /// <summary>The XML tag designating the element that contains each record in an XML document being parsed. Note that this cannot identify a self-closing element (closed by /&gt;). An empty row element that contains only attributes can be parsed as long as it ends with a closing tag (for example, &lt;row item_a="A" item_b="B"&gt;&lt;/row&gt; is okay, but &lt;row item_a="A" item_b="B" /&gt; is not).</summary>
    [JsonPropertyName("rowTag")]
    public string? RowTag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierStatusAtProvider
{
    /// <summary>A classifier for Csv content. Defined below.</summary>
    [JsonPropertyName("csvClassifier")]
    public IList<V1beta1ClassifierStatusAtProviderCsvClassifier>? CsvClassifier { get; set; }

    /// <summary>–  A classifier that uses grok patterns. Defined below.</summary>
    [JsonPropertyName("grokClassifier")]
    public IList<V1beta1ClassifierStatusAtProviderGrokClassifier>? GrokClassifier { get; set; }

    /// <summary>Name of the classifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>–  A classifier for JSON content. Defined below.</summary>
    [JsonPropertyName("jsonClassifier")]
    public IList<V1beta1ClassifierStatusAtProviderJsonClassifier>? JsonClassifier { get; set; }

    /// <summary>–  A classifier for XML content. Defined below.</summary>
    [JsonPropertyName("xmlClassifier")]
    public IList<V1beta1ClassifierStatusAtProviderXmlClassifier>? XmlClassifier { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierStatusConditions
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

/// <summary>ClassifierStatus defines the observed state of Classifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ClassifierStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClassifierStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Classifier is the Schema for the Classifiers API. Provides an Glue Classifier resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Classifier : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClassifierSpec>, IStatus<V1beta1ClassifierStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Classifier";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "classifiers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClassifierSpec defines the desired state of Classifier</summary>
    [JsonPropertyName("spec")]
    public V1beta1ClassifierSpec Spec { get; set; }

    /// <summary>ClassifierStatus defines the observed state of Classifier.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClassifierStatus? Status { get; set; }
}