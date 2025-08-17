using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datalossprevention.gcp.m.upbound.io;
#nullable enable
/// <summary>StoredInfoType is the Schema for the StoredInfoTypes API. Allows creation of custom info types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StoredInfoTypeList : IKubernetesObject<V1ListMeta>, IItems<V1beta1StoredInfoType>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StoredInfoTypeList";
    public const string KubeGroup = "datalossprevention.gcp.m.upbound.io";
    public const string KubePluralName = "storedinfotypes";
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
    public IList<V1beta1StoredInfoType> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecForProviderDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>List of words or phrases to search for. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecForProviderDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecForProviderDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta1StoredInfoTypeSpecForProviderDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public V1beta1StoredInfoTypeSpecForProviderDictionaryWordList? WordList { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Designated field in the BigQuery table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryFieldField
{
    /// <summary>The resource name of the info type. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryFieldTable
{
    /// <summary>The dataset ID of the table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The Google Cloud Platform project ID of the project containing the table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryField
{
    /// <summary>Designated field in the BigQuery table. Structure is documented below.</summary>
    [JsonPropertyName("field")]
    public V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryFieldField? Field { get; set; }

    /// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
    [JsonPropertyName("table")]
    public V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryFieldTable? Table { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Set of files containing newline-delimited lists of dictionary phrases. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionaryCloudStorageFileSet
{
    /// <summary>The url, in the format gs://&lt;bucket&gt;/&lt;path&gt;. Trailing wildcard in the path is allowed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API. If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionaryOutputPath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionary
{
    /// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
    [JsonPropertyName("bigQueryField")]
    public V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionaryBigQueryField? BigQueryField { get; set; }

    /// <summary>Set of files containing newline-delimited lists of dictionary phrases. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorageFileSet")]
    public V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionaryCloudStorageFileSet? CloudStorageFileSet { get; set; }

    /// <summary>Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API. If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used. Structure is documented below.</summary>
    [JsonPropertyName("outputPath")]
    public V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionaryOutputPath? OutputPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecForProviderRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecForProvider
{
    /// <summary>A description of the info type.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public V1beta1StoredInfoTypeSpecForProviderDictionary? Dictionary { get; set; }

    /// <summary>User set display name of the info type.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("largeCustomDictionary")]
    public V1beta1StoredInfoTypeSpecForProviderLargeCustomDictionary? LargeCustomDictionary { get; set; }

    /// <summary>The parent of the info type in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public V1beta1StoredInfoTypeSpecForProviderRegex? Regex { get; set; }

    /// <summary>The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("storedInfoTypeId")]
    public string? StoredInfoTypeId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecInitProviderDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>List of words or phrases to search for. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecInitProviderDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecInitProviderDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta1StoredInfoTypeSpecInitProviderDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public V1beta1StoredInfoTypeSpecInitProviderDictionaryWordList? WordList { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Designated field in the BigQuery table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryFieldField
{
    /// <summary>The resource name of the info type. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryFieldTable
{
    /// <summary>The dataset ID of the table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The Google Cloud Platform project ID of the project containing the table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryField
{
    /// <summary>Designated field in the BigQuery table. Structure is documented below.</summary>
    [JsonPropertyName("field")]
    public V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryFieldField? Field { get; set; }

    /// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
    [JsonPropertyName("table")]
    public V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryFieldTable? Table { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Set of files containing newline-delimited lists of dictionary phrases. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionaryCloudStorageFileSet
{
    /// <summary>The url, in the format gs://&lt;bucket&gt;/&lt;path&gt;. Trailing wildcard in the path is allowed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API. If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionaryOutputPath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionary
{
    /// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
    [JsonPropertyName("bigQueryField")]
    public V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionaryBigQueryField? BigQueryField { get; set; }

    /// <summary>Set of files containing newline-delimited lists of dictionary phrases. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorageFileSet")]
    public V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionaryCloudStorageFileSet? CloudStorageFileSet { get; set; }

    /// <summary>Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API. If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used. Structure is documented below.</summary>
    [JsonPropertyName("outputPath")]
    public V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionaryOutputPath? OutputPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecInitProviderRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecInitProvider
{
    /// <summary>A description of the info type.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public V1beta1StoredInfoTypeSpecInitProviderDictionary? Dictionary { get; set; }

    /// <summary>User set display name of the info type.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("largeCustomDictionary")]
    public V1beta1StoredInfoTypeSpecInitProviderLargeCustomDictionary? LargeCustomDictionary { get; set; }

    /// <summary>The parent of the info type in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public V1beta1StoredInfoTypeSpecInitProviderRegex? Regex { get; set; }

    /// <summary>The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("storedInfoTypeId")]
    public string? StoredInfoTypeId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpecProviderConfigRef
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
public partial class V1beta1StoredInfoTypeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>StoredInfoTypeSpec defines the desired state of StoredInfoType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1StoredInfoTypeSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1StoredInfoTypeSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1StoredInfoTypeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1StoredInfoTypeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusAtProviderDictionaryCloudStoragePath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>List of words or phrases to search for. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusAtProviderDictionaryWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusAtProviderDictionary
{
    /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted. Structure is documented below.</summary>
    [JsonPropertyName("cloudStoragePath")]
    public V1beta1StoredInfoTypeStatusAtProviderDictionaryCloudStoragePath? CloudStoragePath { get; set; }

    /// <summary>List of words or phrases to search for. Structure is documented below.</summary>
    [JsonPropertyName("wordList")]
    public V1beta1StoredInfoTypeStatusAtProviderDictionaryWordList? WordList { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Designated field in the BigQuery table. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryFieldField
{
    /// <summary>The resource name of the info type. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryFieldTable
{
    /// <summary>The dataset ID of the table.</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    /// <summary>The Google Cloud Platform project ID of the project containing the table.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>The name of the table.</summary>
    [JsonPropertyName("tableId")]
    public string? TableId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryField
{
    /// <summary>Designated field in the BigQuery table. Structure is documented below.</summary>
    [JsonPropertyName("field")]
    public V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryFieldField? Field { get; set; }

    /// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
    [JsonPropertyName("table")]
    public V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryFieldTable? Table { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Set of files containing newline-delimited lists of dictionary phrases. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionaryCloudStorageFileSet
{
    /// <summary>The url, in the format gs://&lt;bucket&gt;/&lt;path&gt;. Trailing wildcard in the path is allowed.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API. If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionaryOutputPath
{
    /// <summary>A url representing a file or path (no wildcards) in Cloud Storage. Example: gs://[BUCKET_NAME]/dictionary.txt</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionary
{
    /// <summary>Field in a BigQuery table where each cell represents a dictionary phrase. Structure is documented below.</summary>
    [JsonPropertyName("bigQueryField")]
    public V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionaryBigQueryField? BigQueryField { get; set; }

    /// <summary>Set of files containing newline-delimited lists of dictionary phrases. Structure is documented below.</summary>
    [JsonPropertyName("cloudStorageFileSet")]
    public V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionaryCloudStorageFileSet? CloudStorageFileSet { get; set; }

    /// <summary>Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API. If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used. Structure is documented below.</summary>
    [JsonPropertyName("outputPath")]
    public V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionaryOutputPath? OutputPath { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusAtProviderRegex
{
    /// <summary>The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.</summary>
    [JsonPropertyName("groupIndexes")]
    public IList<double>? GroupIndexes { get; set; }

    /// <summary>Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusAtProvider
{
    /// <summary>A description of the info type.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("dictionary")]
    public V1beta1StoredInfoTypeStatusAtProviderDictionary? Dictionary { get; set; }

    /// <summary>User set display name of the info type.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/storedInfoTypes/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Dictionary which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("largeCustomDictionary")]
    public V1beta1StoredInfoTypeStatusAtProviderLargeCustomDictionary? LargeCustomDictionary { get; set; }

    /// <summary>The resource name of the info type. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parent of the info type in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Regular expression which defines the rule. Structure is documented below.</summary>
    [JsonPropertyName("regex")]
    public V1beta1StoredInfoTypeStatusAtProviderRegex? Regex { get; set; }

    /// <summary>The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is 100 characters. Can be empty to allow the system to generate one.</summary>
    [JsonPropertyName("storedInfoTypeId")]
    public string? StoredInfoTypeId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatusConditions
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
/// <summary>StoredInfoTypeStatus defines the observed state of StoredInfoType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StoredInfoTypeStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1StoredInfoTypeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StoredInfoTypeStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>StoredInfoType is the Schema for the StoredInfoTypes API. Allows creation of custom info types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StoredInfoType : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StoredInfoTypeSpec>, IStatus<V1beta1StoredInfoTypeStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StoredInfoType";
    public const string KubeGroup = "datalossprevention.gcp.m.upbound.io";
    public const string KubePluralName = "storedinfotypes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StoredInfoTypeSpec defines the desired state of StoredInfoType</summary>
    [JsonPropertyName("spec")]
    public V1beta1StoredInfoTypeSpec Spec { get; set; }

    /// <summary>StoredInfoTypeStatus defines the observed state of StoredInfoType.</summary>
    [JsonPropertyName("status")]
    public V1beta1StoredInfoTypeStatus? Status { get; set; }
}
#nullable disable
