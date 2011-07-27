using System;

namespace Config
{
    /// <summary>
    /// 配置信息类接口
    /// </summary>
    public abstract class IConfigInfo
    {
        protected string CFG_PATH;

        public string GetPATH()
        {
            return CFG_PATH;
        }
    }
}