namespace Projeto02InterfaceUsuario
{
    partial class fCad_Conta
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContaCorrente = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.numSaldo = new System.Windows.Forms.NumericUpDown();
            this.numLimite = new System.Windows.Forms.NumericUpDown();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxBanco = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Limite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Agencia";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(317, 207);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(274, 20);
            this.txtAgencia.TabIndex = 43;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(317, 326);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 42;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "ContaCorrente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID";
            // 
            // txtContaCorrente
            // 
            this.txtContaCorrente.Location = new System.Drawing.Point(317, 233);
            this.txtContaCorrente.Name = "txtContaCorrente";
            this.txtContaCorrente.Size = new System.Drawing.Size(274, 20);
            this.txtContaCorrente.TabIndex = 39;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(317, 128);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(84, 20);
            this.txtID.TabIndex = 38;
            // 
            // numSaldo
            // 
            this.numSaldo.DecimalPlaces = 2;
            this.numSaldo.Location = new System.Drawing.Point(317, 259);
            this.numSaldo.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numSaldo.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.numSaldo.Name = "numSaldo";
            this.numSaldo.Size = new System.Drawing.Size(120, 20);
            this.numSaldo.TabIndex = 49;
            this.numSaldo.ThousandsSeparator = true;
            // 
            // numLimite
            // 
            this.numLimite.DecimalPlaces = 2;
            this.numLimite.Location = new System.Drawing.Point(317, 286);
            this.numLimite.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numLimite.Name = "numLimite";
            this.numLimite.Size = new System.Drawing.Size(120, 20);
            this.numLimite.TabIndex = 50;
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(317, 154);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(274, 21);
            this.cbxCliente.TabIndex = 51;
            // 
            // cbxBanco
            // 
            this.cbxBanco.FormattingEnabled = true;
            this.cbxBanco.Location = new System.Drawing.Point(317, 181);
            this.cbxBanco.Name = "cbxBanco";
            this.cbxBanco.Size = new System.Drawing.Size(274, 21);
            this.cbxBanco.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Banco";
            // 
            // fCad_Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxBanco);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.numLimite);
            this.Controls.Add(this.numSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContaCorrente);
            this.Controls.Add(this.txtID);
            this.Name = "fCad_Conta";
            this.Text = "Cadastro de Contas";
            this.Load += new System.EventHandler(this.fCad_Conta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContaCorrente;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.NumericUpDown numSaldo;
        private System.Windows.Forms.NumericUpDown numLimite;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxBanco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}