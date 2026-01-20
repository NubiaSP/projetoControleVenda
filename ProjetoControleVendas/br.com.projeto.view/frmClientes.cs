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
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoControleVendas.br.com.projeto.view
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ClienteDao dao = new ClienteDao();
            dgvPesqCliente.DataSource = dao.listaCliente();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //1  passo - receber os dados do objeti modelo de cliente

            cliente obj = new cliente();
            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
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

            ClienteDao dao = new ClienteDao();
            dao.cadastrarCliente(obj);

            dgvPesqCliente.DataSource = dao.listaCliente();

        }

        private void dgvPesqCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1 passo pegar os dados da linha selecionanda 
            txtCodigo.Text = dgvPesqCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvPesqCliente.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = dgvPesqCliente.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = dgvPesqCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvPesqCliente.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = dgvPesqCliente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = dgvPesqCliente.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = dgvPesqCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = dgvPesqCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = dgvPesqCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dgvPesqCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = dgvPesqCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = dgvPesqCliente.CurrentRow.Cells[12].Value.ToString();
            cbUf.Text = dgvPesqCliente.CurrentRow.Cells[13].Value.ToString();

            tabCliente.SelectedTab = tabPgDadosPessoais;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            cliente obj = new cliente();
            obj.codigo = int.Parse(txtCodigo.Text);

            ClienteDao dao = new ClienteDao();
            dao.ExcluirCliente(obj);

            dgvPesqCliente.DataSource = dao.listaCliente();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            //1  passo - receber os dados do objeti modelo de cliente

            cliente obj = new cliente();
            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
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

            ClienteDao dao = new ClienteDao();
            dao.AlterarCliente(obj);

            dgvPesqCliente.DataSource = dao.listaCliente();

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            ClienteDao dao = new ClienteDao();

            dgvPesqCliente.DataSource = dao.BuscarClientePorNome(nome);

            if(dgvPesqCliente.Rows.Count == 0 || txtPesquisa.Text == string.Empty)
            {
                dgvPesqCliente.DataSource = dao.listaCliente();
                    
            }

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            ClienteDao dao = new ClienteDao();

            dgvPesqCliente.DataSource = dao.ListarClientePorNome(nome);

        }

        private void btnCepPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";

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
    }
}
