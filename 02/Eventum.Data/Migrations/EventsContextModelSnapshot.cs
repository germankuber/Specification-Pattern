﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Eventum.Data.Migrations
{
    [DbContext(typeof(EventsContext))]
    partial class EventsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Events.Data.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Closed");

                    b.Property<DateTime>("EventDate");

                    b.Property<int>("Guests");

                    b.Property<bool>("Premium");

                    b.Property<string>("Title");

                    b.Property<bool>("Validated");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new { Id = 1, Closed = false, EventDate = new DateTime(2018, 8, 29, 20, 23, 51, 239, DateTimeKind.Local), Guests = 6, Premium = false, Title = "Meetup.Js Event", Validated = false },
                        new { Id = 2, Closed = false, EventDate = new DateTime(2018, 8, 23, 20, 23, 51, 242, DateTimeKind.Local), Guests = 30, Premium = false, Title = "Specification Pattern en C#", Validated = false },
                        new { Id = 3, Closed = false, EventDate = new DateTime(2018, 8, 23, 20, 23, 51, 242, DateTimeKind.Local), Guests = 25, Premium = true, Title = "Azure and Docker", Validated = false }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
