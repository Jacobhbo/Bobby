﻿// <auto-generated />
using System;
using DatingProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatingProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240612082717_ChangeGenderToString")]
    partial class ChangeGenderToString
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DatingProject.Data.Account", b =>
                {
                    b.Property<int>("AccountsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountsId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountsId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountsId = 1,
                            CreatedDate = new DateTime(2024, 6, 12, 8, 27, 16, 319, DateTimeKind.Utc).AddTicks(2008),
                            Email = "jaco@gmail.com",
                            FirstName = "Jacob",
                            LastName = "Hbo",
                            Password = "bob123",
                            UserName = "bob"
                        });
                });

            modelBuilder.Entity("DatingProject.Data.Profile", b =>
                {
                    b.Property<int>("ProfilesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfilesId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("ProfilesId");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            ProfilesId = 1,
                            BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Male",
                            Height = 180,
                            NickName = "JohnDoe",
                            Weight = 75
                        },
                        new
                        {
                            ProfilesId = 2,
                            BirthDate = new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Gender = "Female",
                            Height = 165,
                            NickName = "JaneDoe",
                            Weight = 60
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
