using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.helm.toolkit.fluxcd.io;
/// <summary>ObjectMeta holds the template for metadata like labels and annotations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartMetadata
{
    /// <summary>Annotations is an unstructured key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying objects. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations/</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseSpecChartSpecReconcileStrategyEnum
{
    [EnumMember(Value = "ChartVersion"), JsonStringEnumMemberName("ChartVersion")]
    /// <summary>ChartVersion</summary>
    ChartVersion,
    [EnumMember(Value = "Revision"), JsonStringEnumMemberName("Revision")]
    /// <summary>Revision</summary>
    Revision
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseSpecChartSpecSourceRefKindEnum
{
    [EnumMember(Value = "HelmRepository"), JsonStringEnumMemberName("HelmRepository")]
    /// <summary>HelmRepository</summary>
    HelmRepository,
    [EnumMember(Value = "GitRepository"), JsonStringEnumMemberName("GitRepository")]
    /// <summary>GitRepository</summary>
    GitRepository,
    [EnumMember(Value = "Bucket"), JsonStringEnumMemberName("Bucket")]
    /// <summary>Bucket</summary>
    Bucket
}

/// <summary>The name and namespace of the v1.Source the chart is available at.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartSpecSourceRef
{
    /// <summary>APIVersion of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecChartSpecSourceRefKindEnum>))]
    public V2HelmReleaseSpecChartSpecSourceRefKindEnum? Kind { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseSpecChartSpecVerifyProviderEnum
{
    [EnumMember(Value = "cosign"), JsonStringEnumMemberName("cosign")]
    /// <summary>cosign</summary>
    Cosign,
    [EnumMember(Value = "notation"), JsonStringEnumMemberName("notation")]
    /// <summary>notation</summary>
    Notation
}

/// <summary>SecretRef specifies the Kubernetes Secret containing the trusted public keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartSpecVerifySecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Verify contains the secret name containing the trusted public keys used to verify the signature and specifies which provider to use to check whether OCI image is authentic. This field is only supported for OCI sources. Chart dependencies, which are not bundled in the umbrella chart artifact, are not verified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartSpecVerify
{
    /// <summary>Provider specifies the technology used to sign the OCI Helm chart.</summary>
    [JsonPropertyName("provider")]
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecChartSpecVerifyProviderEnum>))]
    public V2HelmReleaseSpecChartSpecVerifyProviderEnum Provider { get; set; }

    /// <summary>SecretRef specifies the Kubernetes Secret containing the trusted public keys.</summary>
    [JsonPropertyName("secretRef")]
    public V2HelmReleaseSpecChartSpecVerifySecretRef? SecretRef { get; set; }
}

/// <summary>Spec holds the template for the v1.HelmChartSpec for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartSpec
{
    /// <summary>The name or path the Helm chart is available at in the SourceRef.</summary>
    [JsonPropertyName("chart")]
    public string Chart { get; set; }

    /// <summary>IgnoreMissingValuesFiles controls whether to silently ignore missing values files rather than failing.</summary>
    [JsonPropertyName("ignoreMissingValuesFiles")]
    public bool? IgnoreMissingValuesFiles { get; set; }

    /// <summary>Interval at which to check the v1.Source for updates. Defaults to 'HelmReleaseSpec.Interval'.</summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>Determines what enables the creation of a new artifact. Valid values are ('ChartVersion', 'Revision'). See the documentation of the values for an explanation on their behavior. Defaults to ChartVersion when omitted.</summary>
    [JsonPropertyName("reconcileStrategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecChartSpecReconcileStrategyEnum>))]
    public V2HelmReleaseSpecChartSpecReconcileStrategyEnum? ReconcileStrategy { get; set; }

    /// <summary>The name and namespace of the v1.Source the chart is available at.</summary>
    [JsonPropertyName("sourceRef")]
    public V2HelmReleaseSpecChartSpecSourceRef SourceRef { get; set; }

    /// <summary>Alternative list of values files to use as the chart values (values.yaml is not included by default), expected to be a relative path in the SourceRef. Values files are merged in the order of this list with the last file overriding the first. Ignored when omitted.</summary>
    [JsonPropertyName("valuesFiles")]
    public IList<string>? ValuesFiles { get; set; }

    /// <summary>Verify contains the secret name containing the trusted public keys used to verify the signature and specifies which provider to use to check whether OCI image is authentic. This field is only supported for OCI sources. Chart dependencies, which are not bundled in the umbrella chart artifact, are not verified.</summary>
    [JsonPropertyName("verify")]
    public V2HelmReleaseSpecChartSpecVerify? Verify { get; set; }

    /// <summary>Version semver expression, ignored for charts from v1.GitRepository and v1beta2.Bucket sources. Defaults to latest when omitted.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Chart defines the template of the v1.HelmChart that should be created for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChart
{
    /// <summary>ObjectMeta holds the template for metadata like labels and annotations.</summary>
    [JsonPropertyName("metadata")]
    public V2HelmReleaseSpecChartMetadata? Metadata { get; set; }

    /// <summary>Spec holds the template for the v1.HelmChartSpec for this HelmRelease.</summary>
    [JsonPropertyName("spec")]
    public V2HelmReleaseSpecChartSpec Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseSpecChartRefKindEnum
{
    [EnumMember(Value = "OCIRepository"), JsonStringEnumMemberName("OCIRepository")]
    /// <summary>OCIRepository</summary>
    OCIRepository,
    [EnumMember(Value = "HelmChart"), JsonStringEnumMemberName("HelmChart")]
    /// <summary>HelmChart</summary>
    HelmChart
}

/// <summary>ChartRef holds a reference to a source controller resource containing the Helm chart artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartRef
{
    /// <summary>APIVersion of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecChartRefKindEnum>))]
    public V2HelmReleaseSpecChartRefKindEnum Kind { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referent, defaults to the namespace of the Kubernetes resource object that contains the reference.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>NamespacedObjectReference contains enough information to locate the referenced Kubernetes resource object in any namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecDependsOn
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referent, when not specified it acts as LocalObjectReference.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Target is a selector for specifying Kubernetes objects to which this rule applies. If Target is not set, the Paths will be ignored for all Kubernetes objects within the manifest of the Helm release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecDriftDetectionIgnoreTarget
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

/// <summary>IgnoreRule defines a rule to selectively disregard specific changes during the drift detection process.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecDriftDetectionIgnore
{
    /// <summary>Paths is a list of JSON Pointer (RFC 6901) paths to be excluded from consideration in a Kubernetes object.</summary>
    [JsonPropertyName("paths")]
    public IList<string> Paths { get; set; }

    /// <summary>Target is a selector for specifying Kubernetes objects to which this rule applies. If Target is not set, the Paths will be ignored for all Kubernetes objects within the manifest of the Helm release.</summary>
    [JsonPropertyName("target")]
    public V2HelmReleaseSpecDriftDetectionIgnoreTarget? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseSpecDriftDetectionModeEnum
{
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    /// <summary>enabled</summary>
    Enabled,
    [EnumMember(Value = "warn"), JsonStringEnumMemberName("warn")]
    /// <summary>warn</summary>
    Warn,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    /// <summary>disabled</summary>
    Disabled
}

/// <summary>DriftDetection holds the configuration for detecting and handling differences between the manifest in the Helm storage and the resources currently existing in the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecDriftDetection
{
    /// <summary>Ignore contains a list of rules for specifying which changes to ignore during diffing.</summary>
    [JsonPropertyName("ignore")]
    public IList<V2HelmReleaseSpecDriftDetectionIgnore>? Ignore { get; set; }

    /// <summary>Mode defines how differences should be handled between the Helm manifest and the manifest currently applied to the cluster. If not explicitly set, it defaults to DiffModeDisabled.</summary>
    [JsonPropertyName("mode")]
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecDriftDetectionModeEnum>))]
    public V2HelmReleaseSpecDriftDetectionModeEnum? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseSpecInstallCrdsEnum
{
    [EnumMember(Value = "Skip"), JsonStringEnumMemberName("Skip")]
    /// <summary>Skip</summary>
    Skip,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "CreateReplace"), JsonStringEnumMemberName("CreateReplace")]
    /// <summary>CreateReplace</summary>
    CreateReplace
}

/// <summary>Remediation holds the remediation configuration for when the Helm install action for the HelmRelease fails. The default is to not perform any action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecInstallRemediation
{
    /// <summary>IgnoreTestFailures tells the controller to skip remediation when the Helm tests are run after an install action but fail. Defaults to 'Test.IgnoreFailures'.</summary>
    [JsonPropertyName("ignoreTestFailures")]
    public bool? IgnoreTestFailures { get; set; }

    /// <summary>RemediateLastFailure tells the controller to remediate the last failure, when no retries remain. Defaults to 'false'.</summary>
    [JsonPropertyName("remediateLastFailure")]
    public bool? RemediateLastFailure { get; set; }

    /// <summary>Retries is the number of retries that should be attempted on failures before bailing. Remediation, using an uninstall, is performed between each attempt. Defaults to '0', a negative integer equals to unlimited retries.</summary>
    [JsonPropertyName("retries")]
    public int? Retries { get; set; }
}

/// <summary>Install holds the configuration for Helm install actions for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecInstall
{
    /// <summary>CRDs upgrade CRDs from the Helm Chart's crds directory according to the CRD upgrade policy provided here. Valid values are `Skip`, `Create` or `CreateReplace`. Default is `Create` and if omitted CRDs are installed but not updated.   Skip: do neither install nor replace (update) any CRDs.   Create: new CRDs are created, existing CRDs are neither updated nor deleted.   CreateReplace: new CRDs are created, existing CRDs are updated (replaced) but not deleted.   By default, CRDs are applied (installed) during Helm install action. With this option users can opt in to CRD replace existing CRDs on Helm install actions, which is not (yet) natively supported by Helm. https://helm.sh/docs/chart_best_practices/custom_resource_definitions.</summary>
    [JsonPropertyName("crds")]
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecInstallCrdsEnum>))]
    public V2HelmReleaseSpecInstallCrdsEnum? Crds { get; set; }

    /// <summary>CreateNamespace tells the Helm install action to create the HelmReleaseSpec.TargetNamespace if it does not exist yet. On uninstall, the namespace will not be garbage collected.</summary>
    [JsonPropertyName("createNamespace")]
    public bool? CreateNamespace { get; set; }

    /// <summary>DisableHooks prevents hooks from running during the Helm install action.</summary>
    [JsonPropertyName("disableHooks")]
    public bool? DisableHooks { get; set; }

    /// <summary>DisableOpenAPIValidation prevents the Helm install action from validating rendered templates against the Kubernetes OpenAPI Schema.</summary>
    [JsonPropertyName("disableOpenAPIValidation")]
    public bool? DisableOpenAPIValidation { get; set; }

    /// <summary>DisableWait disables the waiting for resources to be ready after a Helm install has been performed.</summary>
    [JsonPropertyName("disableWait")]
    public bool? DisableWait { get; set; }

    /// <summary>DisableWaitForJobs disables waiting for jobs to complete after a Helm install has been performed.</summary>
    [JsonPropertyName("disableWaitForJobs")]
    public bool? DisableWaitForJobs { get; set; }

    /// <summary>Remediation holds the remediation configuration for when the Helm install action for the HelmRelease fails. The default is to not perform any action.</summary>
    [JsonPropertyName("remediation")]
    public V2HelmReleaseSpecInstallRemediation? Remediation { get; set; }

    /// <summary>Replace tells the Helm install action to re-use the 'ReleaseName', but only if that name is a deleted release which remains in the history.</summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }

    /// <summary>SkipCRDs tells the Helm install action to not install any CRDs. By default, CRDs are installed if not already present.   Deprecated use CRD policy (`crds`) attribute with value `Skip` instead.</summary>
    [JsonPropertyName("skipCRDs")]
    public bool? SkipCRDs { get; set; }

    /// <summary>Timeout is the time to wait for any individual Kubernetes operation (like Jobs for hooks) during the performance of a Helm install action. Defaults to 'HelmReleaseSpec.Timeout'.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>SecretRef holds the name of a secret that contains a key with the kubeconfig file as the value. If no key is set, the key will default to 'value'. It is recommended that the kubeconfig is self-contained, and the secret is regularly updated if credentials such as a cloud-access-token expire. Cloud specific `cmd-path` auth helpers will not function without adding binaries and credentials to the Pod that is responsible for reconciling Kubernetes resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecKubeConfigSecretRef
{
    /// <summary>Key in the Secret, when not specified an implementation-specific default key is used.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the Secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>KubeConfig for reconciling the HelmRelease on a remote cluster. When used in combination with HelmReleaseSpec.ServiceAccountName, forces the controller to act on behalf of that Service Account at the target cluster. If the --default-service-account flag is set, its value will be used as a controller level fallback for when HelmReleaseSpec.ServiceAccountName is empty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecKubeConfig
{
    /// <summary>SecretRef holds the name of a secret that contains a key with the kubeconfig file as the value. If no key is set, the key will default to 'value'. It is recommended that the kubeconfig is self-contained, and the secret is regularly updated if credentials such as a cloud-access-token expire. Cloud specific `cmd-path` auth helpers will not function without adding binaries and credentials to the Pod that is responsible for reconciling Kubernetes resources.</summary>
    [JsonPropertyName("secretRef")]
    public V2HelmReleaseSpecKubeConfigSecretRef SecretRef { get; set; }
}

/// <summary>Image contains an image name, a new name, a new tag or digest, which will replace the original name and tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecPostRenderersKustomizeImages
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

/// <summary>Target points to the resources that the patch document should be applied to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecPostRenderersKustomizePatchesTarget
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
public partial class V2HelmReleaseSpecPostRenderersKustomizePatches
{
    /// <summary>Patch contains an inline StrategicMerge patch or an inline JSON6902 patch with an array of operation objects.</summary>
    [JsonPropertyName("patch")]
    public string Patch { get; set; }

    /// <summary>Target points to the resources that the patch document should be applied to.</summary>
    [JsonPropertyName("target")]
    public V2HelmReleaseSpecPostRenderersKustomizePatchesTarget? Target { get; set; }
}

/// <summary>Kustomization to apply as PostRenderer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecPostRenderersKustomize
{
    /// <summary>Images is a list of (image name, new name, new tag or digest) for changing image names, tags or digests. This can also be achieved with a patch, but this operator is simpler to specify.</summary>
    [JsonPropertyName("images")]
    public IList<V2HelmReleaseSpecPostRenderersKustomizeImages>? Images { get; set; }

    /// <summary>Strategic merge and JSON patches, defined as inline YAML objects, capable of targeting objects based on kind, label and annotation selectors.</summary>
    [JsonPropertyName("patches")]
    public IList<V2HelmReleaseSpecPostRenderersKustomizePatches>? Patches { get; set; }
}

/// <summary>PostRenderer contains a Helm PostRenderer specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecPostRenderers
{
    /// <summary>Kustomization to apply as PostRenderer.</summary>
    [JsonPropertyName("kustomize")]
    public V2HelmReleaseSpecPostRenderersKustomize? Kustomize { get; set; }
}

/// <summary>Rollback holds the configuration for Helm rollback actions for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecRollback
{
    /// <summary>CleanupOnFail allows deletion of new resources created during the Helm rollback action when it fails.</summary>
    [JsonPropertyName("cleanupOnFail")]
    public bool? CleanupOnFail { get; set; }

    /// <summary>DisableHooks prevents hooks from running during the Helm rollback action.</summary>
    [JsonPropertyName("disableHooks")]
    public bool? DisableHooks { get; set; }

    /// <summary>DisableWait disables the waiting for resources to be ready after a Helm rollback has been performed.</summary>
    [JsonPropertyName("disableWait")]
    public bool? DisableWait { get; set; }

    /// <summary>DisableWaitForJobs disables waiting for jobs to complete after a Helm rollback has been performed.</summary>
    [JsonPropertyName("disableWaitForJobs")]
    public bool? DisableWaitForJobs { get; set; }

    /// <summary>Force forces resource updates through a replacement strategy.</summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary>Recreate performs pod restarts for the resource if applicable.</summary>
    [JsonPropertyName("recreate")]
    public bool? Recreate { get; set; }

    /// <summary>Timeout is the time to wait for any individual Kubernetes operation (like Jobs for hooks) during the performance of a Helm rollback action. Defaults to 'HelmReleaseSpec.Timeout'.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Filter holds the configuration for individual Helm test filters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecTestFilters
{
    /// <summary>Exclude specifies whether the named test should be excluded.</summary>
    [JsonPropertyName("exclude")]
    public bool? Exclude { get; set; }

    /// <summary>Name is the name of the test.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Test holds the configuration for Helm test actions for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecTest
{
    /// <summary>Enable enables Helm test actions for this HelmRelease after an Helm install or upgrade action has been performed.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Filters is a list of tests to run or exclude from running.</summary>
    [JsonPropertyName("filters")]
    public IList<V2HelmReleaseSpecTestFilters>? Filters { get; set; }

    /// <summary>IgnoreFailures tells the controller to skip remediation when the Helm tests are run but fail. Can be overwritten for tests run after install or upgrade actions in 'Install.IgnoreTestFailures' and 'Upgrade.IgnoreTestFailures'.</summary>
    [JsonPropertyName("ignoreFailures")]
    public bool? IgnoreFailures { get; set; }

    /// <summary>Timeout is the time to wait for any individual Kubernetes operation during the performance of a Helm test action. Defaults to 'HelmReleaseSpec.Timeout'.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseSpecUninstallDeletionPropagationEnum
{
    [EnumMember(Value = "background"), JsonStringEnumMemberName("background")]
    /// <summary>background</summary>
    Background,
    [EnumMember(Value = "foreground"), JsonStringEnumMemberName("foreground")]
    /// <summary>foreground</summary>
    Foreground,
    [EnumMember(Value = "orphan"), JsonStringEnumMemberName("orphan")]
    /// <summary>orphan</summary>
    Orphan
}

/// <summary>Uninstall holds the configuration for Helm uninstall actions for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecUninstall
{
    /// <summary>DeletionPropagation specifies the deletion propagation policy when a Helm uninstall is performed.</summary>
    [JsonPropertyName("deletionPropagation")]
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecUninstallDeletionPropagationEnum>))]
    public V2HelmReleaseSpecUninstallDeletionPropagationEnum? DeletionPropagation { get; set; }

    /// <summary>DisableHooks prevents hooks from running during the Helm rollback action.</summary>
    [JsonPropertyName("disableHooks")]
    public bool? DisableHooks { get; set; }

    /// <summary>DisableWait disables waiting for all the resources to be deleted after a Helm uninstall is performed.</summary>
    [JsonPropertyName("disableWait")]
    public bool? DisableWait { get; set; }

    /// <summary>KeepHistory tells Helm to remove all associated resources and mark the release as deleted, but retain the release history.</summary>
    [JsonPropertyName("keepHistory")]
    public bool? KeepHistory { get; set; }

    /// <summary>Timeout is the time to wait for any individual Kubernetes operation (like Jobs for hooks) during the performance of a Helm uninstall action. Defaults to 'HelmReleaseSpec.Timeout'.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseSpecUpgradeCrdsEnum
{
    [EnumMember(Value = "Skip"), JsonStringEnumMemberName("Skip")]
    /// <summary>Skip</summary>
    Skip,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "CreateReplace"), JsonStringEnumMemberName("CreateReplace")]
    /// <summary>CreateReplace</summary>
    CreateReplace
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseSpecUpgradeRemediationStrategyEnum
{
    [EnumMember(Value = "rollback"), JsonStringEnumMemberName("rollback")]
    /// <summary>rollback</summary>
    Rollback,
    [EnumMember(Value = "uninstall"), JsonStringEnumMemberName("uninstall")]
    /// <summary>uninstall</summary>
    Uninstall
}

/// <summary>Remediation holds the remediation configuration for when the Helm upgrade action for the HelmRelease fails. The default is to not perform any action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecUpgradeRemediation
{
    /// <summary>IgnoreTestFailures tells the controller to skip remediation when the Helm tests are run after an upgrade action but fail. Defaults to 'Test.IgnoreFailures'.</summary>
    [JsonPropertyName("ignoreTestFailures")]
    public bool? IgnoreTestFailures { get; set; }

    /// <summary>RemediateLastFailure tells the controller to remediate the last failure, when no retries remain. Defaults to 'false' unless 'Retries' is greater than 0.</summary>
    [JsonPropertyName("remediateLastFailure")]
    public bool? RemediateLastFailure { get; set; }

    /// <summary>Retries is the number of retries that should be attempted on failures before bailing. Remediation, using 'Strategy', is performed between each attempt. Defaults to '0', a negative integer equals to unlimited retries.</summary>
    [JsonPropertyName("retries")]
    public int? Retries { get; set; }

    /// <summary>Strategy to use for failure remediation. Defaults to 'rollback'.</summary>
    [JsonPropertyName("strategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecUpgradeRemediationStrategyEnum>))]
    public V2HelmReleaseSpecUpgradeRemediationStrategyEnum? Strategy { get; set; }
}

/// <summary>Upgrade holds the configuration for Helm upgrade actions for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecUpgrade
{
    /// <summary>CleanupOnFail allows deletion of new resources created during the Helm upgrade action when it fails.</summary>
    [JsonPropertyName("cleanupOnFail")]
    public bool? CleanupOnFail { get; set; }

    /// <summary>CRDs upgrade CRDs from the Helm Chart's crds directory according to the CRD upgrade policy provided here. Valid values are `Skip`, `Create` or `CreateReplace`. Default is `Skip` and if omitted CRDs are neither installed nor upgraded.   Skip: do neither install nor replace (update) any CRDs.   Create: new CRDs are created, existing CRDs are neither updated nor deleted.   CreateReplace: new CRDs are created, existing CRDs are updated (replaced) but not deleted.   By default, CRDs are not applied during Helm upgrade action. With this option users can opt-in to CRD upgrade, which is not (yet) natively supported by Helm. https://helm.sh/docs/chart_best_practices/custom_resource_definitions.</summary>
    [JsonPropertyName("crds")]
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecUpgradeCrdsEnum>))]
    public V2HelmReleaseSpecUpgradeCrdsEnum? Crds { get; set; }

    /// <summary>DisableHooks prevents hooks from running during the Helm upgrade action.</summary>
    [JsonPropertyName("disableHooks")]
    public bool? DisableHooks { get; set; }

    /// <summary>DisableOpenAPIValidation prevents the Helm upgrade action from validating rendered templates against the Kubernetes OpenAPI Schema.</summary>
    [JsonPropertyName("disableOpenAPIValidation")]
    public bool? DisableOpenAPIValidation { get; set; }

    /// <summary>DisableWait disables the waiting for resources to be ready after a Helm upgrade has been performed.</summary>
    [JsonPropertyName("disableWait")]
    public bool? DisableWait { get; set; }

    /// <summary>DisableWaitForJobs disables waiting for jobs to complete after a Helm upgrade has been performed.</summary>
    [JsonPropertyName("disableWaitForJobs")]
    public bool? DisableWaitForJobs { get; set; }

    /// <summary>Force forces resource updates through a replacement strategy.</summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary>PreserveValues will make Helm reuse the last release's values and merge in overrides from 'Values'. Setting this flag makes the HelmRelease non-declarative.</summary>
    [JsonPropertyName("preserveValues")]
    public bool? PreserveValues { get; set; }

    /// <summary>Remediation holds the remediation configuration for when the Helm upgrade action for the HelmRelease fails. The default is to not perform any action.</summary>
    [JsonPropertyName("remediation")]
    public V2HelmReleaseSpecUpgradeRemediation? Remediation { get; set; }

    /// <summary>Timeout is the time to wait for any individual Kubernetes operation (like Jobs for hooks) during the performance of a Helm upgrade action. Defaults to 'HelmReleaseSpec.Timeout'.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseSpecValuesFromKindEnum
{
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    /// <summary>Secret</summary>
    Secret,
    [EnumMember(Value = "ConfigMap"), JsonStringEnumMemberName("ConfigMap")]
    /// <summary>ConfigMap</summary>
    ConfigMap
}

/// <summary>ValuesReference contains a reference to a resource containing Helm values, and optionally the key they can be found at.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecValuesFrom
{
    /// <summary>Kind of the values referent, valid values are ('Secret', 'ConfigMap').</summary>
    [JsonPropertyName("kind")]
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecValuesFromKindEnum>))]
    public V2HelmReleaseSpecValuesFromKindEnum Kind { get; set; }

    /// <summary>Name of the values referent. Should reside in the same namespace as the referring resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Optional marks this ValuesReference as optional. When set, a not found error for the values reference is ignored, but any ValuesKey, TargetPath or transient error will still result in a reconciliation failure.</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>TargetPath is the YAML dot notation path the value should be merged at. When set, the ValuesKey is expected to be a single flat value. Defaults to 'None', which results in the values getting merged at the root.</summary>
    [JsonPropertyName("targetPath")]
    public string? TargetPath { get; set; }

    /// <summary>ValuesKey is the data key where the values.yaml or a specific value can be found at. Defaults to 'values.yaml'.</summary>
    [JsonPropertyName("valuesKey")]
    public string? ValuesKey { get; set; }
}

