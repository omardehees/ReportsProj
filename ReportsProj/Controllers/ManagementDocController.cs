using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReportsProj.DBC;

namespace ReportsProj.Controllers
{
    public class ManagementDocController : Controller
    {
        #region DI
        private readonly IConfiguration _Configuration;
        private readonly Management_DBC _Management_DBC;
        public ManagementDocController(IConfiguration Configuration, Management_DBC Management_DBC)
        {
            _Configuration = Configuration;
            _Management_DBC = Management_DBC;
        }
        #endregion
        //-- Params Description-- p1=Report Method >>All or Selected & P2=Id>>1,3 &P3>>Report Addressp & P4=UserName >>Admin
        //-- Test_All  Params>> /ManagementDoc?P1=All&P3=عنوان التقرير&P4=admin
        //-- Test_All  Params>> /ManagementDoc?P1=Selected&P2=18,19,20&P3=عنوان%20التقرير&P4=admin


        public IActionResult Index(string P1 = "", string P2 = "", string P3 = "", string P4 = "")
        {
            TempData["P_Id"] = P2;
            TempData["P_T_Header"] = P3;
            TempData["P_User"] = P4;

            if (!string.IsNullOrEmpty(P1))
            {
                if (P1 == "Selected")
                {
                    return View("EmpAdvertisement_Selected");
                }
                else if (P1 == "All")
                {
                    return View("EmpAdvertisement_All");
                }
                else
                {
                    return View("ErrorPage");
                }
            }
            return null;
        }
    }
}
