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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MeniuPrincipal = new System.Windows.Forms.MenuStrip();
            this.companieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateDeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MeniuPrincipal.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.saveToolStripMenuItem,
            this.incarToolStripMenuItem,
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
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveToolStripMenuItem.Text = "Save Rezervari";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveRezervariToolStripMenuItem_Click);
            // 
            // incarToolStripMenuItem
            // 
            this.incarToolStripMenuItem.Name = "incarToolStripMenuItem";
            this.incarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.incarToolStripMenuItem.Text = "Load Rezervari";
            this.incarToolStripMenuItem.Click += new System.EventHandler(this.incarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.closeToolStripMenuItem.Text = "Close";
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
            this.adaugaClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaClientToolStripMenuItem.Text = "Adauga Client";
            this.adaugaClientToolStripMenuItem.Click += new System.EventHandler(this.adaugaClientToolStripMenuItem_Click);
            // 
            // vizualizeazaClientiToolStripMenuItem
            // 
            this.vizualizeazaClientiToolStripMenuItem.Name = "vizualizeazaClientiToolStripMenuItem";
            this.vizualizeazaClientiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.adaugaRezervareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaRezervareToolStripMenuItem.Text = "Adauga Rezervare";
            this.adaugaRezervareToolStripMenuItem.Click += new System.EventHandler(this.adaugaRezervareToolStripMenuItem_Click);
            // 
            // stergeRezervareToolStripMenuItem
            // 
            this.stergeRezervareToolStripMenuItem.Name = "stergeRezervareToolStripMenuItem";
            this.stergeRezervareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergeRezervareToolStripMenuItem.Text = "Sterge Rezervare";
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
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MeniuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MeniuPrincipal;
            this.Name = "MainWindow";
            this.Text = "Air Moldova";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MeniuPrincipal.ResumeLayout(false);
            this.MeniuPrincipal.PerformLayout();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarToolStripMenuItem;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

