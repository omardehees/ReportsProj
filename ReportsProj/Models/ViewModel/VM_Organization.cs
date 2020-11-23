using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.Models.ViewModel
{
    public class VM_Organization
    {

        public int Id { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDefault { get; set; }
        public string Notes { get; set; }
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Code { get; set; } 
        public string Sector { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public string Logo { get; set; }
        public string Banner { get; set; }
        public string Slogan { get; set; }
        public string Owner { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerEmail { get; set; }
        public string RegistrationFiles { get; set; }
        public string ParentOrganization { get; set; }
        public string ParentOrganizationContact { get; set; }
        public bool IsChiledOrganization { get; set; }

    }
}
