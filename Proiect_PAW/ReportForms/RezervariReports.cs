using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace Proiect_PAW.ReportForms
{
    public partial class RezervariReports : Form , ReportForms.IReport
    {
        CompanieAeriana companie;
        public RezervariReports(CompanieAeriana companie)
        {
            InitializeComponent();
            this.companie = companie;
            toolStripComboBoxRute.ComboBox.DataSource = companie.Rute.Keys.ToList();
            try {
                toolStripComboBoxRute.ComboBox.SelectedIndex = 0;
            } catch
            {
                this.reportViewer1.Clear();
            }
        }

        private void RezervariReports_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void toolStripComboBoxRute_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBoxRute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBoxRute.ComboBox.SelectedItem != null)
            {
                toolStripComboBoxData.ComboBox.DataSource = null;
                toolStripComboBoxZbor.ComboBox.DataSource = null;
                toolStripComboBoxData.ComboBox.DataSource = companie.Rute[toolStripComboBoxRute.ComboBox.SelectedItem as RutaAeriana].Keys.ToList();
                try
                {
                    toolStripComboBoxData.ComboBox.SelectedIndex = 0;
                } catch
                {
                    reportViewer1.LocalReport.SetParameters(new[] {
                        new ReportParameter("ParamRuta",(toolStripComboBoxRute.ComboBox.SelectedItem as RutaAeriana).ToString()),
                        new ReportParameter("ParamZbor"," Nu exista zboruri"),
                        new ReportParameter("ParamData"," Lipsa data decolare")});
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRezervanti", new List<Persoana>()));
                    reportViewer1.RefreshReport();
                }
            }
        }

        private void toolStripComboBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBoxData.ComboBox.SelectedItem != null)
            {
                toolStripComboBoxZbor.ComboBox.DataSource = null;
                toolStripComboBoxZbor.ComboBox.DataSource = companie.Rute[toolStripComboBoxRute.ComboBox.SelectedItem as RutaAeriana]
                    [(DateTime)toolStripComboBoxData.ComboBox.SelectedItem].Keys.ToList();
                try
                {
                    toolStripComboBoxZbor.ComboBox.SelectedIndex = 0;
                } catch
                {
                    reportViewer1.LocalReport.SetParameters(new[] {
                        new ReportParameter("ParamRuta",(toolStripComboBoxRute.ComboBox.SelectedItem as RutaAeriana).ToString()),
                        new ReportParameter("ParamZbor"," Nu exista zboruri"),
                        new ReportParameter("ParamData",((DateTime)toolStripComboBoxData.ComboBox.SelectedItem).ToShortDateString())});
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRezervanti", new List<Persoana>()));
                    reportViewer1.RefreshReport();
                }
            }
        }

        private void toolStripComboBoxZbor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBoxZbor.SelectedItem != null)
            {
                IList<Persoana> rezervanti = new List<Persoana>();
                var rezervHashTable = companie.Rute[toolStripComboBoxRute.ComboBox.SelectedItem as RutaAeriana]
                    [(DateTime)toolStripComboBoxData.ComboBox.SelectedItem][toolStripComboBoxZbor.ComboBox.SelectedItem as Zbor]
                    .Values;
                foreach (Rezervare rez in rezervHashTable)
                {
                    rezervanti.Add(rez.Rezervant);
                }

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetRezervanti", rezervanti));
                reportViewer1.LocalReport.SetParameters(new[] {
                        new ReportParameter("ParamRuta",(toolStripComboBoxRute.ComboBox.SelectedItem as RutaAeriana).ToString()),
                        new ReportParameter("ParamZbor",(toolStripComboBoxZbor.ComboBox.SelectedItem as Zbor).ToString()),
                        new ReportParameter("ParamData",((DateTime)toolStripComboBoxData.ComboBox.SelectedItem).ToShortDateString())});
                reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
        }

        public void PrintReport()
        {
            var renderedBytes = reportViewer1.LocalReport.Render
                (
                    "PDF",
                    @"<DeviceInfo><OutputFormat>PDF</OutputFormat><HumanReadablePDF>False</HumanReadablePDF></DeviceInfo>",
                    out var mimeType,
                    out var encoding,
                    out var extension,
                    out var streams,
                    out var warnings
                );

            StringBuilder stringBuilder = new StringBuilder("Rezervari_");
            try
            {
                stringBuilder.Append(toolStripComboBoxRute.ComboBox.SelectedItem.ToString() + "_");
                stringBuilder.Append(((DateTime)toolStripComboBoxData.ComboBox.SelectedItem).ToString("dd-MM-yyyy"));
            } catch { }

            var saveAs = string.Format("{0}.pdf", Path.Combine(Properties.Settings.Default.ReportsPath, stringBuilder.ToString()));

            var idx = 0;
            while (File.Exists(saveAs))
            {
                idx++;
                saveAs = string.Format("{0}({1}).pdf", Path.Combine(Properties.Settings.Default.ReportsPath, stringBuilder.ToString()), idx);
            }

            try
            {
                using (var stream = new FileStream(saveAs, FileMode.Create, FileAccess.Write))
                {
                    stream.Write(renderedBytes, 0, renderedBytes.Length);
                    stream.Close();
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private string GetRenderingExtension(string FileName)
        {
            switch (FileName)
            {
                case ".pdf":
                    return "PDF";
                case ".jpg":
                    return "IMAGE";
                case ".doc":
                    return "WORD";
                default:
                    return "PDF";
            }
        }
        public void PrintReport(FileInfo fileInfo)
        {
            var renderedBytes = reportViewer1.LocalReport.Render
               (
                   GetRenderingExtension(fileInfo.Extension),
                   null,
                   out var mimeType,
                   out var encoding,
                   out var extension,
                   out var streams,
                   out var warnings
               );
            try
            {
                using (var stream = new FileStream(fileInfo.DirectoryName + "\\" + 
                    Path.GetFileNameWithoutExtension(fileInfo.Name) + "." + extension, FileMode.Create, FileAccess.Write))
                {
                    stream.Write(renderedBytes, 0, renderedBytes.Length);
                    stream.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
