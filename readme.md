To reproduce:

1. Install latest .NET Core SDK (to cover .NET Core 2.0)
2. `git clone` this repo
3. Edit `Program.cs`, line 17: to set connection string as appropriate
4. `dotnet restore` to restore packages
5. `dotnet build` to build app
6. `dotnet run` to run & cause exception (will be output to console)