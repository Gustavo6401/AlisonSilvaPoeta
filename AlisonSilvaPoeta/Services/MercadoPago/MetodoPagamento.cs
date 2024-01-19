using MercadoPago.Client.PaymentMethod;
using MercadoPago.Config;
using MercadoPago.Resource;
using MercadoPago.Resource.PaymentMethod;

namespace AlisonSilvaPoeta.Services.MercadoPago;

public class MetodoPagamento
{
    public async Task<ResourcesList<PaymentMethod>> GetPaymentMethods()
    {
        MercadoPagoConfig.AccessToken = "Meu Token de Acesso";

        var client = new PaymentMethodClient();
        ResourcesList<PaymentMethod> paymentMethods = await client.ListAsync();

        foreach(var item in paymentMethods)
        {
            Console.WriteLine($"Nome do Método: {item.Name}, PaymentTypeId: {item.PaymentTypeId}");
        }

        return paymentMethods;
    }
}
