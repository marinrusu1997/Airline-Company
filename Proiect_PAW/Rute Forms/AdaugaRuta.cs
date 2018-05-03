using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class AdaugaRuta : Form
    {
        CompanieAeriana companie;
        public AdaugaRuta(CompanieAeriana companie)
        {
            InitializeComponent();
            this.companie = companie;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            RutaAeriana ruta = dateRutaUsrControl1.GetRutaAeriana();
            if(ruta == null)
            {
                MessageBox.Show("Selectați două aeroporturi valide", "Rută Invalidă",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (companie.AdaugaRuta(ruta) == false)
                    MessageBox.Show("Această rută există deja", "Eroare la adăugarea rutei",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
