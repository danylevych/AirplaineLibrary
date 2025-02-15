# Lab Work #1: DLL C# library

## Overview
This project is a laboratory work for Cross-Platform Programming course. The goal of this project is to implement the dynamic link library (DLL) in C# language.

## Requirements
Download and install [.NET Core SDK](https://dotnet.microsoft.com/download) to build and run the project.

or use the following command to install the .NET Core SDK on Fedora:
```bash
sudo dnf install dotnet-sdk-8.0
```

Run the following command to check the .NET Core SDK version:
```bash
dotnet --version
```

## Building and Running

### Building
Run the following command to build the library:
```bash
cd AirplaneLibrary
dotnet build
```

### Running
Run the following command to run the library:
```bash
cd AirplaneConsoleProject
dotnet add reference ../AirplaneLibrary/AirplaneLibrary.csproj
dotnet run
```

## Features
- The library contains the `Airplane` class that represents an airplane.
- The library contains the `CargoAirplane` class that represent a cargo ariplane.
- The library contains the `PassengerAirplane` class that represent a passenger ariplane.

## Author
- Danylevych Oleh
- Student of TNTU
- Group СН-41

## License
This project is created for educational purposes.
