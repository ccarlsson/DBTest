﻿// <auto-generated />
using BookDB.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookDB.Api.Data.Migrations
{
    [DbContext(typeof(BookDbContext))]
    partial class BookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("BookDB.Api.Entites.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ISBN");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ISBN = "9789140674029",
                            Author = "Magnus Lilja, Ulrik Nilsson",
                            ImageUrl = "https://s2.adlibris.com/images/1796891/programmering-1-c.jpg",
                            Title = "Programmering 1 C#"
                        },
                        new
                        {
                            ISBN = "9789140677099",
                            Author = "Magnus Lilja, Ulrik Nilsson, Bo Silborn",
                            ImageUrl = "https://s2.adlibris.com/images/2773237/programmering-1-c.jpg",
                            Title = "Programmering 1 C++"
                        },
                        new
                        {
                            ISBN = "9789140677105",
                            Author = "Magnus Lilja, Ulrik Nilsson, Bo Silborn",
                            ImageUrl = "https://s2.adlibris.com/images/2773237/programmering-1-c.jpg",
                            Title = "Programmering 1 Java"
                        });
                });

            modelBuilder.Entity("BookDB.Api.Entites.BookCopy", b =>
                {
                    b.Property<string>("BookId");

                    b.Property<int>("CopyNumber");

                    b.Property<string>("Description");

                    b.HasKey("BookId", "CopyNumber");

                    b.ToTable("BookCopies");

                    b.HasData(
                        new
                        {
                            BookId = "9789140674029",
                            CopyNumber = 1
                        },
                        new
                        {
                            BookId = "9789140674029",
                            CopyNumber = 2
                        },
                        new
                        {
                            BookId = "9789140674029",
                            CopyNumber = 3
                        },
                        new
                        {
                            BookId = "9789140674029",
                            CopyNumber = 4
                        },
                        new
                        {
                            BookId = "9789140674029",
                            CopyNumber = 5
                        },
                        new
                        {
                            BookId = "9789140677099",
                            CopyNumber = 1
                        },
                        new
                        {
                            BookId = "9789140677099",
                            CopyNumber = 2
                        },
                        new
                        {
                            BookId = "9789140677099",
                            CopyNumber = 3
                        },
                        new
                        {
                            BookId = "9789140677099",
                            CopyNumber = 4
                        },
                        new
                        {
                            BookId = "9789140677099",
                            CopyNumber = 5
                        },
                        new
                        {
                            BookId = "9789140677105",
                            CopyNumber = 1
                        },
                        new
                        {
                            BookId = "9789140677105",
                            CopyNumber = 2
                        },
                        new
                        {
                            BookId = "9789140677105",
                            CopyNumber = 3
                        },
                        new
                        {
                            BookId = "9789140677105",
                            CopyNumber = 4
                        },
                        new
                        {
                            BookId = "9789140677105",
                            CopyNumber = 5
                        });
                });

            modelBuilder.Entity("BookDB.Api.Entites.BookCopy", b =>
                {
                    b.HasOne("BookDB.Api.Entites.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
