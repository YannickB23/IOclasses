using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string drive = "c:";
            //Console.WriteLine(Path.Combine(drive, "demo.txt"));

            Console.WriteLine(Path.Combine("c:", "demo.txt"));
            Console.WriteLine(Path.Combine(@"c:\", "demo.txt"));
            Console.WriteLine(Path.Combine(@"c:\temp", "demo.txt"));
            Console.WriteLine(Path.Combine(@"c:\temp", @"demo.txt"));
            Console.WriteLine(Path.Combine(@"c:\temp\", "demo.txt"));
            Console.WriteLine(Path.Combine(@"c:\temp\", @"demo.txt"));

            //string part1 = @"c:\temp\";
            //string part2 = @"demo.txt";
            //Console.WriteLine(part1 + part2);


            Console.ReadLine();
        }
    }
}
