using ecomm1_2A.classes;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecomm1_2A
{
    public partial class frmEditarCompra : Form
    {
        Compra compra;
        Contexto db;
        public frmEditarCompra(Compra compra)
        {
            InitializeComponent();

            this.compra = compra;
            this.db = new Contexto();

            cboStatus.Items.Add("FINALIZADO");
            cboStatus.Items.Add("PENDENTE");

            cboStatus.SelectedIndex = cboStatus.Items.IndexOf(compra.Status);

            txtTotal.Text = compra.Total?.ToString("F2") ?? "0.00";

            numAcrescimo.Value = (decimal)(compra.Acrescimo_total ?? 0);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            compra.Status = cboStatus.SelectedItem.ToString();
            compra.Acrescimo_total = (double)numAcrescimo.Value;

            if (decimal.TryParse(txtTotal.Text, out decimal total))
            {
                compra.Total = decimal.Round(total, 2);
                txtTotal.Text = compra.Total.Value.ToString("F2");
            }
            else
            {
                MessageBox.Show("Valor inválido para o total. Por favor, insira um valor válido.");
                return;
            }

            this.db.Compra.Update(compra);
            this.db.SaveChanges();
            MessageBox.Show("Sucesso!");
            this.Close();
        }
    }
}
