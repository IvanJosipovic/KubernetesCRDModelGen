using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accesscontextmanager.cnrm.cloud.google.com;
public partial class V1beta1AccessContextManagerServicePerimeterSpecAccessPolicyRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecAccessLevels
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentitiesServiceAccountRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentities
{
    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFrom
{
    /// <summary></summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access to outside the perimeter. If left unspecified, then members of 'identities' field will be allowed access. Possible values: ["IDENTITY_TYPE_UNSPECIFIED", "ANY_IDENTITY", "ANY_USER_ACCOUNT", "ANY_SERVICE_ACCOUNT"].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for 'method' should be a valid method name for the corresponding 'serviceName' in 'ApiOperation'. If '*' used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding 'serviceName' in 'ApiOperation'.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by 'serviceName' field. A single MethodSelector entry with '*' specified for the 'method' field will allow all methods AND permissions for the service specified in 'serviceName'.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the 'IngressPolicy' or 'EgressPolicy' want to allow. A single 'ApiOperation' with serviceName field set to '*' will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResourcesProjectRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResourcesProjectRef? ProjectRef { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of 'ApiOperations' that this egress rule applies to. A request matches if it contains an operation/service in this list.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressToResources>? Resources { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this 'EgressPolicy' to apply.</summary>
    [JsonPropertyName("egressFrom")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the 'ApiOperation' and destination resources that cause this 'EgressPolicy' to apply.</summary>
    [JsonPropertyName("egressTo")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPoliciesEgressTo? EgressTo { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentitiesServiceAccountRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentities
{
    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesAccessLevelRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesProjectRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter.</summary>
    [JsonPropertyName("accessLevelRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>(Optional) A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects are allowed. Format "projects/{project_number}" The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSourcesProjectRef? ProjectRef { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFrom
{
    /// <summary></summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of 'identities' field will be allowed access. Possible values: ["IDENTITY_TYPE_UNSPECIFIED", "ANY_IDENTITY", "ANY_USER_ACCOUNT", "ANY_SERVICE_ACCOUNT"].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this 'IngressPolicy' authorizes access from.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFromSources>? Sources { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in 'ApiOperation'. If '*' used as value for 'method', then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding 'serviceName' in 'ApiOperation'.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single 'MethodSelector' entry with '*' specified for the method field will allow all methods AND permissions for the service specified in 'serviceName'.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the 'IngressPolicy' or 'EgressPolicy' want to allow. A single 'ApiOperation' with 'serviceName' field set to '*' will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResourcesProjectRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResourcesProjectRef? ProjectRef { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressTo
{
    /// <summary>A list of 'ApiOperations' the sources specified in corresponding 'IngressFrom' are allowed to perform in this 'ServicePerimeter'.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressToResources>? Resources { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this 'IngressPolicy' to apply.</summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the 'ApiOperation' and request destination that cause this 'IngressPolicy' to apply.</summary>
    [JsonPropertyName("ingressTo")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPoliciesIngressTo? IngressTo { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecResourcesProjectRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecResourcesProjectRef? ProjectRef { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpecVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless 'enableRestriction' is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in 'allowedServices'.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecSpec
{
    /// <summary></summary>
    [JsonPropertyName("accessLevels")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecAccessLevels>? AccessLevels { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of 'IngressPolicies' to apply to the perimeter. A perimeter may have multiple 'IngressPolicies', each of which is evaluated separately. Access is granted if any 'Ingress Policy' grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecIngressPolicies>? IngressPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecSpecResources>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if 'storage.googleapis.com' is specified, access to the storage buckets inside the perimeter must meet the perimeter's access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta1AccessContextManagerServicePerimeterSpecSpecVpcAccessibleServices? VpcAccessibleServices { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusAccessLevels
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentitiesServiceAccountRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentities
{
    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFrom
{
    /// <summary></summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access to outside the perimeter. If left unspecified, then members of 'identities' field will be allowed access. Possible values: ["IDENTITY_TYPE_UNSPECIFIED", "ANY_IDENTITY", "ANY_USER_ACCOUNT", "ANY_SERVICE_ACCOUNT"].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for 'method' should be a valid method name for the corresponding 'serviceName' in 'ApiOperation'. If '*' used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding 'serviceName' in 'ApiOperation'.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by 'serviceName' field. A single MethodSelector entry with '*' specified for the 'method' field will allow all methods AND permissions for the service specified in 'serviceName'.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the 'IngressPolicy' or 'EgressPolicy' want to allow. A single 'ApiOperation' with serviceName field set to '*' will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResourcesProjectRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResourcesProjectRef? ProjectRef { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of 'ApiOperations' that this egress rule applies to. A request matches if it contains an operation/service in this list.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressToResources>? Resources { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this 'EgressPolicy' to apply.</summary>
    [JsonPropertyName("egressFrom")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the 'ApiOperation' and destination resources that cause this 'EgressPolicy' to apply.</summary>
    [JsonPropertyName("egressTo")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPoliciesEgressTo? EgressTo { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentitiesServiceAccountRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentities
{
    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentitiesServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesAccessLevelRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesProjectRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter.</summary>
    [JsonPropertyName("accessLevelRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>(Optional) A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects are allowed. Format "projects/{project_number}" The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSourcesProjectRef? ProjectRef { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFrom
{
    /// <summary></summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromIdentities>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of 'identities' field will be allowed access. Possible values: ["IDENTITY_TYPE_UNSPECIFIED", "ANY_IDENTITY", "ANY_USER_ACCOUNT", "ANY_SERVICE_ACCOUNT"].</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this 'IngressPolicy' authorizes access from.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFromSources>? Sources { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in 'ApiOperation'. If '*' used as value for 'method', then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding 'serviceName' in 'ApiOperation'.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single 'MethodSelector' entry with '*' specified for the method field will allow all methods AND permissions for the service specified in 'serviceName'.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the 'IngressPolicy' or 'EgressPolicy' want to allow. A single 'ApiOperation' with 'serviceName' field set to '*' will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResourcesProjectRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResourcesProjectRef? ProjectRef { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressTo
{
    /// <summary>A list of 'ApiOperations' the sources specified in corresponding 'IngressFrom' are allowed to perform in this 'ServicePerimeter'.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressToResources>? Resources { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this 'IngressPolicy' to apply.</summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the 'ApiOperation' and request destination that cause this 'IngressPolicy' to apply.</summary>
    [JsonPropertyName("ingressTo")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPoliciesIngressTo? IngressTo { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusResourcesProjectRef
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

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusResources
{
    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusResourcesProjectRef? ProjectRef { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatusVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless 'enableRestriction' is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in 'allowedServices'.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpecStatus
{
    /// <summary></summary>
    [JsonPropertyName("accessLevels")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusAccessLevels>? AccessLevels { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of 'IngressPolicies' to apply to the perimeter. A perimeter may have multiple 'IngressPolicies', each of which is evaluated separately. Access is granted if any 'Ingress Policy' grants it. Must be empty for a perimeter bridge.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusIngressPolicies>? IngressPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1AccessContextManagerServicePerimeterSpecStatusResources>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if 'storage.googleapis.com' is specified, access to the storage buckets inside the perimeter must meet the perimeter's access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatusVpcAccessibleServices? VpcAccessibleServices { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterSpec
{
    /// <summary>The AccessContextManagerAccessPolicy this AccessContextManagerServicePerimeter lives in.</summary>
    [JsonPropertyName("accessPolicyRef")]
    public V1beta1AccessContextManagerServicePerimeterSpecAccessPolicyRef AccessPolicyRef { get; set; }

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
    public V1beta1AccessContextManagerServicePerimeterSpecSpec? Spec { get; set; }

    /// <summary>ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels that determine perimeter content and boundaries.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccessContextManagerServicePerimeterSpecStatus? Status { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists for all Service Perimeters, and that spec is identical to the status for those Service Perimeters. When this flag is set, it inhibits the generation of the implicit spec, thereby allowing the user to explicitly provide a configuration ("spec") to use in a dry-run version of the Service Perimeter. This allows the user to test changes to the enforced config ("status") without actually enforcing them. This testing is done through analyzing the differences between currently enforced and suggested restrictions. useExplicitDryRunSpec must bet set to True if any of the fields in the spec are set to non-default values.</summary>
    [JsonPropertyName("useExplicitDryRunSpec")]
    public bool? UseExplicitDryRunSpec { get; set; }
}

public partial class V1beta1AccessContextManagerServicePerimeterStatusConditions
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

public partial class V1beta1AccessContextManagerServicePerimeterStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessContextManagerServicePerimeterStatusConditions>? Conditions { get; set; }

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

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessContextManagerServicePerimeter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccessContextManagerServicePerimeterSpec>, IStatus<V1beta1AccessContextManagerServicePerimeterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessContextManagerServicePerimeter";
    public const string KubeGroup = "accesscontextmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "accesscontextmanagerserviceperimeters";
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
    public V1beta1AccessContextManagerServicePerimeterSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1AccessContextManagerServicePerimeterStatus? Status { get; set; }
}