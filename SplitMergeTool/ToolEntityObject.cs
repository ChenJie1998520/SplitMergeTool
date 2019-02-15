using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitMergeTool
{
    #region 文件拆分、合并实体对象
    public class FileSplitModel
    {
        /// <summary>
        /// 文件名
        /// </summary>
        public string fileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string filePath { get; set; }

        /// <summary>
        /// 文件扩展名
        /// </summary>
        public string fileExtension { get; set; }

        /// <summary>
        /// 文件输出文件夹
        /// </summary>
        public string fileOutPath { get; set; }

        /// <summary>
        /// 文件输出路径，包含路径及文件名
        /// </summary>
        public string fileSrc { get; set; }

        /// <summary>
        /// 输出的文件大小（Byte）
        /// </summary>
        public string fileLength { get; set; }

        /// <summary>
        /// 文件流读取字节偏移量
        /// </summary>
        public int fileStreamReadOffset { get; set; }

        /// <summary>
        /// 文件索引（正在执行的第几个,-1代表最后一个）
        /// </summary>
        public int fileIndex { get; set; }

        /// <summary>
        /// 水印对象
        /// </summary>
        public WaterMarkModel fileWaterMark { get; set; }

        /// <summary>
        /// Excel拆分信息对象
        /// </summary>
        public ExcelSplitModel fileExcel { get; set; }
    }

    public class FileMergeModel
    {
        /// <summary>
        /// 文件名
        /// </summary>
        public string mergeFileName { get; set; }

        /// <summary>
        /// 文件扩展名
        /// </summary>
        public string mergeFileExtension { get; set; }

        /// <summary>
        /// 文件输出目录
        /// </summary>
        public string mergeFilePath { get; set; }

        /// <summary>
        /// 文件路径，包含路径及文件名
        /// </summary>
        public string mergeFileSrc { get; set; }

        /// <summary>
        /// 合并文件集合
        /// </summary>
        public List<MergeModel> mergeFileList { get; set; }
    }

    public class MergeModel
    {
        /// <summary>
        /// 文件路径，包含路径及文件名
        /// </summary>
        public string fileSrc { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string fileName { get; set; }

        /// <summary>
        /// 文件扩展名
        /// </summary>
        public string fileExtension { get; set; }

        /// <summary>
        /// 文件大小（Byte）
        /// </summary>
        public string fileLength { get; set; }

        /// <summary>
        /// 文件索引（正在执行的第几个,-1代表最后一个）
        /// </summary>
        public int fileIndex { get; set; }

    }

    /// <summary>
    /// 水印实体对象
    /// </summary>
    public class WaterMarkModel
    {
        /// <summary>
        /// 水印文字
        /// </summary>
        public string waterMarkContent { get; set; }

        /// <summary>
        /// 水印文字大小
        /// </summary>
        public float waterMarkFontSize { get; set; }

        /// <summary>
        /// 水印颜色
        /// </summary>
        public string waterMarkColor { get; set; }

        /// <summary>
        /// 水印布局方式
        /// </summary>
        public int waterMarkLayout { get; set; }
    }

    public class ExcelSplitModel
    {
        /// <summary>
        /// 拆分方式 
        /// 1:将所有工作表拆分为工作簿
        /// 2:将工作表进行固定行数拆分
        /// </summary>
        public int splitType { get; set; }

        /// <summary>
        /// 开始行数(min:1)
        /// </summary>
        public int beginRow { get; set; }

        /// <summary>
        /// 结束行数(min:1,min为0时表示最后一行)
        /// </summary>
        public int endRow { get; set; }

        /// <summary>
        /// 工作表名称（为空时表示所有表）
        /// </summary>
        public string sheetName { get; set; }

        /// <summary>
        /// 工作表列名
        /// </summary>
        public string columnName { get; set; }
    }

    #endregion

    /// <summary>
    /// 下拉框实体对象
    /// </summary>
    public class ComboBoxModel
    {
        /// <summary>
        /// 文本
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string value { get; set; }
    }

    /// <summary>
    /// 文件格式转换
    /// </summary>
    public class ConvertFormatModel
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        public string filePath { get; set; }

        /// <summary>
        /// 保存目录
        /// </summary>
        public string savePath { get; set; }

        /// <summary>
        /// 保存路径（包括目录、文件名、扩展名）
        /// </summary>
        public string saveSrc { get; set; }

        /// <summary>
        /// 保存文件名
        /// </summary>
        public string fileName { get; set; }

        /// <summary>
        /// 保存文件扩展名
        /// </summary>
        public string fileExtension { get; set; }

        /// <summary>
        /// 文件原格式
        /// 0:pdf 1:csv 2:word 3:xps 4:html 5:excel
        /// </summary>
        public int fileFormat { get; set; }

        /// <summary>
        /// 保存文件格式
        /// 0:word 1:xps 2:html 3:pdf 4:png 5:jpg 6:bmp 7:gif 8:icon
        /// </summary>
        public int saveFileFormat { get; set; }
    }

    #region 百度翻译
    public class TranslationResult
    {
        /// <summary>
        /// 错误码
        /// </summary>
        public string Error_code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string Error_msg { get; set; }

        /// <summary>
        /// 翻译源语言
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// 译文语言
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// 翻译源
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 翻译内容信息列表
        /// </summary>
        public Translation[] Trans_result { get; set; }
    }

    public class Translation
    {
        /// <summary>
        /// 原文
        /// </summary>
        public string Src { get; set; }

        /// <summary>
        /// 翻译
        /// </summary>
        public string Dst { get; set; }
    }
    #endregion
}
