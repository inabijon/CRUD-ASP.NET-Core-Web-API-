using Microsoft.EntityFrameworkCore;

namespace CRUD__ASP.NET_Core_Web_API_.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Inspection> inspections { get; set; }

        public DbSet<InspectionType> inspectionTypes { get; set; }

        public DbSet<Status> statuses { get; set; }
    }
}
