using FM.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataLayer
{
    public class FMContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI;Database=FMDB;integrated security=true;");
        }


        public DbSet<ENTUser> User { get; set; }
        public DbSet<ENTRole> Role { get; set; }
        public DbSet<ENTCity> City { get; set; }
        public DbSet<ENTDistrict> District { get; set; }
        public DbSet<ENTCriteria> Criteria { get; set; }
        public DbSet<ENTFacility> Facility { get; set; }
        public DbSet<ENTRent> Rent { get; set; }
        public DbSet<ENTHouse> House { get; set; }
        public DbSet<ENTSampleFacility> SampleFacility { get; set; }
        public DbSet<ENTSampleCriteria> SampleCriteria { get; set; }

    }
}
