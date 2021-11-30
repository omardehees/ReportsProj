using Microsoft.EntityFrameworkCore;
using ReportsProj.Models_Pharmacy;

namespace ReportsProj.DBC
{
    public class Pharmacy_DBC : DbContext
    {
        public Pharmacy_DBC(DbContextOptions<Pharmacy_DBC> options) : base(options)
        {            
        }
        public DbSet<journal_h> journal_h { get; set; }
    }
}
