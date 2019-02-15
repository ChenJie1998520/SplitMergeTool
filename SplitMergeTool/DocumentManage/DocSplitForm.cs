using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitMergeTool.DocumentManage
{
    public partial class DocSplitForm : Form
    {
        public string showTitle = ChangeLanguage.getLanguage("FileManageTool");
        private delegate void SplitSectionMethodInvoker(object obj);
        private delegate void SplitPageMethodInvoker(object obj);

        #region 窗体事件
        public DocSplitForm()
        {
            InitializeComponent();
        }

        private void DocSplitForm_Load(object sender, EventArgs e)
        {
            Inits();
        }
        #endregion

        #region 文件及路径选择
        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (string.IsNullOrWhiteSpace(txt_SelectFile.Text))
            {
                fileDialog.InitialDirectory = "C:\\";
            }
            fileDialog.Filter = "*.doc|*.docx";
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txt_SelectFile.Text = fileDialog.FileName;
                    double fileSize = 0;
                    if (fileDialog.OpenFile().Length > 1073741824)//GB
                    {
                        fileSize = Math.Round(double.Parse(fileDialog.OpenFile().Length.ToString()) / 1024 / 1024 / 1024, 2);
                        lbl_Unit.Text = "GB";
                    }
                    else if (fileDialog.OpenFile().Length > 10485760)//MB
                    {
                        fileSize = Math.Round(double.Parse(fileDialog.OpenFile().Length.ToString()) / 1024 / 1024, 2);
                        lbl_Unit.Text = "MB";
                    }
                    else if (fileDialog.OpenFile().Length > 102400)//KB
                    {
                        fileSize = Math.Round(double.Parse(fileDialog.OpenFile().Length.ToString()) / 1024, 2);
                        lbl_Unit.Text = "KB";
                    }
                    else
                    {
                        fileSize = fileDialog.OpenFile().Length;
                        lbl_Unit.Text = "Byte";
                    }
                    txt_FileSize.Text = fileSize.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        private void btn_SelectSrc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = ChangeLanguage.getLanguage("SelectFileSavePath");
            try
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderSrc = folderDialog.SelectedPath;
                    txt_Src.Text = folderSrc;
                }
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        #endregion

        #region 初始化
        private void Inits()
        {
            gb_BaseInfo.Text = ChangeLanguage.getLanguage("BasicInformation");
            lbl_File.Text = ChangeLanguage.getLanguage("SplitFile") + "：";
            lbl_FilePath.Text = ChangeLanguage.getLanguage("FilePath") + "：";
            lbl_FileName.Text = ChangeLanguage.getLanguage("FileName") + "：";
            lbl_FileSize.Text = ChangeLanguage.getLanguage("FileLength") + "：";
            gb_SplitType.Text = ChangeLanguage.getLanguage("SplitMethod");
            rbtn_PageBreak.Text = ChangeLanguage.getLanguage("FileLength") + "：";
            rbtn_SectionBreak.Text = ChangeLanguage.getLanguage("FileCount") + "：";
            btn_Split.Text = ChangeLanguage.getLanguage("Split");
            btn_SelectFile.Text = ChangeLanguage.getLanguage("Browse");
            btn_SelectSrc.Text = ChangeLanguage.getLanguage("Browse");
            lbl_Number.Text = "+ " + ChangeLanguage.getLanguage("SerialNumber");
            rbtn_PageBreak.Text = ChangeLanguage.getLanguage("PageBreakSplit");
            rbtn_SectionBreak.Text = ChangeLanguage.getLanguage("SectionBreakSplit");
            cb_WaterMark.Text= ChangeLanguage.getLanguage("AddTextWatermark");
            lbl_Layout.Text = ChangeLanguage.getLanguage("LayoutMethod") + "：";
            lbl_Color.Text = ChangeLanguage.getLanguage("WatermarkColor") + "：";
            lbl_FontSize.Text = ChangeLanguage.getLanguage("FontSize") + "：";
            btn_Color.Text = ChangeLanguage.getLanguage("ChooseColor");
            btn_FontSize.Text = ChangeLanguage.getLanguage("ChooseFontSize");

            #region 水印排列方式
            try
            {
                IList<ComboBoxModel> comboxList = new List<ComboBoxModel>();
                ComboBoxModel box1 = new ComboBoxModel() { value = "0", text = ChangeLanguage.getLanguage("WatermarkLayoutDiagonal") };
                ComboBoxModel box2 = new ComboBoxModel() { value = "1", text = ChangeLanguage.getLanguage("WatermarkLayoutHorizontal") };
                comboxList.Add(box1);
                comboxList.Add(box2);
                cbBox_Layout.Items.Clear();
                cbBox_Layout.DataSource = comboxList;
                cbBox_Layout.ValueMember = "value";
                cbBox_Layout.DisplayMember = "text";
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
            #endregion

        }
        #endregion

        #region 鼠标悬浮文件路径提示

        private void txt_SelectFile_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip.SetToolTip(txt_SelectFile, txt_SelectFile.Text);
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        private void txt_Src_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip.SetToolTip(txt_Src, txt_Src.Text);
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 文件分割
        private void btn_Split_Click(object sender, EventArgs e)
        {
            if (!RequiredVerification())
            {
                return;
            }
            if (ShowMessage.ShowConfirm(ChangeLanguage.getLanguage("ConfirmExecution"), showTitle) == DialogResult.OK)
            {
                FileSplitModel splitModel = new FileSplitModel();
                splitModel.filePath = txt_SelectFile.Text.Trim();
                splitModel.fileOutPath = txt_Src.Text.Trim();
                splitModel.fileName = txt_FileName.Text.Trim();
                splitModel.fileExtension = splitModel.filePath.Substring(splitModel.filePath.LastIndexOf('.'));
                if (cb_WaterMark.Checked)
                {
                    WaterMarkModel waterModel = new WaterMarkModel();
                    waterModel.waterMarkContent = txt_WaterMark.Text.Trim();
                    waterModel.waterMarkColor = txt_Color.Text.Trim();
                    waterModel.waterMarkFontSize = float.Parse(txt_FontSize.Text.Trim());
                    waterModel.waterMarkLayout = int.Parse(cbBox_Layout.SelectedValue.ToString());
                    splitModel.fileWaterMark = waterModel;
                }
                if (rbtn_SectionBreak.Checked)//分节符
                {
                    try
                    {
                        SplitSectionMethodInvoker splitSectionMethod = new SplitSectionMethodInvoker(SplitSectionBreak);
                        this.BeginInvoke(splitSectionMethod, new object[] { splitModel });
                    }
                    catch(Exception ex)
                    {
                        ShowMessage.ShowError(ex.Message, showTitle);
                    }
                }
                else if (rbtn_PageBreak.Checked)//分页符
                {
                    try
                    {
                        SplitPageMethodInvoker splitPageMethod = new SplitPageMethodInvoker(SplitPageBreak);
                        this.BeginInvoke(splitPageMethod, new object[] { splitModel });
                    }
                    catch(Exception ex)
                    {
                        ShowMessage.ShowError(ex.Message, showTitle);
                    }
                }
            }
        }
        #endregion

        #region 分割方法
        /// <summary>
        /// 根据分节符进行分割方法
        /// </summary>
        /// <param name="obj"></param>
        private void SplitSectionBreak(object obj)
        {
            try
            {
                FileSplitModel splitModel = obj as FileSplitModel;
                //实例化Document对象
                Document doc = new Document();
                //载入待拆分的Word文档
                doc.LoadFromFile(splitModel.filePath);
                Document newWord;
                int index = 0;
                foreach (Section item in doc.Sections)
                {
                    newWord = new Document();//每有一个section就创建一个新的文档
                    newWord.Sections.Add(item.Clone());//复制section内容到新文档
                    if (splitModel.fileWaterMark != null)
                    {                     
                        TextWatermark txtWatermark = new TextWatermark();//新建一个TextWatermark对象，设置文本水印字样
                        txtWatermark.Text = splitModel.fileWaterMark.waterMarkContent;
                        //设置文本水印字体大小、颜色和文本排列方式
                        txtWatermark.FontSize = splitModel.fileWaterMark.waterMarkFontSize;
                        txtWatermark.Color = Color.FromName(splitModel.fileWaterMark.waterMarkColor);
                        if (splitModel.fileWaterMark.waterMarkLayout == 0)
                            txtWatermark.Layout = WatermarkLayout.Diagonal;
                        else
                            txtWatermark.Layout = WatermarkLayout.Horizontal;

                        newWord.Watermark = txtWatermark;//将文本应用到Word文档水印
                    }
                    newWord.SaveToFile(splitModel.fileOutPath + @"\" + splitModel.fileName + index + splitModel.fileExtension,FileFormat.Auto);//保存文档
                    index++;
                }
                ShowMessage.ShowInfomation(ChangeLanguage.getLanguage("ExecutionCompleted"), showTitle);
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        /// <summary>
        /// 根据分页符进行分割方法
        /// </summary>
        /// <param name="obj"></param>
        private void SplitPageBreak(object obj)
        {
            try
            {
                FileSplitModel splitModel = obj as FileSplitModel;               
                Document doc = new Document();            
                doc.LoadFromFile(splitModel.filePath);//载入待拆分的Word文档

                //实例化一个新的文档并添加新章节
                Document newWord = new Document();
                Section section = newWord.AddSection();

                int index = 0;
                //根据章节，段落的层次由大到小依次遍历文档元素，复制内容到新的文档
                foreach (Section sec in doc.Sections)
                {
                    foreach (DocumentObject docObj in sec.Body.ChildObjects)
                    {
                        if (docObj is Paragraph)
                        {
                            Paragraph para = docObj as Paragraph;
                            section.Body.ChildObjects.Add(para.Clone());

                            foreach (DocumentObject parobj in para.ChildObjects)
                            {
                                //找到段落中的分页符，保存到新文档
                                if (parobj is Break && (parobj as Break).BreakType == BreakType.PageBreak)
                                {
                                    int i = para.ChildObjects.IndexOf(parobj);
                                    section.Body.LastParagraph.ChildObjects.RemoveAt(i);
                                    if (splitModel.fileWaterMark != null)
                                    {
                                        //新建文本水印
                                        TextWatermark txtWatermark = new TextWatermark();
                                        txtWatermark.Text = splitModel.fileWaterMark.waterMarkContent;
                                        txtWatermark.FontSize = splitModel.fileWaterMark.waterMarkFontSize;
                                        txtWatermark.Color = Color.FromName(splitModel.fileWaterMark.waterMarkColor);
                                        if (splitModel.fileWaterMark.waterMarkLayout == 0)
                                            txtWatermark.Layout = WatermarkLayout.Diagonal;
                                        else
                                            txtWatermark.Layout = WatermarkLayout.Horizontal;

                                        newWord.Watermark = txtWatermark;//将文本应用到Word文档水印
                                    }

                                    newWord.SaveToFile(splitModel.fileOutPath + @"\" + splitModel.fileName + index + splitModel.fileExtension, FileFormat.Auto);
                                    index++;
                                    //一个文档完成之后新建一个文档
                                    newWord = new Document();
                                    section = newWord.AddSection();
                                    //复制上一个分页符所在的段落的所有内容到新文档
                                    section.Body.ChildObjects.Add(para.Clone());
                                    //如果新文档第一段（也就是刚刚复制的那一段）没有子元素,则把文档的第一个子元素删除
                                    if (section.Paragraphs[0].ChildObjects.Count == 0)
                                    {
                                        section.Body.ChildObjects.RemoveAt(0);
                                    }
                                    else
                                    {
                                        //如果有内容则删除分页符之前的所有内容
                                        while (i >= 0)
                                        {
                                            section.Paragraphs[0].ChildObjects.RemoveAt(i);
                                            i--;
                                        }
                                    }
                                }
                            }
                        }
                        if (docObj is Table)
                        {
                            section.Body.ChildObjects.Add(docObj.Clone());
                        }
                    }
                }
                if (splitModel.fileWaterMark != null)
                {
                    //新建文本水印
                    TextWatermark txtWatermark = new TextWatermark();
                    txtWatermark.Text = splitModel.fileWaterMark.waterMarkContent;
                    txtWatermark.FontSize = splitModel.fileWaterMark.waterMarkFontSize;
                    txtWatermark.Color = Color.FromName(splitModel.fileWaterMark.waterMarkColor);
                    if (splitModel.fileWaterMark.waterMarkLayout == 0)
                        txtWatermark.Layout = WatermarkLayout.Diagonal;
                    else
                        txtWatermark.Layout = WatermarkLayout.Horizontal;

                    newWord.Watermark = txtWatermark;//将文本应用到Word文档水印
                }
                newWord.SaveToFile(splitModel.fileOutPath + @"\" + splitModel.fileName + index + splitModel.fileExtension, FileFormat.Auto);
                ShowMessage.ShowInfomation(ChangeLanguage.getLanguage("ExecutionCompleted"), showTitle);
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 必填项验证
        /// <summary>
        /// 必填项验证
        /// </summary>
        /// <returns></returns>
        private bool RequiredVerification()
        {
            if (string.IsNullOrWhiteSpace(txt_SelectFile.Text))
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("SelectFile"), showTitle);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Src.Text))
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("SelectFileSavePath"), showTitle);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_FileName.Text))
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("EnterFileName"), showTitle);
                return false;
            }
            if(cb_WaterMark.Checked)
            {
                if (string.IsNullOrWhiteSpace(txt_WaterMark.Text))
                {
                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("EnterCustomContent"), showTitle);
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region  颜色、字体选择框
        private void btn_Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色
                Color chooseColor = colorDialog.Color;
                //改变panel的背景色
                txt_Color.Text = chooseColor.Name;

            }
        }

        private void btn_FontSize_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色
                Font chooseFont = fontDialog.Font;
                //改变panel的背景色
                txt_FontSize.Text = chooseFont.Size.ToString();

            }
        }
        #endregion

        #region 文本水印选项切换事件
        private void cb_WaterMark_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_WaterMark.Checked)
            {
                cbBox_Layout.Enabled = true;
                txt_WaterMark.Enabled = true;
                btn_Color.Enabled = true;
                btn_FontSize.Enabled = true;
            }
            else
            {
                cbBox_Layout.Enabled = false;
                txt_WaterMark.Enabled = false;
                btn_Color.Enabled = false;
                btn_FontSize.Enabled = false;
            }
        }
        #endregion
    }
}
