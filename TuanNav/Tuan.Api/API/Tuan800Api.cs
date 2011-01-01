using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Tuan.Common;
using Tuan.Entity;

namespace Tuan.Api.Tuan800
{
    public class Tuan800Api
    {
        public IList<TuanGou> TuanGouList
        {
            get;
            private set;
        }

        public Tuan800Api(string apiUrl)
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
                    tuanGou.Rebate = (float)Math.Round((tuanGou.TuanPrice / tuanGou.MarketPrice) * 10, 2);
                    tuanGou.TotalCount = m.data.display.maxQuota;
                    tuanGou.BuyCount = m.data.display.bought;
                    tuanGou.TuanUrl = m.loc;
                    tuanGou.Description = m.data.display.tip;
                    tuanGou.TuanDetail = m.data.display.detail;
                    tuanGou.MerchantName = m.data.shops.shop.name;
                    tuanGou.MerchantPhone = m.data.shops.shop.tel;
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

        [XmlElement(ElementName = "shops")]
        public shops shops
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

        public string tag
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

        public int bought
        {
            get;
            set;
        }

        public int maxQuota
        {
            get;
            set;
        }

        public string soldOut
        {
            get;
            set;
        }

        public string tip
        {
            get;
            set;
        }

        public string detail
        {
            get;
            set;
        }
    }

    [Serializable]
    public class shops
    {
        [XmlElement(ElementName = "shop")]
        public shop shop
        {
            get;
            set;
        }
    }

    [Serializable]
    public class shop
    {
        public string name
        {
            get;
            set;
        }

        public string tel
        {
            get;
            set;
        }
    }
}
