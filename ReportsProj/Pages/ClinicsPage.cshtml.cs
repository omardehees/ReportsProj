using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReportsProj.DBC;
using ReportsProj.Reports.Attadawe;
using System.Linq;

namespace ReportsProj.Pages
{
    public class ClinicsPageModel : PageModel
    {
        #region DI
        private readonly Clinics_DBC _Context;
        public ClinicsPageModel(Clinics_DBC Clinics_DBC)
        {
            _Context = Clinics_DBC;
        }
        #endregion
        public XtraReport MyReport { get; set; }

        public void OnGet(int Code)
        {
            //--Declare Report
            MyReport = new Rep_Clinics();

            // --Specify report properties
            Code = (Code - 35097) / 37;
            int Get_MyId = _Context.invoice_h.Where(a => a.code == Code).Select(a => a.id).FirstOrDefault();
            MyReport.Parameters["MyId"].Value = Get_MyId;
            MyReport.RequestParameters = false;
        }
    }
}
