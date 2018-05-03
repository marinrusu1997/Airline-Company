namespace Proiect_PAW
{
    partial class GestioneazaClienti
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
            this.lvClienti = new System.Windows.Forms.ListView();
            this.NumeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrenumeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CetatenieHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NrPasaportHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataNastereHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CnpHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelefonHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnMenuStripClienti = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cetatenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.literaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.litereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.litereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSearchTb = new System.Windows.Forms.ToolStripTextBox();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cnMenuStripClienti.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvClienti
            // 
            this.lvClienti.CheckBoxes = true;
            this.lvClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumeHeader,
            this.PrenumeHeader,
            this.CetatenieHeader,
            this.NrPasaportHeader,
            this.DataNastereHeader,
            this.CnpHeader,
            this.SexHeader,
            this.TelefonHeader,
            this.EmailHeader});
            this.lvClienti.ContextMenuStrip = this.cnMenuStripClienti;
            this.lvClienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvClienti.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClienti.FullRowSelect = true;
            this.lvClienti.GridLines = true;
            this.lvClienti.Location = new System.Drawing.Point(0, 0);
            this.lvClienti.Name = "lvClienti";
            this.lvClienti.Size = new System.Drawing.Size(800, 450);
            this.lvClienti.TabIndex = 0;
            this.lvClienti.UseCompatibleStateImageBehavior = false;
            this.lvClienti.View = System.Windows.Forms.View.Details;
            this.lvClienti.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvClienti_ColumnClick);
            this.lvClienti.SelectedIndexChanged += new System.EventHandler(this.lvClienti_SelectedIndexChanged);
            // 
            // NumeHeader
            // 
            this.NumeHeader.Text = "Nume";
            this.NumeHeader.Width = 84;
            // 
            // PrenumeHeader
            // 
            this.PrenumeHeader.Text = "Prenume";
            this.PrenumeHeader.Width = 90;
            // 
            // CetatenieHeader
            // 
            this.CetatenieHeader.Text = "Cetățenie";
            this.CetatenieHeader.Width = 131;
            // 
            // NrPasaportHeader
            // 
            this.NrPasaportHeader.Text = "Număr Pașaport";
            this.NrPasaportHeader.Width = 83;
            // 
            // DataNastereHeader
            // 
            this.DataNastereHeader.Text = "Dată Naștere";
            this.DataNastereHeader.Width = 59;
            // 
            // CnpHeader
            // 
            this.CnpHeader.Text = "CNP";
            this.CnpHeader.Width = 62;
            // 
            // SexHeader
            // 
            this.SexHeader.Text = "Sex";
            this.SexHeader.Width = 44;
            // 
            // TelefonHeader
            // 
            this.TelefonHeader.Text = "Telefon";
            this.TelefonHeader.Width = 52;
            // 
            // EmailHeader
            // 
            this.EmailHeader.Text = "Email";
            this.EmailHeader.Width = 49;
            // 
            // cnMenuStripClienti
            // 
            this.cnMenuStripClienti.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnMenuStripClienti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.grupeazaToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.cnMenuStripClienti.Name = "cnMenuStripClienti";
            this.cnMenuStripClienti.Size = new System.Drawing.Size(181, 114);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificaToolStripMenuItem.Text = "Modifică";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergeToolStripMenuItem.Text = "Șterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // grupeazaToolStripMenuItem
            // 
            this.grupeazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cetatenieToolStripMenuItem,
            this.numeToolStripMenuItem,
            this.sexToolStripMenuItem});
            this.grupeazaToolStripMenuItem.Name = "grupeazaToolStripMenuItem";
            this.grupeazaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grupeazaToolStripMenuItem.Text = "Grupează";
            // 
            // cetatenieToolStripMenuItem
            // 
            this.cetatenieToolStripMenuItem.Name = "cetatenieToolStripMenuItem";
            this.cetatenieToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cetatenieToolStripMenuItem.Text = "Cetățenie";
            this.cetatenieToolStripMenuItem.Click += new System.EventHandler(this.cetatenieToolStripMenuItem_Click);
            // 
            // numeToolStripMenuItem
            // 
            this.numeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.literaToolStripMenuItem,
            this.litereToolStripMenuItem,
            this.litereToolStripMenuItem1});
            this.numeToolStripMenuItem.Name = "numeToolStripMenuItem";
            this.numeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.numeToolStripMenuItem.Text = "Nume";
            // 
            // literaToolStripMenuItem
            // 
            this.literaToolStripMenuItem.Name = "literaToolStripMenuItem";
            this.literaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.literaToolStripMenuItem.Text = "1 Litera";
            this.literaToolStripMenuItem.Click += new System.EventHandler(this.literaToolStripMenuItem_Click);
            // 
            // litereToolStripMenuItem
            // 
            this.litereToolStripMenuItem.Name = "litereToolStripMenuItem";
            this.litereToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.litereToolStripMenuItem.Text = "2 Litere";
            this.litereToolStripMenuItem.Click += new System.EventHandler(this.litereToolStripMenuItem_Click);
            // 
            // litereToolStripMenuItem1
            // 
            this.litereToolStripMenuItem1.Name = "litereToolStripMenuItem1";
            this.litereToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.litereToolStripMenuItem1.Text = "3 Litere";
            this.litereToolStripMenuItem1.Click += new System.EventHandler(this.litereToolStripMenuItem1_Click);
            // 
            // sexToolStripMenuItem
            // 
            this.sexToolStripMenuItem.Name = "sexToolStripMenuItem";
            this.sexToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sexToolStripMenuItem.Text = "Sex";
            this.sexToolStripMenuItem.Click += new System.EventHandler(this.sexToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSearchTb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripSearchTb
            // 
            this.toolStripSearchTb.Name = "toolStripSearchTb";
            this.toolStripSearchTb.Size = new System.Drawing.Size(100, 25);
            this.toolStripSearchTb.ToolTipText = "Search Input String";
            this.toolStripSearchTb.TextChanged += new System.EventHandler(this.toolStripSearchTb_TextChanged);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // GestioneazaClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvClienti);
            this.KeyPreview = true;
            this.Name = "GestioneazaClienti";
            this.Text = "Gestionează Clienți";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestioneazaClienti_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GestioneazaClienti_KeyDown);
            this.cnMenuStripClienti.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvClienti;
        private System.Windows.Forms.ContextMenuStrip cnMenuStripClienti;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader NumeHeader;
        private System.Windows.Forms.ColumnHeader PrenumeHeader;
        private System.Windows.Forms.ColumnHeader CetatenieHeader;
        private System.Windows.Forms.ColumnHeader NrPasaportHeader;
        private System.Windows.Forms.ColumnHeader DataNastereHeader;
        private System.Windows.Forms.ColumnHeader CnpHeader;
        private System.Windows.Forms.ColumnHeader SexHeader;
        private System.Windows.Forms.ColumnHeader TelefonHeader;
        private System.Windows.Forms.ColumnHeader EmailHeader;
        private System.Windows.Forms.ToolStripMenuItem grupeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetatenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem literaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem litereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem litereToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripSearchTb;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}