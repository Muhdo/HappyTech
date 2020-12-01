using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech.Classes
{
    public class Comment
    {
        private int _commentID;
        private string _shortName;
        private string _comment;

        public int CommentID
        {
            get => _commentID;
            set => _commentID = value;
        }
        public string ShortName
        {
            get => _shortName;
            set => _shortName = value;
        }
        public string CommentText
        {
            get => _comment;
            set => _comment = value;
        }

        public Comment() {}
    }
}
