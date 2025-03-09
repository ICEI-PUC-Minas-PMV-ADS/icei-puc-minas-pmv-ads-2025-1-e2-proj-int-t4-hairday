# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Apresentação do Projeto

https://github.com/user-attachments/assets/d4e19356-2d7c-4c0b-94d8-44469b37a687



## Personas

Identifique, em torno de, 5 personas. Para cada persona, lembre-se de descrever suas angústicas, frustrações e expectativas de vida relacionadas ao problema. Além disso, defina uma "aparência" para a persona. Para isso, você poderá utilizar sites como [https://this-person-does-not-exist.com/pt#google_vignette](https://this-person-does-not-exist.com/pt) ou https://thispersondoesnotexist.com/ 

Utilize também como referência o exemplo abaixo:

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/AnaClara1.png" alt="Persona1"/>

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> 
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Lucas Mendes |        O profissional pode visualizar e editar seus horários   |         Quer gerenciar os horários para evitar furos e atrasos      |
|Lucas Mendes       |        O profissional pode aceitar ou recusar solicitações de agendamento.        | Que eu possa sanar todas as minhas dúvidas rapidamente |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID     | Descrição do Requisito | Prioridade |  
|--------|---------------------------------------------------------|-----------|  
| RF-001 | A aplicação deve permitir o cadastro de clientes com nome, e-mail, telefone e senha. | ALTA |  
| RF-002 | A aplicação deve permitir o login de clientes utilizando e-mail e senha. | ALTA |  
| RF-003 | A aplicação deve permitir que barbearias se cadastrem informando nome, endereço, telefone e horário de funcionamento. | ALTA |  
| RF-004 | A aplicação deve permitir que barbearias cadastrem profissionais com nome, especialidade e horários de trabalho. | ALTA |  
| RF-005 | A aplicação deve exibir uma lista de barbearias disponíveis para os clientes. | ALTA |  
| RF-006 | A aplicação deve permitir que clientes filtrem as barbearias por proximidade, preço médio e uso de produtos veganos. | MÉDIA |  
| RF-007 | A aplicação deve exibir detalhes da barbearia, como endereço, telefone, horários de funcionamento e serviços oferecidos. | ALTA |  
| RF-008 | A aplicação deve permitir que clientes selecionem uma barbearia e visualizem os serviços disponíveis. | ALTA |  
| RF-009 | A aplicação deve permitir que clientes escolham um profissional específico dentro da barbearia. | ALTA |  
| RF-010 | A aplicação deve exibir os horários disponíveis com base na agenda do profissional selecionado. | ALTA |  
| RF-011 | A aplicação deve permitir que clientes realizem a reserva de um horário específico. | ALTA |  
| RF-012 | A aplicação deve permitir que barbearias visualizem a lista de agendamentos realizados. | ALTA |  
| RF-013 | A aplicação deve permitir que barbearias alterem horários disponíveis. | ALTA |  
| RF-014 | A aplicação deve permitir que clientes avaliem a barbearia após o atendimento. | MÉDIA |  
| RF-015 | A aplicação deve calcular uma média de avaliações para cada barbearia e exibi-la no perfil da barbearia. | MÉDIA |  

### Requisitos não Funcionais

| ID     | Descrição do Requisito | Prioridade |  
|--------|---------------------------------------------------------|-----------|  
| RNF-001 | A aplicação deve ser desenvolvida utilizando HTML, CSS, JavaScript e C#, com o back-end em ASP.NET. | ALTA |  
| RNF-002 | O sistema deverá ter uma usabilidade simples para maior compreensão do usuário. | ALTA |  
| RNF-003 | A aplicação deve ser hospedada na plataforma Azure, garantindo escalabilidade e alta disponibilidade. | ALTA |  
| RNF-004 | O tempo de resposta das principais funcionalidades da aplicação não deve ultrapassar 3 segundos em condições normais de uso. | MÉDIA |  
| RNF-005 | O sistema deverá ter um desempenho eficiente de forma a lidar com vários usuários de uma única vez. | MÉDIA |  

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue até o final do semestre |
|RE-02| A hospedagem está restrita à plataforma Azure       |
|RE-03| Não deverão ser utilizados frameworks como React no front-end, restringindo-se ao HTML, CSS, JavaScript e Bootstrap |
|RE-04| O back-end deve ser implemento utilizando-se C# com o framework ASP.NET |
|RE-05| O site deve seguir diretrizes éticas, não permitindo a publicação de conteúdos ofensivos, discriminatórios ou que violem códigos de conduta | 
|RE-06| A base de dados deve ser relacional (por exemplo, SQL Server ou MySQL) e possibilitar pelo menos três operações CRUD, incluindo gerenciamento de clientes, barbearias e agendamentos |  
|RE-07| O conteúdo da aplicação deve respeitar princípios éticos, não permitindo informações ofensivas, discriminatórias ou contrárias às normas estabelecidas. |
 
## Diagrama de Casos de Uso
![image](https://github.com/user-attachments/assets/67ce1506-3889-44b9-bd87-ab79a5afe987)

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 
As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
