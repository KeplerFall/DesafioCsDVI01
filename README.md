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
> |------------|------------------------|---------------------------------------------------------------------|----------------------------------------|
> |200         | application/json       | '{status: 200, message: "Success. The Code was sent to your email"}'| Sucesso, email cadastrado na wishlist. |
</details>
