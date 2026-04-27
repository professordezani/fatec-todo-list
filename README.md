## Instalar donet-ef
`dotnet tool install --global dotnet-ef --version 8.0.26`

## Create migrations
`dotnet ef migrations add "Create todo table"`

## Generate Script DDL (SQL)
`dotnet ef migrations script > script.sql`

## Atualiza o banco de dados
`dotnet database update`

