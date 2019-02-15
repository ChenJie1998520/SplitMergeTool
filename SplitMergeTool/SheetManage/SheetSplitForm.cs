using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitMergeTool.SheetManage
{
    public partial class SheetSplitForm : Form
    {
        public string showTitle = ChangeLanguage.getLanguage("FileManageTool");
        private delegate void InitSheetMethodInvoker(object obj);
        private delegate void SplitMethodInvoker(object obj);

        #region 窗体事件
        public SheetSplitForm()
        {
            InitializeComponent();
        }

        private void SheetSplitForm_Load(object sender, EventArgs e)
        {
            Inits();
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
            btn_Split.Text = ChangeLanguage.getLanguage("Split");
            btn_SelectFile.Text = ChangeLanguage.getLanguage("Browse");
            btn_SelectSrc.Text = ChangeLanguage.getLanguage("Browse");
            lbl_Number.Text = "+ " + ChangeLanguage.getLanguage("SerialNumber");
            gb_SplitWay.Text = ChangeLanguage.getLanguage("SplitType");
            rbtn_AllWorkBook.Text = ChangeLanguage.getLanguage("SplitAllWorksheetsIntoWorkbooks");
            rbtn_FixedRows.Text = ChangeLanguage.getLanguage("SplitWorksheetIntoFixedRows");
            gb_FixedRows.Text = ChangeLanguage.getLanguage("SplitWorksheetIntoFixedRows");
            rbtn_FixedRowsAll.Text = ChangeLanguage.getLanguage("AllWorksheets");
            rbtn_FixedRowsDesignation.Text = ChangeLanguage.getLanguage("DesignatedWorksheet");
            lbl_FixedRows.Text = ChangeLanguage.getLanguage("Rows") + "：";
            lbl_FixedRowsChooseWorkSheet.Text = ChangeLanguage.getLanguage("WorkSheet") + "：";
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

        #region 文件及路径选择
        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (string.IsNullOrWhiteSpace(txt_SelectFile.Text))
            {
                fileDialog.InitialDirectory = "C:\\";
            }
            fileDialog.Filter = "Excel 2007文件|*.xlsx|Excel 99-03文件|*.xls";
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
                    InitSheetMethodInvoker sheetMethod = new InitSheetMethodInvoker(InitSheetMethod);
                    this.BeginInvoke(sheetMethod, new object[] { fileDialog.FileName });
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
            if (rbtn_FixedRows.Checked)
            {
                Regex regex = new Regex(@"^[1-9]\d*$");
                Regex regexs = new Regex(@"^[0-9]\d*$");
                if (string.IsNullOrWhiteSpace(txt_FixedRowsBegin.Text))
                {
                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("RowsCannotBeEmpty"), showTitle);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txt_FixedRowsEnd.Text))
                {
                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("RowsCannotBeEmpty"), showTitle);
                    return false;
                }
                if(!regex.IsMatch(txt_FixedRowsBegin.Text) || !regexs.IsMatch(txt_FixedRowsEnd.Text))
                {
                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("RowsWrongFormat"), showTitle);
                    return false;
                }
                if(rbtn_FixedRowsDesignation.Checked)
                {
                    if(cbBox_FixedRowsWorkSheet.SelectedItem==null)
                    {
                        ShowMessage.ShowContent(ChangeLanguage.getLanguage("ChooseWorksheet"), showTitle);
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion

        #region 拆分
        private void btn_Split_Click(object sender, EventArgs e)
        {
            if(!RequiredVerification())
            {
                return;
            }
            if (ShowMessage.ShowConfirm(ChangeLanguage.getLanguage("ConfirmExecution"), showTitle) == DialogResult.OK)
            {
                FileSplitModel fileSplitModel = new FileSplitModel();
                fileSplitModel.filePath = txt_SelectFile.Text.Trim();
                fileSplitModel.fileOutPath = txt_Src.Text.Trim();
                fileSplitModel.fileName = txt_FileName.Text.Trim();
                fileSplitModel.fileExtension = fileSplitModel.filePath.Substring(fileSplitModel.filePath.LastIndexOf('.'));
                ExcelSplitModel excelModel = new ExcelSplitModel();
                if (rbtn_AllWorkBook.Checked)
                {
                    excelModel.splitType = 1;
                }
                else if (rbtn_FixedRows.Checked)
                {
                    excelModel.splitType = 2;
                    excelModel.sheetName = "";
                    excelModel.beginRow = int.Parse(txt_FixedRowsBegin.Text.Trim());
                    excelModel.endRow = int.Parse(txt_FixedRowsEnd.Text.Trim());
                    if (rbtn_FixedRowsDesignation.Checked)
                    {
                        ComboBoxModel model = cbBox_FixedRowsWorkSheet.SelectedItem as ComboBoxModel;
                        if (model == null)
                        {
                            ShowMessage.ShowError(ChangeLanguage.getLanguage("SpecifiedWorksheetCannotBeEmpty"), showTitle);
                            return;
                        }
                        excelModel.sheetName = model.text;
                    }
                }

                fileSplitModel.fileExcel = excelModel;

                SplitMethodInvoker splitAllMethod = new SplitMethodInvoker(SplitSheetMethod);
                this.BeginInvoke(splitAllMethod, new object[] { fileSplitModel });
            }
        }
        #endregion

        #region 拆分方法
        private void SplitSheetMethod(object obj)
        {
            FileSplitModel fileSplitModel = obj as FileSplitModel;
            Workbook workBook = new Workbook();
            try
            {
                workBook.LoadFromFile(fileSplitModel.filePath);
                foreach (Worksheet sheet in workBook.Worksheets)
                {
                    //实例化一个新的Workbook对象，创建一个空的工作表
                    Workbook newWorkBook = new Workbook();
                    newWorkBook.CreateEmptySheets(1);
                    string filePath = fileSplitModel.fileOutPath + @"\" + fileSplitModel.fileName + sheet.Index + fileSplitModel.fileExtension;

                    //拆分
                    if (fileSplitModel.fileExcel.splitType == 1)
                    {
                        if (fileSplitModel.fileExtension == ".xls")
                            newWorkBook.SaveToFile(filePath, ExcelVersion.Version97to2003);
                        else
                            newWorkBook.SaveToFile(filePath, ExcelVersion.Version2007);

                        newWorkBook.LoadFromFile(filePath);//加载工作簿

                        //获取源excel工作表中的工作表，将它们复制到newWorkBook中的工作表
                        Worksheet newSheet = newWorkBook.Worksheets.AddCopy(sheet);
                        newWorkBook.Worksheets.RemoveAt(0);
                        newSheet.Name = sheet.Name;
                    }
                    else if (fileSplitModel.fileExcel.splitType == 2)
                    {
                        if (sheet.FirstRow == -1)
                            continue;
                        string sheetName = fileSplitModel.fileExcel.sheetName;
                        int begin = fileSplitModel.fileExcel.beginRow;
                        int end = fileSplitModel.fileExcel.endRow;
                        if (end == 0)
                            end = sheet.LastRow;
                        Worksheet newWorkSheet = newWorkBook.Worksheets[0];
                        CellRange range = sheet.Range[begin, 1, end, sheet.LastColumn];
                        if (!string.IsNullOrWhiteSpace(sheetName))
                        {
                            if (sheet.Name == sheetName)
                            {
                                newWorkSheet.Copy(range, newWorkSheet.Range[1, 1]);
                            }
                        }
                        else
                        {
                            newWorkSheet.Copy(range, newWorkSheet.Range[1, 1]);
                        }
                        newWorkSheet.Name = sheet.Name;
                    }
                    if (fileSplitModel.fileExtension == ".xls")
                        newWorkBook.SaveToFile(filePath, ExcelVersion.Version97to2003);
                    else
                        newWorkBook.SaveToFile(filePath, ExcelVersion.Version2007);
                    newWorkBook.Dispose();
                }
                workBook.Dispose();
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("ExecutionCompleted"), showTitle);
            }
            catch(Exception ex)
            {
                workBook.Dispose();
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 初始化工作表数据
        private void InitSheetMethod(object obj)
        {
            try
            {
                string[] list = Common.GetWorkBookSheetNames(obj.ToString());
                IList<ComboBoxModel> comboxList = new List<ComboBoxModel>();
                int index = 0;
                if (list != null && list.Length > 0)
                {
                    foreach (var item in list)
                    {
                        ComboBoxModel box = new ComboBoxModel() { value = index.ToString(), text = item.ToString() };
                        if (!string.IsNullOrWhiteSpace(box.text))
                            comboxList.Add(box);
                        index++;
                    }

                    if (cbBox_FixedRowsWorkSheet.Items.Count > 0)
                    {
                        cbBox_FixedRowsWorkSheet.DataSource = null;
                        cbBox_FixedRowsWorkSheet.Items.Clear();
                    }
                    cbBox_FixedRowsWorkSheet.DataSource = comboxList;
                    cbBox_FixedRowsWorkSheet.ValueMember = "value";
                    cbBox_FixedRowsWorkSheet.DisplayMember = "text";
                }
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 拆分类型
        private void rbtn_FixedRows_CheckedChanged(object sender, EventArgs e)
        {
            gb_FixedRows.Enabled = true;
        }

        private void rbtn_AllWorkBook_CheckedChanged(object sender, EventArgs e)
        {
            gb_FixedRows.Enabled = false;
        }
        #endregion

        #region 固定行数拆分选项事件
        private void rbtn_FixedRowsAll_CheckedChanged(object sender, EventArgs e)
        {
            cbBox_FixedRowsWorkSheet.Enabled = false;
        }

        private void rbtn_FixedRowsDesignation_CheckedChanged(object sender, EventArgs e)
        {
            cbBox_FixedRowsWorkSheet.Enabled = true;
        }
        #endregion
    }
}
