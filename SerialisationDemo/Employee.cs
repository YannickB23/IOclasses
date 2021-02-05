using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationDemo
{
    [Serializable()]    //attribute
    public class Employee
    {
        [NonSerialized()]
        public int Id;
        /*public int Id { get; set; }*/
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public Employee(int id, string name, string type, bool isActive)
        {
            Id = id;
            Name = name;
            Type = type;
            IsActive = isActive;
        }
    }
}
