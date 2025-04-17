using System;
using System.Windows.Forms;

namespace Installer.Net
{
    public partial class UserControlApp : UserControl
    {
        public ApplicationInfo ApplicationInfo { get; internal set; }

        public UserControlApp(ApplicationInfo applicationInfo)
        {
            InitializeComponent();
            ApplicationInfo = applicationInfo;

            picIcon.Image = ImageHelper.Base64ToImage(applicationInfo.Icon);
            cboApp.Text = ApplicationInfo.Name;
            if (ApplicationInfo.AutoSelect)
            {
                cboApp.Checked = true;
            }
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
        public bool Checked => cboApp.Checked;
    }
}
