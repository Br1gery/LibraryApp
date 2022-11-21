using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LibraryApp
{
    public partial class Examples
    {
        public long Id { get; set; }
        public long? LocationId { get; set; }
        public long? OwnderId { get; set; }
        public long? BookId { get; set; }
        public string Shelf { get; set; }
        public byte[] IssueDate { get; set; }
        public byte[] ExpDate { get; set; }
        public byte[] DeliveryDate { get; set; }

        public virtual Books Book { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Students Ownder { get; set; }
    }
}
