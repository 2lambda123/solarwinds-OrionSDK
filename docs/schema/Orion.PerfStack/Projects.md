---
id: Projects
slug: Projects
---

# Orion.PerfStack.Projects

SolarWinds Information Service 2020.2 Schema Documentation Index

This entity represents the view of a Performance Analysis Project, that the user
      can store, reload or share with others.

## Inheritance

↳ [System.Entity](./../System/Entity)

## Access control

| Operations | Right |
| ------ | ------ |
| create,read,update,delete,invoke | admin |
| read | everyone |

## Properties

| Name | Type | Summary | Access Control |
| ------ | ------ | ------ | ------ |
| AccountID | [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string) |  | create,read,delete,invoke: admin&amp;lt;br/&amp;gt;read: everyone |
| ProjectID | [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string) |  | everyone |
| UpdateDateTime | [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime) |  | everyone |
| CreateDateTime | [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime) |  | everyone |
| Favorite | [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean) |  | everyone |
| Data | [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string) |  | everyone |
| ChartCount | [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32) |  | everyone |
| MetricCount | [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32) |  | everyone |
| MetricTypes | [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string) |  | everyone |

