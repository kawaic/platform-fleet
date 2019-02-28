using System;
using Fleet.Access.Vehicle.Service.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fleet.Access.Vehicle.Service
{
    public class VehicleContext : DbContext
    {
        public DbSet<VehicleStorage> Vehicles { get; set; }
        public DbSet<VehicleActivityStorage> VehicleActivities { get; set; }
        public DbSet<VehicleActivitySourceStorage> VehicleActivitySources { get; set; }

    }
}
