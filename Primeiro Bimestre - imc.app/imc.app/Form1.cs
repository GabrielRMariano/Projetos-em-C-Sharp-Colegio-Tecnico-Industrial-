using System.Diagnostics.Eventing.Reader;

namespace imc.app
{
    public partial class Aplicativo : Form
    {
        public Aplicativo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        decimal Imc(decimal p, decimal h)
        {
            if (h == 0 || p == 0)
                return 0;
            return p / (h * h);
        }

        string Classificacao(decimal imc)
        {
            double i = (double)imc;
            if (imc == 0)
                return "Você não existe";
            if (i < 18.6) 
                return "Abaixo do peso";
            if (i < 25)
                return "Peso ideal";
            if (i < 30)
                return "Levemenete acima do peso";
            if (i < 35)
                return "Obesidade grau I";
            if (i < 40)
                return "Obesidade grau II";
            return "Obesidade grau III";
        }

        private void btCalcImc_Click(object sender, EventArgs e)
        {
            decimal peso, altura;
            peso = numPeso.Value;
            altura = numAltura.Value;
            decimal imc = Imc(peso, altura);
            lbCalc.Text = imc.ToString();
            lbClass.Text = Classificacao(imc);
        }

        private void numAltura_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numPeso_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
