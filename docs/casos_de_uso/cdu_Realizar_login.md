# ECOMMERCE - SOUL ARTE

## Especificação do caso de uso - Realizar Login
### Histórico da Revisão
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 26/06/2023 | **1.00** | Realizar Login | Iraikare Rodrigues |


### 1. Resumo 
Permitir o login dos usuários no sistema.


### 2. Atores 
- Visitantes

### 3. Pré-condições
- Ter cadastro já feito

### 4.Pós-condições
- Realizar login no sistema.


### 5. Fluxos de evento

#### 5.1. Fluxo Principal 
`A ser desenvolvido pelo aluno.`
|  Ator  | Sistema |
|:-------|:------- |
|1. [IN] Usuário clica em realizar login.| --- |
| --- |2. [OUT] O sistema apresenta o formulário específico. | --- |
|3. [IN] Usuário preenche Email e Senha. | --- |
| --- |4.  [OUT] O sistema valida os dados. | --- |
|5. [IN] Usuário acessa a página inicial logado. | --- |


#### 5.2. Fluxo de excessão

##### 5.2.1 E-mail em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário não insere seu E-mail e clica em "Login" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O campo 'E-mail' é obrigatório") |

##### 5.2.2 Senha em branco
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário não insere sua Senha e clica em "Login" | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("O campo 'Senha' é obrigatório") |

##### 5.2.3 E-mail incorreto
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário E-mail incorretamente | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("E-mail inválido") |

##### 5.2.4 Senha incorreta
|  Ator  | Sistema |
|:-------|:------- |
|3. O usuário insere sua Senha incorretamente | --- |
|--- |4. O sistema não valida os dados inseridos pelo usuário e exibe uma mensagem de erro ("Senha incorreta") |


### 6. Prototipos de Interface
#### 6.1. prototipo de REALIZAR LOGIN
![LOGIN](https://github.com/PI-InfoWeb-CNAT/2023-Soul_Arte/assets/101957823/02a95d05-f6d5-4aab-9031-4913035edc74)



### 7. Diagrama de classe de domínio usados neste caso de uso
--

### 8. Dicionário de dados
- Email - Uma cadeia de caracteres alfanuméricos tamanho 30.
- Senha - Dados alfanuméricos de mais de 8 caracteres;

### 9. Regras de negócio
- Email - Uma cadeia de caracteres alfanuméricos tamanho 30.
- Senha - Dados alfanuméricos de mais de 8 caracteres;
