namespace Proiect_PAW
{
    partial class ConfigurareDiscounts
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
            this.tvDiscounts = new System.Windows.Forms.TreeView();
            this.cMStvDiscounts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMStvDiscounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDiscounts
            // 
            this.tvDiscounts.AllowDrop = true;
            this.tvDiscounts.ContextMenuStrip = this.cMStvDiscounts;
            this.tvDiscounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDiscounts.Location = new System.Drawing.Point(0, 0);
            this.tvDiscounts.Name = "tvDiscounts";
            this.tvDiscounts.Size = new System.Drawing.Size(800, 450);
            this.tvDiscounts.TabIndex = 0;
            this.tvDiscounts.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvDiscounts_ItemDrag);
            this.tvDiscounts.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvDiscounts_DragDrop);
            this.tvDiscounts.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvDiscounts_DragEnter);
            // 
            // cMStvDiscounts
            // 
            this.cMStvDiscounts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem});
            this.cMStvDiscounts.Name = "cMStvDiscounts";
            this.cMStvDiscounts.Size = new System.Drawing.Size(113, 70);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = " Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // ConfigurareDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvDiscounts);
            this.Name = "ConfigurareDiscounts";
            this.Text = "ConfigurareDiscounts";
            this.cMStvDiscounts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDiscounts;
        private System.Windows.Forms.ContextMenuStrip cMStvDiscounts;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}