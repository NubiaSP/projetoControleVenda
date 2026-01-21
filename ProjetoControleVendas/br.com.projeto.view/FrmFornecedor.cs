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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            FornecedorDao dao = new FornecedorDao();
            dgvPesqFornecedor.DataSource = dao.ListarFornecedor();
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

        private void btNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LiparTela(this);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //1  passo - receber os dados do objeti modelo de cliente

            Fornecedor obj = new Fornecedor();
            obj.nome = txtNome.Text;
            obj.cnpj = txtCnpj.Text;
            obj.email = txtEmail.Text;
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

            FornecedorDao dao = new FornecedorDao();
            dao.CadastrarFornecedor(obj);

            dgvPesqFornecedor.DataSource = dao.ListarFornecedor();

        }

        private void dgvPesqFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1 passo pegar os dados da linha selecionanda 
            txtCodigo.Text = dgvPesqFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvPesqFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = dgvPesqFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvPesqFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = dgvPesqFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = dgvPesqFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtCep.Text = dgvPesqFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = dgvPesqFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = dgvPesqFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtComplemento.Text = dgvPesqFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = dgvPesqFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = dgvPesqFornecedor.CurrentRow.Cells[11].Value.ToString();
            cbUf.Text = dgvPesqFornecedor.CurrentRow.Cells[12].Value.ToString();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            Fornecedor obj = new Fornecedor();
            obj.codigo = int.Parse(txtCodigo.Text);

            FornecedorDao dao = new FornecedorDao();
            dao.ExcluirFornecedor(obj);

            dgvPesqFornecedor.DataSource = dao.ListarFornecedor();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            //1  passo - receber os dados do objeti modelo de cliente

            Fornecedor obj = new Fornecedor();
            obj.nome = txtNome.Text;
            obj.cnpj = txtCnpj.Text;
            obj.email = txtEmail.Text;
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

            FornecedorDao dao = new FornecedorDao();
            dao.AlterarFornecedor(obj);

            dgvPesqFornecedor.DataSource = dao.ListarFornecedor();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            FornecedorDao dao = new FornecedorDao();

            dgvPesqFornecedor.DataSource = dao.BuscarFonecedorPorNome(nome);

            if (dgvPesqFornecedor.Rows.Count == 0 || txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Nem um Forrnecedor encontrado com esse nome");
                dgvPesqFornecedor.DataSource = dao.ListarFornecedor();

            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            FornecedorDao dao = new FornecedorDao();

            dgvPesqFornecedor.DataSource = dao.ListarFornecedorPorNome(nome);
        }
    }
}
