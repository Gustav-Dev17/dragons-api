using Microsoft.EntityFrameworkCore;
using DragonsAPI.Models;
using System;
using DragonsAPI.Models.Enums;

namespace DragonsAPI.Database
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Rider> Riders { get; set; }
		public DbSet<Dragon> Dragons { get; set; }
		public DbSet<DragonRider> DragonRiders { get; set; }
		public DbSet<House> Houses { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Mapeamento das tabelas
			modelBuilder.Entity<Rider>().ToTable("riders");
			modelBuilder.Entity<Dragon>().ToTable("dragons");
			modelBuilder.Entity<DragonRider>().ToTable("dragon_riders");
			modelBuilder.Entity<House>().ToTable("houses");

			modelBuilder.Entity<Rider>()
				.Property(r => r.Id)
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Dragon>()
				.Property(d => d.Id)
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<DragonRider>()
				.Property(dr => dr.Id)
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<House>()
				.Property(h => h.Id)
				.ValueGeneratedOnAdd();
			 
			// RELATION BETWEEN TABLES
			modelBuilder.Entity<DragonRider>()
				.HasOne(dr => dr.Rider)
				.WithMany(r => r.DragonRiders)
				.HasForeignKey(dr => dr.RiderId);

			modelBuilder.Entity<DragonRider>()
				.HasOne(dr => dr.Dragon)
				.WithMany(d => d.DragonRiders)
				.HasForeignKey(dr => dr.DragonId);

			modelBuilder.Entity<Rider>()
				.Property(r => r.Status)
				.HasConversion<string>();

			modelBuilder.Entity<Dragon>()
				.Property(d => d.Status)
				.HasConversion<string>();

			// SEEDS
			modelBuilder.Entity<House>().HasData(
				new House { Id = 1, Name = "Targaryen" }
			);

			modelBuilder.Entity<Rider>().HasData(
				new Rider { Id = 1, Name = "Aegon I Targaryen", HouseId = 1, Status = Status.Dead },
				new Rider { Id = 2, Name = "Visenya Targaryen", HouseId = 1, Status = Status.Dead },
				new Rider { Id = 3, Name = "Rhaenys Targaryen", HouseId = 1, Status = Status.Dead }
			);

			modelBuilder.Entity<Dragon>().HasData(
				new Dragon { Id = 1, Name = "Balerion", Color = "Black", Size = "Gigantic", Weight = 7000, Height = 25, Temperament = "Aggressive", Status = Status.Dead },
				new Dragon { Id = 2, Name = "Vhagar", Color = "Green", Size = "Large", Weight = 6000, Height = 23, Temperament = "Fierce", Status = Status.Alive },
				new Dragon { Id = 3, Name = "Meraxes", Color = "Silver", Size = "Large", Weight = 5000, Height = 22, Temperament = "Calm", Status = Status.Dead }
			);

			modelBuilder.Entity<DragonRider>().HasData(
				new DragonRider { Id = 1, RiderId = 1, DragonId = 1, StartDate = new DateTime(1, 1, 1), EndDate = new DateTime(37, 1, 1), IsCurrent = false }, // Aegon I and Balerion
				new DragonRider { Id = 2, RiderId = 2, DragonId = 2, StartDate = new DateTime(1, 1, 1), EndDate = new DateTime(50, 1, 1), IsCurrent = false }, // Visenya and Vhagar
				new DragonRider { Id = 3, RiderId = 3, DragonId = 3, StartDate = new DateTime(1, 1, 1), EndDate = new DateTime(10, 1, 1), IsCurrent = false }  // Rhaenys and Meraxes
			);

			base.OnModelCreating(modelBuilder);
		}




	}


}
