using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity;

namespace ReportsProj.PM_Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Job { get; set; }
        public string Phone { get; set; }
        public string Language { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public string RoleHint { get; set; }
    }
}
