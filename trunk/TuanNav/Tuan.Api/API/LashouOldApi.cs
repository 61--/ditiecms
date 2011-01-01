using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Tuan.Common;
using Tuan.Entity;

namespace Tuan.Api.LashouOld
{
    public class LashouOldApi
    {
        public IList<TuanGou> TuanGouList
        {
            get;
            private set;
        }

        public LashouOldApi(string apiUrl)
        {
            urlset data = new urlset().GetRemoteData(apiUrl);
            if (data.goods.Count > 0)
            {
                TuanGouList = new List<TuanGou>();
                foreach (goods m in data.goods)
                {
                    TuanGou tuanGou = new TuanGou();
                    tuanGou.CityID = Utils.CityToID(data.cityname);
                    tuanGou.Title = m.goods_title;
                    tuanGou.ImageUrl = m.goods_image_url;
                    tuanGou.ImageThumbUrl = m.goods_image_url;
                    tuanGou.BeginTime = TryConvert.ToDateTime(m.goods_start_time);
                    tuanGou.EndTime = TryConvert.ToDateTime(m.goods_deadline);
                    tuanGou.MarketPrice = m.goods_value;
                    tuanGou.TuanPrice = m.goods_price;
                    tuanGou.Rebate = m.goods_rebate;
                    tuanGou.BuyCount = m.goods_bought;
                    tuanGou.TuanUrl = m.goods_site_url;
                    tuanGou.Description = m.goods_rules;
                    tuanGou.TuanDetail = m.goods_description;
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
        public string cityname
        {
            get;
            set;
        }

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
        public string goods_title
        {
            get;
            set;
        }

        public string goods_rules
        {
            get;
            set;
        }

        public decimal goods_value
        {
            get;
            set;
        }

        public decimal goods_price
        {
            get;
            set;
        }

        public float goods_rebate
        {
            get;
            set;
        }

        public long goods_start_time
        {
            get;
            set;
        }

        public long goods_deadline
        {
            get;
            set;
        }

        public string goods_description
        {
            get;
            set;
        }

        public int goods_bought
        {
            get;
            set;
        }

        public int goods_max_bought
        {
            get;
            set;
        }

        public string goods_sp_name
        {
            get;
            set;
        }

        public string goods_phone
        {
            get;
            set;
        }

        public string goods_image_url
        {
            get;
            set;
        }

        public string goods_site_url
        {
            get;
            set;
        }
    }
}
