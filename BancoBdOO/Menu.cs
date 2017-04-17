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
    public partial class Menu : Form
    {
        DBConnection conexao = new DBConnection();
        public List<Conta> Contas { get; set; }
        BindingList<Conta> binListContas;
        BindingSource bSourceContas;

        public Menu()
        {
            Contas = new List<Conta>();
            InitializeComponent();
        }

        public void UpdateGrid()
        {
            conexao = new DBConnection();
            Contas = conexao.GetAll();

            binListContas = new BindingList<Conta>(Contas);
            bSourceContas = new BindingSource(binListContas, null);
            dataGridView1.DataSource = bSourceContas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Form frmNovaConta = new FrmEditConta(this);
            frmNovaConta.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (conexao.Deletar(dataGridView1.SelectedRows[0].DataBoundItem as Conta))
            {
                UpdateGrid();
            }
        }

        public Conta AcessarConta()
        {
            return dataGridView1.SelectedRows[0].DataBoundItem as Conta;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FrmEditConta frmEdit = new FrmEditConta(AcessarConta(), this);
            frmEdit.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AcessarConta();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmEditConta frmEdit = new FrmEditConta(AcessarConta(), this);
            frmEdit.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            FrmEditConta frmEdit = new FrmEditConta(AcessarConta(), this);
            frmEdit.Show();
        }
    }
}
