using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_Demo
{
    public delegate void PrintDelgate(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            var hello = new Hello();
            PrintDelgate del = new PrintDelgate(hello.PrintHello);
            del("Hello I am called from delegate!!");
        }
    }

    class Hello
    {        
        public void PrintHello(string text)
        {
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
