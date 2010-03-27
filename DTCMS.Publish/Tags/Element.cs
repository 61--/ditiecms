using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.TemplateEngine.Tags
{
    /// <summary>
    /// 各种Element元素的基类
    /// </summary>
    public class Element
    {
        int line;
        int col;

        public Element(int line, int col)
        {
            this.line = line;
            this.col = col;
        }

        public int Col
        {
            get { return this.col; }
        }

        public int Line
        {
            get { return this.line; }
        }
    }
}
