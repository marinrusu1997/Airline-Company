namespace Proiect_PAW.Rezervari_Forms
{
    partial class RezervareUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRutaAeriana = new System.Windows.Forms.ComboBox();
            this.cbZbor = new System.Windows.Forms.ComboBox();
            this.numericBilete = new System.Windows.Forms.NumericUpDown();
            this.errProvRez = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericBilete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvRez)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rută Aeriană";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zbor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Număr Bilete";
            // 
            // cbRutaAeriana
            // 
            this.cbRutaAeriana.FormattingEnabled = true;
            this.errProvRez.SetIconAlignment(this.cbRutaAeriana, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.cbRutaAeriana.Location = new System.Drawing.Point(123, 5);
            this.cbRutaAeriana.Name = "cbRutaAeriana";
            this.cbRutaAeriana.Size = new System.Drawing.Size(266, 21);
            this.cbRutaAeriana.TabIndex = 3;
            this.cbRutaAeriana.SelectedIndexChanged += new System.EventHandler(this.cbRutaAeriana_SelectedIndexChanged);
            // 
            // cbZbor
            // 
            this.cbZbor.FormattingEnabled = true;
            this.errProvRez.SetIconAlignment(this.cbZbor, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.cbZbor.Location = new System.Drawing.Point(123, 59);
            this.cbZbor.Name = "cbZbor";
            this.cbZbor.Size = new System.Drawing.Size(266, 21);
            this.cbZbor.TabIndex = 4;
            // 
            // numericBilete
            // 
            this.errProvRez.SetIconAlignment(this.numericBilete, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.numericBilete.Location = new System.Drawing.Point(269, 92);
            this.numericBilete.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBilete.Name = "numericBilete";
            this.numericBilete.Size = new System.Drawing.Size(120, 20);
            this.numericBilete.TabIndex = 5;
            this.numericBilete.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errProvRez
            // 
            this.errProvRez.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errProvRez.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dată";
            // 
            // cbData
            // 
            this.cbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(123, 32);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(266, 21);
            this.cbData.TabIndex = 7;
            this.cbData.SelectedIndexChanged += new System.EventHandler(this.cbData_SelectedIndexChanged);
            // 
            // RezervareUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericBilete);
            this.Controls.Add(this.cbZbor);
            this.Controls.Add(this.cbRutaAeriana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RezervareUserControl";
            this.Size = new System.Drawing.Size(405, 123);
            ((System.ComponentModel.ISupportInitialize)(this.numericBilete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvRez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRutaAeriana;
        private System.Windows.Forms.ComboBox cbZbor;
        private System.Windows.Forms.NumericUpDown numericBilete;
        private System.Windows.Forms.ErrorProvider errProvRez;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.Label label4;
    }
}
