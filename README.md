# Local Development Instructions

## Install Git Hook

```
git config --local core.hooksPath githooks/
```

## Build App

```
dotnet build
```

## Run tests

### Unit tests

```
dotnet test --filter FullyQualifiedName\~UnitTests
```

### Acceptance tests

```
dotnet test --filter FullyQualifiedName\~AcceptanceTests
```

### All tests
```
dotnet test
```

## Run App

```
cd ReverseAPI && dotnet run && cd ..
```

## Check out the app

[https://localhost:7086/reverse?text=hello](https://localhost:7086/reverse?text=hello)

# CI/CD Resources

- [https://learn.microsoft.com/en-us/azure/devops/pipelines/get-started/what-is-azure-pipelines?view=azure-devops](What is Azure Pipelines?)
- [https://learn.microsoft.com/en-us/azure/devops/pipelines/get-started/pipelines-get-started?view=azure-devops](Use Azure Pipelines)
- [https://learn.microsoft.com/en-us/azure/devops/pipelines/create-first-pipeline?source=recommendations&view=azure-devops&tabs=net%2Ctfs-2018-2%2Cbrowser](Create your first pipeline)
- [https://learn.microsoft.com/en-us/azure/devops/pipelines/ecosystems/dotnet-core?view=azure-devops&tabs=dotnetfive](Build, test and deploy .NET Core apps)
- [https://learn.microsoft.com/en-us/azure/app-service/deploy-azure-pipelines?view=azure-devops&tabs=yaml](Configure CI/CD with Azure Pipelines)
- [https://learn.microsoft.com/en-us/azure/devops/pipelines/agents/agents?view=azure-devops&tabs=browser](Azure Pipelines agents)
- [https://learn.microsoft.com/en-us/azure/devops/pipelines/library/connect-to-azure?view=azure-devops](Connect to Microsoft Azure)