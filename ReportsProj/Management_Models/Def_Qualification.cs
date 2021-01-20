using ReportsProj.PM_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.Management_Models
{
    public class Def_Qualification : _EntityBase
    {
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Description { get; set; } 
        public string DescriptionEn { get; set; } 
        public string AcademicGradeType { get; set; } 
        public string AcademicGradeTypeEn { get; set; }

    }
}
