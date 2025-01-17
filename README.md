# Clean Architecture WebAPI Worker

This repository contains a solution implementing **Clean Architecture** principles combined with **Domain-Driven Design (DDD)** using .NET and Vue.js. The project is designed to demonstrate best practices for building scalable and maintainable applications.

## Project Structure

The solution is divided into multiple layers, each with a clear responsibility:

```
src/
├── Core/             # Domain layer containing entities, interfaces, and domain logic
├── Infrastructure/   # Implementation layer for data access and external services
├── WebAPI/           # ASP.NET Core Web API for exposing endpoints
├── WorkerService/    # Background services using Hangfire for job scheduling
├── Shared/           # Shared utilities and components used across layers
└── Frontend/         # Vue.js frontend for UI interactions
```

## Features

- **Clean Architecture**: Ensures separation of concerns and maintains a clear dependency flow.
- **DDD Principles**: Implements domain models and aggregates for business logic.
- **Entity Framework Core**: Simplifies data access with Repository Pattern.
- **Hangfire Integration**: Schedules and manages recurring jobs within the WorkerService.
- **Vue.js Frontend**: Provides a responsive and filterable grid for data visualization.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (latest version)
- [Node.js](https://nodejs.org/) (for Vue.js)
- [SQL Server](https://www.microsoft.com/sql-server/) (for data storage)
- [Git](https://git-scm.com/)

### Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/Wollacy/clean-architecture-webapi-worker.git
   cd clean-architecture-webapi-worker
   ```

2. Build the solution:
   ```bash
   dotnet build
   ```

3. Navigate to the `Frontend` directory and install dependencies:
   ```bash
   cd src/Frontend
   npm install
   ```

4. Set up the database connection in the `appsettings.json` file located in the `WebAPI` and `WorkerService` projects.

5. Run migrations to initialize the database:
   ```bash
   dotnet ef database update --project src/Infrastructure
   ```

### Running the Application

1. Start the Web API:
   ```bash
   cd src/WebAPI
   dotnet run
   ```

2. Start the Worker Service:
   ```bash
   cd src/WorkerService
   dotnet run
   ```

3. Start the frontend:
   ```bash
   cd src/Frontend
   npm run serve
   ```

4. Access the frontend at `http://localhost:8080`.

## Job Scheduling with Hangfire

The WorkerService uses Hangfire to manage recurring jobs. Jobs are executed hourly and utilize APIs from [Public API Lists](https://github.com/public-api-lists/public-api-lists) for data insertion.

To monitor Hangfire jobs, visit the Hangfire Dashboard at `http://localhost:5000/hangfire` (or the configured port).

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature/fix.
3. Commit your changes.
4. Open a pull request.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.

---

Feel free to reach out with any questions or suggestions! Happy coding! 🚀
