using ReportsProj.PM_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ReportsProj.Management_Models
{
    public class Def_AcademicGradeType : _EntityBase 
    {
        [Required]
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Description { get; set; }
    }
}
