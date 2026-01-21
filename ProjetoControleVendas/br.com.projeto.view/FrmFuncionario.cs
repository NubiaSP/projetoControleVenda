using ProjetoControleVendas.br.com.projeto.dao;
using ProjetoControleVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.view
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //1  passo - receber os dados do objeti modelo de cliente

            Funcionario obj = new Funcionario();
            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;
            obj.cargo = cbCargo.SelectedItem.ToString();
            obj.nivelAcesso = cbNivel.SelectedItem.ToString();
            obj.telefone = txtTelefone.Text;
            obj.celular = txtCelular.Text;
            obj.cep = txtCep.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = Convert.ToInt32(txtNumero.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.estado = cbUf.Text;

            //2 passo - criar  um objeto da classe clientedao e chamar o metodo cadastrar cliente

            funcionarioDao dao = new funcionarioDao();
            dao.cadastrarFincionario(obj);
            dgvPesqFuncionario.DataSource = dao.listaFuncionario();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            funcionarioDao dao = new funcionarioDao();
            dgvPesqFuncionario.DataSource = dao.listaFuncionario();
        }

        private void dgvPesqFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1 passo pegar os dados da linha selecionanda 
            txtCodigo.Text = dgvPesqFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvPesqFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = dgvPesqFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = dgvPesqFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvPesqFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = dgvPesqFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = dgvPesqFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbNivel.Text = dgvPesqFuncionario.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = dgvPesqFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = dgvPesqFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtCep.Text = dgvPesqFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = dgvPesqFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = dgvPesqFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = dgvPesqFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = dgvPesqFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = dgvPesqFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbUf.Text = dgvPesqFuncionario.CurrentRow.Cells[16].Value.ToString();

            tabFuncionario.SelectedTab = tabPgDadosPessoais;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            //1  passo - receber os dados do objeti modelo de cliente

            Funcionario obj = new Funcionario();
            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;
            obj.cargo = cbCargo.Text;
            obj.nivelAcesso = cbNivel.Text;
            obj.telefone = txtTelefone.Text;
            obj.celular = txtCelular.Text;
            obj.cep = txtCep.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = Convert.ToInt32(txtNumero.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.estado = cbUf.Text;
            obj.codigo = Convert.ToInt32(txtCodigo.Text);

            //2 passo - criar  um objeto da classe clientedao e chamar o metodo cadastrar cliente

            funcionarioDao  dao = new funcionarioDao();
            dao.AlterarFuncionario(obj);

            dgvPesqFuncionario.DataSource = dao.listaFuncionario();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.codigo = int.Parse(txtCodigo.Text);

            funcionarioDao dao = new funcionarioDao();
            dao.ExcluirFuncionarios(obj);

            dgvPesqFuncionario.DataSource = dao.listaFuncionario();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LiparTela(this);
        }

        private void btnCepPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);
                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                cbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Endereço nao encontrado, Por favor digite manualmente");
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            funcionarioDao dao = new funcionarioDao();

            dgvPesqFuncionario.DataSource = dao.ListarFuncionarioPorNome(nome);
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            funcionarioDao dao = new funcionarioDao();

            dgvPesqFuncionario.DataSource = dao.BuscarFuncionarioPorNome(nome);

            if (dgvPesqFuncionario.Rows.Count == 0 || txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Nem um funcionario encontrado com esse nome");
                dgvPesqFuncionario.DataSource = dao.listaFuncionario();

            }
        }
    }
}
