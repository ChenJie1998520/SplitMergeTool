namespace SplitMergeTool.DocumentManage
{
    partial class DocSplitForm
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Split = new System.Windows.Forms.Button();
            this.rbtn_PageBreak = new System.Windows.Forms.RadioButton();
            this.rbtn_SectionBreak = new System.Windows.Forms.RadioButton();
            this.gb_SplitType = new System.Windows.Forms.GroupBox();
            this.lbl_FontSize = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.txt_FontSize = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.lbl_Layout = new System.Windows.Forms.Label();
            this.cbBox_Layout = new System.Windows.Forms.ComboBox();
            this.btn_FontSize = new System.Windows.Forms.Button();
            this.btn_Color = new System.Windows.Forms.Button();
            this.txt_WaterMark = new System.Windows.Forms.TextBox();
            this.cb_WaterMark = new System.Windows.Forms.CheckBox();
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
            this.gb_BaseInfo = new System.Windows.Forms.GroupBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.gb_SplitType.SuspendLayout();
            this.gb_BaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Split
            // 
            this.btn_Split.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Split.BackColor = System.Drawing.Color.White;
            this.btn_Split.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Split.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Split.Location = new System.Drawing.Point(791, 194);
            this.btn_Split.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Split.Name = "btn_Split";
            this.btn_Split.Size = new System.Drawing.Size(149, 129);
            this.btn_Split.TabIndex = 35;
            this.btn_Split.Text = "开始拆分";
            this.btn_Split.UseVisualStyleBackColor = false;
            this.btn_Split.Click += new System.EventHandler(this.btn_Split_Click);
            // 
            // rbtn_PageBreak
            // 
            this.rbtn_PageBreak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_PageBreak.AutoSize = true;
            this.rbtn_PageBreak.Checked = true;
            this.rbtn_PageBreak.Location = new System.Drawing.Point(109, 33);
            this.rbtn_PageBreak.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rbtn_PageBreak.Name = "rbtn_PageBreak";
            this.rbtn_PageBreak.Size = new System.Drawing.Size(207, 23);
            this.rbtn_PageBreak.TabIndex = 21;
            this.rbtn_PageBreak.TabStop = true;
            this.rbtn_PageBreak.Text = "根据分页符进行拆分";
            this.rbtn_PageBreak.UseVisualStyleBackColor = true;
            // 
            // rbtn_SectionBreak
            // 
            this.rbtn_SectionBreak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_SectionBreak.AutoSize = true;
            this.rbtn_SectionBreak.Location = new System.Drawing.Point(593, 33);
            this.rbtn_SectionBreak.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rbtn_SectionBreak.Name = "rbtn_SectionBreak";
            this.rbtn_SectionBreak.Size = new System.Drawing.Size(207, 23);
            this.rbtn_SectionBreak.TabIndex = 22;
            this.rbtn_SectionBreak.Text = "根据分节符进行拆分";
            this.rbtn_SectionBreak.UseVisualStyleBackColor = true;
            // 
            // gb_SplitType
            // 
            this.gb_SplitType.AutoSize = true;
            this.gb_SplitType.Controls.Add(this.lbl_FontSize);
            this.gb_SplitType.Controls.Add(this.lbl_Color);
            this.gb_SplitType.Controls.Add(this.txt_FontSize);
            this.gb_SplitType.Controls.Add(this.txt_Color);
            this.gb_SplitType.Controls.Add(this.lbl_Layout);
            this.gb_SplitType.Controls.Add(this.cbBox_Layout);
            this.gb_SplitType.Controls.Add(this.btn_FontSize);
            this.gb_SplitType.Controls.Add(this.btn_Color);
            this.gb_SplitType.Controls.Add(this.txt_WaterMark);
            this.gb_SplitType.Controls.Add(this.cb_WaterMark);
            this.gb_SplitType.Controls.Add(this.btn_Split);
            this.gb_SplitType.Controls.Add(this.rbtn_PageBreak);
            this.gb_SplitType.Controls.Add(this.rbtn_SectionBreak);
            this.gb_SplitType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_SplitType.Location = new System.Drawing.Point(0, 266);
            this.gb_SplitType.Margin = new System.Windows.Forms.Padding(4);
            this.gb_SplitType.Name = "gb_SplitType";
            this.gb_SplitType.Padding = new System.Windows.Forms.Padding(4);
            this.gb_SplitType.Size = new System.Drawing.Size(967, 358);
            this.gb_SplitType.TabIndex = 27;
            this.gb_SplitType.TabStop = false;
            this.gb_SplitType.Text = "拆分方式";
            // 
            // lbl_FontSize
            // 
            this.lbl_FontSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FontSize.AutoSize = true;
            this.lbl_FontSize.Location = new System.Drawing.Point(41, 279);
            this.lbl_FontSize.Name = "lbl_FontSize";
            this.lbl_FontSize.Size = new System.Drawing.Size(109, 19);
            this.lbl_FontSize.TabIndex = 49;
            this.lbl_FontSize.Text = "字体大小：";
            // 
            // lbl_Color
            // 
            this.lbl_Color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(41, 226);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(109, 19);
            this.lbl_Color.TabIndex = 48;
            this.lbl_Color.Text = "水印颜色：";
            // 
            // txt_FontSize
            // 
            this.txt_FontSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_FontSize.Enabled = false;
            this.txt_FontSize.Location = new System.Drawing.Point(228, 276);
            this.txt_FontSize.Name = "txt_FontSize";
            this.txt_FontSize.Size = new System.Drawing.Size(180, 29);
            this.txt_FontSize.TabIndex = 47;
            this.txt_FontSize.Text = "14";
            // 
            // txt_Color
            // 
            this.txt_Color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Color.Enabled = false;
            this.txt_Color.Location = new System.Drawing.Point(228, 223);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(180, 29);
            this.txt_Color.TabIndex = 46;
            this.txt_Color.Text = "Black";
            // 
            // lbl_Layout
            // 
            this.lbl_Layout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Layout.AutoSize = true;
            this.lbl_Layout.Location = new System.Drawing.Point(41, 173);
            this.lbl_Layout.Name = "lbl_Layout";
            this.lbl_Layout.Size = new System.Drawing.Size(109, 19);
            this.lbl_Layout.TabIndex = 45;
            this.lbl_Layout.Text = "排列方式：";
            // 
            // cbBox_Layout
            // 
            this.cbBox_Layout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBox_Layout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Layout.FormattingEnabled = true;
            this.cbBox_Layout.Location = new System.Drawing.Point(228, 170);
            this.cbBox_Layout.Name = "cbBox_Layout";
            this.cbBox_Layout.Size = new System.Drawing.Size(180, 27);
            this.cbBox_Layout.TabIndex = 44;
            // 
            // btn_FontSize
            // 
            this.btn_FontSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_FontSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FontSize.Enabled = false;
            this.btn_FontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FontSize.Location = new System.Drawing.Point(464, 276);
            this.btn_FontSize.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_FontSize.Name = "btn_FontSize";
            this.btn_FontSize.Size = new System.Drawing.Size(163, 35);
            this.btn_FontSize.TabIndex = 43;
            this.btn_FontSize.Text = "字体";
            this.btn_FontSize.UseVisualStyleBackColor = true;
            this.btn_FontSize.Click += new System.EventHandler(this.btn_FontSize_Click);
            // 
            // btn_Color
            // 
            this.btn_Color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Color.Enabled = false;
            this.btn_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Color.Location = new System.Drawing.Point(464, 223);
            this.btn_Color.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(163, 33);
            this.btn_Color.TabIndex = 42;
            this.btn_Color.Text = "颜色";
            this.btn_Color.UseVisualStyleBackColor = true;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // txt_WaterMark
            // 
            this.txt_WaterMark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_WaterMark.Enabled = false;
            this.txt_WaterMark.Location = new System.Drawing.Point(45, 100);
            this.txt_WaterMark.MaxLength = 100;
            this.txt_WaterMark.Multiline = true;
            this.txt_WaterMark.Name = "txt_WaterMark";
            this.txt_WaterMark.Size = new System.Drawing.Size(895, 64);
            this.txt_WaterMark.TabIndex = 37;
            // 
            // cb_WaterMark
            // 
            this.cb_WaterMark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_WaterMark.AutoSize = true;
            this.cb_WaterMark.Location = new System.Drawing.Point(109, 71);
            this.cb_WaterMark.Name = "cb_WaterMark";
            this.cb_WaterMark.Size = new System.Drawing.Size(148, 23);
            this.cb_WaterMark.TabIndex = 36;
            this.cb_WaterMark.Text = "添加文本水印";
            this.cb_WaterMark.UseVisualStyleBackColor = true;
            this.cb_WaterMark.CheckedChanged += new System.EventHandler(this.cb_WaterMark_CheckedChanged);
            // 
            // lbl_FileSize
            // 
            this.lbl_FileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FileSize.AutoSize = true;
            this.lbl_FileSize.Location = new System.Drawing.Point(103, 221);
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
            this.txt_FileSize.Location = new System.Drawing.Point(308, 218);
            this.txt_FileSize.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_FileSize.Name = "txt_FileSize";
            this.txt_FileSize.ReadOnly = true;
            this.txt_FileSize.Size = new System.Drawing.Size(454, 29);
            this.txt_FileSize.TabIndex = 21;
            // 
            // lbl_Number
            // 
            this.lbl_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(817, 166);
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
            this.lbl_FileName.Location = new System.Drawing.Point(103, 159);
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
            this.txt_FileName.Location = new System.Drawing.Point(308, 159);
            this.txt_FileName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_FileName.MaxLength = 20;
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(454, 29);
            this.txt_FileName.TabIndex = 18;
            this.txt_FileName.Text = "docSplit_";
            // 
            // btn_SelectSrc
            // 
            this.btn_SelectSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectSrc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectSrc.Location = new System.Drawing.Point(808, 102);
            this.btn_SelectSrc.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_SelectSrc.Name = "btn_SelectSrc";
            this.btn_SelectSrc.Size = new System.Drawing.Size(132, 35);
            this.btn_SelectSrc.TabIndex = 17;
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
            this.lbl_FilePath.Location = new System.Drawing.Point(103, 105);
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
            this.txt_Src.Location = new System.Drawing.Point(308, 102);
            this.txt_Src.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_Src.Name = "txt_Src";
            this.txt_Src.ReadOnly = true;
            this.txt_Src.Size = new System.Drawing.Size(454, 29);
            this.txt_Src.TabIndex = 15;
            this.txt_Src.Click += new System.EventHandler(this.btn_SelectSrc_Click);
            this.txt_Src.MouseHover += new System.EventHandler(this.txt_Src_MouseHover);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectFile.Location = new System.Drawing.Point(808, 42);
            this.btn_SelectFile.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(132, 35);
            this.btn_SelectFile.TabIndex = 14;
            this.btn_SelectFile.Text = "浏览...";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // lbl_File
            // 
            this.lbl_File.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_File.AutoSize = true;
            this.lbl_File.Location = new System.Drawing.Point(103, 45);
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
            this.txt_SelectFile.Location = new System.Drawing.Point(308, 42);
            this.txt_SelectFile.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_SelectFile.Name = "txt_SelectFile";
            this.txt_SelectFile.ReadOnly = true;
            this.txt_SelectFile.Size = new System.Drawing.Size(454, 29);
            this.txt_SelectFile.TabIndex = 12;
            this.txt_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            this.txt_SelectFile.MouseHover += new System.EventHandler(this.txt_SelectFile_MouseHover);
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
            this.gb_BaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_BaseInfo.Location = new System.Drawing.Point(0, 0);
            this.gb_BaseInfo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.gb_BaseInfo.Name = "gb_BaseInfo";
            this.gb_BaseInfo.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.gb_BaseInfo.Size = new System.Drawing.Size(967, 624);
            this.gb_BaseInfo.TabIndex = 26;
            this.gb_BaseInfo.TabStop = false;
            this.gb_BaseInfo.Text = "基本信息";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Location = new System.Drawing.Point(826, 225);
            this.lbl_Unit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(29, 19);
            this.lbl_Unit.TabIndex = 23;
            this.lbl_Unit.Text = "KB";
            // 
            // DocSplitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 624);
            this.Controls.Add(this.gb_SplitType);
            this.Controls.Add(this.gb_BaseInfo);
            this.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocSplitForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Split Tool";
            this.Load += new System.EventHandler(this.DocSplitForm_Load);
            this.gb_SplitType.ResumeLayout(false);
            this.gb_SplitType.PerformLayout();
            this.gb_BaseInfo.ResumeLayout(false);
            this.gb_BaseInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btn_Split;
        private System.Windows.Forms.RadioButton rbtn_PageBreak;
        private System.Windows.Forms.RadioButton rbtn_SectionBreak;
        private System.Windows.Forms.GroupBox gb_SplitType;
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
        private System.Windows.Forms.GroupBox gb_BaseInfo;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.TextBox txt_WaterMark;
        private System.Windows.Forms.CheckBox cb_WaterMark;
        private System.Windows.Forms.Label lbl_FontSize;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.TextBox txt_FontSize;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.Label lbl_Layout;
        private System.Windows.Forms.ComboBox cbBox_Layout;
        private System.Windows.Forms.Button btn_FontSize;
        private System.Windows.Forms.Button btn_Color;
    }
}