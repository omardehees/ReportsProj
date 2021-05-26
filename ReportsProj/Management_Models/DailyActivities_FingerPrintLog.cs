using ReportsProj.PM_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.Management_Models
{
    public class DailyActivities_FingerPrintLog : _EntityBase
    {
        public int MachineNumber { get; set; }
        public string? MachineTitle { get; set; }
        public string? MachineTitleEn { get; set; } = "";
        public int? IndRegID { get; set; }
        public string? IndRegName { get; set; }
        public string? FullNameAr { get; set; }
        public string? Job { get; set; } = "";
        public string? JobPostionTree { get; set; } = "";
        public string? Department { get; set; } = "";
        public DateTime DateTimeRecord { get; set; }
        public string? TheType { get; set; }
        public DateTime DateOnlyRecord
        {
            get { return DateTime.Parse(DateTimeRecord.ToString("yyyy-MM-dd")); }
        }
        public DateTime TimeOnlyRecord
        {
            get { return DateTime.Parse(DateTimeRecord.ToString("hh:mm:ss tt")); }
        }

        public bool IsOffday { get; set; } = false;
        public bool AcceptedTimming { get; set; } = true;
        public int EarlyMinutes { get; set; } = 0;
        public int LateMinutes { get; set; } = 0;
    }
}
