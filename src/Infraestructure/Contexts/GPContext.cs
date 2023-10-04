using GoldenPaths.Infraestructure.Contexts.Mappings;
using Microsoft.EntityFrameworkCore;

namespace GoldenPaths.Infraestructure.Contexts
{
    public class GPContext : DbContext
    {
        public GPContext(DbContextOptions options): base(options) 
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new DemandMap());
            modelBuilder.ApplyConfiguration(new DemandStatusMap());
            modelBuilder.ApplyConfiguration(new DemandTypeMap());
            modelBuilder.ApplyConfiguration(new PlaceMap());
            modelBuilder.ApplyConfiguration(new AddressMap());
        }
    }
}
