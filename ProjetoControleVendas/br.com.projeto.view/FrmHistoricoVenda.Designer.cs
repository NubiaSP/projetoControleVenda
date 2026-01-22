namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmHistoricoVenda
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
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.btPesquisarDt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Histórico de Venda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 100);
            this.panel1.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(28, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 28);
            this.label15.TabIndex = 16;
            this.label15.Text = "Data Inicio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btPesquisarDt);
            this.groupBox1.Controls.Add(this.dtInicio);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(128, 39);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(132, 28);
            this.dtInicio.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(324, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Data Fim:";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFim.Location = new System.Drawing.Point(417, 36);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(132, 28);
            this.dtFim.TabIndex = 18;
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(12, 234);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.RowHeadersWidth = 51;
            this.dgvHistorico.RowTemplate.Height = 24;
            this.dgvHistorico.Size = new System.Drawing.Size(1083, 373);
            this.dgvHistorico.TabIndex = 20;
            this.dgvHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_CellContentClick);
            // 
            // btPesquisarDt
            // 
            this.btPesquisarDt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btPesquisarDt.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarDt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btPesquisarDt.Location = new System.Drawing.Point(922, 36);
            this.btPesquisarDt.Name = "btPesquisarDt";
            this.btPesquisarDt.Size = new System.Drawing.Size(136, 37);
            this.btPesquisarDt.TabIndex = 18;
            this.btPesquisarDt.Text = "Pesquisar";
            this.btPesquisarDt.UseVisualStyleBackColor = false;
            this.btPesquisarDt.Click += new System.EventHandler(this.btPesquisarDt_Click);
            // 
            // FrmHistoricoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 619);
            this.Controls.Add(this.dgvHistorico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHistoricoVenda";
            this.Text = "Historico Venda";
            this.Load += new System.EventHandler(this.FrmHistoricoVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPesquisarDt;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DataGridView dgvHistorico;
    }
}