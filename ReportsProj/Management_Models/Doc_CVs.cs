using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ReportsProj.PM_Model;

namespace ReportsProj.Management_Models
{
    public class Doc_CVs : _EntityBase
    {
        //CodeTemplate                      drbdApplyToJobObj_Code
        //MaritalStatusTemplate              drbdApplyToJobObj_MaritalStatus
        //BasicData---------------------------------------------------
        public Guid CVCode { get; set; }
        public string JobAdvertizementCode { get; set; } = "";
        //Basic Data
        public string FirstNameAr { get; set; } = "";
        public string MiddleNameAr { get; set; } = "";
        public string LastNameAr { get; set; } = "";
        public string SurnameAr { get; set; } = "";
        public string FirstNameEn { get; set; } = "";
        public string MiddleNameEn { get; set; } = "";
        public string LastNameEn { get; set; } = "";
        public string SurnameEn { get; set; } = "";
        public string SocialSurnameAr { get; set; }
        public string SocialSurnameEn { get; set; } = "";
        public string FullNameAr { get; set; } = "";//*****************جديد
        public string FullNameEn { get; set; } = "";//*****************جديد
        public string Sex { get; set; } = "";
        public string SexEn { get; set; } = "";
        public string MaritalStatus { get; set; } = "";//*****************جديد
        public string MaritalStatusEn { get; set; } = "";//*****************جديد
        public int Kids { get; set; } //*****************جديد
        public bool ResidentWife { get; set; } = false;//*****************جديد
        public string Country { get; set; } = "";
        public string CountryEn { get; set; } = "";
        public string State { get; set; } = "";
        public string City { get; set; } = "";
        public string CityEn { get; set; } = "";
        public string Address { get; set; } = "";
        public string Language { get; set; } = "";
        public string LanguageEn { get; set; } = "";
        public string IDDocumentType { get; set; } = "";
        public string IDDocumentTypeEn { get; set; } = "";
        public string IDDocumentNumber { get; set; } = "";
        public string IDDocumentIssuedFrom { get; set; } = "";//*****************جديد
        public DateTime? IDDocumentIssuedAt { get; set; }
        public DateTime? IDDocumentExpireAt { get; set; }
        public string IDDocumentNotes { get; set; } = ""; //*****************جديد   
        public DateTime? DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; } = "";
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string Photo { get; set; } = "";
        //public bool HaveDrivingLicense { get; set; } = false;///////////////////////////////////////////////////
        public string MilitaryServiceStatus { get; set; } = "";
        public string BankTitle { get; set; } = "";//*****************جديد
        public string BankTitleEn { get; set; } = "";//*****************جديد
        public string BankIBAN { get; set; } = "";//*****************جديد
        public string BankCurrency { get; set; } = "";//*****************جديد
        public string BankAccountNumber { get; set; } = "";//*****************جديد
        //Education       
        public string AcademicGradeType { get; set; } = "";
        public string AcademicGradeTypeEn { get; set; } = "";
        public string Qualification { get; set; } = "";
        public string QualificationEn { get; set; } = "";
        public string Specialization { get; set; } = "";
        public string Univeristy { get; set; } = "";
        public string UniveristyEn { get; set; } = "";
        public DateTime? GraduationDate { get; set; }
        public string GraduationGrade { get; set; } = "";
        public string GraduationProject { get; set; } = "";
        public string GraduationProjectGrade { get; set; } = "";
        public string Religion { get; set; } = "";
        public string ReligionEn { get; set; } = "";
        public DateTime? AvailableFrom { get; set; }
        public Double? ExpectedSalary { get; set; }
        public string Certificates { get; set; } = "";
        public string Skills { get; set; } = "";
        //Current Job
        public int? YearsOfExperience { get; set; }
        public string CurrentCompany { get; set; } = "";
        public string CurrentJob { get; set; } = "";
        public string CurrentJobDescription { get; set; } = "";
        public DateTime? CurrentJobFrom { get; set; }
        public decimal? CurrentJobSalary { get; set; }
        public string PreviousCompanies { get; set; } = "";
        public bool WorkedInOurFirmBefore { get; set; } = false;//*****************جديد
        public DateTime? WorkedInOurFirmBeforeFrom { get; set; } //*****************جديد
        public DateTime? WorkedInOurFirmBeforeTo { get; set; } //*****************جديد

