FROM microsoft/dotnet:2.2-sdk AS build
RUN mkdir src
WORKDIR /src
COPY ./ ./
RUN ls -al
RUN dotnet publish  volume-console-app.csproj -o /tmp/app/ -c Release -r linux-x64


FROM microsoft/dotnet:2.2-runtime AS base
RUN mkdir /app
WORKDIR /app
COPY --from=build /tmp/app .
CMD ["./default_content.txt"]
ENTRYPOINT ["dotnet", "volume-console-app.dll"]
