# grupp3-tdd-Budget-Tracker

![GRUPP3](https://img.shields.io/badge/group-3-blue)
![TDD Budget Tracker](https://img.shields.io/badge/TDD-Budget%20Tracker-blue)
![License: MIT](https://img.shields.io/badge/License-MIT-green)
![.NET Build & Test](https://github.com/Campus-Molndal-CLO25/grupp3-tdd-Budget-Tracker/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/Campus-Molndal-CLO25/grupp3-tdd-Budget-Tracker/actions/workflows/dotnet-desktop.yml)

## Projektbeskrivning
BudgetTracker är en personlig budgetapplikation byggd i .NET med fokus på **TDD**, tydlig arkitektur och separation av ansvar.  
Projektet består av ett Core-lager, ett REST-API och ett MVC-baserat webbgränssnitt.

## Projektstruktur
- **BudgetTracker.Core** – Domänmodeller, DTO:er, repositories och services  
- **BudgetTracker.Api** – REST API for accounts, transactions, categories, budgets, reports, and dashboard. 
- **BudgetTracker.Web** – MVC-baserat webbgränssnitt  with account and Gemini advice experiences.
- **BudgetTracker.Tests** – Tester (TDD)

## Setup instruktioner

### Krav
- .NET 10 SDK
- SQLite

## Configuration

Set 1minAI configuration via environment variables (optional):

```bash
Linux
export ONEMINAI_API_KEY="your-key"
export ONEMINAI_MODEL="gpt-4o-mini"

Window 
$env:ONEMINAI_API_KEY="din-nyckel-här"
$env:ONEMINAI_MODEL="gpt-4o-mini"

```
`appsettings.json` contains the default SQLite connection string.


### Kör API
```bash
dotnet run --project BudgetTracker.Api
```

### Kör Web
```bash
dotnet run --project BudgetTracker.Web
```

## API Endpoints (översikt)

### Budgets
- POST `/api/budgets`
- GET `/api/budgets?month=YYYY-MM`
- PUT `/api/budgets/{id}`
- DELETE `/api/budgets/{id}`

### Transactions
- POST `/api/transactions`
- GET `/api/transactions`
- GET `/api/transactions/{id}`
- PUT `/api/transactions/{id}`
- DELETE `/api/transactions/{id}`

### Dashboard
- GET `/api/dashboard?year={year}&month={month}`

## Swagger / OpenAPI
Swagger och OpenAPI är aktiverat i **Development**.

- Swagger UI: `/swagger`
- OpenAPI JSON: `/swagger/v1/swagger.json`
- Scalar API Reference: `/scalar/v1`

## Databas
SQLite via Entity Framework Core.

Tabeller:
- Accounts (unika namn)
- Categories (unika namn)
- Transactions
- Budgets (unik per Category + Month)

## Tester
```bash
dotnet test BudgetTracker.Tests/BudgetTracker.Tests.csproj
```
## Coverage
Run coverage with the built-in coverlet collector:
```bash
dotnet test BudgetTracker.Tests/BudgetTracker.Tests.csproj --collect:"XPlat Code Coverage" --settings coverlet.runsettings
```

## Teammedlemmar
- **Rayan Care** – Core  
- **Stephan** – API  
- **Ahmed** – Web  

## License
MIT
