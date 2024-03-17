#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8000

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ControleFinanceiro.Api/ControleFinanceiro.Api.csproj", "ControleFinanceiro.Api/"]
COPY ["ControleFinanceiro.IoC/ControleFinanceiro.IoC.csproj", "ControleFinanceiro.IoC/"]
COPY ["ControleFinanceiro.Application/ControleFinanceiro.Application.csproj", "ControleFinanceiro.Application/"]
COPY ["ControleFinanceiro.Domain/ControleFinanceiro.Domain.csproj", "ControleFinanceiro.Domain/"]
COPY ["ControleFinanceiro.Data/ControleFinanceiro.Data.csproj", "ControleFinanceiro.Data/"]
RUN dotnet restore "./ControleFinanceiro.Api/ControleFinanceiro.Api.csproj"
COPY . .
WORKDIR "/src/ControleFinanceiro.Api"
RUN dotnet build "./ControleFinanceiro.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ControleFinanceiro.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ControleFinanceiro.Api.dll"]