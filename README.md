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

We publish premade packages for popular projects at the following repo:

[KubernetesCRDModelGen.Models](https://github.com/IvanJosipovic/KubernetesCRDModelGen.Models)


## Type Mappings

| OpenAPIv3 type | This library emits |
|---|---|
| `'object'` with Properties | generated class |
| `'object'` with AdditionalProperties | `IDictionary<string, TValue>` |
| `'object'` with `x-kubernetes-embedded-resource` | generated class, with implicit `apiVersion`, `kind`, and `metadata` properties added when missing |
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
| `'string'` with `format=duration` | `string` |
