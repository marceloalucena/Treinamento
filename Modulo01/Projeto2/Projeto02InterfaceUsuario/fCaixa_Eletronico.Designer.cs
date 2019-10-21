namespace Projeto02InterfaceUsuario
{
    partial class FCaixa_Eletronico
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
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.tabCaixa = new System.Windows.Forms.TabControl();
            this.tpSaque = new System.Windows.Forms.TabPage();
            this.cbxBancoSaque = new System.Windows.Forms.ComboBox();
            this.tpDeposito = new System.Windows.Forms.TabPage();
            this.cbxBancoDeposito = new System.Windows.Forms.ComboBox();
            this.tpTransferencia = new System.Windows.Forms.TabPage();
            this.cbxBancoOrigem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAgenciaSaque = new System.Windows.Forms.TextBox();
            this.txtAgenciaDeposito = new System.Windows.Forms.TextBox();
            this.txtAgenciaOrigem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContaSaque = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtContaDeposito = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContaOrigem = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtContaDestino = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAgenciaDestino = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxBancoDestino = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnProcessarTransferencia = new System.Windows.Forms.Button();
            this.numValorTransferencia = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numValorDeposito = new System.Windows.Forms.NumericUpDown();
            this.btnProcessarDeposito = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.numValorSaque = new System.Windows.Forms.NumericUpDown();
            this.btnProcessarSaque = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabCaixa.SuspendLayout();
            this.tpSaque.SuspendLayout();
            this.tpDeposito.SuspendLayout();
            this.tpTransferencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(49, 29);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(125, 91);
            this.btnSaque.TabIndex = 0;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(49, 147);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(125, 91);
            this.btnDeposito.TabIndex = 1;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(49, 263);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(125, 91);
            this.btnTransferencia.TabIndex = 2;
            this.btnTransferencia.Text = "Transferência";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // tabCaixa
            // 
            this.tabCaixa.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCaixa.Controls.Add(this.tpSaque);
            this.tabCaixa.Controls.Add(this.tpDeposito);
            this.tabCaixa.Controls.Add(this.tpTransferencia);
            this.tabCaixa.ItemSize = new System.Drawing.Size(20, 20);
            this.tabCaixa.Location = new System.Drawing.Point(189, 29);
            this.tabCaixa.Name = "tabCaixa";
            this.tabCaixa.SelectedIndex = 0;
            this.tabCaixa.Size = new System.Drawing.Size(398, 325);
            this.tabCaixa.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCaixa.TabIndex = 3;
            // 
            // tpSaque
            // 
            this.tpSaque.Controls.Add(this.label22);
            this.tpSaque.Controls.Add(this.label19);
            this.tpSaque.Controls.Add(this.numValorSaque);
            this.tpSaque.Controls.Add(this.btnProcessarSaque);
            this.tpSaque.Controls.Add(this.label10);
            this.tpSaque.Controls.Add(this.txtContaSaque);
            this.tpSaque.Controls.Add(this.label9);
            this.tpSaque.Controls.Add(this.txtAgenciaSaque);
            this.tpSaque.Controls.Add(this.label6);
            this.tpSaque.Controls.Add(this.label1);
            this.tpSaque.Controls.Add(this.cbxBancoSaque);
            this.tpSaque.Location = new System.Drawing.Point(4, 24);
            this.tpSaque.Name = "tpSaque";
            this.tpSaque.Padding = new System.Windows.Forms.Padding(3);
            this.tpSaque.Size = new System.Drawing.Size(390, 297);
            this.tpSaque.TabIndex = 0;
            this.tpSaque.Text = "Sq";
            this.tpSaque.UseVisualStyleBackColor = true;
            // 
            // cbxBancoSaque
            // 
            this.cbxBancoSaque.FormattingEnabled = true;
            this.cbxBancoSaque.Location = new System.Drawing.Point(87, 70);
            this.cbxBancoSaque.Name = "cbxBancoSaque";
            this.cbxBancoSaque.Size = new System.Drawing.Size(259, 21);
            this.cbxBancoSaque.TabIndex = 2;
            // 
            // tpDeposito
            // 
            this.tpDeposito.Controls.Add(this.label21);
            this.tpDeposito.Controls.Add(this.label18);
            this.tpDeposito.Controls.Add(this.numValorDeposito);
            this.tpDeposito.Controls.Add(this.btnProcessarDeposito);
            this.tpDeposito.Controls.Add(this.label11);
            this.tpDeposito.Controls.Add(this.txtContaDeposito);
            this.tpDeposito.Controls.Add(this.label8);
            this.tpDeposito.Controls.Add(this.txtAgenciaDeposito);
            this.tpDeposito.Controls.Add(this.label5);
            this.tpDeposito.Controls.Add(this.label2);
            this.tpDeposito.Controls.Add(this.cbxBancoDeposito);
            this.tpDeposito.Location = new System.Drawing.Point(4, 24);
            this.tpDeposito.Name = "tpDeposito";
            this.tpDeposito.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeposito.Size = new System.Drawing.Size(390, 297);
            this.tpDeposito.TabIndex = 1;
            this.tpDeposito.Text = "Dp";
            this.tpDeposito.UseVisualStyleBackColor = true;
            // 
            // cbxBancoDeposito
            // 
            this.cbxBancoDeposito.FormattingEnabled = true;
            this.cbxBancoDeposito.Location = new System.Drawing.Point(87, 70);
            this.cbxBancoDeposito.Name = "cbxBancoDeposito";
            this.cbxBancoDeposito.Size = new System.Drawing.Size(259, 21);
            this.cbxBancoDeposito.TabIndex = 3;
            // 
            // tpTransferencia
            // 
            this.tpTransferencia.Controls.Add(this.label20);
            this.tpTransferencia.Controls.Add(this.label17);
            this.tpTransferencia.Controls.Add(this.numValorTransferencia);
            this.tpTransferencia.Controls.Add(this.btnProcessarTransferencia);
            this.tpTransferencia.Controls.Add(this.label16);
            this.tpTransferencia.Controls.Add(this.label13);
            this.tpTransferencia.Controls.Add(this.txtContaDestino);
            this.tpTransferencia.Controls.Add(this.label14);
            this.tpTransferencia.Controls.Add(this.txtAgenciaDestino);
            this.tpTransferencia.Controls.Add(this.label15);
            this.tpTransferencia.Controls.Add(this.cbxBancoDestino);
            this.tpTransferencia.Controls.Add(this.label12);
            this.tpTransferencia.Controls.Add(this.txtContaOrigem);
            this.tpTransferencia.Controls.Add(this.label7);
            this.tpTransferencia.Controls.Add(this.txtAgenciaOrigem);
            this.tpTransferencia.Controls.Add(this.label4);
            this.tpTransferencia.Controls.Add(this.label3);
            this.tpTransferencia.Controls.Add(this.cbxBancoOrigem);
            this.tpTransferencia.Location = new System.Drawing.Point(4, 24);
            this.tpTransferencia.Name = "tpTransferencia";
            this.tpTransferencia.Padding = new System.Windows.Forms.Padding(3);
            this.tpTransferencia.Size = new System.Drawing.Size(390, 297);
            this.tpTransferencia.TabIndex = 2;
            this.tpTransferencia.Text = "Tr";
            this.tpTransferencia.UseVisualStyleBackColor = true;
            // 
            // cbxBancoOrigem
            // 
            this.cbxBancoOrigem.FormattingEnabled = true;
            this.cbxBancoOrigem.Location = new System.Drawing.Point(87, 70);
            this.cbxBancoOrigem.Name = "cbxBancoOrigem";
            this.cbxBancoOrigem.Size = new System.Drawing.Size(259, 21);
            this.cbxBancoOrigem.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Banco";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Sienna;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transferência";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Depósito";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SeaGreen;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "Saque";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAgenciaSaque
            // 
            this.txtAgenciaSaque.Location = new System.Drawing.Point(87, 97);
            this.txtAgenciaSaque.Name = "txtAgenciaSaque";
            this.txtAgenciaSaque.Size = new System.Drawing.Size(259, 20);
            this.txtAgenciaSaque.TabIndex = 8;
            // 
            // txtAgenciaDeposito
            // 
            this.txtAgenciaDeposito.Location = new System.Drawing.Point(87, 97);
            this.txtAgenciaDeposito.Name = "txtAgenciaDeposito";
            this.txtAgenciaDeposito.Size = new System.Drawing.Size(259, 20);
            this.txtAgenciaDeposito.TabIndex = 9;
            // 
            // txtAgenciaOrigem
            // 
            this.txtAgenciaOrigem.Location = new System.Drawing.Point(87, 97);
            this.txtAgenciaOrigem.Name = "txtAgenciaOrigem";
            this.txtAgenciaOrigem.Size = new System.Drawing.Size(259, 20);
            this.txtAgenciaOrigem.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Agência";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Agência";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Agência";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Conta";
            // 
            // txtContaSaque
            // 
            this.txtContaSaque.Location = new System.Drawing.Point(87, 123);
            this.txtContaSaque.Name = "txtContaSaque";
            this.txtContaSaque.Size = new System.Drawing.Size(259, 20);
            this.txtContaSaque.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Conta";
            // 
            // txtContaDeposito
            // 
            this.txtContaDeposito.Location = new System.Drawing.Point(87, 123);
            this.txtContaDeposito.Name = "txtContaDeposito";
            this.txtContaDeposito.Size = new System.Drawing.Size(259, 20);
            this.txtContaDeposito.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Conta";
            // 
            // txtContaOrigem
            // 
            this.txtContaOrigem.Location = new System.Drawing.Point(87, 123);
            this.txtContaOrigem.Name = "txtContaOrigem";
            this.txtContaOrigem.Size = new System.Drawing.Size(259, 20);
            this.txtContaOrigem.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Conta";
            // 
            // txtContaDestino
            // 
            this.txtContaDestino.Location = new System.Drawing.Point(87, 228);
            this.txtContaDestino.Name = "txtContaDestino";
            this.txtContaDestino.Size = new System.Drawing.Size(259, 20);
            this.txtContaDestino.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Agência";
            // 
            // txtAgenciaDestino
            // 
            this.txtAgenciaDestino.Location = new System.Drawing.Point(87, 202);
            this.txtAgenciaDestino.Name = "txtAgenciaDestino";
            this.txtAgenciaDestino.Size = new System.Drawing.Size(259, 20);
            this.txtAgenciaDestino.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Banco";
            // 
            // cbxBancoDestino
            // 
            this.cbxBancoDestino.FormattingEnabled = true;
            this.cbxBancoDestino.Location = new System.Drawing.Point(87, 175);
            this.cbxBancoDestino.Name = "cbxBancoDestino";
            this.cbxBancoDestino.Size = new System.Drawing.Size(259, 21);
            this.cbxBancoDestino.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Sienna;
            this.label16.Location = new System.Drawing.Point(0, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(384, 18);
            this.label16.TabIndex = 19;
            this.label16.Text = "Conta Destino";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProcessarTransferencia
            // 
            this.btnProcessarTransferencia.Location = new System.Drawing.Point(239, 254);
            this.btnProcessarTransferencia.Name = "btnProcessarTransferencia";
            this.btnProcessarTransferencia.Size = new System.Drawing.Size(107, 22);
            this.btnProcessarTransferencia.TabIndex = 20;
            this.btnProcessarTransferencia.Text = "Processar";
            this.btnProcessarTransferencia.UseVisualStyleBackColor = true;
            this.btnProcessarTransferencia.Click += new System.EventHandler(this.btnProcessarTransferencia_Click);
            // 
            // numValorTransferencia
            // 
            this.numValorTransferencia.Location = new System.Drawing.Point(87, 256);
            this.numValorTransferencia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numValorTransferencia.Name = "numValorTransferencia";
            this.numValorTransferencia.Size = new System.Drawing.Size(120, 20);
            this.numValorTransferencia.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 259);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Valor";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 154);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 54;
            this.label18.Text = "Valor";
            // 
            // numValorDeposito
            // 
            this.numValorDeposito.Location = new System.Drawing.Point(87, 151);
            this.numValorDeposito.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numValorDeposito.Name = "numValorDeposito";
            this.numValorDeposito.Size = new System.Drawing.Size(120, 20);
            this.numValorDeposito.TabIndex = 53;
            // 
            // btnProcessarDeposito
            // 
            this.btnProcessarDeposito.Location = new System.Drawing.Point(239, 149);
            this.btnProcessarDeposito.Name = "btnProcessarDeposito";
            this.btnProcessarDeposito.Size = new System.Drawing.Size(107, 22);
            this.btnProcessarDeposito.TabIndex = 52;
            this.btnProcessarDeposito.Text = "Processar";
            this.btnProcessarDeposito.UseVisualStyleBackColor = true;
            this.btnProcessarDeposito.Click += new System.EventHandler(this.btnProcessarDeposito_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "Valor";
            // 
            // numValorSaque
            // 
            this.numValorSaque.Location = new System.Drawing.Point(87, 151);
            this.numValorSaque.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numValorSaque.Name = "numValorSaque";
            this.numValorSaque.Size = new System.Drawing.Size(120, 20);
            this.numValorSaque.TabIndex = 53;
            // 
            // btnProcessarSaque
            // 
            this.btnProcessarSaque.Location = new System.Drawing.Point(239, 149);
            this.btnProcessarSaque.Name = "btnProcessarSaque";
            this.btnProcessarSaque.Size = new System.Drawing.Size(107, 22);
            this.btnProcessarSaque.TabIndex = 52;
            this.btnProcessarSaque.Text = "Processar";
            this.btnProcessarSaque.UseVisualStyleBackColor = true;
            this.btnProcessarSaque.Click += new System.EventHandler(this.btnProcessarSaque_Click);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Sienna;
            this.label20.Location = new System.Drawing.Point(3, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(384, 18);
            this.label20.TabIndex = 52;
            this.label20.Text = "Conta Origem";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.SteelBlue;
            this.label21.Location = new System.Drawing.Point(3, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(384, 18);
            this.label21.TabIndex = 55;
            this.label21.Text = "Conta";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.SeaGreen;
            this.label22.Location = new System.Drawing.Point(3, 39);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(384, 18);
            this.label22.TabIndex = 55;
            this.label22.Text = "Conta";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FCaixa_Eletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 496);
            this.Controls.Add(this.tabCaixa);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnSaque);
            this.Name = "FCaixa_Eletronico";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FCaixa_Eletronico_Load);
            this.tabCaixa.ResumeLayout(false);
            this.tpSaque.ResumeLayout(false);
            this.tpSaque.PerformLayout();
            this.tpDeposito.ResumeLayout(false);
            this.tpDeposito.PerformLayout();
            this.tpTransferencia.ResumeLayout(false);
            this.tpTransferencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorSaque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.TabControl tabCaixa;
        private System.Windows.Forms.TabPage tpSaque;
        private System.Windows.Forms.TabPage tpDeposito;
        private System.Windows.Forms.ComboBox cbxBancoSaque;
        private System.Windows.Forms.ComboBox cbxBancoDeposito;
        private System.Windows.Forms.TabPage tpTransferencia;
        private System.Windows.Forms.ComboBox cbxBancoOrigem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContaSaque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAgenciaSaque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtContaDeposito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAgenciaDeposito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtContaOrigem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAgenciaOrigem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcessarTransferencia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtContaDestino;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAgenciaDestino;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxBancoDestino;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numValorTransferencia;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numValorSaque;
        private System.Windows.Forms.Button btnProcessarSaque;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numValorDeposito;
        private System.Windows.Forms.Button btnProcessarDeposito;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
    }
}