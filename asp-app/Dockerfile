FROM microsoft/aspnet:latest

COPY . /app

WORKDIR /app

RUN ["dnu", "restore"]

EXPOSE 5004

ENTRYPOINT ["dnx", ". kestrel"]