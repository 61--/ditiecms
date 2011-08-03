using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class GoodsEntity
    {
        //商品通用属性
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }
        private string m_Title;

        public string Status
        {
            get { return m_Status; }
            set { m_Status = value; }
        }
        private string m_Status;

        public double Price
        {
            get { return m_Price; }
            set { m_Price = value; }
        }
        private double m_Price;

        public int Stock
        {
            get { return m_Stock; }
            set { m_Stock = value; }
        }
        private int m_Stock;

        public DateTime StartTime
        {
            get { return m_StartTime; }
            set { m_StartTime = value; }
        }
        private DateTime m_StartTime;
    }
}
