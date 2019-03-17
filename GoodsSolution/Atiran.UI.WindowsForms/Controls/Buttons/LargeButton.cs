using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PersianUI.Controls.Buttons
{
    public class LargeButton : PersianUI.Controls.Buttons.Button
    {
        public LargeButton()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
           
            
            this.BackColor = Color.FromArgb(0, 140, 231);
            this.ForeColor = Color.White;
            this.Width = 230;
            this.Height = 32;
        }
    }
}
