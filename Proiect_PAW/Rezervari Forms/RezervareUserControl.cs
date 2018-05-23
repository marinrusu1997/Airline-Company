using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Proiect_PAW;

namespace Proiect_PAW.Rezervari_Forms
{
    public partial class RezervareUserControl : UserControl
    {
        public RutaAeriana RutaAeriana
        {
            get
            {
                if (cbRutaAeriana.SelectedItem == null)
                    errProvRez.SetError(cbRutaAeriana, "Selectati o ruta");
                else
                    errProvRez.Clear();
                return (RutaAeriana)cbRutaAeriana.SelectedItem;
            }
        }
        public ZborBasic Zbor
        {
            get
            {

                if (cbZbor.SelectedItem == null)
                    errProvRez.SetError(cbZbor, "Selectati o ruta");
                else
                    errProvRez.Clear();
                return (ZborBasic)cbZbor.SelectedItem;
            }
        }
        public int NumarBilete
        {
            get
            {
                return (int)numericBilete.Value;
            }
        }

       public CompanieAeriana CompanieAeriana { get; set; }


        public RezervareUserControl()
        {
            InitializeComponent();
        }

        public void SetRezervare(Rezervare rezervare)
        {
            if(rezervare != null)
            {
                cbRutaAeriana.Items.Add(rezervare.RutaAeriana);
                try { cbRutaAeriana.SelectedIndex = 0; } catch { }
                cbData.Items.Add(rezervare.Zbor.TimpDecolare);
                try { cbData.SelectedIndex = 0; } catch { }
                cbZbor.Items.Add(rezervare.Zbor);
                try { cbZbor.SelectedIndex = 0; } catch { }
                numericBilete.Value = rezervare.NumarBilete;

                cbRutaAeriana.Enabled = false;
                cbData.Enabled = false;
                
            }
        }

        public void ClearFields()
        {
            cbRutaAeriana.DataSource = null;
            cbRutaAeriana.SelectedItem = null;
            cbData.DataSource = null;
            cbData.SelectedItem = null;
            cbZbor.DataSource = null;
            cbZbor.SelectedItem = null;
            numericBilete.Value = 1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (CompanieAeriana != null)
            {
                try
                {
                    cbRutaAeriana.DataSource = CompanieAeriana.Rute.Keys.ToList();
                    cbRutaAeriana.SelectedIndex = 0;
                } catch (Exception ex)
                {
                    File.AppendAllText("AddRezDebug.txt", Environment.NewLine + DateTime.Now +
                        Environment.NewLine + ex.Message);
                }
            }
        }

        private void cbRutaAeriana_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbData.DataSource = null;
                if (CompanieAeriana.Rute.TryGetValue(cbRutaAeriana.SelectedItem as 
                    RutaAeriana, out var zboruri))
                {
                    List<DateTime> dati = new List<DateTime>();
                        foreach (var zbor in zboruri)
                        {
                        if (zbor.Key.Date.CompareTo(DateTime.Now) >= 0)
                            dati.Add(zbor.Key);
                        }
                    cbData.DataSource = dati;
                }               
            }
            catch (Exception ex)
            {
                File.AppendAllText("AddRezDebug.txt", Environment.NewLine + DateTime.Now +
                    Environment.NewLine + ex.Message);
            }
        }

        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbZbor.DataSource = null;
                if(cbData.SelectedItem != null)
                {
                    cbZbor.DataSource = CompanieAeriana.Rute[cbRutaAeriana.SelectedItem as RutaAeriana]
                         [(DateTime)cbData.SelectedItem].Keys.ToList();
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("AddRezDebug.txt", Environment.NewLine + DateTime.Now +
                    Environment.NewLine + ex.Message);
            }
        }
    }
}
