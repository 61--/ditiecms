using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Tuan.Entity
{
    public class Model : Dictionary<string, string>
    {
        //private Dictionary<string, string> _model;

        //public Model()
        //{
        //    _model = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        //}
    }

    public class ModelList : Collection<Model>
    {
        //private IList<Model> _modelList = new List<Model>();

        public new int Count
        {
            get { return base.Count; }
        }

        public new void Add(Model model)
        {
            base.Add(model);
        }

        public new void Clear()
        {
            base.Clear();
        }

        public new Model this[int index]
        {
            get { return base[index]; }
        }

        #region 返回当前对象的迭代器

        //public IEnumerator<Model> GetEnumerator()
        //{
        //    return base.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return base.GetEnumerator();
        //}

        #endregion
    }
}
