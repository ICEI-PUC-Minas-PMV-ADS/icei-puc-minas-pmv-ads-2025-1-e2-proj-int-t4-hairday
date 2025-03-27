# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas
![196e5bfd-dace-4661-864e-6a32efd4830e](https://github.com/user-attachments/assets/27c73893-44a1-4f98-9c34-57a37abb0119)
![687bd2a2-7397-4440-a80d-439175ebd1c4](https://github.com/user-attachments/assets/c8a51647-a5ff-4200-8991-62a33d05249d)
![c1f048fa-6fb7-4555-94af-d6b9faaf6b37](https://github.com/user-attachments/assets/ec6b9e0d-0427-4d4b-ab0f-3d871e7bd2e0)
![63cc1fe4-ec2f-4e2c-99e7-5e41e566fc0f](https://github.com/user-attachments/assets/d45b91af-e110-46e3-bd12-b240bdcc1067)
![e469866f-a10b-4b5f-83e9-2ea0068d0026](https://github.com/user-attachments/assets/6685d802-deb3-4c3f-8477-86880a0bb72c)



Identifique, em torno de, 5 personas. Para cada persona, lembre-se de descrever suas angústicas, frustrações e expectativas de vida relacionadas ao problema. Além disso, defina uma "aparência" para a persona. Para isso, você poderá utilizar sites como [https://this-person-does-not-exist.com/pt#google_vignette](https://this-person-does-not-exist.com/pt) ou https://thispersondoesnotexist.com/ 



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
|João Silva |   Agendar horários de maneira mais rápida     |        Agendar cortes rápidos sem esperar    |
|           |remarcar meu horário de corte com facilidade pelo sistema|  evitar perder tempo ligando .     |
|Carlos sousa     |     Escolha do profissional preferido.           | Manter o hábito de cortar com o mesmo profissional. |
|                  |  um sistema simples e intuitivo para marcar meus cortes| que eu consiga agendar sem dificuldades ou ajuda de terceiros.     |
|Pedro Oliveira   |  Notificação automática antes do horário agendado.|Receber lembretes para não esquecer o compromisso | 
|                  |   um sistema que confirme meus horários sem precisar esperar atendimento                                               |   evitar frustrações com linhas ocupadas.|
|Lucas Ferreira   | Opções de cortes   |Ter flexibilidade no horário  |
|                 |ver avaliações de outros clientes antes de escolher um barbeiro    | evitar experiências ruins como na espera do atendimento |
|Marcos Lima      |  Histórico de cortes para referência               |  Ter a segurança de que sua reserva está garantida|
|                 |   um sistema que me avise sobre encaixes disponíveis  |conseguir agendar um corte rapidamente quando necessário                                                   |

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
| RF-001 |O sistema deve permitir que os clientes se cadastrem com nome, e-mail e telefone.  | ALTA |  
| RF-002 |  O sistema deve permitir que os barbeiros se cadastrem com nome, especialidade e horários disponíveis. | ALTA |  
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

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.
![41b95c17-9f83-4f34-8e5b-ea5de9faf08a](https://github.com/user-attachments/assets/22248cf5-c32a-416c-b3c9-516294806998)

> **Links Úteis**:

> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
