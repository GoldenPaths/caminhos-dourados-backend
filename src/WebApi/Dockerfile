#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ARG ConnectionStrings__DefaultConnection

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/WebApi/GoldenPaths.WebApi.csproj", "src/WebApi/"]
COPY ["src/CrossCutting/GoldenPaths.CrossCutting.csproj", "src/CrossCutting/"]
COPY ["src/ApplicationCore/GoldenPaths.ApplicationCore.csproj", "src/ApplicationCore/"]
COPY ["src/Domain/GoldenPaths.Domain.csproj", "src/Domain/"]
COPY ["src/Infraestructure/GoldenPaths.Infraestructure.csproj", "src/Infraestructure/"]
RUN dotnet restore "src/WebApi/GoldenPaths.WebApi.csproj"
COPY . .
WORKDIR "/src/src/WebApi"
RUN dotnet build "GoldenPaths.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GoldenPaths.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GoldenPaths.WebApi.dll"]