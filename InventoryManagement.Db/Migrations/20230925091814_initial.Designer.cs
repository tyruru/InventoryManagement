﻿// <auto-generated />
using InventoryManagement.Db.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InventoryManagement.Db.Migrations
{
    [DbContext(typeof(InventoryManagementDbContext))]
    [Migration("20230925091814_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InventoryManagement.Db.Data.Entities.InventoryItemEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<int>("InventoryItemId")
                        .HasColumnType("integer");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("ProductId");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("InventoryManagement.Db.Data.Entities.LocationEntity", b =>
                {
                    b.Property<string>("LocationName")
                        .HasColumnType("text");

                    b.Property<string>("LocationAddress")
                        .HasColumnType("text");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.HasKey("LocationName");

                    b.ToTable("Locatios");
                });

            modelBuilder.Entity("InventoryManagement.Db.Data.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Quantity"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("Quantity");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InventoryManagement.Db.Data.Entities.ProviderEntity", b =>
                {
                    b.Property<string>("SupplierPhone")
                        .HasColumnType("text");

                    b.Property<int>("SupplierId")
                        .HasColumnType("integer");

                    b.Property<string>("SupplierName")
                        .HasColumnType("text");

                    b.HasKey("SupplierPhone");

                    b.ToTable("Providers");
                });
#pragma warning restore 612, 618
        }
    }
}
