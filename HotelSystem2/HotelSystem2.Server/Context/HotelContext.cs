using HotelSystem2.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem2.Server.Context
{
    public class HotelContext : DbContext, IHotelContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }

        public virtual DbSet<Hotel> Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Hotel>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Hotel>()
                .Property(p => p.Name)
                .HasMaxLength(50);
            modelBuilder.Entity<Hotel>()
                .Property(p => p.CreationDate)
                .HasDefaultValue(new DateTime(2000, 1, 1));
            //SeedDatabase(modelBuilder);

            //OnModelCreatingPartial(modelBuilder);
        }


        private static void SeedDatabase(ModelBuilder modelBuilder) { }

        //public Task SaveChangesAsync()
        //{
        //    throw new NotImplementedException();
        //}
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        //}

    }
}
