docker run -h db2server --name db2server --restart=always --detach --privileged=true -p 50000:50000 --env-file .env_list -v /Docker:/database db2server/shadb --network blog


 docker run -dt -e "DOTNET_USE_POLLING_FILE_WATCHER=1"  -p 4396:80 -p 4397:443 --name Blog.Api --link db2server blogapi:latest --network blog