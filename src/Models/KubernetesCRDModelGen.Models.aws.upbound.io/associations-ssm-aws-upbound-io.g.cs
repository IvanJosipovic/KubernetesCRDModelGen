using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ssm.aws.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecForProviderNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Document in ssm to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecForProviderNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AssociationSpecForProviderNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecForProviderNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Document in ssm to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecForProviderNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AssociationSpecForProviderNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecForProviderOutputLocation
{
    /// <summary>The S3 bucket name.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>The S3 bucket prefix. Results stored in the root if not configured.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }

    /// <summary>The S3 bucket region.</summary>
    [JsonPropertyName("s3Region")]
    public string? S3Region { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecForProviderTargetsValuesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecForProviderTargetsValuesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AssociationSpecForProviderTargetsValuesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecForProviderTargetsValuesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Instance in ec2 to populate values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecForProviderTargetsValuesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AssociationSpecForProviderTargetsValuesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecForProviderTargets
{
    /// <summary>Either InstanceIds or tag:Tag Name to specify an EC2 tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>User-defined criteria that maps to Key. A list of instance IDs or tag values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }

    /// <summary>References to Instance in ec2 to populate values.</summary>
    [JsonPropertyName("valuesRefs")]
    public IList<V1beta1AssociationSpecForProviderTargetsValuesRefs>? ValuesRefs { get; set; }

    /// <summary>Selector for a list of Instance in ec2 to populate values.</summary>
    [JsonPropertyName("valuesSelector")]
    public V1beta1AssociationSpecForProviderTargetsValuesSelector? ValuesSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecForProvider
{
    /// <summary>By default, when you create a new or update associations, the system runs it immediately and then according to the schedule you specified. Enable this option if you do not want an association to run immediately after you create or update it. This parameter is not supported for rate expressions. Default: false.</summary>
    [JsonPropertyName("applyOnlyAtCronInterval")]
    public bool? ApplyOnlyAtCronInterval { get; set; }

    /// <summary>The descriptive name for the association.</summary>
    [JsonPropertyName("associationName")]
    public string? AssociationName { get; set; }

    /// <summary>Specify the target for the association. This target is required for associations that use an Automation document and target resources by using rate controls. This should be set to the SSM document parameter that will define how your automation will branch out.</summary>
    [JsonPropertyName("automationTargetParameterName")]
    public string? AutomationTargetParameterName { get; set; }

    /// <summary>The compliance severity for the association. Can be one of the following: UNSPECIFIED, LOW, MEDIUM, HIGH or CRITICAL</summary>
    [JsonPropertyName("complianceSeverity")]
    public string? ComplianceSeverity { get; set; }

    /// <summary>The document version you want to associate with the target(s). Can be a specific version or the default version.</summary>
    [JsonPropertyName("documentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary>The maximum number of targets allowed to run the association at the same time. You can specify a number, for example 10, or a percentage of the target set, for example 10%.</summary>
    [JsonPropertyName("maxConcurrency")]
    public string? MaxConcurrency { get; set; }

    /// <summary>The number of errors that are allowed before the system stops sending requests to run the association on additional targets. You can specify a number, for example 10, or a percentage of the target set, for example 10%. If you specify a threshold of 3, the stop command is sent when the fourth error is returned. If you specify a threshold of 10% for 50 associations, the stop command is sent when the sixth error is returned.</summary>
    [JsonPropertyName("maxErrors")]
    public string? MaxErrors { get; set; }

    /// <summary>The name of the SSM document to apply.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Document in ssm to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1AssociationSpecForProviderNameRef? NameRef { get; set; }

    /// <summary>Selector for a Document in ssm to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1AssociationSpecForProviderNameSelector? NameSelector { get; set; }

    /// <summary>An output location block. Output Location is documented below.</summary>
    [JsonPropertyName("outputLocation")]
    public IList<V1beta1AssociationSpecForProviderOutputLocation>? OutputLocation { get; set; }

    /// <summary>A block of arbitrary string parameters to pass to the SSM document.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A cron or rate expression that specifies when the association runs.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>The mode for generating association compliance. You can specify AUTO or MANUAL.</summary>
    [JsonPropertyName("syncCompliance")]
    public string? SyncCompliance { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A block containing the targets of the SSM association. Targets are documented below. AWS currently supports a maximum of 5 targets.</summary>
    [JsonPropertyName("targets")]
    public IList<V1beta1AssociationSpecForProviderTargets>? Targets { get; set; }

    /// <summary>The number of seconds to wait for the association status to be Success. If Success status is not reached within the given time, create opration will fail.</summary>
    [JsonPropertyName("waitForSuccessTimeoutSeconds")]
    public double? WaitForSuccessTimeoutSeconds { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecInitProviderNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Document in ssm to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecInitProviderNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AssociationSpecInitProviderNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecInitProviderNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Document in ssm to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecInitProviderNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AssociationSpecInitProviderNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecInitProviderOutputLocation
{
    /// <summary>The S3 bucket name.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>The S3 bucket prefix. Results stored in the root if not configured.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }

    /// <summary>The S3 bucket region.</summary>
    [JsonPropertyName("s3Region")]
    public string? S3Region { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecInitProviderTargetsValuesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecInitProviderTargetsValuesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AssociationSpecInitProviderTargetsValuesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecInitProviderTargetsValuesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Instance in ec2 to populate values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecInitProviderTargetsValuesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AssociationSpecInitProviderTargetsValuesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecInitProviderTargets
{
    /// <summary>Either InstanceIds or tag:Tag Name to specify an EC2 tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>User-defined criteria that maps to Key. A list of instance IDs or tag values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }

    /// <summary>References to Instance in ec2 to populate values.</summary>
    [JsonPropertyName("valuesRefs")]
    public IList<V1beta1AssociationSpecInitProviderTargetsValuesRefs>? ValuesRefs { get; set; }

    /// <summary>Selector for a list of Instance in ec2 to populate values.</summary>
    [JsonPropertyName("valuesSelector")]
    public V1beta1AssociationSpecInitProviderTargetsValuesSelector? ValuesSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecInitProvider
{
    /// <summary>By default, when you create a new or update associations, the system runs it immediately and then according to the schedule you specified. Enable this option if you do not want an association to run immediately after you create or update it. This parameter is not supported for rate expressions. Default: false.</summary>
    [JsonPropertyName("applyOnlyAtCronInterval")]
    public bool? ApplyOnlyAtCronInterval { get; set; }

    /// <summary>The descriptive name for the association.</summary>
    [JsonPropertyName("associationName")]
    public string? AssociationName { get; set; }

    /// <summary>Specify the target for the association. This target is required for associations that use an Automation document and target resources by using rate controls. This should be set to the SSM document parameter that will define how your automation will branch out.</summary>
    [JsonPropertyName("automationTargetParameterName")]
    public string? AutomationTargetParameterName { get; set; }

    /// <summary>The compliance severity for the association. Can be one of the following: UNSPECIFIED, LOW, MEDIUM, HIGH or CRITICAL</summary>
    [JsonPropertyName("complianceSeverity")]
    public string? ComplianceSeverity { get; set; }

    /// <summary>The document version you want to associate with the target(s). Can be a specific version or the default version.</summary>
    [JsonPropertyName("documentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary>The maximum number of targets allowed to run the association at the same time. You can specify a number, for example 10, or a percentage of the target set, for example 10%.</summary>
    [JsonPropertyName("maxConcurrency")]
    public string? MaxConcurrency { get; set; }

    /// <summary>The number of errors that are allowed before the system stops sending requests to run the association on additional targets. You can specify a number, for example 10, or a percentage of the target set, for example 10%. If you specify a threshold of 3, the stop command is sent when the fourth error is returned. If you specify a threshold of 10% for 50 associations, the stop command is sent when the sixth error is returned.</summary>
    [JsonPropertyName("maxErrors")]
    public string? MaxErrors { get; set; }

    /// <summary>The name of the SSM document to apply.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a Document in ssm to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1AssociationSpecInitProviderNameRef? NameRef { get; set; }

    /// <summary>Selector for a Document in ssm to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta1AssociationSpecInitProviderNameSelector? NameSelector { get; set; }

    /// <summary>An output location block. Output Location is documented below.</summary>
    [JsonPropertyName("outputLocation")]
    public IList<V1beta1AssociationSpecInitProviderOutputLocation>? OutputLocation { get; set; }

    /// <summary>A block of arbitrary string parameters to pass to the SSM document.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>A cron or rate expression that specifies when the association runs.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>The mode for generating association compliance. You can specify AUTO or MANUAL.</summary>
    [JsonPropertyName("syncCompliance")]
    public string? SyncCompliance { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A block containing the targets of the SSM association. Targets are documented below. AWS currently supports a maximum of 5 targets.</summary>
    [JsonPropertyName("targets")]
    public IList<V1beta1AssociationSpecInitProviderTargets>? Targets { get; set; }

    /// <summary>The number of seconds to wait for the association status to be Success. If Success status is not reached within the given time, create opration will fail.</summary>
    [JsonPropertyName("waitForSuccessTimeoutSeconds")]
    public double? WaitForSuccessTimeoutSeconds { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecProviderConfigRefPolicy
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
public partial class V1beta1AssociationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AssociationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AssociationSpec defines the desired state of Association</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AssociationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AssociationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AssociationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AssociationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationStatusAtProviderOutputLocation
{
    /// <summary>The S3 bucket name.</summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>The S3 bucket prefix. Results stored in the root if not configured.</summary>
    [JsonPropertyName("s3KeyPrefix")]
    public string? S3KeyPrefix { get; set; }

    /// <summary>The S3 bucket region.</summary>
    [JsonPropertyName("s3Region")]
    public string? S3Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationStatusAtProviderTargets
{
    /// <summary>Either InstanceIds or tag:Tag Name to specify an EC2 tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>User-defined criteria that maps to Key. A list of instance IDs or tag values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationStatusAtProvider
{
    /// <summary>By default, when you create a new or update associations, the system runs it immediately and then according to the schedule you specified. Enable this option if you do not want an association to run immediately after you create or update it. This parameter is not supported for rate expressions. Default: false.</summary>
    [JsonPropertyName("applyOnlyAtCronInterval")]
    public bool? ApplyOnlyAtCronInterval { get; set; }

    /// <summary>The ARN of the SSM association</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the SSM association.</summary>
    [JsonPropertyName("associationId")]
    public string? AssociationId { get; set; }

    /// <summary>The descriptive name for the association.</summary>
    [JsonPropertyName("associationName")]
    public string? AssociationName { get; set; }

    /// <summary>Specify the target for the association. This target is required for associations that use an Automation document and target resources by using rate controls. This should be set to the SSM document parameter that will define how your automation will branch out.</summary>
    [JsonPropertyName("automationTargetParameterName")]
    public string? AutomationTargetParameterName { get; set; }

    /// <summary>The compliance severity for the association. Can be one of the following: UNSPECIFIED, LOW, MEDIUM, HIGH or CRITICAL</summary>
    [JsonPropertyName("complianceSeverity")]
    public string? ComplianceSeverity { get; set; }

    /// <summary>The document version you want to associate with the target(s). Can be a specific version or the default version.</summary>
    [JsonPropertyName("documentVersion")]
    public string? DocumentVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The maximum number of targets allowed to run the association at the same time. You can specify a number, for example 10, or a percentage of the target set, for example 10%.</summary>
    [JsonPropertyName("maxConcurrency")]
    public string? MaxConcurrency { get; set; }

    /// <summary>The number of errors that are allowed before the system stops sending requests to run the association on additional targets. You can specify a number, for example 10, or a percentage of the target set, for example 10%. If you specify a threshold of 3, the stop command is sent when the fourth error is returned. If you specify a threshold of 10% for 50 associations, the stop command is sent when the sixth error is returned.</summary>
    [JsonPropertyName("maxErrors")]
    public string? MaxErrors { get; set; }

    /// <summary>The name of the SSM document to apply.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An output location block. Output Location is documented below.</summary>
    [JsonPropertyName("outputLocation")]
    public IList<V1beta1AssociationStatusAtProviderOutputLocation>? OutputLocation { get; set; }

    /// <summary>A block of arbitrary string parameters to pass to the SSM document.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A cron or rate expression that specifies when the association runs.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>The mode for generating association compliance. You can specify AUTO or MANUAL.</summary>
    [JsonPropertyName("syncCompliance")]
    public string? SyncCompliance { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>A block containing the targets of the SSM association. Targets are documented below. AWS currently supports a maximum of 5 targets.</summary>
    [JsonPropertyName("targets")]
    public IList<V1beta1AssociationStatusAtProviderTargets>? Targets { get; set; }

    /// <summary>The number of seconds to wait for the association status to be Success. If Success status is not reached within the given time, create opration will fail.</summary>
    [JsonPropertyName("waitForSuccessTimeoutSeconds")]
    public double? WaitForSuccessTimeoutSeconds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationStatusConditions
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

/// <summary>AssociationStatus defines the observed state of Association.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AssociationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AssociationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AssociationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Association is the Schema for the Associations API. Associates an SSM Document to an instance or EC2 tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Association : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AssociationSpec>, IStatus<V1beta1AssociationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Association";
    public const string KubeGroup = "ssm.aws.upbound.io";
    public const string KubePluralName = "associations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AssociationSpec defines the desired state of Association</summary>
    [JsonPropertyName("spec")]
    public V1beta1AssociationSpec Spec { get; set; }

    /// <summary>AssociationStatus defines the observed state of Association.</summary>
    [JsonPropertyName("status")]
    public V1beta1AssociationStatus? Status { get; set; }
}

/// <summary>Association is the Schema for the Associations API. Associates an SSM Document to an instance or EC2 tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AssociationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Association>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AssociationList";
    public const string KubeGroup = "ssm.aws.upbound.io";
    public const string KubePluralName = "associations";
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
    public IList<V1beta1Association> Items { get; set; }
}