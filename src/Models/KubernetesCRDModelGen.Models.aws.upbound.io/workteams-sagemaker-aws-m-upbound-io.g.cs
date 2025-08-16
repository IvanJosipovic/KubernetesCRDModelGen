using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.m.upbound.io;
/// <summary>Workteam is the Schema for the Workteams API. Provides a SageMaker AI Workteam resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkteamList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Workteam>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkteamList";
    public const string KubeGroup = "sagemaker.aws.m.upbound.io";
    public const string KubePluralName = "workteams";
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
    public IList<V1beta1Workteam> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolClient in cognitoidp to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolClient in cognitoidp to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelector
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
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserGroup in cognitoidp to populate userGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserGroup in cognitoidp to populate userGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelector
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
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelector
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
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicy? Policy { get; set; }
}

/// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinition
{
    /// <summary>An identifier for an application client. You must create the app client ID using Amazon Cognito.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Reference to a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdRef")]
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRef? ClientIdRef { get; set; }

    /// <summary>Selector for a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdSelector")]
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelector? ClientIdSelector { get; set; }

    /// <summary>An identifier for a user group.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }

    /// <summary>Reference to a UserGroup in cognitoidp to populate userGroup.</summary>
    [JsonPropertyName("userGroupRef")]
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRef? UserGroupRef { get; set; }

    /// <summary>Selector for a UserGroup in cognitoidp to populate userGroup.</summary>
    [JsonPropertyName("userGroupSelector")]
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelector? UserGroupSelector { get; set; }

    /// <summary>An identifier for a user pool. The user pool must be in the same region as the service that you are calling.</summary>
    [JsonPropertyName("userPool")]
    public string? UserPool { get; set; }

    /// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPool.</summary>
    [JsonPropertyName("userPoolRef")]
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRef? UserPoolRef { get; set; }

    /// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPool.</summary>
    [JsonPropertyName("userPoolSelector")]
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelector? UserPoolSelector { get; set; }
}

/// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinitionOidcMemberDefinition
{
    /// <summary>A list of comma separated strings that identifies user groups in your OIDC IdP. Each user group is made up of a group of private workers.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderMemberDefinition
{
    /// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("cognitoMemberDefinition")]
    public V1beta1WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition { get; set; }

    /// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("oidcMemberDefinition")]
    public V1beta1WorkteamSpecForProviderMemberDefinitionOidcMemberDefinition? OidcMemberDefinition { get; set; }
}

/// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderNotificationConfiguration
{
    /// <summary>The ARN for the SNS topic to which notifications should be published.</summary>
    [JsonPropertyName("notificationTopicArn")]
    public string? NotificationTopicArn { get; set; }
}

/// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints
{
    /// <summary>When SourceIp is Enabled the worker's IP address when a task is rendered in the worker portal is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. This IP address is checked by Amazon S3 and must match in order for the Amazon S3 resource to be rendered in the worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("sourceIp")]
    public string? SourceIp { get; set; }

    /// <summary>When VpcSourceIp is Enabled the worker's IP address when a task is rendered in private worker portal inside the VPC is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. To render the task successfully Amazon S3 checks that the presigned URL is being accessed over an Amazon S3 VPC Endpoint, and that the worker's IP address matches the IP address in the IAM policy. To learn more about configuring private worker portal, see Use Amazon VPC mode from a private worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("vpcSourceIp")]
    public string? VpcSourceIp { get; set; }
}

/// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderWorkerAccessConfigurationS3Presign
{
    /// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
    [JsonPropertyName("iamPolicyConstraints")]
    public V1beta1WorkteamSpecForProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints? IamPolicyConstraints { get; set; }
}

/// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderWorkerAccessConfiguration
{
    /// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
    [JsonPropertyName("s3Presign")]
    public V1beta1WorkteamSpecForProviderWorkerAccessConfigurationS3Presign? S3Presign { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderWorkforceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Workforce in sagemaker to populate workforceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderWorkforceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkteamSpecForProviderWorkforceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderWorkforceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Workforce in sagemaker to populate workforceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProviderWorkforceNameSelector
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
    public V1beta1WorkteamSpecForProviderWorkforceNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecForProvider
{
    /// <summary>A description of the work team.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A list of Member Definitions that contains objects that identify the workers that make up the work team. Workforces can be created using Amazon Cognito or your own OIDC Identity Provider (IdP). For private workforces created using Amazon Cognito use cognito_member_definition. For workforces created using your own OIDC identity provider (IdP) use oidc_member_definition. Do not provide input for both of these parameters in a single request. see Member Definition details below.</summary>
    [JsonPropertyName("memberDefinition")]
    public IList<V1beta1WorkteamSpecForProviderMemberDefinition>? MemberDefinition { get; set; }

    /// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
    [JsonPropertyName("notificationConfiguration")]
    public V1beta1WorkteamSpecForProviderNotificationConfiguration? NotificationConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
    [JsonPropertyName("workerAccessConfiguration")]
    public V1beta1WorkteamSpecForProviderWorkerAccessConfiguration? WorkerAccessConfiguration { get; set; }

    /// <summary>The name of the workforce.</summary>
    [JsonPropertyName("workforceName")]
    public string? WorkforceName { get; set; }

    /// <summary>Reference to a Workforce in sagemaker to populate workforceName.</summary>
    [JsonPropertyName("workforceNameRef")]
    public V1beta1WorkteamSpecForProviderWorkforceNameRef? WorkforceNameRef { get; set; }

    /// <summary>Selector for a Workforce in sagemaker to populate workforceName.</summary>
    [JsonPropertyName("workforceNameSelector")]
    public V1beta1WorkteamSpecForProviderWorkforceNameSelector? WorkforceNameSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolClient in cognitoidp to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolClient in cognitoidp to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelector
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
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserGroup in cognitoidp to populate userGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserGroup in cognitoidp to populate userGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelector
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
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelector
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
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicy? Policy { get; set; }
}

/// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinition
{
    /// <summary>An identifier for an application client. You must create the app client ID using Amazon Cognito.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Reference to a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdRef")]
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRef? ClientIdRef { get; set; }

    /// <summary>Selector for a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdSelector")]
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelector? ClientIdSelector { get; set; }

    /// <summary>An identifier for a user group.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }

    /// <summary>Reference to a UserGroup in cognitoidp to populate userGroup.</summary>
    [JsonPropertyName("userGroupRef")]
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRef? UserGroupRef { get; set; }

    /// <summary>Selector for a UserGroup in cognitoidp to populate userGroup.</summary>
    [JsonPropertyName("userGroupSelector")]
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelector? UserGroupSelector { get; set; }

    /// <summary>An identifier for a user pool. The user pool must be in the same region as the service that you are calling.</summary>
    [JsonPropertyName("userPool")]
    public string? UserPool { get; set; }

    /// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPool.</summary>
    [JsonPropertyName("userPoolRef")]
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRef? UserPoolRef { get; set; }

    /// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPool.</summary>
    [JsonPropertyName("userPoolSelector")]
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelector? UserPoolSelector { get; set; }
}

/// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinitionOidcMemberDefinition
{
    /// <summary>A list of comma separated strings that identifies user groups in your OIDC IdP. Each user group is made up of a group of private workers.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderMemberDefinition
{
    /// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("cognitoMemberDefinition")]
    public V1beta1WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition { get; set; }

    /// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("oidcMemberDefinition")]
    public V1beta1WorkteamSpecInitProviderMemberDefinitionOidcMemberDefinition? OidcMemberDefinition { get; set; }
}

/// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderNotificationConfiguration
{
    /// <summary>The ARN for the SNS topic to which notifications should be published.</summary>
    [JsonPropertyName("notificationTopicArn")]
    public string? NotificationTopicArn { get; set; }
}

/// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints
{
    /// <summary>When SourceIp is Enabled the worker's IP address when a task is rendered in the worker portal is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. This IP address is checked by Amazon S3 and must match in order for the Amazon S3 resource to be rendered in the worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("sourceIp")]
    public string? SourceIp { get; set; }

    /// <summary>When VpcSourceIp is Enabled the worker's IP address when a task is rendered in private worker portal inside the VPC is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. To render the task successfully Amazon S3 checks that the presigned URL is being accessed over an Amazon S3 VPC Endpoint, and that the worker's IP address matches the IP address in the IAM policy. To learn more about configuring private worker portal, see Use Amazon VPC mode from a private worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("vpcSourceIp")]
    public string? VpcSourceIp { get; set; }
}

/// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderWorkerAccessConfigurationS3Presign
{
    /// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
    [JsonPropertyName("iamPolicyConstraints")]
    public V1beta1WorkteamSpecInitProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints? IamPolicyConstraints { get; set; }
}

/// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderWorkerAccessConfiguration
{
    /// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
    [JsonPropertyName("s3Presign")]
    public V1beta1WorkteamSpecInitProviderWorkerAccessConfigurationS3Presign? S3Presign { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderWorkforceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Workforce in sagemaker to populate workforceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderWorkforceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkteamSpecInitProviderWorkforceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderWorkforceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Workforce in sagemaker to populate workforceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProviderWorkforceNameSelector
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
    public V1beta1WorkteamSpecInitProviderWorkforceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecInitProvider
{
    /// <summary>A description of the work team.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A list of Member Definitions that contains objects that identify the workers that make up the work team. Workforces can be created using Amazon Cognito or your own OIDC Identity Provider (IdP). For private workforces created using Amazon Cognito use cognito_member_definition. For workforces created using your own OIDC identity provider (IdP) use oidc_member_definition. Do not provide input for both of these parameters in a single request. see Member Definition details below.</summary>
    [JsonPropertyName("memberDefinition")]
    public IList<V1beta1WorkteamSpecInitProviderMemberDefinition>? MemberDefinition { get; set; }

    /// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
    [JsonPropertyName("notificationConfiguration")]
    public V1beta1WorkteamSpecInitProviderNotificationConfiguration? NotificationConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
    [JsonPropertyName("workerAccessConfiguration")]
    public V1beta1WorkteamSpecInitProviderWorkerAccessConfiguration? WorkerAccessConfiguration { get; set; }

    /// <summary>The name of the workforce.</summary>
    [JsonPropertyName("workforceName")]
    public string? WorkforceName { get; set; }

    /// <summary>Reference to a Workforce in sagemaker to populate workforceName.</summary>
    [JsonPropertyName("workforceNameRef")]
    public V1beta1WorkteamSpecInitProviderWorkforceNameRef? WorkforceNameRef { get; set; }

    /// <summary>Selector for a Workforce in sagemaker to populate workforceName.</summary>
    [JsonPropertyName("workforceNameSelector")]
    public V1beta1WorkteamSpecInitProviderWorkforceNameSelector? WorkforceNameSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpecProviderConfigRef
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
public partial class V1beta1WorkteamSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WorkteamSpec defines the desired state of Workteam</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WorkteamSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WorkteamSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkteamSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkteamSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamStatusAtProviderMemberDefinitionCognitoMemberDefinition
{
    /// <summary>An identifier for an application client. You must create the app client ID using Amazon Cognito.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>An identifier for a user group.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }

    /// <summary>An identifier for a user pool. The user pool must be in the same region as the service that you are calling.</summary>
    [JsonPropertyName("userPool")]
    public string? UserPool { get; set; }
}

/// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamStatusAtProviderMemberDefinitionOidcMemberDefinition
{
    /// <summary>A list of comma separated strings that identifies user groups in your OIDC IdP. Each user group is made up of a group of private workers.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamStatusAtProviderMemberDefinition
{
    /// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("cognitoMemberDefinition")]
    public V1beta1WorkteamStatusAtProviderMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition { get; set; }

    /// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("oidcMemberDefinition")]
    public V1beta1WorkteamStatusAtProviderMemberDefinitionOidcMemberDefinition? OidcMemberDefinition { get; set; }
}

/// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamStatusAtProviderNotificationConfiguration
{
    /// <summary>The ARN for the SNS topic to which notifications should be published.</summary>
    [JsonPropertyName("notificationTopicArn")]
    public string? NotificationTopicArn { get; set; }
}

/// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamStatusAtProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints
{
    /// <summary>When SourceIp is Enabled the worker's IP address when a task is rendered in the worker portal is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. This IP address is checked by Amazon S3 and must match in order for the Amazon S3 resource to be rendered in the worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("sourceIp")]
    public string? SourceIp { get; set; }

    /// <summary>When VpcSourceIp is Enabled the worker's IP address when a task is rendered in private worker portal inside the VPC is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. To render the task successfully Amazon S3 checks that the presigned URL is being accessed over an Amazon S3 VPC Endpoint, and that the worker's IP address matches the IP address in the IAM policy. To learn more about configuring private worker portal, see Use Amazon VPC mode from a private worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("vpcSourceIp")]
    public string? VpcSourceIp { get; set; }
}

/// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamStatusAtProviderWorkerAccessConfigurationS3Presign
{
    /// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
    [JsonPropertyName("iamPolicyConstraints")]
    public V1beta1WorkteamStatusAtProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints? IamPolicyConstraints { get; set; }
}

/// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamStatusAtProviderWorkerAccessConfiguration
{
    /// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
    [JsonPropertyName("s3Presign")]
    public V1beta1WorkteamStatusAtProviderWorkerAccessConfigurationS3Presign? S3Presign { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this Workteam.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A description of the work team.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the Workteam.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of Member Definitions that contains objects that identify the workers that make up the work team. Workforces can be created using Amazon Cognito or your own OIDC Identity Provider (IdP). For private workforces created using Amazon Cognito use cognito_member_definition. For workforces created using your own OIDC identity provider (IdP) use oidc_member_definition. Do not provide input for both of these parameters in a single request. see Member Definition details below.</summary>
    [JsonPropertyName("memberDefinition")]
    public IList<V1beta1WorkteamStatusAtProviderMemberDefinition>? MemberDefinition { get; set; }

    /// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
    [JsonPropertyName("notificationConfiguration")]
    public V1beta1WorkteamStatusAtProviderNotificationConfiguration? NotificationConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The subdomain for your OIDC Identity Provider.</summary>
    [JsonPropertyName("subdomain")]
    public string? Subdomain { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
    [JsonPropertyName("workerAccessConfiguration")]
    public V1beta1WorkteamStatusAtProviderWorkerAccessConfiguration? WorkerAccessConfiguration { get; set; }

    /// <summary>The name of the workforce.</summary>
    [JsonPropertyName("workforceName")]
    public string? WorkforceName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamStatusConditions
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

/// <summary>WorkteamStatus defines the observed state of Workteam.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkteamStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WorkteamStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkteamStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Workteam is the Schema for the Workteams API. Provides a SageMaker AI Workteam resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Workteam : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkteamSpec>, IStatus<V1beta1WorkteamStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Workteam";
    public const string KubeGroup = "sagemaker.aws.m.upbound.io";
    public const string KubePluralName = "workteams";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkteamSpec defines the desired state of Workteam</summary>
    [JsonPropertyName("spec")]
    public V1beta1WorkteamSpec Spec { get; set; }

    /// <summary>WorkteamStatus defines the observed state of Workteam.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkteamStatus? Status { get; set; }
}