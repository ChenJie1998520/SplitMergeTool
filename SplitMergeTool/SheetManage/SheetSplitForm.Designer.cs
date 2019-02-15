namespace SplitMergeTool.SheetManage
{
    partial class SheetSplitForm
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
            this.gb_SplitType = new System.Windows.Forms.GroupBox();
            this.gb_SplitWay = new System.Windows.Forms.GroupBox();
            this.gb_FixedRows = new System.Windows.Forms.GroupBox();
            this.lbl_Symbol = new System.Windows.Forms.Label();
            this.txt_FixedRowsEnd = new System.Windows.Forms.TextBox();
            this.lbl_FixedRowsChooseWorkSheet = new System.Windows.Forms.Label();
            this.txt_FixedRowsBegin = new System.Windows.Forms.TextBox();
            this.lbl_FixedRows = new System.Windows.Forms.Label();
            this.cbBox_FixedRowsWorkSheet = new System.Windows.Forms.ComboBox();
            this.rbtn_FixedRowsAll = new System.Windows.Forms.RadioButton();
            this.rbtn_FixedRowsDesignation = new System.Windows.Forms.RadioButton();
            this.rbtn_FixedRows = new System.Windows.Forms.RadioButton();
            this.btn_Split = new System.Windows.Forms.Button();
            this.rbtn_AllWorkBook = new System.Windows.Forms.RadioButton();
            this.gb_BaseInfo = new System.Windows.Forms.GroupBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gb_SplitType.SuspendLayout();
            this.gb_SplitWay.SuspendLayout();
            this.gb_FixedRows.SuspendLayout();
            this.gb_BaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_SplitType
            // 
            this.gb_SplitType.AutoSize = true;
            this.gb_SplitType.Controls.Add(this.gb_SplitWay);
            this.gb_SplitType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_SplitType.Location = new System.Drawing.Point(0, 252);
            this.gb_SplitType.Margin = new System.Windows.Forms.Padding(4);
            this.gb_SplitType.Name = "gb_SplitType";
            this.gb_SplitType.Padding = new System.Windows.Forms.Padding(4);
            this.gb_SplitType.Size = new System.Drawing.Size(1045, 341);
            this.gb_SplitType.TabIndex = 27;
            this.gb_SplitType.TabStop = false;
            this.gb_SplitType.Text = "拆分方式";
            // 
            // gb_SplitWay
            // 
            this.gb_SplitWay.Controls.Add(this.gb_FixedRows);
            this.gb_SplitWay.Controls.Add(this.rbtn_FixedRows);
            this.gb_SplitWay.Controls.Add(this.btn_Split);
            this.gb_SplitWay.Controls.Add(this.rbtn_AllWorkBook);
            this.gb_SplitWay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_SplitWay.Location = new System.Drawing.Point(4, 26);
            this.gb_SplitWay.Name = "gb_SplitWay";
            this.gb_SplitWay.Size = new System.Drawing.Size(1037, 311);
            this.gb_SplitWay.TabIndex = 5;
            this.gb_SplitWay.TabStop = false;
            this.gb_SplitWay.Text = "拆分类型";
            // 
            // gb_FixedRows
            // 
            this.gb_FixedRows.Controls.Add(this.lbl_Symbol);
            this.gb_FixedRows.Controls.Add(this.txt_FixedRowsEnd);
            this.gb_FixedRows.Controls.Add(this.lbl_FixedRowsChooseWorkSheet);
            this.gb_FixedRows.Controls.Add(this.txt_FixedRowsBegin);
            this.gb_FixedRows.Controls.Add(this.lbl_FixedRows);
            this.gb_FixedRows.Controls.Add(this.cbBox_FixedRowsWorkSheet);
            this.gb_FixedRows.Controls.Add(this.rbtn_FixedRowsAll);
            this.gb_FixedRows.Controls.Add(this.rbtn_FixedRowsDesignation);
            this.gb_FixedRows.Enabled = false;
            this.gb_FixedRows.Location = new System.Drawing.Point(6, 81);
            this.gb_FixedRows.Name = "gb_FixedRows";
            this.gb_FixedRows.Size = new System.Drawing.Size(1021, 142);
            this.gb_FixedRows.TabIndex = 36;
            this.gb_FixedRows.TabStop = false;
            this.gb_FixedRows.Text = "将工作表进行固定行数拆分";
            // 
            // lbl_Symbol
            // 
            this.lbl_Symbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Symbol.AutoSize = true;
            this.lbl_Symbol.Location = new System.Drawing.Point(805, 35);
            this.lbl_Symbol.Name = "lbl_Symbol";
            this.lbl_Symbol.Size = new System.Drawing.Size(19, 19);
            this.lbl_Symbol.TabIndex = 29;
            this.lbl_Symbol.Text = "~";
            // 
            // txt_FixedRowsEnd
            // 
            this.txt_FixedRowsEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FixedRowsEnd.Location = new System.Drawing.Point(856, 28);
            this.txt_FixedRowsEnd.Name = "txt_FixedRowsEnd";
            this.txt_FixedRowsEnd.Size = new System.Drawing.Size(102, 29);
            this.txt_FixedRowsEnd.TabIndex = 12;
            // 
            // lbl_FixedRowsChooseWorkSheet
            // 
            this.lbl_FixedRowsChooseWorkSheet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FixedRowsChooseWorkSheet.AutoSize = true;
            this.lbl_FixedRowsChooseWorkSheet.Location = new System.Drawing.Point(526, 88);
            this.lbl_FixedRowsChooseWorkSheet.Name = "lbl_FixedRowsChooseWorkSheet";
            this.lbl_FixedRowsChooseWorkSheet.Size = new System.Drawing.Size(89, 19);
            this.lbl_FixedRowsChooseWorkSheet.TabIndex = 27;
            this.lbl_FixedRowsChooseWorkSheet.Text = "工作表：";
            // 
            // txt_FixedRowsBegin
            // 
            this.txt_FixedRowsBegin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FixedRowsBegin.Location = new System.Drawing.Point(669, 28);
            this.txt_FixedRowsBegin.Name = "txt_FixedRowsBegin";
            this.txt_FixedRowsBegin.Size = new System.Drawing.Size(104, 29);
            this.txt_FixedRowsBegin.TabIndex = 11;
            // 
            // lbl_FixedRows
            // 
            this.lbl_FixedRows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FixedRows.AutoSize = true;
            this.lbl_FixedRows.Location = new System.Drawing.Point(546, 35);
            this.lbl_FixedRows.Name = "lbl_FixedRows";
            this.lbl_FixedRows.Size = new System.Drawing.Size(69, 19);
            this.lbl_FixedRows.TabIndex = 25;
            this.lbl_FixedRows.Text = "行数：";
            // 
            // cbBox_FixedRowsWorkSheet
            // 
            this.cbBox_FixedRowsWorkSheet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBox_FixedRowsWorkSheet.BackColor = System.Drawing.SystemColors.Control;
            this.cbBox_FixedRowsWorkSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBox_FixedRowsWorkSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_FixedRowsWorkSheet.Enabled = false;
            this.cbBox_FixedRowsWorkSheet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBox_FixedRowsWorkSheet.FormattingEnabled = true;
            this.cbBox_FixedRowsWorkSheet.Location = new System.Drawing.Point(669, 85);
            this.cbBox_FixedRowsWorkSheet.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cbBox_FixedRowsWorkSheet.Name = "cbBox_FixedRowsWorkSheet";
            this.cbBox_FixedRowsWorkSheet.Size = new System.Drawing.Size(289, 27);
            this.cbBox_FixedRowsWorkSheet.TabIndex = 13;
            // 
            // rbtn_FixedRowsAll
            // 
            this.rbtn_FixedRowsAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_FixedRowsAll.AutoSize = true;
            this.rbtn_FixedRowsAll.Checked = true;
            this.rbtn_FixedRowsAll.Location = new System.Drawing.Point(48, 33);
            this.rbtn_FixedRowsAll.Name = "rbtn_FixedRowsAll";
            this.rbtn_FixedRowsAll.Size = new System.Drawing.Size(127, 23);
            this.rbtn_FixedRowsAll.TabIndex = 9;
            this.rbtn_FixedRowsAll.TabStop = true;
            this.rbtn_FixedRowsAll.Text = "所有工作表";
            this.rbtn_FixedRowsAll.UseVisualStyleBackColor = true;
            this.rbtn_FixedRowsAll.CheckedChanged += new System.EventHandler(this.rbtn_FixedRowsAll_CheckedChanged);
            // 
            // rbtn_FixedRowsDesignation
            // 
            this.rbtn_FixedRowsDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_FixedRowsDesignation.AutoSize = true;
            this.rbtn_FixedRowsDesignation.Location = new System.Drawing.Point(45, 84);
            this.rbtn_FixedRowsDesignation.Name = "rbtn_FixedRowsDesignation";
            this.rbtn_FixedRowsDesignation.Size = new System.Drawing.Size(127, 23);
            this.rbtn_FixedRowsDesignation.TabIndex = 10;
            this.rbtn_FixedRowsDesignation.Text = "指定工作表";
            this.rbtn_FixedRowsDesignation.UseVisualStyleBackColor = true;
            this.rbtn_FixedRowsDesignation.CheckedChanged += new System.EventHandler(this.rbtn_FixedRowsDesignation_CheckedChanged);
            // 
            // rbtn_FixedRows
            // 
            this.rbtn_FixedRows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_FixedRows.AutoSize = true;
            this.rbtn_FixedRows.Location = new System.Drawing.Point(592, 42);
            this.rbtn_FixedRows.Name = "rbtn_FixedRows";
            this.rbtn_FixedRows.Size = new System.Drawing.Size(267, 23);
            this.rbtn_FixedRows.TabIndex = 8;
            this.rbtn_FixedRows.Text = "将工作表进行固定行数拆分";
            this.rbtn_FixedRows.UseVisualStyleBackColor = true;
            this.rbtn_FixedRows.CheckedChanged += new System.EventHandler(this.rbtn_FixedRows_CheckedChanged);
            // 
            // btn_Split
            // 
            this.btn_Split.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Split.BackColor = System.Drawing.Color.White;
            this.btn_Split.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Split.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Split.Location = new System.Drawing.Point(406, 250);
            this.btn_Split.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Split.Name = "btn_Split";
            this.btn_Split.Size = new System.Drawing.Size(200, 50);
            this.btn_Split.TabIndex = 35;
            this.btn_Split.Text = "开始分割";
            this.btn_Split.UseVisualStyleBackColor = false;
            this.btn_Split.Click += new System.EventHandler(this.btn_Split_Click);
            // 
            // rbtn_AllWorkBook
            // 
            this.rbtn_AllWorkBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_AllWorkBook.AutoSize = true;
            this.rbtn_AllWorkBook.Checked = true;
            this.rbtn_AllWorkBook.Location = new System.Drawing.Point(57, 42);
            this.rbtn_AllWorkBook.Name = "rbtn_AllWorkBook";
            this.rbtn_AllWorkBook.Size = new System.Drawing.Size(267, 23);
            this.rbtn_AllWorkBook.TabIndex = 7;
            this.rbtn_AllWorkBook.TabStop = true;
            this.rbtn_AllWorkBook.Text = "将所有工作表拆分为工作簿";
            this.rbtn_AllWorkBook.UseVisualStyleBackColor = true;
            this.rbtn_AllWorkBook.CheckedChanged += new System.EventHandler(this.rbtn_AllWorkBook_CheckedChanged);
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
            this.gb_BaseInfo.Size = new System.Drawing.Size(1045, 252);
            this.gb_BaseInfo.TabIndex = 26;
            this.gb_BaseInfo.TabStop = false;
            this.gb_BaseInfo.Text = "基本信息";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Location = new System.Drawing.Point(866, 221);
            this.lbl_Unit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(29, 19);
            this.lbl_Unit.TabIndex = 23;
            this.lbl_Unit.Text = "KB";
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
            this.txt_FileSize.Location = new System.Drawing.Point(194, 219);
            this.txt_FileSize.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txt_FileSize.Name = "txt_FileSize";
            this.txt_FileSize.ReadOnly = true;
            this.txt_FileSize.Size = new System.Drawing.Size(632, 29);
            this.txt_FileSize.TabIndex = 4;
            // 
            // lbl_Number
            // 
            this.lbl_Number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(866, 161);
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
            this.lbl_FileName.Location = new System.Drawing.Point(33, 169);
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
            this.txt_FileName.TabIndex = 3;
            this.txt_FileName.Text = "split_";
            // 
            // btn_SelectSrc
            // 
            this.btn_SelectSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectSrc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectSrc.Location = new System.Drawing.Point(857, 97);
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
            this.lbl_FilePath.Location = new System.Drawing.Point(33, 105);
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
            this.txt_Src.TabIndex = 2;
            this.txt_Src.Click += new System.EventHandler(this.btn_SelectSrc_Click);
            this.txt_Src.MouseHover += new System.EventHandler(this.txt_Src_MouseHover);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectFile.Location = new System.Drawing.Point(857, 37);
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
            this.lbl_File.Location = new System.Drawing.Point(33, 42);
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
            this.txt_SelectFile.TabIndex = 1;
            this.txt_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            this.txt_SelectFile.MouseHover += new System.EventHandler(this.txt_SelectFile_MouseHover);
            // 
            // SheetSplitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 593);
            this.Controls.Add(this.gb_SplitType);
            this.Controls.Add(this.gb_BaseInfo);
            this.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SheetSplitForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sheet Split Tool";
            this.Load += new System.EventHandler(this.SheetSplitForm_Load);
            this.gb_SplitType.ResumeLayout(false);
            this.gb_SplitWay.ResumeLayout(false);
            this.gb_SplitWay.PerformLayout();
            this.gb_FixedRows.ResumeLayout(false);
            this.gb_FixedRows.PerformLayout();
            this.gb_BaseInfo.ResumeLayout(false);
            this.gb_BaseInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SplitType;
        private System.Windows.Forms.Button btn_Split;
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
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.GroupBox gb_SplitWay;
        private System.Windows.Forms.GroupBox gb_FixedRows;
        private System.Windows.Forms.Label lbl_Symbol;
        private System.Windows.Forms.TextBox txt_FixedRowsEnd;
        private System.Windows.Forms.Label lbl_FixedRowsChooseWorkSheet;
        private System.Windows.Forms.TextBox txt_FixedRowsBegin;
        private System.Windows.Forms.Label lbl_FixedRows;
        private System.Windows.Forms.ComboBox cbBox_FixedRowsWorkSheet;
        private System.Windows.Forms.RadioButton rbtn_FixedRowsAll;
        private System.Windows.Forms.RadioButton rbtn_FixedRowsDesignation;
        private System.Windows.Forms.RadioButton rbtn_FixedRows;
        private System.Windows.Forms.RadioButton rbtn_AllWorkBook;
    }
}