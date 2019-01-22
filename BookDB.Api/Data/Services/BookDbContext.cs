using BookDB.Api.Entites;
using Microsoft.EntityFrameworkCore;


namespace BookDB.Services
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCopy> BookCopies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(b => b.ISBN);
            modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.Author).IsRequired();

            modelBuilder.Entity<BookCopy>().HasKey(copy => new { copy.BookId, copy.CopyNumber });

            modelBuilder.Entity<Group>().HasKey(g => g.GroupId);
            modelBuilder.Entity<Group>().Property(g => g.GroupName).IsRequired();

            modelBuilder.Entity<Customer>().HasKey(c => c.CustomerId);
            modelBuilder.Entity<Customer>().Property(c => c.Firstname).IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.Lastname).IsRequired();

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
                    ImageUrl = "https://s1.adlibris.com/images/966044/programmering-1-java.jpg"
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

            modelBuilder.Entity<Group>().HasData(
                new Group
                {
                    GroupId = new System.Guid("ac9c8a4d-656c-44eb-9a96-62faa5ce050e"),
                    GroupName = "TE18:1"
                },
                new Group
                {
                    GroupId = new System.Guid("f87f4b0d-345c-4240-aa12-7126b5e6a7b5"),
                    GroupName = "TE18:2"
                },
                new Group
                {
                    GroupId = new System.Guid("6aad4c8c-e11c-4d90-b789-dd225fcbf452"),
                    GroupName = "ES18:1"
                },
                new Group
                {
                    GroupId = new System.Guid("8bafeac9-7c73-4448-bc12-59ed95d02186"),
                    GroupName = "ES18:2 "
                },
                new Group
                {
                    GroupId = new System.Guid("d5e77fbe-0dc1-4968-ab12-cdd41d42a7b9"),
                    GroupName = "EE18A"
                }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = new System.Guid("f9e9f3f1-9a31-4af9-84c9-9b60154f7887"),
                    Firstname = "Leona",
                    Lastname = "Perry",
                    GroupId = new System.Guid("ac9c8a4d-656c-44eb-9a96-62faa5ce050e")
                },
                new Customer
                {
                    CustomerId = new System.Guid("4ea68fd8-c632-41e0-95ad-445559e551f6"),
                    Firstname = "Khalil",
                    Lastname = "Trelawney",
                    GroupId = new System.Guid("ac9c8a4d-656c-44eb-9a96-62faa5ce050e")
                },
                new Customer
                {
                    CustomerId = new System.Guid("0c5a5aa0-ee03-482a-a5cd-81e18856dd19"),
                    Firstname = "Marcia",
                    Lastname = "O'Doherty",
                    GroupId = new System.Guid("f87f4b0d-345c-4240-aa12-7126b5e6a7b5")
                },
                new Customer
                {
                    CustomerId = new System.Guid("a2bf8bfc-8cd4-44fe-80fd-51a3531aadaa"),
                    Firstname = "Mathilde",
                    Lastname = "Mills",
                    GroupId = new System.Guid("f87f4b0d-345c-4240-aa12-7126b5e6a7b5")
                },
                new Customer
                {
                    CustomerId = new System.Guid("09c29016-7d6d-4bc0-b55f-13da76f418c3"),
                    Firstname = "Aniela",
                    Lastname = "Freeman",
                    GroupId = new System.Guid("f87f4b0d-345c-4240-aa12-7126b5e6a7b5")
                }
            );
        }
    }
}