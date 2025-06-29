# VehicleLookup

This is a simple ASP.NET Core MVC web application that allows users to:
- Select a car make (brand)
- Enter a manufacturing year
- View the available vehicle types and models

The project uses the following APIs:

- **Get All Makes:**  
  [https://vpic.nhtsa.dot.gov/api/vehicles/getallmakes?format=json](https://vpic.nhtsa.dot.gov/api/vehicles/getallmakes?format=json)
- **Get Vehicle Types for Make by ID:**  
  [https://vpic.nhtsa.dot.gov/api/vehicles/GetVehicleTypesForMakeId/448?format=json](https://vpic.nhtsa.dot.gov/api/vehicles/GetVehicleTypesForMakeId/448?format=json)
- **Get Models by Make ID and Year:**  
  [https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeIdYear/makeId/474/modelyear/2016?format=json](https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeIdYear/makeId/474/modelyear/2016?format=json)

---

## Run the Application Locally

1. **Clone the repository**:

    ```
    git clone https://github.com/Hasan-Mufdy/VehicleLookup.git
    ```

2. **Open the solution in Visual Studio**

3. **Set `VehicleLookup` as the startup project**

4. **Run the application** (F5 or press ??)

## Run the Application using docker container

- build docker container:
```
docker build -t vehiclelookup .
```
- run docker container:
```
docker run -p 5000:80 vehiclelookup
```
---

## Requirements

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

---



