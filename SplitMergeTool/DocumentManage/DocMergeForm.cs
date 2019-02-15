using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitMergeTool.DocumentManage
{
    public partial class DocMergeForm : Form
    {
        public string showTitle = ChangeLanguage.getLanguage("FileManageTool");
        private delegate void DocPageMergeMethodInvoker(object obj);
        private delegate void DocParagraphMergeMethodInvoker(object obj);

        #region 窗体事件
        public DocMergeForm()
        {
            InitializeComponent();
        }

        private void DocMergeForm_Load(object sender, EventArgs e)
        {
            Inits();
        }
        #endregion

        #region 文件拖放
        //拖放进入控件时
        private void lv_File_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))//判断该文件是否可以转换到文件放置格式
                e.Effect = DragDropEffects.All;     //放置效果为所有
            else
                e.Effect = DragDropEffects.None;    //不接受该数据,无法放置，后续事件也无法触发
        }

        //拖放完成
        private void lv_File_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();     //获取文件路径
            if (path.Substring(path.LastIndexOf(".")) == ".doc" || path.Substring(path.LastIndexOf(".")) == ".docx")
            {
                string fileExtension = path.Substring(path.LastIndexOf("."));
                GetFileInfo(path);
            }
        }
        #endregion

        #region 初始化
        private void Inits()
        {
            gb_Main.Text = ChangeLanguage.getLanguage("FilesMerged");
            gb_fileList.Text = ChangeLanguage.getLanguage("FileList");
            gb_Operating.Text = ChangeLanguage.getLanguage("Operating");
            btn_AddFile.Text = ChangeLanguage.getLanguage("Add");
            btn_RemoveFile.Text = ChangeLanguage.getLanguage("Remove");
            btn_Clean.Text = ChangeLanguage.getLanguage("Clear");
            btn_UpFile.Text = ChangeLanguage.getLanguage("MoveUp");
            btn_DownFile.Text = ChangeLanguage.getLanguage("MoveDown");

            lbl_FileName.Text = ChangeLanguage.getLanguage("FileName") + "：";
            lbl_FilePath.Text = ChangeLanguage.getLanguage("FilePath") + "：";
            btn_SelectSrc.Text = ChangeLanguage.getLanguage("Browse");
            btn_Merge.Text = ChangeLanguage.getLanguage("Merge");

            rbtn_NewPage.Text = ChangeLanguage.getLanguage("AddNewPageMerge");
            rbtn_EndSection.Text= ChangeLanguage.getLanguage("TakeEndParagraph");

            lv_File.GridLines = true;
            lv_File.View = View.Details;//显示列名称
            lv_File.FullRowSelect = true;
            lv_File.HeaderStyle = ColumnHeaderStyle.Nonclickable;//隐藏列标题
            lv_File.Columns.Add(ChangeLanguage.getLanguage("FilePath"), 350, System.Windows.Forms.HorizontalAlignment.Center);
            lv_File.Columns.Add(ChangeLanguage.getLanguage("FileName"), 150, System.Windows.Forms.HorizontalAlignment.Center);
            lv_File.Columns.Add(ChangeLanguage.getLanguage("FileType"), 150, System.Windows.Forms.HorizontalAlignment.Center);
            lv_File.Columns.Add(ChangeLanguage.getLanguage("FileSize"), 200, System.Windows.Forms.HorizontalAlignment.Center);
        }
        #endregion

        #region 添加 移除
        private void btn_AddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Filter = "*.doc|*.docx";
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    GetFileInfo(fileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        private void btn_RemoveFile_Click(object sender, EventArgs e)
        {
            if (lv_File.SelectedItems.Count == 0)
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("SelectItemToRemove"), showTitle);
                return;
            }
            foreach (ListViewItem item in lv_File.SelectedItems)
            {
                item.Remove();//删除方法
            }
        }

        #endregion

        #region 清空
        private void btn_Clean_Click(object sender, EventArgs e)
        {
            lv_File.Items.Clear();
        }
        #endregion

        #region 上移 下移
        private void btn_UpFile_Click(object sender, EventArgs e)
        {
            if (lv_File.SelectedItems.Count == 0)
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("SelectItemToMove"), showTitle);
                return;
            }
            if (lv_File.SelectedItems[0].Index == 0)
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("FirstItemCannotMove"), showTitle);
                return;
            }

            lv_File.BeginUpdate();
            foreach (ListViewItem file in lv_File.SelectedItems)
            {
                ListViewItem item = file;
                int index = file.Index;
                lv_File.Items.RemoveAt(index);
                lv_File.Items.Insert(index - 1, item);
            }
            lv_File.EndUpdate();
        }

        private void btn_DownFile_Click(object sender, EventArgs e)
        {
            if (lv_File.SelectedItems.Count == 0)
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("SelectItemToMove"), showTitle);
                return;
            }
            if (lv_File.SelectedItems[lv_File.SelectedItems.Count - 1].Index == (lv_File.Items.Count - 1))
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("LastItemCannotMove"), showTitle);
                return;
            }

            lv_File.BeginUpdate();
            int count = lv_File.SelectedItems.Count;
            foreach (ListViewItem file in lv_File.SelectedItems)
            {
                ListViewItem item = file;
                int index = file.Index;
                lv_File.Items.RemoveAt(index);
                lv_File.Items.Insert(index + count, item);
            }
            lv_File.EndUpdate();
        }
        #endregion

        #region 选择文件输出路径
        private void btn_SelectSrc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = ChangeLanguage.getLanguage("SelectFileSavePath");
            try
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderSrc = folderDialog.SelectedPath;
                    txt_FilePath.Text = folderSrc;
                }
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 鼠标悬浮显示文件输出路径
        private void txt_FilePath_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip.SetToolTip(txt_FilePath, txt_FilePath.Text);
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 获取文件信息
        /// <summary>
        /// 获取文件信息
        /// </summary>
        /// <param name="path">文件路径</param>
        private void GetFileInfo(string path)
        {
            System.IO.FileInfo fileInfo = null;
            try
            {
                fileInfo = new System.IO.FileInfo(path);
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
            // 如果文件存在
            if (fileInfo != null && fileInfo.Exists)
            {

                ListViewItem item = new ListViewItem(path);
                item.SubItems.Add(fileInfo.Name);
                item.SubItems.Add(fileInfo.Extension);
                item.SubItems.Add(fileInfo.Length.ToString());
                lv_File.Items.Add(item);
            }
            else
            {
                ShowMessage.ShowError(ChangeLanguage.getLanguage("FilePathError"), showTitle);
            }
        }
        #endregion

        #region 文件合并
        private void btn_Merge_Click(object sender, EventArgs e)
        {
            if (!RequiredVerification())
            {
                return;
            }
            if (ShowMessage.ShowConfirm(ChangeLanguage.getLanguage("ConfirmExecution"), showTitle) == DialogResult.OK)
            {
                double totalSize = 0;
                FileMergeModel fileMergeModel = new FileMergeModel();
                List<MergeModel> list = new List<MergeModel>();
                foreach (ListViewItem item in lv_File.Items)
                {
                    MergeModel model = new MergeModel();
                    model.fileSrc = item.SubItems[0].Text;
                    model.fileName = item.SubItems[1].Text;
                    model.fileExtension = item.SubItems[2].Text;
                    model.fileLength = item.SubItems[3].Text;
                    if (item.Index == lv_File.Items.Count - 1)
                        model.fileIndex = -1;
                    else
                        model.fileIndex = item.Index;
                    totalSize += double.Parse(model.fileLength);
                    list.Add(model);
                }
                fileMergeModel.mergeFileList = list;
                fileMergeModel.mergeFilePath = txt_FilePath.Text;
                fileMergeModel.mergeFileName = txt_FileName.Text.Trim();
                fileMergeModel.mergeFileExtension = lv_File.Items[0].SubItems[2].Text;
                fileMergeModel.mergeFileSrc = fileMergeModel.mergeFilePath + @"\" + fileMergeModel.mergeFileName + fileMergeModel.mergeFileExtension;
                if (totalSize > 21474836480)
                {
                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("MergeFileSizeLimit"), showTitle);
                    return;
                }
                if (rbtn_NewPage.Checked)
                {
                    DocPageMergeMethodInvoker mergePageMethod = new DocPageMergeMethodInvoker(DocPageMergeMethod);
                    this.BeginInvoke(mergePageMethod, new object[] { fileMergeModel });
                }
                else
                {
                    DocParagraphMergeMethodInvoker mergeParagraphMethod = new DocParagraphMergeMethodInvoker(DocParagraphMergeMethod);
                    this.BeginInvoke(mergeParagraphMethod, new object[] { fileMergeModel });
                }
            }
        }
        #endregion

        #region 合并文件方法
        /// <summary>
        /// 添加新页合并方法
        /// </summary>
        /// <param name="obj"></param>
        private void DocPageMergeMethod(object obj)
        {
            try
            {
                FileMergeModel fileMergeModel = obj as FileMergeModel;
                //实例化Document对象
                Document doc = new Document();
                foreach (var mergeFile in fileMergeModel.mergeFileList)
                {
                    //使用InsertTextFromFile方法将文档合并到已创建的文档对象中
                    doc.InsertTextFromFile(mergeFile.fileSrc, FileFormat.Auto);
                }
                doc.SaveToFile(fileMergeModel.mergeFileSrc, FileFormat.Auto); //保存文档

                ShowMessage.ShowContent(ChangeLanguage.getLanguage("ExecutionCompleted"), showTitle);
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        /// <summary>
        /// 承接段尾合并方法
        /// </summary>
        /// <param name="obj"></param>
        private void DocParagraphMergeMethod(object obj)
        {
            try
            {
                FileMergeModel fileMergeModel = obj as FileMergeModel;
                //实例化Document对象
                Document doc = new Document();
                doc.InsertTextFromFile(fileMergeModel.mergeFileList[0].fileSrc, FileFormat.Auto);

                //遍历进行合并
                for (var i = 1; i < fileMergeModel.mergeFileList.Count; i++)
                {
                    Section lastSection = doc.LastSection;//获取doc的最后一个section

                    Document currDoc = new Document(fileMergeModel.mergeFileList[i].fileSrc);

                    //遍历currDoc的section和段落，将每一个段落添加到doc的最后一个section
                    foreach (Section section in currDoc.Sections)
                    {
                        foreach (Paragraph paragraph in section.Paragraphs)
                        {
                            lastSection.Paragraphs.Add(paragraph.Clone() as Paragraph);
                        }
                    }
                }
                doc.SaveToFile(fileMergeModel.mergeFileSrc, FileFormat.Auto);//保存为新的文档
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("ExecutionCompleted"), showTitle);
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
            if (string.IsNullOrWhiteSpace(txt_FileName.Text))
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("EnterFileName"), showTitle);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_FilePath.Text))
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("SelectFileSavePath"), showTitle);
                return false;
            }
            if (lv_File.Items.Count == 0)
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("AddFileToMerge"), showTitle);
                return false;
            }
            return true;
        }
        #endregion
    }
}
