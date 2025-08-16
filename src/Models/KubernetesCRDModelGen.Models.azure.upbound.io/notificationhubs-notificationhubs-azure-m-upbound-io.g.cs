using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.notificationhubs.azure.m.upbound.io;
/// <summary>NotificationHub is the Schema for the NotificationHubs API. Manages a Notification Hub within a Notification Hub Namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NotificationHubList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NotificationHub>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NotificationHubList";
    public const string KubeGroup = "notificationhubs.azure.m.upbound.io";
    public const string KubePluralName = "notificationhubs";
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
    public IList<V1beta1NotificationHub> Items { get; set; }
}

/// <summary>The Push Token associated with the Apple Developer Account. This is the contents of the key downloaded from the Apple Developer Portal between the -----BEGIN PRIVATE KEY----- and -----END PRIVATE KEY----- blocks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderApnsCredentialTokenSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A apns_credential block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderApnsCredential
{
    /// <summary>The Application Mode which defines which server the APNS Messages should be sent to. Possible values are Production and Sandbox.</summary>
    [JsonPropertyName("applicationMode")]
    public string? ApplicationMode { get; set; }

    /// <summary>The Bundle ID of the iOS/macOS application to send push notifications for, such as com.hashicorp.example.</summary>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>The Apple Push Notifications Service (APNS) Key.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The ID of the team the Token.</summary>
    [JsonPropertyName("teamId")]
    public string? TeamId { get; set; }

    /// <summary>The Push Token associated with the Apple Developer Account. This is the contents of the key downloaded from the Apple Developer Portal between the -----BEGIN PRIVATE KEY----- and -----END PRIVATE KEY----- blocks.</summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1beta1NotificationHubSpecForProviderApnsCredentialTokenSecretRef? TokenSecretRef { get; set; }
}

/// <summary>The Voluntary Application Server Identification (VAPID) private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderBrowserCredentialVapidPrivateKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A browser_credential block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderBrowserCredential
{
    /// <summary>The subject name of web push.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The Voluntary Application Server Identification (VAPID) private key.</summary>
    [JsonPropertyName("vapidPrivateKeySecretRef")]
    public V1beta1NotificationHubSpecForProviderBrowserCredentialVapidPrivateKeySecretRef? VapidPrivateKeySecretRef { get; set; }

    /// <summary>The Voluntary Application Server Identification (VAPID) public key.</summary>
    [JsonPropertyName("vapidPublicKey")]
    public string? VapidPublicKey { get; set; }
}

