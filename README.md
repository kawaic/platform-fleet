# platform-fleet
Platform fleet

- install .net core 2.2 sdk https://dotnet.microsoft.com/download
- install docker desktop
- run dotnet dev-certs https --trust
- run docker build -t fleet-api .
- docker run --name fleet-api -p 8000:80 fleet-api:latest