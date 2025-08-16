using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.m.upbound.io;
/// <summary>Classifier is the Schema for the Classifiers API. Provides an Glue Classifier resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClassifierList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Classifier>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClassifierList";
    public const string KubeGroup = "glue.aws.m.upbound.io";
    public const string KubePluralName = "classifiers";
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
    public IList<V1beta1Classifier> Items { get; set; }
}

/// <summary>A classifier for CSV content. Defined below.</summary>
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

    /// <summary>The delimiter used in the CSV to separate columns.</summary>
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

    /// <summary>The SerDe for processing CSV. Valid values are OpenCSVSerDe, LazySimpleSerDe, None.</summary>
    [JsonPropertyName("serde")]
    public string? Serde { get; set; }
}

/// <summary>A classifier that uses grok patterns. Defined below.</summary>
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

/// <summary>A classifier for JSON content. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecForProviderJsonClassifier
{
    /// <summary>A JsonPath string defining the JSON data for the classifier to classify. AWS Glue supports a subset of JsonPath, as described in Writing JsonPath Custom Classifiers.</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }
}

/// <summary>A classifier for XML content. Defined below.</summary>
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
    /// <summary>A classifier for CSV content. Defined below.</summary>
    [JsonPropertyName("csvClassifier")]
    public V1beta1ClassifierSpecForProviderCsvClassifier? CsvClassifier { get; set; }

    /// <summary>A classifier that uses grok patterns. Defined below.</summary>
    [JsonPropertyName("grokClassifier")]
    public V1beta1ClassifierSpecForProviderGrokClassifier? GrokClassifier { get; set; }

    /// <summary>A classifier for JSON content. Defined below.</summary>
    [JsonPropertyName("jsonClassifier")]
    public V1beta1ClassifierSpecForProviderJsonClassifier? JsonClassifier { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A classifier for XML content. Defined below.</summary>
    [JsonPropertyName("xmlClassifier")]
    public V1beta1ClassifierSpecForProviderXmlClassifier? XmlClassifier { get; set; }
}

/// <summary>A classifier for CSV content. Defined below.</summary>
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

    /// <summary>The delimiter used in the CSV to separate columns.</summary>
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

    /// <summary>The SerDe for processing CSV. Valid values are OpenCSVSerDe, LazySimpleSerDe, None.</summary>
    [JsonPropertyName("serde")]
    public string? Serde { get; set; }
}

/// <summary>A classifier that uses grok patterns. Defined below.</summary>
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

/// <summary>A classifier for JSON content. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecInitProviderJsonClassifier
{
    /// <summary>A JsonPath string defining the JSON data for the classifier to classify. AWS Glue supports a subset of JsonPath, as described in Writing JsonPath Custom Classifiers.</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }
}

/// <summary>A classifier for XML content. Defined below.</summary>
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
    /// <summary>A classifier for CSV content. Defined below.</summary>
    [JsonPropertyName("csvClassifier")]
    public V1beta1ClassifierSpecInitProviderCsvClassifier? CsvClassifier { get; set; }

    /// <summary>A classifier that uses grok patterns. Defined below.</summary>
    [JsonPropertyName("grokClassifier")]
    public V1beta1ClassifierSpecInitProviderGrokClassifier? GrokClassifier { get; set; }

    /// <summary>A classifier for JSON content. Defined below.</summary>
    [JsonPropertyName("jsonClassifier")]
    public V1beta1ClassifierSpecInitProviderJsonClassifier? JsonClassifier { get; set; }

    /// <summary>A classifier for XML content. Defined below.</summary>
    [JsonPropertyName("xmlClassifier")]
    public V1beta1ClassifierSpecInitProviderXmlClassifier? XmlClassifier { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ClassifierSpec defines the desired state of Classifier</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClassifierSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClassifierSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClassifierSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClassifierSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A classifier for CSV content. Defined below.</summary>
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

    /// <summary>The delimiter used in the CSV to separate columns.</summary>
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

    /// <summary>The SerDe for processing CSV. Valid values are OpenCSVSerDe, LazySimpleSerDe, None.</summary>
    [JsonPropertyName("serde")]
    public string? Serde { get; set; }
}

/// <summary>A classifier that uses grok patterns. Defined below.</summary>
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

/// <summary>A classifier for JSON content. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClassifierStatusAtProviderJsonClassifier
{
    /// <summary>A JsonPath string defining the JSON data for the classifier to classify. AWS Glue supports a subset of JsonPath, as described in Writing JsonPath Custom Classifiers.</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }
}

/// <summary>A classifier for XML content. Defined below.</summary>
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
    /// <summary>A classifier for CSV content. Defined below.</summary>
    [JsonPropertyName("csvClassifier")]
    public V1beta1ClassifierStatusAtProviderCsvClassifier? CsvClassifier { get; set; }

    /// <summary>A classifier that uses grok patterns. Defined below.</summary>
    [JsonPropertyName("grokClassifier")]
    public V1beta1ClassifierStatusAtProviderGrokClassifier? GrokClassifier { get; set; }

    /// <summary>Name of the classifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A classifier for JSON content. Defined below.</summary>
    [JsonPropertyName("jsonClassifier")]
    public V1beta1ClassifierStatusAtProviderJsonClassifier? JsonClassifier { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A classifier for XML content. Defined below.</summary>
    [JsonPropertyName("xmlClassifier")]
    public V1beta1ClassifierStatusAtProviderXmlClassifier? XmlClassifier { get; set; }
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
    public const string KubeGroup = "glue.aws.m.upbound.io";
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