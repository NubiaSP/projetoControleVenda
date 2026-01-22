using MySql.Data.MySqlClient;
using ProjetoControleVendas.br.com.projeto.conexao;
using ProjetoControleVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.dao
{
    internal class itemVendaDao
    {
        private MySqlConnection conexao;

        public itemVendaDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastraritemVenda
        public void CadastrarItem(ItemsVenda obj)
        {
            try
            {
                // 1 passo - defineir o cmd sql - insert into

                string sql = @"INSERT INTO bdvendas.tb_itensvendas (venda_id, Produto_id,qtd, subtotal)
                                VALUES(@venda_id,@Produto_id,@qtd,@subtotal)";

                //segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.vendaId);
                executacmd.Parameters.AddWithValue("@Produto_id", obj.produtoId);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);


                // 3 passo - aabri a conexao e execultar ocomando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Item cadastrado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");
            }
        }
        #endregion


    }
}
