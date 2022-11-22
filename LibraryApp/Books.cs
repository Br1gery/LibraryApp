using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LibraryApp
{
    public partial class Books
    {
        public Books()
        {
            Examples = new HashSet<Examples>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? AuthorId { get; set; }
        public long? RelYear { get; set; }
        public long? Pages { get; set; }
        public long? GenreId { get; set; }
        public string Description { get; set; }
        public long? PublisherId { get; set; }

        public virtual Authors Author { get; set; }
        public virtual string Author_name
        {
            get
            {
                return Author.Author;
            }
        }
        public virtual Genres Genre { get; set; }
        public virtual string Genre_name
        {
            get
            {
                return Genre.Genre;
            }
        }
        public virtual Publishers Publisher { get; set; }
        public virtual string Publisher_name
        {
            get
            {
                return Publisher.Publisher;
            }
        }
        public virtual ICollection<Examples> Examples { get; set; }
    }
}
