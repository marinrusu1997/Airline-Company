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
    public partial class DateCompanie : Form
    {
        private CompanieAeriana companie;
        public DateCompanie(CompanieAeriana companie)
        {
            InitializeComponent();
            this.companie = companie;
            InitFields();
        }
        private void InitFields()
        {
            tbNume.Text = this.companie.Nume;
            tbAdresa.Text = this.companie.Adresa;
            tbEmail.Text = this.companie.Email;
            tbTelefon.Text = this.companie.Telefon;
        }
        private bool VerificaEmail(string email)
        {
            try
            {
                if (new System.Net.Mail.MailAddress(email).Address == email)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // (char)8 = caracterul backspace
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (tbNume.Text.Length < 5)
                erProvDateCompanie.SetError(tbNume, "Introduceti un nume valid,minim 5 caractere");
            else if (tbAdresa.Text.Length < 10)
                erProvDateCompanie.SetError(tbAdresa, "Introduceti o adresa valida,minim 10 caractere");
            else if (VerificaEmail(tbEmail.Text) == false)
                erProvDateCompanie.SetError(tbEmail, "Email invalid, example@domain.extension");
            else if (tbTelefon.Text.Length < 8)
                erProvDateCompanie.SetError(tbTelefon, "Telefon invalid, minim 8 cifre");
            else
            {
                erProvDateCompanie.Clear();
            }
        }

        private void DateCompanie_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabelAdresaWeb.Text);
        }
    }
}
