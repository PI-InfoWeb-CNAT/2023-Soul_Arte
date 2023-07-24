# ECOMMERCE - SOUL ARTE

## Especificação do caso de uso - Denunciar Produto
### Histórico da Revisão
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 24/07/2023 | **1.00** | Avaliar Produtos | Iraikare Rodrigues |


### 1. Resumo 
Permitir a avaliação de produtos já comprados.


### 2. Atores 
- Clientes

### 3. Pré-condições
- Possuir registro válido como cliente no sistema

### 4.Pós-condições
- O produto é denunciado e as razões são salvas.

### 5. Fluxos de evento

#### 5.1. Fluxo Principal 
`A ser desenvolvido pelo aluno.`
|  Ator  | Sistema |
|:-------|:------- |
|1. [IN] Usuário acessa acessa página de produto.| --- |
| --- |2.  O sistema apresenta a tela do produto.| --- |
|3. [IN] Usuário clica em denunciar por alguma razão.| --- |
| --- |4. [OUT] O sistema apresenta o pop up de denúncia.| --- |
|5. [IN] Usuário preenche e envia o formulário.| --- |
| --- |6. [OUT]  O sistema armazena o que foi denunciado.| --- |


#### 5.2. Fluxo de excessão 
#### 5.2.1. Usuário não logado
|  Ator  | Sistema |
|:-------|:------- |
|1. [IN]  Cliente tenta enviar o formulário sem estar logado. | --- |
| --- |2. O sistema emite uma mensagem de erro dizendo que o usuário não está logado e isso é necessário para a denúncia.| --- |

#### 5.2.2. Formulário vazio
|  Ator  | Sistema |
|:-------|:------- |
|1. [IN]  Usuário tenta enviar denúncia vazia.| --- |
| --- |2. O sistema emite uma mensagem de erro dizendo que o usuário precisa marcar pelo menos uma razão para poder enviar.| --- |

### 6. Prototipos de Interface
#### 6.1. prototipo de DENUNCIAR PRODUTO
![PRODUTO](https://github.com/PI-InfoWeb-CNAT/2023-Soul_Arte/assets/101957823/7856cc33-69d9-47d8-9ed2-27ea99206e74)


### 7. Diagrama de classe de domínio usados neste caso de uso
--

### 8. Dicionário de dados
- Email - Uma cadeia de caracteres alfanuméricos tamanho 30.
- Senha - Dados alfanuméricos de mais de 8 caracteres;

### 9. Regras de negócio
- Marcar pelo menos uma razão.
