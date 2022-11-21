using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LibraryApp
{
    public partial class Groups
    {
        public Groups()
        {
            Students = new HashSet<Students>();
        }

        public long Id { get; set; }
        public string Group { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}
