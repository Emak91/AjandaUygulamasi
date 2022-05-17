﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gorevYoneticisi.Entities;

namespace gorevYoneticisi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220516234337_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("gorevYoneticisi.Entities.Event", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("color")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("end")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("start")
                        .HasColumnType("datetime2");

                    b.Property<string>("textColor")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("tittle")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Events");
                });
#pragma warning restore 612, 618
        }
    }
}