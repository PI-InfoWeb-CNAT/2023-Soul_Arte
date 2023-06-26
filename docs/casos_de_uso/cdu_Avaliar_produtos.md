# ECOMMERCE - SOUL ARTE

## Especificação do caso de uso - Avaliar Produtos
### Histórico da Revisão
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 26/06/2023 | **1.00** | Avaliar Produtos | Iraikare Rodrigues |


### 1. Resumo 
Permitir a avaliação de produtos já comprados.


### 2. Atores 
- Clientes

### 3. Pré-condições
- Possuir registro válido como cliente no sistema
- Ter comprado o produto em questão.
- Ter recebido o produto em questão.

### 4.Pós-condições
- Avaliar o produto comprado.

### 5. Fluxos de evento

#### 5.1. Fluxo Principal 
`A ser desenvolvido pelo aluno.`
|  Ator  | Sistema |
|:-------|:------- |
|1. [IN] Usuário acessa seus pedidos. | --- |
| --- |2. O sistema apresenta a tela com os pedidos já feitos. | --- |
|3. [IN] Usuário clica em “avaliar produto” (opção somente presente nos produtos já recebidos). | --- |
| --- |4. [OUT] O sistema apresenta um formulário com os dados da avaliação. | --- |
|5. [IN] Usuário preenche e envia os dados. | --- |
| --- |6. [OUT] O sistema os computa e os armazena como parte das avaliações. | --- |


#### 5.2. Fluxo de excessão 
#### 5.2.1. Erro no preenchimento dos dados
|  Ator  | Sistema |
|:-------|:------- |
|1. [IN]  Cliente tenta enviar o formulário em branco. | --- |
| --- |2. O sistema emite uma mensagem dizendo que para enviar o formulário é necessário no mínimo avaliar o produto em estrelas. | --- |

### 6. Prototipos de Interface
#### 6.1. prototipo de DEIXAR AVALIAÇÃO
![AVALIAÇÃO (1)](https://github.com/PI-InfoWeb-CNAT/2023-Soul_Arte/assets/101957823/8deb7cce-0a24-43a4-8178-89c4bbebbb00)



### 7. Diagrama de classe de domínio usados neste caso de uso
--

### 8. Dicionário de dados
- Email - Uma cadeia de caracteres alfanuméricos tamanho 30.
- Senha - Dados alfanuméricos de mais de 8 caracteres;

### 9. Regras de negócio
- Preencher pelo menos a classificação em estrelas.
