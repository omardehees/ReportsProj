using ReportsProj.PM_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.Management_Models
{
    public class DailyActivities_VacationRequest : _EntityBase
    {
        public Guid Code { get; set; }
        public Guid EmployeeCode { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Job { get; set; }
        public string JobTreePosition { get; set; }
        public string JobDescription { get; set; }
        public string DirectBoss { get; set; }
        public string Peers { get; set; }
        public string RequestType { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public string Urgency { get; set; }
        public DateTime RequestFromDate { get; set; }
        public DateTime RequestToDate { get; set; }
        public string IssuedBy { get; set; }
        public DateTime IssuedAt { get; set; } = DateTime.Now;
        public string TheUser { get; set; }
        public string Status { get; set; }
        public string StatusBy { get; set; }
        public DateTime StatusAt { get; set; } = DateTime.Now;
        public string StatusNotes { get; set; } = "";
    }

}
