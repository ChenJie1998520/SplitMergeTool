namespace SplitMergeTool.SystemManage
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_CopyRight = new System.Windows.Forms.Label();
            this.lbl_VersionAll = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.pb_Tool = new System.Windows.Forms.PictureBox();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Tool)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.AutoScroll = true;
            this.pnl_Main.AutoSize = true;
            this.pnl_Main.Controls.Add(this.lbl_CopyRight);
            this.pnl_Main.Controls.Add(this.lbl_VersionAll);
            this.pnl_Main.Controls.Add(this.lbl_Version);
            this.pnl_Main.Controls.Add(this.pb_Tool);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(757, 425);
            this.pnl_Main.TabIndex = 0;
            // 
            // lbl_CopyRight
            // 
            this.lbl_CopyRight.AutoSize = true;
            this.lbl_CopyRight.Location = new System.Drawing.Point(139, 342);
            this.lbl_CopyRight.Name = "lbl_CopyRight";
            this.lbl_CopyRight.Size = new System.Drawing.Size(469, 19);
            this.lbl_CopyRight.TabIndex = 4;
            this.lbl_CopyRight.Text = "CopyRight© 2019 Jay Chan. All Rights Reserved.";
            // 
            // lbl_VersionAll
            // 
            this.lbl_VersionAll.AutoSize = true;
            this.lbl_VersionAll.Location = new System.Drawing.Point(262, 275);
            this.lbl_VersionAll.Name = "lbl_VersionAll";
            this.lbl_VersionAll.Size = new System.Drawing.Size(179, 19);
            this.lbl_VersionAll.TabIndex = 3;
            this.lbl_VersionAll.Text = "Jay Chan 版权所有";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(262, 212);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(179, 19);
            this.lbl_Version.TabIndex = 2;
            this.lbl_Version.Text = "文件管理工具1.0.0";
            // 
            // pb_Tool
            // 
            this.pb_Tool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Tool.Image = ((System.Drawing.Image)(resources.GetObject("pb_Tool.Image")));
            this.pb_Tool.Location = new System.Drawing.Point(266, 60);
            this.pb_Tool.Name = "pb_Tool";
            this.pb_Tool.Size = new System.Drawing.Size(193, 103);
            this.pb_Tool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Tool.TabIndex = 1;
            this.pb_Tool.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 425);
            this.Controls.Add(this.pnl_Main);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Tool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label lbl_CopyRight;
        private System.Windows.Forms.Label lbl_VersionAll;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.PictureBox pb_Tool;
    }
}