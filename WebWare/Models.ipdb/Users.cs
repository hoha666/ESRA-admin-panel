using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsSuperAdmin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string UserInfo { get; set; }
        public string UserPicture { get; set; }
        public bool IsActive { get; set; }
        public bool IsSignature { get; set; }
    }
}
