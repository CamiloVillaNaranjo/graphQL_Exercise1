﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizzeria.Data;

namespace Pizzeria.Data.Migrations
{
    [DbContext(typeof(PizzaDbContext))]
    partial class PizzaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pizzeria.Data.Entities.DetalleOrdenes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion1")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Direccion2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoOrden")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<string>("MovilNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.ToTable("DetalleOrdenes");
                });

            modelBuilder.Entity("Pizzeria.Data.Entities.DetallePizzas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdDetalleOrdenes")
                        .HasColumnType("int");

                    b.Property<int>("Ingredientes")
                        .HasColumnType("int")
                        .HasMaxLength(200);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int>("Tamano")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDetalleOrdenes");

                    b.ToTable("DetallePizzas");
                });

            modelBuilder.Entity("Pizzeria.Data.Entities.DetallePizzas", b =>
                {
                    b.HasOne("Pizzeria.Data.Entities.DetalleOrdenes", "OrderDetails")
                        .WithMany("PizzaDetails")
                        .HasForeignKey("IdDetalleOrdenes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
