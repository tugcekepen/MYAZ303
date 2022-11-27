﻿// <auto-generated />
using MVCProjem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCProjem.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCProjem.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Electronic Products",
                            Description = "to follow the warranty periods and invoices of your products"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "House Cleaning Products",
                            Description = ""
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Car Cleaning Products",
                            Description = ""
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Fresh Food Products",
                            Description = "fruits and vegetables"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Frozen Food Products",
                            Description = "with or without package"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Drink Products",
                            Description = "coffee, tea, water etc."
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Personal Care Products",
                            Description = "oral care, skin care, hair care etc."
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Cosmetics Products",
                            Description = ""
                        },
                        new
                        {
                            Id = 9,
                            CategoryName = "Other Cosmetics Products",
                            Description = "nail polish, deodorant, perfume etc."
                        },
                        new
                        {
                            Id = 10,
                            CategoryName = "Pet Products",
                            Description = "nutrition, medicine etc."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
