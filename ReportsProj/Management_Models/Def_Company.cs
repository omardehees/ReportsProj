using ReportsProj.PM_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.Management_Models
{
    public class Def_Company : _EntityBase
    {
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Sector { get; set; }
        public string SectorEn { get; set; }
        public string Country { get; set; }
        public string CountryEn { get; set; }
        public string City { get; set; }
        public string CityEn { get; set; }

        public string CommercialRecord { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string MailBox { get; set; }
        public string Fax { get; set; }

        public string Logo { get; set; }
        public string Banner { get; set; }
        public string Owner { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerEmail { get; set; }
        public string Address { get; set; }

    }
}
