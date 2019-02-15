using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SplitMergeTool.ToolManage
{
    public partial class TranslationToolForm : Form
    {
        public string showTitle = ChangeLanguage.getLanguage("FileManageTool");

        #region 窗体事件
        public TranslationToolForm()
        {
            InitializeComponent();
        }
        private void TranslationToolForm_Load(object sender, EventArgs e)
        {
            Inits();
        }
        #endregion

        #region  初始化
        private void Inits()
        {
            try
            {
                #region 源语言
                List<ComboBoxModel> formList = new List<ComboBoxModel>();
                for (int i = 0; i < 14; i++)
                {
                    ComboBoxModel cbBox = new ComboBoxModel() { text = ChangeLanguage.getLanguage("lang_" + (i + 1).ToString()), value = i.ToString() };
                    formList.Add(cbBox);
                }

                if (cbBox_Form.Items.Count > 0)
                {
                    cbBox_Form.DataSource = null;
                    cbBox_Form.Items.Clear();
                }
                cbBox_Form.DataSource = formList;
                cbBox_Form.DisplayMember = "text";
                cbBox_Form.ValueMember = "value";
                cbBox_Form.SelectedValue = "0";
                #endregion

                #region 翻译语言
                List<ComboBoxModel> toList = new List<ComboBoxModel>();
                for (int i = 0; i < 13; i++)
                {
                    ComboBoxModel toCbBox = new ComboBoxModel() { text = ChangeLanguage.getLanguage("lang_" + (i + 2).ToString()), value = i.ToString() };
                    toList.Add(toCbBox);
                }

                if (cbBox_To.Items.Count > 0)
                {
                    cbBox_To.DataSource = null;
                    cbBox_To.Items.Clear();
                }
                cbBox_To.DataSource = toList;
                cbBox_To.DisplayMember = "text";
                cbBox_To.ValueMember = "value";
                cbBox_To.SelectedValue = "0";
                #endregion

                gb_Translation.Text = ChangeLanguage.getLanguage("Translation");
                btn_Translation.Text = ChangeLanguage.getLanguage("Translation");
                this.Text = ChangeLanguage.getLanguage("TranslationTool");
                lbl_Note.Text = ChangeLanguage.getLanguage("TranslationNote");
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 翻译
        private void btn_Translation_Click(object sender, EventArgs e)
        {
            try
            {
                string formLang = "";
                string toLang = "";

                #region 获取语言选中项
                ComboBoxModel comboForm = cbBox_Form.SelectedItem as ComboBoxModel;
                switch (comboForm.value)
                {
                    case "0":
                        formLang = "auto"; break;
                    case "1":
                        formLang = "zh"; break;
                    case "2":
                        formLang = "en"; break;
                    case "3":
                        formLang = "yue"; break;
                    case "4":
                        formLang = "wyw"; break;
                    case "5":
                        formLang = "jp"; break;
                    case "6":
                        formLang = "kor"; break;
                    case "7":
                        formLang = "fra"; break;
                    case "8":
                        formLang = "spa"; break;
                    case "9":
                        formLang = "th"; break;
                    case "10":
                        formLang = "ru"; break;
                    case "11":
                        formLang = "de"; break;
                    case "12":
                        formLang = "cht"; break;
                    case "13":
                        formLang = "vie"; break;
                }
                ComboBoxModel comboTo = cbBox_To.SelectedItem as ComboBoxModel;
                switch (comboTo.value)
                {
                    case "0":
                        toLang = "zh"; break;
                    case "1":
                        toLang = "en"; break;
                    case "2":
                        toLang = "yue"; break;
                    case "3":
                        toLang = "wyw"; break;
                    case "4":
                        toLang = "jp"; break;
                    case "5":
                        toLang = "kor"; break;
                    case "6":
                        toLang = "fra"; break;
                    case "7":
                        toLang = "spa"; break;
                    case "8":
                        toLang = "th"; break;
                    case "9":
                        toLang = "ru"; break;
                    case "10":
                        toLang = "de"; break;
                    case "11":
                        toLang = "cht"; break;
                    case "12":
                        toLang = "vie"; break;
                }
                #endregion

                if (!string.IsNullOrWhiteSpace(txt_PendingInput.Text.Trim()))
                {
                    if (formLang == toLang)//语种相同
                    {
                        txt_ToBeTranslated.Text = txt_PendingInput.Text;
                    }
                    else
                    {
                        TranslationResult translation = Translation(txt_PendingInput.Text, formLang, toLang, 0);
                        txt_ToBeTranslated.Text = "";
                        if (translation == null)//转换失败
                        {
                            txt_ToBeTranslated.AppendText("Translation Faild!");
                            txt_ToBeTranslated.ForeColor = Color.Red;
                            txt_ToBeTranslated.Font = new Font(txt_ToBeTranslated.Font.FontFamily, 25);
                        }
                        else
                        {
                            if (translation.Trans_result != null)
                            {
                                foreach (var item in translation.Trans_result)
                                {
                                    txt_ToBeTranslated.AppendText(item.Dst + "\n");
                                }
                            }
                            else//转换失败，出现错误码
                            {
                                txt_ToBeTranslated.AppendText(translation.Error_msg);
                                txt_ToBeTranslated.ForeColor = Color.Red;
                                txt_ToBeTranslated.Font = new Font(txt_ToBeTranslated.Font.FontFamily, 25);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 翻译请求方法
        /// <summary>
        /// 翻译请求方法
        /// </summary>
        /// <param name="content">请求翻译query(UTF-8编码)</param>
        /// <param name="from">翻译源语言(可设置为auto)</param>
        /// <param name="to">译文语言(不可设置为auto)</param>
        /// <param name="channel">翻译渠道 0:百度</param>
        private TranslationResult Translation(string content, string from, string to, int channel)
        {
            //此MDF加密已过时，不建议使用
            //string md5Sign = FormsAuthentication.HashPasswordForStoringInConfigFile(appId + content + randomNum + passWord, "MD5").ToLower();

            TranslationResult result = new TranslationResult();
            string randomNum = new Random().Next().ToString();//随机数
            string apiUrl = "";//api路径
            string appId = "";//appID
            string appKey = "";//app密钥
            string url = "";
            try
            {
                switch (channel)
                {
                    case 0:
                        apiUrl = Global.BaiduTranslatorApi;
                        appId = Global.BaiduTranslatorAppId;
                        appKey = Global.BaiduTranslatorAppKey;
                        string md5Sign = Common.GetMD5(appId + content + randomNum + appKey);
                        url = string.Format("{0}?q={1}&from={2}&to={3}&appid={4}&salt={5}&sign={6}",
                           apiUrl,
                           content,
                           from,
                           to,
                           appId,
                           randomNum,
                           md5Sign
                           );
                        break;
                }

                string jsonResult = new WebClient().DownloadString(url);//得到api返回的json字符串

                result = new JavaScriptSerializer().Deserialize<TranslationResult>(jsonResult);
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
            return result;
        }
        #endregion

    }
}
