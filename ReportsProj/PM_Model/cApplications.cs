using System;
using System.Collections.Generic;
using ReportsProj.PM_Model;

namespace ReportsProj.PM_Model
{
    public class cApplications : _EntityBase
    {
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public Guid Code { get; set; }
        public string Description { get; set; }
        public int ConcurrentUsers { get; set; }
        public bool ConcurrentLogin { get; set; }
        public DateTime LisenceFrom { get; set; }
        public DateTime LisenceTo { get; set; }
        public string Users { get; set; }
        public string IPs { get; set; }
        public string Machines { get; set; }
        public string HWFP { get; set; }
        public string Jobs { get; set; }
        public string Groups { get; set; }
        public string Responsibilities { get; set; }
    }
}
