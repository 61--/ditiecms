using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.IDAL
{
    public interface IDALBase<T>
    {
        int Add(T entity);
        bool Update(T entity);

    }
}
