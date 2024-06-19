using Microsoft.EntityFrameworkCore;
using System;

namespace DatingProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        //public DbSet<Like> Likes { get; set; }
        //public DbSet<City> Cities { get; set; }
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            // Configure the primary key of City not to be an identity column
//            modelBuilder.Entity<City>()
//                .Property(c => c.ZipCode)
//                .ValueGeneratedNever();

//            // Configure many-to-many relationship
//            modelBuilder.Entity<Like>()
//                .HasKey(pc => new { pc.SenderId, pc.ReceiverId });

//            modelBuilder.Entity<Like>()
//                .HasOne(pc => pc.Sender)
//                .WithMany(p => p.SentLikes)
//                .HasForeignKey(pc => pc.SenderId)
//                .OnDelete(DeleteBehavior.Restrict);

//            modelBuilder.Entity<Like>()
//                .HasOne(pc => pc.Receiver)
//                .WithMany(c => c.ReceivedLikes)
//                .HasForeignKey(pc => pc.ReceiverId)
//                .OnDelete(DeleteBehavior.Restrict);

//        }
   }
}

