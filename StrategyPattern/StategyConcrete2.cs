using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class StategyConcrete2 : IStategy
    {
        public object DoStategy(object data)
        {
            var list = data as List<int>;
            list.Sort();
            list.Reverse();
            return list;
        }
    }
}
