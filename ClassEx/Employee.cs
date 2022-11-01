using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx
{
    public class Employee
    {
        public string? EmpName { get; set; }
        public string GetEmployee()
        {
            return EmpName;
        }

        public void SetEmployee(string _empName)
        {
            EmpName = _empName;
        }
    }
}
