# 部署到docker 中的 asp net core api 应用如何使用 https

## 前置：
写了一个小api，简单的两个api，提供中国地区代码。一个api是返回省/直辖市/自治区；另一个是根据地区长代码查询直接子地区。

## 准备https证书 [HTTPS 与 SSL 证书概要](https://www.runoob.com/w3cnote/https-ssl-intro.html)
途径：免费证书，测试开发证书，购买证书  
我这里使用的 `dotnet dev-certs`创建开发证书

dotnet dev-certs https --clean
dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\blogapi.pfx -p 123456
dotnet dev-certs https --trust

## 程序支持https
两个中间件：建议将生产 ASP.NET Core web 应用使用：

+ HTTPS 重定向中间件 (UseHttpsRedirection) 将 HTTP 请求重定向到 HTTPS。
+ HSTS 中间件 (UseHsts) 将 HTTP 严格传输安全协议 (HSTS) 标头发送到客户端。

程序自然很简单了：  
```c#
var builder = WebApplication.CreateBuilder(args);
...
var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
```

注意尽量不要使用程序配置端口！！！在启动docker镜像时配置

1. 挂载https证书的目录
2. 设置证书密码
3. 设置证书路径
4. https端口
```shell
docker run -dt `
-v C:\Users\msdxh\.aspnet\https:/https/ `
-e ASPNETCORE_Kestrel__Certificates__Default__Password=123456 `
-e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/blogapi.pfx `
-e "DOTNET_USE_POLLING_FILE_WATCHER=1" `
-e "ASPNETCORE_HTTPS_PORT=4397" `
-e "ASPNETCORE_URLS=https://+:443;http://+:80"  `
-p 4396:80 -p 4397:443 --name Blog.Api `
--link db2server --network blog blogapi:latest
```



ENV DB2_CLI_DRIVER_INSTALL_PATH=/app/odbc_cli/clidriver
ENV LD_LIBRARY_PATH=/app/odbc_cli/clidriver/lib
ENV LIBPATH=/app/odbc_cli/clidriver/lib
ENV PATH=/app/odbc_cli/clidriver/bin:$PATH
ENV PATH=/app/odbc_cli/clidriver/adm:$PATH
ENV PATH=/app/odbc_cli/clidriver/lib:$PATH
ENV ASPNETCORE_HTTPS_PORT="4399"
ENV ASPNETCORE_ENVIRONMENT=Production