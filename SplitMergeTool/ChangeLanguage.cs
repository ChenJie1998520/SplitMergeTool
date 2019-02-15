using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitMergeTool
{
    public class ChangeLanguage
    {
        //当前默认语言  
        public static string DefaultLanguage = "zh-cn";

        /// <summary>  
        /// 修改默认语言  
        /// </summary>  
        /// <param name="lang">待设置默认语言</param>  
        public static void SetDefaultLanguage(string lang)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            DefaultLanguage = lang;
            Properties.Settings.Default.DefaultLanguage = lang;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 获取资源名称的值
        /// </summary>
        /// <param name="name">资源名称</param>
        /// <returns></returns>
        public static string getLanguage(string name)
        {
            string currName = "";
            try
            {

                Assembly myAssem = Assembly.GetEntryAssembly();
                ResourceManager rm = new ResourceManager("SplitMergeTool.lang."+ DefaultLanguage, myAssem);
                currName = rm.GetString(name);
            }
            catch (Exception ex)
            {
                currName = "";

            }
            return currName;
        }
    }
}
