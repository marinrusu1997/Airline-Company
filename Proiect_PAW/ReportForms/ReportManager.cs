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
using AxAcroPDFLib;
using WinWordControl;
using System.Threading;

namespace Proiect_PAW.Report_Forms
{
    public partial class ReportManager : Form
    {
        private int clientiReportFormNumber = 0;
        public CompanieAeriana CompanieAeriana { get; set; }

        public ReportManager()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Openning Report Windows...";
            ClientiReports clientiReport = new ClientiReports();
            clientiReport.MdiParent = this;
            clientiReport.Text = "Window Rapoarte Clienți " + clientiReportFormNumber++;
            clientiReport.Show();
            this.backgroundWorker1.RunWorkerAsync();
           // statusBarToolStripMenuItem.Invalidate();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "PDF File (*.pdf)|*.pdf|Image File (*.bmp,*.jpg,*.jpeg,*.png,*.tif,*.tiff,*.ico,*.TIF)|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.ico;*.TIF";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Form ReaderForm = new Form();
                ReaderForm.MdiParent = this;
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                switch (fileInfo.Extension)
                {
                    case ".pdf":
                        {
                            toolStripStatusLabel.Text = "Openning PDF Reader...";
                            //statusBarToolStripMenuItem.Invalidate();
                            AxAcroPDF pdfReader = new AxAcroPDF();
                            ((ISupportInitialize)(pdfReader)).BeginInit();
                            pdfReader.CreateControl();
                            pdfReader.Enabled = true;
                            pdfReader.Dock = DockStyle.Fill;
                            pdfReader.Name = "AxAcroPDFReader";
                            pdfReader.Visible = true;
                            pdfReader.LoadFile(fileInfo.FullName);
                            ReaderForm.Controls.Add(pdfReader);
                            pdfReader.Show();
                            ((ISupportInitialize)(pdfReader)).EndInit();
                            ReaderForm.Text = "PDF Reader";
                            toolStripStatusLabel.Text = "PDF Reader Opened";
                            //statusBarToolStripMenuItem.Invalidate();
                        }
                        break;
                    case ".jpg":
                    case ".png":
                    case ".ico":
                    case ".tiff":
                    case ".TIF":
                    case ".bmp":
                    case ".jpeg":
                    case ".tif":
                        {
                            toolStripStatusLabel.Text = "Openning Image Reader...";
                            //statusBarToolStripMenuItem.Invalidate();
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.ImageLocation = fileInfo.FullName;
                            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                            pictureBox.Dock = DockStyle.Fill;
                            pictureBox.Visible = true;
                            pictureBox.Enabled = true;
                            ReaderForm.Controls.Add(pictureBox);
                            pictureBox.Show();
                            ReaderForm.Text = "Image Reader";
                            toolStripStatusLabel.Text = "Image Reader Opened";
                            //statusBarToolStripMenuItem.Invalidate();
                        }
                        break;
                }
                ReaderForm.Show();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Report = ActiveMdiChild as ReportForms.IReport;
            if (Report != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf|Image File (*.jpg)|*.jpg|Word (*.doc)|*.doc";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    toolStripStatusLabel.Text = "Saving...";
                   // statusBarToolStripMenuItem.Invalidate();
                    Report.PrintReport(new FileInfo(saveFileDialog.FileName));
                    toolStripStatusLabel.Text = "Saved";
                    //statusBarToolStripMenuItem.Invalidate();
                }
            }
            else
                MessageBox.Show("Selectati una din ferestrele care contine rapoarte");
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

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            var Report = ActiveMdiChild as ReportForms.IReport;
            if (Report != null)
            {
                Report.PrintReport();
                toolStripStatusLabel.Text = "Saved";
            }
            else
                toolStripStatusLabel.Text = "Failed to save report!";
            //statusBarToolStripMenuItem.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Report = ActiveMdiChild as ReportForms.IReport;
            if (Report != null)
            {
                Report.PrintReport();
                toolStripStatusLabel.Text = "Saved";
            }
            else
                toolStripStatusLabel.Text = "Failed to save report!";
            //statusBarToolStripMenuItem.Invalidate();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ReportForms.RezervariReports rezervariReport = new ReportForms.RezervariReports(CompanieAeriana);
            rezervariReport.MdiParent = this;
            rezervariReport.Text = "Window Rapoarte Rezervări " + clientiReportFormNumber++;
            rezervariReport.Show();
            toolStripStatusLabel.Text = "Report Windows Created";
        }

        private void ReportManager_Load(object sender, EventArgs e)
        {

        }
    }
}
