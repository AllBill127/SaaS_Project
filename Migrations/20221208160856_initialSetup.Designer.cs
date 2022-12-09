﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PSP.Data;

namespace PSP.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221208160856_initialSetup")]
    partial class initialSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("PSP.Models.Booking", b =>
                {
                    b.Property<Guid>("bookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("orderId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("time")
                        .HasColumnType("TEXT");

                    b.HasKey("bookingId");

                    b.ToTable("Booking");
                });
#pragma warning restore 612, 618
        }
    }
}
