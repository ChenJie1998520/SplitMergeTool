using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitMergeTool
{
    public class ShowMessage
    {
        /// <summary>
        /// 仅显示内容的提示框
        /// </summary>
        /// <param name="content">内容</param>
        public static DialogResult ShowContent(string content)
        {
            return MessageBox.Show(content);
        }

        /// <summary>
        /// 显示标题和内容但不显示图标的提示框
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="title">标题</param>
        public static DialogResult ShowContent(string content,string title)
        {
            return MessageBox.Show(content,title);
        }

        /// <summary>
        /// 信息提示框
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="title">标题</param>
        public static DialogResult ShowInfomation(string content, string title)
        {
            return MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 错误提示框
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="title">标题</param>
        public static DialogResult ShowError(string content, string title)
        {
            return MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 带是、否的图标为询问的提示框
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="title">标题</param>
        public static DialogResult ShowWhether(string content,string title)
        {
            return MessageBox.Show(content, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// 带是、否、取消的图标为询问的提示框
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="title">标题</param>
        public static DialogResult ShowWhetherCancel(string content, string title)
        {
            return MessageBox.Show(content, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        /// <summary>
        /// 带确认、取消的图标为询问的提示框
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="title">标题</param>
        public static DialogResult ShowConfirm(string content,string title)
        {
            return MessageBox.Show(content, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
