using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecAnthropicParams
{
    /// <summary></summary>
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    /// <summary></summary>
    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Anthropic configures Anthropic backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecAnthropic
{
    /// <summary></summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecAnthropicParams? Params { get; set; }

    /// <summary></summary>
    [JsonPropertyName("token")]
    public string Token { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecAzureOpenaiParams
{
    /// <summary></summary>
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    /// <summary></summary>
    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>AzureOpenAI configures AzureOpenAI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecAzureOpenai
{
    /// <summary></summary>
    [JsonPropertyName("apiKey")]
    public string ApiKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("baseUrl")]
    public string BaseUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deploymentName")]
    public string DeploymentName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecAzureOpenaiParams? Params { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecBedrockParams
{
    /// <summary></summary>
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    /// <summary></summary>
    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Bedrock configures Bedrock backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecBedrock
{
    /// <summary></summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecBedrockParams? Params { get; set; }

    /// <summary></summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("systemMessage")]
    public bool? SystemMessage { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecCohereParams
{
    /// <summary></summary>
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    /// <summary></summary>
    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Cohere configures Cohere backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecCohere
{
    /// <summary></summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecCohereParams? Params { get; set; }

    /// <summary></summary>
    [JsonPropertyName("token")]
    public string Token { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecGeminiParams
{
    /// <summary></summary>
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    /// <summary></summary>
    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Gemini configures Gemini backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecGemini
{
    /// <summary></summary>
    [JsonPropertyName("apiKey")]
    public string ApiKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecGeminiParams? Params { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecMistralParams
{
    /// <summary></summary>
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    /// <summary></summary>
    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Mistral configures Mistral AI backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecMistral
{
    /// <summary></summary>
    [JsonPropertyName("apiKey")]
    public string ApiKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecMistralParams? Params { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecOllamaParams
{
    /// <summary></summary>
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    /// <summary></summary>
    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>Ollama configures Ollama backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecOllama
{
    /// <summary></summary>
    [JsonPropertyName("baseUrl")]
    public string BaseUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecOllamaParams? Params { get; set; }
}

/// <summary>Params holds the LLM hyperparameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecOpenaiParams
{
    /// <summary></summary>
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxTokens")]
    public int? MaxTokens { get; set; }

    /// <summary></summary>
    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    /// <summary></summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }
}

/// <summary>OpenAI configures OpenAI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpecOpenai
{
    /// <summary></summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>Params holds the LLM hyperparameters.</summary>
    [JsonPropertyName("params")]
    public V1alpha1AIServiceSpecOpenaiParams? Params { get; set; }

    /// <summary></summary>
    [JsonPropertyName("token")]
    public string Token { get; set; }
}

/// <summary>The desired behavior of this AIService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AIServiceSpec
{
    /// <summary>Anthropic configures Anthropic backend.</summary>
    [JsonPropertyName("anthropic")]
    public V1alpha1AIServiceSpecAnthropic? Anthropic { get; set; }

    /// <summary>AzureOpenAI configures AzureOpenAI.</summary>
    [JsonPropertyName("azureOpenai")]
    public V1alpha1AIServiceSpecAzureOpenai? AzureOpenai { get; set; }

    /// <summary>Bedrock configures Bedrock backend.</summary>
    [JsonPropertyName("bedrock")]
    public V1alpha1AIServiceSpecBedrock? Bedrock { get; set; }

    /// <summary>Cohere configures Cohere backend.</summary>
    [JsonPropertyName("cohere")]
    public V1alpha1AIServiceSpecCohere? Cohere { get; set; }

    /// <summary>Gemini configures Gemini backend.</summary>
    [JsonPropertyName("gemini")]
    public V1alpha1AIServiceSpecGemini? Gemini { get; set; }

    /// <summary>Mistral configures Mistral AI backend.</summary>
    [JsonPropertyName("mistral")]
    public V1alpha1AIServiceSpecMistral? Mistral { get; set; }

    /// <summary>Ollama configures Ollama backend.</summary>
    [JsonPropertyName("ollama")]
    public V1alpha1AIServiceSpecOllama? Ollama { get; set; }

    /// <summary>OpenAI configures OpenAI.</summary>
    [JsonPropertyName("openai")]
    public V1alpha1AIServiceSpecOpenai? Openai { get; set; }
}

/// <summary>AIService is a Kubernetes-like Service to interact with a text-based LLM provider. It defines the parameters and credentials required to interact with various LLM providers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AIService : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AIServiceSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AIService";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "aiservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this AIService.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1AIServiceSpec? Spec { get; set; }
}