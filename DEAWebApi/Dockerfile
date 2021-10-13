#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#WORKDIR /src
#COPY ["DEAWebApi/DEAWebApi.csproj", "DEAWebApi/"]
#RUN dotnet restore "DEAWebApi/DEAWebApi.csproj"
#COPY . .
#WORKDIR "/src/DEAWebApi"
#RUN dotnet build "DEAWebApi.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "DEAWebApi.csproj" -c Release -o /app/publish
#
#FROM base AS final
##WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "DEAWebApi.dll"]

# Get the base image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app
EXPOSE 80
EXPOSE 443
# Copy the csproj and restore all of the nugets
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out
#
# Build runtime image
FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "DEAWebApi.dll"]