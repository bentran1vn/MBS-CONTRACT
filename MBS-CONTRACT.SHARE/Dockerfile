# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# Set the working directory
WORKDIR /app

# Copy the solution file and project files
COPY .dockerignore .
COPY MBS-CONTRACT.sln .
COPY MBS-CONTRACT.SHARE/MBS-CONTRACT.SHARE.csproj ./MBS-CONTRACT.SHARE/

# Restore dependencies
RUN dotnet restore

# Copy the rest of the project files
COPY MBS-CONTRACT.SHARE/ ./MBS-CONTRACT.SHARE/

# Build the project
RUN dotnet build MBS-CONTRACT.SHARE/MBS-CONTRACT.SHARE.csproj --configuration Release --no-restore

# Publish the project
RUN dotnet publish MBS-CONTRACT.SHARE/MBS-CONTRACT.SHARE.csproj -c Release -o out

# Pack the NuGet package (with no default excludes and no README required)
RUN dotnet pack MBS-CONTRACT.SHARE/MBS-CONTRACT.SHARE.csproj -c Release -o nupkg --no-restore -NoDefaultExcludes

# Final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
COPY --from=build-env /app/nupkg ./nupkg

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "MBS-CONTRACT.SHARE.dll"]
