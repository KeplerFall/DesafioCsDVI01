### DOCUMENTAÇÂO
------------------------------------------------------------------------------------------
## WishList
<details>
<summary><code>POST</code><code>/</code><code>wishlist</code><code>(Cria um novo usuário a lista de espera)</code></summary>
  
##### Parâmetros

> | name      |  type     | data type               | description                                                           |
> |-----------|-----------|-------------------------|-----------------------------------------------------------------------|
> | Email      |  required | String   | Email do usuário  |
> | Name      |  required | String   | Nome do usuário  |

##### Respostas
> | http code     | content-type                      | response                                                            |
> |---------------|-----------------------------------|---------------------------------------------------------------------|
> |`200         | application/json       | '{status: 200, message: "Success. The Code was sent to your email"}'|
</details>
