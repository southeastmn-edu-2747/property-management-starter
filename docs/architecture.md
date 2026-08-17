# Starter Architecture

The starter repository intentionally uses a simple architecture so students can understand the request flow before adding persistence infrastructure.

```text
Swagger / HTTP Client
        |
        v
ASP.NET Core Minimal API
        |
        v
IPropertyService
        |
        v
InMemoryPropertyService
        |
        v
Temporary sample data
```

During COMC 2747 the application evolves toward:

```text
Swagger / HTTP Client
        |
        v
ASP.NET Core Minimal API
        |
        v
Application services / DTOs
        |
        v
Entity Framework Core
        |
        v
Relational Database
```

## Why persistence is missing

The absence of a completed EF Core persistence layer is intentional. Students build that layer during the course rather than receiving the final architecture on the first day.
