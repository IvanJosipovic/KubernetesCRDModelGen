using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudrun.gcp.upbound.io;
public enum V1beta1DomainMappingSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1DomainMappingSpecForProviderMetadataNamespaceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainMappingSpecForProviderMetadataNamespaceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DomainMappingSpecForProviderMetadataNamespaceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecForProviderMetadataNamespaceRefPolicyResolutionEnum>))]
    public V1beta1DomainMappingSpecForProviderMetadataNamespaceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecForProviderMetadataNamespaceRefPolicyResolveEnum>))]
    public V1beta1DomainMappingSpecForProviderMetadataNamespaceRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DomainMappingSpecForProviderMetadataNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainMappingSpecForProviderMetadataNamespaceRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainMappingSpecForProviderMetadataNamespaceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainMappingSpecForProviderMetadataNamespaceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DomainMappingSpecForProviderMetadataNamespaceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecForProviderMetadataNamespaceSelectorPolicyResolutionEnum>))]
    public V1beta1DomainMappingSpecForProviderMetadataNamespaceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecForProviderMetadataNamespaceSelectorPolicyResolveEnum>))]
    public V1beta1DomainMappingSpecForProviderMetadataNamespaceSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DomainMappingSpecForProviderMetadataNamespaceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainMappingSpecForProviderMetadataNamespaceSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DomainMappingSpecForProviderMetadata
{
    /// <summary>Annotations is a key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field. Note: This field is non-authoritative, and will only manage the annotations present in your configuration. Please refer to the field effective_annotations for all of the annotations present on the resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and routes. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>In Cloud Run the namespace must be equal to either the project ID or project number.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceRef")]
    public V1beta1DomainMappingSpecForProviderMetadataNamespaceRef? NamespaceRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1beta1DomainMappingSpecForProviderMetadataNamespaceSelector? NamespaceSelector { get; set; }
}

public enum V1beta1DomainMappingSpecForProviderSpecRouteNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainMappingSpecForProviderSpecRouteNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DomainMappingSpecForProviderSpecRouteNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecForProviderSpecRouteNameRefPolicyResolutionEnum>))]
    public V1beta1DomainMappingSpecForProviderSpecRouteNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecForProviderSpecRouteNameRefPolicyResolveEnum>))]
    public V1beta1DomainMappingSpecForProviderSpecRouteNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DomainMappingSpecForProviderSpecRouteNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainMappingSpecForProviderSpecRouteNameRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainMappingSpecForProviderSpecRouteNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainMappingSpecForProviderSpecRouteNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DomainMappingSpecForProviderSpecRouteNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecForProviderSpecRouteNameSelectorPolicyResolutionEnum>))]
    public V1beta1DomainMappingSpecForProviderSpecRouteNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecForProviderSpecRouteNameSelectorPolicyResolveEnum>))]
    public V1beta1DomainMappingSpecForProviderSpecRouteNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DomainMappingSpecForProviderSpecRouteNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainMappingSpecForProviderSpecRouteNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DomainMappingSpecForProviderSpec
{
    /// <summary>The mode of the certificate. Default value is AUTOMATIC. Possible values are: NONE, AUTOMATIC.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>If set, the mapping will override any mapping set before this spec was set. It is recommended that the user leaves this empty to receive an error warning about a potential conflict and only set it once the respective UI has given such a warning.</summary>
    [JsonPropertyName("forceOverride")]
    public bool? ForceOverride { get; set; }

    /// <summary>The name of the Cloud Run Service that this DomainMapping applies to. The route must exist.</summary>
    [JsonPropertyName("routeName")]
    public string? RouteName { get; set; }

    /// <summary>Reference to a Service in cloudrun to populate routeName.</summary>
    [JsonPropertyName("routeNameRef")]
    public V1beta1DomainMappingSpecForProviderSpecRouteNameRef? RouteNameRef { get; set; }

    /// <summary>Selector for a Service in cloudrun to populate routeName.</summary>
    [JsonPropertyName("routeNameSelector")]
    public V1beta1DomainMappingSpecForProviderSpecRouteNameSelector? RouteNameSelector { get; set; }
}

public partial class V1beta1DomainMappingSpecForProvider
{
    /// <summary>The location of the cloud run instance. eg us-central1</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Metadata associated with this DomainMapping. Structure is documented below.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1DomainMappingSpecForProviderMetadata>? Metadata { get; set; }

    /// <summary>Name should be a verified domain</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The spec for this DomainMapping. Structure is documented below.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1DomainMappingSpecForProviderSpec>? Spec { get; set; }
}

