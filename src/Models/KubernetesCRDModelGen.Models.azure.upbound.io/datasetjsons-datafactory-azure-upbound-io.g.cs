using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProviderAzureBlobStorageLocation
{
    /// <summary>The container on the Azure Blob Storage Account hosting the file.</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>Is the container using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicContainerEnabled")]
    public bool? DynamicContainerEnabled { get; set; }

    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the web server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the web server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProviderDataFactoryIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSetJSONSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProviderDataFactoryIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProviderDataFactoryIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSetJSONSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProviderHttpServerLocation
{
    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the web server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the web server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The base URL to the web server hosting the file.</summary>
    [JsonPropertyName("relativeUrl")]
    public string? RelativeUrl { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProviderLinkedServiceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProviderLinkedServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSetJSONSpecForProviderLinkedServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProviderLinkedServiceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProviderLinkedServiceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSetJSONSpecForProviderLinkedServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProviderSchemaColumn
{
    /// <summary>The description of the column.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of the column. Valid values are Byte, Byte[], Boolean, Date, DateTime,DateTimeOffset, Decimal, Double, Guid, Int16, Int32, Int64, Single, String, TimeSpan. Please note these values are case sensitive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecForProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Dataset.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>A azure_blob_storage_location block as defined below.</summary>
    [JsonPropertyName("azureBlobStorageLocation")]
    public IList<V1beta1DataSetJSONSpecForProviderAzureBlobStorageLocation>? AzureBlobStorageLocation { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta1DataSetJSONSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta1DataSetJSONSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>The description for the Data Factory Dataset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The encoding format for the file.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>A http_server_location block as defined below.</summary>
    [JsonPropertyName("httpServerLocation")]
    public IList<V1beta1DataSetJSONSpecForProviderHttpServerLocation>? HttpServerLocation { get; set; }

    /// <summary>The Data Factory Linked Service name in which to associate the Dataset with.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Reference to a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameRef")]
    public V1beta1DataSetJSONSpecForProviderLinkedServiceNameRef? LinkedServiceNameRef { get; set; }

    /// <summary>Selector for a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameSelector")]
    public V1beta1DataSetJSONSpecForProviderLinkedServiceNameSelector? LinkedServiceNameSelector { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A schema_column block as defined below.</summary>
    [JsonPropertyName("schemaColumn")]
    public IList<V1beta1DataSetJSONSpecForProviderSchemaColumn>? SchemaColumn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecInitProviderAzureBlobStorageLocation
{
    /// <summary>The container on the Azure Blob Storage Account hosting the file.</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>Is the container using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicContainerEnabled")]
    public bool? DynamicContainerEnabled { get; set; }

    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the web server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the web server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecInitProviderHttpServerLocation
{
    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the web server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the web server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The base URL to the web server hosting the file.</summary>
    [JsonPropertyName("relativeUrl")]
    public string? RelativeUrl { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecInitProviderLinkedServiceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecInitProviderLinkedServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSetJSONSpecInitProviderLinkedServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecInitProviderLinkedServiceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecInitProviderLinkedServiceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSetJSONSpecInitProviderLinkedServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecInitProviderSchemaColumn
{
    /// <summary>The description of the column.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of the column. Valid values are Byte, Byte[], Boolean, Date, DateTime,DateTimeOffset, Decimal, Double, Guid, Int16, Int32, Int64, Single, String, TimeSpan. Please note these values are case sensitive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecInitProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Dataset.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>A azure_blob_storage_location block as defined below.</summary>
    [JsonPropertyName("azureBlobStorageLocation")]
    public IList<V1beta1DataSetJSONSpecInitProviderAzureBlobStorageLocation>? AzureBlobStorageLocation { get; set; }

    /// <summary>The description for the Data Factory Dataset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The encoding format for the file.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>A http_server_location block as defined below.</summary>
    [JsonPropertyName("httpServerLocation")]
    public IList<V1beta1DataSetJSONSpecInitProviderHttpServerLocation>? HttpServerLocation { get; set; }

    /// <summary>The Data Factory Linked Service name in which to associate the Dataset with.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Reference to a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameRef")]
    public V1beta1DataSetJSONSpecInitProviderLinkedServiceNameRef? LinkedServiceNameRef { get; set; }

    /// <summary>Selector for a LinkedServiceWeb in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameSelector")]
    public V1beta1DataSetJSONSpecInitProviderLinkedServiceNameSelector? LinkedServiceNameSelector { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A schema_column block as defined below.</summary>
    [JsonPropertyName("schemaColumn")]
    public IList<V1beta1DataSetJSONSpecInitProviderSchemaColumn>? SchemaColumn { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecProviderConfigRefPolicy
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
public partial class V1beta1DataSetJSONSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DataSetJSONSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DataSetJSONSpec defines the desired state of DataSetJSON</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DataSetJSONSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DataSetJSONSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DataSetJSONSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DataSetJSONSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONStatusAtProviderAzureBlobStorageLocation
{
    /// <summary>The container on the Azure Blob Storage Account hosting the file.</summary>
    [JsonPropertyName("container")]
    public string? Container { get; set; }

    /// <summary>Is the container using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicContainerEnabled")]
    public bool? DynamicContainerEnabled { get; set; }

    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the web server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the web server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONStatusAtProviderHttpServerLocation
{
    /// <summary>Is the filename using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicFilenameEnabled")]
    public bool? DynamicFilenameEnabled { get; set; }

    /// <summary>Is the path using dynamic expression, function or system variables? Defaults to false.</summary>
    [JsonPropertyName("dynamicPathEnabled")]
    public bool? DynamicPathEnabled { get; set; }

    /// <summary>The filename of the file on the web server.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>The folder path to the file on the web server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The base URL to the web server hosting the file.</summary>
    [JsonPropertyName("relativeUrl")]
    public string? RelativeUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONStatusAtProviderSchemaColumn
{
    /// <summary>The description of the column.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the column.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type of the column. Valid values are Byte, Byte[], Boolean, Date, DateTime,DateTimeOffset, Decimal, Double, Guid, Int16, Int32, Int64, Single, String, TimeSpan. Please note these values are case sensitive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONStatusAtProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Dataset.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>A azure_blob_storage_location block as defined below.</summary>
    [JsonPropertyName("azureBlobStorageLocation")]
    public IList<V1beta1DataSetJSONStatusAtProviderAzureBlobStorageLocation>? AzureBlobStorageLocation { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>The description for the Data Factory Dataset.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The encoding format for the file.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.</summary>
    [JsonPropertyName("folder")]
    public string? Folder { get; set; }

    /// <summary>A http_server_location block as defined below.</summary>
    [JsonPropertyName("httpServerLocation")]
    public IList<V1beta1DataSetJSONStatusAtProviderHttpServerLocation>? HttpServerLocation { get; set; }

    /// <summary>The ID of the Data Factory Dataset.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Data Factory Linked Service name in which to associate the Dataset with.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Dataset.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A schema_column block as defined below.</summary>
    [JsonPropertyName("schemaColumn")]
    public IList<V1beta1DataSetJSONStatusAtProviderSchemaColumn>? SchemaColumn { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONStatusConditions
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

/// <summary>DataSetJSONStatus defines the observed state of DataSetJSON.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataSetJSONStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DataSetJSONStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataSetJSONStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DataSetJSON is the Schema for the DataSetJSONs API. Manages an Azure JSON Dataset inside an Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataSetJSON : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataSetJSONSpec>, IStatus<V1beta1DataSetJSONStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataSetJSON";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "datasetjsons";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataSetJSONSpec defines the desired state of DataSetJSON</summary>
    [JsonPropertyName("spec")]
    public V1beta1DataSetJSONSpec Spec { get; set; }

    /// <summary>DataSetJSONStatus defines the observed state of DataSetJSON.</summary>
    [JsonPropertyName("status")]
    public V1beta1DataSetJSONStatus? Status { get; set; }
}

/// <summary>DataSetJSON is the Schema for the DataSetJSONs API. Manages an Azure JSON Dataset inside an Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataSetJSONList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DataSetJSON>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataSetJSONList";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "datasetjsons";
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
    public IList<V1beta1DataSetJSON> Items { get; set; }
}