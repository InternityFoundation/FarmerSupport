﻿// <auto-generated />
using FarmerSupport.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FarmerSupport.Migrations
{
    [DbContext(typeof(FarmerDbContext))]
    partial class FarmerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FarmerSupport.Models.FarmerModel", b =>
                {
                    b.Property<int>("FarmerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ElectricalConducitvity");

                    b.Property<int>("Humidity");

                    b.Property<string>("Next3Months");

                    b.Property<string>("Past3Months");

                    b.Property<int>("Rainfall");

                    b.Property<int>("Sunlight");

                    b.Property<int>("Temperature");

                    b.HasKey("FarmerId");

                    b.ToTable("FarmerModel");
                });
#pragma warning restore 612, 618
        }
    }
}