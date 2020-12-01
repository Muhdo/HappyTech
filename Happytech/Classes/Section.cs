using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech.Classes
{
    public class Section
    {
        private int _sectionID;
        private int _title;
        private List<Comment> _comments = new List<Comment>();

        public int SectionID
        {
            get => _sectionID;
            set => _sectionID = value;
        }
        public int Title
        {
            get => _title;
            set => _title = value;
        }
        public List<Comment> Comments
        {
            get => _comments;
            set => _comments = value;
        }

        public Section() { }
    }
}
