using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Data.SqlClient;

using Proiect_PAW.Rezervari_Forms;

namespace Proiect_PAW
{
    public partial class MainWindow : Form
    {
        CompanieAeriana AirMoldova;
        IList<Aeroport> aeroports = new List<Aeroport>();
        public MainWindow()
        {
            InitializeComponent();
            CompanieAeriana.NumeFisierSerializare = "AirMoldova.txt";
            if (File.Exists(@"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\bin\Debug\" + CompanieAeriana.NumeFisierSerializare))
            {
                AirMoldova = CompanieAeriana.Deserialize();
            }
            else
            {
                AirMoldova = new CompanieAeriana("Air", "Chisinau", "0789856356", "air@moldova.md");
            }
            ThreadPool.SetMaxThreads(3,3);
            ThreadPool.QueueUserWorkItem( obj => { Aeroport.LoadAeroporturi(); });
            ThreadPool.QueueUserWorkItem(obj => { AirMoldova.CitesteRuteXML(); });
            ThreadPool.QueueUserWorkItem(obj => { AirMoldova.DeserializeazaDiscounturi(); });
            //Action LoadAeropAsync = new Action(Aeroport.LoadAeroporturi);
            //LoadAeropAsync.BeginInvoke(new AsyncCallback(result =>
            //{
            //    (result.AsyncState as Action).EndInvoke(result);

            //}), LoadAeropAsync);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            AirMoldova.Serialize();
            AirMoldova.SalveazaRuteXML();
            if(MessageBox.Show("Doriți să salvați modificările asupra discounturilor?",
                "Salvare Discounturi",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                AirMoldova.SerializeazaDiscounturi();
            base.OnFormClosing(e);
        }

        private void dateDeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateCompanie dateCompanie = new DateCompanie(AirMoldova);
            if (dateCompanie.ShowDialog() == DialogResult.OK)
            {
                AirMoldova.Nume = dateCompanie.tbNume.Text;
                AirMoldova.Adresa = dateCompanie.tbAdresa.Text;
                AirMoldova.Email = dateCompanie.tbEmail.Text;
                AirMoldova.Telefon = dateCompanie.tbTelefon.Text;
            }
        }

        private void saveRezervariToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void incarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void adaugaRutaNouaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaRuta adaugaRuta = new AdaugaRuta(AirMoldova);
            adaugaRuta.StartPosition = FormStartPosition.CenterParent;
            adaugaRuta.ShowDialog(this);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void adaugaZboruriRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaZboruriRuta adaugaZboruriRuta = new AdaugaZboruriRuta(this.AirMoldova);
            adaugaZboruriRuta.StartPosition = FormStartPosition.CenterParent;
            adaugaZboruriRuta.ShowDialog(this);
        }

        private void stergeRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergeRuta stergeRuta = new StergeRuta(AirMoldova);
            stergeRuta.StartPosition = FormStartPosition.CenterParent;
            stergeRuta.Width = 500;
            stergeRuta.Height = 150;
            stergeRuta.ShowDialog(this);
        }

        private void modificaRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaRuta modificaRuta = new ModificaRuta(AirMoldova);
            modificaRuta.StartPosition = FormStartPosition.CenterParent;
            modificaRuta.ShowDialog(this);
        }

        private void valoriDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeteazaDiscounts adaugaDiscounts = new SeteazaDiscounts(AirMoldova.Rute.Keys.ToList());
            adaugaDiscounts.StartPosition = FormStartPosition.CenterParent;
            var result = adaugaDiscounts.ShowDialog(this);
            if( result == DialogResult.OK)
            {
                AirMoldova.DiscountMaxim = adaugaDiscounts.DiscountMaxim;
                AirMoldova.AdaugaDiscount(adaugaDiscounts.Ruta, adaugaDiscounts.Discounts);
            } else if (result == DialogResult.Yes)
            {
                AirMoldova.DiscountMaxim = adaugaDiscounts.DiscountMaxim;
                foreach(var ruta in AirMoldova.Rute)
                {
                    AirMoldova.AdaugaDiscount(ruta.Key, adaugaDiscounts.Discounts);
                }
            }
        }

        private void configurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurareDiscounts configurareDiscounts = new ConfigurareDiscounts(AirMoldova);
            configurareDiscounts.StartPosition = FormStartPosition.CenterParent;
            configurareDiscounts.ShowDialog(this);
        }

        private void adaugaClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adaugaClient = new AdaugaClient();
            adaugaClient.StartPosition = FormStartPosition.CenterParent;
            adaugaClient.ShowDialog(this);
        }

        private void vizualizeazaClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestioneazaClienti().Show();
        }

        private void adaugaRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaRezervare adaugaRezervare = new AdaugaRezervare(AirMoldova);
            adaugaRezervare.StartPosition = FormStartPosition.CenterParent;
            adaugaRezervare.ShowDialog(this);
        }
    }
}
