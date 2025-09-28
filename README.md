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
Accede la raíz de tu microservicio `(/catalogo, /index, /reseñas, /promociones)`.<br>
Crea un archivo `.env`, tomando como referencia `.env.example`.<br>
Cada microservicio usa una base de datos diferente.

## 🧪 Comandos esenciales de EF Core
- Crear migración	`dotnet ef migrations add <nombre-migracion>`
- Aplicar migraciones en la base de datos	`dotnet ef database update`
- Ver estado	`dotnet ef migrations list`
- Eliminar migración	`dotnet ef migrations remove`
