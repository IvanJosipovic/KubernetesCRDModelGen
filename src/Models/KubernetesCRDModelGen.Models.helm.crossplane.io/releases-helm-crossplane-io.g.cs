using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.helm.crossplane.io;
/// <summary>ConnectionDetail todo</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecConnectionDetails
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object. TODO: this design is not final and this field is subject to change in the future.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency</summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>SkipPartOfReleaseCheck skips check for meta.helm.sh/release-name annotation.</summary>
    [JsonPropertyName("skipPartOfReleaseCheck")]
    public bool? SkipPartOfReleaseCheck { get; set; }

    /// <summary></summary>
    [JsonPropertyName("toConnectionSecretKey")]
    public string? ToConnectionSecretKey { get; set; }

    /// <summary>UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>PullSecretRef is reference to the secret containing credentials to helm repository</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderChartPullSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>A ChartSpec defines the chart spec for a Release</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderChart
{
    /// <summary>Name of Helm chart, required if ChartSpec.URL not set</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PullSecretRef is reference to the secret containing credentials to helm repository</summary>
    [JsonPropertyName("pullSecretRef")]
    public V1beta1ReleaseSpecForProviderChartPullSecretRef? PullSecretRef { get; set; }

    /// <summary>Repository: Helm repository URL, required if ChartSpec.URL not set</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>URL to chart package (typically .tgz), optional and overrides others fields in the spec</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Version of Helm chart, late initialized with latest version if not set</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderPatchesFromConfigMapKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderPatchesFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ValueFromSource represents source of a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderPatchesFrom
{
    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1beta1ReleaseSpecForProviderPatchesFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ReleaseSpecForProviderPatchesFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderSetValueFromConfigMapKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderSetValueFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ValueFromSource represents source of a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderSetValueFrom
{
    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1beta1ReleaseSpecForProviderSetValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ReleaseSpecForProviderSetValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>SetVal represents a "set" value override in a Release</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderSet
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFromSource represents source of a value</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ReleaseSpecForProviderSetValueFrom? ValueFrom { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderValuesFromConfigMapKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderValuesFromSecretKeyRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ValueFromSource represents source of a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderValuesFrom
{
    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1beta1ReleaseSpecForProviderValuesFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ReleaseSpecForProviderValuesFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>ReleaseParameters are the configurable fields of a Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProvider
{
    /// <summary>A ChartSpec defines the chart spec for a Release</summary>
    [JsonPropertyName("chart")]
    public V1beta1ReleaseSpecForProviderChart Chart { get; set; }

    /// <summary>InsecureSkipTLSVerify skips tls certificate checks for the chart download</summary>
    [JsonPropertyName("insecureSkipTLSVerify")]
    public bool? InsecureSkipTLSVerify { get; set; }

    /// <summary>Namespace to install the release into.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>PatchesFrom describe patches to be applied to the rendered manifests.</summary>
    [JsonPropertyName("patchesFrom")]
    public IList<V1beta1ReleaseSpecForProviderPatchesFrom>? PatchesFrom { get; set; }

    /// <summary></summary>
    [JsonPropertyName("set")]
    public IList<V1beta1ReleaseSpecForProviderSet>? Set { get; set; }

    /// <summary>SkipCRDs skips installation of CRDs for the release.</summary>
    [JsonPropertyName("skipCRDs")]
    public bool? SkipCRDs { get; set; }

    /// <summary>SkipCreateNamespace won't create the namespace for the release. This requires the namespace to already exist.</summary>
    [JsonPropertyName("skipCreateNamespace")]
    public bool? SkipCreateNamespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public JsonNode? Values { get; set; }

    /// <summary></summary>
    [JsonPropertyName("valuesFrom")]
    public IList<V1beta1ReleaseSpecForProviderValuesFrom>? ValuesFrom { get; set; }

    /// <summary>Wait for the release to become ready.</summary>
    [JsonPropertyName("wait")]
    public bool? Wait { get; set; }

    /// <summary>WaitTimeout is the duration Helm will wait for the release to become ready. Only applies if wait is also set. Defaults to 5m.</summary>
    [JsonPropertyName("waitTimeout")]
    public string? WaitTimeout { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecProviderConfigRefPolicy
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
public partial class V1beta1ReleaseSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReleaseSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ReleaseSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ReleaseSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ReleaseSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ReleaseSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ReleaseSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>A ReleaseSpec defines the desired state of a Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpec
{
    /// <summary></summary>
    [JsonPropertyName("connectionDetails")]
    public IList<V1beta1ReleaseSpecConnectionDetails>? ConnectionDetails { get; set; }

    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>ReleaseParameters are the configurable fields of a Release.</summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ReleaseSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReleaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ReleaseSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>RollbackRetriesLimit is max number of attempts to retry Helm deployment by rolling back the release.</summary>
    [JsonPropertyName("rollbackLimit")]
    public int? RollbackLimit { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ReleaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>ReleaseObservation are the observable fields of a Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseStatusAtProvider
{
    /// <summary></summary>
    [JsonPropertyName("releaseDescription")]
    public string? ReleaseDescription { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>Status is the status of a release</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseStatusConditions
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

/// <summary>A ReleaseStatus represents the observed state of a Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseStatus
{
    /// <summary>ReleaseObservation are the observable fields of a Release.</summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ReleaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReleaseStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failed")]
    public int? Failed { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patchesSha")]
    public string? PatchesSha { get; set; }

    /// <summary></summary>
    [JsonPropertyName("synced")]
    public bool? Synced { get; set; }
}

/// <summary>A Release is an example API type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Release : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReleaseSpec>, IStatus<V1beta1ReleaseStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Release";
    public const string KubeGroup = "helm.crossplane.io";
    public const string KubePluralName = "releases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A ReleaseSpec defines the desired state of a Release.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ReleaseSpec Spec { get; set; }

    /// <summary>A ReleaseStatus represents the observed state of a Release.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReleaseStatus? Status { get; set; }
}