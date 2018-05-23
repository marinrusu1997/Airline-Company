namespace Proiect_PAW.Report_Forms
{
    partial class ClientiReports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientiReports));
            this.dataTableClientiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClienti = new Proiect_PAW.Data_Sets.DataSetClienti();
            this.RezervareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersoanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableClientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableClientiTableAdapter = new Proiect_PAW.Data_Sets.DataSetClientiTableAdapters.DataTableClientiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClientiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersoanaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClientiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableClientiBindingSource1
            // 
            this.dataTableClientiBindingSource1.DataMember = "DataTableClienti";
            this.dataTableClientiBindingSource1.DataSource = this.dataSetClientiBindingSource;
            // 
            // dataSetClientiBindingSource
            // 
            this.dataSetClientiBindingSource.DataSource = this.dataSetClienti;
            this.dataSetClientiBindingSource.Position = 0;
            // 
            // dataSetClienti
            // 
            this.dataSetClienti.DataSetName = "DataSetClienti";
            this.dataSetClienti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RezervareBindingSource
            // 
            this.RezervareBindingSource.DataSource = typeof(Proiect_PAW.Rezervare);
            // 
            // PersoanaBindingSource
            // 
            this.PersoanaBindingSource.DataSource = typeof(Proiect_PAW.Persoana);
            // 
            // dataTableClientiBindingSource
            // 
            this.dataTableClientiBindingSource.DataMember = "DataTableClienti";
            this.dataTableClientiBindingSource.DataSource = this.dataSetClientiBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetClienti";
            reportDataSource1.Value = this.dataTableClientiBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proiect_PAW.ReportForms.Reports.ClientiTotal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTableClientiTableAdapter
            // 
            this.dataTableClientiTableAdapter.ClearBeforeFill = true;
            // 
            // ClientiReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientiReports";
            this.Text = "Rapoarte Clienți";
            this.Load += new System.EventHandler(this.ClientiReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClientiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersoanaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClientiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Data_Sets.DataSetClienti dataSetClienti;
        private System.Windows.Forms.BindingSource dataSetClientiBindingSource;
        private System.Windows.Forms.BindingSource dataTableClientiBindingSource;
        private Data_Sets.DataSetClientiTableAdapters.DataTableClientiTableAdapter dataTableClientiTableAdapter;
        private System.Windows.Forms.BindingSource RezervareBindingSource;
        private System.Windows.Forms.BindingSource PersoanaBindingSource;
        private System.Windows.Forms.BindingSource dataTableClientiBindingSource1;
    }
}