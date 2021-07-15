using System;
using System.Collections.Generic;

namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        {

        }

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it)");
            var result = this._strategy.DoAlgorithm(new List<String> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach(var element in result as List<String>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
