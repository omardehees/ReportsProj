using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReportsProj.DBC;
using DevExpress.XtraReports.Web.WebDocumentViewer;
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

        //-- Params Description-- p1=Report Method >>All or Selected & P2=Id>>1,3 &P3>>Report Address & P4=UserName >>Admin & P5=From >>10/10/2020 & P6=To >>11/11/2020 

        //-- Test_adv_All  Params>> /ManagementDoc?P1=All&P3=اعلانات%20التوظيف&P4=admin  
        //-- Test_adv_Selected  Params>> /ManagementDoc?P1=Selected&P2=18,19,20&P3=اعلان%20التوظيف&P4=admin 
        //-- Test_EmpCard_V1  Params>> /ManagementDoc?P1=P_EmpCard_V1&P2=379&P3=Employee20%Card&P4=admin 
        //-- Test_EmpCard_V2  Params>> /ManagementDoc?P1=P_EmpCard_V2&P2=379&P3=Employee20%Card&P4=admin 
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

        //--------- / البصمات  -------------------------------------

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



            string CompanyName = _Management_DBC.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.Company).FirstOrDefault();


            switch (P1)
            {
                case "Selected":
                    return View("EmpAdvertisement_Selected");

                case "All":
                    return View("EmpAdvertisement_All");

                case "Selected_TrainingContract":
                    string TrainingIssuer = _Management_DBC.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.TrainingContractIssuedFrom).FirstOrDefault();

                    TempData["Company_Name"] = CompanyName;
                    TempData["TrainingIssuerJob"] = _Management_DBC.Def_Employee.Where(a => a.Name == TrainingIssuer).Select(s => s.TreePosition).FirstOrDefault();
                    TempData["Company_Address"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Address).FirstOrDefault();
                    TempData["Company_CommercialRecord"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.CommercialRecord).FirstOrDefault();
                    TempData["Company_Neighborhood"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Neighborhood).FirstOrDefault();
                    TempData["Company_Street"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Street).FirstOrDefault();
                    TempData["Company_MailBox"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.MailBox).FirstOrDefault();
                    TempData["Company_Fax"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Fax).FirstOrDefault();

                    return View("TrainingContract");

                case "P_EmployemntContract":
                    string EmploymentIssuer = _Management_DBC.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractIssuedFrom).FirstOrDefault();
                    TempData["Company_Name"] = CompanyName;
                    TempData["EmploymentIssuerJob"] = _Management_DBC.Def_Employee.Where(a => a.Name == EmploymentIssuer).Select(s => s.TreePosition).FirstOrDefault();
                    TempData["Company_Address"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Address).FirstOrDefault();
                    TempData["Company_CommercialRecord"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.CommercialRecord).FirstOrDefault();
                    TempData["Company_Neighborhood"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Neighborhood).FirstOrDefault();
                    TempData["Company_Street"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Street).FirstOrDefault();
                    TempData["Company_MailBox"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.MailBox).FirstOrDefault();
                    TempData["Company_Fax"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Fax).FirstOrDefault();

                    string StartIn = _Management_DBC.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractFirstDay).FirstOrDefault().Value.Year.ToString();
                    string ExpireIn = _Management_DBC.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractExpireAt).FirstOrDefault().Value.Year.ToString();
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

                    }
                //############# / Direct Printing ##################################### 




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
            //        string CompanyName = _Management_DBC.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.Company).FirstOrDefault();
            //        string TrainingIssuer = _Management_DBC.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.TrainingContractIssuedFrom).FirstOrDefault();

            //        TempData["Company_Name"] = CompanyName;
            //        TempData["TrainingIssuerJob"] = _Management_DBC.Def_Employee.Where(a => a.Name == TrainingIssuer).Select(s => s.TreePosition).FirstOrDefault();
            //        TempData["Company_Address"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Address).FirstOrDefault();
            //        TempData["Company_CommercialRecord"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.CommercialRecord).FirstOrDefault();
            //        TempData["Company_Neighborhood"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Neighborhood).FirstOrDefault();
            //        TempData["Company_Street"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Street).FirstOrDefault();
            //        TempData["Company_MailBox"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.MailBox).FirstOrDefault();
            //        TempData["Company_Fax"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Fax).FirstOrDefault();

            //        return View("TrainingContract");
            //    }
            //    else if (P1 == "P_EmployemntContract")
            //    {
            //        string CompanyName = _Management_DBC.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.Company).FirstOrDefault();
            //        string EmploymentIssuer = _Management_DBC.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractIssuedFrom).FirstOrDefault();

            //        TempData["Company_Name"] = CompanyName;
            //        TempData["EmploymentIssuerJob"] = _Management_DBC.Def_Employee.Where(a => a.Name == EmploymentIssuer).Select(s => s.TreePosition).FirstOrDefault();
            //        TempData["Company_Address"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Address).FirstOrDefault();
            //        TempData["Company_CommercialRecord"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.CommercialRecord).FirstOrDefault();
            //        TempData["Company_Neighborhood"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Neighborhood).FirstOrDefault();
            //        TempData["Company_Street"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Street).FirstOrDefault();
            //        TempData["Company_MailBox"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.MailBox).FirstOrDefault();
            //        TempData["Company_Fax"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Fax).FirstOrDefault();

            //        string StartIn= _Management_DBC.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractFirstDay).FirstOrDefault().Value.Year.ToString();
            //        string ExpireIn = _Management_DBC.Doc_CVs.Where(a => a.Id.ToString() == P2).Select(d => d.EmploymentContractExpireAt).FirstOrDefault().Value.Year.ToString();

            //        TempData["EmploymentContractDuration"]  = (int.Parse(ExpireIn) - int.Parse(StartIn)).ToString();
            //        //TempData["EmploymentContractDuration"] = _Management_DBC.Def_Company.Where(a => a.Title == CompanyName).Select(s => s.Fax).FirstOrDefault();


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
