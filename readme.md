# doc commands
```bash
dotnet --help

# list dotnet versions
```bash
dotnet --list-runtimes

# verify templates
```bash
dotnte new --list

# Creating a class webapi
```bash
dotnet new webapi -n Teste.WebApi --framework net6.0

# Creating a class library
```bash
dotnet new classlib -n Teste.Bussiness --framework net6.0
dotnet new classlib -n Teste.Repository --framework net6.0
dotnet new classlib -n Teste.Entity --framework net6.0

# Moving to folder src
```bash
mkdir src
move Test.* src

# Creating a test project
```bash
dotnet new xunit -n Teste.test --framework net6.0

# Moving to folder tests
```bash
mkdir tests
move Test.* tests

# Creating a solution
```bash
dotnet new sln -n Teste

# Add project(s) to solution
```bash
dotnet sln Test.sln add ./src/Teste.Bussiness/Teste.Bussiness.csproj 
dotnet sln Teste.sln add ./src/Teste.WebApi/Teste.WebApi.csproj
dotnet sln Teste.sln add .\tests\Teste.test\Teste.test.csproj
dotnet sln Teste.sln add .\src\Teste.Entity\Teste.Entity.csproj
dotnet sln Teste.sln add .\src\Teste.Repository\Teste.Repository.csproj

# Add refetence (src folder)
```bash
dotnet add .\src\Teste.WebApi\Teste.WebApi.csproj reference .\src\Teste.Bussiness\Teste.Bussiness.csproj
dotnet add .\src\Teste.Bussiness\Teste.Bussiness.csproj reference .\src\Teste.Repository\Teste.Repository.csproj
dotnet add .\src\Teste.Bussiness\Teste.Bussiness.csproj reference .\src\Teste.Entity\Teste.Entity.csproj    
dotnet add .\src\Teste.Repository\Teste.Repository.csproj reference .\src\Teste.Entity\Teste.Entity.csproj  

# Add reference to test
```bash
dotnet add .\tests\Teste.test\Teste.test.csproj reference .\src\Teste.Bussiness\Teste.Bussiness.csproj
dotnet add .\tests\Teste.test\Teste.test.csproj reference .\src\Teste.WebApi\Teste.WebApi.csproj
dotnet add .\tests\Teste.test\Teste.test.csproj reference .\src\Teste.Repository\Teste.Repository.csproj
dotnet add .\tests\Teste.test\Teste.test.csproj reference .\src\Teste.Entity\Teste.Entity.csproj 

# Add Packages to test
```bash
dotnet add .\tests\Teste.test\Teste.test.csproj package NSubstitute
dotnet add .\tests\Teste.test\Teste.test.csproj package FluentAssertions

# Creating a class
```bash
dotnet new class -n UserServiceTests -o .\tests\Teste.test\

# Generation of a report
```bash
dotnet test --collect:"XPlat Code Coverage"

# tools installed
```bash
dotnet tool list --global

# install tools to report test
```bash
dotnet tool install --global dotnet-reportgenerator-globaltool

# verify dashboards (go to coveragexml path and execute the command)
```bash
reportgenerator "-reports:coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html

# Build the project
```bash
dotnet build

# Build the test
```bash
dotnet test