---
id: CATOSPorts
slug: CATOSPorts
---

# NCM.CATOSPorts

SolarWinds Information Service 2020.2 Schema Documentation Index

## Inheritance

↳ [System.Entity](./../System/Entity)

## Access control

everyone

## Properties

| Name | Type | Summary | Access Control |
| ------ | ------ | ------ | ------ |
| NodeID | [System.Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid) |  | everyone |
| LastDiscovery | [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime) |  | everyone |
| FirstDiscovery | [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime) |  | everyone |
| Missing | [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean) |  | everyone |
| InterfaceIndex | [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32) |  | everyone |
| PortName | [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string) |  | everyone |
| EntityID | [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32) |  | everyone |

## Target Relationships

| Name | Type | Notes |
| ------ | ------ | ------ |
| NodeProperties | [NCM.NodeProperties](./../NCM/NodeProperties) | Defined by relationship NCM.NodePropertiesRefCATOSPorts (System.Hosting) |
| Interfaces | [NCM.Interfaces](./../NCM/Interfaces) | Defined by relationship NCM.InterfacesRefCATOSPorts (System.Reference) |

