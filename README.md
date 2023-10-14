# inertiaJS-Abp.Aspnetcore

## Requirements

-   [.NET](dotnet.microsoft.com/en-us/download)
-   [ABP CLI](https://abp.io/get-started)
-   [Postgresql](https://www.postgresql.org/)
-   [Docker](https://www.docker.com/) not really required but I use this to run postgresql in this project

## Getting started

### install project dependencies

-   In solution folder restore dotnet packages
-   In src/Acme.BookStore.Web restore npm packages by running `npm install`

### Setup Database Locally without Docker

-   if you have postgresql installed locally Run postgresql
-   update the database configs appsettings.json file in the following dir to match your database :
    -   src/Acme.BookStore.Web
    -   src/Acme.BookStore.DbMigrator
    -   migrate database by running `dotnet run` in src/Acme.BookStore.DbMigrator

## Setup Database using Docker:

-   Run Docker
-   run `docker compose up` in the root folder of the project
-   migrate database by running `dotnet run` in src/Acme.BookStore.DbMigrator

### Running App

-   Run `dotnet watch ` in src/Acme.BookStore.Web, this will launch in `https://localhost:44358/`
-   Run `npm run dev ` in src/Acme.BookStore.Web to run reactJS