/// <summary>HelmReleaseSpec defines the desired state of a Helm release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpec
{
    /// <summary>Chart defines the template of the v1.HelmChart that should be created for this HelmRelease.</summary>
    [JsonPropertyName("chart")]
    public V2HelmReleaseSpecChart? Chart { get; set; }

    /// <summary>ChartRef holds a reference to a source controller resource containing the Helm chart artifact.</summary>
    [JsonPropertyName("chartRef")]
    public V2HelmReleaseSpecChartRef? ChartRef { get; set; }

    /// <summary>DependsOn may contain a meta.NamespacedObjectReference slice with references to HelmRelease resources that must be ready before this HelmRelease can be reconciled.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V2HelmReleaseSpecDependsOn>? DependsOn { get; set; }

    /// <summary>DriftDetection holds the configuration for detecting and handling differences between the manifest in the Helm storage and the resources currently existing in the cluster.</summary>
    [JsonPropertyName("driftDetection")]
    public V2HelmReleaseSpecDriftDetection? DriftDetection { get; set; }

    /// <summary>Install holds the configuration for Helm install actions for this HelmRelease.</summary>
    [JsonPropertyName("install")]
    public V2HelmReleaseSpecInstall? Install { get; set; }

    /// <summary>Interval at which to reconcile the Helm release.</summary>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }

    /// <summary>KubeConfig for reconciling the HelmRelease on a remote cluster. When used in combination with HelmReleaseSpec.ServiceAccountName, forces the controller to act on behalf of that Service Account at the target cluster. If the --default-service-account flag is set, its value will be used as a controller level fallback for when HelmReleaseSpec.ServiceAccountName is empty.</summary>
    [JsonPropertyName("kubeConfig")]
    public V2HelmReleaseSpecKubeConfig? KubeConfig { get; set; }

    /// <summary>MaxHistory is the number of revisions saved by Helm for this HelmRelease. Use '0' for an unlimited number of revisions; defaults to '5'.</summary>
    [JsonPropertyName("maxHistory")]
    public int? MaxHistory { get; set; }

    /// <summary>PersistentClient tells the controller to use a persistent Kubernetes client for this release. When enabled, the client will be reused for the duration of the reconciliation, instead of being created and destroyed for each (step of a) Helm action.   This can improve performance, but may cause issues with some Helm charts that for example do create Custom Resource Definitions during installation outside Helm's CRD lifecycle hooks, which are then not observed to be available by e.g. post-install hooks.   If not set, it defaults to true.</summary>
    [JsonPropertyName("persistentClient")]
    public bool? PersistentClient { get; set; }

    /// <summary>PostRenderers holds an array of Helm PostRenderers, which will be applied in order of their definition.</summary>
    [JsonPropertyName("postRenderers")]
    public IList<V2HelmReleaseSpecPostRenderers>? PostRenderers { get; set; }

    /// <summary>ReleaseName used for the Helm release. Defaults to a composition of '[TargetNamespace-]Name'.</summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>Rollback holds the configuration for Helm rollback actions for this HelmRelease.</summary>
    [JsonPropertyName("rollback")]
    public V2HelmReleaseSpecRollback? Rollback { get; set; }

    /// <summary>The name of the Kubernetes service account to impersonate when reconciling this HelmRelease.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>StorageNamespace used for the Helm storage. Defaults to the namespace of the HelmRelease.</summary>
    [JsonPropertyName("storageNamespace")]
    public string? StorageNamespace { get; set; }

    /// <summary>Suspend tells the controller to suspend reconciliation for this HelmRelease, it does not apply to already started reconciliations. Defaults to false.</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>TargetNamespace to target when performing operations for the HelmRelease. Defaults to the namespace of the HelmRelease.</summary>
    [JsonPropertyName("targetNamespace")]
    public string? TargetNamespace { get; set; }

    /// <summary>Test holds the configuration for Helm test actions for this HelmRelease.</summary>
    [JsonPropertyName("test")]
    public V2HelmReleaseSpecTest? Test { get; set; }

    /// <summary>Timeout is the time to wait for any individual Kubernetes operation (like Jobs for hooks) during the performance of a Helm action. Defaults to '5m0s'.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Uninstall holds the configuration for Helm uninstall actions for this HelmRelease.</summary>
    [JsonPropertyName("uninstall")]
    public V2HelmReleaseSpecUninstall? Uninstall { get; set; }

    /// <summary>Upgrade holds the configuration for Helm upgrade actions for this HelmRelease.</summary>
    [JsonPropertyName("upgrade")]
    public V2HelmReleaseSpecUpgrade? Upgrade { get; set; }

    /// <summary>Values holds the values for this Helm release.</summary>
    [JsonPropertyName("values")]
    public JsonNode? Values { get; set; }

    /// <summary>ValuesFrom holds references to resources containing Helm values for this HelmRelease, and information about how they should be merged.</summary>
    [JsonPropertyName("valuesFrom")]
    public IList<V2HelmReleaseSpecValuesFrom>? ValuesFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseStatusConditionsStatusEnum
{
    [EnumMember(Value = "true"), JsonStringEnumMemberName("true")]
    /// <summary>true</summary>
    True,
    [EnumMember(Value = "false"), JsonStringEnumMemberName("false")]
    /// <summary>false</summary>
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    /// <summary>Unknown</summary>
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource. --- This struct is intended for direct use as an array at the field path .status.conditions.  For example,   	type FooStatus struct{ 	    // Represents the observations of a foo's current state. 	    // Known .status.conditions.type are: "Available", "Progressing", and "Degraded" 	    // +patchMergeKey=type 	    // +patchStrategy=merge 	    // +listType=map 	    // +listMapKey=type 	    Conditions []metav1.Condition `json:"conditions,omitempty" patchStrategy:"merge" patchMergeKey:"type" protobuf:"bytes,1,rep,name=conditions"`   	    // other fields 	}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseStatusConditions
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
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseStatusConditionsStatusEnum>))]
    public V2HelmReleaseStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase. --- Many .condition.type values are consistent across resources like Available, but because arbitrary conditions can be useful (see .node.status.conditions), the ability to deconflict is important. The regex it matches is (dns1123SubdomainFmt/)?(qualifiedNameFmt)</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>TestHookStatus holds the status information for a test hook as observed to be run by the controller.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseStatusHistoryTestHooks
{
    /// <summary>LastCompleted is the time the test hook last completed.</summary>
    [JsonPropertyName("lastCompleted")]
    public string? LastCompleted { get; set; }

    /// <summary>LastStarted is the time the test hook was last started.</summary>
    [JsonPropertyName("lastStarted")]
    public string? LastStarted { get; set; }

    /// <summary>Phase the test hook was observed to be in.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }
}

