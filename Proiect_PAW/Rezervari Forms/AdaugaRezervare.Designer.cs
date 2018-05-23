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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaRezervare));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.rezervareUserControl1 = new Proiect_PAW.Rezervari_Forms.RezervareUserControl();
            this.clientUserControl1 = new Proiect_PAW.ClientUserControl();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 176);
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
            this.btnAdauga.Location = new System.Drawing.Point(188, 465);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(76, 33);
            this.btnAdauga.TabIndex = 9;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // rezervareUserControl1
            // 
            this.rezervareUserControl1.BackColor = System.Drawing.Color.Red;
            this.rezervareUserControl1.CompanieAeriana = null;
            this.rezervareUserControl1.Location = new System.Drawing.Point(43, 63);
            this.rezervareUserControl1.Name = "rezervareUserControl1";
            this.rezervareUserControl1.Size = new System.Drawing.Size(399, 117);
            this.rezervareUserControl1.TabIndex = 7;
            // 
            // clientUserControl1
            // 
            this.clientUserControl1.BackColor = System.Drawing.Color.Yellow;
            this.clientUserControl1.Location = new System.Drawing.Point(67, 205);
            this.clientUserControl1.Name = "clientUserControl1";
            this.clientUserControl1.Persoana = null;
            this.clientUserControl1.Size = new System.Drawing.Size(355, 254);
            this.clientUserControl1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adaugă Rezervare";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // AdaugaRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(505, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rezervareUserControl1);
            this.Controls.Add(this.clientUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdaugaRezervare";
            this.Text = "Adaugă Rezervare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ClientUserControl clientUserControl1;
        private RezervareUserControl rezervareUserControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}