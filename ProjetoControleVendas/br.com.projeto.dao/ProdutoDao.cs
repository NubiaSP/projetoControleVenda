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
    public class ProdutoDao
    {
        private MySqlConnection conexao;

        public ProdutoDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarProduto
        public void CadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"INSERT INTO bdvendas.tb_produtos (descricao, preco, qtd_estoque,for_id)
                                VALUES(@descricao,@preco,@qtd, @for_id)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdEstoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("produto cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");
            }
        }
        #endregion

        #region ListarProduto
        public DataTable ListarProduto()
        {
            try
            {
                DataTable tabelaProduto = new DataTable();

                string sql = @"SELECT tb_produtos.id AS 'Código',
		                              tb_produtos.descricao AS 'Descrição',
		                              tb_produtos.preco AS 'Preço',
		                              tb_produtos.qtd_estoque AS 'Qtd Esroque',
                                      tb_fornecedores.nome AS 'Fornecedor'
		                              FROM bdvendas.tb_produtos
                            JOIN bdvendas.tb_fornecedores ON (tb_produtos.for_id = tb_fornecedores.id);";

                //2 passo - organizar o comando sql e execultar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 passo criar o mysqldataapter para preencher na datatable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                conexao.Close();
                return tabelaProduto;

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao execultar o comando SQL:{erro}");

                return null;
            }
        }

        #endregion


        #region AlterarProduto
        public void AlterarProduto(Produto obj)
        {
            try
            {
                // 1 passo - defineir o cmd sql - insert into

                string sql = @"UPDATE tb_produtos SET descricao=@descricao,preco=@preco,qtd=@qtd,for_id=@for_id
                                 WHERE id=@id";

                //segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdEstoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                executacmd.Parameters.AddWithValue("id", obj.codigo);


                // 3 passo - aabri a conexao e execultar ocomando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Prosduto Alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");

            }

        }

        #endregion


        #region ExcluirProduto
        public void ExcluirProduto(Produto obj)
        {
            try
            {
                // 1 passo - defineir o cmd sql - insert into

                string sql = @"DELETE FROM tb_produtos WHERE id = @id";

                //segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                // 3 passo - aabri a conexao e execultar ocomando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto Excluido com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");

            }

        }

        #endregion


        #region BuscarProdutoPorNome
        public DataTable BuscarProdutoPorNome(string nome)
        {
            try
            {
                // 1 passo  -  criar o dataTable e o comando Sql

                DataTable tabelaProduto = new DataTable();

                string sql = @"SELECT tb_produtos.id AS 'Código',
		                              tb_produtos.descricao AS 'Descrição',
		                              tb_produtos.preco AS 'Preço',
		                              tb_produtos.qtd_estoque AS 'Qtd Esroque',
                                      tb_fornecedores.nome AS 'Fornecedor'
		                              FROM bdvendas.tb_produtos
                            JOIN bdvendas.tb_fornecedores ON (tb_produtos.for_id = tb_fornecedores.id) 
                            WHERE  tb_produtos.descricao = @nome;";

                //2 passo - organizar o comando sql e execultar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 passo criar o mysqldataapter para preencher na datatable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                conexao.Close();
                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao execultar o comando SQL:{erro}");

                return null;
            }

        }

        #endregion


        #region ListarProdutoPorNome
        public DataTable ListarProdutoPorNome(string nome)
        {
            try
            {
                // 1 passo  -  criar o dataTable e o comando Sql

                DataTable tabelaProduto = new DataTable();

                string sql = @"SELECT tb_produtos.id AS 'Código',
		                              tb_produtos.descricao AS 'Descrição',
		                              tb_produtos.preco AS 'Preço',
		                              tb_produtos.qtd_estoque AS 'Qtd Esroque',
                                      tb_fornecedores.nome AS 'Fornecedor'
		                              FROM bdvendas.tb_produtos
                            JOIN bdvendas.tb_fornecedores ON (tb_produtos.for_id = tb_fornecedores.id) 
                            WHERE  tb_produtos.descricao like @nome;";

                //2 passo - organizar o comando sql e execultar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 passo criar o mysqldataapter para preencher na datatable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                conexao.Close();
                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao execultar o comando SQL:{erro}");

                return null;
            }

        }

        #endregion



        #region metrodo que retonar um produto por codigo
        public Produto retornandoProdutoPoCodigo(int id)
        {
            try
            {
                // 1 passo - criar o dataTable e o comando Sql
                Produto objP = new Produto();
                string sql = "SELECT * FROM bdvendas.tb_produtos WHERE id = @id;";

                //2 passo - organizar o comando sql e execultar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id",id );
                conexao.Open();


                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    objP.codigo = rs.GetInt32("id");
                    objP.descricao = rs.GetString("descricao");
                    objP.preco = rs.GetDecimal("preco");

                    conexao.Close();
                    return objP;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado!");
                    conexao.Close();
                    return null;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao execultar o comando SQL:{erro}");
                return null;
            }
        }


        #endregion

        #region Metodo que baixa estoque

        public void baixaEstoque(int idProduto, int qtdEstoque)
        {
            try
            {
                //1 paaso - comando SQL

                string sql = @"UPDATE tb_produtos SET qtd_estoque=@qtd WHERE id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@qtd", qtdEstoque);
                executacmd.Parameters.AddWithValue("@id", idProduto);


                // 3 passo - aabri a conexao e execultar ocomando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao execultar o comando SQL:{erro}");

                conexao.Close();
            }
        }

        #endregion



        #region Metodo que retorna o estoque atual de um produto
        public int retornaEstoqueAtual(int idProduto)
        {
            try
            {
                string sql = @"SELECT qtd_estoque FROM tb_produtos WHERE id=@id";
                int qtdEstoque = 0;

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", idProduto);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    qtdEstoque = rs.GetInt32("qtd_estoque");
                    conexao.Close();
                }
                return qtdEstoque;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um Erro:{erro}");
                return 0;
            }
        }


        #endregion
    }
}
