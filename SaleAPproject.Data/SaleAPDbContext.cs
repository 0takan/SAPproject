using System;
using Microsoft.EntityFrameworkCore;
using SaleAPproject.Models;

namespace SaleAPproject.Data
{
    public class SaleAPDbContext : DbContext
    {
        public DbSet<Ads> Ads { get; set; }
        public SaleAPDbContext()
        {
            Database.EnsureCreated();
        }
        
    }
}
