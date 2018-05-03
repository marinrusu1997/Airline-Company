namespace Proiect_PAW
{
    partial class ModificaRuta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaRuta));
            this.label1 = new System.Windows.Forms.Label();
            this.cbRute = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbModifZboruri = new System.Windows.Forms.RadioButton();
            this.rbModifAerop = new System.Windows.Forms.RadioButton();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbDateZbor = new System.Windows.Forms.ComboBox();
            this.cbZboruri = new System.Windows.Forms.ComboBox();
            this.labelDataZbor = new System.Windows.Forms.Label();
            this.labelZbor = new System.Windows.Forms.Label();
            this.adaugaZboruriUsrControl1 = new Proiect_PAW.AdaugaZboruriUsrControl();
            this.dateRutaUsrControl1 = new Proiect_PAW.DateRutaUsrControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectează Rută";
            // 
            // cbRute
            // 
            this.cbRute.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRute.FormattingEnabled = true;
            this.cbRute.Location = new System.Drawing.Point(295, 18);
            this.cbRute.Name = "cbRute";
            this.cbRute.Size = new System.Drawing.Size(281, 27);
            this.cbRute.TabIndex = 2;
            this.cbRute.SelectedIndexChanged += new System.EventHandler(this.cbRute_SelectedIndexChanged);
            this.cbRute.DataSourceChanged += new System.EventHandler(this.cbRute_DataSourceChanged);
            this.cbRute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbRute_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbModifZboruri);
            this.groupBox1.Controls.Add(this.rbModifAerop);
            this.groupBox1.Location = new System.Drawing.Point(295, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 34);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbModifZboruri
            // 
            this.rbModifZboruri.AutoSize = true;
            this.rbModifZboruri.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModifZboruri.Location = new System.Drawing.Point(171, 12);
            this.rbModifZboruri.Name = "rbModifZboruri";
            this.rbModifZboruri.Size = new System.Drawing.Size(104, 17);
            this.rbModifZboruri.TabIndex = 1;
            this.rbModifZboruri.TabStop = true;
            this.rbModifZboruri.Text = "Modifică Zboruri";
            this.rbModifZboruri.UseVisualStyleBackColor = true;
            this.rbModifZboruri.CheckedChanged += new System.EventHandler(this.rbModifZboruri_CheckedChanged);
            // 
            // rbModifAerop
            // 
            this.rbModifAerop.AutoSize = true;
            this.rbModifAerop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModifAerop.Location = new System.Drawing.Point(6, 12);
            this.rbModifAerop.Name = "rbModifAerop";
            this.rbModifAerop.Size = new System.Drawing.Size(124, 17);
            this.rbModifAerop.TabIndex = 0;
            this.rbModifAerop.TabStop = true;
            this.rbModifAerop.Text = "Modifică Aeroporturi";
            this.rbModifAerop.UseVisualStyleBackColor = true;
            this.rbModifAerop.CheckedChanged += new System.EventHandler(this.rbModifAerop_CheckedChanged);
            // 
            // btnModifica
            // 
            this.btnModifica.AutoSize = true;
            this.btnModifica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModifica.Font = new System.Drawing.Font("Rockwell Nova", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(295, 332);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(85, 31);
            this.btnModifica.TabIndex = 5;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Font = new System.Drawing.Font("Rockwell Nova", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(457, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbDateZbor
            // 
            this.cbDateZbor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDateZbor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDateZbor.FormattingEnabled = true;
            this.cbDateZbor.Location = new System.Drawing.Point(295, 91);
            this.cbDateZbor.Name = "cbDateZbor";
            this.cbDateZbor.Size = new System.Drawing.Size(281, 21);
            this.cbDateZbor.TabIndex = 7;
            this.cbDateZbor.SelectedIndexChanged += new System.EventHandler(this.cbDateZbor_SelectedIndexChanged);
            this.cbDateZbor.DataSourceChanged += new System.EventHandler(this.cbDateZbor_DataSourceChanged);
            // 
            // cbZboruri
            // 
            this.cbZboruri.FormattingEnabled = true;
            this.cbZboruri.Location = new System.Drawing.Point(295, 114);
            this.cbZboruri.Name = "cbZboruri";
            this.cbZboruri.Size = new System.Drawing.Size(281, 21);
            this.cbZboruri.TabIndex = 8;
            this.cbZboruri.SelectedIndexChanged += new System.EventHandler(this.cbZboruri_SelectedIndexChanged);
            this.cbZboruri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbZboruri_KeyPress);
            // 
            // labelDataZbor
            // 
            this.labelDataZbor.AutoSize = true;
            this.labelDataZbor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataZbor.Location = new System.Drawing.Point(179, 94);
            this.labelDataZbor.Name = "labelDataZbor";
            this.labelDataZbor.Size = new System.Drawing.Size(71, 13);
            this.labelDataZbor.TabIndex = 9;
            this.labelDataZbor.Text = "Dată Zbor";
            // 
            // labelZbor
            // 
            this.labelZbor.AutoSize = true;
            this.labelZbor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZbor.Location = new System.Drawing.Point(179, 117);
            this.labelZbor.Name = "labelZbor";
            this.labelZbor.Size = new System.Drawing.Size(37, 13);
            this.labelZbor.TabIndex = 10;
            this.labelZbor.Text = "Zbor";
            // 
            // adaugaZboruriUsrControl1
            // 
            this.adaugaZboruriUsrControl1.BackColor = System.Drawing.Color.Transparent;
            this.adaugaZboruriUsrControl1.Location = new System.Drawing.Point(182, 158);
            this.adaugaZboruriUsrControl1.Name = "adaugaZboruriUsrControl1";
            this.adaugaZboruriUsrControl1.Size = new System.Drawing.Size(470, 150);
            this.adaugaZboruriUsrControl1.TabIndex = 4;
            // 
            // dateRutaUsrControl1
            // 
            this.dateRutaUsrControl1.BackColor = System.Drawing.Color.Transparent;
            this.dateRutaUsrControl1.Location = new System.Drawing.Point(182, 91);
            this.dateRutaUsrControl1.Name = "dateRutaUsrControl1";
            this.dateRutaUsrControl1.Size = new System.Drawing.Size(394, 235);
            this.dateRutaUsrControl1.TabIndex = 0;
            // 
            // ModificaRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelZbor);
            this.Controls.Add(this.labelDataZbor);
            this.Controls.Add(this.cbZboruri);
            this.Controls.Add(this.cbDateZbor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.adaugaZboruriUsrControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbRute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateRutaUsrControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificaRuta";
            this.Text = "Modifică Rută";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModificaRuta_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateRutaUsrControl dateRutaUsrControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbModifZboruri;
        private System.Windows.Forms.RadioButton rbModifAerop;
        private AdaugaZboruriUsrControl adaugaZboruriUsrControl1;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbDateZbor;
        private System.Windows.Forms.ComboBox cbZboruri;
        private System.Windows.Forms.Label labelDataZbor;
        private System.Windows.Forms.Label labelZbor;
    }
}