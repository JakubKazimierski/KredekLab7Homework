using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZadDomLab7.Models
{
    class VehiclesDbContext : DbContext
    {
        public VehiclesDbContext(DbContextOptions<VehiclesDbContext> options) : base(options)
        {

        }

        public DbSet<Car> CarTable { get; set; }
        public DbSet<MotorBike> MotorBikeTable { get; set; }

    }
}
