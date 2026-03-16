using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp2A
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btAtores_Click(object sender, EventArgs e)
        {
            frmAtores f = new frmAtores(this);
            f.Show();
            this.Hide();
        }

        private void btFilmes_Click(object sender, EventArgs e)
        {
            frmFilmes f = new frmFilmes(this);
            f.Show();
            this.Hide();

        }
    }
}
