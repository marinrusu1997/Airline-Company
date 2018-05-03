namespace Proiect_PAW
{
    partial class AdaugaRuta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaRuta));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errProvRuta = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipButtons = new System.Windows.Forms.ToolTip(this.components);
            this.dateRutaUsrControl1 = new Proiect_PAW.DateRutaUsrControl();
            ((System.ComponentModel.ISupportInitialize)(this.errProvRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rută Aeriană";
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Silver;
            this.btnAdauga.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(302, 324);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(123, 34);
            this.btnAdauga.TabIndex = 13;
            this.btnAdauga.Text = "Adaugă Rută";
            this.toolTipButtons.SetToolTip(this.btnAdauga, "Adaugă o ruta nouă împreună cu zborurile care au\r\nfost adăugate pentru această ru" +
        "ta.După adăugare \r\nlista de zboruri se resetează");
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(505, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.toolTipButtons.SetToolTip(this.btnCancel, "Termină procesul de adăugare a unor noi rute");
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // errProvRuta
            // 
            this.errProvRuta.ContainerControl = this;
            // 
            // dateRutaUsrControl1
            // 
            this.dateRutaUsrControl1.BackColor = System.Drawing.Color.Transparent;
            this.dateRutaUsrControl1.Location = new System.Drawing.Point(200, 70);
            this.dateRutaUsrControl1.Name = "dateRutaUsrControl1";
            this.dateRutaUsrControl1.Size = new System.Drawing.Size(394, 235);
            this.dateRutaUsrControl1.TabIndex = 19;
            // 
            // AdaugaRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateRutaUsrControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdaugaRuta";
            this.Text = "Adaugă Rută Aeriană";
            ((System.ComponentModel.ISupportInitialize)(this.errProvRuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errProvRuta;
        private System.Windows.Forms.ToolTip toolTipButtons;
        private DateRutaUsrControl dateRutaUsrControl1;
    }
}