using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReportsProj.DBC;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using ReportsProj.Management_Models;
using System.Collections.Generic;

namespace ReportsProj.Controllers
{
    public class ManagementDocController : Controller
    {
        #region DI
        private readonly IConfiguration _Configuration;
        private readonly Management_DBC _Context;
        public ManagementDocController(IConfiguration Configuration, Management_DBC Management_DBC)
        {
            _Configuration = Configuration;
            _Context = Management_DBC;
        }
        #endregion

        //-- Params Description-- p1=Report Method >>All or Selected & P2=Id>>1,3 &P3>>Report Address & P4=UserName >>Admin & P5=From >>10/10/2020 & P6=To >>11/11/2020 

        //-- Test_adv_All  Params>> /ManagementDoc?P1=All&P3=اعلانات%20التوظيف&P4=admin  
        //-- Test_adv_Selected  Params>> /ManagementDoc?P1=Selected&P2=18,19,20&P3=اعلان%20التوظيف&P4=admin 
        //-- Test_EmpCard_V1  Params>> /ManagementDoc?P1=P_EmpCard_V1&P2=899&P3=كارت%20الموظف&P4=admin 
        //-- Test_EmpCard_V2  Params>> /ManagementDoc?P1=P_EmpCard_V2&P2=863&P3=كارت%20الموظف&P4=admin 
        //-- Test_EmployemntContract  Params>> /ManagementDoc?P1=P_EmployemntContract&P2=379&P3=عقد%20توظيف&P4=admin  
        //-- Test_EmployemntContract_All  Params>> /ManagementDoc?P1=P_All_EmploymentContract&P3=عقود%20التوظيف&P4=admin
        //-- Test_Interviews   Params>> /ManagementDoc?P1=P_Interviews&P2=1,2,3&P3=المقابلات&P4=admin
        //-- Test_Interviews_All   Params>> /ManagementDoc?P1=P_Interview_All&P3=المقابلات&P4=admin
        //-- Test_ApplyToJob   Params>> /ManagementDoc?P1=P_ApplyToJob&P2=379&P3=التقدم%20لوظيفة&P4=admin

        //---------  طلب اجازة  -------------------------------------
        //-- Params Description-- p1 = PageName & P2=Emplpoyee Code &P3>>Report Address & P4=UserName & P5=Search From Date & P6=Search To Date & P7= Search Department & P8= Preview Or  DirectPrint &P9=MachineNumber &P10=FingerPrintType &p11=EmployeeName &P12=Job

        //-- Test_VacationsRequests Preview Params>> /ManagementDoc?P1=P_VacationRequest&P2=7,11,14&P3=طلب%20اجازة&P4=admin&P8=Preview
        //-- Test_VacationsRequests Print Params>> /ManagementDoc?P1=P_VacationRequest&P2=7,11,14&P3=طلب%20اجازة&P4=admin&P8=Print

        //-- Test_VacationsRequests LS Preview Params>> /ManagementDoc?P1=P_VacationRequest_LS&P3=طلب%20اجازة&P4=admin&P8=Preview
        //-- Test_VacationsRequests LS Print Params>> /ManagementDoc?P1=P_VacationRequest_LS&P3=طلب%20اجازة&P4=admin


        //--------- /  طلب اجازة  -------------------------------------

        //--------- طلب اذن  -------------------------------------
        //-- Test_AttendanceShiftRequest_All Preview Params>> /ManagementDoc?P1=P_AttendanceShiftRequest_LS&P3=طلب%20اذن&P4=admin&P8=Preview
        //-- Test_AttendanceShiftRequest_All Print Params>> /ManagementDoc?P1=P_AttendanceShiftRequest_LS&P3=طلب%20اذن&P4=admin&P8=Print
        //-- Test_AttendanceShiftRequest_Selected Preview Params>> /ManagementDoc?P1=P_AttendanceShiftRequest_Selected&P2=15,21&P3=طلب%20اذن&P4=admin&P8=Preview
        //---------/ طلب اذن  -------------------------------------

        //--------- البصمات  -------------------------------------
        //-- Params Description-- p1 = PageName & P2=Emplpoyee Code &P3>>Report Address & P4=UserName & P5=Search From Date & P6=Search From Date & P7= Search Department & P8= Preview Or  DirectPrint &P9=MachineNumber &P10=FingerPrintType &p11=EmployeeName &P12=Job

