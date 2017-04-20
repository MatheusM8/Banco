using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoBdOO
{
    public partial class FrmEditConta : Form
    {
        decimal saldoAnterior;
        DBConnection conexao;
        string cmd = "";
        public Conta conta;
        public Menu instanciaPai;
        public FrmEditConta(Form p)
        {
            InitializeComponent();
            if (p.GetType() == typeof(Menu))
            {
                instanciaPai = (Menu)p;
                AtivaCampos();
            }
        }

        public FrmEditConta(Conta c, Form p)
        {
            InitializeComponent();
            if(p.GetType() == typeof(Menu))
            {
                instanciaPai = (Menu)p;
            }
            conta = c;
        }

        public void AtivaCampos()
        {
            txtAgencia.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtSaldo.ReadOnly = false;
            rBtnCorrente.Enabled = true;
            rBtnPoupanca.Enabled = true;
        }
        

        private void FrmEditConta_Load(object sender, EventArgs e)
        {
            if(conta != null)
            {
                txtAgencia.Text = conta.Agencia;
                txtNumero.Text = conta.Numero;
                txtSaldo.Text = conta.Saldo.ToString();
                if (conta.Tipo.Equals("C"))
                {
                    rBtnCorrente.Checked = true;
                    conta = conta as ContaCorrente;
                }
                else
                {
                    rBtnPoupanca.Checked = true;
                    conta = conta as ContaPoupanca;
                    txtLimite.Text = "1000,00";
                }
            }
            conexao = new DBConnection();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(conta == null && cmd == "")
            {
                conta = new Conta();
                cmd = "Insert";
            }
            else
            {
                cmd = "Update";
            }

            conta.Numero = txtNumero.Text;
            conta.Agencia = txtAgencia.Text;

            if (rBtnCorrente.Checked)
            {
                conta.Tipo = "C";
            }else
            {
                conta.Tipo = "P";
            }

            conta.Saldo = Convert.ToDecimal(txtSaldo.Text);

            if(cmd == "Insert")
            {

                if (!conexao.Inserir(conta))
                {
                    MessageBox.Show("Conta ja existente");
                }
            }
            else if(cmd == "Update")
            {
                conexao.Alterar(conta);
            }
            instanciaPai.UpdateGrid();
            instanciaPai.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if(conta.Saldo >= Convert.ToDecimal(txtValorSaque.Text))
            {
                if (conta.Tipo.Equals("C"))
                {
                    ((conta) as ContaCorrente).Sacar(Convert.ToDecimal(txtValorSaque.Text));
                    MessageBox.Show("Para confirmar o Saque, Clique em Salvar");
                }
                else
                {
                    if(!((conta) as ContaPoupanca).Sacar(Convert.ToDecimal(txtValorSaque.Text)))
                    {
                        MessageBox.Show("Valor Acima do Limite (R$ 1000,00)");                  
                    }
                    else
                    {
                        MessageBox.Show("Para confirmar o Saque, Clique em Salvar");
                    }
                }
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
            txtSaldo.Text = conta.Saldo.ToString();
            cmd = "Update";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            AtivaCampos();
            cmd = "Update";
        }

        private void txtValorSaque_TextChanged(object sender, EventArgs e)
        {
            decimal taxa = 0.10M;
            if(txtSaldo.Text!="" && txtValorSaque.Text!="")
            {
                if(conta.Tipo.Equals("C"))
                {
                    taxa = 0.20M;
                }
                txtSaldoAposSaque.Text = (Convert.ToDecimal(txtSaldo.Text) - Convert.ToDecimal(txtValorSaque.Text) - taxa).ToString();
                btnSacar.Enabled = true;
            }
            else
            {
                txtSaldoAposSaque.Text = "";
                btnSacar.Enabled = false;
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (conta.Depositar(Convert.ToDecimal(txtValorDeposito.Text)))
            {
                MessageBox.Show("Para confirmar o Depósito, Clique em Salvar");
                txtSaldo.Text = conta.Saldo.ToString();
                cmd = "Update";
            }
            else
            {
                MessageBox.Show("Valor Inválido");
            } 
        }

        private void txtValorDeposito_TextChanged(object sender, EventArgs e)
        {
            if (txtValorDeposito.Text != "")
            {
                btnDepositar.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtSaldo.Text != "" && txtTransferencia.Text != "")
            {
                txtSaldoAposTransf.Text = (Convert.ToDecimal(txtSaldo.Text) - Convert.ToDecimal(txtTransferencia.Text)).ToString();
                btnExecutarTrasf.Enabled = true;
            }
            else
            {
                txtSaldoAposTransf.Text = "";
                btnExecutarTrasf.Enabled = false;
            }
        }

        private void btnExecutarTrasf_Click(object sender, EventArgs e)
        {
            if (conta.Saldo >= Convert.ToDecimal(txtTransferencia.Text))
            {
                conta.Debita(Convert.ToDecimal(txtTransferencia.Text));
                Conta contaTransf = new Conta();
                contaTransf = conexao.Buscar(txtNumContaTransf.Text);
                contaTransf.Depositar(Convert.ToDecimal(txtTransferencia.Text));

                conexao.Alterar(contaTransf);
                conexao.Alterar(conta);

                MessageBox.Show("Transferencia Realizada Com Sucesso");
                instanciaPai.UpdateGrid();
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
            txtSaldo.Text = conta.Saldo.ToString();
        }
    }
}
