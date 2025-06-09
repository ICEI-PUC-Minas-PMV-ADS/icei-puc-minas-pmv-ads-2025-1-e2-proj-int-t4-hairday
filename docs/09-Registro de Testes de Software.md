# Registro de Testes de Software

| **Caso de Teste** 	| **CT-01 – Cadastrar barbeiro** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - O sistema deve permitir que os barbeiros se cadastrem com nome, especialidade, barbearia e horários disponíveis.	|
|	Plano de teste Associado 	| CT-02 Cadastrar perfil do barbeiro |

Registro de evidência  CT- 01

https://github.com/user-attachments/assets/d61a17f6-fb43-4101-aa6a-17bfcfae17a9



| **Caso de Teste** 	| **CT02 – Buscar barbearias** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - A aplicação deve exibir uma lista de barbearias disponíveis para os clientes. |
|	Plano de teste Associado 	| CT04 – Exibir lista de barbearias disponíveis |

Registro de evidência CT-02


https://github.com/user-attachments/assets/38b00201-c122-4a6c-ba77-daa8413ed960


| **Caso de Teste** 	| **CT-03 – Login Usuário**	 |
|:---:	|:---:	|
|	Requisito Associado | RF-014 A aplicação deve permitir que os diferentes tipos de usuários (cliente, barbeiro e barbearia) realizem o login. |
|	Plano de teste Associado 	| CT-14 Login do Usuário |

Registro de evidência  CT-03


https://github.com/user-attachments/assets/e57cb8e2-d684-49f9-abfa-334c79f6467d

| **Caso de Teste** 	| **CT04 – Cadastro Cliente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O sistema deve permitir que os clientes se cadastrem com nome, e-mail e telefone. |
|	Plano de teste Associado 	| CT01 – Cadastrar perfil do usuário |

Registro de evidência CT-04


https://github.com/user-attachments/assets/37862251-e82a-40e7-95bc-e8dd7a6f49b7



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


| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 011 – Buscar Barbearia                                                    |
| **Pré-condições**             | Estar na Homepage                                                    |
| **Procedimento (passo a passo)** | 1) Digitar um nome de uma barbearia  <br> 2) É precionar a tecla ENTER|
| **Dados de entrada**          | Nome fornecido: Corte                              |
| **Resultado esperado (RE)**   | Apareca ao menos uma barbearia que tenha "Corte" em seu nome            |
| **Resultado obtido (RO)**     | Três barbearias que tem a palavra "Corte" em seu nome (Corte Fino, Estilo Cortes e Rei do Corte)                         |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                       |
| **Evidência (print screen)**  |![image](https://github.com/user-attachments/assets/336fa7de-d5db-4c11-82db-cb332193e3dc) |
                                                                          
| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 012 – Agendar data e horário                                                    |
| **Pré-condições**             | Estar logado no sistema                                                    |
| **Procedimento (passo a passo)** | 1) Fazer Login. (caso nao esteja logado) <br> 2) Pesquisar a barbearia e seleciona-la. <br> 3) Selecionar o serviço e clicar em agendar <br> 4) Escolha um horario e aperte em "Agendar"|
| **Dados de entrada**          | Data: 10/06/2025, Horario: 10:00                               |
| **Resultado esperado (RE)**   | Agendar horario e redirecionar para a pagina Meus Agendamentos            |
| **Resultado obtido (RO)**     | Depois de agendar horario, redirecionou para pagina de meus agendamentos e nao apresentou nenhum erro                        |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                        |
| **Evidência (print screen)**  |![image](https://github.com/user-attachments/assets/7c6836a4-dec1-4fff-bc88-b591019c30c9)|

| **Campo**                      | **Descrição**                                                                 |
|-------------------------------|------------------------------------------------------------------------------|
| **Caso de Teste**             | CT 012 – Login                                                    |
| **Pré-condições**             | Não estar logado no sistema.                                                   |
| **Procedimento (passo a passo)** | 1) fornecer dados como email e senha <br> 2) Clicar em Login |
| **Dados de entrada**          | email: carlos@gmail.com, senha: senha123  (senha errada: senha1234)                          |
| **Resultado esperado (RE)**   | Fazer Login e redirecionar para homepage e ao errar a senha aparecer na tela do usuario            |
| **Resultado obtido (RO)**     | Ao fazer o login fui redirecionado para a homepage, e ao errar a senha fui sinalizado                      |
| **Avaliação (pegou / não pegou erro)** | RE = RO → Não pegou erro                        |
| **Evidência (print screen)**  |![image](https://github.com/user-attachments/assets/e4c31bf6-62d0-4660-9b11-901f44e2fa94) |
                                                                            
