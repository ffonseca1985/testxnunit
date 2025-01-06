# Documentation Commands

## General Commands
### Display Help
```bash
dotnet --help
```

### List .NET Versions
```bash
dotnet --list-runtimes
```

### Verify Templates
```bash
dotnet new --list
```

---

## Project Creation
### Create a Web API
```bash
dotnet new webapi -n Teste.WebApi --framework net6.0
```

### Create Class Libraries
```bash
dotnet new classlib -n Teste.Bussiness --framework net6.0
dotnet new classlib -n Teste.Repository --framework net6.0
dotnet new classlib -n Teste.Entity --framework net6.0
```

---

## Folder Operations
### Move to `src` Folder
```bash
mkdir src
move Test.* src
```

### Create a Test Project
```bash
dotnet new xunit -n Teste.test --framework net6.0
```

### Move to `tests` Folder
```bash
mkdir tests
move Test.* tests
```

---

## Solution Setup
### Create a Solution
```bash
dotnet new sln -n Teste
```

### Add Projects to the Solution
```bash
dotnet sln Teste.sln add ./src/Teste.Bussiness/Teste.Bussiness.csproj 
dotnet sln Teste.sln add ./src/Teste.WebApi/Teste.WebApi.csproj
dotnet sln Teste.sln add ./tests/Teste.test/Teste.test.csproj
dotnet sln Teste.sln add ./src/Teste.Entity/Teste.Entity.csproj
dotnet sln Teste.sln add ./src/Teste.Repository/Teste.Repository.csproj
```

---

## Add References
### Add References Between Projects
```bash
dotnet add ./src/Teste.WebApi/Teste.WebApi.csproj reference ./src/Teste.Bussiness/Teste.Bussiness.csproj
dotnet add ./src/Teste.Bussiness/Teste.Bussiness.csproj reference ./src/Teste.Repository/Teste.Repository.csproj
dotnet add ./src/Teste.Bussiness/Teste.Bussiness.csproj reference ./src/Teste.Entity/Teste.Entity.csproj    
dotnet add ./src/Teste.Repository/Teste.Repository.csproj reference ./src/Teste.Entity/Teste.Entity.csproj  
```

### Add References to Test Project
```bash
dotnet add ./tests/Teste.test/Teste.test.csproj reference ./src/Teste.Bussiness/Teste.Bussiness.csproj
dotnet add ./tests/Teste.test/Teste.test.csproj reference ./src/Teste.WebApi/Teste.WebApi.csproj
dotnet add ./tests/Teste.test/Teste.test.csproj reference ./src/Teste.Repository/Teste.Repository.csproj
dotnet add ./tests/Teste.test/Teste.test.csproj reference ./src/Teste.Entity/Teste.Entity.csproj 
```

---

## Add NuGet Packages
### Add Packages to Test Project
```bash
dotnet add ./tests/Teste.test/Teste.test.csproj package NSubstitute
dotnet add ./tests/Teste.test/Teste.test.csproj package FluentAssertions
```

---

## Additional Commands
### Create a Class
```bash
dotnet new class -n UserServiceTests -o ./tests/Teste.test/
```

### Generate a Test Coverage Report
```bash
dotnet test --collect:"XPlat Code Coverage"
```

---

## Tools and Reports
### Check Installed Tools
```bash
dotnet tool list --global
```

### Install Tool for Report Generation
```bash
dotnet tool install --global dotnet-reportgenerator-globaltool
```

### Generate HTML Coverage Report
(Go to the `coveragexml` path and execute the command below)
```bash
reportgenerator "-reports:coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html
```

---

## Build and Test
### Build the Project
```bash
dotnet build
```

### Run Tests
```bash
dotnet test
