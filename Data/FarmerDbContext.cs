using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FarmerSupport.Models;

namespace FarmerSupport.Data
{
    public class FarmerDbContext : DbContext
    {
        public FarmerDbContext (DbContextOptions<FarmerDbContext> options)
            : base(options)
        {
        }

        public DbSet<FarmerSupport.Models.FarmerModel> FarmerModel { get; set; }
    }
}
