using REPORTer.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPORTer.DAL.Entities
{
    public class User : BaseEntity
    {
        public int GroupID { get; set; }
        public string FirstName{ get; set; }
        public string SecondName{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public RoleInGroup RoleInGroup { get; set; }    
        public RoleInReporter RoleInReporter { get; set; }

    }
}