public enum V1beta1DomainMappingSpecInitProviderMetadataNamespaceRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainMappingSpecInitProviderMetadataNamespaceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DomainMappingSpecInitProviderMetadataNamespaceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecInitProviderMetadataNamespaceRefPolicyResolutionEnum>))]
    public V1beta1DomainMappingSpecInitProviderMetadataNamespaceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecInitProviderMetadataNamespaceRefPolicyResolveEnum>))]
    public V1beta1DomainMappingSpecInitProviderMetadataNamespaceRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DomainMappingSpecInitProviderMetadataNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainMappingSpecInitProviderMetadataNamespaceRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainMappingSpecInitProviderMetadataNamespaceSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainMappingSpecInitProviderMetadataNamespaceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DomainMappingSpecInitProviderMetadataNamespaceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecInitProviderMetadataNamespaceSelectorPolicyResolutionEnum>))]
    public V1beta1DomainMappingSpecInitProviderMetadataNamespaceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecInitProviderMetadataNamespaceSelectorPolicyResolveEnum>))]
    public V1beta1DomainMappingSpecInitProviderMetadataNamespaceSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DomainMappingSpecInitProviderMetadataNamespaceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainMappingSpecInitProviderMetadataNamespaceSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DomainMappingSpecInitProviderMetadata
{
    /// <summary>Annotations is a key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field. Note: This field is non-authoritative, and will only manage the annotations present in your configuration. Please refer to the field effective_annotations for all of the annotations present on the resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and routes. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>In Cloud Run the namespace must be equal to either the project ID or project number.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceRef")]
    public V1beta1DomainMappingSpecInitProviderMetadataNamespaceRef? NamespaceRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate namespace.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1beta1DomainMappingSpecInitProviderMetadataNamespaceSelector? NamespaceSelector { get; set; }
}

public enum V1beta1DomainMappingSpecInitProviderSpecRouteNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainMappingSpecInitProviderSpecRouteNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DomainMappingSpecInitProviderSpecRouteNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecInitProviderSpecRouteNameRefPolicyResolutionEnum>))]
    public V1beta1DomainMappingSpecInitProviderSpecRouteNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecInitProviderSpecRouteNameRefPolicyResolveEnum>))]
    public V1beta1DomainMappingSpecInitProviderSpecRouteNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DomainMappingSpecInitProviderSpecRouteNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainMappingSpecInitProviderSpecRouteNameRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainMappingSpecInitProviderSpecRouteNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainMappingSpecInitProviderSpecRouteNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DomainMappingSpecInitProviderSpecRouteNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecInitProviderSpecRouteNameSelectorPolicyResolutionEnum>))]
    public V1beta1DomainMappingSpecInitProviderSpecRouteNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecInitProviderSpecRouteNameSelectorPolicyResolveEnum>))]
    public V1beta1DomainMappingSpecInitProviderSpecRouteNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DomainMappingSpecInitProviderSpecRouteNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainMappingSpecInitProviderSpecRouteNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1DomainMappingSpecInitProviderSpec
{
    /// <summary>The mode of the certificate. Default value is AUTOMATIC. Possible values are: NONE, AUTOMATIC.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>If set, the mapping will override any mapping set before this spec was set. It is recommended that the user leaves this empty to receive an error warning about a potential conflict and only set it once the respective UI has given such a warning.</summary>
    [JsonPropertyName("forceOverride")]
    public bool? ForceOverride { get; set; }

    /// <summary>The name of the Cloud Run Service that this DomainMapping applies to. The route must exist.</summary>
    [JsonPropertyName("routeName")]
    public string? RouteName { get; set; }

    /// <summary>Reference to a Service in cloudrun to populate routeName.</summary>
    [JsonPropertyName("routeNameRef")]
    public V1beta1DomainMappingSpecInitProviderSpecRouteNameRef? RouteNameRef { get; set; }

    /// <summary>Selector for a Service in cloudrun to populate routeName.</summary>
    [JsonPropertyName("routeNameSelector")]
    public V1beta1DomainMappingSpecInitProviderSpecRouteNameSelector? RouteNameSelector { get; set; }
}

public partial class V1beta1DomainMappingSpecInitProvider
{
    /// <summary>The location of the cloud run instance. eg us-central1</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Metadata associated with this DomainMapping. Structure is documented below.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1DomainMappingSpecInitProviderMetadata>? Metadata { get; set; }

    /// <summary>Name should be a verified domain</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The spec for this DomainMapping. Structure is documented below.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1DomainMappingSpecInitProviderSpec>? Spec { get; set; }
}

