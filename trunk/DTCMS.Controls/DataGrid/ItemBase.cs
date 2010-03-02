using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.Controls
{
    /// <summary>
    /// Item 抽象类
    /// </summary>
    public abstract class ItemBase
    {
        private string _width;

        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }
    }
}
