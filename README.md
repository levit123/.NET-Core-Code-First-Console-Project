# .NET Core Code First Console App
.NET Core app that uses Code First to generate an SQL database and initialize it with three objects of a `Student` class.

## Running The Project

Open the .sln file in Visual Studio 2019 or higher (if you get a message saying certain components are missing from your Visual Studio installation, use the Visual Studio Installer to install those components) and execute the program. You may need to click `Build`->`Clean Solution` and then `Build`->`Rebuild Solution`. The program will generate a fresh SQL database with the `Student` info on your machine. You can verify the contents of the database by clicking `View`->`SQL Server Object Explorer`, opening up the database, right-clicking the `Students` table and clicking `View Data`.
