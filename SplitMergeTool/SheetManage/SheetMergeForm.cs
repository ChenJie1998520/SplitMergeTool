using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitMergeTool.SheetManage
{
    public partial class SheetMergeForm : Form
    {
        public string showTitle = ChangeLanguage.getLanguage("FileManageTool");
        private delegate void WorkBookMergeMethodInvoker(object obj);
        private delegate void WorkSheetMergeMethodInvoker(object obj);

        #region 窗体事件
        public SheetMergeForm()
        {
            InitializeComponent();
        }

        private void SheetMergeForm_Load(object sender, EventArgs e)
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
            if (path.Substring(path.LastIndexOf(".")) == ".xls" || path.Substring(path.LastIndexOf(".")) == ".xlsx")
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

            rbtn_WorkBook.Text = ChangeLanguage.getLanguage("MultipleWorkbookMerges");
            rbtn_WorkSheet.Text = ChangeLanguage.getLanguage("MultipleWorksheetsMerges");

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
            fileDialog.Filter = "*.xls|*.xlsx";
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

        #region 合并
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

                if (rbtn_WorkBook.Checked)
                {
                    WorkBookMergeMethodInvoker mergeWorkBookMethod = new WorkBookMergeMethodInvoker(WorkBookMergeMethod);
                    this.BeginInvoke(mergeWorkBookMethod, new object[] { fileMergeModel });
                }
                else if(rbtn_WorkSheet.Checked)
                {
                    WorkSheetMergeMethodInvoker mergeWorkSheetMethod = new WorkSheetMergeMethodInvoker(WorkSheetMergeMethod);
                    this.BeginInvoke(mergeWorkSheetMethod, new object[] { fileMergeModel });
                }
            }
        }
        #endregion

        #region 合并方法
        /// <summary>
        /// 工作簿合并
        /// </summary>
        /// <param name="obj"></param>
        private void WorkBookMergeMethod(object obj)
        {
            FileMergeModel fileMergeModel = obj as FileMergeModel;
            Workbook workBook = new Workbook();
            try
            {
                workBook.CreateEmptySheets(1);
                if (fileMergeModel != null && fileMergeModel.mergeFileList != null)
                {
                    foreach (var mergeFile in fileMergeModel.mergeFileList)
                    {
                        Workbook subWorkBook = new Workbook();
                        subWorkBook.LoadFromFile(mergeFile.fileSrc);
                        workBook.Worksheets.AddCopy(subWorkBook.Worksheets);
                        subWorkBook.Dispose();
                    }
                }
                workBook.Worksheets.RemoveAt(0);
                if (fileMergeModel.mergeFileExtension == ".xls")
                    workBook.SaveToFile(fileMergeModel.mergeFileSrc, ExcelVersion.Version97to2003);
                else
                    workBook.SaveToFile(fileMergeModel.mergeFileSrc, ExcelVersion.Version2007);
                workBook.Dispose();
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("ExecutionCompleted"), showTitle);
            }
            catch(Exception ex)
            {
                workBook.Dispose();
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        /// <summary>
        /// 工作表合并
        /// </summary>
        /// <param name="obj"></param>
        private void WorkSheetMergeMethod(object obj)
        {
            FileMergeModel fileMergeModel = obj as FileMergeModel;
            try
            {
                if (fileMergeModel != null && fileMergeModel.mergeFileList != null)
                {
                    int index = 0;
                    foreach (var mergeFile in fileMergeModel.mergeFileList)
                    {
                        string filePath = fileMergeModel.mergeFilePath + @"\" + fileMergeModel.mergeFileName + index + fileMergeModel.mergeFileExtension;

                        //新建工作簿
                        Workbook workBook = new Workbook();
                        workBook.CreateEmptySheets(1);

                        //需合并的工作簿
                        Workbook subWorkBook = new Workbook();
                        subWorkBook.LoadFromFile(mergeFile.fileSrc);

                        //同步第一个工作表并生成
                        workBook.Worksheets.AddCopy(subWorkBook.Worksheets);
                        int sheetCount = workBook.Worksheets.Count;
                        for (int i = sheetCount - 1; i >= 0; i--)
                        {
                            if (i != 1)
                                workBook.Worksheets.RemoveAt(i);
                        }

                        if (fileMergeModel.mergeFileExtension == ".xls")
                            workBook.SaveToFile(filePath, ExcelVersion.Version97to2003);
                        else
                            workBook.SaveToFile(filePath, ExcelVersion.Version2007);

                        workBook.LoadFromFile(filePath);
                        Worksheet workSheet = workBook.Worksheets[0];

                        //遍历工作簿中的工作表
                        int subIndex = 0;
                        foreach (Worksheet subSheet in subWorkBook.Worksheets)
                        {
                            if (subIndex > 0)
                            {
                                //复制subSheet工作表内容到合并工作表(workSheet)的指定区域中->追加
                                subSheet.AllocatedRange.Copy(workSheet.Range[workSheet.LastRow + 1, 1]);
                            }
                            subIndex++;
                        }
                        subWorkBook.Dispose();
                        workSheet.Name = "Merged sheet";

                        if (fileMergeModel.mergeFileExtension == ".xls")
                            workBook.SaveToFile(filePath, ExcelVersion.Version97to2003);
                        else
                            workBook.SaveToFile(filePath, ExcelVersion.Version2007);

                        workBook.Dispose();
                        index++;
                    }

                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("ExecutionCompleted"), showTitle);
                }
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 合并文件名更改
        private void rbtn_WorkBook_CheckedChanged(object sender, EventArgs e)
        {
            txt_FileName.Text = "MergeExcel";
        }

        private void rbtn_WorkSheet_CheckedChanged(object sender, EventArgs e)
        {
            txt_FileName.Text = "MergeExcel_";
        }
        #endregion
    }
}
