using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LibraryApp
{
    public partial class UsersData
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public long? Role { get; set; }
    }
}
