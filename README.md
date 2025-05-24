# Sistema de Gestión de Personas - Blazor + Web API

Este proyecto fue desarrollado por **Aarón Eduardo Ávila Milanés** como parte de un ejercicio técnico solicitado por Central Informática.  
El sistema permite realizar un CRUD completo (Crear, Leer, Actualizar, Eliminar) sobre una entidad llamada `Persona`, utilizando una API REST con .NET Core y una interfaz desarrollada con Blazor Server.

---

## 🧰 Tecnologías Utilizadas

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server Express
- Blazor Server
- C#
- Bootstrap 5 (estilizado básico por defecto)

---

## ⚙️ Requisitos Previos

Asegúrate de tener instalado lo siguiente antes de correr el proyecto:

* [.NET SDK 7.0 o superior](https://dotnet.microsoft.com/en-us/download)
* [SQL Server Express LocalDB](https://learn.microsoft.com/es-mx/sql/database-engine/configure-windows/sql-server-express-localdb)
* [SQL Server Management Studio (SSMS)](https://aka.ms/ssmsfullsetup) (opcional pero útil para ver la base de datos)
* Visual Studio 2022 o Visual Studio Code

---

## 🚀 Instrucciones para ejecutar el proyecto

### 1. Clona o descarga el proyecto
Guarda todo el contenido en una carpeta local.

---

### 2. Ejecutar la Web API

Desde terminal o Visual Studio:

```bash
cd WebAPI_EduardoAvila
dotnet ef database update   # Aplica la migración y crea la base de datos
dotnet run
```

Esto inicia la API en http://localhost:5206 (puede variar, revisa el puerto mostrado en la terminal).

🔹 Puedes probar los endpoints directamente desde Swagger:
http://localhost:5206/swagger

---

### 3. Ejecutar la aplicación Blazor

Desde otra terminal:

```bash
cd BlazorApp_EduardoAvila
dotnet run
```
Esto levantará la interfaz gráfica en:
http://localhost:5101
Abre esa URL en tu navegador para comenzar a usar la aplicación.

---

### 4. Funcionalidades implementadas

- ✅ Mostrar lista de personas en tabla
- ✅ Agregar nueva persona con validaciones
- ✅ Editar y actualizar persona
- ✅ Eliminar persona
- ✅ Filtro por nombre, apellidos, sexo y rango de fechas
- ✅ Paginación de 5 registros por página
- ✅ Validación en cliente (Blazor) y servidor (DataAnnotations)
- ✅ Manejo de errores (red/API)
- ✅ Documentación con Swagger UI

---

### 5. Modelo de datos (SQL Server)

La entidad `Persona` se almacena en una base de datos SQL Server con la siguiente estructura:

```sql
CREATE TABLE Persona (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50),
    ApellidoPaterno NVARCHAR(50),
    ApellidoMaterno NVARCHAR(50),
    FechaNacimiento DATETIME,
    Sexo CHAR(1) -- F = Femenino, M = Masculino
);
```

---

### 6. Autor del proyecto

Este proyecto fue desarrollado por:

**Aarón Eduardo Ávila Milanés**  
Estudiante de Ingeniería en Sistemas Computacionales  
Tecnológico Nacional de México, campus Colima

📧 Contacto: avila.milanes.eduardo@gmail.com

🔗 [LinkedIn](https://www.linkedin.com/in/aaron-eduardo-avila-milanes-15179a201)  

💻 [GitHub](https://github.com/Edurey21?tab=repositories)"# Blazor_CRUD_EduardoAvila" 
