# Easy Edict Web API

ASP.NET Web API project for Easy Edict Angular application.

## Overview

This is a simple Web API project that provides mock data for the Easy Edict Angular frontend application.

## Endpoints

### Base URL
`http://localhost:5000`

### Available Endpoints

#### 1. Test Endpoint
- **URL:** `/api/test`
- **Method:** `GET`
- **Description:** Test endpoint to verify API is running
- **Response:**
```json
{
  "message": "Easy Edict API is running successfully!",
  "version": "1.0.0",
  "timestamp": "2026-01-07T12:00:00Z"
}
```

#### 2. Get All Entities
- **URL:** `/api/entities`
- **Method:** `GET`
- **Description:** Returns a list of mock entities
- **Response:**
```json
{
  "success": true,
  "count": 5,
  "data": [
    {
      "id": 1,
      "name": "Entity One",
      "description": "...",
      "type": "Type A",
      "status": "Active",
      "createdDate": "2025-12-08T...",
      "updatedDate": "2026-01-02T...",
      "tags": ["important", "featured"],
      "metadata": {...}
    }
  ],
  "timestamp": "2026-01-07T12:00:00Z"
}
```

#### 3. Get Entity by ID
- **URL:** `/api/entities/{id}`
- **Method:** `GET`
- **Description:** Returns a single entity by ID
- **Parameters:**
  - `id` (integer): Entity ID
- **Response:**
```json
{
  "success": true,
  "data": {
    "id": 1,
    "name": "Entity 1",
    "description": "...",
    ...
  },
  "timestamp": "2026-01-07T12:00:00Z"
}
```

## Setup

### Prerequisites
- Visual Studio 2017 or later
- .NET Framework 4.6.1 or later
- IIS Express

### Installation

1. Open the solution in Visual Studio:
   ```
   EasyEdictWebApi.csproj
   ```

2. Restore NuGet packages:
   - Right-click on the solution
   - Select "Restore NuGet Packages"

3. Build the project:
   - Press `Ctrl+Shift+B` or
   - Build > Build Solution

4. Run the project:
   - Press `F5` or
   - Debug > Start Debugging
   - The API will start at `http://localhost:5000`

## CORS Configuration

The API is configured to accept requests from:
- `http://localhost:4200` (Angular development server)

To add more origins, modify the CORS settings in `Startup.cs`.

## Technology Stack

- ASP.NET Web API 2
- .NET Framework 4.6.1
- OWIN/Katana
- Newtonsoft.Json
- Microsoft.Owin.Cors

## Project Structure

```
EasyEdictWebApi/
├── App_Start/
│   └── WebApiConfig.cs
├── Controllers/
│   └── EntitiesController.cs
├── Models/
│   └── EntityModel.cs
├── Properties/
│   └── AssemblyInfo.cs
├── Global.asax
├── Global.asax.cs
├── Startup.cs
├── Web.config
└── packages.config
```

## Development

### Adding New Endpoints

1. Create a new controller in the `Controllers` folder
2. Add route attributes: `[RoutePrefix("api")]` and `[Route("your-endpoint")]`
3. Enable CORS: `[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]`

### Testing

You can test the API using:
- Browser: Navigate to `http://localhost:5000/api/test`
- Postman: Create GET requests to the endpoints
- curl: `curl http://localhost:5000/api/entities`

## Notes

- This is a development API with mock data
- CORS is enabled for development purposes
- Default port is 5000 (configured in .csproj)

