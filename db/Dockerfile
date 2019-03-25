FROM microsoft/mssql-server-linux
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=MyStrong!Passw0rd

COPY Demo2AppContext.bak /var/opt/mssql/data/Demo2AppContext.bak

HEALTHCHECK --interval=30s CMD opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P MyStrong!Passw0rd -Q "RESTORE DATABASE Demo2AppContext FROM DISK='/var/opt/mssql/data/Demo2AppContext.bak' WITH MOVE 'Demo2AppContext' TO '/var/opt/mssql/data/Demo2AppContext.mdf', MOVE 'Demo2AppContext_log' TO '/var/opt/mssql/data/Demo2AppContext_log.ldf' "



