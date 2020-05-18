using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using ProjectOp.Entities;

namespace ProjectOp.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("Server=tcp:cephalin-core.database.windows.net,1433;Database=coreDB;User ID=Dong;Password=BDanh1604;Encrypt=true;Connection Timeout=30;"
 );

            }
        }


        virtual public DbSet<User> users { get; set; }
        virtual public DbSet<Achievement> achievements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(x => x.UserID);
                entity.Property(x => x.UserID).UseIdentityColumn(1, 1);
                entity.Property(x => x.name).HasColumnType("NVARCHAR(100)");
                entity.Property(x => x.department).HasColumnType("NVARCHAR(300)");
                entity.Property(x => x.quote).HasColumnType("NVARCHAR(300)");
                entity.Property(x => x.nationality).HasColumnType("NVARCHAR(50)");
                entity.Property(x => x.image1).HasColumnType("NVARCHAR(300)");
                entity.Property(x => x.image2).HasColumnType("NVARCHAR(300)");




            }
               );
            modelBuilder.Entity<Achievement>(entity =>
            {

                entity.HasKey(x => x.AchievementID);
                entity.Property(x => x.AchievementID).UseIdentityColumn(1, 1);
                entity.Property(x => x.achieve).HasColumnType("NVARCHAR(300)");
                entity.Property(x => x.UserId).HasColumnType("int");

            });
            modelBuilder.Entity<Achievement>().HasOne(x => x.User).WithMany(x => x.achievements).HasForeignKey(p => p.UserId);


        }
    }
}
