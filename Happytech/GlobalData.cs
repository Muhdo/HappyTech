using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Happytech
{
    class UserPages
    {
        public static string firstAction { get; set; }
    }

    class Employee
    {
        public static int id;
        public static string name;
        public static string role;

        public void SetEmployee(int id, string name, string role)
        {
            Employee.id = id;
            Employee.name = name;
            Employee.role = role;
        }
    }
}
