# Greatest Common Divider

A small Windows app that finds the greatest common divisor of two whole numbers in three ways and shows how long each one took. Written in C# with WPF on .NET Framework 4.0; the interface is in Arabic.

## Features

- Type two whole numbers, each from 2 up to 9,223,372,036,854,775,807 (the largest 64-bit `long`), and pick a method:
  - **التقسيم عددا عددا** (trial division): counts down from the smaller number until it finds one that divides both.
  - **اقليدس التكرارية** (Euclid, iterative): the Euclidean algorithm as a loop.
  - **اقليدس العودية** (Euclid, recursive): the same algorithm as a recursive function.
- Shows the result and the time taken in milliseconds, so the methods can be compared.
- Trial division gets slow on very large numbers; the Euclid methods answer at once.

## Requirements

Windows with .NET Framework 4.0 or later. Windows 8, 10 and 11 already include it.

## Usage

Download `Greatest-Common-Divider-v1.0.0.7z` from [Releases](https://github.com/Mohammad-Diab/Greatest-Common-Divider/releases), extract it, and run `Greatest Common Divider.exe`. There is no installer.

The exe is not signed, so Windows SmartScreen may warn the first time you run it: click **More info**, then **Run anyway**.

## Building

```
git clone https://github.com/Mohammad-Diab/Greatest-Common-Divider.git
```

Open `GCD.sln` in Visual Studio and build, or run:

```
MSBuild GCD.sln /p:Configuration=Release
```

The exe is written to `GCD\bin\Release`.

The project targets .NET Framework 4.0. Recent Visual Studio versions don't ship its reference assemblies; if the build stops with `MSB3644`, extract the [Microsoft.NETFramework.ReferenceAssemblies.net40](https://www.nuget.org/packages/Microsoft.NETFramework.ReferenceAssemblies.net40) NuGet package and point MSBuild at its `build` folder:

```
MSBuild GCD.sln /p:Configuration=Release /p:TargetFrameworkRootPath=<package>\build
```

## Author

Mohammad Diab

## License

[Apache 2.0](LICENSE)
