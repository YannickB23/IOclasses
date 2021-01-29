using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] myDryves = DriveInfo.GetDrives();
            foreach (DriveInfo item in myDryves)
            {
                Console.WriteLine($"Drive name: {item.Name}");
                Console.WriteLine($"Drive type: {item.DriveType}");
                Console.WriteLine($"Root directory: {item.RootDirectory}");
                Console.WriteLine($"Total size (in bytes): {item.TotalSize}");
                Console.WriteLine($"Available free space (in bytes): {item.AvailableFreeSpace}");  //kan opgelegt worden door admin
                Console.WriteLine($"Total free space (in bytes): {item.TotalFreeSpace}");
                Console.WriteLine($"Volume label: {item.VolumeLabel}");
                Console.WriteLine($"Is ready: {item.IsReady}");
            }


            Console.ReadLine();
        }
    }
}
