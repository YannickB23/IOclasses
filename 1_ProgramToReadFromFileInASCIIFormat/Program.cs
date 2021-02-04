using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ProgramToReadFromFileInASCIIFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\Demo.txt";
            StreamReader sr;
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
                sr = new StreamReader(fs, Encoding.ASCII, true);
                int count = 0;

                #region read char per char
                while (true)
                {
                    int data = fs.ReadByte();

                    //search and count how many times 'q' in the file
                    if (data == 113)    //113 = decimal value of q
                    {
                        //Console.Write("***"); //zorgt voor meer duidelijkheid waar de q staat
                        count++;
                    }

                    if (data == -1)
                    {
                        break;
                    }
                    Console.Write((char)data);  //this works good with ASCII encoding
                }
                Console.WriteLine($"\n\nThere are {count} q's in the file.");
                #endregion
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }

            Console.ReadLine();
        }
    }
}
