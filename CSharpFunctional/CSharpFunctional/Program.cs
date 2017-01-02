﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpFunctional
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<String> printstr = Console.WriteLine;
            Action<int> prinltln = Console.WriteLine;
            List<int> lst = new List<int>{ 1, 2, 3, 4, 5 };
            lst.ForEach(prinltln);

            printstr(""); printstr("");
            lst.FindAll(x => x > 3).ForEach(x => prinltln(x));

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
            {
               return x<4;
            })
            .ForEach(x =>
            {
                Console.WriteLine(x);
                });


            Console.WriteLine("...............");
            Console.ReadLine();
        }

        static void printAnInt(int n){
            Console.WriteLine(n);
        }
    }
}