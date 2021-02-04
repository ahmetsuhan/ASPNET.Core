using Microsoft.EntityFrameworkCore;
using ModelDto_and_Validation.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelDto_and_Validation.Data.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        public DbSet<DailyForecast> DailyForeCasts { get; set; } 
    }
}
