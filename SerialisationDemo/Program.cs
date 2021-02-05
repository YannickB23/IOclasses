using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(25, "Yannick",  "Fulltime employee", true));
            employees.Add(new Employee(31, "Toon", "Parttime employee", true));
            employees.Add(new Employee(08, "Jarno", "Parttime employee", true));
            employees.Add(new Employee(44, "Emre", "Fulltime employee", true));

            Console.WriteLine("Start writing data...");
            using (Stream stream = File.Open("data.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, employees);
            }
            Console.WriteLine("Start reading data...");

            using (Stream stream = File.Open("data.bin", FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();
               var employeesList = (List<Employee>)bin.Deserialize(stream);
                foreach (var item in employeesList)
                {
                    Console.WriteLine($"*{item.Name}, {item.Type}, {item.IsActive}");
                }
            }

            Console.ReadLine();
        }
    }
}
