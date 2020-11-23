using ReportsProj.PM_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.PM_Model
{
    public class cCSR : _EntityBase
    {
        public string Type { get; set; }
        public string Code { get; set; }
        public string Relationship { get; set; }
        public string TheUser { get; set; }
        public string CreationDate { get; set; }
        public string Subject { get; set; }
        public string PatientCode { get; set; }
        public string PatientName { get; set; }
        public string PatientPhone { get; set; }
        public string PatientNationalId { get; set; }
        public string PatientSex { get; set; }
#nullable enable
        public string? Details { get; set; }
        public string? Department { get; set; }
        public string? Employee { get; set; }
        public string? Service { get; set; }
        public string? Country { get; set; }
        public string? AttachmentsFiles { get; set; }
        public string? AttachmentsFilesTitlesOnly { get; set; }
        public string? Attachments_Description { get; set; }
#nullable disable
        public string CurrentStatus { get; set; }
        public DateTime CurrentStatus_At { get; set; }
        public string CurrentStatus_By { get; set; }
    }
}
