# Registro de Testes de Software

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 001 – Cadastro Cliente                                                     |
| **Pré-condições**             | Estar na tela de cadastro de cliente                                                    |
| **Procedimento (passo a passo)** | 1) É preenchido o formulário de cadastro <br> 2) É selecionada a opção Cadastrar-se |
| **Dados de entrada**          | Cadastro: Nome: Plinio Gonzales, Email: Plinio@gmail.com, Senha: senha123, Cidade: Belo Horizonte, Telefone: 31940028922                              |
| **Resultado esperado (RE)**   | A conta ser criada e ser redirecionado para a Home            |
| **Resultado obtido (RO)**     | Conta criada com sucesso e foi redirecionado para a Home                        |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                       |
| **Evidência (print screen)** |   ![image](https://github.com/user-attachments/assets/8dfdbd74-655f-40e4-a321-19b6275d193d) |

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 002 – Ver horários agendados como barbeiro                                                     |
| **Pré-condições**             | Estar logado como barbeiro                                                    |
| **Procedimento (passo a passo)** | 1) Verificar a listagem de horários agendados. <br> 2)	Confirmar se os detalhes de cada agendamento (cliente, serviço, horário, telefone) estão visíveis corretamente. |
| **Dados de entrada**          |   Data: 10/06/2025, Horário : 09:00                            |
| **Resultado esperado (RE)**   | Ver os horários agendados            |
| **Resultado obtido (RO)**     | Ver os horários agendados            |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                        |
| **Evidência (print screen)**  | ![image](https://github.com/user-attachments/assets/81a81c0d-9420-4b5b-ba60-59223ed92e07) |

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 003 – Visualizar horários reservados da barbearia                                                     |
| **Pré-condições**             | Estar logado como dono da barbearia                                                     |
| **Procedimento (passo a passo)** | 1) Acessar o sistema com login e senha válidos como dono da barbearia. <br> 2) Verificar a listagem dos horários já agendados, com os nomes dos barbeiros, horários e clientes.|
| **Dados de entrada**          |  Data: 10/06/2025                              |
| **Resultado esperado (RE)**   | Visualizar horários reservados da barbearia             |
| **Resultado obtido (RO)**     | Visualizados horários reservados da barbearia                        |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                          |
| **Evidência (print screen)**  | ![image](https://github.com/user-attachments/assets/9903d340-e5f3-4f55-a7c8-2ce0502d6d75) |

| **Campo**                     | **Descrição**                                                                                                                                      |
|------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------|
| **Caso de Teste**            | CT 004 – Cadastrar a barbearia                                                                                                                     |
| **Pré-condições**            | Criar uma nova barbearia                                                                                                                           |
| **Procedimento**             | 1) O usuário acessa a página "Cadastre sua barbearia"<br>2) O usuário insere os dados da barbearia<br>3) O usuário seleciona "Cadastrar"<br> |
| **Dados de entrada**         | Barbearia: Corte Top<br>Cidade: Belo Horizonte<br>CNPJ: 12.323.333/333-34<br>Telefone: 31998295467<br>E-mail: cortetop@gmail.com<br>Senha: 1234<br>Confirmar senha: 1234<br>Endereço: Rua das Flores |
| **Resultado esperado (RE)**  | O usuário faz o cadastro de sua barbearia e é redirecionado para a página "Login", onde é possível fazer o login.                                |
| **Resultado obtido (RO)**    | Depois de programar, o usuário fez o login.                                                                                                       |
| **Avaliação**                | RE = RO → **Não pegou erro**                                                                                        |
| **Evidência**                | ![Evidência](https://github.com/user-attachments/assets/6a550554-7148-4253-815b-58b3e45578db)                                                     |

| **Campo**                     | **Descrição**                                                                                                                                      |
|------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------|
| **Caso de Teste**            | CT 005 – Escolha de um profissional                                                                                                                 |
| **Pré-condições**            | Estar logado como cliente                                                                                                                           |
| **Procedimento**             | 1) O usuário acessa a página da barbearia<br>2) O usuário seleciona uma barbearia<br>3) O usuário seleciona "Cadastrar"<br>4) O usuário visualiza barbeiros e serviços disponíveis |
| **Dados de entrada**         | Login: carlos@gmail.com<br>Senha: senha123                                                                                                          |
| **Resultado esperado (RE)**  | O usuário seleciona uma barbearia e visualiza barbeiros e serviços disponíveis.                                                                    |
| **Resultado obtido (RO)**    | O usuário visualiza barbeiros e serviços.                                                                                                           |
| **Avaliação**                | RE = RO → **Não pegou erro**                                                                                            |
| **Evidência**                | ![Evidência](https://github.com/user-attachments/assets/5313812d-b6fc-4d55-9edd-b094a3375721)                                                       |


| **Campo**                     | **Descrição**                                                                                                                                      |
|------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------|
| **Caso de Teste**            | CT 006 – Gerente visualizar os horários reservados                                                                                                 |
| **Pré-condições**            | Estar logado como cliente                                                                                                                           |
| **Procedimento**             | 1) O usuário acessa a página da barbearia onde fez o agendamento<br>2) Seleciona "Meus agendamentos"<br>3) O usuário visualiza seu agendamento     |
| **Dados de entrada**         | Login: carlos@gmail.com<br>Senha: senha123                                                                                                          |
| **Resultado esperado (RE)**  | O usuário seleciona uma barbearia e visualiza sua barbearia.                                                                                       |
| **Resultado obtido (RO)**    | O usuário visualiza seus agendamentos.                                                                                                              |
| **Avaliação**                | RE = RO → **Não pegou erro**                                                                                         |
| **Evidência**                | ![Evidência](https://github.com/user-attachments/assets/365c762b-cc83-460a-a6bc-e6f5a0281e54)                                                       |

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT07 – Reagendar horários como barbeiro                                      |
| **Pré-condições**             | Estar logado tendo um cadastro como barbeiro                                 |
| **Procedimento (passo a passo)** | 1. Logar como barbeiro para acessar a página de agendamentos <br>2. Clicar em um horário agendado para exibição dos detalhes <br>3. Clicar em "Remarcar" <br>4. Escolher um novo horário <br>5. Confirmar a remarcação |
| **Dados de entrada**          | Data: 08/06/2025 <br> Horário: 20:30                                         |
| **Resultado esperado (RE)**   | Mensagem de sucesso informando que o horário foi remarcado                   |
| **Resultado obtido (RO)**     | Mensagem foi exibida após o sucesso da execução                              |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                                                  |
| **Evidência (print screen)**  | ![Capturar3](https://github.com/user-attachments/assets/c8151c23-6229-448e-8922-ff5fdb0e90cc) |


| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT08 – Cancelar horários como barbeiro                                       |
| **Pré-condições**             | Estar logado tendo um cadastro como barbeiro                                 |
| **Procedimento (passo a passo)** | 1. Logar como barbeiro para acessar a página de agendamentos <br>2. Clicar em um horário agendado para exibição dos detalhes <br>3. Clicar em "Cancelar" para anular o agendamento |
| **Dados de entrada**          | Data: 08/06/2025 <br> Horário: 20:45                                         |
| **Resultado esperado (RE)**   | Mensagem de sucesso informando que o horário foi cancelado                   |
| **Resultado obtido (RO)**     | Mensagem foi exibida após o sucesso do cancelamento                          |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                                                  |
| **Evidência (print screen)**  | ![Capturar4](https://github.com/user-attachments/assets/45816f11-0cb5-4d3c-896a-8f4fe08cf396) |

