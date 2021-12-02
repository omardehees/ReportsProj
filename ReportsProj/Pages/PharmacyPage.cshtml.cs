using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using ReportsProj.DBC;
using ReportsProj.Reports.Attadawe;
using System;
using System.Diagnostics;
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
        public IActionResult OnGet(string Code, string YId)
        {
            try
            {
                //--Declare Report
                MyReport = new Rep_Pharm();
                int Int_Code = 0;
                int Int_YId = 0;
                int MyId = 0;

                // --Specify report properties
                try
                {
                    Int_Code = Convert.ToInt32(Code);
                    Int_YId = Convert.ToInt32(YId);
                }
                catch (Exception)
                {
                    return new RedirectToPageResult("InvalidParam");
                }
                if ((Int_Code - 35097) % 37 != 0)
                {
                    return new RedirectToPageResult("InvalidParam");
                }
                Int_Code = (Int_Code - 35097) / 37;
                Int_YId = (Int_YId - 35097) / 37;
                if (Int_Code > 0)
                {
                    MyId = _Context.journal_h.Where(a => a.code == Int_Code && a.year_id == Int_YId).Select(a => a.id).FirstOrDefault();
                    if (MyId >= 804832)
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
