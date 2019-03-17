using PersianUI.UIElements;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersianUI.Controls
{

    public class UserControl : System.Windows.Forms.UserControl
    {
        //public PersianUI.ResourceManager ResourceManagerInstance;
        public string AtiranTitle { get; set; }
        public Guid UcGuid { get; set; }
        public string ProjectName { get; set; }
        public UserControl()
        {
            // ResourceManagerInstance = new ResourceManager("fa-Ir");
            //  this.Font = FontManager.GetFont("IRNazanin", 14, FontStyle.Bold);
            this.Font = PersianUI.FontManager.GetDefaultTextFont();
            this.BackColor = Color.FromArgb(250, 250, 250);
            this.KeyPress += UserControl_KeyPress;
            UcGuid = Guid.NewGuid();
            ProjectName = this.CompanyName;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void UserControl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (this.ParentForm != null)
                    if (this.ParentForm.TopLevelControl == null)
                        this.ParentForm.Close();
            }

        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UserControl
            // 
            this.Name = "UserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResumeLayout(false);
        }


    }
}
