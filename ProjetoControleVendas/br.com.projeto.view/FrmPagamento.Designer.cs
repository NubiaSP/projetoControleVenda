namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmPagamento
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
            this.txtDinhei = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCartao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btTotal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(126, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 101);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pagamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 137);
            this.panel1.TabIndex = 2;
            // 
            // txtDinhei
            // 
            this.txtDinhei.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinhei.Location = new System.Drawing.Point(328, 186);
            this.txtDinhei.Name = "txtDinhei";
            this.txtDinhei.Size = new System.Drawing.Size(300, 56);
            this.txtDinhei.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(27, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 51);
            this.label7.TabIndex = 23;
            this.label7.Text = "Dinheiro (R$):";
            // 
            // txtCartao
            // 
            this.txtCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartao.Location = new System.Drawing.Point(328, 275);
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Size = new System.Drawing.Size(300, 56);
            this.txtCartao.TabIndex = 26;
            this.txtCartao.TextChanged += new System.EventHandler(this.txtCartao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(158, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 51);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cartão:";
            // 
            // txtTroco
            // 
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(328, 358);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(300, 56);
            this.txtTroco.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(176, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 51);
            this.label3.TabIndex = 27;
            this.label3.Text = "Troco:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(328, 442);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(300, 56);
            this.txtTotal.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(194, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 51);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total:";
            // 
            // btTotal
            // 
            this.btTotal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTotal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btTotal.Location = new System.Drawing.Point(65, 533);
            this.btTotal.Name = "btTotal";
            this.btTotal.Size = new System.Drawing.Size(605, 68);
            this.btTotal.TabIndex = 34;
            this.btTotal.Text = "Finalizar Venda";
            this.btTotal.UseVisualStyleBackColor = false;
            this.btTotal.Click += new System.EventHandler(this.btTotal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(634, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 51);
            this.label5.TabIndex = 35;
            this.label5.Text = "Obs:";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(754, 190);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(288, 318);
            this.txtObs.TabIndex = 36;
            // 
            // FrmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 628);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCartao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDinhei);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPagamento";
            this.Text = "Tela Pagamento";
            this.Load += new System.EventHandler(this.FrmPagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDinhei;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCartao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTotal;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
    }
}