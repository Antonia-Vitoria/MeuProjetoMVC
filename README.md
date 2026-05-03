# LHPet - Sistema de Gerenciamento de Clientes para Pet Shop

## Descrição

O **LHPet** é um projeto de exemplo desenvolvido em ASP.NET Core MVC para demonstrar a criação de um sistema simples de gerenciamento de clientes para um pet shop. O projeto utiliza Entity Framework Core para persistência de dados e inclui operações CRUD (Criar, Ler, Atualizar, Deletar) para a entidade Cliente.

## Funcionalidades

- **Listagem de Clientes**: Visualize todos os clientes cadastrados.
- **Adicionar Cliente**: Cadastre novos clientes com informações básicas.
- **Editar Cliente**: Atualize os dados de um cliente existente.
- **Detalhes do Cliente**: Veja informações detalhadas de um cliente específico.
- **Excluir Cliente**: Remova um cliente do sistema.

## Tecnologias Utilizadas

- **ASP.NET Core MVC**: Framework para desenvolvimento web.
- **Entity Framework Core**: ORM para acesso a dados.
- **C#**: Linguagem de programação principal.
- **SQL Server**: Banco de dados para armazenamento.
- **Bootstrap**: Framework CSS para interface responsiva.
- **jQuery**: Biblioteca JavaScript para interações dinâmicas.
- **Razor Views**: Motor de visualização para as páginas.

## Estrutura do Projeto

- **Controllers/**: Contém os controladores da aplicação (ClientesController, HomeController).
- **Models/**: Define as entidades do domínio (Cliente, Contexto, etc.).
- **Views/**: Páginas Razor para a interface do usuário.
- **Migrations/**: Scripts de migração do Entity Framework.
- **wwwroot/**: Arquivos estáticos (CSS, JS, imagens).
- **appsettings.json**: Configurações da aplicação.

## Pré-requisitos

- .NET 6.0 ou superior
- SQL Server (ou outro provedor de banco de dados compatível com EF Core)
- Visual Studio ou VS Code com extensões para .NET

## Instalação e Configuração

1. **Clone o repositório**:
   ```
   git clone <url-do-repositorio>
   cd LHPet
   ```

2. **Restaure os pacotes NuGet**:
   ```
   dotnet restore
   ```

3. **Configure o banco de dados**:
   - Atualize a string de conexão no arquivo `appsettings.json`.
   - Execute as migrações:
     ```
     dotnet ef database update
     ```

4. **Execute a aplicação**:
   ```
   dotnet run
   ```

5. Acesse a aplicação em `https://localhost:5001` (ou a porta configurada).
