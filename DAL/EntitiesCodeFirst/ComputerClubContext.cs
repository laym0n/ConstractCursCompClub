using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.EntitiesCodeFirst
{
    public partial class ComputerClubContext : DbContext
    {
        public ComputerClubContext()
            : base("name=ComputerClubContext")
        {
        }

        public virtual DbSet<ComputerComposition> ComputerComposition { get; set; }
        public virtual DbSet<ComputerPlaces> ComputerPlaces { get; set; }
        public virtual DbSet<FoodOrders> FoodOrders { get; set; }
        public virtual DbSet<Headphones> Headphones { get; set; }
        public virtual DbSet<Keyboard> Keyboard { get; set; }
        public virtual DbSet<Monitor> Monitor { get; set; }
        public virtual DbSet<Mouse> Mouse { get; set; }
        public virtual DbSet<Processor> Processor { get; set; }
        public virtual DbSet<RAM> RAM { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VideoCard> VideoCard { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComputerPlaces>()
                .HasMany(e => e.ComputerComposition)
                .WithRequired(e => e.ComputerPlaces)
                .HasForeignKey(e => e.PlaceId);

            modelBuilder.Entity<ComputerPlaces>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.ComputerPlaces)
                .HasForeignKey(e => e.PlaceID);

            modelBuilder.Entity<FoodOrders>()
                .Property(e => e.TotalAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Users>()
                .Property(e => e.Balance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Users>()
                .Property(e => e.Bonuses)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.FoodOrders)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID);
        }
    }
}
