# Agência de Viagens - Aplicação Web API

Este projeto é uma aplicação web API desenvolvida em C# para consultar dados de uma agência de viagens. A API permite consultas à base de dados MySQL usando operações GET. O front-end foi desenvolvido utilizando Next.js para interação com a API.

## Tecnologias Utilizadas

- **Back-end**: C#
- **Banco de Dados**: MySQL
- **Front-end**: Next.js

## Estrutura do Projeto

### 1. Back-end

O back-end é responsável por fornecer as APIs para manipulação de dados. Utiliza-se C# e ASP.NET para criar endpoints que retornam informações da base de dados.

#### Tecnologias e Ferramentas:
- ASP.NET Core
- Entity Framework Core (para acesso ao banco de dados)

#### Endpoints Disponíveis:
- `GET /api/v1/destinos` - Obtém a lista de destinos disponíveis.

### 2. Banco de Dados

O banco de dados utilizado é MySQL. Ele contém uma tabela chamada `destino` com informações sobre destinos turísticos.

#### Estrutura da Tabela `destino`:
- **id**: Identificador único do destino.
- **nome**: Nome do destino.
- **descricao**: Descrição do destino.
- **localizacao**: Localização do destino.

### 3. Front-end

O front-end foi desenvolvido com Next.js para fornecer uma interface onde os usuários podem consultar os dados disponíveis na API.

#### Tecnologias e Ferramentas:
- Next.js
- Axios (para chamadas à API)

#### Funcionalidades da Interface:
- Consulta de destinos

## Instruções para Execução

### Configuração do Back-end

1. Clone o repositório:
   ```bash
   git clone https://github.com/usuario/repositorio-backend.git
