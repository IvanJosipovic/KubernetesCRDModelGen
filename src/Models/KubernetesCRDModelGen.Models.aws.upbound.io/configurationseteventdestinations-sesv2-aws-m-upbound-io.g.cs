using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sesv2.aws.m.upbound.io;
#nullable enable
/// <summary>ConfigurationSetEventDestination is the Schema for the ConfigurationSetEventDestinations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigurationSetEventDestinationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ConfigurationSetEventDestination>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigurationSetEventDestinationList";
    public const string KubeGroup = "sesv2.aws.m.upbound.io";
    public const string KubePluralName = "configurationseteventdestinations";
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
    public IList<V1beta1ConfigurationSetEventDestination> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRefPolicy
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
/// <summary>Reference to a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelectorPolicy
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
/// <summary>Selector for a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationCloudWatchDestinationDimensionConfiguration
{
    /// <summary>The default value of the dimension that is published to Amazon CloudWatch if you don't provide the value of the dimension when you send an email.</summary>
    [JsonPropertyName("defaultDimensionValue")]
    public string? DefaultDimensionValue { get; set; }

    /// <summary>The name of an Amazon CloudWatch dimension associated with an email sending metric.</summary>
    [JsonPropertyName("dimensionName")]
    public string? DimensionName { get; set; }

    /// <summary>The location where the Amazon SES API v2 finds the value of a dimension to publish to Amazon CloudWatch. Valid values: MESSAGE_TAG, EMAIL_HEADER, LINK_TAG.</summary>
    [JsonPropertyName("dimensionValueSource")]
    public string? DimensionValueSource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationCloudWatchDestination
{
    /// <summary>An array of objects that define the dimensions to use when you send email events to Amazon CloudWatch. See dimension_configuration Block for details.</summary>
    [JsonPropertyName("dimensionConfiguration")]
    public IList<V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationCloudWatchDestinationDimensionConfiguration>? DimensionConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationEventBridgeDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon EventBridge bus to publish email events to. Only the default bus is supported.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicy
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
/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicy
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
/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicy
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
/// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicy
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
/// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon Kinesis Data Firehose stream that the Amazon SES API v2 sends email events to.</summary>
    [JsonPropertyName("deliveryStreamArn")]
    public string? DeliveryStreamArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
    [JsonPropertyName("deliveryStreamArnRef")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRef? DeliveryStreamArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
    [JsonPropertyName("deliveryStreamArnSelector")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelector? DeliveryStreamArnSelector { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role that the Amazon SES API v2 uses to send email events to the Amazon Kinesis Data Firehose stream.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnRef")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRef? IamRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnSelector")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelector? IamRoleArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRefPolicy
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
/// <summary>Reference to a App in pinpoint to populate applicationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicy
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
/// <summary>Selector for a App in pinpoint to populate applicationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestination
{
    /// <summary></summary>
    [JsonPropertyName("applicationArn")]
    public string? ApplicationArn { get; set; }

    /// <summary>Reference to a App in pinpoint to populate applicationArn.</summary>
    [JsonPropertyName("applicationArnRef")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRef? ApplicationArnRef { get; set; }

    /// <summary>Selector for a App in pinpoint to populate applicationArn.</summary>
    [JsonPropertyName("applicationArnSelector")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelector? ApplicationArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRefPolicy
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
/// <summary>Reference to a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelectorPolicy
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
/// <summary>Selector for a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon SNS topic to publish email events to.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnRef")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRef? TopicArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnSelector")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelector? TopicArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A name that identifies the event destination within the configuration set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestination
{
    /// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
    [JsonPropertyName("cloudWatchDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationCloudWatchDestination? CloudWatchDestination { get; set; }

    /// <summary>When the event destination is enabled, the specified event types are sent to the destinations. Default: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventBridgeDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationEventBridgeDestination? EventBridgeDestination { get; set; }

    /// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
    [JsonPropertyName("kinesisFirehoseDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestination? KinesisFirehoseDestination { get; set; }

    /// <summary>- An array that specifies which events the Amazon SES API v2 should send to the destinations. Valid values: SEND, REJECT, BOUNCE, COMPLAINT, DELIVERY, OPEN, CLICK, RENDERING_FAILURE, DELIVERY_DELAY, SUBSCRIPTION.</summary>
    [JsonPropertyName("matchingEventTypes")]
    public IList<string>? MatchingEventTypes { get; set; }

    /// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
    [JsonPropertyName("pinpointDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestination? PinpointDestination { get; set; }

    /// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
    [JsonPropertyName("snsDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestination? SnsDestination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecForProvider
{
    /// <summary>The name of the configuration set.</summary>
    [JsonPropertyName("configurationSetName")]
    public string? ConfigurationSetName { get; set; }

    /// <summary>Reference to a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
    [JsonPropertyName("configurationSetNameRef")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRef? ConfigurationSetNameRef { get; set; }

    /// <summary>Selector for a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
    [JsonPropertyName("configurationSetNameSelector")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelector? ConfigurationSetNameSelector { get; set; }

    /// <summary>A name that identifies the event destination within the configuration set.</summary>
    [JsonPropertyName("eventDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecForProviderEventDestination? EventDestination { get; set; }

    /// <summary>An object that defines the event destination. See event_destination Block for details.</summary>
    [JsonPropertyName("eventDestinationName")]
    public string? EventDestinationName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRefPolicy
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
/// <summary>Reference to a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelectorPolicy
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
/// <summary>Selector for a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationCloudWatchDestinationDimensionConfiguration
{
    /// <summary>The default value of the dimension that is published to Amazon CloudWatch if you don't provide the value of the dimension when you send an email.</summary>
    [JsonPropertyName("defaultDimensionValue")]
    public string? DefaultDimensionValue { get; set; }

    /// <summary>The name of an Amazon CloudWatch dimension associated with an email sending metric.</summary>
    [JsonPropertyName("dimensionName")]
    public string? DimensionName { get; set; }

    /// <summary>The location where the Amazon SES API v2 finds the value of a dimension to publish to Amazon CloudWatch. Valid values: MESSAGE_TAG, EMAIL_HEADER, LINK_TAG.</summary>
    [JsonPropertyName("dimensionValueSource")]
    public string? DimensionValueSource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationCloudWatchDestination
{
    /// <summary>An array of objects that define the dimensions to use when you send email events to Amazon CloudWatch. See dimension_configuration Block for details.</summary>
    [JsonPropertyName("dimensionConfiguration")]
    public IList<V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationCloudWatchDestinationDimensionConfiguration>? DimensionConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationEventBridgeDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon EventBridge bus to publish email events to. Only the default bus is supported.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicy
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
/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicy
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
/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicy
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
/// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicy
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
/// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon Kinesis Data Firehose stream that the Amazon SES API v2 sends email events to.</summary>
    [JsonPropertyName("deliveryStreamArn")]
    public string? DeliveryStreamArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
    [JsonPropertyName("deliveryStreamArnRef")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRef? DeliveryStreamArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
    [JsonPropertyName("deliveryStreamArnSelector")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelector? DeliveryStreamArnSelector { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role that the Amazon SES API v2 uses to send email events to the Amazon Kinesis Data Firehose stream.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnRef")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRef? IamRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnSelector")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelector? IamRoleArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRefPolicy
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
/// <summary>Reference to a App in pinpoint to populate applicationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicy
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
/// <summary>Selector for a App in pinpoint to populate applicationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestination
{
    /// <summary></summary>
    [JsonPropertyName("applicationArn")]
    public string? ApplicationArn { get; set; }

    /// <summary>Reference to a App in pinpoint to populate applicationArn.</summary>
    [JsonPropertyName("applicationArnRef")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRef? ApplicationArnRef { get; set; }

    /// <summary>Selector for a App in pinpoint to populate applicationArn.</summary>
    [JsonPropertyName("applicationArnSelector")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelector? ApplicationArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRefPolicy
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
/// <summary>Reference to a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelectorPolicy
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
/// <summary>Selector for a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon SNS topic to publish email events to.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnRef")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRef? TopicArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnSelector")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelector? TopicArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A name that identifies the event destination within the configuration set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestination
{
    /// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
    [JsonPropertyName("cloudWatchDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationCloudWatchDestination? CloudWatchDestination { get; set; }

    /// <summary>When the event destination is enabled, the specified event types are sent to the destinations. Default: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventBridgeDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationEventBridgeDestination? EventBridgeDestination { get; set; }

    /// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
    [JsonPropertyName("kinesisFirehoseDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestination? KinesisFirehoseDestination { get; set; }

    /// <summary>- An array that specifies which events the Amazon SES API v2 should send to the destinations. Valid values: SEND, REJECT, BOUNCE, COMPLAINT, DELIVERY, OPEN, CLICK, RENDERING_FAILURE, DELIVERY_DELAY, SUBSCRIPTION.</summary>
    [JsonPropertyName("matchingEventTypes")]
    public IList<string>? MatchingEventTypes { get; set; }

    /// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
    [JsonPropertyName("pinpointDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestination? PinpointDestination { get; set; }

    /// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
    [JsonPropertyName("snsDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestination? SnsDestination { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecInitProvider
{
    /// <summary>The name of the configuration set.</summary>
    [JsonPropertyName("configurationSetName")]
    public string? ConfigurationSetName { get; set; }

    /// <summary>Reference to a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
    [JsonPropertyName("configurationSetNameRef")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRef? ConfigurationSetNameRef { get; set; }

    /// <summary>Selector for a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
    [JsonPropertyName("configurationSetNameSelector")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelector? ConfigurationSetNameSelector { get; set; }

    /// <summary>A name that identifies the event destination within the configuration set.</summary>
    [JsonPropertyName("eventDestination")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProviderEventDestination? EventDestination { get; set; }

    /// <summary>An object that defines the event destination. See event_destination Block for details.</summary>
    [JsonPropertyName("eventDestinationName")]
    public string? EventDestinationName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpecProviderConfigRef
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
public partial class V1beta1ConfigurationSetEventDestinationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ConfigurationSetEventDestinationSpec defines the desired state of ConfigurationSetEventDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConfigurationSetEventDestinationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConfigurationSetEventDestinationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConfigurationSetEventDestinationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConfigurationSetEventDestinationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationCloudWatchDestinationDimensionConfiguration
{
    /// <summary>The default value of the dimension that is published to Amazon CloudWatch if you don't provide the value of the dimension when you send an email.</summary>
    [JsonPropertyName("defaultDimensionValue")]
    public string? DefaultDimensionValue { get; set; }

    /// <summary>The name of an Amazon CloudWatch dimension associated with an email sending metric.</summary>
    [JsonPropertyName("dimensionName")]
    public string? DimensionName { get; set; }

    /// <summary>The location where the Amazon SES API v2 finds the value of a dimension to publish to Amazon CloudWatch. Valid values: MESSAGE_TAG, EMAIL_HEADER, LINK_TAG.</summary>
    [JsonPropertyName("dimensionValueSource")]
    public string? DimensionValueSource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationCloudWatchDestination
{
    /// <summary>An array of objects that define the dimensions to use when you send email events to Amazon CloudWatch. See dimension_configuration Block for details.</summary>
    [JsonPropertyName("dimensionConfiguration")]
    public IList<V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationCloudWatchDestinationDimensionConfiguration>? DimensionConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationEventBridgeDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon EventBridge bus to publish email events to. Only the default bus is supported.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationKinesisFirehoseDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon Kinesis Data Firehose stream that the Amazon SES API v2 sends email events to.</summary>
    [JsonPropertyName("deliveryStreamArn")]
    public string? DeliveryStreamArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role that the Amazon SES API v2 uses to send email events to the Amazon Kinesis Data Firehose stream.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationPinpointDestination
{
    /// <summary></summary>
    [JsonPropertyName("applicationArn")]
    public string? ApplicationArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationSnsDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon SNS topic to publish email events to.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A name that identifies the event destination within the configuration set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestination
{
    /// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
    [JsonPropertyName("cloudWatchDestination")]
    public V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationCloudWatchDestination? CloudWatchDestination { get; set; }

    /// <summary>When the event destination is enabled, the specified event types are sent to the destinations. Default: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eventBridgeDestination")]
    public V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationEventBridgeDestination? EventBridgeDestination { get; set; }

    /// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
    [JsonPropertyName("kinesisFirehoseDestination")]
    public V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationKinesisFirehoseDestination? KinesisFirehoseDestination { get; set; }

    /// <summary>- An array that specifies which events the Amazon SES API v2 should send to the destinations. Valid values: SEND, REJECT, BOUNCE, COMPLAINT, DELIVERY, OPEN, CLICK, RENDERING_FAILURE, DELIVERY_DELAY, SUBSCRIPTION.</summary>
    [JsonPropertyName("matchingEventTypes")]
    public IList<string>? MatchingEventTypes { get; set; }

    /// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
    [JsonPropertyName("pinpointDestination")]
    public V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationPinpointDestination? PinpointDestination { get; set; }

    /// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
    [JsonPropertyName("snsDestination")]
    public V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestinationSnsDestination? SnsDestination { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationStatusAtProvider
{
    /// <summary>The name of the configuration set.</summary>
    [JsonPropertyName("configurationSetName")]
    public string? ConfigurationSetName { get; set; }

    /// <summary>A name that identifies the event destination within the configuration set.</summary>
    [JsonPropertyName("eventDestination")]
    public V1beta1ConfigurationSetEventDestinationStatusAtProviderEventDestination? EventDestination { get; set; }

    /// <summary>An object that defines the event destination. See event_destination Block for details.</summary>
    [JsonPropertyName("eventDestinationName")]
    public string? EventDestinationName { get; set; }

    /// <summary>A pipe-delimited string combining configuration_set_name and event_destination_name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationStatusConditions
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
/// <summary>ConfigurationSetEventDestinationStatus defines the observed state of ConfigurationSetEventDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConfigurationSetEventDestinationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConfigurationSetEventDestinationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConfigurationSetEventDestinationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ConfigurationSetEventDestination is the Schema for the ConfigurationSetEventDestinations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConfigurationSetEventDestination : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConfigurationSetEventDestinationSpec>, IStatus<V1beta1ConfigurationSetEventDestinationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConfigurationSetEventDestination";
    public const string KubeGroup = "sesv2.aws.m.upbound.io";
    public const string KubePluralName = "configurationseteventdestinations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConfigurationSetEventDestinationSpec defines the desired state of ConfigurationSetEventDestination</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConfigurationSetEventDestinationSpec Spec { get; set; }

    /// <summary>ConfigurationSetEventDestinationStatus defines the observed state of ConfigurationSetEventDestination.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConfigurationSetEventDestinationStatus? Status { get; set; }
}
#nullable disable
