
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReportsProj.DBC;

namespace ReportsProj.Controllers
{
    public class ManagementDefController : Controller
    {

        #region DI

        private readonly IConfiguration _Configuration;
        private readonly Management_DBC _Management_DBC;
        public ManagementDefController(IConfiguration Configuration, Management_DBC Management_DBC)
        {
            _Configuration = Configuration;
            _Management_DBC = Management_DBC;
        }

        #endregion

        //-- Params Description-- p1=Report Method >>All or Selected or Details & P2=Id>>1,3 &p3=TableName>>Def_Country &P4>>Report Addressp & P5=UserName >>Admin
        //-- Test_All  Params>> /ManagementDef?P1=All&P3=Def_Country&P4=عنوان التقرير&P5=admin&Col1=Title&Col2=TitleEn
        //-- Test_Selected  Params>> /ManagementDef?P1=Selected&P2=1,2,4,5&P3=Def_Country&P4=عنوان التقرير&P5=admin&Col1=Title&Col2=TitleEn
        //-- Test_Details  Params>> /ManagementDef?P1=Details&P2=1,2,4,5&P3=Def_Country&P4=عنوان التقرير&P5=admin&Col1=Title&Col2=TitleEn

        public IActionResult Index( string P1 = "", string P2 = "", string P3 = "", string P4 = "", string P5="" ,
                                    string Col1="", string Col2 = "", string Col3 = "", string Col4 = "", string Col5 = "")
        {

            TempData["P_Id"] = P2;
            MyDatasource(P3);
            TempData["P_T_Header"] = P4;
            TempData["P_User"] = P5;

            TempData["Col1"] = "[" + Col1 + "]";
            TempData["Col2"] = "[" + Col2 + "]";
            TempData["Col3"] = "[IsEnabled]";
            TempData["Col4"] = "[IsDefault]";
            TempData["Col5"] = "[Notes]";


            if (!string.IsNullOrEmpty(P1))
            {
                if (P1 == "Selected")
                {
                    return View("Management_Selected");
                }
                if (P1 == "Details")
                {
                    return View("Management_DetailsSelected");
                }
                else if (P1 == "All")
                {
                    return View("Management_All");
                }
                else
                {
                    return View("ErrorPage");
                }
            }


            return View();
        }

        //-- DataSources
        public void MyDatasource(string TableName)
        {
            switch (TableName)
            {


                case "Def_AcademicGradeType":
                    TempData["MyDatasource"] = _Management_DBC.Def_AcademicGradeType.ToList();
                    break;
                case "Def_AdditionType":
                    TempData["MyDatasource"] = _Management_DBC.Def_AdditionType.ToList();
                    break;
                case "Def_BusinessSector":
                    TempData["MyDatasource"] = _Management_DBC.Def_BusinessSector.ToList();
                    break;
                case "Def_CandidateStatusType":
                    TempData["MyDatasource"] = _Management_DBC.Def_CandidateStatusType.ToList();
                    break;
                case "Def_City":
                    TempData["MyDatasource"] = _Management_DBC.Def_City.ToList();
                    break;
                case "Def_ContactType":
                    TempData["MyDatasource"] = _Management_DBC.Def_ContactType.ToList();
                    break;
                case "Def_ContractType":
                    TempData["MyDatasource"] = _Management_DBC.Def_ContractType.ToList();
                    break;
                case "Def_Country":
                    TempData["MyDatasource"] = _Management_DBC.Def_Country.ToList();
                    break;
                case "Def_Deduction":
                    TempData["MyDatasource"] = _Management_DBC.Def_Deduction.ToList();
                    break;
                case "Def_DepartmentType":
                    TempData["MyDatasource"] = _Management_DBC.Def_DepartmentType.ToList();
                    break;

                case "Def_Employee":
                    TempData["MyDatasource"] = _Management_DBC.Def_Employee.ToList();
                    break;
                case "Def_EmployeesTree":
                    TempData["MyDatasource"] = _Management_DBC.Def_EmployeesTree.ToList();
                    break;
                case "Def_EvacuationType":
                    TempData["MyDatasource"] = _Management_DBC.Def_EvacuationType.ToList();
                    break;
                case "Def_FileType":
                    TempData["MyDatasource"] = _Management_DBC.Def_FileType.ToList();
                    break;
                case "Def_JobTitle":
                    TempData["MyDatasource"] = _Management_DBC.Def_JobTitle.ToList();
                    break;
                case "Def_Language":
                    TempData["MyDatasource"] = _Management_DBC.Def_Language.ToList();
                    break;
                case "Def_MaritalStatus":
                    TempData["MyDatasource"] = _Management_DBC.Def_MaritalStatus.ToList();
                    break;
                case "Def_MoneyPayTurnover":
                    TempData["MyDatasource"] = _Management_DBC.Def_MoneyPayTurnover.ToList();
                    break;
                case "Def_Nationality":
                    TempData["MyDatasource"] = _Management_DBC.Def_Nationality.ToList();
                    break;
                case "Def_RelativeType":
                    TempData["MyDatasource"] = _Management_DBC.Def_RelativeType.ToList();
                    break;
                case "Def_Religion":
                    TempData["MyDatasource"] = _Management_DBC.Def_Religion.ToList();
                    break;
                case "Def_Salutation":
                    TempData["MyDatasource"] = _Management_DBC.Def_Salutation.ToList();
                    break;
                case "Def_Sex":
                    TempData["MyDatasource"] = _Management_DBC.Def_Sex.ToList();
                    break;
                case "Def_State":
                    TempData["MyDatasource"] = _Management_DBC.Def_State.ToList();
                    break;
                case "Def_University":
                    TempData["MyDatasource"] = _Management_DBC.Def_University.ToList();
                    break;
                case "Def_VacationType":
                    TempData["MyDatasource"] = _Management_DBC.Def_VacationType.ToList();
                    break;
                case "Def_Department":
                    TempData["MyDatasource"] = _Management_DBC.Def_Department.ToList();
                    break;
                case "Def_Company":
                    TempData["MyDatasource"] = _Management_DBC.Def_Company.ToList();
                    break;
                case "Def_Branch":
                    TempData["MyDatasource"] = _Management_DBC.Def_Branch.ToList();
                    break;
                case "Def_Qualification":
                    TempData["MyDatasource"] = _Management_DBC.Def_Qualification.ToList();
                    break;

                    //default:
                    //    View("ErrorPage");
                    //    break;
            }
        }
    }
}
