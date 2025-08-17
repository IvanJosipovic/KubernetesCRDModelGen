using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ssm.aws.m.upbound.io;
#nullable enable
/// <summary>Parameter is the Schema for the Parameters API. Provides a SSM Parameter resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ParameterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Parameter>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ParameterList";
    public const string KubeGroup = "ssm.aws.m.upbound.io";
    public const string KubePluralName = "parameters";
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
    public IList<V1beta1Parameter> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Value of the parameter.15 and later, this may require additional configuration handling for certain scenarios.15 Upgrade Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ParameterSpecForProviderValueSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Value of the parameter. Additionally, write-only values are never stored to state. value_wo_version can be used to trigger an update and is required with this argument.15 and later, this may require additional configuration handling for certain scenarios.15 Upgrade Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ParameterSpecForProviderValueWoSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ParameterSpecForProvider
{
    /// <summary>Regular expression used to validate the parameter value.</summary>
    [JsonPropertyName("allowedPattern")]
    public string? AllowedPattern { get; set; }

    /// <summary>ARN of the parameter.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Data type of the parameter. Valid values: text, aws:ssm:integration and aws:ec2:image for AMI format, see the Native parameter support for Amazon Machine Image IDs.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Description of the parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Value of the parameter. This argument is not valid with a type of SecureString.</summary>
    [JsonPropertyName("insecureValue")]
    public string? InsecureValue { get; set; }

    /// <summary>KMS key ID or ARN for encrypting a SecureString.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Overwrite an existing parameter. Lifecycle rules should be used to manage non-standard update behavior.</summary>
    [JsonPropertyName("overwrite")]
    public bool? Overwrite { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Parameter tier to assign to the parameter. If not specified, will use the default parameter tier for the region. Valid tiers are Standard, Advanced, and Intelligent-Tiering. Downgrading an Advanced tier parameter to Standard will recreate the resource. For more information on parameter tiers, see the AWS SSM Parameter tier comparison and guide.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Type of the parameter. Valid types are String, StringList and SecureString.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value of the parameter.15 and later, this may require additional configuration handling for certain scenarios.15 Upgrade Guide.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ParameterSpecForProviderValueSecretRef? ValueSecretRef { get; set; }

    /// <summary>Value of the parameter. Additionally, write-only values are never stored to state. value_wo_version can be used to trigger an update and is required with this argument.15 and later, this may require additional configuration handling for certain scenarios.15 Upgrade Guide.</summary>
    [JsonPropertyName("valueWoSecretRef")]
    public V1beta1ParameterSpecForProviderValueWoSecretRef? ValueWoSecretRef { get; set; }

    /// <summary>Used together with value_wo to trigger an update. Increment this value when an update to the value_wo is required.</summary>
    [JsonPropertyName("valueWoVersion")]
    public double? ValueWoVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Value of the parameter.15 and later, this may require additional configuration handling for certain scenarios.15 Upgrade Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ParameterSpecInitProviderValueSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Value of the parameter. Additionally, write-only values are never stored to state. value_wo_version can be used to trigger an update and is required with this argument.15 and later, this may require additional configuration handling for certain scenarios.15 Upgrade Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ParameterSpecInitProviderValueWoSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ParameterSpecInitProvider
{
    /// <summary>Regular expression used to validate the parameter value.</summary>
    [JsonPropertyName("allowedPattern")]
    public string? AllowedPattern { get; set; }

    /// <summary>ARN of the parameter.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Data type of the parameter. Valid values: text, aws:ssm:integration and aws:ec2:image for AMI format, see the Native parameter support for Amazon Machine Image IDs.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Description of the parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Value of the parameter. This argument is not valid with a type of SecureString.</summary>
    [JsonPropertyName("insecureValue")]
    public string? InsecureValue { get; set; }

    /// <summary>KMS key ID or ARN for encrypting a SecureString.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Overwrite an existing parameter. Lifecycle rules should be used to manage non-standard update behavior.</summary>
    [JsonPropertyName("overwrite")]
    public bool? Overwrite { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Parameter tier to assign to the parameter. If not specified, will use the default parameter tier for the region. Valid tiers are Standard, Advanced, and Intelligent-Tiering. Downgrading an Advanced tier parameter to Standard will recreate the resource. For more information on parameter tiers, see the AWS SSM Parameter tier comparison and guide.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Type of the parameter. Valid types are String, StringList and SecureString.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value of the parameter.15 and later, this may require additional configuration handling for certain scenarios.15 Upgrade Guide.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ParameterSpecInitProviderValueSecretRef? ValueSecretRef { get; set; }

    /// <summary>Value of the parameter. Additionally, write-only values are never stored to state. value_wo_version can be used to trigger an update and is required with this argument.15 and later, this may require additional configuration handling for certain scenarios.15 Upgrade Guide.</summary>
    [JsonPropertyName("valueWoSecretRef")]
    public V1beta1ParameterSpecInitProviderValueWoSecretRef? ValueWoSecretRef { get; set; }

    /// <summary>Used together with value_wo to trigger an update. Increment this value when an update to the value_wo is required.</summary>
    [JsonPropertyName("valueWoVersion")]
    public double? ValueWoVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ParameterSpecProviderConfigRef
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
public partial class V1beta1ParameterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ParameterSpec defines the desired state of Parameter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ParameterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ParameterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ParameterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ParameterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ParameterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ParameterStatusAtProvider
{
    /// <summary>Regular expression used to validate the parameter value.</summary>
    [JsonPropertyName("allowedPattern")]
    public string? AllowedPattern { get; set; }

    /// <summary>ARN of the parameter.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Data type of the parameter. Valid values: text, aws:ssm:integration and aws:ec2:image for AMI format, see the Native parameter support for Amazon Machine Image IDs.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Description of the parameter.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Indicates whether the resource has a value_wo set.</summary>
    [JsonPropertyName("hasValueWo")]
    public bool? HasValueWo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Value of the parameter. This argument is not valid with a type of SecureString.</summary>
    [JsonPropertyName("insecureValue")]
    public string? InsecureValue { get; set; }

    /// <summary>KMS key ID or ARN for encrypting a SecureString.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>Overwrite an existing parameter. Lifecycle rules should be used to manage non-standard update behavior.</summary>
    [JsonPropertyName("overwrite")]
    public bool? Overwrite { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Parameter tier to assign to the parameter. If not specified, will use the default parameter tier for the region. Valid tiers are Standard, Advanced, and Intelligent-Tiering. Downgrading an Advanced tier parameter to Standard will recreate the resource. For more information on parameter tiers, see the AWS SSM Parameter tier comparison and guide.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Type of the parameter. Valid types are String, StringList and SecureString.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Used together with value_wo to trigger an update. Increment this value when an update to the value_wo is required.</summary>
    [JsonPropertyName("valueWoVersion")]
    public double? ValueWoVersion { get; set; }

    /// <summary>Version of the parameter.</summary>
    [JsonPropertyName("version")]
    public double? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ParameterStatusConditions
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
/// <summary>ParameterStatus defines the observed state of Parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ParameterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ParameterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ParameterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameter is the Schema for the Parameters API. Provides a SSM Parameter resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Parameter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ParameterSpec>, IStatus<V1beta1ParameterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Parameter";
    public const string KubeGroup = "ssm.aws.m.upbound.io";
    public const string KubePluralName = "parameters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ParameterSpec defines the desired state of Parameter</summary>
    [JsonPropertyName("spec")]
    public V1beta1ParameterSpec Spec { get; set; }

    /// <summary>ParameterStatus defines the observed state of Parameter.</summary>
    [JsonPropertyName("status")]
    public V1beta1ParameterStatus? Status { get; set; }
}
#nullable disable
