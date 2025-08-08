using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iot.aws.upbound.io;
/// <summary>An object that specifies the authorization service for a domain. See the authorizer_config Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecForProviderAuthorizerConfig
{
    /// <summary>A Boolean that specifies whether the domain configuration's authorization service can be overridden.</summary>
    [JsonPropertyName("allowAuthorizerOverride")]
    public bool? AllowAuthorizerOverride { get; set; }

    /// <summary>The name of the authorization service for a domain configuration.</summary>
    [JsonPropertyName("defaultAuthorizerName")]
    public string? DefaultAuthorizerName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecForProviderServerCertificateArnsRefsPolicy
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
public partial class V1beta1DomainConfigurationSpecForProviderServerCertificateArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainConfigurationSpecForProviderServerCertificateArnsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecForProviderServerCertificateArnsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Certificate in acm to populate serverCertificateArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecForProviderServerCertificateArnsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainConfigurationSpecForProviderServerCertificateArnsSelectorPolicy? Policy { get; set; }
}

/// <summary>An object that specifies the TLS configuration for a domain. See the tls_config Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecForProviderTlsConfig
{
    /// <summary>The security policy for a domain configuration.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecForProvider
{
    /// <summary>An enumerated string that speciﬁes the application-layer protocol. Valid values are SECURE_MQTT, MQTT_WSS, HTTPS or DEFAULT.</summary>
    [JsonPropertyName("applicationProtocol")]
    public string? ApplicationProtocol { get; set; }

    /// <summary>An enumerated string that speciﬁes the authentication type. Valid values are CUSTOM_AUTH_X509, CUSTOM_AUTH, AWS_X509, AWS_SIGV4 or DEFAULT.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>An object that specifies the authorization service for a domain. See the authorizer_config Block below for details.</summary>
    [JsonPropertyName("authorizerConfig")]
    public V1beta1DomainConfigurationSpecForProviderAuthorizerConfig? AuthorizerConfig { get; set; }

    /// <summary>Fully-qualified domain name.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The ARNs of the certificates that IoT passes to the device during the TLS handshake. Currently you can specify only one certificate ARN. This value is not required for Amazon Web Services-managed domains. When using a custom domain_name, the cert must include it.</summary>
    [JsonPropertyName("serverCertificateArns")]
    public IList<string>? ServerCertificateArns { get; set; }

    /// <summary>References to Certificate in acm to populate serverCertificateArns.</summary>
    [JsonPropertyName("serverCertificateArnsRefs")]
    public IList<V1beta1DomainConfigurationSpecForProviderServerCertificateArnsRefs>? ServerCertificateArnsRefs { get; set; }

    /// <summary>Selector for a list of Certificate in acm to populate serverCertificateArns.</summary>
    [JsonPropertyName("serverCertificateArnsSelector")]
    public V1beta1DomainConfigurationSpecForProviderServerCertificateArnsSelector? ServerCertificateArnsSelector { get; set; }

    /// <summary>The type of service delivered by the endpoint. Note: Amazon Web Services IoT Core currently supports only the DATA service type.</summary>
    [JsonPropertyName("serviceType")]
    public string? ServiceType { get; set; }

    /// <summary>The status to which the domain configuration should be set. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>An object that specifies the TLS configuration for a domain. See the tls_config Block below for details.</summary>
    [JsonPropertyName("tlsConfig")]
    public V1beta1DomainConfigurationSpecForProviderTlsConfig? TlsConfig { get; set; }

    /// <summary>The certificate used to validate the server certificate and prove domain name ownership. This certificate must be signed by a public certificate authority. This value is not required for Amazon Web Services-managed domains.</summary>
    [JsonPropertyName("validationCertificateArn")]
    public string? ValidationCertificateArn { get; set; }
}

/// <summary>An object that specifies the authorization service for a domain. See the authorizer_config Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecInitProviderAuthorizerConfig
{
    /// <summary>A Boolean that specifies whether the domain configuration's authorization service can be overridden.</summary>
    [JsonPropertyName("allowAuthorizerOverride")]
    public bool? AllowAuthorizerOverride { get; set; }

    /// <summary>The name of the authorization service for a domain configuration.</summary>
    [JsonPropertyName("defaultAuthorizerName")]
    public string? DefaultAuthorizerName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecInitProviderServerCertificateArnsRefsPolicy
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
public partial class V1beta1DomainConfigurationSpecInitProviderServerCertificateArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainConfigurationSpecInitProviderServerCertificateArnsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecInitProviderServerCertificateArnsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Certificate in acm to populate serverCertificateArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecInitProviderServerCertificateArnsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainConfigurationSpecInitProviderServerCertificateArnsSelectorPolicy? Policy { get; set; }
}

/// <summary>An object that specifies the TLS configuration for a domain. See the tls_config Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecInitProviderTlsConfig
{
    /// <summary>The security policy for a domain configuration.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecInitProvider
{
    /// <summary>An enumerated string that speciﬁes the application-layer protocol. Valid values are SECURE_MQTT, MQTT_WSS, HTTPS or DEFAULT.</summary>
    [JsonPropertyName("applicationProtocol")]
    public string? ApplicationProtocol { get; set; }

    /// <summary>An enumerated string that speciﬁes the authentication type. Valid values are CUSTOM_AUTH_X509, CUSTOM_AUTH, AWS_X509, AWS_SIGV4 or DEFAULT.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>An object that specifies the authorization service for a domain. See the authorizer_config Block below for details.</summary>
    [JsonPropertyName("authorizerConfig")]
    public V1beta1DomainConfigurationSpecInitProviderAuthorizerConfig? AuthorizerConfig { get; set; }

    /// <summary>Fully-qualified domain name.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The ARNs of the certificates that IoT passes to the device during the TLS handshake. Currently you can specify only one certificate ARN. This value is not required for Amazon Web Services-managed domains. When using a custom domain_name, the cert must include it.</summary>
    [JsonPropertyName("serverCertificateArns")]
    public IList<string>? ServerCertificateArns { get; set; }

    /// <summary>References to Certificate in acm to populate serverCertificateArns.</summary>
    [JsonPropertyName("serverCertificateArnsRefs")]
    public IList<V1beta1DomainConfigurationSpecInitProviderServerCertificateArnsRefs>? ServerCertificateArnsRefs { get; set; }

    /// <summary>Selector for a list of Certificate in acm to populate serverCertificateArns.</summary>
    [JsonPropertyName("serverCertificateArnsSelector")]
    public V1beta1DomainConfigurationSpecInitProviderServerCertificateArnsSelector? ServerCertificateArnsSelector { get; set; }

    /// <summary>The type of service delivered by the endpoint. Note: Amazon Web Services IoT Core currently supports only the DATA service type.</summary>
    [JsonPropertyName("serviceType")]
    public string? ServiceType { get; set; }

    /// <summary>The status to which the domain configuration should be set. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>An object that specifies the TLS configuration for a domain. See the tls_config Block below for details.</summary>
    [JsonPropertyName("tlsConfig")]
    public V1beta1DomainConfigurationSpecInitProviderTlsConfig? TlsConfig { get; set; }

    /// <summary>The certificate used to validate the server certificate and prove domain name ownership. This certificate must be signed by a public certificate authority. This value is not required for Amazon Web Services-managed domains.</summary>
    [JsonPropertyName("validationCertificateArn")]
    public string? ValidationCertificateArn { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecProviderConfigRefPolicy
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
public partial class V1beta1DomainConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DomainConfigurationSpec defines the desired state of DomainConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DomainConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DomainConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DomainConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DomainConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An object that specifies the authorization service for a domain. See the authorizer_config Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationStatusAtProviderAuthorizerConfig
{
    /// <summary>A Boolean that specifies whether the domain configuration's authorization service can be overridden.</summary>
    [JsonPropertyName("allowAuthorizerOverride")]
    public bool? AllowAuthorizerOverride { get; set; }

    /// <summary>The name of the authorization service for a domain configuration.</summary>
    [JsonPropertyName("defaultAuthorizerName")]
    public string? DefaultAuthorizerName { get; set; }
}

/// <summary>An object that specifies the TLS configuration for a domain. See the tls_config Block below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationStatusAtProviderTlsConfig
{
    /// <summary>The security policy for a domain configuration.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationStatusAtProvider
{
    /// <summary>An enumerated string that speciﬁes the application-layer protocol. Valid values are SECURE_MQTT, MQTT_WSS, HTTPS or DEFAULT.</summary>
    [JsonPropertyName("applicationProtocol")]
    public string? ApplicationProtocol { get; set; }

    /// <summary>The ARN of the domain configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>An enumerated string that speciﬁes the authentication type. Valid values are CUSTOM_AUTH_X509, CUSTOM_AUTH, AWS_X509, AWS_SIGV4 or DEFAULT.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>An object that specifies the authorization service for a domain. See the authorizer_config Block below for details.</summary>
    [JsonPropertyName("authorizerConfig")]
    public V1beta1DomainConfigurationStatusAtProviderAuthorizerConfig? AuthorizerConfig { get; set; }

    /// <summary>Fully-qualified domain name.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The type of the domain.</summary>
    [JsonPropertyName("domainType")]
    public string? DomainType { get; set; }

    /// <summary>The name of the created domain configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The ARNs of the certificates that IoT passes to the device during the TLS handshake. Currently you can specify only one certificate ARN. This value is not required for Amazon Web Services-managed domains. When using a custom domain_name, the cert must include it.</summary>
    [JsonPropertyName("serverCertificateArns")]
    public IList<string>? ServerCertificateArns { get; set; }

    /// <summary>The type of service delivered by the endpoint. Note: Amazon Web Services IoT Core currently supports only the DATA service type.</summary>
    [JsonPropertyName("serviceType")]
    public string? ServiceType { get; set; }

    /// <summary>The status to which the domain configuration should be set. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>An object that specifies the TLS configuration for a domain. See the tls_config Block below for details.</summary>
    [JsonPropertyName("tlsConfig")]
    public V1beta1DomainConfigurationStatusAtProviderTlsConfig? TlsConfig { get; set; }

    /// <summary>The certificate used to validate the server certificate and prove domain name ownership. This certificate must be signed by a public certificate authority. This value is not required for Amazon Web Services-managed domains.</summary>
    [JsonPropertyName("validationCertificateArn")]
    public string? ValidationCertificateArn { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationStatusConditions
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

/// <summary>DomainConfigurationStatus defines the observed state of DomainConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DomainConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DomainConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DomainConfiguration is the Schema for the DomainConfigurations API. Creates and manages an AWS IoT domain configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DomainConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DomainConfigurationSpec>, IStatus<V1beta1DomainConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DomainConfiguration";
    public const string KubeGroup = "iot.aws.upbound.io";
    public const string KubePluralName = "domainconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainConfigurationSpec defines the desired state of DomainConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1DomainConfigurationSpec Spec { get; set; }

    /// <summary>DomainConfigurationStatus defines the observed state of DomainConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1DomainConfigurationStatus? Status { get; set; }
}

/// <summary>DomainConfiguration is the Schema for the DomainConfigurations API. Creates and manages an AWS IoT domain configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DomainConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DomainConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DomainConfigurationList";
    public const string KubeGroup = "iot.aws.upbound.io";
    public const string KubePluralName = "domainconfigurations";
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
    public IList<V1beta1DomainConfiguration> Items { get; set; }
}