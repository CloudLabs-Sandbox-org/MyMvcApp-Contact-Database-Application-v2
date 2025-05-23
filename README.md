# MyMvcApp - Aplicación de Contactos

Esta es una aplicación ASP.NET Core MVC para gestionar una base de datos de contactos.

## Requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio, Visual Studio Code o cualquier editor compatible

## Instalación y ejecución

1. Clona este repositorio o descarga el código fuente.
2. Abre una terminal en la carpeta raíz del proyecto.
3. Restaura las dependencias ejecutando:

```powershell
dotnet restore
```

4. Ejecuta la aplicación con:

```powershell
dotnet run
```

5. Abre tu navegador y accede a `https://localhost:5001` o `http://localhost:5000`.

## Configuración

Puedes modificar la configuración de la base de datos y otros parámetros en los archivos:
- `appsettings.json`
- `appsettings.Development.json`

## Estructura del proyecto

- `Controllers/` - Controladores MVC
- `Models/` - Modelos de datos
- `Views/` - Vistas Razor
- `wwwroot/` - Archivos estáticos (CSS, JS, librerías)

## Notas

- Asegúrate de tener los puertos 5000 y 5001 libres.
- Si usas Visual Studio, también puedes presionar F5 para ejecutar la aplicación.

---

¡Listo! Ahora puedes comenzar a usar la aplicación.