        //-- Test__FingerPrint Preview Params>> /ManagementDoc?P1=P_FingerPrint&P2=5&P3=سجل%20البصمات&P4=admin&P5=3/1/2021&P6=4/1/2021&P7=البرمجة&P8=Preview&P9=1&P10=حضور&P11=عمر
        //-- Test__FingerPrint Print Params>> /ManagementDoc?P1=P_FingerPrint&P2=5&P3=سجل%20البصمات&P4=admin&P5=3/1/2021&P6=4/1/2021&P7=البرمجة&P8=Print&P9=1&P10=حضور&P11=عمر
        //-- Test__FingerPrint_Filterd Params>> /ManagementDoc?P1=P_FingerPrint_Filterd&P2=322989,322990,322991,322992
        //--------- / البصمات  -------------------------------------

        //--------- قديم التقدم لوظيفةاونلاين   ---------------------------------------
        //-- Test__ApplyToJobOnline. Params>> /ManagementDoc?P1=P_ApplyToJobOnline&P2=992,984,985
        //--------- /قديم التقدم لوظيفةاونلاين   -------------------------------------

        //---------En  قديم التقدم لوظيفةاونلاين   ---------------------------------------
        //-- Test__ApplyToJobOnline. Params>> /ManagementDoc?P1=P_ApplyToJobOnline_En&P2=2017
        //--------- /En قديم التقدم لوظيفةاونلاين  -------------------------------------




        //--------- التقدم لوظيفة صفحةاونلاين   ---------------------------------------
        //-- Test__ApplyToJobOnline. Params>> /ManagementDoc?P1=P_ApplyToJobOnlinePage&P2=615084805
        //--------- / التقدم لوظيفةصفحةاونلاين   -------------------------------------

        //--------- Enالتقدم لوظيفة صفحةاونلاين   ---------------------------------------
        //-- Test__ApplyToJobOnline. Params>> /ManagementDoc?P1=P_ApplyToJobOnlinePage_En&P2=615084805
        //--------- / Enالتقدم لوظيفةصفحةاونلاين   -------------------------------------



        //--------- التقدم لوظيفةالكل   ---------------------------------------
        //-- Test__ApplyToJob_All Params>> /ManagementDoc?P1=P_ApplyToJob_All&P2=984,985
        //--------- / التقدم لوظيفةالكل   -------------------------------------

        //---------En التقدم لوظيفةالكل   ---------------------------------------
        //-- Test__ApplyToJobEn_All Params>> /ManagementDoc?P1=P_ApplyToJobEn_All&P2=984,985,992
        //--------- / En التقدم لوظيفةالكل   -------------------------------------

        //--------- التعديل على حضور الموظفين   -------------------------------------
        //-- Test__AttendancePlant Params>> /ManagementDoc?P1=P_AttendancePlane_Permites_Ar&P2=109,110,111,112
        //--------- /التعديل على حضور الموظفين   -------------------------------------


        //--------- خطط الحضور  -------------------------------------
        //-- Test__AttendancePlant Params>> /ManagementDoc?P1=P_AttendancePlane&P2=12,13,14,15,16,17,18
        //--------- / خطط الحضور  -------------------------------------

        //--------- خطط الحضور بورتريه عربي  -------------------------------------
        //-- Test__AttendancePlant Params>> /ManagementDoc?P1=P_AttendancePlane_Port_Ar&P2=109,110,111,112
        //--------- /خطط الحضور بورتريه عربي   -------------------------------------

        //--------- خطط الحضور بورتريه انجليزي  -------------------------------------
        //-- Test__AttendancePlant Params>> /ManagementDoc?P1=P_AttendancePlane_Port_En&P2=109,110,111,112
        //--------- /خطط الحضور بورتريه انجليزي   -------------------------------------

        //--------- ملخص الاجازات  -------------------------------------
        //-- Test__AttendancePlant Params>> /ManagementDoc?P1=P_VacationsSummary
        //--------- / ملخص الحضور  -------------------------------------

