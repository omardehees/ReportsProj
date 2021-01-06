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
        public  DbSet<cOrganization> cOrganization { get; set; }
        public DbSet<cCSR> cCSR { get; set; }


    }
}
