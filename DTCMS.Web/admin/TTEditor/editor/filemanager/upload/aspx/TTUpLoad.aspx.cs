using System;
using System.Globalization;
using System.Xml;
using System.Web;
using System.IO;
using System.Configuration;


public partial class TTUpLoad : FredCK.FCKeditorV2.FileWorkerBase
{
    //文件扩展名
    public string FileExtendName = ConfigurationManager.AppSettings["FileExtendName"].ToString();
    //文件大小
    public long MaxFileLength = long.Parse(ConfigurationManager.AppSettings["MaxFileLength"].ToString());
    //文件路径
    public string uploadfolder = ConfigurationManager.AppSettings["FCKeditor:UserFilesPath"].ToString().EndsWith("/") ? ConfigurationManager.AppSettings["FCKeditor:UserFilesPath"].ToString() : ConfigurationManager.AppSettings["FCKeditor:UserFilesPath"].ToString()+"/";
    //文件类型
    public string action = "";


    protected override void OnLoad(EventArgs e)
    {
        action = Request.QueryString["Type"] == null ? "" : Request.QueryString["Type"].ToString();
        switch (action)
        {
            case "Image":
                FileExtendName = FileExtendName.Split('/')[0];
                break;
            case "Flash":
                FileExtendName = FileExtendName.Split('/')[1];
                break;
            default:
                break;
        }
        // Get the posted file.
        HttpPostedFile oFile = Request.Files["NewFile"];

        // Check if the file has been correctly uploaded
        if (oFile == null || oFile.ContentLength == 0)
        {
            SendResults(202);
            return;
        }
        if (oFile.ContentLength > MaxFileLength)
        {
            SendResults(1, "", "", "文件大小超过了:" + MaxFileLength);
            return;
        }
        if (!CheckFileExtendName(System.IO.Path.GetExtension(oFile.FileName), FileExtendName.Split('|')))
        {
            SendResults(1, "", "", "文件类型不符合:" + FileExtendName.Replace("|", null).Replace(".", null).Trim());
            return;
        }

        int iErrorNumber = 0;
        string sFileUrl = "";

        //原文件文件名和扩展名
        string sFileName = System.IO.Path.GetFileName(oFile.FileName);
        //原文件文件名的扩展名
        string sFileExName = System.IO.Path.GetExtension(oFile.FileName);

        int iCounter = 0;

        while (true)
        {
            string m_now = DateTime.Now.ToString("yyyy-MM-dd");
            string m_Year = m_now.Substring(0, 4);
            string m_monthday = m_now.Substring(5, 2) + "_" + m_now.Substring(8, 2);
            string YDateFiles = m_Year;
            string M_DateFiles = m_monthday;
            Random ran =new Random();
            string FileName = DateTime.Now.Ticks.ToString() + ran.Next()+"Del";
            string FilePath = System.IO.Path.Combine(this.UserFilesDirectory, YDateFiles) + "\\" + M_DateFiles + "\\";
            string sFilePath = FilePath + FileName + sFileExName;

            if (System.IO.File.Exists(sFilePath))
            {
                iCounter++;
                FileName =
                    FileName +
                    "(" + iCounter + ")" + sFileExName;

                iErrorNumber = 201;
            }
            else
            {
                if (!System.IO.Directory.Exists(FilePath))
                {
                    System.IO.Directory.CreateDirectory(FilePath);
                }
                oFile.SaveAs(sFilePath);
                sFileName = System.IO.Path.GetFileName(sFilePath);
                sFileUrl = this.uploadfolder + YDateFiles + "/" + M_DateFiles + "/" + sFileName;

                break;
            }
        }

        SendResults(iErrorNumber, sFileUrl, sFileName);
    }
    #region CheckFileExtendName检查文件类型

    private bool CheckFileExtendName(string upFileExtendName, string[] FileTypes)
    {
        bool bCheckResult = false;
        foreach (string str in FileTypes)
        {
            if (upFileExtendName.ToLower() == str.ToLower())
            {
                bCheckResult = true;
                break;
            }
        }
        return bCheckResult;
    }

    #endregion


    #region SendResults Method

    private void SendResults(int errorNumber)
    {
        SendResults(errorNumber, "", "", "");
    }

    private void SendResults(int errorNumber, string fileUrl, string fileName)
    {
        SendResults(errorNumber, fileUrl, fileName, "");
    }

    private void SendResults(int errorNumber, string fileUrl, string fileName, string customMsg)
    {
        Response.Clear();

        Response.Write("<script type=\"text/javascript\">");
        Response.Write("window.parent.OnUploadCompleted(" + errorNumber + ",'" + fileUrl.Replace("'", "\\'") + "','" + fileName.Replace("'", "\\'") + "','" + customMsg.Replace("'", "\\'") + "') ;");
        Response.Write("</script>");

        Response.End();
    }

    #endregion
}
