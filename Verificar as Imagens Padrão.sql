Use AlisonSilvaPoeta

Select Produtos.Id,
		Titulo,
       Link From Produtos
Join Imagens On Produtos.Id = Imagens.ProdutoId
Where Imagens.ImagemPadrao = 1