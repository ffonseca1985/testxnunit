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

# Move to folder src
mkdir src
move Test.* src

# Creating a test project
dotnet new xunit -n Teste.test --framework net6.0

# Move to folder tests
mkdir tests
move Test.* tests

# Creating a solution
dotnet new sln -n Teste

# Add project to solution
dotnet sln Test.sln add ./src/Teste.Bussiness/Teste.Bussiness.csproj 
dotnet sln Teste.sln add ./src/Teste.WebApi/Teste.WebApi.csproj
dotnet sln Teste.sln add .\tests\Teste.test\Teste.test.csproj

# Add refetence to WebApi
dotnet add .\src\Teste.WebApi\Teste.WebApi.csproj reference .\src\Teste.Bussiness\Teste.Bussiness.csproj

# Add reference to test
dotnet add .\tests\Teste.test\Teste.test.csproj reference .\src\Teste.Bussiness\Teste.Bussiness.csproj
dotnet add .\tests\Teste.test\Teste.test.csproj reference .\src\Teste.WebApi\Teste.WebApi.csproj

# Add Packages to test
dotnet add .\tests\Teste.test\Teste.test.csproj package NSubstitute
dotnet add .\tests\Teste.test\Teste.test.csproj package FluentAssertions

# Build the project
dotnet build

# Build the test
dotnet test