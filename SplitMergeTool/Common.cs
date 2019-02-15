using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace SplitMergeTool
{
    public class Common
    {
        #region Excel表名、列名获取（不支持64位）
        /// <summary> 
        /// 获取Excel工作薄中Sheet页(工作表)名集合
        /// </summary> 
        /// <param name="fileName">Excel文件名称及路径,例:C:\Users\JK\Desktop\xxx.xls</param> 
        /// <returns>Sheet页名称集合</returns> 
        public static string[] GetExcelSheetNames(string fileName)
        {
            OleDbConnection objConn = null;
            DataTable dt = null;
            try
            {
                string connString = string.Empty;
                string FileType = fileName.Substring(fileName.LastIndexOf("."));
                if (FileType == ".xls")
                    connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties=Excel 8.0;";
                else//.xlsx
                    connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";
                
                objConn = new OleDbConnection(connString);// 创建连接对象                
                objConn.Open();// 打开数据库连接 
                // 得到包括数据架构的数据表 
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (dt == null)
                {
                    return null;
                }
                string[] sheets = new string[dt.Rows.Count];
                int i = 0;
                // 加入工作表名称到字符串数组 
                foreach (DataRow row in dt.Rows)
                {
                    string sheetTableName = row["Table_Name"].ToString();
                    //过滤无效SheetName
                    if (sheetTableName.Contains("$") && sheetTableName.Replace("'", "").EndsWith("$"))
                    {
                        sheets[i] = sheetTableName.Substring(0, sheetTableName.Length - 1);
                    }
                    i++;
                }
                return sheets;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                // 清理 
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }
        

        /// <summary>
        /// 获取Excel工作薄中指定Sheet页(工作表)的列名集合
        /// </summary>
        /// <param name="fileName">Excel文件名称及路径,例:C:\Users\JK\Desktop\xxx.xls</param>
        /// <param name="tableName">Sheet页(工作表)名称</param>
        /// <returns>Sheet页指定表的列名集合</returns>
        public static string[] GetExcelTableColunms(string fileName,string tableName)
        {
            OleDbConnection objConn = null;
            DataTable dt = null;
            try
            {
                string FileType = fileName.Substring(fileName.LastIndexOf("."));
                string strConn = string.Empty;
                if (FileType == ".xls")
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties=Excel 8.0;";
                else//.xlsx
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";

                objConn = new OleDbConnection(strConn);
                objConn.Open();
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (dt == null)
                {
                    return null;
                }

                string[] tableColumns = null;
                foreach (DataRow drow in dt.Rows)
                {
                    string sheetTableName = drow["Table_Name"].ToString();
                    if (tableName == sheetTableName)
                    {
                        DataTable columns = objConn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, new object[] { null, null, sheetTableName, null });
                        tableColumns = new string[columns.Rows.Count];
                        int i = 0;
                        foreach (DataRow drowColumns in columns.Rows)
                        {
                            string columnName = drowColumns["Column_Name"].ToString();
                            tableColumns[i] = columnName;
                            i++;
                        }
                    }
                }
                return tableColumns;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                // 清理 
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }

        #endregion

        /// <summary>
        /// 获取Excel工作薄中Sheet页(工作表)名集合
        /// </summary>
        /// <param name="filePath">Excel文件名称及路径,例:C:\Users\JK\Desktop\xxx.xls</param>
        /// <returns>Sheet页名称集合</returns>
        public static string[] GetWorkBookSheetNames(string filePath)
        {
            Workbook workBook = new Workbook();
            try
            {
                workBook.LoadFromFile(filePath);
                string[] sheetNames = new string[workBook.Worksheets.Count];
                foreach (Worksheet sheet in workBook.Worksheets)
                {
                    sheetNames[sheet.Index] = sheet.Name;
                }
                workBook.Dispose();
                return sheetNames;
            }
            catch(Exception ex)
            {
                workBook.Dispose();
                return null;
            }
        }

        /// <summary>
        /// 获取Excel工作薄中指定Sheet页(工作表)的行集合
        /// </summary>
        /// <param name="filePath">Excel文件名称及路径,例:C:\Users\JK\Desktop\xxx.xls</param>
        /// <param name="sheetName">Sheet页(工作表)名称</param>
        /// <param name="rowNumber">指定行</param>
        /// <returns>Sheet页指定表的行集合</returns>
        public static string[] GetWorkSheetRowNames(string filePath, string sheetName)
        {
            Workbook workBook = new Workbook();
            try
            {
                workBook.LoadFromFile(filePath);
                string[] rowNames = null;
                foreach (Worksheet sheet in workBook.Worksheets)
                {
                    if (sheetName == sheet.Name)
                    {
                        rowNames = new string[sheet.Rows.Length];
                        int i = 0;
                        foreach (CellRange row in sheet.Rows)
                        {
                            rowNames[i] = (i + 1).ToString();
                            i++;
                        }
                    }
                }
                workBook.Dispose();
                return rowNames;
            }
            catch(Exception ex)
            {
                workBook.Dispose();
                return null;
            }
        }

        /// <summary>
        /// 获取Excel工作薄中指定Sheet页(工作表)的列名集合
        /// </summary>
        /// <param name="filePath">Excel文件名称及路径,例:C:\Users\JK\Desktop\xxx.xls</param>
        /// <param name="sheetName">Sheet页(工作表)名称</param>
        /// <returns>Sheet页指定表的列名集合</returns>
        public static string[] GetWorkSheetColumnNames(string filePath, string sheetName)
        {
            return GetWorkSheetColumnNames(filePath, sheetName, 1);
        }

        /// <summary>
        /// 获取Excel工作薄中指定Sheet页(工作表)的列名集合
        /// </summary>
        /// <param name="filePath">Excel文件名称及路径,例:C:\Users\JK\Desktop\xxx.xls</param>
        /// <param name="sheetName">Sheet页(工作表)名称</param>
        /// <param name="rowNumber">指定行</param>
        /// <returns>Sheet页指定表的列名集合</returns>
        public static string[] GetWorkSheetColumnNames(string filePath, string sheetName, int rowNumber)
        {
            Workbook workBook = new Workbook();
            try
            {
                int cell = 1;
                int.TryParse(rowNumber.ToString(), out cell);
                workBook.LoadFromFile(filePath);
                string[] columnNames = null;
                foreach (Worksheet sheet in workBook.Worksheets)
                {
                    if (sheetName == sheet.Name)
                    {
                        columnNames = new string[sheet.Columns.Length];
                        int i = 0;
                        foreach (CellRange column in sheet.Columns)
                        {
                            columnNames[i] = sheet.Range[cell, column.Column].NumberText;
                            i++;
                        }
                    }
                }
                workBook.Dispose();
                return columnNames;
            }
            catch (Exception ex)
            {
                workBook.Dispose();
                return null;
            }
        }

        /// <summary>
        /// MD5加密(32位小写)
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns></returns>
        public static string GetMD5(string str)
        {
            string sign = "";
            try
            {
                MD5 md5 = MD5.Create();//实例化一个md5对像
                                       // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
                byte[] hashStr = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
                // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
                for (int i = 0; i < hashStr.Length; i++)
                {
                    // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符
                    sign = sign + hashStr[i].ToString("x2");
                }
            }
            catch (Exception ex)
            {}
            return sign;
        }
    }

    public class Global
    {
        /// <summary>
        /// 百度翻译api地址
        /// </summary>
        public static string BaiduTranslatorApi = ConfigurationManager.AppSettings["BaiduTranslatorApi"].ToString();

        /// <summary>
        /// 百度翻译appID
        /// </summary>
        public static string BaiduTranslatorAppId = ConfigurationManager.AppSettings["BaiduTranslatorAppId"].ToString();

        /// <summary>
        /// 百度翻译app密钥
        /// </summary>
        public static string BaiduTranslatorAppKey = ConfigurationManager.AppSettings["BaiduTranslatorAppKey"].ToString();
    }
}
