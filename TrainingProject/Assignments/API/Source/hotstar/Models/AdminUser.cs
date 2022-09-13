using System;
using System.Collections.Generic;

#nullable disable

namespace hotstar.Models
{
    public partial class AdminUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public int? Gender { get; set; }
        public int? Age { get; set; }
    }
}
