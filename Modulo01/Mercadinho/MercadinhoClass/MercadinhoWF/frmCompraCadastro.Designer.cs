﻿namespace MercadinhoWF
{
    partial class frmCompraCadastro
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
            this.numQtde = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numTotal = new System.Windows.Forms.NumericUpDown();
            this.numValorCusto = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // numQtde
            // 
            this.numQtde.Location = new System.Drawing.Point(325, 214);
            this.numQtde.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQtde.Name = "numQtde";
            this.numQtde.Size = new System.Drawing.Size(120, 20);
            this.numQtde.TabIndex = 62;
            this.numQtde.ValueChanged += new System.EventHandler(this.numQtde_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Quantidade";
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(325, 185);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(259, 21);
            this.cbxProduto.TabIndex = 60;
            this.cbxProduto.SelectedValueChanged += new System.EventHandler(this.cbxProduto_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Produto";
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(325, 158);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(259, 21);
            this.cbxFornecedor.TabIndex = 58;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(325, 348);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 57;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(325, 128);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(84, 20);
            this.txtID.TabIndex = 54;
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Enabled = false;
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(325, 242);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(104, 20);
            this.dtpDataCompra.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Data da Venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Total";
            // 
            // numTotal
            // 
            this.numTotal.DecimalPlaces = 2;
            this.numTotal.Enabled = false;
            this.numTotal.Location = new System.Drawing.Point(325, 301);
            this.numTotal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numTotal.Name = "numTotal";
            this.numTotal.Size = new System.Drawing.Size(120, 20);
            this.numTotal.TabIndex = 73;
            // 
            // numValorCusto
            // 
            this.numValorCusto.DecimalPlaces = 2;
            this.numValorCusto.Enabled = false;
            this.numValorCusto.Location = new System.Drawing.Point(325, 273);
            this.numValorCusto.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numValorCusto.Name = "numValorCusto";
            this.numValorCusto.Size = new System.Drawing.Size(120, 20);
            this.numValorCusto.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Custo";
            // 
            // frmCompraCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numTotal);
            this.Controls.Add(this.numValorCusto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDataCompra);
            this.Controls.Add(this.numQtde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxFornecedor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Name = "frmCompraCadastro";
            this.Text = "Cadastro de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.numQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorCusto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numQtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTotal;
        private System.Windows.Forms.NumericUpDown numValorCusto;
        private System.Windows.Forms.Label label7;
    }
}