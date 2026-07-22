# Healthcare Appointment Management System

A production-grade Healthcare Appointment Management System built with ASP.NET Core, Clean Architecture, Entity Framework Core, SQL Server, and JWT Authentication.

## Tech Stack

### Backend

- .NET 8
- ASP.NET Core Web API
- Clean Architecture
- Entity Framework Core
- SQL Server
- JWT Authentication

### Testing

- xUnit

### Planned Frontend

- React
- TypeScript

### Planned Deployment

- Docker
- Azure

---

## Project Structure

```text
src/
├── Healthcare.API
├── Healthcare.Application
├── Healthcare.Domain
└── Healthcare.Infrastructure

tests/
└── Healthcare.Tests
```

---

## Completed

- Initial solution setup
- Clean Architecture project structure
- Project references
- Core domain model
  - BaseEntity
  - AuditableEntity
  - Patient entity
  - Doctor entity
  - Appointment entity
  - Gender enum
  - AppointmentStatus enum

---

## Next Steps

- Implement Application layer
- Configure Entity Framework Core
- Implement SQL Server persistence
- Build REST API endpoints
- Add JWT authentication
- Implement frontend with React and TypeScript
- Containerize with Docker
- Deploy to Azure