using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValue
{
    public class Organization
    {
        public Organization()
        {
            Employees = new List<Employee>();
        }
        public List<Employee> Employees { get; set; }
    }
}
