# VehiculosApp 🚗💨

**VehiculosApp** is a modern solution developed with **.NET MAUI** designed for efficient vehicle fleet management and control. It allows users to manage catalogs, register maintenance tasks, report faults, and view service histories through a clean, optimized user interface.

---

## ✨ Key Features

-   **Main Dashboard:** Quick access to all sections via an intuitive mosaic-style layout.
-   **Inventory Management:** Detailed fleet visualization with search functionality by license plate or model.
-   **Maintenance Logging:** Structured forms to capture costs, mileage, and service types.
-   **Service History:** A visual Timeline to review past interventions and repairs.
-   **Issue Reporting:** Alert system for vehicles with critical or preventive faults.
-   **Dynamic Catalogs:** Administration of vehicle types, services, and statuses.

---

## 🛠️ Tech Stack

-   **Framework:** [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/)
-   **Language:** C# / XAML
-   **Design Pattern:** MVVM (Model-View-ViewModel)
-   **UI/UX:** Modern Card-based design, soft shadows, and clear visual hierarchy.

---

## 📸 Application Views

| Dashboard | Vehicle List | Maintenance Entry |
| :---: | :---: | :---: |
| Mosaic control panel | Card-based list with search | Optimized form with depth |

*(Note: You can add screenshots to a `/Screenshots` folder and link them here)*

---

## 🚀 Installation and Setup

### Prerequisites
* Visual Studio 2022 (with the .NET MAUI workload installed).
* .NET 7.0 SDK or higher.

### Steps to Run
1.  Clone this repository:
    ```bash
    git clone [https://github.com/Broc0liii/VehiculosApp.git](https://github.com/Broc0liii/VehiculosApp.git)
    ```
2.  Open the `VehiculosMaui.sln` file in Visual Studio.
3.  Restore NuGet packages.
4.  Select your target emulator (Android/iOS) or Windows Machine and press **F5**.

---

## 📁 Project Structure

```text
VehiculosMaui/
├── Views/                  # XAML Files (User Interface)
│   ├── InicioPage.xaml
│   ├── ListaVehiculosPage.xaml
│   ├── DetalleVehiculoPage.xaml
│   ├── RegistrarMantenimientoPage.xaml
│   └── ...
├── ViewModels/             # View logic and Data Binding
├── Models/                 # Data entities (Vehicle, Service, etc.)
└── Resources/              # Styles, Fonts, and Images
