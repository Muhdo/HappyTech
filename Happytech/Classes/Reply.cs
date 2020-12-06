using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech.Classes
{
    public class Reply
    {
        public int ApplicationId { get; set; }
        public int TemplateId { get; set; }
        public List<int> CommentIds { get; set; }

        public Reply() {}
    }
}
