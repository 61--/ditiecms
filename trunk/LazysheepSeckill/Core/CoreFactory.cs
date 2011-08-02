using System;

namespace Core
{
    public class CoreFactory
    {
        private static ICore _instance;
        private static object lockHelper = new object();

        public static ICore GetInstance()
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    _instance = new TaobaoCore();
                }
            }
            return _instance;
        }
    }
}
