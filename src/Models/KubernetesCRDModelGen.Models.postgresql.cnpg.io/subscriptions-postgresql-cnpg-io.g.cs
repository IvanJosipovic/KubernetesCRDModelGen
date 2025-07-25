using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>The name of the PostgreSQL cluster that identifies the "subscriber"</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionSpecCluster
{
    /// <summary>Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SubscriptionSpec defines the desired state of Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionSpec
{
    /// <summary>The name of the PostgreSQL cluster that identifies the "subscriber"</summary>
    [JsonPropertyName("cluster")]
    public V1SubscriptionSpecCluster Cluster { get; set; }

    /// <summary>The name of the database where the publication will be installed in the "subscriber" cluster</summary>
    [JsonPropertyName("dbname")]
    public string Dbname { get; set; }

    /// <summary>The name of the external cluster with the publication ("publisher")</summary>
    [JsonPropertyName("externalClusterName")]
    public string ExternalClusterName { get; set; }

    /// <summary>The name of the subscription inside PostgreSQL</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Subscription parameters included in the `WITH` clause of the PostgreSQL `CREATE SUBSCRIPTION` command. Most parameters cannot be changed after the subscription is created and will be ignored if modified later, except for a limited set documented at: https://www.postgresql.org/docs/current/sql-altersubscription.html#SQL-ALTERSUBSCRIPTION-PARAMS-SET</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The name of the database containing the publication on the external cluster. Defaults to the one in the external cluster definition.</summary>
    [JsonPropertyName("publicationDBName")]
    public string? PublicationDBName { get; set; }

    /// <summary>The name of the publication inside the PostgreSQL database in the "publisher"</summary>
    [JsonPropertyName("publicationName")]
    public string PublicationName { get; set; }

    /// <summary>The policy for end-of-life maintenance of this subscription</summary>
    [JsonPropertyName("subscriptionReclaimPolicy")]
    public string? SubscriptionReclaimPolicy { get; set; }
}

/// <summary>SubscriptionStatus defines the observed state of Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SubscriptionStatus
{
    /// <summary>Applied is true if the subscription was reconciled correctly</summary>
    [JsonPropertyName("applied")]
    public bool? Applied { get; set; }

    /// <summary>Message is the reconciliation output message</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A sequence number representing the latest desired state that was synchronized</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Subscription is the Schema for the subscriptions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Subscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1SubscriptionSpec>, IStatus<V1SubscriptionStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Subscription";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "subscriptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubscriptionSpec defines the desired state of Subscription</summary>
    [JsonPropertyName("spec")]
    public V1SubscriptionSpec Spec { get; set; }

    /// <summary>SubscriptionStatus defines the observed state of Subscription</summary>
    [JsonPropertyName("status")]
    public V1SubscriptionStatus? Status { get; set; }
}

/// <summary>Subscription is the Schema for the subscriptions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1SubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1Subscription>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "SubscriptionList";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "subscriptions";
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
    public IList<V1Subscription> Items { get; set; }
}