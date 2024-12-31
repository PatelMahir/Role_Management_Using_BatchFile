# Role_Management_Using_BatchFile
The Implementation of .Net Core web API using an batch file which is runned in command prompt and automatically runs that file by using that file path.



## Features
- Clean Architecture
- Entity Framework Core
- JWT Authentication
- Swagger Documentation
- Global Error Handling
- Automated Testing
- Docker Support
- Logging with Serilog
- Health Checks
- Response Caching
- Rate Limiting
- API Versioning

## Prerequisites
- .NET 8.0 SDK
- SQL Server (or PostgreSQL)
- Docker (optional)

## Getting Started
1. Clone the repository
2. Run the database migrations
3. Start the API using the provided scripts
4. Access Swagger UI at http://localhost:5000/swagger

## Installation
bash
git clone https://github.com/yourusername/dotnet-api-boilerplate.git
cd dotnet-api-boilerplate
dotnet restore
dotnet build
dotnet run --project src/API/API.csproj
