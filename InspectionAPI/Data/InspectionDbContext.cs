using InspectionAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace InspectionAPI.Data
{
    public class InspectionDbContext : DbContext
    {
        public InspectionDbContext(DbContextOptions<InspectionDbContext> options) : base(options){}
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspectionType> InspectionTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
