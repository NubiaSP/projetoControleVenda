using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleVendas.br.com.projeto.model
{
    internal class Funcionario : cliente
    {
        public string senha { get; set; }
        public string cargo { get; set; }
        public string nivelAcesso { get; set; }
    }
}
 