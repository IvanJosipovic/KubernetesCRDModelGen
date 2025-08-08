using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventgrid.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Event Grid Topic.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Grid Topic. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderInboundIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask (CIDR) to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderInputMappingDefaultValues
{
    /// <summary>Specifies the default data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the default event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the default subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderInputMappingFields
{
    /// <summary>Specifies the data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the event time of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Specifies the event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the id of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Specifies the topic of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1TopicSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1TopicSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecForProvider
{
    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1TopicSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>One or more inbound_ip_rule blocks as defined below.</summary>
    [JsonPropertyName("inboundIpRule")]
    public IList<V1beta1TopicSpecForProviderInboundIpRule>? InboundIpRule { get; set; }

    /// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingDefaultValues")]
    public IList<V1beta1TopicSpecForProviderInputMappingDefaultValues>? InputMappingDefaultValues { get; set; }

    /// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingFields")]
    public IList<V1beta1TopicSpecForProviderInputMappingFields>? InputMappingFields { get; set; }

    /// <summary>Specifies the schema in which incoming events will be published to this domain. Allowed values are CloudEventSchemaV1_0, CustomEventSchema, or EventGridSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Whether local authentication methods is enabled for the EventGrid Topic. Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which the EventGrid Topic exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1TopicSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1TopicSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Event Grid Topic.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Grid Topic. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderInboundIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask (CIDR) to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderInputMappingDefaultValues
{
    /// <summary>Specifies the default data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the default event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the default subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProviderInputMappingFields
{
    /// <summary>Specifies the data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the event time of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Specifies the event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the id of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Specifies the topic of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecInitProvider
{
    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1TopicSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>One or more inbound_ip_rule blocks as defined below.</summary>
    [JsonPropertyName("inboundIpRule")]
    public IList<V1beta1TopicSpecInitProviderInboundIpRule>? InboundIpRule { get; set; }

    /// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingDefaultValues")]
    public IList<V1beta1TopicSpecInitProviderInputMappingDefaultValues>? InputMappingDefaultValues { get; set; }

    /// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingFields")]
    public IList<V1beta1TopicSpecInitProviderInputMappingFields>? InputMappingFields { get; set; }

    /// <summary>Specifies the schema in which incoming events will be published to this domain. Allowed values are CloudEventSchemaV1_0, CustomEventSchema, or EventGridSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Whether local authentication methods is enabled for the EventGrid Topic. Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecProviderConfigRefPolicy
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
public partial class V1beta1TopicSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TopicSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>TopicSpec defines the desired state of Topic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TopicSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TopicSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TopicSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TopicSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Event Grid Topic.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Event Grid Topic. Possible values are SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderInboundIpRule
{
    /// <summary>The action to take when the rule is matched. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP mask (CIDR) to match on.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderInputMappingDefaultValues
{
    /// <summary>Specifies the default data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the default event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the default subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProviderInputMappingFields
{
    /// <summary>Specifies the data version of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataVersion")]
    public string? DataVersion { get; set; }

    /// <summary>Specifies the event time of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Specifies the event type of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>Specifies the id of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the subject of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Specifies the topic of the EventGrid Event to associate with the domain. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusAtProvider
{
    /// <summary>The Endpoint associated with the EventGrid Topic.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The EventGrid Topic ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1TopicStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>One or more inbound_ip_rule blocks as defined below.</summary>
    [JsonPropertyName("inboundIpRule")]
    public IList<V1beta1TopicStatusAtProviderInboundIpRule>? InboundIpRule { get; set; }

    /// <summary>A input_mapping_default_values block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingDefaultValues")]
    public IList<V1beta1TopicStatusAtProviderInputMappingDefaultValues>? InputMappingDefaultValues { get; set; }

    /// <summary>A input_mapping_fields block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputMappingFields")]
    public IList<V1beta1TopicStatusAtProviderInputMappingFields>? InputMappingFields { get; set; }

    /// <summary>Specifies the schema in which incoming events will be published to this domain. Allowed values are CloudEventSchemaV1_0, CustomEventSchema, or EventGridSchema. Defaults to EventGridSchema. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("inputSchema")]
    public string? InputSchema { get; set; }

    /// <summary>Whether local authentication methods is enabled for the EventGrid Topic. Defaults to true.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether or not public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which the EventGrid Topic exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatusConditions
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

/// <summary>TopicStatus defines the observed state of Topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TopicStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TopicStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TopicStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Topic is the Schema for the Topics API. Manages an EventGrid Topic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Topic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TopicSpec>, IStatus<V1beta1TopicStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Topic";
    public const string KubeGroup = "eventgrid.azure.upbound.io";
    public const string KubePluralName = "topics";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TopicSpec defines the desired state of Topic</summary>
    [JsonPropertyName("spec")]
    public V1beta1TopicSpec Spec { get; set; }

    /// <summary>TopicStatus defines the observed state of Topic.</summary>
    [JsonPropertyName("status")]
    public V1beta1TopicStatus? Status { get; set; }
}

/// <summary>Topic is the Schema for the Topics API. Manages an EventGrid Topic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TopicList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Topic>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TopicList";
    public const string KubeGroup = "eventgrid.azure.upbound.io";
    public const string KubePluralName = "topics";
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
    public IList<V1beta1Topic> Items { get; set; }
}