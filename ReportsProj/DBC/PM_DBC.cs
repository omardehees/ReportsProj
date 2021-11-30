using Microsoft.EntityFrameworkCore;
using ReportsProj.PM_Model;

namespace ReportsProj.DBC
{
    public class PM_DBC:DbContext
    {
        public PM_DBC(DbContextOptions<PM_DBC> options) : base(options)
        {            
        }
        public  DbSet<cOrganization> cOrganization { get; set; }
        public DbSet<cCSR> cCSR { get; set; }


    }
}
