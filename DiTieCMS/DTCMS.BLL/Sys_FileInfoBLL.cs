using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using DTCMS.Common;
using DTCMS.Entity;

namespace DTCMS.BLL
{
    public class Sys_FileInfoBLL
    {
        /// <summary>
        /// 获取文件信息
        /// </summary>
        /// <param name="filePath">文件先对目录如 "/template/"</param>
        /// <returns>文件信息集合</returns>
        public List<Sys_FileInfo> GetFileList(string filePath)
        {
            string filePhysicalPath = Utils.GetPhysicalPath(filePath);
            if (Directory.Exists(filePhysicalPath))
            {
                List<Sys_FileInfo> list = new List<Sys_FileInfo>();
               
                DirectoryInfo directory = new DirectoryInfo(filePhysicalPath);
                //获取目录
                DirectoryInfo[] directoryInfo = directory.GetDirectories();
                foreach (DirectoryInfo childDirecory in directoryInfo)
                {
                    Sys_FileInfo model = new Sys_FileInfo();
                    model.FileName = childDirecory.Name;
                    model.FilePath = filePath + childDirecory.Name;
                    model.UpdateTime = childDirecory.LastWriteTime.ToString();
                    model.isDirectory = true;
                    list.Add(model);
                }
                //获取文件
                FileInfo[] fileInfo = directory.GetFiles();
                string extension = string.Empty;
                foreach (FileInfo childFile in fileInfo)
                {
                    Sys_FileInfo model = new Sys_FileInfo();
                    model.FileName = childFile.Name;
                    model.FilePath = filePath + childFile.Name;
                    model.UpdateTime = childFile.LastWriteTime.ToString();
                    model.isDirectory = false;
                    extension = childFile.Extension;
                    if (extension == ".html" || extension == ".shtml" || extension == ".htm")
                        model.FileTitle = GetHtmlTitle(filePhysicalPath + childFile.Name);
                    if (childFile.Length > 1024)
                        model.FileSize = Convert.ToString(Math.Round(Convert.ToDecimal(childFile.Length) / 1024, 2)) + " K";
                    else
                        model.FileSize = childFile.Length + " B";
                    list.Add(model);

                }
                return list;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取模板标题
        /// </summary>
        /// <param name="filePath">模板文件物理路径</param>
        /// <returns></returns>
        public string GetHtmlTitle(string filePath)
        {
           
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                string content= reader.ReadToEnd();
                Regex reg = new Regex(@"<title>([\s\S]*?)</title>",RegexOptions.IgnoreCase);
                Match match=reg.Match(content);
                if (match.Success)
                    return match.Groups[1].Value;
                else
                    return "";
            }

        }
    }
}
