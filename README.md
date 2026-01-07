# Easy Edict API

Backend API for the Easy Edict Angular application.

## Quick Start

### Method 1: Visual Studio
1. Open `EasyEdictWebApi.sln` in Visual Studio
2. Right-click on Solution → "Restore NuGet Packages"
3. Build the solution (Ctrl+Shift+B)
4. Press F5 to run
5. API will be available at `http://localhost:5000`

### Method 2: Command Line
```bash
cd D:\Project\Easy-edict-API\EasyEdictWebApi
dotnet restore
dotnet build
```

## Testing

Navigate to `http://localhost:5000/api/test` to verify the API is running.

You should see:
```json
{
  "message": "Easy Edict API is running successfully!",
  "version": "1.0.0",
  "timestamp": "..."
}
```

## Troubleshooting

If you get build errors:
1. Make sure .NET Framework 4.6.1 or higher is installed
2. Restore NuGet packages
3. Clean and Rebuild solution

## Documentation

See [SETUP.md](SETUP.md) for detailed setup instructions.

