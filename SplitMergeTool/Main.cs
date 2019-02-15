using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitMergeTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("创作者：JayChan\r\n联系方式：\r\nQQ：1419181774\r\n微信：14773506840\r\n邮箱：1419181774@qq.com");
        }

        private void btnTextSplitter_Click(object sender, EventArgs e)
        {
            NoteBookManage.NoteSplitForm textSplitter = new NoteBookManage.NoteSplitForm();
            textSplitter.ShowDialog();
        }
    }
}
