# Aprendendo Mediator Pattern

Este projeto tem como objetivo demonstrar a implementação e o uso do padrão Mediator em uma aplicação .NET Core. O padrão Mediator é utilizado para reduzir as dependências diretas entre objetos, promovendo um acoplamento mais fraco e uma melhor organização do código. Este projeto é ideal para desenvolvedores que desejam aprender sobre padrões de design de software e sua aplicação prática.

## Estrutura do Projeto

O projeto está organizado em várias pastas, cada uma contendo tipos específicos de classes:

- **Application**: Esta pasta contém as principais implementações do padrão Mediator, incluindo comandos, manipuladores (handlers), notificações, etc.

  - **Commands**: Contém os objetos DTOs (Data Transfer Objects) que representam uma ação a ser executada pela aplicação. Estes comandos encapsulam os dados necessários para realizar uma operação específica, mantendo o código mais organizado e reutilizável.
  
  - **Handlers**: Contém os objetos responsáveis por processar as ações definidas pelos comandos. Os handlers são onde a lógica de negócio é realmente executada, e eles consomem os comandos para realizar as operações.

  - **Notifications**: Contém os objetos DTOs que representam notificações enviadas pelos handlers. As notificações são uma forma de comunicar eventos ou ações para outras partes da aplicação sem criar dependências diretas entre os componentes.

  - **EventHandlers**: Define objetos responsáveis por receber as notificações geradas pelos handlers. Eles agem em resposta a eventos que ocorrem na aplicação, proporcionando um sistema desacoplado de eventos e reações.

  - **Models**: Define as entidades utilizadas pela aplicação. Estas classes representam os objetos de domínio com os quais o sistema trabalha.

- **Controllers**: Esta pasta contém os controladores da aplicação. Os controladores são responsáveis por receber as requisições HTTP, processar os dados de entrada e delegar as operações necessárias aos objetos da camada `Application`.

- **appsettings.json**: Arquivo de configuração que contém as definições necessárias para a aplicação, como strings de conexão com banco de dados, configurações de logging, etc.

- **Program.cs**: Contém o ponto de entrada da aplicação. Neste arquivo, a aplicação é configurada e iniciada. É aqui que os serviços (incluindo o Mediator) são registrados na injeção de dependência do .NET Core.

- **README.md**: Este arquivo. Contém informações sobre o projeto, estrutura, e como utilizá-lo.

## Como Executar

1. Abra o projeto `MediatRSample` no Visual Studio ou outro ambiente de desenvolvimento compatível com .NET Core.
2. Compile a solução para restaurar as dependências e compilar o código.
3. Execute a aplicação para iniciar o servidor localmente.

## Padrão Mediator

O padrão Mediator é uma excelente forma de organizar a lógica de negócios e eventos em uma aplicação. Ele ajuda a manter o código limpo e desacoplado, facilitando a manutenção e a adição de novas funcionalidades. Neste projeto, o Mediator é utilizado para coordenar as interações entre comandos, manipuladores e notificações.

## Contribuindo

Se desejar contribuir com este projeto, siga as melhores práticas de desenvolvimento, adicionando novas funcionalidades ou corrigindo problemas nas pastas apropriadas:

- Adicione novos comandos, handlers, e notificações na pasta `Application`.
- Atualize ou crie novos controladores na pasta `Controllers`.

## Tecnologias Utilizadas

- .NET Core
- MediatR (Biblioteca para implementar o padrão Mediator)
- Outros pacotes e ferramentas relevantes para o desenvolvimento da aplicação.
