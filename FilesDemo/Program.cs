using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Copy file
            //File.Copy(@"C:\Temp\demo.txt", @"C:\Temp\demo1.txt");
            //File.Copy(@"C:\Temp\demo.txt", @"C:\Temp\sub1\demo.txt");
            //Console.WriteLine("File copied");
            #endregion

            #region Move file
            //File.Move(@"C:\Temp\demo1.txt", @"C:\Temp\sub2\demo1.txt");
            //Console.WriteLine("File moved");
            #endregion

            #region Create file
            //File.Create(@"C:\Temp\demodelete.txt");
            //Console.WriteLine("File created");
            #endregion

            #region Delete file
            //File.Delete(@"C:\Temp\demodelete.txt");
            //Console.WriteLine("File deleted");
            #endregion

            //FileInfo file = new FileInfo(@"C:\Temp\demo.txt");
            //file.CopyTo(@"C:\Temp\sub3\demo.txt");
            //Console.WriteLine("File copied");

            //FileInfo file = new FileInfo(@"C:\Temp\sub3\demo.txt");
            //file.Delete();
            //Console.WriteLine("File deleted");

            //FileInfo file = new FileInfo(@"C:\Temp\sub3\demo.txt");
            //file.MoveTo(@"C:\Temp\sub2\demo.txt");
            //Console.WriteLine("File moved");

            FileInfo file = new FileInfo(@"C:\Temp\sub3\demo3.txt");
            //file.Create();
            //var time = File.GetCreationTime(@"C:\Temp\sub3\demo3.txt");
            //Console.WriteLine(time);
            var fileSize = file.Length;
            Console.WriteLine($"File size: {fileSize} kb");
            Console.WriteLine($"\nFullname: {file.FullName}");

            Console.ReadLine();
        }
    }
}
