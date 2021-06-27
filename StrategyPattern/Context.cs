using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Context
    {


        private IStategy _stategy;

        public Context()
        {

        }

        public Context(IStategy stategy)
        {
            this._stategy = stategy;
        }

        public void setStategy(IStategy stategy)
        {
            this._stategy = stategy;
        }

        public void DoSomeStategy()
        {
            Console.WriteLine("INICIANDO ESTRATEGIA");
            var result = this._stategy.DoStategy(new List<int> {1,2,3,4,5});
            string resultStr = string.Empty;
            foreach(var element in result as List<int>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);

        }



    }
}