public enum V1beta1DomainMappingSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1DomainMappingSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainMappingSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DomainMappingSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1DomainMappingSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1DomainMappingSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DomainMappingSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainMappingSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1DomainMappingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1DomainMappingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1DomainMappingSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1DomainMappingSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1DomainMappingSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1DomainMappingSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainMappingSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1DomainMappingSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1DomainMappingSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DomainMappingSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DomainMappingSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1DomainMappingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1DomainMappingSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainMappingSpecDeletionPolicyEnum>))]
    public V1beta1DomainMappingSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DomainMappingSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DomainMappingSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DomainMappingSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DomainMappingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DomainMappingSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DomainMappingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1DomainMappingStatusAtProviderMetadata
{
    /// <summary>Annotations is a key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations Note: The Cloud Run API may add additional annotations that were not provided in your config.ignore_changes rule to the metadata.0.annotations field. Note: This field is non-authoritative, and will only manage the annotations present in your configuration. Please refer to the field effective_annotations for all of the annotations present on the resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>(Output) A sequence number representing a specific generation of the desired state.</summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and routes. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>In Cloud Run the namespace must be equal to either the project ID or project number.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>(Output) An opaque value that represents the internal version of this object that can be used by clients to determine when objects have changed. May be used for optimistic concurrency, change detection, and the watch operation on a resource or set of resources. They may only be valid for a particular resource or set of resources. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency</summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>(Output) SelfLink is a URL representing this object.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>(Output) The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>(Output) UID is a unique id generated by the server on successful creation of a resource and is not allowed to change on PUT operations. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#uids</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

public partial class V1beta1DomainMappingStatusAtProviderSpec
{
    /// <summary>The mode of the certificate. Default value is AUTOMATIC. Possible values are: NONE, AUTOMATIC.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>If set, the mapping will override any mapping set before this spec was set. It is recommended that the user leaves this empty to receive an error warning about a potential conflict and only set it once the respective UI has given such a warning.</summary>
    [JsonPropertyName("forceOverride")]
    public bool? ForceOverride { get; set; }

    /// <summary>The name of the Cloud Run Service that this DomainMapping applies to. The route must exist.</summary>
    [JsonPropertyName("routeName")]
    public string? RouteName { get; set; }
}

public partial class V1beta1DomainMappingStatusAtProviderStatusConditions
{
    /// <summary>(Output) Human readable message indicating details about the current status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>(Output) One-word CamelCase reason for the condition's current status.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>The current status of the DomainMapping. Structure is documented below.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Resource record type. Example: AAAA. Possible values are: A, AAAA, CNAME.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1DomainMappingStatusAtProviderStatusResourceRecords
{
    /// <summary>(Output) Relative name of the object affected by this record. Only applicable for CNAME records. Example: 'www'.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Output) Data for this record. Values vary by record type, as defined in RFC 1035 (section 5) and RFC 1034 (section 3.6.1).</summary>
    [JsonPropertyName("rrdata")]
    public string? Rrdata { get; set; }

    /// <summary>Resource record type. Example: AAAA. Possible values are: A, AAAA, CNAME.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1DomainMappingStatusAtProviderStatus
{
    /// <summary>(Output) Array of observed DomainMappingConditions, indicating the current state of the DomainMapping. Structure is documented below.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DomainMappingStatusAtProviderStatusConditions>? Conditions { get; set; }

    /// <summary>(Output) The name of the route that the mapping currently points to.</summary>
    [JsonPropertyName("mappedRouteName")]
    public string? MappedRouteName { get; set; }

    /// <summary>(Output) ObservedGeneration is the 'Generation' of the DomainMapping that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public double? ObservedGeneration { get; set; }

    /// <summary>The resource records required to configure this domain mapping. These records must be added to the domain's DNS configuration in order to serve the application via this domain mapping. Structure is documented below.</summary>
    [JsonPropertyName("resourceRecords")]
    public IList<V1beta1DomainMappingStatusAtProviderStatusResourceRecords>? ResourceRecords { get; set; }
}

public partial class V1beta1DomainMappingStatusAtProvider
{
    /// <summary>an identifier for the resource with format locations/{{location}}/namespaces/{{project}}/domainmappings/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The location of the cloud run instance. eg us-central1</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Metadata associated with this DomainMapping. Structure is documented below.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1DomainMappingStatusAtProviderMetadata>? Metadata { get; set; }

    /// <summary>Name should be a verified domain</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The spec for this DomainMapping. Structure is documented below.</summary>
    [JsonPropertyName("spec")]
    public IList<V1beta1DomainMappingStatusAtProviderSpec>? Spec { get; set; }

    /// <summary>The current status of the DomainMapping. Structure is documented below.</summary>
    [JsonPropertyName("status")]
    public IList<V1beta1DomainMappingStatusAtProviderStatus>? Status { get; set; }
}

public partial class V1beta1DomainMappingStatusConditions
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

public partial class V1beta1DomainMappingStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DomainMappingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DomainMappingStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DomainMapping : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DomainMappingSpec>, IStatus<V1beta1DomainMappingStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DomainMapping";
    public const string KubeGroup = "cloudrun.gcp.upbound.io";
    public const string KubePluralName = "domainmappings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainMappingSpec defines the desired state of DomainMapping</summary>
    [JsonPropertyName("spec")]
    public V1beta1DomainMappingSpec Spec { get; set; }

    /// <summary>DomainMappingStatus defines the observed state of DomainMapping.</summary>
    [JsonPropertyName("status")]
    public V1beta1DomainMappingStatus? Status { get; set; }
}