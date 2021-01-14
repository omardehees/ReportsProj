using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReportsProj.Management_Models;

namespace ReportsProj.DBC
{
    public class Management_DBC:DbContext
    {
        public Management_DBC(DbContextOptions<Management_DBC> options) : base(options)
        {
        }
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
        public DbSet<Def_FileTemplates> Def_FileTemplates { get; set; }
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

    }
}
