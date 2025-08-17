using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lambda.aws.m.upbound.io;
#nullable enable
/// <summary>LayerVersion is the Schema for the LayerVersions API. Manages an AWS Lambda Layer Version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LayerVersionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LayerVersion>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LayerVersionList";
    public const string KubeGroup = "lambda.aws.m.upbound.io";
    public const string KubePluralName = "layerversions";
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
    public IList<V1beta1LayerVersion> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecForProviderS3BucketRefPolicy
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
/// <summary>Reference to a Object in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecForProviderS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LayerVersionSpecForProviderS3BucketRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecForProviderS3BucketSelectorPolicy
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
/// <summary>Selector for a Object in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecForProviderS3BucketSelector
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
    public V1beta1LayerVersionSpecForProviderS3BucketSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecForProviderS3KeyRefPolicy
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
/// <summary>Reference to a Object in s3 to populate s3Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecForProviderS3KeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LayerVersionSpecForProviderS3KeyRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecForProviderS3KeySelectorPolicy
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
/// <summary>Selector for a Object in s3 to populate s3Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecForProviderS3KeySelector
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
    public V1beta1LayerVersionSpecForProviderS3KeySelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecForProvider
{
    /// <summary>List of Architectures this layer is compatible with. Currently x86_64 and arm64 can be specified.</summary>
    [JsonPropertyName("compatibleArchitectures")]
    public IList<string>? CompatibleArchitectures { get; set; }

    /// <summary>List of Runtimes this layer is compatible with. Up to 15 runtimes can be specified.</summary>
    [JsonPropertyName("compatibleRuntimes")]
    public IList<string>? CompatibleRuntimes { get; set; }

    /// <summary>Description of what your Lambda Layer does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Path to the function's deployment package within the local filesystem. If defined, The s3_-prefixed options cannot be used.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>Unique name for your Lambda Layer.</summary>
    [JsonPropertyName("layerName")]
    public string? LayerName { get; set; }

    /// <summary>License info for your Lambda Layer. See License Info.</summary>
    [JsonPropertyName("licenseInfo")]
    public string? LicenseInfo { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>S3 bucket location containing the function's deployment package. Conflicts with filename. This bucket must reside in the same AWS region where you are creating the Lambda function.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>Reference to a Object in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketRef")]
    public V1beta1LayerVersionSpecForProviderS3BucketRef? S3BucketRef { get; set; }

    /// <summary>Selector for a Object in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketSelector")]
    public V1beta1LayerVersionSpecForProviderS3BucketSelector? S3BucketSelector { get; set; }

    /// <summary>S3 key of an object containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }

    /// <summary>Reference to a Object in s3 to populate s3Key.</summary>
    [JsonPropertyName("s3KeyRef")]
    public V1beta1LayerVersionSpecForProviderS3KeyRef? S3KeyRef { get; set; }

    /// <summary>Selector for a Object in s3 to populate s3Key.</summary>
    [JsonPropertyName("s3KeySelector")]
    public V1beta1LayerVersionSpecForProviderS3KeySelector? S3KeySelector { get; set; }

    /// <summary>Object version containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3ObjectVersion")]
    public string? S3ObjectVersion { get; set; }

    /// <summary>Whether to retain the old version of a previously deployed Lambda Layer. Default is false. When this is not set to true, changing any of compatible_architectures, compatible_runtimes, description, filename, layer_name, license_info, s3_bucket, s3_key, s3_object_version, or source_code_hash forces deletion of the existing layer version and creation of a new layer version.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Virtual attribute used to trigger replacement when source code changes. Must be set to a base64-encoded SHA256 hash of the package file specified with either filename or s3_key. The usual way to set this is filebase64sha256("file.11.12 or later) or base64sha256(file("file.11.11 and earlier), where "file.zip" is the local filename of the lambda layer source archive.</summary>
    [JsonPropertyName("sourceCodeHash")]
    public string? SourceCodeHash { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecInitProviderS3BucketRefPolicy
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
/// <summary>Reference to a Object in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecInitProviderS3BucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LayerVersionSpecInitProviderS3BucketRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecInitProviderS3BucketSelectorPolicy
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
/// <summary>Selector for a Object in s3 to populate s3Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecInitProviderS3BucketSelector
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
    public V1beta1LayerVersionSpecInitProviderS3BucketSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecInitProviderS3KeyRefPolicy
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
/// <summary>Reference to a Object in s3 to populate s3Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecInitProviderS3KeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LayerVersionSpecInitProviderS3KeyRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecInitProviderS3KeySelectorPolicy
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
/// <summary>Selector for a Object in s3 to populate s3Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecInitProviderS3KeySelector
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
    public V1beta1LayerVersionSpecInitProviderS3KeySelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecInitProvider
{
    /// <summary>List of Architectures this layer is compatible with. Currently x86_64 and arm64 can be specified.</summary>
    [JsonPropertyName("compatibleArchitectures")]
    public IList<string>? CompatibleArchitectures { get; set; }

    /// <summary>List of Runtimes this layer is compatible with. Up to 15 runtimes can be specified.</summary>
    [JsonPropertyName("compatibleRuntimes")]
    public IList<string>? CompatibleRuntimes { get; set; }

    /// <summary>Description of what your Lambda Layer does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Path to the function's deployment package within the local filesystem. If defined, The s3_-prefixed options cannot be used.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>Unique name for your Lambda Layer.</summary>
    [JsonPropertyName("layerName")]
    public string? LayerName { get; set; }

    /// <summary>License info for your Lambda Layer. See License Info.</summary>
    [JsonPropertyName("licenseInfo")]
    public string? LicenseInfo { get; set; }

    /// <summary>S3 bucket location containing the function's deployment package. Conflicts with filename. This bucket must reside in the same AWS region where you are creating the Lambda function.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>Reference to a Object in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketRef")]
    public V1beta1LayerVersionSpecInitProviderS3BucketRef? S3BucketRef { get; set; }

    /// <summary>Selector for a Object in s3 to populate s3Bucket.</summary>
    [JsonPropertyName("s3BucketSelector")]
    public V1beta1LayerVersionSpecInitProviderS3BucketSelector? S3BucketSelector { get; set; }

    /// <summary>S3 key of an object containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }

    /// <summary>Reference to a Object in s3 to populate s3Key.</summary>
    [JsonPropertyName("s3KeyRef")]
    public V1beta1LayerVersionSpecInitProviderS3KeyRef? S3KeyRef { get; set; }

    /// <summary>Selector for a Object in s3 to populate s3Key.</summary>
    [JsonPropertyName("s3KeySelector")]
    public V1beta1LayerVersionSpecInitProviderS3KeySelector? S3KeySelector { get; set; }

    /// <summary>Object version containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3ObjectVersion")]
    public string? S3ObjectVersion { get; set; }

    /// <summary>Whether to retain the old version of a previously deployed Lambda Layer. Default is false. When this is not set to true, changing any of compatible_architectures, compatible_runtimes, description, filename, layer_name, license_info, s3_bucket, s3_key, s3_object_version, or source_code_hash forces deletion of the existing layer version and creation of a new layer version.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Virtual attribute used to trigger replacement when source code changes. Must be set to a base64-encoded SHA256 hash of the package file specified with either filename or s3_key. The usual way to set this is filebase64sha256("file.11.12 or later) or base64sha256(file("file.11.11 and earlier), where "file.zip" is the local filename of the lambda layer source archive.</summary>
    [JsonPropertyName("sourceCodeHash")]
    public string? SourceCodeHash { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpecProviderConfigRef
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
public partial class V1beta1LayerVersionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>LayerVersionSpec defines the desired state of LayerVersion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LayerVersionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LayerVersionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LayerVersionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LayerVersionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionStatusAtProvider
{
    /// <summary>ARN of the Lambda Layer with version.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Base64-encoded representation of raw SHA-256 sum of the zip file.</summary>
    [JsonPropertyName("codeSha256")]
    public string? CodeSha256 { get; set; }

    /// <summary>List of Architectures this layer is compatible with. Currently x86_64 and arm64 can be specified.</summary>
    [JsonPropertyName("compatibleArchitectures")]
    public IList<string>? CompatibleArchitectures { get; set; }

    /// <summary>List of Runtimes this layer is compatible with. Up to 15 runtimes can be specified.</summary>
    [JsonPropertyName("compatibleRuntimes")]
    public IList<string>? CompatibleRuntimes { get; set; }

    /// <summary>Date this resource was created.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>Description of what your Lambda Layer does.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Path to the function's deployment package within the local filesystem. If defined, The s3_-prefixed options cannot be used.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of the Lambda Layer without version.</summary>
    [JsonPropertyName("layerArn")]
    public string? LayerArn { get; set; }

    /// <summary>Unique name for your Lambda Layer.</summary>
    [JsonPropertyName("layerName")]
    public string? LayerName { get; set; }

    /// <summary>License info for your Lambda Layer. See License Info.</summary>
    [JsonPropertyName("licenseInfo")]
    public string? LicenseInfo { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>S3 bucket location containing the function's deployment package. Conflicts with filename. This bucket must reside in the same AWS region where you are creating the Lambda function.</summary>
    [JsonPropertyName("s3Bucket")]
    public string? S3Bucket { get; set; }

    /// <summary>S3 key of an object containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3Key")]
    public string? S3Key { get; set; }

    /// <summary>Object version containing the function's deployment package. Conflicts with filename.</summary>
    [JsonPropertyName("s3ObjectVersion")]
    public string? S3ObjectVersion { get; set; }

    /// <summary>ARN of a signing job.</summary>
    [JsonPropertyName("signingJobArn")]
    public string? SigningJobArn { get; set; }

    /// <summary>ARN for a signing profile version.</summary>
    [JsonPropertyName("signingProfileVersionArn")]
    public string? SigningProfileVersionArn { get; set; }

    /// <summary>Whether to retain the old version of a previously deployed Lambda Layer. Default is false. When this is not set to true, changing any of compatible_architectures, compatible_runtimes, description, filename, layer_name, license_info, s3_bucket, s3_key, s3_object_version, or source_code_hash forces deletion of the existing layer version and creation of a new layer version.</summary>
    [JsonPropertyName("skipDestroy")]
    public bool? SkipDestroy { get; set; }

    /// <summary>Virtual attribute used to trigger replacement when source code changes. Must be set to a base64-encoded SHA256 hash of the package file specified with either filename or s3_key. The usual way to set this is filebase64sha256("file.11.12 or later) or base64sha256(file("file.11.11 and earlier), where "file.zip" is the local filename of the lambda layer source archive.</summary>
    [JsonPropertyName("sourceCodeHash")]
    public string? SourceCodeHash { get; set; }

    /// <summary>Size in bytes of the function .zip file.</summary>
    [JsonPropertyName("sourceCodeSize")]
    public double? SourceCodeSize { get; set; }

    /// <summary>Lambda Layer version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionStatusConditions
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
/// <summary>LayerVersionStatus defines the observed state of LayerVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LayerVersionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LayerVersionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LayerVersionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>LayerVersion is the Schema for the LayerVersions API. Manages an AWS Lambda Layer Version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LayerVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LayerVersionSpec>, IStatus<V1beta1LayerVersionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LayerVersion";
    public const string KubeGroup = "lambda.aws.m.upbound.io";
    public const string KubePluralName = "layerversions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LayerVersionSpec defines the desired state of LayerVersion</summary>
    [JsonPropertyName("spec")]
    public V1beta1LayerVersionSpec Spec { get; set; }

    /// <summary>LayerVersionStatus defines the observed state of LayerVersion.</summary>
    [JsonPropertyName("status")]
    public V1beta1LayerVersionStatus? Status { get; set; }
}
#nullable disable
