using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ReportsProj.PM_Model;

namespace ReportsProj.Management_Models
{
    public class Def_University : _EntityBase 
    {

        [Required]
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string CountryTitle { get; set; }
        public string CountryTitleEn { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Social { get; set; }
        public string Ownership { get; set; }
    }
}
