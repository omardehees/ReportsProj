using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReportsProj.DBC;

namespace ReportsProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _Configuration;
        private readonly PM_DBC _PM_DBC;
        private readonly CSR_DBC _CSR_DBC;
        public HomeController(IConfiguration Configuration
            , PM_DBC PM_DBC
            , CSR_DBC CSR_DBC)
        {
            _Configuration = Configuration;
            _PM_DBC = PM_DBC;
            _CSR_DBC = CSR_DBC;
        }
        public IActionResult Index(string App = "", string T = "",
                                   string p1 = "", string p2 = "", string p3 = "", string p4 = "", string p5 = "", string p6 = "", string p7 = "")
        {
            if ((string.IsNullOrWhiteSpace(App)) || (string.IsNullOrWhiteSpace(T)))
            {
                return View();
            }
            //------ Select Appication Name 
            switch (App)
            {
                //------ Select Database Name 
                case "PM": // --  App=PM 
                    break;
                case "CSR": // --  App=CSR
                    break;
                default:
                    return View();
            }
            switch (T)
            {
                case "CSR_GAL":
                    //طباعة شبكة كل الشكاوي عرضيا
                    // Parameter >> ?App=CSR&T=CSR_GAL&p5=UserName
                    //Test Parameter >> ?App=CSR&T=CSR_GAL&p5=Admin
                    TempData["P_UserName"] = p5;
                    return View("CSR_All");

                case "CSR_b":
                    //طباعة علاقات المرضي فقط 2*4 سم
                    // barcode Visible = false
                    //Parameter >> ?App=CSR&T=CSR_b&p1="CSRCode"&p2="PatientFileNumber"&p3="CSRType"&p4="CSRSubject&p5="CSRCreatedDate&p6="CSREditDate&p7="CSRStatus
                    // Test Parameter >> ?App=CSR&T=CSR_b&p1=R-10000&p2=1234567&p3=إسترداد&p4=جلسة%20تجميل&p5=16/12/2020 03:40 PM
                    TempData["CSRCode"] = p1;
                    TempData["TheDate"] = DateTime.Now.ToString("d/M/yyyy hh:mm tt");
                    TempData["PatientFileNumber"] = p2;
                    TempData["CSRType"] = p3;
                    TempData["CSRSubject"] = p4;
                    TempData["CSRCreatedDate"] = p5;
                    TempData["CSREditDate"] = p6;
                    TempData["CSRStatus"] = p7;
                    return View("Rep_CSR_b");

                case "CSR_R":
                    //طباعة باركود +   كيو آر فقط 12*6 سم
                    //Parameter >> ?App=CSR&T=CSR_R&p1="CSRCode"&p2="PatientFileNumber"&p3="CSRType"&p4="CSRSubject
                    // Test Parameter >> ?App=CSR&T=CSR_R&p1=R-10000&p2=5&p3=إسترداد&p4=جلسة%20تجميل
                    TempData["CSRCode"] = p1;
                    TempData["TheDate"] = DateTime.Now.ToString("d/M/yyyy hh:mm tt");
                    TempData["PatientFileNumber"] = p2;
                    TempData["CSRType"] = p3;
                    TempData["CSRSubject"] = p4;
                    return View("RepCSRBarCodeQR");


                    //case "CSR_Q":
                    //    //CSR
                    //    //طباعة كيو آر فقط 6*6 سم
                    //    //p1="CSRCode",p2="PatientFileNumber",p3="CSRType",p4="CSRSubject"
                    //    TempData["CSRCode"] = p1;
                    //    TempData["TheDate"] = DateTime.Now.ToString();
                    //    TempData["PatientFileNumber"] = p2;
                    //    TempData["CSRType"] = p3;
                    //    TempData["CSRSubject"] = p4;
                    //    return View("Rep_CSR_Q");

                    //case "CSR_GSL":
                    //    //CSR
                    //    //طباعة المحدد من شبكة الشكاوي عرضيا    
                    //    //p1="CSRCode",p2="PatientFileNumber",p3="CSRType",p4="CSRSubject,p5=UserName"

                    //    TempData["MyDatasource"] = _CSR_DBC.cCSR.ToList();
                    //    TempData["P_UserName"] = p5;
                    //    TempData["P_SelectedCodes"] = p1;
                    //    return View("Rep_CRS_Ls");

                    //case "CSR_GSP":
                    //    //CSR
                    //    //طباعة المحدد من شبكة الشكاوي طوليا    
                    //    //p1="CSRCode",p2="PatientFileNumber",p3="CSRType",p4="CSRSubject,p5=UserName"
                    //    TempData["MyDatasource"] = _CSR_DBC.cCSR.ToList();
                    //    TempData["P_UserName"] = p5;
                    //    TempData["P_SelectedCodes"] = p1;
                    //    return View("CSR_Id");

                    //case "cOrganization":  //   تقارير جدول المؤسسات   
                    //    // PM
                    //    TempData["MyDatasource"] = _PM_DBC.cOrganization.ToList();
                    //    TempData["P_UserName"] = p5;
                    //    //طباعةكل شبكة المؤسسات عرضيا

                    //    if (string.IsNullOrEmpty(p1))
                    //    {
                    //        return View("RepOrganization_All");
                    //    }
                    //    else
                    //    {
                    //        //طباعة المحدد من شبكة المؤسسات طوليا    
                    //        if (string.IsNullOrEmpty(p6))// If P6 Empty Print Not landscape
                    //        {
                    //            TempData["P_Id"] = p1;
                    //            return View("RepOrganization_Id");
                    //        }
                    //        else
                    //        {
                    //            //طباعة المحدد من شبكة المؤسسات عرضيا    
                    //            // If P6 Not Empty Print landscape
                    //            TempData["P_Id"] = p1;
                    //            return View("RepOrganization_Ls");
                    //        }
                    //    }
            }

            return View();

        }
        public IActionResult CSR_All()
        {
            return View();
        }
        //public IActionResult RepOrganization_All()
        //{
        //    return View();
        //}
        //public IActionResult RepOrganization_Id()
        //{
        //    return View();
        //}
        //public IActionResult RepOrganization_Ls()
        //{
        //    return View();
        //}
        //public IActionResult Invoices()
        //{
        //    return View();
        //}
        //public IActionResult CSR_Id()
        //{
        //    return View();
        //}

        //public IActionResult Rep_CRS_Ls()
        //{
        //    return View();
        //}

    }
}
