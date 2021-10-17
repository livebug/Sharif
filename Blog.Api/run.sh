# 网络
docker network connect blog db2server
# 构建镜像
docker build -f "/odsdata/Sharif/Blog.Api/Dockerfile" --force-rm -t blogapi  --label "com.microsoft.created-by=visual-studio" --label "com.microsoft.visual-studio.project-name=Blog.Api" "/odsdata/Sharif/"
# 运行容器
docker run -dt \
	-v /home/livebug/.aspnet/https:/https/ \
	-e ASPNETCORE_Kestrel__Certificates__Default__Password=123456 \
	-e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/blogapi.pfx \
	-e "DOTNET_USE_POLLING_FILE_WATCHER=1" \
	-e "ASPNETCORE_HTTPS_PORT=4397" \
	-e "ASPNETCORE_URLS=https://+:443;http://+:80"  \
	-p 4396:80 -p 4397:443 --name Blog.Api \
	--link db2server --network blog blogapi:latest

