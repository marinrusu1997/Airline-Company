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
    public partial class ClientUserControl : UserControl
    {
        public Persoana Persoana
        {
            get
            {
                try
                {
                    if (tbNume.Text.Length <= 2)
                    {
                        errProvClient.SetError(tbNume, "Introduceti un nume valid");
                        return null;
                    }
                    else if (tbPrenume.Text.Length <= 1)
                    {
                        errProvClient.SetError(tbPrenume, "Introduceti un prenume valid");
                        return null;
                    }
                    else if (tbNrPasaport.Text.Length <= 5)
                    {
                        errProvClient.SetError(tbNrPasaport, "Introduceti un numar de pasaport valid");
                        return null;
                    }
                    else if (tbEmail.Text == "")
                    {
                        errProvClient.SetError(tbEmail, "Introduceti un email valid");
                        return null;
                    }
                    else if (new System.Net.Mail.MailAddress(tbEmail.Text).Address != tbEmail.Text)
                    {
                        errProvClient.SetError(tbEmail, "Introduceti un email valid");
                        return null;
                    }
                    else if (cbCetatenie.Text.Length < 3)
                    {
                        errProvClient.SetError(cbCetatenie, "Selectati o cetatenie valida");
                        return null;
                    }
                    else if (!CNPValid(mbCNP.Text))
                    {
                        errProvClient.SetError(mbCNP, "Introduceti un CNP valid");
                        return null;
                    }
                    else if (!TelefonValid(mbTelefon.Text))
                    {
                        errProvClient.SetError(mbTelefon, "Introduceti un telefon valid");
                        return null;
                    }
                    else
                    {
                        errProvClient.Clear();
                        var client = new Persoana(tbNume.Text, tbPrenume.Text, tbEmail.Text, cbCetatenie.Text,
                            dateNastere.Value, tbNrPasaport.Text, mbTelefon.Text, mbCNP.Text, cbSex.Text);
                        tbNume.Clear();
                        tbPrenume.Clear();
                        tbEmail.Clear();
                        cbCetatenie.SelectedIndex = -1;
                        tbNrPasaport.Clear();
                        mbTelefon.Clear();
                        mbCNP.Clear();
                        cbSex.SelectedIndex = 0;
                        return client;
                    }
                } catch (FormatException ex)
                {
                    errProvClient.SetError(tbEmail, ex.Message);
                    return null;
                }
            }
            set
            {
                if (value == null)
                    return;
                tbNume.Text = value.Nume;
                tbPrenume.Text = value.Prenume;
                mbCNP.Text = value.CNP;
                tbNrPasaport.Text = value.NumarPasaport;
                dateNastere.Value = value.DataNastere;
                if (value.Sex == "F") cbSex.SelectedIndex = 0; else cbSex.SelectedIndex = 1;
                cbCetatenie.Text = value.Cetatenie;
                mbTelefon.Text = value.Telefon;
                tbEmail.Text = value.Email;
            }
        }

        public ClientUserControl()
        {
            InitializeComponent();
            cbSex.SelectedIndex = 0;
        }


        private void cbSex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void mbCNP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void mbCNP_TextChanged(object sender, EventArgs e)
        {
        }

        private bool CNPValid(string cnp)
        { 

            if (cnp.Length != 13)
                return false;

            if (cbCetatenie.Text == "Romania(RO)")
            {
                const string a = "279146358279";
                long j = 0;
                if (!long.TryParse(cnp, out j))
                    return false;

                long suma = 0;
                for (int i = 0; i < 12; i++)
                    suma += long.Parse(cnp.Substring(i, 1)) * long.Parse(a.Substring(i, 1));

                long rest = suma - 11 * (int)(suma / 11);
                rest = rest == 10 ? 1 : rest;

                if (long.Parse(cnp.Substring(12, 1)) != rest)
                    return false;

                return true;
            }
            else
            {
                if (cnp.All(c => { if (c >= '0' && c <= '9') return true; else return false; }))
                    return true;
                else
                    return false;
            }
        }

        private bool TelefonValid(string telefon)
        {
            if (telefon.Length != 12)
                return false;
            else if (telefon.All(c => { if (c >= '0' && c <= '9') return true; else return false; }))
                return true;
            else
                return false;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsData(Persoana.FormatClipboard))
            {
                Persoana = (Persoana)Clipboard.GetData(Persoana.FormatClipboard);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ;
            if (Persoana != null)
            {
                Clipboard.Clear();
                Clipboard.SetData(Persoana.FormatClipboard, Persoana);
            }
        }
    }
}
