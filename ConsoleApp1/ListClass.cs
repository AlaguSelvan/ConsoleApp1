﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class ListClass
    {
        public static void List()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 4, 5, 6 });
            numbers.Add(1);
            numbers.Add(2);
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));
            Console.WriteLine("Last Index of 2: " + numbers.LastIndexOf(2));
            Console.WriteLine("Count: " + numbers.Count);
            numbers.Remove(1);
            for(var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
/*            foreach (var number in numbers)
                if (number == 1)
                    numbers.Remove(number);*/
            Console.WriteLine("Count second: " + numbers.Count);
            numbers.Clear();
            Console.WriteLine("Count Last: " + numbers.Count);
        }
    }
}
