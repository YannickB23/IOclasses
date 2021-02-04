using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ProgramToWriteToFileInASCIIFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\DemoToWrite.txt";
            FileStream fs = null;

            try
            {
                try
                {
                    fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                }
                catch (IOException)
                {
                    Console.WriteLine("This file allready exists! Do you want to overwrite [y]/[Y]?");
                    ConsoleKeyInfo ki = Console.ReadKey(true);
                    if (ki.KeyChar == 'Y' || ki.KeyChar == 'y')
                    {
                        fs = new FileStream(path, FileMode.Truncate, FileAccess.Write);
                    }
                    else
                        return;
                }             
                while (true)
                {
                    int data = Console.Read();
                    if (data == '$')
                    {
                        break;
                    }
                    fs.WriteByte((byte)data);
                }
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
