using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ReportsProj.DBC;
using ReportsProj.Models.ViewModel;

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
                    string p1 = "", string p2 = "", string p3 = "", string p4 = "", string p5 = "",
                    string p6 = "", string p7 = "", string p8 = "", string p9 = "", string p10 = "")

        {
            if ((string.IsNullOrWhiteSpace(App)) || (string.IsNullOrWhiteSpace(T)))
            {
                return View();
            }
            //------ Select Appication Name 
            DbContext myCurrentContext;
            switch (App)
            {
                //------ Select Database Name 
                case "PM": // --  App=PM 
                    myCurrentContext = _PM_DBC;
                    break;
                case "CSR":
                    myCurrentContext = _CSR_DBC;
                    break;
                default:
                    return View();
            }
            switch (T)
            {
                case "CSR_b":
                    //PM
                    //طباعة باركود فقط 3*6 سم
                    //p1="CSRCode",p2="PatientFileNumber",p3="CSRType",p4="CSRSubject"
                    TempData["CSRCode"] = p1;
                    TempData["TheDate"] = DateTime.Now.ToString();
                    TempData["PatientFileNumber"] = p2;
                    TempData["CSRType"] = p3;
                    TempData["CSRSubject"] = p4;
                    return View("Rep_CSR_b");

                //case "CSR_Q":
                //    //PM
                //    //طباعة كيو آر فقط 6*6 سم
                //    //p1="CSRCode",p2="PatientFileNumber",p3="CSRType",p4="CSRSubject"
                //    TempData["CSRCode"] = p1;
                //    TempData["TheDate"] = DateTime.Now.ToString();
                //    TempData["PatientFileNumber"] = p2;
                //    TempData["CSRType"] = p3;
                //    TempData["CSRSubject"] = p4;
                //    return View("Rep_CSR_Q");

                case "CSR_R":
                    //PM
                    //طباعة باركود +   كيو آر فقط 12*6 سم
                    //p1="CSRCode",p2="PatientFileNumber",p3="CSRType",p4="CSRSubject,p5=UserName"
                    TempData["CSRCode"] = p1;
                    TempData["TheDate"] = DateTime.Now.ToString();
                    TempData["PatientFileNumber"] = p2;
                    TempData["CSRType"] = p3;
                    TempData["CSRSubject"] = p4;
                    return View("RepCSRBarCodeQR");

                case "CSR_GAL":
                    //PM
                    //طباعةكل شبكة الشكاوي عرضيا
                    TempData["MyDatasource"] = _CSR_DBC.cCSR.ToList();
                    TempData["P_UserName"] = p5;
                    return View("CSR_All");

                //case "CSR_GSL":
                //    //PM
                //    //طباعة المحدد من شبكة الشكاوي عرضيا    
                //    //p1="CSRCode",p2="PatientFileNumber",p3="CSRType",p4="CSRSubject,p5=UserName"

                //    TempData["MyDatasource"] = _CSR_DBC.cCSR.ToList();
                //    TempData["P_UserName"] = p5;
                //    TempData["P_SelectedCodes"] = p1;
                //    return View("Rep_CRS_Ls");

                //case "CSR_GSP":
                //    //PM
                //    //طباعة المحدد من شبكة الشكاوي طوليا    
                //    //p1="CSRCode",p2="PatientFileNumber",p3="CSRType",p4="CSRSubject,p5=UserName"
                //    TempData["MyDatasource"] = _CSR_DBC.cCSR.ToList();
                //    TempData["P_UserName"] = p5;
                //    TempData["P_SelectedCodes"] = p1;
                //    return View("CSR_Id");

                //case "cOrganization":  //   تقارير جدول المؤسسات   

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
                //        if (string.IsNullOrEmpty(p6))// Not landscape
                //        {
                //            TempData["P_Id"] = p1;
                //            return View("RepOrganization_Id");
                //        }
                //        else
                //        {
                //            //طباعة المحدد من شبكة المؤسسات عرضيا    
                //            TempData["P_Id"] = p1;
                //            return View("RepOrganization_Ls");
                //        }
                //    }
            }

            return View();

        }

        public IActionResult RepOrganization_All()
        {
            return View();
        }
        public IActionResult RepOrganization_Id()
        {
            return View();
        }
        public IActionResult RepOrganization_Ls()
        {
            return View();
        }
        public IActionResult Invoices()
        {
            return View();
        }
        public IActionResult CSR_Id()
        {
            return View();
        }
        public IActionResult CSR_All()
        {
            return View();
        }
        public IActionResult Rep_CRS_Ls()
        {
            return View();
        }




        //var PM_DataSource = _PM_DBC;
        //switch (T)
        //{
        //    case "cOrganization":  //  تقارير جدول    

        //        //ِشكل الريبورت هنــــــــــــــــــــــــــا  

        //        TempData["MyDatasource"] = PM_DataSource.cOrganization.ToList();
        //        TempData["P_UserName"] = p1;

        //        if (string.IsNullOrEmpty(p2))
        //        {

        //            return View("RepOrganization_All");
        //        }
        //        else
        //        {
        //            if (string.IsNullOrEmpty(p3))
        //            {
        //                TempData["P_Id"] = p2;
        //                return View("RepOrganization_Id");
        //            }
        //            else
        //            {
        //                TempData["P_Id"] = p2;
        //                return View("RepOrganization_Ls");
        //            }
        //        }


        //    case "cCSR": //  تقارير جدول  

        //        //ِشكل الريبورت هنــــــــــــــــــــــــــا  

        //        TempData["MyDatasource"] = PM_DataSource.cCSR.ToList();
        //        TempData["P_UserName"] = p1;


        //        if (string.IsNullOrEmpty(p2) || string.IsNullOrEmpty(p4))
        //        {

        //            return View("CSR_All");
        //        }
        //        else
        //        {
        //            if (string.IsNullOrEmpty(p3))
        //            {
        //                TempData["P_Id"] = p2;
        //                return View("CSR_Id");
        //            }
        //            else
        //            {
        //                TempData["P_Id"] = p2;
        //                return View("Rep_CRS_Ls");
        //            }
        //        }

        //    default:
        //        return View();
        //}




    }
}
