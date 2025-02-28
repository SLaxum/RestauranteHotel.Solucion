﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestauranteHotel.Infrastructure.Data;

namespace RestauranteHotel.Infrastructure.Data.Migrations
{
    [DbContext(typeof(RestauranteHotelContext))]
    partial class RestauranteHotelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("RestauranteHotel.Domain.Entity.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("Decimal");

                    b.Property<decimal>("Existencia")
                        .HasColumnType("Decimal");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("Decimal");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("RestauranteHotel.Domain.Entity.ProductoCompuesto", b =>
                {
                    b.HasBaseType("RestauranteHotel.Domain.Entity.Producto");

                    b.ToTable("ProductoCompuesto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Costo = 3.0000m,
                            Existencia = 10.0m,
                            Nombre = "perro sencillo",
                            Precio = 5.000m
                        });
                });

            modelBuilder.Entity("RestauranteHotel.Domain.Entity.ProductoSimple", b =>
                {
                    b.HasBaseType("RestauranteHotel.Domain.Entity.Producto");

                    b.Property<int?>("ProductoCompuestoId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("ProductoCompuestoId");

                    b.ToTable("ProductoSimple");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Costo = 1.000m,
                            Existencia = 10.0m,
                            Nombre = "salchicha",
                            Precio = 0.0m,
                            ProductoCompuestoId = 1
                        },
                        new
                        {
                            Id = 3,
                            Costo = 1.000m,
                            Existencia = 10.0m,
                            Nombre = "pan de perro",
                            Precio = 0.0m,
                            ProductoCompuestoId = 1
                        },
                        new
                        {
                            Id = 4,
                            Costo = 1.000m,
                            Existencia = 10.0m,
                            Nombre = "lamina de queso",
                            Precio = 0.0m,
                            ProductoCompuestoId = 1
                        },
                        new
                        {
                            Id = 5,
                            Costo = 2.000m,
                            Existencia = 1.0m,
                            Nombre = "pan de perro extragrande",
                            Precio = 0.0m,
                            ProductoCompuestoId = 1
                        },
                        new
                        {
                            Id = 6,
                            Costo = 2.000m,
                            Existencia = 10.0m,
                            Nombre = "salchicha ranchera",
                            Precio = 0.0m
                        });
                });

            modelBuilder.Entity("RestauranteHotel.Domain.Entity.ProductoCompuesto", b =>
                {
                    b.HasOne("RestauranteHotel.Domain.Entity.Producto", null)
                        .WithOne()
                        .HasForeignKey("RestauranteHotel.Domain.Entity.ProductoCompuesto", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestauranteHotel.Domain.Entity.ProductoSimple", b =>
                {
                    b.HasOne("RestauranteHotel.Domain.Entity.Producto", null)
                        .WithOne()
                        .HasForeignKey("RestauranteHotel.Domain.Entity.ProductoSimple", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestauranteHotel.Domain.Entity.ProductoCompuesto", "ProductoCompuesto")
                        .WithMany("Productos")
                        .HasForeignKey("ProductoCompuestoId");

                    b.Navigation("ProductoCompuesto");
                });

            modelBuilder.Entity("RestauranteHotel.Domain.Entity.ProductoCompuesto", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
