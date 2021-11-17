using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNoProgramUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 Type of Variable where given and will be compared with each other to show the Maximum Number.");
            Console.WriteLine("-------------------------------------------------------------------------------------------");

            Console.WriteLine("Integer");
            new CompareNo<int>(82, 54, 23).testMax(82, 54, 23);
            Console.WriteLine("Float");
            new CompareNo<double>(22.1, 23.2, 22.3).testMax(22.1, 23.2, 22.3);
            Console.WriteLine("Char");
            new CompareNo<char>('B', 'J', 'T').testMax('B', 'J', 'T');
        }
    }
}
