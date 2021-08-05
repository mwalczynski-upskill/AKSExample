#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["AKSExample.Client/AKSExample.Client.csproj", "AKSExample.Client/"]
RUN dotnet restore "AKSExample.Client/AKSExample.Client.csproj"
COPY . .
WORKDIR "/src/AKSExample.Client"
RUN dotnet build "AKSExample.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AKSExample.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AKSExample.Client.dll"]
