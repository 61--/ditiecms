using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Tuan.Common;
using Tuan.Entity;

namespace Tuan.Api.Fanwe
{
    /// <summary>
    /// Goods Api
    /// </summary>
    public class FanweApi
    {
        public IList<TuanGou> TuanGouList
        {
            get;
            private set;
        }

        public FanweApi(string apiUrl)
        {
            response data = new response().GetRemoteData(apiUrl);
            if (data.goods.Count > 0)
            {
                TuanGouList = new List<TuanGou>();
                foreach (goods m in data.goods)
                {
                    TuanGou tuanGou = new TuanGou();
                    tuanGou.CityID = Utils.CityToID(m.cityname);
                    tuanGou.Title = m.title;
                    tuanGou.ImageUrl = m.bigimg;
                    tuanGou.ImageThumbUrl = m.smallimg;
                    tuanGou.BeginTime = DateTime.Parse(m.begintime);
                    tuanGou.EndTime = DateTime.Parse(m.endtime);
                    tuanGou.MarketPrice = m.marketprice;
                    tuanGou.TuanPrice = m.groupprice;
                    tuanGou.Rebate = (float)Math.Round((tuanGou.TuanPrice / tuanGou.MarketPrice) * 10, 2);
                    tuanGou.BuyCount = m.buycount;
                    tuanGou.TuanUrl = m.url;
                    tuanGou.TuanDetail = m.brief;
                    tuanGou.MerchantName = m.suppliers;
                    tuanGou.AddDate = DateTime.Now;

                    TuanGouList.Add(tuanGou);
                }
            }
        }
    }

    [Serializable]
    [XmlRoot(ElementName = "response")]
    public class response : BaseApi<response>
    {
        [XmlElement(ElementName = "goods")]
        public List<goods> goods
        {
            get;
            set;
        }
    }

    [Serializable]
    public class goods
    {
        public string cityname
        {
            get;
            set;
        }

        public string title
        {
            get;
            set;
        }

        public string brief
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public decimal groupprice
        {
            get;
            set;
        }

        public decimal marketprice
        {
            get;
            set;
        }

        public string begintime
        {
            get;
            set;
        }

        public string endtime
        {
            get;
            set;
        }

        public string smallimg
        {
            get;
            set;
        }

        public string bigimg
        {
            get;
            set;
        }

        public string suppliers
        {
            get;
            set;
        }

        public int buycount
        {
            get;
            set;
        }
    }
}
