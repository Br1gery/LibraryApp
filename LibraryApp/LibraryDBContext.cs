using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LibraryApp
{
    public partial class LibraryDBContext : DbContext
    {
        public LibraryDBContext()
        {
        }

        public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Examples> Examples { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Publishers> Publishers { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<UsersData> UsersData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=../../LibraryDB.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Author).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AuthorId).HasColumnName("Author_id");

                entity.Property(e => e.Description).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.GenreId).HasColumnName("Genre_id");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.PublisherId).HasColumnName("Publisher_id");

                entity.Property(e => e.RelYear).HasColumnName("Rel_year");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId);

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.GenreId);

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PublisherId);
            });

            modelBuilder.Entity<Examples>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BookId).HasColumnName("Book_id");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("Delivery_date")
                    .HasColumnType("DATETIME");

                entity.Property(e => e.ExpDate)
                    .HasColumnName("Exp_date")
                    .HasColumnType("DATETIME");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("Issue_date")
                    .HasColumnType("DATETIME");

                entity.Property(e => e.LocationId).HasColumnName("Location_id");

                entity.Property(e => e.OwnderId).HasColumnName("Ownder_id");

                entity.Property(e => e.Shelf).HasColumnType("VARCHAR (255)");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Examples)
                    .HasForeignKey(d => d.BookId);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Examples)
                    .HasForeignKey(d => d.LocationId);

                entity.HasOne(d => d.Ownder)
                    .WithMany(p => p.Examples)
                    .HasForeignKey(d => d.OwnderId);
            });

            modelBuilder.Entity<Genders>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Gender).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Genres>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Genre).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Group).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Location).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Publishers>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Publisher).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_of_birth")
                    .HasColumnType("VARCHAR (255)");

                entity.Property(e => e.GenderId).HasColumnName("Gender_id");

                entity.Property(e => e.GroupId).HasColumnName("Group_id");

                entity.Property(e => e.Lastname).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.RegDate)
                    .HasColumnName("Reg_date")
                    .HasColumnType("DATETIME");

                entity.Property(e => e.Surname).HasColumnType("VARCHAR (255)");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GenderId);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GroupId);
            });

            modelBuilder.Entity<UsersData>(entity =>
            {
                entity.ToTable("Users_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Login).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Password).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Role).HasColumnType("INTEGER (255)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
