using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech.Classes
{
    public class Section
    {
        public int SectionId { get; set; }
        public string Title { get; set; }
        public List<Comment> Comments { get; set; }

        public Section() { }
    }
}
