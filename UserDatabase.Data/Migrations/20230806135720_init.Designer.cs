﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserDatabase.Data;

#nullable disable

namespace UserDatabase.Data.Migrations
{
    [DbContext(typeof(UserDatabaseDbContext))]
    [Migration("20230806135720_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UserDatabase.Core.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdressString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isPrimary")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("UserDatabase.Core.Models.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("UserDatabase.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEdited")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpouseId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UserDatabase.Core.Models.Address", b =>
                {
                    b.HasOne("UserDatabase.Core.Models.User", null)
                        .WithMany("Addresses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("UserDatabase.Core.Models.PhoneNumber", b =>
                {
                    b.HasOne("UserDatabase.Core.Models.User", null)
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("UserDatabase.Core.Models.User", b =>
                {
                    b.HasOne("UserDatabase.Core.Models.User", "Spouse")
                        .WithMany()
                        .HasForeignKey("SpouseId");

                    b.Navigation("Spouse");
                });

            modelBuilder.Entity("UserDatabase.Core.Models.User", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("PhoneNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
