﻿using System;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var element = int.Parse(Console.ReadLine());
                var box = new Box<int>(element);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
