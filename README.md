# ApiService Clean Arquitecture

Solucion ejemplo de la inplementacion de un ApiService con estructura limpia (Clean Arquitecture), Version Funcoinal en Net Core 7.

# 1. Configuracion Inicial 

## Features

- Light/dark mode toggle
- Live previews
- Fullscreen mode
- Cross platform

##  Creacion de solucion principal.
- dotnet new solution

##  Creacion de las Capas 
- dotnet new webapi -o SchoolAdministrator.Web
- dotnet new classlib -o SchoolAdministrator.Core
- dotnet new classlib -o SchoolAdministrator.Services
- dotnet new classlib -o SchoolAdministrator.Infraestructure

## Incluyendo Librerias de Clase y WebApi a la solucion principal
- dotnet sln add SchoolAdministrator.Web/SchoolAdministrator.Web.csproj
- dotnet sln add SchoolAdministrator.Core/SchoolAdministrator.Core.csproj
- dotnet sln add SchoolAdministrator.Services/SchoolAdministrator.Services.csproj
- dotnet sln add SchoolAdministrator.Infraestructure/SchoolAdministrator.Infraestructure.csproj

## Agregando referencias
- dotnet add SchoolAdministrator.Web/SchoolAdministrator.Web.csproj reference SchoolAdministrator.Core/SchoolAdministrator.Core.csproj SchoolsAdministrator.Services/SchoolsAdministrator.Services.csproj
- dotnet add SchoolAdministrator.Infraestructure/SchoolAdministrator.Infraestructure.csproj reference SchoolAdministrator.Core/SchoolAdministrator.Core.csproj
- dotnet add SchoolAdministrator.Services/SchoolAdministrator.Services.csproj reference SchoolAdministrator.Core/SchoolAdministrator.Core.csproj
- dotnet add SchoolAdministrator.Web/SchoolAdministrator.Web.csproj reference SchoolAdministrator.Infraestructure/SchoolAdministrator.Infraestructure.csproj

## Compilando Solución
- dotnet build



# 2. Armado de la capa Infraestructure.

## Instalación de Entity Framework
dotnet tool install --global dotnet-ef --version 7.0.14
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 7.0.14
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.14


dotnet add SchoolAdministrator.Infraestructure/SchoolAdministrator.Infraestructure.csproj package Microsoft.EntityFrameworkCore 
dotnet add SchoolAdministrator.Infraestructure/SchoolAdministrator.Infraestructure.csproj package Microsoft.EntityFrameworkCore.Design 
dotnet add SchoolAdministrator.Infraestructure/SchoolAdministrator.Infraestructure.csproj package Microsoft.EntityFrameworkCore.SqlServer