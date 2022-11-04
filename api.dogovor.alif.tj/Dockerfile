#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 7254
EXPOSE 5254

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["api.dogovor.alif.tj/api.dogovor.alif.tj.csproj", "api.dogovor.alif.tj/"]
COPY ["Service/Service.csproj", "Service/"]
COPY ["Repository/Repository.csproj", "Repository/"]
COPY ["ConnectionProvider/ConnectionProvider.csproj", "ConnectionProvider/"]
COPY ["Entity/Domain.csproj", "Entity/"]
RUN dotnet restore "api.dogovor.alif.tj/api.dogovor.alif.tj.csproj"
COPY . .
WORKDIR "/src/api.dogovor.alif.tj"
RUN dotnet build "api.dogovor.alif.tj.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "api.dogovor.alif.tj.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "api.dogovor.alif.tj.dll"]