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

namespace SplitMergeTool.NoteBookManage
{
    public partial class NoteMergeForm : Form
    {
        public string showTitle = ChangeLanguage.getLanguage("FileManageTool");
        private delegate void MergeMethodInvoker(object obj);

        #region 窗体事件
        public NoteMergeForm()
        {
            InitializeComponent();
        }

        private void NoteMergeForm_Load(object sender, EventArgs e)
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
            if (path.LastIndexOf(".") == path.Length - 4)
            {
                string fileExtension = path.Substring(path.LastIndexOf(".") + 1, 3);
                if (fileExtension == "txt")
                {
                    GetFileInfo(path);
                }
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

            lv_File.GridLines = true;
            lv_File.View = View.Details;//显示列名称
            lv_File.FullRowSelect = true;
            lv_File.HeaderStyle = ColumnHeaderStyle.Nonclickable;//隐藏列标题
            lv_File.Columns.Add(ChangeLanguage.getLanguage("FilePath"), 350, HorizontalAlignment.Center);
            lv_File.Columns.Add(ChangeLanguage.getLanguage("FileName"), 150, HorizontalAlignment.Center);
            lv_File.Columns.Add(ChangeLanguage.getLanguage("FileType"), 150, HorizontalAlignment.Center);
            lv_File.Columns.Add(ChangeLanguage.getLanguage("FileSize"), 200, HorizontalAlignment.Center);
        }
        #endregion

        #region 添加 移除
        private void btn_AddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Filter = "文本文件(*.txt)|*.txt";
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
                ShowMessage.ShowError(ex.Message,showTitle);
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
            if(!RequiredVerification())
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
                fileMergeModel.mergeFileName = txtFileName.Text.Trim();
                fileMergeModel.mergeFileExtension = ".txt";
                fileMergeModel.mergeFileSrc = fileMergeModel.mergeFilePath + @"\" + fileMergeModel.mergeFileName + fileMergeModel.mergeFileExtension;
                if(totalSize> 21474836480)
                {
                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("MergeFileSizeLimit"), showTitle);
                    return;
                }
                MergeMethodInvoker mergeMethod = new MergeMethodInvoker(MergeFileThread);
                this.BeginInvoke(mergeMethod, new object[] { fileMergeModel });
            }
        }
        #endregion

        #region 合并文件方法
        /// <summary>
        /// 合并文件方法
        /// </summary>
        /// <param name="obj"></param>
        private void MergeFileThread(object obj)
        {
            FileMergeModel fileMergeModel = obj as FileMergeModel;
            List<MergeModel> list = new List<MergeModel>();
            list = fileMergeModel.mergeFileList;
            //文件判断
            string outFile = fileMergeModel.mergeFileSrc;
            if (File.Exists(outFile))
            {
                File.Delete(outFile);
            }
            using (FileStream fileOut = new FileStream(fileMergeModel.mergeFileSrc, FileMode.Create, FileAccess.ReadWrite))
            {
                //转换为默认编码的流
                BinaryWriter bw = new BinaryWriter(fileOut, Encoding.UTF8);
                foreach (MergeModel item in list)
                {
                    try
                    {
                        //创建文件
                        FileStream fileStream = new FileStream(item.fileSrc, FileMode.Open, FileAccess.Read, FileShare.Read);
                        //设置当前流的位置，即开始位置
                        fileStream.Seek(0, SeekOrigin.Begin);

                        int fileData = 0;
                        //指定byte数组大小
                        byte[] buffer = new byte[fileStream.Length];
                        //读取指定大小的流
                        if ((fileData = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            //将字节数组写入流
                            bw.Write(buffer, 0, fileData);
                        }
                        if (item.fileIndex == -1)
                        {
                            ShowMessage.ShowContent(ChangeLanguage.getLanguage("ExecutionCompleted"), showTitle);
                            bw.Flush();
                            bw.Dispose();
                            bw.Close();
                            fileOut.Close();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        ShowMessage.ShowError(ex.Message, showTitle);
                        fileOut.Close();
                        return;
                    }
                    finally
                    { }
                }
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
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("EnterFileName"), showTitle);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_FilePath.Text))
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("SelectFileSavePath"), showTitle);
                return false;
            }
            if(lv_File.Items.Count==0)
            {
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("AddFileToMerge"), showTitle);
                return false;
            }
            return true;
        }
        #endregion
    }
}
