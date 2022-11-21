using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LibraryApp
{
    public partial class Locations
    {
        public Locations()
        {
            Examples = new HashSet<Examples>();
        }

        public long Id { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Examples> Examples { get; set; }
    }
}
