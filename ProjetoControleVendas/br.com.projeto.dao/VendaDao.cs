using MySql.Data.MySqlClient;
using Mysqlx;
using ProjetoControleVendas.br.com.projeto.conexao;
using ProjetoControleVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.dao
{
    public class VendaDao
    {
        private MySqlConnection conexao;

        public VendaDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarVenda
        public void CadastrarVenda(Venda obj)
        {
            try
            {
                // 1 passo - defineir o cmd sql - insert into

                string sql = @"INSERT INTO bdvendas.tb_vendas (cliente_id, data_venda,total_venda, observacoes)
                                VALUES(@cliente_id,@data_venda,@total_venda,@observacoes)";

                //segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.idCliente);
                executacmd.Parameters.AddWithValue("@data_venda", obj.dataVenda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.totalVendas);
                executacmd.Parameters.AddWithValue("@observacoes", obj.obs);
 

                // 3 passo - aabri a conexao e execultar ocomando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

               // MessageBox.Show("Venda cadastrado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");
            }
        }
        #endregion

        #region Metodo que retorna o id da ultima venda
        public int restornaIdUtimaVenda()
        {
            try
            {
                int idVenda = 0;
                // 1 passo - defineir o cmd sql - insert into

                string sql = @"SELECT MAX(id) AS 'id' FROM tb_vendas";

                //segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);


                // 3 passo - aabri a conexao e execultar ocomando sql

                conexao.Open();
                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    idVenda = rs.GetInt32("id");
                   
                    
                }
                conexao.Close();
                return idVenda;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");
                conexao.Close();
                return 0;
            }
        }

        #endregion


        #region ExibiHistoricoVenda
        public DataTable listarVendaPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                // 1 passo - crando DataTable defineir o cmd sql - insert into

                DataTable tabelaHistorico = new DataTable();

                string sql = @"SELECT venda.id AS 'Código',
                                      cliente.nome AS 'Cliente',
                                      venda.data_venda AS 'DataVenda',
                                      venda.total_venda AS 'Total',
                                      venda.observacoes AS 'obs'
                                   FROM bdvendas.tb_vendas AS venda 
                                   JOIN tb_clientes AS cliente ON (venda.cliente_id = cliente.id)
                                   WHERE venda. data_venda BETWEEN  @dataInicio AND @dataFim";

               // segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                executacmd.Parameters.AddWithValue("@dataFim", dataFim);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //3 passo - criar o MysqlDataAdapter para preencher os dados no DataTable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaHistorico);

                return tabelaHistorico;

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");
                return null;

            }
        }
        #endregion

        #region ListarVendas
        public DataTable ListarVendas()
        {
            try
            {
                // 1 passo  -  criar o dataTable e o comando Sql

                DataTable tabelaVenda = new DataTable();

                string sql = @"SELECT venda.id AS 'Código',
                                      cliente.nome AS 'Cliente', 
                                      venda.data_venda AS 'Data da venda',
                                      venda.total_venda AS 'Total',
                                      venda.observacoes AS 'obs'
                                  FROM bdvendas.tb_vendas AS venda
                                  JOIN tb_clientes AS cliente ON (venda.cliente_id = cliente.id)";

                //2 passo - organizar o comando sql e execultar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 passo criar o mysqldataapter para preencher na datatable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaVenda);

                conexao.Close();
                return tabelaVenda;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao execultar o comando SQL:{erro}");

                return null;
            }
        }
        #endregion


    }
}
