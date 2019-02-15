using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitMergeTool.NoteBookManage
{
    public partial class NoteSplitForm : Form
    {
        FileStream fileStream;
        public string showTitle = ChangeLanguage.getLanguage("FileManageTool");
        private delegate void SplitMethodInvoker(object obj);

        #region 窗体事件
        public NoteSplitForm()
        {
            InitializeComponent();
        }

        private void TextSplitterForm_Load(object sender, EventArgs e)
        {
            Inits();
        }
        #endregion

        #region 文件及路径选择
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (string.IsNullOrWhiteSpace(txt_SelectFile.Text))
            {
                fileDialog.InitialDirectory = "C:\\";
            }
            fileDialog.Filter = "文本文件(*.txt)|*.txt";
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
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        private void btnSelectSrc_Click(object sender, EventArgs e)
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
            catch(Exception ex)
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
            lbl_FilePath.Text= ChangeLanguage.getLanguage("FilePath") + "：";
            lbl_FileName.Text = ChangeLanguage.getLanguage("FileName") + "：";
            lbl_FileSize.Text = ChangeLanguage.getLanguage("FileLength") + "：";
            gb_SplitType.Text = ChangeLanguage.getLanguage("SplitMethod");
            rbtn_Size.Text = ChangeLanguage.getLanguage("FileLength") + "：";
            lbl_FileCount.Text = ChangeLanguage.getLanguage("FileCount") + "：";
            rbtn_Total.Text = ChangeLanguage.getLanguage("FileCount") + "：";
            lbl_FileLength.Text = ChangeLanguage.getLanguage("FileLength") + "：";
            cb_CustomContent.Text = ChangeLanguage.getLanguage("SplitCustomOptions");
            btn_Split.Text = ChangeLanguage.getLanguage("Split");
            btn_SelectFile.Text = ChangeLanguage.getLanguage("Browse");
            btn_SelectSrc.Text = ChangeLanguage.getLanguage("Browse");
            lbl_Number.Text = "+ " + ChangeLanguage.getLanguage("SerialNumber");

        }
        #endregion

        #region 鼠标悬浮文件路径提示
        private void txtSrc_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip.SetToolTip(txt_Src, txt_Src.Text);
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message,showTitle);
            }
        }

        private void txtSelectFile_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip.SetToolTip(txt_SelectFile, txt_SelectFile.Text);
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 文件分割方式选择
        private void rbtnSize_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txt_FixedSize.Enabled = true;
                txt_FixedTotal.Enabled = false;
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }

        private void rbtnTotal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txt_FixedSize.Enabled = false;
                txt_FixedTotal.Enabled = true;
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 文件分割
        private void btnSplit_Click(object sender, EventArgs e)
        {
            if(!RequiredVerification())
            {
                return;
            }
            if (ShowMessage.ShowConfirm(ChangeLanguage.getLanguage("ConfirmExecution"), showTitle) == DialogResult.OK)
            {
                string filePath = txt_SelectFile.Text.Trim();
                if (!File.Exists(filePath))//文件不存在
                {
                    ShowMessage.ShowError(ChangeLanguage.getLanguage("FilePathError"), showTitle);
                    return;
                }

                //新建文件流
                if (fileStream != null)
                {
                    fileStream.Close();
                }
                fileStream = new FileStream(txt_SelectFile.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                //设置当前流的位置，即开始位置
                fileStream.Seek(0, SeekOrigin.Begin);
                try
                {
                    //获取文件信息
                    double fixSize = 0;
                    int fileCount = 0;
                    if (rbtn_Size.Checked)//固定文件大小
                    {
                        fixSize = double.Parse(txt_FixedSize.Text);
                        fileCount = Convert.ToInt32(txt_Total.Text);
                    }
                    else if (rbtn_Total.Checked)//固定分割份数
                    {
                        fixSize = double.Parse(txt_Size.Text);
                        fileCount = Convert.ToInt32(txt_FixedTotal.Text);
                    }

                    for (int i = 0; i < fileCount; i++)
                    {
                        //实例化分割文件信息
                        FileSplitModel splitModel = new FileSplitModel();
                        splitModel.fileName = txt_FileName.Text + i.ToString();
                        splitModel.fileExtension = ".txt";
                        splitModel.fileOutPath = txt_Src.Text;
                        splitModel.fileSrc = splitModel.fileOutPath + @"\" + splitModel.fileName + splitModel.fileExtension;
                        splitModel.fileLength = Convert.ToInt32(fixSize).ToString();


                        splitModel.fileStreamReadOffset = 0;
                        if (i == fileCount - 1)
                            splitModel.fileIndex = -1;
                        else
                            splitModel.fileIndex = i;

                        SplitMethodInvoker splitMethod = new SplitMethodInvoker(SplitFileThread);
                        this.BeginInvoke(splitMethod, new object[] { splitModel });
                    }
                }
                catch (Exception ex)
                {
                    ShowMessage.ShowError(ex.Message, showTitle);
                }
            }
        }
        #endregion

        #region 分割方法
        /// <summary>
        /// 分割方法
        /// </summary>
        /// <param name="obj"></param>
        private void SplitFileThread(object obj)
        {
            FileSplitModel fileSplitModel = obj as FileSplitModel;

            //文件判断
            string outFile = @fileSplitModel.fileSrc;
            if (File.Exists(outFile))
            {
                File.Delete(outFile);
            }
            if (!System.IO.File.Exists(outFile))
            {
                FileStream fs;
                fs = File.Create(outFile);
                fs.Close();
            }

            //新建文件流按照指定的块数分割文件
            using (FileStream newFileStream = new FileStream(outFile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                int fileData = 0;
                int bufferLength = Convert.ToInt32(fileSplitModel.fileLength);


                //指定byte数组大小
                byte[] buffer = new byte[bufferLength];

                //读取指定大小的流
                if ((fileData = fileStream.Read(buffer, fileSplitModel.fileStreamReadOffset, buffer.Length)) > 0)
                {
                    //转换为默认编码的流
                    BinaryWriter bw = new BinaryWriter(newFileStream, Encoding.UTF8);

                    if (cb_CustomContent.Checked && !string.IsNullOrWhiteSpace(txt_CustomContent.Text))
                    {
                        bw.Write(txt_CustomContent.Text.Trim());
                    }

                    //将字节数组写入流
                    bw.Write(buffer, 0, fileData);
                    bw.Flush();
                    bw.Dispose();
                    bw.Close();
                }
                else
                {
                    ShowMessage.ShowError(string.Format(ChangeLanguage.getLanguage("SplitPrompt"),outFile), showTitle);
                    return;
                }
                if(fileSplitModel.fileIndex==-1)
                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("ExecutionCompleted"),showTitle);
            }
        }
        #endregion

        #region 自定义内容控件启用/禁用
        private void cbCustomContent_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_CustomContent.Checked)
                txt_CustomContent.ReadOnly = false;
            else
                txt_CustomContent.ReadOnly = true;
        }
        #endregion

        #region 必填项验证
        /// <summary>
        /// 必填项验证
        /// </summary>
        /// <returns></returns>
        private bool RequiredVerification()
        {
            if(string.IsNullOrWhiteSpace(txt_SelectFile.Text))
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
            if (rbtn_Size.Checked)
            {
                if (string.IsNullOrWhiteSpace(txt_FixedSize.Text))
                {
                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("EnterFileSize"), showTitle);
                    return false;
                }
            }
            else if (rbtn_Total.Checked)
            {
                if (string.IsNullOrWhiteSpace(txt_FixedTotal.Text))
                {
                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("EnterFileCount"), showTitle);
                    return false;
                }
            }
            if (cb_CustomContent.Checked)
            {
                if (string.IsNullOrWhiteSpace(txt_CustomContent.Text))
                {
                    ShowMessage.ShowContent(ChangeLanguage.getLanguage("EnterCustomContent"), showTitle);
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 根据文件固定大小或文件固定份数决定总份数或每份文件大小
        private void txtFixedSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_FileSize.Text) && !string.IsNullOrWhiteSpace(txt_FixedSize.Text))
                {
                    if (int.Parse(txt_FixedTotal.Text) >= 1)
                    {
                        double fileTotalSize = double.Parse(txt_FileSize.Text);
                        switch (lbl_Unit.Text)
                        {
                            case "Byte":
                                break;
                            case "KB":
                                fileTotalSize = Math.Round(fileTotalSize * 1024, 0);
                                break;
                            case "MB":
                                fileTotalSize = Math.Round(fileTotalSize * 1024 * 1024, 0);
                                break;
                            case "GB":
                                fileTotalSize = Math.Round(fileTotalSize * 1024 * 1024 * 1024, 0);
                                break;
                        }
                        double fixedSize = double.Parse(txt_FixedSize.Text);

                        int count = 0;
                        if (fileTotalSize % fixedSize == 0)
                        {
                            count = Convert.ToInt32(Math.Round(fileTotalSize / fixedSize, 0));
                        }
                        else
                        {
                            count = Convert.ToInt32(Math.Floor(fileTotalSize / fixedSize)) + 1;
                        }
                        txt_Total.Text = count.ToString();
                    }
                }
            }
            catch(Exception ex)
            {}
        }

        private void txtFixedTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_FileSize.Text) && !string.IsNullOrWhiteSpace(txt_FixedTotal.Text))
                {
                    if (int.Parse(txt_FixedTotal.Text) >= 1)
                    {
                        double fileTotalSize = double.Parse(txt_FileSize.Text);
                        switch (lbl_Unit.Text)
                        {
                            case "Byte":
                                break;
                            case "KB":
                                fileTotalSize = Math.Round(fileTotalSize * 1024, 0);
                                break;
                            case "MB":
                                fileTotalSize = Math.Round(fileTotalSize * 1024 * 1024, 0);
                                break;
                            case "GB":
                                fileTotalSize = Math.Round(fileTotalSize * 1024 * 1024 * 1024, 0);
                                break;
                        }
                        double fixedTotal = double.Parse(txt_FixedTotal.Text);

                        int count = 0;
                        if (fileTotalSize % fixedTotal == 0)
                        {
                            count = Convert.ToInt32(Math.Round(fileTotalSize / fixedTotal, 0));
                        }
                        else
                        {
                            count = Convert.ToInt32(Math.Floor(fileTotalSize / fixedTotal)) + 1;
                        }
                        txt_Size.Text = count.ToString();
                    }
                }
            }
            catch(Exception ex)
            {}
        }
        #endregion
    }
}
