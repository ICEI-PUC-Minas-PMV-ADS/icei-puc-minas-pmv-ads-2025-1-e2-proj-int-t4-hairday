# Registro de Testes de Software

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 009 – Cadastrar Barbeiro                                                  |
| **Pré-condições**             | Estar na página de login                                                     |
| **Procedimento (passo a passo)** | 1. Clicar em "Cadastrar-se como Barbeiro" <br>2. Preencher o formulário com dados únicos e utilizar o CNPJ de uma barbearia já cadastrada <br>3. Clicar no botão "Enviar" |
| **Dados de entrada**          | CPF: 443.545.757-67 <br>Nome: José Maria da Silva <br>Email: testebarbeiro@gmail.com <br>Senha: 123 <br>Confirmar senha: 123 <br>Cidade: Belo Horizonte <br>CNPJ: 22222222000102 |
| **Resultado esperado (RE)**   | O usuário é redirecionado à página de escolha de horários e dias da semana   |
| **Resultado obtido (RO)**     | O usuário foi redirecionado à página de escolha de horários e dias da semana |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                                                  |
| **Evidência (print screen)**  | ![Untitled](https://github.com/user-attachments/assets/daebed2f-9e9c-421d-a36a-7424b759fac1) |

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 009 – Escolher dias e horários de atendimento (Barbeiro)                                                  |
| **Pré-condições**             | Ter feito o primeiro passo do cadastro do Barbeiro (CT 009)                                                    |
| **Procedimento (passo a passo)** | 1. Selecionar as caixas com os dias da semana e os horário em que se deseja realizar atendimentos <br>2. Clicar no botão "Salvar e Continuar" |
| **Dados de entrada**          | Dias da semana:  Domingo, Segunda-feira e Terça-feira <br> Horários: 08:00, 09:00 e 10:00 |
| **Resultado esperado (RE)**   | O usuário é redirecionado à página de definição de serviços e preços   |
| **Resultado obtido (RO)**     | O usuário foi redirecionado à página de definição de serviços e preços |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                                                  |
| **Evidência (print screen)**  | ![Screenshot 2025-06-08 202419](https://github.com/user-attachments/assets/f5e9f73d-fc10-45a3-96fa-fb5a3c1f392f)|

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 009 – Definir serviços oferecidos e preços (barbeiro)                                                  |
| **Pré-condições**             | Ter escolhido os dias e horários de atendimento                                                    |
| **Procedimento (passo a passo)** | 1. Selecionar as caixas com os serviços que serão oferecidos <br>2. Preencher os campos correspondentes com os preços |
| **Dados de entrada**          | Serviços: Cabelo, Barba  <br> Preços: 11 (Cabelo), 22 (Barba) |
| **Resultado esperado (RE)**   | Os dados são salvos e o usuário é redirecionado à página de login|
| **Resultado obtido (RO)**     | O usuário foi redirecionado à página de login. Não ocorreram erros |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                                                  |
| **Evidência (print screen)**  |![Screenshot 2025-06-08 202719](https://github.com/user-attachments/assets/793ef226-6cdd-4fd6-a48d-601f5a858485) |

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 009 – Escolher barbearia                                                  |
| **Pré-condições**             | Ter buscado o nome de uma barbearia, ou ter selecionado um dos atalhos de busca (Barba,Cabelo,Massagem,SPA). Estar logado.    |
| **Procedimento (passo a passo)** | 1. Visualizar a lista de barbearias <br>2. Escolher uma barbearia e clicar em "Ver Barbearia"|
| **Dados de entrada**          | Atalho da homepage: "Cabelo" |
| **Resultado esperado (RE)**   | O usuário é redirecionado à página da barbearia correspondente|
| **Resultado obtido (RO)**     | O usuário foi redirecionado à página da barbearia correspondente |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                                                  |
| **Evidência (print screen)**  |![Screenshot 2025-06-08 203720](https://github.com/user-attachments/assets/c23f942c-dd0d-44e3-8129-4723b592feba)|






| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 010 – Senha inválida                                                     |
| **Pré-condições**             | Estar na tela de login                                                      |
| **Procedimento (passo a passo)** | 1) É fornecido um login válido e uma senha inválida  <br> 2) É selecionada a opção OK |
| **Dados de entrada**          | Login: caampp, senha: 1239 (a correta é 1234)                               |
| **Resultado esperado (RE)**   | Mensagem de erro do sistema avisando que a senha está inválida             |
| **Resultado obtido (RO)**     | Depois de programar, executa e preenche este campo                         |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro  <br> RE ≠ RO → Pegou erro                        |
| **Evidência (print screen)**  |                                                                             |

## Relatório de testes de software

| **Relatório** 	| **R-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	|  RF-002 - O sistema deve permitir que os barbeiros se cadastrem com nome, especialidade, barbearia e horários disponíveis. |
|	Plano de teste Associado 	| CT-02 Cadastrar perfil do barbeiro |
|	Caso de teste Associado 	| CT-01 – Cadastrar barbeiro |
|	Avaliação | Descobriu-se que o usuário consegue enviar formulários em branco na etapa de seleção de horários |
| Análise crítica | Reajustar o controlador para impedir que o usuário envie o formulário em branco |
| Oportunidade de melhoria | Entender melhor a validação de dados de formulário no controlador |

| **Relatório** 	| **R-02 – Buscar barbearias** 	|
|:---:	|:---:	|
|	Requisito Associado 	|  RF-004 - A aplicação deve exibir uma lista de barbearias disponíveis para os clientes. |
|	Plano de teste Associado 	| CT-04 - Exibir lista de barbearias disponíveis |
|	Caso de teste Associado 	| CT-02 – Buscar barbearias |
|	Avaliação | Não foram encontrados desvios ou erros no funcionamento da página |
| Análise crítica | A página funciona como esperado |
| Oportunidade de melhoria |  |

| **Relatório** 	| **R-03 –Loign Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado | RF-014 A aplicação deve permitir que os diferentes tipos de usuários (cliente, barbeiro e barbearia) realizem o login. |
|	Plano de teste Associado 	| CT-14 - Login do Usuário |
|	Caso de teste Associado 	| CT-14 – Login Usuário |
|	Avaliação | Não foram encontrados desvios ou erros no funcionamento da página. |
| Análise crítica | Pode ser necessária um feedback para que o usuário saiba que o login foi realizado com sucesso. |
| Oportunidade de melhoria | Aprender como fazer notificações para o usuario. |
