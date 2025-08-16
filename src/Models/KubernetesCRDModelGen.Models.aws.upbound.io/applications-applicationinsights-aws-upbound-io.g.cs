using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.applicationinsights.aws.upbound.io;
/// <summary>Application is the Schema for the Applications API. Provides a CloudWatch Application Insights Application resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Application>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApplicationList";
    public const string KubeGroup = "applicationinsights.aws.upbound.io";
    public const string KubePluralName = "applications";
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
    public IList<V1beta1Application> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProvider
{
    /// <summary>Indicates whether Application Insights automatically configures unmonitored resources in the resource group.</summary>
    [JsonPropertyName("autoConfigEnabled")]
    public bool? AutoConfigEnabled { get; set; }

    /// <summary>Configures all of the resources in the resource group by applying the recommended configurations.</summary>
    [JsonPropertyName("autoCreate")]
    public bool? AutoCreate { get; set; }

    /// <summary>Indicates whether Application Insights can listen to CloudWatch events for the application resources, such as instance terminated, failed deployment, and others.</summary>
    [JsonPropertyName("cweMonitorEnabled")]
    public bool? CweMonitorEnabled { get; set; }

    /// <summary>Application Insights can create applications based on a resource group or on an account. To create an account-based application using all of the resources in the account, set this parameter to ACCOUNT_BASED.</summary>
    [JsonPropertyName("groupingType")]
    public string? GroupingType { get; set; }

    /// <summary>When set to true, creates opsItems for any problems detected on an application.</summary>
    [JsonPropertyName("opsCenterEnabled")]
    public bool? OpsCenterEnabled { get; set; }

    /// <summary>SNS topic provided to Application Insights that is associated to the created opsItem. Allows you to receive notifications for updates to the opsItem.</summary>
    [JsonPropertyName("opsItemSnsTopicArn")]
    public string? OpsItemSnsTopicArn { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProvider
{
    /// <summary>Indicates whether Application Insights automatically configures unmonitored resources in the resource group.</summary>
    [JsonPropertyName("autoConfigEnabled")]
    public bool? AutoConfigEnabled { get; set; }

    /// <summary>Configures all of the resources in the resource group by applying the recommended configurations.</summary>
    [JsonPropertyName("autoCreate")]
    public bool? AutoCreate { get; set; }

    /// <summary>Indicates whether Application Insights can listen to CloudWatch events for the application resources, such as instance terminated, failed deployment, and others.</summary>
    [JsonPropertyName("cweMonitorEnabled")]
    public bool? CweMonitorEnabled { get; set; }

    /// <summary>Application Insights can create applications based on a resource group or on an account. To create an account-based application using all of the resources in the account, set this parameter to ACCOUNT_BASED.</summary>
    [JsonPropertyName("groupingType")]
    public string? GroupingType { get; set; }

    /// <summary>When set to true, creates opsItems for any problems detected on an application.</summary>
    [JsonPropertyName("opsCenterEnabled")]
    public bool? OpsCenterEnabled { get; set; }

    /// <summary>SNS topic provided to Application Insights that is associated to the created opsItem. Allows you to receive notifications for updates to the opsItem.</summary>
    [JsonPropertyName("opsItemSnsTopicArn")]
    public string? OpsItemSnsTopicArn { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecProviderConfigRefPolicy
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
public partial class V1beta1ApplicationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ApplicationSpec defines the desired state of Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ApplicationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ApplicationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ApplicationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ApplicationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProvider
{
    /// <summary>ARN of the Application.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Indicates whether Application Insights automatically configures unmonitored resources in the resource group.</summary>
    [JsonPropertyName("autoConfigEnabled")]
    public bool? AutoConfigEnabled { get; set; }

    /// <summary>Configures all of the resources in the resource group by applying the recommended configurations.</summary>
    [JsonPropertyName("autoCreate")]
    public bool? AutoCreate { get; set; }

    /// <summary>Indicates whether Application Insights can listen to CloudWatch events for the application resources, such as instance terminated, failed deployment, and others.</summary>
    [JsonPropertyName("cweMonitorEnabled")]
    public bool? CweMonitorEnabled { get; set; }

    /// <summary>Application Insights can create applications based on a resource group or on an account. To create an account-based application using all of the resources in the account, set this parameter to ACCOUNT_BASED.</summary>
    [JsonPropertyName("groupingType")]
    public string? GroupingType { get; set; }

    /// <summary>Name of the resource group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>When set to true, creates opsItems for any problems detected on an application.</summary>
    [JsonPropertyName("opsCenterEnabled")]
    public bool? OpsCenterEnabled { get; set; }

    /// <summary>SNS topic provided to Application Insights that is associated to the created opsItem. Allows you to receive notifications for updates to the opsItem.</summary>
    [JsonPropertyName("opsItemSnsTopicArn")]
    public string? OpsItemSnsTopicArn { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusConditions
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

/// <summary>ApplicationStatus defines the observed state of Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ApplicationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Application is the Schema for the Applications API. Provides a CloudWatch Application Insights Application resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Application : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApplicationSpec>, IStatus<V1beta1ApplicationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Application";
    public const string KubeGroup = "applicationinsights.aws.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationSpec defines the desired state of Application</summary>
    [JsonPropertyName("spec")]
    public V1beta1ApplicationSpec Spec { get; set; }

    /// <summary>ApplicationStatus defines the observed state of Application.</summary>
    [JsonPropertyName("status")]
    public V1beta1ApplicationStatus? Status { get; set; }
}