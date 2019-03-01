# OpenCQRS

[![Build Status](https://jmserrano-dev.visualstudio.com/OpenCQRS/_apis/build/status/Master?branchName=master)](https://jmserrano-dev.visualstudio.com/OpenCQRS/_build/latest?definitionId=10&branchName=master)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=jmserrano-dev_OpenCQRS&metric=alert_status)](https://sonarcloud.io/dashboard?id=jmserrano-dev_OpenCQRS) [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=jmserrano-dev_OpenCQRS&metric=code_smells)](https://sonarcloud.io/dashboard?id=jmserrano-dev_OpenCQRS) [![Bugs](https://sonarcloud.io/api/project_badges/measure?project=jmserrano-dev_OpenCQRS&metric=bugs)](https://sonarcloud.io/dashboard?id=jmserrano-dev_OpenCQRS) [![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=jmserrano-dev_OpenCQRS&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=jmserrano-dev_OpenCQRS) [![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=jmserrano-dev_OpenCQRS&metric=security_rating)](https://sonarcloud.io/dashboard?id=jmserrano-dev_OpenCQRS)

OpenCQRS is a .NET Core framework for Domain Driven Design (DDD), Command Query Responsibilty Segragation (CQRS) and Event Sourcing with Azure Service Bus integration.

## Original repo
https://github.com/OpenCQRS/OpenCQRS

## New features added

### 10 February 2019
- OpenCqrs.Bus.Rabbitmq supported
- OpenCqrs.Abstractions: This assembly allows having few depencies in Domain
- Rabbitmq enlistment transactions supported. This allows atomic commits in Database & Message Bus
- Azure Service Bus doesn't support DTC or 2PC (Two-phase Commit). I recommend using Rabbitmq to avoid possible inconsistencies.


## Nuget Packages

### Main packages

[![OpenCqrs package in my-packages@Local feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe@eec5fdcc-c0db-460d-a785-0fc66aaa0ed5&package=c79fbcf4-2aee-4e3d-8a30-00414059e584&preferRelease=true)

[![OpenCqrs.Abstractions package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Abstractions-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=c89288be-62e4-4514-9a1d-c872b1328f89&preferRelease=true)

### Bus packages

[![OpenCqrs.Bus package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Bus-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=6d58f7e7-7f26-4160-b350-fcfbe15287c8&preferRelease=true)

[![OpenCqrs.Bus.Rabbitmq package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Bus.Rabbitqm-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=ca3634b5-f032-4d1d-aa84-85f3afa26fb5&preferRelease=true)

[![OpenCqrs.Bus.ServiceBus package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Bus.ServiceBus-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=29717ec0-e267-483e-8b34-2b4bfc7799e0&preferRelease=true)

### Storage packages

#### Base

[![OpenCqrs.Store.EF package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Store.EF-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=839f0bb3-e305-4382-bf62-58e585be8a41&preferRelease=true)

#### Sql Storage

[![OpenCqrs.Store.EF.Sqlite package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Store.EF.Sqlite-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=867a745f-1d99-422d-b34c-f5899dfd215b&preferRelease=true)

[![OpenCqrs.Store.EF.MySql package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Store.EF.MySql-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=c595d1d1-3aa3-4c29-9911-97cc792b3ad2&preferRelease=true)

[![OpenCqrs.Store.EF.SqlServer package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Store.EF.SqlServer-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=b2119a67-3e14-4ee7-992f-bd527f873c74&preferRelease=true)

[![OpenCqrs.Store.EF.PostgreSql package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Store.EF.PostgreSql-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=f0676415-f9de-4fdb-b6f7-7fdeeb570ca5&preferRelease=true)

#### No-Sql Storage

[![OpenCqrs.Store.Cosmos.Sql package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Store.Cosmos.Sql-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=525aa782-db93-4468-b30a-4e003ad7a026&preferRelease=true)

[![OpenCqrs.Store.Cosmos.Mongo package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Store.Cosmos.Mongo-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=953151b9-b61a-437e-a4cc-d22721397b30&preferRelease=true)

#### Testing Storage

[![OpenCqrs.Store.EF.InMemory package in my-packages feed in Azure Artifacts](https://img.shields.io/badge/OpenCqrs.Store.EF.InMemory-6.0.1-blue.svg?style=flat&logo=nuget)](https://dev.azure.com/jmserrano-dev/OpenCQRS/_packaging?_a=package&feed=2891ba2e-c8f5-43fe-ab5f-412f20a0c5fe&package=d6aefe16-08db-41c8-a340-31bd774070c2&preferRelease=true)

## Wiki

https://github.com/OpenCQRS/OpenCQRS/wiki