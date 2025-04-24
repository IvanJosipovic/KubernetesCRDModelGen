using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containeranalysis.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteMetadata
{
}

/// <summary>Hint hints at the purpose of the attestation authority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecAttestationHint
{
    /// <summary>Required. The human readable name of this attestation authority, for example "qa".</summary>
    [JsonPropertyName("humanReadableName")]
    public string HumanReadableName { get; set; }
}

/// <summary>A note describing an attestation role.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecAttestation
{
    /// <summary>Hint hints at the purpose of the attestation authority.</summary>
    [JsonPropertyName("hint")]
    public ContainerAnalysisNoteSpecAttestationHint? Hint { get; set; }
}

/// <summary>A note describing build provenance for a verifiable build.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecBuild
{
    /// <summary>Required. Immutable. Version of the builder which produced this build.</summary>
    [JsonPropertyName("builderVersion")]
    public string BuilderVersion { get; set; }
}

/// <summary>A note describing something that can be deployed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecDeployment
{
    /// <summary>Required. Resource URI for the artifact being deployed.</summary>
    [JsonPropertyName("resourceUri")]
    public IList<string> ResourceUri { get; set; }
}

/// <summary>A note describing the initial analysis of a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecDiscovery
{
    /// <summary>The kind of analysis that is handled by this discovery. Possible values: NOTE_KIND_UNSPECIFIED, VULNERABILITY, BUILD, IMAGE, PACKAGE, DEPLOYMENT, DISCOVERY, ATTESTATION, UPGRADE</summary>
    [JsonPropertyName("analysisKind")]
    public string AnalysisKind { get; set; }
}

/// <summary>Required. Immutable. The fingerprint of the base image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecImageFingerprint
{
    /// <summary>Required. The layer ID of the final layer in the Docker image's v1 representation.</summary>
    [JsonPropertyName("v1Name")]
    public string V1Name { get; set; }

    /// <summary>Required. The ordered list of v2 blobs that represent a given image.</summary>
    [JsonPropertyName("v2Blob")]
    public IList<string> V2Blob { get; set; }
}

/// <summary>A note describing a base image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecImage
{
    /// <summary>Required. Immutable. The fingerprint of the base image.</summary>
    [JsonPropertyName("fingerprint")]
    public ContainerAnalysisNoteSpecImageFingerprint Fingerprint { get; set; }

    /// <summary>Required. Immutable. The resource_url for the resource representing the basis of associated occurrence images.</summary>
    [JsonPropertyName("resourceUrl")]
    public string ResourceUrl { get; set; }
}

