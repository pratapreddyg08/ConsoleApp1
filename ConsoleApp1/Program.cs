﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static  void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello World");
            Console.WriteLine("I am Pratap From bangalore");
            p.Display();
            Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("This is a Display method added newly");
        }
    }
}
