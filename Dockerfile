FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY . .
WORKDIR /app/api.dogovor.alif.tj

EXPOSE 7254
EXPOSE 5254

RUN dotnet dev-certs https

CMD ["dotnet", "run", "--launch-profile", "Docker"]