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
    public partial class DateRutaUsrControl : UserControl
    {
        public DateRutaUsrControl()
        {
            InitializeComponent();
            if (Aeroport.Aeroporturi != null)
            {
                cbTaraAter.DataSource = Aeroport.Aeroporturi.Keys.ToList();
                cbTaraDec.DataSource = Aeroport.Aeroporturi.Keys.ToList();
            }
        }

        public void SetRuta(RutaAeriana ruta)
        {
            cbTaraDec.SelectedIndex = cbTaraDec.Items.IndexOf(ruta.AeroportDecolare.Tara);
            cbOrasDec.SelectedIndex = cbOrasDec.Items.IndexOf(ruta.AeroportDecolare.Oras);
            cbAeropDec.SelectedIndex = cbAeropDec.Items.IndexOf(ruta.AeroportDecolare);

            cbTaraAter.SelectedIndex = cbTaraAter.Items.IndexOf(ruta.AeroportAterizare.Tara);
            cbOrasAter.SelectedIndex = cbOrasAter.Items.IndexOf(ruta.AeroportAterizare.Oras);
            cbAeropAter.SelectedIndex = cbAeropAter.Items.IndexOf(ruta.AeroportAterizare);
        }
        
        public RutaAeriana GetRutaAeriana()
        {
            if (cbAeropDec.SelectedIndex == -1 || cbAeropAter.SelectedIndex == -1)
                return null;
            else if (cbAeropDec.SelectedItem.Equals(cbAeropAter.SelectedItem as Aeroport))
                return null;
            else
            {
                //returneaza o copie din repository cu aeroporturi
                return new RutaAeriana((Aeroport)((Aeroport)cbAeropDec.SelectedItem).Clone(),
                                        (Aeroport)((Aeroport)cbAeropAter.SelectedItem).Clone());
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            //MessageBox.Show("loaded");
            base.OnLoad(e);
        }

        private void cbTaraDec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTaraDec.SelectedIndex != -1) //daca s-a selectat ceva
            {
                cbOrasDec.DataSource = Aeroport.Aeroporturi[(string)cbTaraDec.SelectedItem].Keys.ToList();
            }
        }

        private void cbOrasDec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrasDec.SelectedIndex != -1 && cbTaraDec.SelectedIndex != -1)
            {
                cbAeropDec.DataSource = Aeroport.Aeroporturi[(string)cbTaraDec.SelectedItem]
                    [(string)cbOrasDec.SelectedItem];
            }
        }

        private void cbTaraAter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTaraAter.SelectedIndex != -1) //daca s-a selectat ceva
            {
                cbOrasAter.DataSource = Aeroport.Aeroporturi[(string)cbTaraAter.SelectedItem].Keys.ToList();
            }
        }

        private void cbOrasAter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOrasAter.SelectedIndex != -1 && cbTaraAter.SelectedIndex != -1)
            {
                cbAeropAter.DataSource = Aeroport.Aeroporturi[(string)cbTaraAter.SelectedItem]
                    [(string)cbOrasAter.SelectedItem];
            }
        }
    }
}
