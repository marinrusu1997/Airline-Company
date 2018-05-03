namespace Proiect_PAW
{
    partial class SeteazaDiscounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeteazaDiscounts));
            this.label1 = new System.Windows.Forms.Label();
            this.cbRute = new System.Windows.Forms.ComboBox();
            this.btnAdgDiscounturi = new System.Windows.Forms.Button();
            this.btnAdgDiscount = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdaugaToate = new System.Windows.Forms.Button();
            this.labelDiscMaxim = new System.Windows.Forms.Label();
            this.numericMaxDiscount = new System.Windows.Forms.NumericUpDown();
            this.discountsUserControl1 = new Proiect_PAW.DiscountsUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectează Ruta";
            // 
            // cbRute
            // 
            this.cbRute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRute.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRute.FormattingEnabled = true;
            this.cbRute.Location = new System.Drawing.Point(226, 25);
            this.cbRute.Name = "cbRute";
            this.cbRute.Size = new System.Drawing.Size(207, 23);
            this.cbRute.TabIndex = 2;
            this.cbRute.SelectedIndexChanged += new System.EventHandler(this.cbRute_SelectedIndexChanged);
            // 
            // btnAdgDiscounturi
            // 
            this.btnAdgDiscounturi.AutoSize = true;
            this.btnAdgDiscounturi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdgDiscounturi.BackColor = System.Drawing.Color.LightGray;
            this.btnAdgDiscounturi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdgDiscounturi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdgDiscounturi.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdgDiscounturi.Location = new System.Drawing.Point(1, 264);
            this.btnAdgDiscounturi.Name = "btnAdgDiscounturi";
            this.btnAdgDiscounturi.Size = new System.Drawing.Size(79, 28);
            this.btnAdgDiscounturi.TabIndex = 3;
            this.btnAdgDiscounturi.Text = "Adaugă";
            this.toolTip1.SetToolTip(this.btnAdgDiscounturi, "Adaugă lista de discounturi la ruta specificată");
            this.btnAdgDiscounturi.UseVisualStyleBackColor = false;
            this.btnAdgDiscounturi.Click += new System.EventHandler(this.btnAdgDiscounturi_Click);
            // 
            // btnAdgDiscount
            // 
            this.btnAdgDiscount.AutoSize = true;
            this.btnAdgDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdgDiscount.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdgDiscount.Location = new System.Drawing.Point(377, 262);
            this.btnAdgDiscount.Name = "btnAdgDiscount";
            this.btnAdgDiscount.Size = new System.Drawing.Size(167, 30);
            this.btnAdgDiscount.TabIndex = 4;
            this.btnAdgDiscount.Text = "Adaugă Discount";
            this.toolTip1.SetToolTip(this.btnAdgDiscount, "Adaugă discountul specificat în lista de discounturi");
            this.btnAdgDiscount.UseVisualStyleBackColor = true;
            this.btnAdgDiscount.Click += new System.EventHandler(this.btnAdgDiscount_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(224, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Discounts";
            this.toolTip1.SetToolTip(this.btnClear, "Șterge toate discounturile care au fost adaugate în lista pînă la momentul actual" +
        "");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdaugaToate
            // 
            this.btnAdaugaToate.AutoSize = true;
            this.btnAdaugaToate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdaugaToate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugaToate.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAdaugaToate.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaToate.Location = new System.Drawing.Point(89, 264);
            this.btnAdaugaToate.Name = "btnAdaugaToate";
            this.btnAdaugaToate.Size = new System.Drawing.Size(129, 28);
            this.btnAdaugaToate.TabIndex = 6;
            this.btnAdaugaToate.Text = "Adaugă toate";
            this.toolTip1.SetToolTip(this.btnAdaugaToate, "Adaugă discounturile la toate rutele");
            this.btnAdaugaToate.UseVisualStyleBackColor = true;
            this.btnAdaugaToate.Click += new System.EventHandler(this.btnAdaugaToate_Click);
            // 
            // labelDiscMaxim
            // 
            this.labelDiscMaxim.AutoSize = true;
            this.labelDiscMaxim.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscMaxim.Location = new System.Drawing.Point(100, 55);
            this.labelDiscMaxim.Name = "labelDiscMaxim";
            this.labelDiscMaxim.Size = new System.Drawing.Size(125, 16);
            this.labelDiscMaxim.TabIndex = 7;
            this.labelDiscMaxim.Text = "Discount Maxim";
            // 
            // numericMaxDiscount
            // 
            this.numericMaxDiscount.AutoSize = true;
            this.numericMaxDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericMaxDiscount.DecimalPlaces = 1;
            this.numericMaxDiscount.Location = new System.Drawing.Point(226, 55);
            this.numericMaxDiscount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericMaxDiscount.Name = "numericMaxDiscount";
            this.numericMaxDiscount.Size = new System.Drawing.Size(207, 20);
            this.numericMaxDiscount.TabIndex = 8;
            this.numericMaxDiscount.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // discountsUserControl1
            // 
            this.discountsUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.discountsUserControl1.Location = new System.Drawing.Point(103, 79);
            this.discountsUserControl1.Name = "discountsUserControl1";
            this.discountsUserControl1.Size = new System.Drawing.Size(330, 159);
            this.discountsUserControl1.TabIndex = 0;
            // 
            // SeteazaDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(546, 313);
            this.Controls.Add(this.numericMaxDiscount);
            this.Controls.Add(this.labelDiscMaxim);
            this.Controls.Add(this.btnAdaugaToate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdgDiscount);
            this.Controls.Add(this.btnAdgDiscounturi);
            this.Controls.Add(this.cbRute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discountsUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AdaugaDiscounts";
            this.Text = "Setează Discounts";
            this.Load += new System.EventHandler(this.AdaugaDiscounts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdaugaDiscounts_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiscountsUserControl discountsUserControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRute;
        private System.Windows.Forms.Button btnAdgDiscounturi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAdgDiscount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdaugaToate;
        private System.Windows.Forms.Label labelDiscMaxim;
        private System.Windows.Forms.NumericUpDown numericMaxDiscount;
    }
}