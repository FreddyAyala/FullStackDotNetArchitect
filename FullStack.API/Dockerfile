#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["FullStack.API/FullStack.API.csproj", "FullStack.API/"]
COPY ["FullStack.Infrastructure.Data/FullStack.Infrastructure.Data.csproj", "FullStack.Infrastructure.Data/"]
COPY ["FullStack.Domain/FullStack.Domain.csproj", "FullStack.Domain/"]
COPY ["FullStack.Infrastructure.IoC/FullStack.Infrastructure.IoC.csproj", "FullStack.Infrastructure.IoC/"]
COPY ["FullStack.Application/FullStack.Application.csproj", "FullStack.Application/"]
RUN dotnet restore "FullStack.API/FullStack.API.csproj"
COPY . .
WORKDIR "/src/FullStack.API"
RUN dotnet build "FullStack.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FullStack.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FullStack.API.dll"]