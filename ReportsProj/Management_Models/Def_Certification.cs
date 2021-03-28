using ReportsProj.PM_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.Management_Models
{
    public class Def_Certification : _EntityBase
    {
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public string Language { get; set; }
        public string LanguageEn { get; set; }
        public string Issuer { get; set; }
        public string Photo { get; set; }
        public DateTime? Valid_From { get; set; }
        public DateTime? Valid_To { get; set; }
    }
}
