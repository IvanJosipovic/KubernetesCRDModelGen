using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.upbound.io;
public enum V1beta1TriggerCustomEventSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1TriggerCustomEventSpecForProviderDataFactoryIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecForProviderDataFactoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecForProviderDataFactoryIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderDataFactoryIdRefPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderDataFactoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderDataFactoryIdRefPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderDataFactoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerCustomEventSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecForProviderDataFactoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecForProviderDataFactoryIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderDataFactoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderDataFactoryIdSelectorPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderDataFactoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecForProviderDataFactoryIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdRefPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdRefPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdSelectorPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TriggerCustomEventSpecForProviderPipelineNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecForProviderPipelineNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecForProviderPipelineNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderPipelineNameRefPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderPipelineNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderPipelineNameRefPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderPipelineNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecForProviderPipelineNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecForProviderPipelineNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerCustomEventSpecForProviderPipelineNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecForProviderPipelineNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecForProviderPipelineNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderPipelineNameSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderPipelineNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecForProviderPipelineNameSelectorPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecForProviderPipelineNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecForProviderPipelineNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecForProviderPipelineNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecForProviderPipeline
{
    /// <summary>The Data Factory Pipeline name that the trigger will act on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Pipeline in datafactory to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1TriggerCustomEventSpecForProviderPipelineNameRef? NameRef { get; set; }

    /// <summary>Selector for a Pipeline in datafactory to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1TriggerCustomEventSpecForProviderPipelineNameSelector? NameSelector { get; set; }

