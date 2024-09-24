using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appengine.cnrm.cloud.google.com;
/// <summary>SSL configuration for this domain. If unconfigured, this domain will not serve with SSL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppEngineDomainMappingSpecSslSettings
{
    /// <summary>ID of the AuthorizedCertificate resource configuring SSL for the application. Clearing this field will remove SSL support. By default, a managed certificate is automatically created for every domain mapping. To omit SSL support or to configure SSL manually, specify 'SslManagementType.MANUAL' on a 'CREATE' or 'UPDATE' request. You must be authorized to administer the 'AuthorizedCertificate' resource to manually map it to a DomainMapping resource. Example: 12345.</summary>
    [JsonPropertyName("certificateId")]
    public string? CertificateId { get; set; }

    /// <summary>ID of the managed 'AuthorizedCertificate' resource currently being provisioned, if applicable. Until the new managed certificate has been successfully provisioned, the previous SSL state will be preserved. Once the provisioning process completes, the 'certificateId' field will reflect the new managed certificate and this field will be left empty. To remove SSL support while there is still a pending managed certificate, clear the 'certificateId' field with an update request.</summary>
    [JsonPropertyName("pendingManagedCertificateId")]
    public string? PendingManagedCertificateId { get; set; }

    /// <summary>SSL management type for this domain. If 'AUTOMATIC', a managed certificate is automatically provisioned. If 'MANUAL', 'certificateId' must be manually specified in order to configure SSL for this domain. Possible values: ["AUTOMATIC", "MANUAL"].</summary>
    [JsonPropertyName("sslManagementType")]
    public string SslManagementType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppEngineDomainMappingSpec
{
    /// <summary>Whether the domain creation should override any existing mappings for this domain. By default, overrides are rejected. Default value: "STRICT" Possible values: ["STRICT", "OVERRIDE"].</summary>
    [JsonPropertyName("overrideStrategy")]
    public string? OverrideStrategy { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Immutable. Optional. The domainName of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>SSL configuration for this domain. If unconfigured, this domain will not serve with SSL.</summary>
    [JsonPropertyName("sslSettings")]
    public V1alpha1AppEngineDomainMappingSpecSslSettings? SslSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppEngineDomainMappingStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppEngineDomainMappingStatusResourceRecords
{
    /// <summary>Relative name of the object affected by this record. Only applicable for CNAME records. Example: 'www'.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Data for this record. Values vary by record type, as defined in RFC 1035 (section 5) and RFC 1034 (section 3.6.1).</summary>
    [JsonPropertyName("rrdata")]
    public string? Rrdata { get; set; }

    /// <summary>Resource record type. Example: 'AAAA'. Possible values: ["A", "AAAA", "CNAME"].</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppEngineDomainMappingStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AppEngineDomainMappingStatusConditions>? Conditions { get; set; }

    /// <summary>Full path to the DomainMapping resource in the API. Example: apps/myapp/domainMapping/example.com.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The resource records required to configure this domain mapping. These records must be added to the domain's DNS configuration in order to serve the application via this domain mapping.</summary>
    [JsonPropertyName("resourceRecords")]
    public IList<V1alpha1AppEngineDomainMappingStatusResourceRecords>? ResourceRecords { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppEngineDomainMapping : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AppEngineDomainMappingSpec>, IStatus<V1alpha1AppEngineDomainMappingStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppEngineDomainMapping";
    public const string KubeGroup = "appengine.cnrm.cloud.google.com";
    public const string KubePluralName = "appenginedomainmappings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1alpha1AppEngineDomainMappingSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1AppEngineDomainMappingStatus? Status { get; set; }
}