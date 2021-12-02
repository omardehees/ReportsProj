using Microsoft.AspNetCore.Mvc.RazorPages;
using DevExpress.XtraReports.UI;
using ReportsProj.Reports.Attadawe;

namespace ReportsProj.Pages
{
    public class ManaierPageModel : PageModel
    {
        public XtraReport MyReport { get; set; }
        public void OnGet(int Code)
        {
            //--Declare Report
            MyReport = new Rep_Manaier();

            // --Specify report properties
            Code = (Code - 35097) / 37;

            MyReport.Parameters["MyCode"].Value = Code;
            MyReport.RequestParameters = false;
        }
    }
}
