using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteData();
            //ReadDataInOneGo();
            //ReadDataLineByLineInLoop();

            Console.WriteLine("Enter your name pls");
            string name = Console.ReadLine();
            WriteData(name);

            Console.ReadLine();
        }
        public static void WriteData(string content)
        {
            FileStream fileStream = new FileStream(@"C:\Temp\Name.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            //streamWriter.WriteLine("Hello, welcome to files in Csharp.");
            streamWriter.Write(content);

            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }
        public static void ReadDataInOneGo()
        {
            FileStream fs = new FileStream(@"C:\Temp\DemoWrite.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            sr.BaseStream.Seek(36, SeekOrigin.Begin);
            //sr.BaseStream.Seek(-100, SeekOrigin.End);

            string content = sr.ReadToEnd();
            Console.WriteLine(content);
            sr.Close();
            fs.Close();
        }
        public static void ReadDataLineByLineInLoop()
        {
            FileStream fs = new FileStream(@"C:\Temp\DemoWrite.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string content = string.Empty;

            while (!sr.EndOfStream)
            {
                content = sr.ReadLine();
                Console.WriteLine(content);
            }
            sr.Close();
            fs.Close();
        }
    }
}
