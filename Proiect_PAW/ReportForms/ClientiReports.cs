using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect_PAW.Report_Forms
{
    public partial class ClientiReports : Form , ReportForms.IReport
    {
        public ClientiReports()
        {
            InitializeComponent();
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

            var saveAs = string.Format("{0}.pdf", Path.Combine(Properties.Settings.Default.ReportsPath, "ListaClientiReport"));

            var idx = 0;
            while (File.Exists(saveAs))
            {
                idx++;
                saveAs = string.Format("{0}({1}).pdf", Path.Combine(Properties.Settings.Default.ReportsPath, "ListaClientiReport"), idx);
            }

            try
            {
                using (var stream = new FileStream(saveAs, FileMode.Create, FileAccess.Write))
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

        private void ClientiReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClienti.DataTableClienti' table. You can move, or remove it, as needed.
            this.dataTableClientiTableAdapter.Fill(this.dataSetClienti.DataTableClienti);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