        //The User
        public string TheUser { get; set; } = "";
        public string Office { get; set; } = "";
        public string DeliveryMethod { get; set; } = "";
        public DateTime? TheDate { get; set; }
        //Contact Info
        public string Phone { get; set; } = "";
        public string Mobile { get; set; } = "";
        public string Email { get; set; } = "";
        public string Google { get; set; } = "";
        public string YouTube { get; set; } = "";
        public string Microsoft { get; set; } = "";
        public string Facebook { get; set; } = "";
        public string Instagram { get; set; } = "";
        public string Telegram { get; set; } = "";
        public string WhatsApp { get; set; } = "";
        public string LinkedIn { get; set; } = "";
        //Governmental Documents . --------------------------------------------------------------------
        public string PracticeLicenseIssuedFrom { get; set; } = "";//*****************جديد
        public string PracticeLicenseNumber { get; set; } = "";//*****************جديد
        public DateTime? PracticeLicenseIssuedAt { get; set; } //*****************جديد
        public DateTime? PracticeLicenseExpireAt { get; set; } //*****************
        public string PracticeLicenseNotes { get; set; } = ""; //*****************جديد
        public string SyndicateIssuedFrom { get; set; } = "";//*****************جديد        
        public string SyndicateNumber { get; set; } = "";//*****************جديد
        public DateTime? SyndicateIssuedAt { get; set; }//*****************جديد
        public DateTime? SyndicateExpireAt { get; set; }//*****************جديد
        public string SyndicateNotes { get; set; } = ""; //*****************جديد
        public string PassportIssuedFrom { get; set; } = "";//*****************جديد
        public string PassportNumber { get; set; } = "";//*****************جديد
        public DateTime? PassportIssuedAt { get; set; }//*****************جديد
        public DateTime? PassportExpireAt { get; set; }//*****************جديد
        public string PassportNotes { get; set; } = ""; //*****************جديد
        public string VisaIssuedFrom { get; set; } = "";//*****************جديد
        public string VisaNumber { get; set; } = "";//*****************جديد
        public DateTime? VisaIssuedAt { get; set; }//*****************جديد
        public DateTime? VisaExpireAt { get; set; }//*****************جديد
        public string VisaNotes { get; set; } = ""; //*****************جديد
        public string ResidenceIssuedFrom { get; set; } = "";//*****************جديد
        public string ResidenceNumber { get; set; } = "";//*****************جديد
        public DateTime? ResidenceIssuedAt { get; set; }//*****************جديد
        public DateTime? ResidenceExpireAt { get; set; }//*****************جديد
        public string ResidenceNotes { get; set; } = ""; //*****************جديد
        public string InsuranceIssuedFrom { get; set; } = "";//*****************جديد
        public string InsuranceClass { get; set; } = "";//*****************جديد
        public string InsuranceNumber { get; set; } = "";//*****************جديد
        public string InsuranceTerm { get; set; } = "";//*****************جديد
        public decimal? InsuranceValue { get; set; } //*****************جديد
        public decimal? InsuranceEmployeeSharePercentage { get; set; } //*****************جديد
        public DateTime? InsuranceIssuedAt { get; set; } //*****************جديد
        public DateTime? InsuranceExpireAt { get; set; } //*****************جديد
        public string InsuranceNotes { get; set; } = ""; //*****************جديد
        public string DrivingLicenceIssuedFrom { get; set; } = "";//*****************جديد
        public string DrivingLicenceClass { get; set; } = "";//*****************جديد  
        public string DrivingLicenceNumber { get; set; } = "";//*****************جديد
        public DateTime? DrivingLicenceIssuedAt { get; set; }//*****************جديد
        public DateTime? DrivingLicenceExpireAt { get; set; }//*****************جديد
        public string DrivingLicenceNotes { get; set; } = ""; //*****************جديد
        //Training . --------------------------------------------------------------------
        public string TrainingContractCode { get; set; } = "";//*****************جديد
        public string TrainingContractType { get; set; } = "";//*****************جديد
        public string TrainingContractWeekDays { get; set; } = "";//*****************جديد
        public int? TrainingContractWeekHours { get; set; } //*****************جديد
        public string TrainingContractIssuedFrom { get; set; } = ""; //*****************جديد
        public DateTime? TrainingContractIssuedAt { get; set; }//*****************جديد
        public DateTime? TrainingContractExpireAt { get; set; }//*****************جديد
        public string TrainingContractStatus { get; set; } = "";//*****************جديد
        public DateTime? TrainingContractLatestDay { get; set; } //*****************جديد
        public string TrainingContractFinalEvaluation { get; set; } = "";//*****************جديد
        public int? TrainingContractFinalEvaluationFrom100 { get; set; } //*****************جديد
        public decimal? TrainingContractBasicSalary { get; set; } //*****************جديد
        public string TrainingContractBasicTerm { get; set; } = "";//*****************جديد
        public string TrainingContractNotes { get; set; } = ""; //*****************جديد
        //job Details . --------------------------------------------------------------------
        public string EmployeeId { get; set; } = "";//*****************جديد
        public string EmployeeAccountNumber { get; set; } = "";//*****************جديد
        public string Company { get; set; } = "";//*****************جديد
        public string Department { get; set; } = "";//*****************جديد
        public string DepartmentEn { get; set; } = "";//*****************جديد
        public string Job { get; set; } = "";//*****************جديد
        public string JobEn { get; set; } = "";//*****************جديد
        public string JobTreePosition { get; set; } = "";//*****************جديد
        public string JobTreePositionEn { get; set; } = "";//*****************جديد
        public string JobDescription { get; set; } = "";//*****************جديد
        public string JobDescriptionEn { get; set; } = "";//*****************جديد
        public string SaudiStandardJobCode { get; set; } = "";//*****************جديد
        public string EmploymentContractCode { get; set; } = "";//*****************جديد
        public string EmploymentContractType { get; set; } = "";//*****************جديد
        public string EmploymentContractWeekDays { get; set; } = "";//*****************جديد
        [Range(0, 112)]//maximun 16 every weekday
        public int? EmploymentContractWeekHours { get; set; } //*****************جديد
        public string EmploymentContractIssuedFrom { get; set; } = ""; //*****************جديد
        public DateTime? EmploymentContractIssuedAt { get; set; } //*****************جديد
        public DateTime? EmploymentContractFirstDay { get; set; } //*****************جديد
        public DateTime? EmploymentContractExpireAt { get; set; } //*****************جديد
        public string EmploymentContractStatus { get; set; } = "";//*****************جديد
        public DateTime? EmploymentContractLatestDay { get; set; } //*****************جديد
        public string EmploymentContractLastEvaluation { get; set; } = "";//*****************جديد
        public string EmploymentContractCumulativeEvaluation { get; set; } = "";//*****************جديد
        [Range(0, 100)]
        public int? EmploymentContractCumulativeEvaluationFrom100 { get; set; } //*****************جديد
        public decimal? EmploymentContractBasicSalary { get; set; } //*****************جديد
        public string EmploymentContractBasicSalaryTerm { get; set; } = "";//*****************جديد
        public decimal? EmploymentContractIncomeShareValue { get; set; } //*****************جديد
        public string EmploymentContractIncomeShareRoles { get; set; } = "";//*****************جديد
        public decimal? EmploymentContractOOD { get; set; } //*****************جديد
        public decimal? EmploymentContractSalaryIncreamentValue { get; set; } //*****************جديد
        public string EmploymentContractSalaryIncreamentRole { get; set; } = "";//*****************جديد
        [Range(0, 200)]
        public int? AllowancesVacationPeriodInDays { get; set; } //*****************جديد
        public int? AllowancesVacationPeriodInDays_Sickness { get; set; } //*****************جديد
        public string EmploymentContractNotes { get; set; } = ""; //*****************جديد
        //Badalaaaaaaaaaaaaaaaaat
        public bool AllowancesHousingExists { get; set; } = false;//*****************جديد
        public string AllowancesHousingTerm { get; set; } = "";//*****************جديد
        public decimal? AllowancesHousingValue { get; set; } //*****************جديد
        public string AllowancesHousingNotes { get; set; } = ""; //*****************جديد
        public bool AllowancesTransferExists { get; set; } = false;//*****************جديد
        public string AllowancesTransferTerm { get; set; } = "";//*****************جديد
        public decimal? AllowancesTransferValue { get; set; } //*****************جديد
        public string AllowancesTransferNotes { get; set; } = ""; //*****************جديد
        public bool AllowancesFoodExists { get; set; } = false;//*****************جديد
        public string AllowancesFoodTerm { get; set; } = "";//*****************جديد
        public decimal? AllowancesFoodValue { get; set; } //*****************جديد
        public string AllowancesFoodNotes { get; set; } = ""; //*****************جديد
        public bool AllowancesFlightTicketExists { get; set; } = false;//*****************جديد
        public string AllowancesFlightTicketTerm { get; set; } = "";//*****************جديد
        public decimal? AllowancesFlightTicketValue { get; set; } //*****************جديد
        public string AllowancesFlightTicketNotes { get; set; } = ""; //*****************جديد
        //public bool AllowancesVacationExists { get; set; } = false;//*****************جديد
        //public string AllowancesVacationType { get; set; } = "";//*****************جديد
        //public string AllowancesVacationTerm { get; set; } = "";//*****************جديد
        //[Range(0, 200)]---------------- تم النق لعقدج التوظيفة
        //public int? AllowancesVacationPeriodInDays { get; set; } //*****************جديد
        //public string AllowancesVacationNotes { get; set; } = ""; //*****************جديد  
        public string Roles { get; set; } = ""; //*****************جديد
        public string RolesEn { get; set; } = ""; //*****************جديد
    }
}
