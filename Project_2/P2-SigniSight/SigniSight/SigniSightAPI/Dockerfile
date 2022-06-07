#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SigniSightAPI/SigniSightAPI.csproj", "SigniSightAPI/"]
COPY ["SigniSightModel/SigniSightModel.csproj", "SigniSightModel/"]
COPY ["SigniSightDL/SigniSightDL.csproj", "SigniSightDL/"]
COPY ["XUnitTest/XUnitTest.csproj", "XUnitTest/"]
COPY ["SigniSightBL/SigniSightBL.csproj", "SigniSightBL/"]
RUN dotnet restore "SigniSightAPI/SigniSightAPI.csproj"
COPY . .
WORKDIR "/src/SigniSightAPI"
RUN dotnet build "SigniSightAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SigniSightAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SigniSightAPI.dll"]