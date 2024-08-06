namespace WindowsFormsAppMercado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textProduto = new System.Windows.Forms.TextBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.textUnitario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bntnova = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.bntFechar = new System.Windows.Forms.Button();
            this.bntnovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "VR. Unitario";
            // 
            // textProduto
            // 
            this.textProduto.Location = new System.Drawing.Point(113, 33);
            this.textProduto.Multiline = true;
            this.textProduto.Name = "textProduto";
            this.textProduto.Size = new System.Drawing.Size(207, 21);
            this.textProduto.TabIndex = 3;
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 206);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(344, 251);
            this.lista.TabIndex = 4;
            // 
            // textQuantidade
            // 
            this.textQuantidade.Location = new System.Drawing.Point(113, 78);
            this.textQuantidade.Multiline = true;
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(207, 21);
            this.textQuantidade.TabIndex = 5;
            // 
            // textUnitario
            // 
            this.textUnitario.Location = new System.Drawing.Point(113, 126);
            this.textUnitario.Multiline = true;
            this.textUnitario.Name = "textUnitario";
            this.textUnitario.Size = new System.Drawing.Size(207, 21);
            this.textUnitario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gasto total";
            // 
            // bntnova
            // 
            this.bntnova.Location = new System.Drawing.Point(16, 530);
            this.bntnova.Name = "bntnova";
            this.bntnova.Size = new System.Drawing.Size(171, 23);
            this.bntnova.TabIndex = 9;
            this.bntnova.Text = "Nova compra";
            this.bntnova.UseVisualStyleBackColor = true;
            this.bntnova.Click += new System.EventHandler(this.bntnova_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(187, 483);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 13);
            this.lbltotal.TabIndex = 10;
            // 
            // bntFechar
            // 
            this.bntFechar.Location = new System.Drawing.Point(205, 530);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(171, 23);
            this.bntFechar.TabIndex = 11;
            this.bntFechar.Text = "Fechar";
            this.bntFechar.UseVisualStyleBackColor = true;
            this.bntFechar.Click += new System.EventHandler(this.bntFechar_Click);
            // 
            // bntnovo
            // 
            this.bntnovo.Location = new System.Drawing.Point(144, 165);
            this.bntnovo.Name = "bntnovo";
            this.bntnovo.Size = new System.Drawing.Size(141, 23);
            this.bntnovo.TabIndex = 12;
            this.bntnovo.Text = "Novo Produto";
            this.bntnovo.UseVisualStyleBackColor = true;
            this.bntnovo.Click += new System.EventHandler(this.bntnovo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 655);
            this.Controls.Add(this.bntnovo);
            this.Controls.Add(this.bntFechar);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.bntnova);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textUnitario);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.textProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textProduto;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.TextBox textUnitario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntnova;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button bntFechar;
        private System.Windows.Forms.Button bntnovo;
    }
}

