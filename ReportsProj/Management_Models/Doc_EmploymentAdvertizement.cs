
using ReportsProj.PM_Model;
using System;

namespace ReportsProj.Management_Models
{
    public class Doc_EmploymentAdvertizement : _EntityBase
    {
        public string Advertizement { get; set; }
        public string AdvertizementEn { get; set; }
        public string Code { get; set; }
        public DateTime PublishedDateFrom { get; set; }
        public DateTime PublishedDateTo { get; set; }
        public string PublishedIn { get; set; }
        public string Job { get; set; }
        public string Department { get; set; }
        public string Branch { get; set; }
        public string ContractType { get; set; }
        public int EmployeeCount { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public bool ForCitizensOnly { get; set; } = false;
        public decimal SalaryFrom { get; set; }
        public decimal SalaryTo { get; set; }
        public int YearsOfExperience { get; set; }
        public string Qualification { get; set; }
        public DateTime InterviewDate { get; set; }
        public string TheUser { get; set; }
        public string IssuedBy { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedAt { get; set; }
    }
}
