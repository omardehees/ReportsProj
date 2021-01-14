using System;
using System.Collections.Generic;
using ReportsProj.PM_Model;

namespace ReportsProj.Management_Models
{
    public class Def_BusinessSector : _EntityBase
    {
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Group { get; set; }
        public string GroupEn { get; set; }
        public string Description { get; set; }
    }
}
