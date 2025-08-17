using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.connect.aws.m.upbound.io;
#nullable enable
/// <summary>InstanceStorageConfig is the Schema for the InstanceStorageConfigs API. Provides details about a specific Amazon Connect Instance Storage Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceStorageConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1InstanceStorageConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceStorageConfigList";
    public const string KubeGroup = "connect.aws.m.upbound.io";
    public const string KubePluralName = "instancestorageconfigs";
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
    public IList<V1beta1InstanceStorageConfig> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderInstanceIdRefPolicy
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
/// <summary>Reference to a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecForProviderInstanceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderInstanceIdSelectorPolicy
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
/// <summary>Selector for a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderInstanceIdSelector
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
    public V1beta1InstanceStorageConfigSpecForProviderInstanceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisFirehoseConfigFirehoseArnRefPolicy
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
/// <summary>Reference to a DeliveryStream in firehose to populate firehoseArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisFirehoseConfigFirehoseArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisFirehoseConfigFirehoseArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisFirehoseConfigFirehoseArnSelectorPolicy
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
/// <summary>Selector for a DeliveryStream in firehose to populate firehoseArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisFirehoseConfigFirehoseArnSelector
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
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisFirehoseConfigFirehoseArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of the Kinesis Firehose delivery stream. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisFirehoseConfig
{
    /// <summary>The Amazon Resource Name (ARN) of the delivery stream.</summary>
    [JsonPropertyName("firehoseArn")]
    public string? FirehoseArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate firehoseArn.</summary>
    [JsonPropertyName("firehoseArnRef")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisFirehoseConfigFirehoseArnRef? FirehoseArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate firehoseArn.</summary>
    [JsonPropertyName("firehoseArnSelector")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisFirehoseConfigFirehoseArnSelector? FirehoseArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisStreamConfigStreamArnRefPolicy
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
/// <summary>Reference to a Stream in kinesis to populate streamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisStreamConfigStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisStreamConfigStreamArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisStreamConfigStreamArnSelectorPolicy
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
/// <summary>Selector for a Stream in kinesis to populate streamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisStreamConfigStreamArnSelector
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
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisStreamConfigStreamArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of the Kinesis data stream. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisStreamConfig
{
    /// <summary>The Amazon Resource Name (ARN) of the data stream.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }

    /// <summary>Reference to a Stream in kinesis to populate streamArn.</summary>
    [JsonPropertyName("streamArnRef")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisStreamConfigStreamArnRef? StreamArnRef { get; set; }

    /// <summary>Selector for a Stream in kinesis to populate streamArn.</summary>
    [JsonPropertyName("streamArnSelector")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisStreamConfigStreamArnSelector? StreamArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdRefPolicy
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
/// <summary>Reference to a Key in kms to populate keyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdSelectorPolicy
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
/// <summary>Selector for a Key in kms to populate keyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdSelector
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
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The encryption configuration. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfigEncryptionConfig
{
    /// <summary>The type of encryption. Valid Values: KMS.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The full ARN of the encryption key. Be sure to provide the full ARN of the encryption key, not just the ID.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate keyId.</summary>
    [JsonPropertyName("keyIdRef")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdRef? KeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate keyId.</summary>
    [JsonPropertyName("keyIdSelector")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdSelector? KeyIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of the Kinesis video stream. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfig
{
    /// <summary>The encryption configuration. Documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>The prefix of the video stream. Minimum length of 1. Maximum length of 128. When read from the state, the value returned is &lt;prefix&gt;-connect-&lt;connect_instance_alias&gt;-contact- since the API appends additional details to the prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The number of hours data is retained in the stream. Kinesis Video Streams retains the data in a data store that is associated with the stream. Minimum value of 0. Maximum value of 87600. A value of 0, indicates that the stream does not persist data.</summary>
    [JsonPropertyName("retentionPeriodHours")]
    public double? RetentionPeriodHours { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigBucketNameRefPolicy
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
/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigBucketNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigBucketNameSelectorPolicy
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
/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigBucketNameSelector
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
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigBucketNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigEncryptionConfigKeyIdRefPolicy
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
/// <summary>Reference to a Key in kms to populate keyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigEncryptionConfigKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigEncryptionConfigKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigEncryptionConfigKeyIdSelectorPolicy
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
/// <summary>Selector for a Key in kms to populate keyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigEncryptionConfigKeyIdSelector
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
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigEncryptionConfigKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The encryption configuration. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigEncryptionConfig
{
    /// <summary>The type of encryption. Valid Values: KMS.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The full ARN of the encryption key. Be sure to provide the full ARN of the encryption key, not just the ID.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate keyId.</summary>
    [JsonPropertyName("keyIdRef")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigEncryptionConfigKeyIdRef? KeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate keyId.</summary>
    [JsonPropertyName("keyIdSelector")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigEncryptionConfigKeyIdSelector? KeyIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of S3 Bucket. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3Config
{
    /// <summary>The S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>The S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>The encryption configuration. Documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3ConfigEncryptionConfig? EncryptionConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the storage configuration options for the Connect Instance. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProviderStorageConfig
{
    /// <summary>A block that specifies the configuration of the Kinesis Firehose delivery stream. Documented below.</summary>
    [JsonPropertyName("kinesisFirehoseConfig")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisFirehoseConfig? KinesisFirehoseConfig { get; set; }

    /// <summary>A block that specifies the configuration of the Kinesis data stream. Documented below.</summary>
    [JsonPropertyName("kinesisStreamConfig")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisStreamConfig? KinesisStreamConfig { get; set; }

    /// <summary>A block that specifies the configuration of the Kinesis video stream. Documented below.</summary>
    [JsonPropertyName("kinesisVideoStreamConfig")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigKinesisVideoStreamConfig? KinesisVideoStreamConfig { get; set; }

    /// <summary>A block that specifies the configuration of S3 Bucket. Documented below.</summary>
    [JsonPropertyName("s3Config")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfigS3Config? S3Config { get; set; }

    /// <summary>A valid storage type. Valid Values: S3 | KINESIS_VIDEO_STREAM | KINESIS_STREAM | KINESIS_FIREHOSE.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecForProvider
{
    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta1InstanceStorageConfigSpecForProviderInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta1InstanceStorageConfigSpecForProviderInstanceIdSelector? InstanceIdSelector { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A valid resource type. Valid Values: AGENT_EVENTS | ATTACHMENTS | CALL_RECORDINGS | CHAT_TRANSCRIPTS | CONTACT_EVALUATIONS | CONTACT_TRACE_RECORDS | EMAIL_MESSAGES | MEDIA_STREAMS | REAL_TIME_CONTACT_ANALYSIS_CHAT_SEGMENTS | REAL_TIME_CONTACT_ANALYSIS_SEGMENTS | REAL_TIME_CONTACT_ANALYSIS_VOICE_SEGMENTS | SCHEDULED_REPORTS | SCREEN_RECORDINGS.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Specifies the storage configuration options for the Connect Instance. Documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public V1beta1InstanceStorageConfigSpecForProviderStorageConfig? StorageConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderInstanceIdRefPolicy
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
/// <summary>Reference to a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecInitProviderInstanceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderInstanceIdSelectorPolicy
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
/// <summary>Selector for a Instance in connect to populate instanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderInstanceIdSelector
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
    public V1beta1InstanceStorageConfigSpecInitProviderInstanceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisFirehoseConfigFirehoseArnRefPolicy
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
/// <summary>Reference to a DeliveryStream in firehose to populate firehoseArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisFirehoseConfigFirehoseArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisFirehoseConfigFirehoseArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisFirehoseConfigFirehoseArnSelectorPolicy
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
/// <summary>Selector for a DeliveryStream in firehose to populate firehoseArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisFirehoseConfigFirehoseArnSelector
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
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisFirehoseConfigFirehoseArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of the Kinesis Firehose delivery stream. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisFirehoseConfig
{
    /// <summary>The Amazon Resource Name (ARN) of the delivery stream.</summary>
    [JsonPropertyName("firehoseArn")]
    public string? FirehoseArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate firehoseArn.</summary>
    [JsonPropertyName("firehoseArnRef")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisFirehoseConfigFirehoseArnRef? FirehoseArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate firehoseArn.</summary>
    [JsonPropertyName("firehoseArnSelector")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisFirehoseConfigFirehoseArnSelector? FirehoseArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisStreamConfigStreamArnRefPolicy
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
/// <summary>Reference to a Stream in kinesis to populate streamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisStreamConfigStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisStreamConfigStreamArnRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisStreamConfigStreamArnSelectorPolicy
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
/// <summary>Selector for a Stream in kinesis to populate streamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisStreamConfigStreamArnSelector
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
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisStreamConfigStreamArnSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of the Kinesis data stream. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisStreamConfig
{
    /// <summary>The Amazon Resource Name (ARN) of the data stream.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }

    /// <summary>Reference to a Stream in kinesis to populate streamArn.</summary>
    [JsonPropertyName("streamArnRef")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisStreamConfigStreamArnRef? StreamArnRef { get; set; }

    /// <summary>Selector for a Stream in kinesis to populate streamArn.</summary>
    [JsonPropertyName("streamArnSelector")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisStreamConfigStreamArnSelector? StreamArnSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdRefPolicy
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
/// <summary>Reference to a Key in kms to populate keyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdSelectorPolicy
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
/// <summary>Selector for a Key in kms to populate keyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdSelector
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
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The encryption configuration. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfigEncryptionConfig
{
    /// <summary>The type of encryption. Valid Values: KMS.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The full ARN of the encryption key. Be sure to provide the full ARN of the encryption key, not just the ID.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate keyId.</summary>
    [JsonPropertyName("keyIdRef")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdRef? KeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate keyId.</summary>
    [JsonPropertyName("keyIdSelector")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfigEncryptionConfigKeyIdSelector? KeyIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of the Kinesis video stream. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfig
{
    /// <summary>The encryption configuration. Documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>The prefix of the video stream. Minimum length of 1. Maximum length of 128. When read from the state, the value returned is &lt;prefix&gt;-connect-&lt;connect_instance_alias&gt;-contact- since the API appends additional details to the prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The number of hours data is retained in the stream. Kinesis Video Streams retains the data in a data store that is associated with the stream. Minimum value of 0. Maximum value of 87600. A value of 0, indicates that the stream does not persist data.</summary>
    [JsonPropertyName("retentionPeriodHours")]
    public double? RetentionPeriodHours { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigBucketNameRefPolicy
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
/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigBucketNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigBucketNameSelectorPolicy
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
/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigBucketNameSelector
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
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigBucketNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigEncryptionConfigKeyIdRefPolicy
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
/// <summary>Reference to a Key in kms to populate keyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigEncryptionConfigKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigEncryptionConfigKeyIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigEncryptionConfigKeyIdSelectorPolicy
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
/// <summary>Selector for a Key in kms to populate keyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigEncryptionConfigKeyIdSelector
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
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigEncryptionConfigKeyIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The encryption configuration. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigEncryptionConfig
{
    /// <summary>The type of encryption. Valid Values: KMS.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The full ARN of the encryption key. Be sure to provide the full ARN of the encryption key, not just the ID.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate keyId.</summary>
    [JsonPropertyName("keyIdRef")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigEncryptionConfigKeyIdRef? KeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate keyId.</summary>
    [JsonPropertyName("keyIdSelector")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigEncryptionConfigKeyIdSelector? KeyIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of S3 Bucket. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3Config
{
    /// <summary>The S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>The S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>The encryption configuration. Documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3ConfigEncryptionConfig? EncryptionConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the storage configuration options for the Connect Instance. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProviderStorageConfig
{
    /// <summary>A block that specifies the configuration of the Kinesis Firehose delivery stream. Documented below.</summary>
    [JsonPropertyName("kinesisFirehoseConfig")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisFirehoseConfig? KinesisFirehoseConfig { get; set; }

    /// <summary>A block that specifies the configuration of the Kinesis data stream. Documented below.</summary>
    [JsonPropertyName("kinesisStreamConfig")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisStreamConfig? KinesisStreamConfig { get; set; }

    /// <summary>A block that specifies the configuration of the Kinesis video stream. Documented below.</summary>
    [JsonPropertyName("kinesisVideoStreamConfig")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigKinesisVideoStreamConfig? KinesisVideoStreamConfig { get; set; }

    /// <summary>A block that specifies the configuration of S3 Bucket. Documented below.</summary>
    [JsonPropertyName("s3Config")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfigS3Config? S3Config { get; set; }

    /// <summary>A valid storage type. Valid Values: S3 | KINESIS_VIDEO_STREAM | KINESIS_STREAM | KINESIS_FIREHOSE.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecInitProvider
{
    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Reference to a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdRef")]
    public V1beta1InstanceStorageConfigSpecInitProviderInstanceIdRef? InstanceIdRef { get; set; }

    /// <summary>Selector for a Instance in connect to populate instanceId.</summary>
    [JsonPropertyName("instanceIdSelector")]
    public V1beta1InstanceStorageConfigSpecInitProviderInstanceIdSelector? InstanceIdSelector { get; set; }

    /// <summary>A valid resource type. Valid Values: AGENT_EVENTS | ATTACHMENTS | CALL_RECORDINGS | CHAT_TRANSCRIPTS | CONTACT_EVALUATIONS | CONTACT_TRACE_RECORDS | EMAIL_MESSAGES | MEDIA_STREAMS | REAL_TIME_CONTACT_ANALYSIS_CHAT_SEGMENTS | REAL_TIME_CONTACT_ANALYSIS_SEGMENTS | REAL_TIME_CONTACT_ANALYSIS_VOICE_SEGMENTS | SCHEDULED_REPORTS | SCREEN_RECORDINGS.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Specifies the storage configuration options for the Connect Instance. Documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public V1beta1InstanceStorageConfigSpecInitProviderStorageConfig? StorageConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpecProviderConfigRef
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
public partial class V1beta1InstanceStorageConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>InstanceStorageConfigSpec defines the desired state of InstanceStorageConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1InstanceStorageConfigSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1InstanceStorageConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstanceStorageConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstanceStorageConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of the Kinesis Firehose delivery stream. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigStatusAtProviderStorageConfigKinesisFirehoseConfig
{
    /// <summary>The Amazon Resource Name (ARN) of the delivery stream.</summary>
    [JsonPropertyName("firehoseArn")]
    public string? FirehoseArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of the Kinesis data stream. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigStatusAtProviderStorageConfigKinesisStreamConfig
{
    /// <summary>The Amazon Resource Name (ARN) of the data stream.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The encryption configuration. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigStatusAtProviderStorageConfigKinesisVideoStreamConfigEncryptionConfig
{
    /// <summary>The type of encryption. Valid Values: KMS.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The full ARN of the encryption key. Be sure to provide the full ARN of the encryption key, not just the ID.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of the Kinesis video stream. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigStatusAtProviderStorageConfigKinesisVideoStreamConfig
{
    /// <summary>The encryption configuration. Documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta1InstanceStorageConfigStatusAtProviderStorageConfigKinesisVideoStreamConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>The prefix of the video stream. Minimum length of 1. Maximum length of 128. When read from the state, the value returned is &lt;prefix&gt;-connect-&lt;connect_instance_alias&gt;-contact- since the API appends additional details to the prefix.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The number of hours data is retained in the stream. Kinesis Video Streams retains the data in a data store that is associated with the stream. Minimum value of 0. Maximum value of 87600. A value of 0, indicates that the stream does not persist data.</summary>
    [JsonPropertyName("retentionPeriodHours")]
    public double? RetentionPeriodHours { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The encryption configuration. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigStatusAtProviderStorageConfigS3ConfigEncryptionConfig
{
    /// <summary>The type of encryption. Valid Values: KMS.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>The full ARN of the encryption key. Be sure to provide the full ARN of the encryption key, not just the ID.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A block that specifies the configuration of S3 Bucket. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigStatusAtProviderStorageConfigS3Config
{
    /// <summary>The S3 bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The S3 bucket prefix.</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>The encryption configuration. Documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta1InstanceStorageConfigStatusAtProviderStorageConfigS3ConfigEncryptionConfig? EncryptionConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the storage configuration options for the Connect Instance. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigStatusAtProviderStorageConfig
{
    /// <summary>A block that specifies the configuration of the Kinesis Firehose delivery stream. Documented below.</summary>
    [JsonPropertyName("kinesisFirehoseConfig")]
    public V1beta1InstanceStorageConfigStatusAtProviderStorageConfigKinesisFirehoseConfig? KinesisFirehoseConfig { get; set; }

    /// <summary>A block that specifies the configuration of the Kinesis data stream. Documented below.</summary>
    [JsonPropertyName("kinesisStreamConfig")]
    public V1beta1InstanceStorageConfigStatusAtProviderStorageConfigKinesisStreamConfig? KinesisStreamConfig { get; set; }

    /// <summary>A block that specifies the configuration of the Kinesis video stream. Documented below.</summary>
    [JsonPropertyName("kinesisVideoStreamConfig")]
    public V1beta1InstanceStorageConfigStatusAtProviderStorageConfigKinesisVideoStreamConfig? KinesisVideoStreamConfig { get; set; }

    /// <summary>A block that specifies the configuration of S3 Bucket. Documented below.</summary>
    [JsonPropertyName("s3Config")]
    public V1beta1InstanceStorageConfigStatusAtProviderStorageConfigS3Config? S3Config { get; set; }

    /// <summary>A valid storage type. Valid Values: S3 | KINESIS_VIDEO_STREAM | KINESIS_STREAM | KINESIS_FIREHOSE.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigStatusAtProvider
{
    /// <summary>The existing association identifier that uniquely identifies the resource type and storage config for the given instance ID.</summary>
    [JsonPropertyName("associationId")]
    public string? AssociationId { get; set; }

    /// <summary>The identifier of the hosting Amazon Connect Instance, association_id, and resource_type separated by a colon (:).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the identifier of the hosting Amazon Connect Instance.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A valid resource type. Valid Values: AGENT_EVENTS | ATTACHMENTS | CALL_RECORDINGS | CHAT_TRANSCRIPTS | CONTACT_EVALUATIONS | CONTACT_TRACE_RECORDS | EMAIL_MESSAGES | MEDIA_STREAMS | REAL_TIME_CONTACT_ANALYSIS_CHAT_SEGMENTS | REAL_TIME_CONTACT_ANALYSIS_SEGMENTS | REAL_TIME_CONTACT_ANALYSIS_VOICE_SEGMENTS | SCHEDULED_REPORTS | SCREEN_RECORDINGS.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Specifies the storage configuration options for the Connect Instance. Documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public V1beta1InstanceStorageConfigStatusAtProviderStorageConfig? StorageConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigStatusConditions
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
/// <summary>InstanceStorageConfigStatus defines the observed state of InstanceStorageConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstanceStorageConfigStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1InstanceStorageConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstanceStorageConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>InstanceStorageConfig is the Schema for the InstanceStorageConfigs API. Provides details about a specific Amazon Connect Instance Storage Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstanceStorageConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstanceStorageConfigSpec>, IStatus<V1beta1InstanceStorageConfigStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstanceStorageConfig";
    public const string KubeGroup = "connect.aws.m.upbound.io";
    public const string KubePluralName = "instancestorageconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceStorageConfigSpec defines the desired state of InstanceStorageConfig</summary>
    [JsonPropertyName("spec")]
    public V1beta1InstanceStorageConfigSpec Spec { get; set; }

    /// <summary>InstanceStorageConfigStatus defines the observed state of InstanceStorageConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstanceStorageConfigStatus? Status { get; set; }
}
#nullable disable
