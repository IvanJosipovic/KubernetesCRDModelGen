using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.upbound.io;
/// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderDataFactoryIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderDataFactoryIdRefPolicyResolveEnum
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
public partial class V1beta1DataFlowSpecForProviderDataFactoryIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderDataFactoryIdRefPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecForProviderDataFactoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderDataFactoryIdRefPolicyResolveEnum>))]
    public V1beta1DataFlowSpecForProviderDataFactoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderDataFactoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderDataFactoryIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderDataFactoryIdSelectorPolicyResolveEnum>))]
    public V1beta1DataFlowSpecForProviderDataFactoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderDataFactoryIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderSinkDatasetNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderSinkDatasetNameRefPolicyResolveEnum
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
public partial class V1beta1DataFlowSpecForProviderSinkDatasetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderSinkDatasetNameRefPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecForProviderSinkDatasetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderSinkDatasetNameRefPolicyResolveEnum>))]
    public V1beta1DataFlowSpecForProviderSinkDatasetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DataSetJSON in datafactory to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSinkDatasetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecForProviderSinkDatasetNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderSinkDatasetNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderSinkDatasetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSinkDatasetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderSinkDatasetNameSelectorPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecForProviderSinkDatasetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderSinkDatasetNameSelectorPolicyResolveEnum>))]
    public V1beta1DataFlowSpecForProviderSinkDatasetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DataSetJSON in datafactory to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSinkDatasetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecForProviderSinkDatasetNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSinkDataset
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a DataSetJSON in datafactory to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DataFlowSpecForProviderSinkDatasetNameRef? NameRef { get; set; }

    /// <summary>Selector for a DataSetJSON in datafactory to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1DataFlowSpecForProviderSinkDatasetNameSelector? NameSelector { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSinkFlowlet
{
    /// <summary>Specifies the reference data flow parameters from dataset.</summary>
    [JsonPropertyName("datasetParameters")]
    public string? DatasetParameters { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSinkLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSinkRejectedLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSinkSchemaLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSink
{
    /// <summary>A dataset block as defined below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DataFlowSpecForProviderSinkDataset>? Dataset { get; set; }

    /// <summary>The description for the Data Flow Source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flowlet block as defined below.</summary>
    [JsonPropertyName("flowlet")]
    public IList<V1beta1DataFlowSpecForProviderSinkFlowlet>? Flowlet { get; set; }

    /// <summary>A linked_service block as defined below.</summary>
    [JsonPropertyName("linkedService")]
    public IList<V1beta1DataFlowSpecForProviderSinkLinkedService>? LinkedService { get; set; }

    /// <summary>The name for the Data Flow Source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A rejected_linked_service block as defined below.</summary>
    [JsonPropertyName("rejectedLinkedService")]
    public IList<V1beta1DataFlowSpecForProviderSinkRejectedLinkedService>? RejectedLinkedService { get; set; }

    /// <summary>A schema_linked_service block as defined below.</summary>
    [JsonPropertyName("schemaLinkedService")]
    public IList<V1beta1DataFlowSpecForProviderSinkSchemaLinkedService>? SchemaLinkedService { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderSourceDatasetNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderSourceDatasetNameRefPolicyResolveEnum
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
public partial class V1beta1DataFlowSpecForProviderSourceDatasetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderSourceDatasetNameRefPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecForProviderSourceDatasetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderSourceDatasetNameRefPolicyResolveEnum>))]
    public V1beta1DataFlowSpecForProviderSourceDatasetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DataSetJSON in datafactory to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSourceDatasetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecForProviderSourceDatasetNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderSourceDatasetNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecForProviderSourceDatasetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSourceDatasetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderSourceDatasetNameSelectorPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecForProviderSourceDatasetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecForProviderSourceDatasetNameSelectorPolicyResolveEnum>))]
    public V1beta1DataFlowSpecForProviderSourceDatasetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DataSetJSON in datafactory to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSourceDatasetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecForProviderSourceDatasetNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSourceDataset
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a DataSetJSON in datafactory to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DataFlowSpecForProviderSourceDatasetNameRef? NameRef { get; set; }

    /// <summary>Selector for a DataSetJSON in datafactory to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1DataFlowSpecForProviderSourceDatasetNameSelector? NameSelector { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSourceFlowlet
{
    /// <summary>Specifies the reference data flow parameters from dataset.</summary>
    [JsonPropertyName("datasetParameters")]
    public string? DatasetParameters { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSourceLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSourceRejectedLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSourceSchemaLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSource
{
    /// <summary>A dataset block as defined below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DataFlowSpecForProviderSourceDataset>? Dataset { get; set; }

    /// <summary>The description for the Data Flow Source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flowlet block as defined below.</summary>
    [JsonPropertyName("flowlet")]
    public IList<V1beta1DataFlowSpecForProviderSourceFlowlet>? Flowlet { get; set; }

    /// <summary>A linked_service block as defined below.</summary>
    [JsonPropertyName("linkedService")]
    public IList<V1beta1DataFlowSpecForProviderSourceLinkedService>? LinkedService { get; set; }

    /// <summary>The name for the Data Flow Source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A rejected_linked_service block as defined below.</summary>
    [JsonPropertyName("rejectedLinkedService")]
    public IList<V1beta1DataFlowSpecForProviderSourceRejectedLinkedService>? RejectedLinkedService { get; set; }

    /// <summary>A schema_linked_service block as defined below.</summary>
    [JsonPropertyName("schemaLinkedService")]
    public IList<V1beta1DataFlowSpecForProviderSourceSchemaLinkedService>? SchemaLinkedService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderTransformationDataset
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderTransformationFlowlet
{
    /// <summary>Specifies the reference data flow parameters from dataset.</summary>
    [JsonPropertyName("datasetParameters")]
    public string? DatasetParameters { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderTransformationLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderTransformation
{
    /// <summary>A dataset block as defined below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DataFlowSpecForProviderTransformationDataset>? Dataset { get; set; }

    /// <summary>The description for the Data Flow transformation.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flowlet block as defined below.</summary>
    [JsonPropertyName("flowlet")]
    public IList<V1beta1DataFlowSpecForProviderTransformationFlowlet>? Flowlet { get; set; }

    /// <summary>A linked_service block as defined below.</summary>
    [JsonPropertyName("linkedService")]
    public IList<V1beta1DataFlowSpecForProviderTransformationLinkedService>? LinkedService { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProvider
{
    /// <summary>List of tags that can be used for describing the Data Factory Data Flow.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The ID of Data Factory in which to associate the Data Flow with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta1DataFlowSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta1DataFlowSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>The description for the Data Factory Data Flow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The folder that this Data Flow is in. If not specified, the Data Flow will appear at the root level.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>The script for the Data Factory Data Flow.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>The script lines for the Data Factory Data Flow.</summary>
    [JsonPropertyName("scriptLines")]
    public IList<string>? ScriptLines { get; set; }

    /// <summary>One or more sink blocks as defined below.</summary>
    [JsonPropertyName("sink")]
    public IList<V1beta1DataFlowSpecForProviderSink>? Sink { get; set; }

    /// <summary>One or more source blocks as defined below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1DataFlowSpecForProviderSource>? Source { get; set; }

    /// <summary>One or more transformation blocks as defined below.</summary>
    [JsonPropertyName("transformation")]
    public IList<V1beta1DataFlowSpecForProviderTransformation>? Transformation { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecInitProviderSinkDatasetNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecInitProviderSinkDatasetNameRefPolicyResolveEnum
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
public partial class V1beta1DataFlowSpecInitProviderSinkDatasetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecInitProviderSinkDatasetNameRefPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecInitProviderSinkDatasetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecInitProviderSinkDatasetNameRefPolicyResolveEnum>))]
    public V1beta1DataFlowSpecInitProviderSinkDatasetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DataSetJSON in datafactory to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSinkDatasetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecInitProviderSinkDatasetNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecInitProviderSinkDatasetNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecInitProviderSinkDatasetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSinkDatasetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecInitProviderSinkDatasetNameSelectorPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecInitProviderSinkDatasetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecInitProviderSinkDatasetNameSelectorPolicyResolveEnum>))]
    public V1beta1DataFlowSpecInitProviderSinkDatasetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DataSetJSON in datafactory to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSinkDatasetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecInitProviderSinkDatasetNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSinkDataset
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a DataSetJSON in datafactory to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DataFlowSpecInitProviderSinkDatasetNameRef? NameRef { get; set; }

    /// <summary>Selector for a DataSetJSON in datafactory to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1DataFlowSpecInitProviderSinkDatasetNameSelector? NameSelector { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSinkFlowlet
{
    /// <summary>Specifies the reference data flow parameters from dataset.</summary>
    [JsonPropertyName("datasetParameters")]
    public string? DatasetParameters { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSinkLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSinkRejectedLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSinkSchemaLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSink
{
    /// <summary>A dataset block as defined below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DataFlowSpecInitProviderSinkDataset>? Dataset { get; set; }

    /// <summary>The description for the Data Flow Source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flowlet block as defined below.</summary>
    [JsonPropertyName("flowlet")]
    public IList<V1beta1DataFlowSpecInitProviderSinkFlowlet>? Flowlet { get; set; }

    /// <summary>A linked_service block as defined below.</summary>
    [JsonPropertyName("linkedService")]
    public IList<V1beta1DataFlowSpecInitProviderSinkLinkedService>? LinkedService { get; set; }

    /// <summary>The name for the Data Flow Source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A rejected_linked_service block as defined below.</summary>
    [JsonPropertyName("rejectedLinkedService")]
    public IList<V1beta1DataFlowSpecInitProviderSinkRejectedLinkedService>? RejectedLinkedService { get; set; }

    /// <summary>A schema_linked_service block as defined below.</summary>
    [JsonPropertyName("schemaLinkedService")]
    public IList<V1beta1DataFlowSpecInitProviderSinkSchemaLinkedService>? SchemaLinkedService { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecInitProviderSourceDatasetNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecInitProviderSourceDatasetNameRefPolicyResolveEnum
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
public partial class V1beta1DataFlowSpecInitProviderSourceDatasetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecInitProviderSourceDatasetNameRefPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecInitProviderSourceDatasetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecInitProviderSourceDatasetNameRefPolicyResolveEnum>))]
    public V1beta1DataFlowSpecInitProviderSourceDatasetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DataSetJSON in datafactory to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSourceDatasetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecInitProviderSourceDatasetNameRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecInitProviderSourceDatasetNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecInitProviderSourceDatasetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSourceDatasetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecInitProviderSourceDatasetNameSelectorPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecInitProviderSourceDatasetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecInitProviderSourceDatasetNameSelectorPolicyResolveEnum>))]
    public V1beta1DataFlowSpecInitProviderSourceDatasetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DataSetJSON in datafactory to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSourceDatasetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecInitProviderSourceDatasetNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSourceDataset
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a DataSetJSON in datafactory to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1DataFlowSpecInitProviderSourceDatasetNameRef? NameRef { get; set; }

    /// <summary>Selector for a DataSetJSON in datafactory to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1DataFlowSpecInitProviderSourceDatasetNameSelector? NameSelector { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSourceFlowlet
{
    /// <summary>Specifies the reference data flow parameters from dataset.</summary>
    [JsonPropertyName("datasetParameters")]
    public string? DatasetParameters { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSourceLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSourceRejectedLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSourceSchemaLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSource
{
    /// <summary>A dataset block as defined below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DataFlowSpecInitProviderSourceDataset>? Dataset { get; set; }

    /// <summary>The description for the Data Flow Source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flowlet block as defined below.</summary>
    [JsonPropertyName("flowlet")]
    public IList<V1beta1DataFlowSpecInitProviderSourceFlowlet>? Flowlet { get; set; }

    /// <summary>A linked_service block as defined below.</summary>
    [JsonPropertyName("linkedService")]
    public IList<V1beta1DataFlowSpecInitProviderSourceLinkedService>? LinkedService { get; set; }

    /// <summary>The name for the Data Flow Source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A rejected_linked_service block as defined below.</summary>
    [JsonPropertyName("rejectedLinkedService")]
    public IList<V1beta1DataFlowSpecInitProviderSourceRejectedLinkedService>? RejectedLinkedService { get; set; }

    /// <summary>A schema_linked_service block as defined below.</summary>
    [JsonPropertyName("schemaLinkedService")]
    public IList<V1beta1DataFlowSpecInitProviderSourceSchemaLinkedService>? SchemaLinkedService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderTransformationDataset
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderTransformationFlowlet
{
    /// <summary>Specifies the reference data flow parameters from dataset.</summary>
    [JsonPropertyName("datasetParameters")]
    public string? DatasetParameters { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderTransformationLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderTransformation
{
    /// <summary>A dataset block as defined below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DataFlowSpecInitProviderTransformationDataset>? Dataset { get; set; }

    /// <summary>The description for the Data Flow transformation.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flowlet block as defined below.</summary>
    [JsonPropertyName("flowlet")]
    public IList<V1beta1DataFlowSpecInitProviderTransformationFlowlet>? Flowlet { get; set; }

    /// <summary>A linked_service block as defined below.</summary>
    [JsonPropertyName("linkedService")]
    public IList<V1beta1DataFlowSpecInitProviderTransformationLinkedService>? LinkedService { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProvider
{
    /// <summary>List of tags that can be used for describing the Data Factory Data Flow.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The description for the Data Factory Data Flow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The folder that this Data Flow is in. If not specified, the Data Flow will appear at the root level.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>The script for the Data Factory Data Flow.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>The script lines for the Data Factory Data Flow.</summary>
    [JsonPropertyName("scriptLines")]
    public IList<string>? ScriptLines { get; set; }

    /// <summary>One or more sink blocks as defined below.</summary>
    [JsonPropertyName("sink")]
    public IList<V1beta1DataFlowSpecInitProviderSink>? Sink { get; set; }

    /// <summary>One or more source blocks as defined below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1DataFlowSpecInitProviderSource>? Source { get; set; }

    /// <summary>One or more transformation blocks as defined below.</summary>
    [JsonPropertyName("transformation")]
    public IList<V1beta1DataFlowSpecInitProviderTransformation>? Transformation { get; set; }
}

/// <summary>A ManagementAction represents an action that the Crossplane controllers can take on an external resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecManagementPoliciesEnum
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

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1DataFlowSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DataFlowSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

/// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1DataFlowSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1DataFlowSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DataFlowSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DataFlowSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataFlowSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DataFlowSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DataFlowSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DataFlowSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DataFlowSpec defines the desired state of DataFlow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataFlowSpecDeletionPolicyEnum>))]
    public V1beta1DataFlowSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DataFlowSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DataFlowSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DataFlowSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DataFlowSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DataFlowSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DataFlowSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSinkDataset
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSinkFlowlet
{
    /// <summary>Specifies the reference data flow parameters from dataset.</summary>
    [JsonPropertyName("datasetParameters")]
    public string? DatasetParameters { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSinkLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSinkRejectedLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSinkSchemaLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSink
{
    /// <summary>A dataset block as defined below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DataFlowStatusAtProviderSinkDataset>? Dataset { get; set; }

    /// <summary>The description for the Data Flow Source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flowlet block as defined below.</summary>
    [JsonPropertyName("flowlet")]
    public IList<V1beta1DataFlowStatusAtProviderSinkFlowlet>? Flowlet { get; set; }

    /// <summary>A linked_service block as defined below.</summary>
    [JsonPropertyName("linkedService")]
    public IList<V1beta1DataFlowStatusAtProviderSinkLinkedService>? LinkedService { get; set; }

    /// <summary>The name for the Data Flow Source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A rejected_linked_service block as defined below.</summary>
    [JsonPropertyName("rejectedLinkedService")]
    public IList<V1beta1DataFlowStatusAtProviderSinkRejectedLinkedService>? RejectedLinkedService { get; set; }

    /// <summary>A schema_linked_service block as defined below.</summary>
    [JsonPropertyName("schemaLinkedService")]
    public IList<V1beta1DataFlowStatusAtProviderSinkSchemaLinkedService>? SchemaLinkedService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSourceDataset
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSourceFlowlet
{
    /// <summary>Specifies the reference data flow parameters from dataset.</summary>
    [JsonPropertyName("datasetParameters")]
    public string? DatasetParameters { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSourceLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSourceRejectedLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSourceSchemaLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderSource
{
    /// <summary>A dataset block as defined below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DataFlowStatusAtProviderSourceDataset>? Dataset { get; set; }

    /// <summary>The description for the Data Flow Source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flowlet block as defined below.</summary>
    [JsonPropertyName("flowlet")]
    public IList<V1beta1DataFlowStatusAtProviderSourceFlowlet>? Flowlet { get; set; }

    /// <summary>A linked_service block as defined below.</summary>
    [JsonPropertyName("linkedService")]
    public IList<V1beta1DataFlowStatusAtProviderSourceLinkedService>? LinkedService { get; set; }

    /// <summary>The name for the Data Flow Source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A rejected_linked_service block as defined below.</summary>
    [JsonPropertyName("rejectedLinkedService")]
    public IList<V1beta1DataFlowStatusAtProviderSourceRejectedLinkedService>? RejectedLinkedService { get; set; }

    /// <summary>A schema_linked_service block as defined below.</summary>
    [JsonPropertyName("schemaLinkedService")]
    public IList<V1beta1DataFlowStatusAtProviderSourceSchemaLinkedService>? SchemaLinkedService { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderTransformationDataset
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderTransformationFlowlet
{
    /// <summary>Specifies the reference data flow parameters from dataset.</summary>
    [JsonPropertyName("datasetParameters")]
    public string? DatasetParameters { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderTransformationLinkedService
{
    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProviderTransformation
{
    /// <summary>A dataset block as defined below.</summary>
    [JsonPropertyName("dataset")]
    public IList<V1beta1DataFlowStatusAtProviderTransformationDataset>? Dataset { get; set; }

    /// <summary>The description for the Data Flow transformation.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flowlet block as defined below.</summary>
    [JsonPropertyName("flowlet")]
    public IList<V1beta1DataFlowStatusAtProviderTransformationFlowlet>? Flowlet { get; set; }

    /// <summary>A linked_service block as defined below.</summary>
    [JsonPropertyName("linkedService")]
    public IList<V1beta1DataFlowStatusAtProviderTransformationLinkedService>? LinkedService { get; set; }

    /// <summary>The name for the Data Flow transformation.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusAtProvider
{
    /// <summary>List of tags that can be used for describing the Data Factory Data Flow.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The ID of Data Factory in which to associate the Data Flow with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>The description for the Data Factory Data Flow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The folder that this Data Flow is in. If not specified, the Data Flow will appear at the root level.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>The ID of the Data Factory Data Flow.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The script for the Data Factory Data Flow.</summary>
    [JsonPropertyName("script")]
    public string? Script { get; set; }

    /// <summary>The script lines for the Data Factory Data Flow.</summary>
    [JsonPropertyName("scriptLines")]
    public IList<string>? ScriptLines { get; set; }

    /// <summary>One or more sink blocks as defined below.</summary>
    [JsonPropertyName("sink")]
    public IList<V1beta1DataFlowStatusAtProviderSink>? Sink { get; set; }

    /// <summary>One or more source blocks as defined below.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta1DataFlowStatusAtProviderSource>? Source { get; set; }

    /// <summary>One or more transformation blocks as defined below.</summary>
    [JsonPropertyName("transformation")]
    public IList<V1beta1DataFlowStatusAtProviderTransformation>? Transformation { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatusConditions
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

/// <summary>DataFlowStatus defines the observed state of DataFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DataFlowStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataFlowStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DataFlow is the Schema for the DataFlows API. Manages a Data Flow inside an Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataFlow : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataFlowSpec>, IStatus<V1beta1DataFlowStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataFlow";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "dataflows";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataFlowSpec defines the desired state of DataFlow</summary>
    [JsonPropertyName("spec")]
    public V1beta1DataFlowSpec Spec { get; set; }

    /// <summary>DataFlowStatus defines the observed state of DataFlow.</summary>
    [JsonPropertyName("status")]
    public V1beta1DataFlowStatus? Status { get; set; }
}