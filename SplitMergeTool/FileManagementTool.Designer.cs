namespace SplitMergeTool
{
    partial class FileManagementTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManagementTool));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsm_SystemManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Chinese = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_English = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Contact = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_NoteManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_SplitNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_MergeNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_DocManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_SplitDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_MergeDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_FormManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_SplitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_MergeForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ToolManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_TranslationTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_SimpleCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_FileFormatConversionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.tb_Main = new System.Windows.Forms.TabControl();
            this.tbp_Index = new System.Windows.Forms.TabPage();
            this.lbl_CurrDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.tb_Main.SuspendLayout();
            this.tbp_Index.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_SystemManagement,
            this.tsm_NoteManagement,
            this.tsm_DocManagement,
            this.tsm_FormManagement,
            this.tsm_ToolManagement});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip.Size = new System.Drawing.Size(1108, 34);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menu";
            // 
            // tsm_SystemManagement
            // 
            this.tsm_SystemManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Language,
            this.tsm_Help,
            this.tsm_About,
            this.tsm_Contact,
            this.tsm_Close});
            this.tsm_SystemManagement.Image = ((System.Drawing.Image)(resources.GetObject("tsm_SystemManagement.Image")));
            this.tsm_SystemManagement.Name = "tsm_SystemManagement";
            this.tsm_SystemManagement.Size = new System.Drawing.Size(95, 24);
            this.tsm_SystemManagement.Text = "系统管理";
            // 
            // tsm_Language
            // 
            this.tsm_Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Chinese,
            this.tsm_English});
            this.tsm_Language.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Language.Image")));
            this.tsm_Language.Name = "tsm_Language";
            this.tsm_Language.Size = new System.Drawing.Size(106, 26);
            this.tsm_Language.Text = "语言";
            // 
            // tsm_Chinese
            // 
            this.tsm_Chinese.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Chinese.Image")));
            this.tsm_Chinese.Name = "tsm_Chinese";
            this.tsm_Chinese.Size = new System.Drawing.Size(106, 26);
            this.tsm_Chinese.Text = "中文";
            this.tsm_Chinese.Click += new System.EventHandler(this.tsm_Chinese_Click);
            // 
            // tsm_English
            // 
            this.tsm_English.Image = ((System.Drawing.Image)(resources.GetObject("tsm_English.Image")));
            this.tsm_English.Name = "tsm_English";
            this.tsm_English.Size = new System.Drawing.Size(106, 26);
            this.tsm_English.Text = "英文";
            this.tsm_English.Click += new System.EventHandler(this.tsm_English_Click);
            // 
            // tsm_Help
            // 
            this.tsm_Help.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Help.Image")));
            this.tsm_Help.Name = "tsm_Help";
            this.tsm_Help.Size = new System.Drawing.Size(106, 26);
            this.tsm_Help.Text = "帮助";
            this.tsm_Help.Click += new System.EventHandler(this.tsm_Help_Click);
            // 
            // tsm_About
            // 
            this.tsm_About.Image = ((System.Drawing.Image)(resources.GetObject("tsm_About.Image")));
            this.tsm_About.Name = "tsm_About";
            this.tsm_About.Size = new System.Drawing.Size(106, 26);
            this.tsm_About.Text = "关于";
            this.tsm_About.Click += new System.EventHandler(this.tsm_About_Click);
            // 
            // tsm_Contact
            // 
            this.tsm_Contact.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Contact.Image")));
            this.tsm_Contact.Name = "tsm_Contact";
            this.tsm_Contact.Size = new System.Drawing.Size(106, 26);
            this.tsm_Contact.Text = "联系";
            this.tsm_Contact.Click += new System.EventHandler(this.tsm_Contact_Click);
            // 
            // tsm_Close
            // 
            this.tsm_Close.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Close.Image")));
            this.tsm_Close.Name = "tsm_Close";
            this.tsm_Close.Size = new System.Drawing.Size(106, 26);
            this.tsm_Close.Text = "退出";
            this.tsm_Close.Click += new System.EventHandler(this.tsm_Close_Click);
            // 
            // tsm_NoteManagement
            // 
            this.tsm_NoteManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_SplitNote,
            this.tsm_MergeNote});
            this.tsm_NoteManagement.Image = ((System.Drawing.Image)(resources.GetObject("tsm_NoteManagement.Image")));
            this.tsm_NoteManagement.Name = "tsm_NoteManagement";
            this.tsm_NoteManagement.Size = new System.Drawing.Size(109, 24);
            this.tsm_NoteManagement.Text = "记事本管理";
            // 
            // tsm_SplitNote
            // 
            this.tsm_SplitNote.Image = ((System.Drawing.Image)(resources.GetObject("tsm_SplitNote.Image")));
            this.tsm_SplitNote.Name = "tsm_SplitNote";
            this.tsm_SplitNote.Size = new System.Drawing.Size(148, 26);
            this.tsm_SplitNote.Text = "记事本拆分";
            this.tsm_SplitNote.Click += new System.EventHandler(this.tsm_SplitNote_Click);
            // 
            // tsm_MergeNote
            // 
            this.tsm_MergeNote.Image = ((System.Drawing.Image)(resources.GetObject("tsm_MergeNote.Image")));
            this.tsm_MergeNote.Name = "tsm_MergeNote";
            this.tsm_MergeNote.Size = new System.Drawing.Size(148, 26);
            this.tsm_MergeNote.Text = "记事本合并";
            this.tsm_MergeNote.Click += new System.EventHandler(this.tsm_MergeNote_Click);
            // 
            // tsm_DocManagement
            // 
            this.tsm_DocManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_SplitDoc,
            this.tsm_MergeDoc});
            this.tsm_DocManagement.Image = ((System.Drawing.Image)(resources.GetObject("tsm_DocManagement.Image")));
            this.tsm_DocManagement.Name = "tsm_DocManagement";
            this.tsm_DocManagement.Size = new System.Drawing.Size(95, 24);
            this.tsm_DocManagement.Text = "文档管理";
            // 
            // tsm_SplitDoc
            // 
            this.tsm_SplitDoc.Image = ((System.Drawing.Image)(resources.GetObject("tsm_SplitDoc.Image")));
            this.tsm_SplitDoc.Name = "tsm_SplitDoc";
            this.tsm_SplitDoc.Size = new System.Drawing.Size(134, 26);
            this.tsm_SplitDoc.Text = "文档拆分";
            this.tsm_SplitDoc.Click += new System.EventHandler(this.tsm_SplitDoc_Click);
            // 
            // tsm_MergeDoc
            // 
            this.tsm_MergeDoc.Image = ((System.Drawing.Image)(resources.GetObject("tsm_MergeDoc.Image")));
            this.tsm_MergeDoc.Name = "tsm_MergeDoc";
            this.tsm_MergeDoc.Size = new System.Drawing.Size(134, 26);
            this.tsm_MergeDoc.Text = "文档合并";
            this.tsm_MergeDoc.Click += new System.EventHandler(this.tsm_MergeDoc_Click);
            // 
            // tsm_FormManagement
            // 
            this.tsm_FormManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_SplitForm,
            this.tsm_MergeForm});
            this.tsm_FormManagement.Image = ((System.Drawing.Image)(resources.GetObject("tsm_FormManagement.Image")));
            this.tsm_FormManagement.Name = "tsm_FormManagement";
            this.tsm_FormManagement.Size = new System.Drawing.Size(95, 24);
            this.tsm_FormManagement.Text = "表格管理";
            // 
            // tsm_SplitForm
            // 
            this.tsm_SplitForm.Image = ((System.Drawing.Image)(resources.GetObject("tsm_SplitForm.Image")));
            this.tsm_SplitForm.Name = "tsm_SplitForm";
            this.tsm_SplitForm.Size = new System.Drawing.Size(134, 26);
            this.tsm_SplitForm.Text = "表格拆分";
            this.tsm_SplitForm.Click += new System.EventHandler(this.tsm_SplitForm_Click);
            // 
            // tsm_MergeForm
            // 
            this.tsm_MergeForm.Image = ((System.Drawing.Image)(resources.GetObject("tsm_MergeForm.Image")));
            this.tsm_MergeForm.Name = "tsm_MergeForm";
            this.tsm_MergeForm.Size = new System.Drawing.Size(134, 26);
            this.tsm_MergeForm.Text = "表格合并";
            this.tsm_MergeForm.Click += new System.EventHandler(this.tsm_MergeForm_Click);
            // 
            // tsm_ToolManagement
            // 
            this.tsm_ToolManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_TranslationTool,
            this.tsm_SimpleCalculator,
            this.tsm_FileFormatConversionTool});
            this.tsm_ToolManagement.Name = "tsm_ToolManagement";
            this.tsm_ToolManagement.Size = new System.Drawing.Size(75, 24);
            this.tsm_ToolManagement.Text = "工具管理";
            // 
            // tsm_TranslationTool
            // 
            this.tsm_TranslationTool.Name = "tsm_TranslationTool";
            this.tsm_TranslationTool.Size = new System.Drawing.Size(186, 22);
            this.tsm_TranslationTool.Text = "翻译工具";
            this.tsm_TranslationTool.Click += new System.EventHandler(this.tsm_TranslationTool_Click);
            // 
            // tsm_SimpleCalculator
            // 
            this.tsm_SimpleCalculator.Name = "tsm_SimpleCalculator";
            this.tsm_SimpleCalculator.Size = new System.Drawing.Size(186, 22);
            this.tsm_SimpleCalculator.Text = "简易计算器";
            this.tsm_SimpleCalculator.Click += new System.EventHandler(this.tsm_SimpleCalculator_Click);
            // 
            // tsm_FileFormatConversionTool
            // 
            this.tsm_FileFormatConversionTool.Name = "tsm_FileFormatConversionTool";
            this.tsm_FileFormatConversionTool.Size = new System.Drawing.Size(186, 22);
            this.tsm_FileFormatConversionTool.Text = "文件格式转换工具";
            this.tsm_FileFormatConversionTool.Click += new System.EventHandler(this.tsm_FileFormatConversionTool_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.AutoSize = true;
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.tb_Main);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 34);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1108, 648);
            this.pnl_Main.TabIndex = 1;
            // 
            // tb_Main
            // 
            this.tb_Main.Controls.Add(this.tbp_Index);
            this.tb_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Main.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Main.ItemSize = new System.Drawing.Size(54, 30);
            this.tb_Main.Location = new System.Drawing.Point(0, 0);
            this.tb_Main.Name = "tb_Main";
            this.tb_Main.SelectedIndex = 0;
            this.tb_Main.Size = new System.Drawing.Size(1108, 648);
            this.tb_Main.TabIndex = 0;
            // 
            // tbp_Index
            // 
            this.tbp_Index.BackColor = System.Drawing.Color.White;
            this.tbp_Index.Controls.Add(this.lbl_CurrDate);
            this.tbp_Index.Location = new System.Drawing.Point(4, 34);
            this.tbp_Index.Name = "tbp_Index";
            this.tbp_Index.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Index.Size = new System.Drawing.Size(1100, 610);
            this.tbp_Index.TabIndex = 0;
            this.tbp_Index.Text = "首页";
            // 
            // lbl_CurrDate
            // 
            this.lbl_CurrDate.AutoSize = true;
            this.lbl_CurrDate.Location = new System.Drawing.Point(44, 31);
            this.lbl_CurrDate.Name = "lbl_CurrDate";
            this.lbl_CurrDate.Size = new System.Drawing.Size(88, 17);
            this.lbl_CurrDate.TabIndex = 0;
            this.lbl_CurrDate.Text = "当前时间：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FileManagementTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 682);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FileManagementTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件管理工具";
            this.Load += new System.EventHandler(this.FileManagementTool_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.tb_Main.ResumeLayout(false);
            this.tbp_Index.ResumeLayout(false);
            this.tbp_Index.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsm_SystemManagement;
        private System.Windows.Forms.ToolStripMenuItem tsm_Help;
        private System.Windows.Forms.ToolStripMenuItem tsm_About;
        private System.Windows.Forms.ToolStripMenuItem tsm_NoteManagement;
        private System.Windows.Forms.ToolStripMenuItem tsm_SplitNote;
        private System.Windows.Forms.ToolStripMenuItem tsm_MergeNote;
        private System.Windows.Forms.ToolStripMenuItem tsm_DocManagement;
        private System.Windows.Forms.ToolStripMenuItem tsm_SplitDoc;
        private System.Windows.Forms.ToolStripMenuItem tsm_MergeDoc;
        private System.Windows.Forms.ToolStripMenuItem tsm_FormManagement;
        private System.Windows.Forms.ToolStripMenuItem tsm_SplitForm;
        private System.Windows.Forms.ToolStripMenuItem tsm_MergeForm;
        private System.Windows.Forms.ToolStripMenuItem tsm_Contact;
        private System.Windows.Forms.ToolStripMenuItem tsm_Close;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.ToolStripMenuItem tsm_Language;
        private System.Windows.Forms.ToolStripMenuItem tsm_Chinese;
        private System.Windows.Forms.ToolStripMenuItem tsm_English;
        private System.Windows.Forms.TabControl tb_Main;
        private System.Windows.Forms.TabPage tbp_Index;
        private System.Windows.Forms.Label lbl_CurrDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tsm_ToolManagement;
        private System.Windows.Forms.ToolStripMenuItem tsm_SimpleCalculator;
        private System.Windows.Forms.ToolStripMenuItem tsm_FileFormatConversionTool;
        private System.Windows.Forms.ToolStripMenuItem tsm_TranslationTool;
    }
}