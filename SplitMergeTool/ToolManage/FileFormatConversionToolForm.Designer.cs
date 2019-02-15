namespace SplitMergeTool.ToolManage
{
    partial class FileFormatConversionToolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Main = new System.Windows.Forms.GroupBox();
            this.gb_fileList = new System.Windows.Forms.GroupBox();
            this.lv_File = new System.Windows.Forms.ListView();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.cbBox_ConvertType = new System.Windows.Forms.ComboBox();
            this.lbl_ConvertType = new System.Windows.Forms.Label();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.btn_SaveSrc = new System.Windows.Forms.Button();
            this.lbl_FilePath = new System.Windows.Forms.Label();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.gb_Operating = new System.Windows.Forms.GroupBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btn_RemoveFile = new System.Windows.Forms.Button();
            this.btn_AddFile = new System.Windows.Forms.Button();
            this.gb_Main.SuspendLayout();
            this.gb_fileList.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.gb_Operating.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Main
            // 
            this.gb_Main.AutoSize = true;
            this.gb_Main.Controls.Add(this.gb_fileList);
            this.gb_Main.Controls.Add(this.pnl_Main);
            this.gb_Main.Controls.Add(this.gb_Operating);
            this.gb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Main.Location = new System.Drawing.Point(0, 0);
            this.gb_Main.Margin = new System.Windows.Forms.Padding(5);
            this.gb_Main.Name = "gb_Main";
            this.gb_Main.Padding = new System.Windows.Forms.Padding(5);
            this.gb_Main.Size = new System.Drawing.Size(1109, 589);
            this.gb_Main.TabIndex = 30;
            this.gb_Main.TabStop = false;
            this.gb_Main.Text = "要转换的文件（可进行文件拖放）";
            // 
            // gb_fileList
            // 
            this.gb_fileList.Controls.Add(this.lv_File);
            this.gb_fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_fileList.Location = new System.Drawing.Point(5, 27);
            this.gb_fileList.Name = "gb_fileList";
            this.gb_fileList.Size = new System.Drawing.Size(959, 405);
            this.gb_fileList.TabIndex = 3;
            this.gb_fileList.TabStop = false;
            this.gb_fileList.Text = "文件列表";
            // 
            // lv_File
            // 
            this.lv_File.AllowDrop = true;
            this.lv_File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lv_File.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_File.FullRowSelect = true;
            this.lv_File.Location = new System.Drawing.Point(3, 25);
            this.lv_File.Name = "lv_File";
            this.lv_File.Size = new System.Drawing.Size(953, 377);
            this.lv_File.TabIndex = 0;
            this.lv_File.UseCompatibleStateImageBehavior = false;
            this.lv_File.View = System.Windows.Forms.View.Details;
            this.lv_File.DragDrop += new System.Windows.Forms.DragEventHandler(this.lv_File_DragDrop);
            this.lv_File.DragEnter += new System.Windows.Forms.DragEventHandler(this.lv_File_DragEnter);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.lbl_Number);
            this.pnl_Main.Controls.Add(this.cbBox_ConvertType);
            this.pnl_Main.Controls.Add(this.lbl_ConvertType);
            this.pnl_Main.Controls.Add(this.lbl_FileName);
            this.pnl_Main.Controls.Add(this.txt_FileName);
            this.pnl_Main.Controls.Add(this.btn_SaveSrc);
            this.pnl_Main.Controls.Add(this.lbl_FilePath);
            this.pnl_Main.Controls.Add(this.txt_FilePath);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Main.Location = new System.Drawing.Point(5, 432);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(959, 152);
            this.pnl_Main.TabIndex = 2;
            // 
            // lbl_Number
            // 
            this.lbl_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(830, 70);
            this.lbl_Number.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(69, 19);
            this.lbl_Number.TabIndex = 44;
            this.lbl_Number.Text = "+ 序号";
            // 
            // cbBox_ConvertType
            // 
            this.cbBox_ConvertType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBox_ConvertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_ConvertType.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBox_ConvertType.FormattingEnabled = true;
            this.cbBox_ConvertType.Location = new System.Drawing.Point(220, 24);
            this.cbBox_ConvertType.Name = "cbBox_ConvertType";
            this.cbBox_ConvertType.Size = new System.Drawing.Size(589, 28);
            this.cbBox_ConvertType.TabIndex = 43;
            // 
            // lbl_ConvertType
            // 
            this.lbl_ConvertType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ConvertType.Location = new System.Drawing.Point(10, 28);
            this.lbl_ConvertType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ConvertType.Name = "lbl_ConvertType";
            this.lbl_ConvertType.Size = new System.Drawing.Size(183, 19);
            this.lbl_ConvertType.TabIndex = 42;
            this.lbl_ConvertType.Text = "转换类型：";
            this.lbl_ConvertType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FileName.Location = new System.Drawing.Point(10, 70);
            this.lbl_FileName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(183, 19);
            this.lbl_FileName.TabIndex = 41;
            this.lbl_FileName.Text = "文件名称：";
            this.lbl_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_FileName
            // 
            this.txt_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FileName.Location = new System.Drawing.Point(220, 67);
            this.txt_FileName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_FileName.MaxLength = 20;
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(589, 29);
            this.txt_FileName.TabIndex = 40;
            this.txt_FileName.Text = "ConversionFile_";
            // 
            // btn_SaveSrc
            // 
            this.btn_SaveSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveSrc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveSrc.Location = new System.Drawing.Point(834, 104);
            this.btn_SaveSrc.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_SaveSrc.Name = "btn_SaveSrc";
            this.btn_SaveSrc.Size = new System.Drawing.Size(114, 35);
            this.btn_SaveSrc.TabIndex = 39;
            this.btn_SaveSrc.Text = "浏览...";
            this.btn_SaveSrc.UseVisualStyleBackColor = true;
            this.btn_SaveSrc.Click += new System.EventHandler(this.btn_SaveSrc_Click);
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FilePath.Location = new System.Drawing.Point(10, 113);
            this.lbl_FilePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(183, 19);
            this.lbl_FilePath.TabIndex = 38;
            this.lbl_FilePath.Text = "保存路径：";
            this.lbl_FilePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FilePath.BackColor = System.Drawing.Color.White;
            this.txt_FilePath.Location = new System.Drawing.Point(220, 110);
            this.txt_FilePath.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.ReadOnly = true;
            this.txt_FilePath.Size = new System.Drawing.Size(589, 29);
            this.txt_FilePath.TabIndex = 37;
            // 
            // gb_Operating
            // 
            this.gb_Operating.Controls.Add(this.btn_Convert);
            this.gb_Operating.Controls.Add(this.btn_Clean);
            this.gb_Operating.Controls.Add(this.btn_RemoveFile);
            this.gb_Operating.Controls.Add(this.btn_AddFile);
            this.gb_Operating.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb_Operating.Location = new System.Drawing.Point(964, 27);
            this.gb_Operating.Margin = new System.Windows.Forms.Padding(5);
            this.gb_Operating.Name = "gb_Operating";
            this.gb_Operating.Padding = new System.Windows.Forms.Padding(5);
            this.gb_Operating.Size = new System.Drawing.Size(140, 557);
            this.gb_Operating.TabIndex = 1;
            this.gb_Operating.TabStop = false;
            this.gb_Operating.Text = "操作";
            // 
            // btn_Convert
            // 
            this.btn_Convert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Convert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Convert.Location = new System.Drawing.Point(10, 405);
            this.btn_Convert.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(118, 109);
            this.btn_Convert.TabIndex = 17;
            this.btn_Convert.Text = "转换";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Clean
            // 
            this.btn_Clean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clean.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clean.Location = new System.Drawing.Point(10, 301);
            this.btn_Clean.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(118, 52);
            this.btn_Clean.TabIndex = 14;
            this.btn_Clean.Text = "清空";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_RemoveFile
            // 
            this.btn_RemoveFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RemoveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_RemoveFile.Location = new System.Drawing.Point(10, 179);
            this.btn_RemoveFile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_RemoveFile.Name = "btn_RemoveFile";
            this.btn_RemoveFile.Size = new System.Drawing.Size(118, 54);
            this.btn_RemoveFile.TabIndex = 13;
            this.btn_RemoveFile.Text = "移除";
            this.btn_RemoveFile.UseVisualStyleBackColor = true;
            this.btn_RemoveFile.Click += new System.EventHandler(this.btn_RemoveFile_Click);
            // 
            // btn_AddFile
            // 
            this.btn_AddFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_AddFile.Location = new System.Drawing.Point(10, 59);
            this.btn_AddFile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AddFile.Name = "btn_AddFile";
            this.btn_AddFile.Size = new System.Drawing.Size(118, 52);
            this.btn_AddFile.TabIndex = 12;
            this.btn_AddFile.Text = "添加";
            this.btn_AddFile.UseVisualStyleBackColor = true;
            this.btn_AddFile.Click += new System.EventHandler(this.btn_AddFile_Click);
            // 
            // FileFormatConversionToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 589);
            this.Controls.Add(this.gb_Main);
            this.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileFormatConversionToolForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Format Conversion Tool";
            this.Load += new System.EventHandler(this.FileFormatConversionToolForm_Load);
            this.gb_Main.ResumeLayout(false);
            this.gb_fileList.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.gb_Operating.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Main;
        private System.Windows.Forms.GroupBox gb_fileList;
        private System.Windows.Forms.ListView lv_File;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.ComboBox cbBox_ConvertType;
        private System.Windows.Forms.Label lbl_ConvertType;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.Button btn_SaveSrc;
        private System.Windows.Forms.Label lbl_FilePath;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.GroupBox gb_Operating;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btn_RemoveFile;
        private System.Windows.Forms.Button btn_AddFile;
        private System.Windows.Forms.Label lbl_Number;
    }
}