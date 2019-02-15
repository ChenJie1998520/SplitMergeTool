using SplitMergeTool.SystemManage;
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
    public partial class FileManagementTool : Form
    {
        NoteBookManage.NoteSplitForm splitNote = null;
        NoteBookManage.NoteMergeForm mergeNote = null;
        DocumentManage.DocSplitForm splitDoc = null;
        DocumentManage.DocMergeForm mergeDoc = null;
        SheetManage.SheetSplitForm splitSheet = null;
        SheetManage.SheetMergeForm mergeSheet = null;
        TabPage splitNoteTabPage = new TabPage();
        TabPage mergeNoteTabPage = new TabPage();
        TabPage splitDocTabPage = new TabPage();
        TabPage mergeDocTabPage = new TabPage();
        TabPage splitSheetTabPage = new TabPage();
        TabPage mergeSheetTabPage = new TabPage();

        #region 窗体事件
        public FileManagementTool()
        {
            InitializeComponent();
            ChangeLanguage.SetDefaultLanguage(Properties.Settings.Default.DefaultLanguage);
        }

        private void FileManagementTool_Load(object sender, EventArgs e)
        {
            Inits();
        }
        #endregion

        #region 退出
        private void tsm_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 计时器事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbl_CurrDate.Text = ChangeLanguage.getLanguage("CurrDate") + "：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        #endregion

        #region 窗体样式初始化设置方法
        private void InitFormMethod(Form showForm)
        {
            showForm.TopLevel = false;
            showForm.FormBorderStyle = FormBorderStyle.None;
            showForm.Width = this.tbp_Index.Width;
            showForm.Height = this.tb_Main.Height - this.tb_Main.ItemSize.Height;
        }
        #endregion

        #region 初始化
        private void Inits()
        {
            #region 初始化信息
            tsm_SystemManagement.Text = ChangeLanguage.getLanguage("SystemManage");
            tsm_NoteManagement.Text = ChangeLanguage.getLanguage("NoteBookManage");
            tsm_DocManagement.Text = ChangeLanguage.getLanguage("DocManage");
            tsm_FormManagement.Text = ChangeLanguage.getLanguage("FormManage");

            tsm_Language.Text = ChangeLanguage.getLanguage("Language");
            tsm_Chinese.Text = ChangeLanguage.getLanguage("Chinese");
            tsm_English.Text = ChangeLanguage.getLanguage("English");
            tsm_Help.Text = ChangeLanguage.getLanguage("Help");
            tsm_About.Text = ChangeLanguage.getLanguage("About");
            tsm_Contact.Text = ChangeLanguage.getLanguage("Contact");
            tsm_Close.Text = ChangeLanguage.getLanguage("DropOut");

            tsm_SplitNote.Text = ChangeLanguage.getLanguage("NoteSplit");
            tsm_MergeNote.Text = ChangeLanguage.getLanguage("NoteMerge");
            tsm_SplitDoc.Text = ChangeLanguage.getLanguage("DocSplit");
            tsm_MergeDoc.Text = ChangeLanguage.getLanguage("DocMerge");
            tsm_SplitForm.Text = ChangeLanguage.getLanguage("FormSplit");
            tsm_MergeForm.Text = ChangeLanguage.getLanguage("FormMerge");

            tsm_ToolManagement.Text = ChangeLanguage.getLanguage("ToolManage");
            tsm_TranslationTool.Text = ChangeLanguage.getLanguage("TranslationTool");
            tsm_SimpleCalculator.Text = ChangeLanguage.getLanguage("SimpleCalculator");
            tsm_FileFormatConversionTool.Text = ChangeLanguage.getLanguage("FileFormatConversionTool");

            tbp_Index.Text = ChangeLanguage.getLanguage("Home");
            this.Text = ChangeLanguage.getLanguage("FileManageTool");
            #endregion

            #region 窗体实例化与样式设置
            //文本分割
            splitNote = new NoteBookManage.NoteSplitForm();
            InitFormMethod(splitNote);

            //文本合并
            mergeNote = new NoteBookManage.NoteMergeForm();
            InitFormMethod(mergeNote);

            //文档分割
            splitDoc = new DocumentManage.DocSplitForm();
            InitFormMethod(splitDoc);

            //文档合并
            mergeDoc = new DocumentManage.DocMergeForm();
            InitFormMethod(mergeDoc);

            //表格分割
            splitSheet = new SheetManage.SheetSplitForm();
            InitFormMethod(splitSheet);

            //表格合并
            mergeSheet = new SheetManage.SheetMergeForm();
            InitFormMethod(mergeSheet);
            #endregion
        }
        #endregion

        #region 展示窗体方法
        /// <summary>
        /// 展示窗体方法
        /// </summary>
        /// <param name="tabPage">tabPage</param>
        /// <param name="pageText">名称</param>
        /// <param name="pageName">Name</param>
        /// <param name="tabIndex">索引</param>
        /// <param name="form">窗体</param>
        private void InitTabMethod(TabPage tabPage,string pageText,string pageName, int tabIndex,Form form)
        {
            if (!tb_Main.TabPages.ContainsKey(pageName))
            {
                tabPage.Text = ChangeLanguage.getLanguage(pageText);
                tabPage.Name = pageName;
                tabPage.TabIndex = tabIndex;

                tabPage.Controls.Add(form);
                tb_Main.Controls.Add(tabPage);
                tb_Main.SelectedTab = tabPage;
                form.Show();
            }
            else
                tb_Main.SelectedTab = tabPage;
        }
        #endregion

        #region 展示窗体
        private void OpenForm(int value)
        {
            switch (value)
            {
                case 0:
                   SystemManage.HelpForm help = new SystemManage.HelpForm();
                    help.ShowInTaskbar = false;
                    help.ShowDialog();
                    break;
                case 1:
                    SystemManage.AboutForm about = new SystemManage.AboutForm();
                    about.ShowInTaskbar = false;
                    about.ShowDialog();
                    break;
                case 2:
                    SystemManage.ContactForm contact = new SystemManage.ContactForm();
                    contact.ShowInTaskbar = false;
                    contact.ShowDialog();
                    break;
                case 20:
                    splitNoteTabPage = new TabPage();
                    InitTabMethod(splitNoteTabPage, "NoteSplit", "tbp_NoteSplit", 20, splitNote);
                    break;
                case 21:
                    mergeNoteTabPage = new TabPage();
                    InitTabMethod(mergeNoteTabPage, "NoteMerge", "tbp_NoteMerge", 21, mergeNote);
                    break;
                case 30:
                    splitDocTabPage = new TabPage();
                    InitTabMethod(splitDocTabPage, "DocSplit", "tbp_DocSplit", 30, splitDoc);
                    break;
                case 31:
                    mergeDocTabPage = new TabPage();
                    InitTabMethod(mergeDocTabPage, "DocMerge", "tbp_DocMerge", 31, mergeDoc);
                    break;
                case 40:
                    splitSheetTabPage = new TabPage();
                    InitTabMethod(splitSheetTabPage, "FormSplit", "tbp_SheetSplit", 40, splitSheet);
                    break;
                case 41:
                    mergeSheetTabPage = new TabPage();
                    InitTabMethod(mergeSheetTabPage, "FormMerge", "tbp_SheetMerge", 41, mergeSheet);
                    break;
                case 50:
                    ToolManage.TranslationToolForm translationToolForm = new ToolManage.TranslationToolForm();
                    translationToolForm.ShowInTaskbar = false;
                    translationToolForm.ShowDialog();
                    break;
                case 51:
                    ToolManage.SimpleCalculatorForm simpleCalculator = new ToolManage.SimpleCalculatorForm();
                    simpleCalculator.ShowInTaskbar = false;
                    simpleCalculator.ShowDialog();
                    break;
                case 52:
                    ToolManage.FileFormatConversionToolForm fileFormatConversionTool = new ToolManage.FileFormatConversionToolForm();
                    fileFormatConversionTool.ShowInTaskbar = false;
                    fileFormatConversionTool.ShowDialog();
                    break;
                
            }
        }
        #endregion

        #region 菜单事件
        //帮助
        private void tsm_Help_Click(object sender, EventArgs e)
        {
            OpenForm(0);
        }

        //关于
        private void tsm_About_Click(object sender, EventArgs e)
        {
            OpenForm(1);
        }

        //联系
        private void tsm_Contact_Click(object sender, EventArgs e)
        {
            OpenForm(2);
        }

        //记事本拆分
        private void tsm_SplitNote_Click(object sender, EventArgs e)
        {
            OpenForm(20);
        }

        //记事本合并
        private void tsm_MergeNote_Click(object sender, EventArgs e)
        {
            OpenForm(21);
        }

        //文档拆分
        private void tsm_SplitDoc_Click(object sender, EventArgs e)
        {
            OpenForm(30);
        }

        //文档合并
        private void tsm_MergeDoc_Click(object sender, EventArgs e)
        {
            OpenForm(31);
        }

        //表格拆分
        private void tsm_SplitForm_Click(object sender, EventArgs e)
        {
            OpenForm(40);
        }

        //表格合并
        private void tsm_MergeForm_Click(object sender, EventArgs e)
        {
            OpenForm(41);
        }

        //翻译工具
        private void tsm_TranslationTool_Click(object sender, EventArgs e)
        {
            OpenForm(50);
        }

        //简易计算器
        private void tsm_SimpleCalculator_Click(object sender, EventArgs e)
        {
            OpenForm(51);
        }

        //文件格式转换工具
        private void tsm_FileFormatConversionTool_Click(object sender, EventArgs e)
        {
            OpenForm(52);
        }
        #endregion

        #region 语言切换
        private void tsm_English_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DefaultLanguage == "zh-cn")
            {
                ChangeLanguage.SetDefaultLanguage("en-us");
                int index = tb_Main.SelectedIndex;
                this.FileManagementTool_Load(null, null);
                RefreshTabPage();
                tb_Main.SelectedIndex = index;
            }
        }

        private void tsm_Chinese_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DefaultLanguage == "en-us")
            {
                ChangeLanguage.SetDefaultLanguage("zh-cn");
                int index = tb_Main.SelectedIndex;
                this.FileManagementTool_Load(null, null);
                RefreshTabPage();
                tb_Main.SelectedIndex = index;
            }
        }
        #endregion

        #region 语言切换方法
        private void RefreshTabPage()
        {
            tb_Main.SelectTab(0);
            int index = 0;
            foreach (TabPage page in tb_Main.TabPages)
            {
                if (index > 0)
                {
                    int key = page.TabIndex;
                    this.tb_Main.TabPages.Remove(page);
                    OpenForm(key);
                }
                index++;
            }
        }

        #endregion

    }
}
