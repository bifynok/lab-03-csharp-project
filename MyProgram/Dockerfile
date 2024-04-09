FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

COPY MyProgram.csproj MyProgram.csproj
RUN dotnet restore

COPY Program.cs Program.cs

RUN dotnet build -c Release

FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS runtime
WORKDIR /app
COPY --from=build /app/bin/Release/netcoreapp3.1 ./

ENTRYPOINT ["dotnet", "MyProgram.dll"]