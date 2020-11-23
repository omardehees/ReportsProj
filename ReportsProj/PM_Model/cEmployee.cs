using System;
using System.Collections.Generic;
using System.Text;

namespace ReportsProj.PM_Model
{
    public class cEmployee : _EntityBase
    {
        public string Name { get; set; }
        public string NameEn { get; set; }
        public Guid Code { get; set; }
        public bool IsAdmin { get; set; }
        public string Department { get; set; }
        public string Machine { get; set; }
        public string Job { get; set; }
        public string Group { get; set; }
        public string Responsibility { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public string PasswordHint { get; set; }
        public string Email { get; set; }
        public string SecurityQuestionA { get; set; }
        public string SecurityQuestionAAnswer { get; set; }
        public string SecurityQuestionB { get; set; }
        public string SecurityQuestionBAnswer { get; set; }
        public string SecurityQuestionC { get; set; }
        public string SecurityQuestionCAnswer { get; set; }
        public string Action { get; set; }

    }
}
