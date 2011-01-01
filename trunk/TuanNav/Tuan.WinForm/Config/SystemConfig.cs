using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Tuan.WinForm.Config
{
    public class SystemConfig
    {
        private static SystemConfig _instance;
        private string _skinName = "Office 2007 Blue";
        private string _serverDBConn = "";
        private string _localDBConn = "";

        public string SkinName
        {
            get
            {
                return _skinName;
            }
            set
            {
                _skinName = value;
            }
        }
        public string ServerDBConn
        {
            get { return _serverDBConn; }
            set { _serverDBConn = value; }
        }
        public string LocalDBConn
        {
            get { return _localDBConn; }
            set { _localDBConn = value; }
        }

        public static SystemConfig Instance
        {
            get
            {
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        //将对象写入XML
        public static void WriteConfig(SystemConfig config)
        {
            XmlSerializer xs = new XmlSerializer(typeof(SystemConfig));
            Stream stream = new FileStream(GetConfigPath(), FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            xs.Serialize(stream, config);
            stream.Close();
        }
        //将XML读到对象
        public static void ReadConfig()
        {
            string path = GetConfigPath();
            if (!File.Exists(path))
            {
                SystemConfig._instance = new SystemConfig();
                WriteConfig(SystemConfig.Instance);
            }
            else
            {
                XmlSerializer xs = new XmlSerializer(typeof(SystemConfig));
                Stream stream = new FileStream(GetConfigPath(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                Instance = xs.Deserialize(stream) as SystemConfig;
                stream.Close();
            }
        }

        public static string GetConfigPath()
        {
            return System.Windows.Forms.Application.StartupPath + "\\SystemSetting.xml";
        }
    }

}
