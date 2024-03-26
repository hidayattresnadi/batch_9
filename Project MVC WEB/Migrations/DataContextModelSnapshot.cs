﻿// <auto-generated />
using Project_MVC_WEB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Project_MVC_WEB.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Project_MVC_WEB.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Electronics",
                            Description = "Electronic Items"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Clothes",
                            Description = "Dress Items"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Groceries",
                            Description = "Grocery Items"
                        });
                });

            modelBuilder.Entity("Project_MVC_WEB.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Laptop",
                            ProductName = "Laptop"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "Mobile",
                            ProductName = "Mobile"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Description = "Shirt",
                            ProductName = "Shirt"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Description = "Jeans",
                            ProductName = "Jeans"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            Description = "Rice",
                            ProductName = "Rice"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Description = "Wheat",
                            ProductName = "Wheat"
                        });
                });

            modelBuilder.Entity("Project_MVC_WEB.Models.Product", b =>
                {
                    b.HasOne("Project_MVC_WEB.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Project_MVC_WEB.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
