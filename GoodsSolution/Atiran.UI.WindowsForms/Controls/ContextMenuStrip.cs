using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianUI.Controls
{
  public class ContextMenuStrip:System.Windows.Forms.ContextMenuStrip
    {
        public ContextMenuStrip()
        {
            Initialize();
        }
        private void Initialize()
        {
            this.Font = FontManager.GetDefaultTextFont();
        }
    }
}
