using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accesscontextmanager.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterMetadata
{
}

/// <summary>The AccessContextManagerAccessPolicy this AccessContextManagerServicePerimeter lives in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecAccessPolicyRef
{
    /// <summary>Allowed value: string of the format `accessPolicies/{{value}}`, where {{value}} is the `name` field of an `AccessContextManagerAccessPolicy` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Optional) A list of AccessLevel resource names that allow resources within the ServicePerimeter to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel is a syntax error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via GCP calls with request origins within the perimeter. For Service Perimeter Bridge, must be empty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecAccessLevels
{
    /// <summary>Allowed value: string of the format `{{parent}}/accessLevels/{{value}}`, where {{value}} is the `name` field of an `AccessContextManagerAccessLevel` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentitiesServiceAccountRef
{
    /// <summary>Allowed value: string of the format `serviceAccount:{{value}}`, where {{value}} is the `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Optional) A list of identities that are allowed access through this EgressPolicy. Should be in the format of email address. The email address should represent individual user or service account only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentities
{
    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>Defines conditions on the source of a request causing this 'EgressPolicy' to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFrom
{
    /// <summary></summary>
    [JsonPropertyName("identities")]
    public IList<AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access to outside the perimeter. If left unspecified, then members of 'identities' field will be allowed access. Possible values: ["IDENTITY_TYPE_UNSPECIFIED", "ANY_IDENTITY", "ANY_USER_ACCOUNT", "ANY_SERVICE_ACCOUNT"].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for 'method' should be a valid method name for the corresponding 'serviceName' in 'ApiOperation'. If '*' used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding 'serviceName' in 'ApiOperation'.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by 'serviceName' field. A single MethodSelector entry with '*' specified for the 'method' field will allow all methods AND permissions for the service specified in 'serviceName'.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the 'IngressPolicy' or 'EgressPolicy' want to allow. A single 'ApiOperation' with serviceName field set to '*' will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Optional) A list of resources, currently only projects in the form "projects/{project_number}". A request matches if it contains a resource in this list.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the 'ApiOperation' and destination resources that cause this 'EgressPolicy' to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of 'ApiOperations' that this egress rule applies to. A request matches if it contains an operation/service in this list.</summary>
    [JsonPropertyName("operations")]
    public IList<AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResources>? Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this 'EgressPolicy' to apply.</summary>
    [JsonPropertyName("egressFrom")]
    public AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the 'ApiOperation' and destination resources that cause this 'EgressPolicy' to apply.</summary>
    [JsonPropertyName("egressTo")]
    public AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressTo? EgressTo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentitiesServiceAccountRef
{
    /// <summary>Allowed value: string of the format `serviceAccount:{{value}}`, where {{value}} is the `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Optional) A list of identities that are allowed access through this ingress policy. Should be in the format of email address. The email address should represent individual user or service account only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentities
{
    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesAccessLevelRef
{
    /// <summary>Allowed value: string of the format `{{parent}}/accessLevels/{{value}}`, where {{value}} is the `name` field of an `AccessContextManagerAccessLevel` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Optional) A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects are allowed. Format "projects/{project_number}" The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter.</summary>
    [JsonPropertyName("accessLevelRef")]
    public AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>(Optional) A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects are allowed. Format "projects/{project_number}" The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in.</summary>
    [JsonPropertyName("projectRef")]
    public AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the source of a request causing this 'IngressPolicy' to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFrom
{
    /// <summary></summary>
    [JsonPropertyName("identities")]
    public IList<AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of 'identities' field will be allowed access. Possible values: ["IDENTITY_TYPE_UNSPECIFIED", "ANY_IDENTITY", "ANY_USER_ACCOUNT", "ANY_SERVICE_ACCOUNT"].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this 'IngressPolicy' authorizes access from.</summary>
    [JsonPropertyName("sources")]
    public IList<AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSources>? Sources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in 'ApiOperation'. If '*' used as value for 'method', then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding 'serviceName' in 'ApiOperation'.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single 'MethodSelector' entry with '*' specified for the method field will allow all methods AND permissions for the service specified in 'serviceName'.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the 'IngressPolicy' or 'EgressPolicy' want to allow. A single 'ApiOperation' with 'serviceName' field set to '*' will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A list of resources, currently only projects in the form "projects/{project_number}", protected by this ServicePerimeter that are allowed to be accessed by sources defined in the corresponding IngressFrom. A request matches if it contains a resource in this list.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the 'ApiOperation' and request destination that cause this 'IngressPolicy' to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressTo
{
    /// <summary>A list of 'ApiOperations' the sources specified in corresponding 'IngressFrom' are allowed to perform in this 'ServicePerimeter'.</summary>
    [JsonPropertyName("operations")]
    public IList<AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResources>? Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this 'IngressPolicy' to apply.</summary>
    [JsonPropertyName("ingressFrom")]
    public AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the 'ApiOperation' and request destination that cause this 'IngressPolicy' to apply.</summary>
    [JsonPropertyName("ingressTo")]
    public AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressTo? IngressTo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Optional) A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public AccessContextManagerServicePerimeterSpecSpecResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpecVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless 'enableRestriction' is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in 'allowedServices'.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

/// <summary>Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the 'useExplicitDryRunSpec' flag is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecSpec
{
    /// <summary></summary>
    [JsonPropertyName("accessLevels")]
    public IList<AccessContextManagerServicePerimeterSpecSpecAccessLevels>? AccessLevels { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<AccessContextManagerServicePerimeterSpecSpecEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of 'IngressPolicies' to apply to the perimeter. A perimeter may have multiple 'IngressPolicies', each of which is evaluated separately. Access is granted if any 'Ingress Policy' grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<AccessContextManagerServicePerimeterSpecSpecIngressPolicies>? IngressPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<AccessContextManagerServicePerimeterSpecSpecResources>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if 'storage.googleapis.com' is specified, access to the storage buckets inside the perimeter must meet the perimeter's access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public AccessContextManagerServicePerimeterSpecSpecVpcAccessibleServices? VpcAccessibleServices { get; set; }
}

/// <summary>(Optional) A list of AccessLevel resource names that allow resources within the ServicePerimeter to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel is a syntax error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via GCP calls with request origins within the perimeter. For Service Perimeter Bridge, must be empty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusAccessLevels
{
    /// <summary>Allowed value: string of the format `{{parent}}/accessLevels/{{value}}`, where {{value}} is the `name` field of an `AccessContextManagerAccessLevel` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentitiesServiceAccountRef
{
    /// <summary>Allowed value: string of the format `serviceAccount:{{value}}`, where {{value}} is the `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Optional) A list of identities that are allowed access through this EgressPolicy. Should be in the format of email address. The email address should represent individual user or service account only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentities
{
    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>Defines conditions on the source of a request causing this 'EgressPolicy' to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFrom
{
    /// <summary></summary>
    [JsonPropertyName("identities")]
    public IList<AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access to outside the perimeter. If left unspecified, then members of 'identities' field will be allowed access. Possible values: ["IDENTITY_TYPE_UNSPECIFIED", "ANY_IDENTITY", "ANY_USER_ACCOUNT", "ANY_SERVICE_ACCOUNT"].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for 'method' should be a valid method name for the corresponding 'serviceName' in 'ApiOperation'. If '*' used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding 'serviceName' in 'ApiOperation'.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by 'serviceName' field. A single MethodSelector entry with '*' specified for the 'method' field will allow all methods AND permissions for the service specified in 'serviceName'.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the 'IngressPolicy' or 'EgressPolicy' want to allow. A single 'ApiOperation' with serviceName field set to '*' will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Optional) A list of resources, currently only projects in the form "projects/{project_number}". A request matches if it contains a resource in this list.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the 'ApiOperation' and destination resources that cause this 'EgressPolicy' to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of 'ApiOperations' that this egress rule applies to. A request matches if it contains an operation/service in this list.</summary>
    [JsonPropertyName("operations")]
    public IList<AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResources>? Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this 'EgressPolicy' to apply.</summary>
    [JsonPropertyName("egressFrom")]
    public AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the 'ApiOperation' and destination resources that cause this 'EgressPolicy' to apply.</summary>
    [JsonPropertyName("egressTo")]
    public AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressTo? EgressTo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentitiesServiceAccountRef
{
    /// <summary>Allowed value: string of the format `serviceAccount:{{value}}`, where {{value}} is the `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Optional) A list of identities that are allowed access through this EgressPolicy. Should be in the format of email address. The email address should represent individual user or service account only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentities
{
    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

/// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesAccessLevelRef
{
    /// <summary>Allowed value: string of the format `{{parent}}/accessLevels/{{value}}`, where {{value}} is the `name` field of an `AccessContextManagerAccessLevel` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Optional) A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects are allowed. Format "projects/{project_number}" The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter.</summary>
    [JsonPropertyName("accessLevelRef")]
    public AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>(Optional) A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects are allowed. Format "projects/{project_number}" The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in.</summary>
    [JsonPropertyName("projectRef")]
    public AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the source of a request causing this 'IngressPolicy' to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFrom
{
    /// <summary></summary>
    [JsonPropertyName("identities")]
    public IList<AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of 'identities' field will be allowed access. Possible values: ["IDENTITY_TYPE_UNSPECIFIED", "ANY_IDENTITY", "ANY_USER_ACCOUNT", "ANY_SERVICE_ACCOUNT"].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this 'IngressPolicy' authorizes access from.</summary>
    [JsonPropertyName("sources")]
    public IList<AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSources>? Sources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in 'ApiOperation'. If '*' used as value for 'method', then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding 'serviceName' in 'ApiOperation'.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single 'MethodSelector' entry with '*' specified for the method field will allow all methods AND permissions for the service specified in 'serviceName'.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the 'IngressPolicy' or 'EgressPolicy' want to allow. A single 'ApiOperation' with 'serviceName' field set to '*' will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A list of resources, currently only projects in the form "projects/{project_number}", protected by this ServicePerimeter that are allowed to be accessed by sources defined in the corresponding IngressFrom. A request matches if it contains a resource in this list.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Defines the conditions on the 'ApiOperation' and request destination that cause this 'IngressPolicy' to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressTo
{
    /// <summary>A list of 'ApiOperations' the sources specified in corresponding 'IngressFrom' are allowed to perform in this 'ServicePerimeter'.</summary>
    [JsonPropertyName("operations")]
    public IList<AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResources>? Resources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this 'IngressPolicy' to apply.</summary>
    [JsonPropertyName("ingressFrom")]
    public AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the 'ApiOperation' and request destination that cause this 'IngressPolicy' to apply.</summary>
    [JsonPropertyName("ingressTo")]
    public AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressTo? IngressTo { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusResourcesProjectRef
{
    /// <summary>Allowed value: string of the format `projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>(Optional) A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public AccessContextManagerServicePerimeterSpecStatusResourcesProjectRef? ProjectRef { get; set; }
}

/// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatusVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless 'enableRestriction' is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in 'allowedServices'.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

/// <summary>ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels that determine perimeter content and boundaries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpecStatus
{
    /// <summary></summary>
    [JsonPropertyName("accessLevels")]
    public IList<AccessContextManagerServicePerimeterSpecStatusAccessLevels>? AccessLevels { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<AccessContextManagerServicePerimeterSpecStatusEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of 'IngressPolicies' to apply to the perimeter. A perimeter may have multiple 'IngressPolicies', each of which is evaluated separately. Access is granted if any 'Ingress Policy' grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<AccessContextManagerServicePerimeterSpecStatusIngressPolicies>? IngressPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<AccessContextManagerServicePerimeterSpecStatusResources>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if 'storage.googleapis.com' is specified, access to the storage buckets inside the perimeter must meet the perimeter's access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public AccessContextManagerServicePerimeterSpecStatusVpcAccessibleServices? VpcAccessibleServices { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterSpec
{
    /// <summary>The AccessContextManagerAccessPolicy this AccessContextManagerServicePerimeter lives in.</summary>
    [JsonPropertyName("accessPolicyRef")]
    public AccessContextManagerServicePerimeterSpecAccessPolicyRef AccessPolicyRef { get; set; }

    /// <summary>Description of the ServicePerimeter and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Specifies the type of the Perimeter. There are two types: regular and bridge. Regular Service Perimeter contains resources, access levels, and restricted services. Every resource can be in at most ONE regular Service Perimeter.  In addition to being in a regular service perimeter, a resource can also be in zero or more perimeter bridges. A perimeter bridge only contains resources. Cross project operations are permitted if all effected resources share some perimeter (whether bridge or regular). Perimeter Bridge does not contain access levels or services: those are governed entirely by the regular perimeter that resource is in.  Perimeter Bridges are typically useful when building more complex topologies with many independent perimeters that need to share some data with a common perimeter, but should not be able to share data among themselves. Default value: "PERIMETER_TYPE_REGULAR" Possible values: ["PERIMETER_TYPE_REGULAR", "PERIMETER_TYPE_BRIDGE"].</summary>
    [JsonPropertyName("perimeterType")]
    public string? PerimeterType { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the 'useExplicitDryRunSpec' flag is set.</summary>
    [JsonPropertyName("spec")]
    public AccessContextManagerServicePerimeterSpecSpec? Spec { get; set; }

    /// <summary>ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels that determine perimeter content and boundaries.</summary>
    [JsonPropertyName("status")]
    public AccessContextManagerServicePerimeterSpecStatus? Status { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists for all Service Perimeters, and that spec is identical to the status for those Service Perimeters. When this flag is set, it inhibits the generation of the implicit spec, thereby allowing the user to explicitly provide a configuration ("spec") to use in a dry-run version of the Service Perimeter. This allows the user to test changes to the enforced config ("status") without actually enforcing them. This testing is done through analyzing the differences between currently enforced and suggested restrictions. useExplicitDryRunSpec must bet set to True if any of the fields in the spec are set to non-default values.</summary>
    [JsonPropertyName("useExplicitDryRunSpec")]
    public bool? UseExplicitDryRunSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeterStatusConditions
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
public partial class AccessContextManagerServicePerimeterStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<AccessContextManagerServicePerimeterStatusConditions>? Conditions { get; set; }

    /// <summary>Time the AccessPolicy was created in UTC.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Time the AccessPolicy was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AccessContextManagerServicePerimeter
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public AccessContextManagerServicePerimeterMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public AccessContextManagerServicePerimeterSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public AccessContextManagerServicePerimeterStatus? Status { get; set; }
}