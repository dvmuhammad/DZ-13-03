using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqq
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Задания 1:");       
            Revers();

            Console.WriteLine("Задания 2:"); 
            Suma();

            Console.WriteLine("Задания 3:");
            Sort();

            Console.WriteLine("Задания 4:");
            Unic();
            
        }

        static void Revers()
        {
            int[] arr = new int[6];
            
            Console.WriteLine("Введите шесть чисел");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(">", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            var orderedn = from i in arr
                                select i;
            foreach (int i in orderedn.Reverse())
                Console.WriteLine(i);
        }

        static void Suma()
        {
            int[] arr = {1,2,3,4,5,6,7,8,9,10,-11,-12,-13,-14,-15};
            
            int[] array = {arr.Where(p => p > 0).Count(), arr.Where(p => p < 0).Sum()};
            
            foreach(var p in array)
                Console.WriteLine(p);
        }

        static void Sort()
        {
            string[] arr = {"Telescopes", "Glasses", "Eyes", "Monocles"};
            
            foreach(var p in arr.OrderBy(p => p.Length))
                Console.WriteLine(p);
        }

        static void Unic()
        {
            int[] arr = {1,1,1,2,1,1};
            var n = arr.GroupBy(p => p).Where(p => p.Count() == 1).Select(p => p.Key);
            foreach(var p in n)
                Console.WriteLine(p);
        }

    }
}
