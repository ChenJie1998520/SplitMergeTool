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
    public partial class ContactForm : Form
    {
        public string showTitle = ChangeLanguage.getLanguage("FileManageTool");

        #region 窗体事件
        public ContactForm()
        {
            InitializeComponent();
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            this.Text = ChangeLanguage.getLanguage("Contact");
            btn_CopyQQ.Text = ChangeLanguage.getLanguage("CopyToClipboard");
            btn_CopyWechat.Text = ChangeLanguage.getLanguage("CopyToClipboard");
            btn_CopyEmail.Text = ChangeLanguage.getLanguage("CopyToClipboard");
            btn_CopyPhone.Text = ChangeLanguage.getLanguage("CopyToClipboard");
            lklbl_Note.Text = ChangeLanguage.getLanguage("ContactNote");
        }
        #endregion

        #region 复制到剪切板
        private void btn_CopyQQ_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(lbl_QQ.Text.Split('：')[1]);
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("CopyQQNumber"), showTitle);
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        private void btn_CopyWechat_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(lbl_Wechat.Text.Split('：')[1]);
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("CopyWeChatNumber"), showTitle);
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        private void btn_CopyEmail_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(lbl_Email.Text.Split('：')[1]);
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("CopyEmailAddress"), showTitle);
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        private void btn_CopyPhone_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(lbl_Phone.Text.Split('：')[1]);
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("CopyPhoneNumber"), showTitle);
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion
    }
}
