
using ReportsProj.PM_Model;
using System;

namespace ReportsProj.Management_Models
{
    public class Doc_EmploymentAdvertizement : _EntityBase
    {
        //BasicData---------------------------------------------------
        public string Code { get; set; }
        public string IssuedBy { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedAt { get; set; }
        public DateTime PublishedDateFrom { get; set; }
        public DateTime PublishedDateTo { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Status { get; set; } = "";
        //AdvertizemenAgency-------------------------------------------
        // [RequiredIf("Details.Phone != null")]
        public string AgencyTitle { get; set; }
        public string AgencyType { get; set; }
        public string AgencyCode { get; set; }
        public string AgencyLink { get; set; }
        public string AgencyPerson { get; set; }
        public string AgencyContact { get; set; }
        public decimal AgencyCost { get; set; }
        public string AgencyNotes { get; set; }
        //JobOverview

        public string Advertizement { get; set; }
        public string AdvertizementEn { get; set; } = "";
        public string Job { get; set; }
        public string SaudiStandardJobCode { get; set; }
        //[Required]
        public string Department { get; set; }
        // [Required]
        public string Branch { get; set; }
        public string ContractType { get; set; }
        public string Permanency { get; set; }
        public int EmployeeCount { get; set; }
        public bool ForCitizensOnly { get; set; } = false;
        public DateTime EstimatedStart { get; set; }
        public string JobDescription { get; set; }
        //Requirements
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public string Languages { get; set; }
        public string AcademicGradeType { get; set; }
        public string Qualification { get; set; }
        public string Specialization { get; set; }
        public string Certificates { get; set; }
        public string YearsOfExperience { get; set; }
        public string Sex { get; set; }
        public bool HaveDrivingLicense { get; set; }
        public string MilitaryServiceStatus { get; set; }
        public string TheUser { get; set; }
    }
}
