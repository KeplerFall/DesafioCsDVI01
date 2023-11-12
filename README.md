### DOCUMENTAÇÂO
------------------------------------------------------------------------------------------
## WishList
<details>
<summary><code>POST</code><code>/</code><code>wishlist</code><code>(Cria um novo usuário a lista de espera)</code></summary>

#### Descrição
Essa é a primeira rota a ser usada pelo usuário durante o beta fechado, onde ele se cadastrará, essa rota permite a criação do documento que contém o usuário e email na tabela de usuários e o código de verificação, que é mandado para o email dele, que posteriormente será usado como parâmetro na rota de <code>/code</code>, o código tem validade de 5 minutos.

##### Parâmetros

> | Name      |  Type     | Data type               | Description                                                           |
> |-----------|-----------|-------------------------|-----------------------------------------------------------------------|
> | Email      |  required | String   | Email do usuário  |
> | Name      |  required | String   | Nome do usuário  |

##### Respostas
> | Http code | Content-type | Response |  Description
> |------------|------------------------|------------------------------------------------------------------------------|----------------------------------------|
> |200         | application/json       | `{status: 200, message: "Success. The Code was sent to your email"}`         | Sucesso, email cadastrado na wishlist. |
> |400         | application/json       | `{status: 400, error: "Invalid Name, name must be more than 3 characters"}`  | Falha, o nome do usuário deve ser maior que 3 caracteres.|
> |409         | application/json       | `{status: 409, error: "Email already in use"}`                               | Falha, este email já está sendo usado por outro usuário.|
> |500         | application/json       | `{status: 500, error: "Internal server error"}`                              | Falha, erro interno do servidor.|
</details>

## Code

<details>
<sumary><code>POST</code><code>/</code><code>wishlist/code</code><code>(Valida o código que o usuário recebeu pelo email)</code></sumary>

#### Parâmetros
> | Name | Type | Data Type | Description |
> |------|-----------|-------|---------------------------------------|
> | code | required | String | Codigo recebido pelo email do usuário |
</details>
