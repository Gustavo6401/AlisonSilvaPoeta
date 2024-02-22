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
            MercadoPagoConfig.AccessToken = "TEST-524328537298760-011520-6c774ae2cd1b0116d89c23e7eb888fb5-800320485";

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
