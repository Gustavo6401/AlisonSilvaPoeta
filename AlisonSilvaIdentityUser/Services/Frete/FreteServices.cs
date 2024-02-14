namespace AlisonSilvaIdentityUser.Services.Frete
{
    public class FreteServices
    {
        public decimal CalcularTotal(int qtdProdutos, decimal frete, decimal preco)
        {
            if (qtdProdutos > 1)
                return preco;
            else
                return frete + preco;
        }
    }
}
