using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ReportsProj.PM_Model
{
    public class cCountry :_EntityBase 
    {
        [Required]
        public string Title { get; set; }
        public string TitleEn { get; set; }     
    }
}
