using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happytech.Classes
{
    public class Role
    {
        private int _id;
        private string _role;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string RoleName
        {
            get => _role;
            set => _role = value;
        }

        public Role() {}
    }
}
