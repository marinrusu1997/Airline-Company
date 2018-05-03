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
    public partial class AdaugaZboruriRuta : Form
    {
        CompanieAeriana companie;
        int counterAfisareZboruri = 0;
        public AdaugaZboruriRuta(CompanieAeriana companieAeriana)
        {
            InitializeComponent();
            this.companie = companieAeriana;
            if (this.companie.Rute.Count > 0)
            {
                foreach (var ruta in this.companie.Rute)
                {
                    cbRute.Items.Add(ruta.Key);
                }
                cbRute.SelectedIndex = 0;
            }
        }
        private void cbRute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void btnAdgZboruri_Click_1(object sender, EventArgs e)
        {
            if (adaugaZboruriUsrControl.Zboruri.Count == 0)
            {
                MessageBox.Show("Lista de rute este goală");
                return;
            }
            if (cbRute.SelectedItem == null)
            {
                MessageBox.Show("Nu a fost selectată nici o rută aeriană");
                return;
            }
            if (companie.AdaugaZboruri((RutaAeriana)cbRute.SelectedItem, adaugaZboruriUsrControl.Zboruri) == false)
            {
                MessageBox.Show("Unele zboruri nu au fost adăugate.Posibil ele deja există in cadrul acestei companii");
            }
            adaugaZboruriUsrControl.Zboruri.Clear();
            try
            {
                cbRute.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void btnAfisZboruri_Click(object sender, EventArgs e)
        {
            if (counterAfisareZboruri++ % 2 == 0 && cbRute.SelectedItem != null)
             {
                tvZboruri.Nodes.Clear();
                TreeNode dataZbor = null;
                try
                {
                    foreach (var zboruri in companie.Rute[(RutaAeriana)cbRute.SelectedItem])
                    {
                        dataZbor = new TreeNode(zboruri.Key.ToShortDateString());
                        tvZboruri.Nodes.Add(dataZbor);
                        foreach (var zbor in zboruri.Value)
                        {
                            dataZbor.Nodes.Add(new TreeNode(zbor.Key.ToString()));
                        }
                    }
                } catch (KeyNotFoundException)
                {
                    return;
                }
                tvZboruri.ExpandAll();
                tvZboruri.Visible = true;
            }
            else
                tvZboruri.Visible = false;
        }

        private void cbRute_SelectedIndexChanged(object sender, EventArgs e)
        {
            adaugaZboruriUsrControl.Zboruri.Clear();
        }
    }
}