/// <summary>The latest available version of this package in this distribution channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecPackageDistributionLatestVersion
{
    /// <summary>Used to correct mistakes in the version numbering scheme.</summary>
    [JsonPropertyName("epoch")]
    public long? Epoch { get; set; }

    /// <summary>Human readable version string. This string is of the form :- and is only set when kind is NORMAL.</summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>Distinguish between sentinel MIN/MAX versions and normal versions. If kind is not NORMAL, then the other fields are ignored. Possible values: VERSION_KIND_UNSPECIFIED, NORMAL, MINIMUM, MAXIMUM</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>The main part of the version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The iteration of the package build from the above version.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecPackageDistribution
{
    /// <summary>The CPU architecture for which packages in this distribution channel were built Possible values: ARCHITECTURE_UNSPECIFIED, X86, X64</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>The cpe_uri in [cpe format](https://cpe.mitre.org/specification/) denoting the package manager version distributing a package.</summary>
    [JsonPropertyName("cpeUri")]
    public string CpeUri { get; set; }

    /// <summary>The distribution channel-specific description of this package.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The latest available version of this package in this distribution channel.</summary>
    [JsonPropertyName("latestVersion")]
    public ContainerAnalysisNoteSpecPackageDistributionLatestVersion? LatestVersion { get; set; }

    /// <summary>A freeform string denoting the maintainer of this package.</summary>
    [JsonPropertyName("maintainer")]
    public string? Maintainer { get; set; }

    /// <summary>The distribution channel-specific homepage for this package.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Required for non-Windows OS. The package this Upgrade is for.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecPackage
{
    /// <summary>The various channels by which a package is distributed.</summary>
    [JsonPropertyName("distribution")]
    public IList<ContainerAnalysisNoteSpecPackageDistribution>? Distribution { get; set; }

    /// <summary>The name of the package.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecRelatedNoteNames
{
    /// <summary>Allowed value: The Google Cloud resource name of a `ContainerAnalysisNote` resource (format: `projects/{{project}}/notes/{{name}}`).</summary>
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
public partial class ContainerAnalysisNoteSpecRelatedUrl
{
    /// <summary>Label to describe usage of the URL</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Specific URL to associate with the note</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The full description of the CVSSv3 for this vulnerability.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecVulnerabilityCvssV3
{
    /// <summary> Possible values: ATTACK_COMPLEXITY_UNSPECIFIED, ATTACK_COMPLEXITY_LOW, ATTACK_COMPLEXITY_HIGH</summary>
    [JsonPropertyName("attackComplexity")]
    public string? AttackComplexity { get; set; }

    /// <summary>Base Metrics Represents the intrinsic characteristics of a vulnerability that are constant over time and across user environments. Possible values: ATTACK_VECTOR_UNSPECIFIED, ATTACK_VECTOR_NETWORK, ATTACK_VECTOR_ADJACENT, ATTACK_VECTOR_LOCAL, ATTACK_VECTOR_PHYSICAL</summary>
    [JsonPropertyName("attackVector")]
    public string? AttackVector { get; set; }

    /// <summary> Possible values: IMPACT_UNSPECIFIED, IMPACT_HIGH, IMPACT_LOW, IMPACT_NONE</summary>
    [JsonPropertyName("availabilityImpact")]
    public string? AvailabilityImpact { get; set; }

    /// <summary>The base score is a function of the base metric scores.</summary>
    [JsonPropertyName("baseScore")]
    public double? BaseScore { get; set; }

    /// <summary> Possible values: IMPACT_UNSPECIFIED, IMPACT_HIGH, IMPACT_LOW, IMPACT_NONE</summary>
    [JsonPropertyName("confidentialityImpact")]
    public string? ConfidentialityImpact { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exploitabilityScore")]
    public double? ExploitabilityScore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("impactScore")]
    public double? ImpactScore { get; set; }

    /// <summary> Possible values: IMPACT_UNSPECIFIED, IMPACT_HIGH, IMPACT_LOW, IMPACT_NONE</summary>
    [JsonPropertyName("integrityImpact")]
    public string? IntegrityImpact { get; set; }

    /// <summary> Possible values: PRIVILEGES_REQUIRED_UNSPECIFIED, PRIVILEGES_REQUIRED_NONE, PRIVILEGES_REQUIRED_LOW, PRIVILEGES_REQUIRED_HIGH</summary>
    [JsonPropertyName("privilegesRequired")]
    public string? PrivilegesRequired { get; set; }

    /// <summary> Possible values: SCOPE_UNSPECIFIED, SCOPE_UNCHANGED, SCOPE_CHANGED</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary> Possible values: USER_INTERACTION_UNSPECIFIED, USER_INTERACTION_NONE, USER_INTERACTION_REQUIRED</summary>
    [JsonPropertyName("userInteraction")]
    public string? UserInteraction { get; set; }
}

/// <summary>The version number at the end of an interval in which this vulnerability exists. A vulnerability can affect a package between version numbers that are disjoint sets of intervals (example: ) each of which will be represented in its own Detail. If a specific affected version is provided by a vulnerability database, affected_version_start and affected_version_end will be the same in that Detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecVulnerabilityDetailsAffectedVersionEnd
{
    /// <summary>Used to correct mistakes in the version numbering scheme.</summary>
    [JsonPropertyName("epoch")]
    public long? Epoch { get; set; }

    /// <summary>Human readable version string. This string is of the form :- and is only set when kind is NORMAL.</summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>Required. Distinguishes between sentinel MIN/MAX versions and normal versions. Possible values: NOTE_KIND_UNSPECIFIED, VULNERABILITY, BUILD, IMAGE, PACKAGE, DEPLOYMENT, DISCOVERY, ATTESTATION, UPGRADE</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Required only when version kind is NORMAL. The main part of the version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The iteration of the package build from the above version.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary>The version number at the start of an interval in which this vulnerability exists. A vulnerability can affect a package between version numbers that are disjoint sets of intervals (example: ) each of which will be represented in its own Detail. If a specific affected version is provided by a vulnerability database, affected_version_start and affected_version_end will be the same in that Detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecVulnerabilityDetailsAffectedVersionStart
{
    /// <summary>Used to correct mistakes in the version numbering scheme.</summary>
    [JsonPropertyName("epoch")]
    public long? Epoch { get; set; }

    /// <summary>Human readable version string. This string is of the form :- and is only set when kind is NORMAL.</summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>Required. Distinguishes between sentinel MIN/MAX versions and normal versions. Possible values: NOTE_KIND_UNSPECIFIED, VULNERABILITY, BUILD, IMAGE, PACKAGE, DEPLOYMENT, DISCOVERY, ATTESTATION, UPGRADE</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Required only when version kind is NORMAL. The main part of the version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The iteration of the package build from the above version.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary>The distro recommended version to update to that contains a fix for this vulnerability. Setting this to VersionKind.MAXIMUM means no such version is yet available.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecVulnerabilityDetailsFixedVersion
{
    /// <summary>Used to correct mistakes in the version numbering scheme.</summary>
    [JsonPropertyName("epoch")]
    public long? Epoch { get; set; }

    /// <summary>Human readable version string. This string is of the form :- and is only set when kind is NORMAL.</summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>Required. Distinguishes between sentinel MIN/MAX versions and normal versions. Possible values: NOTE_KIND_UNSPECIFIED, VULNERABILITY, BUILD, IMAGE, PACKAGE, DEPLOYMENT, DISCOVERY, ATTESTATION, UPGRADE</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Required only when version kind is NORMAL. The main part of the version name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The iteration of the package build from the above version.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecVulnerabilityDetails
{
    /// <summary>Required. The (https://cpe.mitre.org/specification/) this vulnerability affects.</summary>
    [JsonPropertyName("affectedCpeUri")]
    public string AffectedCpeUri { get; set; }

    /// <summary>Required. The package this vulnerability affects.</summary>
    [JsonPropertyName("affectedPackage")]
    public string AffectedPackage { get; set; }

    /// <summary>The version number at the end of an interval in which this vulnerability exists. A vulnerability can affect a package between version numbers that are disjoint sets of intervals (example: ) each of which will be represented in its own Detail. If a specific affected version is provided by a vulnerability database, affected_version_start and affected_version_end will be the same in that Detail.</summary>
    [JsonPropertyName("affectedVersionEnd")]
    public ContainerAnalysisNoteSpecVulnerabilityDetailsAffectedVersionEnd? AffectedVersionEnd { get; set; }

    /// <summary>The version number at the start of an interval in which this vulnerability exists. A vulnerability can affect a package between version numbers that are disjoint sets of intervals (example: ) each of which will be represented in its own Detail. If a specific affected version is provided by a vulnerability database, affected_version_start and affected_version_end will be the same in that Detail.</summary>
    [JsonPropertyName("affectedVersionStart")]
    public ContainerAnalysisNoteSpecVulnerabilityDetailsAffectedVersionStart? AffectedVersionStart { get; set; }

    /// <summary>A vendor-specific description of this vulnerability.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The distro recommended (https://cpe.mitre.org/specification/) to update to that contains a fix for this vulnerability. It is possible for this to be different from the affected_cpe_uri.</summary>
    [JsonPropertyName("fixedCpeUri")]
    public string? FixedCpeUri { get; set; }

    /// <summary>The distro recommended package to update to that contains a fix for this vulnerability. It is possible for this to be different from the affected_package.</summary>
    [JsonPropertyName("fixedPackage")]
    public string? FixedPackage { get; set; }

    /// <summary>The distro recommended version to update to that contains a fix for this vulnerability. Setting this to VersionKind.MAXIMUM means no such version is yet available.</summary>
    [JsonPropertyName("fixedVersion")]
    public ContainerAnalysisNoteSpecVulnerabilityDetailsFixedVersion? FixedVersion { get; set; }

    /// <summary>Whether this detail is obsolete. Occurrences are expected not to point to obsolete details.</summary>
    [JsonPropertyName("isObsolete")]
    public bool? IsObsolete { get; set; }

    /// <summary>The type of package; whether native or non native (e.g., ruby gems, node.js packages, etc.).</summary>
    [JsonPropertyName("packageType")]
    public string? PackageType { get; set; }

    /// <summary>The distro assigned severity of this vulnerability.</summary>
    [JsonPropertyName("severityName")]
    public string? SeverityName { get; set; }

    /// <summary>The time this information was last changed at the source. This is an upstream timestamp from the underlying information source - e.g. Ubuntu security tracker.</summary>
    [JsonPropertyName("sourceUpdateTime")]
    public string? SourceUpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecVulnerabilityWindowsDetailsFixingKbs
{
    /// <summary>The KB name (generally of the form KB+ (e.g., KB123456)).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A link to the KB in the (https://www.catalog.update.microsoft.com/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecVulnerabilityWindowsDetails
{
    /// <summary>Required. The (https://cpe.mitre.org/specification/) this vulnerability affects.</summary>
    [JsonPropertyName("cpeUri")]
    public string CpeUri { get; set; }

    /// <summary>The description of this vulnerability.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The names of the KBs which have hotfixes to mitigate this vulnerability. Note that there may be multiple hotfixes (and thus multiple KBs) that mitigate a given vulnerability. Currently any listed KBs presence is considered a fix.</summary>
    [JsonPropertyName("fixingKbs")]
    public IList<ContainerAnalysisNoteSpecVulnerabilityWindowsDetailsFixingKbs> FixingKbs { get; set; }

    /// <summary>Required. The name of this vulnerability.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A note describing a package vulnerability.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpecVulnerability
{
    /// <summary>The CVSS score of this vulnerability. CVSS score is on a scale of 0 - 10 where 0 indicates low severity and 10 indicates high severity.</summary>
    [JsonPropertyName("cvssScore")]
    public double? CvssScore { get; set; }

    /// <summary>The full description of the CVSSv3 for this vulnerability.</summary>
    [JsonPropertyName("cvssV3")]
    public ContainerAnalysisNoteSpecVulnerabilityCvssV3? CvssV3 { get; set; }

    /// <summary>Details of all known distros and packages affected by this vulnerability.</summary>
    [JsonPropertyName("details")]
    public IList<ContainerAnalysisNoteSpecVulnerabilityDetails>? Details { get; set; }

    /// <summary>The note provider assigned severity of this vulnerability. Possible values: SEVERITY_UNSPECIFIED, MINIMAL, LOW, MEDIUM, HIGH, CRITICAL</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>The time this information was last changed at the source. This is an upstream timestamp from the underlying information source - e.g. Ubuntu security tracker.</summary>
    [JsonPropertyName("sourceUpdateTime")]
    public string? SourceUpdateTime { get; set; }

    /// <summary>Windows details get their own format because the information format and model don't match a normal detail. Specifically Windows updates are done as patches, thus Windows vulnerabilities really are a missing package, rather than a package being at an incorrect version.</summary>
    [JsonPropertyName("windowsDetails")]
    public IList<ContainerAnalysisNoteSpecVulnerabilityWindowsDetails>? WindowsDetails { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteSpec
{
    /// <summary>A note describing an attestation role.</summary>
    [JsonPropertyName("attestation")]
    public ContainerAnalysisNoteSpecAttestation? Attestation { get; set; }

    /// <summary>A note describing build provenance for a verifiable build.</summary>
    [JsonPropertyName("build")]
    public ContainerAnalysisNoteSpecBuild? Build { get; set; }

    /// <summary>A note describing something that can be deployed.</summary>
    [JsonPropertyName("deployment")]
    public ContainerAnalysisNoteSpecDeployment? Deployment { get; set; }

    /// <summary>A note describing the initial analysis of a resource.</summary>
    [JsonPropertyName("discovery")]
    public ContainerAnalysisNoteSpecDiscovery? Discovery { get; set; }

    /// <summary>Time of expiration for this note. Empty if note does not expire.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>A note describing a base image.</summary>
    [JsonPropertyName("image")]
    public ContainerAnalysisNoteSpecImage? Image { get; set; }

    /// <summary>A detailed description of this note.</summary>
    [JsonPropertyName("longDescription")]
    public string? LongDescription { get; set; }

    /// <summary>Required for non-Windows OS. The package this Upgrade is for.</summary>
    [JsonPropertyName("package")]
    public ContainerAnalysisNoteSpecPackage? Package { get; set; }

    /// <summary></summary>
    [JsonPropertyName("relatedNoteNames")]
    public IList<ContainerAnalysisNoteSpecRelatedNoteNames>? RelatedNoteNames { get; set; }

    /// <summary>URLs associated with this note.</summary>
    [JsonPropertyName("relatedUrl")]
    public IList<ContainerAnalysisNoteSpecRelatedUrl>? RelatedUrl { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>A one sentence description of this note.</summary>
    [JsonPropertyName("shortDescription")]
    public string? ShortDescription { get; set; }

    /// <summary>A note describing a package vulnerability.</summary>
    [JsonPropertyName("vulnerability")]
    public ContainerAnalysisNoteSpecVulnerability? Vulnerability { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteStatusConditions
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
public partial class ContainerAnalysisNoteStatusImageFingerprint
{
    /// <summary>Output only. The name of the image's v2 blobs computed via: ) Only the name of the final blob is kept.</summary>
    [JsonPropertyName("v2Name")]
    public string? V2Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteStatusImage
{
    /// <summary></summary>
    [JsonPropertyName("fingerprint")]
    public ContainerAnalysisNoteStatusImageFingerprint? Fingerprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNoteStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<ContainerAnalysisNoteStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The time this note was created. This field can be used as a filter in list requests.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("image")]
    public ContainerAnalysisNoteStatusImage? Image { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The time this note was last updated. This field can be used as a filter in list requests.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContainerAnalysisNote
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public ContainerAnalysisNoteMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public ContainerAnalysisNoteSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public ContainerAnalysisNoteStatus? Status { get; set; }
}