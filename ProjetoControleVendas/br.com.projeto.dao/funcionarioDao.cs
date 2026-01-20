using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    internal class funcionarioDao
    {

        private MySqlConnection conexao;

        public funcionarioDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarFuncionario
        public void cadastrarFincionario(Funcionario obj)
        {
            try
            {
                //1 passo - defineir o cmd sql - insert into

                string sql = @"INSERT INTO tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,
                                cep,endereco,numero,complemento,bairro,cidade,estado)
                                VALUES(@nome, @rg, @cpf, @email,@senha,@cargo,@nivel_acesso,@telefone, @celular,
                                @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";
               
                //segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivelAcesso);
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

                MessageBox.Show("Funciobario cadastrado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro{erro}");  
                throw;
            }
        }

        #endregion


        #region ListarFuncionario
        public DataTable listaFuncionario()
        {
            try
            {
                // 1 passo  -  criar o dataTable e o comando Sql

                DataTable tabelFuncionario = new DataTable();

                string sql = "SELECT * FROM bdvendas.tb_funcionarios;";

                //2 passo - organizar o comando sql e execultar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 passo criar o mysqldataapter para preencher na datatable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelFuncionario);

                conexao.Close();
                return tabelFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao execultar o comando SQL:{erro}");

                return null;
            }

        }
        #endregion


        #region AlterarFuncionario
        public void AlterarFuncionario(Funcionario obj)
        {
            try
            {
                // 1 passo - defineir o cmd sql - insert into

                string sql = @"UPDATE tb_funcionarios SET nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,nivel_acesso=@nivel_acesso,telefone=@telefone,celular=@celular,cep=@cep,
                                endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                                 WHERE id=@id";

                //segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivelAcesso);
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

                MessageBox.Show("Funcionario Alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");

            }

        }

        #endregion


        #region ExcluirFuncionario
        public void ExcluirFuncionarios(Funcionario obj)
        {
            try
            {
                // 1 passo - defineir o cmd sql - insert into

                string sql = @"DELETE FROM tb_funcionarios WHERE id = @id";

                //segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                // 3 passo - aabri a conexao e execultar ocomando sql

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario Excluido com sucesso!");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");

            }

        }

        #endregion


        #region BuscarFuncionarioPorNome
        public DataTable BuscarFuncionarioPorNome(string nome)
        {
            try
            {
                // 1 passo  -  criar o dataTable e o comando Sql

                DataTable tabelaFuncionario = new DataTable();

                string sql = "SELECT * FROM bdvendas.tb_funcionarios WHERE nome = @nome;";

                //2 passo - organizar o comando sql e execultar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 passo criar o mysqldataapter para preencher na datatable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);

                conexao.Close();
                return tabelaFuncionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao execultar o comando SQL:{erro}");

                return null;
            }

        }

        #endregion



        #region ListarFuncionarioPorNome
        public DataTable ListarFuncionarioPorNome(string nome)
        {
            try
            {
                // 1 passo  -  criar o dataTable e o comando Sql

                DataTable tabelaFuncionario = new DataTable();

                string sql = "SELECT * FROM bdvendas.tb_funcionarios WHERE nome LIKE @nome;";

                //2 passo - organizar o comando sql e execultar

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 passo criar o mysqldataapter para preencher na datatable

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFuncionario);

                conexao.Close();
                return tabelaFuncionario;
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
