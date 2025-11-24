# Backend-Focused-Budgeting-Webapp
C# Dotnet + react + Postgres(in docker)

# Folder Structure
Project/
├── Project.UI/                    # React frontend
│   ├── public/
│   ├── src/
│   ├── package.json
│   └── ...
│
├── Project.Api/                   # .NET Backend solution folder
│   ├── Project.Api.Internal/              # Main API project (Web API)
│   │   ├── Controllers/
│   │   ├── Program.cs
│   │   ├── appsettings.json
│   │   └── Project.Api.csproj
│   │
│   ├── Project.Data/             # Data access library
│   │   ├── DbContext/
│   │   ├── Entities/
│   │   ├── Repositories/
│   │   └── Project.Data.csproj
│   │
│   ├── Project.Services/         # Business logic library. Shared services between projects (we will add more projects later on)
│   │   ├── Services/
│   │   ├── Interfaces/
│   │   └── Project.Services.csproj
│   │
│   ├── Project.Test/             # Test project
│   │   ├── UnitTests/
│   │   ├── IntegrationTests/
│   │   └── Project.Test.csproj
│   │
│   └── Project.sln               # Solution file
│
└── Project.Docker/
    └── docker-compose.yml