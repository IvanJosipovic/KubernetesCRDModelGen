using System;
using k8s;
using k8s.Models;
using System.ComponentModel;
[KubernetesEntity(ApiVersion = "v1beta1", Group = "image.toolkit.fluxcd.io", Kind = "ImageRepository", PluralName = "imagerepositories")]
[Description(@"ImageRepository is the Schema for the imagerepositories API")]
public class ImageRepository : IKubernetesObject<V1ObjectMeta?>, ISpec<ImageRepositorySpec?>, IStatus<ImageRepositoryStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ImageRepository";
    public const string KubeGroup = "image.toolkit.fluxcd.io";
    public string ApiVersion { get; set; }
    public string Kind { get; set; }
    public V1ObjectMeta? Metadata { get; set; }
    public ImageRepositorySpec Spec { get; set; }
    public ImageRepositoryStatus Status { get; set; }
}
[Description(@"ImageRepositorySpec defines the parameters for scanning an image repository, e.g., `fluxcd/flux`.")]
public class ImageRepositorySpec
{
    [Description(@"AccessFrom defines an ACL for allowing cross-namespace references to the ImageRepository object based on the caller's namespace labels.")]
    public ImageRepositorySpecaccessFrom accessFrom { get; set; }
    [Description(@"CertSecretRef can be given the name of a secret containing either or both of 
  - a PEM-encoded client certificate (`certFile`) and private  key (`keyFile`);  - a PEM-encoded CA certificate (`caFile`) 
  and whichever are supplied, will be used for connecting to the  registry. The client cert and key are useful if you are  authenticating with a certificate; the CA cert is useful if  you are using a self-signed server certificate.")]
    public ImageRepositorySpeccertSecretRef certSecretRef { get; set; }
    [Description(@"Image is the name of the image repository")]
    public System.String image { get; set; }
    [Description(@"Interval is the length of time to wait between scans of the image repository.")]
    public System.String interval { get; set; }
    [Description(@"SecretRef can be given the name of a secret containing credentials to use for the image registry. The secret should be created with `kubectl create secret docker-registry`, or the equivalent.")]
    public ImageRepositorySpecsecretRef secretRef { get; set; }
    [Description(@"This flag tells the controller to suspend subsequent image scans. It does not apply to already started scans. Defaults to false.")]
    public System.Boolean suspend { get; set; }
    [Description(@"Timeout for image scanning. Defaults to 'Interval' duration.")]
    public System.String timeout { get; set; }
}
[Description(@"AccessFrom defines an ACL for allowing cross-namespace references to the ImageRepository object based on the caller's namespace labels.")]
public class ImageRepositorySpecaccessFrom
{
}
[Description(@"CertSecretRef can be given the name of a secret containing either or both of 
  - a PEM-encoded client certificate (`certFile`) and private  key (`keyFile`);  - a PEM-encoded CA certificate (`caFile`) 
  and whichever are supplied, will be used for connecting to the  registry. The client cert and key are useful if you are  authenticating with a certificate; the CA cert is useful if  you are using a self-signed server certificate.")]
public class ImageRepositorySpeccertSecretRef
{
    [Description(@"Name of the referent")]
    public System.String name { get; set; }
}
[Description(@"SecretRef can be given the name of a secret containing credentials to use for the image registry. The secret should be created with `kubectl create secret docker-registry`, or the equivalent.")]
public class ImageRepositorySpecsecretRef
{
    [Description(@"Name of the referent")]
    public System.String name { get; set; }
}
[Description(@"ImageRepositoryStatus defines the observed state of ImageRepository")]
public class ImageRepositoryStatus
{
    [Description(@"CanonicalName is the name of the image repository with all the implied bits made explicit; e.g., `docker.io/library/alpine` rather than `alpine`.")]
    public System.String canonicalImageName { get; set; }
    [Description(@"LastHandledReconcileAt holds the value of the most recent reconcile request value, so a change can be detected.")]
    public System.String lastHandledReconcileAt { get; set; }
    [Description(@"LastScanResult contains the number of fetched tags.")]
    public ImageRepositoryStatuslastScanResult lastScanResult { get; set; }
    [Description(@"ObservedGeneration is the last reconciled generation.")]
    public System.Int32 observedGeneration { get; set; }
}
[Description(@"LastScanResult contains the number of fetched tags.")]
public class ImageRepositoryStatuslastScanResult
{
    public System.String scanTime { get; set; }
    public System.Int32 tagCount { get; set; }
}