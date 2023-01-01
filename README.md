# DIO - Trilha .NET - API e Entity Framework
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

<br>

### 🟢 Criar nova tarefa (CREATE/INSERT):

![image](https://user-images.githubusercontent.com/93789218/210187411-fee45962-323c-4a54-bfef-84e0363bd4fc.png)

### 🟠 Atualizar uma tarefa (UPDATE):

![image](https://user-images.githubusercontent.com/93789218/210187454-f47b894d-eb30-4309-b882-ed4ec5c95613.png)

### 🔴 Remover uma tarefa (DELETE):

![image](https://user-images.githubusercontent.com/93789218/210187674-c38a867c-642d-4600-b8c3-cd94ef3b41bf.png)

### 🔎 Busca Detalhada:

...
