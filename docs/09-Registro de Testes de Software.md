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
| **Caso de Teste**             | CT 007 – Reagendar horários como barbeiro                                      |
| **Pré-condições**             | Estar logado tendo um cadastro como barbeiro                                 |
| **Procedimento (passo a passo)** | 1. Logar como barbeiro para acessar a página de agendamentos <br>2. Clicar em um horário agendado para exibição dos detalhes <br>3. Clicar em "Remarcar" <br>4. Escolher um novo horário <br>5. Confirmar a remarcação |
| **Dados de entrada**          | Data: 08/06/2025 <br> Horário: 20:30                                         |
| **Resultado esperado (RE)**   | Mensagem de sucesso informando que o horário foi remarcado                   |
| **Resultado obtido (RO)**     | Mensagem foi exibida após o sucesso da execução                              |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                                                  |
| **Evidência (print screen)**  | ![Capturar3](https://github.com/user-attachments/assets/c8151c23-6229-448e-8922-ff5fdb0e90cc) |


| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 008 – Cancelar horários como barbeiro                                       |
| **Pré-condições**             | Estar logado tendo um cadastro como barbeiro                                 |
| **Procedimento (passo a passo)** | 1. Logar como barbeiro para acessar a página de agendamentos <br>2. Clicar em um horário agendado para exibição dos detalhes <br>3. Clicar em "Cancelar" para anular o agendamento |
| **Dados de entrada**          | Data: 08/06/2025 <br> Horário: 20:45                                         |
| **Resultado esperado (RE)**   | Mensagem de sucesso informando que o horário foi cancelado                   |
| **Resultado obtido (RO)**     | Mensagem foi exibida após o sucesso do cancelamento                          |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                                                  |
| **Evidência (print screen)**  | ![Capturar4](https://github.com/user-attachments/assets/45816f11-0cb5-4d3c-896a-8f4fe08cf396) |

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
| **Caso de Teste**             | CT 010 – Escolher dias e horários de atendimento (Barbeiro)                                                  |
| **Pré-condições**             | Ter feito o primeiro passo do cadastro do Barbeiro (CT 009)                                                    |
| **Procedimento (passo a passo)** | 1. Selecionar as caixas com os dias da semana e os horário em que se deseja realizar atendimentos <br>2. Clicar no botão "Salvar e Continuar" |
| **Dados de entrada**          | Dias da semana:  Domingo, Segunda-feira e Terça-feira <br> Horários: 08:00, 09:00 e 10:00 |
| **Resultado esperado (RE)**   | O usuário é redirecionado à página de definição de serviços e preços   |
| **Resultado obtido (RO)**     | O usuário foi redirecionado à página de definição de serviços e preços |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                                                  |
| **Evidência (print screen)**  | ![Screenshot 2025-06-08 202419](https://github.com/user-attachments/assets/f5e9f73d-fc10-45a3-96fa-fb5a3c1f392f)|

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 011 – Definir serviços oferecidos e preços (barbeiro)                                                  |
| **Pré-condições**             | Ter escolhido os dias e horários de atendimento                                                    |
| **Procedimento (passo a passo)** | 1. Selecionar as caixas com os serviços que serão oferecidos <br>2. Preencher os campos correspondentes com os preços |
| **Dados de entrada**          | Serviços: Cabelo, Barba  <br> Preços: 11 (Cabelo), 22 (Barba) |
| **Resultado esperado (RE)**   | Os dados são salvos e o usuário é redirecionado à página de login|
| **Resultado obtido (RO)**     | O usuário foi redirecionado à página de login. Não ocorreram erros |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                                                  |
| **Evidência (print screen)**  |![Screenshot 2025-06-08 202719](https://github.com/user-attachments/assets/793ef226-6cdd-4fd6-a48d-601f5a858485) |

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 012 – Escolher barbearia                                                  |
| **Pré-condições**             | Ter buscado o nome de uma barbearia, ou ter selecionado um dos atalhos de busca (Barba,Cabelo,Massagem,SPA). Estar logado.    |
| **Procedimento (passo a passo)** | 1. Visualizar a lista de barbearias <br>2. Escolher uma barbearia e clicar em "Ver Barbearia"|
| **Dados de entrada**          | Atalho da homepage: "Cabelo" |
| **Resultado esperado (RE)**   | O usuário é redirecionado à página da barbearia correspondente|
| **Resultado obtido (RO)**     | O usuário foi redirecionado à página da barbearia correspondente |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                                                  |
| **Evidência (print screen)**  |![Screenshot 2025-06-08 203720](https://github.com/user-attachments/assets/c23f942c-dd0d-44e3-8129-4723b592feba)|


| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 013 – Buscar Barbearia                                                    |
| **Pré-condições**             | Estar na Homepage                                                    |
| **Procedimento (passo a passo)** | 1) Digitar um nome de uma barbearia  <br> 2) É precionar a tecla ENTER|
| **Dados de entrada**          | Nome fornecido: Corte                              |
| **Resultado esperado (RE)**   | Apareca ao menos uma barbearia que tenha "Corte" em seu nome            |
| **Resultado obtido (RO)**     | Três barbearias que tem a palavra "Corte" em seu nome (Corte Fino, Estilo Cortes e Rei do Corte)                         |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                       |
| **Evidência (print screen)**  |![image](https://github.com/user-attachments/assets/336fa7de-d5db-4c11-82db-cb332193e3dc) |
                                                                          
| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 014 – Agendar data e horário                                                    |
| **Pré-condições**             | Estar logado no sistema                                                    |
| **Procedimento (passo a passo)** | 1) Fazer Login. (caso nao esteja logado) <br> 2) Pesquisar a barbearia e seleciona-la. <br> 3) Selecionar o serviço e clicar em agendar <br> 4) Escolha um horario e aperte em "Agendar"|
| **Dados de entrada**          | Data: 10/06/2025, Horario: 10:00                               |
| **Resultado esperado (RE)**   | Agendar horario e redirecionar para a pagina Meus Agendamentos            |
| **Resultado obtido (RO)**     | Depois de agendar horario, redirecionou para pagina de meus agendamentos e nao apresentou nenhum erro                        |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                        |
| **Evidência (print screen)**  |![image](https://github.com/user-attachments/assets/7c6836a4-dec1-4fff-bc88-b591019c30c9)|

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 015 – Login                                                    |
| **Pré-condições**             | Não estar logado no sistema.                                                   |
| **Procedimento (passo a passo)** | 1) fornecer dados como email e senha <br> 2) Clicar em Login |
| **Dados de entrada**          | email: carlos@gmail.com, senha: senha123  (senha errada: senha1234)                          |
| **Resultado esperado (RE)**   | Fazer Login e redirecionar para homepage e ao errar a senha aparecer na tela do usuario            |
| **Resultado obtido (RO)**     | Ao fazer o login fui redirecionado para a homepage, e ao errar a senha fui sinalizado                      |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                        |
| **Evidência (print screen)**  |![image](https://github.com/user-attachments/assets/e4c31bf6-62d0-4660-9b11-901f44e2fa94) |
                                                                            


