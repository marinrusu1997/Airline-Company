namespace Proiect_PAW
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MeniuPrincipal = new System.Windows.Forms.MenuStrip();
            this.companieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateDeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizeazaClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valoriDiscountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaRutaNouaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaZboruriRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStripRute = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redeseneazăRuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTitlu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MeniuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStripRute.SuspendLayout();
            this.panelTitlu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MeniuPrincipal
            // 
            this.MeniuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companieToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.rezervariToolStripMenuItem,
            this.discountsToolStripMenuItem,
            this.ruteToolStripMenuItem,
            this.diagnosticToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MeniuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MeniuPrincipal.Name = "MeniuPrincipal";
            this.MeniuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MeniuPrincipal.TabIndex = 1;
            this.MeniuPrincipal.Text = "menuStrip1";
            // 
            // companieToolStripMenuItem
            // 
            this.companieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateDeContactToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.companieToolStripMenuItem.Name = "companieToolStripMenuItem";
            this.companieToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.companieToolStripMenuItem.Text = "Companie";
            // 
            // dateDeContactToolStripMenuItem
            // 
            this.dateDeContactToolStripMenuItem.Name = "dateDeContactToolStripMenuItem";
            this.dateDeContactToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dateDeContactToolStripMenuItem.Text = "Date Companie";
            this.dateDeContactToolStripMenuItem.Click += new System.EventHandler(this.dateDeContactToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaClientToolStripMenuItem,
            this.vizualizeazaClientiToolStripMenuItem});
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.clientiToolStripMenuItem.Text = "Clienti";
            // 
            // adaugaClientToolStripMenuItem
            // 
            this.adaugaClientToolStripMenuItem.Name = "adaugaClientToolStripMenuItem";
            this.adaugaClientToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.adaugaClientToolStripMenuItem.Text = "Adauga Client";
            this.adaugaClientToolStripMenuItem.Click += new System.EventHandler(this.adaugaClientToolStripMenuItem_Click);
            // 
            // vizualizeazaClientiToolStripMenuItem
            // 
            this.vizualizeazaClientiToolStripMenuItem.Name = "vizualizeazaClientiToolStripMenuItem";
            this.vizualizeazaClientiToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.vizualizeazaClientiToolStripMenuItem.Text = "Gestioneaza Clienti";
            this.vizualizeazaClientiToolStripMenuItem.Click += new System.EventHandler(this.vizualizeazaClientiToolStripMenuItem_Click);
            // 
            // rezervariToolStripMenuItem
            // 
            this.rezervariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaRezervareToolStripMenuItem,
            this.stergeRezervareToolStripMenuItem});
            this.rezervariToolStripMenuItem.Name = "rezervariToolStripMenuItem";
            this.rezervariToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rezervariToolStripMenuItem.Text = "Rezervari";
            // 
            // adaugaRezervareToolStripMenuItem
            // 
            this.adaugaRezervareToolStripMenuItem.Name = "adaugaRezervareToolStripMenuItem";
            this.adaugaRezervareToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.adaugaRezervareToolStripMenuItem.Text = "Adauga Rezervare";
            this.adaugaRezervareToolStripMenuItem.Click += new System.EventHandler(this.adaugaRezervareToolStripMenuItem_Click);
            // 
            // stergeRezervareToolStripMenuItem
            // 
            this.stergeRezervareToolStripMenuItem.Name = "stergeRezervareToolStripMenuItem";
            this.stergeRezervareToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stergeRezervareToolStripMenuItem.Text = "Configurare";
            this.stergeRezervareToolStripMenuItem.Click += new System.EventHandler(this.stergeRezervareToolStripMenuItem_Click);
            // 
            // discountsToolStripMenuItem
            // 
            this.discountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valoriDiscountToolStripMenuItem,
            this.configurareToolStripMenuItem});
            this.discountsToolStripMenuItem.Name = "discountsToolStripMenuItem";
            this.discountsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.discountsToolStripMenuItem.Text = "Discounts";
            // 
            // valoriDiscountToolStripMenuItem
            // 
            this.valoriDiscountToolStripMenuItem.Name = "valoriDiscountToolStripMenuItem";
            this.valoriDiscountToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.valoriDiscountToolStripMenuItem.Text = "Setează Discounturi";
            this.valoriDiscountToolStripMenuItem.Click += new System.EventHandler(this.valoriDiscountToolStripMenuItem_Click);
            // 
            // configurareToolStripMenuItem
            // 
            this.configurareToolStripMenuItem.Name = "configurareToolStripMenuItem";
            this.configurareToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.configurareToolStripMenuItem.Text = "Configurare";
            this.configurareToolStripMenuItem.Click += new System.EventHandler(this.configurareToolStripMenuItem_Click);
            // 
            // ruteToolStripMenuItem
            // 
            this.ruteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaRutaToolStripMenuItem,
            this.stergeRutaToolStripMenuItem,
            this.modificaRutaToolStripMenuItem});
            this.ruteToolStripMenuItem.Name = "ruteToolStripMenuItem";
            this.ruteToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ruteToolStripMenuItem.Text = "Rute";
            // 
            // adaugaRutaToolStripMenuItem
            // 
            this.adaugaRutaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaRutaNouaToolStripMenuItem,
            this.adaugaZboruriRutaToolStripMenuItem});
            this.adaugaRutaToolStripMenuItem.Name = "adaugaRutaToolStripMenuItem";
            this.adaugaRutaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.adaugaRutaToolStripMenuItem.Text = "Adauga Ruta";
            // 
            // adaugaRutaNouaToolStripMenuItem
            // 
            this.adaugaRutaNouaToolStripMenuItem.Name = "adaugaRutaNouaToolStripMenuItem";
            this.adaugaRutaNouaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.adaugaRutaNouaToolStripMenuItem.Text = "Adauga Ruta Noua";
            this.adaugaRutaNouaToolStripMenuItem.Click += new System.EventHandler(this.adaugaRutaNouaToolStripMenuItem_Click);
            // 
            // adaugaZboruriRutaToolStripMenuItem
            // 
            this.adaugaZboruriRutaToolStripMenuItem.Name = "adaugaZboruriRutaToolStripMenuItem";
            this.adaugaZboruriRutaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.adaugaZboruriRutaToolStripMenuItem.Text = "Adauga Zboruri Ruta";
            this.adaugaZboruriRutaToolStripMenuItem.Click += new System.EventHandler(this.adaugaZboruriRutaToolStripMenuItem_Click);
            // 
            // stergeRutaToolStripMenuItem
            // 
            this.stergeRutaToolStripMenuItem.Name = "stergeRutaToolStripMenuItem";
            this.stergeRutaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.stergeRutaToolStripMenuItem.Text = "Sterge Ruta";
            this.stergeRutaToolStripMenuItem.Click += new System.EventHandler(this.stergeRutaToolStripMenuItem_Click);
            // 
            // modificaRutaToolStripMenuItem
            // 
            this.modificaRutaToolStripMenuItem.Name = "modificaRutaToolStripMenuItem";
            this.modificaRutaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.modificaRutaToolStripMenuItem.Text = "Modifica Ruta";
            this.modificaRutaToolStripMenuItem.Click += new System.EventHandler(this.modificaRutaToolStripMenuItem_Click);
            // 
            // diagnosticToolStripMenuItem
            // 
            this.diagnosticToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagrameToolStripMenuItem,
            this.rapoarteToolStripMenuItem1});
            this.diagnosticToolStripMenuItem.Name = "diagnosticToolStripMenuItem";
            this.diagnosticToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.diagnosticToolStripMenuItem.Text = "Diagnostic";
            // 
            // diagrameToolStripMenuItem
            // 
            this.diagrameToolStripMenuItem.Name = "diagrameToolStripMenuItem";
            this.diagrameToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.diagrameToolStripMenuItem.Text = "Diagrame";
            this.diagrameToolStripMenuItem.Click += new System.EventHandler(this.diagrameToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem1
            // 
            this.rapoarteToolStripMenuItem1.Name = "rapoarteToolStripMenuItem1";
            this.rapoarteToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.rapoarteToolStripMenuItem1.Text = "Rapoarte";
            this.rapoarteToolStripMenuItem1.Click += new System.EventHandler(this.rapoarteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStripRute;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStripRute
            // 
            this.contextMenuStripRute.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redeseneazăRuteToolStripMenuItem});
            this.contextMenuStripRute.Name = "contextMenuStripRute";
            this.contextMenuStripRute.Size = new System.Drawing.Size(169, 26);
            // 
            // redeseneazăRuteToolStripMenuItem
            // 
            this.redeseneazăRuteToolStripMenuItem.Name = "redeseneazăRuteToolStripMenuItem";
            this.redeseneazăRuteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.redeseneazăRuteToolStripMenuItem.Text = "Redesenează Rute";
            this.redeseneazăRuteToolStripMenuItem.Click += new System.EventHandler(this.redeseneazăRuteToolStripMenuItem_Click);
            // 
            // panelTitlu
            // 
            this.panelTitlu.AutoScroll = true;
            this.panelTitlu.BackColor = System.Drawing.Color.SkyBlue;
            this.panelTitlu.Controls.Add(this.flowLayoutPanel1);
            this.panelTitlu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitlu.Location = new System.Drawing.Point(0, 24);
            this.panelTitlu.Name = "panelTitlu";
            this.panelTitlu.Size = new System.Drawing.Size(800, 426);
            this.panelTitlu.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTitlu);
            this.Controls.Add(this.MeniuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MeniuPrincipal;
            this.Name = "MainWindow";
            this.Text = "Air Moldova";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.MeniuPrincipal.ResumeLayout(false);
            this.MeniuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStripRute.ResumeLayout(false);
            this.panelTitlu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MeniuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem companieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateDeContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizeazaClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaRezervareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeRezervareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valoriDiscountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaRutaNouaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaZboruriRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitlu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRute;
        private System.Windows.Forms.ToolStripMenuItem redeseneazăRuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem1;
    }
}

