using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReportsProj.DBC;
using ReportsProj.Reports.Attadawe;
using System;
using System.Diagnostics;
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

        public IActionResult OnGet(string Code)
        {
            try
            {
                //--Declare Report
                MyReport = new Rep_Clinics();
                int Int_Code = 0;
                int MyId = 0;

                // --Specify report properties
                try
                {
                    //Code = Code.Replace("TRIAL", "");
                    Int_Code = Convert.ToInt32(Convert.ToDouble(Code));
                }
                catch (Exception)
                {
                    return new RedirectToPageResult("InvalidParam");
                }
                if ((Int_Code - 35097)  % 37 != 0)
                {
                    return new RedirectToPageResult("InvalidParam");
                }
                Int_Code = (Int_Code - 35097) / 37;
                if (Int_Code > 0)
                {
                    MyId = _Context.invoice_h.Where(a => a.code == Int_Code).Select(a => a.id).FirstOrDefault();
                    if (MyId > 0)
                    {
                        MyReport.Parameters["MyId"].Value = MyId;
                        MyReport.RequestParameters = false;
                    }
                    else
                    {
                        return new RedirectToPageResult("InvalidParam");
                    }
                }
                else
                {
                    return new RedirectToPageResult("InvalidParam");
                }
                return null;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return new RedirectToPageResult("InvalidParam");
            }
        }

    }
}
