using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.costmanagement.azure.m.upbound.io;
/// <summary>CostAnomalyAlert is the Schema for the CostAnomalyAlerts API. Manages a Cost Anomaly Alert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CostAnomalyAlertList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CostAnomalyAlert>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CostAnomalyAlertList";
    public const string KubeGroup = "costmanagement.azure.m.upbound.io";
    public const string KubePluralName = "costanomalyalerts";
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
    public IList<V1beta1CostAnomalyAlert> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CostAnomalyAlertSpecForProvider
{
    /// <summary>The display name which should be used for this Cost Anomaly Alert.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies a list of email addresses which the Anomaly Alerts are send to.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>The email subject of the Cost Anomaly Alerts. Maximum length of the subject is 70.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>The message of the Cost Anomaly Alert. Maximum length of the message is 250.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The email address of the point of contact that should get the unsubscribe requests and notification emails.</summary>
    [JsonPropertyName("notificationEmail")]
    public string? NotificationEmail { get; set; }

    /// <summary>The ID of the Subscription this Cost Anomaly Alert is scoped to. Changing this forces a new resource to be created. When not supplied this defaults to the subscription configured in the provider.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CostAnomalyAlertSpecInitProvider
{
    /// <summary>The display name which should be used for this Cost Anomaly Alert.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies a list of email addresses which the Anomaly Alerts are send to.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>The email subject of the Cost Anomaly Alerts. Maximum length of the subject is 70.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>The message of the Cost Anomaly Alert. Maximum length of the message is 250.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The email address of the point of contact that should get the unsubscribe requests and notification emails.</summary>
    [JsonPropertyName("notificationEmail")]
    public string? NotificationEmail { get; set; }

    /// <summary>The ID of the Subscription this Cost Anomaly Alert is scoped to. Changing this forces a new resource to be created. When not supplied this defaults to the subscription configured in the provider.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CostAnomalyAlertSpecProviderConfigRef
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
public partial class V1beta1CostAnomalyAlertSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>CostAnomalyAlertSpec defines the desired state of CostAnomalyAlert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CostAnomalyAlertSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1CostAnomalyAlertSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1CostAnomalyAlertSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CostAnomalyAlertSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CostAnomalyAlertSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CostAnomalyAlertStatusAtProvider
{
    /// <summary>The display name which should be used for this Cost Anomaly Alert.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies a list of email addresses which the Anomaly Alerts are send to.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>The email subject of the Cost Anomaly Alerts. Maximum length of the subject is 70.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>The ID of the Cost Anomaly Alert.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The message of the Cost Anomaly Alert. Maximum length of the message is 250.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The email address of the point of contact that should get the unsubscribe requests and notification emails.</summary>
    [JsonPropertyName("notificationEmail")]
    public string? NotificationEmail { get; set; }

    /// <summary>The ID of the Subscription this Cost Anomaly Alert is scoped to. Changing this forces a new resource to be created. When not supplied this defaults to the subscription configured in the provider.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CostAnomalyAlertStatusConditions
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

/// <summary>CostAnomalyAlertStatus defines the observed state of CostAnomalyAlert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CostAnomalyAlertStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1CostAnomalyAlertStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CostAnomalyAlertStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CostAnomalyAlert is the Schema for the CostAnomalyAlerts API. Manages a Cost Anomaly Alert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CostAnomalyAlert : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CostAnomalyAlertSpec>, IStatus<V1beta1CostAnomalyAlertStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CostAnomalyAlert";
    public const string KubeGroup = "costmanagement.azure.m.upbound.io";
    public const string KubePluralName = "costanomalyalerts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CostAnomalyAlertSpec defines the desired state of CostAnomalyAlert</summary>
    [JsonPropertyName("spec")]
    public V1beta1CostAnomalyAlertSpec Spec { get; set; }

    /// <summary>CostAnomalyAlertStatus defines the observed state of CostAnomalyAlert.</summary>
    [JsonPropertyName("status")]
    public V1beta1CostAnomalyAlertStatus? Status { get; set; }
}