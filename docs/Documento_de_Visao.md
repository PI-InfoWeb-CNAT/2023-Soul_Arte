# Documento de visão

## Soul Arte

### Histórico da Revisão 
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/04/2023 | **1.00** | Versão Inicial  | Iara Monyke, Iraikare Rodrigues, Luiza Varella, Renan Balbino |

## 1. Objetivo do Projeto 
Este projeto tem como objetivo criar uma plataforma virtual para pequenos negócios e artesãos realizarem suas vendas. 
 
## 2. Descrição do problema 
| | |
|:-|:-|
| **_O problema de_**    | Dificuldade na divulgação e venda dos artefatos produzidos por pequenos negócios, principalmente os que não possuem uma loja física. |
| **_afetando_**      | Os próprios pequenos negócios citados e também o público interessado em consumir esse artesanato local mas não consegue achar uma boa variedade num só lugar. |
| **_cujo impacto é_**| Diminuição de vendas e reconhecimento dos confeccionadores. |
| **_uma boa solução seria_** | Criar uma aplicação web capaz de reunir vários desses produtos em diversas categorias em um único local, focando também no reconhecimento dos artistas que os produzem. |
| | |

## 3. Descrição dos usuários
| Nome | Descrição | Responsabilidades |
|:- |:- |:- |
| Administrador  | Gestor da plataforma; Usuário responsável pelo monitoramento dos processos que irão permitir o cadastro de lojas e compras de materiais. | Moderar as lojas cadastradas podendo excluir vendedores e produtos caso necessário.|
| Vendedor | loja cadastrada que pode vender e se comunicar com seus clientes por meio do sistema. | Pode adicionar novos produtos em sua loja, se comunicar com possíveis compradores, alterar informações no seu perfil e selecionar que métodos de pagamento ele aceita. |
| Visitante | Usuário não cadastrado que visualiza o site e pode obter informações sobre os produtos e lojas.  | Usuário não cadastrado que visualiza o site e pode obter informações sobre os produtos e lojas. |
| cliente | Usuário cadastrado que pode fazer compras no site. | Após o cadastro no site, o cliente pode adicionar produtos e lojas  nos colocar itens no carrinho de compras, selecionar métodos de pagamento e por fim realizar compras. |

## 4. Descrição do ambiente dos usuários 
O comércio teria quatro tipos principais de usuários, os administradores, os vendedores e suas respectivas lojas, e os compradores sejam eles cadastrados ou não.
O administrador acessará a plataforma e será responsável primordialmente pela aprovação do cadastro de novas lojas.

Os vendedores, após terem seus cadastros aprovados e perfis montados, serão responsáveis por adicionar produtos e atualizar as quantidades em estoque, também podem trabalhar sobre demanda então o acesso ao chat seria essencial. Após a coleta dos pedidos ele seria responsável pelo estabelecimento de prazos e por informar quando o envio foi realizado.

Os clientes não cadastrados (visitantes) poderão acessar o site e pesquisar por produtos e lojas, sendo capaz de olhar também as avaliações de produtos e lojas.
Os clientes cadastrados poderão exercer as mesmas funções dos visitantes mas também terão a possibilidade de criar uma lista de favoritos, um carrinho de compras, se comunicar com as lojas através dos chats e também de comprar os produtos. Após a compra, será possível o acompanhamento do produto, e após seu recebimento o cliente pode deixar uma avaliação.



## 5. Principais necessidades dos usuários
Considerando o ponto de vista do vendedor, é necessário um maior reconhecimento e divulgação do seu trabalho e também um aumento no seu número de vendas, neste caso, num ambiente virtual.

Considerando o ponto de vista do cliente, eles sentem falta de um ambiente virtual onde possam achar os produtos em questão em uma alta variedade. Por meio do nosso sistema seria possível uma pesquisa de preços e também uma melhor experiência de compras já que promoveríamos os comerciantes locais.


## 6. Alternativas concorrentes
As principais alternativas concorrentes são plataformas de revenda com uma variedade maior de categorias, não contando apenas com pequenos negócios, como por exemplo: Shopee, Aliexpress, Shein, Amazon, Mercado Livre; e também algumas redes sociais como o Facebook e o Instagram muitas vezes em junção do Whatsapp.


