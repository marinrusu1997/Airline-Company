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
    public partial class StergeRuta : Rute_Forms.RutaBaseForm
    {
        CompanieAeriana companie;
        public StergeRuta(CompanieAeriana companieAeriana)
        {
            InitializeComponent();
            this.companie = companieAeriana;
            if (companie.Rute.Count > 0)
            {
                foreach (var ruta in companie.Rute)
                {
                    cbRute.Items.Add(ruta.Key);
                }
                cbRute.SelectedIndex = 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form confirm = new Form();
            confirm.Width = 400;
            confirm.Height = 120;
            confirm.Text = "Confirmare Ștergere Rută";
            Label textLabel = new Label()
            {
                Left = 20,
                Top = 10,
                Text =
                "Sigur doriți să ștergeți această rută împreună cu lista sa de zboruri?",
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
                if (companie.StergeRuta((RutaAeriana)cbRute.SelectedItem) == false)
                    MessageBox.Show("Eroare la stergerea acestei rute");
                else
                {
                    companie.StergeDiscounturi((RutaAeriana)cbRute.SelectedItem);
                    cbRute.Items.Remove((RutaAeriana)cbRute.SelectedItem);
                    
                    if (cbRute.Items.Count > 0)
                        cbRute.SelectedIndex = 0;
                    else
                    {
                        cbRute.SelectedIndex = -1;
                        cbRute.Text = default(string);
                    }
                    
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbRute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
