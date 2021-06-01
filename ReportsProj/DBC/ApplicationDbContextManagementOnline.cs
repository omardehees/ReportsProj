using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReportsProj.Management_Models;

namespace ReportsProj.DBC
{
    public class ApplicationDbContextManagementOnline : DbContext
    {
        //public IConfiguration _configuration { get; }
        //public ApplicationDbContext(IConfiguration configuration)
        //{
        //    _configuration= configuration;
        //}        
        string InitialiezerFolderPath;
        //-----------------------------
        public ApplicationDbContextManagementOnline(DbContextOptions<ApplicationDbContextManagementOnline> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            ////builder.Entity<c_InboxEntities>().HasIndex(u => u.Title).IsUnique();
            //builder.Entity<cActivity>().Property(p => p.Id).ValueGeneratedOnAdd();
            //builder.Entity<cActivity>().Property(p => p.Id).ValueGeneratedOnAdd();
            //builder.Entity<cActivity>().Property(p => p.Id).ValueGeneratedOnAdd();
            //builder.Entity<cActivity>().Property(b => b.Id).UseIdentityColumn();
            //builder.Entity<cLanguage>().Property(b => b.Id).UseIdentityColumn();
            //builder.Entity<cCountry>().Property(b => b.Id).UseIdentityColumn();
            //builder.Entity<cCSR>().Property(b => b.Id).UseIdentityColumn();
            //builder.Entity<cOrganization>().Property(b => b.Id).UseIdentityColumn();
            ////builder.Entity<cDepartment>().Property(b => b.Code).HasDefaultValueSql("NEWID()");
            //builder.Entity<Def_Employee>().Property(b => b.Code).HasDefaultValueSql("NEWID()");
            //builder.Entity<cService>().Property(b => b.Code).HasDefaultValueSql("NEWID()");
            //builder.Entity<c_Inbox>().Property(b => b.Timestamp).HasDefaultValueSql("getDate()");
            //builder.Entity<c_Outbox>().Property(b => b.Timestamp).HasDefaultValueSql("getDate()");
            //// ----------------------- Default Values ---------------------------------------------------
            //builder.Entity<cOrganization>(entity => { entity.Property(e => e.IsEnabled).HasDefaultValue(1); });
            //builder.Entity<cOrganization>(entity => { entity.Property(e => e.IsEnabled).HasDefaultValue(0); });
            //builder.Entity<cOrganization>(entity => { entity.Property(e => e.IsChiledOrganization).HasDefaultValue(0); });
            //builder.Entity<cCSR>(entity => { entity.Property(e => e.CurrentStatus_At).HasDefaultValueSql("GetDate()"); });
            //builder.Entity<cCSR>(entity => { entity.Property(e => e.CreationDate).HasDefaultValueSql("GetDate()"); });
            //builder.Entity<cCSR>(entity => { entity.Property(e => e.CurrentStatus).HasDefaultValue("جديد"); });
            //builder.Entity<Def_Employee>(entity => { entity.Property(e => e.Code).HasDefaultValueSql("NEWID()"); });
            ////Initial Data ------------------------------------------------------------------------
            ////InitialiezerFolderPath = _configuration.GetSection("Pathes").GetSection("InitialiezerFolderPath").Value.ToString();
            //InitialiezerFolderPath = "Initializer/";
            ////الجداول الطرفية
            //IEnumerable<cLanguage> Language_Seeding = (InitialiezerFolderPath + "_Language.xlsx").ExcelToEnumerable<cLanguage>(x => x.UsingHeaderNames(true));
            //builder.Entity<cLanguage>().HasData(Language_Seeding);
            //IEnumerable<cCountry> Country_Seeding = (InitialiezerFolderPath + "_Country.xlsx").ExcelToEnumerable<cCountry>(x => x.UsingHeaderNames(true));
            //builder.Entity<cCountry>().HasData(Country_Seeding);
            //IEnumerable<cActivity> Activity_Seeding = (InitialiezerFolderPath + "_Activity.xlsx").ExcelToEnumerable<cActivity>(x => x.UsingHeaderNames(true));
            //builder.Entity<cActivity>().HasData(Activity_Seeding);           
            //IEnumerable<cPatient> _Patient_Seeding = (InitialiezerFolderPath + "_Patient.xlsx").ExcelToEnumerable<cPatient>(x => x.UsingHeaderNames(true));
            //builder.Entity<cPatient>().HasData(_Patient_Seeding);
            //IEnumerable<cSector> _Sector_Seeding = (InitialiezerFolderPath + "_Sector.xlsx").ExcelToEnumerable<cSector>(x => x.UsingHeaderNames(true));
            //builder.Entity<cSector>().HasData(_Sector_Seeding);
            ////IEnumerable<cDepartment> _Department_Seeding = (InitialiezerFolderPath + "_Department.xlsx").ExcelToEnumerable<cDepartment>(x => x.UsingHeaderNames(true));
            ////builder.Entity<cDepartment>().HasData(_Department_Seeding);
            //IEnumerable<Def_Employee> _Employee_Seeding = (InitialiezerFolderPath + "_Employee.xlsx").ExcelToEnumerable<Def_Employee>(x => x.UsingHeaderNames(true));
            //builder.Entity<Def_Employee>().HasData(_Employee_Seeding);

            //IEnumerable<cRelationship> _Relationship_Seeding = (InitialiezerFolderPath + "_Relationship.xlsx").ExcelToEnumerable<cRelationship>(x => x.UsingHeaderNames(true));
            //builder.Entity<cRelationship>().HasData(_Relationship_Seeding);

            //IEnumerable<cService> _Service_Seeding = (InitialiezerFolderPath + "_Service.xlsx").ExcelToEnumerable<cService>(x => x.UsingHeaderNames(true));
            //builder.Entity<cService>().HasData(_Service_Seeding);
            //IEnumerable<c_DocumentType> _DocumentType_Seeding = (InitialiezerFolderPath + "_DocumentType.xlsx").ExcelToEnumerable<c_DocumentType>(x => x.UsingHeaderNames(true));
            //builder.Entity<c_DocumentType>().HasData(_DocumentType_Seeding);
            //IEnumerable<c_SaveIn> _SaveIn_Seeding = (InitialiezerFolderPath + "_SaveIn.xlsx").ExcelToEnumerable<c_SaveIn>(x => x.UsingHeaderNames(true));
            //builder.Entity<c_SaveIn >().HasData(_SaveIn_Seeding);
            //IEnumerable<c_Seals> _Seals_Seeding = (InitialiezerFolderPath + "_Seals.xlsx").ExcelToEnumerable<c_Seals>(x => x.UsingHeaderNames(true));
            //builder.Entity<c_Seals>().HasData(_Seals_Seeding);
            //IEnumerable<Def_EmployeesTree> _EmployeesTree_Seeding = (InitialiezerFolderPath + "_EmployeesTree.xlsx").ExcelToEnumerable<Def_EmployeesTree>(x => x.UsingHeaderNames(true));
            //builder.Entity<Def_EmployeesTree>().HasData(_EmployeesTree_Seeding);
            //IEnumerable<c_InboxEntities> _InboxEntities_Seeding = (InitialiezerFolderPath + "_InboxEntities.xlsx").ExcelToEnumerable<c_InboxEntities>(x => x.UsingHeaderNames(true));
            //builder.Entity<c_InboxEntities>().HasData(_InboxEntities_Seeding);
            //IEnumerable<c_OutboxEntities> _OutboxEntities_Seeding = (InitialiezerFolderPath + "_OutboxEntities.xlsx").ExcelToEnumerable<c_OutboxEntities>(x => x.UsingHeaderNames(true));
            //builder.Entity<c_OutboxEntities>().HasData(_OutboxEntities_Seeding);
            //IEnumerable<c_InboxSubjects> _InboxSubjects_Seeding = (InitialiezerFolderPath + "_InboxSubjects.xlsx").ExcelToEnumerable<c_InboxSubjects>(x => x.UsingHeaderNames(true));
            //builder.Entity<c_InboxSubjects>().HasData(_InboxSubjects_Seeding);
            //IEnumerable<c_OutboxSubjects> _OutboxSubjects_Seeding = (InitialiezerFolderPath + "_OutboxSubjects.xlsx").ExcelToEnumerable<c_OutboxSubjects>(x => x.UsingHeaderNames(true));
            //builder.Entity<c_OutboxSubjects>().HasData(_OutboxSubjects_Seeding);
            //IEnumerable<c_Importance> _Importance_Seeding = (InitialiezerFolderPath + "_Importance.xlsx").ExcelToEnumerable<c_Importance>(x => x.UsingHeaderNames(true));
            //builder.Entity<c_Importance>().HasData(_Importance_Seeding);
            //IEnumerable<cCompany> _Company_Seeding = (InitialiezerFolderPath + "_Company.xlsx").ExcelToEnumerable<cCompany>(x => x.UsingHeaderNames(true));
            //builder.Entity<cCompany>().HasData(_Company_Seeding);
            //IEnumerable<cCity> _City_Seeding = (InitialiezerFolderPath + "_City.xlsx").ExcelToEnumerable<cCity>(x => x.UsingHeaderNames(true));
            //builder.Entity<cCity>().HasData(_City_Seeding);
            //IEnumerable<cEmployeesVsCompaniesVsScreens> _cEmployeesVsCompaniesVsScreens_Seeding = (InitialiezerFolderPath + "_EmployeesVsCompaniesVsScreens.xlsx").ExcelToEnumerable<cEmployeesVsCompaniesVsScreens>(x => x.UsingHeaderNames(true));
            //builder.Entity<cEmployeesVsCompaniesVsScreens>().HasData(_cEmployeesVsCompaniesVsScreens_Seeding);

        }

