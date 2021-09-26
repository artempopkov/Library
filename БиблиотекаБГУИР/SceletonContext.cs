using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БиблиотекаБГУИР
{
    class SceletonContext
    {
        private static readonly Library instance = new Library();

        static SceletonContext() { }

        private SceletonContext() { }

        public static Library Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
