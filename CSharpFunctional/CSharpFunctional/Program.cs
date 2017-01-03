using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpFunctional
{
    class Program
    {
        static void Main1(string[] args)
        {
            Action<String> printstr = Console.WriteLine;
            Action<int> prinltln = Console.WriteLine;
            List<int> lst = new List<int>{ 1, 2, 3, 4, 5 };
            lst.ForEach(prinltln);

            printstr(""); printstr("");
            lst.FindAll(x => x > 3).ForEach(x => prinltln(x));//lambdas and chaining of combinators

            printstr(""); printstr("");
            List<int> lst1 = lst.FindAll(x => x > 3);
            lst1.ForEach(prinltln);

            printstr("===================="); 
            lst.FindAll(x => x > 3).ForEach( x=>
                {
                    Console.WriteLine(x);
                });


            printstr(".........======.........."); 
            lst.FindAll(x =>
            {//Anonymous function/delegate (predicate) 
               return x<4;
            })
            .ForEach(x =>
            {//Anonymous function/delegate (action)
                Console.WriteLine(x);
                });


            Console.WriteLine("...............");
            filterOdd(lst, x => x % 2 == 0).ForEach(prinltln);//passing function as argument
            Console.ReadLine();
        }

        static void printAnInt(int n){
            Console.WriteLine(n);
        }

        static List<int> filterOdd(List<int> input, Predicate<int> condition) {
            // condition is a delegate instance here or reference to a function in other owrds
            return input.FindAll(condition);
        }
    }
}
