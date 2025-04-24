using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kustomize.toolkit.fluxcd.io;
/// <summary>CommonMetadata specifies the common labels and annotations that are applied to all resources. Any existing label or annotation will be overridden if its key matches a common one.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecCommonMetadata
{
    /// <summary>Annotations to be added to the object's metadata.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels to be added to the object's metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>The secret name containing the private OpenPGP keys used for decryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecDecryptionSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Decrypt Kubernetes secrets before applying them on the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecDecryption
{
    /// <summary>Provider is the name of the decryption engine.</summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }

    /// <summary>The secret name containing the private OpenPGP keys used for decryption.</summary>
    [JsonPropertyName("secretRef")]
    public V1KustomizationSpecDecryptionSecretRef? SecretRef { get; set; }
}

/// <summary>NamespacedObjectReference contains enough information to locate the referenced Kubernetes resource object in any namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecDependsOn
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referent, when not specified it acts as LocalObjectReference.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>CustomHealthCheck defines the health check for custom resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecHealthCheckExprs
{
    /// <summary>APIVersion of the custom resource under evaluation.</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>Current is the CEL expression that determines if the status of the custom resource has reached the desired state.</summary>
    [JsonPropertyName("current")]
    public string Current { get; set; }

    /// <summary>Failed is the CEL expression that determines if the status of the custom resource has failed to reach the desired state.</summary>
    [JsonPropertyName("failed")]
    public string? Failed { get; set; }

    /// <summary>InProgress is the CEL expression that determines if the status of the custom resource has not yet reached the desired state.</summary>
    [JsonPropertyName("inProgress")]
    public string? InProgress { get; set; }

    /// <summary>Kind of the custom resource under evaluation.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }
}

/// <summary>NamespacedObjectKindReference contains enough information to locate the typed referenced Kubernetes resource object in any namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecHealthChecks
{
    /// <summary>API version of the referent, if not specified the Kubernetes preferred version will be used.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referent, when not specified it acts as LocalObjectReference.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Image contains an image name, a new name, a new tag or digest, which will replace the original name and tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecImages
{
    /// <summary>Digest is the value used to replace the original image tag. If digest is present NewTag value is ignored.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>Name is a tag-less image name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>NewName is the value used to replace the original name.</summary>
    [JsonPropertyName("newName")]
    public string? NewName { get; set; }

    /// <summary>NewTag is the value used to replace the original tag.</summary>
    [JsonPropertyName("newTag")]
    public string? NewTag { get; set; }
}

/// <summary>SecretRef holds the name of a secret that contains a key with the kubeconfig file as the value. If no key is set, the key will default to 'value'. It is recommended that the kubeconfig is self-contained, and the secret is regularly updated if credentials such as a cloud-access-token expire. Cloud specific `cmd-path` auth helpers will not function without adding binaries and credentials to the Pod that is responsible for reconciling Kubernetes resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecKubeConfigSecretRef
{
    /// <summary>Key in the Secret, when not specified an implementation-specific default key is used.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the Secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The KubeConfig for reconciling the Kustomization on a remote cluster. When used in combination with KustomizationSpec.ServiceAccountName, forces the controller to act on behalf of that Service Account at the target cluster. If the --default-service-account flag is set, its value will be used as a controller level fallback for when KustomizationSpec.ServiceAccountName is empty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecKubeConfig
{
    /// <summary>SecretRef holds the name of a secret that contains a key with the kubeconfig file as the value. If no key is set, the key will default to 'value'. It is recommended that the kubeconfig is self-contained, and the secret is regularly updated if credentials such as a cloud-access-token expire. Cloud specific `cmd-path` auth helpers will not function without adding binaries and credentials to the Pod that is responsible for reconciling Kubernetes resources.</summary>
    [JsonPropertyName("secretRef")]
    public V1KustomizationSpecKubeConfigSecretRef SecretRef { get; set; }
}

/// <summary>Target points to the resources that the patch document should be applied to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecPatchesTarget
{
    /// <summary>AnnotationSelector is a string that follows the label selection expression https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#api It matches with the resource annotations.</summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary>Group is the API group to select resources from. Together with Version and Kind it is capable of unambiguously identifying and/or selecting resources. https://github.com/kubernetes/community/blob/master/contributors/design-proposals/api-machinery/api-group.md</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind of the API Group to select resources from. Together with Group and Version it is capable of unambiguously identifying and/or selecting resources. https://github.com/kubernetes/community/blob/master/contributors/design-proposals/api-machinery/api-group.md</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>LabelSelector is a string that follows the label selection expression https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#api It matches with the resource labels.</summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary>Name to match resources with.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace to select resources from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Version of the API Group to select resources from. Together with Group and Kind it is capable of unambiguously identifying and/or selecting resources. https://github.com/kubernetes/community/blob/master/contributors/design-proposals/api-machinery/api-group.md</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Patch contains an inline StrategicMerge or JSON6902 patch, and the target the patch should be applied to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecPatches
{
    /// <summary>Patch contains an inline StrategicMerge patch or an inline JSON6902 patch with an array of operation objects.</summary>
    [JsonPropertyName("patch")]
    public string Patch { get; set; }

    /// <summary>Target points to the resources that the patch document should be applied to.</summary>
    [JsonPropertyName("target")]
    public V1KustomizationSpecPatchesTarget? Target { get; set; }
}

/// <summary>SubstituteReference contains a reference to a resource containing the variables name and value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecPostBuildSubstituteFrom
{
    /// <summary>Kind of the values referent, valid values are ('Secret', 'ConfigMap').</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the values referent. Should reside in the same namespace as the referring resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Optional indicates whether the referenced resource must exist, or whether to tolerate its absence. If true and the referenced resource is absent, proceed as if the resource was present but empty, without any variables defined.</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>PostBuild describes which actions to perform on the YAML manifest generated by building the kustomize overlay.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecPostBuild
{
    /// <summary>Substitute holds a map of key/value pairs. The variables defined in your YAML manifests that match any of the keys defined in the map will be substituted with the set value. Includes support for bash string replacement functions e.g. ${var:=default}, ${var:position} and ${var/substring/replacement}.</summary>
    [JsonPropertyName("substitute")]
    public IDictionary<string, string>? Substitute { get; set; }

    /// <summary>SubstituteFrom holds references to ConfigMaps and Secrets containing the variables and their values to be substituted in the YAML manifests. The ConfigMap and the Secret data keys represent the var names, and they must match the vars declared in the manifests for the substitution to happen.</summary>
    [JsonPropertyName("substituteFrom")]
    public IList<V1KustomizationSpecPostBuildSubstituteFrom>? SubstituteFrom { get; set; }
}

/// <summary>Reference of the source where the kustomization file is.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecSourceRef
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referent, defaults to the namespace of the Kubernetes resource object that contains the reference.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>KustomizationSpec defines the configuration to calculate the desired state from a Source using Kustomize.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpec
{
    /// <summary>CommonMetadata specifies the common labels and annotations that are applied to all resources. Any existing label or annotation will be overridden if its key matches a common one.</summary>
    [JsonPropertyName("commonMetadata")]
    public V1KustomizationSpecCommonMetadata? CommonMetadata { get; set; }

    /// <summary>Components specifies relative paths to specifications of other Components.</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>Decrypt Kubernetes secrets before applying them on the cluster.</summary>
    [JsonPropertyName("decryption")]
    public V1KustomizationSpecDecryption? Decryption { get; set; }

    /// <summary>DeletionPolicy can be used to control garbage collection when this Kustomization is deleted. Valid values are ('MirrorPrune', 'Delete', 'Orphan'). 'MirrorPrune' mirrors the Prune field (orphan if false, delete if true). Defaults to 'MirrorPrune'.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>DependsOn may contain a meta.NamespacedObjectReference slice with references to Kustomization resources that must be ready before this Kustomization can be reconciled.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1KustomizationSpecDependsOn>? DependsOn { get; set; }

    /// <summary>Force instructs the controller to recreate resources when patching fails due to an immutable field change.</summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary>HealthCheckExprs is a list of healthcheck expressions for evaluating the health of custom resources using Common Expression Language (CEL). The expressions are evaluated only when Wait or HealthChecks are specified.</summary>
    [JsonPropertyName("healthCheckExprs")]
    public IList<V1KustomizationSpecHealthCheckExprs>? HealthCheckExprs { get; set; }

    /// <summary>A list of resources to be included in the health assessment.</summary>
    [JsonPropertyName("healthChecks")]
    public IList<V1KustomizationSpecHealthChecks>? HealthChecks { get; set; }

    /// <summary>Images is a list of (image name, new name, new tag or digest) for changing image names, tags or digests. This can also be achieved with a patch, but this operator is simpler to specify.</summary>
    [JsonPropertyName("images")]
    public IList<V1KustomizationSpecImages>? Images { get; set; }

    /// <summary>The interval at which to reconcile the Kustomization. This interval is approximate and may be subject to jitter to ensure efficient use of resources.</summary>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }

    /// <summary>The KubeConfig for reconciling the Kustomization on a remote cluster. When used in combination with KustomizationSpec.ServiceAccountName, forces the controller to act on behalf of that Service Account at the target cluster. If the --default-service-account flag is set, its value will be used as a controller level fallback for when KustomizationSpec.ServiceAccountName is empty.</summary>
    [JsonPropertyName("kubeConfig")]
    public V1KustomizationSpecKubeConfig? KubeConfig { get; set; }

    /// <summary>NamePrefix will prefix the names of all managed resources.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix will suffix the names of all managed resources.</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>Strategic merge and JSON patches, defined as inline YAML objects, capable of targeting objects based on kind, label and annotation selectors.</summary>
    [JsonPropertyName("patches")]
    public IList<V1KustomizationSpecPatches>? Patches { get; set; }

    /// <summary>Path to the directory containing the kustomization.yaml file, or the set of plain YAMLs a kustomization.yaml should be generated for. Defaults to 'None', which translates to the root path of the SourceRef.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>PostBuild describes which actions to perform on the YAML manifest generated by building the kustomize overlay.</summary>
    [JsonPropertyName("postBuild")]
    public V1KustomizationSpecPostBuild? PostBuild { get; set; }

    /// <summary>Prune enables garbage collection.</summary>
    [JsonPropertyName("prune")]
    public bool Prune { get; set; }

    /// <summary>The interval at which to retry a previously failed reconciliation. When not specified, the controller uses the KustomizationSpec.Interval value to retry failures.</summary>
    [JsonPropertyName("retryInterval")]
    public string? RetryInterval { get; set; }

    /// <summary>The name of the Kubernetes service account to impersonate when reconciling this Kustomization.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>Reference of the source where the kustomization file is.</summary>
    [JsonPropertyName("sourceRef")]
    public V1KustomizationSpecSourceRef SourceRef { get; set; }

    /// <summary>This flag tells the controller to suspend subsequent kustomize executions, it does not apply to already started executions. Defaults to false.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>TargetNamespace sets or overrides the namespace in the kustomization.yaml file.</summary>
    [JsonPropertyName("targetNamespace")]
    public string? TargetNamespace { get; set; }

    /// <summary>Timeout for validation, apply and health checking operations. Defaults to 'Interval' duration.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Wait instructs the controller to check the health of all the reconciled resources. When enabled, the HealthChecks are ignored. Defaults to false.</summary>
    [JsonPropertyName("wait")]
    public bool? Wait { get; set; }
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationStatusConditions
{
    /// <summary>lastTransitionTime is the last time the condition transitioned from one status to another. This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>message is a human readable message indicating details about the transition. This may be an empty string.</summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>observedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>reason contains a programmatic identifier indicating the reason for the condition's last transition. Producers of specific condition types may define expected values and meanings for this field, and whether the values are considered a guaranteed API. The value should be a CamelCase string. This field may not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>ResourceRef contains the information necessary to locate a resource within a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationStatusInventoryEntries
{
    /// <summary>ID is the string representation of the Kubernetes resource object's metadata, in the format '&lt;namespace&gt;_&lt;name&gt;_&lt;group&gt;_&lt;kind&gt;'.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Version is the API version of the Kubernetes resource object's kind.</summary>
    [JsonPropertyName("v")]
    public string V { get; set; }
}

/// <summary>Inventory contains the list of Kubernetes resource object references that have been successfully applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationStatusInventory
{
    /// <summary>Entries of Kubernetes resource object references.</summary>
    [JsonPropertyName("entries")]
    public IList<V1KustomizationStatusInventoryEntries> Entries { get; set; }
}

/// <summary>KustomizationStatus defines the observed state of a kustomization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationStatus
{
    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1KustomizationStatusConditions>? Conditions { get; set; }

    /// <summary>Inventory contains the list of Kubernetes resource object references that have been successfully applied.</summary>
    [JsonPropertyName("inventory")]
    public V1KustomizationStatusInventory? Inventory { get; set; }

    /// <summary>The last successfully applied origin revision. Equals the origin revision of the applied Artifact from the referenced Source. Usually present on the Metadata of the applied Artifact and depends on the Source type, e.g. for OCI it's the value associated with the key "org.opencontainers.image.revision".</summary>
    [JsonPropertyName("lastAppliedOriginRevision")]
    public string? LastAppliedOriginRevision { get; set; }

    /// <summary>The last successfully applied revision. Equals the Revision of the applied Artifact from the referenced Source.</summary>
    [JsonPropertyName("lastAppliedRevision")]
    public string? LastAppliedRevision { get; set; }

    /// <summary>LastAttemptedRevision is the revision of the last reconciliation attempt.</summary>
    [JsonPropertyName("lastAttemptedRevision")]
    public string? LastAttemptedRevision { get; set; }

    /// <summary>LastHandledReconcileAt holds the value of the most recent reconcile request value, so a change of the annotation value can be detected.</summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>ObservedGeneration is the last reconciled generation.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Kustomization is the Schema for the kustomizations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Kustomization : IKubernetesObject<V1ObjectMeta>, ISpec<V1KustomizationSpec>, IStatus<V1KustomizationStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Kustomization";
    public const string KubeGroup = "kustomize.toolkit.fluxcd.io";
    public const string KubePluralName = "kustomizations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KustomizationSpec defines the configuration to calculate the desired state from a Source using Kustomize.</summary>
    [JsonPropertyName("spec")]
    public V1KustomizationSpec? Spec { get; set; }

    /// <summary>KustomizationStatus defines the observed state of a kustomization.</summary>
    [JsonPropertyName("status")]
    public V1KustomizationStatus? Status { get; set; }
}

/// <summary>Kustomization is the Schema for the kustomizations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KustomizationList : IKubernetesObject<V1ListMeta>, IItems<V1Kustomization>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KustomizationList";
    public const string KubeGroup = "kustomize.toolkit.fluxcd.io";
    public const string KubePluralName = "kustomizations";
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
    public IList<V1Kustomization> Items { get; set; }
}