        //--------- خطط الحضورالشهري  -------------------------------------
        //-- Test__AttendancePlant Params>> /ManagementDoc?P1=P_Schedule_Month&P3= جدول شهر مايو 2021 باستثناء يوم الجمعة-البرمجة&P7=البرمجة&P5=5/1/2021&P6=5/31/2021
        //--------- / خطط الحضورالشهري  -------------------------------------

        //--------- خطط الحضورالجمعة  -------------------------------------
        //-- Test__AttendancePlant Params>> /ManagementDoc?P1=P_Schedule_Friday&P3=جدول شهر مايو-الجمعة 2021&P5=5/1/2021&P6=5/31/2021&P7=برمج
        //--------- / خطط الحضورالجمعة  -------------------------------------

        //--------- خطط الحضور التفصيلية  -------------------------------------
        //-- Test__AttendancePlant Params>> /ManagementDoc?P1=P_Schedule_All&P3=جدول شهر مايو 2021
        //--------- /خطط الحضور التفصيلية  -------------------------------------

        public IActionResult Index(string P1 = "", string P2 = "", string P3 = "", string P4 = "", string P5 = "", string P6 = "", string P7 = "", string P8 = "", string P9 = "", string P10 = "", string P11 = "", string P12 = "")
        {
            TempData["P_Id"] = P2;
            TempData["P_T_Header"] = P3;
            TempData["P_User"] = P4;
            TempData["P_P5"] = P5;
            TempData["P_P6"] = P6;
            TempData["P_P7"] = P7;
            TempData["P_P9"] = P9;
            TempData["P_P10"] = P10;
            TempData["P_P11"] = P11;
            TempData["P_P12"] = P12;

            //DailyActivities_AttendancePlanPerEmployee2 MyObject = new DailyActivities_AttendancePlanPerEmployee2();

           IEnumerable<DailyActivities_AttendancePlanPerEmployee2> cccc= _Context.DailyActivities_AttendancePlanPerEmployee2.Where(c => c.Job == "مبرمج");
            string CompanyName = _Context.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.Company).FirstOrDefault();


            switch (P1)
            {
                case "Selected":
                    return View("EmpAdvertisement_Selected");

                case "All":
                    return View("EmpAdvertisement_All");

                case "Selected_TrainingContract":
                    string TrainingIssuer = _Context.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.TrainingContractIssuedFrom).FirstOrDefault();

                    TempData["Company_Name"] = CompanyName;
                    TempData["TrainingIssuerJob"] = _Context.Def_Employee.Where(a => a.Name == TrainingIssuer).Select(s => s.TreePosition).FirstOrDefault();
                    TempData["Company_Address"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Address).FirstOrDefault();
                    TempData["Company_CommercialRecord"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.CommercialRecord).FirstOrDefault();
                    TempData["Company_Neighborhood"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Neighborhood).FirstOrDefault();
                    TempData["Company_Street"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Street).FirstOrDefault();
                    TempData["Company_MailBox"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.MailBox).FirstOrDefault();
                    TempData["Company_Fax"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Fax).FirstOrDefault();

                    return View("TrainingContract");

                case "P_EmployemntContract":
                    string EmploymentIssuer = _Context.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractIssuedFrom).FirstOrDefault();
                    TempData["Company_Name"] = CompanyName;
                    TempData["EmploymentIssuerJob"] = _Context.Def_Employee.Where(a => a.Name == EmploymentIssuer).Select(s => s.TreePosition).FirstOrDefault();
                    TempData["Company_Address"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Address).FirstOrDefault();
                    TempData["Company_CommercialRecord"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.CommercialRecord).FirstOrDefault();
                    TempData["Company_Neighborhood"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Neighborhood).FirstOrDefault();
                    TempData["Company_Street"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Street).FirstOrDefault();
                    TempData["Company_MailBox"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.MailBox).FirstOrDefault();
                    TempData["Company_Fax"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Fax).FirstOrDefault();

