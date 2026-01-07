# Easy Edict API - Setup Guide

## Быстрый старт

### Шаг 1: Открыть проект в Visual Studio

1. Откройте `EasyEdictWebApi.sln` в Visual Studio 2017 или новее
2. Если Visual Studio предложит установить недостающие компоненты - согласитесь

### Шаг 2: Восстановить NuGet пакеты

1. В Visual Studio нажмите правой кнопкой на Solution
2. Выберите "Restore NuGet Packages"
3. Дождитесь завершения установки пакетов

### Шаг 3: Собрать проект

1. Нажмите `Ctrl+Shift+B` или выберите `Build > Build Solution`
2. Убедитесь, что сборка прошла успешно

### Шаг 4: Запустить API

1. Нажмите `F5` или выберите `Debug > Start Debugging`
2. API запустится на `http://localhost:5000`
3. Автоматически откроется браузер

### Шаг 5: Проверить работу API

Откройте в браузере или используйте Postman:

```
http://localhost:5000/api/test
```

Вы должны увидеть:
```json
{
  "message": "Easy Edict API is running successfully!",
  "version": "1.0.0",
  "timestamp": "2026-01-07T..."
}
```

## Доступные эндпоинты

### 1. Test Endpoint
```
GET http://localhost:5000/api/test
```

### 2. Get All Entities
```
GET http://localhost:5000/api/entities
```

### 3. Get Entity by ID
```
GET http://localhost:5000/api/entities/1
```

## Запуск Angular приложения

После запуска API, запустите Angular приложение:

```bash
cd D:\Project\EasyEdictAngular
npm start
```

Angular приложение откроется на `http://localhost:4200`

## Проверка интеграции

1. Откройте `http://localhost:4200` в браузере
2. Нажмите кнопку "Go to Details Page"
3. Вы должны увидеть данные, загруженные из API

## Решение проблем

### Порт 5000 занят

Если порт 5000 занят, измените его в:
- `EasyEdictWebApi.csproj` (строка с `<DevelopmentServerPort>`)
- `src/app/services/entities.service.ts` (переменная `apiUrl`)

### Ошибка CORS

Убедитесь, что Angular приложение запущено на `http://localhost:4200`

Если используете другой порт, обновите CORS настройки в:
- `Web.config` (в секции `<customHeaders>`)
- `Global.asax.cs` (в методе `Application_BeginRequest`)

### Ошибки компиляции

1. Убедитесь, что установлен .NET Framework 4.6.1 или новее
2. Попробуйте очистить и пересобрать решение:
   - `Build > Clean Solution`
   - `Build > Rebuild Solution`

## Структура проекта

```
Easy-edict-API/
├── EasyEdictWebApi/
│   ├── App_Start/
│   │   └── WebApiConfig.cs
│   ├── Controllers/
│   │   └── EntitiesController.cs
│   ├── Models/
│   │   └── EntityModel.cs
│   ├── Properties/
│   │   └── AssemblyInfo.cs
│   ├── Global.asax
│   ├── Global.asax.cs
│   ├── Startup.cs
│   ├── Web.config
│   └── packages.config
├── EasyEdictWebApi.sln
└── README.md
```

## Технологии

- ASP.NET Web API 2
- .NET Framework 4.6.1
- OWIN/Katana
- Microsoft.Owin.Cors
- Newtonsoft.Json

## Дополнительная информация

- Все данные в API - моканые (захардкоженные)
- API поддерживает CORS для `http://localhost:4200`
- Все эндпоинты возвращают JSON

