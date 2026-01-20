namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmFornecedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFuncionario = new System.Windows.Forms.TabControl();
            this.tabPgDadosPessoais = new System.Windows.Forms.TabPage();
            this.btnCepPesquisar = new System.Windows.Forms.Button();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.tabPgConsulta = new System.Windows.Forms.TabPage();
            this.dgvPesqFornecedor = new System.Windows.Forms.DataGridView();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabFuncionario.SuspendLayout();
            this.tabPgDadosPessoais.SuspendLayout();
            this.tabPgConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 155);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Fornecedor";
            // 
            // tabFuncionario
            // 
            this.tabFuncionario.Controls.Add(this.tabPgDadosPessoais);
            this.tabFuncionario.Controls.Add(this.tabPgConsulta);
            this.tabFuncionario.Location = new System.Drawing.Point(12, 162);
            this.tabFuncionario.Name = "tabFuncionario";
            this.tabFuncionario.SelectedIndex = 0;
            this.tabFuncionario.Size = new System.Drawing.Size(1045, 493);
            this.tabFuncionario.TabIndex = 3;
            // 
            // tabPgDadosPessoais
            // 
            this.tabPgDadosPessoais.Controls.Add(this.btnCepPesquisar);
            this.tabPgDadosPessoais.Controls.Add(this.txtComplemento);
            this.tabPgDadosPessoais.Controls.Add(this.label16);
            this.tabPgDadosPessoais.Controls.Add(this.cbUf);
            this.tabPgDadosPessoais.Controls.Add(this.label14);
            this.tabPgDadosPessoais.Controls.Add(this.txtBairro);
            this.tabPgDadosPessoais.Controls.Add(this.label13);
            this.tabPgDadosPessoais.Controls.Add(this.txtCidade);
            this.tabPgDadosPessoais.Controls.Add(this.label12);
            this.tabPgDadosPessoais.Controls.Add(this.txtNumero);
            this.tabPgDadosPessoais.Controls.Add(this.label11);
            this.tabPgDadosPessoais.Controls.Add(this.txtCep);
            this.tabPgDadosPessoais.Controls.Add(this.txtEndereco);
            this.tabPgDadosPessoais.Controls.Add(this.txtTelefone);
            this.tabPgDadosPessoais.Controls.Add(this.txtEmail);
            this.tabPgDadosPessoais.Controls.Add(this.txtCnpj);
            this.tabPgDadosPessoais.Controls.Add(this.txtNome);
            this.tabPgDadosPessoais.Controls.Add(this.label10);
            this.tabPgDadosPessoais.Controls.Add(this.label9);
            this.tabPgDadosPessoais.Controls.Add(this.label8);
            this.tabPgDadosPessoais.Controls.Add(this.label7);
            this.tabPgDadosPessoais.Controls.Add(this.label6);
            this.tabPgDadosPessoais.Controls.Add(this.label4);
            this.tabPgDadosPessoais.Controls.Add(this.label3);
            this.tabPgDadosPessoais.Controls.Add(this.label2);
            this.tabPgDadosPessoais.Controls.Add(this.txtCodigo);
            this.tabPgDadosPessoais.Controls.Add(this.txtCelular);
            this.tabPgDadosPessoais.Location = new System.Drawing.Point(4, 31);
            this.tabPgDadosPessoais.Name = "tabPgDadosPessoais";
            this.tabPgDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgDadosPessoais.Size = new System.Drawing.Size(1037, 458);
            this.tabPgDadosPessoais.TabIndex = 0;
            this.tabPgDadosPessoais.Text = "Dados Pessoais";
            this.tabPgDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // btnCepPesquisar
            // 
            this.btnCepPesquisar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCepPesquisar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCepPesquisar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCepPesquisar.Location = new System.Drawing.Point(261, 252);
            this.btnCepPesquisar.Name = "btnCepPesquisar";
            this.btnCepPesquisar.Size = new System.Drawing.Size(128, 33);
            this.btnCepPesquisar.TabIndex = 6;
            this.btnCepPesquisar.Text = "Pesquisar";
            this.btnCepPesquisar.UseVisualStyleBackColor = false;
            this.btnCepPesquisar.Click += new System.EventHandler(this.btnCepPesquisar_Click);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(585, 303);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(131, 28);
            this.txtComplemento.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(459, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 22);
            this.label16.TabIndex = 26;
            this.label16.Text = "Complemento";
            // 
            // cbUf
            // 
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUf.Location = new System.Drawing.Point(390, 302);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(60, 30);
            this.cbUf.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(338, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 22);
            this.label14.TabIndex = 24;
            this.label14.Text = "UF:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(103, 302);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(225, 28);
            this.txtBairro.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(12, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 22);
            this.label13.TabIndex = 22;
            this.label13.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(506, 249);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(386, 28);
            this.txtCidade.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(421, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Cidade:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(796, 303);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(96, 28);
            this.txtNumero.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(722, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Número:";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(103, 252);
            this.txtCep.Mask = "#####-###";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(142, 28);
            this.txtCep.TabIndex = 17;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(103, 198);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(382, 28);
            this.txtEndereco.TabIndex = 16;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(589, 201);
            this.txtTelefone.Mask = "(##)####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(178, 28);
            this.txtTelefone.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(103, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(382, 28);
            this.txtEmail.TabIndex = 14;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(562, 87);
            this.txtCnpj.Mask = "##.###.###/####-##";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(173, 28);
            this.txtCnpj.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(103, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(382, 28);
            this.txtNome.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(12, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "CEP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(11, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(501, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(502, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(498, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Celular:";
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
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(103, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(106, 28);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(589, 152);
            this.txtCelular.Mask = "(##)#####-####";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(178, 28);
            this.txtCelular.TabIndex = 0;
            // 
            // tabPgConsulta
            // 
            this.tabPgConsulta.Controls.Add(this.dgvPesqFornecedor);
            this.tabPgConsulta.Controls.Add(this.btPesquisar);
            this.tabPgConsulta.Controls.Add(this.txtPesquisa);
            this.tabPgConsulta.Controls.Add(this.label15);
            this.tabPgConsulta.Location = new System.Drawing.Point(4, 31);
            this.tabPgConsulta.Name = "tabPgConsulta";
            this.tabPgConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgConsulta.Size = new System.Drawing.Size(1037, 458);
            this.tabPgConsulta.TabIndex = 1;
            this.tabPgConsulta.Text = "Consulta";
            this.tabPgConsulta.UseVisualStyleBackColor = true;
            // 
            // dgvPesqFornecedor
            // 
            this.dgvPesqFornecedor.AllowUserToAddRows = false;
            this.dgvPesqFornecedor.AllowUserToDeleteRows = false;
            this.dgvPesqFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesqFornecedor.Location = new System.Drawing.Point(6, 100);
            this.dgvPesqFornecedor.Name = "dgvPesqFornecedor";
            this.dgvPesqFornecedor.ReadOnly = true;
            this.dgvPesqFornecedor.RowHeadersWidth = 51;
            this.dgvPesqFornecedor.RowTemplate.Height = 24;
            this.dgvPesqFornecedor.Size = new System.Drawing.Size(1025, 344);
            this.dgvPesqFornecedor.TabIndex = 14;
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
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(86, 41);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(382, 28);
            this.txtPesquisa.TabIndex = 13;
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
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btEditar.Location = new System.Drawing.Point(715, 685);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(154, 49);
            this.btEditar.TabIndex = 13;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btExcluir.Location = new System.Drawing.Point(543, 685);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(154, 49);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btNovo.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btNovo.Location = new System.Drawing.Point(196, 685);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(154, 49);
            this.btNovo.TabIndex = 11;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btSalvar.Location = new System.Drawing.Point(366, 685);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(154, 49);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 778);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tabFuncionario);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFuncionario.ResumeLayout(false);
            this.tabPgDadosPessoais.ResumeLayout(false);
            this.tabPgDadosPessoais.PerformLayout();
            this.tabPgConsulta.ResumeLayout(false);
            this.tabPgConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesqFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabFuncionario;
        private System.Windows.Forms.TabPage tabPgDadosPessoais;
        private System.Windows.Forms.Button btnCepPesquisar;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbUf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.TabPage tabPgConsulta;
        private System.Windows.Forms.DataGridView dgvPesqFornecedor;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btSalvar;
    }
}