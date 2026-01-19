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
    public class ClienteDao
    {
        private MySqlConnection conexao;

        public ClienteDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #region CadastrarCliente
        public void cadastrarCliente(cliente obj)
        {
            try
            {
                // 1 passo - defineir o cmd sql - insert into

                string sql = @"INSERT INTO tb_clientes (nome,rg,cpf,email,telefone,celular,
                                cep,endereco,numero,complemento,bairro,cidade,estado)
                                VALUES(@nome, @rg, @cpf, @email, @telefone, @celular,
                                @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //segundo paasso e organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql,conexao);
                executacmd.Parameters.AddWithValue("@nome",obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Aconteceu um erro: {erro}");
              
            }

        }
        #endregion
    }
}
