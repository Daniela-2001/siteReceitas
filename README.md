O projeto foi dividido em quatro partes:
- Front office 
- Back office (ASP.NET)
- DAL (Camada de Acesso a Dados)
- Banco de Dados (SQL)

O Front office foi composto por um site onde foram implementadas as seguintes funcionalidades:

- Os usuários não registrados devem ter permissão para:
	* Cadastrar
	* Utilizar a opção de pesquisa
	* Visualizar os detalhes de cada receita

- Os usuários registrados devem ter permissão para:

	* Realizar todas as ações que usuários não cadastrados realizam (exceto cadastro)
	* Inserir novas receitas (que deverão estar pendentes de aprovação)
	* Inserir comentários nas receitas
	*Adicionar receitas como favoritas para consultar posteriormente
	* Gerenciar favoritos do usuário
	* Entrar
	*Aceder a área pessoa e gerir informações pessoais

O Back office será restrito a administradores. Os administradores deverão ter permissão para 
- Gerenciar o acesso dos usuários do site 
- Aprovar conteúdos de receitas pendentes
- Adicionar novos ingredientes
- Adicionar novas categorias
- Adicionar novos níveis de dificuldades
Cada receita deve ser composta por:
- Título
- Lista de ingredientes
- Método de preparação
- Categoria
- Dificuldade
- Classificação
- Tempo de preparação

  Tecnologias utilizadas: C#, SQL, ADO.NET, HTML, CSS, JS, ASP.NET e Bootstrap.

