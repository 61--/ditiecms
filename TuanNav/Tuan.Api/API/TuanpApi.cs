using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Tuan.Common;
using Tuan.Entity;

namespace Tuan.Api.Tuanp
{
    public class TuanpApi
    {
        public IList<TuanGou> TuanGouList
        {
            get;
            private set;
        }

        public TuanpApi(string apiUrl)
        {
            urlset data = new urlset().GetRemoteData(apiUrl);
            if (data.url.Count > 0)
            {
                TuanGouList = new List<TuanGou>();
                foreach (url m in data.url)
                {
                    TuanGou tuanGou = new TuanGou();
                    tuanGou.CityID = Utils.CityToID(m.data.display.city);
                    tuanGou.Title = m.data.display.title;
                    tuanGou.ImageUrl = m.data.display.image;
                    tuanGou.ImageThumbUrl = m.data.display.image;
                    tuanGou.BeginTime = TryConvert.ToDateTime(m.data.display.startTime);
                    tuanGou.EndTime = TryConvert.ToDateTime(m.data.display.endTime);
                    tuanGou.MarketPrice = m.data.display.value;
                    tuanGou.TuanPrice = m.data.display.price;
                    tuanGou.Rebate = m.data.display.rebate;
                    tuanGou.BuyCount = m.data.display.bought;
                    tuanGou.Description = m.data.display.description;
                    tuanGou.TuanDetail = m.data.display.detail;
                    tuanGou.MerchantName = m.data.display.merchantName;
                    tuanGou.MerchantPhone = m.data.display.merchantPhone;
                    tuanGou.MerchantAddress = m.data.display.merchantAddr;
                    tuanGou.TuanUrl = m.loc;
                    tuanGou.AddDate = DateTime.Now;

                    TuanGouList.Add(tuanGou);
                }
            }
        }
    }

    [Serializable]
    [XmlRoot(ElementName = "urlset")]
    public class urlset : BaseApi<urlset>
    {
        [XmlElement(ElementName = "url")]
        public List<url> url
        {
            get;
            set;
        }
    }

    [Serializable]
    public class url
    {
        public string loc
        {
            get;
            set;
        }

        [XmlElement(ElementName = "data")]
        public data data
        {
            get;
            set;
        }
    }

    [Serializable]
    public class data
    {
        [XmlElement(ElementName = "display")]
        public display display
        {
            get;
            set;
        }
    }

    [Serializable]
    public class display
    {
        public string city
        {
            get;
            set;
        }

        public string title
        {
            get;
            set;
        }

        public string image
        {
            get;
            set;
        }

        public long startTime
        {
            get;
            set;
        }

        public long endTime
        {
            get;
            set;
        }

        public decimal value
        {
            get;
            set;
        }

        public decimal price
        {
            get;
            set;
        }

        public float rebate
        {
            get;
            set;
        }

        public int bought
        {
            get;
            set;
        }

        public string description
        {
            get;
            set;
        }

        public string detail
        {
            get;
            set;
        }

        public string merchantName
        {
            get;
            set;
        }

        public string merchantPhone
        {
            get;
            set;
        }

        public string merchantAddr
        {
            get;
            set;
        }
    }
}
