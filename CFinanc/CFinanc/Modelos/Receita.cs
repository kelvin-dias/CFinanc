using CFinanc.Modelos.Enumeradores;
using System;

namespace CFinanc.Modelos
{
    public class Receita
    {
        public long ReceitaId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public bool Recebido { get; set; }
        public bool ReceitaFixa { get; set; }
        public bool Repetir { get; set; }
        public int? QuantidadeRepetir { get; set; }
    }
}
