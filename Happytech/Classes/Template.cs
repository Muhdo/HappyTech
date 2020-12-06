using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Happytech.Classes;
namespace HappyTech.Classes
{
    public class Template
    {
        public int TemplateId { get; set; }
        public string Name { get; set; }
        public int DesignedPositionId { get; set; }
        public List<Section> Sections { get; set; } = new List<Section>();

        public Template() {}
    }
}
