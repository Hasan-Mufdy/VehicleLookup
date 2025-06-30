# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
# Copy sln and project files
COPY VehicleLookup.sln ./
COPY VehicleLookup/VehicleLookup.csproj VehicleLookup/

# Restore
RUN dotnet restore VehicleLookup.sln

# Copy the rest of the source code
COPY VehicleLookup/ VehicleLookup/

# Publish
RUN dotnet publish VehicleLookup/VehicleLookup.csproj -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
#
ENTRYPOINT ["dotnet", "VehicleLookup.dll"]
