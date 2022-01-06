#FROM mcr.microsoft.com/dotnet/samples:aspnetapp
FROM mcr.microsoft.com/dotnet/aspnet:6.0

COPY ./build /App

WORKDIR /App

ENTRYPOINT ["dotnet", "apiorder.dll"];