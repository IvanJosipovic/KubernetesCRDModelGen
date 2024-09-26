using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.devices.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderIpFilterRule
{
    /// <summary>The desired action for requests captured by this rule. Possible values are Accept, Reject</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP address range in CIDR notation for the rule.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary>The name of the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Target for requests captured by this rule. Possible values are all, deviceApi and serviceApi.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>The connection string to connect to the IoT Hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderLinkedHubConnectionStringSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderLinkedHub
{
    /// <summary>The weight applied to the IoT Hub. Defaults to 1.</summary>
    [JsonPropertyName("allocationWeight")]
    public double? AllocationWeight { get; set; }

    /// <summary>Determines whether to apply allocation policies to the IoT Hub. Defaults to true.</summary>
    [JsonPropertyName("applyAllocationPolicy")]
    public bool? ApplyAllocationPolicy { get; set; }

    /// <summary>The connection string to connect to the IoT Hub.</summary>
    [JsonPropertyName("connectionStringSecretRef")]
    public V1beta1IOTHubDPSSpecForProviderLinkedHubConnectionStringSecretRef ConnectionStringSecretRef { get; set; }

    /// <summary>The location of the IoT hub.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1IOTHubDPSSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProviderSku
{
    /// <summary>The number of provisioned IoT Device Provisioning Service units.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the sku. Currently can only be set to S1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecForProvider
{
    /// <summary>The allocation policy of the IoT Device Provisioning Service (Hashed, GeoLatency or Static). Defaults to Hashed.</summary>
    [JsonPropertyName("allocationPolicy")]
    public string? AllocationPolicy { get; set; }

    /// <summary>Specifies if the IoT Device Provisioning Service has data residency and disaster recovery enabled. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataResidencyEnabled")]
    public bool? DataResidencyEnabled { get; set; }

    /// <summary>An ip_filter_rule block as defined below.</summary>
    [JsonPropertyName("ipFilterRule")]
    public IList<V1beta1IOTHubDPSSpecForProviderIpFilterRule>? IpFilterRule { get; set; }

    /// <summary>A linked_hub block as defined below.</summary>
    [JsonPropertyName("linkedHub")]
    public IList<V1beta1IOTHubDPSSpecForProviderLinkedHub>? LinkedHub { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether requests from Public Network are allowed. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group under which the Iot Device Provisioning Service resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1IOTHubDPSSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1IOTHubDPSSpecForProviderSku>? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecInitProviderIpFilterRule
{
    /// <summary>The desired action for requests captured by this rule. Possible values are Accept, Reject</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP address range in CIDR notation for the rule.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary>The name of the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Target for requests captured by this rule. Possible values are all, deviceApi and serviceApi.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecInitProviderLinkedHub
{
    /// <summary>The weight applied to the IoT Hub. Defaults to 1.</summary>
    [JsonPropertyName("allocationWeight")]
    public double? AllocationWeight { get; set; }

    /// <summary>Determines whether to apply allocation policies to the IoT Hub. Defaults to true.</summary>
    [JsonPropertyName("applyAllocationPolicy")]
    public bool? ApplyAllocationPolicy { get; set; }

    /// <summary>The location of the IoT hub.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecInitProviderSku
{
    /// <summary>The number of provisioned IoT Device Provisioning Service units.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the sku. Currently can only be set to S1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecInitProvider
{
    /// <summary>The allocation policy of the IoT Device Provisioning Service (Hashed, GeoLatency or Static). Defaults to Hashed.</summary>
    [JsonPropertyName("allocationPolicy")]
    public string? AllocationPolicy { get; set; }

    /// <summary>Specifies if the IoT Device Provisioning Service has data residency and disaster recovery enabled. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataResidencyEnabled")]
    public bool? DataResidencyEnabled { get; set; }

    /// <summary>An ip_filter_rule block as defined below.</summary>
    [JsonPropertyName("ipFilterRule")]
    public IList<V1beta1IOTHubDPSSpecInitProviderIpFilterRule>? IpFilterRule { get; set; }

    /// <summary>A linked_hub block as defined below.</summary>
    [JsonPropertyName("linkedHub")]
    public IList<V1beta1IOTHubDPSSpecInitProviderLinkedHub>? LinkedHub { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether requests from Public Network are allowed. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1IOTHubDPSSpecInitProviderSku>? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecProviderConfigRefPolicy
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
public partial class V1beta1IOTHubDPSSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubDPSSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1IOTHubDPSSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IOTHubDPSSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1IOTHubDPSSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1IOTHubDPSSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1IOTHubDPSSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>IOTHubDPSSpec defines the desired state of IOTHubDPS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1IOTHubDPSSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1IOTHubDPSSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IOTHubDPSSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1IOTHubDPSSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IOTHubDPSSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatusAtProviderIpFilterRule
{
    /// <summary>The desired action for requests captured by this rule. Possible values are Accept, Reject</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP address range in CIDR notation for the rule.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary>The name of the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Target for requests captured by this rule. Possible values are all, deviceApi and serviceApi.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatusAtProviderLinkedHub
{
    /// <summary>The weight applied to the IoT Hub. Defaults to 1.</summary>
    [JsonPropertyName("allocationWeight")]
    public double? AllocationWeight { get; set; }

    /// <summary>Determines whether to apply allocation policies to the IoT Hub. Defaults to true.</summary>
    [JsonPropertyName("applyAllocationPolicy")]
    public bool? ApplyAllocationPolicy { get; set; }

    /// <summary>(Computed) The IoT Hub hostname.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>The location of the IoT hub.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatusAtProviderSku
{
    /// <summary>The number of provisioned IoT Device Provisioning Service units.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the sku. Currently can only be set to S1.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatusAtProvider
{
    /// <summary>The allocation policy of the IoT Device Provisioning Service (Hashed, GeoLatency or Static). Defaults to Hashed.</summary>
    [JsonPropertyName("allocationPolicy")]
    public string? AllocationPolicy { get; set; }

    /// <summary>Specifies if the IoT Device Provisioning Service has data residency and disaster recovery enabled. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataResidencyEnabled")]
    public bool? DataResidencyEnabled { get; set; }

    /// <summary>The device endpoint of the IoT Device Provisioning Service.</summary>
    [JsonPropertyName("deviceProvisioningHostName")]
    public string? DeviceProvisioningHostName { get; set; }

    /// <summary>The ID of the IoT Device Provisioning Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The unique identifier of the IoT Device Provisioning Service.</summary>
    [JsonPropertyName("idScope")]
    public string? IdScope { get; set; }

    /// <summary>An ip_filter_rule block as defined below.</summary>
    [JsonPropertyName("ipFilterRule")]
    public IList<V1beta1IOTHubDPSStatusAtProviderIpFilterRule>? IpFilterRule { get; set; }

    /// <summary>A linked_hub block as defined below.</summary>
    [JsonPropertyName("linkedHub")]
    public IList<V1beta1IOTHubDPSStatusAtProviderLinkedHub>? LinkedHub { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether requests from Public Network are allowed. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group under which the Iot Device Provisioning Service resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The service endpoint of the IoT Device Provisioning Service.</summary>
    [JsonPropertyName("serviceOperationsHostName")]
    public string? ServiceOperationsHostName { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public IList<V1beta1IOTHubDPSStatusAtProviderSku>? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatusConditions
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

/// <summary>IOTHubDPSStatus defines the observed state of IOTHubDPS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IOTHubDPSStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1IOTHubDPSStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IOTHubDPSStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IOTHubDPS is the Schema for the IOTHubDPSs API. Manages an IoT Device Provisioning Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IOTHubDPS : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IOTHubDPSSpec>, IStatus<V1beta1IOTHubDPSStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IOTHubDPS";
    public const string KubeGroup = "devices.azure.upbound.io";
    public const string KubePluralName = "iothubdps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IOTHubDPSSpec defines the desired state of IOTHubDPS</summary>
    [JsonPropertyName("spec")]
    public V1beta1IOTHubDPSSpec Spec { get; set; }

    /// <summary>IOTHubDPSStatus defines the observed state of IOTHubDPS.</summary>
    [JsonPropertyName("status")]
    public V1beta1IOTHubDPSStatus? Status { get; set; }
}