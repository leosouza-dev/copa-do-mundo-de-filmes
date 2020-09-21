# Copa do Mundo de Filmes

Este é um repositório de uma aplicação exemplo de um cameponato de filmes, dividido em Backend e FrontEnd.

---

## Frontend

A aplicação de Frontend foi Desenvolvida em **ReactJS**.

Para sua execução:

- Realizar o clone ou download do repositório;
- Execute o comando **yarn** para download das dependências;
- Execute o comando **yarn start** para rodar a aplicação;
- Abra um navegador com o endereço **http://localhost:3000**;

---

## Backend

Existem dois projetos no Backend - um da API usando **ASP.NET Core 3.1** e outro para Teste usando **XUnit**.

Obs 1: para a execução da aplicação backend é necessário ter instalado o SDK ou Runtime do .NET Core instalado.

Para sua execução:

### API

#### Visual Studio

- Realizar o clone ou download do repositório;
- Abra a pasta do projeto e selecione o arquivo com extensão .sln;
- Clique no botão F5 para rodar a aplicação;

#### Visual Studio Code

- Realizar o clone ou download do repositório;
- Abra a pasta do projeto no terminal;
- Execute o comando **dotnet run**;

Existe uma documentação criada pelo Swagger que pode ser acessada no edpoint - **https://localhost:5001/swagger/index.html**

Obs 2: A aplicação frontend espera o endpoint **http://localhost:5000/v1/filmes**;

---

### Teste

#### Visual Studio

- Realizar o clone ou download do repositório;
- Abra a pasta do projeto e selecione o arquivo com extensão .sln;
- Clique no botão **Tests/Run All Tests**;

#### Visual Studio Code

- Realizar o clone ou download do repositório;
- Abra a pasta do projeto no terminal;
- Execute o comando **dotnet test**;
