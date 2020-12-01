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
        private int _templateID;
        private string _name;
        private int _designedPositionID;
        private List<Section> _sections = new List<Section>();

        public int TemplateID
        {
            get => _templateID;
            set => _templateID = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int DesignedPositionID
        {
            get => _designedPositionID;
            set => _designedPositionID = value;
        }
        public List<Section> Sections
        {
            get => _sections;
            set => _sections = value;
        }

        public Template() {}
    }
}
