using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer.Net
{
    public partial class UserControlAppIcon: UserControl
    {
        public UserControlAppIcon()
        {
            InitializeComponent();
        }

        private void UserControlAppIcon_Click(object sender, EventArgs e)
        {
            cboApp.Checked = !cboApp.Checked;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cboApp.Checked = !cboApp.Checked;
        }

        public void SelectAll()
        {
            cboApp.Checked = true;
        }

        public void UnSelectAll()
        {
            cboApp.Checked = !cboApp.Checked;
        }
    }
}
