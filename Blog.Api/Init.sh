docker run -h db2server --name db2server --restart=always --detach --privileged=true -p 50000:50000 --env-file .env_list -v /Docker:/database db2server/shadb --network blog

docker build -f "D:\Sharif\Blog.Api\Dockerfile" --force-rm -t blogapi  --label "com.microsoft.created-by=visual-studio" --label "com.microsoft.visual-studio.project-name=Blog.Api" "D:\Sharif"

docker run -dt `
-v C:\Users\msdxh\.aspnet\https:/https/ `
-e ASPNETCORE_Kestrel__Certificates__Default__Password=123456 `
-e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/blogapi.pfx `
-e "DOTNET_USE_POLLING_FILE_WATCHER=1" `
-e "ASPNETCORE_HTTPS_PORT=4397" `
-e "ASPNETCORE_ENVIRONMENT=Production"
-e "ASPNETCORE_URLS=https://+:443;http://+:80"  `
-p 4396:80 -p 4397:443 --name Blog.Api `
--link db2server --network blog blogapi:latest

docker run -dt \
-v C:\Users\msdxh\.aspnet\https:/https/ \
-e ASPNETCORE_Kestrel__Certificates__Default__Password=123456 \
-e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/blogapi.pfx \
-e "DOTNET_USE_POLLING_FILE_WATCHER=1" \
-e "ASPNETCORE_HTTPS_PORT=4397" \
-e "ASPNETCORE_URLS=https://+:443;http://+:80"  \
-p 4396:80 -p 4397:443 --name Blog.Api \
--link db2server --network blog blogapi:latest

# dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\blogapi.pfx -p 123456
# dotnet dev-certs https --trust
# docker pull mcr.microsoft.com/dotnet/core/samples:aspnetapp
docker run --rm -it -p 8000:80 -p 8001:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8001 -e ASPNETCORE_Kestrel__Certificates__Default__Password="password" -e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/aspnetapp.pfx -v %USERPROFILE%\.aspnet\https:/https/  