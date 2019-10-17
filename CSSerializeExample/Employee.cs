using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSerializeExample
{
    public class Employee
    {
        public int Id = 1;
        public String name = "John Smith";
        public string subject = "Physics";
        public List<int> list = new List<int>() { 10, 20, 30 };
    }
}
