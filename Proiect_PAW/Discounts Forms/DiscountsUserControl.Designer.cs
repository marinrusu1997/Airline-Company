namespace Proiect_PAW
{
    partial class DiscountsUserControl
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
            this.cbTipDiscount = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProcent = new System.Windows.Forms.Label();
            this.numericProcSpec = new System.Windows.Forms.NumericUpDown();
            this.labelSuma = new System.Windows.Forms.Label();
            this.numericSumaAd = new System.Windows.Forms.NumericUpDown();
            this.labelMotiv = new System.Windows.Forms.Label();
            this.cbMotiv = new System.Windows.Forms.ComboBox();
            this.labelDataInc = new System.Windows.Forms.Label();
            this.dateTimeInceput = new System.Windows.Forms.DateTimePicker();
            this.labelDataSf = new System.Windows.Forms.Label();
            this.dateTimeSfirsit = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericProcSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSumaAd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip Discount";
            // 
            // cbTipDiscount
            // 
            this.cbTipDiscount.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipDiscount.FormattingEnabled = true;
            this.cbTipDiscount.Items.AddRange(new object[] {
            "Discount Numar Bilete",
            "Discount Specific"});
            this.cbTipDiscount.Location = new System.Drawing.Point(126, 0);
            this.cbTipDiscount.Name = "cbTipDiscount";
            this.cbTipDiscount.Size = new System.Drawing.Size(204, 23);
            this.cbTipDiscount.TabIndex = 1;
            this.cbTipDiscount.SelectedIndexChanged += new System.EventHandler(this.cbTipDiscount_SelectedIndexChanged);
            this.cbTipDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipDiscount_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimeSfirsit);
            this.panel1.Controls.Add(this.labelDataSf);
            this.panel1.Controls.Add(this.dateTimeInceput);
            this.panel1.Controls.Add(this.labelDataInc);
            this.panel1.Controls.Add(this.cbMotiv);
            this.panel1.Controls.Add(this.labelMotiv);
            this.panel1.Controls.Add(this.numericSumaAd);
            this.panel1.Controls.Add(this.labelSuma);
            this.panel1.Controls.Add(this.numericProcSpec);
            this.panel1.Controls.Add(this.labelProcent);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 131);
            this.panel1.TabIndex = 2;
            // 
            // labelProcent
            // 
            this.labelProcent.AutoSize = true;
            this.labelProcent.BackColor = System.Drawing.Color.Orange;
            this.labelProcent.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcent.ForeColor = System.Drawing.Color.Black;
            this.labelProcent.Location = new System.Drawing.Point(4, 4);
            this.labelProcent.Name = "labelProcent";
            this.labelProcent.Size = new System.Drawing.Size(116, 18);
            this.labelProcent.TabIndex = 0;
            this.labelProcent.Text = "Procent Discount";
            // 
            // numericProcSpec
            // 
            this.numericProcSpec.DecimalPlaces = 1;
            this.numericProcSpec.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericProcSpec.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericProcSpec.Location = new System.Drawing.Point(123, 4);
            this.numericProcSpec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericProcSpec.Name = "numericProcSpec";
            this.numericProcSpec.Size = new System.Drawing.Size(200, 24);
            this.numericProcSpec.TabIndex = 1;
            this.numericProcSpec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.BackColor = System.Drawing.Color.Orange;
            this.labelSuma.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuma.ForeColor = System.Drawing.Color.Black;
            this.labelSuma.Location = new System.Drawing.Point(4, 29);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(114, 18);
            this.labelSuma.TabIndex = 2;
            this.labelSuma.Text = "Sumă Adițională";
            // 
            // numericSumaAd
            // 
            this.numericSumaAd.DecimalPlaces = 2;
            this.numericSumaAd.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSumaAd.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericSumaAd.Location = new System.Drawing.Point(123, 29);
            this.numericSumaAd.Name = "numericSumaAd";
            this.numericSumaAd.Size = new System.Drawing.Size(200, 18);
            this.numericSumaAd.TabIndex = 3;
            // 
            // labelMotiv
            // 
            this.labelMotiv.AutoSize = true;
            this.labelMotiv.BackColor = System.Drawing.Color.Orange;
            this.labelMotiv.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotiv.ForeColor = System.Drawing.Color.Black;
            this.labelMotiv.Location = new System.Drawing.Point(4, 54);
            this.labelMotiv.Name = "labelMotiv";
            this.labelMotiv.Size = new System.Drawing.Size(45, 18);
            this.labelMotiv.TabIndex = 4;
            this.labelMotiv.Text = "Motiv";
            // 
            // cbMotiv
            // 
            this.cbMotiv.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotiv.FormattingEnabled = true;
            this.cbMotiv.Location = new System.Drawing.Point(123, 54);
            this.cbMotiv.Name = "cbMotiv";
            this.cbMotiv.Size = new System.Drawing.Size(200, 23);
            this.cbMotiv.Sorted = true;
            this.cbMotiv.TabIndex = 5;
            this.cbMotiv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMotiv_KeyPress);
            // 
            // labelDataInc
            // 
            this.labelDataInc.AutoSize = true;
            this.labelDataInc.BackColor = System.Drawing.Color.Orange;
            this.labelDataInc.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInc.ForeColor = System.Drawing.Color.Black;
            this.labelDataInc.Location = new System.Drawing.Point(4, 80);
            this.labelDataInc.Name = "labelDataInc";
            this.labelDataInc.Size = new System.Drawing.Size(87, 18);
            this.labelDataInc.TabIndex = 6;
            this.labelDataInc.Text = "Dată început";
            // 
            // dateTimeInceput
            // 
            this.dateTimeInceput.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimeInceput.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeInceput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInceput.Location = new System.Drawing.Point(123, 80);
            this.dateTimeInceput.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimeInceput.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimeInceput.Name = "dateTimeInceput";
            this.dateTimeInceput.Size = new System.Drawing.Size(200, 24);
            this.dateTimeInceput.TabIndex = 7;
            this.dateTimeInceput.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // labelDataSf
            // 
            this.labelDataSf.AutoSize = true;
            this.labelDataSf.BackColor = System.Drawing.Color.Orange;
            this.labelDataSf.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataSf.ForeColor = System.Drawing.Color.Black;
            this.labelDataSf.Location = new System.Drawing.Point(4, 107);
            this.labelDataSf.Name = "labelDataSf";
            this.labelDataSf.Size = new System.Drawing.Size(81, 18);
            this.labelDataSf.TabIndex = 8;
            this.labelDataSf.Text = "Dată Sfîrșit";
            // 
            // dateTimeSfirsit
            // 
            this.dateTimeSfirsit.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimeSfirsit.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeSfirsit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeSfirsit.Location = new System.Drawing.Point(123, 102);
            this.dateTimeSfirsit.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimeSfirsit.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimeSfirsit.Name = "dateTimeSfirsit";
            this.dateTimeSfirsit.Size = new System.Drawing.Size(200, 24);
            this.dateTimeSfirsit.TabIndex = 9;
            this.dateTimeSfirsit.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // DiscountsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbTipDiscount);
            this.Controls.Add(this.label1);
            this.Name = "DiscountsUserControl";
            this.Size = new System.Drawing.Size(330, 159);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericProcSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSumaAd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipDiscount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMotiv;
        private System.Windows.Forms.Label labelMotiv;
        private System.Windows.Forms.NumericUpDown numericSumaAd;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.NumericUpDown numericProcSpec;
        private System.Windows.Forms.Label labelProcent;
        private System.Windows.Forms.DateTimePicker dateTimeSfirsit;
        private System.Windows.Forms.Label labelDataSf;
        private System.Windows.Forms.DateTimePicker dateTimeInceput;
        private System.Windows.Forms.Label labelDataInc;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
