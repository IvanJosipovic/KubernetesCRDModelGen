using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accesscontextmanager.gcp.m.upbound.io;
#nullable enable
/// <summary>ServicePerimeter is the Schema for the ServicePerimeters API. ServicePerimeter describes a set of GCP resources which can freely import and export data amongst themselves, but not export outside of the ServicePerimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServicePerimeterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ServicePerimeter>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServicePerimeterList";
    public const string KubeGroup = "accesscontextmanager.gcp.m.upbound.io";
    public const string KubePluralName = "serviceperimeters";
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
    public IList<V1beta1ServicePerimeter> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecAccessLevelsRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecAccessLevelsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecForProviderSpecAccessLevelsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecAccessLevelsSelectorPolicy
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
/// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecAccessLevelsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecForProviderSpecAccessLevelsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecEgressPoliciesEgressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecEgressPoliciesEgressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED. Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.</summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterSpecForProviderSpecEgressPoliciesEgressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterSpecForProviderSpecEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterSpecForProviderSpecEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressFrom")]
    public V1beta1ServicePerimeterSpecForProviderSpecEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressTo")]
    public V1beta1ServicePerimeterSpecForProviderSpecEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecIngressPoliciesIngressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecIngressPoliciesIngressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterSpecForProviderSpecIngressPoliciesIngressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterSpecForProviderSpecIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecIngressPoliciesIngressTo
{
    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterSpecForProviderSpecIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta1ServicePerimeterSpecForProviderSpecIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressTo")]
    public V1beta1ServicePerimeterSpecForProviderSpecIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpecVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless enableRestriction is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in 'allowedServices'.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the useExplicitDryRunSpec flag is set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderSpec
{
    /// <summary>A list of AccessLevel resource names that allow resources within the ServicePerimeter to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel is a syntax error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via GCP calls with request origins within the perimeter. For Service Perimeter Bridge, must be empty. Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}</summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>References to AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsRefs")]
    public IList<V1beta1ServicePerimeterSpecForProviderSpecAccessLevelsRefs>? AccessLevelsRefs { get; set; }

    /// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsSelector")]
    public V1beta1ServicePerimeterSpecForProviderSpecAccessLevelsSelector? AccessLevelsSelector { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta1ServicePerimeterSpecForProviderSpecEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of IngressPolicies to apply to the perimeter. A perimeter may have multiple IngressPolicies, each of which is evaluated separately. Access is granted if any Ingress Policy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta1ServicePerimeterSpecForProviderSpecIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if storage.googleapis.com is specified, access to the storage buckets inside the perimeter must meet the perimeter's access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta1ServicePerimeterSpecForProviderSpecVpcAccessibleServices? VpcAccessibleServices { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusAccessLevelsRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusAccessLevelsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecForProviderStatusAccessLevelsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusAccessLevelsSelectorPolicy
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
/// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusAccessLevelsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecForProviderStatusAccessLevelsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusEgressPoliciesEgressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusEgressPoliciesEgressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED. Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.</summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterSpecForProviderStatusEgressPoliciesEgressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterSpecForProviderStatusEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterSpecForProviderStatusEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressFrom")]
    public V1beta1ServicePerimeterSpecForProviderStatusEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressTo")]
    public V1beta1ServicePerimeterSpecForProviderStatusEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicy
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
/// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicy
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
/// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelRef")]
    public V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelSelector")]
    public V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelector? AccessLevelSelector { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressTo
{
    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressTo")]
    public V1beta1ServicePerimeterSpecForProviderStatusIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatusVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless enableRestriction is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in 'allowedServices'.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels that determine perimeter content and boundaries. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProviderStatus
{
    /// <summary>A list of AccessLevel resource names that allow resources within the ServicePerimeter to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel is a syntax error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via GCP calls with request origins within the perimeter. For Service Perimeter Bridge, must be empty. Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}</summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>References to AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsRefs")]
    public IList<V1beta1ServicePerimeterSpecForProviderStatusAccessLevelsRefs>? AccessLevelsRefs { get; set; }

    /// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsSelector")]
    public V1beta1ServicePerimeterSpecForProviderStatusAccessLevelsSelector? AccessLevelsSelector { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta1ServicePerimeterSpecForProviderStatusEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of IngressPolicies to apply to the perimeter. A perimeter may have multiple IngressPolicies, each of which is evaluated separately. Access is granted if any Ingress Policy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta1ServicePerimeterSpecForProviderStatusIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if storage.googleapis.com is specified, access to the storage buckets inside the perimeter must meet the perimeter's access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta1ServicePerimeterSpecForProviderStatusVpcAccessibleServices? VpcAccessibleServices { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecForProvider
{
    /// <summary>Description of the ServicePerimeter and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Resource name for the ServicePerimeter. The short_name component must begin with a letter and only include alphanumeric and '_'. Format: accessPolicies/{policy_id}/servicePerimeters/{short_name}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The AccessPolicy this ServicePerimeter lives in. Format: accessPolicies/{policy_id}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Specifies the type of the Perimeter. There are two types: regular and bridge. Regular Service Perimeter contains resources, access levels, and restricted services. Every resource can be in at most ONE regular Service Perimeter. In addition to being in a regular service perimeter, a resource can also be in zero or more perimeter bridges. A perimeter bridge only contains resources. Cross project operations are permitted if all effected resources share some perimeter (whether bridge or regular). Perimeter Bridge does not contain access levels or services: those are governed entirely by the regular perimeter that resource is in. Perimeter Bridges are typically useful when building more complex topologies with many independent perimeters that need to share some data with a common perimeter, but should not be able to share data among themselves. Default value is PERIMETER_TYPE_REGULAR. Possible values are: PERIMETER_TYPE_REGULAR, PERIMETER_TYPE_BRIDGE.</summary>
    [JsonPropertyName("perimeterType")]
    public string? PerimeterType { get; set; }

    /// <summary>Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the useExplicitDryRunSpec flag is set. Structure is documented below.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServicePerimeterSpecForProviderSpec? Spec { get; set; }

    /// <summary>ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels that determine perimeter content and boundaries. Structure is documented below.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServicePerimeterSpecForProviderStatus? Status { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists for all Service Perimeters, and that spec is identical to the status for those Service Perimeters. When this flag is set, it inhibits the generation of the implicit spec, thereby allowing the user to explicitly provide a configuration ("spec") to use in a dry-run version of the Service Perimeter. This allows the user to test changes to the enforced config ("status") without actually enforcing them. This testing is done through analyzing the differences between currently enforced and suggested restrictions. useExplicitDryRunSpec must bet set to True if any of the fields in the spec are set to non-default values.</summary>
    [JsonPropertyName("useExplicitDryRunSpec")]
    public bool? UseExplicitDryRunSpec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecAccessLevelsRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecAccessLevelsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecInitProviderSpecAccessLevelsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecAccessLevelsSelectorPolicy
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
/// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecAccessLevelsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecInitProviderSpecAccessLevelsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED. Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.</summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressFrom")]
    public V1beta1ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressTo")]
    public V1beta1ServicePerimeterSpecInitProviderSpecEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressTo
{
    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta1ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressTo")]
    public V1beta1ServicePerimeterSpecInitProviderSpecIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpecVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless enableRestriction is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in 'allowedServices'.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the useExplicitDryRunSpec flag is set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderSpec
{
    /// <summary>A list of AccessLevel resource names that allow resources within the ServicePerimeter to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel is a syntax error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via GCP calls with request origins within the perimeter. For Service Perimeter Bridge, must be empty. Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}</summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>References to AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsRefs")]
    public IList<V1beta1ServicePerimeterSpecInitProviderSpecAccessLevelsRefs>? AccessLevelsRefs { get; set; }

    /// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsSelector")]
    public V1beta1ServicePerimeterSpecInitProviderSpecAccessLevelsSelector? AccessLevelsSelector { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta1ServicePerimeterSpecInitProviderSpecEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of IngressPolicies to apply to the perimeter. A perimeter may have multiple IngressPolicies, each of which is evaluated separately. Access is granted if any Ingress Policy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta1ServicePerimeterSpecInitProviderSpecIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if storage.googleapis.com is specified, access to the storage buckets inside the perimeter must meet the perimeter's access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta1ServicePerimeterSpecInitProviderSpecVpcAccessibleServices? VpcAccessibleServices { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusAccessLevelsRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusAccessLevelsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecInitProviderStatusAccessLevelsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusAccessLevelsSelectorPolicy
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
/// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusAccessLevelsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecInitProviderStatusAccessLevelsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED. Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.</summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressFrom")]
    public V1beta1ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressTo")]
    public V1beta1ServicePerimeterSpecInitProviderStatusEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicy
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
/// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicy
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
/// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>Reference to a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelRef")]
    public V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelRef? AccessLevelRef { get; set; }

    /// <summary>Selector for a AccessLevel in accesscontextmanager to populate accessLevel.</summary>
    [JsonPropertyName("accessLevelSelector")]
    public V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSourcesAccessLevelSelector? AccessLevelSelector { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressTo
{
    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressTo")]
    public V1beta1ServicePerimeterSpecInitProviderStatusIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatusVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless enableRestriction is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in 'allowedServices'.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels that determine perimeter content and boundaries. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProviderStatus
{
    /// <summary>A list of AccessLevel resource names that allow resources within the ServicePerimeter to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel is a syntax error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via GCP calls with request origins within the perimeter. For Service Perimeter Bridge, must be empty. Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}</summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>References to AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsRefs")]
    public IList<V1beta1ServicePerimeterSpecInitProviderStatusAccessLevelsRefs>? AccessLevelsRefs { get; set; }

    /// <summary>Selector for a list of AccessLevel in accesscontextmanager to populate accessLevels.</summary>
    [JsonPropertyName("accessLevelsSelector")]
    public V1beta1ServicePerimeterSpecInitProviderStatusAccessLevelsSelector? AccessLevelsSelector { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta1ServicePerimeterSpecInitProviderStatusEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of IngressPolicies to apply to the perimeter. A perimeter may have multiple IngressPolicies, each of which is evaluated separately. Access is granted if any Ingress Policy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta1ServicePerimeterSpecInitProviderStatusIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if storage.googleapis.com is specified, access to the storage buckets inside the perimeter must meet the perimeter's access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta1ServicePerimeterSpecInitProviderStatusVpcAccessibleServices? VpcAccessibleServices { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecInitProvider
{
    /// <summary>Description of the ServicePerimeter and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Resource name for the ServicePerimeter. The short_name component must begin with a letter and only include alphanumeric and '_'. Format: accessPolicies/{policy_id}/servicePerimeters/{short_name}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The AccessPolicy this ServicePerimeter lives in. Format: accessPolicies/{policy_id}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Specifies the type of the Perimeter. There are two types: regular and bridge. Regular Service Perimeter contains resources, access levels, and restricted services. Every resource can be in at most ONE regular Service Perimeter. In addition to being in a regular service perimeter, a resource can also be in zero or more perimeter bridges. A perimeter bridge only contains resources. Cross project operations are permitted if all effected resources share some perimeter (whether bridge or regular). Perimeter Bridge does not contain access levels or services: those are governed entirely by the regular perimeter that resource is in. Perimeter Bridges are typically useful when building more complex topologies with many independent perimeters that need to share some data with a common perimeter, but should not be able to share data among themselves. Default value is PERIMETER_TYPE_REGULAR. Possible values are: PERIMETER_TYPE_REGULAR, PERIMETER_TYPE_BRIDGE.</summary>
    [JsonPropertyName("perimeterType")]
    public string? PerimeterType { get; set; }

    /// <summary>Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the useExplicitDryRunSpec flag is set. Structure is documented below.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServicePerimeterSpecInitProviderSpec? Spec { get; set; }

    /// <summary>ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels that determine perimeter content and boundaries. Structure is documented below.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServicePerimeterSpecInitProviderStatus? Status { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists for all Service Perimeters, and that spec is identical to the status for those Service Perimeters. When this flag is set, it inhibits the generation of the implicit spec, thereby allowing the user to explicitly provide a configuration ("spec") to use in a dry-run version of the Service Perimeter. This allows the user to test changes to the enforced config ("status") without actually enforcing them. This testing is done through analyzing the differences between currently enforced and suggested restrictions. useExplicitDryRunSpec must bet set to True if any of the fields in the spec are set to non-default values.</summary>
    [JsonPropertyName("useExplicitDryRunSpec")]
    public bool? UseExplicitDryRunSpec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ServicePerimeterSpec defines the desired state of ServicePerimeter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ServicePerimeterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ServicePerimeterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ServicePerimeterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ServicePerimeterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED. Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.</summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressFrom")]
    public V1beta1ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressTo")]
    public V1beta1ServicePerimeterStatusAtProviderSpecEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressTo
{
    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta1ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressTo")]
    public V1beta1ServicePerimeterStatusAtProviderSpecIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpecVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless enableRestriction is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in 'allowedServices'.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the useExplicitDryRunSpec flag is set. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderSpec
{
    /// <summary>A list of AccessLevel resource names that allow resources within the ServicePerimeter to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel is a syntax error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via GCP calls with request origins within the perimeter. For Service Perimeter Bridge, must be empty. Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}</summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta1ServicePerimeterStatusAtProviderSpecEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of IngressPolicies to apply to the perimeter. A perimeter may have multiple IngressPolicies, each of which is evaluated separately. Access is granted if any Ingress Policy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta1ServicePerimeterStatusAtProviderSpecIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if storage.googleapis.com is specified, access to the storage buckets inside the perimeter must meet the perimeter's access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta1ServicePerimeterStatusAtProviderSpecVpcAccessibleServices? VpcAccessibleServices { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Whether to enforce traffic restrictions based on sources field. If the sources field is non-empty, then this field must be set to SOURCE_RESTRICTION_ENABLED. Possible values are: SOURCE_RESTRICTION_UNSPECIFIED, SOURCE_RESTRICTION_ENABLED, SOURCE_RESTRICTION_DISABLED.</summary>
    [JsonPropertyName("sourceRestriction")]
    public string? SourceRestriction { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressTo
{
    /// <summary>A list of external resources that are allowed to be accessed. A request matches if it contains an external resource in this list (Example: s3://bucket/path). Currently '*' is not allowed.</summary>
    [JsonPropertyName("externalResources")]
    public IList<string>? ExternalResources { get; set; }

    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusEgressPolicies
{
    /// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressFrom")]
    public V1beta1ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressFrom? EgressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("egressTo")]
    public V1beta1ServicePerimeterStatusAtProviderStatusEgressPoliciesEgressTo? EgressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressFromSources
{
    /// <summary>An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example accessPolicies/MY_POLICY/accessLevels/MY_LEVEL. If * is specified, then all IngressSources will be allowed.</summary>
    [JsonPropertyName("accessLevel")]
    public string? AccessLevel { get; set; }

    /// <summary>A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be allowed to access perimeter data. Currently only projects and VPCs are allowed. Project format: projects/{projectNumber} VPC network format: //compute.googleapis.com/projects/{PROJECT_ID}/global/networks/{NAME}. The project may be in any Google Cloud organization, not just the organization that the perimeter is defined in. * is not allowed, the case of allowing all Google Cloud resources only is not supported.</summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressFrom
{
    /// <summary>Identities can be an individual user, service account, Google group, or third-party identity. For third-party identity, only single identities are supported and other identity types are not supported.The v1 identities that have the prefix user, group and serviceAccount in https://cloud.google.com/iam/docs/principal-identifiers#v1 are supported.</summary>
    [JsonPropertyName("identities")]
    public IList<string>? Identities { get; set; }

    /// <summary>Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified, then members of identities field will be allowed access. Possible values are: IDENTITY_TYPE_UNSPECIFIED, ANY_IDENTITY, ANY_USER_ACCOUNT, ANY_SERVICE_ACCOUNT.</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }

    /// <summary>Sources that this IngressPolicy authorizes access from. Structure is documented below.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressFromSources>? Sources { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressToOperationsMethodSelectors
{
    /// <summary>Value for method should be a valid method name for the corresponding serviceName in ApiOperation. If * used as value for method, then ALL methods and permissions are allowed.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Value for permission should be a valid Cloud IAM permission for the corresponding serviceName in ApiOperation.</summary>
    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressToOperations
{
    /// <summary>API methods or permissions to allow. Method or permission must belong to the service specified by serviceName field. A single MethodSelector entry with * specified for the method field will allow all methods AND permissions for the service specified in serviceName. Structure is documented below.</summary>
    [JsonPropertyName("methodSelectors")]
    public IList<V1beta1ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressToOperationsMethodSelectors>? MethodSelectors { get; set; }

    /// <summary>The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single ApiOperation with serviceName field set to * will allow all methods AND permissions for all services.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressTo
{
    /// <summary>A list of ApiOperations the sources specified in corresponding IngressFrom are allowed to perform in this ServicePerimeter. Structure is documented below.</summary>
    [JsonPropertyName("operations")]
    public IList<V1beta1ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressToOperations>? Operations { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>A list of IAM roles that represent the set of operations that the sources specified in the corresponding IngressFrom are allowed to perform.</summary>
    [JsonPropertyName("roles")]
    public IList<string>? Roles { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusIngressPolicies
{
    /// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressFrom")]
    public V1beta1ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressFrom? IngressFrom { get; set; }

    /// <summary>Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply. Structure is documented below.</summary>
    [JsonPropertyName("ingressTo")]
    public V1beta1ServicePerimeterStatusAtProviderStatusIngressPoliciesIngressTo? IngressTo { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatusVpcAccessibleServices
{
    /// <summary>The list of APIs usable within the Service Perimeter. Must be empty unless enableRestriction is True.</summary>
    [JsonPropertyName("allowedServices")]
    public IList<string>? AllowedServices { get; set; }

    /// <summary>Whether to restrict API calls within the Service Perimeter to the list of APIs specified in 'allowedServices'.</summary>
    [JsonPropertyName("enableRestriction")]
    public bool? EnableRestriction { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels that determine perimeter content and boundaries. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProviderStatus
{
    /// <summary>A list of AccessLevel resource names that allow resources within the ServicePerimeter to be accessed from the internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent AccessLevel is a syntax error. If no AccessLevel names are listed, resources within the perimeter can only be accessed via GCP calls with request origins within the perimeter. For Service Perimeter Bridge, must be empty. Format: accessPolicies/{policy_id}/accessLevels/{access_level_name}</summary>
    [JsonPropertyName("accessLevels")]
    public IList<string>? AccessLevels { get; set; }

    /// <summary>List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("egressPolicies")]
    public IList<V1beta1ServicePerimeterStatusAtProviderStatusEgressPolicies>? EgressPolicies { get; set; }

    /// <summary>List of IngressPolicies to apply to the perimeter. A perimeter may have multiple IngressPolicies, each of which is evaluated separately. Access is granted if any Ingress Policy grants it. Must be empty for a perimeter bridge. Structure is documented below.</summary>
    [JsonPropertyName("ingressPolicies")]
    public IList<V1beta1ServicePerimeterStatusAtProviderStatusIngressPolicies>? IngressPolicies { get; set; }

    /// <summary>A list of GCP resources that are inside of the service perimeter. Currently only projects are allowed. Format: projects/{project_number}</summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>GCP services that are subject to the Service Perimeter restrictions. Must contain a list of services. For example, if storage.googleapis.com is specified, access to the storage buckets inside the perimeter must meet the perimeter's access restrictions.</summary>
    [JsonPropertyName("restrictedServices")]
    public IList<string>? RestrictedServices { get; set; }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter. Structure is documented below.</summary>
    [JsonPropertyName("vpcAccessibleServices")]
    public V1beta1ServicePerimeterStatusAtProviderStatusVpcAccessibleServices? VpcAccessibleServices { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusAtProvider
{
    /// <summary>Time the AccessPolicy was created in UTC.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Description of the ServicePerimeter and its use. Does not affect behavior.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Resource name for the ServicePerimeter. The short_name component must begin with a letter and only include alphanumeric and '_'. Format: accessPolicies/{policy_id}/servicePerimeters/{short_name}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The AccessPolicy this ServicePerimeter lives in. Format: accessPolicies/{policy_id}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Specifies the type of the Perimeter. There are two types: regular and bridge. Regular Service Perimeter contains resources, access levels, and restricted services. Every resource can be in at most ONE regular Service Perimeter. In addition to being in a regular service perimeter, a resource can also be in zero or more perimeter bridges. A perimeter bridge only contains resources. Cross project operations are permitted if all effected resources share some perimeter (whether bridge or regular). Perimeter Bridge does not contain access levels or services: those are governed entirely by the regular perimeter that resource is in. Perimeter Bridges are typically useful when building more complex topologies with many independent perimeters that need to share some data with a common perimeter, but should not be able to share data among themselves. Default value is PERIMETER_TYPE_REGULAR. Possible values are: PERIMETER_TYPE_REGULAR, PERIMETER_TYPE_BRIDGE.</summary>
    [JsonPropertyName("perimeterType")]
    public string? PerimeterType { get; set; }

    /// <summary>Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the useExplicitDryRunSpec flag is set. Structure is documented below.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServicePerimeterStatusAtProviderSpec? Spec { get; set; }

    /// <summary>ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels that determine perimeter content and boundaries. Structure is documented below.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServicePerimeterStatusAtProviderStatus? Status { get; set; }

    /// <summary>Human readable title. Must be unique within the Policy.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Time the AccessPolicy was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists for all Service Perimeters, and that spec is identical to the status for those Service Perimeters. When this flag is set, it inhibits the generation of the implicit spec, thereby allowing the user to explicitly provide a configuration ("spec") to use in a dry-run version of the Service Perimeter. This allows the user to test changes to the enforced config ("status") without actually enforcing them. This testing is done through analyzing the differences between currently enforced and suggested restrictions. useExplicitDryRunSpec must bet set to True if any of the fields in the spec are set to non-default values.</summary>
    [JsonPropertyName("useExplicitDryRunSpec")]
    public bool? UseExplicitDryRunSpec { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatusConditions
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
/// <summary>ServicePerimeterStatus defines the observed state of ServicePerimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServicePerimeterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ServicePerimeterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServicePerimeterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ServicePerimeter is the Schema for the ServicePerimeters API. ServicePerimeter describes a set of GCP resources which can freely import and export data amongst themselves, but not export outside of the ServicePerimeter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServicePerimeter : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServicePerimeterSpec>, IStatus<V1beta1ServicePerimeterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServicePerimeter";
    public const string KubeGroup = "accesscontextmanager.gcp.m.upbound.io";
    public const string KubePluralName = "serviceperimeters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServicePerimeterSpec defines the desired state of ServicePerimeter</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServicePerimeterSpec Spec { get; set; }

    /// <summary>ServicePerimeterStatus defines the observed state of ServicePerimeter.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServicePerimeterStatus? Status { get; set; }
}
#nullable disable
