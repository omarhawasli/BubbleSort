using System;
using System.Collections.Generic;
using static Bublesort.MyFunction;

namespace Bublesort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(4);
            list.Add(5);
            list.Add(2);
            list.Add(1);
            list.Add(3);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            MyFunction.MyFunc(list);
            
            Console.WriteLine("after sorting");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}