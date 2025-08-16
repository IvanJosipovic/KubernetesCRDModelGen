using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.upbound.io;
/// <summary>APIOperation is the Schema for the APIOperations API. Manages an API Operation within an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1APIOperationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1APIOperation>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "APIOperationList";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "apioperations";
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
    public IList<V1beta1APIOperation> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderApiManagementNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderApiManagementNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIOperationSpecForProviderApiManagementNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderApiManagementNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderApiManagementNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIOperationSpecForProviderApiManagementNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderApiNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a API in apimanagement to populate apiName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderApiNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIOperationSpecForProviderApiNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderApiNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a API in apimanagement to populate apiName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderApiNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIOperationSpecForProviderApiNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderRequestHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderRequestHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecForProviderRequestHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderRequestQueryParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderRequestQueryParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecForProviderRequestQueryParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderRequestRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderRequestRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderRequestRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecForProviderRequestRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderRequestRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecForProviderRequestRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta1APIOperationSpecForProviderRequestRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderRequest
{
    /// <summary>A description of the HTTP Request, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1APIOperationSpecForProviderRequestHeader>? Header { get; set; }

    /// <summary>One or more query_parameter blocks as defined above.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1APIOperationSpecForProviderRequestQueryParameter>? QueryParameter { get; set; }

    /// <summary>One or more representation blocks as defined below.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta1APIOperationSpecForProviderRequestRepresentation>? Representation { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIOperationSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIOperationSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderResponseHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderResponseHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecForProviderResponseHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderResponseRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderResponseRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderResponseRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecForProviderResponseRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderResponseRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecForProviderResponseRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta1APIOperationSpecForProviderResponseRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderResponse
{
    /// <summary>A description of the HTTP Response, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1APIOperationSpecForProviderResponseHeader>? Header { get; set; }

    /// <summary>One or more representation blocks as defined below.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta1APIOperationSpecForProviderResponseRepresentation>? Representation { get; set; }

    /// <summary>The HTTP Status Code.</summary>
    [JsonPropertyName("statusCode")]
    public double? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderTemplateParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProviderTemplateParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecForProviderTemplateParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecForProvider
{
    /// <summary>The Name of the API Management Service where the API exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameRef")]
    public V1beta1APIOperationSpecForProviderApiManagementNameRef? ApiManagementNameRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameSelector")]
    public V1beta1APIOperationSpecForProviderApiManagementNameSelector? ApiManagementNameSelector { get; set; }

    /// <summary>The name of the API within the API Management Service where this API Operation should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiName")]
    public string? ApiName { get; set; }

    /// <summary>Reference to a API in apimanagement to populate apiName.</summary>
    [JsonPropertyName("apiNameRef")]
    public V1beta1APIOperationSpecForProviderApiNameRef? ApiNameRef { get; set; }

    /// <summary>Selector for a API in apimanagement to populate apiName.</summary>
    [JsonPropertyName("apiNameSelector")]
    public V1beta1APIOperationSpecForProviderApiNameSelector? ApiNameSelector { get; set; }

    /// <summary>A description for this API Operation, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this API Management Operation.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The HTTP Method used for this API Management Operation, like GET, DELETE, PUT or POST - but not limited to these values.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public IList<V1beta1APIOperationSpecForProviderRequest>? Request { get; set; }

    /// <summary>The Name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1APIOperationSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1APIOperationSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>One or more response blocks as defined below.</summary>
    [JsonPropertyName("response")]
    public IList<V1beta1APIOperationSpecForProviderResponse>? Response { get; set; }

    /// <summary>One or more template_parameter blocks as defined below. Required if url_template contains one or more parameters.</summary>
    [JsonPropertyName("templateParameter")]
    public IList<V1beta1APIOperationSpecForProviderTemplateParameter>? TemplateParameter { get; set; }

    /// <summary>The relative URL Template identifying the target resource for this operation, which may include parameters.</summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderRequestHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderRequestHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecInitProviderRequestHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderRequestQueryParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderRequestQueryParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecInitProviderRequestQueryParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderRequestRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderRequestRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderRequestRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecInitProviderRequestRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderRequestRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecInitProviderRequestRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta1APIOperationSpecInitProviderRequestRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderRequest
{
    /// <summary>A description of the HTTP Request, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1APIOperationSpecInitProviderRequestHeader>? Header { get; set; }

    /// <summary>One or more query_parameter blocks as defined above.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1APIOperationSpecInitProviderRequestQueryParameter>? QueryParameter { get; set; }

    /// <summary>One or more representation blocks as defined below.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta1APIOperationSpecInitProviderRequestRepresentation>? Representation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderResponseHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderResponseHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecInitProviderResponseHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderResponseRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderResponseRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderResponseRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecInitProviderResponseRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderResponseRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecInitProviderResponseRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta1APIOperationSpecInitProviderResponseRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderResponse
{
    /// <summary>A description of the HTTP Response, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1APIOperationSpecInitProviderResponseHeader>? Header { get; set; }

    /// <summary>One or more representation blocks as defined below.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta1APIOperationSpecInitProviderResponseRepresentation>? Representation { get; set; }

    /// <summary>The HTTP Status Code.</summary>
    [JsonPropertyName("statusCode")]
    public double? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderTemplateParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProviderTemplateParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationSpecInitProviderTemplateParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecInitProvider
{
    /// <summary>A description for this API Operation, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this API Management Operation.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The HTTP Method used for this API Management Operation, like GET, DELETE, PUT or POST - but not limited to these values.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public IList<V1beta1APIOperationSpecInitProviderRequest>? Request { get; set; }

    /// <summary>One or more response blocks as defined below.</summary>
    [JsonPropertyName("response")]
    public IList<V1beta1APIOperationSpecInitProviderResponse>? Response { get; set; }

    /// <summary>One or more template_parameter blocks as defined below. Required if url_template contains one or more parameters.</summary>
    [JsonPropertyName("templateParameter")]
    public IList<V1beta1APIOperationSpecInitProviderTemplateParameter>? TemplateParameter { get; set; }

    /// <summary>The relative URL Template identifying the target resource for this operation, which may include parameters.</summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecProviderConfigRefPolicy
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
public partial class V1beta1APIOperationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1APIOperationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>APIOperationSpec defines the desired state of APIOperation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1APIOperationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1APIOperationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1APIOperationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1APIOperationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderRequestHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderRequestHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationStatusAtProviderRequestHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderRequestQueryParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderRequestQueryParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationStatusAtProviderRequestQueryParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderRequestRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderRequestRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderRequestRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationStatusAtProviderRequestRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderRequestRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationStatusAtProviderRequestRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta1APIOperationStatusAtProviderRequestRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderRequest
{
    /// <summary>A description of the HTTP Request, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1APIOperationStatusAtProviderRequestHeader>? Header { get; set; }

    /// <summary>One or more query_parameter blocks as defined above.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1APIOperationStatusAtProviderRequestQueryParameter>? QueryParameter { get; set; }

    /// <summary>One or more representation blocks as defined below.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta1APIOperationStatusAtProviderRequestRepresentation>? Representation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderResponseHeaderExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderResponseHeader
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationStatusAtProviderResponseHeaderExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderResponseRepresentationExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderResponseRepresentationFormParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderResponseRepresentationFormParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationStatusAtProviderResponseRepresentationFormParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderResponseRepresentation
{
    /// <summary>The Content Type of this representation, such as application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationStatusAtProviderResponseRepresentationExample>? Example { get; set; }

    /// <summary>One or more form_parameter block as defined above.</summary>
    [JsonPropertyName("formParameter")]
    public IList<V1beta1APIOperationStatusAtProviderResponseRepresentationFormParameter>? FormParameter { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderResponse
{
    /// <summary>A description of the HTTP Response, which may include HTML tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more header blocks as defined above.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1APIOperationStatusAtProviderResponseHeader>? Header { get; set; }

    /// <summary>One or more representation blocks as defined below.</summary>
    [JsonPropertyName("representation")]
    public IList<V1beta1APIOperationStatusAtProviderResponseRepresentation>? Representation { get; set; }

    /// <summary>The HTTP Status Code.</summary>
    [JsonPropertyName("statusCode")]
    public double? StatusCode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderTemplateParameterExample
{
    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A URL that points to the literal example.</summary>
    [JsonPropertyName("externalValue")]
    public string? ExternalValue { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A short description for this example.</summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>The example of the representation.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProviderTemplateParameter
{
    /// <summary>The default value for this Template Parameter.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>A description of this Template Parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more example blocks as defined above.</summary>
    [JsonPropertyName("example")]
    public IList<V1beta1APIOperationStatusAtProviderTemplateParameterExample>? Example { get; set; }

    /// <summary>The Name of this Template Parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this Template Parameter Required?</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>The name of the Schema.</summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>The Type of this Template Parameter, such as a string.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The type name defined by the Schema.</summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }

    /// <summary>One or more acceptable values for this Template Parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusAtProvider
{
    /// <summary>The Name of the API Management Service where the API exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>The name of the API within the API Management Service where this API Operation should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiName")]
    public string? ApiName { get; set; }

    /// <summary>A description for this API Operation, which may include HTML formatting tags.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Display Name for this API Management Operation.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the API Management API Operation.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The HTTP Method used for this API Management Operation, like GET, DELETE, PUT or POST - but not limited to these values.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>A request block as defined below.</summary>
    [JsonPropertyName("request")]
    public IList<V1beta1APIOperationStatusAtProviderRequest>? Request { get; set; }

    /// <summary>The Name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>One or more response blocks as defined below.</summary>
    [JsonPropertyName("response")]
    public IList<V1beta1APIOperationStatusAtProviderResponse>? Response { get; set; }

    /// <summary>One or more template_parameter blocks as defined below. Required if url_template contains one or more parameters.</summary>
    [JsonPropertyName("templateParameter")]
    public IList<V1beta1APIOperationStatusAtProviderTemplateParameter>? TemplateParameter { get; set; }

    /// <summary>The relative URL Template identifying the target resource for this operation, which may include parameters.</summary>
    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatusConditions
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

/// <summary>APIOperationStatus defines the observed state of APIOperation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1APIOperationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1APIOperationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1APIOperationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>APIOperation is the Schema for the APIOperations API. Manages an API Operation within an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1APIOperation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1APIOperationSpec>, IStatus<V1beta1APIOperationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "APIOperation";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "apioperations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APIOperationSpec defines the desired state of APIOperation</summary>
    [JsonPropertyName("spec")]
    public V1beta1APIOperationSpec Spec { get; set; }

    /// <summary>APIOperationStatus defines the observed state of APIOperation.</summary>
    [JsonPropertyName("status")]
    public V1beta1APIOperationStatus? Status { get; set; }
}