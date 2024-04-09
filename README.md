# lab-03-csharp-project

This program is only created for the example of creating a docker container. You don't need to compile it, but if you want...

## How to run it?

Download code, after that open terminal in the derictory "/MyProgram" and enter:

`dotnet restore`

After that you need to open MyProgram.csproj file and change one thing:

`<TargetFramework>netcoreapp3.1</TargetFramework>` -> `<TargetFramework>net8.0</TargetFramework>`

Now you can close it and run it with command:

`dotnet run MyProgram.csproj`

## What does it do?

Nothing usefull. It just showing some info in JSON format.