﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210208165247_seedvalues")]
    partial class seedvalues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MyProperty");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "feven"
                        },
                        new
                        {
                            Id = 2,
                            Name = "feven1"
                        },
                        new
                        {
                            Id = 3,
                            Name = "feven2"
                        },
                        new
                        {
                            Id = 4,
                            Name = "feven3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
