using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zad7JakubKazimierski.Models
{
    //Database context
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<MotorBike> MBikes { get; set; }
    }
}
