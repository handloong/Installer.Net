using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer.Net.UI
{
    public partial class FrmLoadJson : Form
    {
        private readonly Action<string> _action;

        public FrmLoadJson(Action<string> action)
        {
            InitializeComponent();
            _action = action;
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            _action.Invoke(txtUrl.Text);
            this.Close();
        }

        private void linkLabelIct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUrl.Text = Pastebin.ICTUrl;
            btnInvoke_Click(null, null);
        }
    }
}
