### DOCUMENTAÇÂO
------------------------------------------------------------------------------------------
## WishList
<details>
<summary><code>POST -></code><code>/wishlist</code> (Cria um novo usuário a lista de espera)</summary>

#### Descrição
Essa é a primeira rota a ser usada pelo usuário durante o beta fechado, onde ele se cadastrará, essa rota permite a criação do documento que contém o usuário e email na tabela de usuários e o código de verificação, que é mandado para o email dele, que posteriormente será usado como parâmetro na rota de <code>/code</code>, o código tem validade de 5 minutos.

##### Parâmetros

> | Name      |  Type     | Data type               | Description                                                           |
> |-----------|-----------|-------------------------|-----------------------------------------------------------------------|
> | email      |  required | String   | Email do usuário  |
> | name      |  required | String   | Nome do usuário  |

##### Respostas
> | Http code | Content-type | Response |  Description
> |------------|------------------------|------------------------------------------------------------------------------|----------------------------------------|
> |200         | application/json       | `{status: 200, message: "Success. The Code was sent to your email"}`         | Sucesso, email cadastrado na wishlist. |
> |400         | application/json       | `{status: 400, error: "Invalid Name, name must be more than 3 characters"}`  | Falha, o nome do usuário deve ser maior que 3 caracteres.|
> |409         | application/json       | `{status: 409, error: "Email already in use"}`                               | Falha, este email já está sendo usado por outro usuário.|
> |500         | application/json       | `{status: 500, error: "Internal server error"}`                              | Falha, erro interno do servidor.|
</details>

<details>
<summary><code>POST -></code><code>/wishlist/code</code> (Valida o código que o usuário recebeu pelo email)</summary>

#### Descrição
Essa rota é usada para verificar se o usuário possui um email válido, ele receberá um código no email dele após passar pela rota de <code>/wishlist</code> que perdurará por 5 minutos, depois disso o código se torna expirado.

#### Parâmetros
> | Name | Type | Data Type | Description |
> |------|-----------|-------|---------------------------------------|
> | code | required | String | Codigo recebido pelo email do usuário |

#### Respostas
> | Http code | Content-type | Response |  Description
> |------------|------------------------|------------------------------------------------------------------------------|----------------------------------------|
> | 200        | application/json       | `{status: 200, message: "Success. The User is now verified"}`                | Sucesso, email validado com sucesso.   |
> | 400        | application/json       | `{status: 400, error: "Invalid Code"}`                                       | Falha, código menor que 4 caracteres   |
> | 409        | application/json       | `{status: 409, error: "Code expired"}`                                       | Falha, código expirado                 |
> | 500        | application/json       | `{status: 500, error: "Internal server error"}`                              | Falha, erro interno do servidor.       |
</details>

## Authentication
<details>
<summary><code>POST -></code><code>/authentication/login</code> (Rota de autenticação para login do usuário)</summary>
  
#### Parâmetros
> | Name      |  Type     | Data type               | Description                                                           |
> |-----------|-----------|-------------------------|-----------------------------------------------------------------------|
> | email      |  required | String   | Email do usuário  |
> | password      |  required | String   | Senha do usuário  |

#### Respostas
> | Http code | Content-type | Response |  Description
> |------------|------------------------|------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------|
> | 200        | application/json       | `{ status: 200, message: "Success", token: *token*, data: *update* }`          | Sucesso, {token}: Novo token gerado para garantir a segurança, {update}: Status da atualização de last seen e status online.|
> | 400        | application/json       | `{ status: 400, error: "Invalid Email" }`                                      | Falha email não passou pelas verificações dos REGEX, e foi rejeitado.|
> | 400        | application/json       | `{ status: 400, error: "Invalid Password" }`                                   | Falha senha omitida ou inválida|
> | 404        | application/json       | `{ status: 404, error: "User not found" }`                                     | Falha email não encontrado na base de dados|
> | 500        | application/json       | `{status: 500, error: "Internal server error"}`                                | Falha, erro interno do servidor.|
</details>

<details>
<summary><code>POST -></code><code>/authentication/register</code> (Registra um novo usuário ao banco)</summary>
  
#### Parâmetros
> | Name      |  Type     | Data type               | Description                                                           |
> |-----------|-----------|-------------------------|-----------------------------------------------------------------------|
> | email      |  required | String   | Email do usuário  |
> | password      |  required | String   | Senha do usuário  |
> | name | required | String | Nome do usuário |
> | birthday | required | String | Data de nascimento do usuário | 
> | phone | required | String | Telefone do usuário |
> | avatar | required | file | Foto do usuário
</details>

#### Respostas
> | Http code | Content-type | Response |  Description
> |------------|------------------------|------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------|
> | 200        | application/json       | `{ status: 200, message: "User created successfully" }`                      | Sucesso, usuário criado com sucesso|
> | 400        | application/json       | `{ status: 400, error: "Invalid Request" }`                                  | Falha, avatar ou algum campo requerido está vazio|
> | 400        | application/json       | `{ status: 400, error: "Invalid Request" }`                                  | Falha, o campo, senha, email nome, data de nascimento ou telefone estão vazios|
> | 409        | application/json       | `{ status: 409, error: "User not verified or allowed in our wishlist" }`     | Falha, usuário não foi verificado com o código recebido por email|

</details>


