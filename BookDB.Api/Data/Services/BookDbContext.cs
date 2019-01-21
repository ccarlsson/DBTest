using BookDB.Api.Entites;
using Microsoft.EntityFrameworkCore;


namespace BookDB.Services
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCopy> BookCopies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(b => b.ISBN);
            modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.Author).IsRequired();

            modelBuilder.Entity<BookCopy>().HasKey(copy => new { copy.BookId, copy.CopyNumber });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    ISBN = "9789140674029",
                    Title = "Programmering 1 C#",
                    Author = "Magnus Lilja, Ulrik Nilsson",
                    ImageUrl = "https://s2.adlibris.com/images/1796891/programmering-1-c.jpg"
                },
                new Book
                {
                    ISBN = "9789140677099",
                    Title = "Programmering 1 C++",
                    Author = "Magnus Lilja, Ulrik Nilsson, Bo Silborn",
                    ImageUrl = "https://s2.adlibris.com/images/2773237/programmering-1-c.jpg"
                },
                new Book
                {
                    ISBN = "9789140677105",
                    Title = "Programmering 1 Java",
                    Author = "Magnus Lilja, Ulrik Nilsson, Bo Silborn",
                    ImageUrl = "https://s2.adlibris.com/images/2773237/programmering-1-c.jpg"
                });

            modelBuilder.Entity<BookCopy>().HasData(
                new BookCopy
                {
                    BookId = "9789140674029",
                    CopyNumber = 1
                },
                new BookCopy
                {
                    BookId = "9789140674029",
                    CopyNumber = 2
                },
                new BookCopy
                {
                    BookId = "9789140674029",
                    CopyNumber = 3
                },
                new BookCopy
                {
                    BookId = "9789140674029",
                    CopyNumber = 4
                }, new BookCopy
                {
                    BookId = "9789140674029",
                    CopyNumber = 5
                },
                new BookCopy
                {
                    BookId = "9789140677099",
                    CopyNumber = 1
                },
                new BookCopy
                {
                    BookId = "9789140677099",
                    CopyNumber = 2
                },
                new BookCopy
                {
                    BookId = "9789140677099",
                    CopyNumber = 3
                },
                new BookCopy
                {
                    BookId = "9789140677099",
                    CopyNumber = 4
                }, new BookCopy
                {
                    BookId = "9789140677099",
                    CopyNumber = 5
                }, new BookCopy
                {
                    BookId = "9789140677105",
                    CopyNumber = 1
                },
                new BookCopy
                {
                    BookId = "9789140677105",
                    CopyNumber = 2
                },
                new BookCopy
                {
                    BookId = "9789140677105",
                    CopyNumber = 3
                },
                new BookCopy
                {
                    BookId = "9789140677105",
                    CopyNumber = 4
                }, new BookCopy
                {
                    BookId = "9789140677105",
                    CopyNumber = 5
                }
            );
        }
    }
}