using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.resourcemanager.cnrm.cloud.google.com;
public partial class V1beta1ResourceManagerPolicySpecBooleanPolicy
{
    /// <summary>If true, then the Policy is enforced. If false, then any configuration is acceptable.</summary>
    [JsonPropertyName("enforced")]
    public bool Enforced { get; set; }
}

public partial class V1beta1ResourceManagerPolicySpecFolderRef
{
    /// <summary>Allowed value: The `name` field of a `Folder` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ResourceManagerPolicySpecListPolicyAllow
{
    /// <summary>The policy allows or denies all values.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>The policy can define specific values that are allowed or denied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

public partial class V1beta1ResourceManagerPolicySpecListPolicyDeny
{
    /// <summary>The policy allows or denies all values.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; set; }

    /// <summary>The policy can define specific values that are allowed or denied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

public partial class V1beta1ResourceManagerPolicySpecListPolicy
{
    /// <summary>One or the other must be set.</summary>
    [JsonPropertyName("allow")]
    public V1beta1ResourceManagerPolicySpecListPolicyAllow? Allow { get; set; }

    /// <summary>One or the other must be set.</summary>
    [JsonPropertyName("deny")]
    public V1beta1ResourceManagerPolicySpecListPolicyDeny? Deny { get; set; }

    /// <summary>If set to true, the values from the effective Policy of the parent resource are inherited, meaning the values set in this Policy are added to the values inherited up the hierarchy.</summary>
    [JsonPropertyName("inheritFromParent")]
    public bool? InheritFromParent { get; set; }

    /// <summary>The Google Cloud Console will try to default to a configuration that matches the value specified in this field.</summary>
    [JsonPropertyName("suggestedValue")]
    public string? SuggestedValue { get; set; }
}

public partial class V1beta1ResourceManagerPolicySpecOrganizationRef
{
    /// <summary>Allowed value: The `name` field of an `Organization` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ResourceManagerPolicySpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ResourceManagerPolicySpecRestorePolicy
{
    /// <summary>May only be set to true. If set, then the default Policy is restored.</summary>
    [JsonPropertyName("default")]
    public bool Default { get; set; }
}

public partial class V1beta1ResourceManagerPolicySpec
{
    /// <summary>A boolean policy is a constraint that is either enforced or not.</summary>
    [JsonPropertyName("booleanPolicy")]
    public V1beta1ResourceManagerPolicySpecBooleanPolicy? BooleanPolicy { get; set; }

    /// <summary>Immutable. The name of the Constraint the Policy is configuring, for example, serviceuser.services.</summary>
    [JsonPropertyName("constraint")]
    public string Constraint { get; set; }

    /// <summary>The folder on which to configure the constraint. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
    [JsonPropertyName("folderRef")]
    public V1beta1ResourceManagerPolicySpecFolderRef? FolderRef { get; set; }

    /// <summary>A policy that can define specific values that are allowed or denied for the given constraint. It can also be used to allow or deny all values. .</summary>
    [JsonPropertyName("listPolicy")]
    public V1beta1ResourceManagerPolicySpecListPolicy? ListPolicy { get; set; }

    /// <summary>The organization on which to configure the constraint. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1ResourceManagerPolicySpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>The project on which to configure the constraint. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ResourceManagerPolicySpecProjectRef? ProjectRef { get; set; }

    /// <summary>A restore policy is a constraint to restore the default policy.</summary>
    [JsonPropertyName("restorePolicy")]
    public V1beta1ResourceManagerPolicySpecRestorePolicy? RestorePolicy { get; set; }

    /// <summary>Version of the Policy. Default version is 0.</summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}

public partial class V1beta1ResourceManagerPolicyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1ResourceManagerPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ResourceManagerPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>The etag of the organization policy. etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds, representing when the variable was last updated. Example: "2016-10-09T12:33:37.578138407Z".</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourceManagerPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ResourceManagerPolicySpec>, IStatus<V1beta1ResourceManagerPolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourceManagerPolicy";
    public const string KubeGroup = "resourcemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "resourcemanagerpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1ResourceManagerPolicySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ResourceManagerPolicyStatus? Status { get; set; }
}