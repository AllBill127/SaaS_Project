﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PSP.Data;

#nullable disable

namespace PSP.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221226221158_DiscountCode")]
    partial class DiscountCode
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

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

            modelBuilder.Entity("PSP.Models.CatalogueItem", b =>
                {
                    b.Property<Guid>("CatalogueItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<int>("LoyaltyPointsReward")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("Tax")
                        .HasColumnType("INTEGER");

                    b.HasKey("CatalogueItemId");

                    b.HasIndex("ClientId");

                    b.ToTable("CatalogueItem");
                });

            modelBuilder.Entity("PSP.Models.Client", b =>
                {
                    b.Property<Guid>("clientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("address")
                        .HasColumnType("TEXT");

                    b.Property<string>("currency")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("timezone")
                        .HasColumnType("TEXT");

                    b.HasKey("clientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("PSP.Models.CollectedLoyaltyReward", b =>
                {
                    b.Property<Guid>("orderId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("loyaltyRewardId")
                        .HasColumnType("TEXT");

                    b.HasKey("orderId", "loyaltyRewardId");

                    b.ToTable("CollectedLoyaltyReward");
                });

            modelBuilder.Entity("PSP.Models.DiscountCode", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Discount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Code", "ClientId");

                    b.HasIndex("ClientId");

                    b.ToTable("DiscountCode");
                });

            modelBuilder.Entity("PSP.Models.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeId");

                    b.HasIndex("LocationId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("PSP.Models.EmployeeCard", b =>
                {
                    b.Property<Guid>("EmployeeCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeCardId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LocationId");

                    b.ToTable("EmployeeCard");
                });

            modelBuilder.Entity("PSP.Models.EmployeeShift", b =>
                {
                    b.Property<Guid>("EmployeeShiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ShiftId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("WorkDay")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeShiftId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ShiftId");

                    b.ToTable("EmployeeShift");
                });

            modelBuilder.Entity("PSP.Models.Inventory", b =>
                {
                    b.Property<Guid>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Item")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("TEXT");

                    b.HasKey("ItemId");

                    b.HasIndex("LocationId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("PSP.Models.InventoryUsage", b =>
                {
                    b.Property<Guid>("InventoryUsageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("CatalogueItemId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("TEXT");

                    b.HasKey("InventoryUsageId");

                    b.HasIndex("CatalogueItemId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ItemId");

                    b.ToTable("InventoryUsage");
                });

            modelBuilder.Entity("PSP.Models.Location", b =>
                {
                    b.Property<Guid>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<double>("Tax")
                        .HasColumnType("REAL");

                    b.Property<string>("Timezone")
                        .HasColumnType("TEXT");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("PSP.Models.LoyaltyCard", b =>
                {
                    b.Property<Guid>("cardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("clientId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("customerId")
                        .HasColumnType("TEXT");

                    b.Property<int>("loyaltyPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("status")
                        .HasColumnType("INTEGER");

                    b.HasKey("cardId");

                    b.ToTable("LoyaltyCard");
                });

            modelBuilder.Entity("PSP.Models.Modifier", b =>
                {
                    b.Property<Guid>("ModifierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("CatalogueItemId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("TEXT");

                    b.Property<int>("LoyaltyPointsModifier")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PriceModifier")
                        .HasColumnType("INTEGER");

                    b.HasKey("ModifierId");

                    b.HasIndex("CatalogueItemId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ItemId");

                    b.ToTable("Modifier");
                });

            modelBuilder.Entity("PSP.Models.OrderedItem", b =>
                {
                    b.Property<Guid>("OrderedItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("CatalogueItemId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<double>("Tax")
                        .HasColumnType("REAL");

                    b.HasKey("OrderedItemId");

                    b.ToTable("OrderedItem");
                });

            modelBuilder.Entity("PSP.Models.OrderedItemModification", b =>
                {
                    b.Property<Guid>("OrderedItemId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ModifierId")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderedItemId", "ModifierId");

                    b.HasIndex("ModifierId");

                    b.ToTable("OrderedItemModification");
                });

            modelBuilder.Entity("PSP.Models.Payment", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("amount")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("clientId")
                        .HasColumnType("TEXT");

                    b.Property<string>("comment")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<int>("method")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("orderId")
                        .HasColumnType("TEXT");

                    b.Property<int>("status")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("PSP.Models.Permission", b =>
                {
                    b.Property<Guid>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PermissionTypeId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("PermissionId");

                    b.HasIndex("ClientId");

                    b.HasIndex("PermissionTypeId");

                    b.HasIndex("RoleId");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("PSP.Models.PermissionType", b =>
                {
                    b.Property<Guid>("PermissionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("PermissionTypeId");

                    b.ToTable("PermissionType");
                });

            modelBuilder.Entity("PSP.Models.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId");

                    b.HasIndex("ClientId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("PSP.Models.Shift", b =>
                {
                    b.Property<Guid>("ShiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("EndTimeTS")
                        .HasColumnType("TEXT")
                        .HasColumnName("EndTime");

                    b.Property<TimeSpan>("StartTimeTS")
                        .HasColumnType("TEXT")
                        .HasColumnName("StartTime");

                    b.HasKey("ShiftId");

                    b.ToTable("Shift");
                });

            modelBuilder.Entity("PSP.Models.Station", b =>
                {
                    b.Property<Guid>("stationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("employeeId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("locationId")
                        .HasColumnType("TEXT");

                    b.Property<int>("seats")
                        .HasColumnType("INTEGER");

                    b.Property<int>("status")
                        .HasColumnType("INTEGER");

                    b.HasKey("stationId");

                    b.ToTable("Station");
                });

            modelBuilder.Entity("PSP.Models.CatalogueItem", b =>
                {
                    b.HasOne("PSP.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("PSP.Models.DiscountCode", b =>
                {
                    b.HasOne("PSP.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("PSP.Models.Employee", b =>
                {
                    b.HasOne("PSP.Models.Location", "location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSP.Models.Role", "role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("location");

                    b.Navigation("role");
                });

            modelBuilder.Entity("PSP.Models.EmployeeCard", b =>
                {
                    b.HasOne("PSP.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSP.Models.Location", "location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("location");
                });

            modelBuilder.Entity("PSP.Models.EmployeeShift", b =>
                {
                    b.HasOne("PSP.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSP.Models.Shift", "shift")
                        .WithMany()
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("shift");
                });

            modelBuilder.Entity("PSP.Models.Inventory", b =>
                {
                    b.HasOne("PSP.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("PSP.Models.InventoryUsage", b =>
                {
                    b.HasOne("PSP.Models.CatalogueItem", "CatalogueItem")
                        .WithMany()
                        .HasForeignKey("CatalogueItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSP.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSP.Models.Inventory", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CatalogueItem");

                    b.Navigation("Client");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("PSP.Models.Modifier", b =>
                {
                    b.HasOne("PSP.Models.CatalogueItem", "CatalogueItem")
                        .WithMany()
                        .HasForeignKey("CatalogueItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSP.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSP.Models.Inventory", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CatalogueItem");

                    b.Navigation("Client");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("PSP.Models.OrderedItemModification", b =>
                {
                    b.HasOne("PSP.Models.Modifier", "Modifier")
                        .WithMany()
                        .HasForeignKey("ModifierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSP.Models.OrderedItem", "OrderedItem")
                        .WithMany()
                        .HasForeignKey("OrderedItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modifier");

                    b.Navigation("OrderedItem");
                });

            modelBuilder.Entity("PSP.Models.Permission", b =>
                {
                    b.HasOne("PSP.Models.Client", "client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSP.Models.PermissionType", "permissionType")
                        .WithMany()
                        .HasForeignKey("PermissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PSP.Models.Role", "role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");

                    b.Navigation("permissionType");

                    b.Navigation("role");
                });

            modelBuilder.Entity("PSP.Models.Role", b =>
                {
                    b.HasOne("PSP.Models.Client", "client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });
#pragma warning restore 612, 618
        }
    }
}
