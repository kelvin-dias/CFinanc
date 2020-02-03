using CFinanc.Modelos.Enumeradores;
using System;

namespace CFinanc.Modelos
{
    public class Despesa
    {
        public long DespesaId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public bool Pago { get; set; }
        public bool DespesaFixa { get; set; }
        public bool Repetir { get; set; }
        public int? QuantidadeParcela { get; set; }
    }
}
