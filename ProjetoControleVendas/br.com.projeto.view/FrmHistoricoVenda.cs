using ProjetoControleVendas.br.com.projeto.dao;
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
    public partial class FrmHistoricoVenda : Form
    {
        public FrmHistoricoVenda()
        {
            InitializeComponent();
        }

        private void btPesquisarDt_Click(object sender, EventArgs e)
        {
            DateTime dataInicio, dataFim;

            

            dataInicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));

             dataFim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendaDao dao = new VendaDao();

            dgvHistorico.AutoGenerateColumns = true;
            dgvHistorico.DataSource = dao.listarVendaPorPeriodo(dataInicio, dataFim);


        }

        private void FrmHistoricoVenda_Load(object sender, EventArgs e)
        {
             VendaDao dao = new VendaDao();
             dgvHistorico.DataSource = dao.ListarVendas();

      
        }

        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
