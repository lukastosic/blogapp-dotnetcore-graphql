FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/BlogApp/BlogApp.csproj", "BlogApp/"]
RUN dotnet restore "BlogApp/BlogApp.csproj"
COPY . .
WORKDIR "/src/BlogApp"
RUN dotnet build "BlogApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BlogApp.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BlogApp.dll"]