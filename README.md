# VehiculosApp 🚗💨

**VehiculosApp** es una solución moderna desarrollada con **.NET MAUI** diseñada para el control y gestión eficiente de flotas vehiculares. Permite administrar catálogos, registrar mantenimientos, reportar fallas y visualizar historiales de servicio con una interfaz de usuario optimizada y limpia.

---

## ✨ Características Principales

-   **Panel Principal (Dashboard):** Acceso rápido a todas las secciones mediante un diseño de mosaico intuitivo.
-   **Gestión de Inventario:** Visualización detallada de la flota con búsqueda por placas o modelo.
-   **Registro de Mantenimientos:** Formulario estructurado para capturar costos, kilometraje y tipos de servicio.
-   **Historial de Servicios:** Línea de tiempo (Timeline) para revisar intervenciones pasadas.
-   **Reporte de Incidencias:** Sistema de alertas para vehículos con fallas críticas o preventivas.
-   **Catálogos Dinámicos:** Administración de tipos de vehículos, servicios y estados.

---

## 🛠️ Tecnologías Utilizadas

-   **Framework:** [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/)
-   **Lenguaje:** C# / XAML
-   **Patrón de Diseño:** MVVM (Model-View-ViewModel)
-   **Estilos:** Diseño basado en Cards, sombras suaves y jerarquía visual moderna.

---

## 📸 Vistas de la Aplicación

| Inicio | Lista de Vehículos | Registro de Mantenimiento |
| :---: | :---: | :---: |
| Panel de control tipo mosaico | Listado con tarjetas y búsqueda | Formulario optimizado con sombras |

*(Nota: Puedes añadir capturas de pantalla en una carpeta `/Screenshots` y enlazarlas aquí)*

---

## 🚀 Instalación y Uso

### Requisitos Previos
* Visual Studio 2022 (con la carga de trabajo de .NET MAUI instalada).
* SDK de .NET 7.0 o superior.

### Pasos para ejecutar
1.  Clona este repositorio:
    ```bash
    git clone [https://github.com/Broc0liii/VehiculosApp.git](https://github.com/Broc0liii/VehiculosApp.git)
    ```
2.  Abre el archivo `VehiculosMaui.sln` en Visual Studio.
3.  Restaura los paquetes NuGet.
4.  Selecciona el emulador (Android/iOS) o Windows Machine y presiona **F5**.

---

## 📁 Estructura del Proyecto

```text
VehiculosMaui/
├── Views/                  # Archivos XAML (Interfaz de usuario)
│   ├── InicioPage.xaml
│   ├── ListaVehiculosPage.xaml
│   ├── DetalleVehiculoPage.xaml
│   ├── RegistrarMantenimientoPage.xaml
│   └── ...
├── ViewModels/             # Lógica de las vistas
├── Models/                 # Entidades de datos (Vehículo, Servicio, etc.)
└── Resources/              # Estilos, Fuentes e Imágenes
