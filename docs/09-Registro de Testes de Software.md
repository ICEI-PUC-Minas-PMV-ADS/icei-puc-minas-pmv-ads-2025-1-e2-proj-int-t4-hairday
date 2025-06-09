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
| **Caso de Teste**            | CT 003 – Cadastrar a barbearia                                                                                                                     |
| **Pré-condições**            | Criar uma nova barbearia                                                                                                                           |
| **Procedimento**             | 1) O usuário acessa a página "Cadastre sua barbearia"<br>2) O usuário insere os dados da barbearia<br>3) O usuário seleciona "Cadastrar"<br> |
| **Dados de entrada**         | Barbearia: Corte Top<br>Cidade: Belo Horizonte<br>CNPJ: 12.323.333/333-34<br>Telefone: 31998295467<br>E-mail: cortetop@gmail.com<br>Senha: 1234<br>Confirmar senha: 1234<br>Endereço: Rua das Flores |
| **Resultado esperado (RE)**  | O usuário faz o cadastro de sua barbearia e é redirecionado para a página "Login", onde é possível fazer o login.                                |
| **Resultado obtido (RO)**    | Depois de programar, o usuário fez o login.                                                                                                       |
| **Avaliação**                | RE = RO → **Não pegou erro**                                                                                        |
| **Evidência**                | ![Evidência](https://github.com/user-attachments/assets/6a550554-7148-4253-815b-58b3e45578db)                                                     |

| **Campo**                     | **Descrição**                                                                                                                                      |
|------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------|
| **Caso de Teste**            | CT 008 – Escolha de um profissional                                                                                                                 |
| **Pré-condições**            | Estar logado como cliente                                                                                                                           |
| **Procedimento**             | 1) O usuário acessa a página da barbearia<br>2) O usuário seleciona uma barbearia<br>3) O usuário seleciona "Cadastrar"<br>4) O usuário visualiza barbeiros e serviços disponíveis |
| **Dados de entrada**         | Login: carlos@gmail.com<br>Senha: senha123                                                                                                          |
| **Resultado esperado (RE)**  | O usuário seleciona uma barbearia e visualiza barbeiros e serviços disponíveis.                                                                    |
| **Resultado obtido (RO)**    | O usuário visualiza barbeiros e serviços.                                                                                                           |
| **Avaliação**                | RE = RO → **Não pegou erro**                                                                                            |
| **Evidência**                | ![Evidência](https://github.com/user-attachments/assets/5313812d-b6fc-4d55-9edd-b094a3375721)                                                       |


| **Campo**                     | **Descrição**                                                                                                                                      |
|------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------|
| **Caso de Teste**            | CT 011 – Gerente visualizar os horários reservados                                                                                                 |
| **Pré-condições**            | Estar logado como cliente                                                                                                                           |
| **Procedimento**             | 1) O usuário acessa a página da barbearia onde fez o agendamento<br>2) Seleciona "Meus agendamentos"<br>3) O usuário visualiza seu agendamento     |
| **Dados de entrada**         | Login: carlos@gmail.com<br>Senha: senha123                                                                                                          |
| **Resultado esperado (RE)**  | O usuário seleciona uma barbearia e visualiza sua barbearia.                                                                                       |
| **Resultado obtido (RO)**    | O usuário visualiza seus agendamentos.                                                                                                              |
| **Avaliação**                | RE = RO → **Não pegou erro**                                                                                         |
| **Evidência**                | ![Evidência](https://github.com/user-attachments/assets/365c762b-cc83-460a-a6bc-e6f5a0281e54)                                                       |
