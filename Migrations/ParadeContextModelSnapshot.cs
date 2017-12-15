using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SantaTracker.Contexts;

namespace SantaTracker.Migrations
{
    [DbContext(typeof(ParadeContext))]
    partial class ParadeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SantaTracker.Models.Coordinates", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("acc");

                    b.Property<string>("cos");

                    b.Property<string>("lat");

                    b.Property<string>("lon");

                    b.Property<string>("tid");

                    b.Property<DateTime>("time");

                    b.Property<string>("vel");

                    b.HasKey("ID");

                    b.ToTable("Coordinate");
                });
        }
    }
}
