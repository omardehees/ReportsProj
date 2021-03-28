using ReportsProj.PM_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.Management_Models
{
    public class Doc_Interview : _EntityBase
    {
        public Guid Code { get; set; }
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string TheType { get; set; }
        public DateTime? TheDate { get; set; }
        public string Place { get; set; }
        public string Interviewers { get; set; }
        public string Interviewee { get; set; }
        public string EmploymentAdvertizementCode { get; set; }
        public string GeneralAssessment { get; set; }
        public int RankOf100 { get; set; }
        public string Recommendation { get; set; }
        public DateTime? NextInterViewDate { get; set; }
        public string Status { get; set; }
    }

}
