using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LibraryApp
{
    public partial class Students
    {
        public Students()
        {
            Examples = new HashSet<Examples>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public long? GroupId { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public long? GenderId { get; set; }
        public byte[] RegDate { get; set; }

        public virtual Genders Gender { get; set; }
        public virtual Groups Group { get; set; }
        public virtual ICollection<Examples> Examples { get; set; }
    }
}
