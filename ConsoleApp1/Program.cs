using System;
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
            p.Read();
            p.Write();
            Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("This is a Display method added newly");
        }
        public void Read()
        {
            Console.WriteLine("This is a Read Method");
        }
        public void Write()
            {
            Console.WriteLine("This is a Write Method");
        }
    }
}
