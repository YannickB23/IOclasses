using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ProgramToReadFromFileAnyEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Temp\Demo.txt";
            //string path1 = @"C:\Temp\DemoDemo.txt";   //catch gaat dit opvangen -> file bestaat niet
            FileStream fs = null;
            StreamReader sr = null; ;
            int count = 0;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
                sr = new StreamReader(fs);
                while (true)
                {
                    int data = sr.Read();
                    if (data != 32)
                    {
                        count++;
                    }
                    if (data == -1)
                    {
                        break;
                    }
                    Console.Write((char)data);
                }
                Console.WriteLine("\n");
                Console.WriteLine($"Total chars in txt = {count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                if (sr != null)
                {
                    sr.Close();
                }
            }     
        }
    }
}
