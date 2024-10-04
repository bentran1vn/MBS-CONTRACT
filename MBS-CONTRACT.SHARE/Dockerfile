# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# Set the working directory
WORKDIR /app

# Copy the project file and restore dependencies
COPY *.sln .
COPY MBS-CONTRACT.SHARE/*.csproj ./MBS-CONTRACT.SHARE/
RUN dotnet restore

# Copy the rest of the files
COPY . ./

# Build the project
RUN dotnet build --configuration Release --no-restore

# Run tests (if you have any)
# RUN dotnet test --no-build --verbosity normal

# Publish the project
RUN dotnet publish MBS-CONTRACT.SHARE/MBS-CONTRACT.SHARE.csproj -c Release -o out

# Pack the NuGet package
RUN dotnet pack MBS-CONTRACT.SHARE/MBS-CONTRACT.SHARE.csproj -c Release -o nupkg

# Final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
COPY --from=build-env /app/nupkg ./nupkg
ENTRYPOINT ["dotnet", "MBS-CONTRACT.SHARE.dll"]