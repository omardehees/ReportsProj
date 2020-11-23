using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using ReportsProj.PM_Model;
using ReportsProj.PM_Model;

namespace ReportsProj.DBC
{
    public class CSR_DBC:DbContext
    {
        public CSR_DBC(DbContextOptions<CSR_DBC> options) : base(options)
        {            
        }
        //private IConfiguration _Configuration { get; }
        //public CSR_DBC(IConfiguration Configuration)
        //{
        //    _Configuration = Configuration;
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_Configuration.GetSection("ConnectionStrings").GetSection("PM").Value);
        //}

        public  DbSet<cOrganization> cOrganization { get; set; }
        public DbSet<cCSR> cCSR { get; set; }


    }
}
