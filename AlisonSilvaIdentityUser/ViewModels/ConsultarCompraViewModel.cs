namespace AlisonSilvaIdentityUser.ViewModels
{
    public class ConsultarCompraViewModel
    {
        public ConsultarCompraViewModel()
        {

        }

        public ConsultarCompraViewModel(EnderecoViewModel endereco, CompraViewModel compra)
        {
            Endereco = endereco;
            Compra = compra;
        }
        public EnderecoViewModel? Endereco { get; set; }
        public CompraViewModel? Compra { get; set; }
    }
}
