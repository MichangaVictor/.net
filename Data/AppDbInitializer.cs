using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if(!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "C# Programming language",
                        Description = "Very popular language",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Education",
                        CoverUrl = "https://onyango.epizy.com",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {
                        Title = "Ruby language",
                        Description = "Very Easy language",
                        IsRead = false,
                        DateRead = DateTime.Now.AddDays(-5),
                        Rate = 4,
                        Genre = "Programming",
                        CoverUrl = "https://onyango.epizy.com",
                        DateAdded = DateTime.Now.AddDays(-2)
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
