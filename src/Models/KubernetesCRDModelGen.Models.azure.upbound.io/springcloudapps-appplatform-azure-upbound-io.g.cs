using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderCustomPersistentDisk
{
    /// <summary>These are the mount options for a persistent disk.</summary>
    [JsonPropertyName("mountOptions")]
    public IList<string>? MountOptions { get; set; }

    /// <summary>The mount path of the persistent disk.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Indicates whether the persistent disk is a readOnly one.</summary>
    [JsonPropertyName("readOnlyEnabled")]
    public bool? ReadOnlyEnabled { get; set; }

    /// <summary>The share name of the Azure File share.</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>The name of the Spring Cloud Storage.</summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Spring Cloud Application.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Spring Cloud Application. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderIngressSettings
{
    /// <summary>Specifies how ingress should communicate with this app backend service. Allowed values are GRPC and Default. Defaults to Default.</summary>
    [JsonPropertyName("backendProtocol")]
    public string? BackendProtocol { get; set; }

    /// <summary>Specifies the ingress read time out in seconds. Defaults to 300.</summary>
    [JsonPropertyName("readTimeoutInSeconds")]
    public double? ReadTimeoutInSeconds { get; set; }

    /// <summary>Specifies the ingress send time out in seconds. Defaults to 60.</summary>
    [JsonPropertyName("sendTimeoutInSeconds")]
    public double? SendTimeoutInSeconds { get; set; }

    /// <summary>Specifies the type of the affinity, set this to Cookie to enable session affinity. Allowed values are Cookie and None. Defaults to None.</summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>Specifies the time in seconds until the cookie expires.</summary>
    [JsonPropertyName("sessionCookieMaxAge")]
    public double? SessionCookieMaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderPersistentDisk
{
    /// <summary>Specifies the mount path of the persistent disk. Defaults to /persistent.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Specifies the size of the persistent disk in GB. Possible values are between 0 and 50.</summary>
    [JsonPropertyName("sizeInGb")]
    public double? SizeInGb { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderServiceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SpringCloudService in appplatform to populate serviceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppSpecForProviderServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderServiceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SpringCloudService in appplatform to populate serviceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProviderServiceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppSpecForProviderServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecForProvider
{
    /// <summary>A JSON object that contains the addon configurations of the Spring Cloud Service.</summary>
    [JsonPropertyName("addonJson")]
    public string? AddonJson { get; set; }

    /// <summary>A custom_persistent_disk block as defined below.</summary>
    [JsonPropertyName("customPersistentDisk")]
    public IList<V1beta1SpringCloudAppSpecForProviderCustomPersistentDisk>? CustomPersistentDisk { get; set; }

    /// <summary>Is only HTTPS allowed? Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1SpringCloudAppSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>An ingress_settings block as defined below.</summary>
    [JsonPropertyName("ingressSettings")]
    public IList<V1beta1SpringCloudAppSpecForProviderIngressSettings>? IngressSettings { get; set; }

    /// <summary>Does the Spring Cloud Application have public endpoint? Defaults to false.</summary>
    [JsonPropertyName("isPublic")]
    public bool? IsPublic { get; set; }

    /// <summary>An persistent_disk block as defined below.</summary>
    [JsonPropertyName("persistentDisk")]
    public IList<V1beta1SpringCloudAppSpecForProviderPersistentDisk>? PersistentDisk { get; set; }

    /// <summary>Should the App in vnet injection instance exposes endpoint which could be accessed from Internet?</summary>
    [JsonPropertyName("publicEndpointEnabled")]
    public bool? PublicEndpointEnabled { get; set; }

    /// <summary>Specifies the name of the resource group in which to create the Spring Cloud Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1SpringCloudAppSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1SpringCloudAppSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies the name of the Spring Cloud Service resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Reference to a SpringCloudService in appplatform to populate serviceName.</summary>
    [JsonPropertyName("serviceNameRef")]
    public V1beta1SpringCloudAppSpecForProviderServiceNameRef? ServiceNameRef { get; set; }

    /// <summary>Selector for a SpringCloudService in appplatform to populate serviceName.</summary>
    [JsonPropertyName("serviceNameSelector")]
    public V1beta1SpringCloudAppSpecForProviderServiceNameSelector? ServiceNameSelector { get; set; }

    /// <summary>Is End to End TLS Enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEnabled")]
    public bool? TlsEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecInitProviderCustomPersistentDisk
{
    /// <summary>These are the mount options for a persistent disk.</summary>
    [JsonPropertyName("mountOptions")]
    public IList<string>? MountOptions { get; set; }

    /// <summary>The mount path of the persistent disk.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Indicates whether the persistent disk is a readOnly one.</summary>
    [JsonPropertyName("readOnlyEnabled")]
    public bool? ReadOnlyEnabled { get; set; }

    /// <summary>The share name of the Azure File share.</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>The name of the Spring Cloud Storage.</summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Spring Cloud Application.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Spring Cloud Application. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecInitProviderIngressSettings
{
    /// <summary>Specifies how ingress should communicate with this app backend service. Allowed values are GRPC and Default. Defaults to Default.</summary>
    [JsonPropertyName("backendProtocol")]
    public string? BackendProtocol { get; set; }

    /// <summary>Specifies the ingress read time out in seconds. Defaults to 300.</summary>
    [JsonPropertyName("readTimeoutInSeconds")]
    public double? ReadTimeoutInSeconds { get; set; }

    /// <summary>Specifies the ingress send time out in seconds. Defaults to 60.</summary>
    [JsonPropertyName("sendTimeoutInSeconds")]
    public double? SendTimeoutInSeconds { get; set; }

    /// <summary>Specifies the type of the affinity, set this to Cookie to enable session affinity. Allowed values are Cookie and None. Defaults to None.</summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>Specifies the time in seconds until the cookie expires.</summary>
    [JsonPropertyName("sessionCookieMaxAge")]
    public double? SessionCookieMaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecInitProviderPersistentDisk
{
    /// <summary>Specifies the mount path of the persistent disk. Defaults to /persistent.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Specifies the size of the persistent disk in GB. Possible values are between 0 and 50.</summary>
    [JsonPropertyName("sizeInGb")]
    public double? SizeInGb { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecInitProvider
{
    /// <summary>A JSON object that contains the addon configurations of the Spring Cloud Service.</summary>
    [JsonPropertyName("addonJson")]
    public string? AddonJson { get; set; }

    /// <summary>A custom_persistent_disk block as defined below.</summary>
    [JsonPropertyName("customPersistentDisk")]
    public IList<V1beta1SpringCloudAppSpecInitProviderCustomPersistentDisk>? CustomPersistentDisk { get; set; }

    /// <summary>Is only HTTPS allowed? Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1SpringCloudAppSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>An ingress_settings block as defined below.</summary>
    [JsonPropertyName("ingressSettings")]
    public IList<V1beta1SpringCloudAppSpecInitProviderIngressSettings>? IngressSettings { get; set; }

    /// <summary>Does the Spring Cloud Application have public endpoint? Defaults to false.</summary>
    [JsonPropertyName("isPublic")]
    public bool? IsPublic { get; set; }

    /// <summary>An persistent_disk block as defined below.</summary>
    [JsonPropertyName("persistentDisk")]
    public IList<V1beta1SpringCloudAppSpecInitProviderPersistentDisk>? PersistentDisk { get; set; }

    /// <summary>Should the App in vnet injection instance exposes endpoint which could be accessed from Internet?</summary>
    [JsonPropertyName("publicEndpointEnabled")]
    public bool? PublicEndpointEnabled { get; set; }

    /// <summary>Is End to End TLS Enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEnabled")]
    public bool? TlsEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecProviderConfigRefPolicy
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
public partial class V1beta1SpringCloudAppSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpringCloudAppSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>SpringCloudAppSpec defines the desired state of SpringCloudApp</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SpringCloudAppSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SpringCloudAppSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpringCloudAppSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpringCloudAppSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppStatusAtProviderCustomPersistentDisk
{
    /// <summary>These are the mount options for a persistent disk.</summary>
    [JsonPropertyName("mountOptions")]
    public IList<string>? MountOptions { get; set; }

    /// <summary>The mount path of the persistent disk.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Indicates whether the persistent disk is a readOnly one.</summary>
    [JsonPropertyName("readOnlyEnabled")]
    public bool? ReadOnlyEnabled { get; set; }

    /// <summary>The share name of the Azure File share.</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>The name of the Spring Cloud Storage.</summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this Spring Cloud Application.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID for the Service Principal associated with the Managed Service Identity of this Spring Cloud Application.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID for the Service Principal associated with the Managed Service Identity of this Spring Cloud Application.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Spring Cloud Application. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppStatusAtProviderIngressSettings
{
    /// <summary>Specifies how ingress should communicate with this app backend service. Allowed values are GRPC and Default. Defaults to Default.</summary>
    [JsonPropertyName("backendProtocol")]
    public string? BackendProtocol { get; set; }

    /// <summary>Specifies the ingress read time out in seconds. Defaults to 300.</summary>
    [JsonPropertyName("readTimeoutInSeconds")]
    public double? ReadTimeoutInSeconds { get; set; }

    /// <summary>Specifies the ingress send time out in seconds. Defaults to 60.</summary>
    [JsonPropertyName("sendTimeoutInSeconds")]
    public double? SendTimeoutInSeconds { get; set; }

    /// <summary>Specifies the type of the affinity, set this to Cookie to enable session affinity. Allowed values are Cookie and None. Defaults to None.</summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>Specifies the time in seconds until the cookie expires.</summary>
    [JsonPropertyName("sessionCookieMaxAge")]
    public double? SessionCookieMaxAge { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppStatusAtProviderPersistentDisk
{
    /// <summary>Specifies the mount path of the persistent disk. Defaults to /persistent.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Specifies the size of the persistent disk in GB. Possible values are between 0 and 50.</summary>
    [JsonPropertyName("sizeInGb")]
    public double? SizeInGb { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppStatusAtProvider
{
    /// <summary>A JSON object that contains the addon configurations of the Spring Cloud Service.</summary>
    [JsonPropertyName("addonJson")]
    public string? AddonJson { get; set; }

    /// <summary>A custom_persistent_disk block as defined below.</summary>
    [JsonPropertyName("customPersistentDisk")]
    public IList<V1beta1SpringCloudAppStatusAtProviderCustomPersistentDisk>? CustomPersistentDisk { get; set; }

    /// <summary>The Fully Qualified DNS Name of the Spring Application in the service.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Is only HTTPS allowed? Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>The ID of the Spring Cloud Application.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1SpringCloudAppStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>An ingress_settings block as defined below.</summary>
    [JsonPropertyName("ingressSettings")]
    public IList<V1beta1SpringCloudAppStatusAtProviderIngressSettings>? IngressSettings { get; set; }

    /// <summary>Does the Spring Cloud Application have public endpoint? Defaults to false.</summary>
    [JsonPropertyName("isPublic")]
    public bool? IsPublic { get; set; }

    /// <summary>An persistent_disk block as defined below.</summary>
    [JsonPropertyName("persistentDisk")]
    public IList<V1beta1SpringCloudAppStatusAtProviderPersistentDisk>? PersistentDisk { get; set; }

    /// <summary>Should the App in vnet injection instance exposes endpoint which could be accessed from Internet?</summary>
    [JsonPropertyName("publicEndpointEnabled")]
    public bool? PublicEndpointEnabled { get; set; }

    /// <summary>Specifies the name of the resource group in which to create the Spring Cloud Application. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Specifies the name of the Spring Cloud Service resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Is End to End TLS Enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEnabled")]
    public bool? TlsEnabled { get; set; }

    /// <summary>The public endpoint of the Spring Cloud Application.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppStatusConditions
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

/// <summary>SpringCloudAppStatus defines the observed state of SpringCloudApp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpringCloudAppStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SpringCloudAppStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpringCloudAppStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpringCloudApp is the Schema for the SpringCloudApps API. Manage an Azure Spring Cloud Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudApp : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpringCloudAppSpec>, IStatus<V1beta1SpringCloudAppStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudApp";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudapps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudAppSpec defines the desired state of SpringCloudApp</summary>
    [JsonPropertyName("spec")]
    public V1beta1SpringCloudAppSpec Spec { get; set; }

    /// <summary>SpringCloudAppStatus defines the observed state of SpringCloudApp.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpringCloudAppStatus? Status { get; set; }
}

/// <summary>SpringCloudApp is the Schema for the SpringCloudApps API. Manage an Azure Spring Cloud Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpringCloudAppList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpringCloudApp>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpringCloudAppList";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudapps";
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
    public IList<V1beta1SpringCloudApp> Items { get; set; }
}