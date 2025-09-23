# microservices-dotnet

## 📦 Instalación de dependencias
```bash
dotnet restore
```

## Correr la aplicación
```bash
dotnet watch run
```

## Configuración de secretos en desarrollo
Accede la raíz de tu microservicio `(/catalogo, /filtro, /reseñas)`.
User Secrets ya se encuentra inicializado en el archivo `.csproj`, va a haber un `UserSecretsId`

En la terminal introduce el comando
```bash
dotnet user-secrets set "ConnectionStrings:Postgres" "Host=localhost;Port=5432;Database=example;Username=example;Password=example"
```
Completa los valores con tu base de datos, usuario y contraseña de Postgres. 

En tu archivo `Program.cs` vas a encontrar este fragmento de código:
```csharp
var connectionString = builder.Configuration.GetConnectionString("postgres");

builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseNpgsql(connectionString));
```
Aquí es donde se usan los User Secrets que ya has definido previamente, por lo que ya se debe poder trabajar con `EF core`.

## 🧪 Comandos esenciales de EF Core
- Crear migración	`dotnet ef migrations add <nombre-migracion>`
- Aplicar migraciones en la base de datos	`dotnet ef database update`
- Ver estado	`dotnet ef migrations list`
- Eliminar migración	`dotnet ef migrations remove`
