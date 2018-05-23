namespace Proiect_PAW.Rezervari_Forms
{
    partial class RezervariConfigurare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervariConfigurare));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRuta = new System.Windows.Forms.ComboBox();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.cbZbor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPersoana = new System.Windows.Forms.ComboBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRezervare = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rezervareUserControl1 = new Proiect_PAW.Rezervari_Forms.RezervareUserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rută Aeriană";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dată Zbor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zbor";
            // 
            // cbRuta
            // 
            this.cbRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRuta.FormattingEnabled = true;
            this.cbRuta.Location = new System.Drawing.Point(254, 37);
            this.cbRuta.Name = "cbRuta";
            this.cbRuta.Size = new System.Drawing.Size(262, 21);
            this.cbRuta.TabIndex = 4;
            this.cbRuta.SelectedIndexChanged += new System.EventHandler(this.cbRuta_SelectedIndexChanged);
            // 
            // cbData
            // 
            this.cbData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(254, 63);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(262, 21);
            this.cbData.TabIndex = 5;
            this.cbData.SelectedIndexChanged += new System.EventHandler(this.cbData_SelectedIndexChanged);
            // 
            // cbZbor
            // 
            this.cbZbor.FormattingEnabled = true;
            this.cbZbor.Location = new System.Drawing.Point(254, 89);
            this.cbZbor.Name = "cbZbor";
            this.cbZbor.Size = new System.Drawing.Size(262, 21);
            this.cbZbor.TabIndex = 6;
            this.cbZbor.SelectedIndexChanged += new System.EventHandler(this.cbZbor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rezervare";
            // 
            // cbPersoana
            // 
            this.cbPersoana.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPersoana.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPersoana.FormattingEnabled = true;
            this.cbPersoana.Location = new System.Drawing.Point(254, 115);
            this.cbPersoana.Name = "cbPersoana";
            this.cbPersoana.Size = new System.Drawing.Size(262, 21);
            this.cbPersoana.TabIndex = 8;
            this.cbPersoana.SelectedIndexChanged += new System.EventHandler(this.cbPersoana_SelectedIndexChanged);
            // 
            // btnModifica
            // 
            this.btnModifica.AutoSize = true;
            this.btnModifica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModifica.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(218, 319);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(76, 33);
            this.btnModifica.TabIndex = 9;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.AutoSize = true;
            this.btnSterge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSterge.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(416, 319);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(62, 33);
            this.btnSterge.TabIndex = 10;
            this.btnSterge.Text = "Șterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Persoană";
            // 
            // tbRezervare
            // 
            this.tbRezervare.Location = new System.Drawing.Point(254, 141);
            this.tbRezervare.Name = "tbRezervare";
            this.tbRezervare.ReadOnly = true;
            this.tbRezervare.Size = new System.Drawing.Size(262, 20);
            this.tbRezervare.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selectați Rezervarea";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Configurare Rezervare";
            // 
            // rezervareUserControl1
            // 
            this.rezervareUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.rezervareUserControl1.CompanieAeriana = null;
            this.rezervareUserControl1.Location = new System.Drawing.Point(129, 190);
            this.rezervareUserControl1.Name = "rezervareUserControl1";
            this.rezervareUserControl1.Size = new System.Drawing.Size(405, 123);
            this.rezervareUserControl1.TabIndex = 0;
            // 
            // RezervariConfigurare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 368);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbRezervare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.cbPersoana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbZbor);
            this.Controls.Add(this.cbData);
            this.Controls.Add(this.cbRuta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rezervareUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RezervariConfigurare";
            this.Text = "Rezervări Configurare";
            this.Load += new System.EventHandler(this.RezervariConfigurare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RezervareUserControl rezervareUserControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRuta;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.ComboBox cbZbor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPersoana;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRezervare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}