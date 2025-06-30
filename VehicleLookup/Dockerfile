# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the entire repo including the solution and project files
COPY ../VehicleLookup.sln ../
COPY . ./

# Restore and build
RUN dotnet restore ../VehicleLookup.sln
RUN dotnet publish VehicleLookup.csproj -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "VehicleLookup.dll"]
