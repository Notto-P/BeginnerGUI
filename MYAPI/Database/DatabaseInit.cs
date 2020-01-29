using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MYAPI.Models;

namespace MYAPI.Database
{
    public class DatabaseInit
    {
        public static void INIT(IServiceProvider ServiceProvider)
        {
            var context = new DatabaseContext(ServiceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>());

            // If database does not exist then the database and all its schema are created
            context.Database.EnsureCreated();

            InsertData(context);
        }


        private static void InsertData(DatabaseContext context)
        {
            // If category table has data, it will return.
            if (context.Categories.Any())
            {
                return;
            }

            context.Categories.Add(new Category
            {
                Name = "IT",
                Description = "Mac Products"
            });
            context.SaveChanges();

            context.Suppliers.Add(new Supplier
            {
                Name = "Arnoldo",
                Phone = "994-919-2393"
            });
            context.SaveChanges();

            context.Products.Add(new Product
            {
                Name = "MacBook",
                Price = 50000,
                CategoryID = 1,
                SupplierID = 1
            });
            context.SaveChanges();
        }
    }
}