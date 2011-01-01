using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Tuan.Common;
using Tuan.Entity;

namespace Tuan.Api.Sohu
{
    public class SohuApi
    {
        public IList<TuanGou> TuanGouList
        {
            get;
            private set;
        }

        public SohuApi(string apiUrl)
        {
            ActivitySet data = new ActivitySet().GetRemoteData(apiUrl);
            if (data.Activity.Count > 0)
            {
                TuanGouList = new List<TuanGou>();
                foreach (Activity m in data.Activity)
                {
                    TuanGou tuanGou = new TuanGou();
                    tuanGou.CityID = Utils.CityToID(m.CityName);
                    tuanGou.Title = m.Title;
                    tuanGou.ImageUrl = m.ImageUrl;
                    tuanGou.ImageThumbUrl = m.ImageUrl;
                    tuanGou.BeginTime = DateTime.ParseExact(m.StartTime, "yyyyMMddhhmmss", System.Globalization.CultureInfo.CurrentCulture);
                    tuanGou.EndTime = DateTime.ParseExact(m.EndTime, "yyyyMMddhhmmss", System.Globalization.CultureInfo.CurrentCulture);
                    tuanGou.MarketPrice = m.Value;
                    tuanGou.TuanPrice = m.Price;
                    tuanGou.Rebate = m.ReBate;
                    tuanGou.TotalCount = m.Quantity;
                    tuanGou.BuyCount = m.Bought;
                    tuanGou.TuanUrl = m.Url;
                    tuanGou.Description = m.Description;
                    tuanGou.TuanDetail = m.Goods.Description;
                    tuanGou.MerchantName = m.Goods.ProviderName;
                    tuanGou.MerchantPhone = m.Goods.Contact;
                    tuanGou.MerchantAddress = m.Goods.Address;
                    tuanGou.AddDate = DateTime.Now;

                    TuanGouList.Add(tuanGou);
                }
            }
        }
    }

    [Serializable]
    [XmlRoot(ElementName = "ActivitySet")]
    public class ActivitySet : BaseApi<ActivitySet>
    {
        [XmlElement(ElementName = "Activity")]
        public List<Activity> Activity
        {
            get;
            set;
        }
    }

    [Serializable]
    public class Activity
    {
        public string Title
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string ImageUrl
        {
            get;
            set;
        }

        public string CityName
        {
            get;
            set;
        }

        public string AreaCode
        {
            get;
            set;
        }

        public decimal Value
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public float ReBate
        {
            get;
            set;
        }

        public string StartTime
        {
            get;
            set;
        }

        public string EndTime
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public int Bought
        {
            get;
            set;
        }

        [XmlElement(ElementName = "Goods")]
        public Goods Goods
        {
            get;
            set;
        }
    }

    [Serializable]
    public class Goods
    {
        public string ProviderName
        {
            get;
            set;
        }

        public string Contact
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }
    }
}
