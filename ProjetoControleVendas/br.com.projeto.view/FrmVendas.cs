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
    public partial class FrmVendas : Form
    {
        cliente clientes = new cliente();
        ClienteDao cdao = new ClienteDao();

        Produto prod = new Produto();
        ProdutoDao pdao = new ProdutoDao();

        //variaveis
        int qtd;
        decimal preco;
        decimal subtotal, total;

        //carrinho
        DataTable carrinho = new DataTable();

        public FrmVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            dgvProdutosVnd.DataSource = carrinho;
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                clientes = cdao.retornandoClienteCpf(txtCpf.Text);
                if(clientes != null)
                {
                    txtNome.Text = clientes.nome;
                }
                else
                {
                    txtCpf.Clear();
                    txtCpf.Focus();
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                prod = pdao.retornandoProdutoPoCodigo(int.Parse(txtCodigo1.Text));

                if (prod != null)
                {
                    txtDescricao.Text = prod.descricao;
                    txtPreco.Text = prod.preco.ToString();
                }
                else
                {
                    txtCodigo1.Clear();
                    txtCodigo1.Focus();
                }
              
            }
        }

        private void dgvProdutosVnd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtEstoque.Text);
                preco = decimal.Parse(txtPreco.Text);

                subtotal = qtd * preco;

                total += subtotal;

                carrinho.Rows.Add(int.Parse(txtCodigo1.Text), txtDescricao.Text, qtd, preco, subtotal);

                txtTotal.Text = total.ToString();



                txtDescricao.Clear();
                txtPreco.Clear();
                txtEstoque.Clear();
                txtCodigo1.Clear();

                txtCodigo1.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Digite o Código do preoduto!");
            }


        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            //botao remover item
            decimal subProduto = decimal.Parse(dgvProdutosVnd.CurrentRow.Cells[4].Value.ToString());

            int indice = dgvProdutosVnd.CurrentRow.Index;

            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subProduto;

            txtTotal.Text = total.ToString();
        }

        private void btPagamento_Click(object sender, EventArgs e)
        {
            //botao Pagamento
            DateTime dataAtual = DateTime.Parse(txtData.Text);
            FrmPagamento tela = new FrmPagamento(dataAtual,clientes,carrinho);

            //passando o total para a tela de pagamento 
            tela.txtTotal.Text = total.ToString();

            tela.ShowDialog();

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            // pegando a data atual
            txtData.Text = DateTime.Now.ToShortDateString();

        }
    }
}
