using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.upbound.io;
#nullable enable
/// <summary>Backend is the Schema for the Backends API. Manages a backend within an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackendList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Backend>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackendList";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "backends";
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
    public IList<V1beta1Backend> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderApiManagementNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderApiManagementNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendSpecForProviderApiManagementNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderApiManagementNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderApiManagementNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendSpecForProviderApiManagementNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderCredentialsAuthorization
{
    /// <summary>The authentication Parameter value.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The authentication Scheme name.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderCredentials
{
    /// <summary>An authorization block as defined below.</summary>
    [JsonPropertyName("authorization")]
    public IList<V1beta1BackendSpecForProviderCredentialsAuthorization>? Authorization { get; set; }

    /// <summary>A list of client certificate thumbprints to present to the backend host. The certificates must exist within the API Management Service.</summary>
    [JsonPropertyName("certificate")]
    public IList<string>? Certificate { get; set; }

    /// <summary>A mapping of header parameters to pass to the backend host. The keys are the header names and the values are a comma separated string of header values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("header")]
    public IDictionary<string, string>? Header { get; set; }

    /// <summary>A mapping of query parameters to pass to the backend host. The keys are the query names and the values are a comma separated string of query values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("query")]
    public IDictionary<string, string>? Query { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The password to connect to the proxy server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderProxyPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderProxy
{
    /// <summary>The password to connect to the proxy server.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1BackendSpecForProviderProxyPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The URL of the proxy server.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The username to connect to the proxy server.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderServiceFabricClusterServerX509Name
{
    /// <summary>The thumbprint for the issuer of the certificate.</summary>
    [JsonPropertyName("issuerCertificateThumbprint")]
    public string? IssuerCertificateThumbprint { get; set; }

    /// <summary>The common name of the certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderServiceFabricCluster
{
    /// <summary>The client certificate resource id for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    /// <summary>The client certificate thumbprint for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public string? ClientCertificateThumbprint { get; set; }

    /// <summary>A list of cluster management endpoints.</summary>
    [JsonPropertyName("managementEndpoints")]
    public IList<string>? ManagementEndpoints { get; set; }

    /// <summary>The maximum number of retries when attempting resolve the partition.</summary>
    [JsonPropertyName("maxPartitionResolutionRetries")]
    public double? MaxPartitionResolutionRetries { get; set; }

    /// <summary>A list of thumbprints of the server certificates of the Service Fabric cluster.</summary>
    [JsonPropertyName("serverCertificateThumbprints")]
    public IList<string>? ServerCertificateThumbprints { get; set; }

    /// <summary>One or more server_x509_name blocks as documented below.</summary>
    [JsonPropertyName("serverX509Name")]
    public IList<V1beta1BackendSpecForProviderServiceFabricClusterServerX509Name>? ServerX509Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderTls
{
    /// <summary>Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateChain")]
    public bool? ValidateCertificateChain { get; set; }

    /// <summary>Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateName")]
    public bool? ValidateCertificateName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProvider
{
    /// <summary>The Name of the API Management Service where this backend should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameRef")]
    public V1beta1BackendSpecForProviderApiManagementNameRef? ApiManagementNameRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameSelector")]
    public V1beta1BackendSpecForProviderApiManagementNameSelector? ApiManagementNameSelector { get; set; }

    /// <summary>A credentials block as documented below.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1beta1BackendSpecForProviderCredentials>? Credentials { get; set; }

    /// <summary>The description of the backend.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The protocol used by the backend host. Possible values are http or soap.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>A proxy block as documented below.</summary>
    [JsonPropertyName("proxy")]
    public IList<V1beta1BackendSpecForProviderProxy>? Proxy { get; set; }

    /// <summary>The Name of the Resource Group where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1BackendSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1BackendSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The management URI of the backend host in an external system. This URI can be the ARM Resource ID of Logic Apps, Function Apps or API Apps, or the management endpoint of a Service Fabric cluster.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>A service_fabric_cluster block as documented below.</summary>
    [JsonPropertyName("serviceFabricCluster")]
    public IList<V1beta1BackendSpecForProviderServiceFabricCluster>? ServiceFabricCluster { get; set; }

    /// <summary>The title of the backend.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A tls block as documented below.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1BackendSpecForProviderTls>? Tls { get; set; }

    /// <summary>The URL of the backend host.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderCredentialsAuthorization
{
    /// <summary>The authentication Parameter value.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The authentication Scheme name.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderCredentials
{
    /// <summary>An authorization block as defined below.</summary>
    [JsonPropertyName("authorization")]
    public IList<V1beta1BackendSpecInitProviderCredentialsAuthorization>? Authorization { get; set; }

    /// <summary>A list of client certificate thumbprints to present to the backend host. The certificates must exist within the API Management Service.</summary>
    [JsonPropertyName("certificate")]
    public IList<string>? Certificate { get; set; }

    /// <summary>A mapping of header parameters to pass to the backend host. The keys are the header names and the values are a comma separated string of header values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("header")]
    public IDictionary<string, string>? Header { get; set; }

    /// <summary>A mapping of query parameters to pass to the backend host. The keys are the query names and the values are a comma separated string of query values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("query")]
    public IDictionary<string, string>? Query { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderProxy
{
    /// <summary>The URL of the proxy server.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The username to connect to the proxy server.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderServiceFabricClusterServerX509Name
{
    /// <summary>The thumbprint for the issuer of the certificate.</summary>
    [JsonPropertyName("issuerCertificateThumbprint")]
    public string? IssuerCertificateThumbprint { get; set; }

    /// <summary>The common name of the certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderServiceFabricCluster
{
    /// <summary>The client certificate resource id for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    /// <summary>The client certificate thumbprint for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public string? ClientCertificateThumbprint { get; set; }

    /// <summary>A list of cluster management endpoints.</summary>
    [JsonPropertyName("managementEndpoints")]
    public IList<string>? ManagementEndpoints { get; set; }

    /// <summary>The maximum number of retries when attempting resolve the partition.</summary>
    [JsonPropertyName("maxPartitionResolutionRetries")]
    public double? MaxPartitionResolutionRetries { get; set; }

    /// <summary>A list of thumbprints of the server certificates of the Service Fabric cluster.</summary>
    [JsonPropertyName("serverCertificateThumbprints")]
    public IList<string>? ServerCertificateThumbprints { get; set; }

    /// <summary>One or more server_x509_name blocks as documented below.</summary>
    [JsonPropertyName("serverX509Name")]
    public IList<V1beta1BackendSpecInitProviderServiceFabricClusterServerX509Name>? ServerX509Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderTls
{
    /// <summary>Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateChain")]
    public bool? ValidateCertificateChain { get; set; }

    /// <summary>Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateName")]
    public bool? ValidateCertificateName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProvider
{
    /// <summary>A credentials block as documented below.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1beta1BackendSpecInitProviderCredentials>? Credentials { get; set; }

    /// <summary>The description of the backend.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The protocol used by the backend host. Possible values are http or soap.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>A proxy block as documented below.</summary>
    [JsonPropertyName("proxy")]
    public IList<V1beta1BackendSpecInitProviderProxy>? Proxy { get; set; }

    /// <summary>The management URI of the backend host in an external system. This URI can be the ARM Resource ID of Logic Apps, Function Apps or API Apps, or the management endpoint of a Service Fabric cluster.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>A service_fabric_cluster block as documented below.</summary>
    [JsonPropertyName("serviceFabricCluster")]
    public IList<V1beta1BackendSpecInitProviderServiceFabricCluster>? ServiceFabricCluster { get; set; }

    /// <summary>The title of the backend.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A tls block as documented below.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1BackendSpecInitProviderTls>? Tls { get; set; }

    /// <summary>The URL of the backend host.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BackendSpec defines the desired state of Backend</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BackendSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BackendSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BackendSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BackendSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderCredentialsAuthorization
{
    /// <summary>The authentication Parameter value.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The authentication Scheme name.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderCredentials
{
    /// <summary>An authorization block as defined below.</summary>
    [JsonPropertyName("authorization")]
    public IList<V1beta1BackendStatusAtProviderCredentialsAuthorization>? Authorization { get; set; }

    /// <summary>A list of client certificate thumbprints to present to the backend host. The certificates must exist within the API Management Service.</summary>
    [JsonPropertyName("certificate")]
    public IList<string>? Certificate { get; set; }

    /// <summary>A mapping of header parameters to pass to the backend host. The keys are the header names and the values are a comma separated string of header values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("header")]
    public IDictionary<string, string>? Header { get; set; }

    /// <summary>A mapping of query parameters to pass to the backend host. The keys are the query names and the values are a comma separated string of query values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("query")]
    public IDictionary<string, string>? Query { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderProxy
{
    /// <summary>The URL of the proxy server.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The username to connect to the proxy server.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderServiceFabricClusterServerX509Name
{
    /// <summary>The thumbprint for the issuer of the certificate.</summary>
    [JsonPropertyName("issuerCertificateThumbprint")]
    public string? IssuerCertificateThumbprint { get; set; }

    /// <summary>The common name of the certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderServiceFabricCluster
{
    /// <summary>The client certificate resource id for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    /// <summary>The client certificate thumbprint for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public string? ClientCertificateThumbprint { get; set; }

    /// <summary>A list of cluster management endpoints.</summary>
    [JsonPropertyName("managementEndpoints")]
    public IList<string>? ManagementEndpoints { get; set; }

    /// <summary>The maximum number of retries when attempting resolve the partition.</summary>
    [JsonPropertyName("maxPartitionResolutionRetries")]
    public double? MaxPartitionResolutionRetries { get; set; }

    /// <summary>A list of thumbprints of the server certificates of the Service Fabric cluster.</summary>
    [JsonPropertyName("serverCertificateThumbprints")]
    public IList<string>? ServerCertificateThumbprints { get; set; }

    /// <summary>One or more server_x509_name blocks as documented below.</summary>
    [JsonPropertyName("serverX509Name")]
    public IList<V1beta1BackendStatusAtProviderServiceFabricClusterServerX509Name>? ServerX509Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderTls
{
    /// <summary>Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateChain")]
    public bool? ValidateCertificateChain { get; set; }

    /// <summary>Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateName")]
    public bool? ValidateCertificateName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProvider
{
    /// <summary>The Name of the API Management Service where this backend should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>A credentials block as documented below.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1beta1BackendStatusAtProviderCredentials>? Credentials { get; set; }

    /// <summary>The description of the backend.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the API Management API.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The protocol used by the backend host. Possible values are http or soap.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>A proxy block as documented below.</summary>
    [JsonPropertyName("proxy")]
    public IList<V1beta1BackendStatusAtProviderProxy>? Proxy { get; set; }

    /// <summary>The Name of the Resource Group where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The management URI of the backend host in an external system. This URI can be the ARM Resource ID of Logic Apps, Function Apps or API Apps, or the management endpoint of a Service Fabric cluster.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>A service_fabric_cluster block as documented below.</summary>
    [JsonPropertyName("serviceFabricCluster")]
    public IList<V1beta1BackendStatusAtProviderServiceFabricCluster>? ServiceFabricCluster { get; set; }

    /// <summary>The title of the backend.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A tls block as documented below.</summary>
    [JsonPropertyName("tls")]
    public IList<V1beta1BackendStatusAtProviderTls>? Tls { get; set; }

    /// <summary>The URL of the backend host.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusConditions
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
/// <summary>BackendStatus defines the observed state of Backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BackendStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackendStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Backend is the Schema for the Backends API. Manages a backend within an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Backend : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackendSpec>, IStatus<V1beta1BackendStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Backend";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "backends";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackendSpec defines the desired state of Backend</summary>
    [JsonPropertyName("spec")]
    public V1beta1BackendSpec Spec { get; set; }

    /// <summary>BackendStatus defines the observed state of Backend.</summary>
    [JsonPropertyName("status")]
    public V1beta1BackendStatus? Status { get; set; }
}
#nullable disable
