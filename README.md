# DVLD Enterprise System

A driving and vehicle licensing management system with a backend implementation built using ASP.NET Core Web API, Entity Framework Core, and SQL Server.

**Project Status:** Under Active Development

## Implemented Areas

- People management endpoints and application services.
- DTO-based request and response handling.
- Entity Framework Core persistence and migrations.
- JWT authentication and authorization.
- Input validation with FluentValidation.
- Object mapping with Mapster.
- Centralized exception handling.
- Structured logging with Serilog.
- In-memory caching.
- Local file storage services.

## Technology Stack

- C#
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- FluentValidation
- Mapster
- JWT
- Serilog
- xUnit

## Architecture

The backend follows a Clean Architecture structure:

- **Domain:** Business entities and core rules.
- **Application:** Use cases, services, DTOs, and validation.
- **Infrastructure:** Database persistence and external services.
- **API:** HTTP endpoints, authentication, and application configuration.

## Engineering Practices

- Unit and integration testing.
- GitHub Actions CI workflow.
- Docker-based application build.
