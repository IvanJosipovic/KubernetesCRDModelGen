using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.upbound.io;
#nullable enable
/// <summary>DataFlow is the Schema for the DataFlows API. Manages a Data Flow inside an Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataFlowList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DataFlow>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataFlowList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1DataFlow> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderDataFactoryIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderDataFactoryIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSinkDatasetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSinkDatasetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSourceDatasetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecForProviderSourceDatasetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSinkDatasetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSinkDatasetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSourceDatasetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecInitProviderSourceDatasetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
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
#nullable disable

#nullable enable
/// <summary>DataFlowSpec defines the desired state of DataFlow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataFlowSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DataFlowSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DataFlowSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DataFlowSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DataFlowSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable
