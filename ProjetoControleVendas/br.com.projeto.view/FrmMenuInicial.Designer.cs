namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmMenuInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadasCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadasFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadasFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadsProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHisVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConfiguracao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTrocaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuClientes,
            this.MenuFuncionario,
            this.MenuFornecedores,
            this.menuProduto,
            this.menuVendas,
            this.MenuConfiguracao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuClientes
            // 
            this.MenuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadasCliente,
            this.menuConsuClientes});
            this.MenuClientes.Image = global::ProjetoControleVendas.Properties.Resources.usuarios;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(95, 24);
            this.MenuClientes.Text = "Clientes";
            // 
            // MenuCadasCliente
            // 
            this.MenuCadasCliente.Name = "MenuCadasCliente";
            this.MenuCadasCliente.Size = new System.Drawing.Size(215, 26);
            this.MenuCadasCliente.Text = "Cadastrar Cliente";
            // 
            // menuConsuClientes
            // 
            this.menuConsuClientes.Name = "menuConsuClientes";
            this.menuConsuClientes.Size = new System.Drawing.Size(215, 26);
            this.menuConsuClientes.Text = "Consultar Cliemtes";
            // 
            // MenuFuncionario
            // 
            this.MenuFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadasFuncionario,
            this.menuConsuFuncionario});
            this.MenuFuncionario.Image = global::ProjetoControleVendas.Properties.Resources.usuario_ativo;
            this.MenuFuncionario.Name = "MenuFuncionario";
            this.MenuFuncionario.Size = new System.Drawing.Size(134, 24);
            this.MenuFuncionario.Text = "Funcionaários";
            // 
            // menuCadasFuncionario
            // 
            this.menuCadasFuncionario.Name = "menuCadasFuncionario";
            this.menuCadasFuncionario.Size = new System.Drawing.Size(263, 26);
            this.menuCadasFuncionario.Text = "Cadastro de Funcionários ";
            this.menuCadasFuncionario.Click += new System.EventHandler(this.cadastroDeToolStripMenuItem_Click);
            // 
            // menuConsuFuncionario
            // 
            this.menuConsuFuncionario.Name = "menuConsuFuncionario";
            this.menuConsuFuncionario.Size = new System.Drawing.Size(263, 26);
            this.menuConsuFuncionario.Text = "Consulta de Funcionário";
            // 
            // MenuFornecedores
            // 
            this.MenuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadasFornecedor,
            this.MenuConsuFornecedor});
            this.MenuFornecedores.Image = global::ProjetoControleVendas.Properties.Resources.dolly;
            this.MenuFornecedores.Name = "MenuFornecedores";
            this.MenuFornecedores.Size = new System.Drawing.Size(132, 24);
            this.MenuFornecedores.Text = "Fornecedores";
            // 
            // MenuCadasFornecedor
            // 
            this.MenuCadasFornecedor.Name = "MenuCadasFornecedor";
            this.MenuCadasFornecedor.Size = new System.Drawing.Size(265, 26);
            this.MenuCadasFornecedor.Text = "Cadastro de Fornecedores";
            // 
            // MenuConsuFornecedor
            // 
            this.MenuConsuFornecedor.Name = "MenuConsuFornecedor";
            this.MenuConsuFornecedor.Size = new System.Drawing.Size(265, 26);
            this.MenuConsuFornecedor.Text = "Consulta de Fornecedores";
            this.MenuConsuFornecedor.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuProduto
            // 
            this.menuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadsProduto,
            this.MenuConsuProduto});
            this.menuProduto.Image = global::ProjetoControleVendas.Properties.Resources.adicionar_ao_carrinho;
            this.menuProduto.Name = "menuProduto";
            this.menuProduto.Size = new System.Drawing.Size(102, 24);
            this.menuProduto.Text = "Produtos";
            // 
            // MenuCadsProduto
            // 
            this.MenuCadsProduto.Name = "MenuCadsProduto";
            this.MenuCadsProduto.Size = new System.Drawing.Size(236, 26);
            this.MenuCadsProduto.Text = "Cadastro de produtos";
            // 
            // MenuConsuProduto
            // 
            this.MenuConsuProduto.Name = "MenuConsuProduto";
            this.MenuConsuProduto.Size = new System.Drawing.Size(236, 26);
            this.MenuConsuProduto.Text = "Consulta de produtos";
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNovaVenda,
            this.MenuHisVenda});
            this.menuVendas.Image = global::ProjetoControleVendas.Properties.Resources.aba;
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(90, 24);
            this.menuVendas.Text = "Vendas";
            // 
            // MenuNovaVenda
            // 
            this.MenuNovaVenda.Name = "MenuNovaVenda";
            this.MenuNovaVenda.Size = new System.Drawing.Size(223, 26);
            this.MenuNovaVenda.Text = "Nova venda";
            // 
            // MenuHisVenda
            // 
            this.MenuHisVenda.Name = "MenuHisVenda";
            this.MenuHisVenda.Size = new System.Drawing.Size(223, 26);
            this.MenuHisVenda.Text = "Historico de vendas";
            // 
            // MenuConfiguracao
            // 
            this.MenuConfiguracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTrocaUsuario,
            this.menuSair});
            this.MenuConfiguracao.Image = global::ProjetoControleVendas.Properties.Resources.configuracao;
            this.MenuConfiguracao.Name = "MenuConfiguracao";
            this.MenuConfiguracao.Size = new System.Drawing.Size(138, 24);
            this.MenuConfiguracao.Text = "Configurações";
            this.MenuConfiguracao.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // MenuTrocaUsuario
            // 
            this.MenuTrocaUsuario.Name = "MenuTrocaUsuario";
            this.MenuTrocaUsuario.Size = new System.Drawing.Size(210, 26);
            this.MenuTrocaUsuario.Text = "Trocar de usuario ";
            // 
            // menuSair
            // 
            this.menuSair.Image = global::ProjetoControleVendas.Properties.Resources.sair;
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(210, 26);
            this.menuSair.Text = "Sair";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtData,
            this.toolStripStatusLabel3,
            this.txtHora,
            this.toolStripStatusLabel5,
            this.txtUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(995, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 20);
            this.toolStripStatusLabel1.Text = "Data Atual";
            // 
            // txtData
            // 
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(95, 20);
            this.txtData.Text = "22/01/2026";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(79, 20);
            this.toolStripStatusLabel3.Text = "Hora atual";
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(49, 20);
            this.txtHora.Text = "14:30";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(111, 20);
            this.toolStripStatusLabel5.Text = "Usuario logado";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(51, 20);
            this.txtUsuario.Text = "Nubia";
            // 
            // FrmMenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 672);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenuInicial";
            this.Text = "Menu Inicial  - Controle de Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCadasFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuConsuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem MenuCadasFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MenuConsuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem menuProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuCadsProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuConsuProduto;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem MenuHisVenda;
        private System.Windows.Forms.ToolStripMenuItem MenuConfiguracao;
        private System.Windows.Forms.ToolStripMenuItem MenuTrocaUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txtHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem MenuClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuCadasCliente;
        private System.Windows.Forms.ToolStripMenuItem menuConsuClientes;
    }
}