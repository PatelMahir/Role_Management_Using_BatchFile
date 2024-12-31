@echo off
setlocal enabledelayedexpansion

:: Set environment variables
set ASPNETCORE_ENVIRONMENT=Development
set PORT=5000
set DB_CONNECTION="Server=localhost;Database=ApiDb;Trusted_Connection=True;MultipleActiveResultSets=true"

:: Project directory
set PROJECT_DIR=%~dp0
cd /d "%PROJECT_DIR%..\"

:: Clean and build
echo Cleaning and building solution...
dotnet clean
dotnet restore
dotnet build --configuration Release --no-restore

:: Run database migrations
echo Running database migrations...
dotnet ef database update --project src/Infrastructure --startup-project src/API

:: Run tests
echo Running tests...
dotnet test

:: Start API
echo Starting Web API...
dotnet run --project src/API/API.csproj --urls="http://localhost:%PORT%"

endlocal
