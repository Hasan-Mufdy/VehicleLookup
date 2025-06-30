# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy .csproj file
COPY VehicleLookup/*.csproj ./VehicleLookup/

# Restore dependencies
RUN dotnet restore VehicleLookup/VehicleLookup.csproj

# Copy all project files
COPY . .

# Publish the app
WORKDIR /src/VehicleLookup
RUN dotnet publish VehicleLookup.csproj -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "VehicleLookup.dll"]
