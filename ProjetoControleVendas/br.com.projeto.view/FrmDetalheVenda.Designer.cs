namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmDetalheVenda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCleinte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDetalhe = new System.Windows.Forms.DataGridView();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalhe da Venda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 100);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCleinte);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(48, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 286);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Venda";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(24, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 22);
            this.label15.TabIndex = 16;
            this.label15.Text = "Data:";
            // 
            // txtCleinte
            // 
            this.txtCleinte.Location = new System.Drawing.Point(97, 60);
            this.txtCleinte.Name = "txtCleinte";
            this.txtCleinte.ReadOnly = true;
            this.txtCleinte.Size = new System.Drawing.Size(763, 28);
            this.txtCleinte.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(24, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Obs:";
            // 
            // dgvDetalhe
            // 
            this.dgvDetalhe.AllowUserToAddRows = false;
            this.dgvDetalhe.AllowUserToDeleteRows = false;
            this.dgvDetalhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalhe.Location = new System.Drawing.Point(58, 446);
            this.dgvDetalhe.Name = "dgvDetalhe";
            this.dgvDetalhe.ReadOnly = true;
            this.dgvDetalhe.RowHeadersWidth = 51;
            this.dgvDetalhe.RowTemplate.Height = 24;
            this.dgvDetalhe.Size = new System.Drawing.Size(871, 215);
            this.dgvDetalhe.TabIndex = 21;
            this.dgvDetalhe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(97, 126);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(195, 28);
            this.txtData.TabIndex = 21;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(97, 182);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ReadOnly = true;
            this.txtObs.Size = new System.Drawing.Size(763, 76);
            this.txtObs.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(315, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Total da Venda:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(482, 129);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(378, 28);
            this.txtTotal.TabIndex = 23;
            // 
            // FrmDetalheVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 718);
            this.Controls.Add(this.dgvDetalhe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDetalheVenda";
            this.Text = "FrmDetalheVenda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCleinte;
        private System.Windows.Forms.DataGridView dgvDetalhe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtData;
    }
}