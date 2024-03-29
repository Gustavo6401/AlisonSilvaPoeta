﻿namespace AlisonSilvaPoeta.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string? CEP { get; set; }
        public string? Rua { get; set; }
        public int Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }

        public Cliente? Cliente { get; set; }
        public int ClienteId { get; set; }

        public ICollection<Compra>? Compras { get; set; }
    }
}
