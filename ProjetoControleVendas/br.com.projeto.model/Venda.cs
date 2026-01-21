using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleVendas.br.com.projeto.model
{
    public class Venda
    {
        public int id { get; set; }
        public int idVenda { get; set; }
        public DateTime dataVenda { get; set; }
        public decimal totalVendas { get; set; }
        public string obs { get; set; }
    }
}
