using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ReportsProj.PM_Model;

namespace ReportsProj.PM_Model
{
    public class cOrganization : _EntityBase
    {
        [Required]
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public Guid Code { get; set; } 
        [Required]
        public string Sector { get; set; }
        [Required]
        public string Country { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public string Logo { get; set; }
        public string Banner { get; set; }
        public string Slogan { get; set; }
        [Required]
        public string Owner { get; set; } 
        public string OwnerPhone { get; set; }
        public string OwnerEmail { get; set; }
        public string RegistrationFiles { get; set; }
        public bool IsChiledOrganization { get; set; } = false;
        public string ParentOrganization { get; set; }
        public string ParentOrganizationContact { get; set; }
    }
}
