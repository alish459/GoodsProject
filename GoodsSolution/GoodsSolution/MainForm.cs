using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsSolution
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            pnlMain = new System.Windows.Forms.Panel();
            InitializeComponent();
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 25);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1184, 470);
            pnlMain.TabIndex = 2;
            this.Controls.Add(pnlMain);

        }
        private void ArzDefineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArzDefinition arzDefinition = new ArzDefinition
            {
                Dock = DockStyle.Fill
            };
            arzDefinition.txtArz.Focus();
            pnlMain.Controls.Add(arzDefinition);
        }

        private void GoodsDefineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsDefinition arzDefinition = new GoodsDefinition
            {
                Dock = DockStyle.Fill
            };
            pnlMain.Controls.Add(arzDefinition);
        }
        private void ArzReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsReport arzDefinition = new GoodsReport
            {
                Dock = DockStyle.Fill
            };
            pnlMain.Controls.Add(arzDefinition);
        }
    }
}
