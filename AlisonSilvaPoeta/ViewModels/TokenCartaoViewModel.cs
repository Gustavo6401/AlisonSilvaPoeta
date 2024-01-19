namespace AlisonSilvaPoeta.ViewModels
{
    public class TokenCartaoViewModel
    {
        public dynamic Id { get; set; }
        public dynamic CardNumber { get; set; } // Número do Cartão
        public dynamic ExpirationDate { get; set; } // Data de Expiração
        public dynamic SecurityCode { get; set; } // Código de Segurança
        public dynamic CodeHolderName { get; set; } // Nome do Proprietário
        public dynamic Issuer { get; set; } // Banco Emissor
        public dynamic Installments { get; set; } // Parcelas
        public dynamic IdentificationType { get; set; } // Tipo de Documento
        public dynamic IdentificationNumber { get; set; } // Número do Documento
        public dynamic CardHolderEmail { get; set; } // E-Mail do Proprietário
    }
}
