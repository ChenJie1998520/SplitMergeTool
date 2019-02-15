using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitMergeTool.ToolManage
{
    public partial class SimpleCalculatorForm : Form
    {
        /// <summary>
        /// 上一个按键是否是运算符,默认为不是
        /// </summary>
        private bool lastKeyOperator = false;

        /// <summary>
        /// 上一个按键是否是小数点,默认为不是
        /// </summary>
        private bool lastKeyPoint = false;

        /// <summary>
        /// 是否已计算完毕
        /// </summary>
        private bool calculated = false;

        public string showTitle = ChangeLanguage.getLanguage("FileManageTool");
        Regex regex = new Regex("^[0-9]*$");

        #region 窗体事件
        public SimpleCalculatorForm()
        {
            InitializeComponent();
        }
        private void SimpleCalculatorForm_Load(object sender, EventArgs e)
        {
            this.Text = ChangeLanguage.getLanguage("SimpleCalculator");
            gb_Input.Text = ChangeLanguage.getLanguage("InputField");
            btn_ExtendedArea.Text = ChangeLanguage.getLanguage("ExtendedArea");
        }
        #endregion

        #region 清空
        private void btn_Clean_Click(object sender, EventArgs e)
        {
            this.txt_Value.Text = "0";
            this.txt_Record.Text = "";

            lastKeyOperator = false;
            lastKeyPoint = false;
            calculated = false;
        }
        #endregion

        #region 输入
        private void btnNum_Click(object sender, EventArgs e)
        {
            try
            {
                string txtValue = this.txt_Value.Text;
                string keyValue = ((Button)sender).Text.Trim();

                string saveStr = "";

                if (txt_Record.Text.Length > 100)
                    return;

                //输入框中为0或者上个按键值为运算符时直接替换内容
                if (txtValue == "0" || lastKeyOperator)
                {
                    saveStr = keyValue;
                    if (calculated)
                        txt_Record.Text = "";
                }
                else
                    saveStr = txtValue + keyValue;

                if (saveStr.Length < 12)
                {
                    //标记处理
                    if (keyValue == ".")
                        lastKeyPoint = true;
                    else
                        lastKeyPoint = false;

                    calculated = false;
                    lastKeyOperator = false;
                    txt_Value.Text = saveStr;
                }
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion

        #region 退格
        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            if(txt_Value.Text.Length>1)
            {
                txt_Value.Text = txt_Value.Text.Substring(0, txt_Value.Text.Length - 1);
            }
            else
            {
                txt_Value.Text = "0";
            }
        }
        #endregion

        #region 运算
        private void btnOperation_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();

                string txtValue = this.txt_Value.Text;
                string recordValue = calculated ? "" : txt_Record.Text;
                string keyCode = ((Button)sender).Text.Trim();

                string saveStr = "";

                //上一个按键值不为运算符且上一个按键值不为小数点
                if (!lastKeyOperator && !lastKeyPoint)
                {
                    switch (keyCode)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "/":
                            saveStr = recordValue + txtValue + keyCode;
                            calculated = false;
                            break;
                        case "=":
                            string formulate = recordValue + txtValue;
                            string result = table.Compute(formulate, "").ToString();
                            saveStr = recordValue + txtValue + keyCode;

                            txt_Value.Text = result;
                            calculated = true;
                            break;
                    }

                    lastKeyOperator = true;
                    txt_Record.Text = saveStr;
                }
            }
            catch(Exception ex)
            {
                ShowMessage.ShowError(ex.Message, showTitle);
            }
        }
        #endregion
    }
}
