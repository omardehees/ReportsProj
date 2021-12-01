using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using ReportsProj.DBC;
using ReportsProj.Reports.Attadawe;
using System.Linq;

namespace ReportsProj.Pages
{
    public class PharmacyPageModel : PageModel
    {
        #region DI
        private readonly Pharmacy_DBC _Context;
        public PharmacyPageModel(Pharmacy_DBC Pharmacy_DBC)
        {
            _Context = Pharmacy_DBC;
        }
        #endregion
        public XtraReport MyReport { get; set; }

        public void OnGet(int Code,int YId)
        {
            //--Declare Report
            MyReport = new Rep_Pharm();

            // --Specify report properties
            Code = (Code - 35097) / 37;
            YId = (YId - 35097) / 37;

            int Get_MyId = _Context.journal_h.Where(a => a.code == Code && a.year_id == YId).Select(a => a.id).FirstOrDefault();
            MyReport.Parameters["MyId"].Value = Get_MyId;
            MyReport.RequestParameters = false;
        }
    }
}
