#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENV DB2_CLI_DRIVER_INSTALL_PATH=/app/odbc_cli/clidriver  LD_LIBRARY_PATH=/app/odbc_cli/clidriver/lib  LIBPATH=/app/odbc_cli/clidriver/lib  PATH=/app/odbc_cli/clidriver/bin:/app/odbc_cli/clidriver/adm:/app/odbc_cli/clidriver/lib:$PATH

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Blog.Api/Blog.Api.csproj", "Blog.Api/"]
RUN dotnet restore "Blog.Api/Blog.Api.csproj"
COPY . .
WORKDIR "/src/Blog.Api"
RUN dotnet build "Blog.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blog.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blog.Api.dll"]

# docker exec -i -e ASPNETCORE_HTTPS_PORT="49163" -w "/app" 27f99f778bd1e9ce72e2a565041f285f9c090bacb2fb365ef3ee173efacd29e1 sh -c ""dotnet" --additionalProbingPath /root/.nuget/fallbackpackages3 --additionalProbingPath /root/.nuget/fallbackpackages --additionalProbingPath /root/.nuget/fallbackpackages2  \"/app/bin/x64/Debug/net6.0/Blog.Api.dll\" | tee /dev/console"
