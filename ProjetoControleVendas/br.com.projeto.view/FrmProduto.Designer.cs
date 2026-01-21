namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabProduto = new System.Windows.Forms.TabControl();
            this.tabPgDadosPessoais = new System.Windows.Forms.TabPage();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabPgConsulta = new System.Windows.Forms.TabPage();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabProduto.SuspendLayout();
            this.tabPgDadosPessoais.SuspendLayout();
            this.tabPgConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Produto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 100);
            this.panel1.TabIndex = 1;
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.tabPgDadosPessoais);
            this.tabProduto.Controls.Add(this.tabPgConsulta);
            this.tabProduto.Location = new System.Drawing.Point(12, 115);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.SelectedIndex = 0;
            this.tabProduto.Size = new System.Drawing.Size(1048, 507);
            this.tabProduto.TabIndex = 2;
            // 
            // tabPgDadosPessoais
            // 
            this.tabPgDadosPessoais.Controls.Add(this.txtPreco);
            this.tabPgDadosPessoais.Controls.Add(this.cbFornecedor);
            this.tabPgDadosPessoais.Controls.Add(this.label4);
            this.tabPgDadosPessoais.Controls.Add(this.txtEstoque);
            this.tabPgDadosPessoais.Controls.Add(this.txtDescricao);
            this.tabPgDadosPessoais.Controls.Add(this.label9);
            this.tabPgDadosPessoais.Controls.Add(this.label7);
            this.tabPgDadosPessoais.Controls.Add(this.label3);
            this.tabPgDadosPessoais.Controls.Add(this.label2);
            this.tabPgDadosPessoais.Controls.Add(this.txtCodigo);
            this.tabPgDadosPessoais.Location = new System.Drawing.Point(4, 31);
            this.tabPgDadosPessoais.Name = "tabPgDadosPessoais";
            this.tabPgDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgDadosPessoais.Size = new System.Drawing.Size(1040, 472);
            this.tabPgDadosPessoais.TabIndex = 0;
            this.tabPgDadosPessoais.Text = "Dados Pessoais";
            this.tabPgDadosPessoais.UseVisualStyleBackColor = true;
            this.tabPgDadosPessoais.Click += new System.EventHandler(this.tabPgDadosPessoais_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(723, 92);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(152, 28);
            this.txtPreco.TabIndex = 20;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(414, 155);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(241, 30);
            this.cbFornecedor.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(298, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fornecedor:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Location = new System.Drawing.Point(131, 152);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(152, 28);
            this.txtEstoque.TabIndex = 16;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(131, 90);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(477, 28);
            this.txtDescricao.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(11, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Qtd Estoque:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(630, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Preço(R$):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(133, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(106, 28);
            this.txtCodigo.TabIndex = 1;
            // 
            // tabPgConsulta
            // 
            this.tabPgConsulta.Controls.Add(this.dgvProduto);
            this.tabPgConsulta.Controls.Add(this.btPesquisar);
            this.tabPgConsulta.Controls.Add(this.txtPesquisa);
            this.tabPgConsulta.Controls.Add(this.label15);
            this.tabPgConsulta.Location = new System.Drawing.Point(4, 31);
            this.tabPgConsulta.Name = "tabPgConsulta";
            this.tabPgConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgConsulta.Size = new System.Drawing.Size(1040, 472);
            this.tabPgConsulta.TabIndex = 1;
            this.tabPgConsulta.Text = "Consulta";
            this.tabPgConsulta.UseVisualStyleBackColor = true;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(6, 100);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersWidth = 51;
            this.dgvProduto.RowTemplate.Height = 24;
            this.dgvProduto.Size = new System.Drawing.Size(1010, 358);
            this.dgvProduto.TabIndex = 14;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btPesquisar.Location = new System.Drawing.Point(498, 35);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(154, 42);
            this.btPesquisar.TabIndex = 6;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(86, 41);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(382, 28);
            this.txtPesquisa.TabIndex = 13;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(18, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 22);
            this.label15.TabIndex = 12;
            this.label15.Text = "Nome:";
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btRemover.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btRemover.Location = new System.Drawing.Point(730, 668);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(154, 49);
            this.btRemover.TabIndex = 31;
            this.btRemover.Text = "Editar";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btExcluir.Location = new System.Drawing.Point(552, 668);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(154, 49);
            this.btExcluir.TabIndex = 30;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btNovo.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btNovo.Location = new System.Drawing.Point(205, 668);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(154, 49);
            this.btNovo.TabIndex = 29;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btSalvar.Location = new System.Drawing.Point(375, 668);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(154, 49);
            this.btSalvar.TabIndex = 28;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 744);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.tabProduto);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSalvar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProduto";
            this.Text = "Cadasdro de produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabProduto.ResumeLayout(false);
            this.tabPgDadosPessoais.ResumeLayout(false);
            this.tabPgDadosPessoais.PerformLayout();
            this.tabPgConsulta.ResumeLayout(false);
            this.tabPgConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabProduto;
        private System.Windows.Forms.TabPage tabPgDadosPessoais;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TabPage tabPgConsulta;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.TextBox txtPreco;
    }
}