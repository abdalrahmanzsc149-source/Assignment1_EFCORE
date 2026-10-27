using Assignment1_EFCORE.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace Assignment1_EFCORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (BookStoreDbContext db = new BookStoreDbContext())
            {
                db.Database.EnsureCreated();

                Console.WriteLine("Database created successfully!");

                Console.WriteLine("Books table: " +
                    db.Books.Count());

                Console.WriteLine("Authors table: " +
                    db.Authors.Count());

                Console.WriteLine("Categories table: " +
                    db.Categories.Count());
            }

            Console.ReadKey();
        }
    }
}