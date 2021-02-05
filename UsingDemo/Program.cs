using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Write to File with Using

            //string strToBeWritten = "Hello World. Using statement!";
            //FileStream fs = new FileStream(@"C:\Temp\dummy.txt", FileMode.Create, FileAccess.Write);
            //using (StreamWriter sw = new StreamWriter(fs))
            //{
            //    sw.Write(strToBeWritten);
            //}

            #endregion

            #region Read from File with Using

            //string data;
            //FileStream fs = new FileStream(@"C:\Temp\dummy.txt", FileMode.Open, FileAccess.Read);
            //using (StreamReader sr = new StreamReader(fs))
            //{
            //    data = sr.ReadToEnd();
            //}
            //Console.WriteLine(data);

            #endregion

            #region Problematic Reading

            FileStream fs = new FileStream(@"C:\Temp\dummy.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            fs.Close();

            FileStream fs1 = new FileStream(@"C:\Temp\dummy.txt", FileMode.Open);

            #endregion
        }
    }
}
