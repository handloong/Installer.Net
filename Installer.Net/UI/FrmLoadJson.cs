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

        private void FrmLoadJson_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;       // 边框大小设为 0
            button1.BackColor = Color.Transparent;       // 背景透明（可选）
            button1.FlatAppearance.MouseDownBackColor = Color.LightGray; // 点击效果（可选）
            button1.FlatAppearance.MouseOverBackColor = Color.Gainsboro; // 悬停效果（可选）
        }
    }
}
