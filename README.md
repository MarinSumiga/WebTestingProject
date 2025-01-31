# WebTestingProject
This repository contains an automated web testing project for the page "eKupi". It was made as a project that is a part of the Methods and Techniques for Software Testing course.
## Description 
This project is a suite of automated web tests built using NUnit and Selenium WebDriver. It is designed to test various functionalities of a web application, ensuring that the user interface and critical workflows are working as expected.

## 🚀 **Project Overview**
The project includes tests for:
- Adding items to the basket
- Comparing items
- Logging in and out
- Navigating the page
- Saving the basket
- Attempting to complete the checkout process

## 🛠️ **Requirements**
To run this project, ensure you have the following installed:

### **Software Requirements**
- **Visual Studio IDE**
- **.NET 9.0 SDK** (or later)
- **Chrome Browser** (latest version recommended)

### **NuGet Dependencies**
The project uses the following NuGet packages:
- [DotNetSeleniumExtras.WaitHelpers](https://www.nuget.org/packages/DotNetSeleniumExtras.WaitHelpers) (Explicit waits for Selenium)
- [Microsoft.NET.Test.Sdk](https://www.nuget.org/packages/Microsoft.NET.Test.Sdk) (Test runner support)
- [NUnit](https://www.nuget.org/packages/NUnit) (Unit testing framework)
- [NUnit.Analyzers](https://www.nuget.org/packages/NUnit.Analyzers) (NUnit code analysis)
- [NUnit3TestAdapter](https://www.nuget.org/packages/NUnit3TestAdapter) (Test adapter for NUnit)
- [Selenium.Support](https://www.nuget.org/packages/Selenium.Support) (Selenium support library)
- [Selenium.WebDriver](https://www.nuget.org/packages/Selenium.WebDriver) (Core Selenium WebDriver library)
- [Selenium.WebDriver.ChromeDriver](https://www.nuget.org/packages/Selenium.WebDriver.ChromeDriver) (Chrome WebDriver)

## 📥 **Installation**
1. Clone the repository:
   ```sh
   git clone https://github.com/MarinSumiga/WebTestingProject.git
   cd WebTestingProject
2. Restore NuGet packages
   ```sh
   dotnet restore
3. Build the project
   ```sh
   dotnet build
   
## ▶️ **Run Tests**
To run all tests use paste the code below into the terminal.
```sh
dotnet test

