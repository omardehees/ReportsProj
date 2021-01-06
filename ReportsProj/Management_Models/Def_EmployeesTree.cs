using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ReportsProj.PM_Model;

namespace ReportsProj.Management_Models
{
    public class Def_EmployeesTree
    {
        public int Id { get; set; }        
        public string Code { get; set; }
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string TheType { get; set; }
        public string JobDecription { get; set; }
        public string ParentCode { get; set; }
        public string TitleParentAr { get; set; }
        public string TitleParentEn { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDefault { get; set; }
        public string Notes { get; set; }
        public string Company { get; set; }
    }
}
