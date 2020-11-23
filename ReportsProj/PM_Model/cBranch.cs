using System;
using System.Collections.Generic;
using System.Text;

namespace ReportsProj.PM_Model
{
    public class cBranch : _EntityBase
    {
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public Guid Code { get; set; }
        public string Activity { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public bool IsHeadQuarter { get; set; }
        public string  Owner { get; set; }
        public string OwnerContact { get; set; }
        public string ManagerCode { get; set; }
        public string ExecutiveManagerCode { get; set; }
        public string FinancialManagerCode { get; set; }
        public string TechnicalManagerCode { get; set; }
        public string HRManagerCode { get; set; }
        public string InventoryManagerCode { get; set; }
        public string SecurityManagerCode { get; set; }
        public string SmallLogo { get; set; }
        public string BigLogo { get; set; }
        public string SmallBanner { get; set; }
        public string BigBanner { get; set; }
        public string Slogan { get; set; }
        public string AvailableApplications { get; set; }
        public string AvailableJobs { get; set; }
        public string AvailableGroups { get; set; }
        public string AvailableResponsibilities { get; set; }
        public TimeSpan OpenAt  { get; set; }
        public TimeSpan CloseAt { get; set; }   

    }
}
