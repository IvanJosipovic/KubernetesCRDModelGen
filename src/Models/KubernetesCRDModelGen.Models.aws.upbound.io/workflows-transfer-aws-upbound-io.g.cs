using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.transfer.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsCopyStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsCustomStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>The ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsDecryptStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsDeleteStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsTagStepDetailsTags
{
    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionStepsTagStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsTagStepDetailsTags>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderOnExceptionSteps
{
    /// <summary>Details for a step that performs a file copy. See Copy Step Details below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsCopyStepDetails>? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function.</summary>
    [JsonPropertyName("customStepDetails")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsCustomStepDetails>? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsDecryptStepDetails>? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsDeleteStepDetails>? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags.</summary>
    [JsonPropertyName("tagStepDetails")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionStepsTagStepDetails>? TagStepDetails { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsCopyStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowSpecForProviderStepsCopyStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsCustomStepDetailsTargetRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsCustomStepDetailsTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkflowSpecForProviderStepsCustomStepDetailsTargetRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsCustomStepDetailsTargetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsCustomStepDetailsTargetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkflowSpecForProviderStepsCustomStepDetailsTargetSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsCustomStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>The ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Reference to a Function in lambda to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta1WorkflowSpecForProviderStepsCustomStepDetailsTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta1WorkflowSpecForProviderStepsCustomStepDetailsTargetSelector? TargetSelector { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsDecryptStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowSpecForProviderStepsDecryptStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsDeleteStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsTagStepDetailsTags
{
    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderStepsTagStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1WorkflowSpecForProviderStepsTagStepDetailsTags>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProviderSteps
{
    /// <summary>Details for a step that performs a file copy. See Copy Step Details below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public IList<V1beta1WorkflowSpecForProviderStepsCopyStepDetails>? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function.</summary>
    [JsonPropertyName("customStepDetails")]
    public IList<V1beta1WorkflowSpecForProviderStepsCustomStepDetails>? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public IList<V1beta1WorkflowSpecForProviderStepsDecryptStepDetails>? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public IList<V1beta1WorkflowSpecForProviderStepsDeleteStepDetails>? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags.</summary>
    [JsonPropertyName("tagStepDetails")]
    public IList<V1beta1WorkflowSpecForProviderStepsTagStepDetails>? TagStepDetails { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecForProvider
{
    /// <summary>A textual description for the workflow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the steps (actions) to take if errors are encountered during execution of the workflow. See Workflow Steps below.</summary>
    [JsonPropertyName("onExceptionSteps")]
    public IList<V1beta1WorkflowSpecForProviderOnExceptionSteps>? OnExceptionSteps { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Specifies the details for the steps that are in the specified workflow. See Workflow Steps below.</summary>
    [JsonPropertyName("steps")]
    public IList<V1beta1WorkflowSpecForProviderSteps>? Steps { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsCopyStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsCustomStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>The ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsDeleteStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsTagStepDetailsTags
{
    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionStepsTagStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsTagStepDetailsTags>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderOnExceptionSteps
{
    /// <summary>Details for a step that performs a file copy. See Copy Step Details below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsCopyStepDetails>? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function.</summary>
    [JsonPropertyName("customStepDetails")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsCustomStepDetails>? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsDecryptStepDetails>? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsDeleteStepDetails>? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags.</summary>
    [JsonPropertyName("tagStepDetails")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionStepsTagStepDetails>? TagStepDetails { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsCopyStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderStepsCopyStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsCustomStepDetailsTargetRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsCustomStepDetailsTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkflowSpecInitProviderStepsCustomStepDetailsTargetRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsCustomStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>The ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Reference to a Function in lambda to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta1WorkflowSpecInitProviderStepsCustomStepDetailsTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta1WorkflowSpecInitProviderStepsCustomStepDetailsTargetSelector? TargetSelector { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsDecryptStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowSpecInitProviderStepsDecryptStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsDeleteStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsTagStepDetailsTags
{
    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderStepsTagStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1WorkflowSpecInitProviderStepsTagStepDetailsTags>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProviderSteps
{
    /// <summary>Details for a step that performs a file copy. See Copy Step Details below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public IList<V1beta1WorkflowSpecInitProviderStepsCopyStepDetails>? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function.</summary>
    [JsonPropertyName("customStepDetails")]
    public IList<V1beta1WorkflowSpecInitProviderStepsCustomStepDetails>? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public IList<V1beta1WorkflowSpecInitProviderStepsDecryptStepDetails>? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public IList<V1beta1WorkflowSpecInitProviderStepsDeleteStepDetails>? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags.</summary>
    [JsonPropertyName("tagStepDetails")]
    public IList<V1beta1WorkflowSpecInitProviderStepsTagStepDetails>? TagStepDetails { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecInitProvider
{
    /// <summary>A textual description for the workflow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the steps (actions) to take if errors are encountered during execution of the workflow. See Workflow Steps below.</summary>
    [JsonPropertyName("onExceptionSteps")]
    public IList<V1beta1WorkflowSpecInitProviderOnExceptionSteps>? OnExceptionSteps { get; set; }

    /// <summary>Specifies the details for the steps that are in the specified workflow. See Workflow Steps below.</summary>
    [JsonPropertyName("steps")]
    public IList<V1beta1WorkflowSpecInitProviderSteps>? Steps { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecProviderConfigRefPolicy
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
public partial class V1beta1WorkflowSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkflowSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1WorkflowSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkflowSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1WorkflowSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1WorkflowSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1WorkflowSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>WorkflowSpec defines the desired state of Workflow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WorkflowSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WorkflowSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkflowSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1WorkflowSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkflowSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsCopyStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsCopyStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsCustomStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>The ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsDeleteStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsTagStepDetailsTags
{
    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionStepsTagStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsTagStepDetailsTags>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderOnExceptionSteps
{
    /// <summary>Details for a step that performs a file copy. See Copy Step Details below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsCopyStepDetails>? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function.</summary>
    [JsonPropertyName("customStepDetails")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsCustomStepDetails>? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsDecryptStepDetails>? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsDeleteStepDetails>? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags.</summary>
    [JsonPropertyName("tagStepDetails")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionStepsTagStepDetails>? TagStepDetails { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsCopyStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderStepsCopyStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsCustomStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>The ARN for the lambda function that is being called.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Timeout, in seconds, for the step.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation
{
    /// <summary>The ID of the file system, assigned by Amazon EFS.</summary>
    [JsonPropertyName("fileSystemId")]
    public string? FileSystemId { get; set; }

    /// <summary>The pathname for the folder being used by a workflow.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation
{
    /// <summary>Specifies the S3 bucket for the customer input file.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocation
{
    /// <summary>Specifies the details for the EFS file being copied.</summary>
    [JsonPropertyName("efsFileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation>? EfsFileLocation { get; set; }

    /// <summary>Specifies the details for the S3 file being copied.</summary>
    [JsonPropertyName("s3FileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocationS3FileLocation>? S3FileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsDecryptStepDetails
{
    /// <summary>Specifies the location for the file being copied. Use ${Transfer:username} in this field to parametrize the destination prefix by username.</summary>
    [JsonPropertyName("destinationFileLocation")]
    public IList<V1beta1WorkflowStatusAtProviderStepsDecryptStepDetailsDestinationFileLocation>? DestinationFileLocation { get; set; }

    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A flag that indicates whether or not to overwrite an existing file of the same name. The default is FALSE. Valid values are TRUE and FALSE.</summary>
    [JsonPropertyName("overwriteExisting")]
    public string? OverwriteExisting { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsDeleteStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsTagStepDetailsTags
{
    /// <summary>The name assigned to the file when it was created in S3. You use the object key to retrieve the object.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value that corresponds to the key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderStepsTagStepDetails
{
    /// <summary>The name of the step, used as an identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies which file to use as input to the workflow step: either the output from the previous step, or the originally uploaded file for the workflow. Enter ${previous.file} to use the previous file as the input. In this case, this workflow step uses the output file from the previous workflow step as input. This is the default value. Enter ${original.file} to use the originally-uploaded file location as input for this step.</summary>
    [JsonPropertyName("sourceFileLocation")]
    public string? SourceFileLocation { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IList<V1beta1WorkflowStatusAtProviderStepsTagStepDetailsTags>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProviderSteps
{
    /// <summary>Details for a step that performs a file copy. See Copy Step Details below.</summary>
    [JsonPropertyName("copyStepDetails")]
    public IList<V1beta1WorkflowStatusAtProviderStepsCopyStepDetails>? CopyStepDetails { get; set; }

    /// <summary>Details for a step that invokes a lambda function.</summary>
    [JsonPropertyName("customStepDetails")]
    public IList<V1beta1WorkflowStatusAtProviderStepsCustomStepDetails>? CustomStepDetails { get; set; }

    /// <summary>Details for a step that decrypts the file.</summary>
    [JsonPropertyName("decryptStepDetails")]
    public IList<V1beta1WorkflowStatusAtProviderStepsDecryptStepDetails>? DecryptStepDetails { get; set; }

    /// <summary>Details for a step that deletes the file.</summary>
    [JsonPropertyName("deleteStepDetails")]
    public IList<V1beta1WorkflowStatusAtProviderStepsDeleteStepDetails>? DeleteStepDetails { get; set; }

    /// <summary>Details for a step that creates one or more tags.</summary>
    [JsonPropertyName("tagStepDetails")]
    public IList<V1beta1WorkflowStatusAtProviderStepsTagStepDetails>? TagStepDetails { get; set; }

    /// <summary>One of the following step types are supported. COPY, CUSTOM, DECRYPT, DELETE, and TAG.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusAtProvider
{
    /// <summary>The Workflow ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A textual description for the workflow.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Workflow id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the steps (actions) to take if errors are encountered during execution of the workflow. See Workflow Steps below.</summary>
    [JsonPropertyName("onExceptionSteps")]
    public IList<V1beta1WorkflowStatusAtProviderOnExceptionSteps>? OnExceptionSteps { get; set; }

    /// <summary>Specifies the details for the steps that are in the specified workflow. See Workflow Steps below.</summary>
    [JsonPropertyName("steps")]
    public IList<V1beta1WorkflowStatusAtProviderSteps>? Steps { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatusConditions
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

/// <summary>WorkflowStatus defines the observed state of Workflow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkflowStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WorkflowStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkflowStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Workflow is the Schema for the Workflows API. Provides a AWS Transfer Workflow resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Workflow : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkflowSpec>, IStatus<V1beta1WorkflowStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Workflow";
    public const string KubeGroup = "transfer.aws.upbound.io";
    public const string KubePluralName = "workflows";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkflowSpec defines the desired state of Workflow</summary>
    [JsonPropertyName("spec")]
    public V1beta1WorkflowSpec Spec { get; set; }

    /// <summary>WorkflowStatus defines the observed state of Workflow.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkflowStatus? Status { get; set; }
}