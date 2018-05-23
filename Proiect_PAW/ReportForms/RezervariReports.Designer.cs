namespace Proiect_PAW.ReportForms
{
    partial class RezervariReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervariReports));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxRute = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxData = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxZbor = new System.Windows.Forms.ToolStripComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RezervareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersoanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RezervareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersoanaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxRute,
            this.toolStripComboBoxData,
            this.toolStripComboBoxZbor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBoxRute
            // 
            this.toolStripComboBoxRute.Name = "toolStripComboBoxRute";
            this.toolStripComboBoxRute.Size = new System.Drawing.Size(250, 25);
            this.toolStripComboBoxRute.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxRute_SelectedIndexChanged);
            this.toolStripComboBoxRute.Click += new System.EventHandler(this.toolStripComboBoxRute_Click);
            // 
            // toolStripComboBoxData
            // 
            this.toolStripComboBoxData.Name = "toolStripComboBoxData";
            this.toolStripComboBoxData.Size = new System.Drawing.Size(200, 25);
            this.toolStripComboBoxData.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxData_SelectedIndexChanged);
            // 
            // toolStripComboBoxZbor
            // 
            this.toolStripComboBoxZbor.Name = "toolStripComboBoxZbor";
            this.toolStripComboBoxZbor.Size = new System.Drawing.Size(250, 25);
            this.toolStripComboBoxZbor.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxZbor_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proiect_PAW.ReportForms.Reports.Rezervari.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 425);
            this.reportViewer1.TabIndex = 1;
            // 
            // RezervareBindingSource
            // 
            this.RezervareBindingSource.DataSource = typeof(Proiect_PAW.Rezervare);
            // 
            // PersoanaBindingSource
            // 
            this.PersoanaBindingSource.DataSource = typeof(Proiect_PAW.Persoana);
            // 
            // RezervariReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RezervariReports";
            this.Text = "Rapoarte Rezervări";
            this.Load += new System.EventHandler(this.RezervariReports_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RezervareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersoanaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxRute;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxData;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxZbor;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RezervareBindingSource;
        private System.Windows.Forms.BindingSource PersoanaBindingSource;
    }
}