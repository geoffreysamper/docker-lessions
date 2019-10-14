FROM microsoft/dotnet:2.2-sdk AS build
RUN mkdir src
WORKDIR src
COPY ./ ./
RUN ls -al
RUN dotnet publish  cmds-and-entrypoint.csproj -o /tmp/app/ -c Release -r linux-x64


FROM microsoft/dotnet:2.2-runtime AS base
RUN mkdir /app
WORKDIR /app
COPY --from=build /tmp/app .
CMD ["cargs=1", "cargs2"]

ENTRYPOINT ["dotnet", "cmds-and-entrypoint.dll", "earg=1"]
