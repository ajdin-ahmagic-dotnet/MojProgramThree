# MojProgramThree

MojProgramThree is an educational C# .NET project aimed at teaching and demonstrating fundamental programming concepts in C#. The project is structured as a Visual Studio solution and contains multiple libraries and a console application, with a focus on beginner-to-intermediate programming tasks, best practices, and hands-on exercises.

## Table of Contents

- [Project Structure](#project-structure)
- [Main Features](#main-features)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Libraries](#libraries)
- [Contributing](#contributing)
- [License](#license)

---

## Project Structure

The solution consists of several components:

```
MojProgramThree/
├── MojProgram_Three/
│   ├── MojProgram_Three/           # Main console application
│   ├── BibilotekaKoda/             # (Library, likely for code examples)
│   ├── VarijableClassLibrary/      # Library focused on variables and comments
│   └── ... (solution and config files)
├── LICENSE
├── README.md
```

## Main Features

- **Login System:** Demonstrates reading user credentials, masking passwords, and basic authentication with a SQL Server database.
- **Interactive Console Menus:** Rich text-based menus for navigating educational modules.
- **Fundamental C# Topics:** Includes code examples for variables, types, loops, arrays, if-else, switch, and more.
- **Commentary and Guidance:** Inline explanations, comments, and educational notes in code (in Bosnian/Croatian/Serbian).
- **Hands-On Exercises:** Students can run and adapt the code to reinforce learning.

## Getting Started

### Prerequisites

- Visual Studio 2019 or later (or compatible IDE)
- .NET Framework 4.5+
- Local SQL Server instance (for authentication demos)

### Building the Project

1. Clone the repository:
   ```sh
   git clone https://github.com/saulmagicinc/MojProgramThree.git
   ```
2. Open the solution file `MojProgram_Three.sln` in Visual Studio.
3. Restore NuGet packages if prompted.
4. Build the solution (`Build > Build Solution`).

### Running the Application

- Set `MojProgram_Three` as the startup project.
- Press `F5` or click `Start` to run the console application.
- Follow the on-screen menu prompts.

> **Note:** The login demo connects to a local database named `LoginDB` using integrated security. You may need to adjust or mock the connection string if you do not have SQL Server installed.

## Usage

The console will display structured menus such as:

- **Glavni Izbornik (Main Menu):** Selects between modules like C# fundamentals or OOP basics.
- **Submenus:** Drill down into topics such as variables, types, loops, arrays, comments, and more.
- **Examples:** Each menu option runs code examples or provides explanations.

## Libraries

### VarijableClassLibrary

Contains code and explanations about variables and comments in C#. For example:

- `Varijable01.cs` – Introduction to variables with explanations.
- `Komentari.cs` – Demonstrates the importance of code comments; outputs a description and lists students using LINQ.

### BibilotekaKoda

(Contents not fully explored here, but likely contains reusable code examples or helper methods for educational purposes.)

## Localization

Most code comments and textual output are in Bosnian/Croatian/Serbian, making it especially useful for native speakers learning C#.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the terms described in the [LICENSE](LICENSE) file.

---

**Author:** [saulmagicinc](https://github.com/saulmagicinc)

