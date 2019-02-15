using Spire.Doc;
using Spire.Pdf;
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
using static System.Windows.Forms.ListViewItem;

namespace SplitMergeTool.ToolManage
{
    public partial class FileFormatConversionToolForm : Form
    {
        public string showTitle = ChangeLanguage.getLanguage("FileManageTool");
        private delegate void ConvertMethodInvoker(object obj);

        #region 窗体事件
        public FileFormatConversionToolForm()
        {
            InitializeComponent();
        }

        private void FileFormatConversionToolForm_Load(object sender, EventArgs e)
        {
            Inits();
        }
        #endregion

        #region 初始化
        private void Inits()
        {
            try
            {
                #region 初始化转换类型
                List<ComboBoxModel> list = new List<ComboBoxModel>();
                for (int i = 0; i < 13; i++)
                {
                    ComboBoxModel cbBoxModel = new ComboBoxModel();
                    cbBoxModel.text = ChangeLanguage.getLanguage("FormatType" + i.ToString());
                    cbBoxModel.value = i.ToString();
                    list.Add(cbBoxModel);
                }
                if (cbBox_ConvertType.Items.Count > 0)
                {
                    cbBox_ConvertType.DataSource = null;
                    cbBox_ConvertType.Items.Clear();
                }
                cbBox_ConvertType.DataSource = list;
                cbBox_ConvertType.DisplayMember = "text";
                cbBox_ConvertType.ValueMember = "value";
                cbBox_ConvertType.SelectedIndex = 0;
                #endregion

                #region 初始化文件列表
                lv_File.GridLines = true;
                lv_File.View = View.Details;//显示列名称
                lv_File.FullRowSelect = true;
                lv_File.HeaderStyle = ColumnHeaderStyle.Nonclickable;//隐藏列标题
                lv_File.Columns.Add(ChangeLanguage.getLanguage("FilePath"), 350, System.Windows.Forms.HorizontalAlignment.Center);
                lv_File.Columns.Add(ChangeLanguage.getLanguage("FileName"), 150, System.Windows.Forms.HorizontalAlignment.Center);
                lv_File.Columns.Add(ChangeLanguage.getLanguage("FileType"), 150, System.Windows.Forms.HorizontalAlignment.Center);
                lv_File.Columns.Add(ChangeLanguage.getLanguage("FileSize"), 200, System.Windows.Forms.HorizontalAlignment.Center);
                #endregion

                btn_SaveSrc.Text = ChangeLanguage.getLanguage("Browse");
                lbl_Number.Text = "+ " + ChangeLanguage.getLanguage("SerialNumber");
                btn_AddFile.Text = ChangeLanguage.getLanguage("Add");
                btn_RemoveFile.Text = ChangeLanguage.getLanguage("Remove");
                btn_Clean.Text = ChangeLanguage.getLanguage("Clear");
                gb_fileList.Text = ChangeLanguage.getLanguage("FileList");
                gb_Main.Text = ChangeLanguage.getLanguage("FilesConvert");
                gb_Operating.Text = ChangeLanguage.getLanguage("Operating");
                btn_Convert.Text = ChangeLanguage.getLanguage("Convert");
                lbl_FileName.Text = ChangeLanguage.getLanguage("FileName") + "：";
                lbl_FilePath.Text = ChangeLanguage.getLanguage("FilePath") + "：";
                lbl_ConvertType.Text = ChangeLanguage.getLanguage("ConvertType") + "：";
                this.Text = ChangeLanguage.getLanguage("FileFormatConversionTool");
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 添加
        private void btn_AddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\";

            string extension = "";
            string extensions = "";
            ComboBoxModel comboBoxModel = cbBox_ConvertType.SelectedItem as ComboBoxModel;
            switch (comboBoxModel.value)
            {
                case "0":
                case "1":
                case "2":
                case "7":
                case "9":
                case "10":
                case "11":
                case "12":
                    extension = "pdf";
                    extensions = "pdf";
                    break;
                case "3":
                    extension = "csv";
                    extensions = "csv";
                    break;
                case "4":
                    extension = "doc";
                    extensions = "docx";
                    break;
                case "5":
                    extension = "xps";
                    extensions = "xps";
                    break;
                case "6":
                    extension = "html";
                    extensions = "html";
                    break;
                case "8":
                    extension = "xls";
                    extensions = "xlsx";
                    break;
            }
            fileDialog.Filter = "*." + extension + "|*." + extensions;

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
        #endregion

        #region 移除
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

        #region 文件拖放
        //拖放完成
        private void lv_File_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();     //获取文件路径
            string extension = "";
            string extensions = "";

            ComboBoxModel comboBoxModel = cbBox_ConvertType.SelectedItem as ComboBoxModel;
            switch(comboBoxModel.value)
            {
                case "0":
                case "1":
                case "2":
                case "7":
                case "9":
                case "10":
                case "11":
                case "12":
                    extension = "pdf";
                    extensions = "pdf";
                    break;
                case "3":
                    extension = "csv";
                    extensions = "csv";
                    break;
                case "4":
                    extension = "doc";
                    extensions = "docx";
                    break;
                case "5":
                    extension = "xps";
                    extensions = "xps";
                    break;
                case "6":
                    extension = "html";
                    extensions = "html";
                    break;
                case "8":
                    extension = "xls";
                    extensions = "xlsx";
                    break;
            }

            if (string.IsNullOrWhiteSpace(extension) || string.IsNullOrWhiteSpace(extensions))
                return;
            if (path.Substring(path.LastIndexOf(".") + 1) == extension || path.Substring(path.LastIndexOf(".") + 1) == extensions)
            {
                GetFileInfo(path);
            }
        }

        //拖放进入控件时
        private void lv_File_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))//判断该文件是否可以转换到文件放置格式
                e.Effect = DragDropEffects.All;     //放置效果为所有
            else
                e.Effect = DragDropEffects.None;    //不接受该数据,无法放置，后续事件也无法触发
        }
        #endregion

        #region 选择文件保存路径
        private void btn_SaveSrc_Click(object sender, EventArgs e)
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

        #region 转换
        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!RequiredVerification())
                    return;
                if (ShowMessage.ShowConfirm(ChangeLanguage.getLanguage("ConfirmExecution"), showTitle) == DialogResult.OK)
                {
                    ComboBoxModel comboBoxModel = cbBox_ConvertType.SelectedItem as ComboBoxModel;

                    List<ConvertFormatModel> list = new List<ConvertFormatModel>();
                    foreach (ListViewItem item in lv_File.Items)
                    {
                        ConvertFormatModel model = new ConvertFormatModel();
                        model.filePath = item.SubItems[0].Text;
                        model.fileName = txt_FileName.Text + lv_File.Items.IndexOf(item);
                        switch (comboBoxModel.value)
                        {
                            case "0"://pdf转word
                                model.fileExtension = ".doc";
                                model.saveFileFormat = 0;
                                model.fileFormat = 0;
                                break;
                            case "1"://pdf转xps
                                model.fileExtension = ".xps";
                                model.saveFileFormat = 1;
                                model.fileFormat = 0;
                                break;
                            case "2"://pdf转html
                                model.fileExtension = ".html";
                                model.saveFileFormat = 2;
                                model.fileFormat = 0;
                                break;
                            case "3"://csv转pdf
                                model.fileExtension = ".pdf";
                                model.saveFileFormat = 3;
                                model.fileFormat = 1;
                                break;
                            case "4"://word转pdf
                                model.fileExtension = ".pdf";
                                model.saveFileFormat = 3;
                                model.fileFormat = 2;
                                break;
                            case "5"://xps转pdf
                                model.fileExtension = ".pdf";
                                model.saveFileFormat = 3;
                                model.fileFormat = 3;
                                break;
                            case "6"://html转pdf
                                model.fileExtension = ".pdf";
                                model.saveFileFormat = 3;
                                model.fileFormat = 4;
                                break;
                            case "7"://pdf转png
                                model.fileExtension = ".png";
                                model.saveFileFormat = 4;
                                model.fileFormat = 0;
                                break;
                            case "8"://excel转pdf
                                model.fileExtension = ".pdf";
                                model.saveFileFormat = 3;
                                model.fileFormat = 5;
                                break;
                            case "9"://pdf转jpg
                                model.fileExtension = ".jpg";
                                model.saveFileFormat = 5;
                                model.fileFormat = 0;
                                break;
                            case "10"://pdf转bmp
                                model.fileExtension = ".bmp";
                                model.saveFileFormat = 6;
                                model.fileFormat = 0;
                                break;
                            case "11"://pdf转gif
                                model.fileExtension = ".gif";
                                model.saveFileFormat = 7;
                                model.fileFormat = 0;
                                break;
                            case "12"://pdf转ico
                                model.fileExtension = ".ico";
                                model.saveFileFormat = 8;
                                model.fileFormat = 0;
                                break;
                        }
                        model.savePath = txt_FilePath.Text;
                        model.saveSrc = model.savePath + @"\" + model.fileName + model.fileExtension;

                        list.Add(model);
                    }
                    ConvertMethodInvoker convertMethod = new ConvertMethodInvoker(ConvertMethod);
                    this.BeginInvoke(convertMethod, new object[] { list });
                }
            }
            catch (Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        #endregion

        #region 转换方法
        private void ConvertMethod(object obj)
        {
            try
            {
                List<ConvertFormatModel> list = obj as List<ConvertFormatModel>;
                foreach (var item in list)
                {
                    switch(item.fileFormat)
                    {
                        case 0://pdf转word、xps、html、image
                            PdfDocument doc = new PdfDocument();
                            doc.LoadFromFile(@item.filePath);
                            switch(item.saveFileFormat)
                            {
                                case 0://word
                                    doc.SaveToFile(item.saveSrc, Spire.Pdf.FileFormat.DOC);
                                    break;
                                case 1://xps
                                    doc.SaveToFile(item.saveSrc, Spire.Pdf.FileFormat.XPS);
                                    break;
                                case 2://html
                                    doc.SaveToFile(item.saveSrc, Spire.Pdf.FileFormat.HTML);
                                    break;
                                case 4://png
                                case 5://jpg
                                case 6://bmp
                                case 7://gif
                                case 8://icon
                                    for (int i = 0; i < doc.Pages.Count; i++)
                                    {
                                        //将PDF页转换成Bitmap图形
                                        System.Drawing.Image bmp = doc.SaveAsImage(i);
                                        //将Bitmap图形保存为Png格式的图片
                                        string fileName = item.savePath + @"/" + item.fileName + i.ToString() + item.fileExtension;
                                        switch(item.saveFileFormat)
                                        {
                                            case 4:
                                                bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                                                break;
                                            case 5:
                                                bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                                                break;
                                            case 6:
                                                bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                                                break;
                                            case 7:
                                                bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                                                break;
                                            case 8:
                                                bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Icon);
                                                break;
                                        }
                                        bmp.Dispose();
                                    }
                                    break;
                            }
                            doc.Close();
                            break;
                        case 1://csv转pdf
                            Workbook workBook = new Workbook();
                            workBook.LoadFromFile(@item.filePath, ",", 1, 1);
                            //workBook.ConverterSetting.SheetFitToPage = true;
                            foreach (Worksheet worksheet in workBook.Worksheets)
                            {
                                for (int i = 1; i < worksheet.Columns.Length; i++)
                                {
                                    worksheet.AutoFitColumn(i);
                                }
                                worksheet.SaveToPdf(item.savePath + @"/" + item.fileName + workBook.Worksheets.IndexOf(worksheet) + item.fileExtension);

                                worksheet.Dispose();
                            }
                            workBook.Dispose();
                            break;
                        case 2://word转pdf
                            Document wordToPdf = new Document();
                            wordToPdf.LoadFromFile(@item.filePath);
                            wordToPdf.SaveToFile(item.saveSrc, Spire.Doc.FileFormat.PDF);
                            wordToPdf.Close();
                            break;
                        case 3://xps转pdf
                            PdfDocument xpsToPdf = new PdfDocument();
                            xpsToPdf.LoadFromXPS(@item.filePath);
                            xpsToPdf.SaveToFile(item.saveSrc, Spire.Pdf.FileFormat.PDF);
                            xpsToPdf.Close();
                            break;
                        case 4://html转pdf
                            PdfDocument htmlToPdf = new PdfDocument();
                            htmlToPdf.LoadFromHTML(@item.filePath,false,true,true);
                            htmlToPdf.SaveToFile(item.saveSrc, Spire.Pdf.FileFormat.PDF);
                            htmlToPdf.Close();
                            break;
                        case 5://excel转pdf
                            Workbook excelToPdf = new Workbook();
                            excelToPdf.LoadFromFile(@item.filePath);
                            excelToPdf.SaveToFile(item.saveSrc, Spire.Xls.FileFormat.PDF);
                            excelToPdf.Dispose();
                            break;
                    }
                }
                ShowMessage.ShowContent(ChangeLanguage.getLanguage("ExecutionCompleted"), showTitle);
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 必填项验证
        private bool RequiredVerification()
        {
            try
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
                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("SelectConvertFile"), showTitle);
                    return false;
                }

                string fileExtension = lv_File.Items[0].SubItems[2].Text;
                foreach (ListViewItem item in lv_File.Items)
                {
                    if (item.SubItems[2].Text != fileExtension)
                    {
                        ShowMessage.ShowContent(ChangeLanguage.getLanguage("InconsistentFileFormat"), showTitle);
                        return false;
                    }
                }

                ComboBoxModel comboBoxModel = cbBox_ConvertType.SelectedItem as ComboBoxModel;
                string showContent = "";
                switch (comboBoxModel.value)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "7":
                    case "9":
                    case "10":
                    case "11":
                    case "12":
                        if (fileExtension.IndexOf("pdf") == -1)
                            showContent = ChangeLanguage.getLanguage("ConversionFormatNotMatch");
                        break;
                    case "3":
                        if (fileExtension.IndexOf("csv") == -1)
                            showContent = ChangeLanguage.getLanguage("ConversionFormatNotMatch");
                        break;
                    case "4":
                        if (fileExtension.IndexOf("doc") == -1 && fileExtension.IndexOf("docx") == -1)
                            showContent = ChangeLanguage.getLanguage("ConversionFormatNotMatch");
                        break;
                    case "5":
                        if (fileExtension.IndexOf("xps") == -1)
                            showContent = ChangeLanguage.getLanguage("ConversionFormatNotMatch");
                        break;
                    case "6":
                        if (fileExtension.IndexOf("html") == -1)
                            showContent = ChangeLanguage.getLanguage("ConversionFormatNotMatch");
                        break;
                    case "8":
                        if (fileExtension.IndexOf("xls") == -1 && fileExtension.IndexOf("xlsx") == -1)
                            showContent = ChangeLanguage.getLanguage("ConversionFormatNotMatch");
                        break;
                }
                if (!string.IsNullOrWhiteSpace(showContent))
                {
                    ShowMessage.ShowContent(showContent, showTitle);
                    return false;
                }

                return true;
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
                return false;
            }
        }
        #endregion
    }
}
