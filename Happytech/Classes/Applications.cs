using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happytech.Classes
{
    public class Applications
    {
        private int _applicationId;
        private string _name;
        private string _email;
        private string _position;
        private string _curriculum;

        public int ApplicationId
        {
            get => _applicationId;
            set => _applicationId = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string Position
        {
            get => _position;
            set => _position = value;
        }
        public string Curriculum
        {
            get => _curriculum;
            set => _curriculum = value;
        }

        public Applications() {}
    }
}
