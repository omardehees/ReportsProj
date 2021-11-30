using Microsoft.EntityFrameworkCore;
using ReportsProj.Models_Clinics;

namespace ReportsProj.DBC
{
    public class Clinics_DBC : DbContext
    {
        public Clinics_DBC(DbContextOptions<Clinics_DBC> options) : base(options)
        {
        }

        public DbSet<invoice_h> invoice_h { get; set; }
    }
}
