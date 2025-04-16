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
    public partial class UserControlApp: UserControl
    {
        public UserControlApp()
        {
            InitializeComponent();
        }

        public void SelectAll()
        {
            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is UserControlAppIcon)
                {
                    (item as UserControlAppIcon).SelectAll();
                }
            }
        }

        public void UnSelectAll()
        {
            foreach (Control item in flowLayoutPanel.Controls)
            {
                if (item is UserControlAppIcon)
                {
                    (item as UserControlAppIcon).UnSelectAll();
                }
            }
        }
    }
}
