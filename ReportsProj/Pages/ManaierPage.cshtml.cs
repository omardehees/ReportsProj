using Microsoft.AspNetCore.Mvc.RazorPages;
using DevExpress.XtraReports.UI;
using ReportsProj.Reports.Attadawe;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;

namespace ReportsProj.Pages
{
    public class ManaierPageModel : PageModel
    {
        public XtraReport MyReport { get; set; }
        public IActionResult OnGet(string Code)
        {
            try
            {
                //--Declare Report
                MyReport = new Rep_Manaier();
                int Int_Code = 0;

                // --Specify report properties
                try
                {
                    Int_Code = Convert.ToInt32(Code);
                }
                catch (Exception)
                {
                    return new RedirectToPageResult("InvalidParam");
                }
                if ((Int_Code - 35097) % 37 != 0)
                {
                    return new RedirectToPageResult("InvalidParam");
                }

                if (Int_Code > 0)
                {
                    Int_Code = (Int_Code - 35097) / 37;
                    MyReport.Parameters["MyCode"].Value = Int_Code;
                    MyReport.RequestParameters = false;
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
