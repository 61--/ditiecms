using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using Microsoft.Win32;
using System.IO;
using System.Management;
using System.Diagnostics;
using Tuan.Data.SqlServer;
using Tuan.Entity;
using Tuan.Entity.Global;
using Tuan.Web.UI;

namespace Tuan.Web.admin
{
    public partial class index : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                #region 程序和系统信息

                lbSoftVersion.Text = "Tuanlet团购导航系统 V1.0";

                lbIp.Text = Request.ServerVariables["LOCAl_ADDR"];

                lbIISVer.Text = Request.ServerVariables["Server_SoftWare"].ToString();

                lbPhPath.Text = Request.PhysicalApplicationPath;

                lbOperat.Text = Environment.OSVersion.ToString();

                lbTimeOut.Text = (Server.ScriptTimeout).ToString() + "秒";

                lbAspnetVer.Text = string.Concat(new object[] { Environment.Version.Major, ".", Environment.Version.Minor, Environment.Version.Build, ".", Environment.Version.Revision });

                TimeSpan timeSpan = new TimeSpan(Environment.TickCount * 0x2710L);
                string osRunTime = string.Concat((int)timeSpan.TotalDays, " 天 ", timeSpan.Hours, " 小时 ", timeSpan.Minutes, " 分 ", timeSpan.Seconds, " 秒");
                lbServerLastStartToNow.Text = string.Format("{0} ({1}分钟)", osRunTime, (Environment.TickCount / 0x3e8) / 60);

                string[] achDrives = Directory.GetLogicalDrives();
                for (int i = 0; i < Directory.GetLogicalDrives().Length - 1; i++)
                {
                    lbLogicDriver.Text = lbLogicDriver.Text + achDrives[i].ToString();
                }


                lbCpuType.Text = string.Format("{0} (×{1})", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"), Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS"));


                MemoryInfo memoryInfo = new MemoryInfo().GetMemoryInfo();
                lbMemory.Text = string.Format("{0}M (已使用{1}%)", memoryInfo.dwTotalPhys / 0x100000, memoryInfo.dwMemoryLoad);
                lbMemoryNet.Text = string.Format("{0}M / {1}M (程序/.NET)", ((float)GC.GetTotalMemory(false) / 0x100000).ToString("N2"), ((float)Process.GetCurrentProcess().WorkingSet64 / 0x100000).ToString("N2"));
                try
                {
                    lbCpuNet.Text = ((TimeSpan)Process.GetCurrentProcess().TotalProcessorTime).TotalSeconds.ToString("N2") + "%";
                }
                catch
                {
                    lbCpuNet.Text = "获取失败";
                }

                DataBaseInfo dbInfo = DataBaseDAO.Instance.GetDataBaseInfo();
                lbDbVersion.Text = dbInfo.Version;
                lblDbSize.Text = string.Format("{0}M / {1}M (数据库/日志)", ((float)dbInfo.DataSize / 0x400).ToString("N2"), ((float)dbInfo.LogSize / 0x400).ToString("N2"));
                lbSession.Text = Session.Contents.SessionID;

                #endregion

                #region 网站统计信息

                ModelList statsModel = DataBaseDAO.Instance.GetBaseStats();
                if (statsModel != null && statsModel.Count > 0)
                {
                    lbTotalUser.Text = string.Format("{0} (今日{1} / 未审核{1})", statsModel[0]["ROWS"], statsModel[1]["ROWS"]);
                    lbTotalSite.Text = string.Format("{0} (今日{1} / 未审核{1})", statsModel[2]["ROWS"], statsModel[3]["ROWS"]);
                    lbTotalTuan.Text = string.Format("{0} (今日{1} / 未审核{1})", statsModel[4]["ROWS"], statsModel[5]["ROWS"]);
                    lbSiteComment.Text = string.Format("{0} (今日{1} / 未审核{1})", statsModel[6]["ROWS"], statsModel[7]["ROWS"]);
                    lbTuanComment.Text = string.Format("{0} (今日{1} / 未审核{1})", statsModel[8]["ROWS"], statsModel[9]["ROWS"]);
                }

                #endregion
            }
        }
    }
}
