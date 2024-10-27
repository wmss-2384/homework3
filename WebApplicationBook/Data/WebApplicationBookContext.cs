using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationBook.Models;

namespace WebApplicationBook.Data
{
    public class WebApplicationBookContext : DbContext
    {
        public WebApplicationBookContext (DbContextOptions<WebApplicationBookContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationBook.Models.Book> Book { get; set; } = default!;
    }
}
