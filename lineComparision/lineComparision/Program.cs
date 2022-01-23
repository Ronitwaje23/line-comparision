using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lineComparision-comparision");
            LineComparison l =new LineComparison();
            l.length_line();
            l.function_check();
            Console.ReadLine();

        }
    }
}

