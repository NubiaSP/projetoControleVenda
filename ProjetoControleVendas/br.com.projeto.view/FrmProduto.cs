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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void tabPgDadosPessoais_Click(object sender, EventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            FornecedorDao f_dao = new FornecedorDao();
            cbFornecedor.DataSource = f_dao.ListarFornecedor();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id";


            ProdutoDao dao = new ProdutoDao();
            dgvProduto.DataSource = dao.ListarProduto();
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.descricao = txtDescricao.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.qtdEstoque = int.Parse(txtEstoque.Text);
            obj.for_id = int.Parse(cbFornecedor.SelectedValue.ToString());

            ProdutoDao dao = new ProdutoDao();
            dao.CadastrarProduto(obj);


            new Helpers().LiparTela(this);
            dgvProduto.DataSource = dao.ListarProduto();

            
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LiparTela(this);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.codigo = int.Parse(txtCodigo.Text);

            ProdutoDao dao = new ProdutoDao();
            dao.ExcluirProduto(obj);

            new Helpers().LiparTela(this);

            dgvProduto.DataSource = dao.ListarProduto();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            //1  passo - receber os dados do objeti modelo de cliente

            Produto obj = new Produto();
            obj.descricao = txtDescricao.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.qtdEstoque = int.Parse(txtEstoque.Text);
            obj.for_id = int.Parse(cbFornecedor.Text);
            obj.codigo = Convert.ToInt32(txtCodigo.Text);

            //2 passo - criar  um objeto da classe clientedao e chamar o metodo cadastrar cliente

            ProdutoDao dao = new ProdutoDao();
            dao.AlterarProduto(obj);

            new Helpers().LiparTela(this);
            dgvProduto.DataSource = dao.ListarProduto();
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //1 passo pegar os dados da linha selecionanda 
            txtCodigo.Text = dgvProduto.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = dgvProduto.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = dgvProduto.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = dgvProduto.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = dgvProduto.CurrentRow.Cells[4].Value.ToString();
        
            tabProduto.SelectedTab = tabPgDadosPessoais;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            ProdutoDao dao = new ProdutoDao();

            dgvProduto.DataSource = dao.ListarProdutoPorNome(nome);

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;
            ProdutoDao dao = new ProdutoDao();

            dgvProduto.DataSource = dao.BuscarProdutoPorNome(nome);

            if (dgvProduto.Rows.Count == 0 || txtPesquisa.Text == string.Empty)
            {
                MessageBox.Show("Nem um cliente encontrado com esse nome");
                dgvProduto.DataSource = dao.ListarProduto();

            }
        }
    }
}
