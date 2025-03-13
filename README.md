# New project Primes

### Create project with git repository and setting up SDK
```powershell
cd Primes
git init
dotnet new globaljson --sdk-version=8.0.302  --roll-forward latestFeature
dotnet new sln --name Primes
```

## Application
```powershell
dotnet new classlib --output src/Application --name Primes.Application
dotnet sln add src/Application
```

## Infrastructure

```powershell
dotnet new classlib --output src/Infrastructure --name Primes.Infrastructure
dotnet sln add src/Infrastructure
dotnet add src/Infrastructure reference src/Application
```

## WebAPI with controllers
```powershell 
dotnet new webapi --no-https --use-controllers --use-program-main --output src/WebApi --name Primes.WebApi
dotnet sln add src/WebAPI
dotnet add src/WebApi reference src/Infrastructure
```

### Packages
#### Logging
```powershell
dotnet add src/Application package Microsoft.Extensions.Logging.Abstractions
```
#### Package for CQRS way with mediator
```powershell
dotnet add src/Application package MediatR
```
#### Package for MySQL
```powershell
dotnet add src/Infrastructure package MySql.Data
```
#### Automaper for objects
```powershell
dotnet add src/Infrastructure package AutoMapper
```
#### Package for partial configuration
```powershell
dotnet add src/Infrastructure package Microsoft.Extensions.Configuration.Binder
```


## Add Application UnitTests

```powershell
dotnet new mstest --output tests/Application.UnitTests --name Primes.Application.UnitTests
dotnet sln add tests/Application.UnitTests
dotnet add tests/Application.UnitTests reference src/Application

```

## Tests
```powershell
dotnet new mstest --output tests/WebApi.IntegrationTests --name Primes.WebApi.IntegrationTests
dotnet sln add tests/WebApi.IntegrationTests
dotnet add tests/WebApi.IntegrationTests reference src/WebApi
```

### Packages for testing
```powershell
dotnet add tests/Application.UnitTests package Microsoft.Extensions.Logging
dotnet add tests/WebApi.IntegrationTests package FluentAssertions
dotnet add tests/WebApi.IntegrationTests package Microsoft.AspNetCore.Mvc.Testing
```

