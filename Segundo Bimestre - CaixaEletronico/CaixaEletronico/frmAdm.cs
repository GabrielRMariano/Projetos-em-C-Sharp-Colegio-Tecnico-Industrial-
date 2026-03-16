using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaEletronico.Classes;


namespace CaixaEletronico
{
    public partial class frmAdm : Form
    {
        private Singleton s;
        public frmAdm()
        {
            InitializeComponent();
        }

        private void frmAdm_Load(object sender, EventArgs e)
        {
            s = Singleton.Instance;

            Recarregar();
            LimparCampos();
        }
        public void Recarregar()
        {
            var data = new BindingSource();
            data.DataSource = s.contas;
            dgvContas.DataSource = data;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            frmInicial f = new frmInicial();
            f.Show();
            this.Close();
        }

        private void btCadastar_Click(object sender, EventArgs e)
        {
            string numero = txtNum.Text;
            Conta c = s.contas.Find(conta => conta.Numero == numero);
            if(c == null)
            {
                MessageBox.Show("Conta já cadastrada!");
            }
            else
            {
                if(cbxTipo.SelectedIndex == 0)
                {
                    CCorrente conta = new CCorrente(numero, (double) numLimite.Value);
                    s.contas.Add(conta);
                }
                else
                {
                    CPoupanca conta = new CPoupanca(numero);
                    s.contas.Add(conta);
                }
                MessageBox.Show("Conta cadastrada com sucesso!");
                Recarregar();
                LimparCampos();
            }
        }

        public void LimparCampos()
        {
            txtNum.Text = "";
            cbxTipo.SelectedIndex = -1;
            numLimite.Value = 0;
            numSaldo.Value = 0;
            chbEspecial.Checked = false;
            chbStatus.Checked = false;
            btSalvar.Enabled = false;
            btExcluir.Enabled = false;
        }
    }
}