/// <summary>The API Key associated with the Google Cloud Messaging service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderGcmCredentialApiKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A gcm_credential block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderGcmCredential
{
    /// <summary>The API Key associated with the Google Cloud Messaging service.</summary>
    [JsonPropertyName("apiKeySecretRef")]
    public V1beta1NotificationHubSpecForProviderGcmCredentialApiKeySecretRef? ApiKeySecretRef { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderNamespaceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a NotificationHubNamespace in notificationhubs to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationHubSpecForProviderNamespaceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderNamespaceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a NotificationHubNamespace in notificationhubs to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderNamespaceNameSelector
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
    public V1beta1NotificationHubSpecForProviderNamespaceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1NotificationHubSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NotificationHubSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1NotificationHubSpecForProviderResourceGroupNameSelector
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
    public V1beta1NotificationHubSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecForProvider
{
    /// <summary>A apns_credential block as defined below.</summary>
    [JsonPropertyName("apnsCredential")]
    public V1beta1NotificationHubSpecForProviderApnsCredential? ApnsCredential { get; set; }

    /// <summary>A browser_credential block as defined below.</summary>
    [JsonPropertyName("browserCredential")]
    public V1beta1NotificationHubSpecForProviderBrowserCredential? BrowserCredential { get; set; }

    /// <summary>A gcm_credential block as defined below.</summary>
    [JsonPropertyName("gcmCredential")]
    public V1beta1NotificationHubSpecForProviderGcmCredential? GcmCredential { get; set; }

    /// <summary>The Azure Region in which this Notification Hub Namespace exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Notification Hub Namespace in which to create this Notification Hub. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>Reference to a NotificationHubNamespace in notificationhubs to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameRef")]
    public V1beta1NotificationHubSpecForProviderNamespaceNameRef? NamespaceNameRef { get; set; }

    /// <summary>Selector for a NotificationHubNamespace in notificationhubs to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameSelector")]
    public V1beta1NotificationHubSpecForProviderNamespaceNameSelector? NamespaceNameSelector { get; set; }

    /// <summary>The name of the Resource Group in which the Notification Hub Namespace exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1NotificationHubSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1NotificationHubSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>The Push Token associated with the Apple Developer Account. This is the contents of the key downloaded from the Apple Developer Portal between the -----BEGIN PRIVATE KEY----- and -----END PRIVATE KEY----- blocks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecInitProviderApnsCredentialTokenSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A apns_credential block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecInitProviderApnsCredential
{
    /// <summary>The Application Mode which defines which server the APNS Messages should be sent to. Possible values are Production and Sandbox.</summary>
    [JsonPropertyName("applicationMode")]
    public string? ApplicationMode { get; set; }

    /// <summary>The Bundle ID of the iOS/macOS application to send push notifications for, such as com.hashicorp.example.</summary>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>The Apple Push Notifications Service (APNS) Key.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The ID of the team the Token.</summary>
    [JsonPropertyName("teamId")]
    public string? TeamId { get; set; }

    /// <summary>The Push Token associated with the Apple Developer Account. This is the contents of the key downloaded from the Apple Developer Portal between the -----BEGIN PRIVATE KEY----- and -----END PRIVATE KEY----- blocks.</summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1beta1NotificationHubSpecInitProviderApnsCredentialTokenSecretRef TokenSecretRef { get; set; }
}

/// <summary>The Voluntary Application Server Identification (VAPID) private key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecInitProviderBrowserCredentialVapidPrivateKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A browser_credential block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecInitProviderBrowserCredential
{
    /// <summary>The subject name of web push.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The Voluntary Application Server Identification (VAPID) private key.</summary>
    [JsonPropertyName("vapidPrivateKeySecretRef")]
    public V1beta1NotificationHubSpecInitProviderBrowserCredentialVapidPrivateKeySecretRef VapidPrivateKeySecretRef { get; set; }

    /// <summary>The Voluntary Application Server Identification (VAPID) public key.</summary>
    [JsonPropertyName("vapidPublicKey")]
    public string? VapidPublicKey { get; set; }
}

/// <summary>The API Key associated with the Google Cloud Messaging service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecInitProviderGcmCredentialApiKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A gcm_credential block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecInitProviderGcmCredential
{
    /// <summary>The API Key associated with the Google Cloud Messaging service.</summary>
    [JsonPropertyName("apiKeySecretRef")]
    public V1beta1NotificationHubSpecInitProviderGcmCredentialApiKeySecretRef ApiKeySecretRef { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecInitProvider
{
    /// <summary>A apns_credential block as defined below.</summary>
    [JsonPropertyName("apnsCredential")]
    public V1beta1NotificationHubSpecInitProviderApnsCredential? ApnsCredential { get; set; }

    /// <summary>A browser_credential block as defined below.</summary>
    [JsonPropertyName("browserCredential")]
    public V1beta1NotificationHubSpecInitProviderBrowserCredential? BrowserCredential { get; set; }

    /// <summary>A gcm_credential block as defined below.</summary>
    [JsonPropertyName("gcmCredential")]
    public V1beta1NotificationHubSpecInitProviderGcmCredential? GcmCredential { get; set; }

    /// <summary>The Azure Region in which this Notification Hub Namespace exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>NotificationHubSpec defines the desired state of NotificationHub</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NotificationHubSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NotificationHubSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NotificationHubSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NotificationHubSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A apns_credential block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubStatusAtProviderApnsCredential
{
    /// <summary>The Application Mode which defines which server the APNS Messages should be sent to. Possible values are Production and Sandbox.</summary>
    [JsonPropertyName("applicationMode")]
    public string? ApplicationMode { get; set; }

    /// <summary>The Bundle ID of the iOS/macOS application to send push notifications for, such as com.hashicorp.example.</summary>
    [JsonPropertyName("bundleId")]
    public string? BundleId { get; set; }

    /// <summary>The Apple Push Notifications Service (APNS) Key.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The ID of the team the Token.</summary>
    [JsonPropertyName("teamId")]
    public string? TeamId { get; set; }
}

/// <summary>A browser_credential block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubStatusAtProviderBrowserCredential
{
    /// <summary>The subject name of web push.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The Voluntary Application Server Identification (VAPID) public key.</summary>
    [JsonPropertyName("vapidPublicKey")]
    public string? VapidPublicKey { get; set; }
}

/// <summary>The API Key associated with the Google Cloud Messaging service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubStatusAtProviderGcmCredentialApiKeySecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A gcm_credential block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubStatusAtProviderGcmCredential
{
    /// <summary>The API Key associated with the Google Cloud Messaging service.</summary>
    [JsonPropertyName("apiKeySecretRef")]
    public V1beta1NotificationHubStatusAtProviderGcmCredentialApiKeySecretRef? ApiKeySecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubStatusAtProvider
{
    /// <summary>A apns_credential block as defined below.</summary>
    [JsonPropertyName("apnsCredential")]
    public V1beta1NotificationHubStatusAtProviderApnsCredential? ApnsCredential { get; set; }

    /// <summary>A browser_credential block as defined below.</summary>
    [JsonPropertyName("browserCredential")]
    public V1beta1NotificationHubStatusAtProviderBrowserCredential? BrowserCredential { get; set; }

    /// <summary>A gcm_credential block as defined below.</summary>
    [JsonPropertyName("gcmCredential")]
    public V1beta1NotificationHubStatusAtProviderGcmCredential? GcmCredential { get; set; }

    /// <summary>The ID of the Notification Hub.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Azure Region in which this Notification Hub Namespace exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Notification Hub Namespace in which to create this Notification Hub. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>The name of the Resource Group in which the Notification Hub Namespace exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubStatusConditions
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

/// <summary>NotificationHubStatus defines the observed state of NotificationHub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NotificationHubStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NotificationHubStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NotificationHubStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NotificationHub is the Schema for the NotificationHubs API. Manages a Notification Hub within a Notification Hub Namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NotificationHub : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NotificationHubSpec>, IStatus<V1beta1NotificationHubStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NotificationHub";
    public const string KubeGroup = "notificationhubs.azure.m.upbound.io";
    public const string KubePluralName = "notificationhubs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NotificationHubSpec defines the desired state of NotificationHub</summary>
    [JsonPropertyName("spec")]
    public V1beta1NotificationHubSpec Spec { get; set; }

    /// <summary>NotificationHubStatus defines the observed state of NotificationHub.</summary>
    [JsonPropertyName("status")]
    public V1beta1NotificationHubStatus? Status { get; set; }
}