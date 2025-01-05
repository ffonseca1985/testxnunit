# doc commands
dotnet --help

# list dotnet versions
dotnet --list-runtimes

# verify templates
dotnte new --list

# Creating a class webapi
dotnet new webapi -n Teste.WebApi --framework net6.0

# Creating a class library
dotnet new classlib -n Teste.Bussiness --framework net6.0
dotnet new classlib -n Teste.Repository --framework net6.0
dotnet new classlib -n Teste.Entity --framework net6.0

# Moving to folder src
mkdir src
move Test.* src

# Creating a test project
dotnet new xunit -n Teste.test --framework net6.0

# Moving to folder tests
mkdir tests
move Test.* tests

# Creating a solution
dotnet new sln -n Teste

# Add project(s) to solution
dotnet sln Test.sln add ./src/Teste.Bussiness/Teste.Bussiness.csproj 
dotnet sln Teste.sln add ./src/Teste.WebApi/Teste.WebApi.csproj
dotnet sln Teste.sln add .\tests\Teste.test\Teste.test.csproj
dotnet sln Teste.sln add .\src\Teste.Entity\Teste.Entity.csproj
dotnet sln Teste.sln add .\src\Teste.Repository\Teste.Repository.csproj

# Add refetence (src folder)
dotnet add .\src\Teste.WebApi\Teste.WebApi.csproj reference .\src\Teste.Bussiness\Teste.Bussiness.csproj
dotnet add .\src\Teste.Bussiness\Teste.Bussiness.csproj reference .\src\Teste.Repository\Teste.Repository.csproj
dotnet add .\src\Teste.Bussiness\Teste.Bussiness.csproj reference .\src\Teste.Entity\Teste.Entity.csproj    
dotnet add .\src\Teste.Repository\Teste.Repository.csproj reference .\src\Teste.Entity\Teste.Entity.csproj  

# Add reference to test
dotnet add .\tests\Teste.test\Teste.test.csproj reference .\src\Teste.Bussiness\Teste.Bussiness.csproj
dotnet add .\tests\Teste.test\Teste.test.csproj reference .\src\Teste.WebApi\Teste.WebApi.csproj
dotnet add .\tests\Teste.test\Teste.test.csproj reference .\src\Teste.Repository\Teste.Repository.csproj
dotnet add .\tests\Teste.test\Teste.test.csproj reference .\src\Teste.Entity\Teste.Entity.csproj 

# Add Packages to test
dotnet add .\tests\Teste.test\Teste.test.csproj package NSubstitute
dotnet add .\tests\Teste.test\Teste.test.csproj package FluentAssertions

# Creating a class
dotnet new class -n UserServiceTests -o .\tests\Teste.test\

# Build the project
dotnet build

# Build the test
dotnet test