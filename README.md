# platform-fleet
Platform fleet

- install .net core 2.2 sdk https://dotnet.microsoft.com/download
- install docker desktop
- exec `dotnet dev-certs https --trust`
- exec `docker build -t fleet-api .`
- exec `docker run --name fleet-api -p 8000:80 fleet-api:latest`

- configure for https https://github.com/dotnet/dotnet-docker/blob/master/samples/aspnetapp/aspnetcore-docker-https.md