        //public DbSet<cTreeGroup> cTreeGroup { get; set; }
        public DbSet<Def_AcademicGradeType> Def_AcademicGradeType { get; set; }
        public DbSet<Def_AdditionType> Def_AdditionType { get; set; }
        public DbSet<Def_BusinessSector> Def_BusinessSector { get; set; }
        public DbSet<Def_CandidateStatusType> Def_CandidateStatusType { get; set; }
        public DbSet<Def_City> Def_City { get; set; }
        public DbSet<Def_Country> Def_Country { get; set; }
        public DbSet<Def_ContactType> Def_ContactType { get; set; }
        public DbSet<Def_ContractType> Def_ContractType { get; set; }
        public DbSet<Def_Deduction> Def_Deduction { get; set; }
        public DbSet<Def_DepartmentType> Def_DepartmentType { get; set; }
        public DbSet<Def_EvacuationType> Def_EvacuationType { get; set; }
        public DbSet<Def_FileType> Def_FileType { get; set; }
        public DbSet<Def_JobTitle> Def_JobTitle { get; set; }
        public DbSet<Def_Language> Def_Language { get; set; }
        public DbSet<Def_MaritalStatus> Def_MaritalStatus { get; set; }
        public DbSet<Def_MoneyPayTurnover> Def_MoneyPayTurnover { get; set; }
        public DbSet<Def_Nationality> Def_Nationality { get; set; }
        public DbSet<Def_RelativeType> Def_RelativeType { get; set; }
        public DbSet<Def_Religion> Def_Religion { get; set; }
        public DbSet<Def_Salutation> Def_Salutation { get; set; }
        public DbSet<Def_Sex> Def_Sex { get; set; }
        public DbSet<Def_State> Def_State { get; set; }
        public DbSet<Def_University> Def_University { get; set; }
        public DbSet<Def_VacationType> Def_VacationType { get; set; }
        public DbSet<Def_EmployeesTree> Def_EmployeesTree { get; set; }
        public DbSet<Def_Employee> Def_Employee { get; set; }
        public DbSet<Doc_EmploymentAdvertizement> Doc_EmploymentAdvertizement { get; set; }
        public DbSet<Def_Department> Def_Department { get; set; }
        public DbSet<Def_Branch> Def_Branch { get; set; }
        //public DbSet<Def_Job> Def_Job { get; set; }
        //public DbSet<Def_Company> Def_Company { get; set; }
        //public DbSet<Def_Qualification> Def_Qualification { get; set; }
        //public DbSet<Def_AdvertizementAgency> Def_AdvertizementAgency { get; set; }
        //public DbSet<Def_YearsRange> Def_YearsRange { get; set; }
        //public DbSet<Def_Permanency> Def_Permanency { get; set; }
        public DbSet<Def_Specialization> Def_Specialization { get; set; }
        public DbSet<Def_Certification> Def_Certification { get; set; }
        //public DbSet<Def_SaudiStandardJobCode> Def_SaudiStandardJobCode { get; set; }
        //public DbSet<Def_MilitaryServiceStatus> Def_MilitaryServiceStatus { get; set; }
        //public DbSet<Doc_EmploymentAdvertizement_Advantages> Doc_EmploymentAdvertizement_Advantages { get; set; }
        public DbSet<Doc_CVs> Doc_CVs { get; set; }
       // public DbSet<Def_Contact> Def_Contact { get; set; }
        //public DbSet<Def_Skill> Def_Skill { get; set; }
        //public DbSet<Doc_Docs> Doc_Docs { get; set; }
        //public DbSet<Doc_Docs_Extention> Doc_Docs_Extention { get; set; }
        //public DbSet<Def_Seal> Def_Seal { get; set; }
        //public DbSet<Doc_Interview> Doc_Interview { get; set; }
        //public DbSet<Doc_InterviewAssessment> Doc_InterviewAssessment { get; set; }
        //public DbSet<Set_ApprovementVsScreen> Set_ApprovementVsScreen { get; set; }
        //public DbSet<Def_DocumentDeliveryMethod> Def_DocumentDeliveryMethod { get; set; }
        //public DbSet<Def_SocialSurname> Def_SocialSurname { get; set; }
        //public DbSet<Def_IDDocumentType> Def_IDDocumentType { get; set; }
        //public DbSet<Doc_ContentsType> Doc_ContentsType { get; set; }
        //public DbSet<Doc_InterviewType> Doc_InterviewType { get; set; }
        //public DbSet<Doc_InterviewStatus> Doc_InterviewStatus { get; set; }
        //public DbSet<Def_TermsAndCondition> Def_TermsAndCondition { get; set; }
        //public DbSet<Doc_TrainingContract> Doc_TrainingContract { get; set; }
        //public DbSet<Def_TimeIntervals> Def_TimeIntervals { get; set; }
        //public DbSet<Def_Bank> Def_Bank { get; set; }
        //public DbSet<Def_Currency> Def_Currency { get; set; }
        //public DbSet<Def_Weekdays> Def_Weekdays { get; set; }
        //public DbSet<Def_ContractStatus> Def_ContractStatus { get; set; }
        //public DbSet<Set_FormFiled> Set_FormFiled { get; set; }
        //public DbSet<Def_Addition> Def_Addition { get; set; }
        //public DbSet<DailyActivities_FingerPrintLog> DailyActivities_FingerPrintLog { get; set; }
        //public DbSet<Def_FingerPrintMachine> Def_FingerPrintMachine { get; set; }
        //public DbSet<DailyActivities_AttendancePlan> DailyActivities_AttendancePlan { get; set; }
        //public DbSet<Def_AttendancePlanTypes> Def_AttendancePlanTypes { get; set; }
        //public DbSet<DailyActivities_AttendancePlanPerEmployee> DailyActivities_AttendancePlanPerEmployee { get; set; }
        //public DbSet<Def_AttendancePerDay> Def_AttendancePerDay { get; set; }
        //public DbSet<DailyActivities_AttendanceShiftRequest> DailyActivities_AttendanceShiftRequest { get; set; }
        //public DbSet<DailyActivities_DccStatus> DailyActivities_DccStatus { get; set; }
        //public DbSet<DailyActivities_StatusLog> DailyActivities_StatusLog { get; set; }
        //public DbSet<DailyActivities_DocType> DailyActivities_DocType { get; set; }
        //public DbSet<DailyActivities_VacationRequest> DailyActivities_VacationRequest { get; set; }
        //public DbSet<Def_VacationRequestUrgencyTypes> Def_VacationRequestUrgencyTypes { get; set; }
        //public DbSet<Def_EmployeeTabs> Def_EmployeeTabs { get; set; }
        //public DbSet<DailyActivities_DocStatus> DailyActivities_DocStatus { get; set; }
        //public DbSet<DailyActivities_DocMajorType> DailyActivities_DocMajorType { get; set; }
        //public DbSet<State_Employees> State_Employees { get; set; }
        //public DbSet<DailyActivities_EmployeesIncomeLog> DailyActivities_EmployeesIncomeLog { get; set; }
        //public DbSet<State_States> State_States { get; set; }
        //public DbSet<Set_Evaluations> Set_Evaluations { get; set; }
        //public DbSet<Set_Evaluation_Factors> Set_Evaluation_Factors { get; set; }
        //public DbSet<DailyActivities_EmployeeEvaluation> DailyActivities_EmployeeEvaluation { get; set; }
        //public DbSet<Set_Evaluation_FactorsTypes> Set_Evaluation_FactorsTypes { get; set; }
        //public DbSet<Set_Evaluation_Status> Set_Evaluation_Status { get; set; }
        //public DbSet<DailyActivities_AttendancePlanPerEmployeeDeviation> DailyActivities_AttendancePlanPerEmployeeDeviation { get; set; }
        //public DbSet<Variables_ClassesProperties> Variables_ClassesProperties { get; set; }
        //public DbSet<Def_FingerPrintMachineUsersInfo> Def_FingerPrintMachineUsersInfo { get; set; }
        //public DbSet<DailyActivities_AttendancePlanPerEmployee2> DailyActivities_AttendancePlanPerEmployee2 { get; set; }
        //public DbSet<Def_Dictionary> Def_Dictionary { get; set; }
        //public DbSet<DailyActivities_Vacations> DailyActivities_Vacations { get; set; }
        //public DbSet<Form_43_CustodyReceipt> Form_43_CustodyReceipt { get; set; }
        //public DbSet<Form_43_CustodyReceipt_Status> Form_43_CustodyReceipt_Status { get; set; }
        //public DbSet<Form_CustodyDetails> Form_CustodyDetails { get; set; }
        //public DbSet<Form_48_StampReceiving> Form_48_StampReceiving { get; set; }
        //public DbSet<Form_84_ChangeSalaryBank> Form_84_ChangeSalaryBank { get; set; }
        //public DbSet<Form_94_Interrogatory> Form_94_Interrogatory { get; set; }
        //public DbSet<Form_94_Interrogatory_Status> Form_94_Interrogatory_Status { get; set; }
        //public DbSet<Form_TermsAndConditions> Form_TermsAndConditions { get; set; }
        //public DbSet<Form_4_AddFingerPrint> Form_4_AddFingerPrint { get; set; }
        //public DbSet<Form_20_DeliveryRequest> Form_20_DeliveryRequest { get; set; }
        //public DbSet<Form_20_DeliveryRequest_Status> Form_20_DeliveryRequest_Status { get; set; }
        //public DbSet<View_Form_48_StampReceiving> View_Form_48_StampReceiving { get; set; }
        //public DbSet<Form_Summary> Form_Summary { get; set; }
        //public DbSet<View_Form_4_AddFingerPrint> View_Form_4_AddFingerPrint { get; set; }
        //public DbSet<View_Form_94_Interrogatory> View_Form_94_Interrogatory { get; set; }
        //public DbSet<View_Form_43_CustodyReceipt> View_Form_43_CustodyReceipt { get; set; }
        //public DbSet<View_Form_84_ChangeSalaryBank> View_Form_84_ChangeSalaryBank { get; set; }
        //public DbSet<View_Form_20_DeliveryRequest> View_Form_20_DeliveryRequest { get; set; }
        //public DbSet<DailyActivities_MissingAttendanceStatus> DailyActivities_MissingAttendanceStatus { get; set; }
        //public DbSet<DailyActivities_MissingAttendancePeriods> DailyActivities_MissingAttendancePeriods { get; set; }
        //public DbSet<Form_M001_Advances> Form_M001_Advances { get; set; }
        //public DbSet<Form_M001_Advances_Status> Form_M001_Advances_Status { get; set; }
        //public DbSet<Form_M001_Advances_Installment> Form_M001_Advances_Installment { get; set; }
        //public DbSet<EmployeeStatus> EmployeeStatus { get; set; }
        //public DbSet<Def_EntityType> Def_EntityType { get; set; }





    }
}
