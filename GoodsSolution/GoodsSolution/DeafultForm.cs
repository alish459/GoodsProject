using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsSolution
{
    public class DefaultForm : System.Windows.Forms.Form
    {
        public DefaultForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DeafultForm
            // 
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "DeafultForm";
            this.ResumeLayout(false);

        }
    }
}
