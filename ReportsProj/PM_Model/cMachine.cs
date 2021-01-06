using System;
using System.Collections.Generic;
using ReportsProj.PM_Model;

namespace ReportsProj.PM_Model
{
    public class cMachine : _EntityBase
    {
        public string Branch { get; set; }
        public string Department { get; set; }
        public string ComputerName { get; set; }
        public string WorkGroup { get; set; }
        public string Ip { get; set; }
        public string HWFP { get; set; }
        public string Application { get; set; }
        public string User { get; set; }
        public string Job { get; set; }
        public string Group { get; set; }
        public string Responsibility { get; set; }
    }
}
