# Digital Menu And POS System

## Apply Database Migrations

Run the following commands from the **solution root directory**.

**Add a migration** (only if no migrations exist):

```powershell
dotnet ef migrations add Mig_1 --project .\Infrastructure\Infrastructure.csproj --startup-project .\API\API.csproj
```

**Update the database:**

```powershell
dotnet ef database update --project .\Infrastructure\Infrastructure.csproj --startup-project .\API\API.csproj
```
