# API - WebDiary

## Setup

Create the .env file

> touch .env

> cp .env.example .env

Install dependencies

> dotnet restore

Update the database

> dotnet ef database update

Run WebDiary-API

> dotnet run

# Learnings

## CRUD using Entity Framework

Entity Framework is an ORM (Object-Relational Mapping) that enables interaction with relational databases in .NET. It maps C# classes to database tables, allowing the use of LINQ (which enables querying SQL directly in C# code). Additionally, EF supports the use of migrations and allows working with data in the form of objects without the need to manually write SQL code.

## Swagger

Swagger is a library that implements the OpenAPI specification and is used to document and test RESTful APIs. It is integrated via NuGet (in .NET) and generates an interactive interface to explore and test your API endpoints. 

* Swashbuckle

Swashbuckle is a NuGet package that makes it easy to integrate Swagger into .NET projects. It automates the generation of API documentation following the OpenAPI specification and provides an interactive UI for testing API endpoints.

* NuGet package

NuGet played a crucial role in this project (all in .net). As the package manager for .NET, it allowed me to easily integrate and manage third-party libraries, tools, and dependencies. From Entity Framework to Swagger, NuGet streamlined the process of adding and updating packages, ensuring that the project remained efficient and up-to-date. Its seamless integration with Visual Studio made it an indispensable tool throughout the development process.


## SQL Server

SQL Server is a relational database management system (RDBMS) developed by Microsoft. It is widely used for storing and managing structured data. In this project, SQL Server served as the backend database. Entity Framework facilitated seamless interaction with the database by mapping C# classes to database tables and handling migrations. This abstraction allowed the focus to remain on application logic without the need to write raw SQL queries.

## Open API

OpenAPI.NET is a .NET library designed for working with OpenAPI documents.

Widely adopted standard for describing HTTP APIs 

This library enables to create, modify, validate, and convert OpenAPI documents (between JSON and YAML)

Like built-in readers and writers for serializing and deserializing OpenAPI documents across different formats and versions.

Provides an object model that represents the structure of OpenAPI documents. This model includes components such as paths, operations, parameters, and responses, allowing developers to programmatically interact with and manipulate API specifications.

⭐

# API - WebDiary

## Configuração

Crie o arquivo .env

> touch .env

> cp .env.example .env

Instale as dependências

> dotnet restore

Atualizar o Banco de Dados

> dotnet ef database update

Inicializar o WebDiary-API

> dotnet run

# Aprendizados

## CRUD usando Entity Framework

O Entity Framework é um ORM (Object-Relational Mapping) que permite a interação com bancos de dados relacionais no .NET. Ele mapeia classes C# para tabelas do banco de dados, permitindo o uso do LINQ (que possibilita consultar SQL diretamente no código C#). Além disso, o EF suporta o uso de migrations e permite trabalhar com dados na forma de objetos, sem a necessidade de escrever manualmente código SQL.

## Swagger

O Swagger é uma biblioteca que implementa a especificação OpenAPI e é usada para documentar e testar APIs RESTful. Ele é integrado via NuGet (no .NET) e gera uma interface interativa para explorar e testar os endpoints da sua API.

* Swashbuckle

O Swashbuckle é um pacote NuGet que facilita a integração do Swagger em projetos .NET. Ele automatiza a geração da documentação da API seguindo a especificação OpenAPI e fornece uma interface interativa para testar os endpoints da API.

* NuGet package

O NuGet desempenhou um papel crucial neste projeto (tudo no .NET). Como gerenciador de pacotes do .NET, ele permitiu integrar e gerenciar facilmente bibliotecas, ferramentas e dependências de terceiros. Desde o Entity Framework até o Swagger, o NuGet simplificou o processo de adicionar e atualizar pacotes, garantindo que o projeto permanecesse eficiente e atualizado. Sua integração perfeita com o Visual Studio o tornou uma ferramenta indispensável durante todo o processo de desenvolvimento.

## SQL Server

O SQL Server é um sistema de gerenciamento de banco de dados relacional (RDBMS) desenvolvido pela Microsoft. Ele é amplamente utilizado para armazenar e gerenciar dados estruturados. Neste projeto, o SQL Server foi o banco de dados backend. O Entity Framework facilitou a interação com o banco de dados, mapeando classes C# para tabelas do banco e lidando com as migrations. Essa abstração permitiu que o foco permanecesse na lógica da aplicação, sem a necessidade de escrever consultas SQL manualmente.

## Open API

O OpenAPI.NET é uma biblioteca .NET projetada para trabalhar com documentos OpenAPI.

Padrão amplamente adotado para descrever APIs HTTP.

Essa biblioteca permite criar, modificar, validar e converter documentos OpenAPI (entre JSON e YAML).

Como leitores e gravadores integrados para serializar e desserializar documentos OpenAPI em diferentes formatos e versões.

Fornece um modelo de objetos que representa a estrutura dos documentos OpenAPI. Esse modelo inclui componentes como paths, operations, parameters e responses, permitindo que os desenvolvedores interajam e manipulem as especificações da API.

⭐