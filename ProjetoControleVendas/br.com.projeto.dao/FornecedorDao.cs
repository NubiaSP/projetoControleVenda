using MySql.Data.MySqlClient;
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
    internal class FornecedorDao
    {
        private MySqlConnection conexao;

        public FornecedorDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #region CadastrarFornecedor
        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                // 1 passo - defineir o cmd sql - insert into
                string sql = @"INSERT INTO bdvendas.tb_fornecedores (nome,cnpj,email,telefone,celular,
                                cep,endereco,numero,complemento,bairro,cidade,estado)
                                VALUES(@nome, @cnpj, @email, @telefone, @celular,
                                @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //segundo paasso e organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                // 3 passo - aabri a conexao e execultar ocomando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show($"Aconteceu um erro: {erro}");
            }
           
        }
        #endregion


        #region ListarFornecedor
        public DataTable ListarFornecedor()
        {
            try
            {
                // 1 passo  -  criar o dataTable e o comando Sql

                DataTable tabelaFornecedor = new DataTable();

                string sql = "SELECT * FROM bdvendas.tb_fornecedores;";

                //2 passo - organizar o comando sql e execultar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 passo criar o mysqldataapter para preencher na datatable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao execultar o comando SQL:{erro}");

                return null;
            }

        }
        #endregion


        #region AlterarFornecedor
        public void AlterarFornecedor(Fornecedor obj)
        {
            try
            {
                // 1 passo - defineir o cmd sql - insert into

                string sql = @"UPDATE tb_fornecedores SET nome=@nome,cnpj=@cnpj,email=@email,telefone=@telefone,celular=@celular,cep=@cep,
                                endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                                 WHERE id=@id";

                //segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                // 3 passo - aabri a conexao e execultar ocomando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");

            }

        }

        #endregion


        #region ExcluirFornecedor
        public void ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                // 1 passo - defineir o cmd sql - insert into

                string sql = @"DELETE FROM tb_fornecedores WHERE id = @id";

                //segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                // 3 passo - aabri a conexao e execultar ocomando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");

            }

        }

        #endregion


        #region BuscarFonecedorPorNome
        public DataTable BuscarFonecedorPorNome(string nome)
        {
            try
            {
                // 1 passo  -  criar o dataTable e o comando Sql

                DataTable tabelaFornecedor = new DataTable();

                string sql = "SELECT * FROM bdvendas.tb_fornecedor WHERE nome = @nome;";

                //2 passo - organizar o comando sql e execultar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 passo criar o mysqldataapter para preencher na datatable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao execultar o comando SQL:{erro}");

                return null;
            }

        }

        #endregion


        #region ListarFornecedorPorNome
        public DataTable ListarFornecedorPorNome(string nome)
        {
            try
            {
                // 1 passo  -  criar o dataTable e o comando Sql

                DataTable tabelaFornecedor = new DataTable();

                string sql = "SELECT * FROM bdvendas.tb_fornecedores WHERE nome LIKE @nome;";

                //2 passo - organizar o comando sql e execultar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 passo criar o mysqldataapter para preencher na datatable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();
                return tabelaFornecedor;
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
