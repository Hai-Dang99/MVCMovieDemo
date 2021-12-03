﻿// <auto-generated />
using System;
using MVCMovie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCMovie.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211203074839_Create_Table1")]
    partial class Create_Table1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("MVCMovie.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categois");
                });

            modelBuilder.Entity("MVCMovie.Models.DT", b =>
                {
                    b.Property<int>("DTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DTName")
                        .HasColumnType("TEXT");

                    b.Property<int>("LHLID")
                        .HasColumnType("INTEGER");

                    b.HasKey("DTID");

                    b.HasIndex("LHLID");

                    b.ToTable("DTs");
                });

            modelBuilder.Entity("MVCMovie.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("MVCMovie.Models.HD", b =>
                {
                    b.Property<string>("HDID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HDName")
                        .HasColumnType("TEXT");

                    b.HasKey("HDID");

                    b.ToTable("HDs");

                    b.HasDiscriminator<string>("Discriminator").HasValue("HD");
                });

            modelBuilder.Entity("MVCMovie.Models.LHD", b =>
                {
                    b.Property<int>("LHDID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LHDName")
                        .HasColumnType("TEXT");

                    b.HasKey("LHDID");

                    b.HasIndex("CategoryID");

                    b.ToTable("LHDs");
                });

            modelBuilder.Entity("MVCMovie.Models.LHL", b =>
                {
                    b.Property<int>("LHLID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LHLName")
                        .HasColumnType("TEXT");

                    b.HasKey("LHLID");

                    b.ToTable("LHLs");
                });

            modelBuilder.Entity("MVCMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MVCMovie.Models.Person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("MVCMovie.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("MVCMovie.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("MVCMovie.Models.NLN", b =>
                {
                    b.HasBaseType("MVCMovie.Models.HD");

                    b.Property<string>("NLNID")
                        .HasColumnType("TEXT");

                    b.Property<string>("University")
                        .HasColumnType("TEXT");

                    b.ToTable("HDs");

                    b.HasDiscriminator().HasValue("NLN");
                });

            modelBuilder.Entity("MVCMovie.Models.Young", b =>
                {
                    b.HasBaseType("MVCMovie.Models.Person");

                    b.Property<string>("University")
                        .HasColumnType("TEXT");

                    b.Property<string>("YoungID")
                        .HasColumnType("TEXT");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Young");
                });

            modelBuilder.Entity("MVCMovie.Models.DT", b =>
                {
                    b.HasOne("MVCMovie.Models.LHL", "LHL")
                        .WithMany("DTs")
                        .HasForeignKey("LHLID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LHL");
                });

            modelBuilder.Entity("MVCMovie.Models.LHD", b =>
                {
                    b.HasOne("MVCMovie.Models.Category", "Category")
                        .WithMany("LHDs")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MVCMovie.Models.Category", b =>
                {
                    b.Navigation("LHDs");
                });

            modelBuilder.Entity("MVCMovie.Models.LHL", b =>
                {
                    b.Navigation("DTs");
                });
#pragma warning restore 612, 618
        }
    }
}
