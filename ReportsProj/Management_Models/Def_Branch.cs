using ReportsProj.PM_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.Management_Models
{
    public class Def_Branch : _EntityBase
    { public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Company { get; set; }
        public string CompanyEn { get; set; }
        public string Country { get; set; }
        public string CountryEn { get; set; }
        public string City { get; set; }
        public string CityEn { get; set; }
        public string Address { get; set; }
        public bool IsHeadQuarter { get; set; }
        public string Manager { get; set; }
        public string ManagerPhone { get; set; }
        public string ManagerEmail { get; set; }
        public string Logo { get; set; }
        public string Banner { get; set; }
    }
}
