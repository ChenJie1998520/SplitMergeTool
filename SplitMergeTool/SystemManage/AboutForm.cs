using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitMergeTool.SystemManage
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            this.Text = ChangeLanguage.getLanguage("About");
            lbl_Version.Text = ChangeLanguage.getLanguage("ToolVersion");
            lbl_VersionAll.Text = ChangeLanguage.getLanguage("VersionAll");
            lbl_CopyRight.Text= ChangeLanguage.getLanguage("CopyRight");
        }
    }
}
