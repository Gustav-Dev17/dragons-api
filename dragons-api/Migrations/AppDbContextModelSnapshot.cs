﻿// <auto-generated />
using System;
using DragonsAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DragonsAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("DragonsAPI.Models.Dragon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateOfDeath")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Temperament")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("dragons", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Black",
                            Height = 25m,
                            Name = "Balerion",
                            Size = "Gigantic",
                            Status = "Dead",
                            Temperament = "Aggressive",
                            Weight = 7000m
                        },
                        new
                        {
                            Id = 2,
                            Color = "Green",
                            Height = 23m,
                            Name = "Vhagar",
                            Size = "Large",
                            Status = "Alive",
                            Temperament = "Fierce",
                            Weight = 6000m
                        },
                        new
                        {
                            Id = 3,
                            Color = "Silver",
                            Height = 22m,
                            Name = "Meraxes",
                            Size = "Large",
                            Status = "Dead",
                            Temperament = "Calm",
                            Weight = 5000m
                        });
                });

            modelBuilder.Entity("DragonsAPI.Models.DragonRider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DragonId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("RiderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DragonId");

                    b.HasIndex("RiderId");

                    b.ToTable("dragon_riders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DragonId = 1,
                            EndDate = new DateTime(37, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCurrent = false,
                            RiderId = 1,
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            DragonId = 2,
                            EndDate = new DateTime(50, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCurrent = false,
                            RiderId = 2,
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            DragonId = 3,
                            EndDate = new DateTime(10, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCurrent = false,
                            RiderId = 3,
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DragonsAPI.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("houses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Targaryen"
                        });
                });

            modelBuilder.Entity("DragonsAPI.Models.Rider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateOfDeath")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("HouseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.ToTable("riders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HouseId = 1,
                            Name = "Aegon I Targaryen",
                            Status = "Dead"
                        },
                        new
                        {
                            Id = 2,
                            HouseId = 1,
                            Name = "Visenya Targaryen",
                            Status = "Dead"
                        },
                        new
                        {
                            Id = 3,
                            HouseId = 1,
                            Name = "Rhaenys Targaryen",
                            Status = "Dead"
                        });
                });

            modelBuilder.Entity("DragonsAPI.Models.DragonRider", b =>
                {
                    b.HasOne("DragonsAPI.Models.Dragon", "Dragon")
                        .WithMany("DragonRiders")
                        .HasForeignKey("DragonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DragonsAPI.Models.Rider", "Rider")
                        .WithMany("DragonRiders")
                        .HasForeignKey("RiderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dragon");

                    b.Navigation("Rider");
                });

            modelBuilder.Entity("DragonsAPI.Models.Rider", b =>
                {
                    b.HasOne("DragonsAPI.Models.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("House");
                });

            modelBuilder.Entity("DragonsAPI.Models.Dragon", b =>
                {
                    b.Navigation("DragonRiders");
                });

            modelBuilder.Entity("DragonsAPI.Models.Rider", b =>
                {
                    b.Navigation("DragonRiders");
                });
#pragma warning restore 612, 618
        }
    }
}
