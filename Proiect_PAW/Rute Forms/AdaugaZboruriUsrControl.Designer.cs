namespace Proiect_PAW
{
    partial class AdaugaZboruriUsrControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errProvZbor = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelZboruri = new System.Windows.Forms.Panel();
            this.btnResetZboruri = new System.Windows.Forms.Button();
            this.btnResFields = new System.Windows.Forms.Button();
            this.btnAdaugaZbor = new System.Windows.Forms.Button();
            this.numericNrLocuri = new System.Windows.Forms.NumericUpDown();
            this.numericCost = new System.Windows.Forms.NumericUpDown();
            this.dateAterizare = new System.Windows.Forms.DateTimePicker();
            this.dateDecolare = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvZbor)).BeginInit();
            this.panelZboruri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNrLocuri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCost)).BeginInit();
            this.SuspendLayout();
            // 
            // errProvZbor
            // 
            this.errProvZbor.ContainerControl = this;
            // 
            // panelZboruri
            // 
            this.panelZboruri.Controls.Add(this.btnResetZboruri);
            this.panelZboruri.Controls.Add(this.btnResFields);
            this.panelZboruri.Controls.Add(this.btnAdaugaZbor);
            this.panelZboruri.Controls.Add(this.numericNrLocuri);
            this.panelZboruri.Controls.Add(this.numericCost);
            this.panelZboruri.Controls.Add(this.dateAterizare);
            this.panelZboruri.Controls.Add(this.dateDecolare);
            this.panelZboruri.Controls.Add(this.label4);
            this.panelZboruri.Controls.Add(this.label3);
            this.panelZboruri.Controls.Add(this.label2);
            this.panelZboruri.Controls.Add(this.label1);
            this.panelZboruri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZboruri.Location = new System.Drawing.Point(0, 0);
            this.panelZboruri.Name = "panelZboruri";
            this.panelZboruri.Size = new System.Drawing.Size(474, 152);
            this.panelZboruri.TabIndex = 0;
            // 
            // btnResetZboruri
            // 
            this.btnResetZboruri.AutoSize = true;
            this.btnResetZboruri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetZboruri.BackColor = System.Drawing.Color.Gainsboro;
            this.btnResetZboruri.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetZboruri.Location = new System.Drawing.Point(324, 109);
            this.btnResetZboruri.Name = "btnResetZboruri";
            this.btnResetZboruri.Size = new System.Drawing.Size(140, 33);
            this.btnResetZboruri.TabIndex = 10;
            this.btnResetZboruri.Text = "Resetează Zboruri";
            this.toolTip1.SetToolTip(this.btnResetZboruri, "Șterge toate zborurile care au fost introduse pîna acum");
            this.btnResetZboruri.UseVisualStyleBackColor = false;
            this.btnResetZboruri.Click += new System.EventHandler(this.btnResetZboruri_Click);
            // 
            // btnResFields
            // 
            this.btnResFields.AutoSize = true;
            this.btnResFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResFields.BackColor = System.Drawing.Color.Gainsboro;
            this.btnResFields.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResFields.Location = new System.Drawing.Point(176, 109);
            this.btnResFields.Name = "btnResFields";
            this.btnResFields.Size = new System.Drawing.Size(142, 33);
            this.btnResFields.TabIndex = 9;
            this.btnResFields.Text = "Resetează Cîmpuri";
            this.toolTip1.SetToolTip(this.btnResFields, "Reseatează cîmpurile în care trebuie de introdus un zbor nou");
            this.btnResFields.UseVisualStyleBackColor = false;
            this.btnResFields.Click += new System.EventHandler(this.btnResFields_Click);
            // 
            // btnAdaugaZbor
            // 
            this.btnAdaugaZbor.AutoSize = true;
            this.btnAdaugaZbor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdaugaZbor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdaugaZbor.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaZbor.Location = new System.Drawing.Point(63, 109);
            this.btnAdaugaZbor.Name = "btnAdaugaZbor";
            this.btnAdaugaZbor.Size = new System.Drawing.Size(107, 33);
            this.btnAdaugaZbor.TabIndex = 8;
            this.btnAdaugaZbor.Text = "Adaugă Zbor";
            this.toolTip1.SetToolTip(this.btnAdaugaZbor, "Adaugă un zbor nou in lista de zboruri");
            this.btnAdaugaZbor.UseVisualStyleBackColor = false;
            this.btnAdaugaZbor.Click += new System.EventHandler(this.btnAdaugaZbor_Click);
            // 
            // numericNrLocuri
            // 
            this.numericNrLocuri.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNrLocuri.Location = new System.Drawing.Point(112, 83);
            this.numericNrLocuri.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericNrLocuri.Name = "numericNrLocuri";
            this.numericNrLocuri.Size = new System.Drawing.Size(120, 20);
            this.numericNrLocuri.TabIndex = 7;
            // 
            // numericCost
            // 
            this.numericCost.DecimalPlaces = 2;
            this.numericCost.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCost.Location = new System.Drawing.Point(112, 59);
            this.numericCost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericCost.Name = "numericCost";
            this.numericCost.Size = new System.Drawing.Size(120, 20);
            this.numericCost.TabIndex = 6;
            // 
            // dateAterizare
            // 
            this.dateAterizare.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateAterizare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAterizare.Location = new System.Drawing.Point(112, 33);
            this.dateAterizare.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateAterizare.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateAterizare.Name = "dateAterizare";
            this.dateAterizare.Size = new System.Drawing.Size(200, 20);
            this.dateAterizare.TabIndex = 5;
            // 
            // dateDecolare
            // 
            this.dateDecolare.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateDecolare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDecolare.Location = new System.Drawing.Point(110, 3);
            this.dateDecolare.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateDecolare.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateDecolare.Name = "dateDecolare";
            this.dateDecolare.Size = new System.Drawing.Size(200, 20);
            this.dateDecolare.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell Nova", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Număr Locuri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Nova", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Nova", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dată Aterizare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dată Decolare";
            // 
            // AdaugaZboruriUsrControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelZboruri);
            this.Name = "AdaugaZboruriUsrControl";
            this.Size = new System.Drawing.Size(474, 152);
            ((System.ComponentModel.ISupportInitialize)(this.errProvZbor)).EndInit();
            this.panelZboruri.ResumeLayout(false);
            this.panelZboruri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNrLocuri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errProvZbor;
        private System.Windows.Forms.Panel panelZboruri;
        public System.Windows.Forms.Button btnResetZboruri;
        public System.Windows.Forms.Button btnResFields;
        public System.Windows.Forms.Button btnAdaugaZbor;
        public System.Windows.Forms.NumericUpDown numericNrLocuri;
        public System.Windows.Forms.NumericUpDown numericCost;
        public System.Windows.Forms.DateTimePicker dateAterizare;
        public System.Windows.Forms.DateTimePicker dateDecolare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
