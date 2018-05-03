namespace Proiect_PAW
{
    partial class ModificaDiscountManager
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
            this.numericProcentMaxim = new System.Windows.Forms.NumericUpDown();
            this.btnModifica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericProcentMaxim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procent Discount Maxin";
            // 
            // numericProcentMaxim
            // 
            this.numericProcentMaxim.AutoSize = true;
            this.numericProcentMaxim.DecimalPlaces = 1;
            this.numericProcentMaxim.Location = new System.Drawing.Point(277, 45);
            this.numericProcentMaxim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericProcentMaxim.Name = "numericProcentMaxim";
            this.numericProcentMaxim.Size = new System.Drawing.Size(120, 20);
            this.numericProcentMaxim.TabIndex = 1;
            this.numericProcentMaxim.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // btnModifica
            // 
            this.btnModifica.AutoSize = true;
            this.btnModifica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModifica.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModifica.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(185, 73);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(89, 28);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // ModificaDiscountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnModifica;
            this.ClientSize = new System.Drawing.Size(469, 110);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.numericProcentMaxim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificaDiscountManager";
            this.Text = "Modifica Discount Manager";
            this.Load += new System.EventHandler(this.ModificaDiscountManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericProcentMaxim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericProcentMaxim;
        private System.Windows.Forms.Button btnModifica;
    }
}