namespace SplitMergeTool.NoteBookManage
{
    partial class NoteSplitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteSplitForm));
            this.gb_BaseInfo = new System.Windows.Forms.GroupBox();
            this.lbl_FileSize = new System.Windows.Forms.Label();
            this.txt_FileSize = new System.Windows.Forms.TextBox();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.btn_SelectSrc = new System.Windows.Forms.Button();
            this.lbl_FilePath = new System.Windows.Forms.Label();
            this.txt_Src = new System.Windows.Forms.TextBox();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.lbl_File = new System.Windows.Forms.Label();
            this.txt_SelectFile = new System.Windows.Forms.TextBox();
            this.gb_SplitType = new System.Windows.Forms.GroupBox();
            this.btn_Split = new System.Windows.Forms.Button();
            this.txt_CustomContent = new System.Windows.Forms.TextBox();
            this.cb_CustomContent = new System.Windows.Forms.CheckBox();
            this.lbl_FixedSizeUnit = new System.Windows.Forms.Label();
            this.lbl_TotalSizeUnit = new System.Windows.Forms.Label();
            this.txt_FixedSize = new System.Windows.Forms.TextBox();
            this.rbtn_Size = new System.Windows.Forms.RadioButton();
            this.lbl_FileLength = new System.Windows.Forms.Label();
            this.rbtn_Total = new System.Windows.Forms.RadioButton();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_FixedTotal = new System.Windows.Forms.TextBox();
            this.lbl_FileCount = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.gb_BaseInfo.SuspendLayout();
            this.gb_SplitType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_BaseInfo
            // 
            this.gb_BaseInfo.AutoSize = true;
            this.gb_BaseInfo.Controls.Add(this.lbl_Unit);
            this.gb_BaseInfo.Controls.Add(this.lbl_FileSize);
            this.gb_BaseInfo.Controls.Add(this.txt_FileSize);
            this.gb_BaseInfo.Controls.Add(this.lbl_Number);
            this.gb_BaseInfo.Controls.Add(this.lbl_FileName);
            this.gb_BaseInfo.Controls.Add(this.txt_FileName);
            this.gb_BaseInfo.Controls.Add(this.btn_SelectSrc);
            this.gb_BaseInfo.Controls.Add(this.lbl_FilePath);
            this.gb_BaseInfo.Controls.Add(this.txt_Src);
            this.gb_BaseInfo.Controls.Add(this.btn_SelectFile);
            this.gb_BaseInfo.Controls.Add(this.lbl_File);
            this.gb_BaseInfo.Controls.Add(this.txt_SelectFile);
            this.gb_BaseInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_BaseInfo.Location = new System.Drawing.Point(0, 0);
            this.gb_BaseInfo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.gb_BaseInfo.Name = "gb_BaseInfo";
            this.gb_BaseInfo.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.gb_BaseInfo.Size = new System.Drawing.Size(1045, 263);
            this.gb_BaseInfo.TabIndex = 23;
            this.gb_BaseInfo.TabStop = false;
            this.gb_BaseInfo.Text = "基本信息";
            // 
            // lbl_FileSize
            // 
            this.lbl_FileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FileSize.AutoSize = true;
            this.lbl_FileSize.Location = new System.Drawing.Point(33, 221);
            this.lbl_FileSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FileSize.Name = "lbl_FileSize";
            this.lbl_FileSize.Size = new System.Drawing.Size(149, 19);
            this.lbl_FileSize.TabIndex = 22;
            this.lbl_FileSize.Text = "拆分文件大小：";
            // 
            // txt_FileSize
            // 
            this.txt_FileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FileSize.BackColor = System.Drawing.Color.White;
            this.txt_FileSize.Location = new System.Drawing.Point(194, 218);
            this.txt_FileSize.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_FileSize.Name = "txt_FileSize";
            this.txt_FileSize.ReadOnly = true;
            this.txt_FileSize.Size = new System.Drawing.Size(632, 29);
            this.txt_FileSize.TabIndex = 21;
            // 
            // lbl_Number
            // 
            this.lbl_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(863, 161);
            this.lbl_Number.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(69, 19);
            this.lbl_Number.TabIndex = 20;
            this.lbl_Number.Text = "+ 序号";
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(33, 162);
            this.lbl_FileName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(149, 19);
            this.lbl_FileName.TabIndex = 19;
            this.lbl_FileName.Text = "保存文件命名：";
            // 
            // txt_FileName
            // 
            this.txt_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FileName.Location = new System.Drawing.Point(194, 159);
            this.txt_FileName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_FileName.MaxLength = 20;
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(632, 29);
            this.txt_FileName.TabIndex = 18;
            this.txt_FileName.Text = "split_";
            // 
            // btn_SelectSrc
            // 
            this.btn_SelectSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectSrc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectSrc.Location = new System.Drawing.Point(854, 97);
            this.btn_SelectSrc.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_SelectSrc.Name = "btn_SelectSrc";
            this.btn_SelectSrc.Size = new System.Drawing.Size(132, 35);
            this.btn_SelectSrc.TabIndex = 17;
            this.btn_SelectSrc.Text = "浏览...";
            this.btn_SelectSrc.UseVisualStyleBackColor = true;
            this.btn_SelectSrc.Click += new System.EventHandler(this.btnSelectSrc_Click);
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FilePath.AutoSize = true;
            this.lbl_FilePath.Location = new System.Drawing.Point(33, 102);
            this.lbl_FilePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(149, 19);
            this.lbl_FilePath.TabIndex = 16;
            this.lbl_FilePath.Text = "文件保存路径：";
            // 
            // txt_Src
            // 
            this.txt_Src.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Src.BackColor = System.Drawing.Color.White;
            this.txt_Src.Location = new System.Drawing.Point(194, 102);
            this.txt_Src.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_Src.Name = "txt_Src";
            this.txt_Src.ReadOnly = true;
            this.txt_Src.Size = new System.Drawing.Size(632, 29);
            this.txt_Src.TabIndex = 15;
            this.txt_Src.Click += new System.EventHandler(this.btnSelectSrc_Click);
            this.txt_Src.MouseHover += new System.EventHandler(this.txtSrc_MouseHover);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectFile.Location = new System.Drawing.Point(854, 37);
            this.btn_SelectFile.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(132, 35);
            this.btn_SelectFile.TabIndex = 14;
            this.btn_SelectFile.Text = "浏览...";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lbl_File
            // 
            this.lbl_File.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_File.AutoSize = true;
            this.lbl_File.Location = new System.Drawing.Point(33, 45);
            this.lbl_File.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_File.Name = "lbl_File";
            this.lbl_File.Size = new System.Drawing.Size(149, 19);
            this.lbl_File.TabIndex = 13;
            this.lbl_File.Text = "选择拆分文件：";
            // 
            // txt_SelectFile
            // 
            this.txt_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SelectFile.BackColor = System.Drawing.Color.White;
            this.txt_SelectFile.Location = new System.Drawing.Point(194, 42);
            this.txt_SelectFile.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_SelectFile.Name = "txt_SelectFile";
            this.txt_SelectFile.ReadOnly = true;
            this.txt_SelectFile.Size = new System.Drawing.Size(632, 29);
            this.txt_SelectFile.TabIndex = 12;
            this.txt_SelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            this.txt_SelectFile.MouseHover += new System.EventHandler(this.txtSelectFile_MouseHover);
            // 
            // gb_SplitType
            // 
            this.gb_SplitType.AutoSize = true;
            this.gb_SplitType.Controls.Add(this.btn_Split);
            this.gb_SplitType.Controls.Add(this.txt_CustomContent);
            this.gb_SplitType.Controls.Add(this.cb_CustomContent);
            this.gb_SplitType.Controls.Add(this.lbl_FixedSizeUnit);
            this.gb_SplitType.Controls.Add(this.lbl_TotalSizeUnit);
            this.gb_SplitType.Controls.Add(this.txt_FixedSize);
            this.gb_SplitType.Controls.Add(this.rbtn_Size);
            this.gb_SplitType.Controls.Add(this.lbl_FileLength);
            this.gb_SplitType.Controls.Add(this.rbtn_Total);
            this.gb_SplitType.Controls.Add(this.txt_Size);
            this.gb_SplitType.Controls.Add(this.txt_Total);
            this.gb_SplitType.Controls.Add(this.txt_FixedTotal);
            this.gb_SplitType.Controls.Add(this.lbl_FileCount);
            this.gb_SplitType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_SplitType.Location = new System.Drawing.Point(0, 263);
            this.gb_SplitType.Margin = new System.Windows.Forms.Padding(4);
            this.gb_SplitType.Name = "gb_SplitType";
            this.gb_SplitType.Padding = new System.Windows.Forms.Padding(4);
            this.gb_SplitType.Size = new System.Drawing.Size(1045, 364);
            this.gb_SplitType.TabIndex = 25;
            this.gb_SplitType.TabStop = false;
            this.gb_SplitType.Text = "拆分方式";
            // 
            // btn_Split
            // 
            this.btn_Split.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Split.BackColor = System.Drawing.Color.White;
            this.btn_Split.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Split.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Split.Location = new System.Drawing.Point(377, 295);
            this.btn_Split.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Split.Name = "btn_Split";
            this.btn_Split.Size = new System.Drawing.Size(325, 46);
            this.btn_Split.TabIndex = 35;
            this.btn_Split.Text = "开始拆分";
            this.btn_Split.UseVisualStyleBackColor = false;
            this.btn_Split.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // txt_CustomContent
            // 
            this.txt_CustomContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CustomContent.BackColor = System.Drawing.Color.White;
            this.txt_CustomContent.Location = new System.Drawing.Point(15, 213);
            this.txt_CustomContent.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_CustomContent.MaxLength = 50;
            this.txt_CustomContent.Multiline = true;
            this.txt_CustomContent.Name = "txt_CustomContent";
            this.txt_CustomContent.ReadOnly = true;
            this.txt_CustomContent.Size = new System.Drawing.Size(1015, 65);
            this.txt_CustomContent.TabIndex = 34;
            // 
            // cb_CustomContent
            // 
            this.cb_CustomContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_CustomContent.AutoSize = true;
            this.cb_CustomContent.Location = new System.Drawing.Point(15, 180);
            this.cb_CustomContent.Name = "cb_CustomContent";
            this.cb_CustomContent.Size = new System.Drawing.Size(808, 23);
            this.cb_CustomContent.TabIndex = 33;
            this.cb_CustomContent.Text = "拆分文件内容首行添加自定义内容（仅限50个字符，若勾选此项，则所填内容不能为空）";
            this.cb_CustomContent.UseVisualStyleBackColor = true;
            this.cb_CustomContent.CheckedChanged += new System.EventHandler(this.cbCustomContent_CheckedChanged);
            // 
            // lbl_FixedSizeUnit
            // 
            this.lbl_FixedSizeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FixedSizeUnit.AutoSize = true;
            this.lbl_FixedSizeUnit.Location = new System.Drawing.Point(506, 54);
            this.lbl_FixedSizeUnit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FixedSizeUnit.Name = "lbl_FixedSizeUnit";
            this.lbl_FixedSizeUnit.Size = new System.Drawing.Size(49, 19);
            this.lbl_FixedSizeUnit.TabIndex = 31;
            this.lbl_FixedSizeUnit.Text = "Byte";
            // 
            // lbl_TotalSizeUnit
            // 
            this.lbl_TotalSizeUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalSizeUnit.AutoSize = true;
            this.lbl_TotalSizeUnit.Location = new System.Drawing.Point(986, 125);
            this.lbl_TotalSizeUnit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_TotalSizeUnit.Name = "lbl_TotalSizeUnit";
            this.lbl_TotalSizeUnit.Size = new System.Drawing.Size(49, 19);
            this.lbl_TotalSizeUnit.TabIndex = 30;
            this.lbl_TotalSizeUnit.Text = "Byte";
            // 
            // txt_FixedSize
            // 
            this.txt_FixedSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_FixedSize.BackColor = System.Drawing.Color.White;
            this.txt_FixedSize.Location = new System.Drawing.Point(222, 50);
            this.txt_FixedSize.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_FixedSize.MaxLength = 15;
            this.txt_FixedSize.Name = "txt_FixedSize";
            this.txt_FixedSize.Size = new System.Drawing.Size(246, 29);
            this.txt_FixedSize.TabIndex = 23;
            this.txt_FixedSize.Text = "1";
            this.txt_FixedSize.TextChanged += new System.EventHandler(this.txtFixedSize_TextChanged);
            // 
            // rbtn_Size
            // 
            this.rbtn_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_Size.AutoSize = true;
            this.rbtn_Size.Checked = true;
            this.rbtn_Size.Location = new System.Drawing.Point(15, 51);
            this.rbtn_Size.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rbtn_Size.Name = "rbtn_Size";
            this.rbtn_Size.Size = new System.Drawing.Size(167, 23);
            this.rbtn_Size.TabIndex = 21;
            this.rbtn_Size.TabStop = true;
            this.rbtn_Size.Text = "文件固定大小：";
            this.rbtn_Size.UseVisualStyleBackColor = true;
            this.rbtn_Size.CheckedChanged += new System.EventHandler(this.rbtnSize_CheckedChanged);
            // 
            // lbl_FileLength
            // 
            this.lbl_FileLength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FileLength.AutoSize = true;
            this.lbl_FileLength.Location = new System.Drawing.Point(632, 125);
            this.lbl_FileLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FileLength.Name = "lbl_FileLength";
            this.lbl_FileLength.Size = new System.Drawing.Size(109, 19);
            this.lbl_FileLength.TabIndex = 28;
            this.lbl_FileLength.Text = "每份大小：";
            // 
            // rbtn_Total
            // 
            this.rbtn_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_Total.AutoSize = true;
            this.rbtn_Total.Location = new System.Drawing.Point(15, 120);
            this.rbtn_Total.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rbtn_Total.Name = "rbtn_Total";
            this.rbtn_Total.Size = new System.Drawing.Size(167, 23);
            this.rbtn_Total.TabIndex = 22;
            this.rbtn_Total.Text = "文件固定份数：";
            this.rbtn_Total.UseVisualStyleBackColor = true;
            this.rbtn_Total.CheckedChanged += new System.EventHandler(this.rbtnTotal_CheckedChanged);
            // 
            // txt_Size
            // 
            this.txt_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Size.BackColor = System.Drawing.Color.White;
            this.txt_Size.Enabled = false;
            this.txt_Size.Location = new System.Drawing.Point(808, 120);
            this.txt_Size.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(166, 29);
            this.txt_Size.TabIndex = 27;
            this.txt_Size.Text = "1";
            // 
            // txt_Total
            // 
            this.txt_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total.BackColor = System.Drawing.Color.White;
            this.txt_Total.Enabled = false;
            this.txt_Total.Location = new System.Drawing.Point(808, 50);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(166, 29);
            this.txt_Total.TabIndex = 24;
            this.txt_Total.Text = "1";
            // 
            // txt_FixedTotal
            // 
            this.txt_FixedTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_FixedTotal.BackColor = System.Drawing.Color.White;
            this.txt_FixedTotal.Enabled = false;
            this.txt_FixedTotal.Location = new System.Drawing.Point(222, 122);
            this.txt_FixedTotal.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_FixedTotal.MaxLength = 15;
            this.txt_FixedTotal.Name = "txt_FixedTotal";
            this.txt_FixedTotal.Size = new System.Drawing.Size(246, 29);
            this.txt_FixedTotal.TabIndex = 26;
            this.txt_FixedTotal.Text = "1";
            this.txt_FixedTotal.TextChanged += new System.EventHandler(this.txtFixedTotal_TextChanged);
            // 
            // lbl_FileCount
            // 
            this.lbl_FileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FileCount.AutoSize = true;
            this.lbl_FileCount.Location = new System.Drawing.Point(632, 54);
            this.lbl_FileCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FileCount.Name = "lbl_FileCount";
            this.lbl_FileCount.Size = new System.Drawing.Size(109, 19);
            this.lbl_FileCount.TabIndex = 25;
            this.lbl_FileCount.Text = "文件份数：";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Location = new System.Drawing.Point(863, 221);
            this.lbl_Unit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(49, 19);
            this.lbl_Unit.TabIndex = 32;
            this.lbl_Unit.Text = "Byte";
            // 
            // NoteSplitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 627);
            this.Controls.Add(this.gb_SplitType);
            this.Controls.Add(this.gb_BaseInfo);
            this.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteSplitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note Book Split Tool";
            this.Load += new System.EventHandler(this.TextSplitterForm_Load);
            this.gb_BaseInfo.ResumeLayout(false);
            this.gb_BaseInfo.PerformLayout();
            this.gb_SplitType.ResumeLayout(false);
            this.gb_SplitType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_BaseInfo;
        private System.Windows.Forms.Label lbl_FileSize;
        private System.Windows.Forms.TextBox txt_FileSize;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.Button btn_SelectSrc;
        private System.Windows.Forms.Label lbl_FilePath;
        private System.Windows.Forms.TextBox txt_Src;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.Label lbl_File;
        private System.Windows.Forms.TextBox txt_SelectFile;
        private System.Windows.Forms.GroupBox gb_SplitType;
        private System.Windows.Forms.TextBox txt_FixedSize;
        private System.Windows.Forms.RadioButton rbtn_Size;
        private System.Windows.Forms.Label lbl_FileLength;
        private System.Windows.Forms.RadioButton rbtn_Total;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_FixedTotal;
        private System.Windows.Forms.Label lbl_FileCount;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lbl_TotalSizeUnit;
        private System.Windows.Forms.Label lbl_FixedSizeUnit;
        private System.Windows.Forms.TextBox txt_CustomContent;
        private System.Windows.Forms.CheckBox cb_CustomContent;
        private System.Windows.Forms.Button btn_Split;
        private System.Windows.Forms.Label lbl_Unit;
    }
}