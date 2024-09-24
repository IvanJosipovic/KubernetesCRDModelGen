using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.streamanalytics.azure.upbound.io;
public enum V1beta1OutputServiceBusTopicSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderSerialization
{
    /// <summary>The encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output. It currently can only be set to UTF8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The delimiter that will be used to separate comma-separated value (CSV) records. Possible values are   (space), , (comma), 	 (tab), | (pipe) and ;.</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Specifies the format of the JSON the output will be written in. Possible values are Array and LineSeparated.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The serialization format used for outgoing data streams. Possible values are Avro, Csv, Json and Parquet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceRefPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceRefPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceRefPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceSelectorPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceSelectorPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderSharedAccessPolicyKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameRefPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameRefPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameRefPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameSelectorPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameSelectorPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecForProviderTopicNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecForProviderTopicNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderTopicNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderTopicNameRefPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderTopicNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderTopicNameRefPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderTopicNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderTopicNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecForProviderTopicNameRefPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecForProviderTopicNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecForProviderTopicNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderTopicNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderTopicNameSelectorPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderTopicNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecForProviderTopicNameSelectorPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecForProviderTopicNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecForProviderTopicNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecForProviderTopicNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecForProvider
{
    /// <summary>The authentication mode for the Stream Output. Possible values are Msi and ConnectionString. Defaults to ConnectionString.</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    /// <summary>The name of the Stream Output. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of property columns to add to the Service Bus Topic output.</summary>
    [JsonPropertyName("propertyColumns")]
    public IList<string>? PropertyColumns { get; set; }

    /// <summary>The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1OutputServiceBusTopicSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A serialization block as defined below.</summary>
    [JsonPropertyName("serialization")]
    public IList<V1beta1OutputServiceBusTopicSpecForProviderSerialization>? Serialization { get; set; }

    /// <summary>The namespace that is associated with the desired Event Hub, Service Bus Topic, Service Bus Topic, etc.</summary>
    [JsonPropertyName("servicebusNamespace")]
    public string? ServicebusNamespace { get; set; }

    /// <summary>Reference to a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
    [JsonPropertyName("servicebusNamespaceRef")]
    public V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceRef? ServicebusNamespaceRef { get; set; }

    /// <summary>Selector for a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
    [JsonPropertyName("servicebusNamespaceSelector")]
    public V1beta1OutputServiceBusTopicSpecForProviderServicebusNamespaceSelector? ServicebusNamespaceSelector { get; set; }

    /// <summary>The shared access policy key for the specified shared access policy. Required if authentication_mode is ConnectionString.</summary>
    [JsonPropertyName("sharedAccessPolicyKeySecretRef")]
    public V1beta1OutputServiceBusTopicSpecForProviderSharedAccessPolicyKeySecretRef? SharedAccessPolicyKeySecretRef { get; set; }

    /// <summary>The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc. Required if authentication_mode is ConnectionString.</summary>
    [JsonPropertyName("sharedAccessPolicyName")]
    public string? SharedAccessPolicyName { get; set; }

    /// <summary>The name of the Stream Analytics Job. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamAnalyticsJobName")]
    public string? StreamAnalyticsJobName { get; set; }

    /// <summary>Reference to a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
    [JsonPropertyName("streamAnalyticsJobNameRef")]
    public V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameRef? StreamAnalyticsJobNameRef { get; set; }

    /// <summary>Selector for a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
    [JsonPropertyName("streamAnalyticsJobNameSelector")]
    public V1beta1OutputServiceBusTopicSpecForProviderStreamAnalyticsJobNameSelector? StreamAnalyticsJobNameSelector { get; set; }

    /// <summary>A key-value pair of system property columns that will be attached to the outgoing messages for the Service Bus Topic Output.</summary>
    [JsonPropertyName("systemPropertyColumns")]
    public IDictionary<string, string>? SystemPropertyColumns { get; set; }

    /// <summary>The name of the Service Bus Topic.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }

    /// <summary>Reference to a Topic in servicebus to populate topicName.</summary>
    [JsonPropertyName("topicNameRef")]
    public V1beta1OutputServiceBusTopicSpecForProviderTopicNameRef? TopicNameRef { get; set; }

    /// <summary>Selector for a Topic in servicebus to populate topicName.</summary>
    [JsonPropertyName("topicNameSelector")]
    public V1beta1OutputServiceBusTopicSpecForProviderTopicNameSelector? TopicNameSelector { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderSerialization
{
    /// <summary>The encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output. It currently can only be set to UTF8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The delimiter that will be used to separate comma-separated value (CSV) records. Possible values are   (space), , (comma), 	 (tab), | (pipe) and ;.</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Specifies the format of the JSON the output will be written in. Possible values are Array and LineSeparated.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The serialization format used for outgoing data streams. Possible values are Avro, Csv, Json and Parquet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceRefPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceRefPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceRefPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceSelectorPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceSelectorPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceSelectorPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameRefPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameRefPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameRefPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameSelectorPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameSelectorPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderTopicNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderTopicNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderTopicNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderTopicNameRefPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderTopicNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderTopicNameRefPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderTopicNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderTopicNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecInitProviderTopicNameRefPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderTopicNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecInitProviderTopicNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderTopicNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderTopicNameSelectorPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderTopicNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecInitProviderTopicNameSelectorPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecInitProviderTopicNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecInitProviderTopicNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecInitProviderTopicNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecInitProvider
{
    /// <summary>The authentication mode for the Stream Output. Possible values are Msi and ConnectionString. Defaults to ConnectionString.</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    /// <summary>The name of the Stream Output. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of property columns to add to the Service Bus Topic output.</summary>
    [JsonPropertyName("propertyColumns")]
    public IList<string>? PropertyColumns { get; set; }

    /// <summary>The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1OutputServiceBusTopicSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A serialization block as defined below.</summary>
    [JsonPropertyName("serialization")]
    public IList<V1beta1OutputServiceBusTopicSpecInitProviderSerialization>? Serialization { get; set; }

    /// <summary>The namespace that is associated with the desired Event Hub, Service Bus Topic, Service Bus Topic, etc.</summary>
    [JsonPropertyName("servicebusNamespace")]
    public string? ServicebusNamespace { get; set; }

    /// <summary>Reference to a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
    [JsonPropertyName("servicebusNamespaceRef")]
    public V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceRef? ServicebusNamespaceRef { get; set; }

    /// <summary>Selector for a ServiceBusNamespace in servicebus to populate servicebusNamespace.</summary>
    [JsonPropertyName("servicebusNamespaceSelector")]
    public V1beta1OutputServiceBusTopicSpecInitProviderServicebusNamespaceSelector? ServicebusNamespaceSelector { get; set; }

    /// <summary>The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc. Required if authentication_mode is ConnectionString.</summary>
    [JsonPropertyName("sharedAccessPolicyName")]
    public string? SharedAccessPolicyName { get; set; }

    /// <summary>The name of the Stream Analytics Job. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamAnalyticsJobName")]
    public string? StreamAnalyticsJobName { get; set; }

    /// <summary>Reference to a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
    [JsonPropertyName("streamAnalyticsJobNameRef")]
    public V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameRef? StreamAnalyticsJobNameRef { get; set; }

    /// <summary>Selector for a Job in streamanalytics to populate streamAnalyticsJobName.</summary>
    [JsonPropertyName("streamAnalyticsJobNameSelector")]
    public V1beta1OutputServiceBusTopicSpecInitProviderStreamAnalyticsJobNameSelector? StreamAnalyticsJobNameSelector { get; set; }

    /// <summary>A key-value pair of system property columns that will be attached to the outgoing messages for the Service Bus Topic Output.</summary>
    [JsonPropertyName("systemPropertyColumns")]
    public IDictionary<string, string>? SystemPropertyColumns { get; set; }

    /// <summary>The name of the Service Bus Topic.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }

    /// <summary>Reference to a Topic in servicebus to populate topicName.</summary>
    [JsonPropertyName("topicNameRef")]
    public V1beta1OutputServiceBusTopicSpecInitProviderTopicNameRef? TopicNameRef { get; set; }

    /// <summary>Selector for a Topic in servicebus to populate topicName.</summary>
    [JsonPropertyName("topicNameSelector")]
    public V1beta1OutputServiceBusTopicSpecInitProviderTopicNameSelector? TopicNameSelector { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecManagementPoliciesEnum
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

public enum V1beta1OutputServiceBusTopicSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1OutputServiceBusTopicSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OutputServiceBusTopicSpecDeletionPolicyEnum>))]
    public V1beta1OutputServiceBusTopicSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OutputServiceBusTopicSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OutputServiceBusTopicSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1OutputServiceBusTopicSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OutputServiceBusTopicSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1OutputServiceBusTopicSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OutputServiceBusTopicSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1OutputServiceBusTopicStatusAtProviderSerialization
{
    /// <summary>The encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output. It currently can only be set to UTF8.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The delimiter that will be used to separate comma-separated value (CSV) records. Possible values are   (space), , (comma), 	 (tab), | (pipe) and ;.</summary>
    [JsonPropertyName("fieldDelimiter")]
    public string? FieldDelimiter { get; set; }

    /// <summary>Specifies the format of the JSON the output will be written in. Possible values are Array and LineSeparated.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The serialization format used for outgoing data streams. Possible values are Avro, Csv, Json and Parquet.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1OutputServiceBusTopicStatusAtProvider
{
    /// <summary>The authentication mode for the Stream Output. Possible values are Msi and ConnectionString. Defaults to ConnectionString.</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    /// <summary>The ID of the Stream Analytics Output ServiceBus Topic.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Stream Output. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of property columns to add to the Service Bus Topic output.</summary>
    [JsonPropertyName("propertyColumns")]
    public IList<string>? PropertyColumns { get; set; }

    /// <summary>The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A serialization block as defined below.</summary>
    [JsonPropertyName("serialization")]
    public IList<V1beta1OutputServiceBusTopicStatusAtProviderSerialization>? Serialization { get; set; }

    /// <summary>The namespace that is associated with the desired Event Hub, Service Bus Topic, Service Bus Topic, etc.</summary>
    [JsonPropertyName("servicebusNamespace")]
    public string? ServicebusNamespace { get; set; }

    /// <summary>The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc. Required if authentication_mode is ConnectionString.</summary>
    [JsonPropertyName("sharedAccessPolicyName")]
    public string? SharedAccessPolicyName { get; set; }

    /// <summary>The name of the Stream Analytics Job. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("streamAnalyticsJobName")]
    public string? StreamAnalyticsJobName { get; set; }

    /// <summary>A key-value pair of system property columns that will be attached to the outgoing messages for the Service Bus Topic Output.</summary>
    [JsonPropertyName("systemPropertyColumns")]
    public IDictionary<string, string>? SystemPropertyColumns { get; set; }

    /// <summary>The name of the Service Bus Topic.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }
}

public partial class V1beta1OutputServiceBusTopicStatusConditions
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

public partial class V1beta1OutputServiceBusTopicStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OutputServiceBusTopicStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OutputServiceBusTopicStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OutputServiceBusTopic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OutputServiceBusTopicSpec>, IStatus<V1beta1OutputServiceBusTopicStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OutputServiceBusTopic";
    public const string KubeGroup = "streamanalytics.azure.upbound.io";
    public const string KubePluralName = "outputservicebustopics";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OutputServiceBusTopicSpec defines the desired state of OutputServiceBusTopic</summary>
    [JsonPropertyName("spec")]
    public V1beta1OutputServiceBusTopicSpec Spec { get; set; }

    /// <summary>OutputServiceBusTopicStatus defines the observed state of OutputServiceBusTopic.</summary>
    [JsonPropertyName("status")]
    public V1beta1OutputServiceBusTopicStatus? Status { get; set; }
}