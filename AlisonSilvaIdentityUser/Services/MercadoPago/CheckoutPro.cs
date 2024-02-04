using AlisonSilvaIdentityUser.ViewModels;
using MercadoPago.Client.Preference;
using MercadoPago.Config;
using MercadoPago.Resource.Preference;
using Microsoft.CodeAnalysis.CSharp;

namespace AlisonSilvaIdentityUser.Services.MercadoPago
{
    public class CheckoutPro
    {
        public async Task<Preference> PagarAsync(int compraId, decimal total)
        {
            MercadoPagoConfig.AccessToken = "Meu Access Token";

            var request = new PreferenceRequest
            {
                Items = new List<PreferenceItemRequest>
                {
                    new PreferenceItemRequest
                    {
                        Title = $"Compra{compraId}",
                        Quantity = 1,
                        CurrencyId = "BRL",
                        UnitPrice = total
                    }
                }
            };

            var client = new PreferenceClient();
            Preference preference = await client.CreateAsync(request);

            return preference;
        }
    }
}
