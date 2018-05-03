namespace Proiect_PAW
{
    partial class AdaugaZboruriRuta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaZboruriRuta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRute = new System.Windows.Forms.ComboBox();
            this.btnAfisZboruri = new System.Windows.Forms.Button();
            this.errProvZbor = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdgZboruri = new System.Windows.Forms.Button();
            this.tvZboruri = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.adaugaZboruriUsrControl = new Proiect_PAW.AdaugaZboruriUsrControl();
            ((System.ComponentModel.ISupportInitialize)(this.errProvZbor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adaugă Zboruri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selectează Rută";
            // 
            // cbRute
            // 
            this.cbRute.FormattingEnabled = true;
            this.cbRute.Location = new System.Drawing.Point(273, 64);
            this.cbRute.Name = "cbRute";
            this.cbRute.Size = new System.Drawing.Size(336, 21);
            this.cbRute.TabIndex = 2;
            this.cbRute.SelectedIndexChanged += new System.EventHandler(this.cbRute_SelectedIndexChanged);
            this.cbRute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbRute_KeyPress);
            // 
            // btnAfisZboruri
            // 
            this.btnAfisZboruri.AutoSize = true;
            this.btnAfisZboruri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAfisZboruri.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisZboruri.Location = new System.Drawing.Point(273, 110);
            this.btnAfisZboruri.Name = "btnAfisZboruri";
            this.btnAfisZboruri.Size = new System.Drawing.Size(130, 33);
            this.btnAfisZboruri.TabIndex = 4;
            this.btnAfisZboruri.Text = "Afișează Zboruri";
            this.toolTip1.SetToolTip(this.btnAfisZboruri, "Afișează zborurile efectuate pe ruta selectată\r\nClick încă odată pentru a ascunde" +
        " afisarea");
            this.btnAfisZboruri.UseVisualStyleBackColor = true;
            this.btnAfisZboruri.Click += new System.EventHandler(this.btnAfisZboruri_Click);
            // 
            // errProvZbor
            // 
            this.errProvZbor.ContainerControl = this;
            // 
            // btnAdgZboruri
            // 
            this.btnAdgZboruri.AutoSize = true;
            this.btnAdgZboruri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdgZboruri.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdgZboruri.Location = new System.Drawing.Point(483, 110);
            this.btnAdgZboruri.Name = "btnAdgZboruri";
            this.btnAdgZboruri.Size = new System.Drawing.Size(126, 33);
            this.btnAdgZboruri.TabIndex = 5;
            this.btnAdgZboruri.Text = "Adaugă Zboruri";
            this.toolTip1.SetToolTip(this.btnAdgZboruri, "Adaugă toate zborurile care au fost introduse pînă \r\nla momentul actual în lista " +
        "de zboruri la ruta selectată\r\n");
            this.btnAdgZboruri.UseVisualStyleBackColor = true;
            this.btnAdgZboruri.Click += new System.EventHandler(this.btnAdgZboruri_Click_1);
            // 
            // tvZboruri
            // 
            this.tvZboruri.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tvZboruri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tvZboruri.Location = new System.Drawing.Point(0, 293);
            this.tvZboruri.Name = "tvZboruri";
            this.tvZboruri.Size = new System.Drawing.Size(800, 157);
            this.tvZboruri.TabIndex = 7;
            this.tvZboruri.Visible = false;
            // 
            // adaugaZboruriUsrControl
            // 
            this.adaugaZboruriUsrControl.BackColor = System.Drawing.Color.Transparent;
            this.adaugaZboruriUsrControl.Location = new System.Drawing.Point(156, 149);
            this.adaugaZboruriUsrControl.Name = "adaugaZboruriUsrControl";
            this.adaugaZboruriUsrControl.Size = new System.Drawing.Size(474, 146);
            this.adaugaZboruriUsrControl.TabIndex = 6;
            // 
            // AdaugaZboruriRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvZboruri);
            this.Controls.Add(this.adaugaZboruriUsrControl);
            this.Controls.Add(this.btnAdgZboruri);
            this.Controls.Add(this.btnAfisZboruri);
            this.Controls.Add(this.cbRute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdaugaZboruriRuta";
            this.Text = "Adaugă Zboruri Rută";
            ((System.ComponentModel.ISupportInitialize)(this.errProvZbor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRute;
        private System.Windows.Forms.Button btnAfisZboruri;
        private System.Windows.Forms.ErrorProvider errProvZbor;
        private System.Windows.Forms.Button btnAdgZboruri;
        private AdaugaZboruriUsrControl adaugaZboruriUsrControl;
        private System.Windows.Forms.TreeView tvZboruri;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}