namespace BancoBdOO
{
    partial class FrmEditConta
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
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rBtnPoupanca = new System.Windows.Forms.RadioButton();
            this.rBtnCorrente = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaldoAposSaque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorSaque = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumContaTransf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnExecutarTrasf = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agencia";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(72, 25);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.ReadOnly = true;
            this.txtAgencia.Size = new System.Drawing.Size(74, 20);
            this.txtAgencia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(72, 143);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo";
            // 
            // rBtnPoupanca
            // 
            this.rBtnPoupanca.AutoSize = true;
            this.rBtnPoupanca.Enabled = false;
            this.rBtnPoupanca.Location = new System.Drawing.Point(72, 105);
            this.rBtnPoupanca.Name = "rBtnPoupanca";
            this.rBtnPoupanca.Size = new System.Drawing.Size(74, 17);
            this.rBtnPoupanca.TabIndex = 7;
            this.rBtnPoupanca.TabStop = true;
            this.rBtnPoupanca.Text = "Poupança";
            this.rBtnPoupanca.UseVisualStyleBackColor = true;
            // 
            // rBtnCorrente
            // 
            this.rBtnCorrente.AutoSize = true;
            this.rBtnCorrente.Enabled = false;
            this.rBtnCorrente.Location = new System.Drawing.Point(163, 105);
            this.rBtnCorrente.Name = "rBtnCorrente";
            this.rBtnCorrente.Size = new System.Drawing.Size(65, 17);
            this.rBtnCorrente.TabIndex = 8;
            this.rBtnCorrente.TabStop = true;
            this.rBtnCorrente.Text = "Corrente";
            this.rBtnCorrente.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(21, 317);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(72, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero";
            // 
            // btnSacar
            // 
            this.btnSacar.Enabled = false;
            this.btnSacar.Location = new System.Drawing.Point(157, 68);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 13;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(21, 186);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(265, 125);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtLimite);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtSaldoAposSaque);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtValorSaque);
            this.tabPage2.Controls.Add(this.btnSacar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(257, 99);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saque";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(145, 28);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.ReadOnly = true;
            this.txtLimite.Size = new System.Drawing.Size(98, 20);
            this.txtLimite.TabIndex = 19;
            this.txtLimite.Text = "------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Limite";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Saldo Após Saque";
            // 
            // txtSaldoAposSaque
            // 
            this.txtSaldoAposSaque.Location = new System.Drawing.Point(15, 70);
            this.txtSaldoAposSaque.Name = "txtSaldoAposSaque";
            this.txtSaldoAposSaque.ReadOnly = true;
            this.txtSaldoAposSaque.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoAposSaque.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor Saque";
            // 
            // txtValorSaque
            // 
            this.txtValorSaque.Location = new System.Drawing.Point(15, 28);
            this.txtValorSaque.Name = "txtValorSaque";
            this.txtValorSaque.Size = new System.Drawing.Size(100, 20);
            this.txtValorSaque.TabIndex = 14;
            this.txtValorSaque.TextChanged += new System.EventHandler(this.txtValorSaque_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtNumContaTransf);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.btnExecutarTrasf);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(257, 99);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transferência";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nº Conta";
            // 
            // txtNumContaTransf
            // 
            this.txtNumContaTransf.Location = new System.Drawing.Point(143, 26);
            this.txtNumContaTransf.Name = "txtNumContaTransf";
            this.txtNumContaTransf.ReadOnly = true;
            this.txtNumContaTransf.Size = new System.Drawing.Size(100, 20);
            this.txtNumContaTransf.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Saldo Após Trasf.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Valor Transf.";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 21;
            // 
            // btnExecutarTrasf
            // 
            this.btnExecutarTrasf.Location = new System.Drawing.Point(152, 66);
            this.btnExecutarTrasf.Name = "btnExecutarTrasf";
            this.btnExecutarTrasf.Size = new System.Drawing.Size(75, 23);
            this.btnExecutarTrasf.TabIndex = 20;
            this.btnExecutarTrasf.Text = "Transferir";
            this.btnExecutarTrasf.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(207, 317);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 15;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(114, 317);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // FrmEditConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 352);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.rBtnPoupanca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rBtnCorrente);
            this.Name = "FrmEditConta";
            this.Text = "FrmEditConta";
            this.Load += new System.EventHandler(this.FrmEditConta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rBtnPoupanca;
        private System.Windows.Forms.RadioButton rBtnCorrente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaldoAposSaque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorSaque;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumContaTransf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnExecutarTrasf;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnEditar;
    }
}