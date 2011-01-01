using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Tuan.Common;
using Tuan.Entity;

namespace Tuan.Api.TuanLet
{
    public class TuanLetApi
    {
        public IList<TuanGou> TuanGouList
        {
            get;
            private set;
        }

        public TuanLetApi(string apiUrl)
        {

        }
    }
}
