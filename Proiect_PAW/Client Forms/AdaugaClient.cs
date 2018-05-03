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
    public partial class AdaugaClient : Form
    {
        public AdaugaClient()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            var client = clientUserControl1.Persoana;
            if (client != null)
            {
                if (DBRepositoriesManager.AirCompanyDBExecuteNonQuerry("INSERT INTO CLIENTI" +
                      "(NUME,PRENUME,EMAIL,CETATENIE,DATA_NASTERE,NUMAR_PASAPORT,TELEFON,CNP,SEX) VALUES"
                      + "('" + @client.Nume + "','" + @client.Prenume + "','" + @client.Email + "','" +
                      @client.Cetatenie + "','" +
                      @client.DataNastere.ToString("yyyy-MM-dd") + "','" + @client.NumarPasaport + "','" +
                      @client.Telefon + "','" +
                      @client.CNP + "','" + @client.Sex + "')") == -1)

                    MessageBox.Show("Eroare la adaugarea noului client in baza de date");
            } 
        }

        private void AdaugaClient_Load(object sender, EventArgs e)
        {
            if (DBRepositoriesManager.OpenAirCompanyDB() == false)
            {
                MessageBox.Show("Can't open AirCompanyDB");
                Close();
                return;
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            DBRepositoriesManager.CloseAirCompanyDB();
            base.OnClosing(e);
        }
    }
}
