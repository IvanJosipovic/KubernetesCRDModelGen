using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.serving.databricks.crossplane.io;
/// <summary>ModelServing is the Schema for the ModelServings API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ModelServingList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ModelServing>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ModelServingList";
    public const string KubeGroup = "serving.databricks.crossplane.io";
    public const string KubePluralName = "modelservings";
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
    public IList<V1alpha1ModelServing> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderAiGatewayFallbackConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderAiGatewayGuardrailsInputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderAiGatewayGuardrailsInput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public IList<V1alpha1ModelServingSpecForProviderAiGatewayGuardrailsInputPii>? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderAiGatewayGuardrailsOutputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderAiGatewayGuardrailsOutput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public IList<V1alpha1ModelServingSpecForProviderAiGatewayGuardrailsOutputPii>? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderAiGatewayGuardrails
{
    /// <summary>A block with configuration for input guardrail filters:</summary>
    [JsonPropertyName("input")]
    public IList<V1alpha1ModelServingSpecForProviderAiGatewayGuardrailsInput>? Input { get; set; }

    /// <summary>A block with configuration for output guardrail filters.  Has the same structure as input block.</summary>
    [JsonPropertyName("output")]
    public IList<V1alpha1ModelServingSpecForProviderAiGatewayGuardrailsOutput>? Output { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderAiGatewayInferenceTableConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderAiGatewayRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Principal field for a user, user group, or service principal to apply rate limiting to. Accepts a user email, group name, or service principal application ID.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderAiGatewayUsageTrackingConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderAiGateway
{
    /// <summary>block with configuration for traffic fallback which auto fallbacks to other served entities if the request to a served entity fails with certain error codes, to increase availability.</summary>
    [JsonPropertyName("fallbackConfig")]
    public IList<V1alpha1ModelServingSpecForProviderAiGatewayFallbackConfig>? FallbackConfig { get; set; }

    /// <summary>Block with configuration for AI Guardrails to prevent unwanted data and unsafe data in requests and responses. Consists of the following attributes:</summary>
    [JsonPropertyName("guardrails")]
    public IList<V1alpha1ModelServingSpecForProviderAiGatewayGuardrails>? Guardrails { get; set; }

    /// <summary>Block describing the configuration of usage tracking. Consists of the following attributes:</summary>
    [JsonPropertyName("inferenceTableConfig")]
    public IList<V1alpha1ModelServingSpecForProviderAiGatewayInferenceTableConfig>? InferenceTableConfig { get; set; }

    /// <summary>Block describing rate limits for AI gateway. For details see the description of rate_limits block above.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1alpha1ModelServingSpecForProviderAiGatewayRateLimits>? RateLimits { get; set; }

    /// <summary>Block with configuration for payload logging using inference tables. For details see the description of auto_capture_config block above.</summary>
    [JsonPropertyName("usageTrackingConfig")]
    public IList<V1alpha1ModelServingSpecForProviderAiGatewayUsageTrackingConfig>? UsageTrackingConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigAutoCaptureConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelAi21labsConfig
{
    /// <summary>The Databricks secret key reference for an AI21Labs API key.</summary>
    [JsonPropertyName("ai21labsApiKey")]
    public string? Ai21labsApiKey { get; set; }

    /// <summary>An AI21 Labs API key provided as a plaintext string.</summary>
    [JsonPropertyName("ai21labsApiKeyPlaintext")]
    public string? Ai21labsApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelAmazonBedrockConfig
{
    /// <summary>The Databricks secret key reference for an AWS Access Key ID with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsAccessKeyId")]
    public string? AwsAccessKeyId { get; set; }

    /// <summary>An AWS access key ID with permissions to interact with Bedrock services provided as a plaintext string.</summary>
    [JsonPropertyName("awsAccessKeyIdPlaintext")]
    public string? AwsAccessKeyIdPlaintext { get; set; }

    /// <summary>The AWS region to use. Bedrock has to be enabled there.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>The Databricks secret key reference for an AWS Secret Access Key paired with the access key ID, with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public string? AwsSecretAccessKey { get; set; }

    /// <summary>An AWS secret access key paired with the access key ID, with permissions to interact with Bedrock services provided as a plaintext string.</summary>
    [JsonPropertyName("awsSecretAccessKeyPlaintext")]
    public string? AwsSecretAccessKeyPlaintext { get; set; }

    /// <summary>The underlying provider in Amazon Bedrock. Supported values (case insensitive) include: Anthropic, Cohere, AI21Labs, Amazon.</summary>
    [JsonPropertyName("bedrockProvider")]
    public string? BedrockProvider { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelAnthropicConfig
{
    /// <summary>The Databricks secret key reference for an Anthropic API key.</summary>
    [JsonPropertyName("anthropicApiKey")]
    public string? AnthropicApiKey { get; set; }

    /// <summary>The Anthropic API key provided as a plaintext string.</summary>
    [JsonPropertyName("anthropicApiKeyPlaintext")]
    public string? AnthropicApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelCohereConfig
{
    /// <summary></summary>
    [JsonPropertyName("cohereApiBase")]
    public string? CohereApiBase { get; set; }

    /// <summary>The Databricks secret key reference for a Cohere API key.</summary>
    [JsonPropertyName("cohereApiKey")]
    public string? CohereApiKey { get; set; }

    /// <summary>The Cohere API key provided as a plaintext string.</summary>
    [JsonPropertyName("cohereApiKeyPlaintext")]
    public string? CohereApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Databricks secret key reference for an API Key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>The API Key provided as a plaintext string.</summary>
    [JsonPropertyName("valuePlaintext")]
    public string? ValuePlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth
{
    /// <summary>The Databricks secret key reference for a token.</summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>The token provided as a plaintext string.</summary>
    [JsonPropertyName("tokenPlaintext")]
    public string? TokenPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfig
{
    /// <summary>API key authentication for the custom provider API. Conflicts with bearer_token_auth.</summary>
    [JsonPropertyName("apiKeyAuth")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth>? ApiKeyAuth { get; set; }

    /// <summary>bearer token authentication for the custom provider API.  Conflicts with api_key_auth.</summary>
    [JsonPropertyName("bearerTokenAuth")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth>? BearerTokenAuth { get; set; }

    /// <summary>URL of the custom provider API.</summary>
    [JsonPropertyName("customProviderUrl")]
    public string? CustomProviderUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig
{
    /// <summary>The Databricks secret key reference for a Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksApiToken")]
    public string? DatabricksApiToken { get; set; }

    /// <summary>The Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model provided as a plaintext string.</summary>
    [JsonPropertyName("databricksApiTokenPlaintext")]
    public string? DatabricksApiTokenPlaintext { get; set; }

    /// <summary>The URL of the Databricks workspace containing the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksWorkspaceUrl")]
    public string? DatabricksWorkspaceUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig
{
    /// <summary>The Databricks secret key reference for a private key for the service account that has access to the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>The private key for the service account that has access to the Google Cloud Vertex AI Service is provided as a plaintext secret.</summary>
    [JsonPropertyName("privateKeyPlaintext")]
    public string? PrivateKeyPlaintext { get; set; }

    /// <summary>This is the Google Cloud project id that the service account is associated with.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>This is the region for the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelOpenaiConfig
{
    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Client ID.</summary>
    [JsonPropertyName("microsoftEntraClientId")]
    public string? MicrosoftEntraClientId { get; set; }

    /// <summary>The Databricks secret key reference for a client secret used for Microsoft Entra ID authentication.</summary>
    [JsonPropertyName("microsoftEntraClientSecret")]
    public string? MicrosoftEntraClientSecret { get; set; }

    /// <summary>The client secret used for Microsoft Entra ID authentication provided as a plaintext string.</summary>
    [JsonPropertyName("microsoftEntraClientSecretPlaintext")]
    public string? MicrosoftEntraClientSecretPlaintext { get; set; }

    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Tenant ID.</summary>
    [JsonPropertyName("microsoftEntraTenantId")]
    public string? MicrosoftEntraTenantId { get; set; }

    /// <summary>This is the base URL for the OpenAI API (default: "https://api.openai.com/v1"). For Azure OpenAI, this field is required and is the base URL for the Azure OpenAI API service provided by Azure.</summary>
    [JsonPropertyName("openaiApiBase")]
    public string? OpenaiApiBase { get; set; }

    /// <summary>The Databricks secret key reference for an OpenAI or Azure OpenAI API key.</summary>
    [JsonPropertyName("openaiApiKey")]
    public string? OpenaiApiKey { get; set; }

    /// <summary>The OpenAI API key using the OpenAI or Azure service provided as a plaintext string.</summary>
    [JsonPropertyName("openaiApiKeyPlaintext")]
    public string? OpenaiApiKeyPlaintext { get; set; }

    /// <summary>This is an optional field to specify the type of OpenAI API to use. For Azure OpenAI, this field is required, and this parameter represents the preferred security access validation protocol. For access token validation, use azure. For authentication using Azure Active Directory (Azure AD) use, azuread.</summary>
    [JsonPropertyName("openaiApiType")]
    public string? OpenaiApiType { get; set; }

    /// <summary>This is an optional field to specify the OpenAI API version. For Azure OpenAI, this field is required and is the version of the Azure OpenAI service to utilize, specified by a date.</summary>
    [JsonPropertyName("openaiApiVersion")]
    public string? OpenaiApiVersion { get; set; }

    /// <summary>This field is only required for Azure OpenAI and is the name of the deployment resource for the Azure OpenAI service.</summary>
    [JsonPropertyName("openaiDeploymentName")]
    public string? OpenaiDeploymentName { get; set; }

    /// <summary>This is an optional field to specify the organization in OpenAI or Azure OpenAI.</summary>
    [JsonPropertyName("openaiOrganization")]
    public string? OpenaiOrganization { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelPalmConfig
{
    /// <summary>The Databricks secret key reference for a PaLM API key.</summary>
    [JsonPropertyName("palmApiKey")]
    public string? PalmApiKey { get; set; }

    /// <summary>The PaLM API key provided as a plaintext string.</summary>
    [JsonPropertyName("palmApiKeyPlaintext")]
    public string? PalmApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModel
{
    /// <summary>AI21Labs Config</summary>
    [JsonPropertyName("ai21labsConfig")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelAi21labsConfig>? Ai21labsConfig { get; set; }

    /// <summary>Amazon Bedrock Config</summary>
    [JsonPropertyName("amazonBedrockConfig")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelAmazonBedrockConfig>? AmazonBedrockConfig { get; set; }

    /// <summary>Anthropic Config</summary>
    [JsonPropertyName("anthropicConfig")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelAnthropicConfig>? AnthropicConfig { get; set; }

    /// <summary>Cohere Config</summary>
    [JsonPropertyName("cohereConfig")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelCohereConfig>? CohereConfig { get; set; }

    /// <summary>Custom Provider Config. Only required if the provider is 'custom'.</summary>
    [JsonPropertyName("customProviderConfig")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelCustomProviderConfig>? CustomProviderConfig { get; set; }

    /// <summary>Databricks Model Serving Config</summary>
    [JsonPropertyName("databricksModelServingConfig")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig>? DatabricksModelServingConfig { get; set; }

    /// <summary>Google Cloud Vertex AI Config.</summary>
    [JsonPropertyName("googleCloudVertexAiConfig")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig>? GoogleCloudVertexAiConfig { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OpenAI Config</summary>
    [JsonPropertyName("openaiConfig")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelOpenaiConfig>? OpenaiConfig { get; set; }

    /// <summary>PaLM Config</summary>
    [JsonPropertyName("palmConfig")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModelPalmConfig>? PalmConfig { get; set; }

    /// <summary>The name of the provider for the external model. Currently, the supported providers are ai21labs, anthropic, amazon-bedrock, cohere, databricks-model-serving, google-cloud-vertex-ai, openai, and palm.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The task type of the external model.</summary>
    [JsonPropertyName("task")]
    public string? Task { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedEntities
{
    /// <summary>The name of the entity to be served. The entity may be a model in the Databricks Model Registry, a model in the Unity Catalog (UC), or a function of type FEATURE_SPEC in the UC. If it is a UC object, the full name of the object should be given in the form of catalog_name.schema_name.model_name.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served or empty if the entity is a FEATURE_SPEC.</summary>
    [JsonPropertyName("entityVersion")]
    public string? EntityVersion { get; set; }

    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>The external model to be served. NOTE: Only one of external_model and (entity_name, entity_version, workload_size, workload_type, and scale_to_zero_enabled) can be specified with the latter set being used for custom model serving for a Databricks registered model. When an external_model is present, the served entities list can only have one served_entity object. An existing endpoint with external_model can not be updated to an endpoint without external_model. If the endpoint is created without external_model, users cannot update it to add external_model later.</summary>
    [JsonPropertyName("externalModel")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntitiesExternalModel>? ExternalModel { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigServedModels
{
    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelVersion")]
    public string? ModelVersion { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigTrafficConfigRoutes
{
    /// <summary>The name of the served entity this route configures traffic for. This needs to match the name of a served_entity block.</summary>
    [JsonPropertyName("servedEntityName")]
    public string? ServedEntityName { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("servedModelName")]
    public string? ServedModelName { get; set; }

    /// <summary>The percentage of endpoint traffic to send to this route. It must be an integer between 0 and 100 inclusive.</summary>
    [JsonPropertyName("trafficPercentage")]
    public double? TrafficPercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfigTrafficConfig
{
    /// <summary>Each block represents a route that defines traffic to each served entity. Each served_entity block needs to have a corresponding routes block.</summary>
    [JsonPropertyName("routes")]
    public IList<V1alpha1ModelServingSpecForProviderConfigTrafficConfigRoutes>? Routes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderConfig
{
    /// <summary>Configuration for Inference Tables which automatically logs requests and responses to Unity Catalog.</summary>
    [JsonPropertyName("autoCaptureConfig")]
    public IList<V1alpha1ModelServingSpecForProviderConfigAutoCaptureConfig>? AutoCaptureConfig { get; set; }

    /// <summary>A list of served entities for the endpoint to serve. A serving endpoint can have up to 10 served entities.</summary>
    [JsonPropertyName("servedEntities")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedEntities>? ServedEntities { get; set; }

    /// <summary>(Deprecated, use served_entities instead) Each block represents a served model for the endpoint to serve. A model serving endpoint can have up to 10 served models.</summary>
    [JsonPropertyName("servedModels")]
    public IList<V1alpha1ModelServingSpecForProviderConfigServedModels>? ServedModels { get; set; }

    /// <summary>A single block represents the traffic split configuration amongst the served models.</summary>
    [JsonPropertyName("trafficConfig")]
    public IList<V1alpha1ModelServingSpecForProviderConfigTrafficConfig>? TrafficConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>Key field for a serving endpoint rate limit. Currently, user, user_group, service_principal, and endpoint are supported, with endpoint being the default if not specified.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProviderTags
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value field for a tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecForProvider
{
    /// <summary>A block with AI Gateway configuration for the serving endpoint. Note: only external model endpoints are supported as of now.</summary>
    [JsonPropertyName("aiGateway")]
    public IList<V1alpha1ModelServingSpecForProviderAiGateway>? AiGateway { get; set; }

    /// <summary>(Optiona) The Budget Policy ID set for this serving endpoint.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The model serving endpoint configuration. This is optional and can be added and modified after creation. If config was provided in a previous apply but is not provided in the current apply, no change to the model serving endpoint will occur. To recreate the model serving endpoint without the config block, the model serving endpoint must be destroyed and recreated.</summary>
    [JsonPropertyName("config")]
    public IList<V1alpha1ModelServingSpecForProviderConfig>? Config { get; set; }

    /// <summary>The description of the model serving endpoint.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Deprecated, use ai_gateway to manage rate limits) A list of rate limit blocks to be applied to the serving endpoint. Note: only external and foundation model endpoints are supported as of now.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1alpha1ModelServingSpecForProviderRateLimits>? RateLimits { get; set; }

    /// <summary>A boolean enabling route optimization for the endpoint. Note: only available for custom models.</summary>
    [JsonPropertyName("routeOptimized")]
    public bool? RouteOptimized { get; set; }

    /// <summary>Tags to be attached to the serving endpoint and automatically propagated to billing logs.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ModelServingSpecForProviderTags>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderAiGatewayFallbackConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderAiGatewayGuardrailsInputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderAiGatewayGuardrailsInput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public IList<V1alpha1ModelServingSpecInitProviderAiGatewayGuardrailsInputPii>? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderAiGatewayGuardrailsOutputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderAiGatewayGuardrailsOutput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public IList<V1alpha1ModelServingSpecInitProviderAiGatewayGuardrailsOutputPii>? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderAiGatewayGuardrails
{
    /// <summary>A block with configuration for input guardrail filters:</summary>
    [JsonPropertyName("input")]
    public IList<V1alpha1ModelServingSpecInitProviderAiGatewayGuardrailsInput>? Input { get; set; }

    /// <summary>A block with configuration for output guardrail filters.  Has the same structure as input block.</summary>
    [JsonPropertyName("output")]
    public IList<V1alpha1ModelServingSpecInitProviderAiGatewayGuardrailsOutput>? Output { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderAiGatewayInferenceTableConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderAiGatewayRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Principal field for a user, user group, or service principal to apply rate limiting to. Accepts a user email, group name, or service principal application ID.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderAiGatewayUsageTrackingConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderAiGateway
{
    /// <summary>block with configuration for traffic fallback which auto fallbacks to other served entities if the request to a served entity fails with certain error codes, to increase availability.</summary>
    [JsonPropertyName("fallbackConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderAiGatewayFallbackConfig>? FallbackConfig { get; set; }

    /// <summary>Block with configuration for AI Guardrails to prevent unwanted data and unsafe data in requests and responses. Consists of the following attributes:</summary>
    [JsonPropertyName("guardrails")]
    public IList<V1alpha1ModelServingSpecInitProviderAiGatewayGuardrails>? Guardrails { get; set; }

    /// <summary>Block describing the configuration of usage tracking. Consists of the following attributes:</summary>
    [JsonPropertyName("inferenceTableConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderAiGatewayInferenceTableConfig>? InferenceTableConfig { get; set; }

    /// <summary>Block describing rate limits for AI gateway. For details see the description of rate_limits block above.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1alpha1ModelServingSpecInitProviderAiGatewayRateLimits>? RateLimits { get; set; }

    /// <summary>Block with configuration for payload logging using inference tables. For details see the description of auto_capture_config block above.</summary>
    [JsonPropertyName("usageTrackingConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderAiGatewayUsageTrackingConfig>? UsageTrackingConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigAutoCaptureConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAi21labsConfig
{
    /// <summary>The Databricks secret key reference for an AI21Labs API key.</summary>
    [JsonPropertyName("ai21labsApiKey")]
    public string? Ai21labsApiKey { get; set; }

    /// <summary>An AI21 Labs API key provided as a plaintext string.</summary>
    [JsonPropertyName("ai21labsApiKeyPlaintext")]
    public string? Ai21labsApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAmazonBedrockConfig
{
    /// <summary>The Databricks secret key reference for an AWS Access Key ID with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsAccessKeyId")]
    public string? AwsAccessKeyId { get; set; }

    /// <summary>An AWS access key ID with permissions to interact with Bedrock services provided as a plaintext string.</summary>
    [JsonPropertyName("awsAccessKeyIdPlaintext")]
    public string? AwsAccessKeyIdPlaintext { get; set; }

    /// <summary>The AWS region to use. Bedrock has to be enabled there.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>The Databricks secret key reference for an AWS Secret Access Key paired with the access key ID, with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public string? AwsSecretAccessKey { get; set; }

    /// <summary>An AWS secret access key paired with the access key ID, with permissions to interact with Bedrock services provided as a plaintext string.</summary>
    [JsonPropertyName("awsSecretAccessKeyPlaintext")]
    public string? AwsSecretAccessKeyPlaintext { get; set; }

    /// <summary>The underlying provider in Amazon Bedrock. Supported values (case insensitive) include: Anthropic, Cohere, AI21Labs, Amazon.</summary>
    [JsonPropertyName("bedrockProvider")]
    public string? BedrockProvider { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAnthropicConfig
{
    /// <summary>The Databricks secret key reference for an Anthropic API key.</summary>
    [JsonPropertyName("anthropicApiKey")]
    public string? AnthropicApiKey { get; set; }

    /// <summary>The Anthropic API key provided as a plaintext string.</summary>
    [JsonPropertyName("anthropicApiKeyPlaintext")]
    public string? AnthropicApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCohereConfig
{
    /// <summary></summary>
    [JsonPropertyName("cohereApiBase")]
    public string? CohereApiBase { get; set; }

    /// <summary>The Databricks secret key reference for a Cohere API key.</summary>
    [JsonPropertyName("cohereApiKey")]
    public string? CohereApiKey { get; set; }

    /// <summary>The Cohere API key provided as a plaintext string.</summary>
    [JsonPropertyName("cohereApiKeyPlaintext")]
    public string? CohereApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Databricks secret key reference for an API Key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>The API Key provided as a plaintext string.</summary>
    [JsonPropertyName("valuePlaintext")]
    public string? ValuePlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth
{
    /// <summary>The Databricks secret key reference for a token.</summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>The token provided as a plaintext string.</summary>
    [JsonPropertyName("tokenPlaintext")]
    public string? TokenPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfig
{
    /// <summary>API key authentication for the custom provider API. Conflicts with bearer_token_auth.</summary>
    [JsonPropertyName("apiKeyAuth")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth>? ApiKeyAuth { get; set; }

    /// <summary>bearer token authentication for the custom provider API.  Conflicts with api_key_auth.</summary>
    [JsonPropertyName("bearerTokenAuth")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth>? BearerTokenAuth { get; set; }

    /// <summary>URL of the custom provider API.</summary>
    [JsonPropertyName("customProviderUrl")]
    public string? CustomProviderUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig
{
    /// <summary>The Databricks secret key reference for a Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksApiToken")]
    public string? DatabricksApiToken { get; set; }

    /// <summary>The Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model provided as a plaintext string.</summary>
    [JsonPropertyName("databricksApiTokenPlaintext")]
    public string? DatabricksApiTokenPlaintext { get; set; }

    /// <summary>The URL of the Databricks workspace containing the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksWorkspaceUrl")]
    public string? DatabricksWorkspaceUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig
{
    /// <summary>The Databricks secret key reference for a private key for the service account that has access to the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>The private key for the service account that has access to the Google Cloud Vertex AI Service is provided as a plaintext secret.</summary>
    [JsonPropertyName("privateKeyPlaintext")]
    public string? PrivateKeyPlaintext { get; set; }

    /// <summary>This is the Google Cloud project id that the service account is associated with.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>This is the region for the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelOpenaiConfig
{
    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Client ID.</summary>
    [JsonPropertyName("microsoftEntraClientId")]
    public string? MicrosoftEntraClientId { get; set; }

    /// <summary>The Databricks secret key reference for a client secret used for Microsoft Entra ID authentication.</summary>
    [JsonPropertyName("microsoftEntraClientSecret")]
    public string? MicrosoftEntraClientSecret { get; set; }

    /// <summary>The client secret used for Microsoft Entra ID authentication provided as a plaintext string.</summary>
    [JsonPropertyName("microsoftEntraClientSecretPlaintext")]
    public string? MicrosoftEntraClientSecretPlaintext { get; set; }

    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Tenant ID.</summary>
    [JsonPropertyName("microsoftEntraTenantId")]
    public string? MicrosoftEntraTenantId { get; set; }

    /// <summary>This is the base URL for the OpenAI API (default: "https://api.openai.com/v1"). For Azure OpenAI, this field is required and is the base URL for the Azure OpenAI API service provided by Azure.</summary>
    [JsonPropertyName("openaiApiBase")]
    public string? OpenaiApiBase { get; set; }

    /// <summary>The Databricks secret key reference for an OpenAI or Azure OpenAI API key.</summary>
    [JsonPropertyName("openaiApiKey")]
    public string? OpenaiApiKey { get; set; }

    /// <summary>The OpenAI API key using the OpenAI or Azure service provided as a plaintext string.</summary>
    [JsonPropertyName("openaiApiKeyPlaintext")]
    public string? OpenaiApiKeyPlaintext { get; set; }

    /// <summary>This is an optional field to specify the type of OpenAI API to use. For Azure OpenAI, this field is required, and this parameter represents the preferred security access validation protocol. For access token validation, use azure. For authentication using Azure Active Directory (Azure AD) use, azuread.</summary>
    [JsonPropertyName("openaiApiType")]
    public string? OpenaiApiType { get; set; }

    /// <summary>This is an optional field to specify the OpenAI API version. For Azure OpenAI, this field is required and is the version of the Azure OpenAI service to utilize, specified by a date.</summary>
    [JsonPropertyName("openaiApiVersion")]
    public string? OpenaiApiVersion { get; set; }

    /// <summary>This field is only required for Azure OpenAI and is the name of the deployment resource for the Azure OpenAI service.</summary>
    [JsonPropertyName("openaiDeploymentName")]
    public string? OpenaiDeploymentName { get; set; }

    /// <summary>This is an optional field to specify the organization in OpenAI or Azure OpenAI.</summary>
    [JsonPropertyName("openaiOrganization")]
    public string? OpenaiOrganization { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelPalmConfig
{
    /// <summary>The Databricks secret key reference for a PaLM API key.</summary>
    [JsonPropertyName("palmApiKey")]
    public string? PalmApiKey { get; set; }

    /// <summary>The PaLM API key provided as a plaintext string.</summary>
    [JsonPropertyName("palmApiKeyPlaintext")]
    public string? PalmApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModel
{
    /// <summary>AI21Labs Config</summary>
    [JsonPropertyName("ai21labsConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAi21labsConfig>? Ai21labsConfig { get; set; }

    /// <summary>Amazon Bedrock Config</summary>
    [JsonPropertyName("amazonBedrockConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAmazonBedrockConfig>? AmazonBedrockConfig { get; set; }

    /// <summary>Anthropic Config</summary>
    [JsonPropertyName("anthropicConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelAnthropicConfig>? AnthropicConfig { get; set; }

    /// <summary>Cohere Config</summary>
    [JsonPropertyName("cohereConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCohereConfig>? CohereConfig { get; set; }

    /// <summary>Custom Provider Config. Only required if the provider is 'custom'.</summary>
    [JsonPropertyName("customProviderConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelCustomProviderConfig>? CustomProviderConfig { get; set; }

    /// <summary>Databricks Model Serving Config</summary>
    [JsonPropertyName("databricksModelServingConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig>? DatabricksModelServingConfig { get; set; }

    /// <summary>Google Cloud Vertex AI Config.</summary>
    [JsonPropertyName("googleCloudVertexAiConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig>? GoogleCloudVertexAiConfig { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OpenAI Config</summary>
    [JsonPropertyName("openaiConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelOpenaiConfig>? OpenaiConfig { get; set; }

    /// <summary>PaLM Config</summary>
    [JsonPropertyName("palmConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModelPalmConfig>? PalmConfig { get; set; }

    /// <summary>The name of the provider for the external model. Currently, the supported providers are ai21labs, anthropic, amazon-bedrock, cohere, databricks-model-serving, google-cloud-vertex-ai, openai, and palm.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The task type of the external model.</summary>
    [JsonPropertyName("task")]
    public string? Task { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedEntities
{
    /// <summary>The name of the entity to be served. The entity may be a model in the Databricks Model Registry, a model in the Unity Catalog (UC), or a function of type FEATURE_SPEC in the UC. If it is a UC object, the full name of the object should be given in the form of catalog_name.schema_name.model_name.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served or empty if the entity is a FEATURE_SPEC.</summary>
    [JsonPropertyName("entityVersion")]
    public string? EntityVersion { get; set; }

    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>The external model to be served. NOTE: Only one of external_model and (entity_name, entity_version, workload_size, workload_type, and scale_to_zero_enabled) can be specified with the latter set being used for custom model serving for a Databricks registered model. When an external_model is present, the served entities list can only have one served_entity object. An existing endpoint with external_model can not be updated to an endpoint without external_model. If the endpoint is created without external_model, users cannot update it to add external_model later.</summary>
    [JsonPropertyName("externalModel")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntitiesExternalModel>? ExternalModel { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigServedModels
{
    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelVersion")]
    public string? ModelVersion { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigTrafficConfigRoutes
{
    /// <summary>The name of the served entity this route configures traffic for. This needs to match the name of a served_entity block.</summary>
    [JsonPropertyName("servedEntityName")]
    public string? ServedEntityName { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("servedModelName")]
    public string? ServedModelName { get; set; }

    /// <summary>The percentage of endpoint traffic to send to this route. It must be an integer between 0 and 100 inclusive.</summary>
    [JsonPropertyName("trafficPercentage")]
    public double? TrafficPercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfigTrafficConfig
{
    /// <summary>Each block represents a route that defines traffic to each served entity. Each served_entity block needs to have a corresponding routes block.</summary>
    [JsonPropertyName("routes")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigTrafficConfigRoutes>? Routes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderConfig
{
    /// <summary>Configuration for Inference Tables which automatically logs requests and responses to Unity Catalog.</summary>
    [JsonPropertyName("autoCaptureConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigAutoCaptureConfig>? AutoCaptureConfig { get; set; }

    /// <summary>A list of served entities for the endpoint to serve. A serving endpoint can have up to 10 served entities.</summary>
    [JsonPropertyName("servedEntities")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedEntities>? ServedEntities { get; set; }

    /// <summary>(Deprecated, use served_entities instead) Each block represents a served model for the endpoint to serve. A model serving endpoint can have up to 10 served models.</summary>
    [JsonPropertyName("servedModels")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigServedModels>? ServedModels { get; set; }

    /// <summary>A single block represents the traffic split configuration amongst the served models.</summary>
    [JsonPropertyName("trafficConfig")]
    public IList<V1alpha1ModelServingSpecInitProviderConfigTrafficConfig>? TrafficConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>Key field for a serving endpoint rate limit. Currently, user, user_group, service_principal, and endpoint are supported, with endpoint being the default if not specified.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProviderTags
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value field for a tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecInitProvider
{
    /// <summary>A block with AI Gateway configuration for the serving endpoint. Note: only external model endpoints are supported as of now.</summary>
    [JsonPropertyName("aiGateway")]
    public IList<V1alpha1ModelServingSpecInitProviderAiGateway>? AiGateway { get; set; }

    /// <summary>(Optiona) The Budget Policy ID set for this serving endpoint.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The model serving endpoint configuration. This is optional and can be added and modified after creation. If config was provided in a previous apply but is not provided in the current apply, no change to the model serving endpoint will occur. To recreate the model serving endpoint without the config block, the model serving endpoint must be destroyed and recreated.</summary>
    [JsonPropertyName("config")]
    public IList<V1alpha1ModelServingSpecInitProviderConfig>? Config { get; set; }

    /// <summary>The description of the model serving endpoint.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Deprecated, use ai_gateway to manage rate limits) A list of rate limit blocks to be applied to the serving endpoint. Note: only external and foundation model endpoints are supported as of now.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1alpha1ModelServingSpecInitProviderRateLimits>? RateLimits { get; set; }

    /// <summary>A boolean enabling route optimization for the endpoint. Note: only available for custom models.</summary>
    [JsonPropertyName("routeOptimized")]
    public bool? RouteOptimized { get; set; }

    /// <summary>Tags to be attached to the serving endpoint and automatically propagated to billing logs.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ModelServingSpecInitProviderTags>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecProviderConfigRefPolicy
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
public partial class V1alpha1ModelServingSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ModelServingSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1alpha1ModelServingSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ModelServingSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecPublishConnectionDetailsToMetadata
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
public partial class V1alpha1ModelServingSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1alpha1ModelServingSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1ModelServingSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ModelServingSpec defines the desired state of ModelServing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1alpha1ModelServingSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1ModelServingSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1ModelServingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1alpha1ModelServingSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1ModelServingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderAiGatewayFallbackConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderAiGatewayGuardrailsInputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderAiGatewayGuardrailsInput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public IList<V1alpha1ModelServingStatusAtProviderAiGatewayGuardrailsInputPii>? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderAiGatewayGuardrailsOutputPii
{
    /// <summary>a string that describes the behavior for PII filter. Currently only BLOCK value is supported.</summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderAiGatewayGuardrailsOutput
{
    /// <summary>(Deprecated) List of invalid keywords. AI guardrail uses keyword or string matching to decide if the keyword exists in the request or response content.</summary>
    [JsonPropertyName("invalidKeywords")]
    public IList<string>? InvalidKeywords { get; set; }

    /// <summary>Block with configuration for guardrail PII filter:</summary>
    [JsonPropertyName("pii")]
    public IList<V1alpha1ModelServingStatusAtProviderAiGatewayGuardrailsOutputPii>? Pii { get; set; }

    /// <summary>the boolean flag that indicates whether the safety filter is enabled.</summary>
    [JsonPropertyName("safety")]
    public bool? Safety { get; set; }

    /// <summary>(Deprecated) The list of allowed topics. Given a chat request, this guardrail flags the request if its topic is not in the allowed topics.</summary>
    [JsonPropertyName("validTopics")]
    public IList<string>? ValidTopics { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderAiGatewayGuardrails
{
    /// <summary>A block with configuration for input guardrail filters:</summary>
    [JsonPropertyName("input")]
    public IList<V1alpha1ModelServingStatusAtProviderAiGatewayGuardrailsInput>? Input { get; set; }

    /// <summary>A block with configuration for output guardrail filters.  Has the same structure as input block.</summary>
    [JsonPropertyName("output")]
    public IList<V1alpha1ModelServingStatusAtProviderAiGatewayGuardrailsOutput>? Output { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderAiGatewayInferenceTableConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderAiGatewayRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Principal field for a user, user group, or service principal to apply rate limiting to. Accepts a user email, group name, or service principal application ID.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderAiGatewayUsageTrackingConfig
{
    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderAiGateway
{
    /// <summary>block with configuration for traffic fallback which auto fallbacks to other served entities if the request to a served entity fails with certain error codes, to increase availability.</summary>
    [JsonPropertyName("fallbackConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderAiGatewayFallbackConfig>? FallbackConfig { get; set; }

    /// <summary>Block with configuration for AI Guardrails to prevent unwanted data and unsafe data in requests and responses. Consists of the following attributes:</summary>
    [JsonPropertyName("guardrails")]
    public IList<V1alpha1ModelServingStatusAtProviderAiGatewayGuardrails>? Guardrails { get; set; }

    /// <summary>Block describing the configuration of usage tracking. Consists of the following attributes:</summary>
    [JsonPropertyName("inferenceTableConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderAiGatewayInferenceTableConfig>? InferenceTableConfig { get; set; }

    /// <summary>Block describing rate limits for AI gateway. For details see the description of rate_limits block above.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1alpha1ModelServingStatusAtProviderAiGatewayRateLimits>? RateLimits { get; set; }

    /// <summary>Block with configuration for payload logging using inference tables. For details see the description of auto_capture_config block above.</summary>
    [JsonPropertyName("usageTrackingConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderAiGatewayUsageTrackingConfig>? UsageTrackingConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigAutoCaptureConfig
{
    /// <summary>The name of the catalog in Unity Catalog. NOTE: On update, you cannot change the catalog name if it was already set.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Whether to enable traffic fallback. When a served entity in the serving endpoint returns specific error codes (e.g. 500), the request will automatically be round-robin attempted with other served entities in the same endpoint, following the order of served entity list, until a successful response is returned.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the schema in Unity Catalog. NOTE: On update, you cannot change the schema name if it was already set.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The prefix of the table in Unity Catalog. NOTE: On update, you cannot change the prefix name if it was already set.</summary>
    [JsonPropertyName("tableNamePrefix")]
    public string? TableNamePrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAi21labsConfig
{
    /// <summary>The Databricks secret key reference for an AI21Labs API key.</summary>
    [JsonPropertyName("ai21labsApiKey")]
    public string? Ai21labsApiKey { get; set; }

    /// <summary>An AI21 Labs API key provided as a plaintext string.</summary>
    [JsonPropertyName("ai21labsApiKeyPlaintext")]
    public string? Ai21labsApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAmazonBedrockConfig
{
    /// <summary>The Databricks secret key reference for an AWS Access Key ID with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsAccessKeyId")]
    public string? AwsAccessKeyId { get; set; }

    /// <summary>An AWS access key ID with permissions to interact with Bedrock services provided as a plaintext string.</summary>
    [JsonPropertyName("awsAccessKeyIdPlaintext")]
    public string? AwsAccessKeyIdPlaintext { get; set; }

    /// <summary>The AWS region to use. Bedrock has to be enabled there.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    /// <summary>The Databricks secret key reference for an AWS Secret Access Key paired with the access key ID, with permissions to interact with Bedrock services.</summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public string? AwsSecretAccessKey { get; set; }

    /// <summary>An AWS secret access key paired with the access key ID, with permissions to interact with Bedrock services provided as a plaintext string.</summary>
    [JsonPropertyName("awsSecretAccessKeyPlaintext")]
    public string? AwsSecretAccessKeyPlaintext { get; set; }

    /// <summary>The underlying provider in Amazon Bedrock. Supported values (case insensitive) include: Anthropic, Cohere, AI21Labs, Amazon.</summary>
    [JsonPropertyName("bedrockProvider")]
    public string? BedrockProvider { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAnthropicConfig
{
    /// <summary>The Databricks secret key reference for an Anthropic API key.</summary>
    [JsonPropertyName("anthropicApiKey")]
    public string? AnthropicApiKey { get; set; }

    /// <summary>The Anthropic API key provided as a plaintext string.</summary>
    [JsonPropertyName("anthropicApiKeyPlaintext")]
    public string? AnthropicApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCohereConfig
{
    /// <summary></summary>
    [JsonPropertyName("cohereApiBase")]
    public string? CohereApiBase { get; set; }

    /// <summary>The Databricks secret key reference for a Cohere API key.</summary>
    [JsonPropertyName("cohereApiKey")]
    public string? CohereApiKey { get; set; }

    /// <summary>The Cohere API key provided as a plaintext string.</summary>
    [JsonPropertyName("cohereApiKeyPlaintext")]
    public string? CohereApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Databricks secret key reference for an API Key.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>The API Key provided as a plaintext string.</summary>
    [JsonPropertyName("valuePlaintext")]
    public string? ValuePlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth
{
    /// <summary>The Databricks secret key reference for a token.</summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>The token provided as a plaintext string.</summary>
    [JsonPropertyName("tokenPlaintext")]
    public string? TokenPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfig
{
    /// <summary>API key authentication for the custom provider API. Conflicts with bearer_token_auth.</summary>
    [JsonPropertyName("apiKeyAuth")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfigApiKeyAuth>? ApiKeyAuth { get; set; }

    /// <summary>bearer token authentication for the custom provider API.  Conflicts with api_key_auth.</summary>
    [JsonPropertyName("bearerTokenAuth")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfigBearerTokenAuth>? BearerTokenAuth { get; set; }

    /// <summary>URL of the custom provider API.</summary>
    [JsonPropertyName("customProviderUrl")]
    public string? CustomProviderUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig
{
    /// <summary>The Databricks secret key reference for a Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksApiToken")]
    public string? DatabricksApiToken { get; set; }

    /// <summary>The Databricks API token that corresponds to a user or service principal with Can Query access to the model serving endpoint pointed to by this external model provided as a plaintext string.</summary>
    [JsonPropertyName("databricksApiTokenPlaintext")]
    public string? DatabricksApiTokenPlaintext { get; set; }

    /// <summary>The URL of the Databricks workspace containing the model serving endpoint pointed to by this external model.</summary>
    [JsonPropertyName("databricksWorkspaceUrl")]
    public string? DatabricksWorkspaceUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig
{
    /// <summary>The Databricks secret key reference for a private key for the service account that has access to the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>The private key for the service account that has access to the Google Cloud Vertex AI Service is provided as a plaintext secret.</summary>
    [JsonPropertyName("privateKeyPlaintext")]
    public string? PrivateKeyPlaintext { get; set; }

    /// <summary>This is the Google Cloud project id that the service account is associated with.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>This is the region for the Google Cloud Vertex AI Service.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelOpenaiConfig
{
    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Client ID.</summary>
    [JsonPropertyName("microsoftEntraClientId")]
    public string? MicrosoftEntraClientId { get; set; }

    /// <summary>The Databricks secret key reference for a client secret used for Microsoft Entra ID authentication.</summary>
    [JsonPropertyName("microsoftEntraClientSecret")]
    public string? MicrosoftEntraClientSecret { get; set; }

    /// <summary>The client secret used for Microsoft Entra ID authentication provided as a plaintext string.</summary>
    [JsonPropertyName("microsoftEntraClientSecretPlaintext")]
    public string? MicrosoftEntraClientSecretPlaintext { get; set; }

    /// <summary>This field is only required for Azure AD OpenAI and is the Microsoft Entra Tenant ID.</summary>
    [JsonPropertyName("microsoftEntraTenantId")]
    public string? MicrosoftEntraTenantId { get; set; }

    /// <summary>This is the base URL for the OpenAI API (default: "https://api.openai.com/v1"). For Azure OpenAI, this field is required and is the base URL for the Azure OpenAI API service provided by Azure.</summary>
    [JsonPropertyName("openaiApiBase")]
    public string? OpenaiApiBase { get; set; }

    /// <summary>The Databricks secret key reference for an OpenAI or Azure OpenAI API key.</summary>
    [JsonPropertyName("openaiApiKey")]
    public string? OpenaiApiKey { get; set; }

    /// <summary>The OpenAI API key using the OpenAI or Azure service provided as a plaintext string.</summary>
    [JsonPropertyName("openaiApiKeyPlaintext")]
    public string? OpenaiApiKeyPlaintext { get; set; }

    /// <summary>This is an optional field to specify the type of OpenAI API to use. For Azure OpenAI, this field is required, and this parameter represents the preferred security access validation protocol. For access token validation, use azure. For authentication using Azure Active Directory (Azure AD) use, azuread.</summary>
    [JsonPropertyName("openaiApiType")]
    public string? OpenaiApiType { get; set; }

    /// <summary>This is an optional field to specify the OpenAI API version. For Azure OpenAI, this field is required and is the version of the Azure OpenAI service to utilize, specified by a date.</summary>
    [JsonPropertyName("openaiApiVersion")]
    public string? OpenaiApiVersion { get; set; }

    /// <summary>This field is only required for Azure OpenAI and is the name of the deployment resource for the Azure OpenAI service.</summary>
    [JsonPropertyName("openaiDeploymentName")]
    public string? OpenaiDeploymentName { get; set; }

    /// <summary>This is an optional field to specify the organization in OpenAI or Azure OpenAI.</summary>
    [JsonPropertyName("openaiOrganization")]
    public string? OpenaiOrganization { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelPalmConfig
{
    /// <summary>The Databricks secret key reference for a PaLM API key.</summary>
    [JsonPropertyName("palmApiKey")]
    public string? PalmApiKey { get; set; }

    /// <summary>The PaLM API key provided as a plaintext string.</summary>
    [JsonPropertyName("palmApiKeyPlaintext")]
    public string? PalmApiKeyPlaintext { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModel
{
    /// <summary>AI21Labs Config</summary>
    [JsonPropertyName("ai21labsConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAi21labsConfig>? Ai21labsConfig { get; set; }

    /// <summary>Amazon Bedrock Config</summary>
    [JsonPropertyName("amazonBedrockConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAmazonBedrockConfig>? AmazonBedrockConfig { get; set; }

    /// <summary>Anthropic Config</summary>
    [JsonPropertyName("anthropicConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelAnthropicConfig>? AnthropicConfig { get; set; }

    /// <summary>Cohere Config</summary>
    [JsonPropertyName("cohereConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCohereConfig>? CohereConfig { get; set; }

    /// <summary>Custom Provider Config. Only required if the provider is 'custom'.</summary>
    [JsonPropertyName("customProviderConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelCustomProviderConfig>? CustomProviderConfig { get; set; }

    /// <summary>Databricks Model Serving Config</summary>
    [JsonPropertyName("databricksModelServingConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelDatabricksModelServingConfig>? DatabricksModelServingConfig { get; set; }

    /// <summary>Google Cloud Vertex AI Config.</summary>
    [JsonPropertyName("googleCloudVertexAiConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelGoogleCloudVertexAiConfig>? GoogleCloudVertexAiConfig { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OpenAI Config</summary>
    [JsonPropertyName("openaiConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelOpenaiConfig>? OpenaiConfig { get; set; }

    /// <summary>PaLM Config</summary>
    [JsonPropertyName("palmConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModelPalmConfig>? PalmConfig { get; set; }

    /// <summary>The name of the provider for the external model. Currently, the supported providers are ai21labs, anthropic, amazon-bedrock, cohere, databricks-model-serving, google-cloud-vertex-ai, openai, and palm.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>The task type of the external model.</summary>
    [JsonPropertyName("task")]
    public string? Task { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedEntities
{
    /// <summary>The name of the entity to be served. The entity may be a model in the Databricks Model Registry, a model in the Unity Catalog (UC), or a function of type FEATURE_SPEC in the UC. If it is a UC object, the full name of the object should be given in the form of catalog_name.schema_name.model_name.</summary>
    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served or empty if the entity is a FEATURE_SPEC.</summary>
    [JsonPropertyName("entityVersion")]
    public string? EntityVersion { get; set; }

    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>The external model to be served. NOTE: Only one of external_model and (entity_name, entity_version, workload_size, workload_type, and scale_to_zero_enabled) can be specified with the latter set being used for custom model serving for a Databricks registered model. When an external_model is present, the served entities list can only have one served_entity object. An existing endpoint with external_model can not be updated to an endpoint without external_model. If the endpoint is created without external_model, users cannot update it to add external_model later.</summary>
    [JsonPropertyName("externalModel")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntitiesExternalModel>? ExternalModel { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigServedModels
{
    /// <summary>a map of environment variable names/values that will be used for serving this model.  Environment variables may refer to Databricks secrets using the standard syntax: {{secrets/secret_scope/secret_key}}.</summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>ARN of the instance profile that the served model will use to access AWS resources.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The maximum provisioned concurrency that the endpoint can scale up to. Conflicts with workload_size.</summary>
    [JsonPropertyName("maxProvisionedConcurrency")]
    public double? MaxProvisionedConcurrency { get; set; }

    /// <summary>The maximum tokens per second that the endpoint can scale up to.</summary>
    [JsonPropertyName("maxProvisionedThroughput")]
    public double? MaxProvisionedThroughput { get; set; }

    /// <summary>The minimum provisioned concurrency that the endpoint can scale down to. Conflicts with workload_size.</summary>
    [JsonPropertyName("minProvisionedConcurrency")]
    public double? MinProvisionedConcurrency { get; set; }

    /// <summary>The minimum tokens per second that the endpoint can scale down to.</summary>
    [JsonPropertyName("minProvisionedThroughput")]
    public double? MinProvisionedThroughput { get; set; }

    /// <summary>The name of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>The version of the model in Databricks Model Registry to be served.</summary>
    [JsonPropertyName("modelVersion")]
    public string? ModelVersion { get; set; }

    /// <summary>The name of a served model. It must be unique across an endpoint. If not specified, this field will default to modelname-modelversion. A served model name can consist of alphanumeric characters, dashes, and underscores.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionedModelUnits")]
    public double? ProvisionedModelUnits { get; set; }

    /// <summary>Whether the compute resources for the served model should scale down to zero. If scale-to-zero is enabled, the lower bound of the provisioned concurrency for each workload size will be 0. The default value is true.</summary>
    [JsonPropertyName("scaleToZeroEnabled")]
    public bool? ScaleToZeroEnabled { get; set; }

    /// <summary>The workload size of the served model. The workload size corresponds to a range of provisioned concurrency that the compute will autoscale between. A single unit of provisioned concurrency can process one request at a time. Valid workload sizes are Small (4 - 4 provisioned concurrency), Medium (8 - 16 provisioned concurrency), and Large (16 - 64 provisioned concurrency).</summary>
    [JsonPropertyName("workloadSize")]
    public string? WorkloadSize { get; set; }

    /// <summary>The workload type of the served model. The workload type selects which type of compute to use in the endpoint. For deep learning workloads, GPU acceleration is available by selecting workload types like GPU_SMALL and others. See the documentation for all options. The default value is CPU.</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigTrafficConfigRoutes
{
    /// <summary>The name of the served entity this route configures traffic for. This needs to match the name of a served_entity block.</summary>
    [JsonPropertyName("servedEntityName")]
    public string? ServedEntityName { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("servedModelName")]
    public string? ServedModelName { get; set; }

    /// <summary>The percentage of endpoint traffic to send to this route. It must be an integer between 0 and 100 inclusive.</summary>
    [JsonPropertyName("trafficPercentage")]
    public double? TrafficPercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfigTrafficConfig
{
    /// <summary>Each block represents a route that defines traffic to each served entity. Each served_entity block needs to have a corresponding routes block.</summary>
    [JsonPropertyName("routes")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigTrafficConfigRoutes>? Routes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderConfig
{
    /// <summary>Configuration for Inference Tables which automatically logs requests and responses to Unity Catalog.</summary>
    [JsonPropertyName("autoCaptureConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigAutoCaptureConfig>? AutoCaptureConfig { get; set; }

    /// <summary>A list of served entities for the endpoint to serve. A serving endpoint can have up to 10 served entities.</summary>
    [JsonPropertyName("servedEntities")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedEntities>? ServedEntities { get; set; }

    /// <summary>(Deprecated, use served_entities instead) Each block represents a served model for the endpoint to serve. A model serving endpoint can have up to 10 served models.</summary>
    [JsonPropertyName("servedModels")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigServedModels>? ServedModels { get; set; }

    /// <summary>A single block represents the traffic split configuration amongst the served models.</summary>
    [JsonPropertyName("trafficConfig")]
    public IList<V1alpha1ModelServingStatusAtProviderConfigTrafficConfig>? TrafficConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderRateLimits
{
    /// <summary>Used to specify how many calls are allowed for a key within the renewal_period.</summary>
    [JsonPropertyName("calls")]
    public double? Calls { get; set; }

    /// <summary>Key field for a serving endpoint rate limit. Currently, user, user_group, service_principal, and endpoint are supported, with endpoint being the default if not specified.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Renewal period field for a serving endpoint rate limit. Currently, only minute is supported.</summary>
    [JsonPropertyName("renewalPeriod")]
    public string? RenewalPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProviderTags
{
    /// <summary>The key field for a tag.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value field for a tag.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusAtProvider
{
    /// <summary>A block with AI Gateway configuration for the serving endpoint. Note: only external model endpoints are supported as of now.</summary>
    [JsonPropertyName("aiGateway")]
    public IList<V1alpha1ModelServingStatusAtProviderAiGateway>? AiGateway { get; set; }

    /// <summary>(Optiona) The Budget Policy ID set for this serving endpoint.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The model serving endpoint configuration. This is optional and can be added and modified after creation. If config was provided in a previous apply but is not provided in the current apply, no change to the model serving endpoint will occur. To recreate the model serving endpoint without the config block, the model serving endpoint must be destroyed and recreated.</summary>
    [JsonPropertyName("config")]
    public IList<V1alpha1ModelServingStatusAtProviderConfig>? Config { get; set; }

    /// <summary>The description of the model serving endpoint.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Equal to the name argument and used to identify the serving endpoint.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the model serving endpoint. This field is required and must be unique across a workspace. An endpoint name can consist of alphanumeric characters, dashes, and underscores. NOTE: Changing this name will delete the existing endpoint and create a new endpoint with the updated name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>(Deprecated, use ai_gateway to manage rate limits) A list of rate limit blocks to be applied to the serving endpoint. Note: only external and foundation model endpoints are supported as of now.</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1alpha1ModelServingStatusAtProviderRateLimits>? RateLimits { get; set; }

    /// <summary>A boolean enabling route optimization for the endpoint. Note: only available for custom models.</summary>
    [JsonPropertyName("routeOptimized")]
    public bool? RouteOptimized { get; set; }

    /// <summary>Unique identifier of the serving endpoint primarily used to set permissions and refer to this instance for other operations.</summary>
    [JsonPropertyName("servingEndpointId")]
    public string? ServingEndpointId { get; set; }

    /// <summary>Tags to be attached to the serving endpoint and automatically propagated to billing logs.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ModelServingStatusAtProviderTags>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatusConditions
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

/// <summary>ModelServingStatus defines the observed state of ModelServing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelServingStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1ModelServingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ModelServingStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ModelServing is the Schema for the ModelServings API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ModelServing : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ModelServingSpec>, IStatus<V1alpha1ModelServingStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ModelServing";
    public const string KubeGroup = "serving.databricks.crossplane.io";
    public const string KubePluralName = "modelservings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ModelServingSpec defines the desired state of ModelServing</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ModelServingSpec Spec { get; set; }

    /// <summary>ModelServingStatus defines the observed state of ModelServing.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ModelServingStatus? Status { get; set; }
}