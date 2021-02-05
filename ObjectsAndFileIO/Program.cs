using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "employee.txt";

            List<Employee> listOfEmployees = new List<Employee>();
            Employee e1 = new Employee { Id = 25, FirstName = "Yannick", LastName = "Beterams", Age = 31, Salary = 3571.90M };
            Employee e2 = new Employee { Id = 97, FirstName = "Patrick", LastName = "Ewing", Age = 60, Salary = 3119.77M };
            Employee e3 = new Employee { Id = 123, FirstName = "Chris", LastName = "Webber", Age = 37, Salary = 2571.90M };
            Employee e4 = new Employee { Id = 03, FirstName = "Bob", LastName = "Cousy", Age = 25, Salary = 2465.30M };

            listOfEmployees.Add(e1); listOfEmployees.Add(e2); listOfEmployees.Add(e3); listOfEmployees.Add(e4);

            WriteToFile(listOfEmployees, path);
            List<Employee> list1 = ReadFromFile(path);
            foreach (var item in list1)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Salary);
            }

        }
        public static void WriteToFile(List<Employee> listOfEmployees, string path)
        {
            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < listOfEmployees.Count; i++)
            {
                sw.WriteLine(listOfEmployees[i].Id);
                sw.WriteLine(listOfEmployees[i].FirstName);
                sw.WriteLine(listOfEmployees[i].LastName);
                sw.WriteLine(listOfEmployees[i].Age);
                sw.WriteLine(listOfEmployees[i].Salary);
            }
            sw.Close();
        }
        public static List<Employee> ReadFromFile(string path)
        {
            List<Employee> list = new List<Employee>();
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                var e = new Employee();

                e.Id = Convert.ToInt32(sr.ReadLine());
                e.FirstName = sr.ReadLine();
                e.LastName = sr.ReadLine();
                e.Age = Convert.ToInt32(sr.ReadLine());
                e.Salary = Convert.ToDecimal(sr.ReadLine());
                list.Add(e);
            }
                return list;
        }
    }
}
