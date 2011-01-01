using System;
using System.Collections.Generic;
using System.Text;

namespace Tuan.Entity.Global
{
    public class DataBaseInfo
    {
        public DataBaseInfo()
        { }

        private string version;
        private int dataSize;
        private int logSize;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }
        public int DataSize
        {
            get { return dataSize; }
            set { dataSize = value; }
        }
        public int LogSize
        {
            get { return logSize; }
            set { logSize = value; }
        }
    }
}
