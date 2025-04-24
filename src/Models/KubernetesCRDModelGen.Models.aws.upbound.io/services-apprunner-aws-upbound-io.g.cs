using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apprunner.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderEncryptionConfiguration
{
    /// <summary>ARN of the KMS key used for encryption.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderHealthCheckConfiguration
{
    /// <summary>Number of consecutive checks that must succeed before App Runner decides that the service is healthy. Defaults to 1. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time interval, in seconds, between health checks. Defaults to 5. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>URL to send requests to for health checks. Defaults to /. Minimum length of 0. Maximum length of 51200.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>IP protocol that App Runner uses to perform health checks for your service. Valid values: TCP, HTTP. Defaults to TCP. If you set protocol to HTTP, App Runner sends health check requests to the HTTP path specified by path.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Time, in seconds, to wait for a health check response before deciding it failed. Defaults to 2. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Number of consecutive checks that must fail before App Runner decides that the service is unhealthy. Defaults to 5. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderInstanceConfiguration
{
    /// <summary>Number of CPU units reserved for each instance of your App Runner service represented as a String. Defaults to 1024. Valid values: 256|512|1024|2048|4096|(0.25|0.5|1|2|4) vCPU.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>ARN of an IAM role that provides permissions to your App Runner service. These are permissions that your code needs when it calls any AWS APIs.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    /// <summary>Amount of memory, in MB or GB, reserved for each instance of your App Runner service. Defaults to 2048. Valid values: 512|1024|2048|3072|4096|6144|8192|10240|12288|(0.5|1|2|3|4|6|8|10|12) GB.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderNetworkConfigurationEgressConfiguration
{
    /// <summary>The type of egress configuration. Valid values are: DEFAULT and VPC.</summary>
    [JsonPropertyName("egressType")]
    public string? EgressType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the App Runner VPC connector that you want to associate with your App Runner service. Only valid when EgressType = VPC.</summary>
    [JsonPropertyName("vpcConnectorArn")]
    public string? VpcConnectorArn { get; set; }

    /// <summary>Reference to a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
    [JsonPropertyName("vpcConnectorArnRef")]
    public V1beta1ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRef? VpcConnectorArnRef { get; set; }

    /// <summary>Selector for a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
    [JsonPropertyName("vpcConnectorArnSelector")]
    public V1beta1ServiceSpecForProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelector? VpcConnectorArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderNetworkConfigurationIngressConfiguration
{
    /// <summary>Specifies whether your App Runner service is publicly accessible. To make the service publicly accessible set it to True. To make the service privately accessible, from only within an Amazon VPC set it to False.</summary>
    [JsonPropertyName("isPubliclyAccessible")]
    public bool? IsPubliclyAccessible { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderNetworkConfiguration
{
    /// <summary>Network configuration settings for outbound message traffic. See Egress Configuration below for more details.</summary>
    [JsonPropertyName("egressConfiguration")]
    public IList<V1beta1ServiceSpecForProviderNetworkConfigurationEgressConfiguration>? EgressConfiguration { get; set; }

    /// <summary>Network configuration settings for inbound network traffic. See Ingress Configuration below for more details.</summary>
    [JsonPropertyName("ingressConfiguration")]
    public IList<V1beta1ServiceSpecForProviderNetworkConfigurationIngressConfiguration>? IngressConfiguration { get; set; }

    /// <summary>App Runner provides you with the option to choose between Internet Protocol version 4 (IPv4) and dual stack (IPv4 and IPv6) for your incoming public network configuration. Valid values: IPV4, DUAL_STACK. Default: IPV4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderObservabilityConfiguration
{
    /// <summary>ARN of the observability configuration that is associated with the service. Specified only when observability_enabled is true.</summary>
    [JsonPropertyName("observabilityConfigurationArn")]
    public string? ObservabilityConfigurationArn { get; set; }

    /// <summary>Reference to a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
    [JsonPropertyName("observabilityConfigurationArnRef")]
    public V1beta1ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnRef? ObservabilityConfigurationArnRef { get; set; }

    /// <summary>Selector for a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
    [JsonPropertyName("observabilityConfigurationArnSelector")]
    public V1beta1ServiceSpecForProviderObservabilityConfigurationObservabilityConfigurationArnSelector? ObservabilityConfigurationArnSelector { get; set; }

    /// <summary>When true, an observability configuration resource is associated with the service.</summary>
    [JsonPropertyName("observabilityEnabled")]
    public bool? ObservabilityEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Connection in apprunner to populate connectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Connection in apprunner to populate connectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfigurationAuthenticationConfiguration
{
    /// <summary>ARN of the IAM role that grants the App Runner service access to a source repository. Required for ECR image repositories (but not for ECR Public)</summary>
    [JsonPropertyName("accessRoleArn")]
    public string? AccessRoleArn { get; set; }

    /// <summary>ARN of the App Runner connection that enables the App Runner service to connect to a source repository. Required for GitHub code repositories.</summary>
    [JsonPropertyName("connectionArn")]
    public string? ConnectionArn { get; set; }

    /// <summary>Reference to a Connection in apprunner to populate connectionArn.</summary>
    [JsonPropertyName("connectionArnRef")]
    public V1beta1ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnRef? ConnectionArnRef { get; set; }

    /// <summary>Selector for a Connection in apprunner to populate connectionArn.</summary>
    [JsonPropertyName("connectionArnSelector")]
    public V1beta1ServiceSpecForProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelector? ConnectionArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues
{
    /// <summary>Command App Runner runs to build your application.</summary>
    [JsonPropertyName("buildCommand")]
    public string? BuildCommand { get; set; }

    /// <summary>Port that your application listens to in the container. Defaults to "8080".</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Runtime environment type for building and running an App Runner service. Represents a programming language runtime. Valid values: PYTHON_3, NODEJS_12, NODEJS_14, NODEJS_16, CORRETTO_8, CORRETTO_11, GO_1, DOTNET_6, PHP_81, RUBY_31.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren't valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfigurationCodeRepositoryCodeConfiguration
{
    /// <summary>Basic configuration for building and running the App Runner service. Use this parameter to quickly launch an App Runner service without providing an apprunner.yaml file in the source code repository (or ignoring the file if it exists). See Code Configuration Values below for more details.</summary>
    [JsonPropertyName("codeConfigurationValues")]
    public IList<V1beta1ServiceSpecForProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues>? CodeConfigurationValues { get; set; }

    /// <summary>Source of the App Runner configuration. Valid values: REPOSITORY, API. Values are interpreted as follows:</summary>
    [JsonPropertyName("configurationSource")]
    public string? ConfigurationSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfigurationCodeRepositorySourceCodeVersion
{
    /// <summary>Type of version identifier. For a git-based repository, branches represent versions. Valid values: BRANCH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Source code version. For a git-based repository, a branch name maps to a specific version. App Runner uses the most recent commit to the branch.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfigurationCodeRepository
{
    /// <summary>Configuration for building and running the service from a source code repository. See Code Configuration below for more details.</summary>
    [JsonPropertyName("codeConfiguration")]
    public IList<V1beta1ServiceSpecForProviderSourceConfigurationCodeRepositoryCodeConfiguration>? CodeConfiguration { get; set; }

    /// <summary>Location of the repository that contains the source code.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }

    /// <summary>Version that should be used within the source code repository. See Source Code Version below for more details.</summary>
    [JsonPropertyName("sourceCodeVersion")]
    public IList<V1beta1ServiceSpecForProviderSourceConfigurationCodeRepositorySourceCodeVersion>? SourceCodeVersion { get; set; }

    /// <summary>The path of the directory that stores source code and configuration files. The build and start commands also execute from here. The path is absolute from root and, if not specified, defaults to the repository root.</summary>
    [JsonPropertyName("sourceDirectory")]
    public string? SourceDirectory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfigurationImageRepositoryImageConfiguration
{
    /// <summary>Port that your application listens to in the container. Defaults to "8080".</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren't valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfigurationImageRepository
{
    /// <summary>Configuration for running the identified image. See Image Configuration below for more details.</summary>
    [JsonPropertyName("imageConfiguration")]
    public IList<V1beta1ServiceSpecForProviderSourceConfigurationImageRepositoryImageConfiguration>? ImageConfiguration { get; set; }

    /// <summary>Identifier of an image. For an image in Amazon Elastic Container Registry (Amazon ECR), this is an image name. For the image name format, see Pulling an image in the Amazon ECR User Guide.</summary>
    [JsonPropertyName("imageIdentifier")]
    public string? ImageIdentifier { get; set; }

    /// <summary>Type of the image repository. This reflects the repository provider and whether the repository is private or public. Valid values: ECR , ECR_PUBLIC.</summary>
    [JsonPropertyName("imageRepositoryType")]
    public string? ImageRepositoryType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProviderSourceConfiguration
{
    /// <summary>Describes resources needed to authenticate access to some source repositories. See Authentication Configuration below for more details.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public IList<V1beta1ServiceSpecForProviderSourceConfigurationAuthenticationConfiguration>? AuthenticationConfiguration { get; set; }

    /// <summary>Whether continuous integration from the source repository is enabled for the App Runner service. If set to true, each repository change (source code commit or new image version) starts a deployment. Defaults to true.</summary>
    [JsonPropertyName("autoDeploymentsEnabled")]
    public bool? AutoDeploymentsEnabled { get; set; }

    /// <summary>Description of a source code repository. See Code Repository below for more details.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1ServiceSpecForProviderSourceConfigurationCodeRepository>? CodeRepository { get; set; }

    /// <summary>Description of a source image repository. See Image Repository below for more details.</summary>
    [JsonPropertyName("imageRepository")]
    public IList<V1beta1ServiceSpecForProviderSourceConfigurationImageRepository>? ImageRepository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecForProvider
{
    /// <summary>ARN of an App Runner automatic scaling configuration resource that you want to associate with your service. If not provided, App Runner associates the latest revision of a default auto scaling configuration.</summary>
    [JsonPropertyName("autoScalingConfigurationArn")]
    public string? AutoScalingConfigurationArn { get; set; }

    /// <summary>(Forces new resource) An optional custom encryption key that App Runner uses to encrypt the copy of your source repository that it maintains and your service logs. By default, App Runner uses an AWS managed CMK. See Encryption Configuration below for more details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1ServiceSpecForProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>Settings of the health check that AWS App Runner performs to monitor the health of your service. See Health Check Configuration below for more details.</summary>
    [JsonPropertyName("healthCheckConfiguration")]
    public IList<V1beta1ServiceSpecForProviderHealthCheckConfiguration>? HealthCheckConfiguration { get; set; }

    /// <summary>The runtime configuration of instances (scaling units) of the App Runner service. See Instance Configuration below for more details.</summary>
    [JsonPropertyName("instanceConfiguration")]
    public IList<V1beta1ServiceSpecForProviderInstanceConfiguration>? InstanceConfiguration { get; set; }

    /// <summary>Configuration settings related to network traffic of the web application that the App Runner service runs. See Network Configuration below for more details.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1ServiceSpecForProviderNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>The observability configuration of your service. See Observability Configuration below for more details.</summary>
    [JsonPropertyName("observabilityConfiguration")]
    public IList<V1beta1ServiceSpecForProviderObservabilityConfiguration>? ObservabilityConfiguration { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>(Forces new resource) Name of the service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>The source to deploy to the App Runner service. Can be a code or an image repository. See Source Configuration below for more details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public IList<V1beta1ServiceSpecForProviderSourceConfiguration>? SourceConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderEncryptionConfiguration
{
    /// <summary>ARN of the KMS key used for encryption.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderHealthCheckConfiguration
{
    /// <summary>Number of consecutive checks that must succeed before App Runner decides that the service is healthy. Defaults to 1. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time interval, in seconds, between health checks. Defaults to 5. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>URL to send requests to for health checks. Defaults to /. Minimum length of 0. Maximum length of 51200.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>IP protocol that App Runner uses to perform health checks for your service. Valid values: TCP, HTTP. Defaults to TCP. If you set protocol to HTTP, App Runner sends health check requests to the HTTP path specified by path.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Time, in seconds, to wait for a health check response before deciding it failed. Defaults to 2. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Number of consecutive checks that must fail before App Runner decides that the service is unhealthy. Defaults to 5. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderInstanceConfiguration
{
    /// <summary>Number of CPU units reserved for each instance of your App Runner service represented as a String. Defaults to 1024. Valid values: 256|512|1024|2048|4096|(0.25|0.5|1|2|4) vCPU.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>ARN of an IAM role that provides permissions to your App Runner service. These are permissions that your code needs when it calls any AWS APIs.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    /// <summary>Amount of memory, in MB or GB, reserved for each instance of your App Runner service. Defaults to 2048. Valid values: 512|1024|2048|3072|4096|6144|8192|10240|12288|(0.5|1|2|3|4|6|8|10|12) GB.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderNetworkConfigurationEgressConfiguration
{
    /// <summary>The type of egress configuration. Valid values are: DEFAULT and VPC.</summary>
    [JsonPropertyName("egressType")]
    public string? EgressType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the App Runner VPC connector that you want to associate with your App Runner service. Only valid when EgressType = VPC.</summary>
    [JsonPropertyName("vpcConnectorArn")]
    public string? VpcConnectorArn { get; set; }

    /// <summary>Reference to a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
    [JsonPropertyName("vpcConnectorArnRef")]
    public V1beta1ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnRef? VpcConnectorArnRef { get; set; }

    /// <summary>Selector for a VPCConnector in apprunner to populate vpcConnectorArn.</summary>
    [JsonPropertyName("vpcConnectorArnSelector")]
    public V1beta1ServiceSpecInitProviderNetworkConfigurationEgressConfigurationVpcConnectorArnSelector? VpcConnectorArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderNetworkConfigurationIngressConfiguration
{
    /// <summary>Specifies whether your App Runner service is publicly accessible. To make the service publicly accessible set it to True. To make the service privately accessible, from only within an Amazon VPC set it to False.</summary>
    [JsonPropertyName("isPubliclyAccessible")]
    public bool? IsPubliclyAccessible { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderNetworkConfiguration
{
    /// <summary>Network configuration settings for outbound message traffic. See Egress Configuration below for more details.</summary>
    [JsonPropertyName("egressConfiguration")]
    public IList<V1beta1ServiceSpecInitProviderNetworkConfigurationEgressConfiguration>? EgressConfiguration { get; set; }

    /// <summary>Network configuration settings for inbound network traffic. See Ingress Configuration below for more details.</summary>
    [JsonPropertyName("ingressConfiguration")]
    public IList<V1beta1ServiceSpecInitProviderNetworkConfigurationIngressConfiguration>? IngressConfiguration { get; set; }

    /// <summary>App Runner provides you with the option to choose between Internet Protocol version 4 (IPv4) and dual stack (IPv4 and IPv6) for your incoming public network configuration. Valid values: IPV4, DUAL_STACK. Default: IPV4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderObservabilityConfiguration
{
    /// <summary>ARN of the observability configuration that is associated with the service. Specified only when observability_enabled is true.</summary>
    [JsonPropertyName("observabilityConfigurationArn")]
    public string? ObservabilityConfigurationArn { get; set; }

    /// <summary>Reference to a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
    [JsonPropertyName("observabilityConfigurationArnRef")]
    public V1beta1ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnRef? ObservabilityConfigurationArnRef { get; set; }

    /// <summary>Selector for a ObservabilityConfiguration in apprunner to populate observabilityConfigurationArn.</summary>
    [JsonPropertyName("observabilityConfigurationArnSelector")]
    public V1beta1ServiceSpecInitProviderObservabilityConfigurationObservabilityConfigurationArnSelector? ObservabilityConfigurationArnSelector { get; set; }

    /// <summary>When true, an observability configuration resource is associated with the service.</summary>
    [JsonPropertyName("observabilityEnabled")]
    public bool? ObservabilityEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Connection in apprunner to populate connectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Connection in apprunner to populate connectionArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfigurationAuthenticationConfiguration
{
    /// <summary>ARN of the IAM role that grants the App Runner service access to a source repository. Required for ECR image repositories (but not for ECR Public)</summary>
    [JsonPropertyName("accessRoleArn")]
    public string? AccessRoleArn { get; set; }

    /// <summary>ARN of the App Runner connection that enables the App Runner service to connect to a source repository. Required for GitHub code repositories.</summary>
    [JsonPropertyName("connectionArn")]
    public string? ConnectionArn { get; set; }

    /// <summary>Reference to a Connection in apprunner to populate connectionArn.</summary>
    [JsonPropertyName("connectionArnRef")]
    public V1beta1ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnRef? ConnectionArnRef { get; set; }

    /// <summary>Selector for a Connection in apprunner to populate connectionArn.</summary>
    [JsonPropertyName("connectionArnSelector")]
    public V1beta1ServiceSpecInitProviderSourceConfigurationAuthenticationConfigurationConnectionArnSelector? ConnectionArnSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues
{
    /// <summary>Command App Runner runs to build your application.</summary>
    [JsonPropertyName("buildCommand")]
    public string? BuildCommand { get; set; }

    /// <summary>Port that your application listens to in the container. Defaults to "8080".</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Runtime environment type for building and running an App Runner service. Represents a programming language runtime. Valid values: PYTHON_3, NODEJS_12, NODEJS_14, NODEJS_16, CORRETTO_8, CORRETTO_11, GO_1, DOTNET_6, PHP_81, RUBY_31.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren't valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfigurationCodeRepositoryCodeConfiguration
{
    /// <summary>Basic configuration for building and running the App Runner service. Use this parameter to quickly launch an App Runner service without providing an apprunner.yaml file in the source code repository (or ignoring the file if it exists). See Code Configuration Values below for more details.</summary>
    [JsonPropertyName("codeConfigurationValues")]
    public IList<V1beta1ServiceSpecInitProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues>? CodeConfigurationValues { get; set; }

    /// <summary>Source of the App Runner configuration. Valid values: REPOSITORY, API. Values are interpreted as follows:</summary>
    [JsonPropertyName("configurationSource")]
    public string? ConfigurationSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfigurationCodeRepositorySourceCodeVersion
{
    /// <summary>Type of version identifier. For a git-based repository, branches represent versions. Valid values: BRANCH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Source code version. For a git-based repository, a branch name maps to a specific version. App Runner uses the most recent commit to the branch.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfigurationCodeRepository
{
    /// <summary>Configuration for building and running the service from a source code repository. See Code Configuration below for more details.</summary>
    [JsonPropertyName("codeConfiguration")]
    public IList<V1beta1ServiceSpecInitProviderSourceConfigurationCodeRepositoryCodeConfiguration>? CodeConfiguration { get; set; }

    /// <summary>Location of the repository that contains the source code.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }

    /// <summary>Version that should be used within the source code repository. See Source Code Version below for more details.</summary>
    [JsonPropertyName("sourceCodeVersion")]
    public IList<V1beta1ServiceSpecInitProviderSourceConfigurationCodeRepositorySourceCodeVersion>? SourceCodeVersion { get; set; }

    /// <summary>The path of the directory that stores source code and configuration files. The build and start commands also execute from here. The path is absolute from root and, if not specified, defaults to the repository root.</summary>
    [JsonPropertyName("sourceDirectory")]
    public string? SourceDirectory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfigurationImageRepositoryImageConfiguration
{
    /// <summary>Port that your application listens to in the container. Defaults to "8080".</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren't valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfigurationImageRepository
{
    /// <summary>Configuration for running the identified image. See Image Configuration below for more details.</summary>
    [JsonPropertyName("imageConfiguration")]
    public IList<V1beta1ServiceSpecInitProviderSourceConfigurationImageRepositoryImageConfiguration>? ImageConfiguration { get; set; }

    /// <summary>Identifier of an image. For an image in Amazon Elastic Container Registry (Amazon ECR), this is an image name. For the image name format, see Pulling an image in the Amazon ECR User Guide.</summary>
    [JsonPropertyName("imageIdentifier")]
    public string? ImageIdentifier { get; set; }

    /// <summary>Type of the image repository. This reflects the repository provider and whether the repository is private or public. Valid values: ECR , ECR_PUBLIC.</summary>
    [JsonPropertyName("imageRepositoryType")]
    public string? ImageRepositoryType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProviderSourceConfiguration
{
    /// <summary>Describes resources needed to authenticate access to some source repositories. See Authentication Configuration below for more details.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public IList<V1beta1ServiceSpecInitProviderSourceConfigurationAuthenticationConfiguration>? AuthenticationConfiguration { get; set; }

    /// <summary>Whether continuous integration from the source repository is enabled for the App Runner service. If set to true, each repository change (source code commit or new image version) starts a deployment. Defaults to true.</summary>
    [JsonPropertyName("autoDeploymentsEnabled")]
    public bool? AutoDeploymentsEnabled { get; set; }

    /// <summary>Description of a source code repository. See Code Repository below for more details.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1ServiceSpecInitProviderSourceConfigurationCodeRepository>? CodeRepository { get; set; }

    /// <summary>Description of a source image repository. See Image Repository below for more details.</summary>
    [JsonPropertyName("imageRepository")]
    public IList<V1beta1ServiceSpecInitProviderSourceConfigurationImageRepository>? ImageRepository { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecInitProvider
{
    /// <summary>ARN of an App Runner automatic scaling configuration resource that you want to associate with your service. If not provided, App Runner associates the latest revision of a default auto scaling configuration.</summary>
    [JsonPropertyName("autoScalingConfigurationArn")]
    public string? AutoScalingConfigurationArn { get; set; }

    /// <summary>(Forces new resource) An optional custom encryption key that App Runner uses to encrypt the copy of your source repository that it maintains and your service logs. By default, App Runner uses an AWS managed CMK. See Encryption Configuration below for more details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1ServiceSpecInitProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>Settings of the health check that AWS App Runner performs to monitor the health of your service. See Health Check Configuration below for more details.</summary>
    [JsonPropertyName("healthCheckConfiguration")]
    public IList<V1beta1ServiceSpecInitProviderHealthCheckConfiguration>? HealthCheckConfiguration { get; set; }

    /// <summary>The runtime configuration of instances (scaling units) of the App Runner service. See Instance Configuration below for more details.</summary>
    [JsonPropertyName("instanceConfiguration")]
    public IList<V1beta1ServiceSpecInitProviderInstanceConfiguration>? InstanceConfiguration { get; set; }

    /// <summary>Configuration settings related to network traffic of the web application that the App Runner service runs. See Network Configuration below for more details.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1ServiceSpecInitProviderNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>The observability configuration of your service. See Observability Configuration below for more details.</summary>
    [JsonPropertyName("observabilityConfiguration")]
    public IList<V1beta1ServiceSpecInitProviderObservabilityConfiguration>? ObservabilityConfiguration { get; set; }

    /// <summary>(Forces new resource) Name of the service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>The source to deploy to the App Runner service. Can be a code or an image repository. See Source Configuration below for more details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public IList<V1beta1ServiceSpecInitProviderSourceConfiguration>? SourceConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecProviderConfigRefPolicy
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
public partial class V1beta1ServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ServiceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServiceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ServiceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ServiceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ServiceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ServiceSpec defines the desired state of Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ServiceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderEncryptionConfiguration
{
    /// <summary>ARN of the KMS key used for encryption.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderHealthCheckConfiguration
{
    /// <summary>Number of consecutive checks that must succeed before App Runner decides that the service is healthy. Defaults to 1. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time interval, in seconds, between health checks. Defaults to 5. Minimum value of 1. Maximum value of 20.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>URL to send requests to for health checks. Defaults to /. Minimum length of 0. Maximum length of 51200.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>IP protocol that App Runner uses to perform health checks for your service. Valid values: TCP, HTTP. Defaults to TCP. If you set protocol to HTTP, App Runner sends health check requests to the HTTP path specified by path.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Time, in seconds, to wait for a health check response before deciding it failed. Defaults to 2. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>Number of consecutive checks that must fail before App Runner decides that the service is unhealthy. Defaults to 5. Minimum value of  1. Maximum value of 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderInstanceConfiguration
{
    /// <summary>Number of CPU units reserved for each instance of your App Runner service represented as a String. Defaults to 1024. Valid values: 256|512|1024|2048|4096|(0.25|0.5|1|2|4) vCPU.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>ARN of an IAM role that provides permissions to your App Runner service. These are permissions that your code needs when it calls any AWS APIs.</summary>
    [JsonPropertyName("instanceRoleArn")]
    public string? InstanceRoleArn { get; set; }

    /// <summary>Amount of memory, in MB or GB, reserved for each instance of your App Runner service. Defaults to 2048. Valid values: 512|1024|2048|3072|4096|6144|8192|10240|12288|(0.5|1|2|3|4|6|8|10|12) GB.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderNetworkConfigurationEgressConfiguration
{
    /// <summary>The type of egress configuration. Valid values are: DEFAULT and VPC.</summary>
    [JsonPropertyName("egressType")]
    public string? EgressType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the App Runner VPC connector that you want to associate with your App Runner service. Only valid when EgressType = VPC.</summary>
    [JsonPropertyName("vpcConnectorArn")]
    public string? VpcConnectorArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderNetworkConfigurationIngressConfiguration
{
    /// <summary>Specifies whether your App Runner service is publicly accessible. To make the service publicly accessible set it to True. To make the service privately accessible, from only within an Amazon VPC set it to False.</summary>
    [JsonPropertyName("isPubliclyAccessible")]
    public bool? IsPubliclyAccessible { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderNetworkConfiguration
{
    /// <summary>Network configuration settings for outbound message traffic. See Egress Configuration below for more details.</summary>
    [JsonPropertyName("egressConfiguration")]
    public IList<V1beta1ServiceStatusAtProviderNetworkConfigurationEgressConfiguration>? EgressConfiguration { get; set; }

    /// <summary>Network configuration settings for inbound network traffic. See Ingress Configuration below for more details.</summary>
    [JsonPropertyName("ingressConfiguration")]
    public IList<V1beta1ServiceStatusAtProviderNetworkConfigurationIngressConfiguration>? IngressConfiguration { get; set; }

    /// <summary>App Runner provides you with the option to choose between Internet Protocol version 4 (IPv4) and dual stack (IPv4 and IPv6) for your incoming public network configuration. Valid values: IPV4, DUAL_STACK. Default: IPV4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderObservabilityConfiguration
{
    /// <summary>ARN of the observability configuration that is associated with the service. Specified only when observability_enabled is true.</summary>
    [JsonPropertyName("observabilityConfigurationArn")]
    public string? ObservabilityConfigurationArn { get; set; }

    /// <summary>When true, an observability configuration resource is associated with the service.</summary>
    [JsonPropertyName("observabilityEnabled")]
    public bool? ObservabilityEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderSourceConfigurationAuthenticationConfiguration
{
    /// <summary>ARN of the IAM role that grants the App Runner service access to a source repository. Required for ECR image repositories (but not for ECR Public)</summary>
    [JsonPropertyName("accessRoleArn")]
    public string? AccessRoleArn { get; set; }

    /// <summary>ARN of the App Runner connection that enables the App Runner service to connect to a source repository. Required for GitHub code repositories.</summary>
    [JsonPropertyName("connectionArn")]
    public string? ConnectionArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues
{
    /// <summary>Command App Runner runs to build your application.</summary>
    [JsonPropertyName("buildCommand")]
    public string? BuildCommand { get; set; }

    /// <summary>Port that your application listens to in the container. Defaults to "8080".</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Runtime environment type for building and running an App Runner service. Represents a programming language runtime. Valid values: PYTHON_3, NODEJS_12, NODEJS_14, NODEJS_16, CORRETTO_8, CORRETTO_11, GO_1, DOTNET_6, PHP_81, RUBY_31.</summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren't valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderSourceConfigurationCodeRepositoryCodeConfiguration
{
    /// <summary>Basic configuration for building and running the App Runner service. Use this parameter to quickly launch an App Runner service without providing an apprunner.yaml file in the source code repository (or ignoring the file if it exists). See Code Configuration Values below for more details.</summary>
    [JsonPropertyName("codeConfigurationValues")]
    public IList<V1beta1ServiceStatusAtProviderSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues>? CodeConfigurationValues { get; set; }

    /// <summary>Source of the App Runner configuration. Valid values: REPOSITORY, API. Values are interpreted as follows:</summary>
    [JsonPropertyName("configurationSource")]
    public string? ConfigurationSource { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderSourceConfigurationCodeRepositorySourceCodeVersion
{
    /// <summary>Type of version identifier. For a git-based repository, branches represent versions. Valid values: BRANCH.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Source code version. For a git-based repository, a branch name maps to a specific version. App Runner uses the most recent commit to the branch.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderSourceConfigurationCodeRepository
{
    /// <summary>Configuration for building and running the service from a source code repository. See Code Configuration below for more details.</summary>
    [JsonPropertyName("codeConfiguration")]
    public IList<V1beta1ServiceStatusAtProviderSourceConfigurationCodeRepositoryCodeConfiguration>? CodeConfiguration { get; set; }

    /// <summary>Location of the repository that contains the source code.</summary>
    [JsonPropertyName("repositoryUrl")]
    public string? RepositoryUrl { get; set; }

    /// <summary>Version that should be used within the source code repository. See Source Code Version below for more details.</summary>
    [JsonPropertyName("sourceCodeVersion")]
    public IList<V1beta1ServiceStatusAtProviderSourceConfigurationCodeRepositorySourceCodeVersion>? SourceCodeVersion { get; set; }

    /// <summary>The path of the directory that stores source code and configuration files. The build and start commands also execute from here. The path is absolute from root and, if not specified, defaults to the repository root.</summary>
    [JsonPropertyName("sourceDirectory")]
    public string? SourceDirectory { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderSourceConfigurationImageRepositoryImageConfiguration
{
    /// <summary>Port that your application listens to in the container. Defaults to "8080".</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>Secrets and parameters available to your service as environment variables. A map of key/value pairs, where the key is the desired name of the Secret in the environment (i.e. it does not have to match the name of the secret in Secrets Manager or SSM Parameter Store), and the value is the ARN of the secret from AWS Secrets Manager or the ARN of the parameter in AWS SSM Parameter Store.</summary>
    [JsonPropertyName("runtimeEnvironmentSecrets")]
    public IDictionary<string, string>? RuntimeEnvironmentSecrets { get; set; }

    /// <summary>Environment variables available to your running App Runner service. A map of key/value pairs. Keys with a prefix of AWSAPPRUNNER are reserved for system use and aren't valid.</summary>
    [JsonPropertyName("runtimeEnvironmentVariables")]
    public IDictionary<string, string>? RuntimeEnvironmentVariables { get; set; }

    /// <summary>Command App Runner runs to start the application in the source image. If specified, this command overrides the Docker image’s default start command.</summary>
    [JsonPropertyName("startCommand")]
    public string? StartCommand { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderSourceConfigurationImageRepository
{
    /// <summary>Configuration for running the identified image. See Image Configuration below for more details.</summary>
    [JsonPropertyName("imageConfiguration")]
    public IList<V1beta1ServiceStatusAtProviderSourceConfigurationImageRepositoryImageConfiguration>? ImageConfiguration { get; set; }

    /// <summary>Identifier of an image. For an image in Amazon Elastic Container Registry (Amazon ECR), this is an image name. For the image name format, see Pulling an image in the Amazon ECR User Guide.</summary>
    [JsonPropertyName("imageIdentifier")]
    public string? ImageIdentifier { get; set; }

    /// <summary>Type of the image repository. This reflects the repository provider and whether the repository is private or public. Valid values: ECR , ECR_PUBLIC.</summary>
    [JsonPropertyName("imageRepositoryType")]
    public string? ImageRepositoryType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProviderSourceConfiguration
{
    /// <summary>Describes resources needed to authenticate access to some source repositories. See Authentication Configuration below for more details.</summary>
    [JsonPropertyName("authenticationConfiguration")]
    public IList<V1beta1ServiceStatusAtProviderSourceConfigurationAuthenticationConfiguration>? AuthenticationConfiguration { get; set; }

    /// <summary>Whether continuous integration from the source repository is enabled for the App Runner service. If set to true, each repository change (source code commit or new image version) starts a deployment. Defaults to true.</summary>
    [JsonPropertyName("autoDeploymentsEnabled")]
    public bool? AutoDeploymentsEnabled { get; set; }

    /// <summary>Description of a source code repository. See Code Repository below for more details.</summary>
    [JsonPropertyName("codeRepository")]
    public IList<V1beta1ServiceStatusAtProviderSourceConfigurationCodeRepository>? CodeRepository { get; set; }

    /// <summary>Description of a source image repository. See Image Repository below for more details.</summary>
    [JsonPropertyName("imageRepository")]
    public IList<V1beta1ServiceStatusAtProviderSourceConfigurationImageRepository>? ImageRepository { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusAtProvider
{
    /// <summary>ARN of the App Runner service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN of an App Runner automatic scaling configuration resource that you want to associate with your service. If not provided, App Runner associates the latest revision of a default auto scaling configuration.</summary>
    [JsonPropertyName("autoScalingConfigurationArn")]
    public string? AutoScalingConfigurationArn { get; set; }

    /// <summary>(Forces new resource) An optional custom encryption key that App Runner uses to encrypt the copy of your source repository that it maintains and your service logs. By default, App Runner uses an AWS managed CMK. See Encryption Configuration below for more details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public IList<V1beta1ServiceStatusAtProviderEncryptionConfiguration>? EncryptionConfiguration { get; set; }

    /// <summary>Settings of the health check that AWS App Runner performs to monitor the health of your service. See Health Check Configuration below for more details.</summary>
    [JsonPropertyName("healthCheckConfiguration")]
    public IList<V1beta1ServiceStatusAtProviderHealthCheckConfiguration>? HealthCheckConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The runtime configuration of instances (scaling units) of the App Runner service. See Instance Configuration below for more details.</summary>
    [JsonPropertyName("instanceConfiguration")]
    public IList<V1beta1ServiceStatusAtProviderInstanceConfiguration>? InstanceConfiguration { get; set; }

    /// <summary>Configuration settings related to network traffic of the web application that the App Runner service runs. See Network Configuration below for more details.</summary>
    [JsonPropertyName("networkConfiguration")]
    public IList<V1beta1ServiceStatusAtProviderNetworkConfiguration>? NetworkConfiguration { get; set; }

    /// <summary>The observability configuration of your service. See Observability Configuration below for more details.</summary>
    [JsonPropertyName("observabilityConfiguration")]
    public IList<V1beta1ServiceStatusAtProviderObservabilityConfiguration>? ObservabilityConfiguration { get; set; }

    /// <summary>An alphanumeric ID that App Runner generated for this service. Unique within the AWS Region.</summary>
    [JsonPropertyName("serviceId")]
    public string? ServiceId { get; set; }

    /// <summary>(Forces new resource) Name of the service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Subdomain URL that App Runner generated for this service. You can use this URL to access your service web application.</summary>
    [JsonPropertyName("serviceUrl")]
    public string? ServiceUrl { get; set; }

    /// <summary>The source to deploy to the App Runner service. Can be a code or an image repository. See Source Configuration below for more details.</summary>
    [JsonPropertyName("sourceConfiguration")]
    public IList<V1beta1ServiceStatusAtProviderSourceConfiguration>? SourceConfiguration { get; set; }

    /// <summary>Current state of the App Runner service.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatusConditions
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

/// <summary>ServiceStatus defines the observed state of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Service is the Schema for the Services API. Manages an App Runner Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Service : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServiceSpec>, IStatus<V1beta1ServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Service";
    public const string KubeGroup = "apprunner.aws.upbound.io";
    public const string KubePluralName = "services";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceSpec defines the desired state of Service</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServiceSpec Spec { get; set; }

    /// <summary>ServiceStatus defines the observed state of Service.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServiceStatus? Status { get; set; }
}

/// <summary>Service is the Schema for the Services API. Manages an App Runner Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Service>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceList";
    public const string KubeGroup = "apprunner.aws.upbound.io";
    public const string KubePluralName = "services";
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
    public IList<V1beta1Service> Items { get; set; }
}