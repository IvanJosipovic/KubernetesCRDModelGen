# KubernetesCRDModelGen

[![Nuget](https://img.shields.io/nuget/vpre/KubernetesCRDModelGen.svg?style=flat-square)](https://www.nuget.org/packages/KubernetesCRDModelGen)[![Nuget)](https://img.shields.io/nuget/dt/KubernetesCRDModelGen.svg?style=flat-square)](https://www.nuget.org/packages/KubernetesCRDModelGen)
[![codecov](https://codecov.io/gh/IvanJosipovic/KubernetesCRDModelGen/branch/main/graph/badge.svg?token=Xxq5yw1TtO)](https://codecov.io/gh/IvanJosipovic/KubernetesCRDModelGen)

## What is this?

This project contains components which allow generation of C# Classes/Assemblies from Kubernetes Custom Resource Definitions.

- KubernetesCRDModelGen
  - Custom Resource Definition to C# Class/Assembly Generator
- KubernetesCRDModelGen.SourceGenerator
  - Yaml to C# Source Generator
- KubernetesCRDModelGen.Tool
  - Yaml to C# Class Generator
- KubernetesCRDModelGen.Sync
  - Synchronizes Custom Resource Definitions from numerous sources

## How to use

- Programmatically
  ```csharp
  var crd = KubernetesYaml.LoadAllFromString(yaml);
  var generator = new Generator();
  var code = generator.GenerateCode(crd);
  var result = generator.GenerateAssembly(crd);
  using var unloadHandle = result.UnloadHandle;

  if (!result.Success)
  {
      foreach (var diagnostic in result.Diagnostics)
      {
          Console.WriteLine($"{diagnostic.Severity}: {diagnostic.Id}: {diagnostic.Message}");
      }
  }
  else
  {
      var assembly = result.Assembly;
      var xml = result.XmlDocumentation;
  }
  ```
- CLI
  - Install .Net Tool
    - `dotnet tool install --global KubernetesCRDModelGen.Tool`
  - Run
    - `KubernetesCRDModelGen --FolderPath /path/to/yamls --Namespace Namespace`

## How to use the Source Generator
Create a C# Class Library Project and add some CRD yaml files to the project.
Update the .csproj with the following settings. The Models will be generated in the "KubernetesCRDModelGen.Models.{CRD Group Name}" namespace.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFrameworks>net10.0</TargetFrameworks>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <LangVersion>latest</LangVersion>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="KubernetesClient" Version="19.0.2" />
    <PackageReference Include="KubernetesCRDModelGen.SourceGenerator" Version="2.*" />
  </ItemGroup>

  <!-- For local CRD files -->
  <ItemGroup>
    <AdditionalFiles Include="*.yaml" />
  </ItemGroup>

  <!-- For Remote CRD files -->
  <ItemGroup>
    <!-- Single line style: -->
    <CRDYamlSourceUrls>https://app1.com/crd.yaml,https://app2.com/crd.yaml</CRDYamlSourceUrls>

    <!-- Multi line style: -->
    <CRDYamlSourceUrls>https://app1.com/crd.yaml</CRDYamlSourceUrls>
    <CRDYamlSourceUrls>$(CRDYamlSourceUrls),https://app2.com/crd.yaml</CRDYamlSourceUrls>
  </ItemGroup>

</Project>
```

## Published Packages

We publish the following premade packages

| Group | NuGet |
|---|---|
| aquasecurity.github.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.aquasecurity.github.io/) |
| argoproj.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.argoproj.io/) |
| aws.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.aws.upbound.io/) |
| azapi.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.azapi.upbound.io/) |
| azure.com | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.azure.com/)  |
| azure.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.azure.upbound.io/) |
| azuread.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.azuread.upbound.io/) |
| cnrm.cloud.google.com | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.cnrm.cloud.google.com/) |
| crossplane.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.crossplane.io/) |
| databricks.crossplane.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.databricks.crossplane.io/) |
| databricks.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.databricks.upbound.io/) |
| fluxcd.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.fluxcd.io/) |
| gateway.networking.k8s.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.gateway.networking.k8s.io/) |
| gcp.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.gcp.upbound.io/) |
| github.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.github.upbound.io/) |
| helm.crossplane.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.helm.crossplane.io/) |
| http.crossplane.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.http.crossplane.io/) |
| istio.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.istio.io/) |
| jetstack.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.jetstack.io/) |
| keda.sh | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.keda.sh/) |
| knative.dev | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.knative.dev/) |
| kubernetes.crossplane.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.kubernetes.crossplane.io/) |
| kubevirt.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.kubevirt.io/) |
| longhorn.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.longhorn.io/) |
| opentofu.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.opentofu.upbound.io/) |
| postgresql.cnpg.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.postgresql.cnpg.io/) |
| projectcalico.org | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.projectcalico.org/) |
| secrets-store.csi.x-k8s.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.secrets-store.csi.x-k8s.io) |
| storage.k8s.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.storage.k8s.io) |
| tf.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.tf.upbound.io/) |
| traefik.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.traefik.io/) |
| upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.upbound.io/) |
| vault.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.vault.upbound.io/) |

## Type Mappings

| OpenAPIv3 type | This library emits |
|---|---|
| `'object'` with Properties | generated class |
| `'object'` with AdditionalProperties | `IDictionary<string, TValue>` |
| `'object'` with `x-kubernetes-embedded-type` | currently treated like a normal object, so usually a generated class |
| `'object'` with `x-kubernetes-preserve-unknown-fields` | `JsonNode`, plus `JsonExtensionData` at object roots with the extension |
| `x-kubernetes-int-or-string` | `k8s.Models.IntOrString` |
| `'array'` | `IList<T>` |
| `'array'` with `x-kubernetes-list-type=atomic` | `IList<T>` |
| `'array'` with `x-kubernetes-list-type=map` | `IList<T>` |
| `'array'` with `x-kubernetes-list-type=set` | `IList<T>` |
| `'boolean'` | `bool` |
| `'number'` with `format=float` | `float` |
| `'number'` default / `format=double` | `double` |
| `'integer'` default / `format=int32` | `int` |
| `'integer'` with `format=int64` | `long` |
| `'null'` | nullable reference/value type when combined with another schema type |
| `'string'` | `string` |
| `'string'` with `format=binary` | `byte[]` |
| `'string'` with `format=byte` (base64 encoded) | `byte[]` |
| `'string'` with `format=date` | `DateTime` |
| `'string'` with `format=date-time` | `DateTime` |
| `'string'` with `format=duration` | `TimeSpan` |
