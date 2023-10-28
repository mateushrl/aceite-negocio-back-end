﻿// <auto-generated />
using System;
using AceiteNegocio.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AceiteNegocio.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AceiteNegocio.Models.Lancamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Avulso")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("Lancamento", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
