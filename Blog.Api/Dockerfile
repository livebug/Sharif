#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENV DB2_CLI_DRIVER_INSTALL_PATH=/app/odbc_cli/clidriver
ENV LD_LIBRARY_PATH=/app/odbc_cli/clidriver/lib
ENV LIBPATH=/app/odbc_cli/clidriver/lib
ENV PATH=/app/odbc_cli/clidriver/bin:$PATH
ENV PATH=/app/odbc_cli/clidriver/adm:$PATH
ENV PATH=/app/odbc_cli/clidriver/lib:$PATH

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

# docker exec -i -e ASPNETCORE_HTTPS_PORT="49157" -w "/app" 7fe77eaa1969d342c758fd71adbe902ffb7cab878a057746ea417bd8aca28500 sh -c ""dotnet" \"WebApplication1.dll\" | tee /dev/console"