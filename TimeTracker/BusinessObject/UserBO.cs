using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
    public class UserBO
    {
        public string  Username { get; set; }
        public int UserId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; } 
        public long PhnNo { get; set; }

        public RoleBO RoleBO { get; set; }
    }
}
