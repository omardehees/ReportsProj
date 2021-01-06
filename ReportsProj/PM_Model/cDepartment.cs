using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using ReportsProj.PM_Model;

namespace ReportsProj.PM_Model
{
    public class cDepartment:_EntityBase
    {
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public Guid Code { get; set; }
        public string Branch { get; set; }             
        public string AvailableApplications { get; set; }
        public string AvailableJobs { get; set; }
        public string AvailableGroups { get; set; }
        public string AvailableResponsibilities { get; set; }  
    }
}
