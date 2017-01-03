using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpFunctional
{
    public class LinqOperators
    {
        static void Main(string[] args)
        {
            LinqOperators o = new LinqOperators();

            o.getFilteredStrings().ToList().ForEach(x =>
            {
                Console.WriteLine(x);
                return ;
            });

            o.getFilteredStrings().Select(x =>
            {
                Console.WriteLine(x);//select is called for each element like forEach but returns a collection
                return x+"12";
            }).ToList().ForEach(Console.WriteLine);

            Console.ReadKey();
        }
        public IEnumerable<string> getFilteredStrings()
        {
            string[] words = { "zero", "one", "two", "three", "four" };
            List<string> words2 =new List<string> { "zero", "one", "two", "three", "four" };
            var retVal = words.Select(w => w.Substring(1));
            return retVal;
        }
    }
}
