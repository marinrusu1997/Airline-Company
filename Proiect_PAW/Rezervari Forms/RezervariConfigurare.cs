using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Proiect_PAW.Rezervari_Forms
{
    public partial class RezervariConfigurare : Form
    {
        CompanieAeriana companie;
        public RezervariConfigurare(CompanieAeriana companie)
        {
            InitializeComponent();
            this.companie = companie;
            cbRuta.DataSource = companie.Rute.Keys.ToList();
            rezervareUserControl1.Enabled = false;
            btnModifica.Enabled = false;
            btnSterge.Enabled = false;
        }

        private void cbRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbRuta.SelectedItem != null)
            {
                btnModifica.Enabled = false;
                btnSterge.Enabled = false;
                rezervareUserControl1.Enabled = false;
                cbZbor.DataSource = null;
                cbPersoana.DataSource = null;
                tbRezervare.Text = default(string);
                cbData.DataSource = null;

                cbData.DataSource = companie.Rute[cbRuta.SelectedItem as RutaAeriana].Keys.ToList();
                try { cbData.SelectedIndex = 0; } catch { }
            }
        }

        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbData.SelectedItem != null)
            {
                btnModifica.Enabled = false;
                btnSterge.Enabled = false;
                rezervareUserControl1.Enabled = false;
                cbPersoana.DataSource = null;
                cbPersoana.Text = default(string);
                tbRezervare.Text = default(string);

                cbZbor.DataSource = companie.Rute[cbRuta.SelectedItem as RutaAeriana]
                        [(DateTime)cbData.SelectedItem].Keys.ToList();
                try { cbZbor.SelectedIndex = 0; } catch { }
            }
        }

        private void cbZbor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbZbor.SelectedItem != null)
            {
                btnModifica.Enabled = false;
                btnSterge.Enabled = false;
                rezervareUserControl1.Enabled = false;

                //cbPersoana.DataSource = Rute[cbRuta.SelectedItem as RutaAeriana]
                //    [(DateTime)cbData.SelectedItem][cbZbor.SelectedItem as Zbor].Keys.Cast<string>().ToList();

                var Rezervari = companie.Rute[cbRuta.SelectedItem as RutaAeriana]
                    [(DateTime)cbData.SelectedItem][cbZbor.SelectedItem as Zbor].Values;
                IList<Persoana> persoane = new List<Persoana>();
                foreach(Rezervare rezervare in Rezervari)
                {
                    persoane.Add(rezervare.Rezervant);
                }
                cbPersoana.DataSource = persoane;

                try { cbPersoana.SelectedIndex = 0; } catch { };  
                
            }
        }

        private void cbPersoana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPersoana.SelectedItem != null)
            {
                var rezervare = (Rezervare)companie.Rute[cbRuta.SelectedItem as RutaAeriana]
                    [(DateTime)cbData.SelectedItem][cbZbor.SelectedItem as Zbor][(string)(cbPersoana.SelectedItem as Persoana).CNP];

                tbRezervare.Text = rezervare.ToString();
                rezervareUserControl1.SetRezervare(rezervare);
                rezervareUserControl1.Enabled = true;
                btnModifica.Enabled = true;
                btnSterge.Enabled = true;
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Rezervare rezervareVeche = (Rezervare)companie.Rute[cbRuta.SelectedItem as RutaAeriana]
                    [(DateTime)cbData.SelectedItem][cbZbor.SelectedItem as Zbor]
                    [(string)(cbPersoana.SelectedItem as Persoana).CNP];
            if(rezervareUserControl1.RutaAeriana != null && rezervareUserControl1.Zbor != null)
            {
                if(companie.StergeRezervare(rezervareVeche) == true)
                {
                    companie.AdaugaRezervare(new Rezervare(rezervareUserControl1.RutaAeriana,
                        rezervareUserControl1.Zbor, rezervareUserControl1.NumarBilete,
                        rezervareVeche.Rezervant),out var sumaDePlata);
                    MessageBox.Show("Noua suma de plata este " + sumaDePlata);

                    try
                    {
                        var curentIndex = cbData.SelectedIndex;
                        var curentZbor = cbZbor.SelectedIndex;
                        cbData.SelectedIndex = 0;
                        cbData.SelectedIndex = curentIndex;
                        cbZbor.SelectedIndex = curentZbor;
                    } catch { }                   
                }               
            }
            rezervareUserControl1.ClearFields();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if(companie.StergeRezervare((Rezervare)companie.Rute[cbRuta.SelectedItem as RutaAeriana]
                    [(DateTime)cbData.SelectedItem][cbZbor.SelectedItem as Zbor]
                    [(string)(cbPersoana.SelectedItem as Persoana).CNP]))
            {
                try
                {
                    var curentIndex = cbData.SelectedIndex;
                    var curentZbor = cbZbor.SelectedIndex;
                    cbData.SelectedIndex = 0;
                    cbData.SelectedIndex = curentIndex;
                    cbZbor.SelectedIndex = curentZbor;
                }
                catch { }
            }
            rezervareUserControl1.ClearFields();
        }

        private void RezervariConfigurare_Load(object sender, EventArgs e)
        {

        }
    }
}