                    string StartIn = _Context.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractFirstDay).FirstOrDefault().Value.Year.ToString();
                    string ExpireIn = _Context.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractExpireAt).FirstOrDefault().Value.Year.ToString();
                    TempData["EmploymentContractDuration"] = (int.Parse(ExpireIn) - int.Parse(StartIn)).ToString();

                    return View("EmployemntContract");

                case "P_EmpCard_V1":
                    return View("EmpCard_V1");

                case "P_EmpCard_V2":
                    return View("EmpCard_V2");

                case "P_Interviews":
                    return View("Interview");

                case "P_Interview_All":
                    return View("Interview_All");

                case "P_ApplyToJob":
                    return View("ApplyToJob");
                case "P_All_EmploymentContract":
                    return View("All_EmploymentContract");

                case "P_VacationRequest":
                    //if (string.IsNullOrEmpty(P5) || string.IsNullOrEmpty(P6))
                    //{
                    //    return View("ErrorPage");
                    //}

                    if (P8 == "Preview")
                    {
                        return View("VacationRequest");
                    }
                    else
                    {
                        //#############  Direct Printing ##################################### 
                        //--Declare Report
                        ReportsProj.Reports.ManagementDoc.Rep_VacationRequest MyReport = new ReportsProj.Reports.ManagementDoc.Rep_VacationRequest();

                        ////-- FilterString
                        //string Query = "";
                        //Query = "[RequestToDate] >= #" + P5 + "# And [RequestToDate] <= #" + P6 + "#";
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P2))
                        //{
                        //    Query = Query + "And [EmployeeCode] = {" + P2 + "}";
                        //}
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P7))
                        //{
                        //    Query = Query + "And Contains([Department], '" + P7 + "')";

                        //}
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P9))
                        //{
                        //    Query = Query + "And Contains([Urgency], '" + P9 + "')";
                        //}
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P10))
                        //{
                        //    Query = Query + "And Contains([RequestType], '" + P10 + "')";
                        //}
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P11))
                        //{
                        //    Query = Query + "And Contains([Name], '" + P11 + "')";
                        //}
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P12))
                        //{
                        //    Query = Query + "And Contains([Job], '" + P12 + "')";
                        //}
                        //MyReport.FilterString = Query;
                        MyReport.FilterString = "[Id] In (" + P2 + ")";

                        //--Set Header And Footer
                        MyReport.Parameters["P_RepHeader"].Value = P3;
                        MyReport.Parameters["P_UserName"].Value = P4;

                        //--Invisible Parameters Block
                        MyReport.RequestParameters = false;

                        // Go To Print
                        MyReport.CreateDocument();
                        DevExpress.XtraPrinting.PrintToolBase tool = new DevExpress.XtraPrinting.PrintToolBase(MyReport.PrintingSystem);
                        tool.Print();
                        return Ok();

                    }
                //############# / Direct Printing ##################################### 


                case "P_VacationRequest_LS":
                    //if (string.IsNullOrEmpty(P5) || string.IsNullOrEmpty(P6))
                    //{
                    //    return View("ErrorPage");
                    //}

                    if (P8 == "Preview")
                    {
                        return View("VacationRequest_LS");
                    }
                    else
                    {
                        //#############  Direct Printing ##################################### 
                        //--Declare Report
                        ReportsProj.Reports.ManagementDoc.Rep_VacationRequest_LS MyReport = new ReportsProj.Reports.ManagementDoc.Rep_VacationRequest_LS();

                        ////-- FilterString
                        //string Query = "";
                        //Query = "[RequestToDate] >= #" + P5 + "# And [RequestToDate] <= #" + P6 + "#";
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P2))
                        //{
                        //    Query = Query + "And [EmployeeCode] = {" + P2 + "}";
                        //}
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P7))
                        //{
                        //    Query = Query + "And Contains([Department], '" + P7 + "')";

                        //}
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P9))
                        //{
                        //    Query = Query + "And Contains([Urgency], '" + P9 + "')";
                        //}
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P10))
                        //{
                        //    Query = Query + "And Contains([RequestType], '" + P10 + "')";
                        //}
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P11))
                        //{
                        //    Query = Query + "And Contains([Name], '" + P11 + "')";
                        //}
                        //if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P12))
                        //{
                        //    Query = Query + "And Contains([Job], '" + P12 + "')";
                        //}
                        //MyReport.FilterString = Query;

                        //--Set Header And Footer
                        MyReport.Parameters["P_RepHeader"].Value = P3;
                        MyReport.Parameters["P_UserName"].Value = P4;

                        //--Invisible Parameters Block
                        MyReport.RequestParameters = false;

                        // Go To Print
                        MyReport.CreateDocument();
                        DevExpress.XtraPrinting.PrintToolBase tool = new DevExpress.XtraPrinting.PrintToolBase(MyReport.PrintingSystem);
                        tool.Print();
                        return Ok();

                    }
                    //############# / Direct Printing ##################################### 

                    

                    case "P_AttendanceShiftRequest_Selected":

                    if (P8 == "Preview")
                    {
                        return View("AttendanceShiftRequest");
                    }
                    else
                    {
                        //#############  Direct Printing ##################################### 
                        //--Declare Report
                        ReportsProj.Reports.ManagementDoc.Rep_AttendanceShiftRequest MyReport = new ReportsProj.Reports.ManagementDoc.Rep_AttendanceShiftRequest();



                        //--Set Header And Footer
                        MyReport.Parameters["P_RepHeader"].Value = P3;
                        MyReport.Parameters["P_UserName"].Value = P4;

                        //--Invisible Parameters Block
                        MyReport.RequestParameters = false;

                        // Go To Print
                        MyReport.CreateDocument();
                        DevExpress.XtraPrinting.PrintToolBase tool = new DevExpress.XtraPrinting.PrintToolBase(MyReport.PrintingSystem);
                        tool.Print();
                        return Ok();

                    }
                //############# / Direct Printing ##################################### 

                case "P_AttendanceShiftRequest_LS":

                    if (P8 == "Preview")
                    {
                        return View("AttendanceShiftRequest_All");
                    }
                    else
                    {
                        //#############  Direct Printing ##################################### 
                        //--Declare Report
                        ReportsProj.Reports.ManagementDoc.Rep_AttendanceShiftRequest_All MyReport = new ReportsProj.Reports.ManagementDoc.Rep_AttendanceShiftRequest_All();

                   

                        //--Set Header And Footer
                        MyReport.Parameters["P_RepHeader"].Value = P3;
                        MyReport.Parameters["P_UserName"].Value = P4;

                        //--Invisible Parameters Block
                        MyReport.RequestParameters = false;

                        // Go To Print
                        MyReport.CreateDocument();
                        DevExpress.XtraPrinting.PrintToolBase tool = new DevExpress.XtraPrinting.PrintToolBase(MyReport.PrintingSystem);
                        tool.Print();
                        return Ok();

                    }

                 //--------- Attendance Plane per Employee ---------
                  case "P_AttendancePlane":
                  return View("AttendancePlane_All");
                //--------- / Attendance Plane per Employee ---------

                //--------- Attendance Plane per Employee ---------
                case "P_AttendancePlane_Port_Ar":
                    return View("AttendancePlane_Port_Ar");



                //--------- Attendance Plane Permites ar ---------
                case "P_AttendancePlane_Permites_Ar":
                    return View("AttendancePlane_Permites_Ar");

                //--------- / Attendance Plane Permites ar ---------

                //--------- ApplyToJob_All ---------
                case "P_ApplyToJob_All":
                    return View("ApplyToJob_All");

                //--------- / ApplyToJob_All ---------

                //--------- ApplyToJobEn_All ---------
                case "P_ApplyToJobEn_All":
                    return View("ApplyToJobEn_All");

                //--------- / ApplyToJobEn_All ---------

                //--------- P_ApplyToJobOnline ---------
                case "P_ApplyToJobOnline":
                    return View("ApplyToJobOnline");

                //--------- / P_ApplyToJobOnline ---------

                //--------- P_ApplyToJobOnlinePage ---------
                case "P_ApplyToJobOnlinePage":
                    return View("ApplyToJobOnlinePage");

                //--------- / P_ApplyToJobOnlinePage ---------

                //--------- P_ApplyToJobOnlinePage_En ---------
                case "P_ApplyToJobOnlinePage_En":
                    return View("ApplyToJobOnlinePage_En");

                //--------- / P_ApplyToJobOnlinePage_En ---------

                //--------- P_ApplyToJobOnline_En ---------
                case "P_ApplyToJobOnline_En":
                    return View("ApplyToJobOnline_En");

                //--------- / P_ApplyToJobOnline_En ---------

                //--------- Attendance Plane per Employee en ---------
                case "P_AttendancePlane_Port_En":
                    return View("AttendancePlane_Port_En");
                //--------- / Attendance Plane per Employee en ---------

                //--------- FingerPrint_Filterd ---------
                case "P_FingerPrint_Filterd":
                    return View("FingerPrint_Filterd");
                //--------- / FingerPrint_Filterd ---------P_VacationsSummary

                //--------- Vacations Summary ---------
                case "P_VacationsSummary":
                    return View("VacationsSummary");
                //--------- / FingerPrint_Filterd ---------

                //--------- Schedule_Month  ---------
                case "P_Schedule_Month":
                    return View("Schedule_Month");
                //------ / Schedule_Month --------

                //--------- Schedule_Friday  ---------
                case "P_Schedule_Friday":
                    return View("Schedule_Friday");
                //------ / Schedule_Friday --------

                //--------- Schedule_All  ---------
                case "P_Schedule_All":
                    return View("Schedule_All");
                //------ / Schedule_All --------


                //############# / Direct Printing ##################################### 


                case "P_FingerPrint":
                    if (string.IsNullOrEmpty(P5) || string.IsNullOrEmpty(P6))
                    {
                        return View("ErrorPage");
                    }

                    if (P8 == "Preview" && !string.IsNullOrEmpty(P5))
                    {
                        return View("FingerPrint");
                    }
                    else
                    {
                        //#############  Direct Printing ##################################### 
                        //--Declare Report
                        ReportsProj.Reports.ManagementDoc.Rep_FingerPrint MyReport = new ReportsProj.Reports.ManagementDoc.Rep_FingerPrint();

                        //-- FilterString
                        string Query = "";
                        P6 = DateTime.Parse(P6).AddDays(1).ToString("MM/dd/yyyy");
                        Query = "[DateTimeRecord] >= #" + P5 + "# And [DateTimeRecord] <= #" + P6 + "#";

                        if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P2))
                        {
                            Query = Query + "And [IndRegID] = " + P2 + "";
                        }
                        if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P7))
                        {
                            Query = Query + "And [Department] = '" + P7 + "'";
                        }
                        if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P9))
                        {
                            Query = Query + "And [MachineNumber] = " + P9 + "";
                        }
                        if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P10))
                        {
                            Query = Query + "And Contains([TheType], '" + P10 + "')";
                        }
                        if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P11))
                        {
                            Query = Query + "And Contains([FullNameAr], '" + P11 + "')";
                        }
                        if (!string.IsNullOrEmpty(P5) && !string.IsNullOrEmpty(P12))
                        {
                            Query = Query + "And Contains([Job], '" + P12 + "')";
                        }
                        MyReport.FilterString = Query;

                        //--Set Header And Footer
                        MyReport.Parameters["P_RepHeader"].Value = P3;
                        MyReport.Parameters["P_UserName"].Value = P4;

                        //--Invisible Parameters Block
                        MyReport.RequestParameters = false;

                        // Go To Print
                        MyReport.CreateDocument();
                        DevExpress.XtraPrinting.PrintToolBase tool = new DevExpress.XtraPrinting.PrintToolBase(MyReport.PrintingSystem);
                        tool.Print();
                        return Ok();
                        //############# / Direct Printing ##################################### 

                    }




                default:
                    return View("ErrorPage");

            }

            #region peer switch
            //if (!string.IsNullOrEmpty(P1))
            //{
            //    if (P1 == "Selected")
            //    {
            //        return View("EmpAdvertisement_Selected");
            //    }
            //    else if (P1 == "All")
            //    {
            //        return View("EmpAdvertisement_All");
            //    }        
            //    else if (P1 == "Selected_TrainingContract")
            //    {
            //        string CompanyName = _Context.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.Company).FirstOrDefault();
            //        string TrainingIssuer = _Context.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.TrainingContractIssuedFrom).FirstOrDefault();

            //        TempData["Company_Name"] = CompanyName;
            //        TempData["TrainingIssuerJob"] = _Context.Def_Employee.Where(a => a.Name == TrainingIssuer).Select(s => s.TreePosition).FirstOrDefault();
            //        TempData["Company_Address"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Address).FirstOrDefault();
            //        TempData["Company_CommercialRecord"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.CommercialRecord).FirstOrDefault();
            //        TempData["Company_Neighborhood"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Neighborhood).FirstOrDefault();
            //        TempData["Company_Street"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Street).FirstOrDefault();
            //        TempData["Company_MailBox"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.MailBox).FirstOrDefault();
            //        TempData["Company_Fax"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Fax).FirstOrDefault();

            //        return View("TrainingContract");
            //    }
            //    else if (P1 == "P_EmployemntContract")
            //    {
            //        string CompanyName = _Context.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.Company).FirstOrDefault();
            //        string EmploymentIssuer = _Context.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractIssuedFrom).FirstOrDefault();

            //        TempData["Company_Name"] = CompanyName;
            //        TempData["EmploymentIssuerJob"] = _Context.Def_Employee.Where(a => a.Name == EmploymentIssuer).Select(s => s.TreePosition).FirstOrDefault();
            //        TempData["Company_Address"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Address).FirstOrDefault();
            //        TempData["Company_CommercialRecord"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.CommercialRecord).FirstOrDefault();
            //        TempData["Company_Neighborhood"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Neighborhood).FirstOrDefault();
            //        TempData["Company_Street"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Street).FirstOrDefault();
            //        TempData["Company_MailBox"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.MailBox).FirstOrDefault();
            //        TempData["Company_Fax"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Fax).FirstOrDefault();

            //        string StartIn= _Context.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractFirstDay).FirstOrDefault().Value.Year.ToString();
            //        string ExpireIn = _Context.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractExpireAt).FirstOrDefault().Value.Year.ToString();

            //        TempData["EmploymentContractDuration"]  = (int.Parse(ExpireIn) - int.Parse(StartIn)).ToString();
            //        //TempData["EmploymentContractDuration"] = _Context.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Fax).FirstOrDefault();


            //        return View("EmployemntContract");
            //    }
            //    else if (P1 == "P_EmpCard_V1")
            //    {
            //        return View("EmpCard_V1");


            //        ////****  Direct Printing  *****
            //        ////--- Declare Report
            //        //ReportsProj.Reports.ManagementDoc.Rep_EmpCard_V1 MyReport = new ReportsProj.Reports.ManagementDoc.Rep_EmpCard_V1();
            //        ////--- Specify the report properties
            //        //MyReport.FilterString = "[Id] In (" + TempData["P_Id"] + ")";
            //        //MyReport.Parameters["P_UserName"].Value = TempData["P_User"];
            //        //MyReport.Parameters["P_RepHeader"].Value = TempData["P_T_Header"];
            //        //MyReport.RequestParameters = false;
            //        ////--- Go To Print
            //        //MyReport.CreateDocument();
            //        //DevExpress.XtraPrinting.PrintToolBase tool = new DevExpress.XtraPrinting.PrintToolBase(MyReport.PrintingSystem);
            //        //tool.Print();
            //        //return Ok();
            //        ////**** / Direct Printing  *****

            //    }
            //    else if (P1 == "P_EmpCard_V2")
            //    {
            //        return View("EmpCard_V2");


            //        ////****  Direct Printing  *****
            //        ////--- Declare Report
            //        //ReportsProj.Reports.ManagementDoc.Rep_EmpCard_V2 MyReport = new ReportsProj.Reports.ManagementDoc.Rep_EmpCard_V2();
            //        ////--- Specify the report properties
            //        //MyReport.FilterString = "[Id] In (" + TempData["P_Id"] + ")";
            //        //MyReport.Parameters["P_UserName"].Value = TempData["P_User"];
            //        //MyReport.Parameters["P_RepHeader"].Value = TempData["P_T_Header"];
            //        //MyReport.RequestParameters = false;
            //        ////--- Go To Print
            //        //MyReport.CreateDocument();
            //        //DevExpress.XtraPrinting.PrintToolBase tool = new DevExpress.XtraPrinting.PrintToolBase(MyReport.PrintingSystem);
            //        //tool.Print();
            //        //return Ok();
            //        ////**** / Direct Printing  ***** 

            //    }
            //    else if (P1 == "P_Interviews")
            //    {
            //        return View("Interview");
            //    }
            //    else if (P1 == "P_Interviews_All")
            //    {
            //        return View("Interviews_All");
            //    }
            //    else if (P1 == "P_ApplyToJob")
            //    {
            //        return View("ApplyToJob");
            //    }
            //    else
            //    {
            //        return View("ErrorPage");
            //    }
            //}
            #endregion
        }
    }
}
