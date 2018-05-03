using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class AdaugaZboruriUsrControl : UserControl
    {

        public IList<Zbor> Zboruri
        {
            get;
            internal set;
        }
        public AdaugaZboruriUsrControl()
        {
            InitializeComponent();
            Zboruri = new List<Zbor>();
        }
        
        public void ClearZboruri()
        {
            Zboruri.Clear();
        }

        private void btnAdaugaZbor_Click(object sender, EventArgs e)
        {
            if (numericCost.Value == 0)
                errProvZbor.SetError(numericCost, "Costul nu poate sa fie 0");
            else if (numericNrLocuri.Value == 0)
                errProvZbor.SetError(numericNrLocuri, "Numarul de locuri nu poate fi 0");
            else if (DateTime.Compare(dateAterizare.Value, dateDecolare.Value) <= 0)
            {
                MessageBox.Show("Data aterizării nu poate fi mai mica sau egală cu data decolării");
                return;
            }
            else
            {
                errProvZbor.Clear();
                Zboruri.Add(new Zbor(dateDecolare.Value, dateAterizare.Value,
                    float.Parse(numericCost.Text), int.Parse(numericNrLocuri.Text)));
                //btnResFields_Click(sender, e);
            }
        }

        private void btnResFields_Click(object sender, EventArgs e)
        {
            dateDecolare.Value = new DateTime(2018, 1, 1, 0, 0, 0);
            dateAterizare.Value = new DateTime(2018, 1, 1, 0, 0, 0);
            numericCost.Text = "0.00";
            numericNrLocuri.Text = "0";
        }

        private void btnResetZboruri_Click(object sender, EventArgs e)
        {
            Form confirm = new Form();
            confirm.Width = 400;
            confirm.Height = 120;
            confirm.Text = "Confirmare Ștergere Zboruri";
            Label textLabel = new Label()
            {
                Left = 20,
                Top = 10,
                Text =
                "Sigur doriți să ștergeți toate zborurile adăgate anterior în lista de zboruri?",
                AutoSize = true
            };
            Button accept = new Button() { Text = "Da", Left = 130, Width = 50, Top = 40 };
            Button discard = new Button() { Text = "Nu", Left = 200, Width = 50, Top = 40 };
            accept.DialogResult = DialogResult.Yes;
            discard.DialogResult = DialogResult.No;
            accept.Click += (_sender_, _e_) => { confirm.Close(); };
            discard.Click += (_sender_, _e_) => { confirm.Close(); };
            confirm.Controls.Add(textLabel);
            confirm.Controls.Add(accept);
            confirm.Controls.Add(discard);
            confirm.StartPosition = FormStartPosition.CenterParent;
            if (confirm.ShowDialog(this) == DialogResult.Yes)
            {
                Zboruri.Clear();
                MessageBox.Show("Toată lista de zboruri a fost resetată");
            }
        }

        public void SetZbor(Zbor zbor)
        {
            dateAterizare.Value = zbor.TimpAterizare;
            dateDecolare.Value = zbor.TimpDecolare;
            numericCost.Value = (decimal)zbor.Cost;
            numericNrLocuri.Value = zbor.LocuriDisponibile;
        }

        public Zbor GetZbor()
        {
            if (DateTime.Compare(dateAterizare.Value, dateDecolare.Value) <= 0)
            {
                MessageBox.Show("Data aterizării nu poate fi mai mica sau egală cu data decolării");
                return null;
            }
            else
            {
                return new Zbor(dateDecolare.Value, dateAterizare.Value,(float)numericCost.Value,
                    (int)numericNrLocuri.Value);
            }
        }
    }
}
