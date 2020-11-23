using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportsProj.PM_Model
{
    public class cEmployeeJob : _EntityBase
    {
        [Required]
        public string  Title { get; set; }
        public string TitleEn { get; set; }
        public Guid Code { get; set; }
        public string Action { get; set; }
    }
}
