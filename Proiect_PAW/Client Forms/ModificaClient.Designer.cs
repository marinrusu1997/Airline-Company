namespace Proiect_PAW.Client_Forms
{
    partial class ModificaClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaClient));
            this.clientUserControl1 = new Proiect_PAW.ClientUserControl();
            this.btnModifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientUserControl1
            // 
            this.clientUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.clientUserControl1.Persoana = null;
            this.clientUserControl1.Location = new System.Drawing.Point(12, 12);
            this.clientUserControl1.Name = "clientUserControl1";
            this.clientUserControl1.Size = new System.Drawing.Size(560, 253);
            this.clientUserControl1.TabIndex = 0;
            // 
            // btnModifica
            // 
            this.btnModifica.AutoSize = true;
            this.btnModifica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModifica.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModifica.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(132, 281);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(90, 38);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // ModificaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(354, 353);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.clientUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModificaClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modifică Client";
            this.Load += new System.EventHandler(this.ModificaClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClientUserControl clientUserControl1;
        private System.Windows.Forms.Button btnModifica;
    }
}