/// <summary>Snapshot captures a point-in-time copy of the status information for a Helm release, as managed by the controller.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseStatusHistory
{
    /// <summary>APIVersion is the API version of the Snapshot. Provisional: when the calculation method of the Digest field is changed, this field will be used to distinguish between the old and new methods.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>AppVersion is the chart app version of the release object in storage.</summary>
    [JsonPropertyName("appVersion")]
    public string? AppVersion { get; set; }

    /// <summary>ChartName is the chart name of the release object in storage.</summary>
    [JsonPropertyName("chartName")]
    public string ChartName { get; set; }

    /// <summary>ChartVersion is the chart version of the release object in storage.</summary>
    [JsonPropertyName("chartVersion")]
    public string ChartVersion { get; set; }

    /// <summary>ConfigDigest is the checksum of the config (better known as "values") of the release object in storage. It has the format of `&lt;algo&gt;:&lt;checksum&gt;`.</summary>
    [JsonPropertyName("configDigest")]
    public string ConfigDigest { get; set; }

    /// <summary>Deleted is when the release was deleted.</summary>
    [JsonPropertyName("deleted")]
    public string? Deleted { get; set; }

    /// <summary>Digest is the checksum of the release object in storage. It has the format of `&lt;algo&gt;:&lt;checksum&gt;`.</summary>
    [JsonPropertyName("digest")]
    public string Digest { get; set; }

    /// <summary>FirstDeployed is when the release was first deployed.</summary>
    [JsonPropertyName("firstDeployed")]
    public string FirstDeployed { get; set; }

    /// <summary>LastDeployed is when the release was last deployed.</summary>
    [JsonPropertyName("lastDeployed")]
    public string LastDeployed { get; set; }

    /// <summary>Name is the name of the release.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace is the namespace the release is deployed to.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>OCIDigest is the digest of the OCI artifact associated with the release.</summary>
    [JsonPropertyName("ociDigest")]
    public string? OciDigest { get; set; }

    /// <summary>Status is the current state of the release.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>TestHooks is the list of test hooks for the release as observed to be run by the controller.</summary>
    [JsonPropertyName("testHooks")]
    public IDictionary<string, V2HelmReleaseStatusHistoryTestHooks>? TestHooks { get; set; }

    /// <summary>Version is the version of the release object in storage.</summary>
    [JsonPropertyName("version")]
    public int Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V2HelmReleaseStatusLastAttemptedReleaseActionEnum
{
    [EnumMember(Value = "install"), JsonStringEnumMemberName("install")]
    /// <summary>install</summary>
    Install,
    [EnumMember(Value = "upgrade"), JsonStringEnumMemberName("upgrade")]
    /// <summary>upgrade</summary>
    Upgrade
}

/// <summary>HelmReleaseStatus defines the observed state of a HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseStatus
{
    /// <summary>Conditions holds the conditions for the HelmRelease.</summary>
    [JsonPropertyName("conditions")]
    public IList<V2HelmReleaseStatusConditions>? Conditions { get; set; }

    /// <summary>Failures is the reconciliation failure count against the latest desired state. It is reset after a successful reconciliation.</summary>
    [JsonPropertyName("failures")]
    public long? Failures { get; set; }

    /// <summary>HelmChart is the namespaced name of the HelmChart resource created by the controller for the HelmRelease.</summary>
    [JsonPropertyName("helmChart")]
    public string? HelmChart { get; set; }

    /// <summary>History holds the history of Helm releases performed for this HelmRelease up to the last successfully completed release.</summary>
    [JsonPropertyName("history")]
    public IList<V2HelmReleaseStatusHistory>? History { get; set; }

    /// <summary>InstallFailures is the install failure count against the latest desired state. It is reset after a successful reconciliation.</summary>
    [JsonPropertyName("installFailures")]
    public long? InstallFailures { get; set; }

    /// <summary>LastAttemptedConfigDigest is the digest for the config (better known as "values") of the last reconciliation attempt.</summary>
    [JsonPropertyName("lastAttemptedConfigDigest")]
    public string? LastAttemptedConfigDigest { get; set; }

    /// <summary>LastAttemptedGeneration is the last generation the controller attempted to reconcile.</summary>
    [JsonPropertyName("lastAttemptedGeneration")]
    public long? LastAttemptedGeneration { get; set; }

    /// <summary>LastAttemptedReleaseAction is the last release action performed for this HelmRelease. It is used to determine the active remediation strategy.</summary>
    [JsonPropertyName("lastAttemptedReleaseAction")]
    [JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseStatusLastAttemptedReleaseActionEnum>))]
    public V2HelmReleaseStatusLastAttemptedReleaseActionEnum? LastAttemptedReleaseAction { get; set; }

    /// <summary>LastAttemptedRevision is the Source revision of the last reconciliation attempt. For OCIRepository  sources, the 12 first characters of the digest are appended to the chart version e.g. "1.2.3+1234567890ab".</summary>
    [JsonPropertyName("lastAttemptedRevision")]
    public string? LastAttemptedRevision { get; set; }

    /// <summary>LastAttemptedRevisionDigest is the digest of the last reconciliation attempt. This is only set for OCIRepository sources.</summary>
    [JsonPropertyName("lastAttemptedRevisionDigest")]
    public string? LastAttemptedRevisionDigest { get; set; }

    /// <summary>LastAttemptedValuesChecksum is the SHA1 checksum for the values of the last reconciliation attempt. Deprecated: Use LastAttemptedConfigDigest instead.</summary>
    [JsonPropertyName("lastAttemptedValuesChecksum")]
    public string? LastAttemptedValuesChecksum { get; set; }

    /// <summary>LastHandledForceAt holds the value of the most recent force request value, so a change of the annotation value can be detected.</summary>
    [JsonPropertyName("lastHandledForceAt")]
    public string? LastHandledForceAt { get; set; }

    /// <summary>LastHandledReconcileAt holds the value of the most recent reconcile request value, so a change of the annotation value can be detected.</summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>LastHandledResetAt holds the value of the most recent reset request value, so a change of the annotation value can be detected.</summary>
    [JsonPropertyName("lastHandledResetAt")]
    public string? LastHandledResetAt { get; set; }

    /// <summary>LastReleaseRevision is the revision of the last successful Helm release. Deprecated: Use History instead.</summary>
    [JsonPropertyName("lastReleaseRevision")]
    public int? LastReleaseRevision { get; set; }

    /// <summary>ObservedGeneration is the last observed generation.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedPostRenderersDigest is the digest for the post-renderers of the last successful reconciliation attempt.</summary>
    [JsonPropertyName("observedPostRenderersDigest")]
    public string? ObservedPostRenderersDigest { get; set; }

    /// <summary>StorageNamespace is the namespace of the Helm release storage for the current release.</summary>
    [JsonPropertyName("storageNamespace")]
    public string? StorageNamespace { get; set; }

    /// <summary>UpgradeFailures is the upgrade failure count against the latest desired state. It is reset after a successful reconciliation.</summary>
    [JsonPropertyName("upgradeFailures")]
    public long? UpgradeFailures { get; set; }
}

/// <summary>HelmRelease is the Schema for the helmreleases API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2HelmRelease : IKubernetesObject<V1ObjectMeta>, ISpec<V2HelmReleaseSpec>, IStatus<V2HelmReleaseStatus>
{
    public const string KubeApiVersion = "v2";
    public const string KubeKind = "HelmRelease";
    public const string KubeGroup = "helm.toolkit.fluxcd.io";
    public const string KubePluralName = "helmreleases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HelmReleaseSpec defines the desired state of a Helm release.</summary>
    [JsonPropertyName("spec")]
    public V2HelmReleaseSpec? Spec { get; set; }

    /// <summary>HelmReleaseStatus defines the observed state of a HelmRelease.</summary>
    [JsonPropertyName("status")]
    public V2HelmReleaseStatus? Status { get; set; }
}