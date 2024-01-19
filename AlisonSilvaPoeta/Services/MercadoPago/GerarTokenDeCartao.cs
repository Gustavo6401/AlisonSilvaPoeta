using MercadoPago.Config;

namespace AlisonSilvaPoeta.Services.MercadoPago
{
    public class GerarTokenDeCartao
    {
        public async Task GerarToken()
        {
            MercadoPagoConfig.AccessToken = "Meu token de Acesso";

            
        }
    }
}
