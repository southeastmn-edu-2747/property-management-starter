# COMC 2747 Property Management Starter

This repository is the starting application for **COMC 2747 – Database Application Development**. It is intentionally functional but incomplete.

The starter application uses an ASP.NET Core Minimal API and temporary in-memory sample data. During the semester, students will replace the temporary persistence approach with Entity Framework Core and a relational database, add application features and tests, automate testing, and deploy the completed database-backed application.

## Technology

- .NET 10 / C#
- ASP.NET Core Minimal APIs
- Swagger / OpenAPI via Swashbuckle
- xUnit starter test project
- Entity Framework Core: **not yet included by design**

## Repository structure

```text
PropertyManagement.Api/      ASP.NET Core API and Swagger interface
PropertyManagement.Core/     Domain models and starter service abstraction
PropertyManagement.Tests/    Small starter test project
docs/                        Architecture and course roadmap
```

## Prerequisites

Install the .NET 10 SDK and an IDE/editor such as Visual Studio or Visual Studio Code with the C# Dev Kit.

## Run the starter application

From the repository root:

```bash
dotnet restore
dotnet run --project PropertyManagement.Api
```

The development profile opens Swagger automatically. If it does not, browse to the URL shown in the terminal and append `/swagger`.

Example endpoints:

- `GET /api/properties`
- `GET /api/properties/{id}`
- `GET /api/units`
- `GET /api/tenants`

## Run the starter tests

```bash
dotnet test
```

The starter tests are deliberately small. A more meaningful unit and integration test suite is developed later in the course.

## Week 1 exploration

Before changing the application, students should be able to explain the request path:

```text
Swagger -> HTTP endpoint -> IPropertyService -> InMemoryPropertyService -> sample data -> JSON response
```

Explore the solution and locate:

1. The API endpoints in `PropertyManagement.Api/Program.cs`.
2. The domain models in `PropertyManagement.Core/Models`.
3. The service abstraction and temporary implementation in `PropertyManagement.Core/Services`.
4. The starter tests in `PropertyManagement.Tests`.
5. The architecture notes under `docs/`.

## Intentionally missing

The following are intentionally **not** implemented in the starter repository:

- Entity Framework Core
- `DbContext`
- relational database configuration
- entity relationship mappings/navigation properties
- migrations
- CRUD persistence
- application service/DTO architecture
- payments
- transactions
- database integration tests
- GitHub Actions workflow
- Docker/Compose configuration
- Azure configuration or deployment

These are added progressively during COMC 2747.
