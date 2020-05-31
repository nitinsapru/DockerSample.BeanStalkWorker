FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["DockerSample.BeanStalkWorker/DockerSample.BeanStalkWorker.csproj", "DockerSample.BeanStalkWorker/"]
RUN dotnet restore "DockerSample.BeanStalkWorker/DockerSample.BeanStalkWorker.csproj"
COPY . .
WORKDIR "/src/DockerSample.BeanStalkWorker"
RUN dotnet build "DockerSample.BeanStalkWorker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerSample.BeanStalkWorker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerSample.BeanStalkWorker.dll"]