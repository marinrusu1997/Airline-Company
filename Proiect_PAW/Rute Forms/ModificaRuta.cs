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
using System.IO;

namespace Proiect_PAW
{
    public partial class ModificaRuta : Form
    {
        CompanieAeriana companie;
        public ModificaRuta(CompanieAeriana companieAeriana)
        {
            InitializeComponent();
            this.companie = companieAeriana;
            cbRute.DataSource = companie.Rute.Keys.ToList();
            rbModifAerop.Checked = true;
            try
            {
                //this.BackgroundImage = new Bitmap(@"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\Resources\Images\AirPlaneTakeOff.jpg");
                //this.BackgroundImage = new Bitmap(@"‪C:\Users\dimar\Downloads\Document.png");
            }
            catch
            {
                File.WriteAllText("debug.txt", "Unnable to open image C:\\Users\\dimar\\Downloads\\Document.png");
            }
        }

        private void cbRute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbRute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRute.SelectedIndex != -1)
            {
                dateRutaUsrControl1.SetRuta(cbRute.SelectedItem as RutaAeriana);
                cbDateZbor.DataSource = null;
                cbZboruri.DataSource = null;

                if (rbModifZboruri.Checked)
                {
                    btnModifica.Enabled = false;
                    adaugaZboruriUsrControl1.dateAterizare.Enabled = false;
                    adaugaZboruriUsrControl1.dateDecolare.Enabled = false;
                }
                else
                    btnModifica.Enabled = true;

                try
                {
                    cbDateZbor.DataSource = companie.Rute[cbRute.SelectedItem as RutaAeriana].Keys.ToList();
                }
                catch
                {

                }
            }
        }
        private void rbModifAerop_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = new Bitmap(@"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\Resources\Images\Airport.jpg");
            }
            catch { }

            dateRutaUsrControl1.Visible = true;
            adaugaZboruriUsrControl1.Visible = false;
            labelZbor.Visible = false;
            labelDataZbor.Visible = false;
            cbDateZbor.Visible = false;
            cbZboruri.Visible = false;

            btnModifica.Enabled = true;
        }

        private void rbModifZboruri_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = new Bitmap(@"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\Resources\Images\AirPlaneTakeOff.jpg");
            }
            catch { }

            dateRutaUsrControl1.Visible = false;

            adaugaZboruriUsrControl1.btnAdaugaZbor.Visible = false;
            adaugaZboruriUsrControl1.btnResetZboruri.Visible = false;
            adaugaZboruriUsrControl1.btnResFields.Visible = false;
            adaugaZboruriUsrControl1.numericCost.Enabled = false;
            adaugaZboruriUsrControl1.numericNrLocuri.Enabled = false;
            adaugaZboruriUsrControl1.dateAterizare.Enabled = false;
            adaugaZboruriUsrControl1.dateDecolare.Enabled = false;
            adaugaZboruriUsrControl1.Visible = true;
            labelZbor.Visible = true;
            labelDataZbor.Visible = true;
            cbDateZbor.Visible = true;
            cbZboruri.Visible = true;
            btnModifica.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (rbModifAerop.Checked == true)
            {
                var rutaModificata = dateRutaUsrControl1.GetRutaAeriana();
                if (companie.Rute.ContainsKey(rutaModificata))
                {
                    MessageBox.Show("Această rută modificată este deja deservită de către companie",
                        "Eroare modificare rută", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                RutaAeriana rutaVeche;
                if ((rutaVeche = cbRute.SelectedItem as RutaAeriana) != null &&
                    companie.Rute[rutaVeche].Count == 0)
                {
                    //ruta veche o avem deja
                    SortedDictionary<DateTime, SortedDictionary<Zbor, Hashtable>> zboruriVechi = null;
                    try
                    {
                        zboruriVechi = companie.Rute[rutaVeche];
                    }
                    catch (KeyNotFoundException ex)
                    { File.WriteAllText("debug.txt", ex.Message); }
                    //stergem ruta veche din dictionar
                    companie.Rute.Remove(rutaVeche);
                    //introducem ruta modificata
                    companie.AdaugaRuta(rutaModificata, zboruriVechi);
                    //reactulizam data sources
                    cbRute.DataSource = null;
                    cbRute.Items.Clear();
                    cbRute.DataSource = companie.Rute.Keys.ToList();
                }
                else
                    MessageBox.Show("Această rută nu poate fi modificată,deoarece pentru dinsa deja au fost " +
                        "înregistrate zboruri,pentru care la rîndul lor au fost înregistrate rezervări",
                        "Eroare modificare rută", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbModifZboruri.Checked == true)
            {
                var zborModificat = adaugaZboruriUsrControl1.GetZbor();
                if (zborModificat != null)
                {
                    cbRute.Enabled = false;
                    cbDateZbor.Enabled = false;
                    cbZboruri.Enabled = false;
                    rbModifAerop.Enabled = false;
                    btnCancel.Enabled = false;

                    RutaAeriana rutaAeriana = cbRute.SelectedItem as RutaAeriana;

                    try
                    {
                        if (companie.Rute[rutaAeriana]
                            [CompanieAeriana.ExtractDate(zborModificat.TimpDecolare)].
                            ContainsKey(zborModificat))
                        {
                            MessageBox.Show("Aceast zbor deja există în cadrul acestei rute",
                            "Eroare modificare zbor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnModifica.Enabled = false;

                            cbRute.Enabled = true;
                            cbDateZbor.Enabled = true;
                            cbZboruri.Enabled = true;
                            rbModifAerop.Enabled = true;
                            btnCancel.Enabled = true;

                            return;
                        }
                    }
                    catch (KeyNotFoundException)
                    {
                        //daca data nu a fost gasita atunci sigur asa ruta nu exista in dictionar
                    }
                    //datele vechi
                    var zborVechi = cbZboruri.SelectedItem as Zbor;
                    var rezervVechi = companie.Rute[rutaAeriana]
                        [CompanieAeriana.ExtractDate(zborVechi.TimpDecolare)][zborVechi];
                    companie.Rute[rutaAeriana]
                        [CompanieAeriana.ExtractDate(zborVechi.TimpDecolare)].Remove(zborVechi);
                    //modificare date vechi
                    zborVechi.TimpAterizare = zborModificat.TimpAterizare;
                    zborVechi.TimpDecolare = zborModificat.TimpDecolare;
                    //reinserare date noi
                    companie.AdaugaZbor(rutaAeriana, zborVechi, rezervVechi);
                    //reactualizare data sources
                    try
                    {
                        cbDateZbor.DataSource = null;
                        cbDateZbor.Items.Clear();
                        cbZboruri.DataSource = null;
                        cbZboruri.Items.Clear();


                        cbDateZbor.DataSource = companie.Rute[rutaAeriana].Keys.ToList();
                        cbZboruri.DataSource = companie.Rute[rutaAeriana]
                            [(DateTime)cbDateZbor.SelectedItem].Keys.ToList();
                    }
                    catch { }
                    btnModifica.Enabled = false;
                    adaugaZboruriUsrControl1.dateAterizare.Enabled = false;
                    adaugaZboruriUsrControl1.dateDecolare.Enabled = false;

                    cbRute.Enabled = true;
                    cbDateZbor.Enabled = true;
                    cbZboruri.Enabled = true;
                    rbModifAerop.Enabled = true;
                    btnCancel.Enabled = true;
                }
            }
        }

        private void cbDateZbor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRute.SelectedItem != null && cbDateZbor.SelectedIndex != -1)
            {
                companie.Rute.TryGetValue(cbRute.SelectedItem as RutaAeriana,
                    out var zboruri);
                if (zboruri != null)
                {
                    zboruri.TryGetValue((DateTime)cbDateZbor.SelectedItem, out var zbor);
                    if (zbor != null)
                    {
                        cbZboruri.DataSource = null;
                        cbZboruri.Items.Clear();
                        var listZboruri = zbor.Keys.ToList();
                        if (listZboruri.Count == 0)
                        {
                            btnModifica.Enabled = false;
                            adaugaZboruriUsrControl1.dateAterizare.Enabled = false;
                            adaugaZboruriUsrControl1.dateDecolare.Enabled = false;
                        }
                        else
                            cbZboruri.DataSource = listZboruri;
                    }
                }
            }
        }

        private void cbZboruri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbZboruri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbZboruri.SelectedIndex != -1)
            {
                adaugaZboruriUsrControl1.dateAterizare.Enabled = true;
                adaugaZboruriUsrControl1.dateDecolare.Enabled = true;
                adaugaZboruriUsrControl1.SetZbor(cbZboruri.SelectedItem as Zbor);
                btnModifica.Enabled = true;
            }
        }

        private void ModificaRuta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.M)
            {
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
                if (btnModifica.Enabled == true)
                    btnModifica_Click(sender, e);
                e.SuppressKeyPress = false;
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                e.SuppressKeyPress = true;
                if (btnCancel.Enabled == true)
                    btnCancel_Click(sender, e);
                e.SuppressKeyPress = false;
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.R)
            {
                e.SuppressKeyPress = true;
                rbModifAerop.Checked = true;
                e.SuppressKeyPress = false;
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.Z)
            {
                e.SuppressKeyPress = true;
                rbModifZboruri.Checked = true;
                e.SuppressKeyPress = false;
            }
        }

        private void cbRute_DataSourceChanged(object sender, EventArgs e)
        {
            cbDateZbor.DataSource = null;
            cbDateZbor.Items.Clear();
        }

        private void cbDateZbor_DataSourceChanged(object sender, EventArgs e)
        {
            cbZboruri.DataSource = null;
            cbZboruri.Items.Clear();
        }
    }
}
