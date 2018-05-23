using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW.Chart_Forms
{
    public partial class ChartsManager : Form
    {
        public CompanieAeriana CompanieAeriana  {get;set;}

        public ChartsManager()
        {
            InitializeComponent();           
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void zboruriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZboruriChartConfig zboruriChartConfig = new ZboruriChartConfig();
            zboruriChartConfig.RuteAeriene = CompanieAeriana.Rute;
            zboruriChartConfig.StartPosition = FormStartPosition.CenterParent;
            if(zboruriChartConfig.ShowDialog(this) == DialogResult.OK)
            {
                if (zboruriChartConfig.Zboruri == null)
                {
                    MessageBox.Show("Eroare la citirea parametrilor pentru desenarea graficului");
                    return;
                }
                chart.Titles.Clear();
                chart.Titles.Add("Zboruri pe ruta " + zboruriChartConfig.RutaAeriana.ToString());
                chart.Titles.Add("Luna " + zboruriChartConfig.Luna);
                chart.Series["Bilete Total"].Points.Clear();
                chart.Series["Bilete Rezervate"].Points.Clear();

                chart.ChartAreas["Zbor Area"].AxisX.Title = "Ziua";
                chart.ChartAreas["Zbor Area"].AxisY.Title = "Numar Locuri";

                var Zboruri = zboruriChartConfig.Zboruri;
                foreach(var zbor in Zboruri)
                {
                    chart.Series["Bilete Total"].Points.AddXY(zbor.TimpDecolare.Day, zbor.NumarLocuri);
                    chart.Series["Bilete Rezervate"].Points.AddXY(zbor.TimpDecolare.Day, zbor.NumarLocuri - zbor.LocuriDisponibile);
                }               
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart.Printing.PrintPreview();
        }
    }
}
