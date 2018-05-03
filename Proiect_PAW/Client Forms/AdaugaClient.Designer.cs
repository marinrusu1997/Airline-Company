namespace Proiect_PAW
{
    partial class AdaugaClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaClient));
            this.btnAdauga = new System.Windows.Forms.Button();
            this.clientUserControl1 = new Proiect_PAW.ClientUserControl();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.AutoSize = true;
            this.btnAdauga.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdauga.Font = new System.Drawing.Font("Rockwell Nova", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(221, 292);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(79, 31);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // clientUserControl1
            // 
            this.clientUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.clientUserControl1.Location = new System.Drawing.Point(24, 12);
            this.clientUserControl1.Name = "clientUserControl1";
            this.clientUserControl1.Size = new System.Drawing.Size(505, 260);
            this.clientUserControl1.TabIndex = 0;
            // 
            // AdaugaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(541, 362);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.clientUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdaugaClient";
            this.Text = "Adaugă Client";
            this.Load += new System.EventHandler(this.AdaugaClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClientUserControl clientUserControl1;
        private System.Windows.Forms.Button btnAdauga;
    }
}