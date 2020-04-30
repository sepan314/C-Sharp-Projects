using System;
using Microsoft.EntityFrameworkCore;

namespace ExcelConsoleApp
{
    public class StockContext : DbContext
    {
        public DbSet<Stock> Stock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433; Database=StockDb1;User=sa; Password=<YourStrong@Passw0rd>");
    }
}
