---
id: ReachabilityInfo
slug: ReachabilityInfo
---

# Orion.ReachabilityInfo

SolarWinds Information Service 2020.2 Schema Documentation Index

List of host names and IP addresses of all polling engines.

## Inheritance

↳ [System.Entity](./../System/Entity)

## Access control

everyone

## Properties

| Name | Type | Summary | Access Control |
| ------ | ------ | ------ | ------ |
| IP | [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string) | IP v4 address, can be null | everyone |
| HostName | [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string) | Host name of Orion server, can be null | everyone |
| OrionServerId | [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32) | ID of Orion.OrionServers entity | everyone |
| EngineId | [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32) | ID of Orion.Engines entity, can be null | everyone |
| IsMyOwn | [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean) | IP or hostname belongs to currently connected Orion | everyone |
| IsPreferred | [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean) | Preferred IP or HostName for making a connection it is set just for one row per Orion server | everyone |
| IsVirtual | [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean) | Set to true in case of virtual IP or virtual HostName | everyone |

## Target Relationships

| Name | Type | Notes |
| ------ | ------ | ------ |
| Engine | [Orion.Engines](./../Orion/Engines) | Defined by relationship Orion.EnginesReferencesReachabilityInfo (System.Reference) |
| OrionServer | [Orion.OrionServers](./../Orion/OrionServers) | Defined by relationship Orion.OrionServersReferencesReachabilityInfo (System.Reference) |

