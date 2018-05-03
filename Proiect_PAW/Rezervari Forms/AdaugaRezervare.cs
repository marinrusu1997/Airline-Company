using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_PAW.Rezervari_Forms
{
    public partial class AdaugaRezervare : Form
    {
        public CompanieAeriana companie;
        public AdaugaRezervare(CompanieAeriana companieAeriana)
        {
            InitializeComponent();
            this.companie = companieAeriana;
            rezervareUserControl1.CompanieAeriana = companie;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            var persoana = clientUserControl1.Persoana;
            var RutaAeriana = rezervareUserControl1.RutaAeriana;
            var Zbor = rezervareUserControl1.Zbor;
            var nrBilete = rezervareUserControl1.NumarBilete;
            if (persoana == null || RutaAeriana == null || Zbor == null)
            {
                MessageBox.Show("Completati toate cimpurile", "Eroare la adaugarea rezervarii",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //il cautam in clienti
            SqlCommand command = new SqlCommand("SELECT COUNT(ID_CLIENT) FROM CLIENTI WHERE CNP=@cnp");
            command.Parameters.Add("@cnp", SqlDbType.VarChar).Value = persoana.CNP;
            //daca l-am gasit
            object result = DBRepositoriesManager.AirCompanyDBExecuteScalar(command);
            if (result != null && ((Int32)result) > 0)
            {
                persoana.EsteClient = true;
            }
            //altfel il cautam daca nu a mai facut rezervari anterioare
            else
            {
                //indicam ca acesta nu este clientul nostru
                persoana.EsteClient = false;
                //verificam daca trebuie sa il adaugam la tabela de rezervanti
                command.CommandText = "SELECT COUNT(ID_REZERVANT) FROM REZERVANTI WHERE CNP=@cnp_cautat";
                command.Parameters.Add("@cnp_cautat", SqlDbType.VarChar).Value = persoana.CNP;
                result = DBRepositoriesManager.AirCompanyDBExecuteScalar(command);
                if (((Int32)result) == 0)
                {
                    //daca adaugarea nu s-a facut cu succes anuntam despre asta
                    if (DBRepositoriesManager.AirCompanyDBAddRezervant(persoana) == -1)
                    {
                        MessageBox.Show("Eroare la adaugarea rezervantului",
                                        "Eroare la adaugarea rezervantului",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            //daca totul s-a trecut de toate validarile adaugam rezervarea la companie
            if (companie.AdaugaRezervare(new Rezervare(RutaAeriana, Zbor, nrBilete, persoana), out var suma))
            {
                MessageBox.Show("Suma de plata este " + suma);
            }
            else
            {
                MessageBox.Show("Rezervarea nu a fost adaugata.Aceasta persoana deja a facut rezervare");
            }

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DBRepositoriesManager.OpenAirCompanyDB() == false)
            {
                MessageBox.Show("Eroare la deschiderea bazei de date",
                    "Eroare la deschiderea bazei de date",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            DBRepositoriesManager.CloseAirCompanyDB();
        }

  
    }
}
