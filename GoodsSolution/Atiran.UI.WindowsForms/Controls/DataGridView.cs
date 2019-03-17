using System.Drawing;

namespace PersianUI.Controls
{
    public class DataGridView: System.Windows.Forms.DataGridView
    {
        public DataGridView()
        {
            this.Font = FontManager.GetDefaultTextFont();
            //this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(144, 164, 174);
            //this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.EnableHeadersVisualStyles = false;
        }
    }
}
