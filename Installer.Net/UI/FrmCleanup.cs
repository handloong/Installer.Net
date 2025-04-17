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
    public partial class FrmCleanup: Form
    {
        public FrmCleanup()
        {
            InitializeComponent();
            this.Size = new Size(300, 150);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            var label = new Label
            {
                Text = "正在清理临时资源，请稍候...",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.Controls.Add(label);
        }
    }
}
