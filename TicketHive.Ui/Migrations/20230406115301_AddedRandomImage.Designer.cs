﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketHive.Server.Data;

#nullable disable

namespace TicketHive.Ui.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230406115301_AddedRandomImage")]
    partial class AddedRandomImage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketHive.Server.Models.BookingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountOfTickets")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GuestCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TicketHive.Server.Models.EventModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GuestCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTime = new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventType = "Music festival",
                            GuestCapacity = 35000,
                            Image = "Image5.jpg",
                            Location = "Sölvesborg",
                            Name = "Sweden Rock",
                            TicketPrice = 600m
                        },
                        new
                        {
                            Id = 2,
                            DateTime = new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventType = "Music festival",
                            GuestCapacity = 125000,
                            Image = "Image7.jpg",
                            Location = "Indio, California",
                            Name = "Coachella Music Festival",
                            TicketPrice = 429.99m
                        },
                        new
                        {
                            Id = 3,
                            DateTime = new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventType = "Beer festival",
                            GuestCapacity = 6000,
                            Image = "Image6.jpg",
                            Location = "Munich, Germany",
                            Name = "Oktoberfest",
                            TicketPrice = 50m
                        },
                        new
                        {
                            Id = 4,
                            DateTime = new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventType = "Art festival",
                            GuestCapacity = 70000,
                            Image = "Image2.jpg",
                            Location = "Black Rock City, Nevada",
                            Name = "Burning Man",
                            TicketPrice = 475m
                        },
                        new
                        {
                            Id = 5,
                            DateTime = new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventType = "Entertainment convention",
                            GuestCapacity = 135000,
                            Image = "Image10.jpg",
                            Location = "San Diego, California",
                            Name = "San Diego Comic-Con",
                            TicketPrice = 150m
                        },
                        new
                        {
                            Id = 6,
                            DateTime = new DateTime(2026, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventType = "Sports event",
                            GuestCapacity = 2500,
                            Image = "Image6.jpg",
                            Location = "Beijing, China",
                            Name = "Winter Olympics",
                            TicketPrice = 250m
                        },
                        new
                        {
                            Id = 7,
                            DateTime = new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventType = "Film festival",
                            GuestCapacity = 40000,
                            Image = "Image10.jpg",
                            Location = "Cannes, France",
                            Name = "Cannes Film Festival",
                            TicketPrice = 50m
                        },
                        new
                        {
                            Id = 8,
                            DateTime = new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventType = "Carnival",
                            GuestCapacity = 1000000,
                            Image = "Image5.jpg",
                            Location = "New Orleans, Louisiana",
                            Name = "Mardi Gras",
                            TicketPrice = 300m
                        },
                        new
                        {
                            Id = 9,
                            DateTime = new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventType = "Technology convention",
                            GuestCapacity = 170000,
                            Image = "Image6.jpg",
                            Location = "Las Vegas, Nevada",
                            Name = "Consumer Electronics Show",
                            TicketPrice = 200m
                        },
                        new
                        {
                            Id = 10,
                            DateTime = new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventType = "Sports event",
                            GuestCapacity = 39000,
                            Image = "Image7.jpg",
                            Location = "London, United Kingdom",
                            Name = "Wimbledon Tennis Championships",
                            TicketPrice = 500m
                        },
                        new
                        {
                            Id = 11,
                            DateTime = new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventType = "Cultural event",
                            GuestCapacity = 2000000,
                            Image = "Image6.jpg",
                            Location = "Pamplona, Spain",
                            Name = "Running of the Bulls",
                            TicketPrice = 150m
                        },
                        new
                        {
                            Id = 12,
                            DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2024),
                            EventType = "Sports event",
                            GuestCapacity = 40000,
                            Image = "Image8.jpg",
                            Location = "Various cities",
                            Name = "World Series",
                            TicketPrice = 70000m
                        });
                });

            modelBuilder.Entity("TicketHive.Server.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EventModelId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventModelId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TicketHive.Server.Models.BookingModel", b =>
                {
                    b.HasOne("TicketHive.Server.Models.UserModel", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TicketHive.Server.Models.UserModel", b =>
                {
                    b.HasOne("TicketHive.Server.Models.EventModel", null)
                        .WithMany("Users")
                        .HasForeignKey("EventModelId");
                });

            modelBuilder.Entity("TicketHive.Server.Models.EventModel", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("TicketHive.Server.Models.UserModel", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
