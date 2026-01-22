using Microsoft.SqlServer.Server;
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
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace ProjetoControleVendas.br.com.projeto.view
{
    public partial class FrmPagamento : Form
    {
        cliente clientes = new cliente();
        DataTable carrinho = new DataTable();
        DateTime dataAtual;

        public FrmPagamento(DateTime  dataAtual  , cliente clientes, DataTable carrinho)
        {
            this.clientes = clientes;
            this.carrinho = carrinho;
            this.dataAtual = dataAtual;
            InitializeComponent();
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            try
            {
                //botao finalizar venda
                decimal vDinheiro, vCartao, troco, totalPago, total;
                ProdutoDao daoProduto = new ProdutoDao();

                int qtdEstoque, qtdComprada, estoqueAtualizado ;

                vDinheiro = decimal.Parse(txtDinhei.Text);
                vCartao = decimal.Parse(txtCartao.Text);
                total = decimal.Parse(txtTotal.Text);

                //calcular o total pago
                totalPago = vDinheiro + vCartao;

                if (totalPago < total)
                {
                    MessageBox.Show("O  total pago é menor que o valor total da venda!");
                }
                else
                {
                    //calcular troco
                    troco = totalPago - total;

                    Venda vendas = new Venda();

                    //pegando o id do cliente

                    vendas.idCliente = clientes.codigo;
                    vendas.dataVenda = dataAtual;
                    vendas.totalVendas = total;
                    vendas.obs = txtObs.Text;

                    VendaDao vDao = new VendaDao();
                    txtTroco.Text = troco.ToString();

                    vDao.CadastrarVenda(vendas);

                    //cadastrar item das vendas

                    foreach (DataRow linha in carrinho.Rows)
                    {
                        ItemsVenda item = new ItemsVenda();
                        item.vendaId = vDao.restornaIdUtimaVenda();
                        item.produtoId = int.Parse(linha["Código"].ToString());
                        item.qtd = int.Parse(linha["Qtd"].ToString());
                        item.subtotal = decimal.Parse(linha["Subtotal"].ToString());


                        //baixa no estoque
                        qtdEstoque = daoProduto.retornaEstoqueAtual(item.produtoId);
                        qtdComprada = item.qtd;
                        estoqueAtualizado = qtdEstoque - qtdComprada;
                        daoProduto.baixaEstoque(item.produtoId, estoqueAtualizado);

                        itemVendaDao itemdao = new itemVendaDao();
                        itemdao.CadastrarItem(item);
                    }

                    MessageBox.Show("Venda Finalizada com sucesso!");

                    this.Dispose();
                    new FrmVendas().ShowDialog();
                }


            }
            catch (Exception)
            {

                throw;
            }
         

        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            //Carrega tela
            txtTroco.Text = "0,00";
            txtDinhei.Text = "0,00";
            txtCartao.Text = "0,00";
        }

        private void txtCartao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
