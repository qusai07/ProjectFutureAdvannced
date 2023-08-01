﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectFutureAdvannced.Data;

#nullable disable

namespace ProjectFutureAdvannced.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectFutureAdvannced.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryImg = "sedan.png",
                            Name = 2
                        },
                        new
                        {
                            Id = 2,
                            CategoryImg = "plug.png",
                            Name = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryImg = "kitchen.png",
                            Name = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryImg = "baby-boy.png",
                            Name = 6
                        },
                        new
                        {
                            Id = 5,
                            CategoryImg = "cosmetics.png",
                            Name = 5
                        },
                        new
                        {
                            Id = 6,
                            CategoryImg = "fashion.png",
                            Name = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
