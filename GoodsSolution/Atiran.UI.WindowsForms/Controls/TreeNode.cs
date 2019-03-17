using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianUI.Controls
{
    public class TreeNode : System.Windows.Forms.TreeNode
    {
        public TreeNode(string text) : base(text)
        {
        }

        public TreeNode(string text, int imageIndex, int selectedImageIndex) : base(text, imageIndex, selectedImageIndex)
        {
        }
    }
}
