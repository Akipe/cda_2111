﻿// <auto-generated />
using System;
using ApiCereals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiCereals.Migrations
{
    [DbContext(typeof(CerealDbContext))]
    [Migration("20220324090500_correction_01")]
    partial class correction_01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiCereals.Models.Cereal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<int?>("Carbo")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Fiber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int?>("Potass")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Protein")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("Sodium")
                        .HasColumnType("int");

                    b.Property<int?>("Sugars")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Vitamins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cereals");
                });
#pragma warning restore 612, 618
        }
    }
}
