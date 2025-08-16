using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.emrserverless.aws.m.upbound.io;
/// <summary>Application is the Schema for the Applications API. Manages an EMR Serverless Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Application>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApplicationList";
    public const string KubeGroup = "emrserverless.aws.m.upbound.io";
    public const string KubePluralName = "applications";
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
    public IList<V1beta1Application> Items { get; set; }
}

/// <summary>The configuration for an application to automatically start on job submission.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderAutoStartConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The configuration for an application to automatically stop after a certain amount of time being idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderAutoStopConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The amount of idle time in minutes after which your application will automatically stop. Defaults to 15 minutes.</summary>
    [JsonPropertyName("idleTimeoutMinutes")]
    public double? IdleTimeoutMinutes { get; set; }
}

/// <summary>The image configuration applied to all worker types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderImageConfiguration
{
    /// <summary>The image URI.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }
}

/// <summary>The resource configuration of the initial capacity configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInitialCapacityInitialCapacityConfigWorkerConfiguration
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>The initial capacity configuration per worker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInitialCapacityInitialCapacityConfig
{
    /// <summary>The resource configuration of the initial capacity configuration.</summary>
    [JsonPropertyName("workerConfiguration")]
    public V1beta1ApplicationSpecForProviderInitialCapacityInitialCapacityConfigWorkerConfiguration? WorkerConfiguration { get; set; }

    /// <summary>The number of workers in the initial capacity configuration.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInitialCapacity
{
    /// <summary>The initial capacity configuration per worker.</summary>
    [JsonPropertyName("initialCapacityConfig")]
    public V1beta1ApplicationSpecForProviderInitialCapacityInitialCapacityConfig? InitialCapacityConfig { get; set; }

    /// <summary>The worker type for an analytics framework. For Spark applications, the key can either be set to Driver or Executor. For Hive applications, it can be set to HiveDriver or TezTask.</summary>
    [JsonPropertyName("initialCapacityType")]
    public string? InitialCapacityType { get; set; }
}

/// <summary>Enables the interactive use cases to use when running an application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderInteractiveConfiguration
{
    /// <summary>Enables an Apache Livy endpoint that you can connect to and run interactive jobs.</summary>
    [JsonPropertyName("livyEndpointEnabled")]
    public bool? LivyEndpointEnabled { get; set; }

    /// <summary>Enables you to connect an application to Amazon EMR Studio to run interactive workloads in a notebook.</summary>
    [JsonPropertyName("studioEnabled")]
    public bool? StudioEnabled { get; set; }
}

/// <summary>The maximum capacity to allocate when the application is created. This is cumulative across all workers at any given point in time, not just when an application is created. No new resources will be created once any one of the defined limits is hit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderMaximumCapacity
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>The network configuration for customer VPC connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderNetworkConfiguration
{
    /// <summary>The array of security group Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The array of subnet Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProvider
{
    /// <summary>The CPU architecture of an application. Valid values are ARM64 or X86_64. Default value is X86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>The configuration for an application to automatically start on job submission.</summary>
    [JsonPropertyName("autoStartConfiguration")]
    public V1beta1ApplicationSpecForProviderAutoStartConfiguration? AutoStartConfiguration { get; set; }

    /// <summary>The configuration for an application to automatically stop after a certain amount of time being idle.</summary>
    [JsonPropertyName("autoStopConfiguration")]
    public V1beta1ApplicationSpecForProviderAutoStopConfiguration? AutoStopConfiguration { get; set; }

    /// <summary>The image configuration applied to all worker types.</summary>
    [JsonPropertyName("imageConfiguration")]
    public V1beta1ApplicationSpecForProviderImageConfiguration? ImageConfiguration { get; set; }

    /// <summary>The capacity to initialize when the application is created.</summary>
    [JsonPropertyName("initialCapacity")]
    public IList<V1beta1ApplicationSpecForProviderInitialCapacity>? InitialCapacity { get; set; }

    /// <summary>Enables the interactive use cases to use when running an application.</summary>
    [JsonPropertyName("interactiveConfiguration")]
    public V1beta1ApplicationSpecForProviderInteractiveConfiguration? InteractiveConfiguration { get; set; }

    /// <summary>The maximum capacity to allocate when the application is created. This is cumulative across all workers at any given point in time, not just when an application is created. No new resources will be created once any one of the defined limits is hit.</summary>
    [JsonPropertyName("maximumCapacity")]
    public V1beta1ApplicationSpecForProviderMaximumCapacity? MaximumCapacity { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The network configuration for customer VPC connectivity.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1ApplicationSpecForProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>The EMR release version associated with the application.</summary>
    [JsonPropertyName("releaseLabel")]
    public string? ReleaseLabel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of application you want to start, such as spark or hive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The configuration for an application to automatically start on job submission.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderAutoStartConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The configuration for an application to automatically stop after a certain amount of time being idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderAutoStopConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The amount of idle time in minutes after which your application will automatically stop. Defaults to 15 minutes.</summary>
    [JsonPropertyName("idleTimeoutMinutes")]
    public double? IdleTimeoutMinutes { get; set; }
}

/// <summary>The image configuration applied to all worker types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderImageConfiguration
{
    /// <summary>The image URI.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }
}

/// <summary>The resource configuration of the initial capacity configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInitialCapacityInitialCapacityConfigWorkerConfiguration
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>The initial capacity configuration per worker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInitialCapacityInitialCapacityConfig
{
    /// <summary>The resource configuration of the initial capacity configuration.</summary>
    [JsonPropertyName("workerConfiguration")]
    public V1beta1ApplicationSpecInitProviderInitialCapacityInitialCapacityConfigWorkerConfiguration? WorkerConfiguration { get; set; }

    /// <summary>The number of workers in the initial capacity configuration.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInitialCapacity
{
    /// <summary>The initial capacity configuration per worker.</summary>
    [JsonPropertyName("initialCapacityConfig")]
    public V1beta1ApplicationSpecInitProviderInitialCapacityInitialCapacityConfig? InitialCapacityConfig { get; set; }

    /// <summary>The worker type for an analytics framework. For Spark applications, the key can either be set to Driver or Executor. For Hive applications, it can be set to HiveDriver or TezTask.</summary>
    [JsonPropertyName("initialCapacityType")]
    public string? InitialCapacityType { get; set; }
}

/// <summary>Enables the interactive use cases to use when running an application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderInteractiveConfiguration
{
    /// <summary>Enables an Apache Livy endpoint that you can connect to and run interactive jobs.</summary>
    [JsonPropertyName("livyEndpointEnabled")]
    public bool? LivyEndpointEnabled { get; set; }

    /// <summary>Enables you to connect an application to Amazon EMR Studio to run interactive workloads in a notebook.</summary>
    [JsonPropertyName("studioEnabled")]
    public bool? StudioEnabled { get; set; }
}

/// <summary>The maximum capacity to allocate when the application is created. This is cumulative across all workers at any given point in time, not just when an application is created. No new resources will be created once any one of the defined limits is hit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderMaximumCapacity
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>The network configuration for customer VPC connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderNetworkConfiguration
{
    /// <summary>The array of security group Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The array of subnet Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProvider
{
    /// <summary>The CPU architecture of an application. Valid values are ARM64 or X86_64. Default value is X86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>The configuration for an application to automatically start on job submission.</summary>
    [JsonPropertyName("autoStartConfiguration")]
    public V1beta1ApplicationSpecInitProviderAutoStartConfiguration? AutoStartConfiguration { get; set; }

    /// <summary>The configuration for an application to automatically stop after a certain amount of time being idle.</summary>
    [JsonPropertyName("autoStopConfiguration")]
    public V1beta1ApplicationSpecInitProviderAutoStopConfiguration? AutoStopConfiguration { get; set; }

    /// <summary>The image configuration applied to all worker types.</summary>
    [JsonPropertyName("imageConfiguration")]
    public V1beta1ApplicationSpecInitProviderImageConfiguration? ImageConfiguration { get; set; }

    /// <summary>The capacity to initialize when the application is created.</summary>
    [JsonPropertyName("initialCapacity")]
    public IList<V1beta1ApplicationSpecInitProviderInitialCapacity>? InitialCapacity { get; set; }

    /// <summary>Enables the interactive use cases to use when running an application.</summary>
    [JsonPropertyName("interactiveConfiguration")]
    public V1beta1ApplicationSpecInitProviderInteractiveConfiguration? InteractiveConfiguration { get; set; }

    /// <summary>The maximum capacity to allocate when the application is created. This is cumulative across all workers at any given point in time, not just when an application is created. No new resources will be created once any one of the defined limits is hit.</summary>
    [JsonPropertyName("maximumCapacity")]
    public V1beta1ApplicationSpecInitProviderMaximumCapacity? MaximumCapacity { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The network configuration for customer VPC connectivity.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1ApplicationSpecInitProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>The EMR release version associated with the application.</summary>
    [JsonPropertyName("releaseLabel")]
    public string? ReleaseLabel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The type of application you want to start, such as spark or hive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecProviderConfigRef
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
public partial class V1beta1ApplicationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ApplicationSpec defines the desired state of Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ApplicationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ApplicationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ApplicationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ApplicationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The configuration for an application to automatically start on job submission.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderAutoStartConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The configuration for an application to automatically stop after a certain amount of time being idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderAutoStopConfiguration
{
    /// <summary>Enables the application to automatically start on job submission. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The amount of idle time in minutes after which your application will automatically stop. Defaults to 15 minutes.</summary>
    [JsonPropertyName("idleTimeoutMinutes")]
    public double? IdleTimeoutMinutes { get; set; }
}

/// <summary>The image configuration applied to all worker types.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderImageConfiguration
{
    /// <summary>The image URI.</summary>
    [JsonPropertyName("imageUri")]
    public string? ImageUri { get; set; }
}

/// <summary>The resource configuration of the initial capacity configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInitialCapacityInitialCapacityConfigWorkerConfiguration
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>The initial capacity configuration per worker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInitialCapacityInitialCapacityConfig
{
    /// <summary>The resource configuration of the initial capacity configuration.</summary>
    [JsonPropertyName("workerConfiguration")]
    public V1beta1ApplicationStatusAtProviderInitialCapacityInitialCapacityConfigWorkerConfiguration? WorkerConfiguration { get; set; }

    /// <summary>The number of workers in the initial capacity configuration.</summary>
    [JsonPropertyName("workerCount")]
    public double? WorkerCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInitialCapacity
{
    /// <summary>The initial capacity configuration per worker.</summary>
    [JsonPropertyName("initialCapacityConfig")]
    public V1beta1ApplicationStatusAtProviderInitialCapacityInitialCapacityConfig? InitialCapacityConfig { get; set; }

    /// <summary>The worker type for an analytics framework. For Spark applications, the key can either be set to Driver or Executor. For Hive applications, it can be set to HiveDriver or TezTask.</summary>
    [JsonPropertyName("initialCapacityType")]
    public string? InitialCapacityType { get; set; }
}

/// <summary>Enables the interactive use cases to use when running an application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderInteractiveConfiguration
{
    /// <summary>Enables an Apache Livy endpoint that you can connect to and run interactive jobs.</summary>
    [JsonPropertyName("livyEndpointEnabled")]
    public bool? LivyEndpointEnabled { get; set; }

    /// <summary>Enables you to connect an application to Amazon EMR Studio to run interactive workloads in a notebook.</summary>
    [JsonPropertyName("studioEnabled")]
    public bool? StudioEnabled { get; set; }
}

/// <summary>The maximum capacity to allocate when the application is created. This is cumulative across all workers at any given point in time, not just when an application is created. No new resources will be created once any one of the defined limits is hit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderMaximumCapacity
{
    /// <summary>The maximum allowed CPU for an application.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>The maximum allowed disk for an application.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>The maximum allowed resources for an application.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>The network configuration for customer VPC connectivity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderNetworkConfiguration
{
    /// <summary>The array of security group Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>The array of subnet Ids for customer VPC connectivity.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProvider
{
    /// <summary>The CPU architecture of an application. Valid values are ARM64 or X86_64. Default value is X86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>ARN of the cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The configuration for an application to automatically start on job submission.</summary>
    [JsonPropertyName("autoStartConfiguration")]
    public V1beta1ApplicationStatusAtProviderAutoStartConfiguration? AutoStartConfiguration { get; set; }

    /// <summary>The configuration for an application to automatically stop after a certain amount of time being idle.</summary>
    [JsonPropertyName("autoStopConfiguration")]
    public V1beta1ApplicationStatusAtProviderAutoStopConfiguration? AutoStopConfiguration { get; set; }

    /// <summary>The ID of the cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The image configuration applied to all worker types.</summary>
    [JsonPropertyName("imageConfiguration")]
    public V1beta1ApplicationStatusAtProviderImageConfiguration? ImageConfiguration { get; set; }

    /// <summary>The capacity to initialize when the application is created.</summary>
    [JsonPropertyName("initialCapacity")]
    public IList<V1beta1ApplicationStatusAtProviderInitialCapacity>? InitialCapacity { get; set; }

    /// <summary>Enables the interactive use cases to use when running an application.</summary>
    [JsonPropertyName("interactiveConfiguration")]
    public V1beta1ApplicationStatusAtProviderInteractiveConfiguration? InteractiveConfiguration { get; set; }

    /// <summary>The maximum capacity to allocate when the application is created. This is cumulative across all workers at any given point in time, not just when an application is created. No new resources will be created once any one of the defined limits is hit.</summary>
    [JsonPropertyName("maximumCapacity")]
    public V1beta1ApplicationStatusAtProviderMaximumCapacity? MaximumCapacity { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The network configuration for customer VPC connectivity.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1ApplicationStatusAtProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The EMR release version associated with the application.</summary>
    [JsonPropertyName("releaseLabel")]
    public string? ReleaseLabel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The type of application you want to start, such as spark or hive.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusConditions
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

/// <summary>ApplicationStatus defines the observed state of Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ApplicationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Application is the Schema for the Applications API. Manages an EMR Serverless Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Application : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApplicationSpec>, IStatus<V1beta1ApplicationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Application";
    public const string KubeGroup = "emrserverless.aws.m.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationSpec defines the desired state of Application</summary>
    [JsonPropertyName("spec")]
    public V1beta1ApplicationSpec Spec { get; set; }

    /// <summary>ApplicationStatus defines the observed state of Application.</summary>
    [JsonPropertyName("status")]
    public V1beta1ApplicationStatus? Status { get; set; }
}