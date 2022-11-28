# KubernetesCRDModelGen
[![codecov](https://codecov.io/gh/IvanJosipovic/KubernetesCRDModelGen/branch/alpha/graph/badge.svg?token=Xxq5yw1TtO)](https://codecov.io/gh/IvanJosipovic/KubernetesCRDModelGen)

## What is this?
This project contains components which allow generation of C# Classes/Assemblies from Kubernetes Custom Resource Definitions.

- KubernetesCRDModelGen
  - Custom Resource Definition to C# Class/Assembly Generator
- KubernetesCRDModelGen.SourceGenerator
  - Yaml to C# Source Generator
- KubernetesCRDModelGen.Sync
  - Synchronizes Custom Resource Definitions from numerous sources

## Published Packages
We publish the following premade packages

| Group | NuGet |
|---|---|
| argoproj.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.argoproj.io/) |
| azure.com | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.azure.com/)  |
| azure.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.azure.upbound.io/) |
| fluxcd.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.fluxcd.io/) |
| istio.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.istio.io/) |
| jetstack.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.jetstack.io/) |
| projectcalico.org | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.projectcalico.org/) |

## Type Mappings

| OpenAPIv3 type | Type |
|---|---|
| 'object' with Properties | object |
| 'object' with AdditionalProperties | Dictionary
| 'object' with x-kubernetes-embedded-type | object |
| 'object' with x-kubernetes-preserve-unknown-fields | object |
| x-kubernetes-int-or-string | k8s.Models.IntstrIntOrString |
| 'array' | List |
| 'array' with x-kubernetes-list-type=map | List |
| 'array' with x-kubernetes-list-type=set | List |
| 'boolean' | boolean |
| 'number' (all formats) | double |
| 'integer' (all formats) | int (64) |
| 'null' | null |
| 'string' | string |
| 'string' with format=byte (base64 encoded) | bytes |
| 'string' with format=date | timestamp (google.protobuf.Timestamp) |
| 'string' with format=datetime | timestamp (google.protobuf.Timestamp) |
| 'string' with format=duration | duration (google.protobuf.Duration) |
