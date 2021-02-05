using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteBinaryFile();
            ReadBinaryFile();
        }
        static void WriteBinaryFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(@"C:\Temp\binaryFile.bin", FileMode.Create)))
            {
                writer.Write(202.55M);
                writer.Write(2.75d);
                writer.Write("Yannick");
                writer.Write(true);
                writer.Write(1904);
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(@"C:\Temp\binaryFile.bin", FileMode.Open)))
            {
                Console.WriteLine($"Decimal value: {reader.ReadDecimal()}");
                Console.WriteLine($"Double value: {reader.ReadDouble()}");
                Console.WriteLine($"String value: {reader.ReadString()}");
                Console.WriteLine($"Decimal value: {reader.ReadBoolean()}");
                Console.WriteLine($"Decimal value: {reader.ReadInt32()}");
            }
        }
    }
}
