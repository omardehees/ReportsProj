using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ReportsProj.PM_Model;

namespace ReportsProj.Management_Models
{
    public class Def_City : _EntityBase 
    {
        [Required]
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string StateTitle { get; set; }
        public string StateTitleEn { get; set; }
        public string CountryTitle { get; set; }
        public string CountryTitleEn { get; set; }
    }
}