    /// <summary>The Data Factory Pipeline parameters that the trigger will act on.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecForProvider
{
    /// <summary>Specifies if the Data Factory Custom Event Trigger is activated. Defaults to true.</summary>
    [JsonPropertyName("activated")]
    public bool? Activated { get; set; }

    /// <summary>A map of additional properties to associate with the Data Factory Custom Event Trigger.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Custom Event Trigger.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The ID of Data Factory in which to associate the Trigger with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta1TriggerCustomEventSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta1TriggerCustomEventSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>The description for the Data Factory Custom Event Trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of Event Grid Topic in which event will be listened. Changing this forces a new resource.</summary>
    [JsonPropertyName("eventgridTopicId")]
    public string? EventgridTopicId { get; set; }

    /// <summary>Reference to a Topic in eventgrid to populate eventgridTopicId.</summary>
    [JsonPropertyName("eventgridTopicIdRef")]
    public V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdRef? EventgridTopicIdRef { get; set; }

    /// <summary>Selector for a Topic in eventgrid to populate eventgridTopicId.</summary>
    [JsonPropertyName("eventgridTopicIdSelector")]
    public V1beta1TriggerCustomEventSpecForProviderEventgridTopicIdSelector? EventgridTopicIdSelector { get; set; }

    /// <summary>List of events that will fire this trigger. At least one event must be specified.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>One or more pipeline blocks as defined below.</summary>
    [JsonPropertyName("pipeline")]
    public IList<V1beta1TriggerCustomEventSpecForProviderPipeline>? Pipeline { get; set; }

    /// <summary>The pattern that event subject starts with for trigger to fire.</summary>
    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    /// <summary>The pattern that event subject ends with for trigger to fire.</summary>
    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

public enum V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdRefPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdRefPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdSelectorPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1TriggerCustomEventSpecInitProviderPipelineNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecInitProviderPipelineNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecInitProviderPipelineNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecInitProviderPipelineNameRefPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecInitProviderPipelineNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecInitProviderPipelineNameRefPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecInitProviderPipelineNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecInitProviderPipelineNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecInitProviderPipelineNameRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerCustomEventSpecInitProviderPipelineNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecInitProviderPipelineNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecInitProviderPipelineNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecInitProviderPipelineNameSelectorPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecInitProviderPipelineNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecInitProviderPipelineNameSelectorPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecInitProviderPipelineNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecInitProviderPipelineNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecInitProviderPipelineNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecInitProviderPipeline
{
    /// <summary>The Data Factory Pipeline name that the trigger will act on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Pipeline in datafactory to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1TriggerCustomEventSpecInitProviderPipelineNameRef? NameRef { get; set; }

    /// <summary>Selector for a Pipeline in datafactory to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1TriggerCustomEventSpecInitProviderPipelineNameSelector? NameSelector { get; set; }

    /// <summary>The Data Factory Pipeline parameters that the trigger will act on.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecInitProvider
{
    /// <summary>Specifies if the Data Factory Custom Event Trigger is activated. Defaults to true.</summary>
    [JsonPropertyName("activated")]
    public bool? Activated { get; set; }

    /// <summary>A map of additional properties to associate with the Data Factory Custom Event Trigger.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Custom Event Trigger.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The description for the Data Factory Custom Event Trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of Event Grid Topic in which event will be listened. Changing this forces a new resource.</summary>
    [JsonPropertyName("eventgridTopicId")]
    public string? EventgridTopicId { get; set; }

    /// <summary>Reference to a Topic in eventgrid to populate eventgridTopicId.</summary>
    [JsonPropertyName("eventgridTopicIdRef")]
    public V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdRef? EventgridTopicIdRef { get; set; }

    /// <summary>Selector for a Topic in eventgrid to populate eventgridTopicId.</summary>
    [JsonPropertyName("eventgridTopicIdSelector")]
    public V1beta1TriggerCustomEventSpecInitProviderEventgridTopicIdSelector? EventgridTopicIdSelector { get; set; }

    /// <summary>List of events that will fire this trigger. At least one event must be specified.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>One or more pipeline blocks as defined below.</summary>
    [JsonPropertyName("pipeline")]
    public IList<V1beta1TriggerCustomEventSpecInitProviderPipeline>? Pipeline { get; set; }

    /// <summary>The pattern that event subject starts with for trigger to fire.</summary>
    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    /// <summary>The pattern that event subject ends with for trigger to fire.</summary>
    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

public enum V1beta1TriggerCustomEventSpecManagementPoliciesEnum
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

public enum V1beta1TriggerCustomEventSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1TriggerCustomEventSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1TriggerCustomEventSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1TriggerCustomEventSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1TriggerCustomEventSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1TriggerCustomEventSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerCustomEventSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1TriggerCustomEventSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1TriggerCustomEventSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1TriggerCustomEventSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1TriggerCustomEventSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1TriggerCustomEventSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1TriggerCustomEventSpecDeletionPolicyEnum>))]
    public V1beta1TriggerCustomEventSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TriggerCustomEventSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TriggerCustomEventSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TriggerCustomEventSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TriggerCustomEventSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1TriggerCustomEventSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TriggerCustomEventSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1TriggerCustomEventStatusAtProviderPipeline
{
    /// <summary>The Data Factory Pipeline name that the trigger will act on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Data Factory Pipeline parameters that the trigger will act on.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

public partial class V1beta1TriggerCustomEventStatusAtProvider
{
    /// <summary>Specifies if the Data Factory Custom Event Trigger is activated. Defaults to true.</summary>
    [JsonPropertyName("activated")]
    public bool? Activated { get; set; }

    /// <summary>A map of additional properties to associate with the Data Factory Custom Event Trigger.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Custom Event Trigger.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The ID of Data Factory in which to associate the Trigger with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>The description for the Data Factory Custom Event Trigger.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of Event Grid Topic in which event will be listened. Changing this forces a new resource.</summary>
    [JsonPropertyName("eventgridTopicId")]
    public string? EventgridTopicId { get; set; }

    /// <summary>List of events that will fire this trigger. At least one event must be specified.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>The ID of the Data Factory Custom Event Trigger.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more pipeline blocks as defined below.</summary>
    [JsonPropertyName("pipeline")]
    public IList<V1beta1TriggerCustomEventStatusAtProviderPipeline>? Pipeline { get; set; }

    /// <summary>The pattern that event subject starts with for trigger to fire.</summary>
    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    /// <summary>The pattern that event subject ends with for trigger to fire.</summary>
    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

public partial class V1beta1TriggerCustomEventStatusConditions
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

public partial class V1beta1TriggerCustomEventStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TriggerCustomEventStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TriggerCustomEventStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TriggerCustomEvent : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TriggerCustomEventSpec>, IStatus<V1beta1TriggerCustomEventStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TriggerCustomEvent";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "triggercustomevents";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TriggerCustomEventSpec defines the desired state of TriggerCustomEvent</summary>
    [JsonPropertyName("spec")]
    public V1beta1TriggerCustomEventSpec Spec { get; set; }

    /// <summary>TriggerCustomEventStatus defines the observed state of TriggerCustomEvent.</summary>
    [JsonPropertyName("status")]
    public V1beta1TriggerCustomEventStatus? Status { get; set; }
}