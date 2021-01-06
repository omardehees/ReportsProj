using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ReportsProj.PM_Model;

namespace ReportsProj.PM_Model
{
    public class cCity:_EntityBase
    {
        [Required]
        public string Title { get; set; }
        public string TitleEn { get; set; }
        [Required]
        public string Country { get; set; }
        public string CountryEn { get; set; }
    }
}
