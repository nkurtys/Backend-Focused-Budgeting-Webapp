# Backend-Focused-Budgeting-Webapp
C# Dotnet + react + Postgres(in docker)

# Folder Structure

```
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
    
```

# Project.Angular.Ui

This project was generated using [Angular CLI](https://github.com/angular/angular-cli) version 21.0.0.

## Development server

To start a local development server, run:

```bash
ng serve
```

Once the server is running, open your browser and navigate to `http://localhost:4200/`. The application will automatically reload whenever you modify any of the source files.

## Code scaffolding

To generate a new component, run:

```bash
ng generate component component-name
```

For a complete list of available schematics (such as `components`, `directives`, or `pipes`), run:

```bash
ng generate --help
```

## Building

To build the project run:

```bash
ng build
```

This will compile your project and store the build artifacts in the `dist/` directory. By default, the production build optimizes your application for performance and speed.

## Running unit tests

To execute unit tests with the [Karma](https://karma-runner.github.io) test runner, use the following command:

```bash
ng test
```

## Running end-to-end tests

For end-to-end (e2e) testing, run:

```bash
ng e2e
```

For this project I picked Playwright.

## Additional Resources

For more information on using the Angular CLI, including detailed command references, visit the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli) page.
