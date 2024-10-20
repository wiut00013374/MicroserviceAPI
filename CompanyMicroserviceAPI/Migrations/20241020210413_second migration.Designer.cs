﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanyMicroserviceAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241020210413_second migration")]
    partial class secondmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CompanyMicroserviceAPI.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Description = "Description 1",
                            Name = "Product 1",
                            Price = 10.99m,
                            Stock = 100
                        },
                        new
                        {
                            id = 2,
                            Description = "Description 2",
                            Name = "Product 2",
                            Price = 20.99m,
                            Stock = 150
                        },
                        new
                        {
                            id = 3,
                            Description = "Description 3",
                            Name = "Product 3",
                            Price = 30.99m,
                            Stock = 200
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
