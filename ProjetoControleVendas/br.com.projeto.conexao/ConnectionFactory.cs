using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoControleVendas.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        //metodo que conectar com o banco de dados 

        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
