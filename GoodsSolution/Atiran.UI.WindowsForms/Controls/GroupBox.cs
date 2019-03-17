using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianUI.Controls
{
    public class GroupBox : System.Windows.Forms.GroupBox
    {

       public GroupBox()
        {
            this.Enter += GroupBox_Enter;
            this.Leave += GroupBox_Leave;
        }

        private void GroupBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Empty;
        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {
           // this.BackColor = System.Drawing.Color.FromArgb(204, 212, 219);
        }
    }
}
