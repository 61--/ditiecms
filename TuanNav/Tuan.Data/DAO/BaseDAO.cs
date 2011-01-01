using System;
using System.Collections.Generic;
using System.Text;
using Tuan.Data.Provider;

namespace Tuan.Data.DAO
{
    public abstract class BaseDAO<T> where T : BaseDAO<T>
    {
        public static T Instance
        {
            get { return DbProviderFactory.Create().GetInstance<T>(); }
        }
    }
}
