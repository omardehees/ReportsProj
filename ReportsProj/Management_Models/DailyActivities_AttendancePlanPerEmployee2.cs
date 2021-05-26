using ReportsProj.PM_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.Management_Models
{
    public class DailyActivities_AttendancePlanPerEmployee2 : _EntityBase
    {
        //about Employee
        public Guid EmployeeCode { get; set; }
        public string FullNameAr { get; set; }
        public string FullNameEn { get; set; } = "";
        public string EmployeeId { get; set; }
        public string JobTreePosition { get; set; } = "";
        public string Department { get; set; } = "";
        public string DepartmentEn { get; set; } = "";
        public string Job { get; set; } = "";
        //about plan
        public string AttendancePlanTitleAr { get; set; } = "";
        public string AttendancePlanTitleEn { get; set; } = "";
        public string AttendancePlanType { get; set; } = "";
        public int BreakMinutes { get; set; } = 0;
        public int FlixableMinutes { get; set; } = 0;
        public int FingerprintEarlyMinutes { get; set; } = 0;
        public int FingerprintLateMinutes { get; set; } = 0;
        //Notes
        public string IssuedBy { get; set; } = "";
        public DateTime IssuedAt { get; set; } = DateTime.Now;
        public string IssuedNotes { get; set; } = "";
        public string EditedBy { get; set; } = "";
        public DateTime? EditedAt { get; set; }
        public string EditedNotes { get; set; } = "";
        public string DeletedBy { get; set; } = "";
        public DateTime? DeletedAt { get; set; }
        public string DeletedNotes { get; set; } = "";
        //about timming
        public DateTime AttendanceDate { get; set; }
        //In
        public DateTime InDateTime { get; set; }
        public DateTime? InFingerprintDateTime { get; set; }
        public int InFingerPrintShift { get; set; } = 0;
        public string InMachineFingerPrintTitle { get; set; } = "";
        //Out
        public DateTime OutDateTime { get; set; }
        public DateTime? OutFingerprintDateTime { get; set; }
        public int OutFingerPrintShift { get; set; } = 0;
        public string OutMachineFingerPrintTitle { get; set; } = "";
        //Status
        public string FingerPrintStatus { get; set; } = "";
        public TimeSpan AttendancePeriod { get; set; }
        //visual span
        public string H05_00 { get; set; } = "";
        public string H05_15 { get; set; } = "";
        public string H05_30 { get; set; } = "";
        public string H05_45 { get; set; } = "";

        public string H06_00 { get; set; } = "";
        public string H06_15 { get; set; } = "";
        public string H06_30 { get; set; } = "";
        public string H06_45 { get; set; } = "";

        public string H07_00 { get; set; } = "";
        public string H07_15 { get; set; } = "";
        public string H07_30 { get; set; } = "";
        public string H07_45 { get; set; } = "";

        public string H08_00 { get; set; } = "";
        public string H08_15 { get; set; } = "";
        public string H08_30 { get; set; } = "";
        public string H08_45 { get; set; } = "";

        public string H09_00 { get; set; } = "";
        public string H09_15 { get; set; } = "";
        public string H09_30 { get; set; } = "";
        public string H09_45 { get; set; } = "";

        public string H10_00 { get; set; } = "";
        public string H10_15 { get; set; } = "";
        public string H10_30 { get; set; } = "";
        public string H10_45 { get; set; } = "";

        public string H11_00 { get; set; } = "";
        public string H11_15 { get; set; } = "";
        public string H11_30 { get; set; } = "";
        public string H11_45 { get; set; } = "";

        public string H12_00 { get; set; } = "";
        public string H12_15 { get; set; } = "";
        public string H12_30 { get; set; } = "";
        public string H12_45 { get; set; } = "";

        public string H13_00 { get; set; } = "";
        public string H13_15 { get; set; } = "";
        public string H13_30 { get; set; } = "";
        public string H13_45 { get; set; } = "";

        public string H14_00 { get; set; } = "";
        public string H14_15 { get; set; } = "";
        public string H14_30 { get; set; } = "";
        public string H14_45 { get; set; } = "";

        public string H15_00 { get; set; } = "";
        public string H15_15 { get; set; } = "";
        public string H15_30 { get; set; } = "";
        public string H15_45 { get; set; } = "";

        public string H16_00 { get; set; } = "";
        public string H16_15 { get; set; } = "";
        public string H16_30 { get; set; } = "";
        public string H16_45 { get; set; } = "";

        public string H17_00 { get; set; } = "";
        public string H17_15 { get; set; } = "";
        public string H17_30 { get; set; } = "";
        public string H17_45 { get; set; } = "";

        public string H18_00 { get; set; } = "";
        public string H18_15 { get; set; } = "";
        public string H18_30 { get; set; } = "";
        public string H18_45 { get; set; } = "";

        public string H19_00 { get; set; } = "";
        public string H19_15 { get; set; } = "";
        public string H19_30 { get; set; } = "";
        public string H19_45 { get; set; } = "";

        public string H20_00 { get; set; } = "";
        public string H20_15 { get; set; } = "";
        public string H20_30 { get; set; } = "";
        public string H20_45 { get; set; } = "";

        public string H21_00 { get; set; } = "";
        public string H21_15 { get; set; } = "";
        public string H21_30 { get; set; } = "";
        public string H21_45 { get; set; } = "";

        public string H22_00 { get; set; } = "";
        public string H22_15 { get; set; } = "";
        public string H22_30 { get; set; } = "";
        public string H22_45 { get; set; } = "";

        public string H23_00 { get; set; } = "";
        public string H23_15 { get; set; } = "";
        public string H23_30 { get; set; } = "";
        public string H23_45 { get; set; } = "";

        public string H00_00 { get; set; } = "";
        public string H00_15 { get; set; } = "";
        public string H00_30 { get; set; } = "";
        public string H00_45 { get; set; } = "";
        public string H01_00 { get; set; } = "";
        public string H01_15 { get; set; } = "";
        public string H01_30 { get; set; } = "";
        public string H01_45 { get; set; } = "";
        //status
        public string PermitAr { get; set; } = "";
        public string PermitEn { get; set; } = "";
        public string PermitStatus { get; set; } = "";
        public string PermitStatusBy { get; set; } = "";
        public DateTime? PermitStatusAt { get; set; }
        public string PermitNotes { get; set; } = "";
        public int TotalShift { get; set; }
    }
}
