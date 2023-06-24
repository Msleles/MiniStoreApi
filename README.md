# MiniStoreApi

Apliquei os princípios da Clean Architecture na construção de uma API utilizando a plataforma .NET, como parte do meu estudo e aprendizado. A API possui os seguintes recursos:

# Recursos

- Validação de entidades usando o FluentValidation.
- Gerenciamento de notificações de erros por meio de um serviço de notificação injetado, reutilizando a lógica de validação e tratamento de erros em diferentes serviços.
- Serviço de mapeamento com AutoMapper que simplifica o processo de mapeamento de propriedades entre objetos de diferentes tipos.
- Utilização do padrão de projeto Unit of Work agrupando as operações de leitura e gravação em uma única unidade lógica.
- Obtenção da lista dos estados brasileiros com as informações de cada estado, incluindo sigla, nome e região por meio da comunicação entre api's MiniStore e IBGE utilizando HttpClient para dar agilidade no cadastro de empresas.
- Autenticação e autorização utilizando a estrutura do Identity Identity Server e JWT (JSON Web Token)
- Agendamento de tarefas com o Hangfire que é projetado para lidar com cargas de trabalho intensivas.
 


## Requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

## Configuração

1. Clone o repositório: git clone
2. Navegue até o diretório do projeto: cd seu-projeto
3. Execute a aplicação : dotnet run

A aplicação estará disponível em http://localhost:5000.


Estrutura do Projeto

Contribuição

Se você quiser contribuir com este projeto, siga as etapas abaixo:

1.Faça um fork do repositório.
2. Crie uma nova branch: git checkout -b sua-branch