## 7.	Visão geral do produto
Em resumo, nosso projeto consiste em um ambiente virtual específico para venda de itens confeccionados por pequenos negócios ou artesãos próximos a localidade dos possíveis compradores, contando então com um filtro de localidade, mecanismos de buscas e de chats, em um ambiente acessível onde também será possível acompanhar e avaliar os produtos após a compra. Também prezamos pelo reconhecimento dos artistas então cada loja terá um perfil específico visando isto.


## 8.	Requisitos funcionais
| Código | Nome | Descrição |
|:---  |:--- |:--- |
| F01	| Adicionar, remover ou alterar produtos.| O vendedor tem à sua disponibilidade a função de adicionar, remover ou alterar produtos comercializados na sua loja, estabelecendo ainda seus preços de venda.
| F02	| Adicionar, remover ou alterar categorias de produtos.	| O administrador tem à sua disponibilidade a função de adicionar, remover ou alterar categorias de produtos comercializados no site.
| F03	| Remover ou alterar lojas.	| O administrador tem à sua disponibilidade a função de remover ou alterar lojas cadastradas.
| F04	| Disponibilizar ou bloquear a apresentação do produto no site de venda.	| O administrador tem à sua disponibilidade a função de liberar ou bloquear a apresentação de produtos à venda.
| F05	| Consultar pedidos realizados e não enviados.	| O vendedor pode acessar os dados de vendas de produtos do site que foram realizados pelos clientes e que ainda não foram remetidos.
| F06	| Registrar recebimento do pagamento do cliente.	| O vendedor registra no site a identificação do recebimento do pagamento realizado pelo cliente liberando o pedido para envio.
| F07	| Registrar o envio do pedido.	| O vendedor informa no site a forma de envio do pedido ao cliente.
| F08	| Visualizar produtos.	| O usuário visualiza os produtos disponíveis filtrando por categorias ou por um trecho do nome do produto.
| F09	| Adicionar ou remover produtos à cesta de compras.	| O usuário pode escolher mais de um produto para realizar a compra e inserir em uma cesta de compras.
| F10	| Realizar o cadastro e login no site como cliente.	| O usuário pode se cadastrar no site para poder comprar produtos e acessar outras diversas funcionalidades como avaliar e comentar os produtos.
| F11	| Realizar o cadastro e login no site como Vendedor/ loja.	| O vendedor pode se cadastrar no site e após a aprovação da sua conta como loja pode adicionar seus produtos para venda além de outras funcionalidades.
| F12	| Realizar a compra de um produto.	| Os clientes podem confirmar a compra dos produtos adicionados em sua cesta de compra gerando assim um pedido.
| F13	| Realizar o cancelamento de pedido solicitado.	| Os clientes podem solicitar o cancelamento de um pedido realizado desde que ainda não tenha sido enviado.
| F14	| Verificar as compras realizadas.	| Os clientes podem verificar seu histórico de compra na loja.
| F15	| Verificar o andamento do pedido.	| Os clientes podem acompanhar o andamento da entrega dos pedidos realizados.
| F16 	| Avaliar o Produto.	| Os clientes podem avaliar os produtos realizando um comentário e atribuindo uma pontuação em estrelas, também podem adicionar fotos do produto recebido.
| F17 	| Revisar dados cadastrais dos clientes.	| Os clientes podem alterar seus dados cadastrais permitindo assim que façam, por exemplo, alteração do endereço de entrega.
| F18 	| Alterar dados do perfil da loja.	| Os vendedores podem alterar informações do seu perfil público ou dados cadastrais caso necessário.
| | | | 

## 9.	Requisitos não-funcionais
| Código | Nome | Descrição | Categoria | Classificação |
|:---  |:--- |:--- |:--- |:--- |
| NF01	| Design responsivo	| O site apresentará responsividade, deixando-o mais confortável para o usuário | Usabilidade	| obrigatório
| NF02	| Acesso somente com internet	| É necessário um acesso contínuo à Internet para poder acessar os dados do site e suas funcionalidades, como comprar produtos.	| Disponibilidade	| Obrigatório
| NF03	| Criptografia das informações sensíveis aos usuários	| Senhas do usuário devem ser gravadas de forma criptografada no banco de dados	| Segurança	| Obrigatório
| NF04	| Organização do conteúdo de forma objetiva	| O site apresentará o conteúdo de forma objetiva, de modo que o usuário encontre o desejado com facilidade.	| Usabilidade	| Obrigatório
| | | | 
