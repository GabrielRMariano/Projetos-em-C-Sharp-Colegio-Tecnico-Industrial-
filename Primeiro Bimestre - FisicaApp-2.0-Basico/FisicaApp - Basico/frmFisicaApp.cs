namespace FisicaApp___Basico
{
    public partial class frmFisicaApp : Form
    {
        public frmFisicaApp()
        {
            InitializeComponent();
        }

        decimal velMediaCalc(decimal a, decimal b)
        {
            return a / b;
        }

        decimal acelCalc(decimal a, decimal b)
        {
            return a / b;
        }

        decimal muCalc(decimal a, decimal b, decimal c)
        {
            return a + (b * c);
        }

        decimal torricCalc(decimal a, decimal b, decimal c)
        {
            return (decimal)Math.Sqrt(Math.Pow((double)a, 2) + 2 * (double)(b * c));
        }

        private void btVelMedia_Click(object sender, EventArgs e)
        {
            decimal deltaS = numEntrada1.Value;
            decimal deltaT = numEntrada2.Value;
            if (deltaT == 0)
            {
                MessageBox.Show("Digite um valor válido para a entrada 2");
            }
            else
            {
                lblResultado.Text = velMediaCalc(deltaS, deltaT).ToString("0.00") + " m/s";
            }
        }

        private void btAcel_Click(object sender, EventArgs e)
        {
            decimal deltaV = numEntrada1.Value;
            decimal deltaT = numEntrada2.Value;
            if (deltaT == 0)
            {
                MessageBox.Show("Digite um valor válido para a entrada 2");
            }
            else
            {
                lblResultado.Text = velMediaCalc(deltaV, deltaT).ToString("0.00") + " m/s2";
            }
        }

        private void btMovUniforme_Click(object sender, EventArgs e)
        {
            decimal s0 = numEntrada1.Value;
            decimal v = numEntrada2.Value;
            decimal t = numEntrada3.Value;
            lblResultado.Text = muCalc(s0, v, t).ToString("0.00") + " m";
        }

        private void btTorricelli_Click(object sender, EventArgs e)
        {
            decimal v0 = numEntrada1.Value;
            decimal a = numEntrada2.Value;
            decimal deltaS = numEntrada3.Value;
            lblResultado.Text = torricCalc(v0, a, deltaS).ToString("0.00") + " m/s";
        }

        private void numEntrada3_ValueChanged(object sender, EventArgs e)
        {
            if (numEntrada1.Value > 0 && numEntrada2.Value > 0 && numEntrada3.Value == 0)
            {
                btAcel.Enabled = true;
                btVelMedia.Enabled = true;
            }
            else
            {
                btAcel.Enabled = false;
                btVelMedia.Enabled = false;
            }
        }
    }
}
