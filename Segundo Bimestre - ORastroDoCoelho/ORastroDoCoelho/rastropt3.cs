using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORastroDoCoelho
{
    public partial class rastropt3 : Form
    {
        public rastropt3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        double calc(double a, double b)
        {
            return (a * b) / 100;
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            double mFinal = (double)numMFINAL.Value;
            double ConcC = (double)tbConc.Value;
            lblRes.Text = calc(mFinal, ConcC).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbConc_ValueChanged(object sender, EventArgs e)
        {
            lblConcVal.Text = tbConc.Value.ToString();
        }
    }
}
