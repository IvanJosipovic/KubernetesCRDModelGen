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
| aws.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.aws.upbound.io/) |
| azure.com | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.azure.com/)  |
| azure.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.azure.upbound.io/) |
| cnrm.cloud.google.com | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.cnrm.cloud.google.com/) |
| crossplane.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.crossplane.io/) |
| fluxcd.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.fluxcd.io/) |
| gcp.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.gcp.upbound.io/) |
| helm.crossplane.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.helm.crossplane.io/) |
| istio.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.istio.io/) |
| jetstack.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.jetstack.io/) |
| projectcalico.org | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.projectcalico.org/) |
| tf.upbound.io | [Link](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.tf.upbound.io/) |

## Type Mappings

| OpenAPIv3 type | Type |
|---|---|
| 'object' with Properties | object |
| 'object' with AdditionalProperties | Dictionary |
| 'object' with x-kubernetes-embedded-type | object |
| 'object' with x-kubernetes-preserve-unknown-fields | object |
| 'object' with x-kubernetes-int-or-string | k8s.Models.IntstrIntOrString |
| 'array' | List |
| 'array' with x-kubernetes-list-type=atomic | List |
| 'array' with x-kubernetes-list-type=map | List |
| 'array' with x-kubernetes-list-type=set | List |
| 'boolean' | boolean |
| 'number' (all formats) | double |
| 'integer' (all formats) | int |
| 'integer' with format=int64 | long |
| 'null' | null |
| 'string' | string |
| 'string' with format=binary | ~~bytes~~ |
| 'string' with format=byte (base64 encoded) | ~~bytes~~ |
| 'string' with format=date | ~~timestamp (google.protobuf.Timestamp)~~ |
| 'string' with format=date-time | ~~timestamp (google.protobuf.Timestamp)~~ |
| 'string' with format=duration | ~~duration (google.protobuf.Duration)~~ |
