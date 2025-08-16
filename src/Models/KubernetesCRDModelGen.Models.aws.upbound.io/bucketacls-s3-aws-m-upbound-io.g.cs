using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.m.upbound.io;
/// <summary>BucketACL is the Schema for the BucketACLs API. Provides an S3 bucket ACL resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BucketACLList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BucketACL>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketACLList";
    public const string KubeGroup = "s3.aws.m.upbound.io";
    public const string KubePluralName = "bucketacls";
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
    public IList<V1beta1BucketACL> Items { get; set; }
}

/// <summary>Configuration block for the person being granted permissions. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecForProviderAccessControlPolicyGrantGrantee
{
    /// <summary>Email address of the grantee. See Regions and Endpoints for supported AWS regions where this argument can be specified.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>ID of the owner.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of grantee. Valid values: CanonicalUser, AmazonCustomerByEmail, Group.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the grantee group.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecForProviderAccessControlPolicyGrant
{
    /// <summary>Configuration block for the person being granted permissions. See below.</summary>
    [JsonPropertyName("grantee")]
    public V1beta1BucketACLSpecForProviderAccessControlPolicyGrantGrantee? Grantee { get; set; }

    /// <summary>Logging permissions assigned to the grantee for the bucket. Valid values: FULL_CONTROL, WRITE, WRITE_ACP, READ, READ_ACP. See What permissions can I grant? for more details about what each permission means in the context of buckets.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>Configuration block for the bucket owner's display name and ID. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecForProviderAccessControlPolicyOwner
{
    /// <summary>Display name of the owner.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>ID of the owner.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Configuration block that sets the ACL permissions for an object per grantee. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecForProviderAccessControlPolicy
{
    /// <summary>Set of grant configuration blocks. See below.</summary>
    [JsonPropertyName("grant")]
    public IList<V1beta1BucketACLSpecForProviderAccessControlPolicyGrant>? Grant { get; set; }

    /// <summary>Configuration block for the bucket owner's display name and ID. See below.</summary>
    [JsonPropertyName("owner")]
    public V1beta1BucketACLSpecForProviderAccessControlPolicyOwner? Owner { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecForProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketACLSpecForProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecForProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecForProviderBucketSelector
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
    public V1beta1BucketACLSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecForProvider
{
    /// <summary>Configuration block that sets the ACL permissions for an object per grantee. See below.</summary>
    [JsonPropertyName("accessControlPolicy")]
    public V1beta1BucketACLSpecForProviderAccessControlPolicy? AccessControlPolicy { get; set; }

    /// <summary>Specifies the Canned ACL to apply to the bucket. Valid values: private, public-read, public-read-write, aws-exec-read, authenticated-read, bucket-owner-read, bucket-owner-full-control, log-delivery-write. Full details are available on the AWS documentation.</summary>
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    /// <summary>Bucket to which to apply the ACL.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketACLSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketACLSpecForProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

/// <summary>Configuration block for the person being granted permissions. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecInitProviderAccessControlPolicyGrantGrantee
{
    /// <summary>Email address of the grantee. See Regions and Endpoints for supported AWS regions where this argument can be specified.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>ID of the owner.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of grantee. Valid values: CanonicalUser, AmazonCustomerByEmail, Group.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the grantee group.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecInitProviderAccessControlPolicyGrant
{
    /// <summary>Configuration block for the person being granted permissions. See below.</summary>
    [JsonPropertyName("grantee")]
    public V1beta1BucketACLSpecInitProviderAccessControlPolicyGrantGrantee? Grantee { get; set; }

    /// <summary>Logging permissions assigned to the grantee for the bucket. Valid values: FULL_CONTROL, WRITE, WRITE_ACP, READ, READ_ACP. See What permissions can I grant? for more details about what each permission means in the context of buckets.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>Configuration block for the bucket owner's display name and ID. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecInitProviderAccessControlPolicyOwner
{
    /// <summary>Display name of the owner.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>ID of the owner.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Configuration block that sets the ACL permissions for an object per grantee. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecInitProviderAccessControlPolicy
{
    /// <summary>Set of grant configuration blocks. See below.</summary>
    [JsonPropertyName("grant")]
    public IList<V1beta1BucketACLSpecInitProviderAccessControlPolicyGrant>? Grant { get; set; }

    /// <summary>Configuration block for the bucket owner's display name and ID. See below.</summary>
    [JsonPropertyName("owner")]
    public V1beta1BucketACLSpecInitProviderAccessControlPolicyOwner? Owner { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecInitProviderBucketRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BucketACLSpecInitProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecInitProviderBucketSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecInitProviderBucketSelector
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
    public V1beta1BucketACLSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecInitProvider
{
    /// <summary>Configuration block that sets the ACL permissions for an object per grantee. See below.</summary>
    [JsonPropertyName("accessControlPolicy")]
    public V1beta1BucketACLSpecInitProviderAccessControlPolicy? AccessControlPolicy { get; set; }

    /// <summary>Specifies the Canned ACL to apply to the bucket. Valid values: private, public-read, public-read-write, aws-exec-read, authenticated-read, bucket-owner-read, bucket-owner-full-control, log-delivery-write. Full details are available on the AWS documentation.</summary>
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    /// <summary>Bucket to which to apply the ACL.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1BucketACLSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta1BucketACLSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>BucketACLSpec defines the desired state of BucketACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BucketACLSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BucketACLSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BucketACLSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BucketACLSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block for the person being granted permissions. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLStatusAtProviderAccessControlPolicyGrantGrantee
{
    /// <summary>Display name of the owner.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Email address of the grantee. See Regions and Endpoints for supported AWS regions where this argument can be specified.</summary>
    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    /// <summary>ID of the owner.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of grantee. Valid values: CanonicalUser, AmazonCustomerByEmail, Group.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>URI of the grantee group.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLStatusAtProviderAccessControlPolicyGrant
{
    /// <summary>Configuration block for the person being granted permissions. See below.</summary>
    [JsonPropertyName("grantee")]
    public V1beta1BucketACLStatusAtProviderAccessControlPolicyGrantGrantee? Grantee { get; set; }

    /// <summary>Logging permissions assigned to the grantee for the bucket. Valid values: FULL_CONTROL, WRITE, WRITE_ACP, READ, READ_ACP. See What permissions can I grant? for more details about what each permission means in the context of buckets.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>Configuration block for the bucket owner's display name and ID. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLStatusAtProviderAccessControlPolicyOwner
{
    /// <summary>Display name of the owner.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>ID of the owner.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Configuration block that sets the ACL permissions for an object per grantee. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLStatusAtProviderAccessControlPolicy
{
    /// <summary>Set of grant configuration blocks. See below.</summary>
    [JsonPropertyName("grant")]
    public IList<V1beta1BucketACLStatusAtProviderAccessControlPolicyGrant>? Grant { get; set; }

    /// <summary>Configuration block for the bucket owner's display name and ID. See below.</summary>
    [JsonPropertyName("owner")]
    public V1beta1BucketACLStatusAtProviderAccessControlPolicyOwner? Owner { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLStatusAtProvider
{
    /// <summary>Configuration block that sets the ACL permissions for an object per grantee. See below.</summary>
    [JsonPropertyName("accessControlPolicy")]
    public V1beta1BucketACLStatusAtProviderAccessControlPolicy? AccessControlPolicy { get; set; }

    /// <summary>Specifies the Canned ACL to apply to the bucket. Valid values: private, public-read, public-read-write, aws-exec-read, authenticated-read, bucket-owner-read, bucket-owner-full-control, log-delivery-write. Full details are available on the AWS documentation.</summary>
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    /// <summary>Bucket to which to apply the ACL.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>The bucket, expected_bucket_owner (if configured), and acl (if configured) separated by commas (,).</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLStatusConditions
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

/// <summary>BucketACLStatus defines the observed state of BucketACL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BucketACLStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BucketACLStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BucketACLStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BucketACL is the Schema for the BucketACLs API. Provides an S3 bucket ACL resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BucketACL : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BucketACLSpec>, IStatus<V1beta1BucketACLStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BucketACL";
    public const string KubeGroup = "s3.aws.m.upbound.io";
    public const string KubePluralName = "bucketacls";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketACLSpec defines the desired state of BucketACL</summary>
    [JsonPropertyName("spec")]
    public V1beta1BucketACLSpec Spec { get; set; }

    /// <summary>BucketACLStatus defines the observed state of BucketACL.</summary>
    [JsonPropertyName("status")]
    public V1beta1BucketACLStatus? Status { get; set; }
}