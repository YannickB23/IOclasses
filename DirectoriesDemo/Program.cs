using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoriesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sample 1
            /*gebruikmakend van de class Directory*/
            //try
            //{
            //    string[] directories = Directory.GetDirectories(@"C:\Temp");
            //    for (int i = 0; i < directories.Length; i++)
            //    {
            //        Console.WriteLine(directories[i]);
            //        Directory.CreateDirectory(directories[i] + @"\submap");
            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Problem occurred! " + e.Message);
            //}

            /*gebruikmakend van de class DirectoryInfo*/
            //DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\temp");
            //DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
            //for (int i = 0; i < subDirectories.Length; i++)
            //{
            //    Console.WriteLine(subDirectories[i].FullName);
            //    subDirectories[i].CreateSubdirectory("submap2");
            //}
            #endregion

            #region Sample 2
            ////string path = @"C:\Temp\sub1";
            //string path = @"C:\Temp\sub2";
            //string[] directories = Directory.GetDirectories(path);
            //foreach (var item in directories)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("********");
            //DirectoryInfo directoryInfo = new DirectoryInfo(path);
            //DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
            //foreach (var item in subDirectories)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Sample 3
            string path = @"C:\Temp";
            string[] directories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (var item in directories)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}