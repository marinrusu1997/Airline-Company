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
        public Persoana Persoana { get; internal set; }
        public RutaAeriana RutaAeriana { get; internal set; }
        public ZborBasic Zbor { get; internal set; }
        public int NumarBileteRezervate { get; internal set; }
        private float SumaPlata { get; set; }

        public AdaugaRezervare(CompanieAeriana companieAeriana)
        {
            InitializeComponent();
            this.companie = companieAeriana;
            rezervareUserControl1.CompanieAeriana = companie;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Persoana = clientUserControl1.Persoana;
            RutaAeriana = rezervareUserControl1.RutaAeriana;
            Zbor = rezervareUserControl1.Zbor;
            NumarBileteRezervate = rezervareUserControl1.NumarBilete;
            if (Persoana == null || RutaAeriana == null || Zbor == null)
            {
                MessageBox.Show("Completati toate cimpurile", "Eroare la adaugarea rezervarii",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //il cautam in clienti
            SqlCommand command = new SqlCommand("SELECT COUNT(ID_CLIENT) FROM CLIENTI WHERE CNP=@cnp");
            command.Parameters.Add("@cnp", SqlDbType.VarChar).Value = Persoana.CNP;
            //daca l-am gasit
            object result = DBRepositoriesManager.AirCompanyDBExecuteScalar(command);
            if (result != null && ((Int32)result) > 0)
            {
                Persoana.EsteClient = true;
            }
            //altfel il cautam daca nu a mai facut rezervari anterioare
            else
            {
                //indicam ca acesta nu este clientul nostru
                Persoana.EsteClient = false;
                //verificam daca trebuie sa il adaugam la tabela de rezervanti
                command.CommandText = "SELECT COUNT(ID_REZERVANT) FROM REZERVANTI WHERE CNP=@cnp_cautat";
                command.Parameters.Add("@cnp_cautat", SqlDbType.VarChar).Value = Persoana.CNP;
                result = DBRepositoriesManager.AirCompanyDBExecuteScalar(command);
                if (((Int32)result) == 0)
                {
                    //daca adaugarea nu s-a facut cu succes anuntam despre asta
                    if (DBRepositoriesManager.AirCompanyDBAddRezervant(Persoana) == -1)
                    {
                        MessageBox.Show("Eroare la adaugarea rezervantului",
                                        "Eroare la adaugarea rezervantului",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            //daca totul s-a trecut de toate validarile adaugam rezervarea la companie
            if (companie.AdaugaRezervare(new Rezervare(RutaAeriana, Zbor, NumarBileteRezervate, Persoana), out var suma))
            {
                MessageBox.Show("Suma de plata este " + suma);
                SumaPlata = suma;
                printDocument1.DocumentName = Persoana.ToString() + ".pdf";
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        { 
            StringBuilder ToPrint =  new StringBuilder("                    Rezervare                   " + Environment.NewLine);
            ToPrint.Append("Ruta Aeriana: " + RutaAeriana.ToString() + Environment.NewLine);
            ToPrint.Append("Zbor: " + "Decolare " +  Zbor.TimpDecolare.ToString("dd/MM/yyyy HH:mm") + " Aterizare " + 
                Zbor.TimpAterizare.ToString("dd/MM/yyyy HH:mm") + Environment.NewLine);
            ToPrint.Append("Numar bilete rezervate: " + NumarBileteRezervate + Environment.NewLine);
            ToPrint.Append("                      Persoana:                   " + Environment.NewLine);
            ToPrint.Append("Nume: " + Persoana.Nume + Environment.NewLine);
            ToPrint.Append("Prenume: " + Persoana.Prenume + Environment.NewLine);
            ToPrint.Append("Cetatenie: " + Persoana.Cetatenie + Environment.NewLine);
            ToPrint.Append("Numar Pasaport: " + Persoana.NumarPasaport + Environment.NewLine);
            ToPrint.Append("Data Nastere: " + Persoana.DataNastere.ToShortDateString() + Environment.NewLine);
            ToPrint.Append("CNP: " + Persoana.CNP + Environment.NewLine);
            ToPrint.Append("Sex: " + Persoana.Sex + Environment.NewLine);
            ToPrint.Append("Telefon: " + Persoana.Telefon + Environment.NewLine);
            ToPrint.Append("Email: " + Persoana.Email + Environment.NewLine);
            ToPrint.Append("Client: " + (Persoana.EsteClient ? "Da" : "Nu") + Environment.NewLine);
            ToPrint.Append(Environment.NewLine + "                                 Cost: " + SumaPlata);
            ToPrint.Append(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine);
            ToPrint.Append("                   Data efectuarii rezervarii: " + DateTime.Now.ToShortDateString()  + 
                "                           Semnatura,");
            string StringToPrint = ToPrint.ToString();

            e.Graphics.MeasureString(StringToPrint, new Font("Times New Roman", 10,FontStyle.Bold), e.MarginBounds.Size,
                StringFormat.GenericTypographic, out var charactersOnPage, out var linesPerPage);

            e.Graphics.DrawString(StringToPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
            e.Graphics.DrawImage(new Bitmap(@"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\Resources\Images\air-moldova--72.jpg"),
                new Point(e.MarginBounds.Right - 250, e.MarginBounds.Y));

        }
    }
}
