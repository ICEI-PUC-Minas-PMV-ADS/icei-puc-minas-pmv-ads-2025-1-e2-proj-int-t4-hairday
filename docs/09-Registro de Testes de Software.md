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
