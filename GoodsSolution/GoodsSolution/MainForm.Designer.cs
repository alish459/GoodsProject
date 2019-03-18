namespace GoodsSolution
{
    partial class MainForm
    {
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem AddGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArzDefineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoodsDefineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HeaderTwoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArzReportToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFooter;
        public static System.Windows.Forms.Panel pnlMain;
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.AddGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArzDefineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoodsDefineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArzReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddGoodsToolStripMenuItem,
            this.HeaderTwoToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStripMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStripMain.Size = new System.Drawing.Size(784, 25);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // AddGoodsToolStripMenuItem
            // 
            this.AddGoodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArzDefineToolStripMenuItem,
            this.GoodsDefineToolStripMenuItem});
            this.AddGoodsToolStripMenuItem.Name = "AddGoodsToolStripMenuItem";
            this.AddGoodsToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.AddGoodsToolStripMenuItem.Text = "تعريف كالا";
            // 
            // ArzDefineToolStripMenuItem
            // 
            this.ArzDefineToolStripMenuItem.Name = "ArzDefineToolStripMenuItem";
            this.ArzDefineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ArzDefineToolStripMenuItem.Text = "تعريف ارز";
            this.ArzDefineToolStripMenuItem.Click += new System.EventHandler(this.ArzDefineToolStripMenuItem_Click);
            // 
            // GoodsDefineToolStripMenuItem
            // 
            this.GoodsDefineToolStripMenuItem.Name = "GoodsDefineToolStripMenuItem";
            this.GoodsDefineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.GoodsDefineToolStripMenuItem.Text = "تعريف كالا";
            this.GoodsDefineToolStripMenuItem.Click += new System.EventHandler(this.GoodsDefineToolStripMenuItem_Click);
            // 
            // HeaderTwoToolStripMenuItem
            // 
            this.HeaderTwoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArzReportToolStripMenuItem});
            this.HeaderTwoToolStripMenuItem.Name = "HeaderTwoToolStripMenuItem";
            this.HeaderTwoToolStripMenuItem.Size = new System.Drawing.Size(150, 19);
            this.HeaderTwoToolStripMenuItem.Text = "گزارش كالاهاي تعريف شده";
            // 
            // ArzReportToolStripMenuItem
            // 
            this.ArzReportToolStripMenuItem.Name = "ArzReportToolStripMenuItem";
            this.ArzReportToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ArzReportToolStripMenuItem.Text = "گزارش ارزي";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 407);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(784, 54);
            this.pnlFooter.TabIndex = 1;
            this.pnlFooter.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "محاسبه ارز كالاها";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
    }
}

