using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ProgramToWriteToFileInUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\DemoUnicode.txt";
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                try
                {
                    fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                }
                catch (IOException)
                {
                    Console.WriteLine("This file allready exists! Do you want to overwrite [y]/[Y])?");
                    ConsoleKeyInfo ki = Console.ReadKey(true);
                    if (ki.KeyChar == 'Y' || ki.KeyChar == 'y')
                    {
                        fs = new FileStream(path, FileMode.Truncate, FileAccess.Write);
                    }
                    else
                        return;
                }
                sw = new StreamWriter(fs, Encoding.Unicode);
                //sw.AutoFlush = true;  -> overhead problems

                while (true)
                {
                    int data = Console.Read();
                    if (data == '$')
                    {
                        break;
                    }
                    sw.Write((char)data);
                }
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
