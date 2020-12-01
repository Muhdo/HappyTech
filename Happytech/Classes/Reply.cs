using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech.Classes
{
    public class Reply
    {
        private int _applicationId;
        private int _templateId;
        private List<Section> _commentSection = new List<Section>();

        public int ApplicationId
        {
            get => _applicationId;
            set => _applicationId = value;
        }
        public int TemplateId
        {
            get => _templateId;
            set => _templateId = value;
        }
        public List<Section> CommentSection
        {
            get => _commentSection;
            set => _commentSection = value;
        }

        public Reply() {}
    }
}
