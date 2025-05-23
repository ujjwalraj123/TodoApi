# Use the official ASP.NET Core runtime as base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy and restore dependencies
COPY ["TodoApi.csproj", "./"]
RUN dotnet restore "TodoApi.csproj"

# Copy the rest of the source code and build
COPY . .
RUN dotnet publish "TodoApi.csproj" -c Release -o /app/publish

# Final stage/image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "TodoApi.dll"]
