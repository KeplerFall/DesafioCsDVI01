### DOCUMENTAÇÂO
------------------------------------------------------------------------------------------
## WishList
<details>
<summary><code>POST</code><code>/</code><code>wishlist</code><code>(Cria um novo usuário a lista de espera)</code></summary>
  
##### Parâmetros

> | Name      |  Type     | Data type               | Description                                                           |
> |-----------|-----------|-------------------------|-----------------------------------------------------------------------|
> | Email      |  required | String   | Email do usuário  |
> | Name      |  required | String   | Nome do usuário  |

##### Respostas
> | Http code | Content-type | Response |  Description
> |------------|------------------------|----------------------------------------------------------------------------|----------------------------------------|
> |200         | application/json       | `{status: 200, message: "Success. The Code was sent to your email"}         `| Sucesso, email cadastrado na wishlist. |
> |400         | application/json       | `{status: 400, error: "Invalid Name, name must be more than 3 characters"}`  | Falha, o nome do usuário deve ser maior que 3 caracteres.|
> |409         | application/json       | `{status: 409, error: "Email already in use"}`                               | Este email já está sendo usado por outro usuário.|
> |500         | application/json       | `{status: 500, error: "Internal server error"}`                              | Erro interno do servidor.|
</details>
