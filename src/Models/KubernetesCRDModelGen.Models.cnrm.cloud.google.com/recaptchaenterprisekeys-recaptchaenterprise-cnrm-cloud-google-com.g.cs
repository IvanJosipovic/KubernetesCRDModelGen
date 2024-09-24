using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.recaptchaenterprise.cnrm.cloud.google.com;
public partial class V1beta1RecaptchaEnterpriseKeySpecAndroidSettings
{
    /// <summary>If set to true, it means allowed_package_names will not be enforced.</summary>
    [JsonPropertyName("allowAllPackageNames")]
    public bool? AllowAllPackageNames { get; set; }

    /// <summary>Android package names of apps allowed to use the key. Example: 'com.companyname.appname'</summary>
    [JsonPropertyName("allowedPackageNames")]
    public IList<string>? AllowedPackageNames { get; set; }
}

public partial class V1beta1RecaptchaEnterpriseKeySpecIosSettings
{
    /// <summary>If set to true, it means allowed_bundle_ids will not be enforced.</summary>
    [JsonPropertyName("allowAllBundleIds")]
    public bool? AllowAllBundleIds { get; set; }

    /// <summary>iOS bundle ids of apps allowed to use the key. Example: 'com.companyname.productname.appname'</summary>
    [JsonPropertyName("allowedBundleIds")]
    public IList<string>? AllowedBundleIds { get; set; }
}

public partial class V1beta1RecaptchaEnterpriseKeySpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1RecaptchaEnterpriseKeySpecTestingOptions
{
    /// <summary>Immutable. For challenge-based keys only (CHECKBOX, INVISIBLE), all challenge requests for this site will return nocaptcha if NOCAPTCHA, or an unsolvable challenge if UNSOLVABLE_CHALLENGE. Possible values: TESTING_CHALLENGE_UNSPECIFIED, NOCAPTCHA, UNSOLVABLE_CHALLENGE</summary>
    [JsonPropertyName("testingChallenge")]
    public string? TestingChallenge { get; set; }

    /// <summary>Immutable. All assessments for this Key will return this score. Must be between 0 (likely not legitimate) and 1 (likely legitimate) inclusive.</summary>
    [JsonPropertyName("testingScore")]
    public double? TestingScore { get; set; }
}

public partial class V1beta1RecaptchaEnterpriseKeySpecWafSettings
{
    /// <summary>Immutable. Supported WAF features. For more information, see https://cloud.google.com/recaptcha-enterprise/docs/usecase#comparison_of_features. Possible values: CHALLENGE_PAGE, SESSION_TOKEN, ACTION_TOKEN, EXPRESS</summary>
    [JsonPropertyName("wafFeature")]
    public string WafFeature { get; set; }

    /// <summary>Immutable. The WAF service that uses this key. Possible values: CA, FASTLY</summary>
    [JsonPropertyName("wafService")]
    public string WafService { get; set; }
}

public partial class V1beta1RecaptchaEnterpriseKeySpecWebSettings
{
    /// <summary>If set to true, it means allowed_domains will not be enforced.</summary>
    [JsonPropertyName("allowAllDomains")]
    public bool? AllowAllDomains { get; set; }

    /// <summary>If set to true, the key can be used on AMP (Accelerated Mobile Pages) websites. This is supported only for the SCORE integration type.</summary>
    [JsonPropertyName("allowAmpTraffic")]
    public bool? AllowAmpTraffic { get; set; }

    /// <summary>Domains or subdomains of websites allowed to use the key. All subdomains of an allowed domain are automatically allowed. A valid domain requires a host and must not include any path, port, query or fragment. Examples: 'example.com' or 'subdomain.example.com'</summary>
    [JsonPropertyName("allowedDomains")]
    public IList<string>? AllowedDomains { get; set; }

    /// <summary>Settings for the frequency and difficulty at which this key triggers captcha challenges. This should only be specified for IntegrationTypes CHECKBOX and INVISIBLE. Possible values: CHALLENGE_SECURITY_PREFERENCE_UNSPECIFIED, USABILITY, BALANCE, SECURITY</summary>
    [JsonPropertyName("challengeSecurityPreference")]
    public string? ChallengeSecurityPreference { get; set; }

    /// <summary>Immutable. Required. Describes how this key is integrated with the website. Possible values: SCORE, CHECKBOX, INVISIBLE</summary>
    [JsonPropertyName("integrationType")]
    public string IntegrationType { get; set; }
}

public partial class V1beta1RecaptchaEnterpriseKeySpec
{
    /// <summary>Settings for keys that can be used by Android apps.</summary>
    [JsonPropertyName("androidSettings")]
    public V1beta1RecaptchaEnterpriseKeySpecAndroidSettings? AndroidSettings { get; set; }

    /// <summary>Human-readable display name of this key. Modifiable by user.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Settings for keys that can be used by iOS apps.</summary>
    [JsonPropertyName("iosSettings")]
    public V1beta1RecaptchaEnterpriseKeySpecIosSettings? IosSettings { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1RecaptchaEnterpriseKeySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. Options for user acceptance testing.</summary>
    [JsonPropertyName("testingOptions")]
    public V1beta1RecaptchaEnterpriseKeySpecTestingOptions? TestingOptions { get; set; }

    /// <summary>Immutable. Settings specific to keys that can be used for WAF (Web Application Firewall).</summary>
    [JsonPropertyName("wafSettings")]
    public V1beta1RecaptchaEnterpriseKeySpecWafSettings? WafSettings { get; set; }

    /// <summary>Settings for keys that can be used by websites.</summary>
    [JsonPropertyName("webSettings")]
    public V1beta1RecaptchaEnterpriseKeySpecWebSettings? WebSettings { get; set; }
}

public partial class V1beta1RecaptchaEnterpriseKeyStatusConditions
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

public partial class V1beta1RecaptchaEnterpriseKeyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RecaptchaEnterpriseKeyStatusConditions>? Conditions { get; set; }

    /// <summary>The timestamp corresponding to the creation of this Key.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RecaptchaEnterpriseKey : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RecaptchaEnterpriseKeySpec>, IStatus<V1beta1RecaptchaEnterpriseKeyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RecaptchaEnterpriseKey";
    public const string KubeGroup = "recaptchaenterprise.cnrm.cloud.google.com";
    public const string KubePluralName = "recaptchaenterprisekeys";
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
    public V1beta1RecaptchaEnterpriseKeySpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1RecaptchaEnterpriseKeyStatus? Status { get; set; }
}