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
            InitializeComponent();
            PersianUI.MessageBoxes.CustomMessageForm.CustomMessageBox.Show("پيغام", "تست","w");
        }
    }
}
