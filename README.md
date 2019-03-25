# Demo 2 - WebApp deployment using Docker

## About project
This project is an example of creating environment for deploying of GameStore web application. 
GameStore is an ASP.NET Web Forms application for accessing a game catalog. The functionality of the GameStore is restricted by following operations: browse the catalog, create, edit and delete entries in the catalog placed in the MS SQL DB.

## Goals 
Automate deployment process of web application (as idempotent operation) using Docker. Deployment environment consists of Load Balancer (HAProxy), few instances of web-servers (ASP.NET Core runtime) and MS SQL server. 

## Tools
* Docker Tools for Windows

## Used docker images
* dockercloud/haproxy (as load balancer);
* microsoft/dotnet:2.2-sdk (for app build);
* microsoft/dotnet:2.2-aspnetcore-runtime (as deployment server);
* microsoft/mssql-server-linux (as MS SQL Server)

## Runbook
1. Download and unzip project's code and scripts from [GitHub repo](https://github.com/shamalets/SSDevOps-Demo2)
2. Install [Docker Tools for Windows](https://docs.docker.com/toolbox/toolbox_install_windows/) or [Docker for Windows](https://docs.docker.com/docker-for-windows/install/)
3. Run Docker Quickstart Terminal (if use Docker Tools for Windows) or Powershell (PS) (if use Docker for Windows) and go to the unziped directory with our project using cd command
4. Build docker images for web-server and sql-server using command "docker-compose build"
5. Run images using command "docker-compose up --scale websvr=3"
6. Check results in browser with you docker-engine IP ("192.168.99.100")

## Workspace description
Deployment view diagram.


