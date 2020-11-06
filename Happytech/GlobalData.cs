using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Happytech.Classes;

namespace Happytech
{
    class UserPages
    {
        public static string firstAction { get; set; }
    }

    public class CurrentEmployee
    {
        public static int Id;
        public static string Name;
        public static string Role;
        public static bool IsAdmin;

        public void SetEmployee(int id, string name, string role, bool isAdmin)
        {
            CurrentEmployee.Id = id;
            CurrentEmployee.Name = name;
            CurrentEmployee.Role = role;
            CurrentEmployee.IsAdmin = isAdmin;
        }
    }
}
