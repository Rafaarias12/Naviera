FROM mcr.microsoft.com/dotnet/core/aspnet:7.0

WORKDIR /app

EXPOSE 80
EXPOSE 7078

COPY ./*.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:7.0
WORKDIR /app
COPY /app/out .
ENTRYPOINT [ "dotnet", "/Naviera.API.dll" ]

