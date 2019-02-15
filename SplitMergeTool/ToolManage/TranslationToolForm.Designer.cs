namespace SplitMergeTool.ToolManage
{
    partial class TranslationToolForm
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
            this.gb_Translation = new System.Windows.Forms.GroupBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Transfer = new System.Windows.Forms.Label();
            this.cbBox_To = new System.Windows.Forms.ComboBox();
            this.cbBox_Form = new System.Windows.Forms.ComboBox();
            this.btn_Translation = new System.Windows.Forms.Button();
            this.txt_ToBeTranslated = new System.Windows.Forms.TextBox();
            this.txt_PendingInput = new System.Windows.Forms.TextBox();
            this.gb_Translation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Translation
            // 
            this.gb_Translation.Controls.Add(this.lbl_Note);
            this.gb_Translation.Controls.Add(this.lbl_Transfer);
            this.gb_Translation.Controls.Add(this.cbBox_To);
            this.gb_Translation.Controls.Add(this.cbBox_Form);
            this.gb_Translation.Controls.Add(this.btn_Translation);
            this.gb_Translation.Controls.Add(this.txt_ToBeTranslated);
            this.gb_Translation.Controls.Add(this.txt_PendingInput);
            this.gb_Translation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Translation.Location = new System.Drawing.Point(0, 0);
            this.gb_Translation.Name = "gb_Translation";
            this.gb_Translation.Size = new System.Drawing.Size(1152, 666);
            this.gb_Translation.TabIndex = 7;
            this.gb_Translation.TabStop = false;
            this.gb_Translation.Text = "翻译";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Note.Location = new System.Drawing.Point(700, 349);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(233, 12);
            this.lbl_Note.TabIndex = 6;
            this.lbl_Note.Text = "注：请在网络畅通的情况下使用此翻译工具";
            // 
            // lbl_Transfer
            // 
            this.lbl_Transfer.AutoSize = true;
            this.lbl_Transfer.Location = new System.Drawing.Point(259, 340);
            this.lbl_Transfer.Name = "lbl_Transfer";
            this.lbl_Transfer.Size = new System.Drawing.Size(23, 20);
            this.lbl_Transfer.TabIndex = 5;
            this.lbl_Transfer.Text = "⇌";
            // 
            // cbBox_To
            // 
            this.cbBox_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_To.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBox_To.FormattingEnabled = true;
            this.cbBox_To.Location = new System.Drawing.Point(288, 336);
            this.cbBox_To.Name = "cbBox_To";
            this.cbBox_To.Size = new System.Drawing.Size(232, 27);
            this.cbBox_To.TabIndex = 4;
            // 
            // cbBox_Form
            // 
            this.cbBox_Form.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Form.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBox_Form.FormattingEnabled = true;
            this.cbBox_Form.Location = new System.Drawing.Point(12, 336);
            this.cbBox_Form.Name = "cbBox_Form";
            this.cbBox_Form.Size = new System.Drawing.Size(241, 27);
            this.cbBox_Form.TabIndex = 3;
            // 
            // btn_Translation
            // 
            this.btn_Translation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Translation.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Translation.Location = new System.Drawing.Point(535, 328);
            this.btn_Translation.Name = "btn_Translation";
            this.btn_Translation.Size = new System.Drawing.Size(148, 43);
            this.btn_Translation.TabIndex = 2;
            this.btn_Translation.Text = "翻译";
            this.btn_Translation.UseVisualStyleBackColor = true;
            this.btn_Translation.Click += new System.EventHandler(this.btn_Translation_Click);
            // 
            // txt_ToBeTranslated
            // 
            this.txt_ToBeTranslated.BackColor = System.Drawing.Color.White;
            this.txt_ToBeTranslated.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ToBeTranslated.Location = new System.Drawing.Point(12, 377);
            this.txt_ToBeTranslated.MaxLength = 500;
            this.txt_ToBeTranslated.Multiline = true;
            this.txt_ToBeTranslated.Name = "txt_ToBeTranslated";
            this.txt_ToBeTranslated.ReadOnly = true;
            this.txt_ToBeTranslated.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ToBeTranslated.Size = new System.Drawing.Size(1128, 277);
            this.txt_ToBeTranslated.TabIndex = 1;
            // 
            // txt_PendingInput
            // 
            this.txt_PendingInput.Location = new System.Drawing.Point(12, 30);
            this.txt_PendingInput.MaxLength = 500;
            this.txt_PendingInput.Multiline = true;
            this.txt_PendingInput.Name = "txt_PendingInput";
            this.txt_PendingInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_PendingInput.Size = new System.Drawing.Size(1128, 291);
            this.txt_PendingInput.TabIndex = 0;
            // 
            // TranslationToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 666);
            this.Controls.Add(this.gb_Translation);
            this.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TranslationToolForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translation Tool";
            this.Load += new System.EventHandler(this.TranslationToolForm_Load);
            this.gb_Translation.ResumeLayout(false);
            this.gb_Translation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Translation;
        private System.Windows.Forms.Button btn_Translation;
        private System.Windows.Forms.TextBox txt_ToBeTranslated;
        private System.Windows.Forms.TextBox txt_PendingInput;
        private System.Windows.Forms.ComboBox cbBox_Form;
        private System.Windows.Forms.Label lbl_Transfer;
        private System.Windows.Forms.ComboBox cbBox_To;
        private System.Windows.Forms.Label lbl_Note;
    }
}