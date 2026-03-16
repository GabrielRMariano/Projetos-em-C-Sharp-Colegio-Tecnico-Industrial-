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
    public partial class rastropt2 : Form
    {
        public rastropt2()
        {
            InitializeComponent();
        }

        double calcCpK(double a)
        {
            return a + 273;
        }

        double calcCpF(double a)
        {
            return (a*1.8) + 32;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double tempC = (double)numTempCelsius.Value;
            lblCelpKelvin.Text = calcCpK(tempC).ToString();
            lblCelpFar.Text = calcCpF(tempC).ToString();
            rastropt3 rastropt3 = new rastropt3();
            rastropt3.Show();
        }
    }
}
