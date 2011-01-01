using System;
using System.Collections.Generic;
using System.Text;
using Tuan.Data.DAO;

namespace Tuan.Data.Provider
{
    public interface IDataProvider
    {
        T GetInstance<T>() where T : BaseDAO<T>;
    }
}
