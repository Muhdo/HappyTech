using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happytech.Classes
{
    public class Employee
    {
        private int _id;
        private string _name;
        private string _role;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Role
        {
            get => _role;
            set => _role = value;
        }

        public Employee() {}
    }
}
