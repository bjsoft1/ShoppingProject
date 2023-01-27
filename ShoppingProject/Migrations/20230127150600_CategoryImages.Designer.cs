﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingProject.Datbase;

#nullable disable

namespace ShoppingProject.Migrations
{
    [DbContext(typeof(DatabaseDesign))]
    [Migration("20230127150600_CategoryImages")]
    partial class CategoryImages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShoppingProject.Models.CategoriesImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Identity", "1, 1");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoriesImages", (string)null);
                });

            modelBuilder.Entity("ShoppingProject.Models.CategoriesModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifierUserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Identity", "1, 1");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("ModifierUserId");

                    b.ToTable("CategoriesModels", (string)null);
                });

            modelBuilder.Entity("ShoppingProject.Models.UserAccountModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifierUserId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Identity", "1, 1");

                    b.HasIndex("ModifierUserId");

                    b.ToTable("UserAccounts", (string)null);
                });

            modelBuilder.Entity("ShoppingProject.Models.CategoriesImages", b =>
                {
                    b.HasOne("ShoppingProject.Models.CategoriesModels", "CateogryAccount")
                        .WithMany("CategoriesImages")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CateogryAccount");
                });

            modelBuilder.Entity("ShoppingProject.Models.CategoriesModels", b =>
                {
                    b.HasOne("ShoppingProject.Models.UserAccountModels", "CreatorUserAccout")
                        .WithMany()
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ShoppingProject.Models.UserAccountModels", "ModifireUserAccout")
                        .WithMany()
                        .HasForeignKey("ModifierUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatorUserAccout");

                    b.Navigation("ModifireUserAccout");
                });

            modelBuilder.Entity("ShoppingProject.Models.UserAccountModels", b =>
                {
                    b.HasOne("ShoppingProject.Models.UserAccountModels", "ModifireUserAccout")
                        .WithMany()
                        .HasForeignKey("ModifierUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ModifireUserAccout");
                });

            modelBuilder.Entity("ShoppingProject.Models.CategoriesModels", b =>
                {
                    b.Navigation("CategoriesImages");
                });
#pragma warning restore 612, 618
        }
    }
}
