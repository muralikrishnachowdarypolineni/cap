﻿// <auto-generated />
using Capgemini.Net.Blazor.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Capgemini.Net.Blazor.Api.Migrations
{
    [DbContext(typeof(BlazorDbContext))]
    [Migration("20201011123801_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Capgemini.Net.Blazor.Api.Models.Category", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Capgemini.Net.Blazor.Api.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AverageRate")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<string>("CategoryFK")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int>("RateRangeFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryFK");

                    b.HasIndex("RateRangeFK");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Capgemini.Net.Blazor.Api.Models.ProductRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductFK")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductFK");

                    b.ToTable("ProductRates");
                });

            modelBuilder.Entity("Capgemini.Net.Blazor.Api.Models.RateRange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxRate")
                        .HasColumnType("int");

                    b.Property<int>("MinRate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RateRanges");
                });

            modelBuilder.Entity("Capgemini.Net.Blazor.Api.Models.Product", b =>
                {
                    b.HasOne("Capgemini.Net.Blazor.Api.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capgemini.Net.Blazor.Api.Models.RateRange", "RateRange")
                        .WithMany("Products")
                        .HasForeignKey("RateRangeFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Capgemini.Net.Blazor.Api.Models.ProductRate", b =>
                {
                    b.HasOne("Capgemini.Net.Blazor.Api.Models.Product", "Product")
                        .WithMany("ProductRates")
                        .HasForeignKey("ProductFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
