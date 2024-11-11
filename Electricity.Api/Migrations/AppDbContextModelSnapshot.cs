﻿// <auto-generated />
using System;
using Electricity.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Electricity.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Electricity.Api.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Київ"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Львів"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Одеса"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Дніпро"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Харків"
                        });
                });

            modelBuilder.Entity("Electricity.Api.Models.Spreadsheet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DateName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("Hour00")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour01")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour02")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour03")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour04")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour05")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour06")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour07")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour08")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour09")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour10")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour11")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour12")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour13")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour14")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour15")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour16")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour17")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour18")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour19")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour20")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour21")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour22")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Hour23")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Spreadsheets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Monday",
                            GroupId = 1,
                            Hour00 = false,
                            Hour01 = false,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = true,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = false,
                            Hour10 = true,
                            Hour11 = true,
                            Hour12 = false,
                            Hour13 = false,
                            Hour14 = false,
                            Hour15 = false,
                            Hour16 = true,
                            Hour17 = true,
                            Hour18 = false,
                            Hour19 = false,
                            Hour20 = true,
                            Hour21 = true,
                            Hour22 = false,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Monday",
                            GroupId = 2,
                            Hour00 = true,
                            Hour01 = true,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = false,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = true,
                            Hour10 = true,
                            Hour11 = false,
                            Hour12 = false,
                            Hour13 = true,
                            Hour14 = true,
                            Hour15 = false,
                            Hour16 = false,
                            Hour17 = true,
                            Hour18 = true,
                            Hour19 = false,
                            Hour20 = false,
                            Hour21 = true,
                            Hour22 = true,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 3,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Tuesday",
                            GroupId = 1,
                            Hour00 = false,
                            Hour01 = false,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = true,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = false,
                            Hour10 = true,
                            Hour11 = true,
                            Hour12 = false,
                            Hour13 = false,
                            Hour14 = false,
                            Hour15 = false,
                            Hour16 = true,
                            Hour17 = true,
                            Hour18 = false,
                            Hour19 = false,
                            Hour20 = true,
                            Hour21 = true,
                            Hour22 = false,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 4,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Tuesday",
                            GroupId = 2,
                            Hour00 = true,
                            Hour01 = true,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = false,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = true,
                            Hour10 = true,
                            Hour11 = false,
                            Hour12 = false,
                            Hour13 = true,
                            Hour14 = true,
                            Hour15 = false,
                            Hour16 = false,
                            Hour17 = true,
                            Hour18 = true,
                            Hour19 = false,
                            Hour20 = false,
                            Hour21 = true,
                            Hour22 = true,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 5,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Wednesday",
                            GroupId = 1,
                            Hour00 = false,
                            Hour01 = false,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = true,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = false,
                            Hour10 = true,
                            Hour11 = true,
                            Hour12 = false,
                            Hour13 = false,
                            Hour14 = false,
                            Hour15 = false,
                            Hour16 = true,
                            Hour17 = true,
                            Hour18 = false,
                            Hour19 = false,
                            Hour20 = true,
                            Hour21 = true,
                            Hour22 = false,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 6,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Wednesday",
                            GroupId = 2,
                            Hour00 = true,
                            Hour01 = true,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = false,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = true,
                            Hour10 = true,
                            Hour11 = false,
                            Hour12 = false,
                            Hour13 = true,
                            Hour14 = true,
                            Hour15 = false,
                            Hour16 = false,
                            Hour17 = true,
                            Hour18 = true,
                            Hour19 = false,
                            Hour20 = false,
                            Hour21 = true,
                            Hour22 = true,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 7,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Thursday",
                            GroupId = 1,
                            Hour00 = false,
                            Hour01 = false,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = true,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = false,
                            Hour10 = true,
                            Hour11 = true,
                            Hour12 = false,
                            Hour13 = false,
                            Hour14 = false,
                            Hour15 = false,
                            Hour16 = true,
                            Hour17 = true,
                            Hour18 = false,
                            Hour19 = false,
                            Hour20 = true,
                            Hour21 = true,
                            Hour22 = false,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 8,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Thursday",
                            GroupId = 2,
                            Hour00 = true,
                            Hour01 = true,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = false,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = true,
                            Hour10 = true,
                            Hour11 = false,
                            Hour12 = false,
                            Hour13 = true,
                            Hour14 = true,
                            Hour15 = false,
                            Hour16 = false,
                            Hour17 = true,
                            Hour18 = true,
                            Hour19 = false,
                            Hour20 = false,
                            Hour21 = true,
                            Hour22 = true,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 9,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Friday",
                            GroupId = 1,
                            Hour00 = false,
                            Hour01 = false,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = true,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = false,
                            Hour10 = true,
                            Hour11 = true,
                            Hour12 = false,
                            Hour13 = false,
                            Hour14 = false,
                            Hour15 = false,
                            Hour16 = true,
                            Hour17 = true,
                            Hour18 = false,
                            Hour19 = false,
                            Hour20 = true,
                            Hour21 = true,
                            Hour22 = false,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 10,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Friday",
                            GroupId = 2,
                            Hour00 = true,
                            Hour01 = true,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = false,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = true,
                            Hour10 = true,
                            Hour11 = false,
                            Hour12 = false,
                            Hour13 = true,
                            Hour14 = true,
                            Hour15 = false,
                            Hour16 = false,
                            Hour17 = true,
                            Hour18 = true,
                            Hour19 = false,
                            Hour20 = false,
                            Hour21 = true,
                            Hour22 = true,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 11,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Saturday",
                            GroupId = 1,
                            Hour00 = false,
                            Hour01 = false,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = true,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = false,
                            Hour10 = true,
                            Hour11 = true,
                            Hour12 = false,
                            Hour13 = false,
                            Hour14 = false,
                            Hour15 = false,
                            Hour16 = true,
                            Hour17 = true,
                            Hour18 = false,
                            Hour19 = false,
                            Hour20 = true,
                            Hour21 = true,
                            Hour22 = false,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 12,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Saturday",
                            GroupId = 2,
                            Hour00 = true,
                            Hour01 = true,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = false,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = true,
                            Hour10 = true,
                            Hour11 = false,
                            Hour12 = false,
                            Hour13 = true,
                            Hour14 = true,
                            Hour15 = false,
                            Hour16 = false,
                            Hour17 = true,
                            Hour18 = true,
                            Hour19 = false,
                            Hour20 = false,
                            Hour21 = true,
                            Hour22 = true,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 13,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Sunday",
                            GroupId = 1,
                            Hour00 = false,
                            Hour01 = false,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = true,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = false,
                            Hour10 = true,
                            Hour11 = true,
                            Hour12 = false,
                            Hour13 = false,
                            Hour14 = false,
                            Hour15 = false,
                            Hour16 = true,
                            Hour17 = true,
                            Hour18 = false,
                            Hour19 = false,
                            Hour20 = true,
                            Hour21 = true,
                            Hour22 = false,
                            Hour23 = false
                        },
                        new
                        {
                            Id = 14,
                            CityId = 1,
                            Date = new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            DateName = "Sunday",
                            GroupId = 2,
                            Hour00 = true,
                            Hour01 = true,
                            Hour02 = false,
                            Hour03 = false,
                            Hour04 = false,
                            Hour05 = true,
                            Hour06 = true,
                            Hour07 = false,
                            Hour08 = false,
                            Hour09 = true,
                            Hour10 = true,
                            Hour11 = false,
                            Hour12 = false,
                            Hour13 = true,
                            Hour14 = true,
                            Hour15 = false,
                            Hour16 = false,
                            Hour17 = true,
                            Hour18 = true,
                            Hour19 = false,
                            Hour20 = false,
                            Hour21 = true,
                            Hour22 = true,
                            Hour23 = false
                        });
                });

            modelBuilder.Entity("Electricity.Api.Models.Zone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("ZoneKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Zones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            ZoneKey = 1
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            ZoneKey = 2
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            ZoneKey = 1
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            ZoneKey = 2
                        },
                        new
                        {
                            Id = 5,
                            CityId = 3,
                            ZoneKey = 1
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            ZoneKey = 2
                        },
                        new
                        {
                            Id = 7,
                            CityId = 4,
                            ZoneKey = 1
                        },
                        new
                        {
                            Id = 8,
                            CityId = 4,
                            ZoneKey = 2
                        },
                        new
                        {
                            Id = 9,
                            CityId = 5,
                            ZoneKey = 1
                        },
                        new
                        {
                            Id = 10,
                            CityId = 5,
                            ZoneKey = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
