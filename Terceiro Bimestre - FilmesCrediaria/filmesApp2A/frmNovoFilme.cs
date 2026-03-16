using filmesApp2A.Models;
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
    public partial class frmNovoFilme : Form
    {
        Contexto db;
        public frmNovoFilme(Contexto db)
        {
            InitializeComponent();

            this.db = db;

            List<Pais> paises = this.db.Pais.ToList();
            cbxPais.DataSource = paises;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Filme novo = new Filme();
            novo.Nome = txtNome.Text;
            novo.AnoLancamento = (int) numAno.Value;

            Pais pais = this.db.Pais
                  .Where(p => p.Nome == cbxPais.SelectedItem.ToString())
                  .First();

            novo.Nacionalidade = pais;

            this.db.Filme.Add(novo);
            this.db.SaveChanges();

            MessageBox.Show("Sucesso!");
            this.Close();
        }
    }
}
