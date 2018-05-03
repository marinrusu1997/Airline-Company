namespace Proiect_PAW.Rezervari_Forms
{
    partial class AdaugaRezervare
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.rezervareUserControl1 = new Proiect_PAW.Rezervari_Forms.RezervareUserControl();
            this.clientUserControl1 = new Proiect_PAW.ClientUserControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Persoană";
            // 
            // btnAdauga
            // 
            this.btnAdauga.AutoSize = true;
            this.btnAdauga.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdauga.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(355, 405);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(76, 33);
            this.btnAdauga.TabIndex = 9;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // rezervareUserControl1
            // 
            this.rezervareUserControl1.CompanieAeriana = null;
            this.rezervareUserControl1.Location = new System.Drawing.Point(162, 3);
            this.rezervareUserControl1.Name = "rezervareUserControl1";
            this.rezervareUserControl1.Size = new System.Drawing.Size(399, 117);
            this.rezervareUserControl1.TabIndex = 7;
            // 
            // clientUserControl1
            // 
            this.clientUserControl1.Location = new System.Drawing.Point(186, 145);
            this.clientUserControl1.Name = "clientUserControl1";
            this.clientUserControl1.Persoana = null;
            this.clientUserControl1.Size = new System.Drawing.Size(355, 254);
            this.clientUserControl1.TabIndex = 6;
            // 
            // AdaugaRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rezervareUserControl1);
            this.Controls.Add(this.clientUserControl1);
            this.Name = "AdaugaRezervare";
            this.Text = "AdaugaRezervare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ClientUserControl clientUserControl1;
        private RezervareUserControl rezervareUserControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdauga;
    }
}