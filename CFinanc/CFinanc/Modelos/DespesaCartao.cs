using CFinanc.Modelos.Enumeradores;
using System;

namespace CFinanc.Modelos
{
    public class DespesaCartao
    {
        public long DespesaCartaoId { get; set; }
        public long CartaoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public bool Repetir { get; set; }
        public int? QuantidadeParcela { get; set; }
    }
}
