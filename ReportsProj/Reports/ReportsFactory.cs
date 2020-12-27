//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ReportsProj
//{
//    public class ReportsFactory
//    {
//    }
//}

using DevExpress.XtraReports.UI;
using ReportsProj.Reports;
using System;
using System.Collections.Generic;
namespace ReportsProj
{
    public class ReportsFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>()
        {
            ["MyInvoices"] = () => new MyInvoices(),

            ["Rep_Organization_Id"] = () => new Rep_Organization_Id(),
            ["Rep_Organaization_Ls"] = () => new Rep_Organaization_Ls(),
            ["Rep_Organization_All"] = () => new Rep_Organization_All(),
            ["Rep_CSR_Id"] = () => new Reports.CSR.Rep_CSR_Id(),
            ["Rep_CRS_All"] = () => new Reports.CSR.Rep_CRS_All(),
            ["Rep_CRS_Ls"] = () => new Reports.CSR.Rep_CRS_Ls(),

            ["Rep_PM_EmployeeActions"] = () => new Reports.PM.Rep_EmployeeActions()


        };
    }
}