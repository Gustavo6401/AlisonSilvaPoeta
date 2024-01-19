using MercadoPago.Client;
using MercadoPago.Client.Payment;
using MercadoPago.Client.Common;
using MercadoPago.Client.PaymentMethod;
using MercadoPago.Config;
using MercadoPago.Resource;
using MercadoPago.Resource.Payment;
using MercadoPago.Resource.PaymentMethod;

namespace AlisonSilvaPoeta.Services.MercadoPago;

public class Pagamento
{
    public async Task PagamentoCartao(decimal total, string? cardToken, int parcelas, string metodoPagamentoId, string payerEmail, string tipoIdentificação, string numeroIdentificação)
    {
        MercadoPagoConfig.AccessToken = "Meu Token de Acesso";

        var request = new PaymentCreateRequest
        {
            TransactionAmount = total,
            Token = cardToken,
            Description = "Compra",
            Installments = parcelas,
            PaymentMethodId = metodoPagamentoId,
            Payer = new PaymentPayerRequest
            {
                Email = payerEmail,
                Identification = new IdentificationRequest
                {
                    Type = tipoIdentificação,
                    Number = numeroIdentificação
                }
            }
        };

        var client = new PaymentClient();
        Payment payment = await client.CreateAsync(request);
    }

    public async Task PagamentoPix(decimal total, string? token, int parcelas, string? metodoPagamentoId, string? usuarioEmail, string? tipoIdentificação, string? numeroIdentificação)
    {
        MercadoPagoConfig.AccessToken = "Meu Token de Acesso";

        var requestOptions = new RequestOptions();
        requestOptions.CustomHeaders.Add("x-idempotency-key", "<SOME_UNIQUE_VALUE>");

        var paymentRequest = new PaymentCreateRequest
        {
            TransactionAmount = total,
            Token = token,
            Description = "Compra PIX",
            Installments = parcelas,
            PaymentMethodId = metodoPagamentoId,
            Payer = new PaymentPayerRequest
            {
                Email = usuarioEmail,
                Identification = new IdentificationRequest
                {
                    Type = tipoIdentificação,
                    Number = numeroIdentificação
                }
            }
        };

        var client = new PaymentClient();
        Payment payment = await client.CreateAsync(paymentRequest, requestOptions);
    }
}
