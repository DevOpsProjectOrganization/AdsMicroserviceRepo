# Use the .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy the solution file and restore dependencies
COPY *.sln .
COPY AdsMicroService/*.csproj ./AdsMicroService/
RUN dotnet restore

# Copy the entire project and build
COPY . .
RUN dotnet publish -c Release -o out

# Use the .NET ASP.NET runtime image for the final image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
EXPOSE 30218
ENV ASPNETCORE_URLS=http://+:30218

# Copy the published output from the build environment
COPY --from=build-env /app/out .

# Specify the entry point for the container
ENTRYPOINT ["dotnet", "AdsMicroService.dll"]
