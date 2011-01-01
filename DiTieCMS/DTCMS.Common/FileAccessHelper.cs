//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2009-12-12 23:56:28
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.IO;
using System.Text;

namespace DTCMS.Common
{
    /// <summary>
    /// FileAccessHelper 文件访问辅助类
    /// </summary>
    public class FileAccessHelper
    {
        private static Encoding defaultEncoding = Encoding.UTF8;

        /// <summary>
        /// 返回文件是否存在
        /// </summary>
        /// <param name="filename">文件路径</param>
        /// <returns>是否存在</returns>
        public static bool FileExists(string filepath)
        {
            return System.IO.File.Exists(filepath);
        }

        /// <summary>
        /// 返回目录是否存在
        /// </summary>
        /// <param name="directoryname">目录路径</param>
        /// <returns>是否存在</returns>
        public static bool DirectoryExists(string directorypath)
        {
            string path = Utils.GetRootPath() + directorypath;
            return System.IO.Directory.Exists(path);
        }

        #region ReadTextFile
        /// <summary>
        /// ReadTextFile
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <returns>文本内容</returns>
        public static string ReadTextFile(string fileName)
        {
            return ReadTextFile(fileName, defaultEncoding);
        }

        /// <summary>
        /// ReadTextFile
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <param name="encoding">编码</param>
        /// <returns>文本内容</returns>
        public static string ReadTextFile(string fileName, Encoding encoding)
        {
            if (FileExists(fileName)) throw new ArgumentNullException("指定文件不存在");

            using (StreamReader sr = new StreamReader(fileName, encoding))
            {
               return sr.ReadToEnd();
            }
        }
        #endregion

        #region WriteTextFile
        /// <summary>
        /// WriteTextFile
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <param name="text">文本内容</param>
        public static void WriteTextAppendFile(string fileName, string text)
        {
            WriteTextFile(fileName, text, true, true, defaultEncoding);
        }

        /// <summary>
        /// WriteTextFile
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <param name="text">文本内容</param>
        public static void WriteTextFile(string fileName, string text)
        {
            WriteTextFile(fileName, text, false, true, defaultEncoding);
        }

        /// <summary>
        /// WriteTextFile
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <param name="text">文本内容</param>
        /// <param name="encoding">编码</param>	
        public static void WriteTextFile(string fileName, string text, Encoding encoding)
        {
            WriteTextFile(fileName, text, false, true, encoding);
        }

        /// <summary>
        /// WriteTextFile
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <param name="text">文本内容</param>
        /// <param name="createDir">是否创建目录</param>		
        public static void WriteTextFile(string fileName, string text, bool createDir)
        {
            WriteTextFile(fileName, text, false, createDir, defaultEncoding);
        }

        /// <summary>
        /// WriteTextFile
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <param name="text">文本内容</param>
        /// <param name="createDir">是否创建目录</param>
        /// <param name="encoding">编码</param>	
        public static void WriteTextFile(string fileName, string text, bool createDir, Encoding encoding)
        {
            WriteTextFile(fileName, text, false, createDir, encoding);
        }

        /// <summary>
        /// WriteTextFile
        /// </summary>
        /// <param name="fileName">文件路径</param>
        /// <param name="text">文本内容</param>
        /// <param name="append">是否添加到文本后面</param>
        /// <param name="createDir">是否创建目录</param>
        /// <param name="encoding">编码</param>
        public static void WriteTextFile(string fileName, string text, bool append, bool createDir, Encoding encoding)
        {
            if (createDir)
            {
                string dirName = Path.GetDirectoryName(fileName);

                if (!DirectoryExists(dirName))
                {
                    Directory.CreateDirectory(dirName);
                }
            }
            using (StreamWriter sw = new StreamWriter(fileName, append, encoding))
            {
                sw.Write(text);
            }
        }
        #endregion

        #region 文件上传
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename">要保存为的文件名</param>
        /// <param name="savepath">文件的保存路径</param>
        /// <returns></returns>
        public static bool FileUpload(System.Web.UI.WebControls.FileUpload fu, string savePath)
        {
            try
            {
                fu.PostedFile.SaveAs(savePath);
                return true;
            }
            catch
            {
                return false;
            }

        }
        #endregion

        #region 文件删除
        public static bool FileDelete(string filePath)
        {
            try
            {
                FileInfo fi = new FileInfo(filePath);
                fi.Delete();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }

    public enum FileType
    {
        Txt = 1,
        Rar = 2,
        Zip = 4,
        Bmp = 8,
        Jpg = 16,
        Gif = 32,
        Png = 64,
        Doc = 128,
        Xls = 256,
        Pdf = 512
    }
 

}
