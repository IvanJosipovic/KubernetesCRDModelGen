using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.glue.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate awsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate awsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption
{
    /// <summary>A KMS key ARN that is used to encrypt the connection password. If connection password protection is enabled, the caller of CreateConnection and UpdateConnection needs at least kms:Encrypt permission on the specified AWS KMS key, to encrypt passwords before storing them in the Data Catalog.</summary>
    [JsonPropertyName("awsKmsKeyId")]
    public string? AwsKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate awsKmsKeyId.</summary>
    [JsonPropertyName("awsKmsKeyIdRef")]
    public V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRef? AwsKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate awsKmsKeyId.</summary>
    [JsonPropertyName("awsKmsKeyIdSelector")]
    public V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelector? AwsKmsKeyIdSelector { get; set; }

    /// <summary>When set to true, passwords remain encrypted in the responses of GetConnection and GetConnections. This encryption takes effect independently of the catalog encryption.</summary>
    [JsonPropertyName("returnConnectionPasswordEncrypted")]
    public bool? ReturnConnectionPasswordEncrypted { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate sseAwsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate sseAwsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRest
{
    /// <summary>The encryption-at-rest mode for encrypting Data Catalog data. Valid values: DISABLED, SSE-KMS, SSE-KMS-WITH-SERVICE-ROLE.</summary>
    [JsonPropertyName("catalogEncryptionMode")]
    public string? CatalogEncryptionMode { get; set; }

    /// <summary>The ARN of the AWS IAM role used for accessing encrypted Data Catalog data.</summary>
    [JsonPropertyName("catalogEncryptionServiceRole")]
    public string? CatalogEncryptionServiceRole { get; set; }

    /// <summary>The ARN of the AWS KMS key to use for encryption at rest.</summary>
    [JsonPropertyName("sseAwsKmsKeyId")]
    public string? SseAwsKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate sseAwsKmsKeyId.</summary>
    [JsonPropertyName("sseAwsKmsKeyIdRef")]
    public V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRef? SseAwsKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate sseAwsKmsKeyId.</summary>
    [JsonPropertyName("sseAwsKmsKeyIdSelector")]
    public V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelector? SseAwsKmsKeyIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettings
{
    /// <summary>When connection password protection is enabled, the Data Catalog uses a customer-provided key to encrypt the password as part of CreateConnection or UpdateConnection and store it in the ENCRYPTED_PASSWORD field in the connection properties. You can enable catalog encryption or only password encryption. see Connection Password Encryption.</summary>
    [JsonPropertyName("connectionPasswordEncryption")]
    public IList<V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption>? ConnectionPasswordEncryption { get; set; }

    /// <summary>Specifies the encryption-at-rest configuration for the Data Catalog. see Encryption At Rest.</summary>
    [JsonPropertyName("encryptionAtRest")]
    public IList<V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettingsEncryptionAtRest>? EncryptionAtRest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecForProvider
{
    /// <summary>–  The ID of the Data Catalog to set the security configuration for. If none is provided, the AWS account ID is used by default.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>–  The security configuration to set. see Data Catalog Encryption Settings.</summary>
    [JsonPropertyName("dataCatalogEncryptionSettings")]
    public IList<V1beta1DataCatalogEncryptionSettingsSpecForProviderDataCatalogEncryptionSettings>? DataCatalogEncryptionSettings { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate awsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate awsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption
{
    /// <summary>A KMS key ARN that is used to encrypt the connection password. If connection password protection is enabled, the caller of CreateConnection and UpdateConnection needs at least kms:Encrypt permission on the specified AWS KMS key, to encrypt passwords before storing them in the Data Catalog.</summary>
    [JsonPropertyName("awsKmsKeyId")]
    public string? AwsKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate awsKmsKeyId.</summary>
    [JsonPropertyName("awsKmsKeyIdRef")]
    public V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdRef? AwsKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate awsKmsKeyId.</summary>
    [JsonPropertyName("awsKmsKeyIdSelector")]
    public V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryptionAwsKmsKeyIdSelector? AwsKmsKeyIdSelector { get; set; }

    /// <summary>When set to true, passwords remain encrypted in the responses of GetConnection and GetConnections. This encryption takes effect independently of the catalog encryption.</summary>
    [JsonPropertyName("returnConnectionPasswordEncrypted")]
    public bool? ReturnConnectionPasswordEncrypted { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate sseAwsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate sseAwsKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRest
{
    /// <summary>The encryption-at-rest mode for encrypting Data Catalog data. Valid values: DISABLED, SSE-KMS, SSE-KMS-WITH-SERVICE-ROLE.</summary>
    [JsonPropertyName("catalogEncryptionMode")]
    public string? CatalogEncryptionMode { get; set; }

    /// <summary>The ARN of the AWS IAM role used for accessing encrypted Data Catalog data.</summary>
    [JsonPropertyName("catalogEncryptionServiceRole")]
    public string? CatalogEncryptionServiceRole { get; set; }

    /// <summary>The ARN of the AWS KMS key to use for encryption at rest.</summary>
    [JsonPropertyName("sseAwsKmsKeyId")]
    public string? SseAwsKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate sseAwsKmsKeyId.</summary>
    [JsonPropertyName("sseAwsKmsKeyIdRef")]
    public V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdRef? SseAwsKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate sseAwsKmsKeyId.</summary>
    [JsonPropertyName("sseAwsKmsKeyIdSelector")]
    public V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRestSseAwsKmsKeyIdSelector? SseAwsKmsKeyIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettings
{
    /// <summary>When connection password protection is enabled, the Data Catalog uses a customer-provided key to encrypt the password as part of CreateConnection or UpdateConnection and store it in the ENCRYPTED_PASSWORD field in the connection properties. You can enable catalog encryption or only password encryption. see Connection Password Encryption.</summary>
    [JsonPropertyName("connectionPasswordEncryption")]
    public IList<V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption>? ConnectionPasswordEncryption { get; set; }

    /// <summary>Specifies the encryption-at-rest configuration for the Data Catalog. see Encryption At Rest.</summary>
    [JsonPropertyName("encryptionAtRest")]
    public IList<V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettingsEncryptionAtRest>? EncryptionAtRest { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecInitProvider
{
    /// <summary>–  The ID of the Data Catalog to set the security configuration for. If none is provided, the AWS account ID is used by default.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>–  The security configuration to set. see Data Catalog Encryption Settings.</summary>
    [JsonPropertyName("dataCatalogEncryptionSettings")]
    public IList<V1beta1DataCatalogEncryptionSettingsSpecInitProviderDataCatalogEncryptionSettings>? DataCatalogEncryptionSettings { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecProviderConfigRefPolicy
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
public partial class V1beta1DataCatalogEncryptionSettingsSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataCatalogEncryptionSettingsSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataCatalogEncryptionSettingsSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DataCatalogEncryptionSettingsSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DataCatalogEncryptionSettingsSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DataCatalogEncryptionSettingsSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DataCatalogEncryptionSettingsSpec defines the desired state of DataCatalogEncryptionSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DataCatalogEncryptionSettingsSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DataCatalogEncryptionSettingsSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DataCatalogEncryptionSettingsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DataCatalogEncryptionSettingsSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DataCatalogEncryptionSettingsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption
{
    /// <summary>A KMS key ARN that is used to encrypt the connection password. If connection password protection is enabled, the caller of CreateConnection and UpdateConnection needs at least kms:Encrypt permission on the specified AWS KMS key, to encrypt passwords before storing them in the Data Catalog.</summary>
    [JsonPropertyName("awsKmsKeyId")]
    public string? AwsKmsKeyId { get; set; }

    /// <summary>When set to true, passwords remain encrypted in the responses of GetConnection and GetConnections. This encryption takes effect independently of the catalog encryption.</summary>
    [JsonPropertyName("returnConnectionPasswordEncrypted")]
    public bool? ReturnConnectionPasswordEncrypted { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettingsEncryptionAtRest
{
    /// <summary>The encryption-at-rest mode for encrypting Data Catalog data. Valid values: DISABLED, SSE-KMS, SSE-KMS-WITH-SERVICE-ROLE.</summary>
    [JsonPropertyName("catalogEncryptionMode")]
    public string? CatalogEncryptionMode { get; set; }

    /// <summary>The ARN of the AWS IAM role used for accessing encrypted Data Catalog data.</summary>
    [JsonPropertyName("catalogEncryptionServiceRole")]
    public string? CatalogEncryptionServiceRole { get; set; }

    /// <summary>The ARN of the AWS KMS key to use for encryption at rest.</summary>
    [JsonPropertyName("sseAwsKmsKeyId")]
    public string? SseAwsKmsKeyId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettings
{
    /// <summary>When connection password protection is enabled, the Data Catalog uses a customer-provided key to encrypt the password as part of CreateConnection or UpdateConnection and store it in the ENCRYPTED_PASSWORD field in the connection properties. You can enable catalog encryption or only password encryption. see Connection Password Encryption.</summary>
    [JsonPropertyName("connectionPasswordEncryption")]
    public IList<V1beta1DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettingsConnectionPasswordEncryption>? ConnectionPasswordEncryption { get; set; }

    /// <summary>Specifies the encryption-at-rest configuration for the Data Catalog. see Encryption At Rest.</summary>
    [JsonPropertyName("encryptionAtRest")]
    public IList<V1beta1DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettingsEncryptionAtRest>? EncryptionAtRest { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsStatusAtProvider
{
    /// <summary>–  The ID of the Data Catalog to set the security configuration for. If none is provided, the AWS account ID is used by default.</summary>
    [JsonPropertyName("catalogId")]
    public string? CatalogId { get; set; }

    /// <summary>–  The security configuration to set. see Data Catalog Encryption Settings.</summary>
    [JsonPropertyName("dataCatalogEncryptionSettings")]
    public IList<V1beta1DataCatalogEncryptionSettingsStatusAtProviderDataCatalogEncryptionSettings>? DataCatalogEncryptionSettings { get; set; }

    /// <summary>The ID of the Data Catalog to set the security configuration for.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsStatusConditions
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

/// <summary>DataCatalogEncryptionSettingsStatus defines the observed state of DataCatalogEncryptionSettings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataCatalogEncryptionSettingsStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DataCatalogEncryptionSettingsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataCatalogEncryptionSettingsStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DataCatalogEncryptionSettings is the Schema for the DataCatalogEncryptionSettingss API. Provides a Glue Data Catalog Encryption Settings resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataCatalogEncryptionSettings : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataCatalogEncryptionSettingsSpec>, IStatus<V1beta1DataCatalogEncryptionSettingsStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataCatalogEncryptionSettings";
    public const string KubeGroup = "glue.aws.upbound.io";
    public const string KubePluralName = "datacatalogencryptionsettings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataCatalogEncryptionSettingsSpec defines the desired state of DataCatalogEncryptionSettings</summary>
    [JsonPropertyName("spec")]
    public V1beta1DataCatalogEncryptionSettingsSpec Spec { get; set; }

    /// <summary>DataCatalogEncryptionSettingsStatus defines the observed state of DataCatalogEncryptionSettings.</summary>
    [JsonPropertyName("status")]
    public V1beta1DataCatalogEncryptionSettingsStatus? Status { get; set; }
}