namespace SplitMergeTool.NoteBookManage
{
    partial class NoteMergeForm
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
            this.components = new System.ComponentModel.Container();
            this.gb_Main = new System.Windows.Forms.GroupBox();
            this.gb_fileList = new System.Windows.Forms.GroupBox();
            this.lv_File = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btn_SelectSrc = new System.Windows.Forms.Button();
            this.lbl_FilePath = new System.Windows.Forms.Label();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.gb_Operating = new System.Windows.Forms.GroupBox();
            this.btn_Merge = new System.Windows.Forms.Button();
            this.btn_DownFile = new System.Windows.Forms.Button();
            this.btn_UpFile = new System.Windows.Forms.Button();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btn_RemoveFile = new System.Windows.Forms.Button();
            this.btn_AddFile = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gb_Main.SuspendLayout();
            this.gb_fileList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_Operating.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Main
            // 
            this.gb_Main.AutoSize = true;
            this.gb_Main.Controls.Add(this.gb_fileList);
            this.gb_Main.Controls.Add(this.panel1);
            this.gb_Main.Controls.Add(this.gb_Operating);
            this.gb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Main.Location = new System.Drawing.Point(0, 0);
            this.gb_Main.Margin = new System.Windows.Forms.Padding(5);
            this.gb_Main.Name = "gb_Main";
            this.gb_Main.Padding = new System.Windows.Forms.Padding(5);
            this.gb_Main.Size = new System.Drawing.Size(1045, 615);
            this.gb_Main.TabIndex = 27;
            this.gb_Main.TabStop = false;
            this.gb_Main.Text = "要合并的文件（可进行文件拖放）";
            // 
            // gb_fileList
            // 
            this.gb_fileList.Controls.Add(this.lv_File);
            this.gb_fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_fileList.Location = new System.Drawing.Point(5, 27);
            this.gb_fileList.Name = "gb_fileList";
            this.gb_fileList.Size = new System.Drawing.Size(895, 479);
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
            this.lv_File.Size = new System.Drawing.Size(889, 451);
            this.lv_File.TabIndex = 0;
            this.lv_File.UseCompatibleStateImageBehavior = false;
            this.lv_File.View = System.Windows.Forms.View.Details;
            this.lv_File.DragDrop += new System.Windows.Forms.DragEventHandler(this.lv_File_DragDrop);
            this.lv_File.DragEnter += new System.Windows.Forms.DragEventHandler(this.lv_File_DragEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_FileName);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Controls.Add(this.btn_SelectSrc);
            this.panel1.Controls.Add(this.lbl_FilePath);
            this.panel1.Controls.Add(this.txt_FilePath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 104);
            this.panel1.TabIndex = 2;
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(100, 17);
            this.lbl_FileName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(149, 19);
            this.lbl_FileName.TabIndex = 41;
            this.lbl_FileName.Text = "输出文件命名：";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(261, 14);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFileName.MaxLength = 20;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(444, 29);
            this.txtFileName.TabIndex = 40;
            this.txtFileName.Text = "MergeNoteBook";
            // 
            // btn_SelectSrc
            // 
            this.btn_SelectSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectSrc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectSrc.Location = new System.Drawing.Point(752, 58);
            this.btn_SelectSrc.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_SelectSrc.Name = "btn_SelectSrc";
            this.btn_SelectSrc.Size = new System.Drawing.Size(132, 35);
            this.btn_SelectSrc.TabIndex = 39;
            this.btn_SelectSrc.Text = "浏览...";
            this.btn_SelectSrc.UseVisualStyleBackColor = true;
            this.btn_SelectSrc.Click += new System.EventHandler(this.btn_SelectSrc_Click);
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FilePath.AutoSize = true;
            this.lbl_FilePath.Location = new System.Drawing.Point(100, 66);
            this.lbl_FilePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(149, 19);
            this.lbl_FilePath.TabIndex = 38;
            this.lbl_FilePath.Text = "文件输出路径：";
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FilePath.BackColor = System.Drawing.Color.White;
            this.txt_FilePath.Location = new System.Drawing.Point(261, 60);
            this.txt_FilePath.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.ReadOnly = true;
            this.txt_FilePath.Size = new System.Drawing.Size(444, 29);
            this.txt_FilePath.TabIndex = 37;
            this.txt_FilePath.Click += new System.EventHandler(this.btn_SelectSrc_Click);
            this.txt_FilePath.MouseHover += new System.EventHandler(this.txt_FilePath_MouseHover);
            // 
            // gb_Operating
            // 
            this.gb_Operating.Controls.Add(this.btn_Merge);
            this.gb_Operating.Controls.Add(this.btn_DownFile);
            this.gb_Operating.Controls.Add(this.btn_UpFile);
            this.gb_Operating.Controls.Add(this.btn_Clean);
            this.gb_Operating.Controls.Add(this.btn_RemoveFile);
            this.gb_Operating.Controls.Add(this.btn_AddFile);
            this.gb_Operating.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb_Operating.Location = new System.Drawing.Point(900, 27);
            this.gb_Operating.Margin = new System.Windows.Forms.Padding(5);
            this.gb_Operating.Name = "gb_Operating";
            this.gb_Operating.Padding = new System.Windows.Forms.Padding(5);
            this.gb_Operating.Size = new System.Drawing.Size(140, 583);
            this.gb_Operating.TabIndex = 1;
            this.gb_Operating.TabStop = false;
            this.gb_Operating.Text = "操作";
            // 
            // btn_Merge
            // 
            this.btn_Merge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Merge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Merge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Merge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Merge.Location = new System.Drawing.Point(10, 479);
            this.btn_Merge.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Merge.Name = "btn_Merge";
            this.btn_Merge.Size = new System.Drawing.Size(118, 72);
            this.btn_Merge.TabIndex = 17;
            this.btn_Merge.Text = "开始合并";
            this.btn_Merge.UseVisualStyleBackColor = true;
            this.btn_Merge.Click += new System.EventHandler(this.btn_Merge_Click);
            // 
            // btn_DownFile
            // 
            this.btn_DownFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DownFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DownFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DownFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DownFile.Location = new System.Drawing.Point(10, 391);
            this.btn_DownFile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_DownFile.Name = "btn_DownFile";
            this.btn_DownFile.Size = new System.Drawing.Size(118, 52);
            this.btn_DownFile.TabIndex = 16;
            this.btn_DownFile.Text = "下移";
            this.btn_DownFile.UseVisualStyleBackColor = true;
            this.btn_DownFile.Click += new System.EventHandler(this.btn_DownFile_Click);
            // 
            // btn_UpFile
            // 
            this.btn_UpFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_UpFile.Location = new System.Drawing.Point(10, 304);
            this.btn_UpFile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_UpFile.Name = "btn_UpFile";
            this.btn_UpFile.Size = new System.Drawing.Size(118, 52);
            this.btn_UpFile.TabIndex = 15;
            this.btn_UpFile.Text = "上移";
            this.btn_UpFile.UseVisualStyleBackColor = true;
            this.btn_UpFile.Click += new System.EventHandler(this.btn_UpFile_Click);
            // 
            // btn_Clean
            // 
            this.btn_Clean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clean.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clean.Location = new System.Drawing.Point(10, 217);
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
            this.btn_RemoveFile.Location = new System.Drawing.Point(10, 129);
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
            this.btn_AddFile.Location = new System.Drawing.Point(10, 41);
            this.btn_AddFile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AddFile.Name = "btn_AddFile";
            this.btn_AddFile.Size = new System.Drawing.Size(118, 52);
            this.btn_AddFile.TabIndex = 12;
            this.btn_AddFile.Text = "添加";
            this.btn_AddFile.UseVisualStyleBackColor = true;
            this.btn_AddFile.Click += new System.EventHandler(this.btn_AddFile_Click);
            // 
            // NoteMergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 615);
            this.Controls.Add(this.gb_Main);
            this.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteMergeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note Book Merge Tool";
            this.Load += new System.EventHandler(this.NoteMergeForm_Load);
            this.gb_Main.ResumeLayout(false);
            this.gb_fileList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Operating.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Main;
        private System.Windows.Forms.GroupBox gb_Operating;
        private System.Windows.Forms.Button btn_DownFile;
        private System.Windows.Forms.Button btn_UpFile;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btn_RemoveFile;
        private System.Windows.Forms.Button btn_AddFile;
        private System.Windows.Forms.GroupBox gb_fileList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SelectSrc;
        private System.Windows.Forms.Label lbl_FilePath;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.ListView lv_File;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btn_Merge;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.TextBox txtFileName;
    }
}