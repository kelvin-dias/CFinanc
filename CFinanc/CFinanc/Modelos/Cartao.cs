using System.Collections.Generic;

namespace CFinanc.Modelos
{
    public class Cartao
    {
        public long CartaoId { get; set; }
        public string Nome { get; set; }
        public string Bandeira { get; set; }
        public List<DespesaCartao> Despesas { get; set; }
    }
}
