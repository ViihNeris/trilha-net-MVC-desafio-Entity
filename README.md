# DIO – Trilha .NET – API e Entity Framework
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de API e Entity Framework, da trilha .NET da DIO.

## Contexto
Você precisa construir um sistema gerenciador de tarefas, onde você poderá cadastrar uma lista de tarefas que permitirá organizar melhor a sua rotina.

Essa lista de tarefas precisa ter um CRUD, ou seja, deverá permitir a você obter os registros, criar, salvar e deletar esses registros.

A sua aplicação deverá ser do tipo Web API ou MVC, fique a vontade para implementar a solução que achar mais adequado.

A sua classe principal, a classe de tarefa, deve ser a seguinte:

![Diagrama da classe Tarefa](diagrama.png)

Não se esqueça de gerar a sua migration para atualização no banco de dados.

## Métodos esperados
É esperado que você crie o seus métodos conforme a seguir:


**Swagger**


![Métodos Swagger](swagger.png)


**Endpoints**


| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| GET    | /Tarefa/{id}            | id        | N/A           |
| PUT    | /Tarefa/{id}            | id        | Schema Tarefa |
| DELETE | /Tarefa/{id}            | id        | N/A           |
| GET    | /Tarefa/ObterTodos      | N/A       | N/A           |
| GET    | /Tarefa/ObterPorTitulo  | titulo    | N/A           |
| GET    | /Tarefa/ObterPorData    | data      | N/A           |
| GET    | /Tarefa/ObterPorStatus  | status    | N/A           |
| POST   | /Tarefa                 | N/A       | Schema Tarefa |

Esse é o schema (model) de Tarefa, utilizado para passar para os métodos que exigirem

```json
{
  "id": 0,
  "titulo": "string",
  "descricao": "string",
  "data": "2022-06-08T01:31:07.056Z",
  "status": "Pendente"
}
```


## Proposta
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
<br><br>

## Solução da DEV 👩🏻‍💻💜
Foi decidido desenvolver o desafio em formato MVC, aplicando todos os métodos solicitados. Acompanhe abaixo as soluções desenvolvidas:

### 🔵 Visualizar todas as tarefas (Obter Todos/READ):

![image](https://user-images.githubusercontent.com/93789218/210187322-98d9aacb-5d47-47f7-aa99-37ac2d149cfa.png)

### 🟢 Criar nova tarefa (CREATE/INSERT):

![image](https://user-images.githubusercontent.com/93789218/210187411-fee45962-323c-4a54-bfef-84e0363bd4fc.png)

### 🟠 Atualizar uma tarefa (UPDATE):

![image](https://user-images.githubusercontent.com/93789218/210187454-f47b894d-eb30-4309-b882-ed4ec5c95613.png)

### 🔴 Remover uma tarefa (DELETE):

![image](https://user-images.githubusercontent.com/93789218/210187674-c38a867c-642d-4600-b8c3-cd94ef3b41bf.png)

### 🔎 Busca Detalhada:

![image](https://user-images.githubusercontent.com/93789218/210191301-bbc12322-1568-40de-9e6c-304a72c8215d.png)


###### Dentro da "<b>Busca Detalhada</b>" há 4 opções disponíveis para o usuário conseguir localizar seu registro/tarefa, as quais são por: <b>ID</b>, <b>Título</b>, <b>Data & Hora</b> e <b>Status</b>. Observe abaixo:

#### 🔵 Busca por ID (ObterPorId/GetById/READ):

![image](https://user-images.githubusercontent.com/93789218/210191491-ec4658c9-b934-4d00-b6f6-826738175e95.png)

#### 🔵 Busca por Título (ObterPorTitulo/READ):

![image](https://user-images.githubusercontent.com/93789218/210191537-44637944-d441-440c-8167-7140a151b66f.png)

#### 🔵 Busca por Data e Hora (ObterPorData/READ):

![image](https://user-images.githubusercontent.com/93789218/210191584-c4970e7b-3e57-46ce-9e13-8754753f9f6c.png)

#### 🔵 Busca por Status (ObterPorStatus/READ):

![image](https://user-images.githubusercontent.com/93789218/210191633-ce4bb368-c136-4b56-ad1c-0aa9400a8a84.png)

<br>

### Database 🎲

Todos os dados estão armazenados localmente (<b>SqlServer</b>), preenchendo o requisito da persistência dos dados:

![image](https://user-images.githubusercontent.com/93789218/210191926-10d0d5fc-b2eb-4f1f-8e81-59c12fb5ff9c.png)

<br>

## Acho que não entendi muito bem... 🤔💭
Sem problemas! Aqui vão 2 vídeos rápidos deste projeto em funcionamento!

[GerenciadorDeTarefas_dev_part1.webm](https://user-images.githubusercontent.com/93789218/210193002-fb3fab31-5d22-4614-91fb-537c3cec56be.webm)

[GerenciadorDeTarefas_dev_part2.webm](https://user-images.githubusercontent.com/93789218/210193267-e89af3b5-94d4-4ff5-a1f8-09d30bc8f88f.webm)

<br>

## Obrigada! ✅
Acompanhe mais projetos meus em https://github.com/ViihNeris 😉💜👩🏻‍💻


